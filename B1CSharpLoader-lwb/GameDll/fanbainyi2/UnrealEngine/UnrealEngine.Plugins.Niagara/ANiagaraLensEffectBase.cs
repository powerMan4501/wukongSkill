using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraLensEffectBase", "Niagara", UnrealModuleType.EnginePlugin)]
public class ANiagaraLensEffectBase : ANiagaraActor, ICameraLensEffectInterface, IInterface
{
	private static bool GetPrimaryParticleComponent_IsValid;

	private IntPtr GetPrimaryParticleComponent_InstanceFunctionAddress;

	private static IntPtr GetPrimaryParticleComponent_FunctionAddress;

	private static int GetPrimaryParticleComponent_ParamsSize;

	private static bool GetPrimaryParticleComponent_ReturnValue_IsValid;

	private static FFieldAddress GetPrimaryParticleComponent_ReturnValue_PropertyAddress;

	private static int GetPrimaryParticleComponent_ReturnValue_Offset;

	private static bool GetParticleComponents_IsValid;

	private IntPtr GetParticleComponents_InstanceFunctionAddress;

	private static IntPtr GetParticleComponents_FunctionAddress;

	private static int GetParticleComponents_ParamsSize;

	private static bool GetParticleComponents_ReturnValue_IsValid;

	private static FFieldAddress GetParticleComponents_ReturnValue_PropertyAddress;

	private static int GetParticleComponents_ReturnValue_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterface:GetPrimaryParticleComponent")]
	public unsafe UFXSystemComponent GetPrimaryParticleComponent()
	{
		CheckDestroyed();
		if (!GetPrimaryParticleComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraLensEffectInterface:GetPrimaryParticleComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrimaryParticleComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrimaryParticleComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPrimaryParticleComponent_FunctionAddress, intPtr, GetPrimaryParticleComponent_ParamsSize);
		return UObjectMarshaler<UFXSystemComponent>.FromNative(IntPtr.Add(intPtr, GetPrimaryParticleComponent_ReturnValue_Offset), 0, GetPrimaryParticleComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterface:GetParticleComponents")]
	public unsafe List<UFXSystemComponent> GetParticleComponents()
	{
		CheckDestroyed();
		if (!GetParticleComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraLensEffectInterface:GetParticleComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParticleComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParticleComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParticleComponents_FunctionAddress, intPtr, GetParticleComponents_ParamsSize);
		List<UFXSystemComponent> result = new TArrayCopyMarshaler<UFXSystemComponent>(1, GetParticleComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UFXSystemComponent, UObjectMarshaler<UFXSystemComponent>>.FromNative, CachedMarshalingDelegates<UFXSystemComponent, UObjectMarshaler<UFXSystemComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetParticleComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParticleComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static ANiagaraLensEffectBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ANiagaraLensEffectBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ANiagaraLensEffectBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraLensEffectBase");
		GetPrimaryParticleComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPrimaryParticleComponent");
		GetPrimaryParticleComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrimaryParticleComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrimaryParticleComponent_ReturnValue_PropertyAddress, GetPrimaryParticleComponent_FunctionAddress, "ReturnValue");
		GetPrimaryParticleComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimaryParticleComponent_FunctionAddress, "ReturnValue");
		GetPrimaryParticleComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimaryParticleComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPrimaryParticleComponent_IsValid = GetPrimaryParticleComponent_FunctionAddress != IntPtr.Zero && GetPrimaryParticleComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraLensEffectInterface:GetPrimaryParticleComponent", GetPrimaryParticleComponent_IsValid);
		GetParticleComponents_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParticleComponents");
		GetParticleComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParticleComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParticleComponents_ReturnValue_PropertyAddress, GetParticleComponents_FunctionAddress, "ReturnValue");
		GetParticleComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParticleComponents_FunctionAddress, "ReturnValue");
		GetParticleComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParticleComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParticleComponents_IsValid = GetParticleComponents_FunctionAddress != IntPtr.Zero && GetParticleComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraLensEffectInterface:GetParticleComponents", GetParticleComponents_IsValid);
	}
}
