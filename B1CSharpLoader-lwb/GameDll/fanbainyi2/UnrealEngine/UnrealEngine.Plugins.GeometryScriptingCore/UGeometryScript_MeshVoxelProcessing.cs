using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshVoxelProcessing : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplyMeshSolidify_IsValid;

	private static IntPtr ApplyMeshSolidify_FunctionAddress;

	private static int ApplyMeshSolidify_ParamsSize;

	private static bool ApplyMeshSolidify_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshSolidify_TargetMesh_PropertyAddress;

	private static int ApplyMeshSolidify_TargetMesh_Offset;

	private static bool ApplyMeshSolidify_Options_IsValid;

	private static FFieldAddress ApplyMeshSolidify_Options_PropertyAddress;

	private static int ApplyMeshSolidify_Options_Offset;

	private static bool ApplyMeshSolidify_Debug_IsValid;

	private static FFieldAddress ApplyMeshSolidify_Debug_PropertyAddress;

	private static int ApplyMeshSolidify_Debug_Offset;

	private static bool ApplyMeshSolidify_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshSolidify_ReturnValue_PropertyAddress;

	private static int ApplyMeshSolidify_ReturnValue_Offset;

	private static bool ApplyMeshMorphology_IsValid;

	private static IntPtr ApplyMeshMorphology_FunctionAddress;

	private static int ApplyMeshMorphology_ParamsSize;

	private static bool ApplyMeshMorphology_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshMorphology_TargetMesh_PropertyAddress;

	private static int ApplyMeshMorphology_TargetMesh_Offset;

	private static bool ApplyMeshMorphology_Options_IsValid;

	private static FFieldAddress ApplyMeshMorphology_Options_PropertyAddress;

	private static int ApplyMeshMorphology_Options_Offset;

	private static bool ApplyMeshMorphology_Debug_IsValid;

	private static FFieldAddress ApplyMeshMorphology_Debug_PropertyAddress;

	private static int ApplyMeshMorphology_Debug_Offset;

	private static bool ApplyMeshMorphology_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshMorphology_ReturnValue_PropertyAddress;

	private static int ApplyMeshMorphology_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions:ApplyMeshSolidify")]
	public unsafe static UDynamicMesh ApplyMeshSolidify(UDynamicMesh TargetMesh, FGeometryScriptSolidifyOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshSolidify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions:ApplyMeshSolidify");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshSolidify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshSolidify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshSolidify_TargetMesh_Offset), 0, ApplyMeshSolidify_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshSolidify_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSolidifyOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshSolidify_Options_Offset), 0, ApplyMeshSolidify_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshSolidify_Debug_Offset), 0, ApplyMeshSolidify_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshSolidify_FunctionAddress, intPtr, ApplyMeshSolidify_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshSolidify_ReturnValue_Offset), 0, ApplyMeshSolidify_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions:ApplyMeshMorphology")]
	public unsafe static UDynamicMesh ApplyMeshMorphology(UDynamicMesh TargetMesh, FGeometryScriptMorphologyOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshMorphology_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions:ApplyMeshMorphology");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshMorphology_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshMorphology_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshMorphology_TargetMesh_Offset), 0, ApplyMeshMorphology_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshMorphology_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMorphologyOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshMorphology_Options_Offset), 0, ApplyMeshMorphology_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshMorphology_Debug_Offset), 0, ApplyMeshMorphology_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshMorphology_FunctionAddress, intPtr, ApplyMeshMorphology_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshMorphology_ReturnValue_Offset), 0, ApplyMeshMorphology_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshVoxelProcessing()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshVoxelProcessing)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshVoxelProcessing));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions");
		ApplyMeshSolidify_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshSolidify");
		ApplyMeshSolidify_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshSolidify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSolidify_TargetMesh_PropertyAddress, ApplyMeshSolidify_FunctionAddress, "TargetMesh");
		ApplyMeshSolidify_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSolidify_FunctionAddress, "TargetMesh");
		ApplyMeshSolidify_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSolidify_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSolidify_Options_PropertyAddress, ApplyMeshSolidify_FunctionAddress, "Options");
		ApplyMeshSolidify_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSolidify_FunctionAddress, "Options");
		ApplyMeshSolidify_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSolidify_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSolidify_Debug_PropertyAddress, ApplyMeshSolidify_FunctionAddress, "Debug");
		ApplyMeshSolidify_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSolidify_FunctionAddress, "Debug");
		ApplyMeshSolidify_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSolidify_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshSolidify_ReturnValue_PropertyAddress, ApplyMeshSolidify_FunctionAddress, "ReturnValue");
		ApplyMeshSolidify_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshSolidify_FunctionAddress, "ReturnValue");
		ApplyMeshSolidify_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshSolidify_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshSolidify_IsValid = ApplyMeshSolidify_FunctionAddress != IntPtr.Zero && ApplyMeshSolidify_TargetMesh_IsValid && ApplyMeshSolidify_Options_IsValid && ApplyMeshSolidify_Debug_IsValid && ApplyMeshSolidify_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions:ApplyMeshSolidify", ApplyMeshSolidify_IsValid);
		ApplyMeshMorphology_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshMorphology");
		ApplyMeshMorphology_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshMorphology_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMorphology_TargetMesh_PropertyAddress, ApplyMeshMorphology_FunctionAddress, "TargetMesh");
		ApplyMeshMorphology_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMorphology_FunctionAddress, "TargetMesh");
		ApplyMeshMorphology_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMorphology_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMorphology_Options_PropertyAddress, ApplyMeshMorphology_FunctionAddress, "Options");
		ApplyMeshMorphology_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMorphology_FunctionAddress, "Options");
		ApplyMeshMorphology_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMorphology_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMorphology_Debug_PropertyAddress, ApplyMeshMorphology_FunctionAddress, "Debug");
		ApplyMeshMorphology_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMorphology_FunctionAddress, "Debug");
		ApplyMeshMorphology_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMorphology_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshMorphology_ReturnValue_PropertyAddress, ApplyMeshMorphology_FunctionAddress, "ReturnValue");
		ApplyMeshMorphology_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshMorphology_FunctionAddress, "ReturnValue");
		ApplyMeshMorphology_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshMorphology_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshMorphology_IsValid = ApplyMeshMorphology_FunctionAddress != IntPtr.Zero && ApplyMeshMorphology_TargetMesh_IsValid && ApplyMeshMorphology_Options_IsValid && ApplyMeshMorphology_Debug_IsValid && ApplyMeshMorphology_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVoxelFunctions:ApplyMeshMorphology", ApplyMeshMorphology_IsValid);
	}
}
