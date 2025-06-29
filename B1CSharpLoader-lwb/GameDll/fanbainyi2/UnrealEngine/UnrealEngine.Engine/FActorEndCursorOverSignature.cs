using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorEndCursorOverSignature__DelegateSignature")]
public class FActorEndCursorOverSignature : FMulticastDelegate<FActorEndCursorOverSignature.Signature>
{
	public delegate void Signature(AActor TouchedActor);

	private static bool ActorEndCursorOverSignature__DelegateSignature_IsValid;

	private static IntPtr ActorEndCursorOverSignature__DelegateSignature_FunctionAddress;

	private static int ActorEndCursorOverSignature__DelegateSignature_ParamsSize;

	private static bool ActorEndCursorOverSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorEndCursorOverSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorEndCursorOverSignature__DelegateSignature_TouchedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorEndCursorOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorEndCursorOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorEndCursorOverSignature__DelegateSignature");
		ActorEndCursorOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorEndCursorOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorEndCursorOverSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorEndCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorEndCursorOverSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorEndCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorEndCursorOverSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorEndCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		ActorEndCursorOverSignature__DelegateSignature_IsValid = ActorEndCursorOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorEndCursorOverSignature__DelegateSignature_TouchedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorEndCursorOverSignature__DelegateSignature", ActorEndCursorOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor TouchedActor)
	{
		if (!ActorEndCursorOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorEndCursorOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorEndCursorOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorEndCursorOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorEndCursorOverSignature__DelegateSignature_TouchedActor_Offset), 0, ActorEndCursorOverSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			ProcessDelegate(intPtr);
		}
	}
}
