using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
internal delegate void LogMessageEventHandler(LoggingLevels level, LogSwitch category, string message, StackTrace location);
