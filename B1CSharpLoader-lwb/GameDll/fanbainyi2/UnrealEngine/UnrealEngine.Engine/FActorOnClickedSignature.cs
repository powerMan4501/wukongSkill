using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorOnClickedSignature__DelegateSignature")]
public class FActorOnClickedSignature : FMulticastDelegate<FActorOnClickedSignature.Signature>
{
	public delegate void Signature(AActor TouchedActor, FKey ButtonPressed);

	private static bool ActorOnClickedSignature__DelegateSignature_IsValid;

	private static IntPtr ActorOnClickedSignature__DelegateSignature_FunctionAddress;

	private static int ActorOnClickedSignature__DelegateSignature_ParamsSize;

	private static bool ActorOnClickedSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorOnClickedSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorOnClickedSignature__DelegateSignature_TouchedActor_Offset;

	private static bool ActorOnClickedSignature__DelegateSignature_ButtonPressed_IsValid;

	private static FFieldAddress ActorOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress;

	private static int ActorOnClickedSignature__DelegateSignature_ButtonPressed_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorOnClickedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorOnClickedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorOnClickedSignature__DelegateSignature");
		ActorOnClickedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorOnClickedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorOnClickedSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorOnClickedSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnClickedSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnClickedSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnClickedSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnClickedSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress, ActorOnClickedSignature__DelegateSignature_FunctionAddress, "ButtonPressed");
		ActorOnClickedSignature__DelegateSignature_ButtonPressed_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnClickedSignature__DelegateSignature_FunctionAddress, "ButtonPressed");
		ActorOnClickedSignature__DelegateSignature_ButtonPressed_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnClickedSignature__DelegateSignature_FunctionAddress, "ButtonPressed", Classes.FStructProperty);
		ActorOnClickedSignature__DelegateSignature_IsValid = ActorOnClickedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorOnClickedSignature__DelegateSignature_TouchedActor_IsValid && ActorOnClickedSignature__DelegateSignature_ButtonPressed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorOnClickedSignature__DelegateSignature", ActorOnClickedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor TouchedActor, FKey ButtonPressed)
	{
		if (!ActorOnClickedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorOnClickedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorOnClickedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorOnClickedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorOnClickedSignature__DelegateSignature_TouchedActor_Offset), 0, ActorOnClickedSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			NativeReflection.InitializeValue_InContainer(ActorOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress.Address, intPtr);
			FKey.ToNative(IntPtr.Add(intPtr, ActorOnClickedSignature__DelegateSignature_ButtonPressed_Offset), 0, ActorOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress.Address, ButtonPressed);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(ActorOnClickedSignature__DelegateSignature_ButtonPressed_PropertyAddress.Address, intPtr);
		}
	}
}
