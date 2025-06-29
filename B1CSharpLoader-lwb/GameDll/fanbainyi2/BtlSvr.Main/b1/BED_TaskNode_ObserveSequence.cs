using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[DisplayName("观察Sequence")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveSequence")]
public class BED_TaskNode_ObserveSequence : BED_TaskNode
{
	private static bool SequencePhase_IsValid;

	private static int SequencePhase_Offset;

	private static FFieldAddress SequencePhase_PropertyAddress;

	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	private static bool SuccessLimit_IsValid;

	private static int SuccessLimit_Offset;

	private static bool SequenceID_IsValid;

	private static int SequenceID_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[DisplayName("Sequence阶段")]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SequencePhase")]
	public ESequencePhase SequencePhase
	{
		get
		{
			CheckDestroyed();
			if (!SequencePhase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SequencePhase");
				return ESequencePhase.None;
			}
			return EnumMarshaler<ESequencePhase>.FromNative(IntPtr.Add(base.Address, SequencePhase_Offset), 0, SequencePhase_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SequencePhase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SequencePhase");
			}
			else
			{
				EnumMarshaler<ESequencePhase>.ToNative(IntPtr.Add(base.Address, SequencePhase_Offset), 0, SequencePhase_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("")]
	[Category("Observe Condition Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveSequence:Sequence")]
	public FGsSmartParam Sequence
	{
		get
		{
			CheckDestroyed();
			if (!Sequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:Sequence");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Sequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:Sequence");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Sequence_Offset), value);
			}
		}
	}

	[Category("Observe Condition Config")]
	[UProperty]
	[Tooltip("最大可触发次数，默认：1")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SuccessLimit")]
	protected int SuccessLimit
	{
		get
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SuccessLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SuccessLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessLimit_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SequenceID")]
	public int SequenceID
	{
		get
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SequenceID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SequenceID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ObserveSequence:SequenceID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SequenceID_Offset), value);
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
		SequencePhase = ESequencePhase.Finished;
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_ObserveSequence:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("观察Sequence是否");
		switch (SequencePhase)
		{
		case ESequencePhase.Started:
			stringBuilder.Append("开始播放");
			break;
		case ESequencePhase.Finished:
			stringBuilder.Append("播放完成");
			break;
		}
		stringBuilder.Append($"，ID = {SequenceID}");
		return stringBuilder.ToString();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.ObserveSequence;
	}

	public override uint GetCustomDataVersion()
	{
		return 1u;
	}

	public override byte[] GetCustomData()
	{
		TaskCustom_ObserveSequence taskCustom_ObserveSequence = new TaskCustom_ObserveSequence();
		GetAssetInCS().GetParameterSequenceIDByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(Sequence.ConfigGuid), out var OutSequenceID);
		taskCustom_ObserveSequence.SequenceId = OutSequenceID;
		taskCustom_ObserveSequence.SuccessLimit = SuccessLimit;
		taskCustom_ObserveSequence.SequencePhase = (int)SequencePhase;
		return taskCustom_ObserveSequence.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_ObserveSequence:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_ObserveSequence bED_TaskNode_ObserveSequence = GCHelper.Find<BED_TaskNode_ObserveSequence>(obj);
		string nodeDescriptionInCS_Implementation = bED_TaskNode_ObserveSequence.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_ObserveSequence");
		NativeReflection.GetPropertyRef(ref SequencePhase_PropertyAddress, intPtr, "SequencePhase");
		SequencePhase_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequencePhase");
		SequencePhase_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequencePhase", Classes.FEnumProperty);
		Sequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Sequence", Classes.FStructProperty);
		SuccessLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessLimit");
		SuccessLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessLimit", Classes.FIntProperty);
		SequenceID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceID");
		SequenceID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceID", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_ObserveSequence:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_TaskNode_ObserveSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_ObserveSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_ObserveSequence));
	}
}
