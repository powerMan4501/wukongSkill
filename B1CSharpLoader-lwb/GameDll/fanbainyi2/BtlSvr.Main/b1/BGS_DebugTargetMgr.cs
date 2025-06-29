using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_DebugTargetMgr : GameStateSystemBase
{
	private BGC_DebugTargetMgrData DebugTargetMgrData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		DebugTargetMgrData = RequireWritableData<BGC_DebugTargetMgrData>();
		base.BGSEventCollection.Evt_BGS_SetNeedShowDebugChr += new Del_Void_ActorInt(SetNeedShowDebugChr);
		base.BGSEventCollection.Evt_BGS_CleanTargetInfos += new Del_Void(CleanTargetInfos);
	}

	public BGUDebugNiaActor GetNiaActorFromPool()
	{
		UWorld world = UBGUFunctionLibraryForCS.BGUGetUWorld(Owner);
		if (DebugTargetMgrData.DebugNiaActorPool.Count != 0)
		{
			BGUDebugNiaActor result = DebugTargetMgrData.DebugNiaActorPool[0];
			DebugTargetMgrData.DebugNiaActorPool.RemoveAt(0);
			return result;
		}
		return BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay<BGUDebugNiaActor>(world);
	}

	public void CollectNiaActor(ref BGUDebugNiaActor NiaActor)
	{
		if (!(NiaActor == null))
		{
			NiaActor.SetVisibility(Vis: false);
			DebugTargetMgrData.DebugNiaActorPool.Add(NiaActor);
			NiaActor = null;
		}
	}

	public void CleanTargetInfos()
	{
		foreach (BGUDebugTargetInfo debugTargetInfo in DebugTargetMgrData.DebugTargetInfos)
		{
			CollectNiaActor(ref debugTargetInfo.AITargetNiaActor);
			CollectNiaActor(ref debugTargetInfo.AOTargetNiaActor);
			CollectNiaActor(ref debugTargetInfo.SkillBaseTargetNiaActor);
			CollectNiaActor(ref debugTargetInfo.ComboTargetNiaActor);
		}
		DebugTargetMgrData.DebugTargetInfos.Clear();
	}

	public int GetTargetInfos(AActor Target)
	{
		return DebugTargetMgrData.DebugTargetInfos.Find((BGUDebugTargetInfo Info) => Info.Self == Target)?.Masks ?? 0;
	}

	public void SetNeedShowDebugChr(AActor Actor, int Mask)
	{
		BGUCharacterCS Chr = Actor as BGUCharacterCS;
		if (!(Chr != null))
		{
			return;
		}
		BGUDebugTargetInfo bGUDebugTargetInfo = DebugTargetMgrData.DebugTargetInfos.Find((BGUDebugTargetInfo Info) => Info.Self == Chr);
		if (bGUDebugTargetInfo != null)
		{
			bGUDebugTargetInfo.Masks = Mask;
			if (bGUDebugTargetInfo.Masks <= 0)
			{
				RemoveNeedShowDebugChr(Chr);
			}
		}
		else
		{
			DebugTargetMgrData.DebugTargetInfos.Add(new BGUDebugTargetInfo(Chr, Mask, this));
		}
	}

	private void UpdateDebugNia(ref BGUDebugNiaActor NiaActor, FVector StartPos, FVector EndPos, FLinearColor DebugLineColor, float DebugBeamUpRadians, float DebugBeamWidth)
	{
		if (NiaActor == null)
		{
			NiaActor = GetNiaActorFromPool();
		}
		NiaActor.UpdateDebugNiaParam(StartPos, EndPos, DebugLineColor, DebugBeamUpRadians, DebugBeamWidth);
		NiaActor.SetVisibility(Vis: true);
	}

	private void RemoveNeedShowDebugChr(BGUCharacterCS Chr)
	{
		if (!(Chr != null))
		{
			return;
		}
		BGUDebugTargetInfo bGUDebugTargetInfo = DebugTargetMgrData.DebugTargetInfos.Find((BGUDebugTargetInfo Info) => Info.Self == Chr);
		CollectNiaActor(ref bGUDebugTargetInfo.AITargetNiaActor);
		CollectNiaActor(ref bGUDebugTargetInfo.AOTargetNiaActor);
		CollectNiaActor(ref bGUDebugTargetInfo.SkillBaseTargetNiaActor);
		CollectNiaActor(ref bGUDebugTargetInfo.ComboTargetNiaActor);
		if (bGUDebugTargetInfo.HatredTargetNiaActor != null && bGUDebugTargetInfo.HatredTargetNiaActor.Count != 0)
		{
			for (int num = 0; num < bGUDebugTargetInfo.HatredTargetNiaActor.Count; num++)
			{
				if (bGUDebugTargetInfo.HatredTargetNiaActor[num] != null)
				{
					bGUDebugTargetInfo.HatredTargetNiaActor[num].SetVisibility(Vis: false);
					DebugTargetMgrData.DebugNiaActorPool.Add(bGUDebugTargetInfo.HatredTargetNiaActor[num]);
					bGUDebugTargetInfo.HatredTargetNiaActor[num] = null;
				}
			}
			bGUDebugTargetInfo.HatredTargetNiaActor.Clear();
		}
		DebugTargetMgrData.DebugTargetInfos.Remove(bGUDebugTargetInfo);
	}

	private void CleanDebugTargetInfo(BGUDebugTargetInfo Info)
	{
		Info.Self = null;
		CollectNiaActor(ref Info.AITargetNiaActor);
		CollectNiaActor(ref Info.AOTargetNiaActor);
		CollectNiaActor(ref Info.SkillBaseTargetNiaActor);
		CollectNiaActor(ref Info.ComboTargetNiaActor);
		if (Info.HatredTargetNiaActor == null || Info.HatredTargetNiaActor.Count == 0)
		{
			return;
		}
		for (int i = 0; i < Info.HatredTargetNiaActor.Count; i++)
		{
			if (Info.HatredTargetNiaActor[i] != null)
			{
				Info.HatredTargetNiaActor[i].SetVisibility(Vis: false);
				DebugTargetMgrData.DebugNiaActorPool.Add(Info.HatredTargetNiaActor[i]);
				Info.HatredTargetNiaActor[i] = null;
			}
		}
		Info.HatredTargetNiaActor.Clear();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public void OnAOSearchDebugDraw(AActor Actor)
	{
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc != null)
		{
			int searchAOTargetXYDistance = unitBattleInfoExtendDesc.SearchAOTargetXYDistance;
			int searchAOTargetZDistance = unitBattleInfoExtendDesc.SearchAOTargetZDistance;
			int num = ((unitBattleInfoExtendDesc.LeaveAOTargetXYDistance >= searchAOTargetXYDistance) ? unitBattleInfoExtendDesc.LeaveAOTargetXYDistance : (searchAOTargetXYDistance + 1000));
			if (unitBattleInfoExtendDesc.LeaveAOTargetZDistance >= searchAOTargetZDistance)
			{
				_ = unitBattleInfoExtendDesc.LeaveAOTargetZDistance;
			}
			USystemLibrary.DrawDebugCircle(Owner.World, Actor.GetActorLocation(), num, 20, FLinearColor.Red, 0.1f, 20f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
			USystemLibrary.DrawDebugCircle(Owner.World, Actor.GetActorLocation(), searchAOTargetXYDistance, 20, FLinearColor.Blue, 0.1f, 20f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		for (int i = 0; i < DebugTargetMgrData.DebugTargetInfos.Count; i++)
		{
			BGUDebugTargetInfo bGUDebugTargetInfo = DebugTargetMgrData.DebugTargetInfos[i];
			IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(bGUDebugTargetInfo.Self);
			if (bGUDebugTargetInfo.Self == null || bGUDebugTargetInfo.Self.IsDestroyed || (unPersistentReadOnlyData != null && unPersistentReadOnlyData.HasState(EBGUUnitState.Dead)))
			{
				CleanDebugTargetInfo(bGUDebugTargetInfo);
				continue;
			}
			BGUCharacterCS self = bGUDebugTargetInfo.Self;
			int masks = bGUDebugTargetInfo.Masks;
			BUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(self);
			FVector actorLocation = self.GetActorLocation();
			if ((masks & 1) != 0)
			{
				if (readOnlyData.GetTargetInfo() != null && readOnlyData.GetTargetInfo().LockTargetActor != null)
				{
					UpdateDebugNia(ref bGUDebugTargetInfo.AITargetNiaActor, actorLocation, readOnlyData.GetTargetInfo().LockTargetActor.GetActorLocation(), FLinearColor.Green, 0.4f, 9f);
				}
				else if (bGUDebugTargetInfo.AITargetNiaActor != null)
				{
					CollectNiaActor(ref bGUDebugTargetInfo.AITargetNiaActor);
				}
			}
			else
			{
				CollectNiaActor(ref bGUDebugTargetInfo.AITargetNiaActor);
			}
			if ((masks & 2) != 0)
			{
				OnAOSearchDebugDraw(bGUDebugTargetInfo.Self);
				if (readOnlyData.GetAOTarget().LockTargetActor != null)
				{
					UpdateDebugNia(ref bGUDebugTargetInfo.AOTargetNiaActor, actorLocation, readOnlyData.GetAOTarget().LockTargetActor.GetActorLocation(), FLinearColor.Red, 0.4f, 8f);
				}
				else if (bGUDebugTargetInfo.AOTargetNiaActor != null)
				{
					CollectNiaActor(ref bGUDebugTargetInfo.AOTargetNiaActor);
				}
			}
			else
			{
				CollectNiaActor(ref bGUDebugTargetInfo.AOTargetNiaActor);
			}
			if ((masks & 4) != 0)
			{
				if (readOnlyData.GetSkillBaseTarget().LockTargetActor != null)
				{
					UpdateDebugNia(ref bGUDebugTargetInfo.SkillBaseTargetNiaActor, actorLocation, readOnlyData.GetSkillBaseTarget().LockTargetActor.GetActorLocation(), FLinearColor.Yellow, 0.4f, 7f);
				}
				else if (bGUDebugTargetInfo.SkillBaseTargetNiaActor != null)
				{
					CollectNiaActor(ref bGUDebugTargetInfo.SkillBaseTargetNiaActor);
				}
			}
			else
			{
				CollectNiaActor(ref bGUDebugTargetInfo.SkillBaseTargetNiaActor);
			}
			if ((masks & 8) != 0)
			{
				if (readOnlyData.GetComboTarget().LockTargetActor != null)
				{
					UpdateDebugNia(ref bGUDebugTargetInfo.ComboTargetNiaActor, actorLocation, readOnlyData.GetComboTarget().LockTargetActor.GetActorLocation(), FLinearColor.Blue, 0.4f, 6f);
				}
				else if (bGUDebugTargetInfo.ComboTargetNiaActor != null)
				{
					CollectNiaActor(ref bGUDebugTargetInfo.ComboTargetNiaActor);
				}
			}
			else
			{
				CollectNiaActor(ref bGUDebugTargetInfo.ComboTargetNiaActor);
			}
			if ((masks & 0x10) != 0)
			{
				if (readOnlyData.GetMoveToTarget().LockTargetActor != null)
				{
					UpdateDebugNia(ref bGUDebugTargetInfo.MoveToTargetNiaActor, actorLocation, readOnlyData.GetMoveToTarget().LockTargetActor.GetActorLocation(), FLinearColor.Orange, 0.4f, 6f);
				}
				else if (bGUDebugTargetInfo.MoveToTargetNiaActor != null)
				{
					CollectNiaActor(ref bGUDebugTargetInfo.MoveToTargetNiaActor);
				}
			}
			else
			{
				CollectNiaActor(ref bGUDebugTargetInfo.MoveToTargetNiaActor);
			}
			if ((masks & 0x20) != 0)
			{
				BUC_UnitHatredData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitHatredData>(self);
				if (self.IsPlayerControlled())
				{
					if (readOnlyData2.HatredTargetInfoList.Count > 0)
					{
						for (int j = 0; j < readOnlyData2.HatredTargetInfoList.Count; j++)
						{
							if (bGUDebugTargetInfo.HatredTargetNiaActor.Count < j + 1)
							{
								bGUDebugTargetInfo.HatredTargetNiaActor.Add(GetNiaActorFromPool());
							}
							if (bGUDebugTargetInfo.HatredTargetNiaActor[j] == null)
							{
								bGUDebugTargetInfo.HatredTargetNiaActor[j] = GetNiaActorFromPool();
							}
							BGUDebugNiaActor NiaActor = bGUDebugTargetInfo.HatredTargetNiaActor[j];
							UpdateDebugNia(ref NiaActor, actorLocation, readOnlyData2.HatredTargetInfoList[j].HatredTargetActor.GetActorLocation(), FLinearColor.Black, 0.3f, 5f);
						}
						if (readOnlyData2.HatredTargetInfoList.Count >= bGUDebugTargetInfo.HatredTargetNiaActor.Count)
						{
							continue;
						}
						for (int k = readOnlyData2.HatredTargetInfoList.Count; k < bGUDebugTargetInfo.HatredTargetNiaActor.Count; k++)
						{
							if (bGUDebugTargetInfo.HatredTargetNiaActor[k] != null)
							{
								bGUDebugTargetInfo.HatredTargetNiaActor[k].SetVisibility(Vis: false);
								DebugTargetMgrData.DebugNiaActorPool.Add(bGUDebugTargetInfo.HatredTargetNiaActor[k]);
								bGUDebugTargetInfo.HatredTargetNiaActor[k] = null;
							}
						}
					}
					else
					{
						if (bGUDebugTargetInfo.HatredTargetNiaActor == null)
						{
							continue;
						}
						for (int l = 0; l < bGUDebugTargetInfo.HatredTargetNiaActor.Count; l++)
						{
							if (bGUDebugTargetInfo.HatredTargetNiaActor[l] != null)
							{
								bGUDebugTargetInfo.HatredTargetNiaActor[l].SetVisibility(Vis: false);
								DebugTargetMgrData.DebugNiaActorPool.Add(bGUDebugTargetInfo.HatredTargetNiaActor[l]);
								bGUDebugTargetInfo.HatredTargetNiaActor[l] = null;
							}
						}
						bGUDebugTargetInfo.HatredTargetNiaActor.Clear();
					}
				}
				else if (readOnlyData2.HatredTargetInfoList.Count > 0)
				{
					for (int m = 0; m < readOnlyData2.HatredTargetInfoList.Count; m++)
					{
						if (bGUDebugTargetInfo.HatredTargetNiaActor.Count < m + 1)
						{
							bGUDebugTargetInfo.HatredTargetNiaActor.Add(GetNiaActorFromPool());
						}
						if (bGUDebugTargetInfo.HatredTargetNiaActor[m] == null)
						{
							bGUDebugTargetInfo.HatredTargetNiaActor[m] = GetNiaActorFromPool();
						}
						BGUDebugNiaActor NiaActor2 = bGUDebugTargetInfo.HatredTargetNiaActor[m];
						UpdateDebugNia(ref NiaActor2, actorLocation, readOnlyData2.HatredTargetInfoList[m].HatredTargetActor.GetActorLocation(), FLinearColor.Black, 0.3f, 5f);
					}
					if (readOnlyData2.HatredTargetInfoList.Count >= bGUDebugTargetInfo.HatredTargetNiaActor.Count)
					{
						continue;
					}
					for (int n = readOnlyData2.HatredTargetInfoList.Count; n < bGUDebugTargetInfo.HatredTargetNiaActor.Count; n++)
					{
						if (bGUDebugTargetInfo.HatredTargetNiaActor[n] != null)
						{
							bGUDebugTargetInfo.HatredTargetNiaActor[n].SetVisibility(Vis: false);
							DebugTargetMgrData.DebugNiaActorPool.Add(bGUDebugTargetInfo.HatredTargetNiaActor[n]);
							bGUDebugTargetInfo.HatredTargetNiaActor[n] = null;
						}
					}
				}
				else
				{
					if (bGUDebugTargetInfo.HatredTargetNiaActor == null)
					{
						continue;
					}
					for (int num = 0; num < bGUDebugTargetInfo.HatredTargetNiaActor.Count; num++)
					{
						if (bGUDebugTargetInfo.HatredTargetNiaActor[num] != null)
						{
							bGUDebugTargetInfo.HatredTargetNiaActor[num].SetVisibility(Vis: false);
							DebugTargetMgrData.DebugNiaActorPool.Add(bGUDebugTargetInfo.HatredTargetNiaActor[num]);
							bGUDebugTargetInfo.HatredTargetNiaActor[num] = null;
						}
					}
					bGUDebugTargetInfo.HatredTargetNiaActor.Clear();
				}
			}
			else
			{
				if (bGUDebugTargetInfo.HatredTargetNiaActor == null)
				{
					continue;
				}
				for (int num2 = 0; num2 < bGUDebugTargetInfo.HatredTargetNiaActor.Count; num2++)
				{
					if (bGUDebugTargetInfo.HatredTargetNiaActor[num2] != null)
					{
						bGUDebugTargetInfo.HatredTargetNiaActor[num2].SetVisibility(Vis: false);
						DebugTargetMgrData.DebugNiaActorPool.Add(bGUDebugTargetInfo.HatredTargetNiaActor[num2]);
						bGUDebugTargetInfo.HatredTargetNiaActor[num2] = null;
					}
				}
				bGUDebugTargetInfo.HatredTargetNiaActor.Clear();
			}
		}
	}
}
