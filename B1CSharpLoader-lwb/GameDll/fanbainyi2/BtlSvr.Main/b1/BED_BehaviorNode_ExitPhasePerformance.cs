using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("退出转阶段表演")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_ExitPhasePerformance")]
internal class BED_BehaviorNode_ExitPhasePerformance : b1.BED_BehaviorNode_Action
{
	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.ExitPhasePerformance;
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_ExitPhasePerformance:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return "退出转阶段表演状态";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_ExitPhasePerformance:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_ExitPhasePerformance bED_BehaviorNode_ExitPhasePerformance = GCHelper.Find<b1.BED_BehaviorNode_ExitPhasePerformance>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_ExitPhasePerformance.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_ExitPhasePerformance");
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_ExitPhasePerformance:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_ExitPhasePerformance()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_ExitPhasePerformance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_ExitPhasePerformance));
	}
}
