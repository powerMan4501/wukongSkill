using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.FieldObjectCommands", "FieldSystemEngine", UnrealModuleType.Engine)]
public struct FFieldObjectCommands
{
	private static bool TargetNames_IsValid;

	private static FFieldAddress TargetNames_PropertyAddress;

	private static int TargetNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldObjectCommands:TargetNames")]
	public List<FName> TargetNames;

	private static bool RootNodes_IsValid;

	private static FFieldAddress RootNodes_PropertyAddress;

	private static int RootNodes_Offset;

	[UProperty(Flags = (PropFlags)5630049290027533uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldObjectCommands:RootNodes")]
	public List<UFieldNodeBase> RootNodes;

	private static bool MetaDatas_IsValid;

	private static FFieldAddress MetaDatas_PropertyAddress;

	private static int MetaDatas_Offset;

	[UProperty(Flags = (PropFlags)5630049290027533uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldObjectCommands:MetaDatas")]
	public List<UFieldSystemMetaData> MetaDatas;

	private static bool FFieldObjectCommands_IsValid;

	private static int FFieldObjectCommands_StructSize;

	public FFieldObjectCommands Copy()
	{
		FFieldObjectCommands result = this;
		if (TargetNames != null)
		{
			result.TargetNames = new List<FName>(TargetNames);
		}
		if (RootNodes != null)
		{
			result.RootNodes = new List<UFieldNodeBase>(RootNodes);
		}
		if (MetaDatas != null)
		{
			result.MetaDatas = new List<UFieldSystemMetaData>(MetaDatas);
		}
		return result;
	}

	public static FFieldObjectCommands FromNative(IntPtr nativeBuffer)
	{
		return new FFieldObjectCommands(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFieldObjectCommands value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFieldObjectCommands FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFieldObjectCommands(nativeBuffer + arrayIndex * FFieldObjectCommands_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFieldObjectCommands value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFieldObjectCommands_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFieldObjectCommands_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FieldSystemEngine.FieldObjectCommands");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, TargetNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TargetNames_Offset), TargetNames);
		new TArrayCopyMarshaler<UFieldNodeBase>(1, RootNodes_PropertyAddress, CachedMarshalingDelegates<UFieldNodeBase, UObjectMarshaler<UFieldNodeBase>>.FromNative, CachedMarshalingDelegates<UFieldNodeBase, UObjectMarshaler<UFieldNodeBase>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RootNodes_Offset), RootNodes);
		new TArrayCopyMarshaler<UFieldSystemMetaData>(1, MetaDatas_PropertyAddress, CachedMarshalingDelegates<UFieldSystemMetaData, UObjectMarshaler<UFieldSystemMetaData>>.FromNative, CachedMarshalingDelegates<UFieldSystemMetaData, UObjectMarshaler<UFieldSystemMetaData>>.ToNative).ToNative(IntPtr.Add(nativeStruct, MetaDatas_Offset), MetaDatas);
	}

	public FFieldObjectCommands(IntPtr nativeStruct)
	{
		if (!FFieldObjectCommands_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FieldSystemEngine.FieldObjectCommands");
			TargetNames = null;
			RootNodes = null;
			MetaDatas = null;
		}
		else
		{
			TargetNames = new TArrayCopyMarshaler<FName>(1, TargetNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TargetNames_Offset));
			RootNodes = new TArrayCopyMarshaler<UFieldNodeBase>(1, RootNodes_PropertyAddress, CachedMarshalingDelegates<UFieldNodeBase, UObjectMarshaler<UFieldNodeBase>>.FromNative, CachedMarshalingDelegates<UFieldNodeBase, UObjectMarshaler<UFieldNodeBase>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RootNodes_Offset));
			MetaDatas = new TArrayCopyMarshaler<UFieldSystemMetaData>(1, MetaDatas_PropertyAddress, CachedMarshalingDelegates<UFieldSystemMetaData, UObjectMarshaler<UFieldSystemMetaData>>.FromNative, CachedMarshalingDelegates<UFieldSystemMetaData, UObjectMarshaler<UFieldSystemMetaData>>.ToNative).FromNative(IntPtr.Add(nativeStruct, MetaDatas_Offset));
		}
	}

	static FFieldObjectCommands()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFieldObjectCommands)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFieldObjectCommands));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FieldSystemEngine.FieldObjectCommands");
		FFieldObjectCommands_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TargetNames_PropertyAddress, intPtr, "TargetNames");
		TargetNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetNames");
		TargetNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RootNodes_PropertyAddress, intPtr, "RootNodes");
		RootNodes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RootNodes");
		RootNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RootNodes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MetaDatas_PropertyAddress, intPtr, "MetaDatas");
		MetaDatas_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetaDatas");
		MetaDatas_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetaDatas", Classes.FArrayProperty);
		FFieldObjectCommands_IsValid = intPtr != IntPtr.Zero && TargetNames_IsValid && RootNodes_IsValid && MetaDatas_IsValid;
		NativeReflection.LogStructIsValid("/Script/FieldSystemEngine.FieldObjectCommands", FFieldObjectCommands_IsValid);
	}
}
