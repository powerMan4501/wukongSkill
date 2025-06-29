using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp")]
public class BUS_AiWeakInteractComp : UActorEditCompBase
{
	private static bool AiWeakInteractCheckType_IsValid;

	private static int AiWeakInteractCheckType_Offset;

	private static FFieldAddress AiWeakInteractCheckType_PropertyAddress;

	private static bool InteractTriggerRadius_IsValid;

	private static int InteractTriggerRadius_Offset;

	private static bool InteractTriggerAngle_IsValid;

	private static int InteractTriggerAngle_Offset;

	private static bool AiConversationID_IsValid;

	private static int AiConversationID_Offset;

	private static bool EnableTaskStageCondition_IsValid;

	private static int EnableTaskStageCondition_Offset;

	private static FFieldAddress EnableTaskStageCondition_PropertyAddress;

	private static bool TaskStageID_IsValid;

	private static int TaskStageID_Offset;

	private static bool TaskStageStatus_IsValid;

	private static int TaskStageStatus_Offset;

	private static FFieldAddress TaskStageStatus_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("检测类型")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp:AiWeakInteractCheckType")]
	public EAiWeakInteractCheckType AiWeakInteractCheckType
	{
		get
		{
			CheckDestroyed();
			if (!AiWeakInteractCheckType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:AiWeakInteractCheckType");
				return EAiWeakInteractCheckType.BothPlayerAndFollowPartner;
			}
			return EnumMarshaler<EAiWeakInteractCheckType>.FromNative(IntPtr.Add(base.Address, AiWeakInteractCheckType_Offset), 0, AiWeakInteractCheckType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AiWeakInteractCheckType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:AiWeakInteractCheckType");
			}
			else
			{
				EnumMarshaler<EAiWeakInteractCheckType>.ToNative(IntPtr.Add(base.Address, AiWeakInteractCheckType_Offset), 0, AiWeakInteractCheckType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("检测判断范围（cm）")]
	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp:InteractTriggerRadius")]
	public int InteractTriggerRadius
	{
		get
		{
			CheckDestroyed();
			if (!InteractTriggerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:InteractTriggerRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InteractTriggerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractTriggerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:InteractTriggerRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InteractTriggerRadius_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, "360")]
	[UMeta(MDProp.ClampMin, "0")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("检测夹角")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp:InteractTriggerAngle")]
	public int InteractTriggerAngle
	{
		get
		{
			CheckDestroyed();
			if (!InteractTriggerAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:InteractTriggerAngle");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InteractTriggerAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractTriggerAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:InteractTriggerAngle");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InteractTriggerAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Ai对话ID")]
	[Tooltip("填AiConversationContent这个表的ID")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp:AiConversationID")]
	public int AiConversationID
	{
		get
		{
			CheckDestroyed();
			if (!AiConversationID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:AiConversationID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AiConversationID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AiConversationID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:AiConversationID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AiConversationID_Offset), value);
			}
		}
	}

	[Tooltip("开启后，如果任务配置信息达成，则关闭弱交互")]
	[DisplayName("开启任务判断关闭弱交互")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp:EnableTaskStageCondition")]
	public bool EnableTaskStageCondition
	{
		get
		{
			CheckDestroyed();
			if (!EnableTaskStageCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:EnableTaskStageCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableTaskStageCondition_Offset), 0, EnableTaskStageCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableTaskStageCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:EnableTaskStageCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableTaskStageCondition_Offset), 0, EnableTaskStageCondition_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnableTaskStageCondition")]
	[UMeta(MDProp.ClampMin, "0")]
	[DisplayName("任务阶段ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp:TaskStageID")]
	public int TaskStageID
	{
		get
		{
			CheckDestroyed();
			if (!TaskStageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:TaskStageID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TaskStageID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TaskStageID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:TaskStageID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TaskStageID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("任务阶段状态")]
	[UMeta(MDProp.EditCondition, "EnableTaskStageCondition")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_AiWeakInteractComp:TaskStageStatus")]
	public EStageStatus TaskStageStatus
	{
		get
		{
			CheckDestroyed();
			if (!TaskStageStatus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:TaskStageStatus");
				return EStageStatus.Default;
			}
			return EnumMarshaler<EStageStatus>.FromNative(IntPtr.Add(base.Address, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TaskStageStatus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_AiWeakInteractComp:TaskStageStatus");
			}
			else
			{
				EnumMarshaler<EStageStatus>.ToNative(IntPtr.Add(base.Address, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_AiWeakInteractData bUC_AiWeakInteractData = RequireWritableData<b1.BUC_AiWeakInteractData>();
		bUC_AiWeakInteractData.AiWeakInteractCheckType = AiWeakInteractCheckType;
		bUC_AiWeakInteractData.InteractTriggerRadius = InteractTriggerRadius;
		bUC_AiWeakInteractData.InteractTriggerAngle = InteractTriggerAngle;
		bUC_AiWeakInteractData.AiConversationID = AiConversationID;
		bUC_AiWeakInteractData.EnableTaskStageCondition = EnableTaskStageCondition;
		bUC_AiWeakInteractData.TaskStageID = TaskStageID;
		bUC_AiWeakInteractData.TaskStageStatus = TaskStageStatus;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_AiWeakInteractComp");
		NativeReflection.GetPropertyRef(ref AiWeakInteractCheckType_PropertyAddress, unrealStruct, "AiWeakInteractCheckType");
		AiWeakInteractCheckType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AiWeakInteractCheckType");
		AiWeakInteractCheckType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AiWeakInteractCheckType", Classes.FEnumProperty);
		InteractTriggerRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractTriggerRadius");
		InteractTriggerRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractTriggerRadius", Classes.FIntProperty);
		InteractTriggerAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractTriggerAngle");
		InteractTriggerAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractTriggerAngle", Classes.FIntProperty);
		AiConversationID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AiConversationID");
		AiConversationID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AiConversationID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EnableTaskStageCondition_PropertyAddress, unrealStruct, "EnableTaskStageCondition");
		EnableTaskStageCondition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableTaskStageCondition");
		EnableTaskStageCondition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableTaskStageCondition", Classes.FBoolProperty);
		TaskStageID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskStageID");
		TaskStageID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskStageID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStatus_PropertyAddress, unrealStruct, "TaskStageStatus");
		TaskStageStatus_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskStageStatus");
		TaskStageStatus_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskStageStatus", Classes.FEnumProperty);
	}

	static BUS_AiWeakInteractComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AiWeakInteractComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AiWeakInteractComp));
	}
}
