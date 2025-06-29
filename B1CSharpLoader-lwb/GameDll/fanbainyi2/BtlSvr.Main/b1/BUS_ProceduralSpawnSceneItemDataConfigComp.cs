using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProceduralSpawnSceneItemDataConfigComp")]
public class BUS_ProceduralSpawnSceneItemDataConfigComp : UActorEditCompBase
{
	private static bool ProceduralSceneItemDataAsset_IsValid;

	private static int ProceduralSceneItemDataAsset_Offset;

	[EditAnywhere]
	[Category("Procedural Character")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProceduralSpawnSceneItemDataConfigComp:ProceduralSceneItemDataAsset")]
	public BGWProceduralSpawnSceneItemDataAsset ProceduralSceneItemDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!ProceduralSceneItemDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralSpawnSceneItemDataConfigComp:ProceduralSceneItemDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWProceduralSpawnSceneItemDataAsset>.FromNative(IntPtr.Add(base.Address, ProceduralSceneItemDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProceduralSceneItemDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProceduralSpawnSceneItemDataConfigComp:ProceduralSceneItemDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWProceduralSpawnSceneItemDataAsset>.ToNative(IntPtr.Add(base.Address, ProceduralSceneItemDataAsset_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_ProceduralSpawnSceneItemData bUC_ProceduralSpawnSceneItemData = RequireWritableData<BUC_ProceduralSpawnSceneItemData>();
		bUC_ProceduralSpawnSceneItemData.ProceduralSpawnList = new List<ProceduralSpawnSceneItemInfo>();
		foreach (ProceduralSpawnSceneItemInfo proceduralSpawn in ProceduralSceneItemDataAsset.ProceduralItemConfig.ProceduralSpawnList)
		{
			bUC_ProceduralSpawnSceneItemData.ProceduralSpawnList.Add(proceduralSpawn);
		}
		bUC_ProceduralSpawnSceneItemData.SpawnRadius = ProceduralSceneItemDataAsset.ProceduralItemConfig.SpawnRadius;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProceduralSpawnSceneItemDataConfigComp");
		ProceduralSceneItemDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProceduralSceneItemDataAsset");
		ProceduralSceneItemDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProceduralSceneItemDataAsset", Classes.FObjectProperty);
	}

	static BUS_ProceduralSpawnSceneItemDataConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProceduralSpawnSceneItemDataConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProceduralSpawnSceneItemDataConfigComp));
	}
}
