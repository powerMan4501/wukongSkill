using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature")]
public class FOnListEntryInitializedDynamic : FMulticastDelegate<FOnListEntryInitializedDynamic.Signature>
{
	public delegate void Signature(UObject Item, UUserWidget Widget);

	private static bool OnListEntryInitializedDynamic__DelegateSignature_IsValid;

	private static IntPtr OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress;

	private static int OnListEntryInitializedDynamic__DelegateSignature_ParamsSize;

	private static bool OnListEntryInitializedDynamic__DelegateSignature_Item_IsValid;

	private static FFieldAddress OnListEntryInitializedDynamic__DelegateSignature_Item_PropertyAddress;

	private static int OnListEntryInitializedDynamic__DelegateSignature_Item_Offset;

	private static bool OnListEntryInitializedDynamic__DelegateSignature_Widget_IsValid;

	private static FFieldAddress OnListEntryInitializedDynamic__DelegateSignature_Widget_PropertyAddress;

	private static int OnListEntryInitializedDynamic__DelegateSignature_Widget_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnListEntryInitializedDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature");
		OnListEntryInitializedDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListEntryInitializedDynamic__DelegateSignature_Item_PropertyAddress, OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnListEntryInitializedDynamic__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnListEntryInitializedDynamic__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListEntryInitializedDynamic__DelegateSignature_Widget_PropertyAddress, OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListEntryInitializedDynamic__DelegateSignature_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress, "Widget");
		OnListEntryInitializedDynamic__DelegateSignature_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnListEntryInitializedDynamic__DelegateSignature_IsValid = OnListEntryInitializedDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnListEntryInitializedDynamic__DelegateSignature_Item_IsValid && OnListEntryInitializedDynamic__DelegateSignature_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature", OnListEntryInitializedDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Item, UUserWidget Widget)
	{
		if (!OnListEntryInitializedDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnListEntryInitializedDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListEntryInitializedDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnListEntryInitializedDynamic__DelegateSignature_Item_Offset), 0, OnListEntryInitializedDynamic__DelegateSignature_Item_PropertyAddress.Address, Item);
			UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, OnListEntryInitializedDynamic__DelegateSignature_Widget_Offset), 0, OnListEntryInitializedDynamic__DelegateSignature_Widget_PropertyAddress.Address, Widget);
			ProcessDelegate(intPtr);
		}
	}
}
