using b1.CppExport;

namespace b1;

public static class ActorFuncLib
{
	public static GSE_ActorFuncs.Del_CalculateScreenPercentageFromController CalculateScreenPercentageFromController;

	public static GSE_ActorFuncs.Del_SetLocalScreenPercentageIfLocalController SetLocalScreenPercentageIfLocalController;

	public static GSE_ActorFuncs.Del_CalculateMaxDistanceFactor CalculateMaxDistanceFactor;

	public static GSE_ActorFuncs.Del_SetActorLocationSimple SetActorLocationSimple;

	public static GSE_ActorFuncs.Del_SetActorRotationSimple SetActorRotationSimple;

	public static GSE_ActorFuncs.Del_SetActorLocationAndRotationSimple SetActorLocationAndRotationSimple;

	public static GSE_ActorFuncs.Del_SetActorTransformSimple SetActorTransformSimple;

	public static GSE_ActorFuncs.Del_GetActorLocationSimple GetActorLocationSimple;

	public static GSE_ActorFuncs.Del_GetActorRotationSimple GetActorRotationSimple;

	public static GSE_ActorFuncs.Del_GetActorTransformSimple GetActorTransformSimple;

	public static GSE_ActorFuncs.Del_GetActorForwardVector GetActorForwardVector;

	public static GSE_ActorFuncs.Del_GetVelocity GetVelocity;

	public static GSE_ActorFuncs.Del_GetAttachParentActor GetAttachParentActor;

	public static GSE_ActorFuncs.Del_GetWorldTransformFast GetWorldTransformFast;

	public static GSE_ActorFuncs.Del_GetActorHasAuthority GetActorHasAuthority;

	public static GSE_ActorFuncs.Del_GetUROResult GetUROResult;

	public static GSE_ActorFuncs.Del_ToggleActorTickEnabled ToggleActorTickEnabled;

	public static GSE_ActorFuncs.Del_DisableSKMeshEndPhysicsTick DisableSKMeshEndPhysicsTick;

	public static GSE_ActorFuncs.Del_SetActorSKMeshesUpdateRateOptimizations SetActorSKMeshesUpdateRateOptimizations;

	public static GSE_ActorFuncs.Del_CheckActorWasRecentlyRendered CheckActorWasRecentlyRendered;

	static ActorFuncLib()
	{
		new GSE_ActorFuncs();
	}
}
