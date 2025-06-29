using b1.CppExport;

namespace b1;

public static class AIFuncLib
{
	public static GSE_NativeAIFuncs.Del_SetAISenseConfig SetAISenseConfig;

	public static GSE_NativeAIFuncs.Del_SinglePerceptionSetEnable SinglePerceptionSetEnable;

	public static GSE_NativeAIFuncs.Del_SetPerceptionForgetAll SetPerceptionForgetAll;

	public static GSE_NativeAIFuncs.Del_ListenerForgetsActor ListenerForgetsActor;

	public static GSE_NativeAIFuncs.Del_SetAIBTPause SetAIBTPause;

	public static GSE_NativeAIFuncs.Del_SetAIBTStop SetAIBTStop;

	public static GSE_NativeAIFuncs.Del_AISetBT AISetBT;

	static AIFuncLib()
	{
		new GSE_NativeAIFuncs();
	}
}
