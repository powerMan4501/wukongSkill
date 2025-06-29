namespace System.Diagnostics;

internal class ProcessData
{
	public int ProcessId;

	public long StartupTime;

	public ProcessData(int pid, long startTime)
	{
		ProcessId = pid;
		StartupTime = startTime;
	}
}
