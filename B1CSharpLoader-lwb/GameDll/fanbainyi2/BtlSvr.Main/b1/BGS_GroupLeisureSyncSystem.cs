using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_GroupLeisureSyncSystem : GameStateSystemBase
{
	private BGC_GroupLeisureSyncData GroupLeisureSyncData;

	public override void OnAttach()
	{
		base.BGSEventCollection.Evt_BGS_OnSyncPlayGroupLeisureMontage += new Del_OnSyncPlayGroupLeisureMontage(OnSyncPlayGroupLeisureMontage);
		GroupLeisureSyncData = RequireWritableData<BGC_GroupLeisureSyncData>();
		SetCanTick(Val: false);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_OnSyncPlayGroupLeisureMontage -= new Del_OnSyncPlayGroupLeisureMontage(OnSyncPlayGroupLeisureMontage);
	}

	public float OnSyncPlayGroupLeisureMontage(AActor Actor, UAnimMontage Montage)
	{
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (bGUCharacterCS == null || !USystemLibrary.IsValid(bGUCharacterCS))
		{
			return -1f;
		}
		IBUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(bGUCharacterCS);
		if (GroupLeisureSyncData == null || readOnlyData == null || !GameplayTagExtension.IsValid(readOnlyData.UnitFixedGuidForGroup))
		{
			return -1f;
		}
		if (!GroupLeisureSyncData.GroupLeisureSyncMemberDic.ContainsKey(readOnlyData.UnitFixedGuidForGroup))
		{
			GroupLeisureSyncData.GroupLeisureSyncMemberDic.Add(readOnlyData.UnitFixedGuidForGroup, new HashSet<AActor>());
		}
		if (!GroupLeisureSyncData.GroupLeisureSyncMontageDic.TryGetValue(readOnlyData.UnitFixedGuidForGroup, out var value))
		{
			GroupLeisureSyncData.GroupLeisureSyncMontageDic.Add(readOnlyData.UnitFixedGuidForGroup, Montage);
		}
		else if (value == null || !USystemLibrary.IsValid(value))
		{
			GroupLeisureSyncData.GroupLeisureSyncMontageDic[readOnlyData.UnitFixedGuidForGroup] = Montage;
		}
		else if (value != Montage)
		{
			BGW_LogUtil.LogError("GroupLeisureSyncSystem  Group %s Has Diffrent Leisure Montage!", readOnlyData.UnitFixedGuidForGroup.ToString());
			return -1f;
		}
		GroupLeisureSyncData.GroupLeisureSyncMemberDic.TryGetValue(readOnlyData.UnitFixedGuidForGroup, out var value2);
		if (GroupLeisureSyncData.GroupLeisureSyncLeaderDic.TryGetValue(readOnlyData.UnitFixedGuidForGroup, out var value3) && USystemLibrary.IsValid(value3) && value3 is BGUCharacterCS bGUCharacterCS2)
		{
			IBUC_PatrolData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(bGUCharacterCS2);
			float num = UBGUFunctionLibrary.BGUGetActiveMontagePosition(bGUCharacterCS2, Montage);
			if (unPersistentReadOnlyData != null && num >= 0f)
			{
				if (!value2.Contains(Actor))
				{
					value2.Add(Actor);
				}
				IBUC_PatrolData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(bGUCharacterCS);
				if (unPersistentReadOnlyData2 != null)
				{
					FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS2) - unPersistentReadOnlyData.StartLeisureLocation;
					fVector.Z = 0f;
					BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUCharacterCS, unPersistentReadOnlyData2.StartLeisureLocation + fVector, bSweep: false, bTeleport: false);
					BGUFuncLibAnim.BGUActorTryPlayMontage(Actor, Montage, FName.None, EMontageBindReason.Patrol, 1f, 1f, num);
					GroupLeisureSyncData.GroupLeisureSyncMemberDic[readOnlyData.UnitFixedGuidForGroup] = value2;
					return num;
				}
				return -1f;
			}
			AActor aActor = TryGetNextLeader(ref value2, Montage);
			if (aActor != null)
			{
				GroupLeisureSyncData.GroupLeisureSyncLeaderDic.Remove(readOnlyData.UnitFixedGuidForGroup);
				GroupLeisureSyncData.GroupLeisureSyncLeaderDic.Add(readOnlyData.UnitFixedGuidForGroup, aActor);
				num = UBGUFunctionLibrary.BGUGetActiveMontagePosition(aActor as BGUCharacterCS, Montage);
				if (num >= 0f)
				{
					if (!value2.Contains(Actor))
					{
						value2.Add(Actor);
					}
					unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(bGUCharacterCS2);
					IBUC_PatrolData unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(bGUCharacterCS);
					if (unPersistentReadOnlyData3 != null)
					{
						FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS2) - unPersistentReadOnlyData.StartLeisureLocation;
						fVector2.Z = 0f;
						BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUCharacterCS, unPersistentReadOnlyData3.StartLeisureLocation + fVector2, bSweep: false, bTeleport: false);
						BGUFuncLibAnim.BGUActorTryPlayMontage(Actor, Montage, FName.None, EMontageBindReason.Patrol, 1f, 1f, num);
						GroupLeisureSyncData.GroupLeisureSyncMemberDic[readOnlyData.UnitFixedGuidForGroup] = value2;
						return num;
					}
					return -1f;
				}
			}
		}
		GroupLeisureSyncData.GroupLeisureSyncLeaderDic.Remove(readOnlyData.UnitFixedGuidForGroup);
		if (BGUFuncLibAnim.BGUActorTryPlayMontage(Actor, Montage, FName.None, EMontageBindReason.Patrol) > 0f)
		{
			if (!value2.Contains(Actor))
			{
				value2.Add(Actor);
			}
			GroupLeisureSyncData.GroupLeisureSyncLeaderDic.Add(readOnlyData.UnitFixedGuidForGroup, Actor);
		}
		GroupLeisureSyncData.GroupLeisureSyncMemberDic[readOnlyData.UnitFixedGuidForGroup] = value2;
		if (GroupLeisureSyncData.GroupLeisureSyncLeaderDic.Count > 0)
		{
			SetCanTick(Val: true);
		}
		return 0f;
	}

	private AActor TryGetNextLeader(ref HashSet<AActor> MemberSet, UAnimMontage Montage)
	{
		List<AActor> list = new List<AActor>();
		list.Capacity = MemberSet.Count;
		AActor result = null;
		foreach (AActor item in MemberSet)
		{
			if (!USystemLibrary.IsValid(item))
			{
				list.Add(item);
			}
			else if (item is BGUCharacterCS actor)
			{
				IBUC_PatrolData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(item);
				if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.bIsInLeisure && UBGUFunctionLibrary.BGUGetActiveMontagePosition(actor, Montage) > 0f)
				{
					result = item;
				}
			}
		}
		if (list.Count > 0)
		{
			foreach (AActor item2 in list)
			{
				MemberSet.Remove(item2);
			}
		}
		return result;
	}

	public override int GetTickGroupMask()
	{
		return 2048;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		List<AActor> list = new List<AActor>();
		List<FGameplayTag> list2 = new List<FGameplayTag>();
		foreach (KeyValuePair<FGameplayTag, HashSet<AActor>> item in GroupLeisureSyncData.GroupLeisureSyncMemberDic)
		{
			FGameplayTag key = item.Key;
			HashSet<AActor> MemberSet = item.Value;
			if (MemberSet.Count == 0 || !GroupLeisureSyncData.GroupLeisureSyncMontageDic.TryGetValue(key, out var value) || value == null || !USystemLibrary.IsValid(value))
			{
				continue;
			}
			BGUCharacterCS bGUCharacterCS = null;
			if (GroupLeisureSyncData.GroupLeisureSyncLeaderDic.TryGetValue(key, out var value2))
			{
				bGUCharacterCS = value2 as BGUCharacterCS;
				if (bGUCharacterCS == null)
				{
					AActor aActor = TryGetNextLeader(ref MemberSet, value);
					if (aActor != null)
					{
						bGUCharacterCS = aActor as BGUCharacterCS;
						GroupLeisureSyncData.GroupLeisureSyncLeaderDic[key] = bGUCharacterCS;
					}
				}
			}
			if (bGUCharacterCS == null || !USystemLibrary.IsValid(bGUCharacterCS))
			{
				AActor aActor2 = TryGetNextLeader(ref MemberSet, value);
				if (aActor2 != null)
				{
					bGUCharacterCS = aActor2 as BGUCharacterCS;
					GroupLeisureSyncData.GroupLeisureSyncLeaderDic[key] = bGUCharacterCS;
				}
			}
			IBUC_PatrolData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(bGUCharacterCS);
			if (unPersistentReadOnlyData == null || !unPersistentReadOnlyData.bIsInLeisure)
			{
				AActor aActor3 = TryGetNextLeader(ref MemberSet, value);
				if (!(aActor3 != null))
				{
					list2.Add(key);
					continue;
				}
				bGUCharacterCS = aActor3 as BGUCharacterCS;
				GroupLeisureSyncData.GroupLeisureSyncLeaderDic[key] = bGUCharacterCS;
				unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(bGUCharacterCS);
				if (unPersistentReadOnlyData == null)
				{
					list2.Add(key);
					continue;
				}
			}
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) - unPersistentReadOnlyData.StartLeisureLocation;
			fVector.Z = 0f;
			fVector = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUCharacterCS).Quaternion().Inverse() * fVector;
			float position = UBGUFunctionLibrary.BGUGetActiveMontagePosition(bGUCharacterCS, value);
			foreach (AActor item2 in MemberSet)
			{
				if (!USystemLibrary.IsValid(item2))
				{
					list.Add(item2);
				}
				else
				{
					if (!(item2 is BGUCharacterCS bGUCharacterCS2) || !(item2 != bGUCharacterCS))
					{
						continue;
					}
					IBUC_PatrolData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PatrolData, BUC_PatrolData>(bGUCharacterCS2);
					if (unPersistentReadOnlyData2 != null && unPersistentReadOnlyData2.bIsInLeisure)
					{
						FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUCharacterCS2).Quaternion() * fVector;
						BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUCharacterCS2, unPersistentReadOnlyData2.StartLeisureLocation + fVector2, bSweep: false, bTeleport: false);
						UBGUFunctionLibrary.BGUSetActiveMontagePosition(bGUCharacterCS2, value, position);
						if (GSGameplayCVar.CVar_GroupLeisureDebugDraw.GetValueInGameThread() != 0)
						{
							USystemLibrary.DrawDebugSphere(Owner, bGUCharacterCS2.GetActorLocation(), 5f, 10, FLinearColor.Blue, 2f, 2f);
							USystemLibrary.DrawDebugArrow(Owner, unPersistentReadOnlyData2.StartLeisureLocation, unPersistentReadOnlyData2.StartLeisureLocation + fVector2, 20f, FLinearColor.Blue, 2f, 2f);
						}
					}
				}
			}
			if (GSGameplayCVar.CVar_GroupLeisureDebugDraw.GetValueInGameThread() != 0)
			{
				USystemLibrary.DrawDebugArrow(Owner, unPersistentReadOnlyData.StartLeisureLocation, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS), 20f, FLinearColor.Red, 2f, 1f);
			}
		}
		foreach (KeyValuePair<FGameplayTag, UAnimMontage> item3 in GroupLeisureSyncData.GroupLeisureSyncMontageDic)
		{
			FGameplayTag key2 = item3.Key;
			if (!GroupLeisureSyncData.GroupLeisureSyncMemberDic.TryGetValue(key2, out var value3))
			{
				continue;
			}
			foreach (AActor item4 in list)
			{
				value3.Remove(item4);
			}
			if (value3.Count == 0)
			{
				list2.Add(key2);
			}
		}
		foreach (FGameplayTag item5 in list2)
		{
			GroupLeisureSyncData.GroupLeisureSyncMemberDic.Remove(item5);
			GroupLeisureSyncData.GroupLeisureSyncMontageDic.Remove(item5);
			GroupLeisureSyncData.GroupLeisureSyncLeaderDic.Remove(item5);
		}
		if (GroupLeisureSyncData.GroupLeisureSyncLeaderDic.Count == 0)
		{
			SetCanTick(Val: false);
		}
	}
}
