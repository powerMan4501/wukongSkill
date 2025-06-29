using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryFramework;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryFramework.DynamicMeshChangeInfo", "GeometryFramework", UnrealModuleType.Engine)]
public struct FDynamicMeshChangeInfo
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshChangeInfo:Type")]
	public EDynamicMeshChangeType Type;

	private static bool Flags_IsValid;

	private static FFieldAddress Flags_PropertyAddress;

	private static int Flags_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshChangeInfo:Flags")]
	public EDynamicMeshAttributeChangeFlags Flags;

	private static bool IsRevertChange_IsValid;

	private static FFieldAddress IsRevertChange_PropertyAddress;

	private static int IsRevertChange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryFramework.DynamicMeshChangeInfo:bIsRevertChange")]
	public bool IsRevertChange;

	private static bool FDynamicMeshChangeInfo_IsValid;

	private static int FDynamicMeshChangeInfo_StructSize;

	public FDynamicMeshChangeInfo Copy()
	{
		return this;
	}

	public static FDynamicMeshChangeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FDynamicMeshChangeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDynamicMeshChangeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDynamicMeshChangeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDynamicMeshChangeInfo(nativeBuffer + arrayIndex * FDynamicMeshChangeInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDynamicMeshChangeInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDynamicMeshChangeInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDynamicMeshChangeInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryFramework.DynamicMeshChangeInfo");
			return;
		}
		EnumMarshaler<EDynamicMeshChangeType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		EnumMarshaler<EDynamicMeshAttributeChangeFlags>.ToNative(IntPtr.Add(nativeStruct, Flags_Offset), 0, Flags_PropertyAddress.Address, Flags);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRevertChange_Offset), 0, IsRevertChange_PropertyAddress.Address, IsRevertChange);
	}

	public FDynamicMeshChangeInfo(IntPtr nativeStruct)
	{
		if (!FDynamicMeshChangeInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryFramework.DynamicMeshChangeInfo");
			Type = EDynamicMeshChangeType.GeneralEdit;
			Flags = EDynamicMeshAttributeChangeFlags.Unknown;
			IsRevertChange = false;
		}
		else
		{
			Type = EnumMarshaler<EDynamicMeshChangeType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			Flags = EnumMarshaler<EDynamicMeshAttributeChangeFlags>.FromNative(IntPtr.Add(nativeStruct, Flags_Offset), 0, Flags_PropertyAddress.Address);
			IsRevertChange = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRevertChange_Offset), 0, IsRevertChange_PropertyAddress.Address);
		}
	}

	static FDynamicMeshChangeInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDynamicMeshChangeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDynamicMeshChangeInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryFramework.DynamicMeshChangeInfo");
		FDynamicMeshChangeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Flags_PropertyAddress, intPtr, "Flags");
		Flags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Flags");
		Flags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Flags", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRevertChange_PropertyAddress, intPtr, "bIsRevertChange");
		IsRevertChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsRevertChange");
		IsRevertChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsRevertChange", Classes.FBoolProperty);
		FDynamicMeshChangeInfo_IsValid = intPtr != IntPtr.Zero && Type_IsValid && Flags_IsValid && IsRevertChange_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryFramework.DynamicMeshChangeInfo", FDynamicMeshChangeInfo_IsValid);
	}
}
