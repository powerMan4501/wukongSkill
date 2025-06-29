using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UDelegate]
[UMetaPath("/Script/GSAnimationKeyBlender.GSOnAKBStateInterupt__DelegateSignature")]
public class FGSOnAKBStateInterupt : FMulticastDelegate<FGSOnAKBStateInterupt.Signature>
{
	public delegate void Signature(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately);

	private static bool GSOnAKBStateInterupt__DelegateSignature_IsValid;

	private static IntPtr GSOnAKBStateInterupt__DelegateSignature_FunctionAddress;

	private static int GSOnAKBStateInterupt__DelegateSignature_ParamsSize;

	private static bool GSOnAKBStateInterupt__DelegateSignature_BeginStateName_IsValid;

	private static FFieldAddress GSOnAKBStateInterupt__DelegateSignature_BeginStateName_PropertyAddress;

	private static int GSOnAKBStateInterupt__DelegateSignature_BeginStateName_Offset;

	private static bool GSOnAKBStateInterupt__DelegateSignature_EndStateName_IsValid;

	private static FFieldAddress GSOnAKBStateInterupt__DelegateSignature_EndStateName_PropertyAddress;

	private static int GSOnAKBStateInterupt__DelegateSignature_EndStateName_Offset;

	private static bool GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_IsValid;

	private static FFieldAddress GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress;

	private static int GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnAKBStateInterupt()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnAKBStateInterupt__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSAnimationKeyBlender.GSOnAKBStateInterupt__DelegateSignature");
		GSOnAKBStateInterupt__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnAKBStateInterupt__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateInterupt__DelegateSignature_BeginStateName_PropertyAddress, GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "BeginStateName");
		GSOnAKBStateInterupt__DelegateSignature_BeginStateName_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "BeginStateName");
		GSOnAKBStateInterupt__DelegateSignature_BeginStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "BeginStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateInterupt__DelegateSignature_EndStateName_PropertyAddress, GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "EndStateName");
		GSOnAKBStateInterupt__DelegateSignature_EndStateName_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "EndStateName");
		GSOnAKBStateInterupt__DelegateSignature_EndStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "EndStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress, GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately");
		GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately");
		GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateInterupt__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately", Classes.FBoolProperty);
		GSOnAKBStateInterupt__DelegateSignature_IsValid = GSOnAKBStateInterupt__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnAKBStateInterupt__DelegateSignature_BeginStateName_IsValid && GSOnAKBStateInterupt__DelegateSignature_EndStateName_IsValid && GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSOnAKBStateInterupt__DelegateSignature", GSOnAKBStateInterupt__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		if (!GSOnAKBStateInterupt__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSOnAKBStateInterupt__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnAKBStateInterupt__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnAKBStateInterupt__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GSOnAKBStateInterupt__DelegateSignature_BeginStateName_Offset), 0, GSOnAKBStateInterupt__DelegateSignature_BeginStateName_PropertyAddress.Address, BeginStateName);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GSOnAKBStateInterupt__DelegateSignature_EndStateName_Offset), 0, GSOnAKBStateInterupt__DelegateSignature_EndStateName_PropertyAddress.Address, EndStateName);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_Offset), 0, GSOnAKBStateInterupt__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress.Address, IsFromForceSetStateImmediately);
			ProcessDelegate(intPtr);
		}
	}
}
