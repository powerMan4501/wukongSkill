using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnCheckBoxComponentStateChanged__DelegateSignature")]
public class FOnCheckBoxComponentStateChanged : FMulticastDelegate<FOnCheckBoxComponentStateChanged.Signature>
{
	public delegate void Signature(bool bIsChecked);

	private static bool OnCheckBoxComponentStateChanged__DelegateSignature_IsValid;

	private static IntPtr OnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress;

	private static int OnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize;

	private static bool OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_IsValid;

	private static FFieldAddress OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_PropertyAddress;

	private static int OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnCheckBoxComponentStateChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnCheckBoxComponentStateChanged__DelegateSignature");
		OnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_PropertyAddress, OnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress, "bIsChecked");
		OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_Offset = NativeReflectionCached.GetPropertyOffset(OnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress, "bIsChecked");
		OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress, "bIsChecked", Classes.FBoolProperty);
		OnCheckBoxComponentStateChanged__DelegateSignature_IsValid = OnCheckBoxComponentStateChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnCheckBoxComponentStateChanged__DelegateSignature", OnCheckBoxComponentStateChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool bIsChecked)
	{
		if (!OnCheckBoxComponentStateChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnCheckBoxComponentStateChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCheckBoxComponentStateChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_Offset), 0, OnCheckBoxComponentStateChanged__DelegateSignature_bIsChecked_PropertyAddress.Address, bIsChecked);
			ProcessDelegate(intPtr);
		}
	}
}
