using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Observe Sequence")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence")]
public class BED_ProcessStateNode_ObserveSequence : BED_ProcessStateNode
{
	private static bool SequenceID_IsValid;

	private static int SequenceID_Offset;

	private static bool SuccessLimit_IsValid;

	private static int SuccessLimit_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Tooltip("")]
	[UProperty]
	[EditAnywhere]
	[Category("Observe Condition Config")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:SequenceID")]
	public int SequenceID
	{
		get
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:SequenceID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SequenceID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:SequenceID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SequenceID_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[Category("Observe Condition Config")]
	[Tooltip("最大可触发次数，默认：1")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:SuccessLimit")]
	protected int SuccessLimit
	{
		get
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:SuccessLimit");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SuccessLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:SuccessLimit");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SuccessLimit_Offset), value);
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

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"观察Sequence是否播放完成，ID = {SequenceID}";
	}

	public override string GetNodeName()
	{
		return "Process.State.ObserveSequence";
	}

	public override byte[] GetCustomData()
	{
		return new ProcessStateCustom_ObserveSequence
		{
			SequenceId = SequenceID,
			SuccessLimit = SuccessLimit
		}.ToByteArray();
	}

	public override bool CheckNodeQueryable(out string ErrorMassager)
	{
		if (BGW_GameDB.GetMovieSequenceDesc(SequenceID) == null)
		{
			ErrorMassager = "不存在的SequenceID";
			return false;
		}
		ErrorMassager = "";
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode_ObserveSequence bED_ProcessStateNode_ObserveSequence = GCHelper.Find<BED_ProcessStateNode_ObserveSequence>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessStateNode_ObserveSequence.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence");
		SequenceID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceID");
		SequenceID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceID", Classes.FIntProperty);
		SuccessLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessLimit");
		SuccessLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessLimit", Classes.FIntProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_ObserveSequence:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessStateNode_ObserveSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_ObserveSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_ObserveSequence));
	}
}
