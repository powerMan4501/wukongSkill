using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshBooleans : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplyMeshSelfUnion_IsValid;

	private static IntPtr ApplyMeshSelfUnion_FunctionAddress;

	private static int ApplyMeshSelfUnion_ParamsSize;

	private static bool ApplyMeshSelfUnion_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshSelfUnion_TargetMesh_PropertyAddress;

	private static int ApplyMeshSelfUnion_TargetMesh_Offset;

	private static bool ApplyMeshSelfUnion_Options_IsValid;

	private static FFieldAddress ApplyMeshSelfUnion_Options_PropertyAddress;

	private static int ApplyMeshSelfUnion_Options_Offset;

	private static bool ApplyMeshSelfUnion_Debug_IsValid;

	private static FFieldAddress ApplyMeshSelfUnion_Debug_PropertyAddress;

	private static int ApplyMeshSelfUnion_Debug_Offset;

	private static bool ApplyMeshSelfUnion_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshSelfUnion_ReturnValue_PropertyAddress;

	private static int ApplyMeshSelfUnion_ReturnValue_Offset;

	private static bool ApplyMeshPlaneSlice_IsValid;

	private static IntPtr ApplyMeshPlaneSlice_FunctionAddress;

	private static int ApplyMeshPlaneSlice_ParamsSize;

	private static bool ApplyMeshPlaneSlice_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshPlaneSlice_TargetMesh_PropertyAddress;

	private static int ApplyMeshPlaneSlice_TargetMesh_Offset;

	private static bool ApplyMeshPlaneSlice_CutFrame_IsValid;

	private static FFieldAddress ApplyMeshPlaneSlice_CutFrame_PropertyAddress;

	private static int ApplyMeshPlaneSlice_CutFrame_Offset;

	private static bool ApplyMeshPlaneSlice_Options_IsValid;

	private static FFieldAddress ApplyMeshPlaneSlice_Options_PropertyAddress;

	private static int ApplyMeshPlaneSlice_Options_Offset;

	private static bool ApplyMeshPlaneSlice_Debug_IsValid;

	private static FFieldAddress ApplyMeshPlaneSlice_Debug_PropertyAddress;

	private static int ApplyMeshPlaneSlice_Debug_Offset;

	private static bool ApplyMeshPlaneSlice_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshPlaneSlice_ReturnValue_PropertyAddress;

	private static int ApplyMeshPlaneSlice_ReturnValue_Offset;

	private static bool ApplyMeshPlaneCut_IsValid;

	private static IntPtr ApplyMeshPlaneCut_FunctionAddress;

	private static int ApplyMeshPlaneCut_ParamsSize;

	private static bool ApplyMeshPlaneCut_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshPlaneCut_TargetMesh_PropertyAddress;

	private static int ApplyMeshPlaneCut_TargetMesh_Offset;

	private static bool ApplyMeshPlaneCut_CutFrame_IsValid;

	private static FFieldAddress ApplyMeshPlaneCut_CutFrame_PropertyAddress;

	private static int ApplyMeshPlaneCut_CutFrame_Offset;

	private static bool ApplyMeshPlaneCut_Options_IsValid;

	private static FFieldAddress ApplyMeshPlaneCut_Options_PropertyAddress;

	private static int ApplyMeshPlaneCut_Options_Offset;

	private static bool ApplyMeshPlaneCut_Debug_IsValid;

	private static FFieldAddress ApplyMeshPlaneCut_Debug_PropertyAddress;

	private static int ApplyMeshPlaneCut_Debug_Offset;

	private static bool ApplyMeshPlaneCut_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshPlaneCut_ReturnValue_PropertyAddress;

	private static int ApplyMeshPlaneCut_ReturnValue_Offset;

	private static bool ApplyMeshMirror_IsValid;

	private static IntPtr ApplyMeshMirror_FunctionAddress;

	private static int ApplyMeshMirror_ParamsSize;

	private static bool ApplyMeshMirror_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshMirror_TargetMesh_PropertyAddress;

	private static int ApplyMeshMirror_TargetMesh_Offset;

	private static bool ApplyMeshMirror_MirrorFrame_IsValid;

	private static FFieldAddress ApplyMeshMirror_MirrorFrame_PropertyAddress;

	private static int ApplyMeshMirror_MirrorFrame_Offset;

	private static bool ApplyMeshMirror_Options_IsValid;

	private static FFieldAddress ApplyMeshMirror_Options_PropertyAddress;

	private static int ApplyMeshMirror_Options_Offset;

	private static bool ApplyMeshMirror_Debug_IsValid;

	private static FFieldAddress ApplyMeshMirror_Debug_PropertyAddress;

	private static int ApplyMeshMirror_Debug_Offset;

	private static bool ApplyMeshMirror_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshMirror_ReturnValue_PropertyAddress;

	private static int ApplyMeshMirror_ReturnValue_Offset;

	private static bool ApplyMeshBoolean_IsValid;

	private static IntPtr ApplyMeshBoolean_FunctionAddress;

	private static int ApplyMeshBoolean_ParamsSize;

	private static bool ApplyMeshBoolean_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshBoolean_TargetMesh_PropertyAddress;

	private static int ApplyMeshBoolean_TargetMesh_Offset;

	private static bool ApplyMeshBoolean_TargetTransform_IsValid;

	private static FFieldAddress ApplyMeshBoolean_TargetTransform_PropertyAddress;

	private static int ApplyMeshBoolean_TargetTransform_Offset;

	private static bool ApplyMeshBoolean_ToolMesh_IsValid;

	private static FFieldAddress ApplyMeshBoolean_ToolMesh_PropertyAddress;

	private static int ApplyMeshBoolean_ToolMesh_Offset;

	private static bool ApplyMeshBoolean_ToolTransform_IsValid;

	private static FFieldAddress ApplyMeshBoolean_ToolTransform_PropertyAddress;

	private static int ApplyMeshBoolean_ToolTransform_Offset;

	private static bool ApplyMeshBoolean_Operation_IsValid;

	private static FFieldAddress ApplyMeshBoolean_Operation_PropertyAddress;

	private static int ApplyMeshBoolean_Operation_Offset;

	private static bool ApplyMeshBoolean_Options_IsValid;

	private static FFieldAddress ApplyMeshBoolean_Options_PropertyAddress;

	private static int ApplyMeshBoolean_Options_Offset;

	private static bool ApplyMeshBoolean_Debug_IsValid;

	private static FFieldAddress ApplyMeshBoolean_Debug_PropertyAddress;

	private static int ApplyMeshBoolean_Debug_Offset;

	private static bool ApplyMeshBoolean_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshBoolean_ReturnValue_PropertyAddress;

	private static int ApplyMeshBoolean_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshSelfUnion")]
	public unsafe static UDynamicMesh ApplyMeshSelfUnion(UDynamicMesh TargetMesh, FGeometryScriptMeshSelfUnionOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshSelfUnion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshSelfUnion");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshSelfUnion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshSelfUnion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshSelfUnion_TargetMesh_Offset), 0, ApplyMeshSelfUnion_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshSelfUnion_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshSelfUnionOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshSelfUnion_Options_Offset), 0, ApplyMeshSelfUnion_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshSelfUnion_Debug_Offset), 0, ApplyMeshSelfUnion_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshSelfUnion_FunctionAddress, intPtr, ApplyMeshSelfUnion_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshSelfUnion_ReturnValue_Offset), 0, ApplyMeshSelfUnion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshPlaneSlice")]
	public unsafe static UDynamicMesh ApplyMeshPlaneSlice(UDynamicMesh TargetMesh, FTransform CutFrame, FGeometryScriptMeshPlaneSliceOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshPlaneSlice_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshPlaneSlice");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshPlaneSlice_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshPlaneSlice_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneSlice_TargetMesh_Offset), 0, ApplyMeshPlaneSlice_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshPlaneSlice_CutFrame_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneSlice_CutFrame_Offset), 0, ApplyMeshPlaneSlice_CutFrame_PropertyAddress.Address, CutFrame);
		NativeReflection.InitializeValue_InContainer(ApplyMeshPlaneSlice_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshPlaneSliceOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneSlice_Options_Offset), 0, ApplyMeshPlaneSlice_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneSlice_Debug_Offset), 0, ApplyMeshPlaneSlice_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshPlaneSlice_FunctionAddress, intPtr, ApplyMeshPlaneSlice_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshPlaneSlice_ReturnValue_Offset), 0, ApplyMeshPlaneSlice_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshPlaneCut")]
	public unsafe static UDynamicMesh ApplyMeshPlaneCut(UDynamicMesh TargetMesh, FTransform CutFrame, FGeometryScriptMeshPlaneCutOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshPlaneCut_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshPlaneCut");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshPlaneCut_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshPlaneCut_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneCut_TargetMesh_Offset), 0, ApplyMeshPlaneCut_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshPlaneCut_CutFrame_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneCut_CutFrame_Offset), 0, ApplyMeshPlaneCut_CutFrame_PropertyAddress.Address, CutFrame);
		NativeReflection.InitializeValue_InContainer(ApplyMeshPlaneCut_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshPlaneCutOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneCut_Options_Offset), 0, ApplyMeshPlaneCut_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshPlaneCut_Debug_Offset), 0, ApplyMeshPlaneCut_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshPlaneCut_FunctionAddress, intPtr, ApplyMeshPlaneCut_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshPlaneCut_ReturnValue_Offset), 0, ApplyMeshPlaneCut_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshMirror")]
	public unsafe static UDynamicMesh ApplyMeshMirror(UDynamicMesh TargetMesh, FTransform MirrorFrame, FGeometryScriptMeshMirrorOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshMirror_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshMirror");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshMirror_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshMirror_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshMirror_TargetMesh_Offset), 0, ApplyMeshMirror_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshMirror_MirrorFrame_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyMeshMirror_MirrorFrame_Offset), 0, ApplyMeshMirror_MirrorFrame_PropertyAddress.Address, MirrorFrame);
		NativeReflection.InitializeValue_InContainer(ApplyMeshMirror_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshMirrorOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshMirror_Options_Offset), 0, ApplyMeshMirror_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshMirror_Debug_Offset), 0, ApplyMeshMirror_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshMirror_FunctionAddress, intPtr, ApplyMeshMirror_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshMirror_ReturnValue_Offset), 0, ApplyMeshMirror_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshBoolean")]
	public unsafe static UDynamicMesh ApplyMeshBoolean(UDynamicMesh TargetMesh, FTransform TargetTransform, UDynamicMesh ToolMesh, FTransform ToolTransform, EGeometryScriptBooleanOperation Operation, FGeometryScriptMeshBooleanOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshBoolean_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshBoolean");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshBoolean_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshBoolean_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshBoolean_TargetMesh_Offset), 0, ApplyMeshBoolean_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshBoolean_TargetTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyMeshBoolean_TargetTransform_Offset), 0, ApplyMeshBoolean_TargetTransform_PropertyAddress.Address, TargetTransform);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshBoolean_ToolMesh_Offset), 0, ApplyMeshBoolean_ToolMesh_PropertyAddress.Address, ToolMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshBoolean_ToolTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyMeshBoolean_ToolTransform_Offset), 0, ApplyMeshBoolean_ToolTransform_PropertyAddress.Address, ToolTransform);
		EnumMarshaler<EGeometryScriptBooleanOperation>.ToNative(IntPtr.Add(intPtr, ApplyMeshBoolean_Operation_Offset), 0, ApplyMeshBoolean_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InitializeValue_InContainer(ApplyMeshBoolean_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshBooleanOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshBoolean_Options_Offset), 0, ApplyMeshBoolean_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshBoolean_Debug_Offset), 0, ApplyMeshBoolean_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshBoolean_FunctionAddress, intPtr, ApplyMeshBoolean_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshBoolean_ReturnValue_Offset), 0, ApplyMeshBoolean_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshBooleans()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshBooleans)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshBooleans));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions");
		ApplyMeshSelfUnion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshSelfUnion");
		ApplyMeshSelfUnion_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshSelfUnion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSelfUnion_TargetMesh_PropertyAddress, ApplyMeshSelfUnion_FunctionAddress, "TargetMesh");
		ApplyMeshSelfUnion_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSelfUnion_FunctionAddress, "TargetMesh");
		ApplyMeshSelfUnion_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSelfUnion_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSelfUnion_Options_PropertyAddress, ApplyMeshSelfUnion_FunctionAddress, "Options");
		ApplyMeshSelfUnion_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSelfUnion_FunctionAddress, "Options");
		ApplyMeshSelfUnion_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSelfUnion_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSelfUnion_Debug_PropertyAddress, ApplyMeshSelfUnion_FunctionAddress, "Debug");
		ApplyMeshSelfUnion_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSelfUnion_FunctionAddress, "Debug");
		ApplyMeshSelfUnion_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSelfUnion_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSelfUnion_ReturnValue_PropertyAddress, ApplyMeshSelfUnion_FunctionAddress, "ReturnValue");
		ApplyMeshSelfUnion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSelfUnion_FunctionAddress, "ReturnValue");
		ApplyMeshSelfUnion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSelfUnion_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshSelfUnion_IsValid = ApplyMeshSelfUnion_FunctionAddress != IntPtr.Zero && ApplyMeshSelfUnion_TargetMesh_IsValid && ApplyMeshSelfUnion_Options_IsValid && ApplyMeshSelfUnion_Debug_IsValid && ApplyMeshSelfUnion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshSelfUnion", ApplyMeshSelfUnion_IsValid);
		ApplyMeshPlaneSlice_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshPlaneSlice");
		ApplyMeshPlaneSlice_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshPlaneSlice_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneSlice_TargetMesh_PropertyAddress, ApplyMeshPlaneSlice_FunctionAddress, "TargetMesh");
		ApplyMeshPlaneSlice_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneSlice_FunctionAddress, "TargetMesh");
		ApplyMeshPlaneSlice_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneSlice_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneSlice_CutFrame_PropertyAddress, ApplyMeshPlaneSlice_FunctionAddress, "CutFrame");
		ApplyMeshPlaneSlice_CutFrame_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneSlice_FunctionAddress, "CutFrame");
		ApplyMeshPlaneSlice_CutFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneSlice_FunctionAddress, "CutFrame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneSlice_Options_PropertyAddress, ApplyMeshPlaneSlice_FunctionAddress, "Options");
		ApplyMeshPlaneSlice_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneSlice_FunctionAddress, "Options");
		ApplyMeshPlaneSlice_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneSlice_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneSlice_Debug_PropertyAddress, ApplyMeshPlaneSlice_FunctionAddress, "Debug");
		ApplyMeshPlaneSlice_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneSlice_FunctionAddress, "Debug");
		ApplyMeshPlaneSlice_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneSlice_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneSlice_ReturnValue_PropertyAddress, ApplyMeshPlaneSlice_FunctionAddress, "ReturnValue");
		ApplyMeshPlaneSlice_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneSlice_FunctionAddress, "ReturnValue");
		ApplyMeshPlaneSlice_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneSlice_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshPlaneSlice_IsValid = ApplyMeshPlaneSlice_FunctionAddress != IntPtr.Zero && ApplyMeshPlaneSlice_TargetMesh_IsValid && ApplyMeshPlaneSlice_CutFrame_IsValid && ApplyMeshPlaneSlice_Options_IsValid && ApplyMeshPlaneSlice_Debug_IsValid && ApplyMeshPlaneSlice_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshPlaneSlice", ApplyMeshPlaneSlice_IsValid);
		ApplyMeshPlaneCut_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshPlaneCut");
		ApplyMeshPlaneCut_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshPlaneCut_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneCut_TargetMesh_PropertyAddress, ApplyMeshPlaneCut_FunctionAddress, "TargetMesh");
		ApplyMeshPlaneCut_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneCut_FunctionAddress, "TargetMesh");
		ApplyMeshPlaneCut_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneCut_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneCut_CutFrame_PropertyAddress, ApplyMeshPlaneCut_FunctionAddress, "CutFrame");
		ApplyMeshPlaneCut_CutFrame_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneCut_FunctionAddress, "CutFrame");
		ApplyMeshPlaneCut_CutFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneCut_FunctionAddress, "CutFrame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneCut_Options_PropertyAddress, ApplyMeshPlaneCut_FunctionAddress, "Options");
		ApplyMeshPlaneCut_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneCut_FunctionAddress, "Options");
		ApplyMeshPlaneCut_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneCut_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneCut_Debug_PropertyAddress, ApplyMeshPlaneCut_FunctionAddress, "Debug");
		ApplyMeshPlaneCut_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneCut_FunctionAddress, "Debug");
		ApplyMeshPlaneCut_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneCut_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPlaneCut_ReturnValue_PropertyAddress, ApplyMeshPlaneCut_FunctionAddress, "ReturnValue");
		ApplyMeshPlaneCut_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPlaneCut_FunctionAddress, "ReturnValue");
		ApplyMeshPlaneCut_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPlaneCut_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshPlaneCut_IsValid = ApplyMeshPlaneCut_FunctionAddress != IntPtr.Zero && ApplyMeshPlaneCut_TargetMesh_IsValid && ApplyMeshPlaneCut_CutFrame_IsValid && ApplyMeshPlaneCut_Options_IsValid && ApplyMeshPlaneCut_Debug_IsValid && ApplyMeshPlaneCut_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshPlaneCut", ApplyMeshPlaneCut_IsValid);
		ApplyMeshMirror_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshMirror");
		ApplyMeshMirror_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshMirror_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMirror_TargetMesh_PropertyAddress, ApplyMeshMirror_FunctionAddress, "TargetMesh");
		ApplyMeshMirror_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMirror_FunctionAddress, "TargetMesh");
		ApplyMeshMirror_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMirror_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMirror_MirrorFrame_PropertyAddress, ApplyMeshMirror_FunctionAddress, "MirrorFrame");
		ApplyMeshMirror_MirrorFrame_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMirror_FunctionAddress, "MirrorFrame");
		ApplyMeshMirror_MirrorFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMirror_FunctionAddress, "MirrorFrame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMirror_Options_PropertyAddress, ApplyMeshMirror_FunctionAddress, "Options");
		ApplyMeshMirror_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMirror_FunctionAddress, "Options");
		ApplyMeshMirror_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMirror_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMirror_Debug_PropertyAddress, ApplyMeshMirror_FunctionAddress, "Debug");
		ApplyMeshMirror_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMirror_FunctionAddress, "Debug");
		ApplyMeshMirror_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMirror_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMirror_ReturnValue_PropertyAddress, ApplyMeshMirror_FunctionAddress, "ReturnValue");
		ApplyMeshMirror_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMirror_FunctionAddress, "ReturnValue");
		ApplyMeshMirror_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMirror_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshMirror_IsValid = ApplyMeshMirror_FunctionAddress != IntPtr.Zero && ApplyMeshMirror_TargetMesh_IsValid && ApplyMeshMirror_MirrorFrame_IsValid && ApplyMeshMirror_Options_IsValid && ApplyMeshMirror_Debug_IsValid && ApplyMeshMirror_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshMirror", ApplyMeshMirror_IsValid);
		ApplyMeshBoolean_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshBoolean");
		ApplyMeshBoolean_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshBoolean_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_TargetMesh_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "TargetMesh");
		ApplyMeshBoolean_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "TargetMesh");
		ApplyMeshBoolean_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_TargetTransform_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "TargetTransform");
		ApplyMeshBoolean_TargetTransform_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "TargetTransform");
		ApplyMeshBoolean_TargetTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "TargetTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_ToolMesh_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "ToolMesh");
		ApplyMeshBoolean_ToolMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "ToolMesh");
		ApplyMeshBoolean_ToolMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "ToolMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_ToolTransform_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "ToolTransform");
		ApplyMeshBoolean_ToolTransform_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "ToolTransform");
		ApplyMeshBoolean_ToolTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "ToolTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_Operation_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "Operation");
		ApplyMeshBoolean_Operation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "Operation");
		ApplyMeshBoolean_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "Operation", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_Options_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "Options");
		ApplyMeshBoolean_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "Options");
		ApplyMeshBoolean_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_Debug_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "Debug");
		ApplyMeshBoolean_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "Debug");
		ApplyMeshBoolean_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoolean_ReturnValue_PropertyAddress, ApplyMeshBoolean_FunctionAddress, "ReturnValue");
		ApplyMeshBoolean_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshBoolean_FunctionAddress, "ReturnValue");
		ApplyMeshBoolean_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshBoolean_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshBoolean_IsValid = ApplyMeshBoolean_FunctionAddress != IntPtr.Zero && ApplyMeshBoolean_TargetMesh_IsValid && ApplyMeshBoolean_TargetTransform_IsValid && ApplyMeshBoolean_ToolMesh_IsValid && ApplyMeshBoolean_ToolTransform_IsValid && ApplyMeshBoolean_Operation_IsValid && ApplyMeshBoolean_Options_IsValid && ApplyMeshBoolean_Debug_IsValid && ApplyMeshBoolean_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshBooleanFunctions:ApplyMeshBoolean", ApplyMeshBoolean_IsValid);
	}
}
