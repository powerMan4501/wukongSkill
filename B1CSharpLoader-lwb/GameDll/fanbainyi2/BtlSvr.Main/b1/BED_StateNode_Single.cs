using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("State")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_StateNode_Single")]
public class BED_StateNode_Single : BED_StateNode
{
	private static bool StateName_IsValid;

	private static int StateName_Offset;

	private static bool SubStateMachine_IsValid;

	private static int SubStateMachine_Offset;

	private static bool SubGraphAssetInstance_IsValid;

	private static int SubGraphAssetInstance_Offset;

	private static bool Events_IsValid;

	private static int Events_Offset;

	private static bool DetectUnitConditions_IsValid;

	private static int DetectUnitConditions_Offset;

	private static FFieldAddress DetectUnitConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FDetectUnitCondition> DetectUnitConditions_Marshaler;

	private static bool OtherConditions_IsValid;

	private static int OtherConditions_Offset;

	private static FFieldAddress OtherConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FCompositeTransitionCondition_State> OtherConditions_Marshaler;

	private static bool ChildActorCollection_IsValid;

	private static int ChildActorCollection_Offset;

	private static bool JumpToEnterStateNode_IsValid;

	private static IntPtr JumpToEnterStateNode_FunctionAddress;

	private static int JumpToEnterStateNode_ParamsSize;

	private static bool IsSubGraphNode_IsValid;

	private static IntPtr IsSubGraphNode_FunctionAddress;

	private static int IsSubGraphNode_ParamsSize;

	private static bool IsSubGraphNode_ReturnValue_IsValid;

	private static int IsSubGraphNode_ReturnValue_Offset;

	private static FFieldAddress IsSubGraphNode_ReturnValue_PropertyAddress;

	private static bool OnSelectNodeInCS_IsValid;

	private static IntPtr OnSelectNodeInCS_FunctionAddress;

	private static int OnSelectNodeInCS_ParamsSize;

	private static bool PrePropertyChanged_IsValid;

	private static IntPtr PrePropertyChanged_FunctionAddress;

	private static int PrePropertyChanged_ParamsSize;

	private static bool PrePropertyChanged_PropertyName_IsValid;

	private static int PrePropertyChanged_PropertyName_Offset;

	private static FFieldAddress PrePropertyChanged_PropertyName_PropertyAddress;

	private static bool GetAssetToEditInCS_IsValid;

	private static IntPtr GetAssetToEditInCS_FunctionAddress;

	private static int GetAssetToEditInCS_ParamsSize;

	private static bool GetAssetToEditInCS_ReturnValue_IsValid;

	private static int GetAssetToEditInCS_ReturnValue_Offset;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetContextInputsInCS_IsValid;

	private static IntPtr GetContextInputsInCS_FunctionAddress;

	private static int GetContextInputsInCS_ParamsSize;

	private static bool GetContextInputsInCS_ReturnValue_IsValid;

	private static int GetContextInputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextInputsInCS_ReturnValue_PropertyAddress;

	private static bool SetSubGraphAssetInPIE_IsValid;

	private static IntPtr SetSubGraphAssetInPIE_FunctionAddress;

	private static int SetSubGraphAssetInPIE_ParamsSize;

	private static bool SetSubGraphAssetInPIE_InSubGraphAsset_IsValid;

