using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("控制附属单位")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor")]
internal class BED_BehaviorNode_ControlChildActor : b1.BED_BehaviorNode_Action
{
	private static bool MatchInfo_IsValid;

	private static int MatchInfo_Offset;

	private static bool ActionInfo_IsValid;

	private static int ActionInfo_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("匹配子Tamer信息")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:MatchInfo")]
	public FTamerFamilyMatchChildInfo MatchInfo
	{
		get
		{
			CheckDestroyed();
			if (!MatchInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:MatchInfo");
				return default(FTamerFamilyMatchChildInfo);
			}
			return FTamerFamilyMatchChildInfo.FromNative(IntPtr.Add(base.Address, MatchInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatchInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:MatchInfo");
			}
			else
			{
				FTamerFamilyMatchChildInfo.ToNative(IntPtr.Add(base.Address, MatchInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("执行操作")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:ActionInfo")]
	public FChildActorActionInfo ActionInfo
	{
		get
		{
			CheckDestroyed();
			if (!ActionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:ActionInfo");
				return default(FChildActorActionInfo);
			}
			return FChildActorActionInfo.FromNative(IntPtr.Add(base.Address, ActionInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:ActionInfo");
			}
			else
			{
				FChildActorActionInfo.ToNative(IntPtr.Add(base.Address, ActionInfo_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.ControlChildActor;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_ControlChildActor
		{
			MatchInfo = BED_CalliopeFuncLib.Serialize(MatchInfo),
			Action = BED_CalliopeFuncLib.Serialize(ActionInfo)
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (ActionInfo.ActionType)
		{
		case EChildActorActionType.CastSkill:
			stringBuilder.Append($"施放技能：{ActionInfo.SkillId}, 是否执行释放条件检测：{ActionInfo.NeedCheckSkillCanCast}");
			break;
		case EChildActorActionType.AddBuff:
			stringBuilder.AppendLine($"添加Buff：{ActionInfo.BuffId}（{ActionInfo.BuffLayer}层)");
			stringBuilder.Append("持续时间：");
			if (ActionInfo.BuffDuration < 0)
			{
				stringBuilder.Append("无限");
			}
			else if (ActionInfo.BuffDuration == 0)
			{
				stringBuilder.Append("与表中配置一致");
			}
			else
			{
				stringBuilder.Append(ActionInfo.BuffDuration);
			}
			break;
		case EChildActorActionType.RemoveBuff:
			stringBuilder.Append($"移除buff：{ActionInfo.BuffId}（{ActionInfo.BuffLayer}层)");
			if (!ActionInfo.TriggerRemoveEffect)
			{
				stringBuilder.Append("\nnote: 仅移除buff但不移除效果");
			}
			break;
		case EChildActorActionType.SpawnSocketAttachTamer:
			stringBuilder.Append("生成附属单位");
			break;
		default:
			stringBuilder.Append("未识别类型");
			break;
		}
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_ControlChildActor bED_BehaviorNode_ControlChildActor = GCHelper.Find<b1.BED_BehaviorNode_ControlChildActor>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_ControlChildActor.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor");
		MatchInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatchInfo");
		MatchInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatchInfo", Classes.FStructProperty);
		ActionInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionInfo");
		ActionInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionInfo", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_ControlChildActor:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_ControlChildActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_ControlChildActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_ControlChildActor));
	}
}
