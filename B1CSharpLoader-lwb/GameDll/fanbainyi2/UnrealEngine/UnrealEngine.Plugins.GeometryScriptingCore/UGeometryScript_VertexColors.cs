using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_VertexColors : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetMeshPerVertexColors_IsValid;

	private static IntPtr SetMeshPerVertexColors_FunctionAddress;

	private static int SetMeshPerVertexColors_ParamsSize;

	private static bool SetMeshPerVertexColors_TargetMesh_IsValid;

	private static FFieldAddress SetMeshPerVertexColors_TargetMesh_PropertyAddress;

	private static int SetMeshPerVertexColors_TargetMesh_Offset;

	private static bool SetMeshPerVertexColors_VertexColorList_IsValid;

	private static FFieldAddress SetMeshPerVertexColors_VertexColorList_PropertyAddress;

	private static int SetMeshPerVertexColors_VertexColorList_Offset;

	private static bool SetMeshPerVertexColors_Debug_IsValid;

	private static FFieldAddress SetMeshPerVertexColors_Debug_PropertyAddress;

	private static int SetMeshPerVertexColors_Debug_Offset;

	private static bool SetMeshPerVertexColors_ReturnValue_IsValid;

	private static FFieldAddress SetMeshPerVertexColors_ReturnValue_PropertyAddress;

	private static int SetMeshPerVertexColors_ReturnValue_Offset;

	private static bool SetMeshConstantVertexColor_IsValid;

	private static IntPtr SetMeshConstantVertexColor_FunctionAddress;

	private static int SetMeshConstantVertexColor_ParamsSize;

	private static bool SetMeshConstantVertexColor_TargetMesh_IsValid;

	private static FFieldAddress SetMeshConstantVertexColor_TargetMesh_PropertyAddress;

	private static int SetMeshConstantVertexColor_TargetMesh_Offset;

	private static bool SetMeshConstantVertexColor_Color_IsValid;

	private static FFieldAddress SetMeshConstantVertexColor_Color_PropertyAddress;

	private static int SetMeshConstantVertexColor_Color_Offset;

	private static bool SetMeshConstantVertexColor_Flags_IsValid;

	private static FFieldAddress SetMeshConstantVertexColor_Flags_PropertyAddress;

	private static int SetMeshConstantVertexColor_Flags_Offset;

	private static bool SetMeshConstantVertexColor_bClearExisting_IsValid;

	private static FFieldAddress SetMeshConstantVertexColor_bClearExisting_PropertyAddress;

	private static int SetMeshConstantVertexColor_bClearExisting_Offset;

	private static bool SetMeshConstantVertexColor_Debug_IsValid;

	private static FFieldAddress SetMeshConstantVertexColor_Debug_PropertyAddress;

	private static int SetMeshConstantVertexColor_Debug_Offset;

	private static bool SetMeshConstantVertexColor_ReturnValue_IsValid;

	private static FFieldAddress SetMeshConstantVertexColor_ReturnValue_PropertyAddress;

	private static int SetMeshConstantVertexColor_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions:SetMeshPerVertexColors")]
	public unsafe static UDynamicMesh SetMeshPerVertexColors(UDynamicMesh TargetMesh, FGeometryScriptColorList VertexColorList, UGeometryScriptDebug Debug)
	{
		if (!SetMeshPerVertexColors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions:SetMeshPerVertexColors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshPerVertexColors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshPerVertexColors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetMeshPerVertexColors_TargetMesh_Offset), 0, SetMeshPerVertexColors_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(SetMeshPerVertexColors_VertexColorList_PropertyAddress.Address, intPtr);
		FGeometryScriptColorList.ToNative(IntPtr.Add(intPtr, SetMeshPerVertexColors_VertexColorList_Offset), 0, SetMeshPerVertexColors_VertexColorList_PropertyAddress.Address, VertexColorList);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetMeshPerVertexColors_Debug_Offset), 0, SetMeshPerVertexColors_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMeshPerVertexColors_FunctionAddress, intPtr, SetMeshPerVertexColors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMeshPerVertexColors_VertexColorList_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetMeshPerVertexColors_ReturnValue_Offset), 0, SetMeshPerVertexColors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions:SetMeshConstantVertexColor")]
	public unsafe static UDynamicMesh SetMeshConstantVertexColor(UDynamicMesh TargetMesh, FLinearColor Color, FGeometryScriptColorFlags Flags, bool bClearExisting, UGeometryScriptDebug Debug)
	{
		if (!SetMeshConstantVertexColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions:SetMeshConstantVertexColor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshConstantVertexColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshConstantVertexColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, SetMeshConstantVertexColor_TargetMesh_Offset), 0, SetMeshConstantVertexColor_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetMeshConstantVertexColor_Color_Offset), 0, SetMeshConstantVertexColor_Color_PropertyAddress.Address, Color);
		NativeReflection.InitializeValue_InContainer(SetMeshConstantVertexColor_Flags_PropertyAddress.Address, intPtr);
		FGeometryScriptColorFlags.ToNative(IntPtr.Add(intPtr, SetMeshConstantVertexColor_Flags_Offset), 0, SetMeshConstantVertexColor_Flags_PropertyAddress.Address, Flags);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMeshConstantVertexColor_bClearExisting_Offset), 0, SetMeshConstantVertexColor_bClearExisting_PropertyAddress.Address, bClearExisting);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, SetMeshConstantVertexColor_Debug_Offset), 0, SetMeshConstantVertexColor_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMeshConstantVertexColor_FunctionAddress, intPtr, SetMeshConstantVertexColor_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, SetMeshConstantVertexColor_ReturnValue_Offset), 0, SetMeshConstantVertexColor_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_VertexColors()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_VertexColors)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_VertexColors));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions");
		SetMeshPerVertexColors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMeshPerVertexColors");
		SetMeshPerVertexColors_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshPerVertexColors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshPerVertexColors_TargetMesh_PropertyAddress, SetMeshPerVertexColors_FunctionAddress, "TargetMesh");
		SetMeshPerVertexColors_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshPerVertexColors_FunctionAddress, "TargetMesh");
		SetMeshPerVertexColors_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshPerVertexColors_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshPerVertexColors_VertexColorList_PropertyAddress, SetMeshPerVertexColors_FunctionAddress, "VertexColorList");
		SetMeshPerVertexColors_VertexColorList_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshPerVertexColors_FunctionAddress, "VertexColorList");
		SetMeshPerVertexColors_VertexColorList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshPerVertexColors_FunctionAddress, "VertexColorList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshPerVertexColors_Debug_PropertyAddress, SetMeshPerVertexColors_FunctionAddress, "Debug");
		SetMeshPerVertexColors_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshPerVertexColors_FunctionAddress, "Debug");
		SetMeshPerVertexColors_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshPerVertexColors_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshPerVertexColors_ReturnValue_PropertyAddress, SetMeshPerVertexColors_FunctionAddress, "ReturnValue");
		SetMeshPerVertexColors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshPerVertexColors_FunctionAddress, "ReturnValue");
		SetMeshPerVertexColors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshPerVertexColors_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMeshPerVertexColors_IsValid = SetMeshPerVertexColors_FunctionAddress != IntPtr.Zero && SetMeshPerVertexColors_TargetMesh_IsValid && SetMeshPerVertexColors_VertexColorList_IsValid && SetMeshPerVertexColors_Debug_IsValid && SetMeshPerVertexColors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions:SetMeshPerVertexColors", SetMeshPerVertexColors_IsValid);
		SetMeshConstantVertexColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMeshConstantVertexColor");
		SetMeshConstantVertexColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshConstantVertexColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshConstantVertexColor_TargetMesh_PropertyAddress, SetMeshConstantVertexColor_FunctionAddress, "TargetMesh");
		SetMeshConstantVertexColor_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshConstantVertexColor_FunctionAddress, "TargetMesh");
		SetMeshConstantVertexColor_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshConstantVertexColor_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshConstantVertexColor_Color_PropertyAddress, SetMeshConstantVertexColor_FunctionAddress, "Color");
		SetMeshConstantVertexColor_Color_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshConstantVertexColor_FunctionAddress, "Color");
		SetMeshConstantVertexColor_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshConstantVertexColor_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshConstantVertexColor_Flags_PropertyAddress, SetMeshConstantVertexColor_FunctionAddress, "Flags");
		SetMeshConstantVertexColor_Flags_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshConstantVertexColor_FunctionAddress, "Flags");
		SetMeshConstantVertexColor_Flags_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshConstantVertexColor_FunctionAddress, "Flags", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshConstantVertexColor_bClearExisting_PropertyAddress, SetMeshConstantVertexColor_FunctionAddress, "bClearExisting");
		SetMeshConstantVertexColor_bClearExisting_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshConstantVertexColor_FunctionAddress, "bClearExisting");
		SetMeshConstantVertexColor_bClearExisting_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshConstantVertexColor_FunctionAddress, "bClearExisting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshConstantVertexColor_Debug_PropertyAddress, SetMeshConstantVertexColor_FunctionAddress, "Debug");
		SetMeshConstantVertexColor_Debug_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshConstantVertexColor_FunctionAddress, "Debug");
		SetMeshConstantVertexColor_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshConstantVertexColor_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMeshConstantVertexColor_ReturnValue_PropertyAddress, SetMeshConstantVertexColor_FunctionAddress, "ReturnValue");
		SetMeshConstantVertexColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshConstantVertexColor_FunctionAddress, "ReturnValue");
		SetMeshConstantVertexColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshConstantVertexColor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SetMeshConstantVertexColor_IsValid = SetMeshConstantVertexColor_FunctionAddress != IntPtr.Zero && SetMeshConstantVertexColor_TargetMesh_IsValid && SetMeshConstantVertexColor_Color_IsValid && SetMeshConstantVertexColor_Flags_IsValid && SetMeshConstantVertexColor_bClearExisting_IsValid && SetMeshConstantVertexColor_Debug_IsValid && SetMeshConstantVertexColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshVertexColorFunctions:SetMeshConstantVertexColor", SetMeshConstantVertexColor_IsValid);
	}
}
