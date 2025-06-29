using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("释放技能")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ComboNode_Skill")]
public class BED_ComboNode_Skill : BED_ComboNode_State
{
	private static bool SkillId_IsValid;

	private static int SkillId_Offset;

	private static bool SkillMappingRuleIDList_IsValid;

	private static int SkillMappingRuleIDList_Offset;

	private static FFieldAddress SkillMappingRuleIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillMappingRuleIDList_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("默认技能ID")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ComboNode_Skill:SkillId")]
	public int SkillId
	{
		get
		{
			CheckDestroyed();
			if (!SkillId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ComboNode_Skill:SkillId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ComboNode_Skill:SkillId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("技能映射规则ID列表")]
	[USharpPath("/Script/b1-Managed.BED_ComboNode_Skill:SkillMappingRuleIDList")]
	public TArrayReadWrite<int> SkillMappingRuleIDList
	{
		get
		{
			CheckDestroyed();
			if (!SkillMappingRuleIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ComboNode_Skill:SkillMappingRuleIDList");
				return null;
			}
			if (SkillMappingRuleIDList_Marshaler == null)
			{
				SkillMappingRuleIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillMappingRuleIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillMappingRuleIDList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillMappingRuleIDList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.InputPins.Add(new FCalliopePin
		{
			PinName = B1GlobalFNames.In
		});
	}

	[USharpPath("/Script/b1-Managed.BED_ComboNode_Skill:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string text = $"SkillId: {SkillId}";
		if (SkillMappingRuleIDList.Count > 0)
		{
			text += "\n映射规则ID : ";
			foreach (int skillMappingRuleID in SkillMappingRuleIDList)
			{
				text += $"\n  RuleID: {skillMappingRuleID}";
			}
		}
		return text;
	}

	public override byte[] GetCustomData()
	{
		ComboCustom_Skill comboCustom_Skill = new ComboCustom_Skill
		{
			SkillId = SkillId
		};
		foreach (int skillMappingRuleID in SkillMappingRuleIDList)
		{
			comboCustom_Skill.SkillMappingRuleIdList.Add(skillMappingRuleID);
		}
		return comboCustom_Skill.ToByteArray();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ComboNode.Skill;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ComboNode_Skill:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ComboNode_Skill bED_ComboNode_Skill = GCHelper.Find<BED_ComboNode_Skill>(obj);
		string nodeDescriptionInCS_Implementation = bED_ComboNode_Skill.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ComboNode_Skill");
		SkillId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillId");
		SkillId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SkillMappingRuleIDList_PropertyAddress, intPtr, "SkillMappingRuleIDList");
		SkillMappingRuleIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillMappingRuleIDList");
		SkillMappingRuleIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillMappingRuleIDList", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ComboNode_Skill:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ComboNode_Skill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ComboNode_Skill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ComboNode_Skill));
	}
}
