using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Plugins.GeometryScriptingCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions", "GeometryScriptingEditor", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_OpenSubdiv : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplyTriangleLoopSubD_IsValid;

	private static IntPtr ApplyTriangleLoopSubD_FunctionAddress;

	private static int ApplyTriangleLoopSubD_ParamsSize;

	private static bool ApplyTriangleLoopSubD_FromDynamicMesh_IsValid;

	private static FFieldAddress ApplyTriangleLoopSubD_FromDynamicMesh_PropertyAddress;

	private static int ApplyTriangleLoopSubD_FromDynamicMesh_Offset;

	private static bool ApplyTriangleLoopSubD_Subdivisions_IsValid;

	private static FFieldAddress ApplyTriangleLoopSubD_Subdivisions_PropertyAddress;

	private static int ApplyTriangleLoopSubD_Subdivisions_Offset;

	private static bool ApplyTriangleLoopSubD_Debug_IsValid;

	private static FFieldAddress ApplyTriangleLoopSubD_Debug_PropertyAddress;

	private static int ApplyTriangleLoopSubD_Debug_Offset;

	private static bool ApplyTriangleLoopSubD_ReturnValue_IsValid;

	private static FFieldAddress ApplyTriangleLoopSubD_ReturnValue_PropertyAddress;

	private static int ApplyTriangleLoopSubD_ReturnValue_Offset;

	private static bool ApplyPolygroupCatmullClarkSubD_IsValid;

	private static IntPtr ApplyPolygroupCatmullClarkSubD_FunctionAddress;

	private static int ApplyPolygroupCatmullClarkSubD_ParamsSize;

	private static bool ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_IsValid;

	private static FFieldAddress ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_PropertyAddress;

	private static int ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_Offset;

	private static bool ApplyPolygroupCatmullClarkSubD_Subdivisions_IsValid;

	private static FFieldAddress ApplyPolygroupCatmullClarkSubD_Subdivisions_PropertyAddress;

	private static int ApplyPolygroupCatmullClarkSubD_Subdivisions_Offset;

	private static bool ApplyPolygroupCatmullClarkSubD_GroupLayer_IsValid;

	private static FFieldAddress ApplyPolygroupCatmullClarkSubD_GroupLayer_PropertyAddress;

	private static int ApplyPolygroupCatmullClarkSubD_GroupLayer_Offset;

	private static bool ApplyPolygroupCatmullClarkSubD_Debug_IsValid;

	private static FFieldAddress ApplyPolygroupCatmullClarkSubD_Debug_PropertyAddress;

	private static int ApplyPolygroupCatmullClarkSubD_Debug_Offset;

	private static bool ApplyPolygroupCatmullClarkSubD_ReturnValue_IsValid;

	private static FFieldAddress ApplyPolygroupCatmullClarkSubD_ReturnValue_PropertyAddress;

	private static int ApplyPolygroupCatmullClarkSubD_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions:ApplyTriangleLoopSubD")]
	public unsafe static UDynamicMesh ApplyTriangleLoopSubD(UDynamicMesh FromDynamicMesh, int Subdivisions, UGeometryScriptDebug Debug)
	{
		if (!ApplyTriangleLoopSubD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions:ApplyTriangleLoopSubD");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyTriangleLoopSubD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyTriangleLoopSubD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyTriangleLoopSubD_FromDynamicMesh_Offset), 0, ApplyTriangleLoopSubD_FromDynamicMesh_PropertyAddress.Address, FromDynamicMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyTriangleLoopSubD_Subdivisions_Offset), 0, ApplyTriangleLoopSubD_Subdivisions_PropertyAddress.Address, Subdivisions);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyTriangleLoopSubD_Debug_Offset), 0, ApplyTriangleLoopSubD_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyTriangleLoopSubD_FunctionAddress, intPtr, ApplyTriangleLoopSubD_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyTriangleLoopSubD_ReturnValue_Offset), 0, ApplyTriangleLoopSubD_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions:ApplyPolygroupCatmullClarkSubD")]
	public unsafe static UDynamicMesh ApplyPolygroupCatmullClarkSubD(UDynamicMesh FromDynamicMesh, int Subdivisions, FGeometryScriptGroupLayer GroupLayer, UGeometryScriptDebug Debug)
	{
		if (!ApplyPolygroupCatmullClarkSubD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions:ApplyPolygroupCatmullClarkSubD");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPolygroupCatmullClarkSubD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPolygroupCatmullClarkSubD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_Offset), 0, ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_PropertyAddress.Address, FromDynamicMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyPolygroupCatmullClarkSubD_Subdivisions_Offset), 0, ApplyPolygroupCatmullClarkSubD_Subdivisions_PropertyAddress.Address, Subdivisions);
		NativeReflection.InitializeValue_InContainer(ApplyPolygroupCatmullClarkSubD_GroupLayer_PropertyAddress.Address, intPtr);
		FGeometryScriptGroupLayer.ToNative(IntPtr.Add(intPtr, ApplyPolygroupCatmullClarkSubD_GroupLayer_Offset), 0, ApplyPolygroupCatmullClarkSubD_GroupLayer_PropertyAddress.Address, GroupLayer);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyPolygroupCatmullClarkSubD_Debug_Offset), 0, ApplyPolygroupCatmullClarkSubD_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyPolygroupCatmullClarkSubD_FunctionAddress, intPtr, ApplyPolygroupCatmullClarkSubD_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyPolygroupCatmullClarkSubD_ReturnValue_Offset), 0, ApplyPolygroupCatmullClarkSubD_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_OpenSubdiv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_OpenSubdiv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_OpenSubdiv));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions");
		ApplyTriangleLoopSubD_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyTriangleLoopSubD");
		ApplyTriangleLoopSubD_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyTriangleLoopSubD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyTriangleLoopSubD_FromDynamicMesh_PropertyAddress, ApplyTriangleLoopSubD_FunctionAddress, "FromDynamicMesh");
		ApplyTriangleLoopSubD_FromDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTriangleLoopSubD_FunctionAddress, "FromDynamicMesh");
		ApplyTriangleLoopSubD_FromDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTriangleLoopSubD_FunctionAddress, "FromDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTriangleLoopSubD_Subdivisions_PropertyAddress, ApplyTriangleLoopSubD_FunctionAddress, "Subdivisions");
		ApplyTriangleLoopSubD_Subdivisions_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTriangleLoopSubD_FunctionAddress, "Subdivisions");
		ApplyTriangleLoopSubD_Subdivisions_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTriangleLoopSubD_FunctionAddress, "Subdivisions", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTriangleLoopSubD_Debug_PropertyAddress, ApplyTriangleLoopSubD_FunctionAddress, "Debug");
		ApplyTriangleLoopSubD_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTriangleLoopSubD_FunctionAddress, "Debug");
		ApplyTriangleLoopSubD_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTriangleLoopSubD_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTriangleLoopSubD_ReturnValue_PropertyAddress, ApplyTriangleLoopSubD_FunctionAddress, "ReturnValue");
		ApplyTriangleLoopSubD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTriangleLoopSubD_FunctionAddress, "ReturnValue");
		ApplyTriangleLoopSubD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTriangleLoopSubD_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyTriangleLoopSubD_IsValid = ApplyTriangleLoopSubD_FunctionAddress != IntPtr.Zero && ApplyTriangleLoopSubD_FromDynamicMesh_IsValid && ApplyTriangleLoopSubD_Subdivisions_IsValid && ApplyTriangleLoopSubD_Debug_IsValid && ApplyTriangleLoopSubD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions:ApplyTriangleLoopSubD", ApplyTriangleLoopSubD_IsValid);
		ApplyPolygroupCatmullClarkSubD_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyPolygroupCatmullClarkSubD");
		ApplyPolygroupCatmullClarkSubD_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPolygroupCatmullClarkSubD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_PropertyAddress, ApplyPolygroupCatmullClarkSubD_FunctionAddress, "FromDynamicMesh");
		ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "FromDynamicMesh");
		ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "FromDynamicMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPolygroupCatmullClarkSubD_Subdivisions_PropertyAddress, ApplyPolygroupCatmullClarkSubD_FunctionAddress, "Subdivisions");
		ApplyPolygroupCatmullClarkSubD_Subdivisions_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "Subdivisions");
		ApplyPolygroupCatmullClarkSubD_Subdivisions_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "Subdivisions", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPolygroupCatmullClarkSubD_GroupLayer_PropertyAddress, ApplyPolygroupCatmullClarkSubD_FunctionAddress, "GroupLayer");
		ApplyPolygroupCatmullClarkSubD_GroupLayer_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "GroupLayer");
		ApplyPolygroupCatmullClarkSubD_GroupLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "GroupLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPolygroupCatmullClarkSubD_Debug_PropertyAddress, ApplyPolygroupCatmullClarkSubD_FunctionAddress, "Debug");
		ApplyPolygroupCatmullClarkSubD_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "Debug");
		ApplyPolygroupCatmullClarkSubD_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPolygroupCatmullClarkSubD_ReturnValue_PropertyAddress, ApplyPolygroupCatmullClarkSubD_FunctionAddress, "ReturnValue");
		ApplyPolygroupCatmullClarkSubD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "ReturnValue");
		ApplyPolygroupCatmullClarkSubD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPolygroupCatmullClarkSubD_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyPolygroupCatmullClarkSubD_IsValid = ApplyPolygroupCatmullClarkSubD_FunctionAddress != IntPtr.Zero && ApplyPolygroupCatmullClarkSubD_FromDynamicMesh_IsValid && ApplyPolygroupCatmullClarkSubD_Subdivisions_IsValid && ApplyPolygroupCatmullClarkSubD_GroupLayer_IsValid && ApplyPolygroupCatmullClarkSubD_Debug_IsValid && ApplyPolygroupCatmullClarkSubD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingEditor.GeometryScriptLibrary_OpenSubdivFunctions:ApplyPolygroupCatmullClarkSubD", ApplyPolygroupCatmullClarkSubD_IsValid);
	}
}
