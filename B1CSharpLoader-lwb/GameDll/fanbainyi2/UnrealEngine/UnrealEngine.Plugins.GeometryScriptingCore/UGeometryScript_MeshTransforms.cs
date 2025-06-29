using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshTransforms : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TranslateMesh_IsValid;

	private static IntPtr TranslateMesh_FunctionAddress;

	private static int TranslateMesh_ParamsSize;

	private static bool TranslateMesh_TargetMesh_IsValid;

	private static FFieldAddress TranslateMesh_TargetMesh_PropertyAddress;

	private static int TranslateMesh_TargetMesh_Offset;

	private static bool TranslateMesh_Translation_IsValid;

	private static FFieldAddress TranslateMesh_Translation_PropertyAddress;

	private static int TranslateMesh_Translation_Offset;

	private static bool TranslateMesh_Debug_IsValid;

	private static FFieldAddress TranslateMesh_Debug_PropertyAddress;

	private static int TranslateMesh_Debug_Offset;

	private static bool TranslateMesh_ReturnValue_IsValid;

	private static FFieldAddress TranslateMesh_ReturnValue_PropertyAddress;

	private static int TranslateMesh_ReturnValue_Offset;

	private static bool TransformMesh_IsValid;

	private static IntPtr TransformMesh_FunctionAddress;

	private static int TransformMesh_ParamsSize;

	private static bool TransformMesh_TargetMesh_IsValid;

	private static FFieldAddress TransformMesh_TargetMesh_PropertyAddress;

	private static int TransformMesh_TargetMesh_Offset;

	private static bool TransformMesh_Transform_IsValid;

	private static FFieldAddress TransformMesh_Transform_PropertyAddress;

	private static int TransformMesh_Transform_Offset;

	private static bool TransformMesh_Debug_IsValid;

	private static FFieldAddress TransformMesh_Debug_PropertyAddress;

	private static int TransformMesh_Debug_Offset;

	private static bool TransformMesh_ReturnValue_IsValid;

	private static FFieldAddress TransformMesh_ReturnValue_PropertyAddress;

	private static int TransformMesh_ReturnValue_Offset;

	private static bool ScaleMesh_IsValid;

	private static IntPtr ScaleMesh_FunctionAddress;

	private static int ScaleMesh_ParamsSize;

	private static bool ScaleMesh_TargetMesh_IsValid;

	private static FFieldAddress ScaleMesh_TargetMesh_PropertyAddress;

	private static int ScaleMesh_TargetMesh_Offset;

	private static bool ScaleMesh_Scale_IsValid;

	private static FFieldAddress ScaleMesh_Scale_PropertyAddress;

	private static int ScaleMesh_Scale_Offset;

	private static bool ScaleMesh_Debug_IsValid;

	private static FFieldAddress ScaleMesh_Debug_PropertyAddress;

	private static int ScaleMesh_Debug_Offset;

	private static bool ScaleMesh_ReturnValue_IsValid;

	private static FFieldAddress ScaleMesh_ReturnValue_PropertyAddress;

	private static int ScaleMesh_ReturnValue_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:TranslateMesh")]
	public unsafe static UDynamicMesh TranslateMesh(UDynamicMesh TargetMesh, FVector Translation, UGeometryScriptDebug Debug)
	{
		if (!TranslateMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:TranslateMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TranslateMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TranslateMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, TranslateMesh_TargetMesh_Offset), 0, TranslateMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TranslateMesh_Translation_Offset), 0, TranslateMesh_Translation_PropertyAddress.Address, Translation);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, TranslateMesh_Debug_Offset), 0, TranslateMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TranslateMesh_FunctionAddress, intPtr, TranslateMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, TranslateMesh_ReturnValue_Offset), 0, TranslateMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:TransformMesh")]
	public unsafe static UDynamicMesh TransformMesh(UDynamicMesh TargetMesh, FTransform Transform, UGeometryScriptDebug Debug)
	{
		if (!TransformMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:TransformMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, TransformMesh_TargetMesh_Offset), 0, TransformMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(TransformMesh_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, TransformMesh_Transform_Offset), 0, TransformMesh_Transform_PropertyAddress.Address, Transform);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, TransformMesh_Debug_Offset), 0, TransformMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TransformMesh_FunctionAddress, intPtr, TransformMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, TransformMesh_ReturnValue_Offset), 0, TransformMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:ScaleMesh")]
	public unsafe static UDynamicMesh ScaleMesh(UDynamicMesh TargetMesh, FVector Scale, UGeometryScriptDebug Debug)
	{
		if (!ScaleMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:ScaleMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScaleMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScaleMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ScaleMesh_TargetMesh_Offset), 0, ScaleMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ScaleMesh_Scale_Offset), 0, ScaleMesh_Scale_PropertyAddress.Address, Scale);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ScaleMesh_Debug_Offset), 0, ScaleMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScaleMesh_FunctionAddress, intPtr, ScaleMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ScaleMesh_ReturnValue_Offset), 0, ScaleMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshTransforms()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshTransforms)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshTransforms));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions");
		TranslateMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TranslateMesh");
		TranslateMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(TranslateMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TranslateMesh_TargetMesh_PropertyAddress, TranslateMesh_FunctionAddress, "TargetMesh");
		TranslateMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMesh_FunctionAddress, "TargetMesh");
		TranslateMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateMesh_Translation_PropertyAddress, TranslateMesh_FunctionAddress, "Translation");
		TranslateMesh_Translation_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMesh_FunctionAddress, "Translation");
		TranslateMesh_Translation_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMesh_FunctionAddress, "Translation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateMesh_Debug_PropertyAddress, TranslateMesh_FunctionAddress, "Debug");
		TranslateMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMesh_FunctionAddress, "Debug");
		TranslateMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateMesh_ReturnValue_PropertyAddress, TranslateMesh_FunctionAddress, "ReturnValue");
		TranslateMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TranslateMesh_FunctionAddress, "ReturnValue");
		TranslateMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TranslateMesh_IsValid = TranslateMesh_FunctionAddress != IntPtr.Zero && TranslateMesh_TargetMesh_IsValid && TranslateMesh_Translation_IsValid && TranslateMesh_Debug_IsValid && TranslateMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:TranslateMesh", TranslateMesh_IsValid);
		TransformMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TransformMesh");
		TransformMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformMesh_TargetMesh_PropertyAddress, TransformMesh_FunctionAddress, "TargetMesh");
		TransformMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(TransformMesh_FunctionAddress, "TargetMesh");
		TransformMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformMesh_Transform_PropertyAddress, TransformMesh_FunctionAddress, "Transform");
		TransformMesh_Transform_Offset = NativeReflectionCached.GetPropertyOffset(TransformMesh_FunctionAddress, "Transform");
		TransformMesh_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformMesh_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformMesh_Debug_PropertyAddress, TransformMesh_FunctionAddress, "Debug");
		TransformMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(TransformMesh_FunctionAddress, "Debug");
		TransformMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformMesh_ReturnValue_PropertyAddress, TransformMesh_FunctionAddress, "ReturnValue");
		TransformMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TransformMesh_FunctionAddress, "ReturnValue");
		TransformMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TransformMesh_IsValid = TransformMesh_FunctionAddress != IntPtr.Zero && TransformMesh_TargetMesh_IsValid && TransformMesh_Transform_IsValid && TransformMesh_Debug_IsValid && TransformMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:TransformMesh", TransformMesh_IsValid);
		ScaleMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScaleMesh");
		ScaleMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ScaleMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScaleMesh_TargetMesh_PropertyAddress, ScaleMesh_FunctionAddress, "TargetMesh");
		ScaleMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMesh_FunctionAddress, "TargetMesh");
		ScaleMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMesh_Scale_PropertyAddress, ScaleMesh_FunctionAddress, "Scale");
		ScaleMesh_Scale_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMesh_FunctionAddress, "Scale");
		ScaleMesh_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMesh_FunctionAddress, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMesh_Debug_PropertyAddress, ScaleMesh_FunctionAddress, "Debug");
		ScaleMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMesh_FunctionAddress, "Debug");
		ScaleMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMesh_ReturnValue_PropertyAddress, ScaleMesh_FunctionAddress, "ReturnValue");
		ScaleMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScaleMesh_FunctionAddress, "ReturnValue");
		ScaleMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ScaleMesh_IsValid = ScaleMesh_FunctionAddress != IntPtr.Zero && ScaleMesh_TargetMesh_IsValid && ScaleMesh_Scale_IsValid && ScaleMesh_Debug_IsValid && ScaleMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshTransformFunctions:ScaleMesh", ScaleMesh_IsValid);
	}
}
