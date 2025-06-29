using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshEditor;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/StaticMeshEditor.StaticMeshReductionOptions", "StaticMeshEditor", UnrealModuleType.Engine)]
public struct FStaticMeshReductionOptions
{
	private static bool AutoComputeLODScreenSize_IsValid;

	private static FFieldAddress AutoComputeLODScreenSize_PropertyAddress;

	private static int AutoComputeLODScreenSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshReductionOptions:bAutoComputeLODScreenSize")]
	public bool AutoComputeLODScreenSize;

	private static bool ReductionSettings_IsValid;

	private static FFieldAddress ReductionSettings_PropertyAddress;

	private static int ReductionSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/StaticMeshEditor.StaticMeshReductionOptions:ReductionSettings")]
	public List<FStaticMeshReductionSettings> ReductionSettings;

	private static bool FStaticMeshReductionOptions_IsValid;

	private static int FStaticMeshReductionOptions_StructSize;

	public FStaticMeshReductionOptions Copy()
	{
		FStaticMeshReductionOptions result = this;
		if (ReductionSettings != null)
		{
			result.ReductionSettings = new List<FStaticMeshReductionSettings>(ReductionSettings);
		}
		return result;
	}

	public static FStaticMeshReductionOptions FromNative(IntPtr nativeBuffer)
	{
		return new FStaticMeshReductionOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStaticMeshReductionOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStaticMeshReductionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStaticMeshReductionOptions(nativeBuffer + arrayIndex * FStaticMeshReductionOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStaticMeshReductionOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStaticMeshReductionOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStaticMeshReductionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.StaticMeshReductionOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoComputeLODScreenSize_Offset), 0, AutoComputeLODScreenSize_PropertyAddress.Address, AutoComputeLODScreenSize);
		new TArrayCopyMarshaler<FStaticMeshReductionSettings>(1, ReductionSettings_PropertyAddress, CachedMarshalingDelegates<FStaticMeshReductionSettings, FStaticMeshReductionSettings>.FromNative, CachedMarshalingDelegates<FStaticMeshReductionSettings, FStaticMeshReductionSettings>.ToNative).ToNative(IntPtr.Add(nativeStruct, ReductionSettings_Offset), ReductionSettings);
	}

	public FStaticMeshReductionOptions(IntPtr nativeStruct)
	{
		if (!FStaticMeshReductionOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.StaticMeshReductionOptions");
			AutoComputeLODScreenSize = false;
			ReductionSettings = null;
		}
		else
		{
			AutoComputeLODScreenSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoComputeLODScreenSize_Offset), 0, AutoComputeLODScreenSize_PropertyAddress.Address);
			ReductionSettings = new TArrayCopyMarshaler<FStaticMeshReductionSettings>(1, ReductionSettings_PropertyAddress, CachedMarshalingDelegates<FStaticMeshReductionSettings, FStaticMeshReductionSettings>.FromNative, CachedMarshalingDelegates<FStaticMeshReductionSettings, FStaticMeshReductionSettings>.ToNative).FromNative(IntPtr.Add(nativeStruct, ReductionSettings_Offset));
		}
	}

	static FStaticMeshReductionOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStaticMeshReductionOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStaticMeshReductionOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/StaticMeshEditor.StaticMeshReductionOptions");
		FStaticMeshReductionOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AutoComputeLODScreenSize_PropertyAddress, intPtr, "bAutoComputeLODScreenSize");
		AutoComputeLODScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoComputeLODScreenSize");
		AutoComputeLODScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoComputeLODScreenSize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReductionSettings_PropertyAddress, intPtr, "ReductionSettings");
		ReductionSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReductionSettings");
		ReductionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReductionSettings", Classes.FArrayProperty);
		FStaticMeshReductionOptions_IsValid = intPtr != IntPtr.Zero && AutoComputeLODScreenSize_IsValid && ReductionSettings_IsValid;
		NativeReflection.LogStructIsValid("/Script/StaticMeshEditor.StaticMeshReductionOptions", FStaticMeshReductionOptions_IsValid);
	}
}
