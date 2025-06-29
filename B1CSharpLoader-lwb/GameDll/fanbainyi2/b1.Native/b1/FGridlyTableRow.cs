using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GridlyTableRow", "UnrealExtent", UnrealModuleType.Game)]
public struct FGridlyTableRow
{
	private static bool Id_IsValid;

	private static int Id_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/UnrealExtent.GridlyTableRow:Id")]
	public string Id;

	private static bool Path_IsValid;

	private static int Path_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/UnrealExtent.GridlyTableRow:Path")]
	public string Path;

	private static bool Cells_IsValid;

	private static FFieldAddress Cells_PropertyAddress;

	private static int Cells_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/UnrealExtent.GridlyTableRow:Cells")]
	public List<FGridlyTableCell> Cells;

	private static bool FGridlyTableRow_IsValid;

	private static int FGridlyTableRow_StructSize;

	public FGridlyTableRow Copy()
	{
		FGridlyTableRow result = this;
		if (Cells != null)
		{
			result.Cells = new List<FGridlyTableCell>(Cells);
		}
		return result;
	}

	public static FGridlyTableRow FromNative(IntPtr nativeBuffer)
	{
		return new FGridlyTableRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGridlyTableRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGridlyTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGridlyTableRow(nativeBuffer + arrayIndex * FGridlyTableRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGridlyTableRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGridlyTableRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGridlyTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GridlyTableRow");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Id_Offset), Id);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Path_Offset), Path);
		new TArrayCopyMarshaler<FGridlyTableCell>(1, Cells_PropertyAddress, CachedMarshalingDelegates<FGridlyTableCell, FGridlyTableCell>.FromNative, CachedMarshalingDelegates<FGridlyTableCell, FGridlyTableCell>.ToNative).ToNative(IntPtr.Add(nativeStruct, Cells_Offset), Cells);
	}

	public FGridlyTableRow(IntPtr nativeStruct)
	{
		if (!FGridlyTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GridlyTableRow");
			Id = FStringMarshaler.DefaultString;
			Path = FStringMarshaler.DefaultString;
			Cells = null;
		}
		else
		{
			Id = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Id_Offset));
			Path = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Path_Offset));
			Cells = new TArrayCopyMarshaler<FGridlyTableCell>(1, Cells_PropertyAddress, CachedMarshalingDelegates<FGridlyTableCell, FGridlyTableCell>.FromNative, CachedMarshalingDelegates<FGridlyTableCell, FGridlyTableCell>.ToNative).FromNative(IntPtr.Add(nativeStruct, Cells_Offset));
		}
	}

	static FGridlyTableRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGridlyTableRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGridlyTableRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GridlyTableRow");
		FGridlyTableRow_StructSize = NativeReflection.GetStructSize(intPtr);
		Id_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Id");
		Id_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Id", Classes.FStrProperty);
		Path_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Path");
		Path_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Cells_PropertyAddress, intPtr, "Cells");
		Cells_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Cells");
		Cells_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Cells", Classes.FArrayProperty);
		FGridlyTableRow_IsValid = intPtr != IntPtr.Zero && Id_IsValid && Path_IsValid && Cells_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GridlyTableRow", FGridlyTableRow_IsValid);
	}
}
