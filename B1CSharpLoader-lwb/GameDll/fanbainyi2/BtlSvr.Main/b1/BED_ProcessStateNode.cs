using System;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode")]
public class BED_ProcessStateNode : BED_ProcessNode
{
	private static bool IsBranchGraphNode_IsValid;

	private static IntPtr IsBranchGraphNode_FunctionAddress;

	private static int IsBranchGraphNode_ParamsSize;

	private static bool IsBranchGraphNode_ReturnValue_IsValid;

	private static int IsBranchGraphNode_ReturnValue_Offset;

	private static FFieldAddress IsBranchGraphNode_ReturnValue_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode:IsBranchGraphNode")]
	protected override bool IsBranchGraphNode_Implementation()
	{
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode:IsBranchGraphNode")]
	private static void IsBranchGraphNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessStateNode bED_ProcessStateNode = GCHelper.Find<BED_ProcessStateNode>(obj);
		bool value = bED_ProcessStateNode.IsBranchGraphNode_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsBranchGraphNode_ReturnValue_Offset), 0, IsBranchGraphNode_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode");
		IsBranchGraphNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsBranchGraphNode");
		IsBranchGraphNode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBranchGraphNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsBranchGraphNode_ReturnValue_PropertyAddress, IsBranchGraphNode_FunctionAddress, "ReturnValue");
		IsBranchGraphNode_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsBranchGraphNode_FunctionAddress, "ReturnValue");
		IsBranchGraphNode_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsBranchGraphNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBranchGraphNode_IsValid = IsBranchGraphNode_FunctionAddress != IntPtr.Zero && IsBranchGraphNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode:IsBranchGraphNode", IsBranchGraphNode_IsValid);
	}

	static BED_ProcessStateNode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode));
	}
}
