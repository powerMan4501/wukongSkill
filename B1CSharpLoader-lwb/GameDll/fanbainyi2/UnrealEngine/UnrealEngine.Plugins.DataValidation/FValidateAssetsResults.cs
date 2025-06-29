using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataValidation;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DataValidation.ValidateAssetsResults", "DataValidation", UnrealModuleType.EnginePlugin)]
public struct FValidateAssetsResults
{
	private static bool NumChecked_IsValid;

	private static int NumChecked_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsResults:NumChecked")]
	public int NumChecked;

	private static bool NumValid_IsValid;

	private static int NumValid_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsResults:NumValid")]
	public int NumValid;

	private static bool NumInvalid_IsValid;

	private static int NumInvalid_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsResults:NumInvalid")]
	public int NumInvalid;

	private static bool NumSkipped_IsValid;

	private static int NumSkipped_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsResults:NumSkipped")]
	public int NumSkipped;

	private static bool NumWarnings_IsValid;

	private static int NumWarnings_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsResults:NumWarnings")]
	public int NumWarnings;

	private static bool NumUnableToValidate_IsValid;

	private static int NumUnableToValidate_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/DataValidation.ValidateAssetsResults:NumUnableToValidate")]
	public int NumUnableToValidate;

	private static bool FValidateAssetsResults_IsValid;

	private static int FValidateAssetsResults_StructSize;

	public FValidateAssetsResults Copy()
	{
		return this;
	}

	public static FValidateAssetsResults FromNative(IntPtr nativeBuffer)
	{
		return new FValidateAssetsResults(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FValidateAssetsResults value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FValidateAssetsResults FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FValidateAssetsResults(nativeBuffer + arrayIndex * FValidateAssetsResults_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FValidateAssetsResults value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FValidateAssetsResults_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FValidateAssetsResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataValidation.ValidateAssetsResults");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumChecked_Offset), NumChecked);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumValid_Offset), NumValid);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumInvalid_Offset), NumInvalid);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumSkipped_Offset), NumSkipped);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumWarnings_Offset), NumWarnings);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumUnableToValidate_Offset), NumUnableToValidate);
	}

	public FValidateAssetsResults(IntPtr nativeStruct)
	{
		if (!FValidateAssetsResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataValidation.ValidateAssetsResults");
			NumChecked = 0;
			NumValid = 0;
			NumInvalid = 0;
			NumSkipped = 0;
			NumWarnings = 0;
			NumUnableToValidate = 0;
		}
		else
		{
			NumChecked = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumChecked_Offset));
			NumValid = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumValid_Offset));
			NumInvalid = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumInvalid_Offset));
			NumSkipped = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumSkipped_Offset));
			NumWarnings = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumWarnings_Offset));
			NumUnableToValidate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumUnableToValidate_Offset));
		}
	}

	static FValidateAssetsResults()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FValidateAssetsResults)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FValidateAssetsResults));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataValidation.ValidateAssetsResults");
		FValidateAssetsResults_StructSize = NativeReflection.GetStructSize(intPtr);
		NumChecked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumChecked");
		NumChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumChecked", Classes.FIntProperty);
		NumValid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumValid");
		NumValid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumValid", Classes.FIntProperty);
		NumInvalid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumInvalid");
		NumInvalid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumInvalid", Classes.FIntProperty);
		NumSkipped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumSkipped");
		NumSkipped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumSkipped", Classes.FIntProperty);
		NumWarnings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumWarnings");
		NumWarnings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumWarnings", Classes.FIntProperty);
		NumUnableToValidate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumUnableToValidate");
		NumUnableToValidate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumUnableToValidate", Classes.FIntProperty);
		FValidateAssetsResults_IsValid = intPtr != IntPtr.Zero && NumChecked_IsValid && NumValid_IsValid && NumInvalid_IsValid && NumSkipped_IsValid && NumWarnings_IsValid && NumUnableToValidate_IsValid;
		NativeReflection.LogStructIsValid("/Script/DataValidation.ValidateAssetsResults", FValidateAssetsResults_IsValid);
	}
}
