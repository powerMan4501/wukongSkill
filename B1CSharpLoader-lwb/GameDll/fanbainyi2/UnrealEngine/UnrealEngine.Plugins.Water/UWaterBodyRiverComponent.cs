using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Water.WaterBodyRiverComponent", "Water", UnrealModuleType.EnginePlugin)]
public class UWaterBodyRiverComponent : UWaterBodyComponent
{
	private static bool LakeTransitionMaterial_IsValid;

	private static int LakeTransitionMaterial_Offset;

	private static bool OceanTransitionMaterial_IsValid;

	private static int OceanTransitionMaterial_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Water.WaterBodyRiverComponent:LakeTransitionMaterial")]
	protected UMaterialInterface LakeTransitionMaterial
	{
		get
		{
			CheckDestroyed();
			if (!LakeTransitionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyRiverComponent:LakeTransitionMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, LakeTransitionMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LakeTransitionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyRiverComponent:LakeTransitionMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, LakeTransitionMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Water.WaterBodyRiverComponent:OceanTransitionMaterial")]
	protected UMaterialInterface OceanTransitionMaterial
	{
		get
		{
			CheckDestroyed();
			if (!OceanTransitionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyRiverComponent:OceanTransitionMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, OceanTransitionMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OceanTransitionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBodyRiverComponent:OceanTransitionMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, OceanTransitionMaterial_Offset), value);
			}
		}
	}

	static UWaterBodyRiverComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWaterBodyRiverComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWaterBodyRiverComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Water.WaterBodyRiverComponent");
		LakeTransitionMaterial_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LakeTransitionMaterial");
		LakeTransitionMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LakeTransitionMaterial", Classes.FObjectProperty);
		OceanTransitionMaterial_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OceanTransitionMaterial");
		OceanTransitionMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OceanTransitionMaterial", Classes.FObjectProperty);
	}
}
