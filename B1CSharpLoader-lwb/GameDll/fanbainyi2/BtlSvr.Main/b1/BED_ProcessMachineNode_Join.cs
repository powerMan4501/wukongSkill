using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[NotBlueprintable]
[DisplayName("Join Node")]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Join")]
public class BED_ProcessMachineNode_Join : BED_ProcessMachineNode
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

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Machine Operators");
		SetNodeStyle(ECalliopeNodeStyle.Logic);
		SetNumberedInputPins(0, 1);
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Join:CanUserAddInputInCS")]
	protected override bool CanUserAddInputInCS_Implementation()
	{
		return true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Join;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Join:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_Join:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_Join bED_ProcessMachineNode_Join = GCHelper.Find<BED_ProcessMachineNode_Join>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_ProcessMachineNode_Join.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_Join:CanUserAddInputInCS")]
	private static void CanUserAddInputInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_Join bED_ProcessMachineNode_Join = GCHelper.Find<BED_ProcessMachineNode_Join>(obj);
		bool value = bED_ProcessMachineNode_Join.CanUserAddInputInCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanUserAddInputInCS_ReturnValue_Offset), 0, CanUserAddInputInCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Join");
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_Join:IsSupportViewType", IsSupportViewType_IsValid);
		CanUserAddInputInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanUserAddInputInCS");
		CanUserAddInputInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserAddInputInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanUserAddInputInCS_ReturnValue_PropertyAddress, CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanUserAddInputInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserAddInputInCS_IsValid = CanUserAddInputInCS_FunctionAddress != IntPtr.Zero && CanUserAddInputInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_Join:CanUserAddInputInCS", CanUserAddInputInCS_IsValid);
	}

	static BED_ProcessMachineNode_Join()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Join)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Join));
	}
}
