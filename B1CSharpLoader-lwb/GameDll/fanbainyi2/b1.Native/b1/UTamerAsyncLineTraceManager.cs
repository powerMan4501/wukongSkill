using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.TamerAsyncLineTraceManager", "UnrealExtent", UnrealModuleType.Game)]
public class UTamerAsyncLineTraceManager : UObject
{
	private static bool UnregisterTamerRef_IsValid;

	private static IntPtr UnregisterTamerRef_FunctionAddress;

	private static int UnregisterTamerRef_ParamsSize;

	private static bool UnregisterTamerRef_InRefID_IsValid;

	private static FFieldAddress UnregisterTamerRef_InRefID_PropertyAddress;

	private static int UnregisterTamerRef_InRefID_Offset;

	private static bool StartAsyncLineTrace_IsValid;

	private static IntPtr StartAsyncLineTrace_FunctionAddress;

	private static int StartAsyncLineTrace_ParamsSize;

	private static bool StartAsyncLineTrace_InPlayerLocation_IsValid;

	private static FFieldAddress StartAsyncLineTrace_InPlayerLocation_PropertyAddress;

	private static int StartAsyncLineTrace_InPlayerLocation_Offset;

	private static bool StartAsyncLineTrace_InTraceTamers_IsValid;

	private static FFieldAddress StartAsyncLineTrace_InTraceTamers_PropertyAddress;

	private static int StartAsyncLineTrace_InTraceTamers_Offset;

	private static bool RegisterTamerRef_IsValid;

	private static IntPtr RegisterTamerRef_FunctionAddress;

	private static int RegisterTamerRef_ParamsSize;

	private static bool RegisterTamerRef_InRefID_IsValid;

	private static FFieldAddress RegisterTamerRef_InRefID_PropertyAddress;

	private static int RegisterTamerRef_InRefID_Offset;

	private static bool RegisterTamerRef_InLocation_IsValid;

	private static FFieldAddress RegisterTamerRef_InLocation_PropertyAddress;

	private static int RegisterTamerRef_InLocation_Offset;

	private static bool RegisterTamerRef_InCapsuleHalfHeight_IsValid;

	private static FFieldAddress RegisterTamerRef_InCapsuleHalfHeight_PropertyAddress;

	private static int RegisterTamerRef_InCapsuleHalfHeight_Offset;

	private static bool GetAndCleanAsyncLineTraceResult_IsValid;

	private static IntPtr GetAndCleanAsyncLineTraceResult_FunctionAddress;

	private static int GetAndCleanAsyncLineTraceResult_ParamsSize;

	private static bool GetAndCleanAsyncLineTraceResult_OutVisibleTamers_IsValid;

	private static FFieldAddress GetAndCleanAsyncLineTraceResult_OutVisibleTamers_PropertyAddress;

	private static int GetAndCleanAsyncLineTraceResult_OutVisibleTamers_Offset;

	private static bool GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_IsValid;

	private static FFieldAddress GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_PropertyAddress;

	private static int GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_Offset;

	private static bool GetAndCleanAsyncLineTraceResult_ReturnValue_IsValid;

	private static FFieldAddress GetAndCleanAsyncLineTraceResult_ReturnValue_PropertyAddress;

	private static int GetAndCleanAsyncLineTraceResult_ReturnValue_Offset;

	private static bool ClearAllData_IsValid;

	private static IntPtr ClearAllData_FunctionAddress;

