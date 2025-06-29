using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp")]
public class BUS_ProceduralMapGeneratorDataConfigComp : UActorEditCompBase
{
	private static bool MapConfigDataAsset_IsValid;

	private static int MapConfigDataAsset_Offset;

	private static bool MapBlockMappingInfo_IsValid;

	private static int MapBlockMappingInfo_Offset;

	private static bool MapCustsomLightConfigs_IsValid;

	private static int MapCustsomLightConfigs_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Procedural Map Info")]
	[DisplayName("地图信息配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapConfigDataAsset")]
	public BGWProceduralMapConfigDataAsset MapConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!MapConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWProceduralMapConfigDataAsset>.FromNative(IntPtr.Add(base.Address, MapConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWProceduralMapConfigDataAsset>.ToNative(IntPtr.Add(base.Address, MapConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Procedural Map Info")]
	[DisplayName("地块映射配置")]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapBlockMappingInfo")]
	public BGWProceduralMapBlockMappingDataAsset MapBlockMappingInfo
	{
		get
		{
			CheckDestroyed();
			if (!MapBlockMappingInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapBlockMappingInfo");
				return null;
			}
			return UObjectMarshaler<BGWProceduralMapBlockMappingDataAsset>.FromNative(IntPtr.Add(base.Address, MapBlockMappingInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapBlockMappingInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapBlockMappingInfo");
			}
			else
			{
				UObjectMarshaler<BGWProceduralMapBlockMappingDataAsset>.ToNative(IntPtr.Add(base.Address, MapBlockMappingInfo_Offset), value);
			}
		}
	}

	[DisplayName("光照信息配置")]
	[Category("Procedural Map Info")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapCustsomLightConfigs")]
	public BGWCustomLightConfigDataAsset MapCustsomLightConfigs
	{
		get
		{
			CheckDestroyed();
			if (!MapCustsomLightConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapCustsomLightConfigs");
				return null;
			}
			return UObjectMarshaler<BGWCustomLightConfigDataAsset>.FromNative(IntPtr.Add(base.Address, MapCustsomLightConfigs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapCustsomLightConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp:MapCustsomLightConfigs");
			}
			else
			{
				UObjectMarshaler<BGWCustomLightConfigDataAsset>.ToNative(IntPtr.Add(base.Address, MapCustsomLightConfigs_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_ProceduralMapGeneratorData bUC_ProceduralMapGeneratorData = RequireWritableData<BUC_ProceduralMapGeneratorData>();
		BGUFuncLibProceduralMap.InitProceduralMapConfig(MapConfigDataAsset, MapBlockMappingInfo, MapCustsomLightConfigs, out var MapInfo);
		bUC_ProceduralMapGeneratorData.MapInfo = MapInfo;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralMapGeneratorDataConfigComp");
		MapConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapConfigDataAsset");
		MapConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapConfigDataAsset", Classes.FObjectProperty);
		MapBlockMappingInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapBlockMappingInfo");
		MapBlockMappingInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapBlockMappingInfo", Classes.FObjectProperty);
		MapCustsomLightConfigs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapCustsomLightConfigs");
		MapCustsomLightConfigs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapCustsomLightConfigs", Classes.FObjectProperty);
	}

	static BUS_ProceduralMapGeneratorDataConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralMapGeneratorDataConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralMapGeneratorDataConfigComp));
	}
}
