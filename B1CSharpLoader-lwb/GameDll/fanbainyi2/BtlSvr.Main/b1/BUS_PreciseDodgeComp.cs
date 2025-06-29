using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_PreciseDodgeComp : UActorCompBaseCS
{
	private BUC_PreciseDodgeData PreciseDodgeData { get; set; }

	private IBUC_SkillInstsData SkillInstsData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_SimpleStateData SimpleStateData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		PreciseDodgeData = RequireWritableData<BUC_PreciseDodgeData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_SweepCheckInPreciseDodgeRange += new Del_SweepCheckInPreciseDodgeRange(SweepCheckInPreciseDodgeRange);
			base.BUSEventCollection.Evt_SetPreciseDodgeAwardLevel += new Del_Void_Int(SetPreciseDodgeAwardLevel);
			base.BUSEventCollection.Evt_BeginPreciseDodge += new Del_TriggerRollSkill(TryPreciseDodge);
			base.BUSEventCollection.Evt_ChangeDodgeSkill += new Del_Void_IntInt(OnChangeDodgeSkill);
			base.BUSEventCollection.Evt_ResetDodgeSkill += new Del_Void(OnResetDodgeSkill);
			base.BUSEventCollection.Evt_UnitSetEnablePreciseDodge += new Del_Void_Bool(UnitSetEnablePreciseDodge);
			base.BUSEventCollection.Evt_ResetPreciseCompRelativeScale += new Del_Void(ResetPreciseCompRelativeScale);
			base.BUSEventCollection.Evt_SetPreciseCompRelativeScale += new Del_Void_Vector(SetPreciseCompRelativeScale);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		PreciseDodgeData.AnimTriggerList.Clear();
	}

	private void UnitSetEnablePreciseDodge(bool EnablePreciseDodge)
	{
		PreciseDodgeData.CanPreciseDodge = EnablePreciseDodge;
	}

	private void SweepCheckInPreciseDodgeRange(AActor Attacker, int MontageID, int GroupID, int NotifyID, float MontageTime)
	{
		FAnimNotifyTriggerList animTriggerList = PreciseDodgeData.AnimTriggerList;
		long entityMontageID = animTriggerList.GetEntityMontageID(Attacker, MontageID);
		if (!animTriggerList.IsCannotTrigger(entityMontageID, GroupID, NotifyID))
		{
			animTriggerList.MarkStash(entityMontageID, GroupID, NotifyID, MontageTime, PreciseDodgeData.PreciseDodgeTolerantTimeSeconds);
			PreciseDodgeData.CurrentPreciseDodgeTimeSeconds = PreciseDodgeData.PreciseDodgeTolerantTimeSeconds;
			_ = PreciseDodgeData.bShowDebugText;
			if (PreciseDodgeData.bShowDebugDraw && PreciseDodgeData.InPreciseDodgeWindow())
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(Owner.World, Owner.GetActorLocation(), 200f, PreciseDodgeData.CurrentPreciseDodgeTimeSeconds, FColor.BlueViolet);
			}
		}
	}

	private void ReadSkillIds()
	{
		FUStPlayerInputSkillMappingDesc playerInputSkillMappingDesc = BGW_GameDB.GetPlayerInputSkillMappingDesc(GetActorResID(), GetOwner());
		if (playerInputSkillMappingDesc != null)
		{
			PreciseDodgeData.PreciseDodgeStartSkillId = playerInputSkillMappingDesc.PreciseDodgeStartSkillID;
			InitPreciseDodgeCombo();
		}
	}

	private void InitPreciseDodgeCombo()
	{
		PreciseDodgeData.CurStateIndex = -1;
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(PreciseDodgeData.PreciseDodgeStartSkillId, GetOwner());
		if (skillSDesc != null && BGW_GameDB.GetRollSkillDesc(PreciseDodgeData.PreciseDodgeStartSkillId, Owner) != null && skillSDesc.SkillType == ESkillType.RollSkill)
		{
			ReadPreciseDodgeChain(PreciseDodgeData.PreciseDodgeStartSkillId);
		}
	}

	private void ReadPreciseDodgeChain(int SkillID)
	{
		if (PreciseDodgeData.PreciseDodgeCombo.Contains(SkillID))
		{
			return;
		}
		FUStRollSkillDesc rollSkillDesc = BGW_GameDB.GetRollSkillDesc(SkillID, Owner);
		if (rollSkillDesc != null)
		{
			PreciseDodgeData.PreciseDodgeCombo.Add(SkillID);
			if (rollSkillDesc.NextRollSkillID != 0)
			{
				ReadPreciseDodgeChain(rollSkillDesc.NextRollSkillID);
			}
		}
	}

	private void TriggerRoll(ESkillDirection RollDir)
	{
		base.BUSEventCollection.Evt_TriggerRollSkill.Invoke(RollDir);
	}

	private void TryPreciseDodge(ESkillDirection RollDir)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		if (uBGUCharacterMovementComponent == null && uBGUCharacterMovementComponent.IsFalling())
		{
			TriggerRoll(RollDir);
			return;
		}
		PreciseDodgeData.PreciseDodgeDirection = RollDir;
		if (GSGameplayCVar.CVar_PreciseDodgeAlwaysSuccess.GetValueInGameThread() == 1)
		{
			OnSatisfyPreciseDodgeConditions();
			return;
		}
		bool flag = GSGameplayCVar.CVar_PreciseDodgeBeatbackCanTrigger.GetValueInGameThread() == 1 || !UnitStateData.HasState(EBGUUnitState.Beatback);
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.CantTriggerPreciseDodge) && !SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) && flag && PreciseDodgeData.CurrentPreciseDodgeTimeSeconds > 0f && PreciseDodgeData.CanPreciseDodge)
		{
			OnSatisfyPreciseDodgeConditions();
			return;
		}
		_ = PreciseDodgeData.bShowDebugText;
		TriggerRoll(RollDir);
	}

	private void OnChangeDodgeSkill(int DodgeSkillID, int PreciseDogeSkillID)
	{
		if (PreciseDogeSkillID > 0)
		{
			PreciseDodgeData.PreciseDodgeCombo.Clear();
			PreciseDodgeData.PreciseDodgeStartSkillId = PreciseDogeSkillID;
			InitPreciseDodgeCombo();
		}
	}

	private void OnResetDodgeSkill()
	{
		PreciseDodgeData.PreciseDodgeCombo.Clear();
		ReadSkillIds();
	}

	public override void PreBeginPlay()
	{
		PreciseDodgeData.CurrentAwardsLevel = PreciseDodgeData.DefaultAwardsLevel;
		PreciseDodgeData.CurrentAwardCount = 0;
		ReadSkillIds();
		CachePreciseCompRelativeScale();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		PreciseDodgeData.AnimTriggerList.Update(DeltaTime);
		if (!(PreciseDodgeData.CurrentPreciseDodgeTimeSeconds <= 0f))
		{
			PreciseDodgeData.CurrentPreciseDodgeTimeSeconds -= DeltaTime;
			if (PreciseDodgeData.CurrentPreciseDodgeTimeSeconds < 0f)
			{
				PreciseDodgeData.CurrentPreciseDodgeTimeSeconds = 0f;
				PreciseDodgeData.CurrentAwardCount = 0;
			}
		}
	}

	private void SetPreciseDodgeAwardLevel(int Level)
	{
		if (PreciseDodgeData.Awards.Count >= Level)
		{
			PreciseDodgeData.CurrentAwardsLevel = Level;
		}
	}

	private void OnSatisfyPreciseDodgeConditions()
	{
		if (PreciseDodgeData.PreciseDodgeCombo.Count == 0)
		{
			return;
		}
		int skillID = PreciseDodgeData.PreciseDodgeCombo[PreciseDodgeData.CurStateIndex + 1];
		FUStRollSkillDesc rollSkillDesc = BGW_GameDB.GetRollSkillDesc(skillID, Owner);
		if (rollSkillDesc == null)
		{
			return;
		}
		if (rollSkillDesc.UseMultiRoll == EGSYesNo.No)
		{
			PreciseDodgeData.PreciseDodgeDirection = ESkillDirection.Forward;
		}
		else if (rollSkillDesc.MultiJustInLock == EGSYesNo.Yes && !UnitStateData.HasState(EBGUUnitState.SideWalking))
		{
			PreciseDodgeData.PreciseDodgeDirection = ESkillDirection.Forward;
		}
		_ = PreciseDodgeData.bShowDebugText;
		FCastSkillInfo cSI = new FCastSkillInfo(skillID, ECastSkillSourceType.PreciseDodge);
		cSI.SkillDirection = PreciseDodgeData.PreciseDodgeDirection;
		base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(cSI);
		if (SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK)
		{
			PreciseDodgeData.CurStateIndex++;
			if (PreciseDodgeData.CurStateIndex >= PreciseDodgeData.PreciseDodgeCombo.Count - 1)
			{
				PreciseDodgeData.CurStateIndex = -1;
			}
			PreciseDodgeData.AnimTriggerList.MarkAllStashCannotTrigger();
			base.BUSEventCollection.Evt_OnPreciseDodgeSuccess.Invoke();
			PreciseDodgeAwardsForData currentLevelAwards = PreciseDodgeData.GetCurrentLevelAwards();
			if (currentLevelAwards == null || PreciseDodgeData.CurrentAwardCount >= currentLevelAwards.MaxAwardCount)
			{
				return;
			}
			foreach (GSBuffInfoForData addBuff in currentLevelAwards.AddBuffList)
			{
				_ = PreciseDodgeData.bShowDebugText;
				base.BUSEventCollection.Evt_BuffAdd.Invoke(addBuff.BuffID, Owner, Owner, addBuff.BuffDuration, EBuffSourceType.PreciseDodge);
			}
			foreach (int removeBuff in currentLevelAwards.RemoveBuffList)
			{
				_ = PreciseDodgeData.bShowDebugText;
				base.BUSEventCollection.Evt_BuffRemove.Invoke(removeBuff, EBuffEffectTriggerType.None, 1);
			}
			FEffectInstReq effectInstReq = new FEffectInstReq(GetOwner());
			foreach (int skillEffectId in currentLevelAwards.SkillEffectIds)
			{
				_ = PreciseDodgeData.bShowDebugText;
				base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(skillEffectId, effectInstReq, GetOwner());
			}
			PreciseDodgeData.CurrentAwardCount++;
			if (PreciseDodgeData.CurrentAwardCount >= currentLevelAwards.MaxAwardCount)
			{
				PreciseDodgeData.CurrentPreciseDodgeTimeSeconds = 0f;
				PreciseDodgeData.CurrentAwardCount = 0;
			}
		}
		else
		{
			_ = PreciseDodgeData.bShowDebugText;
		}
	}

	private void CachePreciseCompRelativeScale()
	{
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.PreciseDodge))
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			PreciseDodgeData.DefaultScale_PreciseDodgeCollision.Add(uSceneComponent.GetName(), uSceneComponent.RelativeScale3D);
		}
	}

	private void SetPreciseCompRelativeScale(FVector RelativeScale3D)
	{
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.PreciseDodge))
		{
			if (PreciseDodgeData.DefaultScale_PreciseDodgeCollision.ContainsKey(item.GetName()))
			{
				(item as USceneComponent).SetRelativeScale3D(RelativeScale3D);
			}
		}
	}

	private void ResetPreciseCompRelativeScale()
	{
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.PreciseDodge))
		{
			if (PreciseDodgeData.DefaultScale_PreciseDodgeCollision.ContainsKey(item.GetName()))
			{
				(item as USceneComponent).SetRelativeScale3D(PreciseDodgeData.DefaultScale_PreciseDodgeCollision[item.GetName()]);
			}
		}
	}
}
