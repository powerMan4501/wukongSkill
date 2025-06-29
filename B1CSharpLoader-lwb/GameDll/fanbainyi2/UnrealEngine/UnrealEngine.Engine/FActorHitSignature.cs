using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorHitSignature__DelegateSignature")]
public class FActorHitSignature : FMulticastDelegate<FActorHitSignature.Signature>
{
	public delegate void Signature(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, FHitResult Hit);

	private static bool ActorHitSignature__DelegateSignature_IsValid;

	private static IntPtr ActorHitSignature__DelegateSignature_FunctionAddress;

	private static int ActorHitSignature__DelegateSignature_ParamsSize;

	private static bool ActorHitSignature__DelegateSignature_SelfActor_IsValid;

	private static FFieldAddress ActorHitSignature__DelegateSignature_SelfActor_PropertyAddress;

	private static int ActorHitSignature__DelegateSignature_SelfActor_Offset;

	private static bool ActorHitSignature__DelegateSignature_OtherActor_IsValid;

	private static FFieldAddress ActorHitSignature__DelegateSignature_OtherActor_PropertyAddress;

	private static int ActorHitSignature__DelegateSignature_OtherActor_Offset;

	private static bool ActorHitSignature__DelegateSignature_NormalImpulse_IsValid;

	private static FFieldAddress ActorHitSignature__DelegateSignature_NormalImpulse_PropertyAddress;

	private static int ActorHitSignature__DelegateSignature_NormalImpulse_Offset;

	private static bool ActorHitSignature__DelegateSignature_Hit_IsValid;

	private static FFieldAddress ActorHitSignature__DelegateSignature_Hit_PropertyAddress;

	private static int ActorHitSignature__DelegateSignature_Hit_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorHitSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorHitSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorHitSignature__DelegateSignature");
		ActorHitSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorHitSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorHitSignature__DelegateSignature_SelfActor_PropertyAddress, ActorHitSignature__DelegateSignature_FunctionAddress, "SelfActor");
		ActorHitSignature__DelegateSignature_SelfActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorHitSignature__DelegateSignature_FunctionAddress, "SelfActor");
		ActorHitSignature__DelegateSignature_SelfActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorHitSignature__DelegateSignature_FunctionAddress, "SelfActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorHitSignature__DelegateSignature_OtherActor_PropertyAddress, ActorHitSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ActorHitSignature__DelegateSignature_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorHitSignature__DelegateSignature_FunctionAddress, "OtherActor");
		ActorHitSignature__DelegateSignature_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorHitSignature__DelegateSignature_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorHitSignature__DelegateSignature_NormalImpulse_PropertyAddress, ActorHitSignature__DelegateSignature_FunctionAddress, "NormalImpulse");
		ActorHitSignature__DelegateSignature_NormalImpulse_Offset = NativeReflectionCached.GetPropertyOffset(ActorHitSignature__DelegateSignature_FunctionAddress, "NormalImpulse");
		ActorHitSignature__DelegateSignature_NormalImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorHitSignature__DelegateSignature_FunctionAddress, "NormalImpulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorHitSignature__DelegateSignature_Hit_PropertyAddress, ActorHitSignature__DelegateSignature_FunctionAddress, "Hit");
		ActorHitSignature__DelegateSignature_Hit_Offset = NativeReflectionCached.GetPropertyOffset(ActorHitSignature__DelegateSignature_FunctionAddress, "Hit");
		ActorHitSignature__DelegateSignature_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorHitSignature__DelegateSignature_FunctionAddress, "Hit", Classes.FStructProperty);
		ActorHitSignature__DelegateSignature_IsValid = ActorHitSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorHitSignature__DelegateSignature_SelfActor_IsValid && ActorHitSignature__DelegateSignature_OtherActor_IsValid && ActorHitSignature__DelegateSignature_NormalImpulse_IsValid && ActorHitSignature__DelegateSignature_Hit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorHitSignature__DelegateSignature", ActorHitSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, FHitResult Hit)
	{
		if (!ActorHitSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorHitSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorHitSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorHitSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorHitSignature__DelegateSignature_SelfActor_Offset), 0, ActorHitSignature__DelegateSignature_SelfActor_PropertyAddress.Address, SelfActor);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorHitSignature__DelegateSignature_OtherActor_Offset), 0, ActorHitSignature__DelegateSignature_OtherActor_PropertyAddress.Address, OtherActor);
			BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ActorHitSignature__DelegateSignature_NormalImpulse_Offset), 0, ActorHitSignature__DelegateSignature_NormalImpulse_PropertyAddress.Address, NormalImpulse);
			NativeReflection.InitializeValue_InContainer(ActorHitSignature__DelegateSignature_Hit_PropertyAddress.Address, intPtr);
			FHitResult.ToNative(IntPtr.Add(intPtr, ActorHitSignature__DelegateSignature_Hit_Offset), 0, ActorHitSignature__DelegateSignature_Hit_PropertyAddress.Address, Hit);
			ProcessDelegate(intPtr);
		}
	}
}
