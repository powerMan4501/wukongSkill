using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGInstanceDataPackerBase", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGInstanceDataPackerBase : UObject
{
	private static bool PackInstances_IsValid;

	private IntPtr PackInstances_InstanceFunctionAddress;

	private static IntPtr PackInstances_FunctionAddress;

	private static int PackInstances_ParamsSize;

	private static bool PackInstances_Context_IsValid;

	private static FFieldAddress PackInstances_Context_PropertyAddress;

	private static int PackInstances_Context_Offset;

	private static bool PackInstances_InSpatialData_IsValid;

	private static FFieldAddress PackInstances_InSpatialData_PropertyAddress;

	private static int PackInstances_InSpatialData_Offset;

	private static bool PackInstances_InstanceList_IsValid;

	private static FFieldAddress PackInstances_InstanceList_PropertyAddress;

	private static int PackInstances_InstanceList_Offset;

	private static bool PackInstances_OutPackedCustomData_IsValid;

	private static FFieldAddress PackInstances_OutPackedCustomData_PropertyAddress;

	private static int PackInstances_OutPackedCustomData_Offset;

	private static bool PackCustomDataFromAttributes_IsValid;

	private static IntPtr PackCustomDataFromAttributes_FunctionAddress;

	private static int PackCustomDataFromAttributes_ParamsSize;

	private static bool PackCustomDataFromAttributes_InstanceList_IsValid;

	private static FFieldAddress PackCustomDataFromAttributes_InstanceList_PropertyAddress;

	private static int PackCustomDataFromAttributes_InstanceList_Offset;

	private static bool PackCustomDataFromAttributes_Metadata_IsValid;

	private static FFieldAddress PackCustomDataFromAttributes_Metadata_PropertyAddress;

	private static int PackCustomDataFromAttributes_Metadata_Offset;

	private static bool PackCustomDataFromAttributes_AttributeNames_IsValid;

	private static FFieldAddress PackCustomDataFromAttributes_AttributeNames_PropertyAddress;

	private static int PackCustomDataFromAttributes_AttributeNames_Offset;

	private static bool PackCustomDataFromAttributes_OutPackedCustomData_IsValid;

	private static FFieldAddress PackCustomDataFromAttributes_OutPackedCustomData_PropertyAddress;

	private static int PackCustomDataFromAttributes_OutPackedCustomData_Offset;

	private static bool AddTypeToPacking_IsValid;

	private static IntPtr AddTypeToPacking_FunctionAddress;

	private static int AddTypeToPacking_ParamsSize;

	private static bool AddTypeToPacking_TypeId_IsValid;

	private static FFieldAddress AddTypeToPacking_TypeId_PropertyAddress;

	private static int AddTypeToPacking_TypeId_Offset;

	private static bool AddTypeToPacking_OutPackedCustomData_IsValid;

	private static FFieldAddress AddTypeToPacking_OutPackedCustomData_PropertyAddress;

	private static int AddTypeToPacking_OutPackedCustomData_Offset;

	private static bool AddTypeToPacking_ReturnValue_IsValid;

	private static FFieldAddress AddTypeToPacking_ReturnValue_PropertyAddress;

	private static int AddTypeToPacking_ReturnValue_Offset;

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/PCG.PCGInstanceDataPackerBase:PackInstances")]
	public unsafe void PackInstances(out FPCGContext Context, UPCGSpatialData InSpatialData, FPCGMeshInstanceList InstanceList, out FPCGPackedCustomData OutPackedCustomData)
	{
		CheckDestroyed();
		if (!PackInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGInstanceDataPackerBase:PackInstances");
			Context = default(FPCGContext);
			OutPackedCustomData = default(FPCGPackedCustomData);
			return;
		}
		if (PackInstances_InstanceFunctionAddress == IntPtr.Zero)
		{
			PackInstances_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PackInstances");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PackInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PackInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PackInstances_Context_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, PackInstances_InSpatialData_Offset), 0, PackInstances_InSpatialData_PropertyAddress.Address, InSpatialData);
		NativeReflection.InitializeValue_InContainer(PackInstances_InstanceList_PropertyAddress.Address, intPtr);
		FPCGMeshInstanceList.ToNative(IntPtr.Add(intPtr, PackInstances_InstanceList_Offset), 0, PackInstances_InstanceList_PropertyAddress.Address, InstanceList);
		NativeReflection.InitializeValue_InContainer(PackInstances_OutPackedCustomData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, PackInstances_InstanceFunctionAddress, intPtr, PackInstances_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, PackInstances_Context_Offset), 0, PackInstances_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PackInstances_Context_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PackInstances_InstanceList_PropertyAddress.Address, intPtr);
		OutPackedCustomData = FPCGPackedCustomData.FromNative(IntPtr.Add(intPtr, PackInstances_OutPackedCustomData_Offset), 0, PackInstances_OutPackedCustomData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PackInstances_OutPackedCustomData_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void PackInstances_Implementation(out FPCGContext Context, UPCGSpatialData InSpatialData, FPCGMeshInstanceList InstanceList, out FPCGPackedCustomData OutPackedCustomData)
	{
		CheckDestroyed();
		if (!PackInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGInstanceDataPackerBase:PackInstances");
			Context = default(FPCGContext);
			OutPackedCustomData = default(FPCGPackedCustomData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PackInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PackInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PackInstances_Context_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, PackInstances_InSpatialData_Offset), 0, PackInstances_InSpatialData_PropertyAddress.Address, InSpatialData);
		NativeReflection.InitializeValue_InContainer(PackInstances_InstanceList_PropertyAddress.Address, intPtr);
		FPCGMeshInstanceList.ToNative(IntPtr.Add(intPtr, PackInstances_InstanceList_Offset), 0, PackInstances_InstanceList_PropertyAddress.Address, InstanceList);
		NativeReflection.InitializeValue_InContainer(PackInstances_OutPackedCustomData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, PackInstances_FunctionAddress, intPtr, PackInstances_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, PackInstances_Context_Offset), 0, PackInstances_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PackInstances_Context_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PackInstances_InstanceList_PropertyAddress.Address, intPtr);
		OutPackedCustomData = FPCGPackedCustomData.FromNative(IntPtr.Add(intPtr, PackInstances_OutPackedCustomData_Offset), 0, PackInstances_OutPackedCustomData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PackInstances_OutPackedCustomData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGInstanceDataPackerBase:PackCustomDataFromAttributes")]
	public unsafe void PackCustomDataFromAttributes(FPCGMeshInstanceList InstanceList, UPCGMetadata Metadata, List<FName> AttributeNames, out FPCGPackedCustomData OutPackedCustomData)
	{
		CheckDestroyed();
		if (!PackCustomDataFromAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGInstanceDataPackerBase:PackCustomDataFromAttributes");
			OutPackedCustomData = default(FPCGPackedCustomData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PackCustomDataFromAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PackCustomDataFromAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PackCustomDataFromAttributes_InstanceList_PropertyAddress.Address, intPtr);
		FPCGMeshInstanceList.ToNative(IntPtr.Add(intPtr, PackCustomDataFromAttributes_InstanceList_Offset), 0, PackCustomDataFromAttributes_InstanceList_PropertyAddress.Address, InstanceList);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, PackCustomDataFromAttributes_Metadata_Offset), 0, PackCustomDataFromAttributes_Metadata_PropertyAddress.Address, Metadata);
		new TArrayCopyMarshaler<FName>(1, PackCustomDataFromAttributes_AttributeNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, PackCustomDataFromAttributes_AttributeNames_Offset), AttributeNames);
		NativeReflection.InitializeValue_InContainer(PackCustomDataFromAttributes_OutPackedCustomData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, PackCustomDataFromAttributes_FunctionAddress, intPtr, PackCustomDataFromAttributes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PackCustomDataFromAttributes_InstanceList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PackCustomDataFromAttributes_AttributeNames_PropertyAddress.Address, intPtr);
		OutPackedCustomData = FPCGPackedCustomData.FromNative(IntPtr.Add(intPtr, PackCustomDataFromAttributes_OutPackedCustomData_Offset), 0, PackCustomDataFromAttributes_OutPackedCustomData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PackCustomDataFromAttributes_OutPackedCustomData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGInstanceDataPackerBase:AddTypeToPacking")]
	public unsafe bool AddTypeToPacking(int TypeId, out FPCGPackedCustomData OutPackedCustomData)
	{
		CheckDestroyed();
		if (!AddTypeToPacking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGInstanceDataPackerBase:AddTypeToPacking");
			OutPackedCustomData = default(FPCGPackedCustomData);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTypeToPacking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTypeToPacking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddTypeToPacking_TypeId_Offset), 0, AddTypeToPacking_TypeId_PropertyAddress.Address, TypeId);
		NativeReflection.InitializeValue_InContainer(AddTypeToPacking_OutPackedCustomData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTypeToPacking_FunctionAddress, intPtr, AddTypeToPacking_ParamsSize);
		OutPackedCustomData = FPCGPackedCustomData.FromNative(IntPtr.Add(intPtr, AddTypeToPacking_OutPackedCustomData_Offset), 0, AddTypeToPacking_OutPackedCustomData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddTypeToPacking_OutPackedCustomData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddTypeToPacking_ReturnValue_Offset), 0, AddTypeToPacking_ReturnValue_PropertyAddress.Address);
	}

	static UPCGInstanceDataPackerBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGInstanceDataPackerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGInstanceDataPackerBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGInstanceDataPackerBase");
		PackInstances_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PackInstances");
		PackInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(PackInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PackInstances_Context_PropertyAddress, PackInstances_FunctionAddress, "Context");
		PackInstances_Context_Offset = NativeReflectionCached.GetPropertyOffset(PackInstances_FunctionAddress, "Context");
		PackInstances_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(PackInstances_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PackInstances_InSpatialData_PropertyAddress, PackInstances_FunctionAddress, "InSpatialData");
		PackInstances_InSpatialData_Offset = NativeReflectionCached.GetPropertyOffset(PackInstances_FunctionAddress, "InSpatialData");
		PackInstances_InSpatialData_IsValid = NativeReflectionCached.ValidatePropertyClass(PackInstances_FunctionAddress, "InSpatialData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PackInstances_InstanceList_PropertyAddress, PackInstances_FunctionAddress, "InstanceList");
		PackInstances_InstanceList_Offset = NativeReflectionCached.GetPropertyOffset(PackInstances_FunctionAddress, "InstanceList");
		PackInstances_InstanceList_IsValid = NativeReflectionCached.ValidatePropertyClass(PackInstances_FunctionAddress, "InstanceList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PackInstances_OutPackedCustomData_PropertyAddress, PackInstances_FunctionAddress, "OutPackedCustomData");
		PackInstances_OutPackedCustomData_Offset = NativeReflectionCached.GetPropertyOffset(PackInstances_FunctionAddress, "OutPackedCustomData");
		PackInstances_OutPackedCustomData_IsValid = NativeReflectionCached.ValidatePropertyClass(PackInstances_FunctionAddress, "OutPackedCustomData", Classes.FStructProperty);
		PackInstances_IsValid = PackInstances_FunctionAddress != IntPtr.Zero && PackInstances_Context_IsValid && PackInstances_InSpatialData_IsValid && PackInstances_InstanceList_IsValid && PackInstances_OutPackedCustomData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGInstanceDataPackerBase:PackInstances", PackInstances_IsValid);
		PackCustomDataFromAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PackCustomDataFromAttributes");
		PackCustomDataFromAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(PackCustomDataFromAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PackCustomDataFromAttributes_InstanceList_PropertyAddress, PackCustomDataFromAttributes_FunctionAddress, "InstanceList");
		PackCustomDataFromAttributes_InstanceList_Offset = NativeReflectionCached.GetPropertyOffset(PackCustomDataFromAttributes_FunctionAddress, "InstanceList");
		PackCustomDataFromAttributes_InstanceList_IsValid = NativeReflectionCached.ValidatePropertyClass(PackCustomDataFromAttributes_FunctionAddress, "InstanceList", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PackCustomDataFromAttributes_Metadata_PropertyAddress, PackCustomDataFromAttributes_FunctionAddress, "Metadata");
		PackCustomDataFromAttributes_Metadata_Offset = NativeReflectionCached.GetPropertyOffset(PackCustomDataFromAttributes_FunctionAddress, "Metadata");
		PackCustomDataFromAttributes_Metadata_IsValid = NativeReflectionCached.ValidatePropertyClass(PackCustomDataFromAttributes_FunctionAddress, "Metadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PackCustomDataFromAttributes_AttributeNames_PropertyAddress, PackCustomDataFromAttributes_FunctionAddress, "AttributeNames");
		PackCustomDataFromAttributes_AttributeNames_Offset = NativeReflectionCached.GetPropertyOffset(PackCustomDataFromAttributes_FunctionAddress, "AttributeNames");
		PackCustomDataFromAttributes_AttributeNames_IsValid = NativeReflectionCached.ValidatePropertyClass(PackCustomDataFromAttributes_FunctionAddress, "AttributeNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PackCustomDataFromAttributes_OutPackedCustomData_PropertyAddress, PackCustomDataFromAttributes_FunctionAddress, "OutPackedCustomData");
		PackCustomDataFromAttributes_OutPackedCustomData_Offset = NativeReflectionCached.GetPropertyOffset(PackCustomDataFromAttributes_FunctionAddress, "OutPackedCustomData");
		PackCustomDataFromAttributes_OutPackedCustomData_IsValid = NativeReflectionCached.ValidatePropertyClass(PackCustomDataFromAttributes_FunctionAddress, "OutPackedCustomData", Classes.FStructProperty);
		PackCustomDataFromAttributes_IsValid = PackCustomDataFromAttributes_FunctionAddress != IntPtr.Zero && PackCustomDataFromAttributes_InstanceList_IsValid && PackCustomDataFromAttributes_Metadata_IsValid && PackCustomDataFromAttributes_AttributeNames_IsValid && PackCustomDataFromAttributes_OutPackedCustomData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGInstanceDataPackerBase:PackCustomDataFromAttributes", PackCustomDataFromAttributes_IsValid);
		AddTypeToPacking_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddTypeToPacking");
		AddTypeToPacking_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTypeToPacking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTypeToPacking_TypeId_PropertyAddress, AddTypeToPacking_FunctionAddress, "TypeId");
		AddTypeToPacking_TypeId_Offset = NativeReflectionCached.GetPropertyOffset(AddTypeToPacking_FunctionAddress, "TypeId");
		AddTypeToPacking_TypeId_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTypeToPacking_FunctionAddress, "TypeId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTypeToPacking_OutPackedCustomData_PropertyAddress, AddTypeToPacking_FunctionAddress, "OutPackedCustomData");
		AddTypeToPacking_OutPackedCustomData_Offset = NativeReflectionCached.GetPropertyOffset(AddTypeToPacking_FunctionAddress, "OutPackedCustomData");
		AddTypeToPacking_OutPackedCustomData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTypeToPacking_FunctionAddress, "OutPackedCustomData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTypeToPacking_ReturnValue_PropertyAddress, AddTypeToPacking_FunctionAddress, "ReturnValue");
		AddTypeToPacking_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddTypeToPacking_FunctionAddress, "ReturnValue");
		AddTypeToPacking_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTypeToPacking_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddTypeToPacking_IsValid = AddTypeToPacking_FunctionAddress != IntPtr.Zero && AddTypeToPacking_TypeId_IsValid && AddTypeToPacking_OutPackedCustomData_IsValid && AddTypeToPacking_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGInstanceDataPackerBase:AddTypeToPacking", AddTypeToPacking_IsValid);
	}
}
