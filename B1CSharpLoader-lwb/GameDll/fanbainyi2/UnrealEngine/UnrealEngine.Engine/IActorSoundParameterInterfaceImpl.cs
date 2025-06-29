using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public sealed class IActorSoundParameterInterfaceImpl : IInterfaceImpl, IActorSoundParameterInterface, IInterface
{
	private static bool GetActorSoundParams_IsValid;

	private IntPtr GetActorSoundParams_InstanceFunctionAddress;

	private static IntPtr GetActorSoundParams_FunctionAddress;

	private static int GetActorSoundParams_ParamsSize;

	private static bool GetActorSoundParams_Params_IsValid;

	private static FFieldAddress GetActorSoundParams_Params_PropertyAddress;

	private static int GetActorSoundParams_Params_Offset;

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Engine.ActorSoundParameterInterface:GetActorSoundParams")]
	public unsafe void GetActorSoundParams(out List<FAudioParameter> Params)
	{
		CheckDestroyed();
		if (!GetActorSoundParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorSoundParameterInterface:GetActorSoundParams");
			Params = null;
			return;
		}
		if (GetActorSoundParams_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetActorSoundParams_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorSoundParams");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorSoundParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorSoundParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorSoundParams_InstanceFunctionAddress, intPtr, GetActorSoundParams_ParamsSize);
		Params = new TArrayCopyMarshaler<FAudioParameter>(1, GetActorSoundParams_Params_PropertyAddress, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.FromNative, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.ToNative).FromNative(IntPtr.Add(intPtr, GetActorSoundParams_Params_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorSoundParams_Params_PropertyAddress.Address, intPtr);
	}

	public override void ResetInterface()
	{
		GetActorSoundParams_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IActorSoundParameterInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IActorSoundParameterInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IActorSoundParameterInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.ActorSoundParameterInterface");
		GetActorSoundParams_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorSoundParams");
		GetActorSoundParams_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorSoundParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorSoundParams_Params_PropertyAddress, GetActorSoundParams_FunctionAddress, "Params");
		GetActorSoundParams_Params_Offset = NativeReflectionCached.GetPropertyOffset(GetActorSoundParams_FunctionAddress, "Params");
		GetActorSoundParams_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorSoundParams_FunctionAddress, "Params", Classes.FArrayProperty);
		GetActorSoundParams_IsValid = GetActorSoundParams_FunctionAddress != IntPtr.Zero && GetActorSoundParams_Params_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorSoundParameterInterface:GetActorSoundParams", GetActorSoundParams_IsValid);
	}
}
