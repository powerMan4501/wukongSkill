using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Observe Actor")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor")]
public class BED_ProcessStateNode_ObserveActor : BED_ProcessStateNode
{
	private static bool SuccessLimit_IsValid;

	private static int SuccessLimit_Offset;

	private static bool ObserveActorInfo_IsValid;

	private static int ObserveActorInfo_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Tooltip("最大可触发次数，默认：1")]
	[UProperty]
	[EditDefaultsOnly]
	[UMeta(MDProp.ClampMin, "1")]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:SuccessLimit")]
	public int SuccessLimit
	{
		get
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:SuccessLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:SuccessLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessLimit_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:ObserveActorInfo")]
	public FObserveActorInfo ObserveActorInfo
	{
		get
		{
			CheckDestroyed();
			if (!ObserveActorInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:ObserveActorInfo");
				return default(FObserveActorInfo);
			}
			return FObserveActorInfo.FromNative(IntPtr.Add(base.Address, ObserveActorInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObserveActorInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:ObserveActorInfo");
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
	}

	public override string GetNodeName()
	{
		return "Process.State.ObserveActor";
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:GetNodeDescriptionInCS")]
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
		ProcessStateCustom_ObserveByCondition processStateCustom_ObserveByCondition = new ProcessStateCustom_ObserveByCondition();
		processStateCustom_ObserveByCondition.ConditionType = (int)ObserveActorInfo.ConditionType;
		processStateCustom_ObserveByCondition.SuccessLimit = SuccessLimit;
		if (ObserveActorInfo.ObservedPlayerOrUnitOrActor.ConfigGuid == Guid.Empty)
		{
			processStateCustom_ObserveByCondition.ObserveActorGuid = B1GlobalFNames.Player_Wukong.PlainName;
		}
		else
		{
			GetAssetInCS().GetParameterActorGuidByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObserveActorInfo.ObservedPlayerOrUnitOrActor.ConfigGuid), out var OutActorGuid);
			processStateCustom_ObserveByCondition.ObserveActorGuid = OutActorGuid;
		}
		processStateCustom_ObserveByCondition.UnitState = (int)ObserveActorInfo.UnitState;
		processStateCustom_ObserveByCondition.SimpleState = (int)ObserveActorInfo.SimpleState;
		processStateCustom_ObserveByCondition.AttrFloatType = (int)ObserveActorInfo.AttrFloatType;
		processStateCustom_ObserveByCondition.CompareOperation = (int)ObserveActorInfo.CompareOperation;
		processStateCustom_ObserveByCondition.CompareValue = ObserveActorInfo.CompareValue;
		GetAssetInCS().GetParameterBuffIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(ObserveActorInfo.Buff.ConfigGuid), out var OutBuffID);
		processStateCustom_ObserveByCondition.BuffId = OutBuffID;
		return processStateCustom_ObserveByCondition.ToByteArray();
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_ObserveActor bED_ProcessStateNode_ObserveActor = GCHelper.Find<BED_ProcessStateNode_ObserveActor>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessStateNode_ObserveActor.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor");
		SuccessLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessLimit");
		SuccessLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessLimit", Classes.FIntProperty);
		ObserveActorInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "ObserveActorInfo");
		ObserveActorInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ObserveActorInfo", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_ObserveActor:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessStateNode_ObserveActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_ObserveActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_ObserveActor));
	}
}
