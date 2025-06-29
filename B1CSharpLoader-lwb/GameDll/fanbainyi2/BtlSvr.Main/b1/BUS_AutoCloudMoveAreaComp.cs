using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_AutoCloudMoveAreaComp : UActorCompBaseCS
{
	private b1.BUC_AutoCloudMoveAreaData AutoCloudMoveAreaData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		AutoCloudMoveAreaData = RequireWritableData<b1.BUC_AutoCloudMoveAreaData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		SetCanTick(AutoCloudMoveAreaData.PlayerActors.Count > 0);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		FVector worldLocation = (Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.SceneComponent)[0] as USceneComponent).GetWorldLocation();
		for (int num = AutoCloudMoveAreaData.PlayerActors.Count - 1; num >= 0; num--)
		{
			AActor aActor = AutoCloudMoveAreaData.PlayerActors[num];
			IBUC_CloudMoveData iBUC_CloudMoveData = AutoCloudMoveAreaData.PlayerCloudMoveDatas[num];
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null && iBUC_CloudMoveData.IsCloudMoveEnabled)
			{
				FVector actorLocation = aActor.GetActorLocation();
				if (AutoCloudMoveAreaData.MaxHeightDistance >= 0f && FMath.Abs(worldLocation.Z - actorLocation.Z) > AutoCloudMoveAreaData.MaxHeightDistance)
				{
					if (worldLocation.Z > actorLocation.Z)
					{
						worldLocation.Z = actorLocation.Z + AutoCloudMoveAreaData.MaxHeightDistance;
					}
					else
					{
						worldLocation.Z = actorLocation.Z - AutoCloudMoveAreaData.MaxHeightDistance;
					}
				}
				bUS_GSEventCollection.Evt_SetAutoCloudMove.Invoke(worldLocation, AutoCloudMoveAreaData.AcceptRadius);
				TryRemovePlayer(aActor);
			}
		}
	}

	private void OnActorEnter(AActor OtherActor)
	{
		TryAddPlayer(OtherActor);
	}

	private void OnActorLeave(AActor OtherActor)
	{
		TryRemovePlayer(OtherActor);
	}

	private void TryAddPlayer(AActor Actor)
	{
		AActor aActor = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
		if (Actor == aActor)
		{
			IBUC_CloudMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(aActor);
			if (unPersistentReadOnlyData != null)
			{
				AutoCloudMoveAreaData.PlayerActors.Add(aActor);
				AutoCloudMoveAreaData.PlayerCloudMoveDatas.Add(unPersistentReadOnlyData);
				SetCanTick(Val: true);
			}
		}
	}

	private void TryRemovePlayer(AActor Actor)
	{
		AActor Player = ((UnrealGameplayData == null) ? UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn() : UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn());
		if (!(Actor == Player) || !(BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>(Player) is BUC_CloudMoveData))
		{
			return;
		}
		int num = AutoCloudMoveAreaData.PlayerActors.FindIndex((AActor r) => r == Player);
		if (num >= 0)
		{
			AutoCloudMoveAreaData.PlayerActors.RemoveAt(num);
			AutoCloudMoveAreaData.PlayerCloudMoveDatas.RemoveAt(num);
			if (AutoCloudMoveAreaData.PlayerActors.Count == 0)
			{
				SetCanTick(Val: false);
			}
		}
	}
}
