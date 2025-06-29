using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGUnionSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGUnionSettings : UPCGSettings
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	private static bool DensityFunction_IsValid;

	private static FFieldAddress DensityFunction_PropertyAddress;

	private static int DensityFunction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGUnionSettings:Type")]
	public EPCGUnionType Type
	{
		get
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionSettings:Type");
				return EPCGUnionType.LeftToRightPriority;
			}
			return EnumMarshaler<EPCGUnionType>.FromNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionSettings:Type");
			}
			else
			{
				EnumMarshaler<EPCGUnionType>.ToNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGUnionSettings:DensityFunction")]
	public EPCGUnionDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionSettings:DensityFunction");
				return EPCGUnionDensityFunction.Maximum;
			}
			return EnumMarshaler<EPCGUnionDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionSettings:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGUnionDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGUnionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGUnionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGUnionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGUnionSettings");
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, unrealStruct, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DensityFunction_PropertyAddress, unrealStruct, "DensityFunction");
		DensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DensityFunction");
		DensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DensityFunction", Classes.FEnumProperty);
	}
}
