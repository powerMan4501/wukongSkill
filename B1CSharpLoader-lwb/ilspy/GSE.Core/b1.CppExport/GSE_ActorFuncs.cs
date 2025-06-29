using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_ActorFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate double Del_CalculateScreenPercentageFromController(IntPtr Actor, IntPtr Controller);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetLocalScreenPercentageIfLocalController(IntPtr Actor, IntPtr Controller, float ScreenPercentage, out float OutScreenPercentage);

	[MonoNativeFunctionWrapper]
	public delegate float Del_CalculateMaxDistanceFactor(IntPtr Actor);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetActorLocationSimple(IntPtr Actor, FVector Pos, bool bSweep, int iTeleportType);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetActorRotationSimple(IntPtr Actor, FRotator Rot, int iTeleportType);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetActorLocationAndRotationSimple(IntPtr Actor, FVector Pos, FRotator Rot, bool bSweep, int iTeleportType);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetActorTransformSimple(IntPtr Actor, FTransform Trans, bool bSweep, int iTeleportType);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetActorLocationSimple(IntPtr Actor, out FVector OutPos);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetActorRotationSimple(IntPtr Actor, out FRotator OutRot);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetActorTransformSimple(IntPtr Actor, out FTransform OutTrans);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetActorForwardVector(IntPtr Actor, out FVector OutDir);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetVelocity(IntPtr Actor, out FVector OutVelocity);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetAttachParentActor(IntPtr Actor, out IntPtr AttachParentActor);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetWorldTransformFast(IntPtr SceneComp, out FTransform Trans);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetActorHasAuthority(IntPtr Actor, out bool OutHasAuthority);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GetUROResult(IntPtr OwnerActor, out float OutAccumulatedDeltaTime);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ToggleActorTickEnabled(IntPtr OwnerActor, bool bEnable, bool ToggleActorTick = true, bool ToggleMoveComp = true, bool ToggleAIComp = true, bool ToggleSKMeshComp = true, bool ToggleAkComp = true, bool ToggleINCLUDE_CHILD_ACTOR = true);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DisableSKMeshEndPhysicsTick(IntPtr OwnerActor, bool bIncludeChildActor = true);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetActorSKMeshesUpdateRateOptimizations(IntPtr OwnerActor, bool bEnable);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_CheckActorWasRecentlyRendered(IntPtr OwnerActor);

	static GSE_ActorFuncs()
	{
		Type typeFromHandle = typeof(ActorFuncLib);
		Dictionary<string, FIntPtr> actorFuncAsMap = UGSE_CppExport.GetActorFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (actorFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
