using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GeometryFramework;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public class UGeometryScript_MeshComparison : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MeasureDistancesBetweenMeshes_IsValid;

	private static IntPtr MeasureDistancesBetweenMeshes_FunctionAddress;

	private static int MeasureDistancesBetweenMeshes_ParamsSize;

	private static bool MeasureDistancesBetweenMeshes_TargetMesh_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_TargetMesh_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_TargetMesh_Offset;

	private static bool MeasureDistancesBetweenMeshes_OtherMesh_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_OtherMesh_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_OtherMesh_Offset;

	private static bool MeasureDistancesBetweenMeshes_Options_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_Options_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_Options_Offset;

	private static bool MeasureDistancesBetweenMeshes_MaxDistance_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_MaxDistance_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_MaxDistance_Offset;

	private static bool MeasureDistancesBetweenMeshes_MinDistance_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_MinDistance_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_MinDistance_Offset;

	private static bool MeasureDistancesBetweenMeshes_AverageDistance_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_AverageDistance_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_AverageDistance_Offset;

	private static bool MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_Offset;

	private static bool MeasureDistancesBetweenMeshes_Debug_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_Debug_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_Debug_Offset;

	private static bool MeasureDistancesBetweenMeshes_ReturnValue_IsValid;

	private static FFieldAddress MeasureDistancesBetweenMeshes_ReturnValue_PropertyAddress;

	private static int MeasureDistancesBetweenMeshes_ReturnValue_Offset;

	private static bool IsSameMeshAs_IsValid;

	private static IntPtr IsSameMeshAs_FunctionAddress;

	private static int IsSameMeshAs_ParamsSize;

	private static bool IsSameMeshAs_TargetMesh_IsValid;

	private static FFieldAddress IsSameMeshAs_TargetMesh_PropertyAddress;

	private static int IsSameMeshAs_TargetMesh_Offset;

	private static bool IsSameMeshAs_OtherMesh_IsValid;

	private static FFieldAddress IsSameMeshAs_OtherMesh_PropertyAddress;

	private static int IsSameMeshAs_OtherMesh_Offset;

	private static bool IsSameMeshAs_Options_IsValid;

	private static FFieldAddress IsSameMeshAs_Options_PropertyAddress;

	private static int IsSameMeshAs_Options_Offset;

	private static bool IsSameMeshAs_bIsSameMesh_IsValid;

	private static FFieldAddress IsSameMeshAs_bIsSameMesh_PropertyAddress;

	private static int IsSameMeshAs_bIsSameMesh_Offset;

	private static bool IsSameMeshAs_Debug_IsValid;

	private static FFieldAddress IsSameMeshAs_Debug_PropertyAddress;

	private static int IsSameMeshAs_Debug_Offset;

	private static bool IsSameMeshAs_ReturnValue_IsValid;

	private static FFieldAddress IsSameMeshAs_ReturnValue_PropertyAddress;

	private static int IsSameMeshAs_ReturnValue_Offset;

	private static bool IsIntersectingMesh_IsValid;

	private static IntPtr IsIntersectingMesh_FunctionAddress;

	private static int IsIntersectingMesh_ParamsSize;

	private static bool IsIntersectingMesh_TargetMesh_IsValid;

	private static FFieldAddress IsIntersectingMesh_TargetMesh_PropertyAddress;

	private static int IsIntersectingMesh_TargetMesh_Offset;

	private static bool IsIntersectingMesh_TargetTransform_IsValid;

	private static FFieldAddress IsIntersectingMesh_TargetTransform_PropertyAddress;

	private static int IsIntersectingMesh_TargetTransform_Offset;

	private static bool IsIntersectingMesh_OtherMesh_IsValid;

	private static FFieldAddress IsIntersectingMesh_OtherMesh_PropertyAddress;

	private static int IsIntersectingMesh_OtherMesh_Offset;

	private static bool IsIntersectingMesh_OtherTransform_IsValid;

	private static FFieldAddress IsIntersectingMesh_OtherTransform_PropertyAddress;

	private static int IsIntersectingMesh_OtherTransform_Offset;

	private static bool IsIntersectingMesh_bIsIntersecting_IsValid;

	private static FFieldAddress IsIntersectingMesh_bIsIntersecting_PropertyAddress;

	private static int IsIntersectingMesh_bIsIntersecting_Offset;

	private static bool IsIntersectingMesh_Debug_IsValid;

	private static FFieldAddress IsIntersectingMesh_Debug_PropertyAddress;

	private static int IsIntersectingMesh_Debug_Offset;

	private static bool IsIntersectingMesh_ReturnValue_IsValid;

	private static FFieldAddress IsIntersectingMesh_ReturnValue_PropertyAddress;

	private static int IsIntersectingMesh_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:MeasureDistancesBetweenMeshes")]
	public unsafe static UDynamicMesh MeasureDistancesBetweenMeshes(UDynamicMesh TargetMesh, UDynamicMesh OtherMesh, FGeometryScriptMeasureMeshDistanceOptions Options, out double MaxDistance, out double MinDistance, out double AverageDistance, out double RootMeanSqrDeviation, UGeometryScriptDebug Debug)
	{
		if (!MeasureDistancesBetweenMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:MeasureDistancesBetweenMeshes");
			MaxDistance = 0.0;
			MinDistance = 0.0;
			AverageDistance = 0.0;
			RootMeanSqrDeviation = 0.0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MeasureDistancesBetweenMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MeasureDistancesBetweenMeshes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_TargetMesh_Offset), 0, MeasureDistancesBetweenMeshes_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_OtherMesh_Offset), 0, MeasureDistancesBetweenMeshes_OtherMesh_PropertyAddress.Address, OtherMesh);
		NativeReflection.InitializeValue_InContainer(MeasureDistancesBetweenMeshes_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptMeasureMeshDistanceOptions.ToNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_Options_Offset), 0, MeasureDistancesBetweenMeshes_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_Debug_Offset), 0, MeasureDistancesBetweenMeshes_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MeasureDistancesBetweenMeshes_FunctionAddress, intPtr, MeasureDistancesBetweenMeshes_ParamsSize);
		MaxDistance = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_MaxDistance_Offset), 0, MeasureDistancesBetweenMeshes_MaxDistance_PropertyAddress.Address);
		MinDistance = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_MinDistance_Offset), 0, MeasureDistancesBetweenMeshes_MinDistance_PropertyAddress.Address);
		AverageDistance = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_AverageDistance_Offset), 0, MeasureDistancesBetweenMeshes_AverageDistance_PropertyAddress.Address);
		RootMeanSqrDeviation = BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_Offset), 0, MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, MeasureDistancesBetweenMeshes_ReturnValue_Offset), 0, MeasureDistancesBetweenMeshes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:IsSameMeshAs")]
	public unsafe static UDynamicMesh IsSameMeshAs(UDynamicMesh TargetMesh, UDynamicMesh OtherMesh, FGeometryScriptIsSameMeshOptions Options, out bool bIsSameMesh, UGeometryScriptDebug Debug)
	{
		if (!IsSameMeshAs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:IsSameMeshAs");
			bIsSameMesh = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSameMeshAs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSameMeshAs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsSameMeshAs_TargetMesh_Offset), 0, IsSameMeshAs_TargetMesh_PropertyAddress.Address, TargetMesh);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsSameMeshAs_OtherMesh_Offset), 0, IsSameMeshAs_OtherMesh_PropertyAddress.Address, OtherMesh);
		NativeReflection.InitializeValue_InContainer(IsSameMeshAs_Options_PropertyAddress.Address, intPtr);
		FGeometryScriptIsSameMeshOptions.ToNative(IntPtr.Add(intPtr, IsSameMeshAs_Options_Offset), 0, IsSameMeshAs_Options_PropertyAddress.Address, Options);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, IsSameMeshAs_Debug_Offset), 0, IsSameMeshAs_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSameMeshAs_FunctionAddress, intPtr, IsSameMeshAs_ParamsSize);
		bIsSameMesh = BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSameMeshAs_bIsSameMesh_Offset), 0, IsSameMeshAs_bIsSameMesh_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, IsSameMeshAs_ReturnValue_Offset), 0, IsSameMeshAs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:IsIntersectingMesh")]
	public unsafe static UDynamicMesh IsIntersectingMesh(UDynamicMesh TargetMesh, FTransform TargetTransform, UDynamicMesh OtherMesh, FTransform OtherTransform, out bool bIsIntersecting, UGeometryScriptDebug Debug)
	{
		if (!IsIntersectingMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:IsIntersectingMesh");
			bIsIntersecting = false;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsIntersectingMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsIntersectingMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsIntersectingMesh_TargetMesh_Offset), 0, IsIntersectingMesh_TargetMesh_PropertyAddress.Address, TargetMesh);
		NativeReflection.InitializeValue_InContainer(IsIntersectingMesh_TargetTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, IsIntersectingMesh_TargetTransform_Offset), 0, IsIntersectingMesh_TargetTransform_PropertyAddress.Address, TargetTransform);
		UObjectMarshaler<UDynamicMesh>.ToNative(IntPtr.Add(intPtr, IsIntersectingMesh_OtherMesh_Offset), 0, IsIntersectingMesh_OtherMesh_PropertyAddress.Address, OtherMesh);
		NativeReflection.InitializeValue_InContainer(IsIntersectingMesh_OtherTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, IsIntersectingMesh_OtherTransform_Offset), 0, IsIntersectingMesh_OtherTransform_PropertyAddress.Address, OtherTransform);
		UObjectMarshaler<UGeometryScriptDebug>.ToNative(IntPtr.Add(intPtr, IsIntersectingMesh_Debug_Offset), 0, IsIntersectingMesh_Debug_PropertyAddress.Address, Debug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsIntersectingMesh_FunctionAddress, intPtr, IsIntersectingMesh_ParamsSize);
		bIsIntersecting = BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsIntersectingMesh_bIsIntersecting_Offset), 0, IsIntersectingMesh_bIsIntersecting_PropertyAddress.Address);
		return UObjectMarshaler<UDynamicMesh>.FromNative(IntPtr.Add(intPtr, IsIntersectingMesh_ReturnValue_Offset), 0, IsIntersectingMesh_ReturnValue_PropertyAddress.Address);
	}

	static UGeometryScript_MeshComparison()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryScript_MeshComparison)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryScript_MeshComparison));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions");
		MeasureDistancesBetweenMeshes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MeasureDistancesBetweenMeshes");
		MeasureDistancesBetweenMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(MeasureDistancesBetweenMeshes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_TargetMesh_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "TargetMesh");
		MeasureDistancesBetweenMeshes_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "TargetMesh");
		MeasureDistancesBetweenMeshes_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_OtherMesh_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "OtherMesh");
		MeasureDistancesBetweenMeshes_OtherMesh_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "OtherMesh");
		MeasureDistancesBetweenMeshes_OtherMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "OtherMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_Options_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "Options");
		MeasureDistancesBetweenMeshes_Options_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "Options");
		MeasureDistancesBetweenMeshes_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_MaxDistance_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "MaxDistance");
		MeasureDistancesBetweenMeshes_MaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "MaxDistance");
		MeasureDistancesBetweenMeshes_MaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "MaxDistance", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_MinDistance_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "MinDistance");
		MeasureDistancesBetweenMeshes_MinDistance_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "MinDistance");
		MeasureDistancesBetweenMeshes_MinDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "MinDistance", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_AverageDistance_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "AverageDistance");
		MeasureDistancesBetweenMeshes_AverageDistance_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "AverageDistance");
		MeasureDistancesBetweenMeshes_AverageDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "AverageDistance", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "RootMeanSqrDeviation");
		MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "RootMeanSqrDeviation");
		MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "RootMeanSqrDeviation", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_Debug_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "Debug");
		MeasureDistancesBetweenMeshes_Debug_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "Debug");
		MeasureDistancesBetweenMeshes_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MeasureDistancesBetweenMeshes_ReturnValue_PropertyAddress, MeasureDistancesBetweenMeshes_FunctionAddress, "ReturnValue");
		MeasureDistancesBetweenMeshes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MeasureDistancesBetweenMeshes_FunctionAddress, "ReturnValue");
		MeasureDistancesBetweenMeshes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MeasureDistancesBetweenMeshes_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MeasureDistancesBetweenMeshes_IsValid = MeasureDistancesBetweenMeshes_FunctionAddress != IntPtr.Zero && MeasureDistancesBetweenMeshes_TargetMesh_IsValid && MeasureDistancesBetweenMeshes_OtherMesh_IsValid && MeasureDistancesBetweenMeshes_Options_IsValid && MeasureDistancesBetweenMeshes_MaxDistance_IsValid && MeasureDistancesBetweenMeshes_MinDistance_IsValid && MeasureDistancesBetweenMeshes_AverageDistance_IsValid && MeasureDistancesBetweenMeshes_RootMeanSqrDeviation_IsValid && MeasureDistancesBetweenMeshes_Debug_IsValid && MeasureDistancesBetweenMeshes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:MeasureDistancesBetweenMeshes", MeasureDistancesBetweenMeshes_IsValid);
		IsSameMeshAs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSameMeshAs");
		IsSameMeshAs_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSameMeshAs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSameMeshAs_TargetMesh_PropertyAddress, IsSameMeshAs_FunctionAddress, "TargetMesh");
		IsSameMeshAs_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsSameMeshAs_FunctionAddress, "TargetMesh");
		IsSameMeshAs_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSameMeshAs_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSameMeshAs_OtherMesh_PropertyAddress, IsSameMeshAs_FunctionAddress, "OtherMesh");
		IsSameMeshAs_OtherMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsSameMeshAs_FunctionAddress, "OtherMesh");
		IsSameMeshAs_OtherMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSameMeshAs_FunctionAddress, "OtherMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSameMeshAs_Options_PropertyAddress, IsSameMeshAs_FunctionAddress, "Options");
		IsSameMeshAs_Options_Offset = NativeReflectionCached.GetPropertyOffset(IsSameMeshAs_FunctionAddress, "Options");
		IsSameMeshAs_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSameMeshAs_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSameMeshAs_bIsSameMesh_PropertyAddress, IsSameMeshAs_FunctionAddress, "bIsSameMesh");
		IsSameMeshAs_bIsSameMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsSameMeshAs_FunctionAddress, "bIsSameMesh");
		IsSameMeshAs_bIsSameMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSameMeshAs_FunctionAddress, "bIsSameMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSameMeshAs_Debug_PropertyAddress, IsSameMeshAs_FunctionAddress, "Debug");
		IsSameMeshAs_Debug_Offset = NativeReflectionCached.GetPropertyOffset(IsSameMeshAs_FunctionAddress, "Debug");
		IsSameMeshAs_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSameMeshAs_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSameMeshAs_ReturnValue_PropertyAddress, IsSameMeshAs_FunctionAddress, "ReturnValue");
		IsSameMeshAs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSameMeshAs_FunctionAddress, "ReturnValue");
		IsSameMeshAs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSameMeshAs_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		IsSameMeshAs_IsValid = IsSameMeshAs_FunctionAddress != IntPtr.Zero && IsSameMeshAs_TargetMesh_IsValid && IsSameMeshAs_OtherMesh_IsValid && IsSameMeshAs_Options_IsValid && IsSameMeshAs_bIsSameMesh_IsValid && IsSameMeshAs_Debug_IsValid && IsSameMeshAs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:IsSameMeshAs", IsSameMeshAs_IsValid);
		IsIntersectingMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsIntersectingMesh");
		IsIntersectingMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(IsIntersectingMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsIntersectingMesh_TargetMesh_PropertyAddress, IsIntersectingMesh_FunctionAddress, "TargetMesh");
		IsIntersectingMesh_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsIntersectingMesh_FunctionAddress, "TargetMesh");
		IsIntersectingMesh_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIntersectingMesh_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIntersectingMesh_TargetTransform_PropertyAddress, IsIntersectingMesh_FunctionAddress, "TargetTransform");
		IsIntersectingMesh_TargetTransform_Offset = NativeReflectionCached.GetPropertyOffset(IsIntersectingMesh_FunctionAddress, "TargetTransform");
		IsIntersectingMesh_TargetTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIntersectingMesh_FunctionAddress, "TargetTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIntersectingMesh_OtherMesh_PropertyAddress, IsIntersectingMesh_FunctionAddress, "OtherMesh");
		IsIntersectingMesh_OtherMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsIntersectingMesh_FunctionAddress, "OtherMesh");
		IsIntersectingMesh_OtherMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIntersectingMesh_FunctionAddress, "OtherMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIntersectingMesh_OtherTransform_PropertyAddress, IsIntersectingMesh_FunctionAddress, "OtherTransform");
		IsIntersectingMesh_OtherTransform_Offset = NativeReflectionCached.GetPropertyOffset(IsIntersectingMesh_FunctionAddress, "OtherTransform");
		IsIntersectingMesh_OtherTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIntersectingMesh_FunctionAddress, "OtherTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIntersectingMesh_bIsIntersecting_PropertyAddress, IsIntersectingMesh_FunctionAddress, "bIsIntersecting");
		IsIntersectingMesh_bIsIntersecting_Offset = NativeReflectionCached.GetPropertyOffset(IsIntersectingMesh_FunctionAddress, "bIsIntersecting");
		IsIntersectingMesh_bIsIntersecting_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIntersectingMesh_FunctionAddress, "bIsIntersecting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIntersectingMesh_Debug_PropertyAddress, IsIntersectingMesh_FunctionAddress, "Debug");
		IsIntersectingMesh_Debug_Offset = NativeReflectionCached.GetPropertyOffset(IsIntersectingMesh_FunctionAddress, "Debug");
		IsIntersectingMesh_Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIntersectingMesh_FunctionAddress, "Debug", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIntersectingMesh_ReturnValue_PropertyAddress, IsIntersectingMesh_FunctionAddress, "ReturnValue");
		IsIntersectingMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsIntersectingMesh_FunctionAddress, "ReturnValue");
		IsIntersectingMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIntersectingMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		IsIntersectingMesh_IsValid = IsIntersectingMesh_FunctionAddress != IntPtr.Zero && IsIntersectingMesh_TargetMesh_IsValid && IsIntersectingMesh_TargetTransform_IsValid && IsIntersectingMesh_OtherMesh_IsValid && IsIntersectingMesh_OtherTransform_IsValid && IsIntersectingMesh_bIsIntersecting_IsValid && IsIntersectingMesh_Debug_IsValid && IsIntersectingMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryScriptingCore.GeometryScriptLibrary_MeshComparisonFunctions:IsIntersectingMesh", IsIntersectingMesh_IsValid);
	}
}
