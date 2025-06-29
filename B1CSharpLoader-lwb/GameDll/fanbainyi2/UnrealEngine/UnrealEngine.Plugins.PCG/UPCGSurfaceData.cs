using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSurfaceData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSurfaceData : UPCGSpatialDataWithPointCache
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)9016065141112853uL)]
	[UMetaPath("/Script/PCG.PCGSurfaceData:Transform")]
	protected FTransform Transform
	{
		get
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceData:Transform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Transform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Transform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSurfaceData:Transform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Transform_Offset), value);
			}
		}
	}

	static UPCGSurfaceData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSurfaceData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSurfaceData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSurfaceData");
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Transform", Classes.FStructProperty);
	}
}
