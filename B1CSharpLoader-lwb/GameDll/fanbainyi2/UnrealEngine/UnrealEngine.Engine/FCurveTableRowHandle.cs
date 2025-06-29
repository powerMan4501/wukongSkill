using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveTableRowHandle", "Engine", UnrealModuleType.Engine)]
public struct FCurveTableRowHandle
{
	private static bool CurveTable_IsValid;

	private static int CurveTable_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.CurveTableRowHandle:CurveTable")]
	public UCurveTable CurveTable;

	private static bool RowName_IsValid;

	private static int RowName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CurveTableRowHandle:RowName")]
	public FName RowName;

	private static bool FCurveTableRowHandle_IsValid;

	private static int FCurveTableRowHandle_StructSize;

	public FCurveTableRowHandle Copy()
	{
		return this;
	}

	public static FCurveTableRowHandle FromNative(IntPtr nativeBuffer)
	{
		return new FCurveTableRowHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCurveTableRowHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCurveTableRowHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCurveTableRowHandle(nativeBuffer + arrayIndex * FCurveTableRowHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCurveTableRowHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCurveTableRowHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCurveTableRowHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveTableRowHandle");
			return;
		}
		UObjectMarshaler<UCurveTable>.ToNative(IntPtr.Add(nativeStruct, CurveTable_Offset), CurveTable);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RowName_Offset), RowName);
	}

	public FCurveTableRowHandle(IntPtr nativeStruct)
	{
		if (!FCurveTableRowHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CurveTableRowHandle");
			CurveTable = null;
			RowName = default(FName);
		}
		else
		{
			CurveTable = UObjectMarshaler<UCurveTable>.FromNative(IntPtr.Add(nativeStruct, CurveTable_Offset));
			RowName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RowName_Offset));
		}
	}

	static FCurveTableRowHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCurveTableRowHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCurveTableRowHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CurveTableRowHandle");
		FCurveTableRowHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		CurveTable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveTable");
		CurveTable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveTable", Classes.FObjectProperty);
		RowName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RowName");
		RowName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RowName", Classes.FNameProperty);
		FCurveTableRowHandle_IsValid = intPtr != IntPtr.Zero && CurveTable_IsValid && RowName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CurveTableRowHandle", FCurveTableRowHandle_IsValid);
	}
}
