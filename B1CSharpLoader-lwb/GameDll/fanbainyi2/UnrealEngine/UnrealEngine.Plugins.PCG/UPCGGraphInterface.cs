using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGGraphInterface", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGGraphInterface : UObject
{
	private static bool GetMutablePCGGraph_IsValid;

	private static IntPtr GetMutablePCGGraph_FunctionAddress;

	private static int GetMutablePCGGraph_ParamsSize;

	private static bool GetMutablePCGGraph_ReturnValue_IsValid;

	private static FFieldAddress GetMutablePCGGraph_ReturnValue_PropertyAddress;

	private static int GetMutablePCGGraph_ReturnValue_Offset;

	private static bool GetConstPCGGraph_IsValid;

	private static IntPtr GetConstPCGGraph_FunctionAddress;

	private static int GetConstPCGGraph_ParamsSize;

	private static bool GetConstPCGGraph_ReturnValue_IsValid;

	private static FFieldAddress GetConstPCGGraph_ReturnValue_PropertyAddress;

	private static int GetConstPCGGraph_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGGraphInterface:GetMutablePCGGraph")]
	public unsafe UPCGGraph GetMutablePCGGraph()
	{
		CheckDestroyed();
		if (!GetMutablePCGGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphInterface:GetMutablePCGGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMutablePCGGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMutablePCGGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMutablePCGGraph_FunctionAddress, intPtr, GetMutablePCGGraph_ParamsSize);
		return UObjectMarshaler<UPCGGraph>.FromNative(IntPtr.Add(intPtr, GetMutablePCGGraph_ReturnValue_Offset), 0, GetMutablePCGGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGGraphInterface:GetConstPCGGraph")]
	public unsafe UPCGGraph GetConstPCGGraph()
	{
		CheckDestroyed();
		if (!GetConstPCGGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGGraphInterface:GetConstPCGGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConstPCGGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConstPCGGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConstPCGGraph_FunctionAddress, intPtr, GetConstPCGGraph_ParamsSize);
		return UObjectMarshaler<UPCGGraph>.FromNative(IntPtr.Add(intPtr, GetConstPCGGraph_ReturnValue_Offset), 0, GetConstPCGGraph_ReturnValue_PropertyAddress.Address);
	}

	static UPCGGraphInterface()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGGraphInterface)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGGraphInterface));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGGraphInterface");
		GetMutablePCGGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMutablePCGGraph");
		GetMutablePCGGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMutablePCGGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMutablePCGGraph_ReturnValue_PropertyAddress, GetMutablePCGGraph_FunctionAddress, "ReturnValue");
		GetMutablePCGGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMutablePCGGraph_FunctionAddress, "ReturnValue");
		GetMutablePCGGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMutablePCGGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMutablePCGGraph_IsValid = GetMutablePCGGraph_FunctionAddress != IntPtr.Zero && GetMutablePCGGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphInterface:GetMutablePCGGraph", GetMutablePCGGraph_IsValid);
		GetConstPCGGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetConstPCGGraph");
		GetConstPCGGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConstPCGGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConstPCGGraph_ReturnValue_PropertyAddress, GetConstPCGGraph_FunctionAddress, "ReturnValue");
		GetConstPCGGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConstPCGGraph_FunctionAddress, "ReturnValue");
		GetConstPCGGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConstPCGGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetConstPCGGraph_IsValid = GetConstPCGGraph_FunctionAddress != IntPtr.Zero && GetConstPCGGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGGraphInterface:GetConstPCGGraph", GetConstPCGGraph_IsValid);
	}
}
