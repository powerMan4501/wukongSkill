using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshDeformers : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplyTwistWarpToMesh_IsValid;

	private static IntPtr ApplyTwistWarpToMesh_FunctionAddress;

	private static int ApplyTwistWarpToMesh_ParamsSize;

	private static bool ApplyTwistWarpToMesh_TargetMesh_IsValid;

	private static FFieldAddress ApplyTwistWarpToMesh_TargetMesh_PropertyAddress;

	private static int ApplyTwistWarpToMesh_TargetMesh_Offset;

	private static bool ApplyTwistWarpToMesh_Options_IsValid;

	private static FFieldAddress ApplyTwistWarpToMesh_Options_PropertyAddress;

	private static int ApplyTwistWarpToMesh_Options_Offset;

	private static bool ApplyTwistWarpToMesh_TwistOrientation_IsValid;

	private static FFieldAddress ApplyTwistWarpToMesh_TwistOrientation_PropertyAddress;

	private static int ApplyTwistWarpToMesh_TwistOrientation_Offset;

	private static bool ApplyTwistWarpToMesh_TwistAngle_IsValid;

	private static FFieldAddress ApplyTwistWarpToMesh_TwistAngle_PropertyAddress;

	private static int ApplyTwistWarpToMesh_TwistAngle_Offset;

	private static bool ApplyTwistWarpToMesh_TwistExtent_IsValid;

	private static FFieldAddress ApplyTwistWarpToMesh_TwistExtent_PropertyAddress;

	private static int ApplyTwistWarpToMesh_TwistExtent_Offset;

	private static bool ApplyTwistWarpToMesh_Debug_IsValid;

	private static FFieldAddress ApplyTwistWarpToMesh_Debug_PropertyAddress;

	private static int ApplyTwistWarpToMesh_Debug_Offset;

	private static bool ApplyTwistWarpToMesh_ReturnValue_IsValid;

	private static FFieldAddress ApplyTwistWarpToMesh_ReturnValue_PropertyAddress;

	private static int ApplyTwistWarpToMesh_ReturnValue_Offset;

	private static bool ApplyPerlinNoiseToMesh_IsValid;

	private static IntPtr ApplyPerlinNoiseToMesh_FunctionAddress;

	private static int ApplyPerlinNoiseToMesh_ParamsSize;

	private static bool ApplyPerlinNoiseToMesh_TargetMesh_IsValid;

	private static FFieldAddress ApplyPerlinNoiseToMesh_TargetMesh_PropertyAddress;

	private static int ApplyPerlinNoiseToMesh_TargetMesh_Offset;

	private static bool ApplyPerlinNoiseToMesh_Options_IsValid;

	private static FFieldAddress ApplyPerlinNoiseToMesh_Options_PropertyAddress;

	private static int ApplyPerlinNoiseToMesh_Options_Offset;

	private static bool ApplyPerlinNoiseToMesh_Debug_IsValid;

	private static FFieldAddress ApplyPerlinNoiseToMesh_Debug_PropertyAddress;

	private static int ApplyPerlinNoiseToMesh_Debug_Offset;

	private static bool ApplyPerlinNoiseToMesh_ReturnValue_IsValid;

	private static FFieldAddress ApplyPerlinNoiseToMesh_ReturnValue_PropertyAddress;

	private static int ApplyPerlinNoiseToMesh_ReturnValue_Offset;

	private static bool ApplyMathWarpToMesh_IsValid;

	private static IntPtr ApplyMathWarpToMesh_FunctionAddress;

	private static int ApplyMathWarpToMesh_ParamsSize;

	private static bool ApplyMathWarpToMesh_TargetMesh_IsValid;

	private static FFieldAddress ApplyMathWarpToMesh_TargetMesh_PropertyAddress;

	private static int ApplyMathWarpToMesh_TargetMesh_Offset;

	private static bool ApplyMathWarpToMesh_WarpOrientation_IsValid;

	private static FFieldAddress ApplyMathWarpToMesh_WarpOrientation_PropertyAddress;

	private static int ApplyMathWarpToMesh_WarpOrientation_Offset;

	private static bool ApplyMathWarpToMesh_WarpType_IsValid;

	private static FFieldAddress ApplyMathWarpToMesh_WarpType_PropertyAddress;

	private static int ApplyMathWarpToMesh_WarpType_Offset;

	private static bool ApplyMathWarpToMesh_Options_IsValid;

	private static FFieldAddress ApplyMathWarpToMesh_Options_PropertyAddress;

	private static int ApplyMathWarpToMesh_Options_Offset;

	private static bool ApplyMathWarpToMesh_Debug_IsValid;

	private static FFieldAddress ApplyMathWarpToMesh_Debug_PropertyAddress;

	private static int ApplyMathWarpToMesh_Debug_Offset;

	private static bool ApplyMathWarpToMesh_ReturnValue_IsValid;

	private static FFieldAddress ApplyMathWarpToMesh_ReturnValue_PropertyAddress;

	private static int ApplyMathWarpToMesh_ReturnValue_Offset;

	private static bool ApplyIterativeSmoothingToMesh_IsValid;

	private static IntPtr ApplyIterativeSmoothingToMesh_FunctionAddress;

	private static int ApplyIterativeSmoothingToMesh_ParamsSize;

	private static bool ApplyIterativeSmoothingToMesh_TargetMesh_IsValid;

	private static FFieldAddress ApplyIterativeSmoothingToMesh_TargetMesh_PropertyAddress;

	private static int ApplyIterativeSmoothingToMesh_TargetMesh_Offset;

	private static bool ApplyIterativeSmoothingToMesh_Options_IsValid;

	private static FFieldAddress ApplyIterativeSmoothingToMesh_Options_PropertyAddress;

	private static int ApplyIterativeSmoothingToMesh_Options_Offset;

	private static bool ApplyIterativeSmoothingToMesh_Debug_IsValid;

	private static FFieldAddress ApplyIterativeSmoothingToMesh_Debug_PropertyAddress;

	private static int ApplyIterativeSmoothingToMesh_Debug_Offset;

	private static bool ApplyIterativeSmoothingToMesh_ReturnValue_IsValid;

	private static FFieldAddress ApplyIterativeSmoothingToMesh_ReturnValue_PropertyAddress;

	private static int ApplyIterativeSmoothingToMesh_ReturnValue_Offset;

	private static bool ApplyFlareWarpToMesh_IsValid;

	private static IntPtr ApplyFlareWarpToMesh_FunctionAddress;

	private static int ApplyFlareWarpToMesh_ParamsSize;

	private static bool ApplyFlareWarpToMesh_TargetMesh_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_TargetMesh_PropertyAddress;

	private static int ApplyFlareWarpToMesh_TargetMesh_Offset;

	private static bool ApplyFlareWarpToMesh_Options_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_Options_PropertyAddress;

	private static int ApplyFlareWarpToMesh_Options_Offset;

	private static bool ApplyFlareWarpToMesh_FlareOrientation_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_FlareOrientation_PropertyAddress;

	private static int ApplyFlareWarpToMesh_FlareOrientation_Offset;

	private static bool ApplyFlareWarpToMesh_FlarePercentX_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_FlarePercentX_PropertyAddress;

	private static int ApplyFlareWarpToMesh_FlarePercentX_Offset;

	private static bool ApplyFlareWarpToMesh_FlarePercentY_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_FlarePercentY_PropertyAddress;

	private static int ApplyFlareWarpToMesh_FlarePercentY_Offset;

	private static bool ApplyFlareWarpToMesh_FlareExtent_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_FlareExtent_PropertyAddress;

	private static int ApplyFlareWarpToMesh_FlareExtent_Offset;

	private static bool ApplyFlareWarpToMesh_Debug_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_Debug_PropertyAddress;

	private static int ApplyFlareWarpToMesh_Debug_Offset;

	private static bool ApplyFlareWarpToMesh_ReturnValue_IsValid;

	private static FFieldAddress ApplyFlareWarpToMesh_ReturnValue_PropertyAddress;

	private static int ApplyFlareWarpToMesh_ReturnValue_Offset;

	private static bool ApplyDisplaceFromTextureMap_IsValid;

	private static IntPtr ApplyDisplaceFromTextureMap_FunctionAddress;

	private static int ApplyDisplaceFromTextureMap_ParamsSize;

	private static bool ApplyDisplaceFromTextureMap_TargetMesh_IsValid;

	private static FFieldAddress ApplyDisplaceFromTextureMap_TargetMesh_PropertyAddress;

	private static int ApplyDisplaceFromTextureMap_TargetMesh_Offset;

	private static bool ApplyDisplaceFromTextureMap_Texture_IsValid;

	private static FFieldAddress ApplyDisplaceFromTextureMap_Texture_PropertyAddress;

	private static int ApplyDisplaceFromTextureMap_Texture_Offset;

	private static bool ApplyDisplaceFromTextureMap_Options_IsValid;

	private static FFieldAddress ApplyDisplaceFromTextureMap_Options_PropertyAddress;

	private static int ApplyDisplaceFromTextureMap_Options_Offset;

	private static bool ApplyDisplaceFromTextureMap_UVLayer_IsValid;

	private static FFieldAddress ApplyDisplaceFromTextureMap_UVLayer_PropertyAddress;

	private static int ApplyDisplaceFromTextureMap_UVLayer_Offset;

	private static bool ApplyDisplaceFromTextureMap_Debug_IsValid;

	private static FFieldAddress ApplyDisplaceFromTextureMap_Debug_PropertyAddress;

	private static int ApplyDisplaceFromTextureMap_Debug_Offset;

	private static bool ApplyDisplaceFromTextureMap_ReturnValue_IsValid;

	private static FFieldAddress ApplyDisplaceFromTextureMap_ReturnValue_PropertyAddress;

	private static int ApplyDisplaceFromTextureMap_ReturnValue_Offset;

	private static bool ApplyBendWarpToMesh_IsValid;

	private static IntPtr ApplyBendWarpToMesh_FunctionAddress;

	private static int ApplyBendWarpToMesh_ParamsSize;

	private static bool ApplyBendWarpToMesh_TargetMesh_IsValid;

	private static FFieldAddress ApplyBendWarpToMesh_TargetMesh_PropertyAddress;

	private static int ApplyBendWarpToMesh_TargetMesh_Offset;

	private static bool ApplyBendWarpToMesh_Options_IsValid;

	private static FFieldAddress ApplyBendWarpToMesh_Options_PropertyAddress;

	private static int ApplyBendWarpToMesh_Options_Offset;

	private static bool ApplyBendWarpToMesh_BendOrientation_IsValid;

	private static FFieldAddress ApplyBendWarpToMesh_BendOrientation_PropertyAddress;

	private static int ApplyBendWarpToMesh_BendOrientation_Offset;

	private static bool ApplyBendWarpToMesh_BendAngle_IsValid;

	private static FFieldAddress ApplyBendWarpToMesh_BendAngle_PropertyAddress;

	private static int ApplyBendWarpToMesh_BendAngle_Offset;

	private static bool ApplyBendWarpToMesh_BendExtent_IsValid;

	private static FFieldAddress ApplyBendWarpToMesh_BendExtent_PropertyAddress;

	private static int ApplyBendWarpToMesh_BendExtent_Offset;

	private static bool ApplyBendWarpToMesh_Debug_IsValid;

	private static FFieldAddress ApplyBendWarpToMesh_Debug_PropertyAddress;

	private static int ApplyBendWarpToMesh_Debug_Offset;

	private static bool ApplyBendWarpToMesh_ReturnValue_IsValid;

	private static FFieldAddress ApplyBendWarpToMesh_ReturnValue_PropertyAddress;

	private static int ApplyBendWarpToMesh_ReturnValue_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyTwistWarpToMesh")]
	public unsafe static UDynamicMesh ApplyTwistWarpToMesh(UDynamicMesh TargetMesh, FGeometryScriptTwistWarpOptions Options, FTransform TwistOrientation, float TwistAngle, float TwistExtent, UGeometryScriptDebug Debug)
	{
		if (!ApplyTwistWarpToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyTwistWarpToMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyTwistWarpToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyTwistWarpToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyTwistWarpToMesh_TargetMesh_Offset), 0, ApplyTwistWarpToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyTwistWarpToMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptTwistWarpOptions.ToNative(IntPtr.Add(intPtr, ApplyTwistWarpToMesh_Options_Offset), 0, ApplyTwistWarpToMesh_Options_PropertyAddress.Address, Options);
		NativeReflection.InitializeValue_InContainer(ApplyTwistWarpToMesh_TwistOrientation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyTwistWarpToMesh_TwistOrientation_Offset), 0, ApplyTwistWarpToMesh_TwistOrientation_PropertyAddress.Address, TwistOrientation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyTwistWarpToMesh_TwistAngle_Offset), 0, ApplyTwistWarpToMesh_TwistAngle_PropertyAddress.Address, TwistAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyTwistWarpToMesh_TwistExtent_Offset), 0, ApplyTwistWarpToMesh_TwistExtent_PropertyAddress.Address, TwistExtent);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyTwistWarpToMesh_Debug_Offset), 0, ApplyTwistWarpToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyTwistWarpToMesh_FunctionAddress, intPtr, ApplyTwistWarpToMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyTwistWarpToMesh_ReturnValue_Offset), 0, ApplyTwistWarpToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyPerlinNoiseToMesh")]
	public unsafe static UDynamicMesh ApplyPerlinNoiseToMesh(UDynamicMesh TargetMesh, FGeometryScriptPerlinNoiseOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyPerlinNoiseToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyPerlinNoiseToMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPerlinNoiseToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPerlinNoiseToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyPerlinNoiseToMesh_TargetMesh_Offset), 0, ApplyPerlinNoiseToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyPerlinNoiseToMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptPerlinNoiseOptions.ToNative(IntPtr.Add(intPtr, ApplyPerlinNoiseToMesh_Options_Offset), 0, ApplyPerlinNoiseToMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyPerlinNoiseToMesh_Debug_Offset), 0, ApplyPerlinNoiseToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyPerlinNoiseToMesh_FunctionAddress, intPtr, ApplyPerlinNoiseToMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyPerlinNoiseToMesh_ReturnValue_Offset), 0, ApplyPerlinNoiseToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyMathWarpToMesh")]
	public unsafe static UDynamicMesh ApplyMathWarpToMesh(UDynamicMesh TargetMesh, FTransform WarpOrientation, EGeometryScriptMathWarpType WarpType, FGeometryScriptMathWarpOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyMathWarpToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyMathWarpToMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyMathWarpToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyMathWarpToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyMathWarpToMesh_TargetMesh_Offset), 0, ApplyMathWarpToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyMathWarpToMesh_WarpOrientation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyMathWarpToMesh_WarpOrientation_Offset), 0, ApplyMathWarpToMesh_WarpOrientation_PropertyAddress.Address, WarpOrientation);
		EnumMarshaler<EGeometryScriptMathWarpType>.ToNative(IntPtr.Add(intPtr, ApplyMathWarpToMesh_WarpType_Offset), 0, ApplyMathWarpToMesh_WarpType_PropertyAddress.Address, WarpType);
		NativeReflection.InitializeValue_InContainer(ApplyMathWarpToMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMathWarpOptions.ToNative(IntPtr.Add(intPtr, ApplyMathWarpToMesh_Options_Offset), 0, ApplyMathWarpToMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyMathWarpToMesh_Debug_Offset), 0, ApplyMathWarpToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyMathWarpToMesh_FunctionAddress, intPtr, ApplyMathWarpToMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyMathWarpToMesh_ReturnValue_Offset), 0, ApplyMathWarpToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyIterativeSmoothingToMesh")]
	public unsafe static UDynamicMesh ApplyIterativeSmoothingToMesh(UDynamicMesh TargetMesh, FGeometryScriptIterativeMeshSmoothingOptions Options, UGeometryScriptDebug Debug)
	{
		if (!ApplyIterativeSmoothingToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyIterativeSmoothingToMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyIterativeSmoothingToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyIterativeSmoothingToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyIterativeSmoothingToMesh_TargetMesh_Offset), 0, ApplyIterativeSmoothingToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyIterativeSmoothingToMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptIterativeMeshSmoothingOptions.ToNative(IntPtr.Add(intPtr, ApplyIterativeSmoothingToMesh_Options_Offset), 0, ApplyIterativeSmoothingToMesh_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyIterativeSmoothingToMesh_Debug_Offset), 0, ApplyIterativeSmoothingToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyIterativeSmoothingToMesh_FunctionAddress, intPtr, ApplyIterativeSmoothingToMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyIterativeSmoothingToMesh_ReturnValue_Offset), 0, ApplyIterativeSmoothingToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyFlareWarpToMesh")]
	public unsafe static UDynamicMesh ApplyFlareWarpToMesh(UDynamicMesh TargetMesh, FGeometryScriptFlareWarpOptions Options, FTransform FlareOrientation, float FlarePercentX, float FlarePercentY, float FlareExtent, UGeometryScriptDebug Debug)
	{
		if (!ApplyFlareWarpToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyFlareWarpToMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyFlareWarpToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyFlareWarpToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_TargetMesh_Offset), 0, ApplyFlareWarpToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyFlareWarpToMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptFlareWarpOptions.ToNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_Options_Offset), 0, ApplyFlareWarpToMesh_Options_PropertyAddress.Address, Options);
		NativeReflection.InitializeValue_InContainer(ApplyFlareWarpToMesh_FlareOrientation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_FlareOrientation_Offset), 0, ApplyFlareWarpToMesh_FlareOrientation_PropertyAddress.Address, FlareOrientation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_FlarePercentX_Offset), 0, ApplyFlareWarpToMesh_FlarePercentX_PropertyAddress.Address, FlarePercentX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_FlarePercentY_Offset), 0, ApplyFlareWarpToMesh_FlarePercentY_PropertyAddress.Address, FlarePercentY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_FlareExtent_Offset), 0, ApplyFlareWarpToMesh_FlareExtent_PropertyAddress.Address, FlareExtent);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_Debug_Offset), 0, ApplyFlareWarpToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyFlareWarpToMesh_FunctionAddress, intPtr, ApplyFlareWarpToMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyFlareWarpToMesh_ReturnValue_Offset), 0, ApplyFlareWarpToMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyDisplaceFromTextureMap")]
	public unsafe static UDynamicMesh ApplyDisplaceFromTextureMap(UDynamicMesh TargetMesh, UTexture2D Texture, FGeometryScriptDisplaceFromTextureOptions Options, int UVLayer, UGeometryScriptDebug Debug)
	{
		if (!ApplyDisplaceFromTextureMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyDisplaceFromTextureMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyDisplaceFromTextureMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyDisplaceFromTextureMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyDisplaceFromTextureMap_TargetMesh_Offset), 0, ApplyDisplaceFromTextureMap_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, ApplyDisplaceFromTextureMap_Texture_Offset), 0, ApplyDisplaceFromTextureMap_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InitializeValue_InContainer(ApplyDisplaceFromTextureMap_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptDisplaceFromTextureOptions.ToNative(IntPtr.Add(intPtr, ApplyDisplaceFromTextureMap_Options_Offset), 0, ApplyDisplaceFromTextureMap_Options_PropertyAddress.Address, Options);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyDisplaceFromTextureMap_UVLayer_Offset), 0, ApplyDisplaceFromTextureMap_UVLayer_PropertyAddress.Address, UVLayer);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyDisplaceFromTextureMap_Debug_Offset), 0, ApplyDisplaceFromTextureMap_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyDisplaceFromTextureMap_FunctionAddress, intPtr, ApplyDisplaceFromTextureMap_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyDisplaceFromTextureMap_ReturnValue_Offset), 0, ApplyDisplaceFromTextureMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyBendWarpToMesh")]
	public unsafe static UDynamicMesh ApplyBendWarpToMesh(UDynamicMesh TargetMesh, FGeometryScriptBendWarpOptions Options, FTransform BendOrientation, float BendAngle, float BendExtent, UGeometryScriptDebug Debug)
	{
		if (!ApplyBendWarpToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyBendWarpToMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyBendWarpToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyBendWarpToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, ApplyBendWarpToMesh_TargetMesh_Offset), 0, ApplyBendWarpToMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(ApplyBendWarpToMesh_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptBendWarpOptions.ToNative(IntPtr.Add(intPtr, ApplyBendWarpToMesh_Options_Offset), 0, ApplyBendWarpToMesh_Options_PropertyAddress.Address, Options);
		NativeReflection.InitializeValue_InContainer(ApplyBendWarpToMesh_BendOrientation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyBendWarpToMesh_BendOrientation_Offset), 0, ApplyBendWarpToMesh_BendOrientation_PropertyAddress.Address, BendOrientation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyBendWarpToMesh_BendAngle_Offset), 0, ApplyBendWarpToMesh_BendAngle_PropertyAddress.Address, BendAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyBendWarpToMesh_BendExtent_Offset), 0, ApplyBendWarpToMesh_BendExtent_PropertyAddress.Address, BendExtent);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, ApplyBendWarpToMesh_Debug_Offset), 0, ApplyBendWarpToMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyBendWarpToMesh_FunctionAddress, intPtr, ApplyBendWarpToMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, ApplyBendWarpToMesh_ReturnValue_Offset), 0, ApplyBendWarpToMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshDeformers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshDeformers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshDeformers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions");
		ApplyTwistWarpToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyTwistWarpToMesh");
		ApplyTwistWarpToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyTwistWarpToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyTwistWarpToMesh_TargetMesh_PropertyAddress, ApplyTwistWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyTwistWarpToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTwistWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyTwistWarpToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTwistWarpToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTwistWarpToMesh_Options_PropertyAddress, ApplyTwistWarpToMesh_FunctionAddress, "Options");
		ApplyTwistWarpToMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTwistWarpToMesh_FunctionAddress, "Options");
		ApplyTwistWarpToMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTwistWarpToMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTwistWarpToMesh_TwistOrientation_PropertyAddress, ApplyTwistWarpToMesh_FunctionAddress, "TwistOrientation");
		ApplyTwistWarpToMesh_TwistOrientation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTwistWarpToMesh_FunctionAddress, "TwistOrientation");
		ApplyTwistWarpToMesh_TwistOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTwistWarpToMesh_FunctionAddress, "TwistOrientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTwistWarpToMesh_TwistAngle_PropertyAddress, ApplyTwistWarpToMesh_FunctionAddress, "TwistAngle");
		ApplyTwistWarpToMesh_TwistAngle_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTwistWarpToMesh_FunctionAddress, "TwistAngle");
		ApplyTwistWarpToMesh_TwistAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTwistWarpToMesh_FunctionAddress, "TwistAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTwistWarpToMesh_TwistExtent_PropertyAddress, ApplyTwistWarpToMesh_FunctionAddress, "TwistExtent");
		ApplyTwistWarpToMesh_TwistExtent_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTwistWarpToMesh_FunctionAddress, "TwistExtent");
		ApplyTwistWarpToMesh_TwistExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTwistWarpToMesh_FunctionAddress, "TwistExtent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTwistWarpToMesh_Debug_PropertyAddress, ApplyTwistWarpToMesh_FunctionAddress, "Debug");
		ApplyTwistWarpToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTwistWarpToMesh_FunctionAddress, "Debug");
		ApplyTwistWarpToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTwistWarpToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyTwistWarpToMesh_ReturnValue_PropertyAddress, ApplyTwistWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyTwistWarpToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyTwistWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyTwistWarpToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyTwistWarpToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyTwistWarpToMesh_IsValid = ApplyTwistWarpToMesh_FunctionAddress != IntPtr.Zero && ApplyTwistWarpToMesh_TargetMesh_IsValid && ApplyTwistWarpToMesh_Options_IsValid && ApplyTwistWarpToMesh_TwistOrientation_IsValid && ApplyTwistWarpToMesh_TwistAngle_IsValid && ApplyTwistWarpToMesh_TwistExtent_IsValid && ApplyTwistWarpToMesh_Debug_IsValid && ApplyTwistWarpToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyTwistWarpToMesh", ApplyTwistWarpToMesh_IsValid);
		ApplyPerlinNoiseToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyPerlinNoiseToMesh");
		ApplyPerlinNoiseToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPerlinNoiseToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPerlinNoiseToMesh_TargetMesh_PropertyAddress, ApplyPerlinNoiseToMesh_FunctionAddress, "TargetMesh");
		ApplyPerlinNoiseToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPerlinNoiseToMesh_FunctionAddress, "TargetMesh");
		ApplyPerlinNoiseToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPerlinNoiseToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPerlinNoiseToMesh_Options_PropertyAddress, ApplyPerlinNoiseToMesh_FunctionAddress, "Options");
		ApplyPerlinNoiseToMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPerlinNoiseToMesh_FunctionAddress, "Options");
		ApplyPerlinNoiseToMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPerlinNoiseToMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPerlinNoiseToMesh_Debug_PropertyAddress, ApplyPerlinNoiseToMesh_FunctionAddress, "Debug");
		ApplyPerlinNoiseToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPerlinNoiseToMesh_FunctionAddress, "Debug");
		ApplyPerlinNoiseToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPerlinNoiseToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPerlinNoiseToMesh_ReturnValue_PropertyAddress, ApplyPerlinNoiseToMesh_FunctionAddress, "ReturnValue");
		ApplyPerlinNoiseToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPerlinNoiseToMesh_FunctionAddress, "ReturnValue");
		ApplyPerlinNoiseToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPerlinNoiseToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyPerlinNoiseToMesh_IsValid = ApplyPerlinNoiseToMesh_FunctionAddress != IntPtr.Zero && ApplyPerlinNoiseToMesh_TargetMesh_IsValid && ApplyPerlinNoiseToMesh_Options_IsValid && ApplyPerlinNoiseToMesh_Debug_IsValid && ApplyPerlinNoiseToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyPerlinNoiseToMesh", ApplyPerlinNoiseToMesh_IsValid);
		ApplyMathWarpToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyMathWarpToMesh");
		ApplyMathWarpToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyMathWarpToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyMathWarpToMesh_TargetMesh_PropertyAddress, ApplyMathWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyMathWarpToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMathWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyMathWarpToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMathWarpToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMathWarpToMesh_WarpOrientation_PropertyAddress, ApplyMathWarpToMesh_FunctionAddress, "WarpOrientation");
		ApplyMathWarpToMesh_WarpOrientation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMathWarpToMesh_FunctionAddress, "WarpOrientation");
		ApplyMathWarpToMesh_WarpOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMathWarpToMesh_FunctionAddress, "WarpOrientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMathWarpToMesh_WarpType_PropertyAddress, ApplyMathWarpToMesh_FunctionAddress, "WarpType");
		ApplyMathWarpToMesh_WarpType_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMathWarpToMesh_FunctionAddress, "WarpType");
		ApplyMathWarpToMesh_WarpType_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMathWarpToMesh_FunctionAddress, "WarpType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMathWarpToMesh_Options_PropertyAddress, ApplyMathWarpToMesh_FunctionAddress, "Options");
		ApplyMathWarpToMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMathWarpToMesh_FunctionAddress, "Options");
		ApplyMathWarpToMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMathWarpToMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMathWarpToMesh_Debug_PropertyAddress, ApplyMathWarpToMesh_FunctionAddress, "Debug");
		ApplyMathWarpToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMathWarpToMesh_FunctionAddress, "Debug");
		ApplyMathWarpToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMathWarpToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMathWarpToMesh_ReturnValue_PropertyAddress, ApplyMathWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyMathWarpToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyMathWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyMathWarpToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyMathWarpToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyMathWarpToMesh_IsValid = ApplyMathWarpToMesh_FunctionAddress != IntPtr.Zero && ApplyMathWarpToMesh_TargetMesh_IsValid && ApplyMathWarpToMesh_WarpOrientation_IsValid && ApplyMathWarpToMesh_WarpType_IsValid && ApplyMathWarpToMesh_Options_IsValid && ApplyMathWarpToMesh_Debug_IsValid && ApplyMathWarpToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyMathWarpToMesh", ApplyMathWarpToMesh_IsValid);
		ApplyIterativeSmoothingToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyIterativeSmoothingToMesh");
		ApplyIterativeSmoothingToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyIterativeSmoothingToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyIterativeSmoothingToMesh_TargetMesh_PropertyAddress, ApplyIterativeSmoothingToMesh_FunctionAddress, "TargetMesh");
		ApplyIterativeSmoothingToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyIterativeSmoothingToMesh_FunctionAddress, "TargetMesh");
		ApplyIterativeSmoothingToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyIterativeSmoothingToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyIterativeSmoothingToMesh_Options_PropertyAddress, ApplyIterativeSmoothingToMesh_FunctionAddress, "Options");
		ApplyIterativeSmoothingToMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyIterativeSmoothingToMesh_FunctionAddress, "Options");
		ApplyIterativeSmoothingToMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyIterativeSmoothingToMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyIterativeSmoothingToMesh_Debug_PropertyAddress, ApplyIterativeSmoothingToMesh_FunctionAddress, "Debug");
		ApplyIterativeSmoothingToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyIterativeSmoothingToMesh_FunctionAddress, "Debug");
		ApplyIterativeSmoothingToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyIterativeSmoothingToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyIterativeSmoothingToMesh_ReturnValue_PropertyAddress, ApplyIterativeSmoothingToMesh_FunctionAddress, "ReturnValue");
		ApplyIterativeSmoothingToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyIterativeSmoothingToMesh_FunctionAddress, "ReturnValue");
		ApplyIterativeSmoothingToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyIterativeSmoothingToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyIterativeSmoothingToMesh_IsValid = ApplyIterativeSmoothingToMesh_FunctionAddress != IntPtr.Zero && ApplyIterativeSmoothingToMesh_TargetMesh_IsValid && ApplyIterativeSmoothingToMesh_Options_IsValid && ApplyIterativeSmoothingToMesh_Debug_IsValid && ApplyIterativeSmoothingToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyIterativeSmoothingToMesh", ApplyIterativeSmoothingToMesh_IsValid);
		ApplyFlareWarpToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyFlareWarpToMesh");
		ApplyFlareWarpToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyFlareWarpToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_TargetMesh_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyFlareWarpToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyFlareWarpToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_Options_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "Options");
		ApplyFlareWarpToMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "Options");
		ApplyFlareWarpToMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_FlareOrientation_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "FlareOrientation");
		ApplyFlareWarpToMesh_FlareOrientation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "FlareOrientation");
		ApplyFlareWarpToMesh_FlareOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "FlareOrientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_FlarePercentX_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "FlarePercentX");
		ApplyFlareWarpToMesh_FlarePercentX_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "FlarePercentX");
		ApplyFlareWarpToMesh_FlarePercentX_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "FlarePercentX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_FlarePercentY_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "FlarePercentY");
		ApplyFlareWarpToMesh_FlarePercentY_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "FlarePercentY");
		ApplyFlareWarpToMesh_FlarePercentY_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "FlarePercentY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_FlareExtent_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "FlareExtent");
		ApplyFlareWarpToMesh_FlareExtent_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "FlareExtent");
		ApplyFlareWarpToMesh_FlareExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "FlareExtent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_Debug_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "Debug");
		ApplyFlareWarpToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "Debug");
		ApplyFlareWarpToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyFlareWarpToMesh_ReturnValue_PropertyAddress, ApplyFlareWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyFlareWarpToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyFlareWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyFlareWarpToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyFlareWarpToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyFlareWarpToMesh_IsValid = ApplyFlareWarpToMesh_FunctionAddress != IntPtr.Zero && ApplyFlareWarpToMesh_TargetMesh_IsValid && ApplyFlareWarpToMesh_Options_IsValid && ApplyFlareWarpToMesh_FlareOrientation_IsValid && ApplyFlareWarpToMesh_FlarePercentX_IsValid && ApplyFlareWarpToMesh_FlarePercentY_IsValid && ApplyFlareWarpToMesh_FlareExtent_IsValid && ApplyFlareWarpToMesh_Debug_IsValid && ApplyFlareWarpToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyFlareWarpToMesh", ApplyFlareWarpToMesh_IsValid);
		ApplyDisplaceFromTextureMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyDisplaceFromTextureMap");
		ApplyDisplaceFromTextureMap_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyDisplaceFromTextureMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyDisplaceFromTextureMap_TargetMesh_PropertyAddress, ApplyDisplaceFromTextureMap_FunctionAddress, "TargetMesh");
		ApplyDisplaceFromTextureMap_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDisplaceFromTextureMap_FunctionAddress, "TargetMesh");
		ApplyDisplaceFromTextureMap_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDisplaceFromTextureMap_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDisplaceFromTextureMap_Texture_PropertyAddress, ApplyDisplaceFromTextureMap_FunctionAddress, "Texture");
		ApplyDisplaceFromTextureMap_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDisplaceFromTextureMap_FunctionAddress, "Texture");
		ApplyDisplaceFromTextureMap_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDisplaceFromTextureMap_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDisplaceFromTextureMap_Options_PropertyAddress, ApplyDisplaceFromTextureMap_FunctionAddress, "Options");
		ApplyDisplaceFromTextureMap_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDisplaceFromTextureMap_FunctionAddress, "Options");
		ApplyDisplaceFromTextureMap_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDisplaceFromTextureMap_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDisplaceFromTextureMap_UVLayer_PropertyAddress, ApplyDisplaceFromTextureMap_FunctionAddress, "UVLayer");
		ApplyDisplaceFromTextureMap_UVLayer_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDisplaceFromTextureMap_FunctionAddress, "UVLayer");
		ApplyDisplaceFromTextureMap_UVLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDisplaceFromTextureMap_FunctionAddress, "UVLayer", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDisplaceFromTextureMap_Debug_PropertyAddress, ApplyDisplaceFromTextureMap_FunctionAddress, "Debug");
		ApplyDisplaceFromTextureMap_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDisplaceFromTextureMap_FunctionAddress, "Debug");
		ApplyDisplaceFromTextureMap_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDisplaceFromTextureMap_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDisplaceFromTextureMap_ReturnValue_PropertyAddress, ApplyDisplaceFromTextureMap_FunctionAddress, "ReturnValue");
		ApplyDisplaceFromTextureMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDisplaceFromTextureMap_FunctionAddress, "ReturnValue");
		ApplyDisplaceFromTextureMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDisplaceFromTextureMap_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyDisplaceFromTextureMap_IsValid = ApplyDisplaceFromTextureMap_FunctionAddress != IntPtr.Zero && ApplyDisplaceFromTextureMap_TargetMesh_IsValid && ApplyDisplaceFromTextureMap_Texture_IsValid && ApplyDisplaceFromTextureMap_Options_IsValid && ApplyDisplaceFromTextureMap_UVLayer_IsValid && ApplyDisplaceFromTextureMap_Debug_IsValid && ApplyDisplaceFromTextureMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyDisplaceFromTextureMap", ApplyDisplaceFromTextureMap_IsValid);
		ApplyBendWarpToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyBendWarpToMesh");
		ApplyBendWarpToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyBendWarpToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyBendWarpToMesh_TargetMesh_PropertyAddress, ApplyBendWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyBendWarpToMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(ApplyBendWarpToMesh_FunctionAddress, "TargetMesh");
		ApplyBendWarpToMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyBendWarpToMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyBendWarpToMesh_Options_PropertyAddress, ApplyBendWarpToMesh_FunctionAddress, "Options");
		ApplyBendWarpToMesh_Options_Offset = NativeReflectionCached.GetPropertyOffset(ApplyBendWarpToMesh_FunctionAddress, "Options");
		ApplyBendWarpToMesh_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyBendWarpToMesh_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyBendWarpToMesh_BendOrientation_PropertyAddress, ApplyBendWarpToMesh_FunctionAddress, "BendOrientation");
		ApplyBendWarpToMesh_BendOrientation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyBendWarpToMesh_FunctionAddress, "BendOrientation");
		ApplyBendWarpToMesh_BendOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyBendWarpToMesh_FunctionAddress, "BendOrientation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyBendWarpToMesh_BendAngle_PropertyAddress, ApplyBendWarpToMesh_FunctionAddress, "BendAngle");
		ApplyBendWarpToMesh_BendAngle_Offset = NativeReflectionCached.GetPropertyOffset(ApplyBendWarpToMesh_FunctionAddress, "BendAngle");
		ApplyBendWarpToMesh_BendAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyBendWarpToMesh_FunctionAddress, "BendAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyBendWarpToMesh_BendExtent_PropertyAddress, ApplyBendWarpToMesh_FunctionAddress, "BendExtent");
		ApplyBendWarpToMesh_BendExtent_Offset = NativeReflectionCached.GetPropertyOffset(ApplyBendWarpToMesh_FunctionAddress, "BendExtent");
		ApplyBendWarpToMesh_BendExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyBendWarpToMesh_FunctionAddress, "BendExtent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyBendWarpToMesh_Debug_PropertyAddress, ApplyBendWarpToMesh_FunctionAddress, "Debug");
		ApplyBendWarpToMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(ApplyBendWarpToMesh_FunctionAddress, "Debug");
		ApplyBendWarpToMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyBendWarpToMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyBendWarpToMesh_ReturnValue_PropertyAddress, ApplyBendWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyBendWarpToMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyBendWarpToMesh_FunctionAddress, "ReturnValue");
		ApplyBendWarpToMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyBendWarpToMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ApplyBendWarpToMesh_IsValid = ApplyBendWarpToMesh_FunctionAddress != IntPtr.Zero && ApplyBendWarpToMesh_TargetMesh_IsValid && ApplyBendWarpToMesh_Options_IsValid && ApplyBendWarpToMesh_BendOrientation_IsValid && ApplyBendWarpToMesh_BendAngle_IsValid && ApplyBendWarpToMesh_BendExtent_IsValid && ApplyBendWarpToMesh_Debug_IsValid && ApplyBendWarpToMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshDeformFunctions:ApplyBendWarpToMesh", ApplyBendWarpToMesh_IsValid);
	}
}
