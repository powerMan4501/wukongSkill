using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ActorLayerUtilities;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/ActorLayerUtilities.LayersBlueprintLibrary", "ActorLayerUtilities", UnrealModuleType.EnginePlugin)]
public class ULayersBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RemoveActorFromLayer_IsValid;

	private static IntPtr RemoveActorFromLayer_FunctionAddress;

	private static int RemoveActorFromLayer_ParamsSize;

	private static bool RemoveActorFromLayer_InActor_IsValid;

	private static FFieldAddress RemoveActorFromLayer_InActor_PropertyAddress;

	private static int RemoveActorFromLayer_InActor_Offset;

	private static bool RemoveActorFromLayer_Layer_IsValid;

	private static FFieldAddress RemoveActorFromLayer_Layer_PropertyAddress;

	private static int RemoveActorFromLayer_Layer_Offset;

	private static bool GetActors_IsValid;

	private static IntPtr GetActors_FunctionAddress;

	private static int GetActors_ParamsSize;

	private static bool GetActors_WorldContextObject_IsValid;

	private static FFieldAddress GetActors_WorldContextObject_PropertyAddress;

	private static int GetActors_WorldContextObject_Offset;

	private static bool GetActors_ActorLayer_IsValid;

	private static FFieldAddress GetActors_ActorLayer_PropertyAddress;

	private static int GetActors_ActorLayer_Offset;

	private static bool GetActors_ReturnValue_IsValid;

	private static FFieldAddress GetActors_ReturnValue_PropertyAddress;

	private static int GetActors_ReturnValue_Offset;

	private static bool AddActorToLayer_IsValid;

	private static IntPtr AddActorToLayer_FunctionAddress;

	private static int AddActorToLayer_ParamsSize;

	private static bool AddActorToLayer_InActor_IsValid;

	private static FFieldAddress AddActorToLayer_InActor_PropertyAddress;

	private static int AddActorToLayer_InActor_Offset;

	private static bool AddActorToLayer_Layer_IsValid;

	private static FFieldAddress AddActorToLayer_Layer_PropertyAddress;

	private static int AddActorToLayer_Layer_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ActorLayerUtilities.LayersBlueprintLibrary:RemoveActorFromLayer")]
	public unsafe static void RemoveActorFromLayer(AActor InActor, FActorLayer Layer)
	{
		if (!RemoveActorFromLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ActorLayerUtilities.LayersBlueprintLibrary:RemoveActorFromLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveActorFromLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveActorFromLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveActorFromLayer_InActor_Offset), 0, RemoveActorFromLayer_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InitializeValue_InContainer(RemoveActorFromLayer_Layer_PropertyAddress.Address, intPtr);
		FActorLayer.ToNative(IntPtr.Add(intPtr, RemoveActorFromLayer_Layer_Offset), 0, RemoveActorFromLayer_Layer_PropertyAddress.Address, Layer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveActorFromLayer_FunctionAddress, intPtr, RemoveActorFromLayer_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ActorLayerUtilities.LayersBlueprintLibrary:GetActors")]
	public unsafe static List<AActor> GetActors(UObject WorldContextObject, FActorLayer ActorLayer)
	{
		if (!GetActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ActorLayerUtilities.LayersBlueprintLibrary:GetActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetActors_WorldContextObject_Offset), 0, GetActors_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(GetActors_ActorLayer_PropertyAddress.Address, intPtr);
		FActorLayer.ToNative(IntPtr.Add(intPtr, GetActors_ActorLayer_Offset), 0, GetActors_ActorLayer_PropertyAddress.Address, ActorLayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActors_FunctionAddress, intPtr, GetActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ActorLayerUtilities.LayersBlueprintLibrary:AddActorToLayer")]
	public unsafe static void AddActorToLayer(AActor InActor, FActorLayer Layer)
	{
		if (!AddActorToLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ActorLayerUtilities.LayersBlueprintLibrary:AddActorToLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorToLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorToLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddActorToLayer_InActor_Offset), 0, AddActorToLayer_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InitializeValue_InContainer(AddActorToLayer_Layer_PropertyAddress.Address, intPtr);
		FActorLayer.ToNative(IntPtr.Add(intPtr, AddActorToLayer_Layer_Offset), 0, AddActorToLayer_Layer_PropertyAddress.Address, Layer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddActorToLayer_FunctionAddress, intPtr, AddActorToLayer_ParamsSize);
	}

	static ULayersBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULayersBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULayersBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ActorLayerUtilities.LayersBlueprintLibrary");
		RemoveActorFromLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveActorFromLayer");
		RemoveActorFromLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveActorFromLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveActorFromLayer_InActor_PropertyAddress, RemoveActorFromLayer_FunctionAddress, "InActor");
		RemoveActorFromLayer_InActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveActorFromLayer_FunctionAddress, "InActor");
		RemoveActorFromLayer_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveActorFromLayer_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveActorFromLayer_Layer_PropertyAddress, RemoveActorFromLayer_FunctionAddress, "Layer");
		RemoveActorFromLayer_Layer_Offset = NativeReflectionCached.GetPropertyOffset(RemoveActorFromLayer_FunctionAddress, "Layer");
		RemoveActorFromLayer_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveActorFromLayer_FunctionAddress, "Layer", Classes.FStructProperty);
		RemoveActorFromLayer_IsValid = RemoveActorFromLayer_FunctionAddress != IntPtr.Zero && RemoveActorFromLayer_InActor_IsValid && RemoveActorFromLayer_Layer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ActorLayerUtilities.LayersBlueprintLibrary:RemoveActorFromLayer", RemoveActorFromLayer_IsValid);
		GetActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActors");
		GetActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActors_WorldContextObject_PropertyAddress, GetActors_FunctionAddress, "WorldContextObject");
		GetActors_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetActors_FunctionAddress, "WorldContextObject");
		GetActors_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActors_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActors_ActorLayer_PropertyAddress, GetActors_FunctionAddress, "ActorLayer");
		GetActors_ActorLayer_Offset = NativeReflectionCached.GetPropertyOffset(GetActors_FunctionAddress, "ActorLayer");
		GetActors_ActorLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActors_FunctionAddress, "ActorLayer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActors_ReturnValue_PropertyAddress, GetActors_FunctionAddress, "ReturnValue");
		GetActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActors_FunctionAddress, "ReturnValue");
		GetActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetActors_IsValid = GetActors_FunctionAddress != IntPtr.Zero && GetActors_WorldContextObject_IsValid && GetActors_ActorLayer_IsValid && GetActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ActorLayerUtilities.LayersBlueprintLibrary:GetActors", GetActors_IsValid);
		AddActorToLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddActorToLayer");
		AddActorToLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorToLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorToLayer_InActor_PropertyAddress, AddActorToLayer_FunctionAddress, "InActor");
		AddActorToLayer_InActor_Offset = NativeReflectionCached.GetPropertyOffset(AddActorToLayer_FunctionAddress, "InActor");
		AddActorToLayer_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorToLayer_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorToLayer_Layer_PropertyAddress, AddActorToLayer_FunctionAddress, "Layer");
		AddActorToLayer_Layer_Offset = NativeReflectionCached.GetPropertyOffset(AddActorToLayer_FunctionAddress, "Layer");
		AddActorToLayer_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorToLayer_FunctionAddress, "Layer", Classes.FStructProperty);
		AddActorToLayer_IsValid = AddActorToLayer_FunctionAddress != IntPtr.Zero && AddActorToLayer_InActor_IsValid && AddActorToLayer_Layer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ActorLayerUtilities.LayersBlueprintLibrary:AddActorToLayer", AddActorToLayer_IsValid);
	}
}
