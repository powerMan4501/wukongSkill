using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGOuterIntersectionSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGOuterIntersectionSettings : UPCGSettingsWithDynamicInputs
{
	private static bool DensityFunction_IsValid;

	private static FFieldAddress DensityFunction_PropertyAddress;

	private static int DensityFunction_Offset;

	private static bool IgnorePinsWithNoInput_IsValid;

	private static FFieldAddress IgnorePinsWithNoInput_PropertyAddress;

	private static int IgnorePinsWithNoInput_Offset;

	private static bool KeepZeroDensityPoints_IsValid;

	private static FFieldAddress KeepZeroDensityPoints_PropertyAddress;

	private static int KeepZeroDensityPoints_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGOuterIntersectionSettings:DensityFunction")]
	public EPCGIntersectionDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGOuterIntersectionSettings:DensityFunction");
				return EPCGIntersectionDensityFunction.Multiply;
			}
			return EnumMarshaler<EPCGIntersectionDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGOuterIntersectionSettings:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGIntersectionDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGOuterIntersectionSettings:bIgnorePinsWithNoInput")]
	public bool IgnorePinsWithNoInput
	{
		get
		{
			CheckDestroyed();
			if (!IgnorePinsWithNoInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGOuterIntersectionSettings:bIgnorePinsWithNoInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnorePinsWithNoInput_Offset), 0, IgnorePinsWithNoInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnorePinsWithNoInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGOuterIntersectionSettings:bIgnorePinsWithNoInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnorePinsWithNoInput_Offset), 0, IgnorePinsWithNoInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021381uL)]
	[UMetaPath("/Script/PCG.PCGOuterIntersectionSettings:bKeepZeroDensityPoints")]
	public bool KeepZeroDensityPoints
	{
		get
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGOuterIntersectionSettings:bKeepZeroDensityPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGOuterIntersectionSettings:bKeepZeroDensityPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGOuterIntersectionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGOuterIntersectionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGOuterIntersectionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGOuterIntersectionSettings");
		NativeReflectionCached.GetPropertyRef(ref DensityFunction_PropertyAddress, unrealStruct, "DensityFunction");
		DensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DensityFunction");
		DensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DensityFunction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnorePinsWithNoInput_PropertyAddress, unrealStruct, "bIgnorePinsWithNoInput");
		IgnorePinsWithNoInput_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIgnorePinsWithNoInput");
		IgnorePinsWithNoInput_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIgnorePinsWithNoInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepZeroDensityPoints_PropertyAddress, unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bKeepZeroDensityPoints", Classes.FBoolProperty);
	}
}
