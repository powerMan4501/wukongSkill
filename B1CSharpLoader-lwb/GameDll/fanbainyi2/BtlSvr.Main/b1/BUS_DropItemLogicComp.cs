using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using CsB1;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DropItemLogicComp : UActorCompBaseCS
{
	public enum DropItemState
	{
		Null,
		Droping,
		Waiting,
		Picking,
		Following,
		Picked
	}

	private BUC_DropItemData DropItemData;

	private IBUC_InteractData InteractData;

	private bool FirstTickFlag;

	private int LoopTickCounter;

	private int TickCounterMaxValue = 6000;

	private BPC_PlayerRoleData CurrentPlayerRoleData;

	private float DelayResetFXParamFlag = -1f;

	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnPickDropItem += new Del_Void(OnPick);
		base.BUSEventCollection.Evt_ScaleDropItemByCurve += new Del_ScaleWeaponByCurve(OnScaleDropitemByCurve);
		DropItemData = RequireWritableData<BUC_DropItemData>();
		InteractData = RequireReadOnlyData<IBUC_InteractData, BUC_InteractData>();
		if (DropItemData.UseSoulBottleCondition)
		{
			base.BUSEventCollection.Evt_InteractTaskCollection += new Del_Void_Actor(OnInteractTaskCollection);
			base.BUSEventCollection.Evt_StopInteractTargetIdleFX += new Del_Void_Actor(OnTriggerStopInteractTargetIdleFX);
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		DropItemData.Player = UGameplayStatics.GetPlayerController(Owner, 0).GetControlledPawn();
		DropItemData.Owner = GetOwner() as BGUDropItemActorCS;
		DropItemData.BornPos = GetOwner().GetActorLocation();
		DropItemData.MeshComp = GetOwner().GetComponentByClass(UClass.GetClass<UMeshComponent>()) as UMeshComponent;
		CurrentPlayerRoleData = null;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BUSEventCollection.Evt_OnPickDropItem -= new Del_Void(OnPick);
		base.BUSEventCollection.Evt_ScaleDropItemByCurve -= new Del_ScaleWeaponByCurve(OnScaleDropitemByCurve);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		LoopTickCounter++;
		if (LoopTickCounter > TickCounterMaxValue)
		{
			LoopTickCounter -= TickCounterMaxValue;
		}
		if (!FirstTickFlag)
		{
			OnFirstTick();
		}
		if (DropItemData.State == DropItemState.Null)
		{
			return;
		}
		if (DropItemData.State == DropItemState.Droping)
		{
			TickDroping(DeltaTime);
		}
		else if (DropItemData.State == DropItemState.Waiting)
		{
			TickWaiting(DeltaTime);
		}
		TickForScale(DeltaTime);
		if (DelayResetFXParamFlag >= 0f)
		{
			DelayResetFXParamFlag -= DeltaTime;
			if (DelayResetFXParamFlag <= 0f)
			{
				DelayResetFXParamFlag = -1f;
				DelayResetFXParam();
			}
		}
	}

	private void TickForScale(float DeltaTime)
	{
		if (GetOwner() == null || DropItemData == null || !DropItemData.EnableScale)
		{
			return;
		}
		if (DropItemData.ScaleCurve == null)
		{
			DropItemData.InitDeformation();
			return;
		}
		FVector vectorValue = DropItemData.ScaleCurve.GetVectorValue(DropItemData.ScaleTimer);
		BGUDropItemActorCS bGUDropItemActorCS = GetOwner() as BGUDropItemActorCS;
		if (bGUDropItemActorCS == null)
		{
			DropItemData.InitDeformation();
			return;
		}
		bGUDropItemActorCS.SetDropItemScale(vectorValue);
		DropItemData.ScaleTimer += DeltaTime;
	}

	private void OnScaleDropitemByCurve(UCurveVector ScaleCurve)
	{
		DropItemData.ScaleCurve = ScaleCurve;
		DropItemData.EnableScale = true;
		DropItemData.ScaleTimer = 0f;
	}

	private void OnFirstTick()
	{
		FirstTickFlag = true;
		InitDropItem();
		DropItemData.Timer = 0f;
		UBGWDropItemTemplete templeteDA = DropItemData.TempleteDA;
		if (templeteDA != null && !DropItemData.Player.IsNullOrDestroyed())
		{
			BUS_DispLibEventCollection.Get(DropItemData.Player)?.Evt_RequestApplyOneDBCDataAsset(templeteDA.DADropFixed, out DropItemData.DropFixedGamePlayDispReqID);
		}
	}

	private void TickDroping(float DeltaTime)
	{
		DropItemData.Timer += DeltaTime;
		FVector fVector = ((DropItemData.TempleteDA.DropingCurve != null) ? DropItemData.TempleteDA.DropingCurve.GetVectorValue(DropItemData.Timer) : new FVector(0.0, 0.0, -100f * DropItemData.Timer));
		FVector newLocation = DropItemData.BornPos + new FVector(fVector.X, 0.0, fVector.Z).RotateAngleAxis(DropItemData.RandomAngle, FVector.UpVector) * DropItemData.RandomRadius;
		FHitResult SweepHitResult;
		if (newLocation.Z <= DropItemData.PerferTarget.Z)
		{
			newLocation.Z = DropItemData.PerferTarget.Z;
			GetOwner().SetActorLocationAndRotation(newLocation, FRotator.ZeroRotator, bSweep: false, out SweepHitResult, bTeleport: true);
			UBGWDropItemTemplete templeteDA = DropItemData.TempleteDA;
			if (templeteDA != null && !DropItemData.Player.IsNullOrDestroyed())
			{
				BUS_DispLibEventCollection.Get(DropItemData.Player)?.Evt_RequestApplyOneDBCDataAsset(templeteDA.DAWaitSign, out DropItemData.WaitSignGamePlayDispReqID);
			}
			DropItemData.DropPos = GetOwner().GetActorLocation();
			DropItemData.State = DropItemState.Waiting;
			if (DropItemData.MeshComp != null)
			{
				DropItemData.MeshComp.SetRelativeRotation(FRotator.ZeroRotator, bSweep: false, out SweepHitResult, bTeleport: true);
			}
		}
		else
		{
			if (DropItemData.MeshComp != null)
			{
				DropItemData.MeshComp.SetRelativeRotation(new FRotator(fVector.Y, 0.0, 0.0), bSweep: false, out SweepHitResult, bTeleport: true);
			}
			GetOwner().SetActorLocationAndRotation(newLocation, FRotator.ZeroRotator, bSweep: false, out SweepHitResult, bTeleport: true);
		}
	}

	private void TickWaiting(float DeltaTime)
	{
		if (LoopTickCounter % 60 == 0)
		{
			UpdateDrappingItemInteractState();
		}
	}

	private void UpdateDrappingItemInteractState()
	{
		if (!(DropItemData.TempleteDA != null) || DropItemData.IsPickingConditionsUsed || DropItemData.TempleteDA.PickingConditionConfig.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < DropItemData.TempleteDA.PickingConditionConfig.Count; i++)
		{
			if (DropItemData.TempleteDA.PickingConditionConfig[i].UseCondi_HasItem)
			{
				if (CurrentPlayerRoleData == null)
				{
					BGP_PlayerControllerCS actor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner) as BGP_PlayerControllerCS;
					CurrentPlayerRoleData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(actor);
				}
				if (CurrentPlayerRoleData != null && RoleDataHelper.HasItem(CurrentPlayerRoleData, DropItemData.TempleteDA.PickingConditionConfig[i].Condi_HasItem_TargetItemID))
				{
					base.BGWEventCollection.Evt_SendUpdateInteractGroup(BGU_DataUtil.GetActorGuid(DropItemData.Owner), DropItemData.TempleteDA.PickingConditionConfig[i].Condi_HasItem_InteractGroupID);
					DropItemData.IsPickingConditionsUsed = true;
					break;
				}
			}
		}
	}

	private void OnPick()
	{
		OnPickedTriggerEffect();
		DropItemData.State = DropItemState.Picked;
		if (DropItemData.TempleteDA != null)
		{
			BGU_UnrealWorldUtil.DestroyActor(GetOwner());
		}
	}

	private void OnPickedTriggerEffect()
	{
		ItemOne itemOne = new ItemOne();
		itemOne.Id = DropItemData.ItemResID;
		itemOne.Num = 1;
		BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get((DropItemData.Player as ABGUCharacter).PlayerState);
		CSMsgBagGainItemListReq bagGainItemList = new CSMsgBagGainItemListReq
		{
			ItemList = { itemOne },
			Reason = OPReason.UnitDropPickUp
		};
		bTF_EventCollectionCS.Evt_BagGainItemListReq(bagGainItemList, GainItemCallBack);
	}

	private void GainItemCallBack(MsgErrCode ErrCode, CSMsgBagGainItemListReq Req, CSMsgBagGainItemListRes Res)
	{
	}

	private FVector Lerp(FVector Des, FVector Target, float Alpha)
	{
		return (Target - Des) * Alpha + Des;
	}

	private void InitDropItem()
	{
		if (DropItemData == null || DropItemData.ItemResID == 0)
		{
			return;
		}
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(DropItemData.ItemResID);
		if (itemDesc != null)
		{
			DropItemData.TempleteDA = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UBGWDropItemTemplete>(itemDesc.DropTemplete, ELoadResourceType.SyncLoadAndCache);
			if (DropItemData.TempleteDA.TempleteType == EDropItemPerfromType.WithDropAnim)
			{
				DropItemData.State = DropItemState.Waiting;
				return;
			}
			DropItemData.PerferTarget = GetVaildPerferPos(DropItemData.BornPos, (DropItemData.TempleteDA.DropingCurve != null) ? DropItemData.TempleteDA.DropingCurve.GetVectorValue(10f) : FVector.ZeroVector);
			DropItemData.State = DropItemState.Droping;
		}
	}

	private FVector GetVaildPerferPos(FVector BaseVector, FVector AdditonVector)
	{
		FVector fVector = BaseVector;
		int num = 90;
		for (int i = 0; i < 3; i++)
		{
			DropItemData.RandomAngle += num;
			fVector = BaseVector + AdditonVector.RotateAngleAxis(DropItemData.RandomAngle, FVector.UpVector) * DropItemData.RandomRadius;
			FVector startTrace = fVector;
			startTrace.Z = BaseVector.Z;
			FVector endTrace = fVector;
			endTrace.Z = BaseVector.Z - 1000f;
			List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery1 };
			if (UBGUSelectUtil.LineTraceForObjectsTypeSimple(GetOwner(), startTrace, endTrace, objectTypes, bDebug: false, out var HitResult) > 0)
			{
				fVector.Z = HitResult.HitLocation.Z;
			}
			if (!UBGUFunctionLibrary.BGUNavigationRaycast(DropItemData.Owner.World, DropItemData.Player.GetActorLocation(), fVector, out var _, null, UGameplayStatics.GetPlayerController(Owner, 0)))
			{
				return fVector;
			}
			DropItemData.RandomRadius = 0.5f;
		}
		return fVector;
	}

	private bool IsHaveSoulBottle()
	{
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.SoukBottleItemId);
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner) as BGP_PlayerControllerCS);
		if (readOnlyData != null)
		{
			return RoleDataHelper.HasItem(readOnlyData, commLogicCfgValue);
		}
		return false;
	}

	private void OnInteractTaskCollection(AActor Player)
	{
		if (!(BGS_GSEventCollection.Get(Player) != null))
		{
			return;
		}
		UBGWDropItemTemplete uBGWDropItemTemplete = null;
		if (IsHaveSoulBottle())
		{
			if (DropItemData.HaveSoulBottleDropTemplate.IsNullOrDestroyed())
			{
				return;
			}
			uBGWDropItemTemplete = DropItemData.HaveSoulBottleDropTemplate;
		}
		else
		{
			if (DropItemData.NoSoulBottleDropTemplate.IsNullOrDestroyed())
			{
				return;
			}
			uBGWDropItemTemplete = DropItemData.NoSoulBottleDropTemplate;
		}
		List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<USceneComponent>(), DropItemData.NewFXSpawnCompTag);
		FTransform overrideSpawnPos = ((componentsByTag == null || componentsByTag.Count <= 0) ? Owner.GetActorTransform() : (componentsByTag[0] as USceneComponent).GetWorldTransform());
		ABGUCharacter aBGUCharacter = Player as ABGUCharacter;
		if (!aBGUCharacter.IsNullOrDestroyed() && aBGUCharacter.IsPlayerControlled())
		{
			PlayDropFX(aBGUCharacter, uBGWDropItemTemplete, overrideSpawnPos);
		}
	}

	private void PlayDropFX(ABGUCharacter Player, UBGWDropItemTemplete WholeTemplete, FTransform OverrideSpawnPos)
	{
		if (!(WholeTemplete != null) || !(WholeTemplete.DADropFixed != null))
		{
			return;
		}
		DBCTransformParam dBCTransform = new DBCTransformParam(OverrideSpawnPos);
		_ = DispLibRefParam.Instance;
		int GamePlayDispReqID = 0;
		BUS_DispLibEventCollection.Get(Player)?.Evt_RequestApplyOneDBCDataAsset(WholeTemplete.DADropFixed, out GamePlayDispReqID, Player.Mesh, FVector.ZeroVector, dBCTransform, DBCSetCallbackParams.Default, Owner.GetUniqueID());
		if (GamePlayDispReqID != 0)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(DropItemData.ItemResID);
			if (itemDesc != null && itemDesc.ItemType == ItemType.SoulSkill)
			{
				ItemQuality quality = itemDesc.Quality;
				float num = 0f;
				BUS_DispLibEventCollection.Get(Player)?.Evt_RequestSetDBCNiagaraFloatParam(GamePlayDispReqID, B1GlobalFNames.User_FireColor_Index, quality switch
				{
					ItemQuality.Blue => 0f, 
					ItemQuality.Purple => 1f, 
					ItemQuality.Red => 2f, 
					_ => 0f, 
				});
			}
		}
	}

	private void OnTriggerBeInteract(AActor PlayerActor, bool IsAiTrigger)
	{
		if (!IsAiTrigger)
		{
			UNiagaraComponent uNiagaraComponent = GetOwner().GetComponentByClass(UClass.GetClass<UNiagaraComponent>()) as UNiagaraComponent;
			if (uNiagaraComponent != null)
			{
				bool inValue = IsHaveSoulBottle();
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_SoulBottle, inValue);
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
			}
		}
	}

	private void OnTriggerStopInteractTargetIdleFX(AActor Player)
	{
		UNiagaraComponent uNiagaraComponent = GetOwner().GetComponentByClass(UClass.GetClass<UNiagaraComponent>()) as UNiagaraComponent;
		if (uNiagaraComponent != null)
		{
			bool flag = IsHaveSoulBottle();
			uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_SoulBottle, flag);
			if (flag)
			{
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
			}
			else
			{
				DelayResetFXParamFlag = 2f;
			}
		}
	}

	private void DelayResetFXParam()
	{
		(GetOwner().GetComponentByClass(UClass.GetClass<UNiagaraComponent>()) as UNiagaraComponent)?.SetVariableBool(B1GlobalFNames.User_GS_SoulBottle, InValue: true);
	}
}
