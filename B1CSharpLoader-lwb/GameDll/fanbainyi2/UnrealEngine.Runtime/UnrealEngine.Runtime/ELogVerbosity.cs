namespace UnrealEngine.Runtime;

public enum ELogVerbosity : byte
{
	NoLogging = 0,
	Fatal = 1,
	Error = 2,
	Warning = 3,
	Display = 4,
	Log = 5,
	Verbose = 6,
	VeryVerbose = 7,
	All = 7,
	NumVerbosity = 8,
	VerbosityMask = 15,
	SetColor = 64,
	BreakOnLog = 128
}
