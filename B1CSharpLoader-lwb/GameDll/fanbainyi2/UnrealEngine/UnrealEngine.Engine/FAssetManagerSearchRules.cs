using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AssetManagerSearchRules", "Engine", UnrealModuleType.Engine)]
public struct FAssetManagerSearchRules
{
	private static bool AssetScanPaths_IsValid;

	private static FFieldAddress AssetScanPaths_PropertyAddress;

	private static int AssetScanPaths_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:AssetScanPaths")]
	public List<string> AssetScanPaths;

	private static bool IncludePatterns_IsValid;

	private static FFieldAddress IncludePatterns_PropertyAddress;

	private static int IncludePatterns_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:IncludePatterns")]
	public List<string> IncludePatterns;

	private static bool ExcludePatterns_IsValid;

	private static FFieldAddress ExcludePatterns_PropertyAddress;

	private static int ExcludePatterns_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:ExcludePatterns")]
	public List<string> ExcludePatterns;

	private static bool AssetBaseClass_IsValid;

	private static int AssetBaseClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:AssetBaseClass")]
	public TSubclassOf<UObject> AssetBaseClass;

	private static bool HasBlueprintClasses_IsValid;

	private static FFieldAddress HasBlueprintClasses_PropertyAddress;

	private static int HasBlueprintClasses_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:bHasBlueprintClasses")]
	public bool HasBlueprintClasses;

	private static bool ForceSynchronousScan_IsValid;

	private static FFieldAddress ForceSynchronousScan_PropertyAddress;

	private static int ForceSynchronousScan_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:bForceSynchronousScan")]
	public bool ForceSynchronousScan;

	private static bool SkipVirtualPathExpansion_IsValid;

	private static FFieldAddress SkipVirtualPathExpansion_PropertyAddress;

	private static int SkipVirtualPathExpansion_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:bSkipVirtualPathExpansion")]
	public bool SkipVirtualPathExpansion;

	private static bool SkipManagerIncludeCheck_IsValid;

	private static FFieldAddress SkipManagerIncludeCheck_PropertyAddress;

	private static int SkipManagerIncludeCheck_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AssetManagerSearchRules:bSkipManagerIncludeCheck")]
	public bool SkipManagerIncludeCheck;

	private static bool FAssetManagerSearchRules_IsValid;

	private static int FAssetManagerSearchRules_StructSize;

	public FAssetManagerSearchRules Copy()
	{
		FAssetManagerSearchRules result = this;
		if (AssetScanPaths != null)
		{
			result.AssetScanPaths = new List<string>(AssetScanPaths);
		}
		if (IncludePatterns != null)
		{
			result.IncludePatterns = new List<string>(IncludePatterns);
		}
		if (ExcludePatterns != null)
		{
			result.ExcludePatterns = new List<string>(ExcludePatterns);
		}
		return result;
	}

