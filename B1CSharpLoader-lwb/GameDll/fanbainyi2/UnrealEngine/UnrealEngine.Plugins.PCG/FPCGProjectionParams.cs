using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGProjectionParams", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGProjectionParams
{
	private static bool ProjectPositions_IsValid;

	private static FFieldAddress ProjectPositions_PropertyAddress;

	private static int ProjectPositions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGProjectionParams:bProjectPositions")]
	public bool ProjectPositions;

	private static bool ProjectRotations_IsValid;

	private static FFieldAddress ProjectRotations_PropertyAddress;

	private static int ProjectRotations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGProjectionParams:bProjectRotations")]
	public bool ProjectRotations;

	private static bool ProjectScales_IsValid;

	private static FFieldAddress ProjectScales_PropertyAddress;

	private static int ProjectScales_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGProjectionParams:bProjectScales")]
	public bool ProjectScales;

	private static bool ProjectColors_IsValid;

	private static FFieldAddress ProjectColors_PropertyAddress;

	private static int ProjectColors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGProjectionParams:bProjectColors")]
	public bool ProjectColors;

	private static bool AttributeList_IsValid;

	private static int AttributeList_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/PCG.PCGProjectionParams:AttributeList")]
	public string AttributeList;

	private static bool AttributeMode_IsValid;

	private static FFieldAddress AttributeMode_PropertyAddress;

	private static int AttributeMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGProjectionParams:AttributeMode")]
	public EPCGMetadataFilterMode AttributeMode;

	private static bool AttributeMergeOperation_IsValid;

	private static FFieldAddress AttributeMergeOperation_PropertyAddress;

	private static int AttributeMergeOperation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGProjectionParams:AttributeMergeOperation")]
	public EPCGMetadataOp AttributeMergeOperation;

	private static bool FPCGProjectionParams_IsValid;

	private static int FPCGProjectionParams_StructSize;

	public FPCGProjectionParams Copy()
	{
		return this;
	}

	public static FPCGProjectionParams FromNative(IntPtr nativeBuffer)
	{
		return new FPCGProjectionParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGProjectionParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGProjectionParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGProjectionParams(nativeBuffer + arrayIndex * FPCGProjectionParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGProjectionParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGProjectionParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGProjectionParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGProjectionParams");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ProjectPositions_Offset), 0, ProjectPositions_PropertyAddress.Address, ProjectPositions);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ProjectRotations_Offset), 0, ProjectRotations_PropertyAddress.Address, ProjectRotations);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ProjectScales_Offset), 0, ProjectScales_PropertyAddress.Address, ProjectScales);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ProjectColors_Offset), 0, ProjectColors_PropertyAddress.Address, ProjectColors);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AttributeList_Offset), AttributeList);
		EnumMarshaler<EPCGMetadataFilterMode>.ToNative(IntPtr.Add(nativeStruct, AttributeMode_Offset), 0, AttributeMode_PropertyAddress.Address, AttributeMode);
		EnumMarshaler<EPCGMetadataOp>.ToNative(IntPtr.Add(nativeStruct, AttributeMergeOperation_Offset), 0, AttributeMergeOperation_PropertyAddress.Address, AttributeMergeOperation);
	}

	public FPCGProjectionParams(IntPtr nativeStruct)
	{
		if (!FPCGProjectionParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGProjectionParams");
			ProjectPositions = false;
			ProjectRotations = false;
			ProjectScales = false;
			ProjectColors = false;
			AttributeList = FStringMarshaler.DefaultString;
			AttributeMode = EPCGMetadataFilterMode.ExcludeAttributes;
			AttributeMergeOperation = EPCGMetadataOp.Min;
		}
		else
		{
			ProjectPositions = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ProjectPositions_Offset), 0, ProjectPositions_PropertyAddress.Address);
			ProjectRotations = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ProjectRotations_Offset), 0, ProjectRotations_PropertyAddress.Address);
			ProjectScales = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ProjectScales_Offset), 0, ProjectScales_PropertyAddress.Address);
			ProjectColors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ProjectColors_Offset), 0, ProjectColors_PropertyAddress.Address);
			AttributeList = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AttributeList_Offset));
			AttributeMode = EnumMarshaler<EPCGMetadataFilterMode>.FromNative(IntPtr.Add(nativeStruct, AttributeMode_Offset), 0, AttributeMode_PropertyAddress.Address);
			AttributeMergeOperation = EnumMarshaler<EPCGMetadataOp>.FromNative(IntPtr.Add(nativeStruct, AttributeMergeOperation_Offset), 0, AttributeMergeOperation_PropertyAddress.Address);
		}
	}

	static FPCGProjectionParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGProjectionParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGProjectionParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGProjectionParams");
		FPCGProjectionParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ProjectPositions_PropertyAddress, intPtr, "bProjectPositions");
		ProjectPositions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProjectPositions");
		ProjectPositions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProjectPositions", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectRotations_PropertyAddress, intPtr, "bProjectRotations");
		ProjectRotations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProjectRotations");
		ProjectRotations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProjectRotations", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectScales_PropertyAddress, intPtr, "bProjectScales");
		ProjectScales_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProjectScales");
		ProjectScales_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProjectScales", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectColors_PropertyAddress, intPtr, "bProjectColors");
		ProjectColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProjectColors");
		ProjectColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProjectColors", Classes.FBoolProperty);
		AttributeList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttributeList");
		AttributeList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttributeList", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AttributeMode_PropertyAddress, intPtr, "AttributeMode");
		AttributeMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttributeMode");
		AttributeMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttributeMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttributeMergeOperation_PropertyAddress, intPtr, "AttributeMergeOperation");
		AttributeMergeOperation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttributeMergeOperation");
		AttributeMergeOperation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttributeMergeOperation", Classes.FEnumProperty);
		FPCGProjectionParams_IsValid = intPtr != IntPtr.Zero && ProjectPositions_IsValid && ProjectRotations_IsValid && ProjectScales_IsValid && ProjectColors_IsValid && AttributeList_IsValid && AttributeMode_IsValid && AttributeMergeOperation_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGProjectionParams", FPCGProjectionParams_IsValid);
	}
}
