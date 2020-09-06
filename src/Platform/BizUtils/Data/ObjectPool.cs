using System;
using System.Collections.Concurrent;

namespace BizUtils.Data
{
    public class ObjectPool<T> : IDisposable
    {
        private ConcurrentBag<T> _objects;
        private Func<T> _objectGenerator;

        public ObjectPool(Func<T> objectGenerator)
        {
            if (objectGenerator == null) throw new ArgumentNullException("objectGenerator");
            _objects = new ConcurrentBag<T>();
            _objectGenerator = objectGenerator;
        }

        //~ObjectPool()
        //{
        //    if (typeof(T).GetInterface("IDisposable") != null)
        //    {
        //        T o;
        //        while (_objects.TryTake(out o))
        //        {
        //            (o as IDisposable).Dispose();
        //        }
        //    }
        //}

        public T GetObject()
        {
            T item;
            if (!_objects.TryTake(out item))
            {
                if (_objects.Count < 200)
                {
                    item = _objectGenerator();
                }
                else
                {
                    while (!_objects.TryTake(out item))
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
                //DC.DCLogger.LogTrace("Taked {0}, pool items:{1}", item.GetHashCode(), _objects.Count);
            }
            else
            {
                if (item is ICheckable && !(item as ICheckable).Check())
                {
                    if (item is IDisposable)
                    { 
                        (item as IDisposable).Dispose();
                        //DC.DCLogger.LogTrace("Disposed {0}, pool items:{1}", item.GetHashCode(), _objects.Count);
                    }
                    item = _objectGenerator();
                    //DC.DCLogger.LogTrace("Created {0}, pool items:{1}", item.GetHashCode(), _objects.Count);
                }
            }
            //DC.DCLogger.LogTrace("GetObject {0}, pool items:{1}", item.GetHashCode(), _objects.Count);
            return item;
        }

        public void PutObject(T item)
        {
            _objects.Add(item);
            //DC.DCLogger.LogTrace("PubObject {0}, pool items:{1}", item.GetHashCode(), _objects.Count);
        }

        public void Dispose()
        {
            if (_objects != null && typeof(T).IsSubclassOf(typeof(IDisposable)))
            {
                foreach (T item in _objects)
                {
                    (item as IDisposable).Dispose();
                }
            }
        }
    }
}
