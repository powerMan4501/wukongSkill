using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Player Cast Magic")]
[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic")]
internal class BED_QuestNode_PlayerCastMagic : BED_QuestNode
{
	private static bool CastType_IsValid;

	private static int CastType_Offset;

	private static FFieldAddress CastType_PropertyAddress;

	private static bool Direction_IsValid;

	private static int Direction_Offset;

	private static FFieldAddress Direction_PropertyAddress;

	private static bool SkillCastConditions_IsValid;

	private static int SkillCastConditions_Offset;

	private static FFieldAddress SkillCastConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FAutoTestPlayerCastSkillConditionGroup> SkillCastConditions_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:CastType")]
	public EBGUAutoTestPlayerMagicType CastType
	{
		get
		{
			CheckDestroyed();
			if (!CastType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:CastType");
				return EBGUAutoTestPlayerMagicType.None;
			}
			return EnumMarshaler<EBGUAutoTestPlayerMagicType>.FromNative(IntPtr.Add(base.Address, CastType_Offset), 0, CastType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:CastType");
			}
			else
			{
				EnumMarshaler<EBGUAutoTestPlayerMagicType>.ToNative(IntPtr.Add(base.Address, CastType_Offset), 0, CastType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:Direction")]
	public ESkillDirection Direction
	{
		get
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:Direction");
				return ESkillDirection.None;
			}
			return EnumMarshaler<ESkillDirection>.FromNative(IntPtr.Add(base.Address, Direction_Offset), 0, Direction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Direction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:Direction");
			}
			else
			{
				EnumMarshaler<ESkillDirection>.ToNative(IntPtr.Add(base.Address, Direction_Offset), 0, Direction_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("各组条件满足其一即通过")]
	[EditAnywhere]
	[DisplayName("或条件组")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:SkillCastConditions")]
	public TArrayReadWrite<FAutoTestPlayerCastSkillConditionGroup> SkillCastConditions
	{
		get
		{
			CheckDestroyed();
			if (!SkillCastConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:SkillCastConditions");
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
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Failed
		});
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.PlayerCastMagic;
	}

	public override byte[] GetCustomData()
	{
		QuestCustom_PlayerCastMagic questCustom_PlayerCastMagic = new QuestCustom_PlayerCastMagic();
		questCustom_PlayerCastMagic.CastType = (int)CastType;
		questCustom_PlayerCastMagic.Direction = (int)Direction;
		questCustom_PlayerCastMagic.SkillCastCondition = new QuestCustom_PlayerCastSkillConditionGroupList();
		foreach (FAutoTestPlayerCastSkillConditionGroup skillCastCondition in SkillCastConditions)
		{
			questCustom_PlayerCastMagic.SkillCastCondition.ConditionGroups.Add(skillCastCondition.ToCustomData());
		}
		return questCustom_PlayerCastMagic.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string text = "";
		text += $"CastType: {CastType}";
		foreach (FAutoTestPlayerCastSkillConditionGroup skillCastCondition in SkillCastConditions)
		{
			if (skillCastCondition.Describe != "")
			{
				text = text + "\r\n" + skillCastCondition.Describe;
			}
		}
		return text;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_QuestNode_PlayerCastMagic bED_QuestNode_PlayerCastMagic = GCHelper.Find<b1.BED_QuestNode_PlayerCastMagic>(obj);
		string nodeDescriptionInCS_Implementation = bED_QuestNode_PlayerCastMagic.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic");
		NativeReflection.GetPropertyRef(ref CastType_PropertyAddress, intPtr, "CastType");
		CastType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CastType");
		CastType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CastType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref Direction_PropertyAddress, intPtr, "Direction");
		Direction_Offset = NativeReflection.GetPropertyOffset(intPtr, "Direction");
		Direction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Direction", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SkillCastConditions_PropertyAddress, intPtr, "SkillCastConditions");
		SkillCastConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillCastConditions");
		SkillCastConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillCastConditions", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_PlayerCastMagic:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_QuestNode_PlayerCastMagic()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_QuestNode_PlayerCastMagic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_QuestNode_PlayerCastMagic));
	}
}
