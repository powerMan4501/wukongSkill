using b1.CppExport;

namespace b1;

public static class ProfilerFuncLib
{
	public static GSE_NativeProfilerFuncs.Del_CreateStatID CreateStatID;

	public static GSE_NativeProfilerFuncs.Del_CreateStatIDInSlateGroup CreateStatIDInSlateGroup;

	public static GSE_NativeProfilerFuncs.Del_CreateStatIDInGSCustomGroup CreateStatIDInGSCustomGroup;

	public static GSE_NativeProfilerFuncs.Del_BeginSampleWithUObject BeginSampleWithUObject;

	public static GSE_NativeProfilerFuncs.Del_BeginSampleWithStatID BeginSampleWithStatID;

	public static GSE_NativeProfilerFuncs.Del_EndSample EndSample;

	public static GSE_NativeProfilerFuncs.Del_BeginSampleCycleCounterWithStatID BeginSampleCycleCounterWithStatID;

	public static GSE_NativeProfilerFuncs.Del_EndSampleCycleCounter EndSampleCycleCounter;

	static ProfilerFuncLib()
	{
		new GSE_NativeProfilerFuncs();
	}
}
