using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshRepair : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WeldMeshEdges_IsValid;

	private static IntPtr WeldMeshEdges_FunctionAddress;

	private static int WeldMeshEdges_ParamsSize;

	private static bool WeldMeshEdges_TargetMesh_IsValid;

	private static FFieldAddress WeldMeshEdges_TargetMesh_PropertyAddress;

	private static int WeldMeshEdges_TargetMesh_Offset;

	private static bool WeldMeshEdges_WeldOptions_IsValid;

	private static FFieldAddress WeldMeshEdges_WeldOptions_PropertyAddress;

	private static int WeldMeshEdges_WeldOptions_Offset;

	private static bool WeldMeshEdges_Debug_IsValid;

	private static FFieldAddress WeldMeshEdges_Debug_PropertyAddress;

	private static int WeldMeshEdges_Debug_Offset;

	private static bool WeldMeshEdges_ReturnValue_IsValid;

	private static FFieldAddress WeldMeshEdges_ReturnValue_PropertyAddress;

	private static int WeldMeshEdges_ReturnValue_Offset;

	private static bool RemoveSmallComponents_IsValid;

	private static IntPtr RemoveSmallComponents_FunctionAddress;

	private static int RemoveSmallComponents_ParamsSize;

	private static bool RemoveSmallComponents_TargetMesh_IsValid;

	private static FFieldAddress RemoveSmallComponents_TargetMesh_PropertyAddress;

	private static int RemoveSmallComponents_TargetMesh_Offset;

	private static bool RemoveSmallComponents_Options_IsValid;

	private static FFieldAddress RemoveSmallComponents_Options_PropertyAddress;

	private static int RemoveSmallComponents_Options_Offset;

	private static bool RemoveSmallComponents_Debug_IsValid;

	private static FFieldAddress RemoveSmallComponents_Debug_PropertyAddress;

	private static int RemoveSmallComponents_Debug_Offset;

	private static bool RemoveSmallComponents_ReturnValue_IsValid;

	private static FFieldAddress RemoveSmallComponents_ReturnValue_PropertyAddress;

	private static int RemoveSmallComponents_ReturnValue_Offset;

	private static bool RemoveHiddenTriangles_IsValid;

	private static IntPtr RemoveHiddenTriangles_FunctionAddress;

	private static int RemoveHiddenTriangles_ParamsSize;

	private static bool RemoveHiddenTriangles_TargetMesh_IsValid;

	private static FFieldAddress RemoveHiddenTriangles_TargetMesh_PropertyAddress;

	private static int RemoveHiddenTriangles_TargetMesh_Offset;

	private static bool RemoveHiddenTriangles_Options_IsValid;

	private static FFieldAddress RemoveHiddenTriangles_Options_PropertyAddress;

	private static int RemoveHiddenTriangles_Options_Offset;

	private static bool RemoveHiddenTriangles_Debug_IsValid;

	private static FFieldAddress RemoveHiddenTriangles_Debug_PropertyAddress;

	private static int RemoveHiddenTriangles_Debug_Offset;

	private static bool RemoveHiddenTriangles_ReturnValue_IsValid;

	private static FFieldAddress RemoveHiddenTriangles_ReturnValue_PropertyAddress;

	private static int RemoveHiddenTriangles_ReturnValue_Offset;

	private static bool FillAllMeshHoles_IsValid;

	private static IntPtr FillAllMeshHoles_FunctionAddress;

	private static int FillAllMeshHoles_ParamsSize;

	private static bool FillAllMeshHoles_TargetMesh_IsValid;

	private static FFieldAddress FillAllMeshHoles_TargetMesh_PropertyAddress;

	private static int FillAllMeshHoles_TargetMesh_Offset;

	private static bool FillAllMeshHoles_FillOptions_IsValid;

	private static FFieldAddress FillAllMeshHoles_FillOptions_PropertyAddress;

	private static int FillAllMeshHoles_FillOptions_Offset;

	private static bool FillAllMeshHoles_NumFilledHoles_IsValid;

	private static FFieldAddress FillAllMeshHoles_NumFilledHoles_PropertyAddress;

	private static int FillAllMeshHoles_NumFilledHoles_Offset;

	private static bool FillAllMeshHoles_NumFailedHoleFills_IsValid;

	private static FFieldAddress FillAllMeshHoles_NumFailedHoleFills_PropertyAddress;

	private static int FillAllMeshHoles_NumFailedHoleFills_Offset;

	private static bool FillAllMeshHoles_Debug_IsValid;

	private static FFieldAddress FillAllMeshHoles_Debug_PropertyAddress;

	private static int FillAllMeshHoles_Debug_Offset;

	private static bool FillAllMeshHoles_ReturnValue_IsValid;

	private static FFieldAddress FillAllMeshHoles_ReturnValue_PropertyAddress;

	private static int FillAllMeshHoles_ReturnValue_Offset;

	private static bool CompactMesh_IsValid;

	private static IntPtr CompactMesh_FunctionAddress;

	private static int CompactMesh_ParamsSize;

	private static bool CompactMesh_TargetMesh_IsValid;

	private static FFieldAddress CompactMesh_TargetMesh_PropertyAddress;

	private static int CompactMesh_TargetMesh_Offset;

	private static bool CompactMesh_Debug_IsValid;

	private static FFieldAddress CompactMesh_Debug_PropertyAddress;

	private static int CompactMesh_Debug_Offset;

	private static bool CompactMesh_ReturnValue_IsValid;

	private static FFieldAddress CompactMesh_ReturnValue_PropertyAddress;

	private static int CompactMesh_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:WeldMeshEdges")]
	public unsafe static UDynamicMesh WeldMeshEdges(UDynamicMesh TargetMesh, FGeometryScriptWeldEdgesOptions WeldOptions, UGeometryScriptDebug Debug)
	{
		if (!WeldMeshEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:WeldMeshEdges");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WeldMeshEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WeldMeshEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, WeldMeshEdges_TargetMesh_Offset), 0, WeldMeshEdges_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(WeldMeshEdges_WeldOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptWeldEdgesOptions.ToNative(IntPtr.Add(intPtr, WeldMeshEdges_WeldOptions_Offset), 0, WeldMeshEdges_WeldOptions_PropertyAddress.Address, WeldOptions);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, WeldMeshEdges_Debug_Offset), 0, WeldMeshEdges_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WeldMeshEdges_FunctionAddress, intPtr, WeldMeshEdges_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, WeldMeshEdges_ReturnValue_Offset), 0, WeldMeshEdges_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:RemoveSmallComponents")]
	public unsafe static UDynamicMesh RemoveSmallComponents(UDynamicMesh TargetMesh, FGeometryScriptRemoveSmallComponentOptions Options, UGeometryScriptDebug Debug)
	{
		if (!RemoveSmallComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:RemoveSmallComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSmallComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSmallComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RemoveSmallComponents_TargetMesh_Offset), 0, RemoveSmallComponents_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(RemoveSmallComponents_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptRemoveSmallComponentOptions.ToNative(IntPtr.Add(intPtr, RemoveSmallComponents_Options_Offset), 0, RemoveSmallComponents_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RemoveSmallComponents_Debug_Offset), 0, RemoveSmallComponents_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveSmallComponents_FunctionAddress, intPtr, RemoveSmallComponents_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RemoveSmallComponents_ReturnValue_Offset), 0, RemoveSmallComponents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:RemoveHiddenTriangles")]
	public unsafe static UDynamicMesh RemoveHiddenTriangles(UDynamicMesh TargetMesh, FGeometryScriptRemoveHiddenTrianglesOptions Options, UGeometryScriptDebug Debug)
	{
		if (!RemoveHiddenTriangles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:RemoveHiddenTriangles");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveHiddenTriangles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveHiddenTriangles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, RemoveHiddenTriangles_TargetMesh_Offset), 0, RemoveHiddenTriangles_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(RemoveHiddenTriangles_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptRemoveHiddenTrianglesOptions.ToNative(IntPtr.Add(intPtr, RemoveHiddenTriangles_Options_Offset), 0, RemoveHiddenTriangles_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, RemoveHiddenTriangles_Debug_Offset), 0, RemoveHiddenTriangles_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveHiddenTriangles_FunctionAddress, intPtr, RemoveHiddenTriangles_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, RemoveHiddenTriangles_ReturnValue_Offset), 0, RemoveHiddenTriangles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:FillAllMeshHoles")]
	public unsafe static UDynamicMesh FillAllMeshHoles(UDynamicMesh TargetMesh, FGeometryScriptFillHolesOptions FillOptions, out int NumFilledHoles, out int NumFailedHoleFills, UGeometryScriptDebug Debug)
	{
		if (!FillAllMeshHoles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:FillAllMeshHoles");
			NumFilledHoles = 0;
			NumFailedHoleFills = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FillAllMeshHoles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FillAllMeshHoles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, FillAllMeshHoles_TargetMesh_Offset), 0, FillAllMeshHoles_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(FillAllMeshHoles_FillOptions_PropertyAddress.Address, intPtr);
		FGeometryScriptFillHolesOptions.ToNative(IntPtr.Add(intPtr, FillAllMeshHoles_FillOptions_Offset), 0, FillAllMeshHoles_FillOptions_PropertyAddress.Address, FillOptions);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, FillAllMeshHoles_Debug_Offset), 0, FillAllMeshHoles_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FillAllMeshHoles_FunctionAddress, intPtr, FillAllMeshHoles_ParamsSize);
		NumFilledHoles = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FillAllMeshHoles_NumFilledHoles_Offset), 0, FillAllMeshHoles_NumFilledHoles_PropertyAddress.Address);
		NumFailedHoleFills = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FillAllMeshHoles_NumFailedHoleFills_Offset), 0, FillAllMeshHoles_NumFailedHoleFills_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, FillAllMeshHoles_ReturnValue_Offset), 0, FillAllMeshHoles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:CompactMesh")]
	public unsafe static UDynamicMesh CompactMesh(UDynamicMesh TargetMesh, UGeometryScriptDebug Debug)
	{
		if (!CompactMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:CompactMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompactMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompactMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, CompactMesh_TargetMesh_Offset), 0, CompactMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, CompactMesh_Debug_Offset), 0, CompactMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompactMesh_FunctionAddress, intPtr, CompactMesh_ParamsSize);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, CompactMesh_ReturnValue_Offset), 0, CompactMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshRepair()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshRepair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshRepair));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions");
		WeldMeshEdges_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WeldMeshEdges");
		WeldMeshEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(WeldMeshEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WeldMeshEdges_TargetMesh_PropertyAddress, WeldMeshEdges_FunctionAddress, "TargetMesh");
		WeldMeshEdges_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(WeldMeshEdges_FunctionAddress, "TargetMesh");
		WeldMeshEdges_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(WeldMeshEdges_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WeldMeshEdges_WeldOptions_PropertyAddress, WeldMeshEdges_FunctionAddress, "WeldOptions");
		WeldMeshEdges_WeldOptions_Offset = NativeReflectionCached.GetPropertyOffset(WeldMeshEdges_FunctionAddress, "WeldOptions");
		WeldMeshEdges_WeldOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(WeldMeshEdges_FunctionAddress, "WeldOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WeldMeshEdges_Debug_PropertyAddress, WeldMeshEdges_FunctionAddress, "Debug");
		WeldMeshEdges_Debug_Offset = NativeReflectionCached.GetPropertyOffset(WeldMeshEdges_FunctionAddress, "Debug");
		WeldMeshEdges_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(WeldMeshEdges_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WeldMeshEdges_ReturnValue_PropertyAddress, WeldMeshEdges_FunctionAddress, "ReturnValue");
		WeldMeshEdges_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WeldMeshEdges_FunctionAddress, "ReturnValue");
		WeldMeshEdges_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WeldMeshEdges_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		WeldMeshEdges_IsValid = WeldMeshEdges_FunctionAddress != IntPtr.Zero && WeldMeshEdges_TargetMesh_IsValid && WeldMeshEdges_WeldOptions_IsValid && WeldMeshEdges_Debug_IsValid && WeldMeshEdges_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:WeldMeshEdges", WeldMeshEdges_IsValid);
		RemoveSmallComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSmallComponents");
		RemoveSmallComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSmallComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSmallComponents_TargetMesh_PropertyAddress, RemoveSmallComponents_FunctionAddress, "TargetMesh");
		RemoveSmallComponents_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSmallComponents_FunctionAddress, "TargetMesh");
		RemoveSmallComponents_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSmallComponents_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSmallComponents_Options_PropertyAddress, RemoveSmallComponents_FunctionAddress, "Options");
		RemoveSmallComponents_Options_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSmallComponents_FunctionAddress, "Options");
		RemoveSmallComponents_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSmallComponents_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSmallComponents_Debug_PropertyAddress, RemoveSmallComponents_FunctionAddress, "Debug");
		RemoveSmallComponents_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSmallComponents_FunctionAddress, "Debug");
		RemoveSmallComponents_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSmallComponents_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSmallComponents_ReturnValue_PropertyAddress, RemoveSmallComponents_FunctionAddress, "ReturnValue");
		RemoveSmallComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSmallComponents_FunctionAddress, "ReturnValue");
		RemoveSmallComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSmallComponents_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RemoveSmallComponents_IsValid = RemoveSmallComponents_FunctionAddress != IntPtr.Zero && RemoveSmallComponents_TargetMesh_IsValid && RemoveSmallComponents_Options_IsValid && RemoveSmallComponents_Debug_IsValid && RemoveSmallComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:RemoveSmallComponents", RemoveSmallComponents_IsValid);
		RemoveHiddenTriangles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveHiddenTriangles");
		RemoveHiddenTriangles_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveHiddenTriangles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveHiddenTriangles_TargetMesh_PropertyAddress, RemoveHiddenTriangles_FunctionAddress, "TargetMesh");
		RemoveHiddenTriangles_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveHiddenTriangles_FunctionAddress, "TargetMesh");
		RemoveHiddenTriangles_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveHiddenTriangles_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveHiddenTriangles_Options_PropertyAddress, RemoveHiddenTriangles_FunctionAddress, "Options");
		RemoveHiddenTriangles_Options_Offset = NativeReflectionCached.GetPropertyOffset(RemoveHiddenTriangles_FunctionAddress, "Options");
		RemoveHiddenTriangles_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveHiddenTriangles_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveHiddenTriangles_Debug_PropertyAddress, RemoveHiddenTriangles_FunctionAddress, "Debug");
		RemoveHiddenTriangles_Debug_Offset = NativeReflectionCached.GetPropertyOffset(RemoveHiddenTriangles_FunctionAddress, "Debug");
		RemoveHiddenTriangles_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveHiddenTriangles_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveHiddenTriangles_ReturnValue_PropertyAddress, RemoveHiddenTriangles_FunctionAddress, "ReturnValue");
		RemoveHiddenTriangles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveHiddenTriangles_FunctionAddress, "ReturnValue");
		RemoveHiddenTriangles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveHiddenTriangles_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RemoveHiddenTriangles_IsValid = RemoveHiddenTriangles_FunctionAddress != IntPtr.Zero && RemoveHiddenTriangles_TargetMesh_IsValid && RemoveHiddenTriangles_Options_IsValid && RemoveHiddenTriangles_Debug_IsValid && RemoveHiddenTriangles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:RemoveHiddenTriangles", RemoveHiddenTriangles_IsValid);
		FillAllMeshHoles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FillAllMeshHoles");
		FillAllMeshHoles_ParamsSize = NativeReflection.GetFunctionParamsSize(FillAllMeshHoles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FillAllMeshHoles_TargetMesh_PropertyAddress, FillAllMeshHoles_FunctionAddress, "TargetMesh");
		FillAllMeshHoles_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(FillAllMeshHoles_FunctionAddress, "TargetMesh");
		FillAllMeshHoles_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(FillAllMeshHoles_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FillAllMeshHoles_FillOptions_PropertyAddress, FillAllMeshHoles_FunctionAddress, "FillOptions");
		FillAllMeshHoles_FillOptions_Offset = NativeReflectionCached.GetPropertyOffset(FillAllMeshHoles_FunctionAddress, "FillOptions");
		FillAllMeshHoles_FillOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(FillAllMeshHoles_FunctionAddress, "FillOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FillAllMeshHoles_NumFilledHoles_PropertyAddress, FillAllMeshHoles_FunctionAddress, "NumFilledHoles");
		FillAllMeshHoles_NumFilledHoles_Offset = NativeReflectionCached.GetPropertyOffset(FillAllMeshHoles_FunctionAddress, "NumFilledHoles");
		FillAllMeshHoles_NumFilledHoles_IsValid = NativeReflectionCached.ValidatePropertyClass(FillAllMeshHoles_FunctionAddress, "NumFilledHoles", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FillAllMeshHoles_NumFailedHoleFills_PropertyAddress, FillAllMeshHoles_FunctionAddress, "NumFailedHoleFills");
		FillAllMeshHoles_NumFailedHoleFills_Offset = NativeReflectionCached.GetPropertyOffset(FillAllMeshHoles_FunctionAddress, "NumFailedHoleFills");
		FillAllMeshHoles_NumFailedHoleFills_IsValid = NativeReflectionCached.ValidatePropertyClass(FillAllMeshHoles_FunctionAddress, "NumFailedHoleFills", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FillAllMeshHoles_Debug_PropertyAddress, FillAllMeshHoles_FunctionAddress, "Debug");
		FillAllMeshHoles_Debug_Offset = NativeReflectionCached.GetPropertyOffset(FillAllMeshHoles_FunctionAddress, "Debug");
		FillAllMeshHoles_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(FillAllMeshHoles_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FillAllMeshHoles_ReturnValue_PropertyAddress, FillAllMeshHoles_FunctionAddress, "ReturnValue");
		FillAllMeshHoles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FillAllMeshHoles_FunctionAddress, "ReturnValue");
		FillAllMeshHoles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FillAllMeshHoles_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FillAllMeshHoles_IsValid = FillAllMeshHoles_FunctionAddress != IntPtr.Zero && FillAllMeshHoles_TargetMesh_IsValid && FillAllMeshHoles_FillOptions_IsValid && FillAllMeshHoles_NumFilledHoles_IsValid && FillAllMeshHoles_NumFailedHoleFills_IsValid && FillAllMeshHoles_Debug_IsValid && FillAllMeshHoles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:FillAllMeshHoles", FillAllMeshHoles_IsValid);
		CompactMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompactMesh");
		CompactMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(CompactMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompactMesh_TargetMesh_PropertyAddress, CompactMesh_FunctionAddress, "TargetMesh");
		CompactMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(CompactMesh_FunctionAddress, "TargetMesh");
		CompactMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompactMesh_Debug_PropertyAddress, CompactMesh_FunctionAddress, "Debug");
		CompactMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(CompactMesh_FunctionAddress, "Debug");
		CompactMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompactMesh_ReturnValue_PropertyAddress, CompactMesh_FunctionAddress, "ReturnValue");
		CompactMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CompactMesh_FunctionAddress, "ReturnValue");
		CompactMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CompactMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CompactMesh_IsValid = CompactMesh_FunctionAddress != IntPtr.Zero && CompactMesh_TargetMesh_IsValid && CompactMesh_Debug_IsValid && CompactMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshRepairFunctions:CompactMesh", CompactMesh_IsValid);
	}
}
