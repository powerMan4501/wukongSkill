namespace System.Diagnostics;

internal class ThreadInfo
{
	public int threadId;

	public int processId;

	public int basePriority;

	public int currentPriority;

	public IntPtr startAddress;

	public ThreadState threadState;

	public ThreadWaitReason threadWaitReason;
}
