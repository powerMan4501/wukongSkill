using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGWorldVolumetricData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGWorldVolumetricData : UPCGVolumeData
{
	private static bool QueryParams_IsValid;

	private static int QueryParams_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGWorldVolumetricData:QueryParams")]
	public FPCGWorldVolumetricQueryParams QueryParams
	{
		get
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldVolumetricData:QueryParams");
				return default(FPCGWorldVolumetricQueryParams);
			}
			return FPCGWorldVolumetricQueryParams.FromNative(IntPtr.Add(base.Address, QueryParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldVolumetricData:QueryParams");
			}
			else
			{
				FPCGWorldVolumetricQueryParams.ToNative(IntPtr.Add(base.Address, QueryParams_Offset), value);
			}
		}
	}

	static UPCGWorldVolumetricData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGWorldVolumetricData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGWorldVolumetricData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGWorldVolumetricData");
		QueryParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "QueryParams");
		QueryParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "QueryParams", Classes.FStructProperty);
	}
}