	public static FAssetManagerSearchRules FromNative(IntPtr nativeBuffer)
	{
		return new FAssetManagerSearchRules(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAssetManagerSearchRules value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAssetManagerSearchRules FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAssetManagerSearchRules(nativeBuffer + arrayIndex * FAssetManagerSearchRules_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAssetManagerSearchRules value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAssetManagerSearchRules_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAssetManagerSearchRules_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AssetManagerSearchRules");
			return;
		}
		new TArrayCopyMarshaler<string>(1, AssetScanPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, AssetScanPaths_Offset), AssetScanPaths);
		new TArrayCopyMarshaler<string>(1, IncludePatterns_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, IncludePatterns_Offset), IncludePatterns);
		new TArrayCopyMarshaler<string>(1, ExcludePatterns_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, ExcludePatterns_Offset), ExcludePatterns);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, AssetBaseClass_Offset), AssetBaseClass);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasBlueprintClasses_Offset), 0, HasBlueprintClasses_PropertyAddress.Address, HasBlueprintClasses);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceSynchronousScan_Offset), 0, ForceSynchronousScan_PropertyAddress.Address, ForceSynchronousScan);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipVirtualPathExpansion_Offset), 0, SkipVirtualPathExpansion_PropertyAddress.Address, SkipVirtualPathExpansion);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipManagerIncludeCheck_Offset), 0, SkipManagerIncludeCheck_PropertyAddress.Address, SkipManagerIncludeCheck);
	}

	public FAssetManagerSearchRules(IntPtr nativeStruct)
	{
		if (!FAssetManagerSearchRules_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AssetManagerSearchRules");
			AssetScanPaths = null;
			IncludePatterns = null;
			ExcludePatterns = null;
			AssetBaseClass = default(TSubclassOf<UObject>);
			HasBlueprintClasses = false;
			ForceSynchronousScan = false;
			SkipVirtualPathExpansion = false;
			SkipManagerIncludeCheck = false;
		}
		else
		{
			AssetScanPaths = new TArrayCopyMarshaler<string>(1, AssetScanPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, AssetScanPaths_Offset));
			IncludePatterns = new TArrayCopyMarshaler<string>(1, IncludePatterns_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, IncludePatterns_Offset));
			ExcludePatterns = new TArrayCopyMarshaler<string>(1, ExcludePatterns_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, ExcludePatterns_Offset));
			AssetBaseClass = TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, AssetBaseClass_Offset));
			HasBlueprintClasses = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasBlueprintClasses_Offset), 0, HasBlueprintClasses_PropertyAddress.Address);
			ForceSynchronousScan = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceSynchronousScan_Offset), 0, ForceSynchronousScan_PropertyAddress.Address);
			SkipVirtualPathExpansion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipVirtualPathExpansion_Offset), 0, SkipVirtualPathExpansion_PropertyAddress.Address);
			SkipManagerIncludeCheck = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipManagerIncludeCheck_Offset), 0, SkipManagerIncludeCheck_PropertyAddress.Address);
		}
	}

	static FAssetManagerSearchRules()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAssetManagerSearchRules)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAssetManagerSearchRules));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AssetManagerSearchRules");
		FAssetManagerSearchRules_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AssetScanPaths_PropertyAddress, intPtr, "AssetScanPaths");
		AssetScanPaths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetScanPaths");
		AssetScanPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetScanPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludePatterns_PropertyAddress, intPtr, "IncludePatterns");
		IncludePatterns_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IncludePatterns");
		IncludePatterns_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IncludePatterns", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExcludePatterns_PropertyAddress, intPtr, "ExcludePatterns");
		ExcludePatterns_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExcludePatterns");
		ExcludePatterns_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExcludePatterns", Classes.FArrayProperty);
		AssetBaseClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetBaseClass");
		AssetBaseClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetBaseClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref HasBlueprintClasses_PropertyAddress, intPtr, "bHasBlueprintClasses");
		HasBlueprintClasses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasBlueprintClasses");
		HasBlueprintClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasBlueprintClasses", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceSynchronousScan_PropertyAddress, intPtr, "bForceSynchronousScan");
		ForceSynchronousScan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceSynchronousScan");
		ForceSynchronousScan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceSynchronousScan", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipVirtualPathExpansion_PropertyAddress, intPtr, "bSkipVirtualPathExpansion");
		SkipVirtualPathExpansion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipVirtualPathExpansion");
		SkipVirtualPathExpansion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipVirtualPathExpansion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipManagerIncludeCheck_PropertyAddress, intPtr, "bSkipManagerIncludeCheck");
		SkipManagerIncludeCheck_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipManagerIncludeCheck");
		SkipManagerIncludeCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipManagerIncludeCheck", Classes.FBoolProperty);
		FAssetManagerSearchRules_IsValid = intPtr != IntPtr.Zero && AssetScanPaths_IsValid && IncludePatterns_IsValid && ExcludePatterns_IsValid && AssetBaseClass_IsValid && HasBlueprintClasses_IsValid && ForceSynchronousScan_IsValid && SkipVirtualPathExpansion_IsValid && SkipManagerIncludeCheck_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AssetManagerSearchRules", FAssetManagerSearchRules_IsValid);
	}
}
