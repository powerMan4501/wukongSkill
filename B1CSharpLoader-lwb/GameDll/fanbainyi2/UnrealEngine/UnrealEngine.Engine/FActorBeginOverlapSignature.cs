using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorBeginOverlapSignature__DelegateSignature")]
public class FActorBeginOverlapSignature : FMulticastDelegate<FActorBeginOverlapSignature.Signature>
{
	public delegate void Signature(AActor OverlappedActor, AActor OtherActor);

	private static bool ActorBeginOverlapSignature__DelegateSignature_IsValid;

	private static IntPtr ActorBeginOverlapSignature__DelegateSignature_FunctionAddress;

	private static int ActorBeginOverlapSignature__DelegateSignature_ParamsSize;

	private static bool ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_IsValid;

	private static FFieldAddress ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_PropertyAddress;

	private static int ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_Offset;

	private static bool ActorBeginOverlapSignature__DelegateSignature_OtherActor_IsValid;

	private static FFieldAddress ActorBeginOverlapSignature__DelegateSignature_OtherActor_PropertyAddress;

	private static int ActorBeginOverlapSignature__DelegateSignature_OtherActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorBeginOverlapSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorBeginOverlapSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorBeginOverlapSignature__DelegateSignature");
		ActorBeginOverlapSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorBeginOverlapSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_PropertyAddress, ActorBeginOverlapSignature__DelegateSignature_FunctionAddress, "OverlappedActor");
		ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorBeginOverlapSignature__DelegateSignature_FunctionAddress, "OverlappedActor");
		ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorBeginOverlapSignature__DelegateSignature_FunctionAddress, "OverlappedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorBeginOverlapSignature__DelegateSignature_OtherActor_PropertyAddress, ActorBeginOverlapSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ActorBeginOverlapSignature__DelegateSignature_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorBeginOverlapSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ActorBeginOverlapSignature__DelegateSignature_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorBeginOverlapSignature__DelegateSignature_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		ActorBeginOverlapSignature__DelegateSignature_IsValid = ActorBeginOverlapSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_IsValid && ActorBeginOverlapSignature__DelegateSignature_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorBeginOverlapSignature__DelegateSignature", ActorBeginOverlapSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor OverlappedActor, AActor OtherActor)
	{
		if (!ActorBeginOverlapSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorBeginOverlapSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorBeginOverlapSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorBeginOverlapSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_Offset), 0, ActorBeginOverlapSignature__DelegateSignature_OverlappedActor_PropertyAddress.Address, OverlappedActor);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorBeginOverlapSignature__DelegateSignature_OtherActor_Offset), 0, ActorBeginOverlapSignature__DelegateSignature_OtherActor_PropertyAddress.Address, OtherActor);
			ProcessDelegate(intPtr);
		}
	}
}
