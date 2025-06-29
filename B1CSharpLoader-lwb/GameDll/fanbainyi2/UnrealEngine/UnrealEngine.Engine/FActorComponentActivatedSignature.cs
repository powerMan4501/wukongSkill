using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.ActorComponentActivatedSignature__DelegateSignature")]
public class FActorComponentActivatedSignature : FMulticastDelegate<FActorComponentActivatedSignature.Signature>
{
	public delegate void Signature(UActorComponent Component, bool bReset);

	private static bool ActorComponentActivatedSignature__DelegateSignature_IsValid;

	private static IntPtr ActorComponentActivatedSignature__DelegateSignature_FunctionAddress;

	private static int ActorComponentActivatedSignature__DelegateSignature_ParamsSize;

	private static bool ActorComponentActivatedSignature__DelegateSignature_Component_IsValid;

	private static FFieldAddress ActorComponentActivatedSignature__DelegateSignature_Component_PropertyAddress;

	private static int ActorComponentActivatedSignature__DelegateSignature_Component_Offset;

	private static bool ActorComponentActivatedSignature__DelegateSignature_bReset_IsValid;

	private static FFieldAddress ActorComponentActivatedSignature__DelegateSignature_bReset_PropertyAddress;

	private static int ActorComponentActivatedSignature__DelegateSignature_bReset_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FActorComponentActivatedSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ActorComponentActivatedSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ActorComponentActivatedSignature__DelegateSignature");
		ActorComponentActivatedSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorComponentActivatedSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorComponentActivatedSignature__DelegateSignature_Component_PropertyAddress, ActorComponentActivatedSignature__DelegateSignature_FunctionAddress, "Component");
		ActorComponentActivatedSignature__DelegateSignature_Component_Offset = NativeReflectionCached.GetPropertyOffset(ActorComponentActivatedSignature__DelegateSignature_FunctionAddress, "Component");
		ActorComponentActivatedSignature__DelegateSignature_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorComponentActivatedSignature__DelegateSignature_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorComponentActivatedSignature__DelegateSignature_bReset_PropertyAddress, ActorComponentActivatedSignature__DelegateSignature_FunctionAddress, "bReset");
		ActorComponentActivatedSignature__DelegateSignature_bReset_Offset = NativeReflectionCached.GetPropertyOffset(ActorComponentActivatedSignature__DelegateSignature_FunctionAddress, "bReset");
		ActorComponentActivatedSignature__DelegateSignature_bReset_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorComponentActivatedSignature__DelegateSignature_FunctionAddress, "bReset", Classes.FBoolProperty);
		ActorComponentActivatedSignature__DelegateSignature_IsValid = ActorComponentActivatedSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ActorComponentActivatedSignature__DelegateSignature_Component_IsValid && ActorComponentActivatedSignature__DelegateSignature_bReset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ActorComponentActivatedSignature__DelegateSignature", ActorComponentActivatedSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UActorComponent Component, bool bReset)
	{
		if (!ActorComponentActivatedSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ActorComponentActivatedSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ActorComponentActivatedSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorComponentActivatedSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, ActorComponentActivatedSignature__DelegateSignature_Component_Offset), 0, ActorComponentActivatedSignature__DelegateSignature_Component_PropertyAddress.Address, Component);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, ActorComponentActivatedSignature__DelegateSignature_bReset_Offset), 0, ActorComponentActivatedSignature__DelegateSignature_bReset_PropertyAddress.Address, bReset);
			ProcessDelegate(intPtr);
		}
	}
}
