using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature")]
public class FActorOnInputTouchEndSignature : FMulticastDelegate<FActorOnInputTouchEndSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, AActor TouchedActor);

	private static bool ActorOnInputTouchEndSignature__DelegateSignature_IsValid;

	private static IntPtr ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress;

	private static int ActorOnInputTouchEndSignature__DelegateSignature_ParamsSize;

	private static bool ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorOnInputTouchEndSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature");
		ActorOnInputTouchEndSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_PropertyAddress, ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		ActorOnInputTouchEndSignature__DelegateSignature_IsValid = ActorOnInputTouchEndSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_IsValid && ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature", ActorOnInputTouchEndSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, AActor TouchedActor)
	{
		if (!ActorOnInputTouchEndSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorOnInputTouchEndSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorOnInputTouchEndSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_Offset), 0, ActorOnInputTouchEndSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_Offset), 0, ActorOnInputTouchEndSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			ProcessDelegate(intPtr);
		}
	}
}
