using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Basic
{
    public static class DelegateExtensions
    {
        public static void FireEvent(this EventHandler source)
        {
            if (source != null)
            {
                source(null, null);
            }
        }

        public static void FireEvent(this EventHandler source, object sender)
        {
            if (source != null)
            {
                source(sender, null);
            }
        }

        public static void FireEvent(this EventHandler source, object sender, EventArgs arg)
        {
            if (source != null)
            {
                source(sender, arg);
            }
        }

        public static void FireEvent<TEventArgs>(this EventHandler<TEventArgs> source, object sender) where TEventArgs : EventArgs
        {
            if (source != null)
            {
                source(sender, Activator.CreateInstance<TEventArgs>());
            }
        }

        public static void FireEvent<TEventArgs>(this EventHandler<TEventArgs> source, object sender, TEventArgs e) where TEventArgs : EventArgs
        {
            if (source != null)
            {
                source(sender, e);
            }
        }

        public static void FireEventAsyn(this EventHandler source, object sender, EventArgs arg)
        {
            if (source == null) return;
            Delegate[] dels = source.GetInvocationList();
            foreach (var item in dels)
            {
                var eventHandler = item as EventHandler;
                eventHandler.BeginInvoke(sender, arg, null, null);
            }
        }
    }
}
