using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_UpdraftLogicComp : UActorCompBaseCS
{
	private BUC_UpdraftLogicData UpdraftLogicData;

	public override void OnAttach()
	{
		UpdraftLogicData = RequireWritableData<BUC_UpdraftLogicData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickCDMap(DeltaTime);
		TickCheck();
	}

	public void TickCDMap(float DeltaTime)
	{
		if (UpdraftLogicData.CDTimerMap.Count < 1)
		{
			return;
		}
		int[] array = UpdraftLogicData.CDTimerMap.Keys.ToArray();
		foreach (int key in array)
		{
			if (UpdraftLogicData.CDTimerMap[key] > 0f)
			{
				UpdraftLogicData.CDTimerMap[key] -= DeltaTime;
			}
			else
			{
				UpdraftLogicData.CDTimerMap.Remove(key);
			}
		}
	}

	public void TickCheck()
	{
		if (UpdraftLogicData.ActorList.Count < 1)
		{
			return;
		}
		for (int i = 0; i < UpdraftLogicData.ActorList.Count; i++)
		{
			BGUCharacterCS bGUCharacterCS = UpdraftLogicData.ActorList[i].Get() as BGUCharacterCS;
			if (bGUCharacterCS.IsNullOrDestroyed())
			{
				UpdraftLogicData.ActorList.RemoveAt(i);
				i--;
			}
			else if (CanUnitPocessUp(bGUCharacterCS))
			{
				PocessUpLogic(bGUCharacterCS);
			}
		}
	}

	private bool CanUnitPocessUp(ACharacter Unit)
	{
		if (!Unit.CharacterMovement.IsFalling())
		{
			return false;
		}
		if (UpdraftLogicData.CDTimerMap.ContainsKey(AActorStatics.GetEntityHash(Unit)))
		{
			return false;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(Unit, EBGUUnitState.Attacking))
		{
			return false;
		}
		return true;
	}

	private void OnActorEnter(AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(OtherActor);
		if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(OtherActor, EBGUSimpleState.InUpdraft, IsRemove: false);
			if (bGUCharacterCS.CharacterMovement.IsFalling() && !UpdraftLogicData.CDTimerMap.ContainsKey(AActorStatics.GetEntityHash(bGUCharacterCS)))
			{
				PocessUpLogic(bGUCharacterCS);
				return;
			}
			TStrongObjectPtr<AActor> tStrongObjectPtr = new TStrongObjectPtr<AActor>();
			tStrongObjectPtr.Set(OtherActor);
			UpdraftLogicData.ActorList.Add(tStrongObjectPtr);
		}
	}

	private void OnActorLeave(AActor OtherActor)
	{
		if ((OtherActor as BGUCharacterCS).IsNullOrDestroyed())
		{
			return;
		}
		IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(OtherActor);
		if (readOnlyData != null && readOnlyData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			TStrongObjectPtr<AActor> tStrongObjectPtr = new TStrongObjectPtr<AActor>();
			tStrongObjectPtr.Set(OtherActor);
			if (UpdraftLogicData.ActorList.Contains(tStrongObjectPtr))
			{
				UpdraftLogicData.ActorList.Remove(tStrongObjectPtr);
			}
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(OtherActor, EBGUSimpleState.InUpdraft, IsRemove: true);
		}
	}

	private void PocessUpLogic(AActor Target)
	{
		if (UpdraftLogicData.UpVelocity <= 0f)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_JumpBreak.Invoke();
			}
			FVector fVector = UpdraftLogicData.UpVelocity * Owner.GetActorUpVector();
			bGUCharacterCS.LaunchCharacter(fVector, bXYOverride: false, bZOverride: false);
			if (UpdraftLogicData.bEnableDebug)
			{
				FVector actorLocation = bGUCharacterCS.GetActorLocation();
				FVector lineEnd = bGUCharacterCS.GetActorLocation() + fVector;
				UBGUFunctionLibraryForCS.BGUDrawLineArrow(bGUCharacterCS.World, actorLocation, lineEnd, 100f);
			}
			if (UpdraftLogicData.CD > 0f)
			{
				UpdraftLogicData.CDTimerMap.Add(AActorStatics.GetEntityHash(bGUCharacterCS), UpdraftLogicData.CD);
			}
		}
	}
}
