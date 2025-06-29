using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_Containment : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ComputeMeshSweptHull_IsValid;

	private static IntPtr ComputeMeshSweptHull_FunctionAddress;

	private static int ComputeMeshSweptHull_ParamsSize;

	private static bool ComputeMeshSweptHull_TargetMesh_IsValid;

	private static FFieldAddress ComputeMeshSweptHull_TargetMesh_PropertyAddress;

	private static int ComputeMeshSweptHull_TargetMesh_Offset;

	private static bool ComputeMeshSweptHull_CopyToMesh_IsValid;

	private static FFieldAddress ComputeMeshSweptHull_CopyToMesh_PropertyAddress;

	private static int ComputeMeshSweptHull_CopyToMesh_Offset;

	private static bool ComputeMeshSweptHull_CopyToMeshOut_IsValid;

	private static FFieldAddress ComputeMeshSweptHull_CopyToMeshOut_PropertyAddress;

	private static int ComputeMeshSweptHull_CopyToMeshOut_Offset;

	private static bool ComputeMeshSweptHull_ProjectionFrame_IsValid;

	private static FFieldAddress ComputeMeshSweptHull_ProjectionFrame_PropertyAddress;

	private static int ComputeMeshSweptHull_ProjectionFrame_Offset;

	private static bool ComputeMeshSweptHull_Options_IsValid;

	private static FFieldAddress ComputeMeshSweptHull_Options_PropertyAddress;

	private static int ComputeMeshSweptHull_Options_Offset;

	private static bool ComputeMeshSweptHull_Debug_IsValid;

	private static FFieldAddress ComputeMeshSweptHull_Debug_PropertyAddress;

	private static int ComputeMeshSweptHull_Debug_Offset;

	private static bool ComputeMeshSweptHull_ReturnValue_IsValid;

	private static FFieldAddress ComputeMeshSweptHull_ReturnValue_PropertyAddress;

	private static int ComputeMeshSweptHull_ReturnValue_Offset;

	private static bool ComputeMeshConvexHull_IsValid;

	private static IntPtr ComputeMeshConvexHull_FunctionAddress;

	private static int ComputeMeshConvexHull_ParamsSize;

	private static bool ComputeMeshConvexHull_TargetMesh_IsValid;

	private static FFieldAddress ComputeMeshConvexHull_TargetMesh_PropertyAddress;

	private static int ComputeMeshConvexHull_TargetMesh_Offset;

	private static bool ComputeMeshConvexHull_CopyToMesh_IsValid;

	private static FFieldAddress ComputeMeshConvexHull_CopyToMesh_PropertyAddress;

	private static int ComputeMeshConvexHull_CopyToMesh_Offset;

	private static bool ComputeMeshConvexHull_CopyToMeshOut_IsValid;

	private static FFieldAddress ComputeMeshConvexHull_CopyToMeshOut_PropertyAddress;

	private static int ComputeMeshConvexHull_CopyToMeshOut_Offset;

	private static bool ComputeMeshConvexHull_Options_IsValid;

	private static FFieldAddress ComputeMeshConvexHull_Options_PropertyAddress;

	private static int ComputeMeshConvexHull_Options_Offset;

	private static bool ComputeMeshConvexHull_Debug_IsValid;

	private static FFieldAddress ComputeMeshConvexHull_Debug_PropertyAddress;

	private static int ComputeMeshConvexHull_Debug_Offset;

	private static bool ComputeMeshConvexHull_ReturnValue_IsValid;

	private static FFieldAddress ComputeMeshConvexHull_ReturnValue_PropertyAddress;

	private static int ComputeMeshConvexHull_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions:ComputeMeshSweptHull")]
	public unsafe static UDynamicMesh ComputeMeshSweptHull(UDynamicMesh TargetMesh, ref UDynamicMesh CopyToMesh, out UDynamicMesh CopyToMeshOut, FTransform ProjectionFrame, FGeometryScriptSweptHullOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ComputeMeshSweptHull_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions:ComputeMeshSweptHull");
			CopyToMeshOut = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputeMeshSweptHull_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputeMeshSweptHull_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_TargetMesh_Offset), 0, ComputeMeshSweptHull_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_CopyToMesh_Offset), 0, ComputeMeshSweptHull_CopyToMesh_PropertyAddress.Address, CopyToMesh);
		NativeReflection.InitializeValue_InContainer(ComputeMeshSweptHull_ProjectionFrame_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_ProjectionFrame_Offset), 0, ComputeMeshSweptHull_ProjectionFrame_PropertyAddress.Address, ProjectionFrame);
		NativeReflection.InitializeValue_InContainer(ComputeMeshSweptHull_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptSweptHullOptions.ToNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_Options_Offset), 0, ComputeMeshSweptHull_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_Debug_Offset), 0, ComputeMeshSweptHull_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ComputeMeshSweptHull_FunctionAddress, intPtr, ComputeMeshSweptHull_ParamsSize);
		CopyToMesh = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_CopyToMesh_Offset), 0, ComputeMeshSweptHull_CopyToMesh_PropertyAddress.Address);
		CopyToMeshOut = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_CopyToMeshOut_Offset), 0, ComputeMeshSweptHull_CopyToMeshOut_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeMeshSweptHull_ReturnValue_Offset), 0, ComputeMeshSweptHull_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions:ComputeMeshConvexHull")]
	public unsafe static UDynamicMesh ComputeMeshConvexHull(UDynamicMesh TargetMesh, ref UDynamicMesh CopyToMesh, out UDynamicMesh CopyToMeshOut, FGeometryScriptConvexHullOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ComputeMeshConvexHull_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions:ComputeMeshConvexHull");
			CopyToMeshOut = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputeMeshConvexHull_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputeMeshConvexHull_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ComputeMeshConvexHull_TargetMesh_Offset), 0, ComputeMeshConvexHull_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ComputeMeshConvexHull_CopyToMesh_Offset), 0, ComputeMeshConvexHull_CopyToMesh_PropertyAddress.Address, CopyToMesh);
		NativeReflection.InitializeValue_InContainer(ComputeMeshConvexHull_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptConvexHullOptions.ToNative(IntPtr.Add(intPtr, ComputeMeshConvexHull_Options_Offset), 0, ComputeMeshConvexHull_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ComputeMeshConvexHull_Debug_Offset), 0, ComputeMeshConvexHull_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ComputeMeshConvexHull_FunctionAddress, intPtr, ComputeMeshConvexHull_ParamsSize);
		CopyToMesh = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeMeshConvexHull_CopyToMesh_Offset), 0, ComputeMeshConvexHull_CopyToMesh_PropertyAddress.Address);
		CopyToMeshOut = UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeMeshConvexHull_CopyToMeshOut_Offset), 0, ComputeMeshConvexHull_CopyToMeshOut_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ComputeMeshConvexHull_ReturnValue_Offset), 0, ComputeMeshConvexHull_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_Containment()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_Containment)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_Containment));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions");
		ComputeMeshSweptHull_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ComputeMeshSweptHull");
		ComputeMeshSweptHull_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputeMeshSweptHull_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshSweptHull_TargetMesh_PropertyAddress, ComputeMeshSweptHull_FunctionAddress, "TargetMesh");
		ComputeMeshSweptHull_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshSweptHull_FunctionAddress, "TargetMesh");
		ComputeMeshSweptHull_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshSweptHull_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshSweptHull_CopyToMesh_PropertyAddress, ComputeMeshSweptHull_FunctionAddress, "CopyToMesh");
		ComputeMeshSweptHull_CopyToMesh_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshSweptHull_FunctionAddress, "CopyToMesh");
		ComputeMeshSweptHull_CopyToMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshSweptHull_FunctionAddress, "CopyToMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshSweptHull_CopyToMeshOut_PropertyAddress, ComputeMeshSweptHull_FunctionAddress, "CopyToMeshOut");
		ComputeMeshSweptHull_CopyToMeshOut_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshSweptHull_FunctionAddress, "CopyToMeshOut");
		ComputeMeshSweptHull_CopyToMeshOut_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshSweptHull_FunctionAddress, "CopyToMeshOut", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshSweptHull_ProjectionFrame_PropertyAddress, ComputeMeshSweptHull_FunctionAddress, "ProjectionFrame");
		ComputeMeshSweptHull_ProjectionFrame_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshSweptHull_FunctionAddress, "ProjectionFrame");
		ComputeMeshSweptHull_ProjectionFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshSweptHull_FunctionAddress, "ProjectionFrame", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshSweptHull_Options_PropertyAddress, ComputeMeshSweptHull_FunctionAddress, "Options");
		ComputeMeshSweptHull_Options_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshSweptHull_FunctionAddress, "Options");
		ComputeMeshSweptHull_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshSweptHull_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshSweptHull_Debug_PropertyAddress, ComputeMeshSweptHull_FunctionAddress, "Debug");
		ComputeMeshSweptHull_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshSweptHull_FunctionAddress, "Debug");
		ComputeMeshSweptHull_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshSweptHull_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshSweptHull_ReturnValue_PropertyAddress, ComputeMeshSweptHull_FunctionAddress, "ReturnValue");
		ComputeMeshSweptHull_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshSweptHull_FunctionAddress, "ReturnValue");
		ComputeMeshSweptHull_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshSweptHull_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ComputeMeshSweptHull_IsValid = ComputeMeshSweptHull_FunctionAddress != IntPtr.Zero && ComputeMeshSweptHull_TargetMesh_IsValid && ComputeMeshSweptHull_CopyToMesh_IsValid && ComputeMeshSweptHull_CopyToMeshOut_IsValid && ComputeMeshSweptHull_ProjectionFrame_IsValid && ComputeMeshSweptHull_Options_IsValid && ComputeMeshSweptHull_Debug_IsValid && ComputeMeshSweptHull_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions:ComputeMeshSweptHull", ComputeMeshSweptHull_IsValid);
		ComputeMeshConvexHull_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ComputeMeshConvexHull");
		ComputeMeshConvexHull_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputeMeshConvexHull_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshConvexHull_TargetMesh_PropertyAddress, ComputeMeshConvexHull_FunctionAddress, "TargetMesh");
		ComputeMeshConvexHull_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshConvexHull_FunctionAddress, "TargetMesh");
		ComputeMeshConvexHull_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshConvexHull_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshConvexHull_CopyToMesh_PropertyAddress, ComputeMeshConvexHull_FunctionAddress, "CopyToMesh");
		ComputeMeshConvexHull_CopyToMesh_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshConvexHull_FunctionAddress, "CopyToMesh");
		ComputeMeshConvexHull_CopyToMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshConvexHull_FunctionAddress, "CopyToMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshConvexHull_CopyToMeshOut_PropertyAddress, ComputeMeshConvexHull_FunctionAddress, "CopyToMeshOut");
		ComputeMeshConvexHull_CopyToMeshOut_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshConvexHull_FunctionAddress, "CopyToMeshOut");
		ComputeMeshConvexHull_CopyToMeshOut_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshConvexHull_FunctionAddress, "CopyToMeshOut", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshConvexHull_Options_PropertyAddress, ComputeMeshConvexHull_FunctionAddress, "Options");
		ComputeMeshConvexHull_Options_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshConvexHull_FunctionAddress, "Options");
		ComputeMeshConvexHull_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshConvexHull_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshConvexHull_Debug_PropertyAddress, ComputeMeshConvexHull_FunctionAddress, "Debug");
		ComputeMeshConvexHull_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshConvexHull_FunctionAddress, "Debug");
		ComputeMeshConvexHull_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshConvexHull_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeMeshConvexHull_ReturnValue_PropertyAddress, ComputeMeshConvexHull_FunctionAddress, "ReturnValue");
		ComputeMeshConvexHull_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComputeMeshConvexHull_FunctionAddress, "ReturnValue");
		ComputeMeshConvexHull_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeMeshConvexHull_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ComputeMeshConvexHull_IsValid = ComputeMeshConvexHull_FunctionAddress != IntPtr.Zero && ComputeMeshConvexHull_TargetMesh_IsValid && ComputeMeshConvexHull_CopyToMesh_IsValid && ComputeMeshConvexHull_CopyToMeshOut_IsValid && ComputeMeshConvexHull_Options_IsValid && ComputeMeshConvexHull_Debug_IsValid && ComputeMeshConvexHull_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_ContainmentFunctions:ComputeMeshConvexHull", ComputeMeshConvexHull_IsValid);
	}
}
