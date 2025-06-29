using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UDelegate]
[UMetaPath("/Script/GSAnimationKeyBlender.GSOnAKBStateBegin__DelegateSignature")]
public class FGSOnAKBStateBegin : FMulticastDelegate<FGSOnAKBStateBegin.Signature>
{
	public delegate void Signature(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately);

	private static bool GSOnAKBStateBegin__DelegateSignature_IsValid;

	private static IntPtr GSOnAKBStateBegin__DelegateSignature_FunctionAddress;

	private static int GSOnAKBStateBegin__DelegateSignature_ParamsSize;

	private static bool GSOnAKBStateBegin__DelegateSignature_BeginStateName_IsValid;

	private static FFieldAddress GSOnAKBStateBegin__DelegateSignature_BeginStateName_PropertyAddress;

	private static int GSOnAKBStateBegin__DelegateSignature_BeginStateName_Offset;

	private static bool GSOnAKBStateBegin__DelegateSignature_EndStateName_IsValid;

	private static FFieldAddress GSOnAKBStateBegin__DelegateSignature_EndStateName_PropertyAddress;

	private static int GSOnAKBStateBegin__DelegateSignature_EndStateName_Offset;

	private static bool GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_IsValid;

	private static FFieldAddress GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress;

	private static int GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FGSOnAKBStateBegin()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		GSOnAKBStateBegin__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSAnimationKeyBlender.GSOnAKBStateBegin__DelegateSignature");
		GSOnAKBStateBegin__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnAKBStateBegin__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateBegin__DelegateSignature_BeginStateName_PropertyAddress, GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "BeginStateName");
		GSOnAKBStateBegin__DelegateSignature_BeginStateName_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "BeginStateName");
		GSOnAKBStateBegin__DelegateSignature_BeginStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "BeginStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateBegin__DelegateSignature_EndStateName_PropertyAddress, GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "EndStateName");
		GSOnAKBStateBegin__DelegateSignature_EndStateName_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "EndStateName");
		GSOnAKBStateBegin__DelegateSignature_EndStateName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "EndStateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress, GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately");
		GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_Offset = NativeReflectionCached.GetPropertyOffset(GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately");
		GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnAKBStateBegin__DelegateSignature_FunctionAddress, "IsFromForceSetStateImmediately", Classes.FBoolProperty);
		GSOnAKBStateBegin__DelegateSignature_IsValid = GSOnAKBStateBegin__DelegateSignature_FunctionAddress != IntPtr.Zero && GSOnAKBStateBegin__DelegateSignature_BeginStateName_IsValid && GSOnAKBStateBegin__DelegateSignature_EndStateName_IsValid && GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSOnAKBStateBegin__DelegateSignature", GSOnAKBStateBegin__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		if (!GSOnAKBStateBegin__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSOnAKBStateBegin__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(GSOnAKBStateBegin__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnAKBStateBegin__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GSOnAKBStateBegin__DelegateSignature_BeginStateName_Offset), 0, GSOnAKBStateBegin__DelegateSignature_BeginStateName_PropertyAddress.Address, BeginStateName);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GSOnAKBStateBegin__DelegateSignature_EndStateName_Offset), 0, GSOnAKBStateBegin__DelegateSignature_EndStateName_PropertyAddress.Address, EndStateName);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_Offset), 0, GSOnAKBStateBegin__DelegateSignature_IsFromForceSetStateImmediately_PropertyAddress.Address, IsFromForceSetStateImmediately);
			ProcessDelegate(intPtr);
		}
	}
}
