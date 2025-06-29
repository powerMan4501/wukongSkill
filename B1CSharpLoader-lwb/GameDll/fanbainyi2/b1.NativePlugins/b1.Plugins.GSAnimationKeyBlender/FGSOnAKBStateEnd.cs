using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UDelegate]
[UMetaPath("/Script/GSAnimationKeyBlender.GSOnAKBStateEnd__DelegateSignature")]
public class FGSOnAKBStateEnd : FMulticastDelegate<FGSOnAKBStateEnd.Signature>
{
	public delegate void Signature(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately);

	private static bool GSOnAKBStateEnd__DelegateSignature_IsValid;

	private static IntPtr GSOnAKBStateEnd__DelegateSignature_FunctionAddress;

	private static int GSOnAKBStateEnd__DelegateSignature_ParamsSize;

	private static bool GSOnAKBStateEnd__DelegateSignature_BeginStateName_IsValid;

	private static FFieldAddress GSOnAKBStateEnd__DelegateSignature_BeginStateName_PropertyAddress;

	private static int GSOnAKBStateEnd__DelegateSignature_BeginStateName_Offset;

	private static bool GSOnAKBStateEnd__DelegateSignature_EndStateName_IsValid;

	private static FFieldAddress GSOnAKBStateEnd__DelegateSignature_EndStateName_PropertyAddress;

	private static int GSOnAKBStateEnd__DelegateSignature_EndStateName_Offset;

	private static bool GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_IsValid;

	private static FFieldAddress GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress;

	private static int GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnAKBStateEnd()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnAKBStateEnd__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSAnimationKeyBlender.GSOnAKBStateEnd__DelegateSignature");
		GSOnAKBStateEnd__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnAKBStateEnd__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateEnd__DelegateSignature_BeginStateName_PropertyAddress, GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "BeginStateName");
		GSOnAKBStateEnd__DelegateSignature_BeginStateName_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "BeginStateName");
		GSOnAKBStateEnd__DelegateSignature_BeginStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "BeginStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateEnd__DelegateSignature_EndStateName_PropertyAddress, GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "EndStateName");
		GSOnAKBStateEnd__DelegateSignature_EndStateName_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "EndStateName");
		GSOnAKBStateEnd__DelegateSignature_EndStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "EndStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress, GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately");
		GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately");
		GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateEnd__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately", Classes.FBoolProperty);
		GSOnAKBStateEnd__DelegateSignature_IsValid = GSOnAKBStateEnd__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnAKBStateEnd__DelegateSignature_BeginStateName_IsValid && GSOnAKBStateEnd__DelegateSignature_EndStateName_IsValid && GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSOnAKBStateEnd__DelegateSignature", GSOnAKBStateEnd__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		if (!GSOnAKBStateEnd__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSOnAKBStateEnd__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnAKBStateEnd__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnAKBStateEnd__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GSOnAKBStateEnd__DelegateSignature_BeginStateName_Offset), 0, GSOnAKBStateEnd__DelegateSignature_BeginStateName_PropertyAddress.Address, BeginStateName);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GSOnAKBStateEnd__DelegateSignature_EndStateName_Offset), 0, GSOnAKBStateEnd__DelegateSignature_EndStateName_PropertyAddress.Address, EndStateName);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_Offset), 0, GSOnAKBStateEnd__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress.Address, IsFromForceSetStateImmediately);
			ProcessDelegate(intPtr);
		}
	}
}
