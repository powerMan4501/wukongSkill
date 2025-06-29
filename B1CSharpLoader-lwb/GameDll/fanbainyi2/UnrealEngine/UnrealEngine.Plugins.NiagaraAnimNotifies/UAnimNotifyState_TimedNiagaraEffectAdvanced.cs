using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraAnimNotifies;

[UClass(Flags = (ClassFlags)810627232uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffectAdvanced", "NiagaraAnimNotifies", UnrealModuleType.EnginePlugin)]
public class UAnimNotifyState_TimedNiagaraEffectAdvanced : UAnimNotifyState_TimedNiagaraEffect
{
	private static bool GetNotifyProgress_IsValid;

	private static IntPtr GetNotifyProgress_FunctionAddress;

	private static int GetNotifyProgress_ParamsSize;

	private static bool GetNotifyProgress_MeshComp_IsValid;

	private static FFieldAddress GetNotifyProgress_MeshComp_PropertyAddress;

	private static int GetNotifyProgress_MeshComp_Offset;

	private static bool GetNotifyProgress_ReturnValue_IsValid;

	private static FFieldAddress GetNotifyProgress_ReturnValue_PropertyAddress;

	private static int GetNotifyProgress_ReturnValue_Offset;

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffectAdvanced:GetNotifyProgress")]
	public unsafe float GetNotifyProgress(UMeshComponent MeshComp)
	{
		CheckDestroyed();
		if (!GetNotifyProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffectAdvanced:GetNotifyProgress");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNotifyProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNotifyProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshComponent>.ToNative(IntPtr.Add(intPtr, GetNotifyProgress_MeshComp_Offset), 0, GetNotifyProgress_MeshComp_PropertyAddress.Address, MeshComp);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNotifyProgress_FunctionAddress, intPtr, GetNotifyProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNotifyProgress_ReturnValue_Offset), 0, GetNotifyProgress_ReturnValue_PropertyAddress.Address);
	}

	static UAnimNotifyState_TimedNiagaraEffectAdvanced()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_TimedNiagaraEffectAdvanced)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_TimedNiagaraEffectAdvanced));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffectAdvanced");
		GetNotifyProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNotifyProgress");
		GetNotifyProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotifyProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyProgress_MeshComp_PropertyAddress, GetNotifyProgress_FunctionAddress, "MeshComp");
		GetNotifyProgress_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyProgress_FunctionAddress, "MeshComp");
		GetNotifyProgress_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyProgress_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyProgress_ReturnValue_PropertyAddress, GetNotifyProgress_FunctionAddress, "ReturnValue");
		GetNotifyProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyProgress_FunctionAddress, "ReturnValue");
		GetNotifyProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyProgress_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNotifyProgress_IsValid = GetNotifyProgress_FunctionAddress != IntPtr.Zero && GetNotifyProgress_MeshComp_IsValid && GetNotifyProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraAnimNotifies.AnimNotifyState_TimedNiagaraEffectAdvanced:GetNotifyProgress", GetNotifyProgress_IsValid);
	}
}
