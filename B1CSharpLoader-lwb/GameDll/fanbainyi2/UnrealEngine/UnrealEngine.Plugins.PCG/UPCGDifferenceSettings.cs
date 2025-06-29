using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDifferenceSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDifferenceSettings : UPCGSettings
{
	private static bool DensityFunction_IsValid;

	private static FFieldAddress DensityFunction_PropertyAddress;

	private static int DensityFunction_Offset;

	private static bool Mode_IsValid;

	private static FFieldAddress Mode_PropertyAddress;

	private static int Mode_Offset;

	private static bool DiffMetadata_IsValid;

	private static FFieldAddress DiffMetadata_PropertyAddress;

	private static int DiffMetadata_Offset;

	private static bool KeepZeroDensityPoints_IsValid;

	private static FFieldAddress KeepZeroDensityPoints_PropertyAddress;

	private static int KeepZeroDensityPoints_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceSettings:DensityFunction")]
	public EPCGDifferenceDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:DensityFunction");
				return EPCGDifferenceDensityFunction.Minimum;
			}
			return EnumMarshaler<EPCGDifferenceDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGDifferenceDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceSettings:Mode")]
	public EPCGDifferenceMode Mode
	{
		get
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:Mode");
				return EPCGDifferenceMode.Inferred;
			}
			return EnumMarshaler<EPCGDifferenceMode>.FromNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:Mode");
			}
			else
			{
				EnumMarshaler<EPCGDifferenceMode>.ToNative(IntPtr.Add(base.Address, Mode_Offset), 0, Mode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceSettings:bDiffMetadata")]
	public bool DiffMetadata
	{
		get
		{
			CheckDestroyed();
			if (!DiffMetadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:bDiffMetadata");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DiffMetadata_Offset), 0, DiffMetadata_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DiffMetadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:bDiffMetadata");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DiffMetadata_Offset), 0, DiffMetadata_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021381uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceSettings:bKeepZeroDensityPoints")]
	public bool KeepZeroDensityPoints
	{
		get
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:bKeepZeroDensityPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceSettings:bKeepZeroDensityPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGDifferenceSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDifferenceSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDifferenceSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGDifferenceSettings");
		NativeReflectionCached.GetPropertyRef(ref DensityFunction_PropertyAddress, unrealStruct, "DensityFunction");
		DensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DensityFunction");
		DensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DensityFunction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Mode_PropertyAddress, unrealStruct, "Mode");
		Mode_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mode");
		Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DiffMetadata_PropertyAddress, unrealStruct, "bDiffMetadata");
		DiffMetadata_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDiffMetadata");
		DiffMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDiffMetadata", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepZeroDensityPoints_PropertyAddress, unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bKeepZeroDensityPoints", Classes.FBoolProperty);
	}
}
