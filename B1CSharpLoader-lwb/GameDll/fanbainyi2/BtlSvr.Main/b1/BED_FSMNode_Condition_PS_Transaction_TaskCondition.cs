using System;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(true)]
[DisplayName("Condition_TaskCondition")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_FSMNode_Condition_PS_Transaction_TaskCondition")]
public class BED_FSMNode_Condition_PS_Transaction_TaskCondition : BED_FSMNode_ConditionBase
{
	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BED_FSMNode_Condition_PS_Transaction_TaskCondition:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return new StringBuilder().ToString();
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = new FName("True")
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = new FName("False")
		});
		SetNodeCategory("PS_Transaction Condition");
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_FSMNode_Condition_PS_Transaction_TaskCondition:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_FSMNode_Condition_PS_Transaction_TaskCondition bED_FSMNode_Condition_PS_Transaction_TaskCondition = GCHelper.Find<BED_FSMNode_Condition_PS_Transaction_TaskCondition>(obj);
		string nodeDescriptionInCS_Implementation = bED_FSMNode_Condition_PS_Transaction_TaskCondition.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_Condition_PS_Transaction_TaskCondition");
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_FSMNode_Condition_PS_Transaction_TaskCondition:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_FSMNode_Condition_PS_Transaction_TaskCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_Condition_PS_Transaction_TaskCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_Condition_PS_Transaction_TaskCondition));
	}
}
