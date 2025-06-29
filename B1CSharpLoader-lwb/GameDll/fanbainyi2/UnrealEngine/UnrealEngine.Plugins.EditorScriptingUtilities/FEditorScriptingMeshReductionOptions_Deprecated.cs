using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public struct FEditorScriptingMeshReductionOptions_Deprecated
{
	private static bool AutoComputeLODScreenSize_IsValid;

	private static FFieldAddress AutoComputeLODScreenSize_PropertyAddress;

	private static int AutoComputeLODScreenSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated:bAutoComputeLODScreenSize")]
	public bool AutoComputeLODScreenSize;

	private static bool ReductionSettings_IsValid;

	private static FFieldAddress ReductionSettings_PropertyAddress;

	private static int ReductionSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated:ReductionSettings")]
	public List<FEditorScriptingMeshReductionSettings_Deprecated> ReductionSettings;

	private static bool FEditorScriptingMeshReductionOptions_Deprecated_IsValid;

	private static int FEditorScriptingMeshReductionOptions_Deprecated_StructSize;

	public FEditorScriptingMeshReductionOptions_Deprecated Copy()
	{
		FEditorScriptingMeshReductionOptions_Deprecated result = this;
		if (ReductionSettings != null)
		{
			result.ReductionSettings = new List<FEditorScriptingMeshReductionSettings_Deprecated>(ReductionSettings);
		}
		return result;
	}

	public static FEditorScriptingMeshReductionOptions_Deprecated FromNative(IntPtr nativeBuffer)
	{
		return new FEditorScriptingMeshReductionOptions_Deprecated(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditorScriptingMeshReductionOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditorScriptingMeshReductionOptions_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditorScriptingMeshReductionOptions_Deprecated(nativeBuffer + arrayIndex * FEditorScriptingMeshReductionOptions_Deprecated_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditorScriptingMeshReductionOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditorScriptingMeshReductionOptions_Deprecated_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditorScriptingMeshReductionOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoComputeLODScreenSize_Offset), 0, AutoComputeLODScreenSize_PropertyAddress.Address, AutoComputeLODScreenSize);
		new TArrayCopyMarshaler<FEditorScriptingMeshReductionSettings_Deprecated>(1, ReductionSettings_PropertyAddress, CachedMarshalingDelegates<FEditorScriptingMeshReductionSettings_Deprecated, FEditorScriptingMeshReductionSettings_Deprecated>.FromNative, CachedMarshalingDelegates<FEditorScriptingMeshReductionSettings_Deprecated, FEditorScriptingMeshReductionSettings_Deprecated>.ToNative).ToNative(IntPtr.Add(nativeStruct, ReductionSettings_Offset), ReductionSettings);
	}

	public FEditorScriptingMeshReductionOptions_Deprecated(IntPtr nativeStruct)
	{
		if (!FEditorScriptingMeshReductionOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated");
			AutoComputeLODScreenSize = false;
			ReductionSettings = null;
		}
		else
		{
			AutoComputeLODScreenSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoComputeLODScreenSize_Offset), 0, AutoComputeLODScreenSize_PropertyAddress.Address);
			ReductionSettings = new TArrayCopyMarshaler<FEditorScriptingMeshReductionSettings_Deprecated>(1, ReductionSettings_PropertyAddress, CachedMarshalingDelegates<FEditorScriptingMeshReductionSettings_Deprecated, FEditorScriptingMeshReductionSettings_Deprecated>.FromNative, CachedMarshalingDelegates<FEditorScriptingMeshReductionSettings_Deprecated, FEditorScriptingMeshReductionSettings_Deprecated>.ToNative).FromNative(IntPtr.Add(nativeStruct, ReductionSettings_Offset));
		}
	}

	static FEditorScriptingMeshReductionOptions_Deprecated()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditorScriptingMeshReductionOptions_Deprecated)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditorScriptingMeshReductionOptions_Deprecated));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated");
		FEditorScriptingMeshReductionOptions_Deprecated_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AutoComputeLODScreenSize_PropertyAddress, intPtr, "bAutoComputeLODScreenSize");
		AutoComputeLODScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoComputeLODScreenSize");
		AutoComputeLODScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoComputeLODScreenSize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReductionSettings_PropertyAddress, intPtr, "ReductionSettings");
		ReductionSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReductionSettings");
		ReductionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReductionSettings", Classes.FArrayProperty);
		FEditorScriptingMeshReductionOptions_Deprecated_IsValid = intPtr != IntPtr.Zero && AutoComputeLODScreenSize_IsValid && ReductionSettings_IsValid;
		NativeReflection.LogStructIsValid("/Script/EditorScriptingUtilities.EditorScriptingMeshReductionOptions_Deprecated", FEditorScriptingMeshReductionOptions_Deprecated_IsValid);
	}
}
