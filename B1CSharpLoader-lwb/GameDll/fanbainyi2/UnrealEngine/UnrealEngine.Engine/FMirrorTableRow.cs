using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MirrorTableRow", "Engine", UnrealModuleType.Engine)]
public struct FMirrorTableRow
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.MirrorTableRow:Name")]
	public FName Name;

	private static bool MirroredName_IsValid;

	private static int MirroredName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.MirrorTableRow:MirroredName")]
	public FName MirroredName;

	private static bool MirrorEntryType_IsValid;

	private static FFieldAddress MirrorEntryType_PropertyAddress;

	private static int MirrorEntryType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.MirrorTableRow:MirrorEntryType")]
	public EMirrorRowType MirrorEntryType;

	private static bool FMirrorTableRow_IsValid;

	private static int FMirrorTableRow_StructSize;

	public FMirrorTableRow Copy()
	{
		return this;
	}

	public static FMirrorTableRow FromNative(IntPtr nativeBuffer)
	{
		return new FMirrorTableRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMirrorTableRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMirrorTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMirrorTableRow(nativeBuffer + arrayIndex * FMirrorTableRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMirrorTableRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMirrorTableRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMirrorTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MirrorTableRow");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MirroredName_Offset), MirroredName);
		EnumMarshaler<EMirrorRowType>.ToNative(IntPtr.Add(nativeStruct, MirrorEntryType_Offset), 0, MirrorEntryType_PropertyAddress.Address, MirrorEntryType);
	}

	public FMirrorTableRow(IntPtr nativeStruct)
	{
		if (!FMirrorTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MirrorTableRow");
			Name = default(FName);
			MirroredName = default(FName);
			MirrorEntryType = EMirrorRowType.Bone;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			MirroredName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MirroredName_Offset));
			MirrorEntryType = EnumMarshaler<EMirrorRowType>.FromNative(IntPtr.Add(nativeStruct, MirrorEntryType_Offset), 0, MirrorEntryType_PropertyAddress.Address);
		}
	}

	static FMirrorTableRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMirrorTableRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMirrorTableRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MirrorTableRow");
		FMirrorTableRow_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		MirroredName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MirroredName");
		MirroredName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MirroredName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MirrorEntryType_PropertyAddress, intPtr, "MirrorEntryType");
		MirrorEntryType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MirrorEntryType");
		MirrorEntryType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MirrorEntryType", Classes.FByteProperty);
		FMirrorTableRow_IsValid = intPtr != IntPtr.Zero && Name_IsValid && MirroredName_IsValid && MirrorEntryType_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MirrorTableRow", FMirrorTableRow_IsValid);
	}
}
