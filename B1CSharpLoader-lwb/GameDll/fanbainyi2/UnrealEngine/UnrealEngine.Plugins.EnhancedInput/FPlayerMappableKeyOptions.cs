using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.PlayerMappableKeyOptions", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public struct FPlayerMappableKeyOptions
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableKeyOptions:Name")]
	public FName Name;

	private static bool DisplayName_IsValid;

	private static int DisplayName_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableKeyOptions:DisplayName")]
	public FText DisplayName;

	private static bool DisplayCategory_IsValid;

	private static int DisplayCategory_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/EnhancedInput.PlayerMappableKeyOptions:DisplayCategory")]
	public FText DisplayCategory;

	private static bool FPlayerMappableKeyOptions_IsValid;

	private static int FPlayerMappableKeyOptions_StructSize;

	public FPlayerMappableKeyOptions Copy()
	{
		return this;
	}

	public static FPlayerMappableKeyOptions FromNative(IntPtr nativeBuffer)
	{
		return new FPlayerMappableKeyOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPlayerMappableKeyOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPlayerMappableKeyOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPlayerMappableKeyOptions(nativeBuffer + arrayIndex * FPlayerMappableKeyOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPlayerMappableKeyOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPlayerMappableKeyOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPlayerMappableKeyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.PlayerMappableKeyOptions");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayName_Offset), DisplayName);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, DisplayCategory_Offset), DisplayCategory);
	}

	public FPlayerMappableKeyOptions(IntPtr nativeStruct)
	{
		if (!FPlayerMappableKeyOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.PlayerMappableKeyOptions");
			Name = default(FName);
			DisplayName = null;
			DisplayCategory = null;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			DisplayName = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayName_Offset));
			DisplayCategory = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, DisplayCategory_Offset));
		}
	}

	static FPlayerMappableKeyOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPlayerMappableKeyOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPlayerMappableKeyOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EnhancedInput.PlayerMappableKeyOptions");
		FPlayerMappableKeyOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayName");
		DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayName", Classes.FTextProperty);
		DisplayCategory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayCategory");
		DisplayCategory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayCategory", Classes.FTextProperty);
		FPlayerMappableKeyOptions_IsValid = intPtr != IntPtr.Zero && Name_IsValid && DisplayName_IsValid && DisplayCategory_IsValid;
		NativeReflection.LogStructIsValid("/Script/EnhancedInput.PlayerMappableKeyOptions", FPlayerMappableKeyOptions_IsValid);
	}
}
