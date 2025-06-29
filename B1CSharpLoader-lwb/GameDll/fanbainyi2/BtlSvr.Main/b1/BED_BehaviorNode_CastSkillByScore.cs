using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("施放最优技能")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore")]
internal class BED_BehaviorNode_CastSkillByScore : b1.BED_BehaviorNode_Action
{
	private static bool SkillInfoList_IsValid;

	private static int SkillInfoList_Offset;

	private static FFieldAddress SkillInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FCBGCastSkillInfo> SkillInfoList_Marshaler;

	private static bool IsGetTopRandomSkill_IsValid;

	private static int IsGetTopRandomSkill_Offset;

	private static FFieldAddress IsGetTopRandomSkill_PropertyAddress;

	private static bool TopRandomSkillPercent_IsValid;

	private static int TopRandomSkillPercent_Offset;

	private static bool NeedTryCastAllSkillUntilSuccess_IsValid;

	private static int NeedTryCastAllSkillUntilSuccess_Offset;

	private static FFieldAddress NeedTryCastAllSkillUntilSuccess_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Cast Skill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("技能ID信息列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:SkillInfoList")]
	public TArrayReadWrite<FCBGCastSkillInfo> SkillInfoList
	{
		get
		{
			CheckDestroyed();
			if (!SkillInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:SkillInfoList");
				return null;
			}
			if (SkillInfoList_Marshaler == null)
			{
				SkillInfoList_Marshaler = new TArrayReadWriteMarshaler<FCBGCastSkillInfo>(1, SkillInfoList_PropertyAddress, CachedMarshalingDelegates<FCBGCastSkillInfo, FCBGCastSkillInfo>.FromNative, CachedMarshalingDelegates<FCBGCastSkillInfo, FCBGCastSkillInfo>.ToNative);
			}
			return SkillInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, SkillInfoList_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("勾选后，会随机根据算分结果排名后的技能列表，随机获取Top万分比的技能来释放")]
	[Category("Cast Skill")]
	[DisplayName("是否随机获取算分顶部技能")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:IsGetTopRandomSkill")]
	public bool IsGetTopRandomSkill
	{
		get
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:IsGetTopRandomSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:IsGetTopRandomSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("算分顶部随机选取技能万分比")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "IsGetTopRandomSkill")]
	[UMeta(MDProp.ClampMax, "10000")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Cast Skill")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:TopRandomSkillPercent")]
	public int TopRandomSkillPercent
	{
		get
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:TopRandomSkillPercent");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:TopRandomSkillPercent");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("是否逐一尝试释放技能直到成功")]
	[Category("Cast Skill")]
	[Tooltip("勾选后，会按顺序尝试释放每个通过测试的技能，直到成功释放为止【也不保证一定能成功】；不勾选，则只会尝试释放一次技能")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:NeedTryCastAllSkillUntilSuccess")]
	public bool NeedTryCastAllSkillUntilSuccess
	{
		get
		{
			CheckDestroyed();
			if (!NeedTryCastAllSkillUntilSuccess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:NeedTryCastAllSkillUntilSuccess");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedTryCastAllSkillUntilSuccess_Offset), 0, NeedTryCastAllSkillUntilSuccess_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedTryCastAllSkillUntilSuccess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:NeedTryCastAllSkillUntilSuccess");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedTryCastAllSkillUntilSuccess_Offset), 0, NeedTryCastAllSkillUntilSuccess_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		IsGetTopRandomSkill = false;
		TopRandomSkillPercent = 0;
		NeedTryCastAllSkillUntilSuccess = true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.CastSkillByScore;
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_CastSkillByScore behaviorCustom_CastSkillByScore = new BehaviorCustom_CastSkillByScore
		{
			IsGetTopRandomSkill = IsGetTopRandomSkill,
			TopRandomSkillPercent = TopRandomSkillPercent,
			NeedTryCastAllSkillUntilSuccess = NeedTryCastAllSkillUntilSuccess
		};
		foreach (FCBGCastSkillInfo skillInfo in SkillInfoList)
		{
			RepeatedField<OneCBGCastSkillInfo> skillInfoList = behaviorCustom_CastSkillByScore.SkillInfoList;
			OneCBGCastSkillInfo obj = new OneCBGCastSkillInfo
			{
				SkillId = skillInfo.SkillID,
				CanCastWhenDead = skillInfo.CanCastWhenDead
			};
			FName montageStartSectionName = skillInfo.MontageStartSectionName;
			obj.MontageStartSectionName = montageStartSectionName.ToString();
			obj.DontCheckSkillCanCast = skillInfo.DontCheckSkillCanCast;
			skillInfoList.Add(obj);
		}
		return behaviorCustom_CastSkillByScore.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (SkillInfoList.Count > 0)
		{
			stringBuilder.Append("施放技能列表：");
			foreach (FCBGCastSkillInfo skillInfo in SkillInfoList)
			{
				stringBuilder.Append($"{skillInfo.SkillID}；");
			}
			stringBuilder.Append("\n");
			stringBuilder.Append(IsGetTopRandomSkill ? $"随机尝试算分顶部技能，万分比：{TopRandomSkillPercent}" : "获取最高分技能释放");
			stringBuilder.Append("\n");
			stringBuilder.Append(NeedTryCastAllSkillUntilSuccess ? "尝试释放技能，直到有一个成功" : "只释放一次技能");
		}
		else
		{
			stringBuilder.Append("没有需要释放的技能列表");
		}
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_CastSkillByScore bED_BehaviorNode_CastSkillByScore = GCHelper.Find<b1.BED_BehaviorNode_CastSkillByScore>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_CastSkillByScore.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore");
		NativeReflection.GetPropertyRef(ref SkillInfoList_PropertyAddress, intPtr, "SkillInfoList");
		SkillInfoList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillInfoList");
		SkillInfoList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillInfoList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsGetTopRandomSkill_PropertyAddress, intPtr, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsGetTopRandomSkill", Classes.FBoolProperty);
		TopRandomSkillPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "TopRandomSkillPercent");
		TopRandomSkillPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TopRandomSkillPercent", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedTryCastAllSkillUntilSuccess_PropertyAddress, intPtr, "NeedTryCastAllSkillUntilSuccess");
		NeedTryCastAllSkillUntilSuccess_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedTryCastAllSkillUntilSuccess");
		NeedTryCastAllSkillUntilSuccess_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedTryCastAllSkillUntilSuccess", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_CastSkillByScore:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_CastSkillByScore()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_CastSkillByScore)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_CastSkillByScore));
	}
}
