using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorOnReleasedSignature__DelegateSignature")]
public class FActorOnReleasedSignature : FMulticastDelegate<FActorOnReleasedSignature.Signature>
{
	public delegate void Signature(AActor TouchedActor, FKey ButtonReleased);

	private static bool ActorOnReleasedSignature__DelegateSignature_IsValid;

	private static IntPtr ActorOnReleasedSignature__DelegateSignature_FunctionAddress;

	private static int ActorOnReleasedSignature__DelegateSignature_ParamsSize;

	private static bool ActorOnReleasedSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorOnReleasedSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorOnReleasedSignature__DelegateSignature_TouchedActor_Offset;

	private static bool ActorOnReleasedSignature__DelegateSignature_ButtonReleased_IsValid;

	private static FFieldAddress ActorOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress;

	private static int ActorOnReleasedSignature__DelegateSignature_ButtonReleased_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorOnReleasedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorOnReleasedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorOnReleasedSignature__DelegateSignature");
		ActorOnReleasedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorOnReleasedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorOnReleasedSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorOnReleasedSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnReleasedSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnReleasedSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnReleasedSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnReleasedSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress, ActorOnReleasedSignature__DelegateSignature_FunctionAddress, "ButtonReleased");
		ActorOnReleasedSignature__DelegateSignature_ButtonReleased_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnReleasedSignature__DelegateSignature_FunctionAddress, "ButtonReleased");
		ActorOnReleasedSignature__DelegateSignature_ButtonReleased_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnReleasedSignature__DelegateSignature_FunctionAddress, "ButtonReleased", Classes.FStructProperty);
		ActorOnReleasedSignature__DelegateSignature_IsValid = ActorOnReleasedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorOnReleasedSignature__DelegateSignature_TouchedActor_IsValid && ActorOnReleasedSignature__DelegateSignature_ButtonReleased_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorOnReleasedSignature__DelegateSignature", ActorOnReleasedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor TouchedActor, FKey ButtonReleased)
	{
		if (!ActorOnReleasedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorOnReleasedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorOnReleasedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorOnReleasedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorOnReleasedSignature__DelegateSignature_TouchedActor_Offset), 0, ActorOnReleasedSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			NativeReflection.InitializeValue_InContainer(ActorOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, ActorOnReleasedSignature__DelegateSignature_ButtonReleased_Offset), 0, ActorOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress.Address, ButtonReleased);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ActorOnReleasedSignature__DelegateSignature_ButtonReleased_PropertyAddress.Address, intPtr);
		}
	}
}
