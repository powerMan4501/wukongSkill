using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Foliage.FoliageStatistics", "Foliage", UnrealModuleType.Engine)]
public class UFoliageStatistics : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool FoliageOverlappingSphereCount_IsValid;

	private static IntPtr FoliageOverlappingSphereCount_FunctionAddress;

	private static int FoliageOverlappingSphereCount_ParamsSize;

	private static bool FoliageOverlappingSphereCount_WorldContextObject_IsValid;

	private static FFieldAddress FoliageOverlappingSphereCount_WorldContextObject_PropertyAddress;

	private static int FoliageOverlappingSphereCount_WorldContextObject_Offset;

	private static bool FoliageOverlappingSphereCount_StaticMesh_IsValid;

	private static FFieldAddress FoliageOverlappingSphereCount_StaticMesh_PropertyAddress;

	private static int FoliageOverlappingSphereCount_StaticMesh_Offset;

	private static bool FoliageOverlappingSphereCount_CenterPosition_IsValid;

	private static FFieldAddress FoliageOverlappingSphereCount_CenterPosition_PropertyAddress;

	private static int FoliageOverlappingSphereCount_CenterPosition_Offset;

	private static bool FoliageOverlappingSphereCount_Radius_IsValid;

	private static FFieldAddress FoliageOverlappingSphereCount_Radius_PropertyAddress;

	private static int FoliageOverlappingSphereCount_Radius_Offset;

	private static bool FoliageOverlappingSphereCount_ReturnValue_IsValid;

	private static FFieldAddress FoliageOverlappingSphereCount_ReturnValue_PropertyAddress;

	private static int FoliageOverlappingSphereCount_ReturnValue_Offset;

	private static bool FoliageOverlappingBoxTransforms_IsValid;

	private static IntPtr FoliageOverlappingBoxTransforms_FunctionAddress;

	private static int FoliageOverlappingBoxTransforms_ParamsSize;

	private static bool FoliageOverlappingBoxTransforms_WorldContextObject_IsValid;

	private static FFieldAddress FoliageOverlappingBoxTransforms_WorldContextObject_PropertyAddress;

	private static int FoliageOverlappingBoxTransforms_WorldContextObject_Offset;

	private static bool FoliageOverlappingBoxTransforms_StaticMesh_IsValid;

	private static FFieldAddress FoliageOverlappingBoxTransforms_StaticMesh_PropertyAddress;

	private static int FoliageOverlappingBoxTransforms_StaticMesh_Offset;

	private static bool FoliageOverlappingBoxTransforms_Box_IsValid;

	private static FFieldAddress FoliageOverlappingBoxTransforms_Box_PropertyAddress;

	private static int FoliageOverlappingBoxTransforms_Box_Offset;

	private static bool FoliageOverlappingBoxTransforms_OutTransforms_IsValid;

	private static FFieldAddress FoliageOverlappingBoxTransforms_OutTransforms_PropertyAddress;

	private static int FoliageOverlappingBoxTransforms_OutTransforms_Offset;

	private static bool FoliageOverlappingBoxCount_IsValid;

	private static IntPtr FoliageOverlappingBoxCount_FunctionAddress;

	private static int FoliageOverlappingBoxCount_ParamsSize;

	private static bool FoliageOverlappingBoxCount_WorldContextObject_IsValid;

	private static FFieldAddress FoliageOverlappingBoxCount_WorldContextObject_PropertyAddress;

	private static int FoliageOverlappingBoxCount_WorldContextObject_Offset;

	private static bool FoliageOverlappingBoxCount_StaticMesh_IsValid;

	private static FFieldAddress FoliageOverlappingBoxCount_StaticMesh_PropertyAddress;

	private static int FoliageOverlappingBoxCount_StaticMesh_Offset;

	private static bool FoliageOverlappingBoxCount_Box_IsValid;

	private static FFieldAddress FoliageOverlappingBoxCount_Box_PropertyAddress;

	private static int FoliageOverlappingBoxCount_Box_Offset;

	private static bool FoliageOverlappingBoxCount_ReturnValue_IsValid;

	private static FFieldAddress FoliageOverlappingBoxCount_ReturnValue_PropertyAddress;

	private static int FoliageOverlappingBoxCount_ReturnValue_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Foliage.FoliageStatistics:FoliageOverlappingSphereCount")]
	public unsafe static int FoliageOverlappingSphereCount(UObject WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
	{
		if (!FoliageOverlappingSphereCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Foliage.FoliageStatistics:FoliageOverlappingSphereCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FoliageOverlappingSphereCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FoliageOverlappingSphereCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingSphereCount_WorldContextObject_Offset), 0, FoliageOverlappingSphereCount_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingSphereCount_StaticMesh_Offset), 0, FoliageOverlappingSphereCount_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingSphereCount_CenterPosition_Offset), 0, FoliageOverlappingSphereCount_CenterPosition_PropertyAddress.Address, CenterPosition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingSphereCount_Radius_Offset), 0, FoliageOverlappingSphereCount_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FoliageOverlappingSphereCount_FunctionAddress, intPtr, FoliageOverlappingSphereCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FoliageOverlappingSphereCount_ReturnValue_Offset), 0, FoliageOverlappingSphereCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Foliage.FoliageStatistics:FoliageOverlappingBoxTransforms")]
	public unsafe static void FoliageOverlappingBoxTransforms(UObject WorldContextObject, UStaticMesh StaticMesh, FBox Box, out List<FTransform> OutTransforms)
	{
		if (!FoliageOverlappingBoxTransforms_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Foliage.FoliageStatistics:FoliageOverlappingBoxTransforms");
			OutTransforms = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FoliageOverlappingBoxTransforms_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FoliageOverlappingBoxTransforms_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingBoxTransforms_WorldContextObject_Offset), 0, FoliageOverlappingBoxTransforms_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingBoxTransforms_StaticMesh_Offset), 0, FoliageOverlappingBoxTransforms_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingBoxTransforms_Box_Offset), 0, FoliageOverlappingBoxTransforms_Box_PropertyAddress.Address, Box);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FoliageOverlappingBoxTransforms_FunctionAddress, intPtr, FoliageOverlappingBoxTransforms_ParamsSize);
		OutTransforms = new TArrayCopyMarshaler<FTransform>(1, FoliageOverlappingBoxTransforms_OutTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(intPtr, FoliageOverlappingBoxTransforms_OutTransforms_Offset));
		NativeReflection.DestroyValue_InContainer(FoliageOverlappingBoxTransforms_OutTransforms_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Foliage.FoliageStatistics:FoliageOverlappingBoxCount")]
	public unsafe static int FoliageOverlappingBoxCount(UObject WorldContextObject, UStaticMesh StaticMesh, FBox Box)
	{
		if (!FoliageOverlappingBoxCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Foliage.FoliageStatistics:FoliageOverlappingBoxCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FoliageOverlappingBoxCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FoliageOverlappingBoxCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingBoxCount_WorldContextObject_Offset), 0, FoliageOverlappingBoxCount_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingBoxCount_StaticMesh_Offset), 0, FoliageOverlappingBoxCount_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, FoliageOverlappingBoxCount_Box_Offset), 0, FoliageOverlappingBoxCount_Box_PropertyAddress.Address, Box);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FoliageOverlappingBoxCount_FunctionAddress, intPtr, FoliageOverlappingBoxCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FoliageOverlappingBoxCount_ReturnValue_Offset), 0, FoliageOverlappingBoxCount_ReturnValue_PropertyAddress.Address);
	}

	static UFoliageStatistics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFoliageStatistics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFoliageStatistics));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Foliage.FoliageStatistics");
		FoliageOverlappingSphereCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FoliageOverlappingSphereCount");
		FoliageOverlappingSphereCount_ParamsSize = NativeReflection.GetFunctionParamsSize(FoliageOverlappingSphereCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingSphereCount_WorldContextObject_PropertyAddress, FoliageOverlappingSphereCount_FunctionAddress, "WorldContextObject");
		FoliageOverlappingSphereCount_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingSphereCount_FunctionAddress, "WorldContextObject");
		FoliageOverlappingSphereCount_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingSphereCount_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingSphereCount_StaticMesh_PropertyAddress, FoliageOverlappingSphereCount_FunctionAddress, "StaticMesh");
		FoliageOverlappingSphereCount_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingSphereCount_FunctionAddress, "StaticMesh");
		FoliageOverlappingSphereCount_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingSphereCount_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingSphereCount_CenterPosition_PropertyAddress, FoliageOverlappingSphereCount_FunctionAddress, "CenterPosition");
		FoliageOverlappingSphereCount_CenterPosition_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingSphereCount_FunctionAddress, "CenterPosition");
		FoliageOverlappingSphereCount_CenterPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingSphereCount_FunctionAddress, "CenterPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingSphereCount_Radius_PropertyAddress, FoliageOverlappingSphereCount_FunctionAddress, "Radius");
		FoliageOverlappingSphereCount_Radius_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingSphereCount_FunctionAddress, "Radius");
		FoliageOverlappingSphereCount_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingSphereCount_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingSphereCount_ReturnValue_PropertyAddress, FoliageOverlappingSphereCount_FunctionAddress, "ReturnValue");
		FoliageOverlappingSphereCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingSphereCount_FunctionAddress, "ReturnValue");
		FoliageOverlappingSphereCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingSphereCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FoliageOverlappingSphereCount_IsValid = FoliageOverlappingSphereCount_FunctionAddress != IntPtr.Zero && FoliageOverlappingSphereCount_WorldContextObject_IsValid && FoliageOverlappingSphereCount_StaticMesh_IsValid && FoliageOverlappingSphereCount_CenterPosition_IsValid && FoliageOverlappingSphereCount_Radius_IsValid && FoliageOverlappingSphereCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Foliage.FoliageStatistics:FoliageOverlappingSphereCount", FoliageOverlappingSphereCount_IsValid);
		FoliageOverlappingBoxTransforms_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FoliageOverlappingBoxTransforms");
		FoliageOverlappingBoxTransforms_ParamsSize = NativeReflection.GetFunctionParamsSize(FoliageOverlappingBoxTransforms_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxTransforms_WorldContextObject_PropertyAddress, FoliageOverlappingBoxTransforms_FunctionAddress, "WorldContextObject");
		FoliageOverlappingBoxTransforms_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxTransforms_FunctionAddress, "WorldContextObject");
		FoliageOverlappingBoxTransforms_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxTransforms_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxTransforms_StaticMesh_PropertyAddress, FoliageOverlappingBoxTransforms_FunctionAddress, "StaticMesh");
		FoliageOverlappingBoxTransforms_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxTransforms_FunctionAddress, "StaticMesh");
		FoliageOverlappingBoxTransforms_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxTransforms_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxTransforms_Box_PropertyAddress, FoliageOverlappingBoxTransforms_FunctionAddress, "Box");
		FoliageOverlappingBoxTransforms_Box_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxTransforms_FunctionAddress, "Box");
		FoliageOverlappingBoxTransforms_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxTransforms_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxTransforms_OutTransforms_PropertyAddress, FoliageOverlappingBoxTransforms_FunctionAddress, "OutTransforms");
		FoliageOverlappingBoxTransforms_OutTransforms_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxTransforms_FunctionAddress, "OutTransforms");
		FoliageOverlappingBoxTransforms_OutTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxTransforms_FunctionAddress, "OutTransforms", Classes.FArrayProperty);
		FoliageOverlappingBoxTransforms_IsValid = FoliageOverlappingBoxTransforms_FunctionAddress != IntPtr.Zero && FoliageOverlappingBoxTransforms_WorldContextObject_IsValid && FoliageOverlappingBoxTransforms_StaticMesh_IsValid && FoliageOverlappingBoxTransforms_Box_IsValid && FoliageOverlappingBoxTransforms_OutTransforms_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Foliage.FoliageStatistics:FoliageOverlappingBoxTransforms", FoliageOverlappingBoxTransforms_IsValid);
		FoliageOverlappingBoxCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FoliageOverlappingBoxCount");
		FoliageOverlappingBoxCount_ParamsSize = NativeReflection.GetFunctionParamsSize(FoliageOverlappingBoxCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxCount_WorldContextObject_PropertyAddress, FoliageOverlappingBoxCount_FunctionAddress, "WorldContextObject");
		FoliageOverlappingBoxCount_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxCount_FunctionAddress, "WorldContextObject");
		FoliageOverlappingBoxCount_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxCount_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxCount_StaticMesh_PropertyAddress, FoliageOverlappingBoxCount_FunctionAddress, "StaticMesh");
		FoliageOverlappingBoxCount_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxCount_FunctionAddress, "StaticMesh");
		FoliageOverlappingBoxCount_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxCount_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxCount_Box_PropertyAddress, FoliageOverlappingBoxCount_FunctionAddress, "Box");
		FoliageOverlappingBoxCount_Box_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxCount_FunctionAddress, "Box");
		FoliageOverlappingBoxCount_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxCount_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FoliageOverlappingBoxCount_ReturnValue_PropertyAddress, FoliageOverlappingBoxCount_FunctionAddress, "ReturnValue");
		FoliageOverlappingBoxCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FoliageOverlappingBoxCount_FunctionAddress, "ReturnValue");
		FoliageOverlappingBoxCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FoliageOverlappingBoxCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FoliageOverlappingBoxCount_IsValid = FoliageOverlappingBoxCount_FunctionAddress != IntPtr.Zero && FoliageOverlappingBoxCount_WorldContextObject_IsValid && FoliageOverlappingBoxCount_StaticMesh_IsValid && FoliageOverlappingBoxCount_Box_IsValid && FoliageOverlappingBoxCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Foliage.FoliageStatistics:FoliageOverlappingBoxCount", FoliageOverlappingBoxCount_IsValid);
	}
}
