using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Player Condition")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCondition")]
internal class BED_QuestNode_PlayerCondition : BED_QuestNode
{
	private static bool ConditionConfigs_IsValid;

	private static int ConditionConfigs_Offset;

	private static FFieldAddress ConditionConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<FAutoTestPlayerCastSkillConditionGroup> ConditionConfigs_Marshaler;

	private static bool PostPropertyChanged_IsValid;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static int PostPropertyChanged_MemberName_Offset;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCondition:ConditionConfigs")]
	public TArrayReadWrite<FAutoTestPlayerCastSkillConditionGroup> ConditionConfigs
	{
		get
		{
			CheckDestroyed();
			if (!ConditionConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCondition:ConditionConfigs");
				return null;
			}
			if (ConditionConfigs_Marshaler == null)
			{
				ConditionConfigs_Marshaler = new TArrayReadWriteMarshaler<FAutoTestPlayerCastSkillConditionGroup>(1, ConditionConfigs_PropertyAddress, CachedMarshalingDelegates<FAutoTestPlayerCastSkillConditionGroup, FAutoTestPlayerCastSkillConditionGroup>.FromNative, CachedMarshalingDelegates<FAutoTestPlayerCastSkillConditionGroup, FAutoTestPlayerCastSkillConditionGroup>.ToNative);
			}
			return ConditionConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, ConditionConfigs_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Auto Test");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.OutputPins.Clear();
	}

	private void RefreshOutputPins()
	{
		base.OutputPins.Clear();
		foreach (FAutoTestPlayerCastSkillConditionGroup conditionConfig in ConditionConfigs)
		{
			if (!(conditionConfig.Describe != ""))
			{
				continue;
			}
			bool flag = true;
			foreach (FCalliopePin outputPin in base.OutputPins)
			{
				if (outputPin.PinName.ToString() == conditionConfig.Describe)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.OutputPins.Add(new FCalliopePin
				{
					PinName = new FName(conditionConfig.Describe)
				});
			}
		}
		ExecuteOnReconstructionRequested();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCondition:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (MemberName == "ConditionConfigs")
		{
			RefreshOutputPins();
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.PlayerCondition;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_PlayerCastSkillConditionGroupList questCustom_PlayerCastSkillConditionGroupList = new QuestCustom_PlayerCastSkillConditionGroupList();
		foreach (FAutoTestPlayerCastSkillConditionGroup conditionConfig in ConditionConfigs)
		{
			if (!(conditionConfig.Describe == ""))
			{
				questCustom_PlayerCastSkillConditionGroupList.ConditionGroups.Add(conditionConfig.ToCustomData());
			}
		}
		return questCustom_PlayerCastSkillConditionGroupList.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCondition:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "Player Condition";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayerCondition:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_PlayerCondition bED_QuestNode_PlayerCondition = GCHelper.Find<b1.BED_QuestNode_PlayerCondition>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_QuestNode_PlayerCondition.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayerCondition:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_PlayerCondition bED_QuestNode_PlayerCondition = GCHelper.Find<b1.BED_QuestNode_PlayerCondition>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PlayerCondition.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PlayerCondition");
		NativeReflection.GetPropertyRef(ref ConditionConfigs_PropertyAddress, intPtr, "ConditionConfigs");
		ConditionConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionConfigs");
		ConditionConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionConfigs", Classes.FArrayProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayerCondition:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayerCondition:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PlayerCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_PlayerCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_PlayerCondition));
	}
}
