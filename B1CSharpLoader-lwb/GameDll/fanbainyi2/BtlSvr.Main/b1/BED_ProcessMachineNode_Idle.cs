using System;
using System.Collections.Generic;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("空闲（Idle）")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Idle")]
public class BED_ProcessMachineNode_Idle : BED_ProcessMachineNode_TemplateBase
{
	private static bool TransitionConditions_IsValid;

	private static int TransitionConditions_Offset;

	private static FFieldAddress TransitionConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FCompositeTransitionCondition_Idle> TransitionConditions_Marshaler;

	private static bool ProcessActions_IsValid;

	private static int ProcessActions_Offset;

	private static FFieldAddress ProcessActions_PropertyAddress;

	private TArrayReadWriteMarshaler<FIdleProcessAction> ProcessActions_Marshaler;

	private static bool bUseResetPin_IsValid;

	private static int bUseResetPin_Offset;

	private static FFieldAddress bUseResetPin_PropertyAddress;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("跳转条件")]
	[Tooltip("跳出当前状态的条件，多个条件就是多个分支")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Idle:TransitionConditions")]
	public TArrayReadWrite<FCompositeTransitionCondition_Idle> TransitionConditions
	{
		get
		{
			CheckDestroyed();
			if (!TransitionConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Idle:TransitionConditions");
				return null;
			}
			if (TransitionConditions_Marshaler == null)
			{
				TransitionConditions_Marshaler = new TArrayReadWriteMarshaler<FCompositeTransitionCondition_Idle>(1, TransitionConditions_PropertyAddress, CachedMarshalingDelegates<FCompositeTransitionCondition_Idle, FCompositeTransitionCondition_Idle>.FromNative, CachedMarshalingDelegates<FCompositeTransitionCondition_Idle, FCompositeTransitionCondition_Idle>.ToNative);
			}
			return TransitionConditions_Marshaler.FromNative(IntPtr.Add(base.Address, TransitionConditions_Offset));
		}
	}

	[Tooltip("进入时直接执行")]
	[DisplayName("执行逻辑")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Idle:ProcessActions")]
	public TArrayReadWrite<FIdleProcessAction> ProcessActions
	{
		get
		{
			CheckDestroyed();
			if (!ProcessActions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Idle:ProcessActions");
				return null;
			}
			if (ProcessActions_Marshaler == null)
			{
				ProcessActions_Marshaler = new TArrayReadWriteMarshaler<FIdleProcessAction>(1, ProcessActions_PropertyAddress, CachedMarshalingDelegates<FIdleProcessAction, FIdleProcessAction>.FromNative, CachedMarshalingDelegates<FIdleProcessAction, FIdleProcessAction>.ToNative);
			}
			return ProcessActions_Marshaler.FromNative(IntPtr.Add(base.Address, ProcessActions_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("Pin")]
	[DisplayName("是否把重置作为跳转条件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Idle:bUseResetPin")]
	public bool bUseResetPin
	{
		get
		{
			CheckDestroyed();
			if (!bUseResetPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Idle:bUseResetPin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseResetPin_Offset), 0, bUseResetPin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseResetPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_Idle:bUseResetPin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseResetPin_Offset), 0, bUseResetPin_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.OutputPins.Clear();
		bUseResetPin = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Idle;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Idle:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> contextOutputsInCS_Implementation = base.GetContextOutputsInCS_Implementation();
		if (bUseResetPin)
		{
			contextOutputsInCS_Implementation.Add(BGW_FlowUtils.PinName.Reset);
		}
		if (TransitionConditions.Count > 0)
		{
			int num = 1;
			foreach (FCompositeTransitionCondition_Idle transitionCondition in TransitionConditions)
			{
				contextOutputsInCS_Implementation.Add(new FName(GetConditionOutputName(num, transitionCondition)));
				num++;
			}
		}
		return contextOutputsInCS_Implementation;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Idle:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.PostPropertyChanged_Implementation(MemberName, PropertyName);
		if (PropertyName == "bUseResetPin")
		{
			ExecuteOnReconstructionRequested();
		}
	}

	public override byte[] GetCustomData()
	{
		ProcessCustom_Idle processCustom_Idle = new ProcessCustom_Idle();
		int num = 1;
		foreach (FCompositeTransitionCondition_Idle transitionCondition in TransitionConditions)
		{
			CalliopeCustom_CompositeTransitionCondition_Idle calliopeCustom_CompositeTransitionCondition_Idle = new CalliopeCustom_CompositeTransitionCondition_Idle();
			calliopeCustom_CompositeTransitionCondition_Idle.IsUseCompositeCondition = transitionCondition.bUseCompositeCondition;
			if (transitionCondition.bUseCompositeCondition)
			{
				calliopeCustom_CompositeTransitionCondition_Idle.ConditionalRelation = (int)transitionCondition.ConditionalRelation;
				foreach (FTransitionCondition_Idle condition in transitionCondition.Conditions)
				{
					calliopeCustom_CompositeTransitionCondition_Idle.Conditions.Add(new CalliopeCustom_TransitionCondition_Idle
					{
						ConditionType = (int)condition.ConditionType,
						OverlapGuid = condition.Overlap.ConfigGuid.ToString(),
						InteractorGuid = condition.Interactor.ConfigGuid.ToString(),
						UnitGuid = condition.Unit.ConfigGuid.ToString(),
						NpcGuid = condition.NPCUnit.ConfigGuid.ToString(),
						GameStateCondition = (int)condition.GameStateCondition,
						InAreaTimer = condition.Timer_InArea,
						OutAreaTimer = condition.Timer_OutArea,
						TaskStageId = condition.TaskStage.ConfigGuid.ToString(),
						TaskStageStatus = (int)condition.TaskStageStatus,
						InteractGroupId = condition.InteractionGroupID,
						InteractStep = condition.InteractionStep,
						OwningItemId = condition.OwningItemID,
						OwningNum = condition.OwningNum,
						ConsumeItemId = condition.ConsumeItemID,
						ConsumptionQuantity = condition.ConsumptionQuantity,
						IsReverseCondition = condition.bReverseCondition,
						NpcMoveType = (int)condition.NpcMoveType,
						ActorGuid = ((condition.NpcMoveType == ENpcMoveType.Navigation) ? condition.TargetActor.ActorGuid : condition.SplineActor.ActorGuid),
						MoveAcceptableRadius = condition.MoveAcceptableRadius,
						SkillId = condition.SkillID
					});
				}
			}
			else
			{
				FTransitionCondition_Idle single = transitionCondition.Single;
				calliopeCustom_CompositeTransitionCondition_Idle.Single = new CalliopeCustom_TransitionCondition_Idle
				{
					ConditionType = (int)single.ConditionType,
					OverlapGuid = single.Overlap.ConfigGuid.ToString(),
					InteractorGuid = single.Interactor.ConfigGuid.ToString(),
					UnitGuid = single.Unit.ConfigGuid.ToString(),
					NpcGuid = single.NPCUnit.ConfigGuid.ToString(),
					GameStateCondition = (int)single.GameStateCondition,
					InAreaTimer = single.Timer_InArea,
					OutAreaTimer = single.Timer_OutArea,
					TaskStageId = single.TaskStage.ConfigGuid.ToString(),
					TaskStageStatus = (int)single.TaskStageStatus,
					InteractGroupId = single.InteractionGroupID,
					InteractStep = single.InteractionStep,
					OwningItemId = single.OwningItemID,
					OwningNum = single.OwningNum,
					ConsumeItemId = single.ConsumeItemID,
					ConsumptionQuantity = single.ConsumptionQuantity,
					IsReverseCondition = single.bReverseCondition,
					NpcMoveType = (int)single.NpcMoveType,
					ActorGuid = ((single.NpcMoveType == ENpcMoveType.Navigation) ? single.TargetActor.ActorGuid : single.SplineActor.ActorGuid),
					MoveAcceptableRadius = single.MoveAcceptableRadius,
					SkillId = single.SkillID
				};
			}
			calliopeCustom_CompositeTransitionCondition_Idle.IsReverseCondition = transitionCondition.bReverseCondition;
			calliopeCustom_CompositeTransitionCondition_Idle.PinName = GetConditionOutputName(num, transitionCondition);
			processCustom_Idle.TransitionConditions.Add(calliopeCustom_CompositeTransitionCondition_Idle);
			num++;
		}
		foreach (FIdleProcessAction processAction in ProcessActions)
		{
			CalliopeCustom_IdleProcessAction calliopeCustom_IdleProcessAction = new CalliopeCustom_IdleProcessAction();
			calliopeCustom_IdleProcessAction.ActionType = (int)processAction.ActionType;
			calliopeCustom_IdleProcessAction.IsTeleportToOtherLevel = processAction.bTeleportToOtherLevel;
			calliopeCustom_IdleProcessAction.TargetLevelId = processAction.TargetLevelID;
			FName pointName = processAction.PointName;
			calliopeCustom_IdleProcessAction.PointName = pointName.PlainName;
			calliopeCustom_IdleProcessAction.BeforeTeleportMontage = ConvertSoftObj2NodeData(processAction.BeforeTeleportMontage);
			calliopeCustom_IdleProcessAction.AfterTeleportMontage = ConvertSoftObj2NodeData(processAction.AfterTeleportMontage);
			calliopeCustom_IdleProcessAction.IsSaveArchiveAfterTeleport = processAction.bSaveArchiveAfterTeleport;
			pointName = processAction.ArchiveLabel;
			calliopeCustom_IdleProcessAction.ArchiveLabel = pointName.PlainName;
			calliopeCustom_IdleProcessAction.RebirthPointId = processAction.RebirthPointID;
			calliopeCustom_IdleProcessAction.IsBlockRebirthpoint = processAction.IsBlockRebirthpoint;
			calliopeCustom_IdleProcessAction.IsDontResetPlayerState = processAction.bDontResetPlayerState;
			calliopeCustom_IdleProcessAction.LoadingScreenType = (int)processAction.LoadingScreenType;
			calliopeCustom_IdleProcessAction.TeleportLoadingTips.AddRange(processAction.TeleportLoadingTips);
			calliopeCustom_IdleProcessAction.ExtendId = processAction.UnitExtendID;
			if (processAction.ActionType == EIdleProcessActionType.AiConversation)
			{
				calliopeCustom_IdleProcessAction.UnitGuid = processAction.UnitOrPlayerorNPC.ConfigGuid.ToString();
			}
			else if (processAction.ActionType == EIdleProcessActionType.NpcPlayMontage || processAction.ActionType == EIdleProcessActionType.NpcMoveTo)
			{
				calliopeCustom_IdleProcessAction.UnitGuid = processAction.NPCUnit.ConfigGuid.ToString();
			}
			else
			{
				calliopeCustom_IdleProcessAction.UnitGuid = processAction.Unit.ConfigGuid.ToString();
			}
			calliopeCustom_IdleProcessAction.DropItemManageGuid = processAction.DropItemManageGuid;
			calliopeCustom_IdleProcessAction.AiConversationContentIdList = processAction.AiConversation.ConfigGuid.ToString();
			calliopeCustom_IdleProcessAction.NpcTeamId = processAction.NPCTeamID;
			calliopeCustom_IdleProcessAction.NpcIdleAmIdx = processAction.NPCIdleAMIdx;
			calliopeCustom_IdleProcessAction.NpcLeisureAnimIndex = processAction.NPCLeisureAnimIndex;
			calliopeCustom_IdleProcessAction.NpcActionSkillId = processAction.NPCActionSkillID;
			calliopeCustom_IdleProcessAction.NpcInteractGroupId = processAction.NPCInteractGroupID;
			calliopeCustom_IdleProcessAction.NpcShowState = (int)processAction.NPCShowState;
			foreach (FProcessUnitTriggerBattleConfig unitTriggerBattleConfig in processAction.UnitTriggerBattleConfigs)
			{
				calliopeCustom_IdleProcessAction.TriggerUnitBattleConfigs.Add(new CalliopeCustom_TriggerUnitBattleConfig
				{
					UnitGuid = unitTriggerBattleConfig.Unit.ConfigGuid.ToString(),
					SwitchTeamId = unitTriggerBattleConfig.SwitchTeamID,
					TargetGuid = unitTriggerBattleConfig.TargetUnit.ConfigGuid.ToString()
				});
			}
			calliopeCustom_IdleProcessAction.FollowPartnerConfigId = processAction.FollowPartnerConfigId.ConfigGuid.ToString();
			calliopeCustom_IdleProcessAction.AssociationUnitInfoConfigId = processAction.AssociationUnitInfoConfigId.ConfigGuid.ToString();
			calliopeCustom_IdleProcessAction.AssociationUnitSpawnInfoDelayExecuteTime = processAction.AssociationUnitSpawnInfoDelayExecuteTime;
			calliopeCustom_IdleProcessAction.AssociationUnitSpawnInfoSpawnType = (int)processAction.AssociationUnitSpawnInfoSpawnType;
			calliopeCustom_IdleProcessAction.AssociationUnitSpawnInfoActiveType = (int)processAction.AssociationUnitSpawnInfoActiveType;
			calliopeCustom_IdleProcessAction.AssociationUnitActiveInfoTargetGuid = processAction.AssociationUnitTarget.ConfigGuid.ToString();
			calliopeCustom_IdleProcessAction.AssociationUnitActiveInfoOnfightSkillid = processAction.AssociationOnFightSkillID;
			calliopeCustom_IdleProcessAction.TargetActorGuid = processAction.TargetActor.ActorGuid;
			calliopeCustom_IdleProcessAction.GameplayTag = processAction.GameplayTag.TagName.PlainName;
			calliopeCustom_IdleProcessAction.NpcMoveType = (int)processAction.NpcMoveType;
			switch (processAction.NpcMoveType)
			{
			case ENpcMoveType.Navigation:
				calliopeCustom_IdleProcessAction.TargetActorGuid = processAction.TargetActor.ActorGuid;
				calliopeCustom_IdleProcessAction.MoveAiType = (int)processAction.MoveAIType;
				calliopeCustom_IdleProcessAction.MoveSpeedType = (int)processAction.MoveSpeedType;
				calliopeCustom_IdleProcessAction.MoveAcceptableRadius = processAction.MoveAcceptableRadius;
				break;
			case ENpcMoveType.Spline:
				calliopeCustom_IdleProcessAction.TargetActorGuid = processAction.NpcGuideSplineMoveConfig.SplineActor.ActorGuid;
				calliopeCustom_IdleProcessAction.NeedSwitchSpeedByDistanceToPlayer = processAction.NpcGuideSplineMoveConfig.NeedSwitchSpeedByDistanceToPlayer;
				calliopeCustom_IdleProcessAction.MoveSpeedType = (int)processAction.NpcGuideSplineMoveConfig.SplineMoveSpeed;
				calliopeCustom_IdleProcessAction.MaxDistanceSprint = processAction.NpcGuideSplineMoveConfig.MaxDistance_Sprint;
				calliopeCustom_IdleProcessAction.MaxDistanceRun = processAction.NpcGuideSplineMoveConfig.MaxDistance_Run;
				calliopeCustom_IdleProcessAction.MaxDistanceJog = processAction.NpcGuideSplineMoveConfig.MaxDistance_Jog;
				calliopeCustom_IdleProcessAction.DistanceBuffer = processAction.NpcGuideSplineMoveConfig.DistanceBuffer;
				break;
			}
			calliopeCustom_IdleProcessAction.WeakPerformConfigId = processAction.WeakPerformConfigID;
			processCustom_Idle.ProcessActions.Add(calliopeCustom_IdleProcessAction);
		}
		processCustom_Idle.ManagedObjs.AddRange(MakeManagedSceneObjCustomData());
		processCustom_Idle.ManagedNpcUnits.AddRange(MakeManagedNPCUnitCustomData());
		processCustom_Idle.ManagedInteractors.AddRange(MakeManagedInteractorCustomData());
		processCustom_Idle.ManagedStreamingLevelStateConfigs.AddRange(MakeManagedStreamingLevelStateConfigCustomData());
		processCustom_Idle.ManagedGroupUnits.AddRange(MakeManagedGroupUnitCustomData());
		return processCustom_Idle.ToByteArray();
	}

	private string GetConditionOutputName(int ConditionCount, FCompositeTransitionCondition_Idle TransitionCondition)
	{
		string result = $"跳转条件{ConditionCount}";
		string OutDisplayName;
		if (!string.IsNullOrEmpty(TransitionCondition.Comment))
		{
			result = TransitionCondition.Comment;
		}
		else if (!TransitionCondition.bUseCompositeCondition && TransitionCondition.Single.ConditionType == ETransitionConditionType_Idle.TaskStage && GetCalliopeAsset().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(TransitionCondition.Single.TaskStage.ConfigGuid), "TaskStage", out OutDisplayName))
		{
			string text = ((TransitionCondition.Single.TaskStageStatus == EStageStatus.Activated) ? "激活" : ((TransitionCondition.Single.TaskStageStatus == EStageStatus.Finished) ? "完成" : "要写状态！"));
			result = OutDisplayName + "[" + text + "]";
		}
		return result;
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		bool flag = base.CorrectnessCheck(out OutErrorMessage);
		StringBuilder stringBuilder = new StringBuilder(OutErrorMessage);
		bool flag2 = true;
		foreach (FCompositeTransitionCondition_Idle transitionCondition in TransitionConditions)
		{
			if (transitionCondition.bUseCompositeCondition)
			{
				foreach (FTransitionCondition_Idle condition in transitionCondition.Conditions)
				{
					if (condition.ConditionType == ETransitionConditionType_Idle.None)
					{
						flag2 = false;
					}
				}
			}
			else if (transitionCondition.Single.ConditionType == ETransitionConditionType_Idle.None)
			{
				flag2 = false;
			}
		}
		if (!flag2)
		{
			stringBuilder.AppendLine("不可以有类型为None的跳转条件");
		}
		OutErrorMessage = stringBuilder.ToString();
		return flag && flag2;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_Idle:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_Idle bED_ProcessMachineNode_Idle = GCHelper.Find<BED_ProcessMachineNode_Idle>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_ProcessMachineNode_Idle.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_Idle:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_Idle bED_ProcessMachineNode_Idle = GCHelper.Find<BED_ProcessMachineNode_Idle>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ProcessMachineNode_Idle.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Idle");
		NativeReflection.GetPropertyRef(ref TransitionConditions_PropertyAddress, intPtr, "TransitionConditions");
		TransitionConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransitionConditions");
		TransitionConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransitionConditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ProcessActions_PropertyAddress, intPtr, "ProcessActions");
		ProcessActions_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcessActions");
		ProcessActions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcessActions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bUseResetPin_PropertyAddress, intPtr, "bUseResetPin");
		bUseResetPin_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseResetPin");
		bUseResetPin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseResetPin", Classes.FBoolProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_Idle:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_Idle:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_ProcessMachineNode_Idle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Idle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Idle));
	}
}
