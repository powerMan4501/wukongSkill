using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSDataTableRowHandle")]
public struct FGSDataTableRowHandle
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSDataTableRowHandle:RowName")]
	public FName RowName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSDataTableRowHandle:DataTable")]
	public UDataTable DataTable;

	private static int FGSDataTableRowHandle_StructSize;

	private static int FGSDataTableRowHandle_IsValid;

	private static bool RowName_IsValid;

	private static int RowName_Offset;

	private static bool DataTable_IsValid;

	private static int DataTable_Offset;

	public FGSDataTableRowHandle(FName RowNameValue, UDataTable DataTableValue)
	{
		RowName = RowNameValue;
		DataTable = DataTableValue;
	}

	public FGSDataTableRowHandle Copy()
	{
		return this;
	}

	public static FGSDataTableRowHandle FromNative(IntPtr nativeBuffer)
	{
		return new FGSDataTableRowHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSDataTableRowHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSDataTableRowHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSDataTableRowHandle(IntPtr.Add(nativeBuffer, arrayIndex * FGSDataTableRowHandle_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSDataTableRowHandle value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSDataTableRowHandle_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSDataTableRowHandle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSDataTableRowHandle");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RowName_Offset), RowName);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(nativeStruct, DataTable_Offset), DataTable);
	}

	public FGSDataTableRowHandle(IntPtr nativeStruct)
	{
		if (FGSDataTableRowHandle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSDataTableRowHandle");
			RowName = default(FName);
			DataTable = null;
		}
		else
		{
			RowName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RowName_Offset));
			DataTable = UObjectMarshaler<UDataTable>.FromNative(IntPtr.Add(nativeStruct, DataTable_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSDataTableRowHandle");
		FGSDataTableRowHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		RowName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RowName");
		RowName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RowName", Classes.FNameProperty);
		DataTable_Offset = NativeReflection.GetPropertyOffset(intPtr, "DataTable");
		DataTable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DataTable", Classes.FObjectProperty);
		FGSDataTableRowHandle_IsValid = ((intPtr != IntPtr.Zero && RowName_IsValid && DataTable_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSDataTableRowHandle", (byte)FGSDataTableRowHandle_IsValid != 0);
	}

	static FGSDataTableRowHandle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSDataTableRowHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSDataTableRowHandle));
	}
}
