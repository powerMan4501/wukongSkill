using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("AND")]
[UClass]
[NotBlueprintable]
[USharpPath("/Script/b1-Managed.BED_TaskNode_LogicalAnd")]
public class BED_TaskNode_LogicalAnd : BED_TaskNode
{
	private static bool CanUserAddInputInCS_IsValid;

	private static IntPtr CanUserAddInputInCS_FunctionAddress;

	private static int CanUserAddInputInCS_ParamsSize;

	private static bool CanUserAddInputInCS_ReturnValue_IsValid;

	private static int CanUserAddInputInCS_ReturnValue_Offset;

	private static FFieldAddress CanUserAddInputInCS_ReturnValue_PropertyAddress;

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Operators");
		SetNodeStyle(ECalliopeNodeStyle.Logic);
		SetNumberedInputPins(0, 1);
	}

	[USharpPath("/Script/b1-Managed.BED_TaskNode_LogicalAnd:CanUserAddInputInCS")]
	protected override bool CanUserAddInputInCS_Implementation()
	{
		return true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.LogicalAnd;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_TaskNode_LogicalAnd:CanUserAddInputInCS")]
	private static void CanUserAddInputInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_TaskNode_LogicalAnd bED_TaskNode_LogicalAnd = GCHelper.Find<BED_TaskNode_LogicalAnd>(obj);
		bool value = bED_TaskNode_LogicalAnd.CanUserAddInputInCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanUserAddInputInCS_ReturnValue_Offset), 0, CanUserAddInputInCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_LogicalAnd");
		CanUserAddInputInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanUserAddInputInCS");
		CanUserAddInputInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserAddInputInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanUserAddInputInCS_ReturnValue_PropertyAddress, CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanUserAddInputInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserAddInputInCS_IsValid = CanUserAddInputInCS_FunctionAddress != IntPtr.Zero && CanUserAddInputInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_TaskNode_LogicalAnd:CanUserAddInputInCS", CanUserAddInputInCS_IsValid);
	}

	static BED_TaskNode_LogicalAnd()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_LogicalAnd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_LogicalAnd));
	}
}
