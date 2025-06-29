using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature")]
public class FActorComponentDeactivateSignature : FMulticastDelegate<FActorComponentDeactivateSignature.Signature>
{
	public delegate void Signature(UActorComponent Component);

	private static bool ActorComponentDeactivateSignature__DelegateSignature_IsValid;

	private static IntPtr ActorComponentDeactivateSignature__DelegateSignature_FunctionAddress;

	private static int ActorComponentDeactivateSignature__DelegateSignature_ParamsSize;

	private static bool ActorComponentDeactivateSignature__DelegateSignature_Component_IsValid;

	private static FFieldAddress ActorComponentDeactivateSignature__DelegateSignature_Component_PropertyAddress;

	private static int ActorComponentDeactivateSignature__DelegateSignature_Component_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorComponentDeactivateSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorComponentDeactivateSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature");
		ActorComponentDeactivateSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorComponentDeactivateSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorComponentDeactivateSignature__DelegateSignature_Component_PropertyAddress, ActorComponentDeactivateSignature__DelegateSignature_FunctionAddress, "Component");
		ActorComponentDeactivateSignature__DelegateSignature_Component_Offset = NativeReflectionCached.GetPropertyOffset(ActorComponentDeactivateSignature__DelegateSignature_FunctionAddress, "Component");
		ActorComponentDeactivateSignature__DelegateSignature_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorComponentDeactivateSignature__DelegateSignature_FunctionAddress, "Component", Classes.FObjectProperty);
		ActorComponentDeactivateSignature__DelegateSignature_IsValid = ActorComponentDeactivateSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorComponentDeactivateSignature__DelegateSignature_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature", ActorComponentDeactivateSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UActorComponent Component)
	{
		if (!ActorComponentDeactivateSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponentDeactivateSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorComponentDeactivateSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorComponentDeactivateSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, ActorComponentDeactivateSignature__DelegateSignature_Component_Offset), 0, ActorComponentDeactivateSignature__DelegateSignature_Component_PropertyAddress.Address, Component);
			ProcessDelegate(intPtr);
		}
	}
}
