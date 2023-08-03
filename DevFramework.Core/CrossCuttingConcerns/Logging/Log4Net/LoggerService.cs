﻿using log4net;
using NHibernate.UserTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net
{
    public class LoggerService
    {
        private log4net.ILog _log;
        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool IsInfoEnabled
        {
            get { return _log.IsInfoEnabled; }
        }
        public bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }
        public bool IsWarnEnabled
        {
            get { return _log.IsWarnEnabled; }
        }
        public bool IsFatalEnabled
        {
            get { return _log.IsFatalEnabled; }
        }
        public bool IsErrorEnabled
        {
            get { return _log.IsErrorEnabled; }
        }

        public void Info(object LogMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Info(LogMessage);
            }
        }
        public void Debug(object LogMessage)
        {
            if (IsDebugEnabled)
            {
                _log.Debug(LogMessage);
            }
        }
        public void Fatal(object LogMessage)
        {
            if (IsFatalEnabled)
            {
                _log.Fatal(LogMessage);
            }
        }
        public void Error(object LogMessage)
        {
            if (IsErrorEnabled)
            {
                _log.Error(LogMessage);
            }
        }
        public void Warn(object LogMessage)
        {
            if (IsWarnEnabled)
            {
                _log.Warn(LogMessage);
            }
        }
    }
}
