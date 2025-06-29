using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.ModifyContextOptions", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public struct FModifyContextOptions
{
	private static bool IgnoreAllPressedKeysUntilRelease_IsValid;

	private static FFieldAddress IgnoreAllPressedKeysUntilRelease_PropertyAddress;

	private static int IgnoreAllPressedKeysUntilRelease_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/EnhancedInput.ModifyContextOptions:bIgnoreAllPressedKeysUntilRelease")]
	public bool IgnoreAllPressedKeysUntilRelease;

	private static bool ForceImmediately_IsValid;

	private static FFieldAddress ForceImmediately_PropertyAddress;

	private static int ForceImmediately_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/EnhancedInput.ModifyContextOptions:bForceImmediately")]
	public bool ForceImmediately;

	private static bool FModifyContextOptions_IsValid;

	private static int FModifyContextOptions_StructSize;

	public FModifyContextOptions Copy()
	{
		return this;
	}

	public static FModifyContextOptions FromNative(IntPtr nativeBuffer)
	{
		return new FModifyContextOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FModifyContextOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FModifyContextOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FModifyContextOptions(nativeBuffer + arrayIndex * FModifyContextOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FModifyContextOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FModifyContextOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FModifyContextOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.ModifyContextOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreAllPressedKeysUntilRelease_Offset), 0, IgnoreAllPressedKeysUntilRelease_PropertyAddress.Address, IgnoreAllPressedKeysUntilRelease);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceImmediately_Offset), 0, ForceImmediately_PropertyAddress.Address, ForceImmediately);
	}

	public FModifyContextOptions(IntPtr nativeStruct)
	{
		if (!FModifyContextOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.ModifyContextOptions");
			IgnoreAllPressedKeysUntilRelease = false;
			ForceImmediately = false;
		}
		else
		{
			IgnoreAllPressedKeysUntilRelease = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreAllPressedKeysUntilRelease_Offset), 0, IgnoreAllPressedKeysUntilRelease_PropertyAddress.Address);
			ForceImmediately = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceImmediately_Offset), 0, ForceImmediately_PropertyAddress.Address);
		}
	}

	static FModifyContextOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FModifyContextOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FModifyContextOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EnhancedInput.ModifyContextOptions");
		FModifyContextOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IgnoreAllPressedKeysUntilRelease_PropertyAddress, intPtr, "bIgnoreAllPressedKeysUntilRelease");
		IgnoreAllPressedKeysUntilRelease_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreAllPressedKeysUntilRelease");
		IgnoreAllPressedKeysUntilRelease_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreAllPressedKeysUntilRelease", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceImmediately_PropertyAddress, intPtr, "bForceImmediately");
		ForceImmediately_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceImmediately");
		ForceImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceImmediately", Classes.FBoolProperty);
		FModifyContextOptions_IsValid = intPtr != IntPtr.Zero && IgnoreAllPressedKeysUntilRelease_IsValid && ForceImmediately_IsValid;
		NativeReflection.LogStructIsValid("/Script/EnhancedInput.ModifyContextOptions", FModifyContextOptions_IsValid);
	}
}
