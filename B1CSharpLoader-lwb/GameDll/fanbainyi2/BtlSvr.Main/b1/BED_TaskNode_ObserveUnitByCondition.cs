using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("观察角色/物件")]
[NotBlueprintable]
[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition")]
public class BED_TaskNode_ObserveUnitByCondition : BED_TaskNode
{
	private static bool SuccessLimit_IsValid;

	private static int SuccessLimit_Offset;

	private static bool ObserveActorInfo_IsValid;

	private static int ObserveActorInfo_Offset;

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

	[Tooltip("最大可触发次数，默认：1")]
	[Category("Observe Condition Config")]
	[EditDefaultsOnly]
	[UProperty]
	[UMeta(MDProp.ClampMin, "1")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:SuccessLimit")]
	public int SuccessLimit
	{
		get
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:SuccessLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:SuccessLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessLimit_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:ObserveActorInfo")]
	public FObserveActorInfo ObserveActorInfo
	{
		get
		{
			CheckDestroyed();
			if (!ObserveActorInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:ObserveActorInfo");
				return default(FObserveActorInfo);
			}
			return FObserveActorInfo.FromNative(IntPtr.Add(base.Address, ObserveActorInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObserveActorInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:ObserveActorInfo");
			}
			else
			{
				FObserveActorInfo.ToNative(IntPtr.Add(base.Address, ObserveActorInfo_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Observe");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enable
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disable
		});
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Completed
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Enabled
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Disabled
		});
		SuccessLimit = 1;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:PostPropertyChanged")]
	protected override void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("ConditionType"))
		{
			ForceRefreshDetailView();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		GetAssetInCS().GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObserveActorInfo.ObservedPlayerOrUnitOrActor.ConfigGuid), "ObservedPlayerOrUnitOrActor", out var OutDisplayName);
		return $"{OutDisplayName}\r\n{GetObserveConditionString()}\r\nSuccessLimit:{SuccessLimit}";
	}

	protected string GetObserveConditionString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(ObserveActorInfo.ConditionType.ToString());
		switch (ObserveActorInfo.ConditionType)
		{
		case EObserveConditionType.UnitAttr:
			stringBuilder.Append($" {ObserveActorInfo.AttrFloatType} {ObserveActorInfo.CompareOperation} {ObserveActorInfo.CompareValue}");
			break;
		case EObserveConditionType.SimpleState:
			stringBuilder.Append($"SimpleState is {ObserveActorInfo.SimpleState}");
			break;
		case EObserveConditionType.UnitState:
			stringBuilder.Append($"SimpleState is {ObserveActorInfo.UnitState}");
			break;
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		TaskCustom_ObserveUnitByCondition taskCustom_ObserveUnitByCondition = new TaskCustom_ObserveUnitByCondition();
		taskCustom_ObserveUnitByCondition.ConditionType = (int)ObserveActorInfo.ConditionType;
		taskCustom_ObserveUnitByCondition.SuccessLimit = SuccessLimit;
		if (ObserveActorInfo.ObservedPlayerOrUnitOrActor.ConfigGuid == Guid.Empty)
		{
			taskCustom_ObserveUnitByCondition.ObserveActorGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObserveActorInfo.ObservedPlayerOrUnitOrActor.ConfigGuid), out var OutActorGuid);
			taskCustom_ObserveUnitByCondition.ObserveActorGuid = OutActorGuid;
		}
		taskCustom_ObserveUnitByCondition.UnitState = (int)ObserveActorInfo.UnitState;
		taskCustom_ObserveUnitByCondition.SimpleState = (int)ObserveActorInfo.SimpleState;
		taskCustom_ObserveUnitByCondition.AttrFloatType = (int)ObserveActorInfo.AttrFloatType;
		taskCustom_ObserveUnitByCondition.CompareOperation = (int)ObserveActorInfo.CompareOperation;
		taskCustom_ObserveUnitByCondition.CompareValue = ObserveActorInfo.CompareValue;
		GetAssetInCS().GetParameterBuffIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObserveActorInfo.Buff.ConfigGuid), out var OutBuffID);
		taskCustom_ObserveUnitByCondition.BuffId = OutBuffID;
		return taskCustom_ObserveUnitByCondition.ToByteArray();
	}

	private bool GetNeedUnit()
	{
		bool result = false;
		EObserveConditionType conditionType = ObserveActorInfo.ConditionType;
		if (conditionType - 12 <= EObserveConditionType.PlayerEnterArea || conditionType - 101 <= EObserveConditionType.PlayerInteractEnd)
		{
			result = true;
		}
		return result;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.ObserveUnitByCondition;
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:PostPropertyChanged")]
	private static void PostPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_ObserveUnitByCondition bED_TaskNode_ObserveUnitByCondition = GCHelper.Find<BED_TaskNode_ObserveUnitByCondition>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, PostPropertyChanged_PropertyName_Offset));
		bED_TaskNode_ObserveUnitByCondition.PostPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_ObserveUnitByCondition bED_TaskNode_ObserveUnitByCondition = GCHelper.Find<BED_TaskNode_ObserveUnitByCondition>(obj);
		string nodeDescriptionInCS_Implementation = bED_TaskNode_ObserveUnitByCondition.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition");
		SuccessLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessLimit");
		SuccessLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessLimit", Classes.FIntProperty);
		ObserveActorInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveActorInfo");
		ObserveActorInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveActorInfo", Classes.FStructProperty);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:PostPropertyChanged", PostPropertyChanged_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_ObserveUnitByCondition:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_TaskNode_ObserveUnitByCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_ObserveUnitByCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_ObserveUnitByCondition));
	}
}
