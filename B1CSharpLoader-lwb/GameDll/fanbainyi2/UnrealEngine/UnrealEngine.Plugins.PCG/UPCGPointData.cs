using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPointData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPointData : UPCGSpatialData
{
	private static bool SetPoints_IsValid;

	private static IntPtr SetPoints_FunctionAddress;

	private static int SetPoints_ParamsSize;

	private static bool SetPoints_InPoints_IsValid;

	private static FFieldAddress SetPoints_InPoints_PropertyAddress;

	private static int SetPoints_InPoints_Offset;

	private static bool GetPoints_IsValid;

	private static IntPtr GetPoints_FunctionAddress;

	private static int GetPoints_ParamsSize;

	private static bool GetPoints_ReturnValue_IsValid;

	private static FFieldAddress GetPoints_ReturnValue_PropertyAddress;

	private static int GetPoints_ReturnValue_Offset;

	private static bool GetPoint_IsValid;

	private static IntPtr GetPoint_FunctionAddress;

	private static int GetPoint_ParamsSize;

	private static bool GetPoint_Index_IsValid;

	private static FFieldAddress GetPoint_Index_PropertyAddress;

	private static int GetPoint_Index_Offset;

	private static bool GetPoint_ReturnValue_IsValid;

	private static FFieldAddress GetPoint_ReturnValue_PropertyAddress;

	private static int GetPoint_ReturnValue_Offset;

	private static bool CopyPointsFrom_IsValid;

	private static IntPtr CopyPointsFrom_FunctionAddress;

	private static int CopyPointsFrom_ParamsSize;

	private static bool CopyPointsFrom_InData_IsValid;

	private static FFieldAddress CopyPointsFrom_InData_PropertyAddress;

	private static int CopyPointsFrom_InData_Offset;

	private static bool CopyPointsFrom_InDataIndices_IsValid;

	private static FFieldAddress CopyPointsFrom_InDataIndices_PropertyAddress;

	private static int CopyPointsFrom_InDataIndices_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGPointData:SetPoints")]
	public unsafe void SetPoints(List<FPCGPoint> InPoints)
	{
		CheckDestroyed();
		if (!SetPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPointData:SetPoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FPCGPoint>(1, SetPoints_InPoints_PropertyAddress, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.FromNative, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.ToNative).ToNative(IntPtr.Add(intPtr, SetPoints_InPoints_Offset), InPoints);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPoints_FunctionAddress, intPtr, SetPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPoints_InPoints_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGPointData:GetPoints")]
	public unsafe List<FPCGPoint> GetPoints()
	{
		CheckDestroyed();
		if (!GetPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPointData:GetPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPoints_FunctionAddress, intPtr, GetPoints_ParamsSize);
		List<FPCGPoint> result = new TArrayCopyMarshaler<FPCGPoint>(1, GetPoints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.FromNative, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.ToNative).FromNative(IntPtr.Add(intPtr, GetPoints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPoints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGPointData:GetPoint")]
	public unsafe FPCGPoint GetPoint(int Index)
	{
		CheckDestroyed();
		if (!GetPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPointData:GetPoint");
			return default(FPCGPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPoint_Index_Offset), 0, GetPoint_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPoint_FunctionAddress, intPtr, GetPoint_ParamsSize);
		return FPCGPoint.FromNative(IntPtr.Add(intPtr, GetPoint_ReturnValue_Offset), 0, GetPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGPointData:CopyPointsFrom")]
	public unsafe void CopyPointsFrom(UPCGPointData InData, List<int> InDataIndices)
	{
		CheckDestroyed();
		if (!CopyPointsFrom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPointData:CopyPointsFrom");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPointsFrom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPointsFrom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, CopyPointsFrom_InData_Offset), 0, CopyPointsFrom_InData_PropertyAddress.Address, InData);
		new TArrayCopyMarshaler<int>(1, CopyPointsFrom_InDataIndices_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, CopyPointsFrom_InDataIndices_Offset), InDataIndices);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyPointsFrom_FunctionAddress, intPtr, CopyPointsFrom_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyPointsFrom_InDataIndices_PropertyAddress.Address, intPtr);
	}

	static UPCGPointData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPointData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPointData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGPointData");
		SetPoints_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPoints");
		SetPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPoints_InPoints_PropertyAddress, SetPoints_FunctionAddress, "InPoints");
		SetPoints_InPoints_Offset = NativeReflectionCached.GetPropertyOffset(SetPoints_FunctionAddress, "InPoints");
		SetPoints_InPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPoints_FunctionAddress, "InPoints", Classes.FArrayProperty);
		SetPoints_IsValid = SetPoints_FunctionAddress != IntPtr.Zero && SetPoints_InPoints_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPointData:SetPoints", SetPoints_IsValid);
		GetPoints_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPoints");
		GetPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPoints_ReturnValue_PropertyAddress, GetPoints_FunctionAddress, "ReturnValue");
		GetPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPoints_FunctionAddress, "ReturnValue");
		GetPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPoints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPoints_IsValid = GetPoints_FunctionAddress != IntPtr.Zero && GetPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPointData:GetPoints", GetPoints_IsValid);
		GetPoint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPoint");
		GetPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPoint_Index_PropertyAddress, GetPoint_FunctionAddress, "Index");
		GetPoint_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetPoint_FunctionAddress, "Index");
		GetPoint_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPoint_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPoint_ReturnValue_PropertyAddress, GetPoint_FunctionAddress, "ReturnValue");
		GetPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPoint_FunctionAddress, "ReturnValue");
		GetPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPoint_IsValid = GetPoint_FunctionAddress != IntPtr.Zero && GetPoint_Index_IsValid && GetPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPointData:GetPoint", GetPoint_IsValid);
		CopyPointsFrom_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyPointsFrom");
		CopyPointsFrom_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPointsFrom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPointsFrom_InData_PropertyAddress, CopyPointsFrom_FunctionAddress, "InData");
		CopyPointsFrom_InData_Offset = NativeReflectionCached.GetPropertyOffset(CopyPointsFrom_FunctionAddress, "InData");
		CopyPointsFrom_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPointsFrom_FunctionAddress, "InData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPointsFrom_InDataIndices_PropertyAddress, CopyPointsFrom_FunctionAddress, "InDataIndices");
		CopyPointsFrom_InDataIndices_Offset = NativeReflectionCached.GetPropertyOffset(CopyPointsFrom_FunctionAddress, "InDataIndices");
		CopyPointsFrom_InDataIndices_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPointsFrom_FunctionAddress, "InDataIndices", Classes.FArrayProperty);
		CopyPointsFrom_IsValid = CopyPointsFrom_FunctionAddress != IntPtr.Zero && CopyPointsFrom_InData_IsValid && CopyPointsFrom_InDataIndices_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPointData:CopyPointsFrom", CopyPointsFrom_IsValid);
	}
}
