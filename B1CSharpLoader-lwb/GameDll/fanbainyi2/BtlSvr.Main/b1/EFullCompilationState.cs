namespace b1;

public enum EFullCompilationState
{
	NotBegin,
	WaitUserConfirm,
	Compiling,
	WaitingAnimationStop,
	SaveCacheFile,
	ClearMemory,
	WaitClearMemoryFinish,
	WaitUserCheckDiskSize,
	Finish
}
