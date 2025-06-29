using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_Polygroups : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetNumExtendedPolygroupLayers_IsValid;

	private static IntPtr SetNumExtendedPolygroupLayers_FunctionAddress;

	private static int SetNumExtendedPolygroupLayers_ParamsSize;

	private static bool SetNumExtendedPolygroupLayers_TargetMesh_IsValid;

	private static FFieldAddress SetNumExtendedPolygroupLayers_TargetMesh_PropertyAddress;

	private static int SetNumExtendedPolygroupLayers_TargetMesh_Offset;

	private static bool SetNumExtendedPolygroupLayers_NumLayers_IsValid;

	private static FFieldAddress SetNumExtendedPolygroupLayers_NumLayers_PropertyAddress;

	private static int SetNumExtendedPolygroupLayers_NumLayers_Offset;

	private static bool SetNumExtendedPolygroupLayers_Debug_IsValid;

	private static FFieldAddress SetNumExtendedPolygroupLayers_Debug_PropertyAddress;

	private static int SetNumExtendedPolygroupLayers_Debug_Offset;

	private static bool SetNumExtendedPolygroupLayers_ReturnValue_IsValid;

	private static FFieldAddress SetNumExtendedPolygroupLayers_ReturnValue_PropertyAddress;

	private static int SetNumExtendedPolygroupLayers_ReturnValue_Offset;

	private static bool GetTrianglesInPolygroup_IsValid;

	private static IntPtr GetTrianglesInPolygroup_FunctionAddress;

	private static int GetTrianglesInPolygroup_ParamsSize;

	private static bool GetTrianglesInPolygroup_TargetMesh_IsValid;

	private static FFieldAddress GetTrianglesInPolygroup_TargetMesh_PropertyAddress;

	private static int GetTrianglesInPolygroup_TargetMesh_Offset;

	private static bool GetTrianglesInPolygroup_GroupLayer_IsValid;

	private static FFieldAddress GetTrianglesInPolygroup_GroupLayer_PropertyAddress;

	private static int GetTrianglesInPolygroup_GroupLayer_Offset;

	private static bool GetTrianglesInPolygroup_PolygroupID_IsValid;

	private static FFieldAddress GetTrianglesInPolygroup_PolygroupID_PropertyAddress;

	private static int GetTrianglesInPolygroup_PolygroupID_Offset;

	private static bool GetTrianglesInPolygroup_TriangleIDsOut_IsValid;

	private static FFieldAddress GetTrianglesInPolygroup_TriangleIDsOut_PropertyAddress;

	private static int GetTrianglesInPolygroup_TriangleIDsOut_Offset;

	private static bool GetTrianglesInPolygroup_ReturnValue_IsValid;

	private static FFieldAddress GetTrianglesInPolygroup_ReturnValue_PropertyAddress;

	private static int GetTrianglesInPolygroup_ReturnValue_Offset;

	private static bool GetTrianglePolygroupID_IsValid;

	private static IntPtr GetTrianglePolygroupID_FunctionAddress;

	private static int GetTrianglePolygroupID_ParamsSize;

	private static bool GetTrianglePolygroupID_TargetMesh_IsValid;

	private static FFieldAddress GetTrianglePolygroupID_TargetMesh_PropertyAddress;

	private static int GetTrianglePolygroupID_TargetMesh_Offset;

	private static bool GetTrianglePolygroupID_GroupLayer_IsValid;

	private static FFieldAddress GetTrianglePolygroupID_GroupLayer_PropertyAddress;

	private static int GetTrianglePolygroupID_GroupLayer_Offset;

	private static bool GetTrianglePolygroupID_TriangleID_IsValid;

	private static FFieldAddress GetTrianglePolygroupID_TriangleID_PropertyAddress;

	private static int GetTrianglePolygroupID_TriangleID_Offset;

	private static bool GetTrianglePolygroupID_bIsValidTriangle_IsValid;

	private static FFieldAddress GetTrianglePolygroupID_bIsValidTriangle_PropertyAddress;

	private static int GetTrianglePolygroupID_bIsValidTriangle_Offset;

	private static bool GetTrianglePolygroupID_ReturnValue_IsValid;

	private static FFieldAddress GetTrianglePolygroupID_ReturnValue_PropertyAddress;

	private static int GetTrianglePolygroupID_ReturnValue_Offset;

	private static bool GetPolygroupIDsInMesh_IsValid;

	private static IntPtr GetPolygroupIDsInMesh_FunctionAddress;

	private static int GetPolygroupIDsInMesh_ParamsSize;

	private static bool GetPolygroupIDsInMesh_TargetMesh_IsValid;

	private static FFieldAddress GetPolygroupIDsInMesh_TargetMesh_PropertyAddress;

	private static int GetPolygroupIDsInMesh_TargetMesh_Offset;

	private static bool GetPolygroupIDsInMesh_GroupLayer_IsValid;

	private static FFieldAddress GetPolygroupIDsInMesh_GroupLayer_PropertyAddress;

	private static int GetPolygroupIDsInMesh_GroupLayer_Offset;

	private static bool GetPolygroupIDsInMesh_PolygroupIDsOut_IsValid;

	private static FFieldAddress GetPolygroupIDsInMesh_PolygroupIDsOut_PropertyAddress;

	private static int GetPolygroupIDsInMesh_PolygroupIDsOut_Offset;

	private static bool GetPolygroupIDsInMesh_ReturnValue_IsValid;

	private static FFieldAddress GetPolygroupIDsInMesh_ReturnValue_PropertyAddress;

	private static int GetPolygroupIDsInMesh_ReturnValue_Offset;

	private static bool GetAllTrianglePolygroupIDs_IsValid;

	private static IntPtr GetAllTrianglePolygroupIDs_FunctionAddress;

	private static int GetAllTrianglePolygroupIDs_ParamsSize;

	private static bool GetAllTrianglePolygroupIDs_TargetMesh_IsValid;

	private static FFieldAddress GetAllTrianglePolygroupIDs_TargetMesh_PropertyAddress;

	private static int GetAllTrianglePolygroupIDs_TargetMesh_Offset;

	private static bool GetAllTrianglePolygroupIDs_GroupLayer_IsValid;

	private static FFieldAddress GetAllTrianglePolygroupIDs_GroupLayer_PropertyAddress;

	private static int GetAllTrianglePolygroupIDs_GroupLayer_Offset;

	private static bool GetAllTrianglePolygroupIDs_PolygroupIDsOut_IsValid;

	private static FFieldAddress GetAllTrianglePolygroupIDs_PolygroupIDsOut_PropertyAddress;

	private static int GetAllTrianglePolygroupIDs_PolygroupIDsOut_Offset;

	private static bool GetAllTrianglePolygroupIDs_ReturnValue_IsValid;

	private static FFieldAddress GetAllTrianglePolygroupIDs_ReturnValue_PropertyAddress;

	private static int GetAllTrianglePolygroupIDs_ReturnValue_Offset;

	private static bool EnablePolygroups_IsValid;

	private static IntPtr EnablePolygroups_FunctionAddress;

	private static int EnablePolygroups_ParamsSize;

	private static bool EnablePolygroups_TargetMesh_IsValid;

	private static FFieldAddress EnablePolygroups_TargetMesh_PropertyAddress;

	private static int EnablePolygroups_TargetMesh_Offset;

	private static bool EnablePolygroups_Debug_IsValid;

	private static FFieldAddress EnablePolygroups_Debug_PropertyAddress;

	private static int EnablePolygroups_Debug_Offset;

	private static bool EnablePolygroups_ReturnValue_IsValid;

	private static FFieldAddress EnablePolygroups_ReturnValue_PropertyAddress;

	private static int EnablePolygroups_ReturnValue_Offset;

	private static bool DeleteTrianglesInPolygroup_IsValid;

	private static IntPtr DeleteTrianglesInPolygroup_FunctionAddress;

	private static int DeleteTrianglesInPolygroup_ParamsSize;

	private static bool DeleteTrianglesInPolygroup_TargetMesh_IsValid;

	private static FFieldAddress DeleteTrianglesInPolygroup_TargetMesh_PropertyAddress;

	private static int DeleteTrianglesInPolygroup_TargetMesh_Offset;

	private static bool DeleteTrianglesInPolygroup_GroupLayer_IsValid;

	private static FFieldAddress DeleteTrianglesInPolygroup_GroupLayer_PropertyAddress;

	private static int DeleteTrianglesInPolygroup_GroupLayer_Offset;

	private static bool DeleteTrianglesInPolygroup_PolygroupID_IsValid;

	private static FFieldAddress DeleteTrianglesInPolygroup_PolygroupID_PropertyAddress;

	private static int DeleteTrianglesInPolygroup_PolygroupID_Offset;

	private static bool DeleteTrianglesInPolygroup_NumDeleted_IsValid;

	private static FFieldAddress DeleteTrianglesInPolygroup_NumDeleted_PropertyAddress;

	private static int DeleteTrianglesInPolygroup_NumDeleted_Offset;

	private static bool DeleteTrianglesInPolygroup_bDeferChangeNotifications_IsValid;

	private static FFieldAddress DeleteTrianglesInPolygroup_bDeferChangeNotifications_PropertyAddress;

	private static int DeleteTrianglesInPolygroup_bDeferChangeNotifications_Offset;

	private static bool DeleteTrianglesInPolygroup_Debug_IsValid;

	private static FFieldAddress DeleteTrianglesInPolygroup_Debug_PropertyAddress;

	private static int DeleteTrianglesInPolygroup_Debug_Offset;

	private static bool DeleteTrianglesInPolygroup_ReturnValue_IsValid;

	private static FFieldAddress DeleteTrianglesInPolygroup_ReturnValue_PropertyAddress;

	private static int DeleteTrianglesInPolygroup_ReturnValue_Offset;

	private static bool CopyPolygroupsLayer_IsValid;

	private static IntPtr CopyPolygroupsLayer_FunctionAddress;

	private static int CopyPolygroupsLayer_ParamsSize;

	private static bool CopyPolygroupsLayer_TargetMesh_IsValid;

	private static FFieldAddress CopyPolygroupsLayer_TargetMesh_PropertyAddress;

	private static int CopyPolygroupsLayer_TargetMesh_Offset;

	private static bool CopyPolygroupsLayer_FromGroupLayer_IsValid;

	private static FFieldAddress CopyPolygroupsLayer_FromGroupLayer_PropertyAddress;

	private static int CopyPolygroupsLayer_FromGroupLayer_Offset;

	private static bool CopyPolygroupsLayer_ToGroupLayer_IsValid;

	private static FFieldAddress CopyPolygroupsLayer_ToGroupLayer_PropertyAddress;

	private static int CopyPolygroupsLayer_ToGroupLayer_Offset;

	private static bool CopyPolygroupsLayer_Debug_IsValid;

	private static FFieldAddress CopyPolygroupsLayer_Debug_PropertyAddress;

	private static int CopyPolygroupsLayer_Debug_Offset;

	private static bool CopyPolygroupsLayer_ReturnValue_IsValid;

	private static FFieldAddress CopyPolygroupsLayer_ReturnValue_PropertyAddress;

	private static int CopyPolygroupsLayer_ReturnValue_Offset;

	private static bool ConvertUVIslandsToPolygroups_IsValid;

	private static IntPtr ConvertUVIslandsToPolygroups_FunctionAddress;

	private static int ConvertUVIslandsToPolygroups_ParamsSize;

	private static bool ConvertUVIslandsToPolygroups_TargetMesh_IsValid;

	private static FFieldAddress ConvertUVIslandsToPolygroups_TargetMesh_PropertyAddress;

	private static int ConvertUVIslandsToPolygroups_TargetMesh_Offset;

	private static bool ConvertUVIslandsToPolygroups_GroupLayer_IsValid;

	private static FFieldAddress ConvertUVIslandsToPolygroups_GroupLayer_PropertyAddress;

	private static int ConvertUVIslandsToPolygroups_GroupLayer_Offset;

	private static bool ConvertUVIslandsToPolygroups_UVLayer_IsValid;

	private static FFieldAddress ConvertUVIslandsToPolygroups_UVLayer_PropertyAddress;

	private static int ConvertUVIslandsToPolygroups_UVLayer_Offset;

	private static bool ConvertUVIslandsToPolygroups_Debug_IsValid;

	private static FFieldAddress ConvertUVIslandsToPolygroups_Debug_PropertyAddress;

	private static int ConvertUVIslandsToPolygroups_Debug_Offset;

	private static bool ConvertUVIslandsToPolygroups_ReturnValue_IsValid;

	private static FFieldAddress ConvertUVIslandsToPolygroups_ReturnValue_PropertyAddress;

	private static int ConvertUVIslandsToPolygroups_ReturnValue_Offset;

	private static bool ConvertComponentsToPolygroups_IsValid;

	private static IntPtr ConvertComponentsToPolygroups_FunctionAddress;

	private static int ConvertComponentsToPolygroups_ParamsSize;

	private static bool ConvertComponentsToPolygroups_TargetMesh_IsValid;

	private static FFieldAddress ConvertComponentsToPolygroups_TargetMesh_PropertyAddress;

	private static int ConvertComponentsToPolygroups_TargetMesh_Offset;

	private static bool ConvertComponentsToPolygroups_GroupLayer_IsValid;

	private static FFieldAddress ConvertComponentsToPolygroups_GroupLayer_PropertyAddress;

	private static int ConvertComponentsToPolygroups_GroupLayer_Offset;

	private static bool ConvertComponentsToPolygroups_Debug_IsValid;

	private static FFieldAddress ConvertComponentsToPolygroups_Debug_PropertyAddress;

	private static int ConvertComponentsToPolygroups_Debug_Offset;

	private static bool ConvertComponentsToPolygroups_ReturnValue_IsValid;

	private static FFieldAddress ConvertComponentsToPolygroups_ReturnValue_PropertyAddress;

	private static int ConvertComponentsToPolygroups_ReturnValue_Offset;

	private static bool ComputePolygroupsFromAngleThreshold_IsValid;

	private static IntPtr ComputePolygroupsFromAngleThreshold_FunctionAddress;

	private static int ComputePolygroupsFromAngleThreshold_ParamsSize;

	private static bool ComputePolygroupsFromAngleThreshold_TargetMesh_IsValid;

	private static FFieldAddress ComputePolygroupsFromAngleThreshold_TargetMesh_PropertyAddress;

	private static int ComputePolygroupsFromAngleThreshold_TargetMesh_Offset;

	private static bool ComputePolygroupsFromAngleThreshold_GroupLayer_IsValid;

	private static FFieldAddress ComputePolygroupsFromAngleThreshold_GroupLayer_PropertyAddress;

	private static int ComputePolygroupsFromAngleThreshold_GroupLayer_Offset;

	private static bool ComputePolygroupsFromAngleThreshold_CreaseAngle_IsValid;

	private static FFieldAddress ComputePolygroupsFromAngleThreshold_CreaseAngle_PropertyAddress;

	private static int ComputePolygroupsFromAngleThreshold_CreaseAngle_Offset;

	private static bool ComputePolygroupsFromAngleThreshold_MinGroupSize_IsValid;

	private static FFieldAddress ComputePolygroupsFromAngleThreshold_MinGroupSize_PropertyAddress;

	private static int ComputePolygroupsFromAngleThreshold_MinGroupSize_Offset;

	private static bool ComputePolygroupsFromAngleThreshold_Debug_IsValid;

	private static FFieldAddress ComputePolygroupsFromAngleThreshold_Debug_PropertyAddress;

	private static int ComputePolygroupsFromAngleThreshold_Debug_Offset;

	private static bool ComputePolygroupsFromAngleThreshold_ReturnValue_IsValid;

	private static FFieldAddress ComputePolygroupsFromAngleThreshold_ReturnValue_PropertyAddress;

	private static int ComputePolygroupsFromAngleThreshold_ReturnValue_Offset;

	private static bool ClearPolygroups_IsValid;

	private static IntPtr ClearPolygroups_FunctionAddress;

	private static int ClearPolygroups_ParamsSize;

	private static bool ClearPolygroups_TargetMesh_IsValid;

	private static FFieldAddress ClearPolygroups_TargetMesh_PropertyAddress;

	private static int ClearPolygroups_TargetMesh_Offset;

	private static bool ClearPolygroups_GroupLayer_IsValid;

	private static FFieldAddress ClearPolygroups_GroupLayer_PropertyAddress;

	private static int ClearPolygroups_GroupLayer_Offset;

	private static bool ClearPolygroups_ClearValue_IsValid;

	private static FFieldAddress ClearPolygroups_ClearValue_PropertyAddress;

	private static int ClearPolygroups_ClearValue_Offset;

	private static bool ClearPolygroups_Debug_IsValid;

	private static FFieldAddress ClearPolygroups_Debug_PropertyAddress;

	private static int ClearPolygroups_Debug_Offset;

	private static bool ClearPolygroups_ReturnValue_IsValid;

	private static FFieldAddress ClearPolygroups_ReturnValue_PropertyAddress;

	private static int ClearPolygroups_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:SetNumExtendedPolygroupLayers")]
	public unsafe static UDynamicMesh SetNumExtendedPolygroupLayers(UDynamicMesh TargetMesh, int NumLayers, UGeometryScriptDebug Debug)
	{
		if (!SetNumExtendedPolygroupLayers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:SetNumExtendedPolygroupLayers");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumExtendedPolygroupLayers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumExtendedPolygroupLayers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetNumExtendedPolygroupLayers_TargetMesh_Offset), 0, SetNumExtendedPolygroupLayers_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumExtendedPolygroupLayers_NumLayers_Offset), 0, SetNumExtendedPolygroupLayers_NumLayers_PropertyAddress.Address, NumLayers);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetNumExtendedPolygroupLayers_Debug_Offset), 0, SetNumExtendedPolygroupLayers_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNumExtendedPolygroupLayers_FunctionAddress, intPtr, SetNumExtendedPolygroupLayers_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetNumExtendedPolygroupLayers_ReturnValue_Offset), 0, SetNumExtendedPolygroupLayers_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetTrianglesInPolygroup")]
	public unsafe static UDynamicMesh GetTrianglesInPolygroup(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int PolygroupID, ref FGeometryScriptIndexList TriangleIDsOut)
	{
		if (!GetTrianglesInPolygroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetTrianglesInPolygroup");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrianglesInPolygroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrianglesInPolygroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetTrianglesInPolygroup_TargetMesh_Offset), 0, GetTrianglesInPolygroup_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetTrianglesInPolygroup_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, GetTrianglesInPolygroup_GroupLayer_Offset), 0, GetTrianglesInPolygroup_GroupLayer_PropertyAddress.Address, GroupLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTrianglesInPolygroup_PolygroupID_Offset), 0, GetTrianglesInPolygroup_PolygroupID_PropertyAddress.Address, PolygroupID);
		NativeReflection.InitializeValue_InContainer(GetTrianglesInPolygroup_TriangleIDsOut_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, GetTrianglesInPolygroup_TriangleIDsOut_Offset), 0, GetTrianglesInPolygroup_TriangleIDsOut_PropertyAddress.Address, TriangleIDsOut);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTrianglesInPolygroup_FunctionAddress, intPtr, GetTrianglesInPolygroup_ParamsSize);
		TriangleIDsOut = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, GetTrianglesInPolygroup_TriangleIDsOut_Offset), 0, GetTrianglesInPolygroup_TriangleIDsOut_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTrianglesInPolygroup_TriangleIDsOut_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetTrianglesInPolygroup_ReturnValue_Offset), 0, GetTrianglesInPolygroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetTrianglePolygroupID")]
	public unsafe static int GetTrianglePolygroupID(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int TriangleID, out bool bIsValidTriangle)
	{
		if (!GetTrianglePolygroupID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetTrianglePolygroupID");
			bIsValidTriangle = false;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrianglePolygroupID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrianglePolygroupID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetTrianglePolygroupID_TargetMesh_Offset), 0, GetTrianglePolygroupID_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetTrianglePolygroupID_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, GetTrianglePolygroupID_GroupLayer_Offset), 0, GetTrianglePolygroupID_GroupLayer_PropertyAddress.Address, GroupLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTrianglePolygroupID_TriangleID_Offset), 0, GetTrianglePolygroupID_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTrianglePolygroupID_FunctionAddress, intPtr, GetTrianglePolygroupID_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTrianglePolygroupID_bIsValidTriangle_Offset), 0, GetTrianglePolygroupID_bIsValidTriangle_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTrianglePolygroupID_ReturnValue_Offset), 0, GetTrianglePolygroupID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetPolygroupIDsInMesh")]
	public unsafe static UDynamicMesh GetPolygroupIDsInMesh(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, ref FGeometryScriptIndexList PolygroupIDsOut)
	{
		if (!GetPolygroupIDsInMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetPolygroupIDsInMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPolygroupIDsInMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPolygroupIDsInMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetPolygroupIDsInMesh_TargetMesh_Offset), 0, GetPolygroupIDsInMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetPolygroupIDsInMesh_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, GetPolygroupIDsInMesh_GroupLayer_Offset), 0, GetPolygroupIDsInMesh_GroupLayer_PropertyAddress.Address, GroupLayer);
		NativeReflection.InitializeValue_InContainer(GetPolygroupIDsInMesh_PolygroupIDsOut_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, GetPolygroupIDsInMesh_PolygroupIDsOut_Offset), 0, GetPolygroupIDsInMesh_PolygroupIDsOut_PropertyAddress.Address, PolygroupIDsOut);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPolygroupIDsInMesh_FunctionAddress, intPtr, GetPolygroupIDsInMesh_ParamsSize);
		PolygroupIDsOut = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, GetPolygroupIDsInMesh_PolygroupIDsOut_Offset), 0, GetPolygroupIDsInMesh_PolygroupIDsOut_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPolygroupIDsInMesh_PolygroupIDsOut_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetPolygroupIDsInMesh_ReturnValue_Offset), 0, GetPolygroupIDsInMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetAllTrianglePolygroupIDs")]
	public unsafe static UDynamicMesh GetAllTrianglePolygroupIDs(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, ref FGeometryScriptIndexList PolygroupIDsOut)
	{
		if (!GetAllTrianglePolygroupIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetAllTrianglePolygroupIDs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllTrianglePolygroupIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllTrianglePolygroupIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, GetAllTrianglePolygroupIDs_TargetMesh_Offset), 0, GetAllTrianglePolygroupIDs_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(GetAllTrianglePolygroupIDs_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, GetAllTrianglePolygroupIDs_GroupLayer_Offset), 0, GetAllTrianglePolygroupIDs_GroupLayer_PropertyAddress.Address, GroupLayer);
		NativeReflection.InitializeValue_InContainer(GetAllTrianglePolygroupIDs_PolygroupIDsOut_PropertyAddress.Address, intPtr);
		FGeometryScriptIndexList.ToNative(IntPtr.Add(intPtr, GetAllTrianglePolygroupIDs_PolygroupIDsOut_Offset), 0, GetAllTrianglePolygroupIDs_PolygroupIDsOut_PropertyAddress.Address, PolygroupIDsOut);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllTrianglePolygroupIDs_FunctionAddress, intPtr, GetAllTrianglePolygroupIDs_ParamsSize);
		PolygroupIDsOut = FGeometryScriptIndexList.FromNative(IntPtr.Add(intPtr, GetAllTrianglePolygroupIDs_PolygroupIDsOut_Offset), 0, GetAllTrianglePolygroupIDs_PolygroupIDsOut_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAllTrianglePolygroupIDs_PolygroupIDsOut_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, GetAllTrianglePolygroupIDs_ReturnValue_Offset), 0, GetAllTrianglePolygroupIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:EnablePolygroups")]
	public unsafe static UDynamicMesh EnablePolygroups(UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		if (!EnablePolygroups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:EnablePolygroups");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnablePolygroups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnablePolygroups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, EnablePolygroups_TargetMesh_Offset), 0, EnablePolygroups_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, EnablePolygroups_Debug_Offset), 0, EnablePolygroups_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnablePolygroups_FunctionAddress, intPtr, EnablePolygroups_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, EnablePolygroups_ReturnValue_Offset), 0, EnablePolygroups_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:DeleteTrianglesInPolygroup")]
	public unsafe static UDynamicMesh DeleteTrianglesInPolygroup(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int PolygroupID, out int NumDeleted, bool bDeferChangeNotifications, UGeometryScriptDebug Debug)
	{
		if (!DeleteTrianglesInPolygroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:DeleteTrianglesInPolygroup");
			NumDeleted = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteTrianglesInPolygroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteTrianglesInPolygroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, DeleteTrianglesInPolygroup_TargetMesh_Offset), 0, DeleteTrianglesInPolygroup_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(DeleteTrianglesInPolygroup_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, DeleteTrianglesInPolygroup_GroupLayer_Offset), 0, DeleteTrianglesInPolygroup_GroupLayer_PropertyAddress.Address, GroupLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DeleteTrianglesInPolygroup_PolygroupID_Offset), 0, DeleteTrianglesInPolygroup_PolygroupID_PropertyAddress.Address, PolygroupID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteTrianglesInPolygroup_bDeferChangeNotifications_Offset), 0, DeleteTrianglesInPolygroup_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, DeleteTrianglesInPolygroup_Debug_Offset), 0, DeleteTrianglesInPolygroup_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteTrianglesInPolygroup_FunctionAddress, intPtr, DeleteTrianglesInPolygroup_ParamsSize);
		NumDeleted = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, DeleteTrianglesInPolygroup_NumDeleted_Offset), 0, DeleteTrianglesInPolygroup_NumDeleted_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, DeleteTrianglesInPolygroup_ReturnValue_Offset), 0, DeleteTrianglesInPolygroup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:CopyPolygroupsLayer")]
	public unsafe static UDynamicMesh CopyPolygroupsLayer(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer FromGroupLayer, FGeometryScriptGroupLayer ToGroupLayer, UGeometryScriptDebug Debug)
	{
		if (!CopyPolygroupsLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:CopyPolygroupsLayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPolygroupsLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPolygroupsLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CopyPolygroupsLayer_TargetMesh_Offset), 0, CopyPolygroupsLayer_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(CopyPolygroupsLayer_FromGroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, CopyPolygroupsLayer_FromGroupLayer_Offset), 0, CopyPolygroupsLayer_FromGroupLayer_PropertyAddress.Address, FromGroupLayer);
		NativeReflection.InitializeValue_InContainer(CopyPolygroupsLayer_ToGroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, CopyPolygroupsLayer_ToGroupLayer_Offset), 0, CopyPolygroupsLayer_ToGroupLayer_PropertyAddress.Address, ToGroupLayer);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CopyPolygroupsLayer_Debug_Offset), 0, CopyPolygroupsLayer_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyPolygroupsLayer_FunctionAddress, intPtr, CopyPolygroupsLayer_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CopyPolygroupsLayer_ReturnValue_Offset), 0, CopyPolygroupsLayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ConvertUVIslandsToPolygroups")]
	public unsafe static UDynamicMesh ConvertUVIslandsToPolygroups(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int UVLayer, UGeometryScriptDebug Debug)
	{
		if (!ConvertUVIslandsToPolygroups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ConvertUVIslandsToPolygroups");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertUVIslandsToPolygroups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertUVIslandsToPolygroups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ConvertUVIslandsToPolygroups_TargetMesh_Offset), 0, ConvertUVIslandsToPolygroups_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ConvertUVIslandsToPolygroups_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, ConvertUVIslandsToPolygroups_GroupLayer_Offset), 0, ConvertUVIslandsToPolygroups_GroupLayer_PropertyAddress.Address, GroupLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertUVIslandsToPolygroups_UVLayer_Offset), 0, ConvertUVIslandsToPolygroups_UVLayer_PropertyAddress.Address, UVLayer);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ConvertUVIslandsToPolygroups_Debug_Offset), 0, ConvertUVIslandsToPolygroups_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertUVIslandsToPolygroups_FunctionAddress, intPtr, ConvertUVIslandsToPolygroups_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ConvertUVIslandsToPolygroups_ReturnValue_Offset), 0, ConvertUVIslandsToPolygroups_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ConvertComponentsToPolygroups")]
	public unsafe static UDynamicMesh ConvertComponentsToPolygroups(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, UGeometryScriptDebug Debug)
	{
		if (!ConvertComponentsToPolygroups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ConvertComponentsToPolygroups");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertComponentsToPolygroups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertComponentsToPolygroups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ConvertComponentsToPolygroups_TargetMesh_Offset), 0, ConvertComponentsToPolygroups_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ConvertComponentsToPolygroups_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, ConvertComponentsToPolygroups_GroupLayer_Offset), 0, ConvertComponentsToPolygroups_GroupLayer_PropertyAddress.Address, GroupLayer);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ConvertComponentsToPolygroups_Debug_Offset), 0, ConvertComponentsToPolygroups_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertComponentsToPolygroups_FunctionAddress, intPtr, ConvertComponentsToPolygroups_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ConvertComponentsToPolygroups_ReturnValue_Offset), 0, ConvertComponentsToPolygroups_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ComputePolygroupsFromAngleThreshold")]
	public unsafe static UDynamicMesh ComputePolygroupsFromAngleThreshold(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, float CreaseAngle, int MinGroupSize, UGeometryScriptDebug Debug)
	{
		if (!ComputePolygroupsFromAngleThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ComputePolygroupsFromAngleThreshold");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputePolygroupsFromAngleThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputePolygroupsFromAngleThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ComputePolygroupsFromAngleThreshold_TargetMesh_Offset), 0, ComputePolygroupsFromAngleThreshold_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ComputePolygroupsFromAngleThreshold_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, ComputePolygroupsFromAngleThreshold_GroupLayer_Offset), 0, ComputePolygroupsFromAngleThreshold_GroupLayer_PropertyAddress.Address, GroupLayer);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ComputePolygroupsFromAngleThreshold_CreaseAngle_Offset), 0, ComputePolygroupsFromAngleThreshold_CreaseAngle_PropertyAddress.Address, CreaseAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ComputePolygroupsFromAngleThreshold_MinGroupSize_Offset), 0, ComputePolygroupsFromAngleThreshold_MinGroupSize_PropertyAddress.Address, MinGroupSize);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ComputePolygroupsFromAngleThreshold_Debug_Offset), 0, ComputePolygroupsFromAngleThreshold_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ComputePolygroupsFromAngleThreshold_FunctionAddress, intPtr, ComputePolygroupsFromAngleThreshold_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputePolygroupsFromAngleThreshold_ReturnValue_Offset), 0, ComputePolygroupsFromAngleThreshold_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ClearPolygroups")]
	public unsafe static UDynamicMesh ClearPolygroups(UDynamicMesh TargetMesh, FGeometryScriptGroupLayer GroupLayer, int ClearValue, UGeometryScriptDebug Debug)
	{
		if (!ClearPolygroups_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ClearPolygroups");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearPolygroups_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearPolygroups_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ClearPolygroups_TargetMesh_Offset), 0, ClearPolygroups_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ClearPolygroups_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, ClearPolygroups_GroupLayer_Offset), 0, ClearPolygroups_GroupLayer_PropertyAddress.Address, GroupLayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ClearPolygroups_ClearValue_Offset), 0, ClearPolygroups_ClearValue_PropertyAddress.Address, ClearValue);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ClearPolygroups_Debug_Offset), 0, ClearPolygroups_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearPolygroups_FunctionAddress, intPtr, ClearPolygroups_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ClearPolygroups_ReturnValue_Offset), 0, ClearPolygroups_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_Polygroups()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_Polygroups)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_Polygroups));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions");
		SetNumExtendedPolygroupLayers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNumExtendedPolygroupLayers");
		SetNumExtendedPolygroupLayers_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumExtendedPolygroupLayers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumExtendedPolygroupLayers_TargetMesh_PropertyAddress, SetNumExtendedPolygroupLayers_FunctionAddress, "TargetMesh");
		SetNumExtendedPolygroupLayers_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetNumExtendedPolygroupLayers_FunctionAddress, "TargetMesh");
		SetNumExtendedPolygroupLayers_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumExtendedPolygroupLayers_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumExtendedPolygroupLayers_NumLayers_PropertyAddress, SetNumExtendedPolygroupLayers_FunctionAddress, "NumLayers");
		SetNumExtendedPolygroupLayers_NumLayers_Offset = NativeReflectionCached.GetPropertyOffset(SetNumExtendedPolygroupLayers_FunctionAddress, "NumLayers");
		SetNumExtendedPolygroupLayers_NumLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumExtendedPolygroupLayers_FunctionAddress, "NumLayers", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumExtendedPolygroupLayers_Debug_PropertyAddress, SetNumExtendedPolygroupLayers_FunctionAddress, "Debug");
		SetNumExtendedPolygroupLayers_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetNumExtendedPolygroupLayers_FunctionAddress, "Debug");
		SetNumExtendedPolygroupLayers_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumExtendedPolygroupLayers_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumExtendedPolygroupLayers_ReturnValue_PropertyAddress, SetNumExtendedPolygroupLayers_FunctionAddress, "ReturnValue");
		SetNumExtendedPolygroupLayers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNumExtendedPolygroupLayers_FunctionAddress, "ReturnValue");
		SetNumExtendedPolygroupLayers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumExtendedPolygroupLayers_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetNumExtendedPolygroupLayers_IsValid = SetNumExtendedPolygroupLayers_FunctionAddress != IntPtr.Zero && SetNumExtendedPolygroupLayers_TargetMesh_IsValid && SetNumExtendedPolygroupLayers_NumLayers_IsValid && SetNumExtendedPolygroupLayers_Debug_IsValid && SetNumExtendedPolygroupLayers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:SetNumExtendedPolygroupLayers", SetNumExtendedPolygroupLayers_IsValid);
		GetTrianglesInPolygroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTrianglesInPolygroup");
		GetTrianglesInPolygroup_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrianglesInPolygroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglesInPolygroup_TargetMesh_PropertyAddress, GetTrianglesInPolygroup_FunctionAddress, "TargetMesh");
		GetTrianglesInPolygroup_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglesInPolygroup_FunctionAddress, "TargetMesh");
		GetTrianglesInPolygroup_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglesInPolygroup_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglesInPolygroup_GroupLayer_PropertyAddress, GetTrianglesInPolygroup_FunctionAddress, "GroupLayer");
		GetTrianglesInPolygroup_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglesInPolygroup_FunctionAddress, "GroupLayer");
		GetTrianglesInPolygroup_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglesInPolygroup_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglesInPolygroup_PolygroupID_PropertyAddress, GetTrianglesInPolygroup_FunctionAddress, "PolygroupID");
		GetTrianglesInPolygroup_PolygroupID_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglesInPolygroup_FunctionAddress, "PolygroupID");
		GetTrianglesInPolygroup_PolygroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglesInPolygroup_FunctionAddress, "PolygroupID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglesInPolygroup_TriangleIDsOut_PropertyAddress, GetTrianglesInPolygroup_FunctionAddress, "TriangleIDsOut");
		GetTrianglesInPolygroup_TriangleIDsOut_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglesInPolygroup_FunctionAddress, "TriangleIDsOut");
		GetTrianglesInPolygroup_TriangleIDsOut_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglesInPolygroup_FunctionAddress, "TriangleIDsOut", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglesInPolygroup_ReturnValue_PropertyAddress, GetTrianglesInPolygroup_FunctionAddress, "ReturnValue");
		GetTrianglesInPolygroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglesInPolygroup_FunctionAddress, "ReturnValue");
		GetTrianglesInPolygroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglesInPolygroup_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTrianglesInPolygroup_IsValid = GetTrianglesInPolygroup_FunctionAddress != IntPtr.Zero && GetTrianglesInPolygroup_TargetMesh_IsValid && GetTrianglesInPolygroup_GroupLayer_IsValid && GetTrianglesInPolygroup_PolygroupID_IsValid && GetTrianglesInPolygroup_TriangleIDsOut_IsValid && GetTrianglesInPolygroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetTrianglesInPolygroup", GetTrianglesInPolygroup_IsValid);
		GetTrianglePolygroupID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTrianglePolygroupID");
		GetTrianglePolygroupID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrianglePolygroupID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygroupID_TargetMesh_PropertyAddress, GetTrianglePolygroupID_FunctionAddress, "TargetMesh");
		GetTrianglePolygroupID_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygroupID_FunctionAddress, "TargetMesh");
		GetTrianglePolygroupID_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygroupID_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygroupID_GroupLayer_PropertyAddress, GetTrianglePolygroupID_FunctionAddress, "GroupLayer");
		GetTrianglePolygroupID_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygroupID_FunctionAddress, "GroupLayer");
		GetTrianglePolygroupID_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygroupID_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygroupID_TriangleID_PropertyAddress, GetTrianglePolygroupID_FunctionAddress, "TriangleID");
		GetTrianglePolygroupID_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygroupID_FunctionAddress, "TriangleID");
		GetTrianglePolygroupID_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygroupID_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygroupID_bIsValidTriangle_PropertyAddress, GetTrianglePolygroupID_FunctionAddress, "bIsValidTriangle");
		GetTrianglePolygroupID_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygroupID_FunctionAddress, "bIsValidTriangle");
		GetTrianglePolygroupID_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygroupID_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrianglePolygroupID_ReturnValue_PropertyAddress, GetTrianglePolygroupID_FunctionAddress, "ReturnValue");
		GetTrianglePolygroupID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrianglePolygroupID_FunctionAddress, "ReturnValue");
		GetTrianglePolygroupID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrianglePolygroupID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTrianglePolygroupID_IsValid = GetTrianglePolygroupID_FunctionAddress != IntPtr.Zero && GetTrianglePolygroupID_TargetMesh_IsValid && GetTrianglePolygroupID_GroupLayer_IsValid && GetTrianglePolygroupID_TriangleID_IsValid && GetTrianglePolygroupID_bIsValidTriangle_IsValid && GetTrianglePolygroupID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetTrianglePolygroupID", GetTrianglePolygroupID_IsValid);
		GetPolygroupIDsInMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPolygroupIDsInMesh");
		GetPolygroupIDsInMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPolygroupIDsInMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPolygroupIDsInMesh_TargetMesh_PropertyAddress, GetPolygroupIDsInMesh_FunctionAddress, "TargetMesh");
		GetPolygroupIDsInMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygroupIDsInMesh_FunctionAddress, "TargetMesh");
		GetPolygroupIDsInMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygroupIDsInMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygroupIDsInMesh_GroupLayer_PropertyAddress, GetPolygroupIDsInMesh_FunctionAddress, "GroupLayer");
		GetPolygroupIDsInMesh_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygroupIDsInMesh_FunctionAddress, "GroupLayer");
		GetPolygroupIDsInMesh_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygroupIDsInMesh_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygroupIDsInMesh_PolygroupIDsOut_PropertyAddress, GetPolygroupIDsInMesh_FunctionAddress, "PolygroupIDsOut");
		GetPolygroupIDsInMesh_PolygroupIDsOut_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygroupIDsInMesh_FunctionAddress, "PolygroupIDsOut");
		GetPolygroupIDsInMesh_PolygroupIDsOut_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygroupIDsInMesh_FunctionAddress, "PolygroupIDsOut", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPolygroupIDsInMesh_ReturnValue_PropertyAddress, GetPolygroupIDsInMesh_FunctionAddress, "ReturnValue");
		GetPolygroupIDsInMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPolygroupIDsInMesh_FunctionAddress, "ReturnValue");
		GetPolygroupIDsInMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPolygroupIDsInMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPolygroupIDsInMesh_IsValid = GetPolygroupIDsInMesh_FunctionAddress != IntPtr.Zero && GetPolygroupIDsInMesh_TargetMesh_IsValid && GetPolygroupIDsInMesh_GroupLayer_IsValid && GetPolygroupIDsInMesh_PolygroupIDsOut_IsValid && GetPolygroupIDsInMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetPolygroupIDsInMesh", GetPolygroupIDsInMesh_IsValid);
		GetAllTrianglePolygroupIDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllTrianglePolygroupIDs");
		GetAllTrianglePolygroupIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllTrianglePolygroupIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllTrianglePolygroupIDs_TargetMesh_PropertyAddress, GetAllTrianglePolygroupIDs_FunctionAddress, "TargetMesh");
		GetAllTrianglePolygroupIDs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTrianglePolygroupIDs_FunctionAddress, "TargetMesh");
		GetAllTrianglePolygroupIDs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTrianglePolygroupIDs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTrianglePolygroupIDs_GroupLayer_PropertyAddress, GetAllTrianglePolygroupIDs_FunctionAddress, "GroupLayer");
		GetAllTrianglePolygroupIDs_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTrianglePolygroupIDs_FunctionAddress, "GroupLayer");
		GetAllTrianglePolygroupIDs_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTrianglePolygroupIDs_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTrianglePolygroupIDs_PolygroupIDsOut_PropertyAddress, GetAllTrianglePolygroupIDs_FunctionAddress, "PolygroupIDsOut");
		GetAllTrianglePolygroupIDs_PolygroupIDsOut_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTrianglePolygroupIDs_FunctionAddress, "PolygroupIDsOut");
		GetAllTrianglePolygroupIDs_PolygroupIDsOut_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTrianglePolygroupIDs_FunctionAddress, "PolygroupIDsOut", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTrianglePolygroupIDs_ReturnValue_PropertyAddress, GetAllTrianglePolygroupIDs_FunctionAddress, "ReturnValue");
		GetAllTrianglePolygroupIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTrianglePolygroupIDs_FunctionAddress, "ReturnValue");
		GetAllTrianglePolygroupIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTrianglePolygroupIDs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAllTrianglePolygroupIDs_IsValid = GetAllTrianglePolygroupIDs_FunctionAddress != IntPtr.Zero && GetAllTrianglePolygroupIDs_TargetMesh_IsValid && GetAllTrianglePolygroupIDs_GroupLayer_IsValid && GetAllTrianglePolygroupIDs_PolygroupIDsOut_IsValid && GetAllTrianglePolygroupIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:GetAllTrianglePolygroupIDs", GetAllTrianglePolygroupIDs_IsValid);
		EnablePolygroups_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnablePolygroups");
		EnablePolygroups_ParamsSize = NativeReflection.GetFunctionParamsSize(EnablePolygroups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnablePolygroups_TargetMesh_PropertyAddress, EnablePolygroups_FunctionAddress, "TargetMesh");
		EnablePolygroups_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(EnablePolygroups_FunctionAddress, "TargetMesh");
		EnablePolygroups_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(EnablePolygroups_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePolygroups_Debug_PropertyAddress, EnablePolygroups_FunctionAddress, "Debug");
		EnablePolygroups_Debug_Offset = NativeReflectionCached.GetPropertyOffset(EnablePolygroups_FunctionAddress, "Debug");
		EnablePolygroups_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(EnablePolygroups_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePolygroups_ReturnValue_PropertyAddress, EnablePolygroups_FunctionAddress, "ReturnValue");
		EnablePolygroups_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EnablePolygroups_FunctionAddress, "ReturnValue");
		EnablePolygroups_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EnablePolygroups_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		EnablePolygroups_IsValid = EnablePolygroups_FunctionAddress != IntPtr.Zero && EnablePolygroups_TargetMesh_IsValid && EnablePolygroups_Debug_IsValid && EnablePolygroups_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:EnablePolygroups", EnablePolygroups_IsValid);
		DeleteTrianglesInPolygroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteTrianglesInPolygroup");
		DeleteTrianglesInPolygroup_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteTrianglesInPolygroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesInPolygroup_TargetMesh_PropertyAddress, DeleteTrianglesInPolygroup_FunctionAddress, "TargetMesh");
		DeleteTrianglesInPolygroup_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesInPolygroup_FunctionAddress, "TargetMesh");
		DeleteTrianglesInPolygroup_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesInPolygroup_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesInPolygroup_GroupLayer_PropertyAddress, DeleteTrianglesInPolygroup_FunctionAddress, "GroupLayer");
		DeleteTrianglesInPolygroup_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesInPolygroup_FunctionAddress, "GroupLayer");
		DeleteTrianglesInPolygroup_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesInPolygroup_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesInPolygroup_PolygroupID_PropertyAddress, DeleteTrianglesInPolygroup_FunctionAddress, "PolygroupID");
		DeleteTrianglesInPolygroup_PolygroupID_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesInPolygroup_FunctionAddress, "PolygroupID");
		DeleteTrianglesInPolygroup_PolygroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesInPolygroup_FunctionAddress, "PolygroupID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesInPolygroup_NumDeleted_PropertyAddress, DeleteTrianglesInPolygroup_FunctionAddress, "NumDeleted");
		DeleteTrianglesInPolygroup_NumDeleted_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesInPolygroup_FunctionAddress, "NumDeleted");
		DeleteTrianglesInPolygroup_NumDeleted_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesInPolygroup_FunctionAddress, "NumDeleted", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesInPolygroup_bDeferChangeNotifications_PropertyAddress, DeleteTrianglesInPolygroup_FunctionAddress, "bDeferChangeNotifications");
		DeleteTrianglesInPolygroup_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesInPolygroup_FunctionAddress, "bDeferChangeNotifications");
		DeleteTrianglesInPolygroup_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesInPolygroup_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesInPolygroup_Debug_PropertyAddress, DeleteTrianglesInPolygroup_FunctionAddress, "Debug");
		DeleteTrianglesInPolygroup_Debug_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesInPolygroup_FunctionAddress, "Debug");
		DeleteTrianglesInPolygroup_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesInPolygroup_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteTrianglesInPolygroup_ReturnValue_PropertyAddress, DeleteTrianglesInPolygroup_FunctionAddress, "ReturnValue");
		DeleteTrianglesInPolygroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteTrianglesInPolygroup_FunctionAddress, "ReturnValue");
		DeleteTrianglesInPolygroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteTrianglesInPolygroup_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DeleteTrianglesInPolygroup_IsValid = DeleteTrianglesInPolygroup_FunctionAddress != IntPtr.Zero && DeleteTrianglesInPolygroup_TargetMesh_IsValid && DeleteTrianglesInPolygroup_GroupLayer_IsValid && DeleteTrianglesInPolygroup_PolygroupID_IsValid && DeleteTrianglesInPolygroup_NumDeleted_IsValid && DeleteTrianglesInPolygroup_bDeferChangeNotifications_IsValid && DeleteTrianglesInPolygroup_Debug_IsValid && DeleteTrianglesInPolygroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:DeleteTrianglesInPolygroup", DeleteTrianglesInPolygroup_IsValid);
		CopyPolygroupsLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyPolygroupsLayer");
		CopyPolygroupsLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPolygroupsLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPolygroupsLayer_TargetMesh_PropertyAddress, CopyPolygroupsLayer_FunctionAddress, "TargetMesh");
		CopyPolygroupsLayer_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(CopyPolygroupsLayer_FunctionAddress, "TargetMesh");
		CopyPolygroupsLayer_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPolygroupsLayer_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPolygroupsLayer_FromGroupLayer_PropertyAddress, CopyPolygroupsLayer_FunctionAddress, "FromGroupLayer");
		CopyPolygroupsLayer_FromGroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(CopyPolygroupsLayer_FunctionAddress, "FromGroupLayer");
		CopyPolygroupsLayer_FromGroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPolygroupsLayer_FunctionAddress, "FromGroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPolygroupsLayer_ToGroupLayer_PropertyAddress, CopyPolygroupsLayer_FunctionAddress, "ToGroupLayer");
		CopyPolygroupsLayer_ToGroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(CopyPolygroupsLayer_FunctionAddress, "ToGroupLayer");
		CopyPolygroupsLayer_ToGroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPolygroupsLayer_FunctionAddress, "ToGroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPolygroupsLayer_Debug_PropertyAddress, CopyPolygroupsLayer_FunctionAddress, "Debug");
		CopyPolygroupsLayer_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CopyPolygroupsLayer_FunctionAddress, "Debug");
		CopyPolygroupsLayer_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPolygroupsLayer_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPolygroupsLayer_ReturnValue_PropertyAddress, CopyPolygroupsLayer_FunctionAddress, "ReturnValue");
		CopyPolygroupsLayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyPolygroupsLayer_FunctionAddress, "ReturnValue");
		CopyPolygroupsLayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPolygroupsLayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CopyPolygroupsLayer_IsValid = CopyPolygroupsLayer_FunctionAddress != IntPtr.Zero && CopyPolygroupsLayer_TargetMesh_IsValid && CopyPolygroupsLayer_FromGroupLayer_IsValid && CopyPolygroupsLayer_ToGroupLayer_IsValid && CopyPolygroupsLayer_Debug_IsValid && CopyPolygroupsLayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:CopyPolygroupsLayer", CopyPolygroupsLayer_IsValid);
		ConvertUVIslandsToPolygroups_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertUVIslandsToPolygroups");
		ConvertUVIslandsToPolygroups_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertUVIslandsToPolygroups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertUVIslandsToPolygroups_TargetMesh_PropertyAddress, ConvertUVIslandsToPolygroups_FunctionAddress, "TargetMesh");
		ConvertUVIslandsToPolygroups_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ConvertUVIslandsToPolygroups_FunctionAddress, "TargetMesh");
		ConvertUVIslandsToPolygroups_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertUVIslandsToPolygroups_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertUVIslandsToPolygroups_GroupLayer_PropertyAddress, ConvertUVIslandsToPolygroups_FunctionAddress, "GroupLayer");
		ConvertUVIslandsToPolygroups_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(ConvertUVIslandsToPolygroups_FunctionAddress, "GroupLayer");
		ConvertUVIslandsToPolygroups_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertUVIslandsToPolygroups_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertUVIslandsToPolygroups_UVLayer_PropertyAddress, ConvertUVIslandsToPolygroups_FunctionAddress, "UVLayer");
		ConvertUVIslandsToPolygroups_UVLayer_Offset = NativeReflectionCached.GetPropertyOffset(ConvertUVIslandsToPolygroups_FunctionAddress, "UVLayer");
		ConvertUVIslandsToPolygroups_UVLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertUVIslandsToPolygroups_FunctionAddress, "UVLayer", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertUVIslandsToPolygroups_Debug_PropertyAddress, ConvertUVIslandsToPolygroups_FunctionAddress, "Debug");
		ConvertUVIslandsToPolygroups_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ConvertUVIslandsToPolygroups_FunctionAddress, "Debug");
		ConvertUVIslandsToPolygroups_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertUVIslandsToPolygroups_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertUVIslandsToPolygroups_ReturnValue_PropertyAddress, ConvertUVIslandsToPolygroups_FunctionAddress, "ReturnValue");
		ConvertUVIslandsToPolygroups_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertUVIslandsToPolygroups_FunctionAddress, "ReturnValue");
		ConvertUVIslandsToPolygroups_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertUVIslandsToPolygroups_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ConvertUVIslandsToPolygroups_IsValid = ConvertUVIslandsToPolygroups_FunctionAddress != IntPtr.Zero && ConvertUVIslandsToPolygroups_TargetMesh_IsValid && ConvertUVIslandsToPolygroups_GroupLayer_IsValid && ConvertUVIslandsToPolygroups_UVLayer_IsValid && ConvertUVIslandsToPolygroups_Debug_IsValid && ConvertUVIslandsToPolygroups_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ConvertUVIslandsToPolygroups", ConvertUVIslandsToPolygroups_IsValid);
		ConvertComponentsToPolygroups_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertComponentsToPolygroups");
		ConvertComponentsToPolygroups_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertComponentsToPolygroups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertComponentsToPolygroups_TargetMesh_PropertyAddress, ConvertComponentsToPolygroups_FunctionAddress, "TargetMesh");
		ConvertComponentsToPolygroups_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ConvertComponentsToPolygroups_FunctionAddress, "TargetMesh");
		ConvertComponentsToPolygroups_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertComponentsToPolygroups_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertComponentsToPolygroups_GroupLayer_PropertyAddress, ConvertComponentsToPolygroups_FunctionAddress, "GroupLayer");
		ConvertComponentsToPolygroups_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(ConvertComponentsToPolygroups_FunctionAddress, "GroupLayer");
		ConvertComponentsToPolygroups_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertComponentsToPolygroups_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertComponentsToPolygroups_Debug_PropertyAddress, ConvertComponentsToPolygroups_FunctionAddress, "Debug");
		ConvertComponentsToPolygroups_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ConvertComponentsToPolygroups_FunctionAddress, "Debug");
		ConvertComponentsToPolygroups_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertComponentsToPolygroups_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertComponentsToPolygroups_ReturnValue_PropertyAddress, ConvertComponentsToPolygroups_FunctionAddress, "ReturnValue");
		ConvertComponentsToPolygroups_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertComponentsToPolygroups_FunctionAddress, "ReturnValue");
		ConvertComponentsToPolygroups_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertComponentsToPolygroups_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ConvertComponentsToPolygroups_IsValid = ConvertComponentsToPolygroups_FunctionAddress != IntPtr.Zero && ConvertComponentsToPolygroups_TargetMesh_IsValid && ConvertComponentsToPolygroups_GroupLayer_IsValid && ConvertComponentsToPolygroups_Debug_IsValid && ConvertComponentsToPolygroups_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ConvertComponentsToPolygroups", ConvertComponentsToPolygroups_IsValid);
		ComputePolygroupsFromAngleThreshold_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ComputePolygroupsFromAngleThreshold");
		ComputePolygroupsFromAngleThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputePolygroupsFromAngleThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputePolygroupsFromAngleThreshold_TargetMesh_PropertyAddress, ComputePolygroupsFromAngleThreshold_FunctionAddress, "TargetMesh");
		ComputePolygroupsFromAngleThreshold_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ComputePolygroupsFromAngleThreshold_FunctionAddress, "TargetMesh");
		ComputePolygroupsFromAngleThreshold_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputePolygroupsFromAngleThreshold_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputePolygroupsFromAngleThreshold_GroupLayer_PropertyAddress, ComputePolygroupsFromAngleThreshold_FunctionAddress, "GroupLayer");
		ComputePolygroupsFromAngleThreshold_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(ComputePolygroupsFromAngleThreshold_FunctionAddress, "GroupLayer");
		ComputePolygroupsFromAngleThreshold_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputePolygroupsFromAngleThreshold_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputePolygroupsFromAngleThreshold_CreaseAngle_PropertyAddress, ComputePolygroupsFromAngleThreshold_FunctionAddress, "CreaseAngle");
		ComputePolygroupsFromAngleThreshold_CreaseAngle_Offset = NativeReflectionCached.GetPropertyOffset(ComputePolygroupsFromAngleThreshold_FunctionAddress, "CreaseAngle");
		ComputePolygroupsFromAngleThreshold_CreaseAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputePolygroupsFromAngleThreshold_FunctionAddress, "CreaseAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputePolygroupsFromAngleThreshold_MinGroupSize_PropertyAddress, ComputePolygroupsFromAngleThreshold_FunctionAddress, "MinGroupSize");
		ComputePolygroupsFromAngleThreshold_MinGroupSize_Offset = NativeReflectionCached.GetPropertyOffset(ComputePolygroupsFromAngleThreshold_FunctionAddress, "MinGroupSize");
		ComputePolygroupsFromAngleThreshold_MinGroupSize_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputePolygroupsFromAngleThreshold_FunctionAddress, "MinGroupSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputePolygroupsFromAngleThreshold_Debug_PropertyAddress, ComputePolygroupsFromAngleThreshold_FunctionAddress, "Debug");
		ComputePolygroupsFromAngleThreshold_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ComputePolygroupsFromAngleThreshold_FunctionAddress, "Debug");
		ComputePolygroupsFromAngleThreshold_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputePolygroupsFromAngleThreshold_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputePolygroupsFromAngleThreshold_ReturnValue_PropertyAddress, ComputePolygroupsFromAngleThreshold_FunctionAddress, "ReturnValue");
		ComputePolygroupsFromAngleThreshold_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComputePolygroupsFromAngleThreshold_FunctionAddress, "ReturnValue");
		ComputePolygroupsFromAngleThreshold_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputePolygroupsFromAngleThreshold_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ComputePolygroupsFromAngleThreshold_IsValid = ComputePolygroupsFromAngleThreshold_FunctionAddress != IntPtr.Zero && ComputePolygroupsFromAngleThreshold_TargetMesh_IsValid && ComputePolygroupsFromAngleThreshold_GroupLayer_IsValid && ComputePolygroupsFromAngleThreshold_CreaseAngle_IsValid && ComputePolygroupsFromAngleThreshold_MinGroupSize_IsValid && ComputePolygroupsFromAngleThreshold_Debug_IsValid && ComputePolygroupsFromAngleThreshold_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ComputePolygroupsFromAngleThreshold", ComputePolygroupsFromAngleThreshold_IsValid);
		ClearPolygroups_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearPolygroups");
		ClearPolygroups_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearPolygroups_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearPolygroups_TargetMesh_PropertyAddress, ClearPolygroups_FunctionAddress, "TargetMesh");
		ClearPolygroups_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ClearPolygroups_FunctionAddress, "TargetMesh");
		ClearPolygroups_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearPolygroups_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearPolygroups_GroupLayer_PropertyAddress, ClearPolygroups_FunctionAddress, "GroupLayer");
		ClearPolygroups_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(ClearPolygroups_FunctionAddress, "GroupLayer");
		ClearPolygroups_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearPolygroups_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearPolygroups_ClearValue_PropertyAddress, ClearPolygroups_FunctionAddress, "ClearValue");
		ClearPolygroups_ClearValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearPolygroups_FunctionAddress, "ClearValue");
		ClearPolygroups_ClearValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearPolygroups_FunctionAddress, "ClearValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearPolygroups_Debug_PropertyAddress, ClearPolygroups_FunctionAddress, "Debug");
		ClearPolygroups_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ClearPolygroups_FunctionAddress, "Debug");
		ClearPolygroups_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearPolygroups_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearPolygroups_ReturnValue_PropertyAddress, ClearPolygroups_FunctionAddress, "ReturnValue");
		ClearPolygroups_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearPolygroups_FunctionAddress, "ReturnValue");
		ClearPolygroups_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearPolygroups_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ClearPolygroups_IsValid = ClearPolygroups_FunctionAddress != IntPtr.Zero && ClearPolygroups_TargetMesh_IsValid && ClearPolygroups_GroupLayer_IsValid && ClearPolygroups_ClearValue_IsValid && ClearPolygroups_Debug_IsValid && ClearPolygroups_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshPolygroupFunctions:ClearPolygroups", ClearPolygroups_IsValid);
	}
}
