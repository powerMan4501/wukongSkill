using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature")]
public class FOnListEntryReleasedDynamic : FMulticastDelegate<FOnListEntryReleasedDynamic.Signature>
{
	public delegate void Signature(UUserWidget Widget);

	private static bool OnListEntryReleasedDynamic__DelegateSignature_IsValid;

	private static IntPtr OnListEntryReleasedDynamic__DelegateSignature_FunctionAddress;

	private static int OnListEntryReleasedDynamic__DelegateSignature_ParamsSize;

	private static bool OnListEntryReleasedDynamic__DelegateSignature_Widget_IsValid;

	private static FFieldAddress OnListEntryReleasedDynamic__DelegateSignature_Widget_PropertyAddress;

	private static int OnListEntryReleasedDynamic__DelegateSignature_Widget_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnListEntryReleasedDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnListEntryReleasedDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature");
		OnListEntryReleasedDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListEntryReleasedDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListEntryReleasedDynamic__DelegateSignature_Widget_PropertyAddress, OnListEntryReleasedDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListEntryReleasedDynamic__DelegateSignature_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnListEntryReleasedDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListEntryReleasedDynamic__DelegateSignature_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListEntryReleasedDynamic__DelegateSignature_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnListEntryReleasedDynamic__DelegateSignature_IsValid = OnListEntryReleasedDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnListEntryReleasedDynamic__DelegateSignature_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature", OnListEntryReleasedDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UUserWidget Widget)
	{
		if (!OnListEntryReleasedDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnListEntryReleasedDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListEntryReleasedDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnListEntryReleasedDynamic__DelegateSignature_Widget_Offset), 0, OnListEntryReleasedDynamic__DelegateSignature_Widget_PropertyAddress.Address, Widget);
			ProcessDelegate(intPtr);
		}
	}
}
