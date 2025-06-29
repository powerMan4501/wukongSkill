using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Sequence")]
[NotBlueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_ExecutionSequence")]
public class BED_QuestNode_ExecutionSequence : BED_QuestNode
{
	private static bool CanUserAddOutputInCS_IsValid;

	private static IntPtr CanUserAddOutputInCS_FunctionAddress;

	private static int CanUserAddOutputInCS_ParamsSize;

	private static bool CanUserAddOutputInCS_ReturnValue_IsValid;

	private static int CanUserAddOutputInCS_ReturnValue_Offset;

	private static FFieldAddress CanUserAddOutputInCS_ReturnValue_PropertyAddress;

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.Logic);
		SetNumberedOutputPins(0, 1);
	}

	[USharpPath("/Script/b1-Managed.BED_QuestNode_ExecutionSequence:CanUserAddOutputInCS")]
	protected override bool CanUserAddOutputInCS_Implementation()
	{
		return true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.ExecutionSequence;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_QuestNode_ExecutionSequence:CanUserAddOutputInCS")]
	private static void CanUserAddOutputInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_QuestNode_ExecutionSequence bED_QuestNode_ExecutionSequence = GCHelper.Find<BED_QuestNode_ExecutionSequence>(obj);
		bool value = bED_QuestNode_ExecutionSequence.CanUserAddOutputInCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanUserAddOutputInCS_ReturnValue_Offset), 0, CanUserAddOutputInCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_ExecutionSequence");
		CanUserAddOutputInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanUserAddOutputInCS");
		CanUserAddOutputInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserAddOutputInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanUserAddOutputInCS_ReturnValue_PropertyAddress, CanUserAddOutputInCS_FunctionAddress, "ReturnValue");
		CanUserAddOutputInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanUserAddOutputInCS_FunctionAddress, "ReturnValue");
		CanUserAddOutputInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanUserAddOutputInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserAddOutputInCS_IsValid = CanUserAddOutputInCS_FunctionAddress != IntPtr.Zero && CanUserAddOutputInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_QuestNode_ExecutionSequence:CanUserAddOutputInCS", CanUserAddOutputInCS_IsValid);
	}

	static BED_QuestNode_ExecutionSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_ExecutionSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_ExecutionSequence));
	}
}
