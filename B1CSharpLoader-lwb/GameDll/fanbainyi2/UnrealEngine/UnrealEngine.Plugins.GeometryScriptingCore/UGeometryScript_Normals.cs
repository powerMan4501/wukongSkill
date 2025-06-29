using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_Normals : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetPerVertexNormals_IsValid;

	private static IntPtr SetPerVertexNormals_FunctionAddress;

	private static int SetPerVertexNormals_ParamsSize;

	private static bool SetPerVertexNormals_TargetMesh_IsValid;

	private static FFieldAddress SetPerVertexNormals_TargetMesh_PropertyAddress;

	private static int SetPerVertexNormals_TargetMesh_Offset;

	private static bool SetPerVertexNormals_Debug_IsValid;

	private static FFieldAddress SetPerVertexNormals_Debug_PropertyAddress;

	private static int SetPerVertexNormals_Debug_Offset;

	private static bool SetPerVertexNormals_ReturnValue_IsValid;

	private static FFieldAddress SetPerVertexNormals_ReturnValue_PropertyAddress;

	private static int SetPerVertexNormals_ReturnValue_Offset;

	private static bool SetPerFaceNormals_IsValid;

	private static IntPtr SetPerFaceNormals_FunctionAddress;

	private static int SetPerFaceNormals_ParamsSize;

	private static bool SetPerFaceNormals_TargetMesh_IsValid;

	private static FFieldAddress SetPerFaceNormals_TargetMesh_PropertyAddress;

	private static int SetPerFaceNormals_TargetMesh_Offset;

	private static bool SetPerFaceNormals_Debug_IsValid;

	private static FFieldAddress SetPerFaceNormals_Debug_PropertyAddress;

	private static int SetPerFaceNormals_Debug_Offset;

	private static bool SetPerFaceNormals_ReturnValue_IsValid;

	private static FFieldAddress SetPerFaceNormals_ReturnValue_PropertyAddress;

	private static int SetPerFaceNormals_ReturnValue_Offset;

	private static bool SetMeshTriangleNormals_IsValid;

	private static IntPtr SetMeshTriangleNormals_FunctionAddress;

	private static int SetMeshTriangleNormals_ParamsSize;

	private static bool SetMeshTriangleNormals_TargetMesh_IsValid;

	private static FFieldAddress SetMeshTriangleNormals_TargetMesh_PropertyAddress;

	private static int SetMeshTriangleNormals_TargetMesh_Offset;

	private static bool SetMeshTriangleNormals_TriangleID_IsValid;

	private static FFieldAddress SetMeshTriangleNormals_TriangleID_PropertyAddress;

	private static int SetMeshTriangleNormals_TriangleID_Offset;

	private static bool SetMeshTriangleNormals_Normals_IsValid;

	private static FFieldAddress SetMeshTriangleNormals_Normals_PropertyAddress;

	private static int SetMeshTriangleNormals_Normals_Offset;

	private static bool SetMeshTriangleNormals_bIsValidTriangle_IsValid;

	private static FFieldAddress SetMeshTriangleNormals_bIsValidTriangle_PropertyAddress;

	private static int SetMeshTriangleNormals_bIsValidTriangle_Offset;

	private static bool SetMeshTriangleNormals_bDeferChangeNotifications_IsValid;

	private static FFieldAddress SetMeshTriangleNormals_bDeferChangeNotifications_PropertyAddress;

	private static int SetMeshTriangleNormals_bDeferChangeNotifications_Offset;

	private static bool SetMeshTriangleNormals_ReturnValue_IsValid;

	private static FFieldAddress SetMeshTriangleNormals_ReturnValue_PropertyAddress;

	private static int SetMeshTriangleNormals_ReturnValue_Offset;

	private static bool RecomputeNormals_IsValid;

	private static IntPtr RecomputeNormals_FunctionAddress;

	private static int RecomputeNormals_ParamsSize;

	private static bool RecomputeNormals_TargetMesh_IsValid;

	private static FFieldAddress RecomputeNormals_TargetMesh_PropertyAddress;

	private static int RecomputeNormals_TargetMesh_Offset;

	private static bool RecomputeNormals_CalculateOptions_IsValid;

	private static FFieldAddress RecomputeNormals_CalculateOptions_PropertyAddress;

	private static int RecomputeNormals_CalculateOptions_Offset;

	private static bool RecomputeNormals_Debug_IsValid;

	private static FFieldAddress RecomputeNormals_Debug_PropertyAddress;

	private static int RecomputeNormals_Debug_Offset;

	private static bool RecomputeNormals_ReturnValue_IsValid;

	private static FFieldAddress RecomputeNormals_ReturnValue_PropertyAddress;

	private static int RecomputeNormals_ReturnValue_Offset;

	private static bool FlipNormals_IsValid;

	private static IntPtr FlipNormals_FunctionAddress;

	private static int FlipNormals_ParamsSize;

	private static bool FlipNormals_TargetMesh_IsValid;

	private static FFieldAddress FlipNormals_TargetMesh_PropertyAddress;

	private static int FlipNormals_TargetMesh_Offset;

	private static bool FlipNormals_Debug_IsValid;

	private static FFieldAddress FlipNormals_Debug_PropertyAddress;

	private static int FlipNormals_Debug_Offset;

	private static bool FlipNormals_ReturnValue_IsValid;

	private static FFieldAddress FlipNormals_ReturnValue_PropertyAddress;

	private static int FlipNormals_ReturnValue_Offset;

	private static bool ComputeTangents_IsValid;

	private static IntPtr ComputeTangents_FunctionAddress;

	private static int ComputeTangents_ParamsSize;

	private static bool ComputeTangents_TargetMesh_IsValid;

	private static FFieldAddress ComputeTangents_TargetMesh_PropertyAddress;

	private static int ComputeTangents_TargetMesh_Offset;

	private static bool ComputeTangents_Options_IsValid;

	private static FFieldAddress ComputeTangents_Options_PropertyAddress;

	private static int ComputeTangents_Options_Offset;

	private static bool ComputeTangents_Debug_IsValid;

	private static FFieldAddress ComputeTangents_Debug_PropertyAddress;

	private static int ComputeTangents_Debug_Offset;

	private static bool ComputeTangents_ReturnValue_IsValid;

	private static FFieldAddress ComputeTangents_ReturnValue_PropertyAddress;

	private static int ComputeTangents_ReturnValue_Offset;

	private static bool ComputeSplitNormals_IsValid;

	private static IntPtr ComputeSplitNormals_FunctionAddress;

	private static int ComputeSplitNormals_ParamsSize;

	private static bool ComputeSplitNormals_TargetMesh_IsValid;

	private static FFieldAddress ComputeSplitNormals_TargetMesh_PropertyAddress;

	private static int ComputeSplitNormals_TargetMesh_Offset;

	private static bool ComputeSplitNormals_SplitOptions_IsValid;

	private static FFieldAddress ComputeSplitNormals_SplitOptions_PropertyAddress;

	private static int ComputeSplitNormals_SplitOptions_Offset;

	private static bool ComputeSplitNormals_CalculateOptions_IsValid;

	private static FFieldAddress ComputeSplitNormals_CalculateOptions_PropertyAddress;

	private static int ComputeSplitNormals_CalculateOptions_Offset;

	private static bool ComputeSplitNormals_Debug_IsValid;

	private static FFieldAddress ComputeSplitNormals_Debug_PropertyAddress;

	private static int ComputeSplitNormals_Debug_Offset;

	private static bool ComputeSplitNormals_ReturnValue_IsValid;

	private static FFieldAddress ComputeSplitNormals_ReturnValue_PropertyAddress;

	private static int ComputeSplitNormals_ReturnValue_Offset;

	private static bool AutoRepairNormals_IsValid;

	private static IntPtr AutoRepairNormals_FunctionAddress;

	private static int AutoRepairNormals_ParamsSize;

	private static bool AutoRepairNormals_TargetMesh_IsValid;

	private static FFieldAddress AutoRepairNormals_TargetMesh_PropertyAddress;

	private static int AutoRepairNormals_TargetMesh_Offset;

	private static bool AutoRepairNormals_Debug_IsValid;

	private static FFieldAddress AutoRepairNormals_Debug_PropertyAddress;

	private static int AutoRepairNormals_Debug_Offset;

	private static bool AutoRepairNormals_ReturnValue_IsValid;

	private static FFieldAddress AutoRepairNormals_ReturnValue_PropertyAddress;

	private static int AutoRepairNormals_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetPerVertexNormals")]
	public unsafe static UDynamicMesh SetPerVertexNormals(UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		if (!SetPerVertexNormals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetPerVertexNormals");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPerVertexNormals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPerVertexNormals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetPerVertexNormals_TargetMesh_Offset), 0, SetPerVertexNormals_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetPerVertexNormals_Debug_Offset), 0, SetPerVertexNormals_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPerVertexNormals_FunctionAddress, intPtr, SetPerVertexNormals_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetPerVertexNormals_ReturnValue_Offset), 0, SetPerVertexNormals_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetPerFaceNormals")]
	public unsafe static UDynamicMesh SetPerFaceNormals(UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		if (!SetPerFaceNormals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetPerFaceNormals");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPerFaceNormals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPerFaceNormals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetPerFaceNormals_TargetMesh_Offset), 0, SetPerFaceNormals_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetPerFaceNormals_Debug_Offset), 0, SetPerFaceNormals_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPerFaceNormals_FunctionAddress, intPtr, SetPerFaceNormals_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetPerFaceNormals_ReturnValue_Offset), 0, SetPerFaceNormals_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetMeshTriangleNormals")]
	public unsafe static UDynamicMesh SetMeshTriangleNormals(UDynamicMesh TargetMesh, int TriangleID, FGeometryScriptTriangle Normals, out bool bIsValidTriangle, bool bDeferChangeNotifications = false)
	{
		if (!SetMeshTriangleNormals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetMeshTriangleNormals");
			bIsValidTriangle = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshTriangleNormals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshTriangleNormals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetMeshTriangleNormals_TargetMesh_Offset), 0, SetMeshTriangleNormals_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMeshTriangleNormals_TriangleID_Offset), 0, SetMeshTriangleNormals_TriangleID_PropertyAddress.Address, TriangleID);
		NativeReflection.InitializeValue_InContainer(SetMeshTriangleNormals_Normals_PropertyAddress.Address, intPtr);
		FGeometryScriptTriangle.ToNative(IntPtr.Add(intPtr, SetMeshTriangleNormals_Normals_Offset), 0, SetMeshTriangleNormals_Normals_PropertyAddress.Address, Normals);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMeshTriangleNormals_bDeferChangeNotifications_Offset), 0, SetMeshTriangleNormals_bDeferChangeNotifications_PropertyAddress.Address, bDeferChangeNotifications);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMeshTriangleNormals_FunctionAddress, intPtr, SetMeshTriangleNormals_ParamsSize);
		bIsValidTriangle = BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMeshTriangleNormals_bIsValidTriangle_Offset), 0, SetMeshTriangleNormals_bIsValidTriangle_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetMeshTriangleNormals_ReturnValue_Offset), 0, SetMeshTriangleNormals_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:RecomputeNormals")]
	public unsafe static UDynamicMesh RecomputeNormals(UDynamicMesh TargetMesh, FGeometryScriptCalculateNormalsOptions CalculateOptions, UGeometryScriptDebug Debug)
	{
		if (!RecomputeNormals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:RecomputeNormals");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputeNormals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputeNormals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RecomputeNormals_TargetMesh_Offset), 0, RecomputeNormals_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(RecomputeNormals_CalculateOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptCalculateNormalsOptions.ToNative(IntPtr.Add(intPtr, RecomputeNormals_CalculateOptions_Offset), 0, RecomputeNormals_CalculateOptions_PropertyAddress.Address, CalculateOptions);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RecomputeNormals_Debug_Offset), 0, RecomputeNormals_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecomputeNormals_FunctionAddress, intPtr, RecomputeNormals_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RecomputeNormals_ReturnValue_Offset), 0, RecomputeNormals_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:FlipNormals")]
	public unsafe static UDynamicMesh FlipNormals(UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		if (!FlipNormals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:FlipNormals");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlipNormals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlipNormals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, FlipNormals_TargetMesh_Offset), 0, FlipNormals_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, FlipNormals_Debug_Offset), 0, FlipNormals_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FlipNormals_FunctionAddress, intPtr, FlipNormals_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, FlipNormals_ReturnValue_Offset), 0, FlipNormals_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:ComputeTangents")]
	public unsafe static UDynamicMesh ComputeTangents(UDynamicMesh TargetMesh, FGeometryScriptTangentsOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ComputeTangents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:ComputeTangents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputeTangents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputeTangents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ComputeTangents_TargetMesh_Offset), 0, ComputeTangents_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ComputeTangents_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptTangentsOptions.ToNative(IntPtr.Add(intPtr, ComputeTangents_Options_Offset), 0, ComputeTangents_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ComputeTangents_Debug_Offset), 0, ComputeTangents_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ComputeTangents_FunctionAddress, intPtr, ComputeTangents_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeTangents_ReturnValue_Offset), 0, ComputeTangents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:ComputeSplitNormals")]
	public unsafe static UDynamicMesh ComputeSplitNormals(UDynamicMesh TargetMesh, FGeometryScriptSplitNormalsOptions SplitOptions, FGeometryScriptCalculateNormalsOptions CalculateOptions, UGeometryScriptDebug Debug)
	{
		if (!ComputeSplitNormals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:ComputeSplitNormals");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputeSplitNormals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputeSplitNormals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ComputeSplitNormals_TargetMesh_Offset), 0, ComputeSplitNormals_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ComputeSplitNormals_SplitOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptSplitNormalsOptions.ToNative(IntPtr.Add(intPtr, ComputeSplitNormals_SplitOptions_Offset), 0, ComputeSplitNormals_SplitOptions_PropertyAddress.Address, SplitOptions);
		NativeReflection.InitializeValue_InContainer(ComputeSplitNormals_CalculateOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptCalculateNormalsOptions.ToNative(IntPtr.Add(intPtr, ComputeSplitNormals_CalculateOptions_Offset), 0, ComputeSplitNormals_CalculateOptions_PropertyAddress.Address, CalculateOptions);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ComputeSplitNormals_Debug_Offset), 0, ComputeSplitNormals_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ComputeSplitNormals_FunctionAddress, intPtr, ComputeSplitNormals_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeSplitNormals_ReturnValue_Offset), 0, ComputeSplitNormals_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:AutoRepairNormals")]
	public unsafe static UDynamicMesh AutoRepairNormals(UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		if (!AutoRepairNormals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:AutoRepairNormals");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutoRepairNormals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutoRepairNormals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, AutoRepairNormals_TargetMesh_Offset), 0, AutoRepairNormals_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, AutoRepairNormals_Debug_Offset), 0, AutoRepairNormals_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutoRepairNormals_FunctionAddress, intPtr, AutoRepairNormals_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, AutoRepairNormals_ReturnValue_Offset), 0, AutoRepairNormals_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_Normals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_Normals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_Normals));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions");
		SetPerVertexNormals_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPerVertexNormals");
		SetPerVertexNormals_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPerVertexNormals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPerVertexNormals_TargetMesh_PropertyAddress, SetPerVertexNormals_FunctionAddress, "TargetMesh");
		SetPerVertexNormals_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetPerVertexNormals_FunctionAddress, "TargetMesh");
		SetPerVertexNormals_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPerVertexNormals_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPerVertexNormals_Debug_PropertyAddress, SetPerVertexNormals_FunctionAddress, "Debug");
		SetPerVertexNormals_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetPerVertexNormals_FunctionAddress, "Debug");
		SetPerVertexNormals_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPerVertexNormals_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPerVertexNormals_ReturnValue_PropertyAddress, SetPerVertexNormals_FunctionAddress, "ReturnValue");
		SetPerVertexNormals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPerVertexNormals_FunctionAddress, "ReturnValue");
		SetPerVertexNormals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPerVertexNormals_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetPerVertexNormals_IsValid = SetPerVertexNormals_FunctionAddress != IntPtr.Zero && SetPerVertexNormals_TargetMesh_IsValid && SetPerVertexNormals_Debug_IsValid && SetPerVertexNormals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetPerVertexNormals", SetPerVertexNormals_IsValid);
		SetPerFaceNormals_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPerFaceNormals");
		SetPerFaceNormals_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPerFaceNormals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPerFaceNormals_TargetMesh_PropertyAddress, SetPerFaceNormals_FunctionAddress, "TargetMesh");
		SetPerFaceNormals_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetPerFaceNormals_FunctionAddress, "TargetMesh");
		SetPerFaceNormals_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPerFaceNormals_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPerFaceNormals_Debug_PropertyAddress, SetPerFaceNormals_FunctionAddress, "Debug");
		SetPerFaceNormals_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetPerFaceNormals_FunctionAddress, "Debug");
		SetPerFaceNormals_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPerFaceNormals_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPerFaceNormals_ReturnValue_PropertyAddress, SetPerFaceNormals_FunctionAddress, "ReturnValue");
		SetPerFaceNormals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPerFaceNormals_FunctionAddress, "ReturnValue");
		SetPerFaceNormals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPerFaceNormals_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetPerFaceNormals_IsValid = SetPerFaceNormals_FunctionAddress != IntPtr.Zero && SetPerFaceNormals_TargetMesh_IsValid && SetPerFaceNormals_Debug_IsValid && SetPerFaceNormals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetPerFaceNormals", SetPerFaceNormals_IsValid);
		SetMeshTriangleNormals_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMeshTriangleNormals");
		SetMeshTriangleNormals_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshTriangleNormals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleNormals_TargetMesh_PropertyAddress, SetMeshTriangleNormals_FunctionAddress, "TargetMesh");
		SetMeshTriangleNormals_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleNormals_FunctionAddress, "TargetMesh");
		SetMeshTriangleNormals_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleNormals_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleNormals_TriangleID_PropertyAddress, SetMeshTriangleNormals_FunctionAddress, "TriangleID");
		SetMeshTriangleNormals_TriangleID_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleNormals_FunctionAddress, "TriangleID");
		SetMeshTriangleNormals_TriangleID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleNormals_FunctionAddress, "TriangleID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleNormals_Normals_PropertyAddress, SetMeshTriangleNormals_FunctionAddress, "Normals");
		SetMeshTriangleNormals_Normals_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleNormals_FunctionAddress, "Normals");
		SetMeshTriangleNormals_Normals_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleNormals_FunctionAddress, "Normals", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleNormals_bIsValidTriangle_PropertyAddress, SetMeshTriangleNormals_FunctionAddress, "bIsValidTriangle");
		SetMeshTriangleNormals_bIsValidTriangle_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleNormals_FunctionAddress, "bIsValidTriangle");
		SetMeshTriangleNormals_bIsValidTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleNormals_FunctionAddress, "bIsValidTriangle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleNormals_bDeferChangeNotifications_PropertyAddress, SetMeshTriangleNormals_FunctionAddress, "bDeferChangeNotifications");
		SetMeshTriangleNormals_bDeferChangeNotifications_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleNormals_FunctionAddress, "bDeferChangeNotifications");
		SetMeshTriangleNormals_bDeferChangeNotifications_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleNormals_FunctionAddress, "bDeferChangeNotifications", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshTriangleNormals_ReturnValue_PropertyAddress, SetMeshTriangleNormals_FunctionAddress, "ReturnValue");
		SetMeshTriangleNormals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshTriangleNormals_FunctionAddress, "ReturnValue");
		SetMeshTriangleNormals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshTriangleNormals_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMeshTriangleNormals_IsValid = SetMeshTriangleNormals_FunctionAddress != IntPtr.Zero && SetMeshTriangleNormals_TargetMesh_IsValid && SetMeshTriangleNormals_TriangleID_IsValid && SetMeshTriangleNormals_Normals_IsValid && SetMeshTriangleNormals_bIsValidTriangle_IsValid && SetMeshTriangleNormals_bDeferChangeNotifications_IsValid && SetMeshTriangleNormals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:SetMeshTriangleNormals", SetMeshTriangleNormals_IsValid);
		RecomputeNormals_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecomputeNormals");
		RecomputeNormals_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeNormals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_TargetMesh_PropertyAddress, RecomputeNormals_FunctionAddress, "TargetMesh");
		RecomputeNormals_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeNormals_FunctionAddress, "TargetMesh");
		RecomputeNormals_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeNormals_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_CalculateOptions_PropertyAddress, RecomputeNormals_FunctionAddress, "CalculateOptions");
		RecomputeNormals_CalculateOptions_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeNormals_FunctionAddress, "CalculateOptions");
		RecomputeNormals_CalculateOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeNormals_FunctionAddress, "CalculateOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_Debug_PropertyAddress, RecomputeNormals_FunctionAddress, "Debug");
		RecomputeNormals_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeNormals_FunctionAddress, "Debug");
		RecomputeNormals_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeNormals_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_ReturnValue_PropertyAddress, RecomputeNormals_FunctionAddress, "ReturnValue");
		RecomputeNormals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RecomputeNormals_FunctionAddress, "ReturnValue");
		RecomputeNormals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RecomputeNormals_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RecomputeNormals_IsValid = RecomputeNormals_FunctionAddress != IntPtr.Zero && RecomputeNormals_TargetMesh_IsValid && RecomputeNormals_CalculateOptions_IsValid && RecomputeNormals_Debug_IsValid && RecomputeNormals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:RecomputeNormals", RecomputeNormals_IsValid);
		FlipNormals_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FlipNormals");
		FlipNormals_ParamsSize = NativeReflection.GetFunctionParamsSize(FlipNormals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FlipNormals_TargetMesh_PropertyAddress, FlipNormals_FunctionAddress, "TargetMesh");
		FlipNormals_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(FlipNormals_FunctionAddress, "TargetMesh");
		FlipNormals_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(FlipNormals_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipNormals_Debug_PropertyAddress, FlipNormals_FunctionAddress, "Debug");
		FlipNormals_Debug_Offset = NativeReflectionCached.GetPropertyOffset(FlipNormals_FunctionAddress, "Debug");
		FlipNormals_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(FlipNormals_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipNormals_ReturnValue_PropertyAddress, FlipNormals_FunctionAddress, "ReturnValue");
		FlipNormals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FlipNormals_FunctionAddress, "ReturnValue");
		FlipNormals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FlipNormals_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FlipNormals_IsValid = FlipNormals_FunctionAddress != IntPtr.Zero && FlipNormals_TargetMesh_IsValid && FlipNormals_Debug_IsValid && FlipNormals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:FlipNormals", FlipNormals_IsValid);
		ComputeTangents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ComputeTangents");
		ComputeTangents_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputeTangents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputeTangents_TargetMesh_PropertyAddress, ComputeTangents_FunctionAddress, "TargetMesh");
		ComputeTangents_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ComputeTangents_FunctionAddress, "TargetMesh");
		ComputeTangents_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeTangents_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeTangents_Options_PropertyAddress, ComputeTangents_FunctionAddress, "Options");
		ComputeTangents_Options_Offset = NativeReflectionCached.GetPropertyOffset(ComputeTangents_FunctionAddress, "Options");
		ComputeTangents_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeTangents_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeTangents_Debug_PropertyAddress, ComputeTangents_FunctionAddress, "Debug");
		ComputeTangents_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ComputeTangents_FunctionAddress, "Debug");
		ComputeTangents_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeTangents_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeTangents_ReturnValue_PropertyAddress, ComputeTangents_FunctionAddress, "ReturnValue");
		ComputeTangents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComputeTangents_FunctionAddress, "ReturnValue");
		ComputeTangents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeTangents_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ComputeTangents_IsValid = ComputeTangents_FunctionAddress != IntPtr.Zero && ComputeTangents_TargetMesh_IsValid && ComputeTangents_Options_IsValid && ComputeTangents_Debug_IsValid && ComputeTangents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:ComputeTangents", ComputeTangents_IsValid);
		ComputeSplitNormals_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ComputeSplitNormals");
		ComputeSplitNormals_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputeSplitNormals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputeSplitNormals_TargetMesh_PropertyAddress, ComputeSplitNormals_FunctionAddress, "TargetMesh");
		ComputeSplitNormals_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ComputeSplitNormals_FunctionAddress, "TargetMesh");
		ComputeSplitNormals_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeSplitNormals_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeSplitNormals_SplitOptions_PropertyAddress, ComputeSplitNormals_FunctionAddress, "SplitOptions");
		ComputeSplitNormals_SplitOptions_Offset = NativeReflectionCached.GetPropertyOffset(ComputeSplitNormals_FunctionAddress, "SplitOptions");
		ComputeSplitNormals_SplitOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeSplitNormals_FunctionAddress, "SplitOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeSplitNormals_CalculateOptions_PropertyAddress, ComputeSplitNormals_FunctionAddress, "CalculateOptions");
		ComputeSplitNormals_CalculateOptions_Offset = NativeReflectionCached.GetPropertyOffset(ComputeSplitNormals_FunctionAddress, "CalculateOptions");
		ComputeSplitNormals_CalculateOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeSplitNormals_FunctionAddress, "CalculateOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeSplitNormals_Debug_PropertyAddress, ComputeSplitNormals_FunctionAddress, "Debug");
		ComputeSplitNormals_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ComputeSplitNormals_FunctionAddress, "Debug");
		ComputeSplitNormals_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeSplitNormals_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeSplitNormals_ReturnValue_PropertyAddress, ComputeSplitNormals_FunctionAddress, "ReturnValue");
		ComputeSplitNormals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComputeSplitNormals_FunctionAddress, "ReturnValue");
		ComputeSplitNormals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeSplitNormals_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ComputeSplitNormals_IsValid = ComputeSplitNormals_FunctionAddress != IntPtr.Zero && ComputeSplitNormals_TargetMesh_IsValid && ComputeSplitNormals_SplitOptions_IsValid && ComputeSplitNormals_CalculateOptions_IsValid && ComputeSplitNormals_Debug_IsValid && ComputeSplitNormals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:ComputeSplitNormals", ComputeSplitNormals_IsValid);
		AutoRepairNormals_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutoRepairNormals");
		AutoRepairNormals_ParamsSize = NativeReflection.GetFunctionParamsSize(AutoRepairNormals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutoRepairNormals_TargetMesh_PropertyAddress, AutoRepairNormals_FunctionAddress, "TargetMesh");
		AutoRepairNormals_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(AutoRepairNormals_FunctionAddress, "TargetMesh");
		AutoRepairNormals_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoRepairNormals_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoRepairNormals_Debug_PropertyAddress, AutoRepairNormals_FunctionAddress, "Debug");
		AutoRepairNormals_Debug_Offset = NativeReflectionCached.GetPropertyOffset(AutoRepairNormals_FunctionAddress, "Debug");
		AutoRepairNormals_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoRepairNormals_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoRepairNormals_ReturnValue_PropertyAddress, AutoRepairNormals_FunctionAddress, "ReturnValue");
		AutoRepairNormals_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AutoRepairNormals_FunctionAddress, "ReturnValue");
		AutoRepairNormals_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AutoRepairNormals_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AutoRepairNormals_IsValid = AutoRepairNormals_FunctionAddress != IntPtr.Zero && AutoRepairNormals_TargetMesh_IsValid && AutoRepairNormals_Debug_IsValid && AutoRepairNormals_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshNormalsFunctions:AutoRepairNormals", AutoRepairNormals_IsValid);
	}
}
