using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[NotBlueprintable]
[DisplayName("Fork Node")]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Fork")]
public class BED_ProcessMachineNode_Fork : BED_ProcessMachineNode
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

	private static bool CanUserAddOutputInCS_IsValid;

	private static IntPtr CanUserAddOutputInCS_FunctionAddress;

	private static int CanUserAddOutputInCS_ParamsSize;

	private static bool CanUserAddOutputInCS_ReturnValue_IsValid;

	private static int CanUserAddOutputInCS_ReturnValue_Offset;

	private static FFieldAddress CanUserAddOutputInCS_ReturnValue_PropertyAddress;

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Machine Operators");
		SetNodeStyle(ECalliopeNodeStyle.Logic);
		SetNumberedOutputPins(0, 1);
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Fork:CanUserAddOutputInCS")]
	protected override bool CanUserAddOutputInCS_Implementation()
	{
		return true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Fork;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Fork:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_Fork:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_Fork bED_ProcessMachineNode_Fork = GCHelper.Find<BED_ProcessMachineNode_Fork>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_ProcessMachineNode_Fork.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessMachineNode_Fork:CanUserAddOutputInCS")]
	private static void CanUserAddOutputInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessMachineNode_Fork bED_ProcessMachineNode_Fork = GCHelper.Find<BED_ProcessMachineNode_Fork>(obj);
		bool value = bED_ProcessMachineNode_Fork.CanUserAddOutputInCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanUserAddOutputInCS_ReturnValue_Offset), 0, CanUserAddOutputInCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Fork");
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_Fork:IsSupportViewType", IsSupportViewType_IsValid);
		CanUserAddOutputInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanUserAddOutputInCS");
		CanUserAddOutputInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserAddOutputInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanUserAddOutputInCS_ReturnValue_PropertyAddress, CanUserAddOutputInCS_FunctionAddress, "ReturnValue");
		CanUserAddOutputInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanUserAddOutputInCS_FunctionAddress, "ReturnValue");
		CanUserAddOutputInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanUserAddOutputInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserAddOutputInCS_IsValid = CanUserAddOutputInCS_FunctionAddress != IntPtr.Zero && CanUserAddOutputInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessMachineNode_Fork:CanUserAddOutputInCS", CanUserAddOutputInCS_IsValid);
	}

	static BED_ProcessMachineNode_Fork()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Fork)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Fork));
	}
}
