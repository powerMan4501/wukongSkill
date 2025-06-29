using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Player Cast Skill")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill")]
internal class BED_QuestNode_PlayerCastSkill : BED_QuestNode
{
	private static bool ComboKey_IsValid;

	private static int ComboKey_Offset;

	private static FFieldAddress ComboKey_PropertyAddress;

	private static bool Direction_IsValid;

	private static int Direction_Offset;

	private static FFieldAddress Direction_PropertyAddress;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool SkillCastConditions_IsValid;

	private static int SkillCastConditions_Offset;

	private static FFieldAddress SkillCastConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FAutoTestPlayerCastSkillConditionGroup> SkillCastConditions_Marshaler;

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

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:ComboKey")]
	public EBGUAutoTestPlayerComboKey ComboKey
	{
		get
		{
			CheckDestroyed();
			if (!ComboKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:ComboKey");
				return EBGUAutoTestPlayerComboKey.None;
			}
			return EnumMarshaler<EBGUAutoTestPlayerComboKey>.FromNative(IntPtr.Add(base.Address, ComboKey_Offset), 0, ComboKey_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComboKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:ComboKey");
			}
			else
			{
				EnumMarshaler<EBGUAutoTestPlayerComboKey>.ToNative(IntPtr.Add(base.Address, ComboKey_Offset), 0, ComboKey_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "ComboKey == EBGUAutoTestPlayerComboKey::Dodge")]
	[Category("Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:Direction")]
	public ESkillDirection Direction
	{
		get
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:Direction");
				return ESkillDirection.None;
			}
			return EnumMarshaler<ESkillDirection>.FromNative(IntPtr.Add(base.Address, Direction_Offset), 0, Direction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:Direction");
			}
			else
			{
				EnumMarshaler<ESkillDirection>.ToNative(IntPtr.Add(base.Address, Direction_Offset), 0, Direction_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "ComboKey == EBGUAutoTestPlayerComboKey::None")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:SkillID")]
	public int SkillID
	{
		get
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:SkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:SkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[DisplayName("或条件组")]
	[Tooltip("各组条件满足其一即通过")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:SkillCastConditions")]
	public TArrayReadWrite<FAutoTestPlayerCastSkillConditionGroup> SkillCastConditions
	{
		get
		{
			CheckDestroyed();
			if (!SkillCastConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:SkillCastConditions");
				return null;
			}
			if (SkillCastConditions_Marshaler == null)
			{
				SkillCastConditions_Marshaler = new TArrayReadWriteMarshaler<FAutoTestPlayerCastSkillConditionGroup>(1, SkillCastConditions_PropertyAddress, CachedMarshalingDelegates<FAutoTestPlayerCastSkillConditionGroup, FAutoTestPlayerCastSkillConditionGroup>.FromNative, CachedMarshalingDelegates<FAutoTestPlayerCastSkillConditionGroup, FAutoTestPlayerCastSkillConditionGroup>.ToNative);
			}
			return SkillCastConditions_Marshaler.FromNative(IntPtr.Add(base.Address, SkillCastConditions_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Auto Test");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Out
		});
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (MemberName == "SkillCastConditions")
		{
			RefreshOutputPins();
		}
	}

	private void RefreshOutputPins()
	{
		if (ComboKey == EBGUAutoTestPlayerComboKey.None && SkillCastConditions.Count > 0)
		{
			base.OutputPins.Clear();
			base.OutputPins.Add(new FCalliopePin
			{
				PinName = BGW_FlowUtils.PinName.Success
			});
			base.OutputPins.Add(new FCalliopePin
			{
				PinName = BGW_FlowUtils.PinName.Failed
			});
		}
		else
		{
			base.OutputPins.Clear();
			base.OutputPins.Add(new FCalliopePin
			{
				PinName = BGW_FlowUtils.PinName.Out
			});
		}
		ExecuteOnReconstructionRequested();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.PlayerCastSkill;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_PlayerCastSkill questCustom_PlayerCastSkill = new QuestCustom_PlayerCastSkill();
		questCustom_PlayerCastSkill.ComboKey = (int)ComboKey;
		questCustom_PlayerCastSkill.Direction = (int)Direction;
		questCustom_PlayerCastSkill.SkillId = SkillID;
		questCustom_PlayerCastSkill.SkillCastCondition = new QuestCustom_PlayerCastSkillConditionGroupList();
		foreach (FAutoTestPlayerCastSkillConditionGroup skillCastCondition in SkillCastConditions)
		{
			questCustom_PlayerCastSkill.SkillCastCondition.ConditionGroups.Add(skillCastCondition.ToCustomData());
		}
		return questCustom_PlayerCastSkill.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string text = "";
		text = ((ComboKey != EBGUAutoTestPlayerComboKey.None) ? (text + $"ComboKey: {ComboKey}") : (text + $"SkillID: {SkillID}"));
		foreach (FAutoTestPlayerCastSkillConditionGroup skillCastCondition in SkillCastConditions)
		{
			if (skillCastCondition.Describe != "")
			{
				text = text + "\r\n" + skillCastCondition.Describe;
			}
		}
		return text;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_PlayerCastSkill bED_QuestNode_PlayerCastSkill = GCHelper.Find<b1.BED_QuestNode_PlayerCastSkill>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_QuestNode_PlayerCastSkill.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_PlayerCastSkill bED_QuestNode_PlayerCastSkill = GCHelper.Find<b1.BED_QuestNode_PlayerCastSkill>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PlayerCastSkill.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill");
		NativeReflection.GetPropertyRef(ref ComboKey_PropertyAddress, intPtr, "ComboKey");
		ComboKey_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComboKey");
		ComboKey_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComboKey", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Direction_PropertyAddress, intPtr, "Direction");
		Direction_Offset = NativeReflection.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Direction", Classes.FEnumProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SkillCastConditions_PropertyAddress, intPtr, "SkillCastConditions");
		SkillCastConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillCastConditions");
		SkillCastConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillCastConditions", Classes.FArrayProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayerCastSkill:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PlayerCastSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_PlayerCastSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_PlayerCastSkill));
	}
}
