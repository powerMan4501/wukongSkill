using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGWorldRayHitSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGWorldRayHitSettings : UPCGSettings
{
	private static bool QueryParams_IsValid;

	private static int QueryParams_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitSettings:QueryParams")]
	public FPCGWorldRayHitQueryParams QueryParams
	{
		get
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldRayHitSettings:QueryParams");
				return default(FPCGWorldRayHitQueryParams);
			}
			return FPCGWorldRayHitQueryParams.FromNative(IntPtr.Add(base.Address, QueryParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldRayHitSettings:QueryParams");
			}
			else
			{
				FPCGWorldRayHitQueryParams.ToNative(IntPtr.Add(base.Address, QueryParams_Offset), value);
			}
		}
	}

	static UPCGWorldRayHitSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGWorldRayHitSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGWorldRayHitSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGWorldRayHitSettings");
		QueryParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "QueryParams");
		QueryParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "QueryParams", Classes.FStructProperty);
	}
}
