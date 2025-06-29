using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_BarSockComp : UActorCompBaseCS
{
	private BUC_BarSockData BarSockData;

	private IBUC_SimpleStateData SimpleStateData;

	public override void OnAttach()
	{
		base.OnAttach();
		BarSockData = RequireWritableData<BUC_BarSockData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		base.BUSEventCollection.Evt_NotifyTargetInfoChanged += new Del_NotifyTargetInfoChanged(OnTargetInfoChanged);
	}

	public override void PreBeginPlay()
	{
		List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.GSInteractSock);
		if (componentsByTag.Count >= 1)
		{
			BarSockData.InteractSock = componentsByTag[0] as USceneComponent;
		}
	}

	private void OnTargetInfoChanged(UnitLockTargetInfo NewTargetInfo)
	{
		if (NewTargetInfo != null && NewTargetInfo.IsValidManualTargetInfo())
		{
			BarSockData.IsTargetSp = GetTargetIsSp(NewTargetInfo.LockTargetEntity);
			BarSockData.LastSwitchLockTime = Owner.World.GetTimeSeconds();
			BarSockData.LockTargetActor = NewTargetInfo.LockTargetEntity;
			BarSockData.LockTargetSkeletonSocket = NewTargetInfo.LockTargetSkeletonSocketName;
		}
		else
		{
			BarSockData.LockTargetActor = Entity.Null;
			BarSockData.LockTargetSkeletonSocket = null;
			BarSockData.IsTargetSp = false;
		}
	}

	private bool GetTargetIsSp(Entity TargetEntity)
	{
		BGUCharacterCS bGUCharacterCS = ECSExtension.ToActor(TargetEntity) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		if (!BGU_DataUtil.GetReadOnlyData<IBUC_VigourDropperData, BUC_VigourDropperData>(bGUCharacterCS).CanDropVigourItem)
		{
			return false;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(bGUCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc == null || unitBattleInfoExtendDesc.VigourDropId == 0)
		{
			return false;
		}
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner));
		if (readOnlyData == null)
		{
			return false;
		}
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.EnableVigourUnitDispItem, out var ConfigInfo);
		if (ConfigInfo == null || !RoleDataHelper.HasItem(readOnlyData, ConfigInfo.IntValue))
		{
			return false;
		}
		return true;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (BarSockData == null || SimpleStateData == null)
		{
			return;
		}
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.CantShowLock);
		if (!flag)
		{
			_ = BarSockData.LockTargetActor;
			if (ECSExtension.ToActor(BarSockData.LockTargetActor) is BGUCharacterCS actor)
			{
				IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(actor);
				if (readOnlyData != null)
				{
					flag = readOnlyData.HasSimpleState(EBGUSimpleState.TargetCantShowLock);
				}
			}
		}
		if (flag != BarSockData.CantShowBarSockUI)
		{
			BarSockData.CantShowBarSockUI = flag;
		}
	}
}
