using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.TextFoldingConfig", "UnrealExtent", UnrealModuleType.Game)]
public struct FTextFoldingConfig
{
	private static bool BeginIndex_IsValid;

	private static int BeginIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.TextFoldingConfig:BeginIndex")]
	public int BeginIndex;

	private static bool EndIndex_IsValid;

	private static int EndIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.TextFoldingConfig:EndIndex")]
	public int EndIndex;

	private static bool DisplayWidth_IsValid;

	private static int DisplayWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.TextFoldingConfig:DisplayWidth")]
	public int DisplayWidth;

	private static bool SubstituteString_IsValid;

	private static int SubstituteString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.TextFoldingConfig:SubstituteString")]
	public string SubstituteString;

	private static bool FTextFoldingConfig_IsValid;

	private static int FTextFoldingConfig_StructSize;

	public FTextFoldingConfig Copy()
	{
		return this;
	}

	public static FTextFoldingConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTextFoldingConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTextFoldingConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTextFoldingConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTextFoldingConfig(nativeBuffer + arrayIndex * FTextFoldingConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTextFoldingConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTextFoldingConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTextFoldingConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.TextFoldingConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BeginIndex_Offset), BeginIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndIndex_Offset), EndIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DisplayWidth_Offset), DisplayWidth);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SubstituteString_Offset), SubstituteString);
	}

	public FTextFoldingConfig(IntPtr nativeStruct)
	{
		if (!FTextFoldingConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.TextFoldingConfig");
			BeginIndex = 0;
			EndIndex = 0;
			DisplayWidth = 0;
			SubstituteString = FStringMarshaler.DefaultString;
		}
		else
		{
			BeginIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BeginIndex_Offset));
			EndIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndIndex_Offset));
			DisplayWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DisplayWidth_Offset));
			SubstituteString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SubstituteString_Offset));
		}
	}

	static FTextFoldingConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTextFoldingConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTextFoldingConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.TextFoldingConfig");
		FTextFoldingConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		BeginIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BeginIndex");
		BeginIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BeginIndex", Classes.FIntProperty);
		EndIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndIndex");
		EndIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndIndex", Classes.FIntProperty);
		DisplayWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplayWidth");
		DisplayWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplayWidth", Classes.FIntProperty);
		SubstituteString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubstituteString");
		SubstituteString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubstituteString", Classes.FStrProperty);
		FTextFoldingConfig_IsValid = intPtr != IntPtr.Zero && BeginIndex_IsValid && EndIndex_IsValid && DisplayWidth_IsValid && SubstituteString_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.TextFoldingConfig", FTextFoldingConfig_IsValid);
	}
}
