using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_RebirthPointCompImpl : BUS_StateMachineCompBase
{
	public class InActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.RebirthPointTag.State_InActived;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.RebirthPointTag.Event_Active, BGW_FlowUtils.RebirthPointTag.State_Actived);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.RebirthPointTag.State_Actived);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			(InOwner as b1.BUS_RebirthPointCompImpl)?.SetRebirthPointActiveState(bActive: false, IsImmediatelyUpdateAllEffect: false);
		}
	}

	public class ActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.RebirthPointTag.State_Actived;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.RebirthPointTag.Event_Deactive, BGW_FlowUtils.RebirthPointTag.State_InActived);
		}

		public override void OnInitialAction(BUS_StateMachineCompBase InOwner)
		{
			OnEnterAction(InOwner);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			(InOwner as b1.BUS_RebirthPointCompImpl)?.SetRebirthPointActiveState(bActive: true, IsImmediatelyUpdateAllEffect: false);
		}
	}

	private TStrongObjectPtr<USceneComponent> mInActiveFXCom = new TStrongObjectPtr<USceneComponent>();

	private TStrongObjectPtr<USceneComponent> mActivatedFXCom = new TStrongObjectPtr<USceneComponent>();

	private float ZhaoHunFanDelayHideTime = -1f;

	private BUC_RebirthPointData RebirthPointData { get; set; }

	private IBPC_RebirthPointData PlayerConRebirthPointData { get; set; }

	private USceneComponent InActiveFXCom
	{
		get
		{
			return mInActiveFXCom.Get();
		}
		set
		{
			mInActiveFXCom.Set(value);
		}
	}

	private USceneComponent ActivatedFXCom
	{
		get
		{
			return mActivatedFXCom.Get();
		}
		set
		{
			mActivatedFXCom.Set(value);
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		RebirthPointData = RequireWritableData<BUC_RebirthPointData>();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		PlayerConRebirthPointData = BGU_DataUtil.GetReadOnlyData<BPC_RebirthPointData>(firstLocalPlayerController);
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.RebirthPoint;
		GSStateBase gSStateBase = AddState(typeof(InActivedState), 0);
		GSStateBase gSStateBase2 = AddState(typeof(ActivedState), 1);
		InitRebirthPointData();
		InitRebirthPointActiveState();
		InitRebirthPointEffect();
		base.InitialState = (RebirthPointData.bActiveState ? gSStateBase2 : gSStateBase);
		base.BUSEventCollection.Evt_EnterActiveArea += new Del_EnterInteractActiveArea(OnEnterActiveArea);
		base.BUSEventCollection.Evt_LeaveActiveArea += new Del_EnterInteractActiveArea(OnLeaveActiveArea);
		base.BUSEventCollection.Evt_SetRebirthPointActiveState += new Del_Void_BoolBool(SetRebirthPointActiveState);
		base.BUSEventCollection.Evt_RBP_RebirthTeleportFinish += new Del_Void(OnPlayerRebirth);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID);
		if (!BGW_LogUtil.LogIfNull(rebirthPointDesc, "Find RebirthPointDesc failed! RebirthPointID: {0}", RebirthPointData.RebirthPointConfigID) && rebirthPointDesc.IsZhaoHunFan == EGSYesNo.Yes)
		{
			GetOwner()?.SetActorHiddenInGame(bNewHidden: true);
			ZhaoHunFanDelayHideTime = -1f;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ZhaoHunFanDelayHideTime >= 0f)
		{
			ZhaoHunFanDelayHideTime -= DeltaTime;
			if (ZhaoHunFanDelayHideTime <= 0f)
			{
				GetOwner()?.SetActorHiddenInGame(bNewHidden: true);
				ZhaoHunFanDelayHideTime = -1f;
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
	}

	private void OnPlayerRebirth()
	{
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID);
		if (BGW_LogUtil.LogIfNull(rebirthPointDesc, "Find RebirthPointDesc failed! RebirthPointID: {0}", RebirthPointData.RebirthPointConfigID))
		{
			return;
		}
		RebirthPointData.RebirthDBC = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<BGWDataAsset_B1DBC>(rebirthPointDesc.RebirthPointDBCWhenPlayerRebirth, ELoadResourceType.SyncLoadAndCache, EAssetPriority.High);
		if (RebirthPointData.RebirthDBC.IsNullOrDestroyed())
		{
			return;
		}
		if (rebirthPointDesc.IsZhaoHunFan == EGSYesNo.Yes)
		{
			GetOwner()?.SetActorHiddenInGame(bNewHidden: false);
			ZhaoHunFanDelayHideTime = -1f;
			if (RebirthPointData.RebirthDBC.PlayAdvanceNiagara != null && RebirthPointData.RebirthDBC.PlayAdvanceNiagara.Count > 0)
			{
				float delay = RebirthPointData.RebirthDBC.PlayAdvanceNiagara[0].Delay;
				if (delay > 0f)
				{
					ZhaoHunFanDelayHideTime = delay + 3f;
				}
			}
		}
		BUS_DispLibEventCollection.Get(base.Owner).Evt_RequestApplyOneDBCDataAsset(RebirthPointData.RebirthDBC, out var _);
	}

	protected override bool IsIgnoreSavedState()
	{
		return true;
	}

	public void SetRebirthPointActiveState(bool bActive, bool IsImmediatelyUpdateAllEffect)
	{
		RebirthPointData.bActiveState = bActive;
		if (bActive)
		{
			BPS_EventCollectionCS.GetLocal(base.Owner).Evt_ActiveRebirthPoint.Invoke(RebirthPointData.RebirthPointConfigID, P2: true);
			if (RebirthPointData.ActiveSetCurrentRebirthPoint)
			{
				_ = UBGUFunctionLibrary.GetPlayerCharacter(GetOwner()) != null;
			}
			BPS_EventCollectionCS.GetLocal(base.Owner)?.Evt_SetMapSymbolState.Invoke(BGU_DataUtil.GetActorGuid(base.Owner), EMapSymbolState.Compelte);
		}
		else
		{
			BPS_EventCollectionCS.GetLocal(base.Owner).Evt_ActiveRebirthPoint.Invoke(RebirthPointData.RebirthPointConfigID, P2: false);
		}
		UpdateRebirthPointActiveStateEffect(IsImmediatelyUpdateAllEffect);
	}

	private void InitRebirthPointActiveState()
	{
		if (PlayerConRebirthPointData == null)
		{
			return;
		}
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID);
		if (!BGW_LogUtil.LogIfNull(rebirthPointDesc, "Find RebirthPointDesc failed! RebirthPointID: {0}", RebirthPointData.RebirthPointConfigID))
		{
			if (PlayerConRebirthPointData.IsRebirthPointActived(RebirthPointData.RebirthPointConfigID))
			{
				RebirthPointData.bActiveState = true;
			}
			if (!RebirthPointData.bActiveState && rebirthPointDesc.IsActive == EGSYesNo.Yes)
			{
				RebirthPointData.bActiveState = true;
			}
		}
	}

	private void UpdateRebirthPointActiveStateEffect(bool IsImmediatelyUpdateAllEffect)
	{
		if (InActiveFXCom != null)
		{
			InActiveFXCom.GetChildrenComponents(bIncludeAllDescendants: true, out var Children);
			foreach (USceneComponent item in Children)
			{
				if (item is UNiagaraComponent uNiagaraComponent)
				{
					uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, RebirthPointData.bActiveState);
					if (RebirthPointData.bActiveState)
					{
						uNiagaraComponent.Deactivate();
					}
					else
					{
						uNiagaraComponent.Activate();
					}
				}
			}
		}
		if (!IsImmediatelyUpdateAllEffect)
		{
			return;
		}
		if (ActivatedFXCom != null)
		{
			ActivatedFXCom.SetVisibility(RebirthPointData.bActiveState, bPropagateToChildren: true);
			ActivatedFXCom.GetChildrenComponents(bIncludeAllDescendants: true, out var Children2);
			if (Children2 == null)
			{
				return;
			}
			foreach (USceneComponent item2 in Children2)
			{
				if (item2 is UNiagaraComponent uNiagaraComponent2)
				{
					uNiagaraComponent2.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, !RebirthPointData.bActiveState);
					if (RebirthPointData.bActiveState)
					{
						uNiagaraComponent2.Activate();
					}
					else
					{
						uNiagaraComponent2.Deactivate();
					}
				}
			}
		}
		if (!RebirthPointData.bActiveState)
		{
			return;
		}
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID);
		if (rebirthPointDesc != null)
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(rebirthPointDesc.ActiveStateMontage, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(base.Owner, uAnimMontage, FName.None);
			}
		}
	}

	private void InitRebirthPointData()
	{
		FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID);
		if (!BGW_LogUtil.LogIfNull(rebirthPointDesc, "Find RebirthPointDesc failed! RebirthPointID: {0}", RebirthPointData.RebirthPointConfigID))
		{
			RebirthPointData.RebirthPointRebirthTrans = UGSE_CharacterFuncLib.GetSceneComponentTransformByName(GetOwner(), rebirthPointDesc.SceneComponentName);
			BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(rebirthPointDesc.ActiveMontage, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
			BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(rebirthPointDesc.ActiveStateMontage, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
			if (rebirthPointDesc != null && !string.IsNullOrEmpty(rebirthPointDesc.RebirthPointDBCWhenPlayerRebirth))
			{
				BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<BGWDataAsset_B1DBC>(rebirthPointDesc.RebirthPointDBCWhenPlayerRebirth, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
			}
		}
	}

	private void InitRebirthPointEffect()
	{
		if (OwnerAsCharacterCS != null)
		{
			InActiveFXCom = BGUFunctionLibraryCS.TryGetComponentByFName(OwnerAsCharacterCS, B1GlobalFNames.RebirthPointFXInActive) as USceneCaptureComponent;
			ActivatedFXCom = BGUFunctionLibraryCS.TryGetComponentByFName(OwnerAsCharacterCS, B1GlobalFNames.RebirthPointFXActivated) as USceneCaptureComponent;
		}
		else
		{
			foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<USceneComponent>()))
			{
				if (item.GetFName() == B1GlobalFNames.RebirthPointFXInActive)
				{
					InActiveFXCom = item as USceneComponent;
				}
				else if (item.GetFName() == B1GlobalFNames.RebirthPointFXActivated)
				{
					ActivatedFXCom = item as USceneComponent;
				}
			}
		}
		if (InActiveFXCom != null)
		{
			InActiveFXCom.GetChildrenComponents(bIncludeAllDescendants: true, out var Children);
			foreach (USceneComponent item2 in Children)
			{
				if (item2 is UNiagaraComponent uNiagaraComponent)
				{
					uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, RebirthPointData.bActiveState);
					if (RebirthPointData.bActiveState)
					{
						uNiagaraComponent.Deactivate();
					}
					else
					{
						uNiagaraComponent.Activate();
					}
				}
			}
		}
		if (ActivatedFXCom != null)
		{
			ActivatedFXCom.SetVisibility(RebirthPointData.bActiveState, bPropagateToChildren: true);
			ActivatedFXCom.GetChildrenComponents(bIncludeAllDescendants: true, out var Children2);
			foreach (USceneComponent item3 in Children2)
			{
				if (item3 is UNiagaraComponent uNiagaraComponent2)
				{
					uNiagaraComponent2.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, !RebirthPointData.bActiveState);
					if (RebirthPointData.bActiveState)
					{
						uNiagaraComponent2.Activate();
					}
					else
					{
						uNiagaraComponent2.Deactivate();
					}
				}
			}
		}
		if (RebirthPointData.bActiveState)
		{
			FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID);
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimMontage>(rebirthPointDesc.ActiveStateMontage, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(base.Owner, uAnimMontage, FName.None);
			}
		}
	}

	private void OnEnterActiveArea(AActor Actor, EInteractType ObjType)
	{
	}

	private void OnLeaveActiveArea(AActor Actor, EInteractType ObjType)
	{
	}

	private UMaterialInstanceDynamic GetDynamicMaterial(UMeshComponent Mesh, int Index, UMaterialInterface Material)
	{
		if (Material != null)
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = Material as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic == null)
			{
				uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(Mesh, Material, FName.None, EMIDCreationFlags.None);
				Mesh.SetMaterial(Index, uMaterialInstanceDynamic);
			}
			return uMaterialInstanceDynamic;
		}
		return null;
	}
}
