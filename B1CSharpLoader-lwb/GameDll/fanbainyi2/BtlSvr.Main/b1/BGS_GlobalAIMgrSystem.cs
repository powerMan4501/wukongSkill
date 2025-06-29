using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_GlobalAIMgrSystem : GameStateSystemBase
{
	private BGC_GlobalAIMgrData GlobalAIMgrData;

	private IBGC_GlobalBattleStateData GlobalBattleStateData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private readonly int MAX_INTO_BATTLE_NUM = 10;

	private readonly float TICK_DURATION = 1f;

	private float TickTimer;

	private List<(string, float)> CanForceLeaveBattleUnits = new List<(string, float)>();

	public override void OnAttach()
	{
		GlobalAIMgrData = RequireWritableData<BGC_GlobalAIMgrData>();
		GlobalBattleStateData = RequireReadOnlyGameStateData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		base.BGSEventCollection.Evt_BGS_MarkGroupCastSkill += new Del_BGS_MarkGroupCastSkill(OnMarkGroupCastSkill);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickTimer -= DeltaTime;
		if (!(TickTimer <= 0f))
		{
			return;
		}
		TickTimer = TICK_DURATION;
		int count = GlobalBattleStateData.CanForceLeaveBattleUnits.Count;
		if (count <= MAX_INTO_BATTLE_NUM)
		{
			return;
		}
		AActor aActor = null;
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(LocalPlayerSharedData.FirstLocalPlayerPawn);
		if (readOnlyData != null)
		{
			UnitLockTargetInfo targetInfo = readOnlyData.GetTargetInfo();
			if (targetInfo != null)
			{
				aActor = targetInfo.LockTargetActor;
			}
		}
		int num = count - MAX_INTO_BATTLE_NUM;
		CanForceLeaveBattleUnits.Clear();
		foreach (KeyValuePair<string, BGUCharacterCS> item in GlobalBattleStateData.CanForceLeaveBattleUnits.ToList())
		{
			BGUCharacterCS value = item.Value;
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(value);
			bool flag = BGUFunctionLibraryCS.BGUIsTargetInView(LocalPlayerSharedData.CachedLocalPlayerLocation, LocalPlayerSharedData.CachedLocalPlayerCameraRotation, fVector, 70f);
			float num2 = FVector.Distance(fVector, LocalPlayerSharedData.CachedLocalPlayerLocation);
			float num3 = 0f;
			float num4 = 0f;
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(value);
			if (unPersistentReadOnlyData != null)
			{
				num3 = FVector.Distance(fVector, unPersistentReadOnlyData.GetEnterBattlePosition());
				num4 = FVector.Distance(LocalPlayerSharedData.CachedLocalPlayerLocation, unPersistentReadOnlyData.GetEnterBattlePosition());
			}
			float num5 = num2 + num3 * 0.5f + num4 * 0.5f;
			if (flag)
			{
				num5 /= 10f;
			}
			CanForceLeaveBattleUnits.Add((item.Key, num5));
		}
		CanForceLeaveBattleUnits.Sort(((string, float) Info1, (string, float) Info2) => (!(Info1.Item2 > Info2.Item2)) ? 1 : (-1));
		foreach (var canForceLeaveBattleUnit in CanForceLeaveBattleUnits)
		{
			if (num <= 0)
			{
				break;
			}
			var (text, _) = canForceLeaveBattleUnit;
			if (GlobalBattleStateData.CanForceLeaveBattleUnits.TryGetValue(text, out var value2) && value2 != null && !value2.IsPendingKill && !value2.IsNullOrDestroyed())
			{
				bool flag2 = true;
				if (aActor != null)
				{
					flag2 = aActor != value2;
				}
				if (flag2)
				{
					num--;
					BUS_EventCollectionCS.Get(value2)?.Evt_NotifyUnitReturnHome.Invoke(P1: true);
					base.BGSEventCollection.Evt_BGS_RemoveForceLeaveBattleUnit.Invoke(text);
				}
			}
		}
	}

	private void OnMarkGroupCastSkill(int UnitResID, string UnitGuid, int SkillID, float NowTime)
	{
		GlobalAIMgrData.MarkGroupCastSkill(UnitResID, UnitGuid, SkillID, NowTime);
	}
}
