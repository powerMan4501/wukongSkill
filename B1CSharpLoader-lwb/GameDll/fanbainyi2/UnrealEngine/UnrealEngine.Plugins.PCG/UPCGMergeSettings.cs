using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMergeSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMergeSettings : UPCGSettings
{
	private static bool MergeMetadata_IsValid;

	private static FFieldAddress MergeMetadata_PropertyAddress;

	private static int MergeMetadata_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMergeSettings:bMergeMetadata")]
	public bool MergeMetadata
	{
		get
		{
			CheckDestroyed();
			if (!MergeMetadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMergeSettings:bMergeMetadata");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MergeMetadata_Offset), 0, MergeMetadata_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MergeMetadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGMergeSettings:bMergeMetadata");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MergeMetadata_Offset), 0, MergeMetadata_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGMergeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMergeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMergeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGMergeSettings");
		NativeReflectionCached.GetPropertyRef(ref MergeMetadata_PropertyAddress, unrealStruct, "bMergeMetadata");
		MergeMetadata_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMergeMetadata");
		MergeMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMergeMetadata", Classes.FBoolProperty);
	}
}
