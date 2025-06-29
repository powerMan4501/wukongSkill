using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraAnimNotifies;

[UClass(Flags = (ClassFlags)810627232uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect", "NiagaraAnimNotifies", UnrealModuleType.EnginePlugin)]
public class UAnimNotifyState_TimedNiagaraEffect : UAnimNotifyState
{
	private static bool GetSpawnedEffect_IsValid;

	private static IntPtr GetSpawnedEffect_FunctionAddress;

	private static int GetSpawnedEffect_ParamsSize;

	private static bool GetSpawnedEffect_MeshComp_IsValid;

	private static FFieldAddress GetSpawnedEffect_MeshComp_PropertyAddress;

	private static int GetSpawnedEffect_MeshComp_Offset;

	private static bool GetSpawnedEffect_ReturnValue_IsValid;

	private static FFieldAddress GetSpawnedEffect_ReturnValue_PropertyAddress;

	private static int GetSpawnedEffect_ReturnValue_Offset;

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect:GetSpawnedEffect")]
	public unsafe UFXSystemComponent GetSpawnedEffect(UMeshComponent MeshComp)
	{
		CheckDestroyed();
		if (!GetSpawnedEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect:GetSpawnedEffect");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpawnedEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpawnedEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshComponent>.ToNative(IntPtr.Add(intPtr, GetSpawnedEffect_MeshComp_Offset), 0, GetSpawnedEffect_MeshComp_PropertyAddress.Address, MeshComp);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpawnedEffect_FunctionAddress, intPtr, GetSpawnedEffect_ParamsSize);
		return UObjectMarshaler<UFXSystemComponent>.FromNative(IntPtr.Add(intPtr, GetSpawnedEffect_ReturnValue_Offset), 0, GetSpawnedEffect_ReturnValue_PropertyAddress.Address);
	}

	static UAnimNotifyState_TimedNiagaraEffect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_TimedNiagaraEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_TimedNiagaraEffect));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect");
		GetSpawnedEffect_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSpawnedEffect");
		GetSpawnedEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpawnedEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpawnedEffect_MeshComp_PropertyAddress, GetSpawnedEffect_FunctionAddress, "MeshComp");
		GetSpawnedEffect_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(GetSpawnedEffect_FunctionAddress, "MeshComp");
		GetSpawnedEffect_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpawnedEffect_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpawnedEffect_ReturnValue_PropertyAddress, GetSpawnedEffect_FunctionAddress, "ReturnValue");
		GetSpawnedEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpawnedEffect_FunctionAddress, "ReturnValue");
		GetSpawnedEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpawnedEffect_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSpawnedEffect_IsValid = GetSpawnedEffect_FunctionAddress != IntPtr.Zero && GetSpawnedEffect_MeshComp_IsValid && GetSpawnedEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffect:GetSpawnedEffect", GetSpawnedEffect_IsValid);
	}
}
