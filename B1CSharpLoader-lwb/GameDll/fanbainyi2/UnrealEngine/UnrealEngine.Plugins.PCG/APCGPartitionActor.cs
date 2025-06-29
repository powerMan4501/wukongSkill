using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818414244uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPartitionActor", "PCG", UnrealModuleType.EnginePlugin)]
public class APCGPartitionActor : APartitionActor
{
	private static bool GetOriginalComponent_IsValid;

	private static IntPtr GetOriginalComponent_FunctionAddress;

	private static int GetOriginalComponent_ParamsSize;

	private static bool GetOriginalComponent_LocalComponent_IsValid;

	private static FFieldAddress GetOriginalComponent_LocalComponent_PropertyAddress;

	private static int GetOriginalComponent_LocalComponent_Offset;

	private static bool GetOriginalComponent_ReturnValue_IsValid;

	private static FFieldAddress GetOriginalComponent_ReturnValue_PropertyAddress;

	private static int GetOriginalComponent_ReturnValue_Offset;

	private static bool GetLocalComponent_IsValid;

	private static IntPtr GetLocalComponent_FunctionAddress;

	private static int GetLocalComponent_ParamsSize;

	private static bool GetLocalComponent_OriginalComponent_IsValid;

	private static FFieldAddress GetLocalComponent_OriginalComponent_PropertyAddress;

	private static int GetLocalComponent_OriginalComponent_Offset;

	private static bool GetLocalComponent_ReturnValue_IsValid;

	private static FFieldAddress GetLocalComponent_ReturnValue_PropertyAddress;

	private static int GetLocalComponent_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGPartitionActor:GetOriginalComponent")]
	public unsafe UPCGComponent GetOriginalComponent(UPCGComponent LocalComponent)
	{
		CheckDestroyed();
		if (!GetOriginalComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPartitionActor:GetOriginalComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOriginalComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOriginalComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGComponent>.ToNative(IntPtr.Add(intPtr, GetOriginalComponent_LocalComponent_Offset), 0, GetOriginalComponent_LocalComponent_PropertyAddress.Address, LocalComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOriginalComponent_FunctionAddress, intPtr, GetOriginalComponent_ParamsSize);
		return UObjectMarshaler<UPCGComponent>.FromNative(IntPtr.Add(intPtr, GetOriginalComponent_ReturnValue_Offset), 0, GetOriginalComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGPartitionActor:GetLocalComponent")]
	public unsafe UPCGComponent GetLocalComponent(UPCGComponent OriginalComponent)
	{
		CheckDestroyed();
		if (!GetLocalComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPartitionActor:GetLocalComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGComponent>.ToNative(IntPtr.Add(intPtr, GetLocalComponent_OriginalComponent_Offset), 0, GetLocalComponent_OriginalComponent_PropertyAddress.Address, OriginalComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalComponent_FunctionAddress, intPtr, GetLocalComponent_ParamsSize);
		return UObjectMarshaler<UPCGComponent>.FromNative(IntPtr.Add(intPtr, GetLocalComponent_ReturnValue_Offset), 0, GetLocalComponent_ReturnValue_PropertyAddress.Address);
	}

	static APCGPartitionActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APCGPartitionActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APCGPartitionActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGPartitionActor");
		GetOriginalComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOriginalComponent");
		GetOriginalComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOriginalComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOriginalComponent_LocalComponent_PropertyAddress, GetOriginalComponent_FunctionAddress, "LocalComponent");
		GetOriginalComponent_LocalComponent_Offset = NativeReflectionCached.GetPropertyOffset(GetOriginalComponent_FunctionAddress, "LocalComponent");
		GetOriginalComponent_LocalComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOriginalComponent_FunctionAddress, "LocalComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOriginalComponent_ReturnValue_PropertyAddress, GetOriginalComponent_FunctionAddress, "ReturnValue");
		GetOriginalComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOriginalComponent_FunctionAddress, "ReturnValue");
		GetOriginalComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOriginalComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOriginalComponent_IsValid = GetOriginalComponent_FunctionAddress != IntPtr.Zero && GetOriginalComponent_LocalComponent_IsValid && GetOriginalComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPartitionActor:GetOriginalComponent", GetOriginalComponent_IsValid);
		GetLocalComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLocalComponent");
		GetLocalComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalComponent_OriginalComponent_PropertyAddress, GetLocalComponent_FunctionAddress, "OriginalComponent");
		GetLocalComponent_OriginalComponent_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalComponent_FunctionAddress, "OriginalComponent");
		GetLocalComponent_OriginalComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalComponent_FunctionAddress, "OriginalComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalComponent_ReturnValue_PropertyAddress, GetLocalComponent_FunctionAddress, "ReturnValue");
		GetLocalComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalComponent_FunctionAddress, "ReturnValue");
		GetLocalComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLocalComponent_IsValid = GetLocalComponent_FunctionAddress != IntPtr.Zero && GetLocalComponent_OriginalComponent_IsValid && GetLocalComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPartitionActor:GetLocalComponent", GetLocalComponent_IsValid);
	}
}
