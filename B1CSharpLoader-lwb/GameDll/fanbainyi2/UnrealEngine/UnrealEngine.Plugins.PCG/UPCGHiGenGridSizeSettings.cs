using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGHiGenGridSizeSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGHiGenGridSizeSettings : UPCGSettings
{
	private static bool HiGenGridSize_IsValid;

	private static FFieldAddress HiGenGridSize_PropertyAddress;

	private static int HiGenGridSize_Offset;

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/PCG.PCGHiGenGridSizeSettings:HiGenGridSize")]
	protected EPCGHiGenGrid HiGenGridSize
	{
		get
		{
			CheckDestroyed();
			if (!HiGenGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGHiGenGridSizeSettings:HiGenGridSize");
				return EPCGHiGenGrid.Uninitialized;
			}
			return EnumMarshaler<EPCGHiGenGrid>.FromNative(IntPtr.Add(base.Address, HiGenGridSize_Offset), 0, HiGenGridSize_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HiGenGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGHiGenGridSizeSettings:HiGenGridSize");
			}
			else
			{
				EnumMarshaler<EPCGHiGenGrid>.ToNative(IntPtr.Add(base.Address, HiGenGridSize_Offset), 0, HiGenGridSize_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGHiGenGridSizeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGHiGenGridSizeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGHiGenGridSizeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGHiGenGridSizeSettings");
		NativeReflectionCached.GetPropertyRef(ref HiGenGridSize_PropertyAddress, unrealStruct, "HiGenGridSize");
		HiGenGridSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HiGenGridSize");
		HiGenGridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HiGenGridSize", Classes.FEnumProperty);
	}
}
