using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGWorldQuerySettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGWorldQuerySettings : UPCGSettings
{
	private static bool QueryParams_IsValid;

	private static int QueryParams_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGWorldQuerySettings:QueryParams")]
	public FPCGWorldVolumetricQueryParams QueryParams
	{
		get
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldQuerySettings:QueryParams");
				return default(FPCGWorldVolumetricQueryParams);
			}
			return FPCGWorldVolumetricQueryParams.FromNative(IntPtr.Add(base.Address, QueryParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldQuerySettings:QueryParams");
			}
			else
			{
				FPCGWorldVolumetricQueryParams.ToNative(IntPtr.Add(base.Address, QueryParams_Offset), value);
			}
		}
	}

	static UPCGWorldQuerySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGWorldQuerySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGWorldQuerySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGWorldQuerySettings");
		QueryParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "QueryParams");
		QueryParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "QueryParams", Classes.FStructProperty);
	}
}
