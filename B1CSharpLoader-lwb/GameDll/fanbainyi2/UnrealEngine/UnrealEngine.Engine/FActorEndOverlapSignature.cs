using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorEndOverlapSignature__DelegateSignature")]
public class FActorEndOverlapSignature : FMulticastDelegate<FActorEndOverlapSignature.Signature>
{
	public delegate void Signature(AActor OverlappedActor, AActor OtherActor);

	private static bool ActorEndOverlapSignature__DelegateSignature_IsValid;

	private static IntPtr ActorEndOverlapSignature__DelegateSignature_FunctionAddress;

	private static int ActorEndOverlapSignature__DelegateSignature_ParamsSize;

	private static bool ActorEndOverlapSignature__DelegateSignature_OverlappedActor_IsValid;

	private static FFieldAddress ActorEndOverlapSignature__DelegateSignature_OverlappedActor_PropertyAddress;

	private static int ActorEndOverlapSignature__DelegateSignature_OverlappedActor_Offset;

	private static bool ActorEndOverlapSignature__DelegateSignature_OtherActor_IsValid;

	private static FFieldAddress ActorEndOverlapSignature__DelegateSignature_OtherActor_PropertyAddress;

	private static int ActorEndOverlapSignature__DelegateSignature_OtherActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorEndOverlapSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorEndOverlapSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorEndOverlapSignature__DelegateSignature");
		ActorEndOverlapSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorEndOverlapSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorEndOverlapSignature__DelegateSignature_OverlappedActor_PropertyAddress, ActorEndOverlapSignature__DelegateSignature_FunctionAddress, "OverlappedActor");
		ActorEndOverlapSignature__DelegateSignature_OverlappedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorEndOverlapSignature__DelegateSignature_FunctionAddress, "OverlappedActor");
		ActorEndOverlapSignature__DelegateSignature_OverlappedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorEndOverlapSignature__DelegateSignature_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorEndOverlapSignature__DelegateSignature_OtherActor_PropertyAddress, ActorEndOverlapSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ActorEndOverlapSignature__DelegateSignature_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorEndOverlapSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ActorEndOverlapSignature__DelegateSignature_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorEndOverlapSignature__DelegateSignature_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		ActorEndOverlapSignature__DelegateSignature_IsValid = ActorEndOverlapSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorEndOverlapSignature__DelegateSignature_OverlappedActor_IsValid && ActorEndOverlapSignature__DelegateSignature_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorEndOverlapSignature__DelegateSignature", ActorEndOverlapSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor OverlappedActor, AActor OtherActor)
	{
		if (!ActorEndOverlapSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorEndOverlapSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorEndOverlapSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorEndOverlapSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorEndOverlapSignature__DelegateSignature_OverlappedActor_Offset), 0, ActorEndOverlapSignature__DelegateSignature_OverlappedActor_PropertyAddress.Address, OverlappedActor);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorEndOverlapSignature__DelegateSignature_OtherActor_Offset), 0, ActorEndOverlapSignature__DelegateSignature_OtherActor_PropertyAddress.Address, OtherActor);
			ProcessDelegate(intPtr);
		}
	}
}
