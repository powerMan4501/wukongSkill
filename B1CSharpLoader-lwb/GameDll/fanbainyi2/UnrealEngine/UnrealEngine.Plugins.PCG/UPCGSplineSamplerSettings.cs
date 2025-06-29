using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSplineSamplerSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSplineSamplerSettings : UPCGSettings
{
	private static bool SamplerParams_IsValid;

	private static int SamplerParams_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGSplineSamplerSettings:SamplerParams")]
	public FPCGSplineSamplerParams SamplerParams
	{
		get
		{
			CheckDestroyed();
			if (!SamplerParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSplineSamplerSettings:SamplerParams");
				return default(FPCGSplineSamplerParams);
			}
			return FPCGSplineSamplerParams.FromNative(IntPtr.Add(base.Address, SamplerParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SamplerParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSplineSamplerSettings:SamplerParams");
			}
			else
			{
				FPCGSplineSamplerParams.ToNative(IntPtr.Add(base.Address, SamplerParams_Offset), value);
			}
		}
	}

	static UPCGSplineSamplerSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSplineSamplerSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSplineSamplerSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSplineSamplerSettings");
		SamplerParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SamplerParams");
		SamplerParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SamplerParams", Classes.FStructProperty);
	}
}
