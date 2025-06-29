using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature")]
public class FActorOnInputTouchBeginSignature : FMulticastDelegate<FActorOnInputTouchBeginSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, AActor TouchedActor);

	private static bool ActorOnInputTouchBeginSignature__DelegateSignature_IsValid;

	private static IntPtr ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress;

	private static int ActorOnInputTouchBeginSignature__DelegateSignature_ParamsSize;

	private static bool ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorOnInputTouchBeginSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature");
		ActorOnInputTouchBeginSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_PropertyAddress, ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		ActorOnInputTouchBeginSignature__DelegateSignature_IsValid = ActorOnInputTouchBeginSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_IsValid && ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature", ActorOnInputTouchBeginSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, AActor TouchedActor)
	{
		if (!ActorOnInputTouchBeginSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorOnInputTouchBeginSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorOnInputTouchBeginSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorOnInputTouchBeginSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_Offset), 0, ActorOnInputTouchBeginSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_Offset), 0, ActorOnInputTouchBeginSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			ProcessDelegate(intPtr);
		}
	}
}
