using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("演员：退出转阶段表演")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerExitPhasePerformance")]
internal class BED_MovieNode_PerformerExitPhasePerformance : b1.BED_MovieNode_PerformerAction
{
	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PerformerExitPhasePerformance;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PerformerExitPhasePerformance
		{
			PerformerGuid = base.Performer.TagName.PlainName
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PerformerExitPhasePerformance:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"演员{base.Performer.TagName}退出转阶段表演";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PerformerExitPhasePerformance:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PerformerExitPhasePerformance bED_MovieNode_PerformerExitPhasePerformance = GCHelper.Find<b1.BED_MovieNode_PerformerExitPhasePerformance>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PerformerExitPhasePerformance.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PerformerExitPhasePerformance");
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PerformerExitPhasePerformance:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PerformerExitPhasePerformance()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PerformerExitPhasePerformance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PerformerExitPhasePerformance));
	}
}
