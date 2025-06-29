using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGProjectionSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGProjectionSettings : UPCGSettings
{
	private static bool ProjectionParams_IsValid;

	private static int ProjectionParams_Offset;

	private static bool KeepZeroDensityPoints_IsValid;

	private static FFieldAddress KeepZeroDensityPoints_PropertyAddress;

	private static int KeepZeroDensityPoints_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGProjectionSettings:ProjectionParams")]
	public FPCGProjectionParams ProjectionParams
	{
		get
		{
			CheckDestroyed();
			if (!ProjectionParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionSettings:ProjectionParams");
				return default(FPCGProjectionParams);
			}
			return FPCGProjectionParams.FromNative(IntPtr.Add(base.Address, ProjectionParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectionParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionSettings:ProjectionParams");
			}
			else
			{
				FPCGProjectionParams.ToNative(IntPtr.Add(base.Address, ProjectionParams_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021381uL)]
	[UMetaPath("/Script/PCG.PCGProjectionSettings:bKeepZeroDensityPoints")]
	public bool KeepZeroDensityPoints
	{
		get
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionSettings:bKeepZeroDensityPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGProjectionSettings:bKeepZeroDensityPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGProjectionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGProjectionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGProjectionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGProjectionSettings");
		ProjectionParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ProjectionParams");
		ProjectionParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ProjectionParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepZeroDensityPoints_PropertyAddress, unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bKeepZeroDensityPoints", Classes.FBoolProperty);
	}
}
