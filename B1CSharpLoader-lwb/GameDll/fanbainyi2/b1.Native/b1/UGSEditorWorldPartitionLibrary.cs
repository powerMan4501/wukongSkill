using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorWorldPartitionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetAllActorLoadGrid_IsValid;

	private static IntPtr SetAllActorLoadGrid_FunctionAddress;

	private static int SetAllActorLoadGrid_ParamsSize;

	private static bool SetAllActorLoadGrid_world_IsValid;

	private static FFieldAddress SetAllActorLoadGrid_world_PropertyAddress;

	private static int SetAllActorLoadGrid_world_Offset;

	private static bool SetAllActorLoadGrid_ActorLoadPolitics_IsValid;

	private static FFieldAddress SetAllActorLoadGrid_ActorLoadPolitics_PropertyAddress;

	private static int SetAllActorLoadGrid_ActorLoadPolitics_Offset;

	private static bool SetAllActorLoadGrid_IgnoreActorClasses_IsValid;

	private static FFieldAddress SetAllActorLoadGrid_IgnoreActorClasses_PropertyAddress;

	private static int SetAllActorLoadGrid_IgnoreActorClasses_Offset;

	private static bool GenerateWorldMiniMap_IsValid;

	private static IntPtr GenerateWorldMiniMap_FunctionAddress;

	private static int GenerateWorldMiniMap_ParamsSize;

	private static bool GenerateWorldMiniMap_world_IsValid;

	private static FFieldAddress GenerateWorldMiniMap_world_PropertyAddress;

	private static int GenerateWorldMiniMap_world_Offset;

	private static bool FixSpecialActorLoadGridPolitics_IsValid;

	private static IntPtr FixSpecialActorLoadGridPolitics_FunctionAddress;

	private static int FixSpecialActorLoadGridPolitics_ParamsSize;

	private static bool FixSpecialActorLoadGridPolitics_world_IsValid;

	private static FFieldAddress FixSpecialActorLoadGridPolitics_world_PropertyAddress;

	private static int FixSpecialActorLoadGridPolitics_world_Offset;

	private static bool FindUncategoryGridActor_IsValid;

	private static IntPtr FindUncategoryGridActor_FunctionAddress;

	private static int FindUncategoryGridActor_ParamsSize;

	private static bool FindUncategoryGridActor_world_IsValid;

	private static FFieldAddress FindUncategoryGridActor_world_PropertyAddress;

	private static int FindUncategoryGridActor_world_Offset;

	private static bool CreateLayerBySubLevel_IsValid;

	private static IntPtr CreateLayerBySubLevel_FunctionAddress;

	private static int CreateLayerBySubLevel_ParamsSize;

	private static bool CreateLayerBySubLevel_world_IsValid;

	private static FFieldAddress CreateLayerBySubLevel_world_PropertyAddress;

	private static int CreateLayerBySubLevel_world_Offset;

	private static bool CleanBadActorDesc_IsValid;

	private static IntPtr CleanBadActorDesc_FunctionAddress;

	private static int CleanBadActorDesc_ParamsSize;

	private static bool CleanBadActorDesc_world_IsValid;

	private static FFieldAddress CleanBadActorDesc_world_PropertyAddress;

	private static int CleanBadActorDesc_world_Offset;

	private static bool CleanBadActorDesc_ReturnValue_IsValid;

	private static FFieldAddress CleanBadActorDesc_ReturnValue_PropertyAddress;

	private static int CleanBadActorDesc_ReturnValue_Offset;

	private static bool AddStaticMeshActorToHLODLayer_IsValid;

	private static IntPtr AddStaticMeshActorToHLODLayer_FunctionAddress;

	private static int AddStaticMeshActorToHLODLayer_ParamsSize;

	private static bool AddStaticMeshActorToHLODLayer_WorldContextObject_IsValid;

	private static FFieldAddress AddStaticMeshActorToHLODLayer_WorldContextObject_PropertyAddress;

	private static int AddStaticMeshActorToHLODLayer_WorldContextObject_Offset;

	private static bool AddStaticMeshActorToHLODLayer_TargeHLODLayer_IsValid;

	private static FFieldAddress AddStaticMeshActorToHLODLayer_TargeHLODLayer_PropertyAddress;

	private static int AddStaticMeshActorToHLODLayer_TargeHLODLayer_Offset;

	private static bool AddStaticMeshActorToHLODLayer_MatchedKeywords_IsValid;

	private static FFieldAddress AddStaticMeshActorToHLODLayer_MatchedKeywords_PropertyAddress;

	private static int AddStaticMeshActorToHLODLayer_MatchedKeywords_Offset;

	private static bool AddStaticMeshActorToHLODLayer_ForfeitKeywords_IsValid;

	private static FFieldAddress AddStaticMeshActorToHLODLayer_ForfeitKeywords_PropertyAddress;

	private static int AddStaticMeshActorToHLODLayer_ForfeitKeywords_Offset;

	private static bool AddStaticMeshActorToHLODLayer_MinExtentSize_IsValid;

	private static FFieldAddress AddStaticMeshActorToHLODLayer_MinExtentSize_PropertyAddress;

	private static int AddStaticMeshActorToHLODLayer_MinExtentSize_Offset;

	private static bool AddStaticMeshActorToHLODLayer_InBatchingPolicy_IsValid;

	private static FFieldAddress AddStaticMeshActorToHLODLayer_InBatchingPolicy_PropertyAddress;

	private static int AddStaticMeshActorToHLODLayer_InBatchingPolicy_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:SetAllActorLoadGrid")]
	public unsafe static void SetAllActorLoadGrid(UWorld world, Dictionary<string, FVector> ActorLoadPolitics, List<TSubclassOf<UObject>> IgnoreActorClasses)
	{
		if (!SetAllActorLoadGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:SetAllActorLoadGrid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllActorLoadGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllActorLoadGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, SetAllActorLoadGrid_world_Offset), 0, SetAllActorLoadGrid_world_PropertyAddress.Address, world);
		NativeReflection.InitializeValue_InContainer(SetAllActorLoadGrid_ActorLoadPolitics_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, FVector>(1, SetAllActorLoadGrid_ActorLoadPolitics_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetAllActorLoadGrid_ActorLoadPolitics_Offset), ActorLoadPolitics);
		new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, SetAllActorLoadGrid_IgnoreActorClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SetAllActorLoadGrid_IgnoreActorClasses_Offset), IgnoreActorClasses);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAllActorLoadGrid_FunctionAddress, intPtr, SetAllActorLoadGrid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAllActorLoadGrid_ActorLoadPolitics_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetAllActorLoadGrid_IgnoreActorClasses_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:GenerateWorldMiniMap")]
	public unsafe static void GenerateWorldMiniMap(UWorld world)
	{
		if (!GenerateWorldMiniMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:GenerateWorldMiniMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateWorldMiniMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateWorldMiniMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GenerateWorldMiniMap_world_Offset), 0, GenerateWorldMiniMap_world_PropertyAddress.Address, world);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateWorldMiniMap_FunctionAddress, intPtr, GenerateWorldMiniMap_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:FixSpecialActorLoadGridPolitics")]
	public unsafe static void FixSpecialActorLoadGridPolitics(UWorld world)
	{
		if (!FixSpecialActorLoadGridPolitics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:FixSpecialActorLoadGridPolitics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixSpecialActorLoadGridPolitics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixSpecialActorLoadGridPolitics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, FixSpecialActorLoadGridPolitics_world_Offset), 0, FixSpecialActorLoadGridPolitics_world_PropertyAddress.Address, world);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixSpecialActorLoadGridPolitics_FunctionAddress, intPtr, FixSpecialActorLoadGridPolitics_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:FindUncategoryGridActor")]
	public unsafe static void FindUncategoryGridActor(UWorld world)
	{
		if (!FindUncategoryGridActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:FindUncategoryGridActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindUncategoryGridActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindUncategoryGridActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, FindUncategoryGridActor_world_Offset), 0, FindUncategoryGridActor_world_PropertyAddress.Address, world);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindUncategoryGridActor_FunctionAddress, intPtr, FindUncategoryGridActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:CreateLayerBySubLevel")]
	public unsafe static void CreateLayerBySubLevel(UWorld world)
	{
		if (!CreateLayerBySubLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:CreateLayerBySubLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLayerBySubLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLayerBySubLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, CreateLayerBySubLevel_world_Offset), 0, CreateLayerBySubLevel_world_PropertyAddress.Address, world);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateLayerBySubLevel_FunctionAddress, intPtr, CreateLayerBySubLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:CleanBadActorDesc")]
	public unsafe static int CleanBadActorDesc(UWorld world)
	{
		if (!CleanBadActorDesc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:CleanBadActorDesc");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanBadActorDesc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanBadActorDesc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, CleanBadActorDesc_world_Offset), 0, CleanBadActorDesc_world_PropertyAddress.Address, world);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CleanBadActorDesc_FunctionAddress, intPtr, CleanBadActorDesc_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CleanBadActorDesc_ReturnValue_Offset), 0, CleanBadActorDesc_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:AddStaticMeshActorToHLODLayer")]
	public unsafe static void AddStaticMeshActorToHLODLayer(UObject WorldContextObject, UHLODLayer TargeHLODLayer, List<string> MatchedKeywords, List<string> ForfeitKeywords, float MinExtentSize, EHLODBatchingPolicy InBatchingPolicy = EHLODBatchingPolicy.None)
	{
		if (!AddStaticMeshActorToHLODLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:AddStaticMeshActorToHLODLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddStaticMeshActorToHLODLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddStaticMeshActorToHLODLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddStaticMeshActorToHLODLayer_WorldContextObject_Offset), 0, AddStaticMeshActorToHLODLayer_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UHLODLayer>.ToNative(IntPtr.Add(intPtr, AddStaticMeshActorToHLODLayer_TargeHLODLayer_Offset), 0, AddStaticMeshActorToHLODLayer_TargeHLODLayer_PropertyAddress.Address, TargeHLODLayer);
		new TArrayCopyMarshaler<string>(1, AddStaticMeshActorToHLODLayer_MatchedKeywords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AddStaticMeshActorToHLODLayer_MatchedKeywords_Offset), MatchedKeywords);
		new TArrayCopyMarshaler<string>(1, AddStaticMeshActorToHLODLayer_ForfeitKeywords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AddStaticMeshActorToHLODLayer_ForfeitKeywords_Offset), ForfeitKeywords);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddStaticMeshActorToHLODLayer_MinExtentSize_Offset), 0, AddStaticMeshActorToHLODLayer_MinExtentSize_PropertyAddress.Address, MinExtentSize);
		EnumMarshaler<EHLODBatchingPolicy>.ToNative(IntPtr.Add(intPtr, AddStaticMeshActorToHLODLayer_InBatchingPolicy_Offset), 0, AddStaticMeshActorToHLODLayer_InBatchingPolicy_PropertyAddress.Address, InBatchingPolicy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddStaticMeshActorToHLODLayer_FunctionAddress, intPtr, AddStaticMeshActorToHLODLayer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddStaticMeshActorToHLODLayer_MatchedKeywords_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddStaticMeshActorToHLODLayer_ForfeitKeywords_PropertyAddress.Address, intPtr);
	}

	static UGSEditorWorldPartitionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorWorldPartitionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorWorldPartitionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary");
		SetAllActorLoadGrid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAllActorLoadGrid");
		SetAllActorLoadGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllActorLoadGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllActorLoadGrid_world_PropertyAddress, SetAllActorLoadGrid_FunctionAddress, "world");
		SetAllActorLoadGrid_world_Offset = NativeReflectionCached.GetPropertyOffset(SetAllActorLoadGrid_FunctionAddress, "world");
		SetAllActorLoadGrid_world_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllActorLoadGrid_FunctionAddress, "world", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllActorLoadGrid_ActorLoadPolitics_PropertyAddress, SetAllActorLoadGrid_FunctionAddress, "ActorLoadPolitics");
		SetAllActorLoadGrid_ActorLoadPolitics_Offset = NativeReflectionCached.GetPropertyOffset(SetAllActorLoadGrid_FunctionAddress, "ActorLoadPolitics");
		SetAllActorLoadGrid_ActorLoadPolitics_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllActorLoadGrid_FunctionAddress, "ActorLoadPolitics", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllActorLoadGrid_IgnoreActorClasses_PropertyAddress, SetAllActorLoadGrid_FunctionAddress, "IgnoreActorClasses");
		SetAllActorLoadGrid_IgnoreActorClasses_Offset = NativeReflectionCached.GetPropertyOffset(SetAllActorLoadGrid_FunctionAddress, "IgnoreActorClasses");
		SetAllActorLoadGrid_IgnoreActorClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllActorLoadGrid_FunctionAddress, "IgnoreActorClasses", Classes.FArrayProperty);
		SetAllActorLoadGrid_IsValid = SetAllActorLoadGrid_FunctionAddress != IntPtr.Zero && SetAllActorLoadGrid_world_IsValid && SetAllActorLoadGrid_ActorLoadPolitics_IsValid && SetAllActorLoadGrid_IgnoreActorClasses_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:SetAllActorLoadGrid", SetAllActorLoadGrid_IsValid);
		GenerateWorldMiniMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateWorldMiniMap");
		GenerateWorldMiniMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateWorldMiniMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateWorldMiniMap_world_PropertyAddress, GenerateWorldMiniMap_FunctionAddress, "world");
		GenerateWorldMiniMap_world_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWorldMiniMap_FunctionAddress, "world");
		GenerateWorldMiniMap_world_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWorldMiniMap_FunctionAddress, "world", Classes.FObjectProperty);
		GenerateWorldMiniMap_IsValid = GenerateWorldMiniMap_FunctionAddress != IntPtr.Zero && GenerateWorldMiniMap_world_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:GenerateWorldMiniMap", GenerateWorldMiniMap_IsValid);
		FixSpecialActorLoadGridPolitics_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixSpecialActorLoadGridPolitics");
		FixSpecialActorLoadGridPolitics_ParamsSize = NativeReflection.GetFunctionParamsSize(FixSpecialActorLoadGridPolitics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixSpecialActorLoadGridPolitics_world_PropertyAddress, FixSpecialActorLoadGridPolitics_FunctionAddress, "world");
		FixSpecialActorLoadGridPolitics_world_Offset = NativeReflectionCached.GetPropertyOffset(FixSpecialActorLoadGridPolitics_FunctionAddress, "world");
		FixSpecialActorLoadGridPolitics_world_IsValid = NativeReflectionCached.ValidatePropertyClass(FixSpecialActorLoadGridPolitics_FunctionAddress, "world", Classes.FObjectProperty);
		FixSpecialActorLoadGridPolitics_IsValid = FixSpecialActorLoadGridPolitics_FunctionAddress != IntPtr.Zero && FixSpecialActorLoadGridPolitics_world_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:FixSpecialActorLoadGridPolitics", FixSpecialActorLoadGridPolitics_IsValid);
		FindUncategoryGridActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindUncategoryGridActor");
		FindUncategoryGridActor_ParamsSize = NativeReflection.GetFunctionParamsSize(FindUncategoryGridActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindUncategoryGridActor_world_PropertyAddress, FindUncategoryGridActor_FunctionAddress, "world");
		FindUncategoryGridActor_world_Offset = NativeReflectionCached.GetPropertyOffset(FindUncategoryGridActor_FunctionAddress, "world");
		FindUncategoryGridActor_world_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUncategoryGridActor_FunctionAddress, "world", Classes.FObjectProperty);
		FindUncategoryGridActor_IsValid = FindUncategoryGridActor_FunctionAddress != IntPtr.Zero && FindUncategoryGridActor_world_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:FindUncategoryGridActor", FindUncategoryGridActor_IsValid);
		CreateLayerBySubLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateLayerBySubLevel");
		CreateLayerBySubLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLayerBySubLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateLayerBySubLevel_world_PropertyAddress, CreateLayerBySubLevel_FunctionAddress, "world");
		CreateLayerBySubLevel_world_Offset = NativeReflectionCached.GetPropertyOffset(CreateLayerBySubLevel_FunctionAddress, "world");
		CreateLayerBySubLevel_world_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLayerBySubLevel_FunctionAddress, "world", Classes.FObjectProperty);
		CreateLayerBySubLevel_IsValid = CreateLayerBySubLevel_FunctionAddress != IntPtr.Zero && CreateLayerBySubLevel_world_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:CreateLayerBySubLevel", CreateLayerBySubLevel_IsValid);
		CleanBadActorDesc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanBadActorDesc");
		CleanBadActorDesc_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanBadActorDesc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CleanBadActorDesc_world_PropertyAddress, CleanBadActorDesc_FunctionAddress, "world");
		CleanBadActorDesc_world_Offset = NativeReflectionCached.GetPropertyOffset(CleanBadActorDesc_FunctionAddress, "world");
		CleanBadActorDesc_world_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanBadActorDesc_FunctionAddress, "world", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CleanBadActorDesc_ReturnValue_PropertyAddress, CleanBadActorDesc_FunctionAddress, "ReturnValue");
		CleanBadActorDesc_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CleanBadActorDesc_FunctionAddress, "ReturnValue");
		CleanBadActorDesc_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanBadActorDesc_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CleanBadActorDesc_IsValid = CleanBadActorDesc_FunctionAddress != IntPtr.Zero && CleanBadActorDesc_world_IsValid && CleanBadActorDesc_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:CleanBadActorDesc", CleanBadActorDesc_IsValid);
		AddStaticMeshActorToHLODLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddStaticMeshActorToHLODLayer");
		AddStaticMeshActorToHLODLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(AddStaticMeshActorToHLODLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddStaticMeshActorToHLODLayer_WorldContextObject_PropertyAddress, AddStaticMeshActorToHLODLayer_FunctionAddress, "WorldContextObject");
		AddStaticMeshActorToHLODLayer_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddStaticMeshActorToHLODLayer_FunctionAddress, "WorldContextObject");
		AddStaticMeshActorToHLODLayer_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStaticMeshActorToHLODLayer_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStaticMeshActorToHLODLayer_TargeHLODLayer_PropertyAddress, AddStaticMeshActorToHLODLayer_FunctionAddress, "TargeHLODLayer");
		AddStaticMeshActorToHLODLayer_TargeHLODLayer_Offset = NativeReflectionCached.GetPropertyOffset(AddStaticMeshActorToHLODLayer_FunctionAddress, "TargeHLODLayer");
		AddStaticMeshActorToHLODLayer_TargeHLODLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStaticMeshActorToHLODLayer_FunctionAddress, "TargeHLODLayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStaticMeshActorToHLODLayer_MatchedKeywords_PropertyAddress, AddStaticMeshActorToHLODLayer_FunctionAddress, "MatchedKeywords");
		AddStaticMeshActorToHLODLayer_MatchedKeywords_Offset = NativeReflectionCached.GetPropertyOffset(AddStaticMeshActorToHLODLayer_FunctionAddress, "MatchedKeywords");
		AddStaticMeshActorToHLODLayer_MatchedKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStaticMeshActorToHLODLayer_FunctionAddress, "MatchedKeywords", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStaticMeshActorToHLODLayer_ForfeitKeywords_PropertyAddress, AddStaticMeshActorToHLODLayer_FunctionAddress, "ForfeitKeywords");
		AddStaticMeshActorToHLODLayer_ForfeitKeywords_Offset = NativeReflectionCached.GetPropertyOffset(AddStaticMeshActorToHLODLayer_FunctionAddress, "ForfeitKeywords");
		AddStaticMeshActorToHLODLayer_ForfeitKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStaticMeshActorToHLODLayer_FunctionAddress, "ForfeitKeywords", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStaticMeshActorToHLODLayer_MinExtentSize_PropertyAddress, AddStaticMeshActorToHLODLayer_FunctionAddress, "MinExtentSize");
		AddStaticMeshActorToHLODLayer_MinExtentSize_Offset = NativeReflectionCached.GetPropertyOffset(AddStaticMeshActorToHLODLayer_FunctionAddress, "MinExtentSize");
		AddStaticMeshActorToHLODLayer_MinExtentSize_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStaticMeshActorToHLODLayer_FunctionAddress, "MinExtentSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStaticMeshActorToHLODLayer_InBatchingPolicy_PropertyAddress, AddStaticMeshActorToHLODLayer_FunctionAddress, "InBatchingPolicy");
		AddStaticMeshActorToHLODLayer_InBatchingPolicy_Offset = NativeReflectionCached.GetPropertyOffset(AddStaticMeshActorToHLODLayer_FunctionAddress, "InBatchingPolicy");
		AddStaticMeshActorToHLODLayer_InBatchingPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStaticMeshActorToHLODLayer_FunctionAddress, "InBatchingPolicy", Classes.FEnumProperty);
		AddStaticMeshActorToHLODLayer_IsValid = AddStaticMeshActorToHLODLayer_FunctionAddress != IntPtr.Zero && AddStaticMeshActorToHLODLayer_WorldContextObject_IsValid && AddStaticMeshActorToHLODLayer_TargeHLODLayer_IsValid && AddStaticMeshActorToHLODLayer_MatchedKeywords_IsValid && AddStaticMeshActorToHLODLayer_ForfeitKeywords_IsValid && AddStaticMeshActorToHLODLayer_MinExtentSize_IsValid && AddStaticMeshActorToHLODLayer_InBatchingPolicy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWorldPartitionLibrary:AddStaticMeshActorToHLODLayer", AddStaticMeshActorToHLODLayer_IsValid);
	}
}
