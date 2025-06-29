using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Water.WaterBodyOceanComponent", "Water", UnrealModuleType.EnginePlugin)]
public class UWaterBodyOceanComponent : UWaterBodyComponent
{
	private static bool CollisionExtents_IsValid;

	private static int CollisionExtents_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Water.WaterBodyOceanComponent:CollisionExtents")]
	protected FVector CollisionExtents
	{
		get
		{
			CheckDestroyed();
			if (!CollisionExtents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyOceanComponent:CollisionExtents");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CollisionExtents_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionExtents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyOceanComponent:CollisionExtents");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CollisionExtents_Offset), value);
			}
		}
	}

	static UWaterBodyOceanComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWaterBodyOceanComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWaterBodyOceanComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Water.WaterBodyOceanComponent");
		CollisionExtents_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CollisionExtents");
		CollisionExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CollisionExtents", Classes.FStructProperty);
	}
}
