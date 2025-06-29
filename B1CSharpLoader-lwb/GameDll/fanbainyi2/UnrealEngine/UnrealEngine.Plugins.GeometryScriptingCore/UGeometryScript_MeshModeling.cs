using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshModeling : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplyMeshShell_IsValid;

	private static IntPtr ApplyMeshShell_FunctionAddress;

	private static int ApplyMeshShell_ParamsSize;

	private static bool ApplyMeshShell_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshShell_TargetMesh_PropertyAddress;

	private static int ApplyMeshShell_TargetMesh_Offset;

	private static bool ApplyMeshShell_Options_IsValid;

	private static FFieldAddress ApplyMeshShell_Options_PropertyAddress;

	private static int ApplyMeshShell_Options_Offset;

	private static bool ApplyMeshShell_Debug_IsValid;

	private static FFieldAddress ApplyMeshShell_Debug_PropertyAddress;

	private static int ApplyMeshShell_Debug_Offset;

	private static bool ApplyMeshShell_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshShell_ReturnValue_PropertyAddress;

	private static int ApplyMeshShell_ReturnValue_Offset;

	private static bool ApplyMeshPolygroupBevel_IsValid;

	private static IntPtr ApplyMeshPolygroupBevel_FunctionAddress;

	private static int ApplyMeshPolygroupBevel_ParamsSize;

	private static bool ApplyMeshPolygroupBevel_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshPolygroupBevel_TargetMesh_PropertyAddress;

	private static int ApplyMeshPolygroupBevel_TargetMesh_Offset;

	private static bool ApplyMeshPolygroupBevel_Options_IsValid;

	private static FFieldAddress ApplyMeshPolygroupBevel_Options_PropertyAddress;

	private static int ApplyMeshPolygroupBevel_Options_Offset;

	private static bool ApplyMeshPolygroupBevel_Debug_IsValid;

	private static FFieldAddress ApplyMeshPolygroupBevel_Debug_PropertyAddress;

	private static int ApplyMeshPolygroupBevel_Debug_Offset;

	private static bool ApplyMeshPolygroupBevel_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshPolygroupBevel_ReturnValue_PropertyAddress;

	private static int ApplyMeshPolygroupBevel_ReturnValue_Offset;

	private static bool ApplyMeshOffset_IsValid;

	private static IntPtr ApplyMeshOffset_FunctionAddress;

	private static int ApplyMeshOffset_ParamsSize;

	private static bool ApplyMeshOffset_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshOffset_TargetMesh_PropertyAddress;

	private static int ApplyMeshOffset_TargetMesh_Offset;

	private static bool ApplyMeshOffset_Options_IsValid;

	private static FFieldAddress ApplyMeshOffset_Options_PropertyAddress;

	private static int ApplyMeshOffset_Options_Offset;

	private static bool ApplyMeshOffset_Debug_IsValid;

	private static FFieldAddress ApplyMeshOffset_Debug_PropertyAddress;

	private static int ApplyMeshOffset_Debug_Offset;

	private static bool ApplyMeshOffset_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshOffset_ReturnValue_PropertyAddress;

	private static int ApplyMeshOffset_ReturnValue_Offset;

	private static bool ApplyMeshExtrude_IsValid;

	private static IntPtr ApplyMeshExtrude_FunctionAddress;

	private static int ApplyMeshExtrude_ParamsSize;

	private static bool ApplyMeshExtrude_TargetMesh_IsValid;

	private static FFieldAddress ApplyMeshExtrude_TargetMesh_PropertyAddress;

	private static int ApplyMeshExtrude_TargetMesh_Offset;

	private static bool ApplyMeshExtrude_Options_IsValid;

	private static FFieldAddress ApplyMeshExtrude_Options_PropertyAddress;

	private static int ApplyMeshExtrude_Options_Offset;

	private static bool ApplyMeshExtrude_Debug_IsValid;

	private static FFieldAddress ApplyMeshExtrude_Debug_PropertyAddress;

	private static int ApplyMeshExtrude_Debug_Offset;

	private static bool ApplyMeshExtrude_ReturnValue_IsValid;

	private static FFieldAddress ApplyMeshExtrude_ReturnValue_PropertyAddress;

	private static int ApplyMeshExtrude_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshShell")]
	public unsafe static UDynamicMesh ApplyMeshShell(UDynamicMesh TargetMesh, FGeometryScriptMeshOffsetOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshShell_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshShell");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshShell_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshShell_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshShell_TargetMesh_Offset), 0, ApplyMeshShell_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshShell_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshOffsetOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshShell_Options_Offset), 0, ApplyMeshShell_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshShell_Debug_Offset), 0, ApplyMeshShell_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshShell_FunctionAddress, intPtr, ApplyMeshShell_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshShell_ReturnValue_Offset), 0, ApplyMeshShell_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshPolygroupBevel")]
	public unsafe static UDynamicMesh ApplyMeshPolygroupBevel(UDynamicMesh TargetMesh, FGeometryScriptMeshBevelOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshPolygroupBevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshPolygroupBevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshPolygroupBevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshPolygroupBevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshPolygroupBevel_TargetMesh_Offset), 0, ApplyMeshPolygroupBevel_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshPolygroupBevel_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshBevelOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshPolygroupBevel_Options_Offset), 0, ApplyMeshPolygroupBevel_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshPolygroupBevel_Debug_Offset), 0, ApplyMeshPolygroupBevel_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshPolygroupBevel_FunctionAddress, intPtr, ApplyMeshPolygroupBevel_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshPolygroupBevel_ReturnValue_Offset), 0, ApplyMeshPolygroupBevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshOffset")]
	public unsafe static UDynamicMesh ApplyMeshOffset(UDynamicMesh TargetMesh, FGeometryScriptMeshOffsetOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshOffset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshOffset_TargetMesh_Offset), 0, ApplyMeshOffset_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshOffset_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshOffsetOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshOffset_Options_Offset), 0, ApplyMeshOffset_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshOffset_Debug_Offset), 0, ApplyMeshOffset_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshOffset_FunctionAddress, intPtr, ApplyMeshOffset_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshOffset_ReturnValue_Offset), 0, ApplyMeshOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshExtrude")]
	public unsafe static UDynamicMesh ApplyMeshExtrude(UDynamicMesh TargetMesh, FGeometryScriptMeshExtrudeOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMeshExtrude_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshExtrude");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMeshExtrude_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMeshExtrude_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMeshExtrude_TargetMesh_Offset), 0, ApplyMeshExtrude_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMeshExtrude_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeshExtrudeOptions.ToNative(IntPtr.Add(intPtr, ApplyMeshExtrude_Options_Offset), 0, ApplyMeshExtrude_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMeshExtrude_Debug_Offset), 0, ApplyMeshExtrude_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMeshExtrude_FunctionAddress, intPtr, ApplyMeshExtrude_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMeshExtrude_ReturnValue_Offset), 0, ApplyMeshExtrude_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshModeling()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshModeling)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshModeling));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions");
		ApplyMeshShell_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshShell");
		ApplyMeshShell_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshShell_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshShell_TargetMesh_PropertyAddress, ApplyMeshShell_FunctionAddress, "TargetMesh");
		ApplyMeshShell_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshShell_FunctionAddress, "TargetMesh");
		ApplyMeshShell_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshShell_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshShell_Options_PropertyAddress, ApplyMeshShell_FunctionAddress, "Options");
		ApplyMeshShell_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshShell_FunctionAddress, "Options");
		ApplyMeshShell_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshShell_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshShell_Debug_PropertyAddress, ApplyMeshShell_FunctionAddress, "Debug");
		ApplyMeshShell_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshShell_FunctionAddress, "Debug");
		ApplyMeshShell_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshShell_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshShell_ReturnValue_PropertyAddress, ApplyMeshShell_FunctionAddress, "ReturnValue");
		ApplyMeshShell_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshShell_FunctionAddress, "ReturnValue");
		ApplyMeshShell_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshShell_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshShell_IsValid = ApplyMeshShell_FunctionAddress != IntPtr.Zero && ApplyMeshShell_TargetMesh_IsValid && ApplyMeshShell_Options_IsValid && ApplyMeshShell_Debug_IsValid && ApplyMeshShell_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshShell", ApplyMeshShell_IsValid);
		ApplyMeshPolygroupBevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshPolygroupBevel");
		ApplyMeshPolygroupBevel_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshPolygroupBevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPolygroupBevel_TargetMesh_PropertyAddress, ApplyMeshPolygroupBevel_FunctionAddress, "TargetMesh");
		ApplyMeshPolygroupBevel_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPolygroupBevel_FunctionAddress, "TargetMesh");
		ApplyMeshPolygroupBevel_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPolygroupBevel_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPolygroupBevel_Options_PropertyAddress, ApplyMeshPolygroupBevel_FunctionAddress, "Options");
		ApplyMeshPolygroupBevel_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPolygroupBevel_FunctionAddress, "Options");
		ApplyMeshPolygroupBevel_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPolygroupBevel_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPolygroupBevel_Debug_PropertyAddress, ApplyMeshPolygroupBevel_FunctionAddress, "Debug");
		ApplyMeshPolygroupBevel_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPolygroupBevel_FunctionAddress, "Debug");
		ApplyMeshPolygroupBevel_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPolygroupBevel_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshPolygroupBevel_ReturnValue_PropertyAddress, ApplyMeshPolygroupBevel_FunctionAddress, "ReturnValue");
		ApplyMeshPolygroupBevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshPolygroupBevel_FunctionAddress, "ReturnValue");
		ApplyMeshPolygroupBevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshPolygroupBevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshPolygroupBevel_IsValid = ApplyMeshPolygroupBevel_FunctionAddress != IntPtr.Zero && ApplyMeshPolygroupBevel_TargetMesh_IsValid && ApplyMeshPolygroupBevel_Options_IsValid && ApplyMeshPolygroupBevel_Debug_IsValid && ApplyMeshPolygroupBevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshPolygroupBevel", ApplyMeshPolygroupBevel_IsValid);
		ApplyMeshOffset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshOffset");
		ApplyMeshOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshOffset_TargetMesh_PropertyAddress, ApplyMeshOffset_FunctionAddress, "TargetMesh");
		ApplyMeshOffset_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshOffset_FunctionAddress, "TargetMesh");
		ApplyMeshOffset_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshOffset_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshOffset_Options_PropertyAddress, ApplyMeshOffset_FunctionAddress, "Options");
		ApplyMeshOffset_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshOffset_FunctionAddress, "Options");
		ApplyMeshOffset_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshOffset_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshOffset_Debug_PropertyAddress, ApplyMeshOffset_FunctionAddress, "Debug");
		ApplyMeshOffset_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshOffset_FunctionAddress, "Debug");
		ApplyMeshOffset_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshOffset_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshOffset_ReturnValue_PropertyAddress, ApplyMeshOffset_FunctionAddress, "ReturnValue");
		ApplyMeshOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshOffset_FunctionAddress, "ReturnValue");
		ApplyMeshOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshOffset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshOffset_IsValid = ApplyMeshOffset_FunctionAddress != IntPtr.Zero && ApplyMeshOffset_TargetMesh_IsValid && ApplyMeshOffset_Options_IsValid && ApplyMeshOffset_Debug_IsValid && ApplyMeshOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshOffset", ApplyMeshOffset_IsValid);
		ApplyMeshExtrude_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMeshExtrude");
		ApplyMeshExtrude_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMeshExtrude_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshExtrude_TargetMesh_PropertyAddress, ApplyMeshExtrude_FunctionAddress, "TargetMesh");
		ApplyMeshExtrude_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshExtrude_FunctionAddress, "TargetMesh");
		ApplyMeshExtrude_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshExtrude_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshExtrude_Options_PropertyAddress, ApplyMeshExtrude_FunctionAddress, "Options");
		ApplyMeshExtrude_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshExtrude_FunctionAddress, "Options");
		ApplyMeshExtrude_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshExtrude_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshExtrude_Debug_PropertyAddress, ApplyMeshExtrude_FunctionAddress, "Debug");
		ApplyMeshExtrude_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshExtrude_FunctionAddress, "Debug");
		ApplyMeshExtrude_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshExtrude_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshExtrude_ReturnValue_PropertyAddress, ApplyMeshExtrude_FunctionAddress, "ReturnValue");
		ApplyMeshExtrude_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMeshExtrude_FunctionAddress, "ReturnValue");
		ApplyMeshExtrude_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMeshExtrude_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMeshExtrude_IsValid = ApplyMeshExtrude_FunctionAddress != IntPtr.Zero && ApplyMeshExtrude_TargetMesh_IsValid && ApplyMeshExtrude_Options_IsValid && ApplyMeshExtrude_Debug_IsValid && ApplyMeshExtrude_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshModelingFunctions:ApplyMeshExtrude", ApplyMeshExtrude_IsValid);
	}
}
