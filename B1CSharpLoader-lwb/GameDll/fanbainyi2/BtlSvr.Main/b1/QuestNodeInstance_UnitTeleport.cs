using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_UnitTeleport : QuestNodeInstance
{
	private string NotifyActorGuid { get; set; }

	private QuestCustom_UnitTeleport CustomData { get; set; }

	private int SkillBeforeTeleport { get; set; }

	private int SkillAfterTeleport { get; set; }

	private int RotationType { get; set; }

	private ETeleportLocationType LocationType { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_UnitTeleport();
		CustomData.MergeFrom(base.Node.NodeData);
		NotifyActorGuid = CustomData.NotifyActorGuid;
		LocationType = (ETeleportLocationType)CustomData.LocationType;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, NotifyActorGuid);
		if (actorByGuid != null)
		{
			FVector fVector = default(FVector);
			FRotator newRotation = default(FRotator);
			if (LocationType == ETeleportLocationType.BossTraceCenter)
			{
				BGC_BossTraceData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_BossTraceData>(UGameplayStatics.GetGameState(base.Owner));
				if (readOnlyData != null)
				{
					AActor curTrace = readOnlyData.GetCurTrace();
					if (curTrace != null)
					{
						fVector = curTrace.GetActorLocation();
					}
				}
			}
			else if (LocationType == ETeleportLocationType.BossTracePointRandom)
			{
				BGC_BossTraceData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BGC_BossTraceData>(UGameplayStatics.GetGameState(base.Owner));
				if (readOnlyData2 != null)
				{
					BGUSplineActor bGUSplineActor = (readOnlyData2.GetCurTrace() as BGUSplineTeleportActor).SplineActor as BGUSplineActor;
					if (bGUSplineActor != null && bGUSplineActor.SplineComp != null)
					{
						int numberOfSplinePoints = bGUSplineActor.SplineComp.GetNumberOfSplinePoints();
						int pointIndex = FMath.RandRange(0, numberOfSplinePoints);
						fVector = bGUSplineActor.SplineComp.GetLocationAtSplinePoint(pointIndex, ESplineCoordinateSpace.World);
					}
				}
			}
			if (fVector != FVector.ZeroVector)
			{
				BUS_EventCollectionCS.Get(actorByGuid)?.Evt_SetActorLocationAndRotation.Invoke(fVector, newRotation, bSweep: false, bTeleport: true);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
