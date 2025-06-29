using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UClass(Flags = (ClassFlags)818414244uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Foliage.InstancedFoliageActor", "Foliage", UnrealModuleType.Engine)]
public class AInstancedFoliageActor : AISMPartitionActor
{
	private static IntPtr classAddress;

	private static bool RemoveAllInstances_IsValid;

	private static IntPtr RemoveAllInstances_FunctionAddress;

	private static int RemoveAllInstances_ParamsSize;

	private static bool RemoveAllInstances_WorldContextObject_IsValid;

	private static FFieldAddress RemoveAllInstances_WorldContextObject_PropertyAddress;

	private static int RemoveAllInstances_WorldContextObject_Offset;

	private static bool RemoveAllInstances_InFoliageType_IsValid;

	private static FFieldAddress RemoveAllInstances_InFoliageType_PropertyAddress;

	private static int RemoveAllInstances_InFoliageType_Offset;

	private static bool AddInstances_IsValid;

	private static IntPtr AddInstances_FunctionAddress;

	private static int AddInstances_ParamsSize;

	private static bool AddInstances_WorldContextObject_IsValid;

	private static FFieldAddress AddInstances_WorldContextObject_PropertyAddress;

	private static int AddInstances_WorldContextObject_Offset;

	private static bool AddInstances_InFoliageType_IsValid;

	private static FFieldAddress AddInstances_InFoliageType_PropertyAddress;

	private static int AddInstances_InFoliageType_Offset;

	private static bool AddInstances_InTransforms_IsValid;

	private static FFieldAddress AddInstances_InTransforms_PropertyAddress;

	private static int AddInstances_InTransforms_Offset;

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Foliage.InstancedFoliageActor:RemoveAllInstances")]
	public unsafe static void RemoveAllInstances(UObject WorldContextObject, UFoliageType InFoliageType)
	{
		if (!RemoveAllInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Foliage.InstancedFoliageActor:RemoveAllInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveAllInstances_WorldContextObject_Offset), 0, RemoveAllInstances_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, RemoveAllInstances_InFoliageType_Offset), 0, RemoveAllInstances_InFoliageType_PropertyAddress.Address, InFoliageType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllInstances_FunctionAddress, intPtr, RemoveAllInstances_ParamsSize);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/Foliage.InstancedFoliageActor:AddInstances")]
	public unsafe static void AddInstances(UObject WorldContextObject, UFoliageType InFoliageType, List<FTransform> InTransforms)
	{
		if (!AddInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Foliage.InstancedFoliageActor:AddInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddInstances_WorldContextObject_Offset), 0, AddInstances_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, AddInstances_InFoliageType_Offset), 0, AddInstances_InFoliageType_PropertyAddress.Address, InFoliageType);
		new TArrayCopyMarshaler<FTransform>(1, AddInstances_InTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, AddInstances_InTransforms_Offset), InTransforms);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddInstances_FunctionAddress, intPtr, AddInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddInstances_InTransforms_PropertyAddress.Address, intPtr);
	}

	static AInstancedFoliageActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AInstancedFoliageActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AInstancedFoliageActor));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Foliage.InstancedFoliageActor");
		RemoveAllInstances_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllInstances");
		RemoveAllInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllInstances_WorldContextObject_PropertyAddress, RemoveAllInstances_FunctionAddress, "WorldContextObject");
		RemoveAllInstances_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllInstances_FunctionAddress, "WorldContextObject");
		RemoveAllInstances_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllInstances_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllInstances_InFoliageType_PropertyAddress, RemoveAllInstances_FunctionAddress, "InFoliageType");
		RemoveAllInstances_InFoliageType_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllInstances_FunctionAddress, "InFoliageType");
		RemoveAllInstances_InFoliageType_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllInstances_FunctionAddress, "InFoliageType", Classes.FObjectProperty);
		RemoveAllInstances_IsValid = RemoveAllInstances_FunctionAddress != IntPtr.Zero && RemoveAllInstances_WorldContextObject_IsValid && RemoveAllInstances_InFoliageType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Foliage.InstancedFoliageActor:RemoveAllInstances", RemoveAllInstances_IsValid);
		AddInstances_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddInstances");
		AddInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInstances_WorldContextObject_PropertyAddress, AddInstances_FunctionAddress, "WorldContextObject");
		AddInstances_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddInstances_FunctionAddress, "WorldContextObject");
		AddInstances_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstances_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstances_InFoliageType_PropertyAddress, AddInstances_FunctionAddress, "InFoliageType");
		AddInstances_InFoliageType_Offset = NativeReflectionCached.GetPropertyOffset(AddInstances_FunctionAddress, "InFoliageType");
		AddInstances_InFoliageType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstances_FunctionAddress, "InFoliageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInstances_InTransforms_PropertyAddress, AddInstances_FunctionAddress, "InTransforms");
		AddInstances_InTransforms_Offset = NativeReflectionCached.GetPropertyOffset(AddInstances_FunctionAddress, "InTransforms");
		AddInstances_InTransforms_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInstances_FunctionAddress, "InTransforms", Classes.FArrayProperty);
		AddInstances_IsValid = AddInstances_FunctionAddress != IntPtr.Zero && AddInstances_WorldContextObject_IsValid && AddInstances_InFoliageType_IsValid && AddInstances_InTransforms_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Foliage.InstancedFoliageActor:AddInstances", AddInstances_IsValid);
	}
}
