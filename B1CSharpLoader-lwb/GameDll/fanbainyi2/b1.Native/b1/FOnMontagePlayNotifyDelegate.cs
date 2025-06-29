using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.OnMontagePlayNotifyDelegate__DelegateSignature")]
public class FOnMontagePlayNotifyDelegate : FMulticastDelegate<FOnMontagePlayNotifyDelegate.Signature>
{
	public delegate void Signature(FName NotifyName);

	private static bool OnMontagePlayNotifyDelegate__DelegateSignature_IsValid;

	private static IntPtr OnMontagePlayNotifyDelegate__DelegateSignature_FunctionAddress;

	private static int OnMontagePlayNotifyDelegate__DelegateSignature_ParamsSize;

	private static bool OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_IsValid;

	private static FFieldAddress OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_PropertyAddress;

	private static int OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMontagePlayNotifyDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMontagePlayNotifyDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.OnMontagePlayNotifyDelegate__DelegateSignature");
		OnMontagePlayNotifyDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMontagePlayNotifyDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_PropertyAddress, OnMontagePlayNotifyDelegate__DelegateSignature_FunctionAddress, "NotifyName");
		OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(OnMontagePlayNotifyDelegate__DelegateSignature_FunctionAddress, "NotifyName");
		OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMontagePlayNotifyDelegate__DelegateSignature_FunctionAddress, "NotifyName", Classes.FNameProperty);
		OnMontagePlayNotifyDelegate__DelegateSignature_IsValid = OnMontagePlayNotifyDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.OnMontagePlayNotifyDelegate__DelegateSignature", OnMontagePlayNotifyDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName NotifyName)
	{
		if (!OnMontagePlayNotifyDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.OnMontagePlayNotifyDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMontagePlayNotifyDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMontagePlayNotifyDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_Offset), 0, OnMontagePlayNotifyDelegate__DelegateSignature_NotifyName_PropertyAddress.Address, NotifyName);
			ProcessDelegate(intPtr);
		}
	}
}
