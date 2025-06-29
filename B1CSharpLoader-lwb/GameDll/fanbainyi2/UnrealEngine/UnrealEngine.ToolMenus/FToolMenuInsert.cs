using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuInsert", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuInsert
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuInsert:Name")]
	public FName Name;

	private static bool Position_IsValid;

	private static FFieldAddress Position_PropertyAddress;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuInsert:Position")]
	public EToolMenuInsertType Position;

	private static bool FToolMenuInsert_IsValid;

	private static int FToolMenuInsert_StructSize;

	public FToolMenuInsert Copy()
	{
		return this;
	}

	public static FToolMenuInsert FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuInsert(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuInsert value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuInsert FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuInsert(nativeBuffer + arrayIndex * FToolMenuInsert_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuInsert value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuInsert_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuInsert_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuInsert");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<EToolMenuInsertType>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), 0, Position_PropertyAddress.Address, Position);
	}

	public FToolMenuInsert(IntPtr nativeStruct)
	{
		if (!FToolMenuInsert_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuInsert");
			Name = default(FName);
			Position = EToolMenuInsertType.Default;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Position = EnumMarshaler<EToolMenuInsertType>.FromNative(IntPtr.Add(nativeStruct, Position_Offset), 0, Position_PropertyAddress.Address);
		}
	}

	static FToolMenuInsert()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuInsert)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuInsert));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuInsert");
		FToolMenuInsert_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Position_PropertyAddress, intPtr, "Position");
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FEnumProperty);
		FToolMenuInsert_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Position_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuInsert", FToolMenuInsert_IsValid);
	}
}
