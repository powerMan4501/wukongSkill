using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MM.InputPlayerDirectionData", "MM", UnrealModuleType.GamePlugin)]
public struct FInputPlayerDirectionData
{
	private static bool DirectionalPointsArray_IsValid;

	private static FFieldAddress DirectionalPointsArray_PropertyAddress;

	private static int DirectionalPointsArray_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MM.InputPlayerDirectionData:DirectionalPointsArray")]
	public List<FPlayerDirectionInput> DirectionalPointsArray;

	private static bool FinishVector_IsValid;

	private static int FinishVector_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MM.InputPlayerDirectionData:FinishVector")]
	public FVector FinishVector;

	private static bool FInputPlayerDirectionData_IsValid;

	private static int FInputPlayerDirectionData_StructSize;

	public FInputPlayerDirectionData Copy()
	{
		FInputPlayerDirectionData result = this;
		if (DirectionalPointsArray != null)
		{
			result.DirectionalPointsArray = new List<FPlayerDirectionInput>(DirectionalPointsArray);
		}
		return result;
	}

	public static FInputPlayerDirectionData FromNative(IntPtr nativeBuffer)
	{
		return new FInputPlayerDirectionData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputPlayerDirectionData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputPlayerDirectionData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputPlayerDirectionData(nativeBuffer + arrayIndex * FInputPlayerDirectionData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputPlayerDirectionData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputPlayerDirectionData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputPlayerDirectionData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.InputPlayerDirectionData");
			return;
		}
		new TArrayCopyMarshaler<FPlayerDirectionInput>(1, DirectionalPointsArray_PropertyAddress, CachedMarshalingDelegates<FPlayerDirectionInput, FPlayerDirectionInput>.FromNative, CachedMarshalingDelegates<FPlayerDirectionInput, FPlayerDirectionInput>.ToNative).ToNative(IntPtr.Add(nativeStruct, DirectionalPointsArray_Offset), DirectionalPointsArray);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, FinishVector_Offset), FinishVector);
	}

	public FInputPlayerDirectionData(IntPtr nativeStruct)
	{
		if (!FInputPlayerDirectionData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MM.InputPlayerDirectionData");
			DirectionalPointsArray = null;
			FinishVector = default(FVector);
		}
		else
		{
			DirectionalPointsArray = new TArrayCopyMarshaler<FPlayerDirectionInput>(1, DirectionalPointsArray_PropertyAddress, CachedMarshalingDelegates<FPlayerDirectionInput, FPlayerDirectionInput>.FromNative, CachedMarshalingDelegates<FPlayerDirectionInput, FPlayerDirectionInput>.ToNative).FromNative(IntPtr.Add(nativeStruct, DirectionalPointsArray_Offset));
			FinishVector = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, FinishVector_Offset));
		}
	}

	static FInputPlayerDirectionData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputPlayerDirectionData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputPlayerDirectionData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MM.InputPlayerDirectionData");
		FInputPlayerDirectionData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DirectionalPointsArray_PropertyAddress, intPtr, "DirectionalPointsArray");
		DirectionalPointsArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectionalPointsArray");
		DirectionalPointsArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectionalPointsArray", Classes.FArrayProperty);
		FinishVector_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinishVector");
		FinishVector_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinishVector", Classes.FStructProperty);
		FInputPlayerDirectionData_IsValid = intPtr != IntPtr.Zero && DirectionalPointsArray_IsValid && FinishVector_IsValid;
		NativeReflection.LogStructIsValid("/Script/MM.InputPlayerDirectionData", FInputPlayerDirectionData_IsValid);
	}
}