	private static int ClearAllData_ParamsSize;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.TamerAsyncLineTraceManager:UnregisterTamerRef")]
	public unsafe void UnregisterTamerRef(int InRefID)
	{
		CheckDestroyed();
		if (!UnregisterTamerRef_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.TamerAsyncLineTraceManager:UnregisterTamerRef");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterTamerRef_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterTamerRef_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UnregisterTamerRef_InRefID_Offset), 0, UnregisterTamerRef_InRefID_PropertyAddress.Address, InRefID);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterTamerRef_FunctionAddress, intPtr, UnregisterTamerRef_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.TamerAsyncLineTraceManager:StartAsyncLineTrace")]
	public unsafe void StartAsyncLineTrace(FVector InPlayerLocation, List<int> InTraceTamers)
	{
		CheckDestroyed();
		if (!StartAsyncLineTrace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.TamerAsyncLineTraceManager:StartAsyncLineTrace");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartAsyncLineTrace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartAsyncLineTrace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, StartAsyncLineTrace_InPlayerLocation_Offset), 0, StartAsyncLineTrace_InPlayerLocation_PropertyAddress.Address, InPlayerLocation);
		new TArrayCopyMarshaler<int>(1, StartAsyncLineTrace_InTraceTamers_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, StartAsyncLineTrace_InTraceTamers_Offset), InTraceTamers);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartAsyncLineTrace_FunctionAddress, intPtr, StartAsyncLineTrace_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartAsyncLineTrace_InTraceTamers_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.TamerAsyncLineTraceManager:RegisterTamerRef")]
	public unsafe void RegisterTamerRef(int InRefID, FVector InLocation, float InCapsuleHalfHeight)
	{
		CheckDestroyed();
		if (!RegisterTamerRef_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.TamerAsyncLineTraceManager:RegisterTamerRef");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterTamerRef_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterTamerRef_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RegisterTamerRef_InRefID_Offset), 0, RegisterTamerRef_InRefID_PropertyAddress.Address, InRefID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RegisterTamerRef_InLocation_Offset), 0, RegisterTamerRef_InLocation_PropertyAddress.Address, InLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RegisterTamerRef_InCapsuleHalfHeight_Offset), 0, RegisterTamerRef_InCapsuleHalfHeight_PropertyAddress.Address, InCapsuleHalfHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterTamerRef_FunctionAddress, intPtr, RegisterTamerRef_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.TamerAsyncLineTraceManager:GetAndCleanAsyncLineTraceResult")]
	public unsafe bool GetAndCleanAsyncLineTraceResult(out List<int> OutVisibleTamers, out List<int> OutInvisibleTamers)
	{
		CheckDestroyed();
		if (!GetAndCleanAsyncLineTraceResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.TamerAsyncLineTraceManager:GetAndCleanAsyncLineTraceResult");
			OutVisibleTamers = null;
			OutInvisibleTamers = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAndCleanAsyncLineTraceResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAndCleanAsyncLineTraceResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAndCleanAsyncLineTraceResult_FunctionAddress, intPtr, GetAndCleanAsyncLineTraceResult_ParamsSize);
		OutVisibleTamers = new TArrayCopyMarshaler<int>(1, GetAndCleanAsyncLineTraceResult_OutVisibleTamers_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAndCleanAsyncLineTraceResult_OutVisibleTamers_Offset));
		NativeReflection.DestroyValue_InContainer(GetAndCleanAsyncLineTraceResult_OutVisibleTamers_PropertyAddress.Address, intPtr);
		OutInvisibleTamers = new TArrayCopyMarshaler<int>(1, GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_Offset));
		NativeReflection.DestroyValue_InContainer(GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAndCleanAsyncLineTraceResult_ReturnValue_Offset), 0, GetAndCleanAsyncLineTraceResult_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.TamerAsyncLineTraceManager:ClearAllData")]
	public unsafe void ClearAllData()
	{
		CheckDestroyed();
		if (!ClearAllData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.TamerAsyncLineTraceManager:ClearAllData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAllData_FunctionAddress, argsSize: ClearAllData_ParamsSize);
	}

	static UTamerAsyncLineTraceManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTamerAsyncLineTraceManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTamerAsyncLineTraceManager));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.TamerAsyncLineTraceManager");
		UnregisterTamerRef_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UnregisterTamerRef");
		UnregisterTamerRef_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterTamerRef_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterTamerRef_InRefID_PropertyAddress, UnregisterTamerRef_FunctionAddress, "InRefID");
		UnregisterTamerRef_InRefID_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterTamerRef_FunctionAddress, "InRefID");
		UnregisterTamerRef_InRefID_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterTamerRef_FunctionAddress, "InRefID", Classes.FIntProperty);
		UnregisterTamerRef_IsValid = UnregisterTamerRef_FunctionAddress != IntPtr.Zero && UnregisterTamerRef_InRefID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.TamerAsyncLineTraceManager:UnregisterTamerRef", UnregisterTamerRef_IsValid);
		StartAsyncLineTrace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartAsyncLineTrace");
		StartAsyncLineTrace_ParamsSize = NativeReflection.GetFunctionParamsSize(StartAsyncLineTrace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartAsyncLineTrace_InPlayerLocation_PropertyAddress, StartAsyncLineTrace_FunctionAddress, "InPlayerLocation");
		StartAsyncLineTrace_InPlayerLocation_Offset = NativeReflectionCached.GetPropertyOffset(StartAsyncLineTrace_FunctionAddress, "InPlayerLocation");
		StartAsyncLineTrace_InPlayerLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAsyncLineTrace_FunctionAddress, "InPlayerLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAsyncLineTrace_InTraceTamers_PropertyAddress, StartAsyncLineTrace_FunctionAddress, "InTraceTamers");
		StartAsyncLineTrace_InTraceTamers_Offset = NativeReflectionCached.GetPropertyOffset(StartAsyncLineTrace_FunctionAddress, "InTraceTamers");
		StartAsyncLineTrace_InTraceTamers_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAsyncLineTrace_FunctionAddress, "InTraceTamers", Classes.FArrayProperty);
		StartAsyncLineTrace_IsValid = StartAsyncLineTrace_FunctionAddress != IntPtr.Zero && StartAsyncLineTrace_InPlayerLocation_IsValid && StartAsyncLineTrace_InTraceTamers_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.TamerAsyncLineTraceManager:StartAsyncLineTrace", StartAsyncLineTrace_IsValid);
		RegisterTamerRef_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterTamerRef");
		RegisterTamerRef_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterTamerRef_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterTamerRef_InRefID_PropertyAddress, RegisterTamerRef_FunctionAddress, "InRefID");
		RegisterTamerRef_InRefID_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTamerRef_FunctionAddress, "InRefID");
		RegisterTamerRef_InRefID_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTamerRef_FunctionAddress, "InRefID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterTamerRef_InLocation_PropertyAddress, RegisterTamerRef_FunctionAddress, "InLocation");
		RegisterTamerRef_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTamerRef_FunctionAddress, "InLocation");
		RegisterTamerRef_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTamerRef_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterTamerRef_InCapsuleHalfHeight_PropertyAddress, RegisterTamerRef_FunctionAddress, "InCapsuleHalfHeight");
		RegisterTamerRef_InCapsuleHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(RegisterTamerRef_FunctionAddress, "InCapsuleHalfHeight");
		RegisterTamerRef_InCapsuleHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterTamerRef_FunctionAddress, "InCapsuleHalfHeight", Classes.FFloatProperty);
		RegisterTamerRef_IsValid = RegisterTamerRef_FunctionAddress != IntPtr.Zero && RegisterTamerRef_InRefID_IsValid && RegisterTamerRef_InLocation_IsValid && RegisterTamerRef_InCapsuleHalfHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.TamerAsyncLineTraceManager:RegisterTamerRef", RegisterTamerRef_IsValid);
		GetAndCleanAsyncLineTraceResult_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAndCleanAsyncLineTraceResult");
		GetAndCleanAsyncLineTraceResult_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAndCleanAsyncLineTraceResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAndCleanAsyncLineTraceResult_OutVisibleTamers_PropertyAddress, GetAndCleanAsyncLineTraceResult_FunctionAddress, "OutVisibleTamers");
		GetAndCleanAsyncLineTraceResult_OutVisibleTamers_Offset = NativeReflectionCached.GetPropertyOffset(GetAndCleanAsyncLineTraceResult_FunctionAddress, "OutVisibleTamers");
		GetAndCleanAsyncLineTraceResult_OutVisibleTamers_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAndCleanAsyncLineTraceResult_FunctionAddress, "OutVisibleTamers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_PropertyAddress, GetAndCleanAsyncLineTraceResult_FunctionAddress, "OutInvisibleTamers");
		GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_Offset = NativeReflectionCached.GetPropertyOffset(GetAndCleanAsyncLineTraceResult_FunctionAddress, "OutInvisibleTamers");
		GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAndCleanAsyncLineTraceResult_FunctionAddress, "OutInvisibleTamers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAndCleanAsyncLineTraceResult_ReturnValue_PropertyAddress, GetAndCleanAsyncLineTraceResult_FunctionAddress, "ReturnValue");
		GetAndCleanAsyncLineTraceResult_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAndCleanAsyncLineTraceResult_FunctionAddress, "ReturnValue");
		GetAndCleanAsyncLineTraceResult_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAndCleanAsyncLineTraceResult_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAndCleanAsyncLineTraceResult_IsValid = GetAndCleanAsyncLineTraceResult_FunctionAddress != IntPtr.Zero && GetAndCleanAsyncLineTraceResult_OutVisibleTamers_IsValid && GetAndCleanAsyncLineTraceResult_OutInvisibleTamers_IsValid && GetAndCleanAsyncLineTraceResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.TamerAsyncLineTraceManager:GetAndCleanAsyncLineTraceResult", GetAndCleanAsyncLineTraceResult_IsValid);
		ClearAllData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearAllData");
		ClearAllData_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllData_FunctionAddress);
		ClearAllData_IsValid = ClearAllData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.TamerAsyncLineTraceManager:ClearAllData", ClearAllData_IsValid);
	}
}
