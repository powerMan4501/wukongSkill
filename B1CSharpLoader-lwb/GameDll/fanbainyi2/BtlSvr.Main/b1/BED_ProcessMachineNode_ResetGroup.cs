using System;
using System.Collections.Generic;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("重置组（Reset Group）")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup")]
public class BED_ProcessMachineNode_ResetGroup : BED_ProcessMachineNode_TemplateBase
{
	private static bool GroupName_IsValid;

	private static int GroupName_Offset;

	private static bool TransitionConditions_IsValid;

	private static int TransitionConditions_Offset;

	private static FFieldAddress TransitionConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FCompositeTransitionCondition_Group> TransitionConditions_Marshaler;

	private static bool OnRefreshAssetInCS_IsValid;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

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

	[EditAnywhere]
	[Category("Reset Group")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GroupName")]
	public FName GroupName
	{
		get
		{
			CheckDestroyed();
			if (!GroupName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GroupName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GroupName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GroupName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GroupName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Reset Group")]
	[DisplayName("结束重置组条件")]
	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:TransitionConditions")]
	public TArrayReadWrite<FCompositeTransitionCondition_Group> TransitionConditions
	{
		get
		{
			CheckDestroyed();
			if (!TransitionConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:TransitionConditions");
				return null;
			}
			if (TransitionConditions_Marshaler == null)
			{
				TransitionConditions_Marshaler = new TArrayReadWriteMarshaler<FCompositeTransitionCondition_Group>(1, TransitionConditions_PropertyAddress, CachedMarshalingDelegates<FCompositeTransitionCondition_Group, FCompositeTransitionCondition_Group>.FromNative, CachedMarshalingDelegates<FCompositeTransitionCondition_Group, FCompositeTransitionCondition_Group>.ToNative);
			}
			return TransitionConditions_Marshaler.FromNative(IntPtr.Add(base.Address, TransitionConditions_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "高级";
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Group;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return GroupName.ToString();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> contextOutputsInCS_Implementation = base.GetContextOutputsInCS_Implementation();
		if (TransitionConditions.Count > 0)
		{
			int num = 1;
			foreach (FCompositeTransitionCondition_Group transitionCondition in TransitionConditions)
			{
				string name = $"跳转条件{num++}";
				if (!string.IsNullOrEmpty(transitionCondition.Comment))
				{
					name = transitionCondition.Comment;
				}
				contextOutputsInCS_Implementation.Add(new FName(name));
			}
		}
		else
		{
			contextOutputsInCS_Implementation.Add(BGW_FlowUtils.PinName.Out);
		}
		return contextOutputsInCS_Implementation;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:OnRefreshAssetInCS")]
	protected override void OnRefreshAssetInCS_Implementation()
	{
		BED_ProcessAsset bED_ProcessAsset = GetCalliopeAsset() as BED_ProcessAsset;
		if (bED_ProcessAsset != null)
		{
			bED_ProcessAsset.RegisterGroup(GroupName.PlainName, this);
		}
		base.OnRefreshAssetInCS_Implementation();
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		bool flag = base.CorrectnessCheck(out OutErrorMessage);
		StringBuilder stringBuilder = new StringBuilder(OutErrorMessage);
		bool flag2 = true;
		foreach (FCompositeTransitionCondition_Group transitionCondition in TransitionConditions)
		{
			if (transitionCondition.bUseCompositeCondition)
			{
				foreach (FTransitionCondition_Group condition in transitionCondition.Conditions)
				{
					if (condition.ConditionType == ETransitionConditionType_Group.None)
					{
						flag2 = false;
					}
				}
			}
			else if (transitionCondition.Single.ConditionType == ETransitionConditionType_Group.None)
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

	public override byte[] GetCustomData()
	{
		ProcessCustom_Group processCustom_Group = new ProcessCustom_Group();
		processCustom_Group.GroupName = GroupName.PlainName;
		int num = 1;
		foreach (FCompositeTransitionCondition_Group transitionCondition in TransitionConditions)
		{
			CalliopeCustom_CompositeTransitionCondition_Group calliopeCustom_CompositeTransitionCondition_Group = new CalliopeCustom_CompositeTransitionCondition_Group();
			calliopeCustom_CompositeTransitionCondition_Group.IsUseCompositeCondition = transitionCondition.bUseCompositeCondition;
			if (transitionCondition.bUseCompositeCondition)
			{
				calliopeCustom_CompositeTransitionCondition_Group.ConditionalRelation = (int)transitionCondition.ConditionalRelation;
				foreach (FTransitionCondition_Group condition in transitionCondition.Conditions)
				{
					CalliopeCustom_TransitionCondition_Group calliopeCustom_TransitionCondition_Group = new CalliopeCustom_TransitionCondition_Group();
					calliopeCustom_TransitionCondition_Group.ConditionType = (int)condition.ConditionType;
					foreach (Guid configGuide in condition.UnitList.ConfigGuides)
					{
						calliopeCustom_TransitionCondition_Group.Units.Add(configGuide.ToString());
					}
					calliopeCustom_TransitionCondition_Group.Spawner = condition.UnitSpawner.ConfigGuid.ToString();
					calliopeCustom_TransitionCondition_Group.BuffId = condition.Buff.ConfigGuid.ToString();
					calliopeCustom_TransitionCondition_Group.UnitGuid = condition.Unit.ConfigGuid.ToString();
					foreach (Guid configGuide2 in condition.UnitKillOrder.ConfigGuides)
					{
						calliopeCustom_TransitionCondition_Group.KillOrder.Add(configGuide2.ToString());
					}
					calliopeCustom_TransitionCondition_Group.OverlapGuid = condition.Overlap.ConfigGuid.ToString();
					calliopeCustom_TransitionCondition_Group.InteractorGuid = condition.Interactor.ConfigGuid.ToString();
					calliopeCustom_TransitionCondition_Group.GameStateCondition = (int)condition.GameStateCondition;
					calliopeCustom_TransitionCondition_Group.SequenceId = condition.Sequence.ConfigGuid.ToString();
					calliopeCustom_TransitionCondition_Group.TaskStageId = condition.TaskStage.ConfigGuid.ToString();
					calliopeCustom_TransitionCondition_Group.TaskStageStatus = (int)condition.TaskStageStatus;
					calliopeCustom_TransitionCondition_Group.IsReverseCondition = condition.bReverseCondition;
					calliopeCustom_CompositeTransitionCondition_Group.Conditions.Add(calliopeCustom_TransitionCondition_Group);
				}
			}
			else
			{
				FTransitionCondition_Group single = transitionCondition.Single;
				calliopeCustom_CompositeTransitionCondition_Group.Single = new CalliopeCustom_TransitionCondition_Group();
				calliopeCustom_CompositeTransitionCondition_Group.Single.ConditionType = (int)single.ConditionType;
				foreach (Guid configGuide3 in single.UnitList.ConfigGuides)
				{
					calliopeCustom_CompositeTransitionCondition_Group.Single.Units.Add(configGuide3.ToString());
				}
				calliopeCustom_CompositeTransitionCondition_Group.Single.Spawner = single.UnitSpawner.ConfigGuid.ToString();
				calliopeCustom_CompositeTransitionCondition_Group.Single.BuffId = single.Buff.ConfigGuid.ToString();
				calliopeCustom_CompositeTransitionCondition_Group.Single.UnitGuid = single.Unit.ConfigGuid.ToString();
				foreach (Guid configGuide4 in single.UnitKillOrder.ConfigGuides)
				{
					calliopeCustom_CompositeTransitionCondition_Group.Single.KillOrder.Add(configGuide4.ToString());
				}
				calliopeCustom_CompositeTransitionCondition_Group.Single.OverlapGuid = single.Overlap.ConfigGuid.ToString();
				calliopeCustom_CompositeTransitionCondition_Group.Single.InteractorGuid = single.Interactor.ConfigGuid.ToString();
				calliopeCustom_CompositeTransitionCondition_Group.Single.GameStateCondition = (int)single.GameStateCondition;
				calliopeCustom_CompositeTransitionCondition_Group.Single.SequenceId = single.Sequence.ConfigGuid.ToString();
				calliopeCustom_CompositeTransitionCondition_Group.Single.TaskStageId = single.TaskStage.ConfigGuid.ToString();
				calliopeCustom_CompositeTransitionCondition_Group.Single.TaskStageStatus = (int)single.TaskStageStatus;
				calliopeCustom_CompositeTransitionCondition_Group.Single.IsReverseCondition = single.bReverseCondition;
			}
			calliopeCustom_CompositeTransitionCondition_Group.IsReverseCondition = transitionCondition.bReverseCondition;
			string pinName = $"跳转条件{num++}";
			if (!string.IsNullOrEmpty(transitionCondition.Comment))
			{
				pinName = transitionCondition.Comment;
			}
			calliopeCustom_CompositeTransitionCondition_Group.PinName = pinName;
			processCustom_Group.TransitionConditions.Add(calliopeCustom_CompositeTransitionCondition_Group);
		}
		processCustom_Group.ManagedObjs.AddRange(MakeManagedSceneObjCustomData());
		processCustom_Group.ManagedNpcUnits.AddRange(MakeManagedNPCUnitCustomData());
		processCustom_Group.ManagedInteractors.AddRange(MakeManagedInteractorCustomData());
		processCustom_Group.ManagedStreamingLevelStateConfigs.AddRange(MakeManagedStreamingLevelStateConfigCustomData());
		processCustom_Group.ManagedGroupUnits.AddRange(MakeManagedGroupUnitCustomData());
		return processCustom_Group.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:OnRefreshAssetInCS")]
	private static void OnRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_ResetGroup bED_ProcessMachineNode_ResetGroup = GCHelper.Find<BED_ProcessMachineNode_ResetGroup>(obj);
		bED_ProcessMachineNode_ResetGroup.OnRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_ResetGroup bED_ProcessMachineNode_ResetGroup = GCHelper.Find<BED_ProcessMachineNode_ResetGroup>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_ProcessMachineNode_ResetGroup.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_ResetGroup bED_ProcessMachineNode_ResetGroup = GCHelper.Find<BED_ProcessMachineNode_ResetGroup>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessMachineNode_ResetGroup.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup");
		GroupName_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupName");
		GroupName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref TransitionConditions_PropertyAddress, intPtr, "TransitionConditions");
		TransitionConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransitionConditions");
		TransitionConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransitionConditions", Classes.FArrayProperty);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_ResetGroup:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessMachineNode_ResetGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_ResetGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_ResetGroup));
	}
}
