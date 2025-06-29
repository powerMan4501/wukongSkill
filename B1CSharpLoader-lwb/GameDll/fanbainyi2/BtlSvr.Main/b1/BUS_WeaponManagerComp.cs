using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using Diana.Common;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_WeaponManagerComp : UActorCompBaseCS
{
	private BUC_WeaponManagerData WeaponManagerData;

	private IBUC_ConfigInfoData ConfigInfoData;

	private IBUC_GuidData GuidData;

	public override void OnAttach()
	{
		WeaponManagerData = RequireWritableData<BUC_WeaponManagerData>();
		ConfigInfoData = RequireReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_ToggleWeaponsStatus_ByNotifyState += new Del_ToggleWeaponsStatus_ByNotifyState(OnToggleWeaponsStatus_ByNotifyState);
		base.BUSEventCollection.Evt_ToggleWeaponsStatus_ByEffect += new Del_ToggleWeaponsStatus_ByEffect(OnToggleWeaponsStatus_ByEffect);
		base.BUSEventCollection.Evt_ToggleWeaponsStatus_ByOtherComp += new Del_ToggleWeaponsStatus_ByOtherComp(OnToggleWeaponsStatus_ByOtherComp);
		base.BUSEventCollection.Evt_StopWeaponStatusSwitch += new Del_Void(OnStopWeaponStatusSwitch);
		base.BUSEventCollection.Evt_AttachWeapon += new Del_AttachWeapon(OnAttachWeapon);
		base.BUSEventCollection.Evt_DetachWeapon += new Del_DetachWeapon(OnDetachWeapon);
		base.BUSEventCollection.Evt_DetachAllWeaponForDead += new Del_Void_Float(OnDetachAllWeaponForDead);
		base.BUSEventCollection.Evt_AddTempOverrideWeapon += new Del_SetWeaponInfo(OnAddTempOverrideWeapon);
		base.BUSEventCollection.Evt_ClearTempOverrideWeapon += new Del_Void(OnClearTempOverrideWeapon);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_OnWeaponDestroyed += new Del_OnWeaponDestroyed(OnWeaponDestroyed);
	}

	private void OnWeaponDestroyed(BGUWeaponBase Weapon)
	{
		int num = -1;
		foreach (KeyValuePair<int, FWeaponInfo> weapon in WeaponManagerData.Weapons)
		{
			if (weapon.Value.IsSameWeapon(Weapon))
			{
				num = weapon.Key;
			}
		}
		if (num >= 0 && WeaponManagerData.Weapons.TryGetValue(num, out var _))
		{
			WeaponManagerData.Weapons.Remove(num);
		}
		WeaponManagerData.bWeaponChangedFlag = true;
		BUS_DispLibEventCollection.Get(Owner)?.Evt_RemoveChildActorMeshCompsFromManager?.Invoke(Weapon);
	}

	public override void PreBeginPlay()
	{
		WeaponManagerData.bTempOverrideWeapons = false;
		WeaponManagerData.IsStopStatusSwitch = false;
		Reset_SpawnAndInitWeapons();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (EndPlayReason != EEndPlayReason.LevelTransition)
		{
			ClearWeapon();
			if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
			{
				base.BGSEventCollection.Evt_ClearWeaponInfo.Invoke(GuidData.GetFinalGuid());
			}
		}
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		WeaponManagerData.IsStopStatusSwitch = false;
		Reset_SpawnAndInitWeapons();
	}

	protected virtual void OnDetachWeapon(int Index, EDetachmentRule LocationRule = EDetachmentRule.KeepWorld, EDetachmentRule RotationRule = EDetachmentRule.KeepWorld, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative, float WeaponDestroyDelayTime = 10f, bool WeaponEnablePhysic = true)
	{
		BGUWeaponBase bGUWeaponBase = WeaponManagerData.FindWeaponByIndex(Index) as BGUWeaponBase;
		if (bGUWeaponBase != null)
		{
			if (WeaponManagerData.Weapons.TryGetValue(Index, out var value))
			{
				value.SetAttached(b: false);
			}
			if (WeaponEnablePhysic)
			{
				WeaponManagerData.Weapons.Remove(Index);
			}
			BUS_EventCollectionCS.Get(bGUWeaponBase)?.Evt_HandleWeaponDetach.Invoke(LocationRule, RotationRule, ScaleRule, WeaponDestroyDelayTime, WeaponEnablePhysic);
		}
	}

	protected void OnDetachAllWeaponForDead(float WeaponDestroyDelayTime)
	{
		foreach (int item in WeaponManagerData.Weapons.Keys.ToList())
		{
			BGUWeaponBase bGUWeaponBase = WeaponManagerData.FindWeaponByIndex(item) as BGUWeaponBase;
			if (!bGUWeaponBase.IsNullOrDestroyed())
			{
				b1.IBUC_WeaponCommData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_WeaponCommData, BUC_WeaponCommData>(bGUWeaponBase);
				if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.bIsActive)
				{
					OnDetachWeapon(item, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, WeaponDestroyDelayTime);
				}
			}
		}
	}

	protected virtual void OnAttachWeapon(AActor Actor, int Index, FName SocketName, EAttachmentRule LocationRule = EAttachmentRule.SnapToTarget, EAttachmentRule RotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule ScaleRule = EAttachmentRule.KeepRelative)
	{
		BGUWeaponBase bGUWeaponBase = Actor as BGUWeaponBase;
		if (bGUWeaponBase == null)
		{
			return;
		}
		ABGUCharacter aBGUCharacter = GetOwner() as ABGUCharacter;
		if (aBGUCharacter.IsNullOrDestroyed())
		{
			return;
		}
		bool flag = false;
		if (WeaponManagerData.Weapons.TryGetValue(Index, out var value))
		{
			if (value.Weapon.IsValid() && value.IsSameWeapon(bGUWeaponBase))
			{
				flag = true;
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUWeaponBase);
				if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
				{
					bUS_GSEventCollection.Evt_HandleWeaponReset.Invoke();
				}
			}
			else
			{
				OnDetachWeapon(Index, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, 10f, WeaponEnablePhysic: false);
			}
		}
		foreach (UActorComponent item in aBGUCharacter.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
			if (uSkeletalMeshComponent != null && uSkeletalMeshComponent.GetAllSocketNames().Contains(SocketName))
			{
				bGUWeaponBase.AttachToComponent(aBGUCharacter.Mesh, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies: true);
				break;
			}
		}
		if (flag)
		{
			value.SetAttached(b: true);
		}
		else
		{
			FWeaponInfo fWeaponInfo = new FWeaponInfo(bGUWeaponBase);
			fWeaponInfo.SetAttached(b: true);
			WeaponManagerData.Weapons.Add(Index, fWeaponInfo);
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection == null)
		{
			BGW_LogUtil.LogError("[DBC] BUS_WeaponManagerComp attach one weapon actor on AttachWeapon() Func. But get BUS_DispLibEventCollection is null.");
		}
		bUS_DispLibEventCollection?.Evt_AddChildActorMeshCompsToManager?.Invoke(bGUWeaponBase);
		WeaponManagerData.bWeaponChangedFlag = true;
	}

	protected virtual void TrySpawnInitOneWeapon(in FUnitWeapon WeaponCfg, int WeaponIndex)
	{
		ABGUCharacter aBGUCharacter = GetOwner() as ABGUCharacter;
		TSubclassOf<AActor> weapon = WeaponCfg.Weapon;
		if (weapon.Value.IsNullOrDestroyed() || aBGUCharacter.IsNullOrDestroyed())
		{
			return;
		}
		bool flag = false;
		if (WeaponManagerData.Weapons.TryGetValue(WeaponIndex, out var value))
		{
			flag = value.Weapon != null && value.Weapon.IsValid();
		}
		BGUWeaponBase bGUWeaponBase = null;
		if (flag)
		{
			bGUWeaponBase = value.Weapon.Get();
			if (value.bAttached)
			{
				OnDetachWeapon(WeaponIndex, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepRelative, -1f, WeaponEnablePhysic: false);
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUWeaponBase);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
			{
				bUS_GSEventCollection.Evt_HandleWeaponReset.Invoke();
			}
			bGUWeaponBase.AttachToComponent(aBGUCharacter.Mesh, WeaponCfg.SocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: true);
			BUS_DispLibEventCollection.Get(Owner)?.Evt_AddChildActorMeshCompsToManager?.Invoke(bGUWeaponBase);
			value.SetAttached(b: true);
			value.SetActive(GetWeaponDefaultActive(WeaponIndex));
			return;
		}
		bGUWeaponBase = BGU_UnrealActorUtil.BGUBeginDeferredActorSpawnFromClass(aBGUCharacter, weapon, FTransform.Identity, ESpawnActorCollisionHandlingMethod.Undefined, aBGUCharacter) as BGUWeaponBase;
		if (!(bGUWeaponBase == null))
		{
			UBGUFunctionLibrary.BGUFinishSpawningActor(bGUWeaponBase, FTransform.Identity);
			if (bGUWeaponBase.GetActorGuid(out var OutActorGuid))
			{
				base.BGSEventCollection.Evt_RegisterWeaponInfo.Invoke(GuidData.GetFinalGuid(), OutActorGuid);
			}
			bGUWeaponBase.AttachToComponent(aBGUCharacter.Mesh, WeaponCfg.SocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: true);
			BUS_DispLibEventCollection.Get(Owner)?.Evt_AddChildActorMeshCompsToManager?.Invoke(bGUWeaponBase);
			FWeaponInfo fWeaponInfo = new FWeaponInfo(bGUWeaponBase);
			fWeaponInfo.SetAttached(b: true);
			fWeaponInfo.SetActive(GetWeaponDefaultActive(WeaponIndex));
			if (WeaponManagerData.Weapons.ContainsKey(WeaponIndex))
			{
				WeaponManagerData.Weapons[WeaponIndex] = fWeaponInfo;
			}
			else
			{
				WeaponManagerData.Weapons.Add(WeaponIndex, fWeaponInfo);
			}
		}
	}

	private void Reset_SpawnAndInitWeapons()
	{
		if (!(GetOwner() as ABGUCharacter).IsNullOrDestroyed() && ConfigInfoData != null && WeaponManagerData != null)
		{
			if (WeaponManagerData.bWeaponChangedFlag || WeaponManagerData.Weapons.Count != ConfigInfoData.Weapons.Count)
			{
				ClearWeapon();
			}
			for (int i = 0; i < ConfigInfoData.Weapons.Count; i++)
			{
				TrySpawnInitOneWeapon(ConfigInfoData.Weapons[i], i);
			}
		}
	}

	private void ClearWeapon()
	{
		foreach (KeyValuePair<int, FWeaponInfo> weapon2 in WeaponManagerData.Weapons)
		{
			TStrongObjectPtr<BGUWeaponBase> weapon = weapon2.Value.Weapon;
			if (!(weapon != null))
			{
				continue;
			}
			BGUWeaponBase bGUWeaponBase = weapon.Get();
			if (bGUWeaponBase != null)
			{
				bGUWeaponBase.DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
				if (bGUWeaponBase.GetActorGuid(out var OutActorGuid) && base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
				{
					base.BGSEventCollection.Evt_UnRegisterWeaponInfo.Invoke(GuidData.GetFinalGuid(), OutActorGuid);
				}
				BUS_DispLibEventCollection.Get(Owner)?.Evt_RemoveChildActorMeshCompsFromManager?.Invoke(bGUWeaponBase);
				BGU_UnrealWorldUtil.DestroyActor(bGUWeaponBase);
			}
		}
		WeaponManagerData.Weapons.Clear();
	}

	private void OnToggleWeaponsStatus_ByNotifyState(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int MontageInstanceID, int NotifyUniqueID)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>=========================NotifyState切换武器状态开始=========================</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, $"<character>{Owner.GetName()}</><action>MontageInstanceID = </><effect>{MontageInstanceID}</><action>，NotifyUniqueID = </><effect>{NotifyUniqueID}</>");
		}
		ToggleWeaponsStatus_Internal(WeaponIndexes, TriggerActivate, NeedOverride, MontageInstanceID, NotifyUniqueID, Reset2Default: false);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>=========================NotifyState切换武器状态结束=========================</>");
		}
	}

	private void OnToggleWeaponsStatus_ByOtherComp(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, EToggleWeaponStatusCompType CompType)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>=========================其他逻辑Comp切换武器状态开始=========================</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, $"<character>{Owner.GetName()}</><action>触发切换逻辑的Comp是：<effect>{CompType}</>");
		}
		int iD = -1;
		int iD2 = -1;
		switch (CompType)
		{
		case EToggleWeaponStatusCompType.MagicallyChange:
			iD = -2;
			iD2 = -2;
			break;
		case EToggleWeaponStatusCompType.TempOverrideWeapon:
			iD = -1;
			iD2 = -1;
			break;
		}
		ToggleWeaponsStatus_Internal(WeaponIndexes, TriggerActivate, NeedOverride, iD, iD2, Reset2Default: false);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>=========================其他逻辑Comp切换武器状态结束=========================</>");
		}
	}

	private void OnToggleWeaponsStatus_ByEffect(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int FlagID1, int FlagID2, bool Reset2Default)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>=========================BuffOrSkillEffect切换武器状态开始=========================</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, $"<character>{Owner.GetName()}</><action>ID1 = </><effect>{FlagID1}</><action>，ID2 = </><effect>{FlagID2}</>");
		}
		ToggleWeaponsStatus_Internal(WeaponIndexes, TriggerActivate, NeedOverride, FlagID1, FlagID2, Reset2Default);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>=========================BuffOrSkillEffect切换武器状态结束=========================</>");
		}
	}

	private void ToggleWeaponsStatus_Internal(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int ID1, int ID2, bool Reset2Default)
	{
		if (WeaponManagerData.IsStopStatusSwitch)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>因为死亡，关闭了状态修改！！！</>");
			}
			return;
		}
		if (WeaponIndexes.Contains(-1))
		{
			foreach (KeyValuePair<int, FWeaponInfo> weapon3 in WeaponManagerData.Weapons)
			{
				if (weapon3.Value.Weapon.IsValid())
				{
					BGUWeaponBase weapon = weapon3.Value.Weapon.Get();
					SetOneWeaponStatus(weapon, weapon3.Key, TriggerActivate, NeedOverride, ID1, ID2, Reset2Default);
				}
			}
			return;
		}
		foreach (int WeaponIndex in WeaponIndexes)
		{
			BGUWeaponBase weapon2 = WeaponManagerData.FindWeaponByIndex(WeaponIndex) as BGUWeaponBase;
			SetOneWeaponStatus(weapon2, WeaponIndex, TriggerActivate, NeedOverride, ID1, ID2, Reset2Default);
		}
	}

	private void OnStopWeaponStatusSwitch()
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, "<character>" + Owner.GetName() + "</><action>死亡禁用武器状态切换！！！</>");
		}
		WeaponManagerData.IsStopStatusSwitch = true;
	}

	private void SetOneWeaponStatus(BGUWeaponBase Weapon, int WeaponIndex, bool TriggerActivate, bool NeedOverride, int ID1, int ID2, bool Reset2Default)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, $"<character>{Owner.GetName()}</><action>切换武器状态，武器Index：</><effect>{WeaponIndex}</><action></>");
		}
		bool flag = false;
		FWeaponInfo value2;
		if (Reset2Default)
		{
			flag = true;
			TriggerActivate = GetWeaponDefaultActive(WeaponIndex);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, $"<character>{Owner.GetName()}</><action>武器恢复为默认状态：</><effect>{TriggerActivate}</>");
			}
		}
		else if (NeedOverride)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, $"<character>{Owner.GetName()}</><action>覆盖Status，武器状态切换为：</><effect>{TriggerActivate}</>");
			}
			flag = true;
			if (WeaponManagerData.Weapons.TryGetValue(WeaponIndex, out var value))
			{
				value.AnimCtrlInfo = new KeyValuePair<int, int>(ID1, ID2);
			}
		}
		else if (WeaponManagerData.Weapons.TryGetValue(WeaponIndex, out value2))
		{
			if (value2.AnimCtrlInfo.Key == ID1 && value2.AnimCtrlInfo.Value == ID2)
			{
				flag = true;
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeaponStatus, flag ? $"<character>{Owner.GetName()}</><action>还原Status，武器状态切换为：</><effect>{TriggerActivate}</>" : $"<character>{Owner.GetName()}</><action>还原Status失败，武器状态被更后期触发的切换效果覆盖，ID1 = </><effect>{value2.AnimCtrlInfo.Key}</><action>，ID2 = </><effect>{value2.AnimCtrlInfo.Value}</>");
			}
		}
		if (!flag)
		{
			return;
		}
		if (WeaponManagerData.Weapons.TryGetValue(WeaponIndex, out var value3))
		{
			value3.SetActive(TriggerActivate);
		}
		if (Weapon != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Weapon);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
			{
				bUS_GSEventCollection.Evt_ToggleWeaponActive.Invoke(TriggerActivate);
			}
		}
	}

	private void OnAddTempOverrideWeapon(List<FUnitWeapon> WeaponInfo)
	{
		if (WeaponManagerData.bTempOverrideWeapons)
		{
			return;
		}
		OnToggleWeaponsStatus_ByOtherComp(new List<int> { -1 }, TriggerActivate: false, NeedOverride: true, EToggleWeaponStatusCompType.TempOverrideWeapon);
		OnClearWeaponsAnimCtrlInfo();
		foreach (KeyValuePair<int, FWeaponInfo> weapon in WeaponManagerData.Weapons)
		{
			WeaponManagerData.TempCachedWeapons.Add(weapon.Key, weapon.Value);
		}
		WeaponManagerData.Weapons.Clear();
		for (int i = 0; i < WeaponInfo.Count; i++)
		{
			TrySpawnInitOneWeapon(WeaponInfo[i], i);
		}
		WeaponManagerData.bTempOverrideWeapons = true;
		WeaponManagerData.bWeaponChangedFlag = true;
	}

	private void OnClearWeaponsAnimCtrlInfo()
	{
		foreach (int item in WeaponManagerData.Weapons.Keys.ToList())
		{
			if (WeaponManagerData.Weapons.TryGetValue(item, out var value))
			{
				value.ClearAnimCtrlInfo();
			}
		}
	}

	private bool GetWeaponDefaultActive(int index)
	{
		if (WeaponManagerData == null || ConfigInfoData == null)
		{
			return false;
		}
		if (WeaponManagerData.bTempOverrideWeapons)
		{
			return true;
		}
		if (index != -1 && ConfigInfoData.Weapons.Count > index)
		{
			return !ConfigInfoData.Weapons[index].bDefaultInactive;
		}
		return true;
	}

	private void OnClearTempOverrideWeapon()
	{
		if (!WeaponManagerData.bTempOverrideWeapons)
		{
			return;
		}
		ClearWeapon();
		foreach (KeyValuePair<int, FWeaponInfo> tempCachedWeapon in WeaponManagerData.TempCachedWeapons)
		{
			WeaponManagerData.Weapons.Add(tempCachedWeapon.Key, tempCachedWeapon.Value);
		}
		WeaponManagerData.TempCachedWeapons.Clear();
		OnClearWeaponsAnimCtrlInfo();
		OnToggleWeaponsStatus_ByOtherComp(new List<int> { -1 }, TriggerActivate: true, NeedOverride: false, EToggleWeaponStatusCompType.TempOverrideWeapon);
		WeaponManagerData.bTempOverrideWeapons = false;
	}
}
