using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorEndTouchOverSignature__DelegateSignature")]
public class FActorEndTouchOverSignature : FMulticastDelegate<FActorEndTouchOverSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, AActor TouchedActor);

	private static bool ActorEndTouchOverSignature__DelegateSignature_IsValid;

	private static IntPtr ActorEndTouchOverSignature__DelegateSignature_FunctionAddress;

	private static int ActorEndTouchOverSignature__DelegateSignature_ParamsSize;

	private static bool ActorEndTouchOverSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ActorEndTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ActorEndTouchOverSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ActorEndTouchOverSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorEndTouchOverSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorEndTouchOverSignature__DelegateSignature_TouchedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorEndTouchOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorEndTouchOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorEndTouchOverSignature__DelegateSignature");
		ActorEndTouchOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorEndTouchOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorEndTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress, ActorEndTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorEndTouchOverSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ActorEndTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorEndTouchOverSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorEndTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorEndTouchOverSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorEndTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorEndTouchOverSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorEndTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorEndTouchOverSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorEndTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		ActorEndTouchOverSignature__DelegateSignature_IsValid = ActorEndTouchOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorEndTouchOverSignature__DelegateSignature_FingerIndex_IsValid && ActorEndTouchOverSignature__DelegateSignature_TouchedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorEndTouchOverSignature__DelegateSignature", ActorEndTouchOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, AActor TouchedActor)
	{
		if (!ActorEndTouchOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorEndTouchOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorEndTouchOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorEndTouchOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ActorEndTouchOverSignature__DelegateSignature_FingerIndex_Offset), 0, ActorEndTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorEndTouchOverSignature__DelegateSignature_TouchedActor_Offset), 0, ActorEndTouchOverSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			ProcessDelegate(intPtr);
		}
	}
}
