using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GridlyTableCell", "UnrealExtent", UnrealModuleType.Game)]
public struct FGridlyTableCell
{
	private static bool ColumnId_IsValid;

	private static int ColumnId_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/UnrealExtent.GridlyTableCell:ColumnId")]
	public string ColumnId;

	private static bool DependencyStatus_IsValid;

	private static int DependencyStatus_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/UnrealExtent.GridlyTableCell:DependencyStatus")]
	public string DependencyStatus;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/UnrealExtent.GridlyTableCell:Value")]
	public string Value;

	private static bool FGridlyTableCell_IsValid;

	private static int FGridlyTableCell_StructSize;

	public FGridlyTableCell Copy()
	{
		return this;
	}

	public static FGridlyTableCell FromNative(IntPtr nativeBuffer)
	{
		return new FGridlyTableCell(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGridlyTableCell value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGridlyTableCell FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGridlyTableCell(nativeBuffer + arrayIndex * FGridlyTableCell_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGridlyTableCell value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGridlyTableCell_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGridlyTableCell_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GridlyTableCell");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ColumnId_Offset), ColumnId);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DependencyStatus_Offset), DependencyStatus);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FGridlyTableCell(IntPtr nativeStruct)
	{
		if (!FGridlyTableCell_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GridlyTableCell");
			ColumnId = FStringMarshaler.DefaultString;
			DependencyStatus = FStringMarshaler.DefaultString;
			Value = FStringMarshaler.DefaultString;
		}
		else
		{
			ColumnId = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ColumnId_Offset));
			DependencyStatus = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DependencyStatus_Offset));
			Value = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FGridlyTableCell()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGridlyTableCell)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGridlyTableCell));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GridlyTableCell");
		FGridlyTableCell_StructSize = NativeReflection.GetStructSize(intPtr);
		ColumnId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColumnId");
		ColumnId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColumnId", Classes.FStrProperty);
		DependencyStatus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DependencyStatus");
		DependencyStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DependencyStatus", Classes.FStrProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStrProperty);
		FGridlyTableCell_IsValid = intPtr != IntPtr.Zero && ColumnId_IsValid && DependencyStatus_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GridlyTableCell", FGridlyTableCell_IsValid);
	}
}
