using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorDestroyedSignature__DelegateSignature")]
public class FActorDestroyedSignature : FMulticastDelegate<FActorDestroyedSignature.Signature>
{
	public delegate void Signature(AActor DestroyedActor);

	private static bool ActorDestroyedSignature__DelegateSignature_IsValid;

	private static IntPtr ActorDestroyedSignature__DelegateSignature_FunctionAddress;

	private static int ActorDestroyedSignature__DelegateSignature_ParamsSize;

	private static bool ActorDestroyedSignature__DelegateSignature_DestroyedActor_IsValid;

	private static FFieldAddress ActorDestroyedSignature__DelegateSignature_DestroyedActor_PropertyAddress;

	private static int ActorDestroyedSignature__DelegateSignature_DestroyedActor_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorDestroyedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorDestroyedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorDestroyedSignature__DelegateSignature");
		ActorDestroyedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorDestroyedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorDestroyedSignature__DelegateSignature_DestroyedActor_PropertyAddress, ActorDestroyedSignature__DelegateSignature_FunctionAddress, "DestroyedActor");
		ActorDestroyedSignature__DelegateSignature_DestroyedActor_Offset = NativeReflectionCached.GetPropertyOffset(ActorDestroyedSignature__DelegateSignature_FunctionAddress, "DestroyedActor");
		ActorDestroyedSignature__DelegateSignature_DestroyedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorDestroyedSignature__DelegateSignature_FunctionAddress, "DestroyedActor", Classes.FObjectProperty);
		ActorDestroyedSignature__DelegateSignature_IsValid = ActorDestroyedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorDestroyedSignature__DelegateSignature_DestroyedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorDestroyedSignature__DelegateSignature", ActorDestroyedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor DestroyedActor)
	{
		if (!ActorDestroyedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorDestroyedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorDestroyedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorDestroyedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorDestroyedSignature__DelegateSignature_DestroyedActor_Offset), 0, ActorDestroyedSignature__DelegateSignature_DestroyedActor_PropertyAddress.Address, DestroyedActor);
			ProcessDelegate(intPtr);
		}
	}
}
