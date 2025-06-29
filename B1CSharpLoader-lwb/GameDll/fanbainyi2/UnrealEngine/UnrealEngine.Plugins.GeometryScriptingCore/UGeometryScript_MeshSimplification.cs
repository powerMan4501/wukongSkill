using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshSimplification : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplySimplifyToVertexCount_IsValid;

	private static IntPtr ApplySimplifyToVertexCount_FunctionAddress;

	private static int ApplySimplifyToVertexCount_ParamsSize;

	private static bool ApplySimplifyToVertexCount_TargetMesh_IsValid;

	private static FFieldAddress ApplySimplifyToVertexCount_TargetMesh_PropertyAddress;

	private static int ApplySimplifyToVertexCount_TargetMesh_Offset;

	private static bool ApplySimplifyToVertexCount_VertexCount_IsValid;

	private static FFieldAddress ApplySimplifyToVertexCount_VertexCount_PropertyAddress;

	private static int ApplySimplifyToVertexCount_VertexCount_Offset;

	private static bool ApplySimplifyToVertexCount_Options_IsValid;

	private static FFieldAddress ApplySimplifyToVertexCount_Options_PropertyAddress;

	private static int ApplySimplifyToVertexCount_Options_Offset;

	private static bool ApplySimplifyToVertexCount_Debug_IsValid;

	private static FFieldAddress ApplySimplifyToVertexCount_Debug_PropertyAddress;

	private static int ApplySimplifyToVertexCount_Debug_Offset;

	private static bool ApplySimplifyToVertexCount_ReturnValue_IsValid;

	private static FFieldAddress ApplySimplifyToVertexCount_ReturnValue_PropertyAddress;

	private static int ApplySimplifyToVertexCount_ReturnValue_Offset;

	private static bool ApplySimplifyToTriangleCount_IsValid;

	private static IntPtr ApplySimplifyToTriangleCount_FunctionAddress;

	private static int ApplySimplifyToTriangleCount_ParamsSize;

	private static bool ApplySimplifyToTriangleCount_TargetMesh_IsValid;

	private static FFieldAddress ApplySimplifyToTriangleCount_TargetMesh_PropertyAddress;

	private static int ApplySimplifyToTriangleCount_TargetMesh_Offset;

	private static bool ApplySimplifyToTriangleCount_TriangleCount_IsValid;

	private static FFieldAddress ApplySimplifyToTriangleCount_TriangleCount_PropertyAddress;

	private static int ApplySimplifyToTriangleCount_TriangleCount_Offset;

	private static bool ApplySimplifyToTriangleCount_Options_IsValid;

	private static FFieldAddress ApplySimplifyToTriangleCount_Options_PropertyAddress;

	private static int ApplySimplifyToTriangleCount_Options_Offset;

	private static bool ApplySimplifyToTriangleCount_Debug_IsValid;

	private static FFieldAddress ApplySimplifyToTriangleCount_Debug_PropertyAddress;

	private static int ApplySimplifyToTriangleCount_Debug_Offset;

	private static bool ApplySimplifyToTriangleCount_ReturnValue_IsValid;

	private static FFieldAddress ApplySimplifyToTriangleCount_ReturnValue_PropertyAddress;

	private static int ApplySimplifyToTriangleCount_ReturnValue_Offset;

	private static bool ApplySimplifyToTolerance_IsValid;

	private static IntPtr ApplySimplifyToTolerance_FunctionAddress;

	private static int ApplySimplifyToTolerance_ParamsSize;

	private static bool ApplySimplifyToTolerance_TargetMesh_IsValid;

	private static FFieldAddress ApplySimplifyToTolerance_TargetMesh_PropertyAddress;

	private static int ApplySimplifyToTolerance_TargetMesh_Offset;

	private static bool ApplySimplifyToTolerance_Tolerance_IsValid;

	private static FFieldAddress ApplySimplifyToTolerance_Tolerance_PropertyAddress;

	private static int ApplySimplifyToTolerance_Tolerance_Offset;

	private static bool ApplySimplifyToTolerance_Options_IsValid;

	private static FFieldAddress ApplySimplifyToTolerance_Options_PropertyAddress;

	private static int ApplySimplifyToTolerance_Options_Offset;

	private static bool ApplySimplifyToTolerance_Debug_IsValid;

	private static FFieldAddress ApplySimplifyToTolerance_Debug_PropertyAddress;

	private static int ApplySimplifyToTolerance_Debug_Offset;

	private static bool ApplySimplifyToTolerance_ReturnValue_IsValid;

	private static FFieldAddress ApplySimplifyToTolerance_ReturnValue_PropertyAddress;

	private static int ApplySimplifyToTolerance_ReturnValue_Offset;

	private static bool ApplySimplifyToPolygroupTopology_IsValid;

	private static IntPtr ApplySimplifyToPolygroupTopology_FunctionAddress;

	private static int ApplySimplifyToPolygroupTopology_ParamsSize;

	private static bool ApplySimplifyToPolygroupTopology_TargetMesh_IsValid;

	private static FFieldAddress ApplySimplifyToPolygroupTopology_TargetMesh_PropertyAddress;

	private static int ApplySimplifyToPolygroupTopology_TargetMesh_Offset;

	private static bool ApplySimplifyToPolygroupTopology_Options_IsValid;

	private static FFieldAddress ApplySimplifyToPolygroupTopology_Options_PropertyAddress;

	private static int ApplySimplifyToPolygroupTopology_Options_Offset;

	private static bool ApplySimplifyToPolygroupTopology_GroupLayer_IsValid;

	private static FFieldAddress ApplySimplifyToPolygroupTopology_GroupLayer_PropertyAddress;

	private static int ApplySimplifyToPolygroupTopology_GroupLayer_Offset;

	private static bool ApplySimplifyToPolygroupTopology_Debug_IsValid;

	private static FFieldAddress ApplySimplifyToPolygroupTopology_Debug_PropertyAddress;

	private static int ApplySimplifyToPolygroupTopology_Debug_Offset;

	private static bool ApplySimplifyToPolygroupTopology_ReturnValue_IsValid;

	private static FFieldAddress ApplySimplifyToPolygroupTopology_ReturnValue_PropertyAddress;

	private static int ApplySimplifyToPolygroupTopology_ReturnValue_Offset;

	private static bool ApplySimplifyToPlanar_IsValid;

	private static IntPtr ApplySimplifyToPlanar_FunctionAddress;

	private static int ApplySimplifyToPlanar_ParamsSize;

	private static bool ApplySimplifyToPlanar_TargetMesh_IsValid;

	private static FFieldAddress ApplySimplifyToPlanar_TargetMesh_PropertyAddress;

	private static int ApplySimplifyToPlanar_TargetMesh_Offset;

	private static bool ApplySimplifyToPlanar_Options_IsValid;

	private static FFieldAddress ApplySimplifyToPlanar_Options_PropertyAddress;

	private static int ApplySimplifyToPlanar_Options_Offset;

	private static bool ApplySimplifyToPlanar_Debug_IsValid;

	private static FFieldAddress ApplySimplifyToPlanar_Debug_PropertyAddress;

	private static int ApplySimplifyToPlanar_Debug_Offset;

	private static bool ApplySimplifyToPlanar_ReturnValue_IsValid;

	private static FFieldAddress ApplySimplifyToPlanar_ReturnValue_PropertyAddress;

	private static int ApplySimplifyToPlanar_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToVertexCount")]
	public unsafe static UDynamicMesh ApplySimplifyToVertexCount(UDynamicMesh TargetMesh, int VertexCount, FGeometryScriptSimplifyMeshOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplySimplifyToVertexCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToVertexCount");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplySimplifyToVertexCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplySimplifyToVertexCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToVertexCount_TargetMesh_Offset), 0, ApplySimplifyToVertexCount_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToVertexCount_VertexCount_Offset), 0, ApplySimplifyToVertexCount_VertexCount_PropertyAddress.Address, VertexCount);
		NativeReflection.InitializeValue_InContainer(ApplySimplifyToVertexCount_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSimplifyMeshOptions.ToNative(IntPtr.Add(intPtr, ApplySimplifyToVertexCount_Options_Offset), 0, ApplySimplifyToVertexCount_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToVertexCount_Debug_Offset), 0, ApplySimplifyToVertexCount_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplySimplifyToVertexCount_FunctionAddress, intPtr, ApplySimplifyToVertexCount_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplySimplifyToVertexCount_ReturnValue_Offset), 0, ApplySimplifyToVertexCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToTriangleCount")]
	public unsafe static UDynamicMesh ApplySimplifyToTriangleCount(UDynamicMesh TargetMesh, int TriangleCount, FGeometryScriptSimplifyMeshOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplySimplifyToTriangleCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToTriangleCount");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplySimplifyToTriangleCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplySimplifyToTriangleCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTriangleCount_TargetMesh_Offset), 0, ApplySimplifyToTriangleCount_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTriangleCount_TriangleCount_Offset), 0, ApplySimplifyToTriangleCount_TriangleCount_PropertyAddress.Address, TriangleCount);
		NativeReflection.InitializeValue_InContainer(ApplySimplifyToTriangleCount_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSimplifyMeshOptions.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTriangleCount_Options_Offset), 0, ApplySimplifyToTriangleCount_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTriangleCount_Debug_Offset), 0, ApplySimplifyToTriangleCount_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplySimplifyToTriangleCount_FunctionAddress, intPtr, ApplySimplifyToTriangleCount_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplySimplifyToTriangleCount_ReturnValue_Offset), 0, ApplySimplifyToTriangleCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToTolerance")]
	public unsafe static UDynamicMesh ApplySimplifyToTolerance(UDynamicMesh TargetMesh, float Tolerance, FGeometryScriptSimplifyMeshOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplySimplifyToTolerance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToTolerance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplySimplifyToTolerance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplySimplifyToTolerance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTolerance_TargetMesh_Offset), 0, ApplySimplifyToTolerance_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTolerance_Tolerance_Offset), 0, ApplySimplifyToTolerance_Tolerance_PropertyAddress.Address, Tolerance);
		NativeReflection.InitializeValue_InContainer(ApplySimplifyToTolerance_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSimplifyMeshOptions.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTolerance_Options_Offset), 0, ApplySimplifyToTolerance_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToTolerance_Debug_Offset), 0, ApplySimplifyToTolerance_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplySimplifyToTolerance_FunctionAddress, intPtr, ApplySimplifyToTolerance_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplySimplifyToTolerance_ReturnValue_Offset), 0, ApplySimplifyToTolerance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToPolygroupTopology")]
	public unsafe static UDynamicMesh ApplySimplifyToPolygroupTopology(UDynamicMesh TargetMesh, FGeometryScriptPolygroupSimplifyOptions Options, FGeometryScriptGroupLayer GroupLayer, UGeometryScriptDebug Debug)
	{
		if (!ApplySimplifyToPolygroupTopology_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToPolygroupTopology");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplySimplifyToPolygroupTopology_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplySimplifyToPolygroupTopology_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToPolygroupTopology_TargetMesh_Offset), 0, ApplySimplifyToPolygroupTopology_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplySimplifyToPolygroupTopology_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptPolygroupSimplifyOptions.ToNative(IntPtr.Add(intPtr, ApplySimplifyToPolygroupTopology_Options_Offset), 0, ApplySimplifyToPolygroupTopology_Options_PropertyAddress.Address, Options);
		NativeReflection.InitializeValue_InContainer(ApplySimplifyToPolygroupTopology_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, ApplySimplifyToPolygroupTopology_GroupLayer_Offset), 0, ApplySimplifyToPolygroupTopology_GroupLayer_PropertyAddress.Address, GroupLayer);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToPolygroupTopology_Debug_Offset), 0, ApplySimplifyToPolygroupTopology_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplySimplifyToPolygroupTopology_FunctionAddress, intPtr, ApplySimplifyToPolygroupTopology_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplySimplifyToPolygroupTopology_ReturnValue_Offset), 0, ApplySimplifyToPolygroupTopology_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToPlanar")]
	public unsafe static UDynamicMesh ApplySimplifyToPlanar(UDynamicMesh TargetMesh, FGeometryScriptPlanarSimplifyOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplySimplifyToPlanar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToPlanar");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplySimplifyToPlanar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplySimplifyToPlanar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToPlanar_TargetMesh_Offset), 0, ApplySimplifyToPlanar_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplySimplifyToPlanar_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptPlanarSimplifyOptions.ToNative(IntPtr.Add(intPtr, ApplySimplifyToPlanar_Options_Offset), 0, ApplySimplifyToPlanar_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplySimplifyToPlanar_Debug_Offset), 0, ApplySimplifyToPlanar_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplySimplifyToPlanar_FunctionAddress, intPtr, ApplySimplifyToPlanar_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplySimplifyToPlanar_ReturnValue_Offset), 0, ApplySimplifyToPlanar_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshSimplification()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshSimplification)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshSimplification));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions");
		ApplySimplifyToVertexCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplySimplifyToVertexCount");
		ApplySimplifyToVertexCount_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySimplifyToVertexCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToVertexCount_TargetMesh_PropertyAddress, ApplySimplifyToVertexCount_FunctionAddress, "TargetMesh");
		ApplySimplifyToVertexCount_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToVertexCount_FunctionAddress, "TargetMesh");
		ApplySimplifyToVertexCount_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToVertexCount_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToVertexCount_VertexCount_PropertyAddress, ApplySimplifyToVertexCount_FunctionAddress, "VertexCount");
		ApplySimplifyToVertexCount_VertexCount_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToVertexCount_FunctionAddress, "VertexCount");
		ApplySimplifyToVertexCount_VertexCount_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToVertexCount_FunctionAddress, "VertexCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToVertexCount_Options_PropertyAddress, ApplySimplifyToVertexCount_FunctionAddress, "Options");
		ApplySimplifyToVertexCount_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToVertexCount_FunctionAddress, "Options");
		ApplySimplifyToVertexCount_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToVertexCount_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToVertexCount_Debug_PropertyAddress, ApplySimplifyToVertexCount_FunctionAddress, "Debug");
		ApplySimplifyToVertexCount_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToVertexCount_FunctionAddress, "Debug");
		ApplySimplifyToVertexCount_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToVertexCount_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToVertexCount_ReturnValue_PropertyAddress, ApplySimplifyToVertexCount_FunctionAddress, "ReturnValue");
		ApplySimplifyToVertexCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToVertexCount_FunctionAddress, "ReturnValue");
		ApplySimplifyToVertexCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToVertexCount_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplySimplifyToVertexCount_IsValid = ApplySimplifyToVertexCount_FunctionAddress != IntPtr.Zero && ApplySimplifyToVertexCount_TargetMesh_IsValid && ApplySimplifyToVertexCount_VertexCount_IsValid && ApplySimplifyToVertexCount_Options_IsValid && ApplySimplifyToVertexCount_Debug_IsValid && ApplySimplifyToVertexCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToVertexCount", ApplySimplifyToVertexCount_IsValid);
		ApplySimplifyToTriangleCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplySimplifyToTriangleCount");
		ApplySimplifyToTriangleCount_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySimplifyToTriangleCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTriangleCount_TargetMesh_PropertyAddress, ApplySimplifyToTriangleCount_FunctionAddress, "TargetMesh");
		ApplySimplifyToTriangleCount_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTriangleCount_FunctionAddress, "TargetMesh");
		ApplySimplifyToTriangleCount_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTriangleCount_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTriangleCount_TriangleCount_PropertyAddress, ApplySimplifyToTriangleCount_FunctionAddress, "TriangleCount");
		ApplySimplifyToTriangleCount_TriangleCount_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTriangleCount_FunctionAddress, "TriangleCount");
		ApplySimplifyToTriangleCount_TriangleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTriangleCount_FunctionAddress, "TriangleCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTriangleCount_Options_PropertyAddress, ApplySimplifyToTriangleCount_FunctionAddress, "Options");
		ApplySimplifyToTriangleCount_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTriangleCount_FunctionAddress, "Options");
		ApplySimplifyToTriangleCount_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTriangleCount_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTriangleCount_Debug_PropertyAddress, ApplySimplifyToTriangleCount_FunctionAddress, "Debug");
		ApplySimplifyToTriangleCount_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTriangleCount_FunctionAddress, "Debug");
		ApplySimplifyToTriangleCount_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTriangleCount_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTriangleCount_ReturnValue_PropertyAddress, ApplySimplifyToTriangleCount_FunctionAddress, "ReturnValue");
		ApplySimplifyToTriangleCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTriangleCount_FunctionAddress, "ReturnValue");
		ApplySimplifyToTriangleCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTriangleCount_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplySimplifyToTriangleCount_IsValid = ApplySimplifyToTriangleCount_FunctionAddress != IntPtr.Zero && ApplySimplifyToTriangleCount_TargetMesh_IsValid && ApplySimplifyToTriangleCount_TriangleCount_IsValid && ApplySimplifyToTriangleCount_Options_IsValid && ApplySimplifyToTriangleCount_Debug_IsValid && ApplySimplifyToTriangleCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToTriangleCount", ApplySimplifyToTriangleCount_IsValid);
		ApplySimplifyToTolerance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplySimplifyToTolerance");
		ApplySimplifyToTolerance_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySimplifyToTolerance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTolerance_TargetMesh_PropertyAddress, ApplySimplifyToTolerance_FunctionAddress, "TargetMesh");
		ApplySimplifyToTolerance_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTolerance_FunctionAddress, "TargetMesh");
		ApplySimplifyToTolerance_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTolerance_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTolerance_Tolerance_PropertyAddress, ApplySimplifyToTolerance_FunctionAddress, "Tolerance");
		ApplySimplifyToTolerance_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTolerance_FunctionAddress, "Tolerance");
		ApplySimplifyToTolerance_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTolerance_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTolerance_Options_PropertyAddress, ApplySimplifyToTolerance_FunctionAddress, "Options");
		ApplySimplifyToTolerance_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTolerance_FunctionAddress, "Options");
		ApplySimplifyToTolerance_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTolerance_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTolerance_Debug_PropertyAddress, ApplySimplifyToTolerance_FunctionAddress, "Debug");
		ApplySimplifyToTolerance_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTolerance_FunctionAddress, "Debug");
		ApplySimplifyToTolerance_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTolerance_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToTolerance_ReturnValue_PropertyAddress, ApplySimplifyToTolerance_FunctionAddress, "ReturnValue");
		ApplySimplifyToTolerance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToTolerance_FunctionAddress, "ReturnValue");
		ApplySimplifyToTolerance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToTolerance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplySimplifyToTolerance_IsValid = ApplySimplifyToTolerance_FunctionAddress != IntPtr.Zero && ApplySimplifyToTolerance_TargetMesh_IsValid && ApplySimplifyToTolerance_Tolerance_IsValid && ApplySimplifyToTolerance_Options_IsValid && ApplySimplifyToTolerance_Debug_IsValid && ApplySimplifyToTolerance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToTolerance", ApplySimplifyToTolerance_IsValid);
		ApplySimplifyToPolygroupTopology_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplySimplifyToPolygroupTopology");
		ApplySimplifyToPolygroupTopology_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySimplifyToPolygroupTopology_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPolygroupTopology_TargetMesh_PropertyAddress, ApplySimplifyToPolygroupTopology_FunctionAddress, "TargetMesh");
		ApplySimplifyToPolygroupTopology_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPolygroupTopology_FunctionAddress, "TargetMesh");
		ApplySimplifyToPolygroupTopology_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPolygroupTopology_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPolygroupTopology_Options_PropertyAddress, ApplySimplifyToPolygroupTopology_FunctionAddress, "Options");
		ApplySimplifyToPolygroupTopology_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPolygroupTopology_FunctionAddress, "Options");
		ApplySimplifyToPolygroupTopology_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPolygroupTopology_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPolygroupTopology_GroupLayer_PropertyAddress, ApplySimplifyToPolygroupTopology_FunctionAddress, "GroupLayer");
		ApplySimplifyToPolygroupTopology_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPolygroupTopology_FunctionAddress, "GroupLayer");
		ApplySimplifyToPolygroupTopology_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPolygroupTopology_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPolygroupTopology_Debug_PropertyAddress, ApplySimplifyToPolygroupTopology_FunctionAddress, "Debug");
		ApplySimplifyToPolygroupTopology_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPolygroupTopology_FunctionAddress, "Debug");
		ApplySimplifyToPolygroupTopology_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPolygroupTopology_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPolygroupTopology_ReturnValue_PropertyAddress, ApplySimplifyToPolygroupTopology_FunctionAddress, "ReturnValue");
		ApplySimplifyToPolygroupTopology_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPolygroupTopology_FunctionAddress, "ReturnValue");
		ApplySimplifyToPolygroupTopology_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPolygroupTopology_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplySimplifyToPolygroupTopology_IsValid = ApplySimplifyToPolygroupTopology_FunctionAddress != IntPtr.Zero && ApplySimplifyToPolygroupTopology_TargetMesh_IsValid && ApplySimplifyToPolygroupTopology_Options_IsValid && ApplySimplifyToPolygroupTopology_GroupLayer_IsValid && ApplySimplifyToPolygroupTopology_Debug_IsValid && ApplySimplifyToPolygroupTopology_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToPolygroupTopology", ApplySimplifyToPolygroupTopology_IsValid);
		ApplySimplifyToPlanar_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplySimplifyToPlanar");
		ApplySimplifyToPlanar_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySimplifyToPlanar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPlanar_TargetMesh_PropertyAddress, ApplySimplifyToPlanar_FunctionAddress, "TargetMesh");
		ApplySimplifyToPlanar_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPlanar_FunctionAddress, "TargetMesh");
		ApplySimplifyToPlanar_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPlanar_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPlanar_Options_PropertyAddress, ApplySimplifyToPlanar_FunctionAddress, "Options");
		ApplySimplifyToPlanar_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPlanar_FunctionAddress, "Options");
		ApplySimplifyToPlanar_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPlanar_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPlanar_Debug_PropertyAddress, ApplySimplifyToPlanar_FunctionAddress, "Debug");
		ApplySimplifyToPlanar_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPlanar_FunctionAddress, "Debug");
		ApplySimplifyToPlanar_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPlanar_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplySimplifyToPlanar_ReturnValue_PropertyAddress, ApplySimplifyToPlanar_FunctionAddress, "ReturnValue");
		ApplySimplifyToPlanar_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplySimplifyToPlanar_FunctionAddress, "ReturnValue");
		ApplySimplifyToPlanar_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySimplifyToPlanar_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplySimplifyToPlanar_IsValid = ApplySimplifyToPlanar_FunctionAddress != IntPtr.Zero && ApplySimplifyToPlanar_TargetMesh_IsValid && ApplySimplifyToPlanar_Options_IsValid && ApplySimplifyToPlanar_Debug_IsValid && ApplySimplifyToPlanar_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSimplifyFunctions:ApplySimplifyToPlanar", ApplySimplifyToPlanar_IsValid);
	}
}
