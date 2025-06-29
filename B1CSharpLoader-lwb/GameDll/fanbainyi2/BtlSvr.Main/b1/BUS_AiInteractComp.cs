using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_AiInteractComp : BUS_StateMachineCompBase
{
	public class IdleState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.AiInteractTag.State_Idle;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointFar, BGW_FlowUtils.AiInteractTag.State_TeleportPos);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointNear, BGW_FlowUtils.AiInteractTag.State_MatchPos);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToWaitPointFar, BGW_FlowUtils.AiInteractTag.State_TeleportWait);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToWaitPointNear, BGW_FlowUtils.AiInteractTag.State_MatchWaiting);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_AiInteractComp bUS_AiInteractComp)
			{
				bUS_AiInteractComp.ResetInteractCacheInfo();
			}
		}
	}

	public class ActionState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.AiInteractTag.State_Action;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_NextStep, BGW_FlowUtils.AiInteractTag.State_Idle);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (!(InOwner is BUS_AiInteractComp bUS_AiInteractComp))
			{
				return;
			}
			AActor aActor = EntitySharedRefFuncLib.Actor(bUS_AiInteractComp.AiInteractData.BestInteractEntityRef);
			BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(aActor);
			if (readOnlyData == null || readOnlyData.ActionList == null || readOnlyData.ActionList.Count == 0)
			{
				bUS_AiInteractComp.TryTriggerInteractEnd(EAiBreakInteractionType.Other);
				return;
			}
			bool flag = false;
			if (bUS_AiInteractComp.AiInteractData.InteractActionDesc != null)
			{
				flag = bUS_AiInteractComp.InteractActionTemplate.DoInteractAction(bUS_AiInteractComp.TargetInteractData.InteractiveUnitID, bUS_AiInteractComp.Owner, aActor, bUS_AiInteractComp.AiInteractData.InteractActionDesc);
			}
			if (flag)
			{
				BUS_EventCollectionCS.Get(aActor).Evt_TriggerBeInteract.Invoke(bUS_AiInteractComp.Owner, IsAiTrigger: true);
			}
			else
			{
				bUS_AiInteractComp.TryTriggerInteractEnd(EAiBreakInteractionType.Other);
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			if (InOwner is BUS_AiInteractComp aiInteractComp)
			{
				TickForEndInteract(aiInteractComp);
			}
		}

		private void TickForEndInteract(BUS_AiInteractComp AiInteractComp)
		{
			if (AiInteractComp.UnitStateData.HasState(EBGUUnitState.Attacking) || AiInteractComp.SimpleStateData.HasSimpleState(EBGUSimpleState.Interacting))
			{
				AActor aActor = ECSExtension.ToActor(AiInteractComp.AiInteractData.CurrentInteractingEntityRef);
				if (!(aActor != null))
				{
					return;
				}
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(AiInteractComp.Owner.World);
				if (firstLocalPlayerController != null)
				{
					APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
					if (controlledPawn != null && FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn), BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)) >= (float)AiInteractComp.AiInteractData.InteractiveUnitCommDesc.BreakDistance)
					{
						AiInteractComp.OnBreakInteract(EAiBreakInteractionType.PlayerFaraway);
					}
				}
			}
			else
			{
				AiInteractComp.FinishInteract();
				AiInteractComp.OnEvent(BGW_FlowUtils.AiInteractTag.Event_NextStep);
			}
		}
	}

	public class WaitingState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.AiInteractTag.State_Waiting;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointFar, BGW_FlowUtils.AiInteractTag.State_TeleportPos);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointNear, BGW_FlowUtils.AiInteractTag.State_MatchPos);
		}
	}

	public class MatchPosState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.AiInteractTag.State_MatchPos;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_NextStep, BGW_FlowUtils.AiInteractTag.State_Action);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			BUS_AiInteractComp AiInteractComp = InOwner as BUS_AiInteractComp;
			if (AiInteractComp == null)
			{
				return;
			}
			if (AiInteractComp.AiInteractData.InteractActionDesc.MatchingPosType == EMatchingPosType.None)
			{
				AiInteractComp.OnEvent(BGW_FlowUtils.AiInteractTag.Event_NextStep);
				return;
			}
			AActor aActor = EntitySharedRefFuncLib.Actor(AiInteractComp.AiInteractData.BestInteractEntityRef);
			if (aActor.IsNullOrDestroyed())
			{
				AiInteractComp.TryTriggerInteractEnd(EAiBreakInteractionType.Other);
				return;
			}
			if (AiInteractComp.AiInteractData.InteractActionDesc.CanBreak == EGSYesNo.No)
			{
				BUS_EventCollectionCS.Get(AiInteractComp).Evt_BuffAdd.Invoke(AiInteractComp.CantbreakBuffID, AiInteractComp.Owner, AiInteractComp.Owner, -1f, EBuffSourceType.AIInteract);
			}
			if (AiInteractComp.AiInteractData.InteractActionDesc != null && AiInteractComp.AiInteractData.InteractActionDesc.InteractAction == EInteractAction.DummyMeshAnim && AiInteractComp.AiInteractData.InteractActionDesc.ParamsBool == EGSYesNo.Yes)
			{
				FName fName = new FName(AiInteractComp.AiInteractData.InteractActionDesc.ParamsString[1]);
				BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, aActor, fName, out var SocketOwnerComp);
				USkeletalMeshComponent uSkeletalMeshComponent = SocketOwnerComp as USkeletalMeshComponent;
				if (uSkeletalMeshComponent != null)
				{
					UAnimationAsset animation = BGW_PreloadAssetMgr.Get(AiInteractComp).TryGetCachedResourceObj<UAnimationAsset>(AiInteractComp.AiInteractData.InteractActionDesc.ParamsString[2], ELoadResourceType.SyncLoadAndCache);
					uSkeletalMeshComponent.SetAnimationMode(EAnimationMode.AnimationSingleNode);
					uSkeletalMeshComponent.SetAnimation(animation);
					AiInteractComp.AiInteractData.MatchingPointDummyMesh = uSkeletalMeshComponent;
					AiInteractComp.AiInteractData.MatchingPointDummyMeshSocket = fName;
					return;
				}
			}
			AiInteractComp.TriggerMatchingPositionMove(AiInteractComp.AiInteractData.MatchingPosTargetTransform, delegate(bool Success)
			{
				if (AiInteractComp.CurrentState != null && AiInteractComp.CurrentState.StateTag.Equals(StateTag))
				{
					AiInteractComp.FinishMatchPosition(Success, IsMatchingWaitingPos: false);
				}
			});
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			if (InOwner is BUS_AiInteractComp bUS_AiInteractComp)
			{
				bUS_AiInteractComp.UpdateMoveSpeedRateByCurve();
				TickForMatchPos(bUS_AiInteractComp);
			}
		}

		private void TickForMatchPos(BUS_AiInteractComp AiInteractComp)
		{
			if (!(AiInteractComp.AiInteractData.MatchingPointDummyMesh != null))
			{
				return;
			}
			if (AiInteractComp.DummyMeshTimer < AiInteractComp.DUMMY_WAIT_FRAME)
			{
				AiInteractComp.DummyMeshTimer++;
				return;
			}
			AiInteractComp.DummyMeshTimer = 0;
			USkeletalMeshComponent matchingPointDummyMesh = AiInteractComp.AiInteractData.MatchingPointDummyMesh;
			AiInteractComp.AiInteractData.MatchingPointDummyMesh = null;
			if (ECSExtension.ToActor(AiInteractComp.AiInteractData.CurrentInteractingEntityRef) == null)
			{
				AiInteractComp.TryTriggerInteractEnd(EAiBreakInteractionType.Other);
				return;
			}
			AiInteractComp.TriggerMatchingPositionMove(matchingPointDummyMesh.GetSocketTransform(AiInteractComp.AiInteractData.MatchingPointDummyMeshSocket), delegate(bool Success)
			{
				if (AiInteractComp.CurrentState != null && AiInteractComp.CurrentState.StateTag.Equals(StateTag))
				{
					AiInteractComp.FinishMatchPosition(Success, IsMatchingWaitingPos: false);
				}
			});
		}
	}

	public class MatchWaitingState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.AiInteractTag.State_MatchWaiting;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_NextStep, BGW_FlowUtils.AiInteractTag.State_Waiting);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointFar, BGW_FlowUtils.AiInteractTag.State_TeleportPos);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointNear, BGW_FlowUtils.AiInteractTag.State_MatchPos);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			BUS_AiInteractComp AiInteractComp = InOwner as BUS_AiInteractComp;
			if (AiInteractComp == null)
			{
				return;
			}
			if (EntitySharedRefFuncLib.Actor(AiInteractComp.AiInteractData.BestInteractEntityRef).IsNullOrDestroyed())
			{
				AiInteractComp.TryTriggerInteractEnd(EAiBreakInteractionType.Other);
				return;
			}
			AiInteractComp.TriggerMatchingPositionMove(AiInteractComp.AiInteractData.MatchingPosTargetTransform, delegate(bool Success)
			{
				if (AiInteractComp.CurrentState != null && AiInteractComp.CurrentState.StateTag.Equals(StateTag))
				{
					AiInteractComp.FinishMatchPosition(Success, IsMatchingWaitingPos: true);
				}
			});
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			if (InOwner is BUS_AiInteractComp bUS_AiInteractComp)
			{
				bUS_AiInteractComp.UpdateMoveSpeedRateByCurve();
			}
		}
	}

	public class TeleportPosState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.AiInteractTag.State_TeleportPos;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_NextStep, BGW_FlowUtils.AiInteractTag.State_MatchPos);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (!(InOwner is BUS_AiInteractComp bUS_AiInteractComp))
			{
				return;
			}
			bool flag = false;
			FUStAiInteractionMappingDesc aiInteractionMappingDesc = bUS_AiInteractComp.AiInteractData.AiInteractionMappingDesc;
			if (aiInteractionMappingDesc != null)
			{
				int linerMatchingPointTeleportSkillID = aiInteractionMappingDesc.LinerMatchingPointTeleportSkillID;
				if (linerMatchingPointTeleportSkillID > 0)
				{
					flag = true;
					if (bUS_AiInteractComp.AiInteractData.InteractActionDesc.CanBreak == EGSYesNo.No)
					{
						BUS_EventCollectionCS.Get(bUS_AiInteractComp).Evt_BuffAdd.Invoke(bUS_AiInteractComp.CantbreakBuffID, bUS_AiInteractComp.Owner, bUS_AiInteractComp.Owner, -1f, EBuffSourceType.AIInteract);
					}
					BUS_EventCollectionCS.Get(bUS_AiInteractComp).Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(linerMatchingPointTeleportSkillID, ECastSkillSourceType.AIInteract)
					{
						NeedCheckSkillCanCast = false
					});
				}
			}
			if (!flag)
			{
				bUS_AiInteractComp.OnEvent(BGW_FlowUtils.AiInteractTag.Event_NextStep);
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			if (InOwner is BUS_AiInteractComp bUS_AiInteractComp)
			{
				bUS_AiInteractComp.TickForEndTeleport();
			}
		}
	}

	public class TeleportWaitState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.AiInteractTag.State_TeleportWait;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_NextStep, BGW_FlowUtils.AiInteractTag.State_MatchWaiting);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointFar, BGW_FlowUtils.AiInteractTag.State_TeleportPos);
			base.EventTransitDictionary.Add(BGW_FlowUtils.AiInteractTag.Event_ToInteractPointNear, BGW_FlowUtils.AiInteractTag.State_MatchPos);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (!(InOwner is BUS_AiInteractComp bUS_AiInteractComp))
			{
				return;
			}
			bool flag = false;
			FUStAiInteractionMappingDesc aiInteractionMappingDesc = bUS_AiInteractComp.AiInteractData.AiInteractionMappingDesc;
			if (aiInteractionMappingDesc != null)
			{
				int linerMatchingPointTeleportSkillID = aiInteractionMappingDesc.LinerMatchingPointTeleportSkillID;
				if (linerMatchingPointTeleportSkillID > 0)
				{
					flag = true;
					if (bUS_AiInteractComp.AiInteractData.InteractActionDesc.CanBreak == EGSYesNo.No)
					{
						BUS_EventCollectionCS.Get(bUS_AiInteractComp).Evt_BuffAdd.Invoke(bUS_AiInteractComp.CantbreakBuffID, bUS_AiInteractComp.Owner, bUS_AiInteractComp.Owner, -1f, EBuffSourceType.AIInteract);
					}
					BUS_EventCollectionCS.Get(bUS_AiInteractComp).Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(linerMatchingPointTeleportSkillID, ECastSkillSourceType.AIInteract)
					{
						NeedCheckSkillCanCast = false
					});
				}
			}
			if (!flag)
			{
				bUS_AiInteractComp.OnEvent(BGW_FlowUtils.AiInteractTag.Event_NextStep);
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			if (InOwner is BUS_AiInteractComp bUS_AiInteractComp)
			{
				bUS_AiInteractComp.TickForEndTeleport();
			}
		}
	}

	private BUC_AiInteractData AiInteractData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_InteractData TargetInteractData;

	private BUInteractTypeTemplate InteractTypeTemplate;

	private BUInteractActionTemplate InteractActionTemplate;

	private int DUMMY_WAIT_FRAME = 1;

	private int DummyMeshTimer;

	private int CantbreakBuffID = 306;

	private GSStateBase State_Idle { get; set; }

	private GSStateBase State_Action { get; set; }

	private GSStateBase State_Waiting { get; set; }

	private GSStateBase State_MatchPos { get; set; }

	private GSStateBase State_MatchWaiting { get; set; }

	private GSStateBase State_TeleportPos { get; set; }

	private GSStateBase State_TeleportWait { get; set; }

	protected override bool IsIgnoreSavedState()
	{
		return true;
	}

	public override void OnAttach()
	{
		base.OnAttach();
		AiInteractData = RequireWritableData<BUC_AiInteractData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		base.BUSEventCollection.Evt_TriggerAiInteract += new Del_Actor(OnTriggerAiInteract);
		base.BUSEventCollection.Evt_AiComeCloseToInteractActor += new Del_Actor(OnAiComeCloseToInteractActor);
		base.BUSEventCollection.Evt_AiBreakInteract += new Del_AiBreakInteract(OnBreakInteract);
		base.BUSEventCollection.Evt_AiDisengageInteract += new Del_AiBreakInteract(OnDisengageInteract);
		base.BUSEventCollection.Evt_UnitSkillBreak += new Del_UnitSkillBreak(OnSkillBreak);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_TriggerFallDying += new Del_Void_Actor(OnTriggerFallDying);
		base.BUSEventCollection.Evt_TriggerAttackStiff += new Del_TriggerAttackStiff(OnHandleAttackStiff);
	}

	public override void PreBeginPlay()
	{
		State_Idle = AddState(typeof(IdleState), 0);
		State_Action = AddState(typeof(ActionState), 1);
		State_Waiting = AddState(typeof(WaitingState), 2);
		State_MatchPos = AddState(typeof(MatchPosState), 3);
		State_MatchWaiting = AddState(typeof(MatchWaitingState), 4);
		State_TeleportPos = AddState(typeof(TeleportPosState), 5);
		State_TeleportWait = AddState(typeof(TeleportWaitState), 6);
		base.InitialState = State_Idle;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (DebugConfig.FollowPartnerDispInfo && base.CurrentState != null)
		{
			base.BUSEventCollection?.Evt_UpdateDebugUIInfo.Invoke("FollowPartnerDispInfo", $"当前AI交互状态：{base.CurrentState.StateTag.TagName}");
		}
	}

	private void ResetInteractCacheInfo()
	{
		AiInteractData.SpeedRateDistanceCurve = null;
		AiInteractData.InteractActionDesc = null;
		AiInteractData.AiInteractionMappingDesc = null;
		AiInteractData.OnUnPersistentDestroy();
		base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(CantbreakBuffID, EBuffEffectTriggerType.None);
	}

	private void UpdateMoveSpeedRateByCurve()
	{
		if (AiInteractData.SpeedRateDistanceCurve == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = base.Owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			float inTime = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS), AiInteractData.MatchingPosTargetTransform.GetLocation());
			float floatValue = AiInteractData.SpeedRateDistanceCurve.GetFloatValue(inTime);
			floatValue = ((floatValue > 0f) ? floatValue : 1f);
			if (DebugConfig.EnableMoveSpeedInfoDebug)
			{
				base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("EnableMoveSpeedInfoDebug", "更新曲线：" + AiInteractData.SpeedRateDistanceCurve.GetName(), 3);
				base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("EnableMoveSpeedInfoDebug", $"更新曲线速率：{floatValue}", 4);
			}
			BGUFunctionLibraryCS.BGUAIChangeToTargetSpeedRate(bGUCharacterCS, floatValue);
		}
	}

	private void FinishInteract()
	{
		AActor aActor = ECSExtension.ToActor(AiInteractData.CurrentInteractingEntityRef);
		InteractActionTemplate.OnFinishInteractAction(TargetInteractData.InteractiveUnitID, base.Owner, aActor, AiInteractData.InteractActionDesc);
		InteractTypeTemplate.FinishInteract(TargetInteractData.InteractiveUnitID, base.Owner, aActor);
		base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(CantbreakBuffID, EBuffEffectTriggerType.None);
		BUS_EventCollectionCS.Get(aActor)?.Evt_TriggerFinishInteract.Invoke(base.Owner);
	}

	private bool CacheInteractInfo(AActor InteractActor, bool bFindMatchingPoint)
	{
		if (InteractActor == null)
		{
			return false;
		}
		TargetInteractData = BGU_DataUtil.GetReadOnlyData<IBUC_InteractData, BUC_InteractData>(InteractActor);
		if (BGW_LogUtil.LogIfNull(TargetInteractData, "[AiInteractComp] CacheInteractInfo TargetInteractData == null"))
		{
			return false;
		}
		AiInteractData.InteractiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(TargetInteractData.InteractiveUnitID);
		if (BGW_LogUtil.LogIfNull(AiInteractData.InteractiveUnitCommDesc, "[AiInteractComp] CacheInteractInfo Find InteractiveUnitCommDesc failed! ResID: {0}", TargetInteractData.InteractiveUnitID))
		{
			return false;
		}
		AiInteractData.InteractActionDesc = null;
		List<FUStInteractionMappingDesc> actionList = TargetInteractData.ActionList;
		if (actionList.Count != 0)
		{
			AiInteractData.InteractActionDesc = actionList[0];
			InteractTypeTemplate = BGW_EffectTemplateList.Get(base.Owner).GetInteractTypeTemplate(AiInteractData.InteractiveUnitCommDesc.InteractType);
			InteractActionTemplate = BGW_EffectTemplateList.Get(base.Owner).GetInteractActionTemplate(AiInteractData.InteractActionDesc.InteractAction);
			if (BGW_LogUtil.LogIfNull(InteractTypeTemplate, "[AiInteractComp] CacheInteractInfo InteractTypeTemplate == null") || BGW_LogUtil.LogIfNull(InteractActionTemplate, "[AiInteractComp] CacheInteractInfo InteractActionTemplate == null"))
			{
				return false;
			}
			AiInteractData.AiInteractionMappingDesc = null;
			List<FUStAiInteractionMappingDesc> aiInteractionActionsByGroupID = BGW_GameDB.GetAiInteractionActionsByGroupID(AiInteractData.InteractActionDesc.OriginID, AiInteractData.InteractActionDesc.GroupID);
			if (aiInteractionActionsByGroupID != null && aiInteractionActionsByGroupID.Count > 0)
			{
				FUStAiInteractionMappingDesc fUStAiInteractionMappingDesc = aiInteractionActionsByGroupID[0];
				if (fUStAiInteractionMappingDesc != null)
				{
					AiInteractData.AiInteractionMappingDesc = fUStAiInteractionMappingDesc;
				}
			}
			AiInteractData.CurrentInteractingEntityRef = ECSExtension.ToEntity(InteractActor);
			AiInteractData.BestInteractEntityRef = new EntitySharedRef(InteractActor);
			FName tag = new FName(AiInteractData.InteractActionDesc.MathchingPointCompTag);
			if (!bFindMatchingPoint)
			{
				if (AiInteractData.AiInteractionMappingDesc == null)
				{
					return false;
				}
				tag = new FName(AiInteractData.AiInteractionMappingDesc.WaitingPointCompTag);
			}
			List<UActorComponent> componentsByTag = ECSExtension.ToActor(AiInteractData.CurrentInteractingEntityRef).GetComponentsByTag(UClass.GetClass<USceneComponent>(), tag);
			if (componentsByTag.Count != 0)
			{
				if (componentsByTag[0] is USceneComponent uSceneComponent)
				{
					AiInteractData.MatchingPosTargetTransform = uSceneComponent.GetWorldTransform();
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private void TriggerMatchingPositionMove(in FTransform TargetTrans, Del_MatchingPositionFinishCallback Callback)
	{
		AiInteractData.MatchingPosTargetTransform = TargetTrans;
		base.BUSEventCollection.Evt_ChangeMotionMatchingState.Invoke(EState_MM.Free);
		GSDel_MatchingPositionMove evt_MatchingPositionMove = base.BUSEventCollection.Evt_MatchingPositionMove;
		FMatchingPositionMoveParam Param = new FMatchingPositionMoveParam
		{
			MatchingPosType = AiInteractData.InteractActionDesc.MatchingPosType,
			TargetTrans = AiInteractData.MatchingPosTargetTransform,
			MoveSpeedType = (EAIMoveSpeedType)AiInteractData.InteractActionDesc.MatchingPosMoveSpeedType,
			bFacingTargetRotation = (AiInteractData.InteractActionDesc.MatchingPosFacingTarget == EGSYesNo.Yes),
			bIncludeSelfRadius = false,
			AcceptableRadius = AiInteractData.InteractActionDesc.AcceptableRadius,
			InterpMoveTime = AiInteractData.InteractActionDesc.InterpMoveTime,
			AIPathMoveCallbackFunc = Callback
		};
		evt_MatchingPositionMove.Invoke(in Param);
		if (AiInteractData.AiInteractionMappingDesc != null)
		{
			BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UCurveFloat>(AiInteractData.AiInteractionMappingDesc.LinerMatchingPointSpeedRateDistanceCurvePath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium, delegate(int I, UObject O)
			{
				AiInteractData.SpeedRateDistanceCurve = O as UCurveFloat;
			});
		}
	}

	private void FinishMatchPosition(bool Success, bool IsMatchingWaitingPos)
	{
		if (!Success)
		{
			base.BUSEventCollection.Evt_TeleportMoveByTrans.Invoke(AiInteractData.MatchingPosTargetTransform);
		}
		BGUFunctionLibraryCS.BGUAIChangeToTargetSpeedRate(base.Owner, EAIMoveSpeedType.RUN);
		AActor aActor = ECSExtension.ToActor(AiInteractData.CurrentInteractingEntityRef);
		if (BGW_LogUtil.LogIfNull(aActor, "[AiInteractComp] FinishMatchPosition Interact target {0} is null!!!", AiInteractData.CurrentInteractingEntityRef))
		{
			TryTriggerInteractEnd(EAiBreakInteractionType.Other);
			return;
		}
		OnEvent(BGW_FlowUtils.AiInteractTag.Event_NextStep);
		if (IsMatchingWaitingPos)
		{
			base.BUSEventCollection.Evt_AiFinishComeCloseToInteractActor.Invoke(aActor);
		}
	}

	private void TickForEndTeleport()
	{
		if (!UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(CantbreakBuffID, EBuffEffectTriggerType.None);
			if (AiInteractData.AiInteractionMappingDesc.EnableCheckDistanceAfterTeleport == EGSYesNo.Yes && AiInteractData.AiInteractionMappingDesc != null && FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner), AiInteractData.MatchingPosTargetTransform.GetLocation()) <= (float)AiInteractData.AiInteractionMappingDesc.LinerMatchingPointTeleportFinishCheckDistance)
			{
				base.BUSEventCollection.Evt_TeleportMoveByTrans.Invoke(AiInteractData.MatchingPosTargetTransform);
			}
			OnEvent(BGW_FlowUtils.AiInteractTag.Event_NextStep);
		}
	}

	private void TryTriggerInteractEnd(EAiBreakInteractionType BreakType)
	{
		if (base.CurrentState == null)
		{
			return;
		}
		if (base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_Action))
		{
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			}
			if (AiInteractData.InteractActionDesc != null && AiInteractData.InteractActionDesc.BreakAsFinish == EGSYesNo.Yes)
			{
				FinishInteract();
			}
			else
			{
				base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(CantbreakBuffID, EBuffEffectTriggerType.None);
				AActor aActor = ECSExtension.ToActor(AiInteractData.CurrentInteractingEntityRef);
				InteractTypeTemplate?.BreakInteract(TargetInteractData.InteractiveUnitID, base.Owner, aActor);
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
				if (bUS_GSEventCollection != null && aActor.World != null)
				{
					bUS_GSEventCollection.Evt_TriggerBreakInteract.Invoke(base.Owner);
				}
			}
			base.BGSEventCollection.Evt_BGS_NotifyAiBreakInteractAction.Invoke(BreakType);
		}
		else
		{
			AActor aActor2 = ECSExtension.ToActor(AiInteractData.CurrentInteractingEntityRef);
			BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(aActor2);
			if (bUS_GSEventCollection2 != null && aActor2.World != null)
			{
				bUS_GSEventCollection2.Evt_TriggerInteractRollback.Invoke();
			}
		}
		OnForceJumpToState(BGW_FlowUtils.AiInteractTag.State_Idle);
	}

	private void OnTriggerAiInteract(AActor InteractTarget)
	{
		if (base.CurrentState == null || base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_TeleportPos) || base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_MatchPos) || base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_Action))
		{
			return;
		}
		if (CacheInteractInfo(InteractTarget, bFindMatchingPoint: true))
		{
			if (TargetInteractData.InteractConstraint != EInteractConstraint.None)
			{
				TryTriggerInteractEnd(EAiBreakInteractionType.Other);
				return;
			}
			if (!InteractTypeTemplate.TriggerInteractInput(TargetInteractData.InteractiveUnitID, base.Owner, InteractTarget))
			{
				TryTriggerInteractEnd(EAiBreakInteractionType.Other);
				return;
			}
			BUS_EventCollectionCS.Get(InteractTarget).Evt_TriggerPreInteractForAiInteract.Invoke(base.Owner);
			AiInteractData.StartInteractTime = base.Owner.World.GetTimeSeconds();
			AiInteractData.IsTriggerBreak = false;
			InteractTypeTemplate.FinishInteractInput(TargetInteractData.InteractiveUnitID, base.Owner, InteractTarget);
			bool flag = false;
			if (AiInteractData.AiInteractionMappingDesc != null && ECSExtension.ToActor(AiInteractData.CurrentInteractingEntityRef) != null)
			{
				flag = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner), AiInteractData.MatchingPosTargetTransform.GetLocation()) > (float)AiInteractData.AiInteractionMappingDesc.LinerMatchingPointTeleportDistance;
			}
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			}
			base.BUSEventCollection?.Evt_OnAiMoveToInteractPoint.Invoke();
			OnEvent(flag ? BGW_FlowUtils.AiInteractTag.Event_ToInteractPointFar : BGW_FlowUtils.AiInteractTag.Event_ToInteractPointNear);
		}
		else
		{
			TryTriggerInteractEnd(EAiBreakInteractionType.Other);
		}
	}

	private void OnAiComeCloseToInteractActor(AActor InteractTarget)
	{
		if (base.CurrentState == null || !base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_Idle))
		{
			return;
		}
		if (CacheInteractInfo(InteractTarget, bFindMatchingPoint: false))
		{
			bool flag = false;
			if (AiInteractData.AiInteractionMappingDesc != null && ECSExtension.ToActor(AiInteractData.CurrentInteractingEntityRef) != null)
			{
				flag = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(base.Owner), AiInteractData.MatchingPosTargetTransform.GetLocation()) > (float)AiInteractData.AiInteractionMappingDesc.LinerMatchingPointTeleportDistance;
			}
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			}
			base.BUSEventCollection?.Evt_OnAiMoveToWaitPoint.Invoke();
			OnEvent(flag ? BGW_FlowUtils.AiInteractTag.Event_ToWaitPointFar : BGW_FlowUtils.AiInteractTag.Event_ToWaitPointNear);
		}
		else
		{
			TryTriggerInteractEnd(EAiBreakInteractionType.Other);
		}
	}

	private void OnBreakInteract(EAiBreakInteractionType BreakType)
	{
		if (base.CurrentState != null && !base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_Idle))
		{
			if (UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, 0f);
			}
			TryTriggerInteractEnd(BreakType);
		}
	}

	private void OnDisengageInteract(EAiBreakInteractionType BreakType)
	{
		if (base.CurrentState != null && !base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_Idle) && !base.CurrentState.StateTag.Equals(BGW_FlowUtils.AiInteractTag.State_Action))
		{
			TryTriggerInteractEnd(BreakType);
		}
	}

	private void OnSkillBreak(int SkillID, string Reason)
	{
		OnBreakInteract(EAiBreakInteractionType.Other);
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		OnBreakInteract(EAiBreakInteractionType.Other);
	}

	private void OnTriggerFallDying(AActor Attacker)
	{
		OnBreakInteract(EAiBreakInteractionType.Other);
	}

	private void OnHandleAttackStiff(AActor AttackerMaster, int StiffLevel, float HitWeight)
	{
		OnBreakInteract(EAiBreakInteractionType.Other);
	}
}
