using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BUS_EquipComp : UActorCompBaseCS
{
	private BUC_EquipData EquipData;

	private IBUC_ActorBasicData ActorBasicData;

	private IBPC_RoleBaseData PlayerRoleData;

	private bool IsPlayer;

	private APawn SelfPawn;

	private IBPC_PlayerTagData PlayerTagData;

	public override void OnAttach()
	{
		EquipData = RequireWritableData<BUC_EquipData>();
		ActorBasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
		IsPlayer = Owner.GetClass().IsChildOf<BGUCharacterCS>();
		SelfPawn = Owner as APawn;
		PlayerTagData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(SelfPawn?.PlayerState);
		PlayerRoleData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(SelfPawn?.PlayerState);
		PlayerRoleData?.EquipList.BindAnyOneValueChange(OnEquipListAnyOneValueChange);
		PlayerRoleData?.EquipList.BindAdd(OnChangeEquip);
		if (IsPlayer)
		{
			base.BUSEventCollection.Evt_BattleLogicChangeEquip += new Del_BattleLogicChangeEquip(OnChangeEquip);
			base.BUSEventCollection.Evt_BattleLogicChangeEquipIllusion += new Del_BattleLogicChangeEquipIllusion(OnChangeEquipIllusion);
			base.BUSEventCollection.Evt_BattleLogicResetEquipIllusion += new Del_Void(OnResetEquipIllusion);
			base.BUSEventCollection.Evt_InitDaShenEquipData += new Del_BattleLogicChangeEquip(OnChangeEquipReal);
			base.BUSEventCollection.Evt_OnRefreshEquip += new Del_Void(OnRefreshEquip);
			base.BUSEventCollection.Evt_OnPhotoModeHeadEquipVisibleChange += new Del_Void_Bool(OnPhotoModeHeadEquipVisibleChange);
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Combine(bGWEventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChanged));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Combine(bGWEventCollection2.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
		}
		else
		{
			base.BUSEventCollection.Evt_ChangePreviewEquip += new Del_BattleLogicChangeEquip(OnChangeEquip);
		}
		base.BUSEventCollection.Evt_AttachEquipCompToSocket += new Del_AttachEquipCompToSocket(OnAttachEquipCompToSocket);
		EquipData.bHidenHeadEquip = BGW_SettingFuncUtil.GetSettingIntValueByType(GetOwner(), UISettingConfigType.HeadWeaponShow) == 0;
	}

	private void OnPhotoModeHeadEquipVisibleChange(bool bVisible)
	{
		if (EquipData != null)
		{
			EquipData.bHidenHeadEquipInPhotoMode = !bVisible;
			OnRefreshShowHeadEquip();
		}
	}

	public override void PreBeginPlay()
	{
		InitDefaultEquip();
	}

	private void OnEquipListAnyOneValueChange(EquipPosition Position, int OldEquipId, int NewEquipId)
	{
		OnChangeEquip(Position, NewEquipId);
	}

	public override void OnBeginPlay()
	{
		InitEquipMap();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		PlayerRoleData?.EquipList.UnBindAnyOneValueChange(OnEquipListAnyOneValueChange);
		PlayerRoleData?.EquipList.UnBindAdd(OnChangeEquip);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Remove(bGWEventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChanged));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Remove(bGWEventCollection2.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
	}

	private void InitDefaultEquip()
	{
		EquipData.MapDefaultEquip.Clear();
		foreach (KeyValuePair<int, EquipPositionConfDesc> item in GameDBRuntime.GetAllEquipPositionDesc())
		{
			EquipData.MapDefaultEquip.Add(item.Value.EquipPosition, item.Value.DefaultEquipId);
		}
	}

	private void InitEquipMap()
	{
		if (EquipData.MapEquip.Count > 0 || PlayerRoleData == null)
		{
			return;
		}
		foreach (KeyValuePair<EquipPosition, int> item in EquipData.MapDefaultEquip)
		{
			int OutValue = 0;
			PlayerRoleData.EquipList.TryGetValue(item.Key, out OutValue);
			if (!EquipData.MapEquip.ContainsKey(item.Key))
			{
				EquipData.MapEquip.Add(item.Key, 0);
			}
			OnChangeEquip(item.Key, OutValue);
		}
	}

	private void OnChangeEquip(EquipPosition EquipPosition, int EquipID)
	{
		if (PlayerTagData == null || !PlayerTagData.HasTag(EBGPPlayerTag.Transforming))
		{
			OnChangeEquipReal(EquipPosition, EquipID);
		}
	}

	private void OnChangeEquipReal(EquipPosition EquipPosition, int EquipID)
	{
		string skeletalMeshPath = "";
		string aBPClassPath = "";
		List<string> staticMeshPathList = new List<string>();
		string attachSocketName = "";
		ECharacterModularType modularType = ECharacterModularType.MasterPose;
		int audioMappingID = 0;
		bool bHideTail = false;
		if (EquipID <= 0)
		{
			EquipData.MapDefaultEquip.TryGetValue(EquipPosition, out EquipID);
		}
		int value = EquipID;
		if (EquipPosition == EquipPosition.Head && (!EquipData.CanShowHeadEquip() || GSGameplayCVar.CVar_ForceHidePlayerHeadEquip.GetValueInGameThread() != 0) && EquipData.EquipIllusionList.Count == 0 && Owner is BGUPlayerCharacterCS)
		{
			EquipData.MapDefaultEquip.TryGetValue(EquipPosition.Head, out value);
			EquipData.CurShowHeadEquipID = value;
		}
		else
		{
			EquipData.CurShowHeadEquipID = value;
		}
		EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(value);
		if (equipDesc != null)
		{
			skeletalMeshPath = equipDesc.SkeletalMesh;
			aBPClassPath = equipDesc.AnimBlueprintClass;
			staticMeshPathList = equipDesc.StaticMesh.ToList();
			modularType = ((ActorBasicData.ActorType == BGU_ActorType.CharacterAI) ? equipDesc.ModularTypeForCharacterAI : equipDesc.ModularType);
			attachSocketName = equipDesc.AttachSocketName;
			audioMappingID = equipDesc.AudioMappingId;
			bHideTail = equipDesc.HideTail == YesNoType.Yes;
			if (EquipPosition != equipDesc.EquipPosition)
			{
				BGW_LogUtil.LogError("[{0}]BUS_EquipSystem.OnChangeEquip EqupPosition [{1}] is not fit to EquipID {2}!", Owner.GetName(), EquipPosition, EquipID);
				return;
			}
		}
		else
		{
			EquipID = 0;
		}
		if (EquipData.MapEquipAttachSocket.ContainsKey(EquipPosition))
		{
			attachSocketName = EquipData.MapEquipAttachSocket[EquipPosition];
		}
		if (EquipData.EquipIllusionList.Count == 0)
		{
			FCharacterModuleResourceData ResourceData = new FCharacterModuleResourceData
			{
				SkeletalMeshPath = skeletalMeshPath,
				ABPClassPath = aBPClassPath,
				StaticMeshPathList = staticMeshPathList,
				AttachSocketName = attachSocketName,
				ModularType = modularType,
				AudioMappingID = audioMappingID,
				bHideTail = bHideTail
			};
			base.BUSEventCollection.Evt_CharacterModuleChanged.Invoke(EquipPosition, value, in ResourceData);
		}
		if (EquipData.SelfEquipMap.ContainsKey(EquipPosition))
		{
			if (EquipID != 0)
			{
				EquipData.SelfEquipMap[EquipPosition] = EquipID;
			}
			else
			{
				EquipData.SelfEquipMap.Remove(EquipPosition);
			}
		}
		else if (EquipID != 0)
		{
			EquipData.SelfEquipMap.Add(EquipPosition, EquipID);
		}
		if (PlayerRoleData != null && GetOwner().World.IsServer())
		{
			if (!EquipData.MapEquip.ContainsKey(EquipPosition))
			{
				BGW_LogUtil.LogError("[{0}]BUS_EquipSystem.OnChangeEquip EqupPosition [{1}] is not init!", Owner.GetName(), EquipPosition);
			}
			else
			{
				EquipData.MapEquip[EquipPosition] = EquipID;
			}
		}
	}

	private void OnChangeEquipIllusion(string EquipIllusionConfigPath)
	{
		BGWDataAsset_EquipIllusionConfig bGWDataAsset_EquipIllusionConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_EquipIllusionConfig>(EquipIllusionConfigPath, ELoadResourceType.SyncLoadAndCache);
		string text = ((bGWDataAsset_EquipIllusionConfig.SM != null) ? bGWDataAsset_EquipIllusionConfig.SM.PathName : "");
		if (!EquipData.EquipIllusionList.ContainsKey(bGWDataAsset_EquipIllusionConfig.Position))
		{
			EquipData.EquipIllusionList.Add(bGWDataAsset_EquipIllusionConfig.Position, text);
		}
		string aBPClassPath = ((bGWDataAsset_EquipIllusionConfig.ABP != null) ? bGWDataAsset_EquipIllusionConfig.ABP.Value.PathName : "");
		List<string> list = new List<string>();
		foreach (UStaticMesh item in bGWDataAsset_EquipIllusionConfig.StaticMesh)
		{
			list.Add(item.PathName);
		}
		FCharacterModuleResourceData ResourceData = new FCharacterModuleResourceData
		{
			SkeletalMeshPath = text,
			ABPClassPath = aBPClassPath,
			StaticMeshPathList = list,
			AttachSocketName = "",
			ModularType = (ECharacterModularType)bGWDataAsset_EquipIllusionConfig.ModularType,
			AudioMappingID = 0,
			bHideTail = false
		};
		base.BUSEventCollection.Evt_CharacterModuleChanged.Invoke(bGWDataAsset_EquipIllusionConfig.Position, -1, in ResourceData);
	}

	private void OnResetEquipIllusion()
	{
		if (EquipData.EquipIllusionList.Count == 0)
		{
			return;
		}
		Dictionary<EquipPosition, int> dictionary = new Dictionary<EquipPosition, int>();
		foreach (KeyValuePair<EquipPosition, string> equipIllusion in EquipData.EquipIllusionList)
		{
			EquipPosition key = equipIllusion.Key;
			if (EquipData.MapEquip.ContainsKey(key))
			{
				int value = EquipData.MapEquip[key];
				dictionary.Add(key, value);
			}
		}
		EquipData.EquipIllusionList.Clear();
		foreach (KeyValuePair<EquipPosition, int> item in dictionary)
		{
			OnChangeEquip(item.Key, item.Value);
		}
	}

	private void OnRefreshEquip()
	{
		if (EquipData.MapEquip.Count == 0 || PlayerRoleData == null)
		{
			return;
		}
		foreach (KeyValuePair<EquipPosition, int> item in EquipData.MapDefaultEquip)
		{
			int OutValue = 0;
			PlayerRoleData.EquipList.TryGetValue(item.Key, out OutValue);
			if (!EquipData.MapEquip.ContainsKey(item.Key))
			{
				EquipData.MapEquip.Add(item.Key, 0);
			}
			OnChangeEquip(item.Key, OutValue);
		}
	}

	private void OnRefreshShowHeadEquip()
	{
		if (EquipData.MapEquip.Count == 0 || PlayerRoleData == null)
		{
			return;
		}
		bool num = !EquipData.CanShowHeadEquip() || (GSGameplayCVar.CVar_ForceHidePlayerHeadEquip.GetValueInGameThread() != 0 && EquipData.EquipIllusionList.Count == 0 && Owner is BGUPlayerCharacterCS);
		int OutValue = 0;
		PlayerRoleData.EquipList.TryGetValue(EquipPosition.Head, out OutValue);
		int value = OutValue;
		if (num)
		{
			EquipData.MapDefaultEquip.TryGetValue(EquipPosition.Head, out value);
		}
		if (EquipData.CurShowHeadEquipID != value)
		{
			if (!EquipData.MapEquip.ContainsKey(EquipPosition.Head))
			{
				EquipData.MapEquip.Add(EquipPosition.Head, 0);
			}
			OnChangeEquip(EquipPosition.Head, OutValue);
		}
	}

	private void OnAttachEquipCompToSocket(EquipPosition EquipPosition, string SocketName, int InstanceID, int UniqueID)
	{
		if (!EquipData.SelfEquipMap.TryGetValue(EquipPosition, out var value))
		{
			return;
		}
		EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(value);
		if (equipDesc == null)
		{
			return;
		}
		string value2 = Convert.ToString(InstanceID) + Convert.ToString(UniqueID);
		string attachSocketName = SocketName;
		bool flag = EquipData.MapEquipAttachSocket.ContainsKey(EquipPosition);
		if (SocketName.Equals(""))
		{
			if (!EquipData.MapEquipAttachMontage.TryGetValue(EquipPosition, out var value3) || !value3.Equals(value2))
			{
				return;
			}
			ECharacterModularType eCharacterModularType = ((ActorBasicData.ActorType == BGU_ActorType.CharacterAI) ? equipDesc.ModularTypeForCharacterAI : equipDesc.ModularType);
			attachSocketName = (((uint)eCharacterModularType <= 1u || eCharacterModularType != ECharacterModularType.AttachToSocket) ? "" : equipDesc.AttachSocketName);
			if (flag)
			{
				EquipData.MapEquipAttachSocket.Remove(EquipPosition);
			}
		}
		else
		{
			EquipData.MapEquipAttachMontage[EquipPosition] = value2;
			if (flag)
			{
				EquipData.MapEquipAttachSocket[EquipPosition] = SocketName;
			}
			else
			{
				EquipData.MapEquipAttachSocket.Add(EquipPosition, SocketName);
			}
		}
		base.BUSEventCollection.Evt_RefreshCharacterModuleAttachment.Invoke(EquipPosition, attachSocketName);
	}

	private void OnSettingValueChanged(int OldValue, int NewValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.HeadWeaponShow)
		{
			EquipData.bHidenHeadEquip = NewValue == 0;
			OnRefreshShowHeadEquip();
		}
	}

	public void OnSetGamePause(EPauseEvent PauseEvent, bool bPause)
	{
		if (PauseEvent == EPauseEvent.TakePhoto && EquipData != null)
		{
			EquipData.bInPhotoMode = bPause;
			OnRefreshShowHeadEquip();
		}
	}
}
