using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProceduralSpawnSceneItemComp : UActorCompBaseCS
{
	protected IBUC_ProceduralSpawnSceneItemData ProceduralSceneItemData;

	public override void OnAttach()
	{
		ProceduralSceneItemData = RequireReadOnlyData<IBUC_ProceduralSpawnSceneItemData, BUC_ProceduralSpawnSceneItemData>();
		base.BUSEventCollection.Evt_ProceduralSpawnItem += new Del_Void(SpawnItem);
	}

	private void SpawnItem()
	{
		if (ProceduralSceneItemData.ProceduralSpawnList != null)
		{
			UWorld world = GetOwner().World;
			float value = FMath.DegreesToRadians(FMath.RandRange(0f, 360f));
			float num = FMath.RandRange(0f, ProceduralSceneItemData.GetSpawnRadius());
			FVector Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
			Location.X += FMath.Cos(value) * num;
			Location.Y += FMath.Sin(value) * num;
			FRotator Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner());
			Rotation.Roll = 0f;
			Rotation.Pitch = 0f;
			int index = FMath.RandRange(0, ProceduralSceneItemData.ProceduralSpawnList.Count - 1);
			BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(world, ProceduralSceneItemData.ProceduralSpawnList[index].SpawnClass.Value, in Location, in Rotation);
		}
	}

	public override void OnBeginPlay()
	{
	}
}
