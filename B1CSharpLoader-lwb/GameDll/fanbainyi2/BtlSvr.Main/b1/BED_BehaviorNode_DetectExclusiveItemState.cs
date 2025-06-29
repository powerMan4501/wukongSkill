using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("检测专属物件状态")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState")]
internal class BED_BehaviorNode_DetectExclusiveItemState : BED_BehaviorNode_Condition
{
	private static bool ActorTag_IsValid;

	private static int ActorTag_Offset;

	private static bool StateTags_IsValid;

	private static int StateTags_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("DetectState")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:ActorTag")]
	public FGameplayTag ActorTag
	{
		get
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:ActorTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, ActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:ActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, ActorTag_Offset), value);
			}
		}
	}

	[Category("DetectState")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:StateTags")]
	public FGameplayTagContainer StateTags
	{
		get
		{
			CheckDestroyed();
			if (!StateTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:StateTags");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, StateTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StateTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:StateTags");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, StateTags_Offset), value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.DetectExclusiveItemState;
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_DetectExclusiveItemState behaviorCustom_DetectExclusiveItemState = new BehaviorCustom_DetectExclusiveItemState();
		behaviorCustom_DetectExclusiveItemState.IsReverseCondition = base.bReverseCondition;
		behaviorCustom_DetectExclusiveItemState.ConditionCoolDownTimeMs = base.ConditionCoolDownTimeMs;
		behaviorCustom_DetectExclusiveItemState.ActorTag = ActorTag.TagName.PlainName;
		foreach (FGameplayTag gameplayTag in StateTags.GameplayTags)
		{
			RepeatedField<string> stateTags = behaviorCustom_DetectExclusiveItemState.StateTags;
			FName tagName = gameplayTag.TagName;
			stateTags.Add(tagName.PlainName);
		}
		return behaviorCustom_DetectExclusiveItemState.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (GameplayTagExtension.IsValid(ActorTag))
		{
			stringBuilder.AppendLine("专属ActorTag: " + ActorTag.TagName.PlainName);
		}
		else
		{
			stringBuilder.AppendLine("未配置专属ActorTag");
		}
		if (GameplayTagExtension.IsValid(StateTags))
		{
			stringBuilder.AppendLine("检测是否在以下状态中：");
			foreach (FGameplayTag gameplayTag in StateTags.GameplayTags)
			{
				stringBuilder.AppendLine($"{gameplayTag.TagName}");
			}
		}
		else
		{
			stringBuilder.Append("未配置需要检测的状态");
		}
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_DetectExclusiveItemState bED_BehaviorNode_DetectExclusiveItemState = GCHelper.Find<b1.BED_BehaviorNode_DetectExclusiveItemState>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_DetectExclusiveItemState.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState");
		ActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorTag");
		ActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorTag", Classes.FStructProperty);
		StateTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "StateTags");
		StateTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StateTags", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_DetectExclusiveItemState:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_DetectExclusiveItemState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_DetectExclusiveItemState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_DetectExclusiveItemState));
	}
}
