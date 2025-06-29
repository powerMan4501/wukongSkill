using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_SpawnBossTrace : QuestNodeInstance
{
	private ETraceSpawnType SpawnType;

	private string TraceEfxPath;

	private QuestCustom_SpawnBossTrace CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_SpawnBossTrace();
		CustomData.MergeFrom(base.Node.NodeData);
		SpawnType = (ETraceSpawnType)CustomData.SpawnType;
		TraceEfxPath = CustomData.TraceEfxPath;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGC_BossTraceData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_BossTraceData>(UGameplayStatics.GetGameState(base.Owner));
		if (readOnlyData != null)
		{
			List<BGUSplineTeleportActor> traceList = GetTraceList();
			int numPlayerControllers = UGameplayStatics.GetNumPlayerControllers(base.Owner);
			int playerIndex = 0;
			if (numPlayerControllers > 1)
			{
				FMath.RandRange(0, numPlayerControllers - 1);
			}
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(base.Owner, playerIndex);
			foreach (BGUSplineTeleportActor item2 in traceList)
			{
				readOnlyData.AddBossTraceList(item2);
				BGUSplineActor bGUSplineActor = item2.SplineActor as BGUSplineActor;
				if (bGUSplineActor != null && bGUSplineActor.SplineComp != null)
				{
					int numberOfSplinePoints = bGUSplineActor.SplineComp.GetNumberOfSplinePoints();
					List<FTransform> list = new List<FTransform>();
					for (int i = 0; i < numberOfSplinePoints; i++)
					{
						FTransform item = default(FTransform);
						item.SetLocation(bGUSplineActor.SplineComp.GetLocationAtSplinePoint(i, ESplineCoordinateSpace.World));
						list.Add(item);
					}
					readOnlyData.AddFXListForTrace(item2, playerCharacter, list, TraceEfxPath);
				}
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

	private List<BGUSplineTeleportActor> GetTraceList()
	{
		List<BGUSplineTeleportActor> list = new List<BGUSplineTeleportActor>();
		if (SpawnType == ETraceSpawnType.ByTeleportIndex)
		{
			BGUSplineTeleportActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUSplineTeleportActor>(base.Owner);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(base.Owner, 0);
			BGUSplineTeleportActor bGUSplineTeleportActor = null;
			float num = 0f;
			BGUSplineTeleportActor[] array = allActorsOfClass;
			foreach (BGUSplineTeleportActor bGUSplineTeleportActor2 in array)
			{
				float num2 = FVector.Distance(playerCharacter.GetActorLocation(), bGUSplineTeleportActor2.GetActorLocation());
				if (num == 0f || num > num2)
				{
					num = num2;
					bGUSplineTeleportActor = bGUSplineTeleportActor2;
				}
			}
			int num3 = 2;
			int num4 = bGUSplineTeleportActor.CircleIndex - num3;
			int num5 = bGUSplineTeleportActor.CircleIndex + num3;
			if (num4 < 0)
			{
				num4 += allActorsOfClass.Length;
			}
			if (num5 > allActorsOfClass.Length)
			{
				num5 -= allActorsOfClass.Length;
			}
			array = allActorsOfClass;
			foreach (BGUSplineTeleportActor bGUSplineTeleportActor3 in array)
			{
				if (bGUSplineTeleportActor3.CircleIndex == num4 || bGUSplineTeleportActor3.CircleIndex == num5)
				{
					list.Add(bGUSplineTeleportActor3);
				}
			}
		}
		return list;
	}
}
