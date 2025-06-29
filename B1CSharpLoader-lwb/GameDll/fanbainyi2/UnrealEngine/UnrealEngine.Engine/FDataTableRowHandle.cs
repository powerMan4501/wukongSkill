using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.DataTableRowHandle", "Engine", UnrealModuleType.Engine)]
public struct FDataTableRowHandle
{
	private static bool DataTable_IsValid;

	private static int DataTable_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.DataTableRowHandle:DataTable")]
	public UDataTable DataTable;

	private static bool RowName_IsValid;

	private static int RowName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DataTableRowHandle:RowName")]
	public FName RowName;

	private static bool FDataTableRowHandle_IsValid;

	private static int FDataTableRowHandle_StructSize;

	public FDataTableRowHandle Copy()
	{
		return this;
	}

	public static FDataTableRowHandle FromNative(IntPtr nativeBuffer)
	{
		return new FDataTableRowHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDataTableRowHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDataTableRowHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDataTableRowHandle(nativeBuffer + arrayIndex * FDataTableRowHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDataTableRowHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDataTableRowHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDataTableRowHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DataTableRowHandle");
			return;
		}
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(nativeStruct, DataTable_Offset), DataTable);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RowName_Offset), RowName);
	}

	public FDataTableRowHandle(IntPtr nativeStruct)
	{
		if (!FDataTableRowHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DataTableRowHandle");
			DataTable = null;
			RowName = default(FName);
		}
		else
		{
			DataTable = UObjectMarshaler<UDataTable>.FromNative(IntPtr.Add(nativeStruct, DataTable_Offset));
			RowName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RowName_Offset));
		}
	}

	static FDataTableRowHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDataTableRowHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDataTableRowHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DataTableRowHandle");
		FDataTableRowHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		DataTable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataTable");
		DataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataTable", Classes.FObjectProperty);
		RowName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RowName");
		RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RowName", Classes.FNameProperty);
		FDataTableRowHandle_IsValid = intPtr != IntPtr.Zero && DataTable_IsValid && RowName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.DataTableRowHandle", FDataTableRowHandle_IsValid);
	}
}
