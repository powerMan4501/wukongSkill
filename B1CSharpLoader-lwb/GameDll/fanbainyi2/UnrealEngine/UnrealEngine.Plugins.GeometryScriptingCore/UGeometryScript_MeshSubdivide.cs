using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshSubdivide : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplyUniformTessellation_IsValid;

	private static IntPtr ApplyUniformTessellation_FunctionAddress;

	private static int ApplyUniformTessellation_ParamsSize;

	private static bool ApplyUniformTessellation_TargetMesh_IsValid;

	private static FFieldAddress ApplyUniformTessellation_TargetMesh_PropertyAddress;

	private static int ApplyUniformTessellation_TargetMesh_Offset;

	private static bool ApplyUniformTessellation_TessellationLevel_IsValid;

	private static FFieldAddress ApplyUniformTessellation_TessellationLevel_PropertyAddress;

	private static int ApplyUniformTessellation_TessellationLevel_Offset;

	private static bool ApplyUniformTessellation_Debug_IsValid;

	private static FFieldAddress ApplyUniformTessellation_Debug_PropertyAddress;

	private static int ApplyUniformTessellation_Debug_Offset;

	private static bool ApplyUniformTessellation_ReturnValue_IsValid;

	private static FFieldAddress ApplyUniformTessellation_ReturnValue_PropertyAddress;

	private static int ApplyUniformTessellation_ReturnValue_Offset;

	private static bool ApplyPNTessellation_IsValid;

	private static IntPtr ApplyPNTessellation_FunctionAddress;

	private static int ApplyPNTessellation_ParamsSize;

	private static bool ApplyPNTessellation_TargetMesh_IsValid;

	private static FFieldAddress ApplyPNTessellation_TargetMesh_PropertyAddress;

	private static int ApplyPNTessellation_TargetMesh_Offset;

	private static bool ApplyPNTessellation_Options_IsValid;

	private static FFieldAddress ApplyPNTessellation_Options_PropertyAddress;

	private static int ApplyPNTessellation_Options_Offset;

	private static bool ApplyPNTessellation_TessellationLevel_IsValid;

	private static FFieldAddress ApplyPNTessellation_TessellationLevel_PropertyAddress;

	private static int ApplyPNTessellation_TessellationLevel_Offset;

	private static bool ApplyPNTessellation_Debug_IsValid;

	private static FFieldAddress ApplyPNTessellation_Debug_PropertyAddress;

	private static int ApplyPNTessellation_Debug_Offset;

	private static bool ApplyPNTessellation_ReturnValue_IsValid;

	private static FFieldAddress ApplyPNTessellation_ReturnValue_PropertyAddress;

	private static int ApplyPNTessellation_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions:ApplyUniformTessellation")]
	public unsafe static UDynamicMesh ApplyUniformTessellation(UDynamicMesh TargetMesh, int TessellationLevel, UGeometryScriptDebug Debug)
	{
		if (!ApplyUniformTessellation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions:ApplyUniformTessellation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyUniformTessellation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyUniformTessellation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyUniformTessellation_TargetMesh_Offset), 0, ApplyUniformTessellation_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyUniformTessellation_TessellationLevel_Offset), 0, ApplyUniformTessellation_TessellationLevel_PropertyAddress.Address, TessellationLevel);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyUniformTessellation_Debug_Offset), 0, ApplyUniformTessellation_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyUniformTessellation_FunctionAddress, intPtr, ApplyUniformTessellation_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyUniformTessellation_ReturnValue_Offset), 0, ApplyUniformTessellation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions:ApplyPNTessellation")]
	public unsafe static UDynamicMesh ApplyPNTessellation(UDynamicMesh TargetMesh, FGeometryScriptPNTessellateOptions Options, int TessellationLevel, UGeometryScriptDebug Debug)
	{
		if (!ApplyPNTessellation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions:ApplyPNTessellation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPNTessellation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPNTessellation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyPNTessellation_TargetMesh_Offset), 0, ApplyPNTessellation_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyPNTessellation_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptPNTessellateOptions.ToNative(IntPtr.Add(intPtr, ApplyPNTessellation_Options_Offset), 0, ApplyPNTessellation_Options_PropertyAddress.Address, Options);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyPNTessellation_TessellationLevel_Offset), 0, ApplyPNTessellation_TessellationLevel_PropertyAddress.Address, TessellationLevel);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyPNTessellation_Debug_Offset), 0, ApplyPNTessellation_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyPNTessellation_FunctionAddress, intPtr, ApplyPNTessellation_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyPNTessellation_ReturnValue_Offset), 0, ApplyPNTessellation_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshSubdivide()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshSubdivide)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshSubdivide));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions");
		ApplyUniformTessellation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyUniformTessellation");
		ApplyUniformTessellation_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyUniformTessellation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformTessellation_TargetMesh_PropertyAddress, ApplyUniformTessellation_FunctionAddress, "TargetMesh");
		ApplyUniformTessellation_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformTessellation_FunctionAddress, "TargetMesh");
		ApplyUniformTessellation_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformTessellation_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformTessellation_TessellationLevel_PropertyAddress, ApplyUniformTessellation_FunctionAddress, "TessellationLevel");
		ApplyUniformTessellation_TessellationLevel_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformTessellation_FunctionAddress, "TessellationLevel");
		ApplyUniformTessellation_TessellationLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformTessellation_FunctionAddress, "TessellationLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformTessellation_Debug_PropertyAddress, ApplyUniformTessellation_FunctionAddress, "Debug");
		ApplyUniformTessellation_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformTessellation_FunctionAddress, "Debug");
		ApplyUniformTessellation_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformTessellation_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformTessellation_ReturnValue_PropertyAddress, ApplyUniformTessellation_FunctionAddress, "ReturnValue");
		ApplyUniformTessellation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformTessellation_FunctionAddress, "ReturnValue");
		ApplyUniformTessellation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformTessellation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyUniformTessellation_IsValid = ApplyUniformTessellation_FunctionAddress != IntPtr.Zero && ApplyUniformTessellation_TargetMesh_IsValid && ApplyUniformTessellation_TessellationLevel_IsValid && ApplyUniformTessellation_Debug_IsValid && ApplyUniformTessellation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions:ApplyUniformTessellation", ApplyUniformTessellation_IsValid);
		ApplyPNTessellation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyPNTessellation");
		ApplyPNTessellation_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPNTessellation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPNTessellation_TargetMesh_PropertyAddress, ApplyPNTessellation_FunctionAddress, "TargetMesh");
		ApplyPNTessellation_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPNTessellation_FunctionAddress, "TargetMesh");
		ApplyPNTessellation_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPNTessellation_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPNTessellation_Options_PropertyAddress, ApplyPNTessellation_FunctionAddress, "Options");
		ApplyPNTessellation_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPNTessellation_FunctionAddress, "Options");
		ApplyPNTessellation_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPNTessellation_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPNTessellation_TessellationLevel_PropertyAddress, ApplyPNTessellation_FunctionAddress, "TessellationLevel");
		ApplyPNTessellation_TessellationLevel_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPNTessellation_FunctionAddress, "TessellationLevel");
		ApplyPNTessellation_TessellationLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPNTessellation_FunctionAddress, "TessellationLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPNTessellation_Debug_PropertyAddress, ApplyPNTessellation_FunctionAddress, "Debug");
		ApplyPNTessellation_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPNTessellation_FunctionAddress, "Debug");
		ApplyPNTessellation_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPNTessellation_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPNTessellation_ReturnValue_PropertyAddress, ApplyPNTessellation_FunctionAddress, "ReturnValue");
		ApplyPNTessellation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPNTessellation_FunctionAddress, "ReturnValue");
		ApplyPNTessellation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPNTessellation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyPNTessellation_IsValid = ApplyPNTessellation_FunctionAddress != IntPtr.Zero && ApplyPNTessellation_TargetMesh_IsValid && ApplyPNTessellation_Options_IsValid && ApplyPNTessellation_TessellationLevel_IsValid && ApplyPNTessellation_Debug_IsValid && ApplyPNTessellation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshSubdivideFunctions:ApplyPNTessellation", ApplyPNTessellation_IsValid);
	}
}
