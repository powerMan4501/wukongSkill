using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.InputTipsCfg")]
public struct FInputTipsCfg
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("常显Tips")]
	[USharpPath("/Script/b1-Managed.InputTipsCfg:AwalysShowInput")]
	public FInputTipsList AwalysShowInput;

	[UProperty]
	[DisplayName("条件显示Tips")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InputTipsCfg:OptionShowInput")]
	public Dictionary<EInputTipsType, FInputTipsList> OptionShowInput;

	private static int InputTipsCfg_StructSize;

	private static int InputTipsCfg_IsValid;

	private static bool AwalysShowInput_IsValid;

	private static int AwalysShowInput_Offset;

	private static bool OptionShowInput_IsValid;

	private static int OptionShowInput_Offset;

	private static FFieldAddress OptionShowInput_PropertyAddress;

	public FInputTipsCfg Copy()
	{
		FInputTipsCfg result = this;
		if (OptionShowInput != null)
		{
			result.OptionShowInput = new Dictionary<EInputTipsType, FInputTipsList>(OptionShowInput);
		}
		return result;
	}

	public static FInputTipsCfg FromNative(IntPtr nativeBuffer)
	{
		return new FInputTipsCfg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputTipsCfg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputTipsCfg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputTipsCfg(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsCfg_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputTipsCfg value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputTipsCfg_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputTipsCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsCfg");
			return;
		}
		FInputTipsList.ToNative(IntPtr.Add(nativeStruct, AwalysShowInput_Offset), AwalysShowInput);
		new TMapCopyMarshaler<EInputTipsType, FInputTipsList>(1, OptionShowInput_PropertyAddress, CachedMarshalingDelegates<EInputTipsType, EnumMarshaler<EInputTipsType>>.FromNative, CachedMarshalingDelegates<EInputTipsType, EnumMarshaler<EInputTipsType>>.ToNative, CachedMarshalingDelegates<FInputTipsList, FInputTipsList>.FromNative, CachedMarshalingDelegates<FInputTipsList, FInputTipsList>.ToNative).ToNative(IntPtr.Add(nativeStruct, OptionShowInput_Offset), OptionShowInput);
	}

	public FInputTipsCfg(IntPtr nativeStruct)
	{
		if (InputTipsCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputTipsCfg");
			AwalysShowInput = default(FInputTipsList);
			OptionShowInput = null;
		}
		else
		{
			AwalysShowInput = FInputTipsList.FromNative(IntPtr.Add(nativeStruct, AwalysShowInput_Offset));
			OptionShowInput = new TMapCopyMarshaler<EInputTipsType, FInputTipsList>(1, OptionShowInput_PropertyAddress, CachedMarshalingDelegates<EInputTipsType, EnumMarshaler<EInputTipsType>>.FromNative, CachedMarshalingDelegates<EInputTipsType, EnumMarshaler<EInputTipsType>>.ToNative, CachedMarshalingDelegates<FInputTipsList, FInputTipsList>.FromNative, CachedMarshalingDelegates<FInputTipsList, FInputTipsList>.ToNative).FromNative(IntPtr.Add(nativeStruct, OptionShowInput_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputTipsCfg");
		InputTipsCfg_StructSize = NativeReflection.GetStructSize(intPtr);
		AwalysShowInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "AwalysShowInput");
		AwalysShowInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AwalysShowInput", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OptionShowInput_PropertyAddress, intPtr, "OptionShowInput");
		OptionShowInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "OptionShowInput");
		OptionShowInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OptionShowInput", Classes.FMapProperty);
		InputTipsCfg_IsValid = ((intPtr != IntPtr.Zero && AwalysShowInput_IsValid && OptionShowInput_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputTipsCfg", (byte)InputTipsCfg_IsValid != 0);
	}

	static FInputTipsCfg()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInputTipsCfg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputTipsCfg));
	}
}
