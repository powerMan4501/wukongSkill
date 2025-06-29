using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature")]
public class FActorBeginCursorOverSignature : FMulticastDelegate<FActorBeginCursorOverSignature.Signature>
{
	public delegate void Signature(AActor TouchedActor);

	private static bool ActorBeginCursorOverSignature__DelegateSignature_IsValid;

	private static IntPtr ActorBeginCursorOverSignature__DelegateSignature_FunctionAddress;

	private static int ActorBeginCursorOverSignature__DelegateSignature_ParamsSize;

	private static bool ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_IsValid;

	private static FFieldAddress ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_PropertyAddress;

	private static int ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorBeginCursorOverSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorBeginCursorOverSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature");
		ActorBeginCursorOverSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorBeginCursorOverSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_PropertyAddress, ActorBeginCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorBeginCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedActor");
		ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorBeginCursorOverSignature__DelegateSignature_FunctionAddress, "TouchedActor", Classes.FObjectProperty);
		ActorBeginCursorOverSignature__DelegateSignature_IsValid = ActorBeginCursorOverSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature", ActorBeginCursorOverSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor TouchedActor)
	{
		if (!ActorBeginCursorOverSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorBeginCursorOverSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorBeginCursorOverSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorBeginCursorOverSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_Offset), 0, ActorBeginCursorOverSignature__DelegateSignature_TouchedActor_PropertyAddress.Address, TouchedActor);
			ProcessDelegate(intPtr);
		}
	}
}
