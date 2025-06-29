using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_SetAwardState : QuestNodeInstance, IObserveNodeInstance
{
	private QuestCustom_SetAwardState CustomData;

	private AActor Target;

	private FVector CenterPoint;

	private int CenterDistance;

	private int Distance;

	private List<EAwardStateConditionType> ConditionList = new List<EAwardStateConditionType>();

	private int EventId { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_SetAwardState();
		CustomData.MergeFrom(base.Node.NodeData);
		EventId = CustomData.EventId;
		Distance = CustomData.Distance;
		CenterDistance = CustomData.CenterDistance;
		CenterPoint = new FVector(CustomData.CenterPointX, CustomData.CenterPointY, CustomData.CenterPointZ);
		if (CustomData.ObservedActorGuid == B1GlobalFNames.Player_Wukong.PlainName)
		{
			Target = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
		}
		else
		{
			Target = BGU_DataUtil.GetActorByGuid(base.Owner, CustomData.ObservedActorGuid);
		}
		foreach (int condition in CustomData.ConditionList)
		{
			ConditionList.Add((EAwardStateConditionType)condition);
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void Tick(float DeltaTime)
	{
		bool flag = true;
		using (List<EAwardStateConditionType>.Enumerator enumerator = ConditionList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				switch (enumerator.Current)
				{
				case EAwardStateConditionType.IsInBattle:
					flag = !IsInBattle();
					break;
				case EAwardStateConditionType.InDistanceToCenter:
					flag = !InDistanceToCenter();
					break;
				case EAwardStateConditionType.TraceTeleportDistance:
					flag = !TraceTeleportDistance();
					break;
				case EAwardStateConditionType.PlayerDead:
					flag = !PlayerDead();
					break;
				}
				if (!flag)
				{
					break;
				}
			}
		}
		OnSetCanAwardState(flag);
	}

	private void OnSetCanAwardState(bool CanAward)
	{
		BGU_DataUtil.GetReadOnlyData<BGC_RandomEventData>(UGameplayStatics.GetGameState(base.Owner))?.SetCanAwardState(EventId, CanAward);
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}

	private bool IsInBattle()
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(Target)?.IsUnitInBattle() ?? true;
	}

	private bool InDistanceToCenter()
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
		if (controlledPawn != null)
		{
			return FVector.Distance(controlledPawn.GetActorLocation(), CenterPoint) < (float)CenterDistance;
		}
		return true;
	}

	private bool TraceTeleportDistance()
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
		if (controlledPawn != null)
		{
			BGUSplineTeleportActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUSplineTeleportActor>(base.Owner);
			BGUSplineTeleportActor bGUSplineTeleportActor = null;
			float num = 0f;
			BGUSplineTeleportActor[] array = allActorsOfClass;
			foreach (BGUSplineTeleportActor bGUSplineTeleportActor2 in array)
			{
				float num2 = FVector.Distance(controlledPawn.GetActorLocation(), bGUSplineTeleportActor2.GetActorLocation());
				if (num == 0f || num > num2)
				{
					num = num2;
					bGUSplineTeleportActor = bGUSplineTeleportActor2;
				}
			}
			array = allActorsOfClass;
			foreach (BGUSplineTeleportActor bGUSplineTeleportActor3 in array)
			{
				if (CheckCircleIndex(bGUSplineTeleportActor.CircleIndex, bGUSplineTeleportActor3.CircleIndex, allActorsOfClass.Length) && FVector.Distance(Target.GetActorLocation(), bGUSplineTeleportActor3.GetActorLocation()) < (float)Distance)
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	private bool PlayerDead()
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn();
		if (controlledPawn != null)
		{
			BUC_FallDyingData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_FallDyingData>(controlledPawn);
			if (readOnlyData != null)
			{
				return readOnlyData.GetFallDyingState() != EFallDyingState.Alive;
			}
		}
		return true;
	}

	private bool CheckCircleIndex(int NearestIndex, int TargetIndex, int Length)
	{
		int num = 1;
		if (FMath.Abs(NearestIndex - TargetIndex) <= num)
		{
			return true;
		}
		if (NearestIndex < num)
		{
			if (TargetIndex - NearestIndex >= num)
			{
				return Length - TargetIndex - NearestIndex < num;
			}
			return true;
		}
		if (NearestIndex > Length - num)
		{
			if (TargetIndex >= num)
			{
				return Length - TargetIndex - NearestIndex < num;
			}
			return true;
		}
		return false;
	}
}
