using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature")]
public class FOnItemIsHoveredChangedDynamic : FMulticastDelegate<FOnItemIsHoveredChangedDynamic.Signature>
{
	public delegate void Signature(UObject Item, bool bIsHovered);

	private static bool OnItemIsHoveredChangedDynamic__DelegateSignature_IsValid;

	private static IntPtr OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress;

	private static int OnItemIsHoveredChangedDynamic__DelegateSignature_ParamsSize;

	private static bool OnItemIsHoveredChangedDynamic__DelegateSignature_Item_IsValid;

	private static FFieldAddress OnItemIsHoveredChangedDynamic__DelegateSignature_Item_PropertyAddress;

	private static int OnItemIsHoveredChangedDynamic__DelegateSignature_Item_Offset;

	private static bool OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_IsValid;

	private static FFieldAddress OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_PropertyAddress;

	private static int OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnItemIsHoveredChangedDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature");
		OnItemIsHoveredChangedDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnItemIsHoveredChangedDynamic__DelegateSignature_Item_PropertyAddress, OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnItemIsHoveredChangedDynamic__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress, "Item");
		OnItemIsHoveredChangedDynamic__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_PropertyAddress, OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress, "bIsHovered");
		OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_Offset = NativeReflectionCached.GetPropertyOffset(OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress, "bIsHovered");
		OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_IsValid = NativeReflectionCached.ValidatePropertyClass(OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress, "bIsHovered", Classes.FBoolProperty);
		OnItemIsHoveredChangedDynamic__DelegateSignature_IsValid = OnItemIsHoveredChangedDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && OnItemIsHoveredChangedDynamic__DelegateSignature_Item_IsValid && OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature", OnItemIsHoveredChangedDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Item, bool bIsHovered)
	{
		if (!OnItemIsHoveredChangedDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnItemIsHoveredChangedDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnItemIsHoveredChangedDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnItemIsHoveredChangedDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnItemIsHoveredChangedDynamic__DelegateSignature_Item_Offset), 0, OnItemIsHoveredChangedDynamic__DelegateSignature_Item_PropertyAddress.Address, Item);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_Offset), 0, OnItemIsHoveredChangedDynamic__DelegateSignature_bIsHovered_PropertyAddress.Address, bIsHovered);
			ProcessDelegate(intPtr);
		}
	}
}
