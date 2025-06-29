using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorEndPlaySignature__DelegateSignature")]
public class FActorEndPlaySignature : FMulticastDelegate<FActorEndPlaySignature.Signature>
{
	public delegate void Signature(AActor Actor, EEndPlayReason EndPlayReason);

	private static bool ActorEndPlaySignature__DelegateSignature_IsValid;

	private static IntPtr ActorEndPlaySignature__DelegateSignature_FunctionAddress;

	private static int ActorEndPlaySignature__DelegateSignature_ParamsSize;

	private static bool ActorEndPlaySignature__DelegateSignature_Actor_IsValid;

	private static FFieldAddress ActorEndPlaySignature__DelegateSignature_Actor_PropertyAddress;

	private static int ActorEndPlaySignature__DelegateSignature_Actor_Offset;

	private static bool ActorEndPlaySignature__DelegateSignature_EndPlayReason_IsValid;

	private static FFieldAddress ActorEndPlaySignature__DelegateSignature_EndPlayReason_PropertyAddress;

	private static int ActorEndPlaySignature__DelegateSignature_EndPlayReason_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorEndPlaySignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorEndPlaySignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorEndPlaySignature__DelegateSignature");
		ActorEndPlaySignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorEndPlaySignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorEndPlaySignature__DelegateSignature_Actor_PropertyAddress, ActorEndPlaySignature__DelegateSignature_FunctionAddress, "Actor");
		ActorEndPlaySignature__DelegateSignature_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ActorEndPlaySignature__DelegateSignature_FunctionAddress, "Actor");
		ActorEndPlaySignature__DelegateSignature_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorEndPlaySignature__DelegateSignature_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorEndPlaySignature__DelegateSignature_EndPlayReason_PropertyAddress, ActorEndPlaySignature__DelegateSignature_FunctionAddress, "EndPlayReason");
		ActorEndPlaySignature__DelegateSignature_EndPlayReason_Offset = NativeReflectionCached.GetPropertyOffset(ActorEndPlaySignature__DelegateSignature_FunctionAddress, "EndPlayReason");
		ActorEndPlaySignature__DelegateSignature_EndPlayReason_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorEndPlaySignature__DelegateSignature_FunctionAddress, "EndPlayReason", Classes.FByteProperty);
		ActorEndPlaySignature__DelegateSignature_IsValid = ActorEndPlaySignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorEndPlaySignature__DelegateSignature_Actor_IsValid && ActorEndPlaySignature__DelegateSignature_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorEndPlaySignature__DelegateSignature", ActorEndPlaySignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor Actor, EEndPlayReason EndPlayReason)
	{
		if (!ActorEndPlaySignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorEndPlaySignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorEndPlaySignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorEndPlaySignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorEndPlaySignature__DelegateSignature_Actor_Offset), 0, ActorEndPlaySignature__DelegateSignature_Actor_PropertyAddress.Address, Actor);
			EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, ActorEndPlaySignature__DelegateSignature_EndPlayReason_Offset), 0, ActorEndPlaySignature__DelegateSignature_EndPlayReason_PropertyAddress.Address, EndPlayReason);
			ProcessDelegate(intPtr);
		}
	}
}
