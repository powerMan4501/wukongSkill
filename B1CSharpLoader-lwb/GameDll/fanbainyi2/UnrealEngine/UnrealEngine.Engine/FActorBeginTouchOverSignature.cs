using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature")]
public class FActorBeginTouchOverSignature : FMulticastDelegate<FActorBeginTouchOverSignature.Signature>
{
	public delegate void Signature(ETouchIndex FingerIndex, AActor TouchedActor);

	private static bool ActorBeginTouchOverSignature__DelegateSignature_IsValid;

	private static IntPtr ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress;

	private static int ActorBeginTouchOverSignature__DelegateSignature_ParamsSize;

	private static bool ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_IsValid;

	private static FFieldAddress ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress;

	private static int ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_Offset;

	private static bool ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorBeginTouchOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature");
		ActorBeginTouchOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress, ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex");
		ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		ActorBeginTouchOverSignature__DelegateSignature_IsValid = ActorBeginTouchOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_IsValid && ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature", ActorBeginTouchOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ETouchIndex FingerIndex, AActor TouchedActor)
	{
		if (!ActorBeginTouchOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorBeginTouchOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorBeginTouchOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorBeginTouchOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_Offset), 0, ActorBeginTouchOverSignature__DelegateSignature_FingerIndex_PropertyAddress.Address, FingerIndex);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_Offset), 0, ActorBeginTouchOverSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			ProcessDelegate(intPtr);
		}
	}
}
