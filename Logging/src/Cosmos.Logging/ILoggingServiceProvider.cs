﻿using System;
using Cosmos.Logging.Events;

namespace Cosmos.Logging {
    public interface ILoggingServiceProvider {
        ILogger GetLogger(LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger(string name, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger(LogEventLevel minLevel, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger(string name, LogEventLevel minLevel, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger(Type type, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger(Type type, string name, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger(Type type, LogEventLevel minLevel, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger(Type type, string name, LogEventLevel level, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger<T>(LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger<T>(string name, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger<T>(LogEventLevel minLevel, LogEventSendMode mode = LogEventSendMode.Customize);
        ILogger GetLogger<T>(string name, LogEventLevel minLevel, LogEventSendMode mode = LogEventSendMode.Customize);

    }
}