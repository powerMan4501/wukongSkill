using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMRerouteNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMRerouteNode : URigVMNode
{
	private static bool GetShowsAsFullNode_IsValid;

	private static IntPtr GetShowsAsFullNode_FunctionAddress;

	private static int GetShowsAsFullNode_ParamsSize;

	private static bool GetShowsAsFullNode_ReturnValue_IsValid;

	private static FFieldAddress GetShowsAsFullNode_ReturnValue_PropertyAddress;

	private static int GetShowsAsFullNode_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMRerouteNode:GetShowsAsFullNode")]
	public unsafe bool GetShowsAsFullNode()
	{
		CheckDestroyed();
		if (!GetShowsAsFullNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMRerouteNode:GetShowsAsFullNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShowsAsFullNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShowsAsFullNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShowsAsFullNode_FunctionAddress, intPtr, GetShowsAsFullNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetShowsAsFullNode_ReturnValue_Offset), 0, GetShowsAsFullNode_ReturnValue_PropertyAddress.Address);
	}

	static URigVMRerouteNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMRerouteNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMRerouteNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMRerouteNode");
		GetShowsAsFullNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetShowsAsFullNode");
		GetShowsAsFullNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShowsAsFullNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShowsAsFullNode_ReturnValue_PropertyAddress, GetShowsAsFullNode_FunctionAddress, "ReturnValue");
		GetShowsAsFullNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShowsAsFullNode_FunctionAddress, "ReturnValue");
		GetShowsAsFullNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShowsAsFullNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetShowsAsFullNode_IsValid = GetShowsAsFullNode_FunctionAddress != IntPtr.Zero && GetShowsAsFullNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMRerouteNode:GetShowsAsFullNode", GetShowsAsFullNode_IsValid);
	}
}
