using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("OR")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_LogicalOr")]
internal class BED_BehaviorNode_LogicalOr : BED_BehaviorNode
{
	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	private static bool CanUserAddInputInCS_IsValid;

	private static IntPtr CanUserAddInputInCS_FunctionAddress;

	private static int CanUserAddInputInCS_ParamsSize;

	private static bool CanUserAddInputInCS_ReturnValue_IsValid;

	private static int CanUserAddInputInCS_ReturnValue_Offset;

	private static FFieldAddress CanUserAddInputInCS_ReturnValue_PropertyAddress;

	public override EBehaviorNodeSide NodeSide => EBehaviorNodeSide.LeftNode;

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Logic");
		SetNodeStyle(ECalliopeNodeStyle.Logic);
		base.InputPins.Clear();
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Failed
		});
		SetNumberedInputPins(0, 1);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.LogicalOr;
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_LogicalOr:CanUserAddInputInCS")]
	protected override bool CanUserAddInputInCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_LogicalOr:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_LogicalOr:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_LogicalOr bED_BehaviorNode_LogicalOr = GCHelper.Find<b1.BED_BehaviorNode_LogicalOr>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_LogicalOr.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_LogicalOr:CanUserAddInputInCS")]
	private static void CanUserAddInputInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_LogicalOr bED_BehaviorNode_LogicalOr = GCHelper.Find<b1.BED_BehaviorNode_LogicalOr>(obj);
		bool value = bED_BehaviorNode_LogicalOr.CanUserAddInputInCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanUserAddInputInCS_ReturnValue_Offset), 0, CanUserAddInputInCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_LogicalOr");
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_LogicalOr:IsSupportViewType", IsSupportViewType_IsValid);
		CanUserAddInputInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanUserAddInputInCS");
		CanUserAddInputInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserAddInputInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanUserAddInputInCS_ReturnValue_PropertyAddress, CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanUserAddInputInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserAddInputInCS_IsValid = CanUserAddInputInCS_FunctionAddress != IntPtr.Zero && CanUserAddInputInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_LogicalOr:CanUserAddInputInCS", CanUserAddInputInCS_IsValid);
	}

	static BED_BehaviorNode_LogicalOr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_LogicalOr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_LogicalOr));
	}
}
