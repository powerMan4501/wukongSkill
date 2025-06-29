using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSelfPruningSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSelfPruningSettings : UPCGSettings
{
	private static bool PruningType_IsValid;

	private static FFieldAddress PruningType_PropertyAddress;

	private static int PruningType_Offset;

	private static bool RadiusSimilarityFactor_IsValid;

	private static int RadiusSimilarityFactor_Offset;

	private static bool RandomizedPruning_IsValid;

	private static FFieldAddress RandomizedPruning_PropertyAddress;

	private static int RandomizedPruning_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSelfPruningSettings:PruningType")]
	public EPCGSelfPruningType PruningType
	{
		get
		{
			CheckDestroyed();
			if (!PruningType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSelfPruningSettings:PruningType");
				return EPCGSelfPruningType.LargeToSmall;
			}
			return EnumMarshaler<EPCGSelfPruningType>.FromNative(IntPtr.Add(base.Address, PruningType_Offset), 0, PruningType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PruningType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSelfPruningSettings:PruningType");
			}
			else
			{
				EnumMarshaler<EPCGSelfPruningType>.ToNative(IntPtr.Add(base.Address, PruningType_Offset), 0, PruningType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSelfPruningSettings:RadiusSimilarityFactor")]
	public float RadiusSimilarityFactor
	{
		get
		{
			CheckDestroyed();
			if (!RadiusSimilarityFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSelfPruningSettings:RadiusSimilarityFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RadiusSimilarityFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RadiusSimilarityFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSelfPruningSettings:RadiusSimilarityFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RadiusSimilarityFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSelfPruningSettings:bRandomizedPruning")]
	public bool RandomizedPruning
	{
		get
		{
			CheckDestroyed();
			if (!RandomizedPruning_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSelfPruningSettings:bRandomizedPruning");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RandomizedPruning_Offset), 0, RandomizedPruning_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RandomizedPruning_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSelfPruningSettings:bRandomizedPruning");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RandomizedPruning_Offset), 0, RandomizedPruning_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGSelfPruningSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSelfPruningSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSelfPruningSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSelfPruningSettings");
		NativeReflectionCached.GetPropertyRef(ref PruningType_PropertyAddress, unrealStruct, "PruningType");
		PruningType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PruningType");
		PruningType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PruningType", Classes.FEnumProperty);
		RadiusSimilarityFactor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RadiusSimilarityFactor");
		RadiusSimilarityFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RadiusSimilarityFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomizedPruning_PropertyAddress, unrealStruct, "bRandomizedPruning");
		RandomizedPruning_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRandomizedPruning");
		RandomizedPruning_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRandomizedPruning", Classes.FBoolProperty);
	}
}
