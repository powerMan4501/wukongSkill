using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.DataTableCategoryHandle", "Engine", UnrealModuleType.Engine)]
public struct FDataTableCategoryHandle
{
	private static bool DataTable_IsValid;

	private static int DataTable_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.DataTableCategoryHandle:DataTable")]
	public UDataTable DataTable;

	private static bool ColumnName_IsValid;

	private static int ColumnName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DataTableCategoryHandle:ColumnName")]
	public FName ColumnName;

	private static bool RowContents_IsValid;

	private static int RowContents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DataTableCategoryHandle:RowContents")]
	public FName RowContents;

	private static bool FDataTableCategoryHandle_IsValid;

	private static int FDataTableCategoryHandle_StructSize;

	public FDataTableCategoryHandle Copy()
	{
		return this;
	}

	public static FDataTableCategoryHandle FromNative(IntPtr nativeBuffer)
	{
		return new FDataTableCategoryHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDataTableCategoryHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDataTableCategoryHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDataTableCategoryHandle(nativeBuffer + arrayIndex * FDataTableCategoryHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDataTableCategoryHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDataTableCategoryHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDataTableCategoryHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DataTableCategoryHandle");
			return;
		}
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(nativeStruct, DataTable_Offset), DataTable);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ColumnName_Offset), ColumnName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RowContents_Offset), RowContents);
	}

	public FDataTableCategoryHandle(IntPtr nativeStruct)
	{
		if (!FDataTableCategoryHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DataTableCategoryHandle");
			DataTable = null;
			ColumnName = default(FName);
			RowContents = default(FName);
		}
		else
		{
			DataTable = UObjectMarshaler<UDataTable>.FromNative(IntPtr.Add(nativeStruct, DataTable_Offset));
			ColumnName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ColumnName_Offset));
			RowContents = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RowContents_Offset));
		}
	}

	static FDataTableCategoryHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDataTableCategoryHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDataTableCategoryHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DataTableCategoryHandle");
		FDataTableCategoryHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		DataTable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataTable");
		DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataTable", Classes.FObjectProperty);
		ColumnName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColumnName");
		ColumnName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColumnName", Classes.FNameProperty);
		RowContents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RowContents");
		RowContents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RowContents", Classes.FNameProperty);
		FDataTableCategoryHandle_IsValid = intPtr != IntPtr.Zero && DataTable_IsValid && ColumnName_IsValid && RowContents_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.DataTableCategoryHandle", FDataTableCategoryHandle_IsValid);
	}
}
