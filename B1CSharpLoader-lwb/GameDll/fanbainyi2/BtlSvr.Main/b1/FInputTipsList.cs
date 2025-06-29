using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InputTipsList")]
public struct FInputTipsList
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.InputTipsList:InputActionList")]
	public List<FInputTipsOneCfg> InputActionList;

	private static int InputTipsList_StructSize;

	private static int InputTipsList_IsValid;

	private static bool InputActionList_IsValid;

	private static int InputActionList_Offset;

	private static FFieldAddress InputActionList_PropertyAddress;

	public FInputTipsList Copy()
	{
		FInputTipsList result = this;
		if (InputActionList != null)
		{
			result.InputActionList = new List<FInputTipsOneCfg>(InputActionList);
		}
		return result;
	}

	public static FInputTipsList FromNative(IntPtr nativeBuffer)
	{
		return new FInputTipsList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputTipsList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputTipsList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputTipsList(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsList_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputTipsList value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsList_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputTipsList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsList");
		}
		else
		{
			new TArrayCopyMarshaler<FInputTipsOneCfg>(1, InputActionList_PropertyAddress, CachedMarshalingDelegates<FInputTipsOneCfg, FInputTipsOneCfg>.FromNative, CachedMarshalingDelegates<FInputTipsOneCfg, FInputTipsOneCfg>.ToNative).ToNative(IntPtr.Add(nativeStruct, InputActionList_Offset), InputActionList);
		}
	}

	public FInputTipsList(IntPtr nativeStruct)
	{
		if (InputTipsList_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsList");
			InputActionList = null;
		}
		else
		{
			InputActionList = new TArrayCopyMarshaler<FInputTipsOneCfg>(1, InputActionList_PropertyAddress, CachedMarshalingDelegates<FInputTipsOneCfg, FInputTipsOneCfg>.FromNative, CachedMarshalingDelegates<FInputTipsOneCfg, FInputTipsOneCfg>.ToNative).FromNative(IntPtr.Add(nativeStruct, InputActionList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputTipsList");
		InputTipsList_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref InputActionList_PropertyAddress, intPtr, "InputActionList");
		InputActionList_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputActionList");
		InputActionList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputActionList", Classes.FArrayProperty);
		InputTipsList_IsValid = ((intPtr != IntPtr.Zero && InputActionList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputTipsList", (byte)InputTipsList_IsValid != 0);
	}

	static FInputTipsList()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInputTipsList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputTipsList));
	}
}
