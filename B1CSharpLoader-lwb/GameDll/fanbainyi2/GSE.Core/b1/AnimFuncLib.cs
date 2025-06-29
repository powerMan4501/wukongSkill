using b1.CppExport;

namespace b1;

public static class AnimFuncLib
{
	public static GSE_AnimFuncs.Del_ABPStateMachineGetGlobalWeight ABPStateMachineGetGlobalWeight;

	public static GSE_AnimFuncs.Del_GetActiveMontageInstanceID GetActiveMontageInstanceID;

	public static GSE_AnimFuncs.Del_CalcSlotMontageLocalWeight CalcSlotMontageLocalWeight;

	public static GSE_AnimFuncs.Del_GetCurveValueFromAnimInstance GetCurveValueFromAnimInstance;

	public static GSE_AnimFuncs.Del_IsMontageInstancePlaying IsMontageInstancePlaying;

	static AnimFuncLib()
	{
		new GSE_AnimFuncs();
	}
}
