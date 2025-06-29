using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature")]
public class FOnListEntryGeneratedDynamic : FMulticastDelegate<FOnListEntryGeneratedDynamic.Signature>
{
	public delegate void Signature(UUserWidget Widget);

	private static bool OnListEntryGeneratedDynamic__DelegateSignature_IsValid;

	private static IntPtr OnListEntryGeneratedDynamic__DelegateSignature_FunctionAddress;

	private static int OnListEntryGeneratedDynamic__DelegateSignature_ParamsSize;

	private static bool OnListEntryGeneratedDynamic__DelegateSignature_Widget_IsValid;

	private static FFieldAddress OnListEntryGeneratedDynamic__DelegateSignature_Widget_PropertyAddress;

	private static int OnListEntryGeneratedDynamic__DelegateSignature_Widget_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnListEntryGeneratedDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnListEntryGeneratedDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature");
		OnListEntryGeneratedDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListEntryGeneratedDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListEntryGeneratedDynamic__DelegateSignature_Widget_PropertyAddress, OnListEntryGeneratedDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListEntryGeneratedDynamic__DelegateSignature_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnListEntryGeneratedDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListEntryGeneratedDynamic__DelegateSignature_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListEntryGeneratedDynamic__DelegateSignature_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnListEntryGeneratedDynamic__DelegateSignature_IsValid = OnListEntryGeneratedDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnListEntryGeneratedDynamic__DelegateSignature_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature", OnListEntryGeneratedDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UUserWidget Widget)
	{
		if (!OnListEntryGeneratedDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnListEntryGeneratedDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListEntryGeneratedDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnListEntryGeneratedDynamic__DelegateSignature_Widget_Offset), 0, OnListEntryGeneratedDynamic__DelegateSignature_Widget_PropertyAddress.Address, Widget);
			ProcessDelegate(intPtr);
		}
	}
}
