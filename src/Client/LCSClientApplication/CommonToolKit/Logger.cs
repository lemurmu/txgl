using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LcsClient
{
    public static class Logger
    {
        private static log4net.ILog m_Log;

        static Logger()
        {
            string ConfigFile = @"Config/log4net.config";
            log4net.Config.XmlConfigurator.Configure(new FileInfo(ConfigFile));
            m_Log = log4net.LogManager.GetLogger("NSALogger");
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Debug(object message)
        {
            m_Log.Debug(message);
        }
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public static void Debug(object message, Exception exception)
        {
            m_Log.Debug(message, exception);
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public static void DebugFormat(string format, object arg0)
        {
            m_Log.DebugFormat(format, arg0);
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void DebugFormat(string format, params object[] args)
        {
            m_Log.DebugFormat(format, args);
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            m_Log.DebugFormat(provider, format, args);
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public static void DebugFormat(string format, object arg0, object arg1)
        {
            m_Log.DebugFormat(format, arg0, arg1);
        }

        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public static void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            m_Log.DebugFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Error(object message)
        {
            m_Log.Error(message);
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public static void Error(object message, Exception exception)
        {
            m_Log.Error(message, exception);
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public static void ErrorFormat(string format, object arg0)
        {
            m_Log.ErrorFormat(format, arg0);
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void ErrorFormat(string format, params object[] args)
        {
            m_Log.ErrorFormat(format, args);
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            m_Log.ErrorFormat(provider, format, args);
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public static void ErrorFormat(string format, object arg0, object arg1)
        {
            m_Log.ErrorFormat(format, arg0, arg1);
        }

        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public static void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            m_Log.ErrorFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Fatal(object message)
        {
            m_Log.Fatal(message);
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public static void Fatal(object message, Exception exception)
        {
            m_Log.Fatal(message, exception);
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public static void FatalFormat(string format, object arg0)
        {
            m_Log.FatalFormat(format, arg0);
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void FatalFormat(string format, params object[] args)
        {
            m_Log.FatalFormat(format, args);
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            m_Log.FatalFormat(provider, format, args);
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public static void FatalFormat(string format, object arg0, object arg1)
        {
            m_Log.FatalFormat(format, arg0, arg1);
        }

        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public static void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            m_Log.FatalFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Info(object message)
        {
            m_Log.Info(message);
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public static void Info(object message, Exception exception)
        {
            m_Log.Info(message, exception);
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public static void InfoFormat(string format, object arg0)
        {
            m_Log.InfoFormat(format, arg0);
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void InfoFormat(string format, params object[] args)
        {
            m_Log.InfoFormat(format, args);
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            m_Log.InfoFormat(provider, format, args);
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public static void InfoFormat(string format, object arg0, object arg1)
        {
            m_Log.InfoFormat(format, arg0, arg1);
        }

        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public static void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            m_Log.InfoFormat(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void Warn(object message)
        {
            m_Log.Warn(message);
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public static void Warn(object message, Exception exception)
        {
            m_Log.Warn(message, exception);
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public static void WarnFormat(string format, object arg0)
        {
            m_Log.WarnFormat(format, arg0);
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void WarnFormat(string format, params object[] args)
        {
            m_Log.WarnFormat(format, args);
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            m_Log.WarnFormat(provider, format, args);
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public static void WarnFormat(string format, object arg0, object arg1)
        {
            m_Log.WarnFormat(format, arg0, arg1);
        }

        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public static void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            m_Log.WarnFormat(format, arg0, arg1, arg2);
        }
    }
}