	private static int SetSubGraphAssetInPIE_InSubGraphAsset_Offset;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("State")]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:StateName")]
	public FGameplayTag StateName
	{
		get
		{
			CheckDestroyed();
			if (!StateName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:StateName");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, StateName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StateName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:StateName");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, StateName_Offset), value);
			}
		}
	}

	[Category("State")]
	[DisplayName("子状态机")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:SubStateMachine")]
	public BED_StateAsset SubStateMachine
	{
		get
		{
			CheckDestroyed();
			if (!SubStateMachine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:SubStateMachine");
				return null;
			}
			return UObjectMarshaler<BED_StateAsset>.FromNative(IntPtr.Add(base.Address, SubStateMachine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubStateMachine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:SubStateMachine");
			}
			else
			{
				UObjectMarshaler<BED_StateAsset>.ToNative(IntPtr.Add(base.Address, SubStateMachine_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:SubGraphAssetInstance")]
	public BED_StateAsset SubGraphAssetInstance
	{
		get
		{
			CheckDestroyed();
			if (!SubGraphAssetInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:SubGraphAssetInstance");
				return null;
			}
			return UObjectMarshaler<BED_StateAsset>.FromNative(IntPtr.Add(base.Address, SubGraphAssetInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubGraphAssetInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:SubGraphAssetInstance");
			}
			else
			{
				UObjectMarshaler<BED_StateAsset>.ToNative(IntPtr.Add(base.Address, SubGraphAssetInstance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[DisplayName("事件列表")]
	[Category("State")]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:Events")]
	public FGameplayTagContainer Events
	{
		get
		{
			CheckDestroyed();
			if (!Events_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:Events");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, Events_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Events_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:Events");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, Events_Offset), value);
			}
		}
	}

	[Category("State")]
	[DisplayName("检测单位跳转条件")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:DetectUnitConditions")]
	public TArrayReadWrite<FDetectUnitCondition> DetectUnitConditions
	{
		get
		{
			CheckDestroyed();
			if (!DetectUnitConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:DetectUnitConditions");
				return null;
			}
			if (DetectUnitConditions_Marshaler == null)
			{
				DetectUnitConditions_Marshaler = new TArrayReadWriteMarshaler<FDetectUnitCondition>(1, DetectUnitConditions_PropertyAddress, CachedMarshalingDelegates<FDetectUnitCondition, FDetectUnitCondition>.FromNative, CachedMarshalingDelegates<FDetectUnitCondition, FDetectUnitCondition>.ToNative);
			}
			return DetectUnitConditions_Marshaler.FromNative(IntPtr.Add(base.Address, DetectUnitConditions_Offset));
		}
	}

	[Category("State")]
	[DisplayName("其他跳转条件")]
	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:OtherConditions")]
	public TArrayReadWrite<FCompositeTransitionCondition_State> OtherConditions
	{
		get
		{
			CheckDestroyed();
			if (!OtherConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:OtherConditions");
				return null;
			}
			if (OtherConditions_Marshaler == null)
			{
				OtherConditions_Marshaler = new TArrayReadWriteMarshaler<FCompositeTransitionCondition_State>(1, OtherConditions_PropertyAddress, CachedMarshalingDelegates<FCompositeTransitionCondition_State, FCompositeTransitionCondition_State>.FromNative, CachedMarshalingDelegates<FCompositeTransitionCondition_State, FCompositeTransitionCondition_State>.ToNative);
			}
			return OtherConditions_Marshaler.FromNative(IntPtr.Add(base.Address, OtherConditions_Offset));
		}
	}

	[EditDefaultsOnly]
	[Category("State")]
	[DisplayName("专属物件状态管理")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:ChildActorCollection")]
	public FStateNodeChildActorControl ChildActorCollection
	{
		get
		{
			CheckDestroyed();
			if (!ChildActorCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:ChildActorCollection");
				return default(FStateNodeChildActorControl);
			}
			return FStateNodeChildActorControl.FromNative(IntPtr.Add(base.Address, ChildActorCollection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChildActorCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_StateNode_Single:ChildActorCollection");
			}
			else
			{
				FStateNodeChildActorControl.ToNative(IntPtr.Add(base.Address, ChildActorCollection_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Notifies";
		base.NodeStyle = ECalliopeNodeStyle.SubGraph;
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.ShallowHistory
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.DeepHistory
		});
		base.OutputPins.Clear();
		base.SupportsContextPins = true;
	}

	public override byte[] GetCustomData()
	{
		StateCustom_Single stateCustom_Single = new StateCustom_Single();
		stateCustom_Single.StateName = StateName.TagName.PlainName;
		if (SubStateMachine != null)
		{
			SubStateMachine.ExportToData();
			string pathName = SubStateMachine.GetPathName();
			stateCustom_Single.SubStateMachinePath = Path.Combine(Path.GetDirectoryName(pathName) ?? string.Empty, Path.GetFileNameWithoutExtension(pathName)).Replace("\\", "/");
		}
		UCalliopeAsset calliopeAsset = GetCalliopeAsset();
		int num = 1;
		string OutActorGuid;
		foreach (FDetectUnitCondition detectUnitCondition in DetectUnitConditions)
		{
			CalliopeCustom_DetectUnitCondition calliopeCustom_DetectUnitCondition = new CalliopeCustom_DetectUnitCondition();
			calliopeCustom_DetectUnitCondition.UnitType = (int)detectUnitCondition.UnitType;
			foreach (FDetectCondition condition in detectUnitCondition.Conditions)
			{
				calliopeCustom_DetectUnitCondition.Conditions.Add(condition.GetSerializableObject());
			}
			calliopeCustom_DetectUnitCondition.ConditionalRelation = (int)detectUnitCondition.ConditionalRelation;
			if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(detectUnitCondition.SmartUnit.ConfigGuid), out OutActorGuid))
			{
				calliopeCustom_DetectUnitCondition.SmartUnitGuid = OutActorGuid;
			}
			string pinName = $"跳转条件{num++}";
			if (!string.IsNullOrEmpty(detectUnitCondition.Comment))
			{
				pinName = detectUnitCondition.Comment;
			}
			calliopeCustom_DetectUnitCondition.PinName = pinName;
			calliopeCustom_DetectUnitCondition.BossPhaseInfo = BED_CalliopeFuncLib.SerializeToCustomData(detectUnitCondition.BossPhaseInfo);
			stateCustom_Single.DetectUnitConditions.Add(calliopeCustom_DetectUnitCondition);
		}
		foreach (FCompositeTransitionCondition_State otherCondition in OtherConditions)
		{
			CalliopeCustom_CompositeTransitionCondition_State calliopeCustom_CompositeTransitionCondition_State = new CalliopeCustom_CompositeTransitionCondition_State();
			calliopeCustom_CompositeTransitionCondition_State.IsUseCompositeCondition = otherCondition.bUseCompositeCondition;
			int OutBuffID;
			if (otherCondition.bUseCompositeCondition)
			{
				calliopeCustom_CompositeTransitionCondition_State.ConditionalRelation = (int)otherCondition.ConditionalRelation;
				foreach (FTransitionCondition_State condition2 in otherCondition.Conditions)
				{
					CalliopeCustom_TransitionCondition_State calliopeCustom_TransitionCondition_State = new CalliopeCustom_TransitionCondition_State();
					calliopeCustom_TransitionCondition_State.ConditionType = (int)condition2.ConditionType;
					foreach (Guid configGuide in condition2.UnitList.ConfigGuides)
					{
						if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(configGuide), out OutActorGuid))
						{
							calliopeCustom_TransitionCondition_State.Units.Add(OutActorGuid);
						}
					}
					if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition2.UnitSpawner.ConfigGuid), out OutActorGuid))
					{
						calliopeCustom_TransitionCondition_State.Spawner = OutActorGuid;
					}
					if (calliopeAsset.GetParameterBuffIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition2.Buff.ConfigGuid), out OutBuffID))
					{
						calliopeCustom_TransitionCondition_State.BuffId = OutBuffID;
					}
					if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition2.Unit.ConfigGuid), out OutActorGuid))
					{
						calliopeCustom_TransitionCondition_State.UnitGuid = OutActorGuid;
					}
					if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition2.Overlap.ConfigGuid), out OutActorGuid))
					{
						calliopeCustom_TransitionCondition_State.OverlapGuid = OutActorGuid;
					}
					if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition2.Interactor.ConfigGuid), out OutActorGuid))
					{
						calliopeCustom_TransitionCondition_State.InteractorGuid = OutActorGuid;
					}
					if (calliopeAsset.GetParameterSequenceIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition2.Sequence.ConfigGuid), out OutBuffID))
					{
						calliopeCustom_TransitionCondition_State.SequenceId = OutBuffID;
					}
					if (calliopeAsset.GetParameterTaskStateIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(condition2.TaskStage.ConfigGuid), out OutBuffID))
					{
						calliopeCustom_TransitionCondition_State.TaskStageId = OutBuffID;
					}
					calliopeCustom_TransitionCondition_State.CircusNickName = condition2.CircusMemberNickName.TagName.ToString();
					calliopeCustom_TransitionCondition_State.TaskStageStatus = (int)condition2.TaskStageStatus;
					calliopeCustom_CompositeTransitionCondition_State.Conditions.Add(calliopeCustom_TransitionCondition_State);
				}
			}
			else
			{
				FTransitionCondition_State single = otherCondition.Single;
				calliopeCustom_CompositeTransitionCondition_State.Single = new CalliopeCustom_TransitionCondition_State();
				calliopeCustom_CompositeTransitionCondition_State.Single.ConditionType = (int)single.ConditionType;
				CalliopeCustom_TransitionCondition_State single2 = calliopeCustom_CompositeTransitionCondition_State.Single;
				foreach (Guid configGuide2 in single.UnitList.ConfigGuides)
				{
					if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(configGuide2), out OutActorGuid))
					{
						single2.Units.Add(OutActorGuid);
					}
				}
				if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.UnitSpawner.ConfigGuid), out OutActorGuid))
				{
					single2.Spawner = OutActorGuid;
				}
				if (calliopeAsset.GetParameterBuffIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.Buff.ConfigGuid), out OutBuffID))
				{
					single2.BuffId = OutBuffID;
				}
				if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.Unit.ConfigGuid), out OutActorGuid))
				{
					single2.UnitGuid = OutActorGuid;
				}
				if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.Overlap.ConfigGuid), out OutActorGuid))
				{
					single2.OverlapGuid = OutActorGuid;
				}
				if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.Interactor.ConfigGuid), out OutActorGuid))
				{
					single2.InteractorGuid = OutActorGuid;
				}
				if (calliopeAsset.GetParameterSequenceIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.Sequence.ConfigGuid), out OutBuffID))
				{
					single2.SequenceId = OutBuffID;
				}
				if (calliopeAsset.GetParameterTaskStateIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.TaskStage.ConfigGuid), out OutBuffID))
				{
					single2.TaskStageId = OutBuffID;
				}
				calliopeCustom_CompositeTransitionCondition_State.Single.CircusNickName = single.CircusMemberNickName.TagName.ToString();
				calliopeCustom_CompositeTransitionCondition_State.Single.TaskStageStatus = (int)single.TaskStageStatus;
				calliopeCustom_CompositeTransitionCondition_State.Single.GameplayCounterType = (int)single.CounterType;
				calliopeCustom_CompositeTransitionCondition_State.Single.GameplayCounterValue = (int)single.CounterValue;
				if (calliopeAsset.GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(single.Unit.ConfigGuid), out OutActorGuid))
				{
					single2.GameplayCounterGuid = OutActorGuid;
				}
			}
			string pinName2 = $"跳转条件{num++}";
			if (!string.IsNullOrEmpty(otherCondition.Comment))
			{
				pinName2 = otherCondition.Comment;
			}
			calliopeCustom_CompositeTransitionCondition_State.PinName = pinName2;
			calliopeCustom_CompositeTransitionCondition_State.BossPhaseInfo = BED_CalliopeFuncLib.SerializeToCustomData(otherCondition.BossPhaseInfo);
			stateCustom_Single.OtherConditions.Add(calliopeCustom_CompositeTransitionCondition_State);
		}
		if (SubStateMachine != null)
		{
			UCalliopeAsset subStateMachine = SubStateMachine;
			if ((object)subStateMachine != null)
			{
				foreach (FName customOutput in subStateMachine.GetCustomOutputs())
				{
					stateCustom_Single.CustomExitEvents.Add(customOutput.PlainName);
				}
				foreach (FName customInput in subStateMachine.GetCustomInputs())
				{
					stateCustom_Single.CustomEnterEvents.Add(customInput.PlainName);
				}
			}
		}
		CalliopeCustom_StateNodeChildActorControl calliopeCustom_StateNodeChildActorControl = new CalliopeCustom_StateNodeChildActorControl();
		foreach (FStateNodeChildActorControlJJSObstacle item in ChildActorCollection.JJSObstacleCollection)
		{
			CalliopeCustom_StateNodeChildActorControlJJSObstacle calliopeCustom_StateNodeChildActorControlJJSObstacle = new CalliopeCustom_StateNodeChildActorControlJJSObstacle();
			calliopeCustom_StateNodeChildActorControlJJSObstacle.Nickname = item.Nickname.TagName.ToString();
			calliopeCustom_StateNodeChildActorControlJJSObstacle.State = (int)item.State;
			calliopeCustom_StateNodeChildActorControl.JjsobstacleCollection.Add(calliopeCustom_StateNodeChildActorControlJJSObstacle);
		}
		stateCustom_Single.ChildActorCollection = calliopeCustom_StateNodeChildActorControl;
		return stateCustom_Single.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.Single;
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("State: " + StateName.TagName.PlainName + "\n");
		if (SubStateMachine != null)
		{
			string pathName = SubStateMachine.GetPathName();
			stringBuilder.Append("SubStateMach:" + Path.Combine(Path.GetDirectoryName(pathName) ?? string.Empty, Path.GetFileNameWithoutExtension(pathName)));
		}
		return stringBuilder.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		foreach (FGameplayTag gameplayTag in Events.GameplayTags)
		{
			list.Add(gameplayTag.TagName);
		}
		int num = 1;
		foreach (FDetectUnitCondition detectUnitCondition in DetectUnitConditions)
		{
			string name = $"跳转条件{num++}";
			if (!string.IsNullOrEmpty(detectUnitCondition.Comment))
			{
				name = detectUnitCondition.Comment;
			}
			list.Add(new FName(name));
		}
		foreach (FCompositeTransitionCondition_State otherCondition in OtherConditions)
		{
			string name2 = $"跳转条件{num++}";
			if (!string.IsNullOrEmpty(otherCondition.Comment))
			{
				name2 = otherCondition.Comment;
			}
			list.Add(new FName(name2));
		}
		if (SubStateMachine != null)
		{
			UCalliopeAsset subStateMachine = SubStateMachine;
			if ((object)subStateMachine != null)
			{
				foreach (FName customOutput in subStateMachine.GetCustomOutputs())
				{
					list.Add(customOutput);
				}
			}
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:GetContextInputsInCS")]
	protected override List<FName> GetContextInputsInCS_Implementation()
	{
		List<FName> list = new List<FName>();
		if (SubStateMachine != null)
		{
			UCalliopeAsset subStateMachine = SubStateMachine;
			if ((object)subStateMachine != null)
			{
				foreach (FName customInput in subStateMachine.GetCustomInputs())
				{
					list.Add(customInput);
				}
			}
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:GetAssetToEditInCS")]
	protected override UObject GetAssetToEditInCS_Implementation()
	{
		if (GetCalliopeAsset() is BED_StateAsset bED_StateAsset && bED_StateAsset.PhaseBehaviorAsset != null)
		{
			b1.BED_BehaviorNode_EnterState enterStateNode = GetEnterStateNode();
			if (enterStateNode != null)
			{
				enterStateNode.BossPhaseRequireActive = true;
				FTimerManager.EngineEditor.SetTimer(this, JumpToEnterStateNode, 0.1f);
			}
			return bED_StateAsset.PhaseBehaviorAsset;
		}
		if (SubGraphAssetInstance != null)
		{
			return SubGraphAssetInstance;
		}
		return SubStateMachine;
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:IsSubGraphNode")]
	protected override bool IsSubGraphNode_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:SetSubGraphAssetInPIE")]
	protected override void SetSubGraphAssetInPIE_Implementation(UCalliopeAsset InSubGraphAsset)
	{
		SubGraphAssetInstance = InSubGraphAsset as BED_StateAsset;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:JumpToEnterStateNode")]
	private void JumpToEnterStateNode()
	{
		b1.BED_BehaviorNode_EnterState enterStateNode = GetEnterStateNode();
		if (enterStateNode != null)
		{
			enterStateNode.JumpToMe();
		}
	}

	private b1.BED_BehaviorNode_EnterState GetEnterStateNode()
	{
		if (GetCalliopeAsset() is BED_StateAsset bED_StateAsset && bED_StateAsset.PhaseBehaviorAsset != null)
		{
			return bED_StateAsset.PhaseBehaviorAsset.GetNodes().Values.OfType<b1.BED_BehaviorNode_EnterState>().FirstOrDefault((b1.BED_BehaviorNode_EnterState node) => node.StateTag.TagName == StateName.TagName);
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:OnSelectNodeInCS")]
	protected override void OnSelectNodeInCS_Implementation()
	{
		if (!(GetCalliopeAsset() is BED_StateAsset bED_StateAsset) || bED_StateAsset.PhaseBehaviorAsset == null)
		{
			return;
		}
		foreach (UCalliopeNode value in bED_StateAsset.PhaseBehaviorAsset.Nodes.Values)
		{
			value.BossPhaseRequireActive = false;
		}
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:PrePropertyChanged")]
	protected override void PrePropertyChanged_Implementation(string PropertyName)
	{
		if (PropertyName.Equals("SubStateMachine") && SubStateMachine != null)
		{
			UnBindAssetOnSubGraphReconstructionRequested(SubStateMachine);
		}
	}

	[USharpPath("/Script/b1-Managed.BED_StateNode_Single:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("SubStateMachine"))
		{
			ExecuteOnReconstructionRequested();
			SubscribeToAssetChanges();
		}
	}

	private void SubscribeToAssetChanges()
	{
		if (SubStateMachine != null)
		{
			BindAssetOnSubGraphReconstructionRequested(SubStateMachine);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:JumpToEnterStateNode")]
	private static void JumpToEnterStateNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		bED_StateNode_Single.JumpToEnterStateNode();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:IsSubGraphNode")]
	private static void IsSubGraphNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		bool value = bED_StateNode_Single.IsSubGraphNode_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSubGraphNode_ReturnValue_Offset), 0, IsSubGraphNode_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:OnSelectNodeInCS")]
	private static void OnSelectNodeInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		bED_StateNode_Single.OnSelectNodeInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:PrePropertyChanged")]
	private static void PrePropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PrePropertyChanged_PropertyName_Offset));
		bED_StateNode_Single.PrePropertyChanged_Implementation(propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:GetAssetToEditInCS")]
	private static void GetAssetToEditInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		UObject assetToEditInCS_Implementation = bED_StateNode_Single.GetAssetToEditInCS_Implementation();
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetAssetToEditInCS_ReturnValue_Offset), assetToEditInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_StateNode_Single.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:GetContextInputsInCS")]
	private static void GetContextInputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextInputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextInputsInCS_Implementation = bED_StateNode_Single.GetContextInputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextInputsInCS_ReturnValue_Offset), contextInputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:SetSubGraphAssetInPIE")]
	private static void SetSubGraphAssetInPIE__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		UCalliopeAsset subGraphAssetInPIE_Implementation = UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(buffer, SetSubGraphAssetInPIE_InSubGraphAsset_Offset));
		bED_StateNode_Single.SetSubGraphAssetInPIE_Implementation(subGraphAssetInPIE_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_StateNode_Single.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_StateNode_Single:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_StateNode_Single bED_StateNode_Single = GCHelper.Find<BED_StateNode_Single>(obj);
		string nodeDescriptionInCS_Implementation = bED_StateNode_Single.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_Single");
		StateName_Offset = NativeReflection.GetPropertyOffset(intPtr, "StateName");
		StateName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StateName", Classes.FStructProperty);
		SubStateMachine_Offset = NativeReflection.GetPropertyOffset(intPtr, "SubStateMachine");
		SubStateMachine_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SubStateMachine", Classes.FObjectProperty);
		SubGraphAssetInstance_Offset = NativeReflection.GetPropertyOffset(intPtr, "SubGraphAssetInstance");
		SubGraphAssetInstance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SubGraphAssetInstance", Classes.FObjectProperty);
		Events_Offset = NativeReflection.GetPropertyOffset(intPtr, "Events");
		Events_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Events", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref DetectUnitConditions_PropertyAddress, intPtr, "DetectUnitConditions");
		DetectUnitConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetectUnitConditions");
		DetectUnitConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetectUnitConditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OtherConditions_PropertyAddress, intPtr, "OtherConditions");
		OtherConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "OtherConditions");
		OtherConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OtherConditions", Classes.FArrayProperty);
		ChildActorCollection_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChildActorCollection");
		ChildActorCollection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChildActorCollection", Classes.FStructProperty);
		JumpToEnterStateNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "JumpToEnterStateNode");
		JumpToEnterStateNode_ParamsSize = NativeReflection.GetFunctionParamsSize(JumpToEnterStateNode_FunctionAddress);
		JumpToEnterStateNode_IsValid = JumpToEnterStateNode_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:JumpToEnterStateNode", JumpToEnterStateNode_IsValid);
		IsSubGraphNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSubGraphNode");
		IsSubGraphNode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSubGraphNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSubGraphNode_ReturnValue_PropertyAddress, IsSubGraphNode_FunctionAddress, "ReturnValue");
		IsSubGraphNode_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSubGraphNode_FunctionAddress, "ReturnValue");
		IsSubGraphNode_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSubGraphNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSubGraphNode_IsValid = IsSubGraphNode_FunctionAddress != IntPtr.Zero && IsSubGraphNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:IsSubGraphNode", IsSubGraphNode_IsValid);
		OnSelectNodeInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSelectNodeInCS");
		OnSelectNodeInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectNodeInCS_FunctionAddress);
		OnSelectNodeInCS_IsValid = OnSelectNodeInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:OnSelectNodeInCS", OnSelectNodeInCS_IsValid);
		PrePropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrePropertyChanged");
		PrePropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PrePropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PrePropertyChanged_PropertyName_PropertyAddress, PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PrePropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PrePropertyChanged_IsValid = PrePropertyChanged_FunctionAddress != IntPtr.Zero && PrePropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:PrePropertyChanged", PrePropertyChanged_IsValid);
		GetAssetToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAssetToEditInCS");
		GetAssetToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetToEditInCS_FunctionAddress);
		GetAssetToEditInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAssetToEditInCS_FunctionAddress, "ReturnValue");
		GetAssetToEditInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAssetToEditInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetToEditInCS_IsValid = GetAssetToEditInCS_FunctionAddress != IntPtr.Zero && GetAssetToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:GetAssetToEditInCS", GetAssetToEditInCS_IsValid);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetContextInputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextInputsInCS");
		GetContextInputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextInputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextInputsInCS_ReturnValue_PropertyAddress, GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextInputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextInputsInCS_IsValid = GetContextInputsInCS_FunctionAddress != IntPtr.Zero && GetContextInputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:GetContextInputsInCS", GetContextInputsInCS_IsValid);
		SetSubGraphAssetInPIE_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubGraphAssetInPIE");
		SetSubGraphAssetInPIE_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubGraphAssetInPIE_FunctionAddress);
		SetSubGraphAssetInPIE_InSubGraphAsset_Offset = NativeReflection.GetPropertyOffset(SetSubGraphAssetInPIE_FunctionAddress, "InSubGraphAsset");
		SetSubGraphAssetInPIE_InSubGraphAsset_IsValid = NativeReflection.ValidatePropertyClass(SetSubGraphAssetInPIE_FunctionAddress, "InSubGraphAsset", Classes.FObjectProperty);
		SetSubGraphAssetInPIE_IsValid = SetSubGraphAssetInPIE_FunctionAddress != IntPtr.Zero && SetSubGraphAssetInPIE_InSubGraphAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:SetSubGraphAssetInPIE", SetSubGraphAssetInPIE_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_StateNode_Single:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_StateNode_Single()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_Single)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_Single));
	}
}
