using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGWorldRayHitData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGWorldRayHitData : UPCGSurfaceData
{
	private static bool QueryParams_IsValid;

	private static int QueryParams_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGWorldRayHitData:QueryParams")]
	public FPCGWorldRayHitQueryParams QueryParams
	{
		get
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldRayHitData:QueryParams");
				return default(FPCGWorldRayHitQueryParams);
			}
			return FPCGWorldRayHitQueryParams.FromNative(IntPtr.Add(base.Address, QueryParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueryParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGWorldRayHitData:QueryParams");
			}
			else
			{
				FPCGWorldRayHitQueryParams.ToNative(IntPtr.Add(base.Address, QueryParams_Offset), value);
			}
		}
	}

	static UPCGWorldRayHitData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGWorldRayHitData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGWorldRayHitData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGWorldRayHitData");
		QueryParams_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "QueryParams");
		QueryParams_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "QueryParams", Classes.FStructProperty);
	}
}
