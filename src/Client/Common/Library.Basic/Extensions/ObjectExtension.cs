﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Reflection;
using System.Collections;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Library.Basic
{
    public static class ObjectExtension
    {

        private static ConcurrentDictionary<Type, FieldInfo[]> _FieldMap;

        static ObjectExtension()
		{
			_FieldMap = new ConcurrentDictionary<Type, FieldInfo[]>();
		}

        public static string ToStringSafe(this object @this)
        {
            return @this == null ? "" : @this.ToString();
        }

        public static object To(this Object @this, Type type)
        {
            if (@this != null)
            {
                Type targetType = type;

                if (@this.GetType() == targetType)
                {
                    return @this;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                {
                    if (converter.CanConvertTo(targetType))
                    {
                        return converter.ConvertTo(@this, targetType);
                    }
                }

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                {
                    if (converter.CanConvertFrom(@this.GetType()))
                    {
                        return converter.ConvertFrom(@this);
                    }
                }

                if (@this == DBNull.Value)
                {
                    return null;
                }
            }

            return @this;
        }

        public static T To<T>(this Object @this)
        {
            if (@this != null)
            {
                Type targetType = typeof(T);

                if (@this.GetType() == targetType)
                {
                    return (T)@this;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                {
                    if (converter.CanConvertTo(targetType))
                    {
                        return (T)converter.ConvertTo(@this, targetType);
                    }
                }

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                {
                    if (converter.CanConvertFrom(@this.GetType()))
                    {
                        return (T)converter.ConvertFrom(@this);
                    }
                }

                if (@this == DBNull.Value)
                {
                    return (T)(object)null;
                }
            }

            return (T)@this;
        }

        public static T ToOrDefault<T>(this Object @this, Func<object, T> defaultValueFactory)
        {
            try
            {
                if (@this != null)
                {
                    Type targetType = typeof(T);

                    if (@this.GetType() == targetType)
                    {
                        return (T)@this;
                    }

                    TypeConverter converter = TypeDescriptor.GetConverter(@this);
                    if (converter != null)
                    {
                        if (converter.CanConvertTo(targetType))
                        {
                            return (T)converter.ConvertTo(@this, targetType);
                        }
                    }

                    converter = TypeDescriptor.GetConverter(targetType);
                    if (converter != null)
                    {
                        if (converter.CanConvertFrom(@this.GetType()))
                        {
                            return (T)converter.ConvertFrom(@this);
                        }
                    }

                    if (@this == DBNull.Value)
                    {
                        return (T)(object)null;
                    }
                }

                return (T)@this;
            }
            catch (Exception)
            {
                return defaultValueFactory(@this);
            }
        }

        public static T ToOrDefault<T>(this Object @this)
        {
            return @this.ToOrDefault(x => default(T));
        }

        public static T ToOrDefault<T>(this Object @this, T defaultValue)
        {
            return @this.ToOrDefault(x => defaultValue);
        }

        public static object DeepCopy(this object obj, bool preferICloneable = false)
        {
            // Improved from: http://www.codeproject.com/Articles/38270/Deep-copy-of-objects-in-C

            if (obj == null)
                return null;

            if (preferICloneable)
            {
                // ICloneable -- If object implements ICloneable, respect that interface
                var cloneable = obj as ICloneable;
                if (cloneable != null)
                {
                    return cloneable.Clone();
                }
            }

            // String
            var stringObj = obj as string;
            if (stringObj != null)
            {
                return string.Copy(stringObj);
            }


            Type type = obj.GetType();
            if (type.AssemblyQualifiedName != null
                && !type.IsArray
                && type.AssemblyQualifiedName.Contains("[]"))
            {
                type = Type.GetType(type.AssemblyQualifiedName.Replace("[]", string.Empty));
                if (type == null)
                    throw new NotSupportedException("Can't find type to copy.");
            }

            // Array
            if (type.IsArray)
            {
                var array = obj as Array;
                var elementType = Type.GetType(type.AssemblyQualifiedName.Replace("[]", string.Empty));
                var newObject = Array.CreateInstance(elementType, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    var item = array.GetValue(i);
                    var newValue = item.DeepCopy(preferICloneable);

                    newObject.SetValue(newValue, i);
                }
                return Convert.ChangeType(newObject, obj.GetType());
            }

            // Anonymous type
            if (type.IsGenericType
                && (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic
                && type.Name.Contains("AnonymousType")
                && Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)
                && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$")))
            {
                var fields = GetFieldsFromType(type);
                object[] values = new object[fields.Length];
                for (int i = 0; i < fields.Length; i++)
                {
                    var originalValue = fields[i].GetValue(obj);
                    values[i] = originalValue.DeepCopy(preferICloneable);
                }

                var newObject = Activator.CreateInstance(type, values);
                return newObject;
            }


            // Base type & structures
            if (type.IsValueType)
            {
                var newObject = Activator.CreateInstance(type);
                var fields = GetFieldsFromType(type);
                foreach (var field in fields)
                {
                    var originalValue = field.GetValue(obj);
                    if (originalValue == null)
                        continue;
                    field.SetValue(newObject, originalValue);
                }
                return newObject;
            }




            // IList
            var list = obj as IList;
            if (list != null)
            {
                var newObject = Activator.CreateInstance(type);
                var newList = (IList)newObject;
                foreach (var item in list)
                {
                    newList.Add(item.DeepCopy(preferICloneable));
                }
                return newList;
            }


            if (type.IsGenericType)
            {
                var genericTypeDef = type.GetGenericTypeDefinition();
                MethodInfo addMethod = null;
                IEnumerable enumerable = null;
                if (genericTypeDef == typeof(Queue))
                {
                    addMethod = type.GetMethod("Enqueue");
                }
                else if (genericTypeDef == typeof(Queue<>) || genericTypeDef == typeof(ConcurrentQueue<>))
                {
                    addMethod = type.GetMethod("Enqueue", new[] { type.GetGenericArguments()[0] });
                }
                else if (genericTypeDef == typeof(Stack))
                {
                    addMethod = type.GetMethod("Push");
                    var reversedItems = new Stack(((Stack)obj).Count);
                    foreach (var item in (IEnumerable)obj)
                        reversedItems.Push(item);
                    enumerable = reversedItems;
                }
                else if (genericTypeDef == typeof(Stack<>) || genericTypeDef == typeof(ConcurrentStack<>))
                {
                    addMethod = type.GetMethod("Push", new[] { type.GetGenericArguments()[0] });
                    var reversedItems = new Stack();
                    foreach (var item in (IEnumerable)obj)
                        reversedItems.Push(item);
                    enumerable = reversedItems;
                }
                else if (genericTypeDef == typeof(LinkedList<>))
                {
                    addMethod = type.GetMethod("AddLast", new[] { type.GetGenericArguments()[0] });
                }
                else
                {
                    foreach (var typeInterface in type.GetInterfaces())
                    {
                        if (!typeInterface.IsGenericType)
                            continue;

                        var genericInterfaceTypeDef = typeInterface.GetGenericTypeDefinition();

                        // ISet<>
                        if (genericInterfaceTypeDef == typeof(ISet<>))
                        {
                            addMethod = type.GetMethod("Add", new[] { type.GetGenericArguments()[0] });
                            break;
                        }
                    }
                }

                if (addMethod != null)
                {
                    var newObject = Activator.CreateInstance(type);
                    if (enumerable == null)
                        enumerable = (IEnumerable)obj;

                    foreach (var item in enumerable)
                    {
                        var itemCopy = item.DeepCopy(preferICloneable);
                        addMethod.Invoke(newObject, BindingFlags.InvokeMethod, null, new[] { itemCopy }, null);
                    }
                    return newObject;
                }

                if (genericTypeDef == typeof(Tuple<>)
                || genericTypeDef == typeof(Tuple<,>)
                || genericTypeDef == typeof(Tuple<,,>)
                || genericTypeDef == typeof(Tuple<,,,>)
                || genericTypeDef == typeof(Tuple<,,,,>)
                || genericTypeDef == typeof(Tuple<,,,,,>)
                || genericTypeDef == typeof(Tuple<,,,,,,>)
                || genericTypeDef == typeof(Tuple<,,,,,,,>)
                || genericTypeDef == typeof(Tuple<,,,,,,,>))
                {
                    // Special case Tuple
                    var fields = GetFieldsFromType(type);
                    object[] values = new object[fields.Length];
                    for (int i = 0; i < fields.Length; i++)
                    {
                        var originalValue = fields[i].GetValue(obj);
                        values[i] = originalValue.DeepCopy(preferICloneable);
                    }
                    return Activator.CreateInstance(type, values);

                }

            }

            // IDictionary
            var dictionary = obj as IDictionary;
            if (dictionary != null)
            {
                var newObject = (IDictionary)Activator.CreateInstance(type);
                foreach (var key in dictionary.Keys)
                {
                    var keyCopy = key.DeepCopy(preferICloneable);
                    var valueCopy = dictionary[key].DeepCopy(preferICloneable);
                    newObject[keyCopy] = valueCopy;
                }
                return newObject;
            }

            // BitArray
            if (type == typeof(BitArray))
            {
                var bitArray = obj as BitArray;
                var newObject = new BitArray(bitArray);
                return newObject;
            }

            // Other classes
            if (type.IsClass)
            {

                if (type.GetConstructor(Type.EmptyTypes) == null)
                {
                    // No default constructor for this type
                    return null;
                }

                var newObject = Activator.CreateInstance(type);
                foreach (var field in GetFieldsFromType(type))
                {
                    var originalValue = field.GetValue(obj);
                    if (originalValue == null)
                        continue;
                    var newValue = originalValue.DeepCopy(preferICloneable);
                    field.SetValue(newObject, newValue);
                }
                return newObject;
            }

            // ICloneable -- If object implements ICloneable, respect that interface
            var cloneable2 = obj as ICloneable;
            if (cloneable2 != null)
            {
                return cloneable2.Clone();
            }

            return null;

        }

        private static FieldInfo[] GetFieldsFromType(Type type)
        {
            FieldInfo[] fields = null;
            if (_FieldMap.TryGetValue(type, out fields))
                return fields;

            fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            _FieldMap[type] = fields;
            return fields;
        }
    }
}
