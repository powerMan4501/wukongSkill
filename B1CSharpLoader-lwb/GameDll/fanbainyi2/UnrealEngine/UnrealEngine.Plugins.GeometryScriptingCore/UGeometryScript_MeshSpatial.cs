using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshSpatial : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ResetBVH_IsValid;

	private static IntPtr ResetBVH_FunctionAddress;

	private static int ResetBVH_ParamsSize;

	private static bool ResetBVH_ResetBVH_IsValid;

	private static FFieldAddress ResetBVH_ResetBVH_PropertyAddress;

	private static int ResetBVH_ResetBVH_Offset;

	private static bool RebuildBVHForMesh_IsValid;

	private static IntPtr RebuildBVHForMesh_FunctionAddress;

	private static int RebuildBVHForMesh_ParamsSize;

	private static bool RebuildBVHForMesh_TargetMesh_IsValid;

	private static FFieldAddress RebuildBVHForMesh_TargetMesh_PropertyAddress;

	private static int RebuildBVHForMesh_TargetMesh_Offset;

	private static bool RebuildBVHForMesh_UpdateBVH_IsValid;

	private static FFieldAddress RebuildBVHForMesh_UpdateBVH_PropertyAddress;

	private static int RebuildBVHForMesh_UpdateBVH_Offset;

	private static bool RebuildBVHForMesh_bOnlyIfInvalid_IsValid;

	private static FFieldAddress RebuildBVHForMesh_bOnlyIfInvalid_PropertyAddress;

	private static int RebuildBVHForMesh_bOnlyIfInvalid_Offset;

	private static bool RebuildBVHForMesh_Debug_IsValid;

	private static FFieldAddress RebuildBVHForMesh_Debug_PropertyAddress;

	private static int RebuildBVHForMesh_Debug_Offset;

	private static bool RebuildBVHForMesh_ReturnValue_IsValid;

	private static FFieldAddress RebuildBVHForMesh_ReturnValue_PropertyAddress;

	private static int RebuildBVHForMesh_ReturnValue_Offset;

	private static bool IsPointInsideMesh_IsValid;

	private static IntPtr IsPointInsideMesh_FunctionAddress;

	private static int IsPointInsideMesh_ParamsSize;

	private static bool IsPointInsideMesh_TargetMesh_IsValid;

	private static FFieldAddress IsPointInsideMesh_TargetMesh_PropertyAddress;

	private static int IsPointInsideMesh_TargetMesh_Offset;

	private static bool IsPointInsideMesh_QueryBVH_IsValid;

	private static FFieldAddress IsPointInsideMesh_QueryBVH_PropertyAddress;

	private static int IsPointInsideMesh_QueryBVH_Offset;

	private static bool IsPointInsideMesh_QueryPoint_IsValid;

	private static FFieldAddress IsPointInsideMesh_QueryPoint_PropertyAddress;

	private static int IsPointInsideMesh_QueryPoint_Offset;

	private static bool IsPointInsideMesh_Options_IsValid;

	private static FFieldAddress IsPointInsideMesh_Options_PropertyAddress;

	private static int IsPointInsideMesh_Options_Offset;

	private static bool IsPointInsideMesh_bIsInside_IsValid;

	private static FFieldAddress IsPointInsideMesh_bIsInside_PropertyAddress;

	private static int IsPointInsideMesh_bIsInside_Offset;

	private static bool IsPointInsideMesh_Outcome_IsValid;

	private static FFieldAddress IsPointInsideMesh_Outcome_PropertyAddress;

	private static int IsPointInsideMesh_Outcome_Offset;

	private static bool IsPointInsideMesh_Debug_IsValid;

	private static FFieldAddress IsPointInsideMesh_Debug_PropertyAddress;

	private static int IsPointInsideMesh_Debug_Offset;

	private static bool IsPointInsideMesh_ReturnValue_IsValid;

	private static FFieldAddress IsPointInsideMesh_ReturnValue_PropertyAddress;

	private static int IsPointInsideMesh_ReturnValue_Offset;

	private static bool IsBVHValidForMesh_IsValid;

	private static IntPtr IsBVHValidForMesh_FunctionAddress;

	private static int IsBVHValidForMesh_ParamsSize;

	private static bool IsBVHValidForMesh_TargetMesh_IsValid;

	private static FFieldAddress IsBVHValidForMesh_TargetMesh_PropertyAddress;

	private static int IsBVHValidForMesh_TargetMesh_Offset;

	private static bool IsBVHValidForMesh_TestBVH_IsValid;

	private static FFieldAddress IsBVHValidForMesh_TestBVH_PropertyAddress;

	private static int IsBVHValidForMesh_TestBVH_Offset;

	private static bool IsBVHValidForMesh_bIsValid_IsValid;

	private static FFieldAddress IsBVHValidForMesh_bIsValid_PropertyAddress;

	private static int IsBVHValidForMesh_bIsValid_Offset;

	private static bool IsBVHValidForMesh_Debug_IsValid;

	private static FFieldAddress IsBVHValidForMesh_Debug_PropertyAddress;

	private static int IsBVHValidForMesh_Debug_Offset;

	private static bool IsBVHValidForMesh_ReturnValue_IsValid;

	private static FFieldAddress IsBVHValidForMesh_ReturnValue_PropertyAddress;

	private static int IsBVHValidForMesh_ReturnValue_Offset;

	private static bool FindNearestRayIntersectionWithMesh_IsValid;

	private static IntPtr FindNearestRayIntersectionWithMesh_FunctionAddress;

	private static int FindNearestRayIntersectionWithMesh_ParamsSize;

	private static bool FindNearestRayIntersectionWithMesh_TargetMesh_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_TargetMesh_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_TargetMesh_Offset;

	private static bool FindNearestRayIntersectionWithMesh_QueryBVH_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_QueryBVH_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_QueryBVH_Offset;

	private static bool FindNearestRayIntersectionWithMesh_RayOrigin_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_RayOrigin_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_RayOrigin_Offset;

	private static bool FindNearestRayIntersectionWithMesh_RayDirection_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_RayDirection_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_RayDirection_Offset;

	private static bool FindNearestRayIntersectionWithMesh_Options_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_Options_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_Options_Offset;

	private static bool FindNearestRayIntersectionWithMesh_HitResult_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_HitResult_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_HitResult_Offset;

	private static bool FindNearestRayIntersectionWithMesh_Outcome_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_Outcome_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_Outcome_Offset;

	private static bool FindNearestRayIntersectionWithMesh_Debug_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_Debug_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_Debug_Offset;

	private static bool FindNearestRayIntersectionWithMesh_ReturnValue_IsValid;

	private static FFieldAddress FindNearestRayIntersectionWithMesh_ReturnValue_PropertyAddress;

	private static int FindNearestRayIntersectionWithMesh_ReturnValue_Offset;

	private static bool FindNearestPointOnMesh_IsValid;

	private static IntPtr FindNearestPointOnMesh_FunctionAddress;

	private static int FindNearestPointOnMesh_ParamsSize;

	private static bool FindNearestPointOnMesh_TargetMesh_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_TargetMesh_PropertyAddress;

	private static int FindNearestPointOnMesh_TargetMesh_Offset;

	private static bool FindNearestPointOnMesh_QueryBVH_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_QueryBVH_PropertyAddress;

	private static int FindNearestPointOnMesh_QueryBVH_Offset;

	private static bool FindNearestPointOnMesh_QueryPoint_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_QueryPoint_PropertyAddress;

	private static int FindNearestPointOnMesh_QueryPoint_Offset;

	private static bool FindNearestPointOnMesh_Options_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_Options_PropertyAddress;

	private static int FindNearestPointOnMesh_Options_Offset;

	private static bool FindNearestPointOnMesh_NearestResult_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_NearestResult_PropertyAddress;

	private static int FindNearestPointOnMesh_NearestResult_Offset;

	private static bool FindNearestPointOnMesh_Outcome_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_Outcome_PropertyAddress;

	private static int FindNearestPointOnMesh_Outcome_Offset;

	private static bool FindNearestPointOnMesh_Debug_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_Debug_PropertyAddress;

	private static int FindNearestPointOnMesh_Debug_Offset;

	private static bool FindNearestPointOnMesh_ReturnValue_IsValid;

	private static FFieldAddress FindNearestPointOnMesh_ReturnValue_PropertyAddress;

	private static int FindNearestPointOnMesh_ReturnValue_Offset;

	private static bool BuildBVHForMesh_IsValid;

	private static IntPtr BuildBVHForMesh_FunctionAddress;

	private static int BuildBVHForMesh_ParamsSize;

	private static bool BuildBVHForMesh_TargetMesh_IsValid;

	private static FFieldAddress BuildBVHForMesh_TargetMesh_PropertyAddress;

	private static int BuildBVHForMesh_TargetMesh_Offset;

	private static bool BuildBVHForMesh_OutputBVH_IsValid;

	private static FFieldAddress BuildBVHForMesh_OutputBVH_PropertyAddress;

	private static int BuildBVHForMesh_OutputBVH_Offset;

	private static bool BuildBVHForMesh_Debug_IsValid;

	private static FFieldAddress BuildBVHForMesh_Debug_PropertyAddress;

	private static int BuildBVHForMesh_Debug_Offset;

	private static bool BuildBVHForMesh_ReturnValue_IsValid;

	private static FFieldAddress BuildBVHForMesh_ReturnValue_PropertyAddress;

	private static int BuildBVHForMesh_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:ResetBVH")]
	public unsafe static void ResetBVH(ref FGeometryScriptDynamicMeshBVH ResetBVH)
	{
		if (!ResetBVH_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:ResetBVH");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetBVH_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetBVH_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ResetBVH_ResetBVH_PropertyAddress.Address, intPtr);
		FGeometryScriptDynamicMeshBVH.ToNative(IntPtr.Add(intPtr, ResetBVH_ResetBVH_Offset), 0, ResetBVH_ResetBVH_PropertyAddress.Address, ResetBVH);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetBVH_FunctionAddress, intPtr, ResetBVH_ParamsSize);
		ResetBVH = FGeometryScriptDynamicMeshBVH.FromNative(IntPtr.Add(intPtr, ResetBVH_ResetBVH_Offset), 0, ResetBVH_ResetBVH_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ResetBVH_ResetBVH_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:RebuildBVHForMesh")]
	public unsafe static UDynamicMesh RebuildBVHForMesh(UDynamicMesh TargetMesh, ref FGeometryScriptDynamicMeshBVH UpdateBVH, bool bOnlyIfInvalid, UGeometryScriptDebug Debug)
	{
		if (!RebuildBVHForMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:RebuildBVHForMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RebuildBVHForMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RebuildBVHForMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RebuildBVHForMesh_TargetMesh_Offset), 0, RebuildBVHForMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(RebuildBVHForMesh_UpdateBVH_PropertyAddress.Address, intPtr);
		FGeometryScriptDynamicMeshBVH.ToNative(IntPtr.Add(intPtr, RebuildBVHForMesh_UpdateBVH_Offset), 0, RebuildBVHForMesh_UpdateBVH_PropertyAddress.Address, UpdateBVH);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RebuildBVHForMesh_bOnlyIfInvalid_Offset), 0, RebuildBVHForMesh_bOnlyIfInvalid_PropertyAddress.Address, bOnlyIfInvalid);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RebuildBVHForMesh_Debug_Offset), 0, RebuildBVHForMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RebuildBVHForMesh_FunctionAddress, intPtr, RebuildBVHForMesh_ParamsSize);
		UpdateBVH = FGeometryScriptDynamicMeshBVH.FromNative(IntPtr.Add(intPtr, RebuildBVHForMesh_UpdateBVH_Offset), 0, RebuildBVHForMesh_UpdateBVH_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RebuildBVHForMesh_UpdateBVH_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RebuildBVHForMesh_ReturnValue_Offset), 0, RebuildBVHForMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:IsPointInsideMesh")]
	public unsafe static UDynamicMesh IsPointInsideMesh(UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH QueryBVH, FVector QueryPoint, FGeometryScriptSpatialQueryOptions Options, out bool bIsInside, out EGeometryScriptContainmentOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!IsPointInsideMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:IsPointInsideMesh");
			bIsInside = false;
			Outcome = EGeometryScriptContainmentOutcomePins.Inside;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPointInsideMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPointInsideMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsPointInsideMesh_TargetMesh_Offset), 0, IsPointInsideMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(IsPointInsideMesh_QueryBVH_PropertyAddress.Address, intPtr);
		FGeometryScriptDynamicMeshBVH.ToNative(IntPtr.Add(intPtr, IsPointInsideMesh_QueryBVH_Offset), 0, IsPointInsideMesh_QueryBVH_PropertyAddress.Address, QueryBVH);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsPointInsideMesh_QueryPoint_Offset), 0, IsPointInsideMesh_QueryPoint_PropertyAddress.Address, QueryPoint);
		NativeReflection.InitializeValue_InContainer(IsPointInsideMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSpatialQueryOptions.ToNative(IntPtr.Add(intPtr, IsPointInsideMesh_Options_Offset), 0, IsPointInsideMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, IsPointInsideMesh_Debug_Offset), 0, IsPointInsideMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPointInsideMesh_FunctionAddress, intPtr, IsPointInsideMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsPointInsideMesh_QueryBVH_PropertyAddress.Address, intPtr);
		bIsInside = BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPointInsideMesh_bIsInside_Offset), 0, IsPointInsideMesh_bIsInside_PropertyAddress.Address);
		Outcome = EnumMarshaler<EGeometryScriptContainmentOutcomePins>.FromNative(IntPtr.Add(intPtr, IsPointInsideMesh_Outcome_Offset), 0, IsPointInsideMesh_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, IsPointInsideMesh_ReturnValue_Offset), 0, IsPointInsideMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:IsBVHValidForMesh")]
	public unsafe static UDynamicMesh IsBVHValidForMesh(UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH TestBVH, out bool bIsValid, UGeometryScriptDebug Debug)
	{
		if (!IsBVHValidForMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:IsBVHValidForMesh");
			bIsValid = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBVHValidForMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBVHValidForMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsBVHValidForMesh_TargetMesh_Offset), 0, IsBVHValidForMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(IsBVHValidForMesh_TestBVH_PropertyAddress.Address, intPtr);
		FGeometryScriptDynamicMeshBVH.ToNative(IntPtr.Add(intPtr, IsBVHValidForMesh_TestBVH_Offset), 0, IsBVHValidForMesh_TestBVH_PropertyAddress.Address, TestBVH);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, IsBVHValidForMesh_Debug_Offset), 0, IsBVHValidForMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsBVHValidForMesh_FunctionAddress, intPtr, IsBVHValidForMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsBVHValidForMesh_TestBVH_PropertyAddress.Address, intPtr);
		bIsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBVHValidForMesh_bIsValid_Offset), 0, IsBVHValidForMesh_bIsValid_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, IsBVHValidForMesh_ReturnValue_Offset), 0, IsBVHValidForMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:FindNearestRayIntersectionWithMesh")]
	public unsafe static UDynamicMesh FindNearestRayIntersectionWithMesh(UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH QueryBVH, FVector RayOrigin, FVector RayDirection, FGeometryScriptSpatialQueryOptions Options, out FGeometryScriptRayHitResult HitResult, out EGeometryScriptSearchOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!FindNearestRayIntersectionWithMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:FindNearestRayIntersectionWithMesh");
			HitResult = default(FGeometryScriptRayHitResult);
			Outcome = EGeometryScriptSearchOutcomePins.Found;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNearestRayIntersectionWithMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNearestRayIntersectionWithMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_TargetMesh_Offset), 0, FindNearestRayIntersectionWithMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(FindNearestRayIntersectionWithMesh_QueryBVH_PropertyAddress.Address, intPtr);
		FGeometryScriptDynamicMeshBVH.ToNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_QueryBVH_Offset), 0, FindNearestRayIntersectionWithMesh_QueryBVH_PropertyAddress.Address, QueryBVH);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_RayOrigin_Offset), 0, FindNearestRayIntersectionWithMesh_RayOrigin_PropertyAddress.Address, RayOrigin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_RayDirection_Offset), 0, FindNearestRayIntersectionWithMesh_RayDirection_PropertyAddress.Address, RayDirection);
		NativeReflection.InitializeValue_InContainer(FindNearestRayIntersectionWithMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSpatialQueryOptions.ToNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_Options_Offset), 0, FindNearestRayIntersectionWithMesh_Options_PropertyAddress.Address, Options);
		NativeReflection.InitializeValue_InContainer(FindNearestRayIntersectionWithMesh_HitResult_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_Debug_Offset), 0, FindNearestRayIntersectionWithMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, intPtr, FindNearestRayIntersectionWithMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindNearestRayIntersectionWithMesh_QueryBVH_PropertyAddress.Address, intPtr);
		HitResult = FGeometryScriptRayHitResult.FromNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_HitResult_Offset), 0, FindNearestRayIntersectionWithMesh_HitResult_PropertyAddress.Address);
		Outcome = EnumMarshaler<EGeometryScriptSearchOutcomePins>.FromNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_Outcome_Offset), 0, FindNearestRayIntersectionWithMesh_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, FindNearestRayIntersectionWithMesh_ReturnValue_Offset), 0, FindNearestRayIntersectionWithMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:FindNearestPointOnMesh")]
	public unsafe static UDynamicMesh FindNearestPointOnMesh(UDynamicMesh TargetMesh, FGeometryScriptDynamicMeshBVH QueryBVH, FVector QueryPoint, FGeometryScriptSpatialQueryOptions Options, out FGeometryScriptTrianglePoint NearestResult, out EGeometryScriptSearchOutcomePins Outcome, UGeometryScriptDebug Debug)
	{
		if (!FindNearestPointOnMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:FindNearestPointOnMesh");
			NearestResult = default(FGeometryScriptTrianglePoint);
			Outcome = EGeometryScriptSearchOutcomePins.Found;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNearestPointOnMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNearestPointOnMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_TargetMesh_Offset), 0, FindNearestPointOnMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(FindNearestPointOnMesh_QueryBVH_PropertyAddress.Address, intPtr);
		FGeometryScriptDynamicMeshBVH.ToNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_QueryBVH_Offset), 0, FindNearestPointOnMesh_QueryBVH_PropertyAddress.Address, QueryBVH);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_QueryPoint_Offset), 0, FindNearestPointOnMesh_QueryPoint_PropertyAddress.Address, QueryPoint);
		NativeReflection.InitializeValue_InContainer(FindNearestPointOnMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSpatialQueryOptions.ToNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_Options_Offset), 0, FindNearestPointOnMesh_Options_PropertyAddress.Address, Options);
		NativeReflection.InitializeValue_InContainer(FindNearestPointOnMesh_NearestResult_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_Debug_Offset), 0, FindNearestPointOnMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindNearestPointOnMesh_FunctionAddress, intPtr, FindNearestPointOnMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindNearestPointOnMesh_QueryBVH_PropertyAddress.Address, intPtr);
		NearestResult = FGeometryScriptTrianglePoint.FromNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_NearestResult_Offset), 0, FindNearestPointOnMesh_NearestResult_PropertyAddress.Address);
		Outcome = EnumMarshaler<EGeometryScriptSearchOutcomePins>.FromNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_Outcome_Offset), 0, FindNearestPointOnMesh_Outcome_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, FindNearestPointOnMesh_ReturnValue_Offset), 0, FindNearestPointOnMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:BuildBVHForMesh")]
	public unsafe static UDynamicMesh BuildBVHForMesh(UDynamicMesh TargetMesh, out FGeometryScriptDynamicMeshBVH OutputBVH, UGeometryScriptDebug Debug)
	{
		if (!BuildBVHForMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:BuildBVHForMesh");
			OutputBVH = default(FGeometryScriptDynamicMeshBVH);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildBVHForMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildBVHForMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, BuildBVHForMesh_TargetMesh_Offset), 0, BuildBVHForMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(BuildBVHForMesh_OutputBVH_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, BuildBVHForMesh_Debug_Offset), 0, BuildBVHForMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildBVHForMesh_FunctionAddress, intPtr, BuildBVHForMesh_ParamsSize);
		OutputBVH = FGeometryScriptDynamicMeshBVH.FromNative(IntPtr.Add(intPtr, BuildBVHForMesh_OutputBVH_Offset), 0, BuildBVHForMesh_OutputBVH_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildBVHForMesh_OutputBVH_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, BuildBVHForMesh_ReturnValue_Offset), 0, BuildBVHForMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshSpatial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshSpatial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshSpatial));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial");
		ResetBVH_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetBVH");
		ResetBVH_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetBVH_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetBVH_ResetBVH_PropertyAddress, ResetBVH_FunctionAddress, "ResetBVH");
		ResetBVH_ResetBVH_Offset = NativeReflectionCached.GetPropertyOffset(ResetBVH_FunctionAddress, "ResetBVH");
		ResetBVH_ResetBVH_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetBVH_FunctionAddress, "ResetBVH", Classes.FStructProperty);
		ResetBVH_IsValid = ResetBVH_FunctionAddress != IntPtr.Zero && ResetBVH_ResetBVH_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:ResetBVH", ResetBVH_IsValid);
		RebuildBVHForMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RebuildBVHForMesh");
		RebuildBVHForMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(RebuildBVHForMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RebuildBVHForMesh_TargetMesh_PropertyAddress, RebuildBVHForMesh_FunctionAddress, "TargetMesh");
		RebuildBVHForMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RebuildBVHForMesh_FunctionAddress, "TargetMesh");
		RebuildBVHForMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildBVHForMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RebuildBVHForMesh_UpdateBVH_PropertyAddress, RebuildBVHForMesh_FunctionAddress, "UpdateBVH");
		RebuildBVHForMesh_UpdateBVH_Offset = NativeReflectionCached.GetPropertyOffset(RebuildBVHForMesh_FunctionAddress, "UpdateBVH");
		RebuildBVHForMesh_UpdateBVH_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildBVHForMesh_FunctionAddress, "UpdateBVH", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RebuildBVHForMesh_bOnlyIfInvalid_PropertyAddress, RebuildBVHForMesh_FunctionAddress, "bOnlyIfInvalid");
		RebuildBVHForMesh_bOnlyIfInvalid_Offset = NativeReflectionCached.GetPropertyOffset(RebuildBVHForMesh_FunctionAddress, "bOnlyIfInvalid");
		RebuildBVHForMesh_bOnlyIfInvalid_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildBVHForMesh_FunctionAddress, "bOnlyIfInvalid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RebuildBVHForMesh_Debug_PropertyAddress, RebuildBVHForMesh_FunctionAddress, "Debug");
		RebuildBVHForMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RebuildBVHForMesh_FunctionAddress, "Debug");
		RebuildBVHForMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildBVHForMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RebuildBVHForMesh_ReturnValue_PropertyAddress, RebuildBVHForMesh_FunctionAddress, "ReturnValue");
		RebuildBVHForMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RebuildBVHForMesh_FunctionAddress, "ReturnValue");
		RebuildBVHForMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RebuildBVHForMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RebuildBVHForMesh_IsValid = RebuildBVHForMesh_FunctionAddress != IntPtr.Zero && RebuildBVHForMesh_TargetMesh_IsValid && RebuildBVHForMesh_UpdateBVH_IsValid && RebuildBVHForMesh_bOnlyIfInvalid_IsValid && RebuildBVHForMesh_Debug_IsValid && RebuildBVHForMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:RebuildBVHForMesh", RebuildBVHForMesh_IsValid);
		IsPointInsideMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPointInsideMesh");
		IsPointInsideMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPointInsideMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_TargetMesh_PropertyAddress, IsPointInsideMesh_FunctionAddress, "TargetMesh");
		IsPointInsideMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "TargetMesh");
		IsPointInsideMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_QueryBVH_PropertyAddress, IsPointInsideMesh_FunctionAddress, "QueryBVH");
		IsPointInsideMesh_QueryBVH_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "QueryBVH");
		IsPointInsideMesh_QueryBVH_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "QueryBVH", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_QueryPoint_PropertyAddress, IsPointInsideMesh_FunctionAddress, "QueryPoint");
		IsPointInsideMesh_QueryPoint_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "QueryPoint");
		IsPointInsideMesh_QueryPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "QueryPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_Options_PropertyAddress, IsPointInsideMesh_FunctionAddress, "Options");
		IsPointInsideMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "Options");
		IsPointInsideMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_bIsInside_PropertyAddress, IsPointInsideMesh_FunctionAddress, "bIsInside");
		IsPointInsideMesh_bIsInside_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "bIsInside");
		IsPointInsideMesh_bIsInside_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "bIsInside", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_Outcome_PropertyAddress, IsPointInsideMesh_FunctionAddress, "Outcome");
		IsPointInsideMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "Outcome");
		IsPointInsideMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_Debug_PropertyAddress, IsPointInsideMesh_FunctionAddress, "Debug");
		IsPointInsideMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "Debug");
		IsPointInsideMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointInsideMesh_ReturnValue_PropertyAddress, IsPointInsideMesh_FunctionAddress, "ReturnValue");
		IsPointInsideMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPointInsideMesh_FunctionAddress, "ReturnValue");
		IsPointInsideMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointInsideMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		IsPointInsideMesh_IsValid = IsPointInsideMesh_FunctionAddress != IntPtr.Zero && IsPointInsideMesh_TargetMesh_IsValid && IsPointInsideMesh_QueryBVH_IsValid && IsPointInsideMesh_QueryPoint_IsValid && IsPointInsideMesh_Options_IsValid && IsPointInsideMesh_bIsInside_IsValid && IsPointInsideMesh_Outcome_IsValid && IsPointInsideMesh_Debug_IsValid && IsPointInsideMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:IsPointInsideMesh", IsPointInsideMesh_IsValid);
		IsBVHValidForMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsBVHValidForMesh");
		IsBVHValidForMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBVHValidForMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBVHValidForMesh_TargetMesh_PropertyAddress, IsBVHValidForMesh_FunctionAddress, "TargetMesh");
		IsBVHValidForMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsBVHValidForMesh_FunctionAddress, "TargetMesh");
		IsBVHValidForMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBVHValidForMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBVHValidForMesh_TestBVH_PropertyAddress, IsBVHValidForMesh_FunctionAddress, "TestBVH");
		IsBVHValidForMesh_TestBVH_Offset = NativeReflectionCached.GetPropertyOffset(IsBVHValidForMesh_FunctionAddress, "TestBVH");
		IsBVHValidForMesh_TestBVH_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBVHValidForMesh_FunctionAddress, "TestBVH", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBVHValidForMesh_bIsValid_PropertyAddress, IsBVHValidForMesh_FunctionAddress, "bIsValid");
		IsBVHValidForMesh_bIsValid_Offset = NativeReflectionCached.GetPropertyOffset(IsBVHValidForMesh_FunctionAddress, "bIsValid");
		IsBVHValidForMesh_bIsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBVHValidForMesh_FunctionAddress, "bIsValid", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBVHValidForMesh_Debug_PropertyAddress, IsBVHValidForMesh_FunctionAddress, "Debug");
		IsBVHValidForMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(IsBVHValidForMesh_FunctionAddress, "Debug");
		IsBVHValidForMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBVHValidForMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBVHValidForMesh_ReturnValue_PropertyAddress, IsBVHValidForMesh_FunctionAddress, "ReturnValue");
		IsBVHValidForMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBVHValidForMesh_FunctionAddress, "ReturnValue");
		IsBVHValidForMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBVHValidForMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		IsBVHValidForMesh_IsValid = IsBVHValidForMesh_FunctionAddress != IntPtr.Zero && IsBVHValidForMesh_TargetMesh_IsValid && IsBVHValidForMesh_TestBVH_IsValid && IsBVHValidForMesh_bIsValid_IsValid && IsBVHValidForMesh_Debug_IsValid && IsBVHValidForMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:IsBVHValidForMesh", IsBVHValidForMesh_IsValid);
		FindNearestRayIntersectionWithMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindNearestRayIntersectionWithMesh");
		FindNearestRayIntersectionWithMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNearestRayIntersectionWithMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_TargetMesh_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "TargetMesh");
		FindNearestRayIntersectionWithMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "TargetMesh");
		FindNearestRayIntersectionWithMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_QueryBVH_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "QueryBVH");
		FindNearestRayIntersectionWithMesh_QueryBVH_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "QueryBVH");
		FindNearestRayIntersectionWithMesh_QueryBVH_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "QueryBVH", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_RayOrigin_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "RayOrigin");
		FindNearestRayIntersectionWithMesh_RayOrigin_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "RayOrigin");
		FindNearestRayIntersectionWithMesh_RayOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "RayOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_RayDirection_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "RayDirection");
		FindNearestRayIntersectionWithMesh_RayDirection_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "RayDirection");
		FindNearestRayIntersectionWithMesh_RayDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "RayDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_Options_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "Options");
		FindNearestRayIntersectionWithMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "Options");
		FindNearestRayIntersectionWithMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_HitResult_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "HitResult");
		FindNearestRayIntersectionWithMesh_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "HitResult");
		FindNearestRayIntersectionWithMesh_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_Outcome_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "Outcome");
		FindNearestRayIntersectionWithMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "Outcome");
		FindNearestRayIntersectionWithMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_Debug_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "Debug");
		FindNearestRayIntersectionWithMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "Debug");
		FindNearestRayIntersectionWithMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestRayIntersectionWithMesh_ReturnValue_PropertyAddress, FindNearestRayIntersectionWithMesh_FunctionAddress, "ReturnValue");
		FindNearestRayIntersectionWithMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestRayIntersectionWithMesh_FunctionAddress, "ReturnValue");
		FindNearestRayIntersectionWithMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestRayIntersectionWithMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindNearestRayIntersectionWithMesh_IsValid = FindNearestRayIntersectionWithMesh_FunctionAddress != IntPtr.Zero && FindNearestRayIntersectionWithMesh_TargetMesh_IsValid && FindNearestRayIntersectionWithMesh_QueryBVH_IsValid && FindNearestRayIntersectionWithMesh_RayOrigin_IsValid && FindNearestRayIntersectionWithMesh_RayDirection_IsValid && FindNearestRayIntersectionWithMesh_Options_IsValid && FindNearestRayIntersectionWithMesh_HitResult_IsValid && FindNearestRayIntersectionWithMesh_Outcome_IsValid && FindNearestRayIntersectionWithMesh_Debug_IsValid && FindNearestRayIntersectionWithMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:FindNearestRayIntersectionWithMesh", FindNearestRayIntersectionWithMesh_IsValid);
		FindNearestPointOnMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindNearestPointOnMesh");
		FindNearestPointOnMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNearestPointOnMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_TargetMesh_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "TargetMesh");
		FindNearestPointOnMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "TargetMesh");
		FindNearestPointOnMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_QueryBVH_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "QueryBVH");
		FindNearestPointOnMesh_QueryBVH_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "QueryBVH");
		FindNearestPointOnMesh_QueryBVH_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "QueryBVH", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_QueryPoint_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "QueryPoint");
		FindNearestPointOnMesh_QueryPoint_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "QueryPoint");
		FindNearestPointOnMesh_QueryPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "QueryPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_Options_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "Options");
		FindNearestPointOnMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "Options");
		FindNearestPointOnMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_NearestResult_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "NearestResult");
		FindNearestPointOnMesh_NearestResult_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "NearestResult");
		FindNearestPointOnMesh_NearestResult_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "NearestResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_Outcome_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "Outcome");
		FindNearestPointOnMesh_Outcome_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "Outcome");
		FindNearestPointOnMesh_Outcome_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "Outcome", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_Debug_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "Debug");
		FindNearestPointOnMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "Debug");
		FindNearestPointOnMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNearestPointOnMesh_ReturnValue_PropertyAddress, FindNearestPointOnMesh_FunctionAddress, "ReturnValue");
		FindNearestPointOnMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNearestPointOnMesh_FunctionAddress, "ReturnValue");
		FindNearestPointOnMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNearestPointOnMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindNearestPointOnMesh_IsValid = FindNearestPointOnMesh_FunctionAddress != IntPtr.Zero && FindNearestPointOnMesh_TargetMesh_IsValid && FindNearestPointOnMesh_QueryBVH_IsValid && FindNearestPointOnMesh_QueryPoint_IsValid && FindNearestPointOnMesh_Options_IsValid && FindNearestPointOnMesh_NearestResult_IsValid && FindNearestPointOnMesh_Outcome_IsValid && FindNearestPointOnMesh_Debug_IsValid && FindNearestPointOnMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:FindNearestPointOnMesh", FindNearestPointOnMesh_IsValid);
		BuildBVHForMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildBVHForMesh");
		BuildBVHForMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildBVHForMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildBVHForMesh_TargetMesh_PropertyAddress, BuildBVHForMesh_FunctionAddress, "TargetMesh");
		BuildBVHForMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(BuildBVHForMesh_FunctionAddress, "TargetMesh");
		BuildBVHForMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildBVHForMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildBVHForMesh_OutputBVH_PropertyAddress, BuildBVHForMesh_FunctionAddress, "OutputBVH");
		BuildBVHForMesh_OutputBVH_Offset = NativeReflectionCached.GetPropertyOffset(BuildBVHForMesh_FunctionAddress, "OutputBVH");
		BuildBVHForMesh_OutputBVH_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildBVHForMesh_FunctionAddress, "OutputBVH", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildBVHForMesh_Debug_PropertyAddress, BuildBVHForMesh_FunctionAddress, "Debug");
		BuildBVHForMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(BuildBVHForMesh_FunctionAddress, "Debug");
		BuildBVHForMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildBVHForMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildBVHForMesh_ReturnValue_PropertyAddress, BuildBVHForMesh_FunctionAddress, "ReturnValue");
		BuildBVHForMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildBVHForMesh_FunctionAddress, "ReturnValue");
		BuildBVHForMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildBVHForMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BuildBVHForMesh_IsValid = BuildBVHForMesh_FunctionAddress != IntPtr.Zero && BuildBVHForMesh_TargetMesh_IsValid && BuildBVHForMesh_OutputBVH_IsValid && BuildBVHForMesh_Debug_IsValid && BuildBVHForMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSpatial:BuildBVHForMesh", BuildBVHForMesh_IsValid);
	}
}
