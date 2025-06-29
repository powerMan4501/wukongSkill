using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UDelegate]
[UMetaPath("/Script/AnimGraphRuntime.OnMontagePlayDelegate__DelegateSignature")]
public class FOnMontagePlayDelegate : FMulticastDelegate<FOnMontagePlayDelegate.Signature>
{
	public delegate void Signature(FName NotifyName);

	private static bool OnMontagePlayDelegate__DelegateSignature_IsValid;

	private static IntPtr OnMontagePlayDelegate__DelegateSignature_FunctionAddress;

	private static int OnMontagePlayDelegate__DelegateSignature_ParamsSize;

	private static bool OnMontagePlayDelegate__DelegateSignature_NotifyName_IsValid;

	private static FFieldAddress OnMontagePlayDelegate__DelegateSignature_NotifyName_PropertyAddress;

	private static int OnMontagePlayDelegate__DelegateSignature_NotifyName_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMontagePlayDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMontagePlayDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AnimGraphRuntime.OnMontagePlayDelegate__DelegateSignature");
		OnMontagePlayDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMontagePlayDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMontagePlayDelegate__DelegateSignature_NotifyName_PropertyAddress, OnMontagePlayDelegate__DelegateSignature_FunctionAddress, "NotifyName");
		OnMontagePlayDelegate__DelegateSignature_NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(OnMontagePlayDelegate__DelegateSignature_FunctionAddress, "NotifyName");
		OnMontagePlayDelegate__DelegateSignature_NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMontagePlayDelegate__DelegateSignature_FunctionAddress, "NotifyName", Classes.FNameProperty);
		OnMontagePlayDelegate__DelegateSignature_IsValid = OnMontagePlayDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMontagePlayDelegate__DelegateSignature_NotifyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.OnMontagePlayDelegate__DelegateSignature", OnMontagePlayDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName NotifyName)
	{
		if (!OnMontagePlayDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.OnMontagePlayDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMontagePlayDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMontagePlayDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnMontagePlayDelegate__DelegateSignature_NotifyName_Offset), 0, OnMontagePlayDelegate__DelegateSignature_NotifyName_PropertyAddress.Address, NotifyName);
			ProcessDelegate(intPtr);
		}
	}
}
