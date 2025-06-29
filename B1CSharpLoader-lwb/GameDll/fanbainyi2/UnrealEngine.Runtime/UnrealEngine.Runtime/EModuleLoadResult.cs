namespace UnrealEngine.Runtime;

public enum EModuleLoadResult
{
	Success,
	FileNotFound,
	FileIncompatible,
	CouldNotBeLoadedByOS,
	FailedToInitialize
}
