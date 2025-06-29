using System;

namespace b1.Profile;

public class GSE_ProfileScope : IDisposable
{
	private IntPtr CycleCounter;

	public GSE_ProfileScope(int StatID)
	{
		CycleCounter = ProfilerFuncLib.BeginSampleCycleCounterWithStatID(StatID);
	}

	public void Dispose()
	{
		ProfilerFuncLib.EndSampleCycleCounter(CycleCounter);
	}
}
