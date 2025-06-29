namespace System.Diagnostics;

[Serializable]
internal delegate void LogSwitchLevelHandler(LogSwitch ls, LoggingLevels newLevel);
