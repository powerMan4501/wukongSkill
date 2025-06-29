using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature")]
public class FOnListItemSelectionChangedDynamic : FMulticastDelegate<FOnListItemSelectionChangedDynamic.Signature>
{
	public delegate void Signature(UObject Item, bool bIsSelected);

	private static bool OnListItemSelectionChangedDynamic__DelegateSignature_IsValid;

	private static IntPtr OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress;

	private static int OnListItemSelectionChangedDynamic__DelegateSignature_ParamsSize;

	private static bool OnListItemSelectionChangedDynamic__DelegateSignature_Item_IsValid;

	private static FFieldAddress OnListItemSelectionChangedDynamic__DelegateSignature_Item_PropertyAddress;

	private static int OnListItemSelectionChangedDynamic__DelegateSignature_Item_Offset;

	private static bool OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_IsValid;

	private static FFieldAddress OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_PropertyAddress;

	private static int OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnListItemSelectionChangedDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature");
		OnListItemSelectionChangedDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnListItemSelectionChangedDynamic__DelegateSignature_Item_PropertyAddress, OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnListItemSelectionChangedDynamic__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnListItemSelectionChangedDynamic__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_PropertyAddress, OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress, "bIsSelected");
		OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_Offset = NativeReflectionCached.GetPropertyOffset(OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress, "bIsSelected");
		OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress, "bIsSelected", Classes.FBoolProperty);
		OnListItemSelectionChangedDynamic__DelegateSignature_IsValid = OnListItemSelectionChangedDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnListItemSelectionChangedDynamic__DelegateSignature_Item_IsValid && OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature", OnListItemSelectionChangedDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Item, bool bIsSelected)
	{
		if (!OnListItemSelectionChangedDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnListItemSelectionChangedDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnListItemSelectionChangedDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnListItemSelectionChangedDynamic__DelegateSignature_Item_Offset), 0, OnListItemSelectionChangedDynamic__DelegateSignature_Item_PropertyAddress.Address, Item);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_Offset), 0, OnListItemSelectionChangedDynamic__DelegateSignature_bIsSelected_PropertyAddress.Address, bIsSelected);
			ProcessDelegate(intPtr);
		}
	}
}
