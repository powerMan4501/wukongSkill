using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UDelegate]
[UMetaPath("/Script/RigVMDeveloper.RigVMGraphModifiedDynamicEvent__DelegateSignature")]
public class FRigVMGraphModifiedDynamicEvent : FMulticastDelegate<FRigVMGraphModifiedDynamicEvent.Signature>
{
	public delegate void Signature(ERigVMGraphNotifType NotifType, URigVMGraph Graph, UObject Subject);

	private static bool RigVMGraphModifiedDynamicEvent__DelegateSignature_IsValid;

	private static IntPtr RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress;

	private static int RigVMGraphModifiedDynamicEvent__DelegateSignature_ParamsSize;

	private static bool RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_IsValid;

	private static FFieldAddress RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_PropertyAddress;

	private static int RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_Offset;

	private static bool RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_IsValid;

	private static FFieldAddress RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_PropertyAddress;

	private static int RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_Offset;

	private static bool RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_IsValid;

	private static FFieldAddress RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_PropertyAddress;

	private static int RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FRigVMGraphModifiedDynamicEvent()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/RigVMDeveloper.RigVMGraphModifiedDynamicEvent__DelegateSignature");
		RigVMGraphModifiedDynamicEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_PropertyAddress, RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "NotifType");
		RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_Offset = NativeReflectionCached.GetPropertyOffset(RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "NotifType");
		RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_IsValid = NativeReflectionCached.ValidatePropertyClass(RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "NotifType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_PropertyAddress, RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Graph");
		RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_Offset = NativeReflectionCached.GetPropertyOffset(RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Graph");
		RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Graph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_PropertyAddress, RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Subject");
		RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_Offset = NativeReflectionCached.GetPropertyOffset(RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Subject");
		RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_IsValid = NativeReflectionCached.ValidatePropertyClass(RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress, "Subject", Classes.FObjectProperty);
		RigVMGraphModifiedDynamicEvent__DelegateSignature_IsValid = RigVMGraphModifiedDynamicEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_IsValid && RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_IsValid && RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraphModifiedDynamicEvent__DelegateSignature", RigVMGraphModifiedDynamicEvent__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(ERigVMGraphNotifType NotifType, URigVMGraph Graph, UObject Subject)
	{
		if (!RigVMGraphModifiedDynamicEvent__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraphModifiedDynamicEvent__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(RigVMGraphModifiedDynamicEvent__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RigVMGraphModifiedDynamicEvent__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<ERigVMGraphNotifType>.ToNative(IntPtr.Add(intPtr, RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_Offset), 0, RigVMGraphModifiedDynamicEvent__DelegateSignature_NotifType_PropertyAddress.Address, NotifType);
			UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(intPtr, RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_Offset), 0, RigVMGraphModifiedDynamicEvent__DelegateSignature_Graph_PropertyAddress.Address, Graph);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_Offset), 0, RigVMGraphModifiedDynamicEvent__DelegateSignature_Subject_PropertyAddress.Address, Subject);
			ProcessDelegate(intPtr);
		}
	}
}
