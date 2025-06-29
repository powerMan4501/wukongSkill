namespace System.Diagnostics;

[Serializable]
internal enum LoggingLevels
{
	TraceLevel0 = 0,
	TraceLevel1 = 1,
	TraceLevel2 = 2,
	TraceLevel3 = 3,
	TraceLevel4 = 4,
	StatusLevel0 = 20,
	StatusLevel1 = 21,
	StatusLevel2 = 22,
	StatusLevel3 = 23,
	StatusLevel4 = 24,
	WarningLevel = 40,
	ErrorLevel = 50,
	PanicLevel = 100
}
