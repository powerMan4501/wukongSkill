using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Foliage;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorStaticMeshFoliageLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SpawnInteractiveVolumesForSelectedFoliageInstances_IsValid;

	private static IntPtr SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress;

	private static int SpawnInteractiveVolumesForSelectedFoliageInstances_ParamsSize;

	private static bool SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_IsValid;

	private static FFieldAddress SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_PropertyAddress;

	private static int SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_Offset;

	private static bool SpawnInteractiveVolumesForSelectedFoliageActors_IsValid;

	private static IntPtr SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress;

	private static int SpawnInteractiveVolumesForSelectedFoliageActors_ParamsSize;

	private static bool SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_IsValid;

	private static FFieldAddress SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_PropertyAddress;

	private static int SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_Offset;

	private static bool SetCullDistanceMin_IsValid;

	private static IntPtr SetCullDistanceMin_FunctionAddress;

	private static int SetCullDistanceMin_ParamsSize;

	private static bool SetCullDistanceMin_Target_IsValid;

	private static FFieldAddress SetCullDistanceMin_Target_PropertyAddress;

	private static int SetCullDistanceMin_Target_Offset;

	private static bool SetCullDistanceMin_Min_IsValid;

	private static FFieldAddress SetCullDistanceMin_Min_PropertyAddress;

	private static int SetCullDistanceMin_Min_Offset;

	private static bool SetCullDistanceMin_ReturnValue_IsValid;

	private static FFieldAddress SetCullDistanceMin_ReturnValue_PropertyAddress;

	private static int SetCullDistanceMin_ReturnValue_Offset;

	private static bool SetCullDistanceMax_IsValid;

	private static IntPtr SetCullDistanceMax_FunctionAddress;

	private static int SetCullDistanceMax_ParamsSize;

	private static bool SetCullDistanceMax_Target_IsValid;

	private static FFieldAddress SetCullDistanceMax_Target_PropertyAddress;

	private static int SetCullDistanceMax_Target_Offset;

	private static bool SetCullDistanceMax_Max_IsValid;

	private static FFieldAddress SetCullDistanceMax_Max_PropertyAddress;

	private static int SetCullDistanceMax_Max_Offset;

	private static bool SetCullDistanceMax_ReturnValue_IsValid;

	private static FFieldAddress SetCullDistanceMax_ReturnValue_PropertyAddress;

	private static int SetCullDistanceMax_ReturnValue_Offset;

	private static bool ResetFoliageTypeInfoToFoliageComponent_IsValid;

	private static IntPtr ResetFoliageTypeInfoToFoliageComponent_FunctionAddress;

	private static int ResetFoliageTypeInfoToFoliageComponent_ParamsSize;

	private static bool ResetFoliageTypeInfoToFoliageComponent_Levels_IsValid;

	private static FFieldAddress ResetFoliageTypeInfoToFoliageComponent_Levels_PropertyAddress;

	private static int ResetFoliageTypeInfoToFoliageComponent_Levels_Offset;

	private static bool RemoveUnmappedFoliageComponents_IsValid;

	private static IntPtr RemoveUnmappedFoliageComponents_FunctionAddress;

	private static int RemoveUnmappedFoliageComponents_ParamsSize;

	private static bool RemoveShadowFoliageComponents_IsValid;

	private static IntPtr RemoveShadowFoliageComponents_FunctionAddress;

	private static int RemoveShadowFoliageComponents_ParamsSize;

	private static bool RemoveShadowFoliageComponents_Level_IsValid;

	private static FFieldAddress RemoveShadowFoliageComponents_Level_PropertyAddress;

	private static int RemoveShadowFoliageComponents_Level_Offset;

	private static bool RemoveFoliageInstancesByTransform_IsValid;

	private static IntPtr RemoveFoliageInstancesByTransform_FunctionAddress;

	private static int RemoveFoliageInstancesByTransform_ParamsSize;

	private static bool RemoveFoliageInstancesByTransform_InFoliageType_IsValid;

	private static FFieldAddress RemoveFoliageInstancesByTransform_InFoliageType_PropertyAddress;

	private static int RemoveFoliageInstancesByTransform_InFoliageType_Offset;

	private static bool RemoveFoliageInstancesByTransform_Instances_IsValid;

	private static FFieldAddress RemoveFoliageInstancesByTransform_Instances_PropertyAddress;

	private static int RemoveFoliageInstancesByTransform_Instances_Offset;

	private static bool RemoveFoliageInstancesByTransform_ReturnValue_IsValid;

	private static FFieldAddress RemoveFoliageInstancesByTransform_ReturnValue_PropertyAddress;

	private static int RemoveFoliageInstancesByTransform_ReturnValue_Offset;

	private static bool PrintAllFoliageMaterialInfo_IsValid;

	private static IntPtr PrintAllFoliageMaterialInfo_FunctionAddress;

	private static int PrintAllFoliageMaterialInfo_ParamsSize;

	private static bool GetSelectedFoliageInstances_IsValid;

	private static IntPtr GetSelectedFoliageInstances_FunctionAddress;

	private static int GetSelectedFoliageInstances_ParamsSize;

	private static bool GetSelectedFoliageInstances_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedFoliageInstances_ReturnValue_PropertyAddress;

	private static int GetSelectedFoliageInstances_ReturnValue_Offset;

	private static bool GetLevelFoliageInstanceDataByLevelName_IsValid;

	private static IntPtr GetLevelFoliageInstanceDataByLevelName_FunctionAddress;

	private static int GetLevelFoliageInstanceDataByLevelName_ParamsSize;

	private static bool GetLevelFoliageInstanceDataByLevelName_LevelName_IsValid;

	private static FFieldAddress GetLevelFoliageInstanceDataByLevelName_LevelName_PropertyAddress;

	private static int GetLevelFoliageInstanceDataByLevelName_LevelName_Offset;

	private static bool GetLevelFoliageInstanceDataByLevelName_ReturnValue_IsValid;

	private static FFieldAddress GetLevelFoliageInstanceDataByLevelName_ReturnValue_PropertyAddress;

	private static int GetLevelFoliageInstanceDataByLevelName_ReturnValue_Offset;

	private static bool GetLevelFoliageInstanceData_IsValid;

	private static IntPtr GetLevelFoliageInstanceData_FunctionAddress;

	private static int GetLevelFoliageInstanceData_ParamsSize;

	private static bool GetLevelFoliageInstanceData_Level_IsValid;

	private static FFieldAddress GetLevelFoliageInstanceData_Level_PropertyAddress;

	private static int GetLevelFoliageInstanceData_Level_Offset;

	private static bool GetLevelFoliageInstanceData_ReturnValue_IsValid;

	private static FFieldAddress GetLevelFoliageInstanceData_ReturnValue_PropertyAddress;

	private static int GetLevelFoliageInstanceData_ReturnValue_Offset;

	private static bool GetCullDistanceMin_IsValid;

	private static IntPtr GetCullDistanceMin_FunctionAddress;

	private static int GetCullDistanceMin_ParamsSize;

	private static bool GetCullDistanceMin_Target_IsValid;

	private static FFieldAddress GetCullDistanceMin_Target_PropertyAddress;

	private static int GetCullDistanceMin_Target_Offset;

	private static bool GetCullDistanceMin_ReturnValue_IsValid;

	private static FFieldAddress GetCullDistanceMin_ReturnValue_PropertyAddress;

	private static int GetCullDistanceMin_ReturnValue_Offset;

	private static bool GetCullDistanceMax_IsValid;

	private static IntPtr GetCullDistanceMax_FunctionAddress;

	private static int GetCullDistanceMax_ParamsSize;

	private static bool GetCullDistanceMax_Target_IsValid;

	private static FFieldAddress GetCullDistanceMax_Target_PropertyAddress;

	private static int GetCullDistanceMax_Target_Offset;

	private static bool GetCullDistanceMax_ReturnValue_IsValid;

	private static FFieldAddress GetCullDistanceMax_ReturnValue_PropertyAddress;

	private static int GetCullDistanceMax_ReturnValue_Offset;

	private static bool GatherAllFoliageActorToMainLevel_IsValid;

	private static IntPtr GatherAllFoliageActorToMainLevel_FunctionAddress;

	private static int GatherAllFoliageActorToMainLevel_ParamsSize;

	private static bool GatherAllFoliageActorToMainLevel_MainLevel_IsValid;

	private static FFieldAddress GatherAllFoliageActorToMainLevel_MainLevel_PropertyAddress;

	private static int GatherAllFoliageActorToMainLevel_MainLevel_Offset;

	private static bool GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_IsValid;

	private static FFieldAddress GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_PropertyAddress;

	private static int GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_Offset;

	private static bool GatherAllFoliageActorToCurrentLevel_IsValid;

	private static IntPtr GatherAllFoliageActorToCurrentLevel_FunctionAddress;

	private static int GatherAllFoliageActorToCurrentLevel_ParamsSize;

	private static bool GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_IsValid;

	private static FFieldAddress GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_PropertyAddress;

	private static int GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_Offset;

	private static bool GatherAllFoliageActorsToMainLevels_IsValid;

	private static IntPtr GatherAllFoliageActorsToMainLevels_FunctionAddress;

	private static int GatherAllFoliageActorsToMainLevels_ParamsSize;

	private static bool GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_IsValid;

	private static FFieldAddress GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_PropertyAddress;

	private static int GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_Offset;

	private static bool FixFoliageComponentAttach_IsValid;

	private static IntPtr FixFoliageComponentAttach_FunctionAddress;

	private static int FixFoliageComponentAttach_ParamsSize;

	private static bool FindComponentByFoliageType_IsValid;

	private static IntPtr FindComponentByFoliageType_FunctionAddress;

	private static int FindComponentByFoliageType_ParamsSize;

	private static bool FindComponentByFoliageType_InFoliageType_IsValid;

	private static FFieldAddress FindComponentByFoliageType_InFoliageType_PropertyAddress;

	private static int FindComponentByFoliageType_InFoliageType_Offset;

	private static bool FindComponentByFoliageType_ReturnValue_IsValid;

	private static FFieldAddress FindComponentByFoliageType_ReturnValue_PropertyAddress;

	private static int FindComponentByFoliageType_ReturnValue_Offset;

	private static bool ConvertStaticMeshActorToFoliage_IsValid;

	private static IntPtr ConvertStaticMeshActorToFoliage_FunctionAddress;

	private static int ConvertStaticMeshActorToFoliage_ParamsSize;

	private static bool ConvertStaticMeshActorToFoliage_SelectedActor_IsValid;

	private static FFieldAddress ConvertStaticMeshActorToFoliage_SelectedActor_PropertyAddress;

	private static int ConvertStaticMeshActorToFoliage_SelectedActor_Offset;

	private static bool ConvertStaticMeshActorToFoliage_CanAddNewFoliage_IsValid;

	private static FFieldAddress ConvertStaticMeshActorToFoliage_CanAddNewFoliage_PropertyAddress;

	private static int ConvertStaticMeshActorToFoliage_CanAddNewFoliage_Offset;

	private static bool ConvertStaticMeshActorToFoliage_ReturnValue_IsValid;

	private static FFieldAddress ConvertStaticMeshActorToFoliage_ReturnValue_PropertyAddress;

	private static int ConvertStaticMeshActorToFoliage_ReturnValue_Offset;

	private static bool CommandletCleanAllFoliageInstancesBaseID_IsValid;

	private static IntPtr CommandletCleanAllFoliageInstancesBaseID_FunctionAddress;

	private static int CommandletCleanAllFoliageInstancesBaseID_ParamsSize;

	private static bool CommandletCleanAllFoliageInstancesBaseID_Level_IsValid;

	private static FFieldAddress CommandletCleanAllFoliageInstancesBaseID_Level_PropertyAddress;

	private static int CommandletCleanAllFoliageInstancesBaseID_Level_Offset;

	private static bool CleanAllFoliageInstancesBaseID_IsValid;

	private static IntPtr CleanAllFoliageInstancesBaseID_FunctionAddress;

	private static int CleanAllFoliageInstancesBaseID_ParamsSize;

	private static bool CleanAllFoliageInstancesBaseID_Level_IsValid;

	private static FFieldAddress CleanAllFoliageInstancesBaseID_Level_PropertyAddress;

	private static int CleanAllFoliageInstancesBaseID_Level_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SpawnInteractiveVolumesForSelectedFoliageInstances")]
	public unsafe static List<AFoliageInteractiveVolume> SpawnInteractiveVolumesForSelectedFoliageInstances()
	{
		if (!SpawnInteractiveVolumesForSelectedFoliageInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SpawnInteractiveVolumesForSelectedFoliageInstances");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnInteractiveVolumesForSelectedFoliageInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnInteractiveVolumesForSelectedFoliageInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress, intPtr, SpawnInteractiveVolumesForSelectedFoliageInstances_ParamsSize);
		List<AFoliageInteractiveVolume> result = new TArrayCopyMarshaler<AFoliageInteractiveVolume>(1, SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AFoliageInteractiveVolume, UObjectMarshaler<AFoliageInteractiveVolume>>.FromNative, CachedMarshalingDelegates<AFoliageInteractiveVolume, UObjectMarshaler<AFoliageInteractiveVolume>>.ToNative).FromNative(IntPtr.Add(intPtr, SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SpawnInteractiveVolumesForSelectedFoliageActors")]
	public unsafe static List<AFoliageInteractiveVolume> SpawnInteractiveVolumesForSelectedFoliageActors()
	{
		if (!SpawnInteractiveVolumesForSelectedFoliageActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SpawnInteractiveVolumesForSelectedFoliageActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnInteractiveVolumesForSelectedFoliageActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnInteractiveVolumesForSelectedFoliageActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress, intPtr, SpawnInteractiveVolumesForSelectedFoliageActors_ParamsSize);
		List<AFoliageInteractiveVolume> result = new TArrayCopyMarshaler<AFoliageInteractiveVolume>(1, SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AFoliageInteractiveVolume, UObjectMarshaler<AFoliageInteractiveVolume>>.FromNative, CachedMarshalingDelegates<AFoliageInteractiveVolume, UObjectMarshaler<AFoliageInteractiveVolume>>.ToNative).FromNative(IntPtr.Add(intPtr, SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SetCullDistanceMin")]
	public unsafe static bool SetCullDistanceMin(UFoliageType_InstancedStaticMesh Target, int Min)
	{
		if (!SetCullDistanceMin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SetCullDistanceMin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCullDistanceMin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCullDistanceMin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType_InstancedStaticMesh>.ToNative(IntPtr.Add(intPtr, SetCullDistanceMin_Target_Offset), 0, SetCullDistanceMin_Target_PropertyAddress.Address, Target);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCullDistanceMin_Min_Offset), 0, SetCullDistanceMin_Min_PropertyAddress.Address, Min);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCullDistanceMin_FunctionAddress, intPtr, SetCullDistanceMin_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCullDistanceMin_ReturnValue_Offset), 0, SetCullDistanceMin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SetCullDistanceMax")]
	public unsafe static bool SetCullDistanceMax(UFoliageType_InstancedStaticMesh Target, int Max)
	{
		if (!SetCullDistanceMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SetCullDistanceMax");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCullDistanceMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCullDistanceMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType_InstancedStaticMesh>.ToNative(IntPtr.Add(intPtr, SetCullDistanceMax_Target_Offset), 0, SetCullDistanceMax_Target_PropertyAddress.Address, Target);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCullDistanceMax_Max_Offset), 0, SetCullDistanceMax_Max_PropertyAddress.Address, Max);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCullDistanceMax_FunctionAddress, intPtr, SetCullDistanceMax_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCullDistanceMax_ReturnValue_Offset), 0, SetCullDistanceMax_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:ResetFoliageTypeInfoToFoliageComponent")]
	public unsafe static void ResetFoliageTypeInfoToFoliageComponent(List<ULevel> Levels)
	{
		if (!ResetFoliageTypeInfoToFoliageComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:ResetFoliageTypeInfoToFoliageComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetFoliageTypeInfoToFoliageComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetFoliageTypeInfoToFoliageComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<ULevel>(1, ResetFoliageTypeInfoToFoliageComponent_Levels_PropertyAddress, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.FromNative, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.ToNative).ToNative(IntPtr.Add(intPtr, ResetFoliageTypeInfoToFoliageComponent_Levels_Offset), Levels);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetFoliageTypeInfoToFoliageComponent_FunctionAddress, intPtr, ResetFoliageTypeInfoToFoliageComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResetFoliageTypeInfoToFoliageComponent_Levels_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveUnmappedFoliageComponents")]
	public unsafe static void RemoveUnmappedFoliageComponents()
	{
		if (!RemoveUnmappedFoliageComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveUnmappedFoliageComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveUnmappedFoliageComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveUnmappedFoliageComponents_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RemoveUnmappedFoliageComponents_FunctionAddress, argsSize: RemoveUnmappedFoliageComponents_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveShadowFoliageComponents")]
	public unsafe static void RemoveShadowFoliageComponents(ULevel Level)
	{
		if (!RemoveShadowFoliageComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveShadowFoliageComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveShadowFoliageComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveShadowFoliageComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, RemoveShadowFoliageComponents_Level_Offset), 0, RemoveShadowFoliageComponents_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveShadowFoliageComponents_FunctionAddress, intPtr, RemoveShadowFoliageComponents_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveFoliageInstancesByTransform")]
	public unsafe static bool RemoveFoliageInstancesByTransform(UFoliageType InFoliageType, List<FFoliageInstanceData> Instances)
	{
		if (!RemoveFoliageInstancesByTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveFoliageInstancesByTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveFoliageInstancesByTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveFoliageInstancesByTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, RemoveFoliageInstancesByTransform_InFoliageType_Offset), 0, RemoveFoliageInstancesByTransform_InFoliageType_PropertyAddress.Address, InFoliageType);
		new TArrayCopyMarshaler<FFoliageInstanceData>(1, RemoveFoliageInstancesByTransform_Instances_PropertyAddress, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.FromNative, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveFoliageInstancesByTransform_Instances_Offset), Instances);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveFoliageInstancesByTransform_FunctionAddress, intPtr, RemoveFoliageInstancesByTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveFoliageInstancesByTransform_Instances_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveFoliageInstancesByTransform_ReturnValue_Offset), 0, RemoveFoliageInstancesByTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:PrintAllFoliageMaterialInfo")]
	public unsafe static void PrintAllFoliageMaterialInfo()
	{
		if (!PrintAllFoliageMaterialInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:PrintAllFoliageMaterialInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrintAllFoliageMaterialInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrintAllFoliageMaterialInfo_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PrintAllFoliageMaterialInfo_FunctionAddress, argsSize: PrintAllFoliageMaterialInfo_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetSelectedFoliageInstances")]
	public unsafe static Dictionary<ULevel, FLevel_FoliageInfo_BPData> GetSelectedFoliageInstances()
	{
		if (!GetSelectedFoliageInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetSelectedFoliageInstances");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedFoliageInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedFoliageInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedFoliageInstances_FunctionAddress, intPtr, GetSelectedFoliageInstances_ParamsSize);
		Dictionary<ULevel, FLevel_FoliageInfo_BPData> result = new TMapCopyMarshaler<ULevel, FLevel_FoliageInfo_BPData>(1, GetSelectedFoliageInstances_ReturnValue_PropertyAddress, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.FromNative, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.ToNative, CachedMarshalingDelegates<FLevel_FoliageInfo_BPData, FLevel_FoliageInfo_BPData>.FromNative, CachedMarshalingDelegates<FLevel_FoliageInfo_BPData, FLevel_FoliageInfo_BPData>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedFoliageInstances_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedFoliageInstances_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetLevelFoliageInstanceDataByLevelName")]
	public unsafe static Dictionary<UFoliageType, FFoliageInfo_BPData> GetLevelFoliageInstanceDataByLevelName(string LevelName)
	{
		if (!GetLevelFoliageInstanceDataByLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetLevelFoliageInstanceDataByLevelName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelFoliageInstanceDataByLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelFoliageInstanceDataByLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetLevelFoliageInstanceDataByLevelName_LevelName_Offset), 0, GetLevelFoliageInstanceDataByLevelName_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelFoliageInstanceDataByLevelName_FunctionAddress, intPtr, GetLevelFoliageInstanceDataByLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLevelFoliageInstanceDataByLevelName_LevelName_PropertyAddress.Address, intPtr);
		Dictionary<UFoliageType, FFoliageInfo_BPData> result = new TMapCopyMarshaler<UFoliageType, FFoliageInfo_BPData>(1, GetLevelFoliageInstanceDataByLevelName_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.FromNative, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.ToNative, CachedMarshalingDelegates<FFoliageInfo_BPData, FFoliageInfo_BPData>.FromNative, CachedMarshalingDelegates<FFoliageInfo_BPData, FFoliageInfo_BPData>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelFoliageInstanceDataByLevelName_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelFoliageInstanceDataByLevelName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetLevelFoliageInstanceData")]
	public unsafe static Dictionary<UFoliageType, FFoliageInfo_BPData> GetLevelFoliageInstanceData(ULevel Level)
	{
		if (!GetLevelFoliageInstanceData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetLevelFoliageInstanceData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelFoliageInstanceData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelFoliageInstanceData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, GetLevelFoliageInstanceData_Level_Offset), 0, GetLevelFoliageInstanceData_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelFoliageInstanceData_FunctionAddress, intPtr, GetLevelFoliageInstanceData_ParamsSize);
		Dictionary<UFoliageType, FFoliageInfo_BPData> result = new TMapCopyMarshaler<UFoliageType, FFoliageInfo_BPData>(1, GetLevelFoliageInstanceData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.FromNative, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.ToNative, CachedMarshalingDelegates<FFoliageInfo_BPData, FFoliageInfo_BPData>.FromNative, CachedMarshalingDelegates<FFoliageInfo_BPData, FFoliageInfo_BPData>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelFoliageInstanceData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelFoliageInstanceData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetCullDistanceMin")]
	public unsafe static int GetCullDistanceMin(UFoliageType_InstancedStaticMesh Target)
	{
		if (!GetCullDistanceMin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetCullDistanceMin");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCullDistanceMin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCullDistanceMin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType_InstancedStaticMesh>.ToNative(IntPtr.Add(intPtr, GetCullDistanceMin_Target_Offset), 0, GetCullDistanceMin_Target_PropertyAddress.Address, Target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCullDistanceMin_FunctionAddress, intPtr, GetCullDistanceMin_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCullDistanceMin_ReturnValue_Offset), 0, GetCullDistanceMin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetCullDistanceMax")]
	public unsafe static int GetCullDistanceMax(UFoliageType_InstancedStaticMesh Target)
	{
		if (!GetCullDistanceMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetCullDistanceMax");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCullDistanceMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCullDistanceMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType_InstancedStaticMesh>.ToNative(IntPtr.Add(intPtr, GetCullDistanceMax_Target_Offset), 0, GetCullDistanceMax_Target_PropertyAddress.Address, Target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCullDistanceMax_FunctionAddress, intPtr, GetCullDistanceMax_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCullDistanceMax_ReturnValue_Offset), 0, GetCullDistanceMax_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorToMainLevel")]
	public unsafe static void GatherAllFoliageActorToMainLevel(ULevel MainLevel, bool DestoryFoliageActorInTileLevel)
	{
		if (!GatherAllFoliageActorToMainLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorToMainLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GatherAllFoliageActorToMainLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GatherAllFoliageActorToMainLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, GatherAllFoliageActorToMainLevel_MainLevel_Offset), 0, GatherAllFoliageActorToMainLevel_MainLevel_PropertyAddress.Address, MainLevel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_Offset), 0, GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_PropertyAddress.Address, DestoryFoliageActorInTileLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GatherAllFoliageActorToMainLevel_FunctionAddress, intPtr, GatherAllFoliageActorToMainLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorToCurrentLevel")]
	public unsafe static void GatherAllFoliageActorToCurrentLevel(bool DestoryFoliageActorInTileLevel)
	{
		if (!GatherAllFoliageActorToCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorToCurrentLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GatherAllFoliageActorToCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GatherAllFoliageActorToCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_Offset), 0, GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_PropertyAddress.Address, DestoryFoliageActorInTileLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GatherAllFoliageActorToCurrentLevel_FunctionAddress, intPtr, GatherAllFoliageActorToCurrentLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorsToMainLevels")]
	public unsafe static void GatherAllFoliageActorsToMainLevels(bool DestoryFoliageActorInTileLevel)
	{
		if (!GatherAllFoliageActorsToMainLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorsToMainLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GatherAllFoliageActorsToMainLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GatherAllFoliageActorsToMainLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_Offset), 0, GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_PropertyAddress.Address, DestoryFoliageActorInTileLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GatherAllFoliageActorsToMainLevels_FunctionAddress, intPtr, GatherAllFoliageActorsToMainLevels_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:FixFoliageComponentAttach")]
	public unsafe static void FixFoliageComponentAttach()
	{
		if (!FixFoliageComponentAttach_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:FixFoliageComponentAttach");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixFoliageComponentAttach_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixFoliageComponentAttach_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: FixFoliageComponentAttach_FunctionAddress, argsSize: FixFoliageComponentAttach_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:FindComponentByFoliageType")]
	public unsafe static List<UHierarchicalInstancedStaticMeshComponent> FindComponentByFoliageType(UFoliageType_InstancedStaticMesh InFoliageType)
	{
		if (!FindComponentByFoliageType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:FindComponentByFoliageType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindComponentByFoliageType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindComponentByFoliageType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType_InstancedStaticMesh>.ToNative(IntPtr.Add(intPtr, FindComponentByFoliageType_InFoliageType_Offset), 0, FindComponentByFoliageType_InFoliageType_PropertyAddress.Address, InFoliageType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindComponentByFoliageType_FunctionAddress, intPtr, FindComponentByFoliageType_ParamsSize);
		List<UHierarchicalInstancedStaticMeshComponent> result = new TArrayCopyMarshaler<UHierarchicalInstancedStaticMeshComponent>(1, FindComponentByFoliageType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UHierarchicalInstancedStaticMeshComponent, UObjectMarshaler<UHierarchicalInstancedStaticMeshComponent>>.FromNative, CachedMarshalingDelegates<UHierarchicalInstancedStaticMeshComponent, UObjectMarshaler<UHierarchicalInstancedStaticMeshComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, FindComponentByFoliageType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindComponentByFoliageType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:ConvertStaticMeshActorToFoliage")]
	public unsafe static int ConvertStaticMeshActorToFoliage(List<AActor> SelectedActor, bool CanAddNewFoliage)
	{
		if (!ConvertStaticMeshActorToFoliage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:ConvertStaticMeshActorToFoliage");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertStaticMeshActorToFoliage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertStaticMeshActorToFoliage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ConvertStaticMeshActorToFoliage_SelectedActor_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertStaticMeshActorToFoliage_SelectedActor_Offset), SelectedActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ConvertStaticMeshActorToFoliage_CanAddNewFoliage_Offset), 0, ConvertStaticMeshActorToFoliage_CanAddNewFoliage_PropertyAddress.Address, CanAddNewFoliage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertStaticMeshActorToFoliage_FunctionAddress, intPtr, ConvertStaticMeshActorToFoliage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertStaticMeshActorToFoliage_SelectedActor_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ConvertStaticMeshActorToFoliage_ReturnValue_Offset), 0, ConvertStaticMeshActorToFoliage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:CommandletCleanAllFoliageInstancesBaseID")]
	public unsafe static void CommandletCleanAllFoliageInstancesBaseID(ULevel Level)
	{
		if (!CommandletCleanAllFoliageInstancesBaseID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:CommandletCleanAllFoliageInstancesBaseID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CommandletCleanAllFoliageInstancesBaseID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CommandletCleanAllFoliageInstancesBaseID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, CommandletCleanAllFoliageInstancesBaseID_Level_Offset), 0, CommandletCleanAllFoliageInstancesBaseID_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CommandletCleanAllFoliageInstancesBaseID_FunctionAddress, intPtr, CommandletCleanAllFoliageInstancesBaseID_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:CleanAllFoliageInstancesBaseID")]
	public unsafe static void CleanAllFoliageInstancesBaseID(ULevel Level)
	{
		if (!CleanAllFoliageInstancesBaseID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:CleanAllFoliageInstancesBaseID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanAllFoliageInstancesBaseID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanAllFoliageInstancesBaseID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, CleanAllFoliageInstancesBaseID_Level_Offset), 0, CleanAllFoliageInstancesBaseID_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CleanAllFoliageInstancesBaseID_FunctionAddress, intPtr, CleanAllFoliageInstancesBaseID_ParamsSize);
	}

	static UGSEditorStaticMeshFoliageLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorStaticMeshFoliageLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorStaticMeshFoliageLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary");
		SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnInteractiveVolumesForSelectedFoliageInstances");
		SpawnInteractiveVolumesForSelectedFoliageInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_PropertyAddress, SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress, "ReturnValue");
		SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress, "ReturnValue");
		SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		SpawnInteractiveVolumesForSelectedFoliageInstances_IsValid = SpawnInteractiveVolumesForSelectedFoliageInstances_FunctionAddress != IntPtr.Zero && SpawnInteractiveVolumesForSelectedFoliageInstances_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SpawnInteractiveVolumesForSelectedFoliageInstances", SpawnInteractiveVolumesForSelectedFoliageInstances_IsValid);
		SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnInteractiveVolumesForSelectedFoliageActors");
		SpawnInteractiveVolumesForSelectedFoliageActors_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_PropertyAddress, SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress, "ReturnValue");
		SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress, "ReturnValue");
		SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		SpawnInteractiveVolumesForSelectedFoliageActors_IsValid = SpawnInteractiveVolumesForSelectedFoliageActors_FunctionAddress != IntPtr.Zero && SpawnInteractiveVolumesForSelectedFoliageActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SpawnInteractiveVolumesForSelectedFoliageActors", SpawnInteractiveVolumesForSelectedFoliageActors_IsValid);
		SetCullDistanceMin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCullDistanceMin");
		SetCullDistanceMin_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCullDistanceMin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistanceMin_Target_PropertyAddress, SetCullDistanceMin_FunctionAddress, "Target");
		SetCullDistanceMin_Target_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistanceMin_FunctionAddress, "Target");
		SetCullDistanceMin_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistanceMin_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistanceMin_Min_PropertyAddress, SetCullDistanceMin_FunctionAddress, "Min");
		SetCullDistanceMin_Min_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistanceMin_FunctionAddress, "Min");
		SetCullDistanceMin_Min_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistanceMin_FunctionAddress, "Min", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistanceMin_ReturnValue_PropertyAddress, SetCullDistanceMin_FunctionAddress, "ReturnValue");
		SetCullDistanceMin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistanceMin_FunctionAddress, "ReturnValue");
		SetCullDistanceMin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistanceMin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCullDistanceMin_IsValid = SetCullDistanceMin_FunctionAddress != IntPtr.Zero && SetCullDistanceMin_Target_IsValid && SetCullDistanceMin_Min_IsValid && SetCullDistanceMin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SetCullDistanceMin", SetCullDistanceMin_IsValid);
		SetCullDistanceMax_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCullDistanceMax");
		SetCullDistanceMax_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCullDistanceMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistanceMax_Target_PropertyAddress, SetCullDistanceMax_FunctionAddress, "Target");
		SetCullDistanceMax_Target_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistanceMax_FunctionAddress, "Target");
		SetCullDistanceMax_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistanceMax_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistanceMax_Max_PropertyAddress, SetCullDistanceMax_FunctionAddress, "Max");
		SetCullDistanceMax_Max_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistanceMax_FunctionAddress, "Max");
		SetCullDistanceMax_Max_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistanceMax_FunctionAddress, "Max", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistanceMax_ReturnValue_PropertyAddress, SetCullDistanceMax_FunctionAddress, "ReturnValue");
		SetCullDistanceMax_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistanceMax_FunctionAddress, "ReturnValue");
		SetCullDistanceMax_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistanceMax_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCullDistanceMax_IsValid = SetCullDistanceMax_FunctionAddress != IntPtr.Zero && SetCullDistanceMax_Target_IsValid && SetCullDistanceMax_Max_IsValid && SetCullDistanceMax_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:SetCullDistanceMax", SetCullDistanceMax_IsValid);
		ResetFoliageTypeInfoToFoliageComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetFoliageTypeInfoToFoliageComponent");
		ResetFoliageTypeInfoToFoliageComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetFoliageTypeInfoToFoliageComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetFoliageTypeInfoToFoliageComponent_Levels_PropertyAddress, ResetFoliageTypeInfoToFoliageComponent_FunctionAddress, "Levels");
		ResetFoliageTypeInfoToFoliageComponent_Levels_Offset = NativeReflectionCached.GetPropertyOffset(ResetFoliageTypeInfoToFoliageComponent_FunctionAddress, "Levels");
		ResetFoliageTypeInfoToFoliageComponent_Levels_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetFoliageTypeInfoToFoliageComponent_FunctionAddress, "Levels", Classes.FArrayProperty);
		ResetFoliageTypeInfoToFoliageComponent_IsValid = ResetFoliageTypeInfoToFoliageComponent_FunctionAddress != IntPtr.Zero && ResetFoliageTypeInfoToFoliageComponent_Levels_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:ResetFoliageTypeInfoToFoliageComponent", ResetFoliageTypeInfoToFoliageComponent_IsValid);
		RemoveUnmappedFoliageComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveUnmappedFoliageComponents");
		RemoveUnmappedFoliageComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveUnmappedFoliageComponents_FunctionAddress);
		RemoveUnmappedFoliageComponents_IsValid = RemoveUnmappedFoliageComponents_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveUnmappedFoliageComponents", RemoveUnmappedFoliageComponents_IsValid);
		RemoveShadowFoliageComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveShadowFoliageComponents");
		RemoveShadowFoliageComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveShadowFoliageComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveShadowFoliageComponents_Level_PropertyAddress, RemoveShadowFoliageComponents_FunctionAddress, "Level");
		RemoveShadowFoliageComponents_Level_Offset = NativeReflectionCached.GetPropertyOffset(RemoveShadowFoliageComponents_FunctionAddress, "Level");
		RemoveShadowFoliageComponents_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveShadowFoliageComponents_FunctionAddress, "Level", Classes.FObjectProperty);
		RemoveShadowFoliageComponents_IsValid = RemoveShadowFoliageComponents_FunctionAddress != IntPtr.Zero && RemoveShadowFoliageComponents_Level_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveShadowFoliageComponents", RemoveShadowFoliageComponents_IsValid);
		RemoveFoliageInstancesByTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveFoliageInstancesByTransform");
		RemoveFoliageInstancesByTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveFoliageInstancesByTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveFoliageInstancesByTransform_InFoliageType_PropertyAddress, RemoveFoliageInstancesByTransform_FunctionAddress, "InFoliageType");
		RemoveFoliageInstancesByTransform_InFoliageType_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFoliageInstancesByTransform_FunctionAddress, "InFoliageType");
		RemoveFoliageInstancesByTransform_InFoliageType_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFoliageInstancesByTransform_FunctionAddress, "InFoliageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFoliageInstancesByTransform_Instances_PropertyAddress, RemoveFoliageInstancesByTransform_FunctionAddress, "Instances");
		RemoveFoliageInstancesByTransform_Instances_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFoliageInstancesByTransform_FunctionAddress, "Instances");
		RemoveFoliageInstancesByTransform_Instances_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFoliageInstancesByTransform_FunctionAddress, "Instances", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFoliageInstancesByTransform_ReturnValue_PropertyAddress, RemoveFoliageInstancesByTransform_FunctionAddress, "ReturnValue");
		RemoveFoliageInstancesByTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFoliageInstancesByTransform_FunctionAddress, "ReturnValue");
		RemoveFoliageInstancesByTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFoliageInstancesByTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveFoliageInstancesByTransform_IsValid = RemoveFoliageInstancesByTransform_FunctionAddress != IntPtr.Zero && RemoveFoliageInstancesByTransform_InFoliageType_IsValid && RemoveFoliageInstancesByTransform_Instances_IsValid && RemoveFoliageInstancesByTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:RemoveFoliageInstancesByTransform", RemoveFoliageInstancesByTransform_IsValid);
		PrintAllFoliageMaterialInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrintAllFoliageMaterialInfo");
		PrintAllFoliageMaterialInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintAllFoliageMaterialInfo_FunctionAddress);
		PrintAllFoliageMaterialInfo_IsValid = PrintAllFoliageMaterialInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:PrintAllFoliageMaterialInfo", PrintAllFoliageMaterialInfo_IsValid);
		GetSelectedFoliageInstances_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedFoliageInstances");
		GetSelectedFoliageInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedFoliageInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedFoliageInstances_ReturnValue_PropertyAddress, GetSelectedFoliageInstances_FunctionAddress, "ReturnValue");
		GetSelectedFoliageInstances_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedFoliageInstances_FunctionAddress, "ReturnValue");
		GetSelectedFoliageInstances_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedFoliageInstances_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetSelectedFoliageInstances_IsValid = GetSelectedFoliageInstances_FunctionAddress != IntPtr.Zero && GetSelectedFoliageInstances_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetSelectedFoliageInstances", GetSelectedFoliageInstances_IsValid);
		GetLevelFoliageInstanceDataByLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelFoliageInstanceDataByLevelName");
		GetLevelFoliageInstanceDataByLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelFoliageInstanceDataByLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelFoliageInstanceDataByLevelName_LevelName_PropertyAddress, GetLevelFoliageInstanceDataByLevelName_FunctionAddress, "LevelName");
		GetLevelFoliageInstanceDataByLevelName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelFoliageInstanceDataByLevelName_FunctionAddress, "LevelName");
		GetLevelFoliageInstanceDataByLevelName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelFoliageInstanceDataByLevelName_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelFoliageInstanceDataByLevelName_ReturnValue_PropertyAddress, GetLevelFoliageInstanceDataByLevelName_FunctionAddress, "ReturnValue");
		GetLevelFoliageInstanceDataByLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelFoliageInstanceDataByLevelName_FunctionAddress, "ReturnValue");
		GetLevelFoliageInstanceDataByLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelFoliageInstanceDataByLevelName_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetLevelFoliageInstanceDataByLevelName_IsValid = GetLevelFoliageInstanceDataByLevelName_FunctionAddress != IntPtr.Zero && GetLevelFoliageInstanceDataByLevelName_LevelName_IsValid && GetLevelFoliageInstanceDataByLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetLevelFoliageInstanceDataByLevelName", GetLevelFoliageInstanceDataByLevelName_IsValid);
		GetLevelFoliageInstanceData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelFoliageInstanceData");
		GetLevelFoliageInstanceData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelFoliageInstanceData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelFoliageInstanceData_Level_PropertyAddress, GetLevelFoliageInstanceData_FunctionAddress, "Level");
		GetLevelFoliageInstanceData_Level_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelFoliageInstanceData_FunctionAddress, "Level");
		GetLevelFoliageInstanceData_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelFoliageInstanceData_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelFoliageInstanceData_ReturnValue_PropertyAddress, GetLevelFoliageInstanceData_FunctionAddress, "ReturnValue");
		GetLevelFoliageInstanceData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelFoliageInstanceData_FunctionAddress, "ReturnValue");
		GetLevelFoliageInstanceData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelFoliageInstanceData_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetLevelFoliageInstanceData_IsValid = GetLevelFoliageInstanceData_FunctionAddress != IntPtr.Zero && GetLevelFoliageInstanceData_Level_IsValid && GetLevelFoliageInstanceData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetLevelFoliageInstanceData", GetLevelFoliageInstanceData_IsValid);
		GetCullDistanceMin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCullDistanceMin");
		GetCullDistanceMin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCullDistanceMin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCullDistanceMin_Target_PropertyAddress, GetCullDistanceMin_FunctionAddress, "Target");
		GetCullDistanceMin_Target_Offset = NativeReflectionCached.GetPropertyOffset(GetCullDistanceMin_FunctionAddress, "Target");
		GetCullDistanceMin_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCullDistanceMin_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCullDistanceMin_ReturnValue_PropertyAddress, GetCullDistanceMin_FunctionAddress, "ReturnValue");
		GetCullDistanceMin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCullDistanceMin_FunctionAddress, "ReturnValue");
		GetCullDistanceMin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCullDistanceMin_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCullDistanceMin_IsValid = GetCullDistanceMin_FunctionAddress != IntPtr.Zero && GetCullDistanceMin_Target_IsValid && GetCullDistanceMin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetCullDistanceMin", GetCullDistanceMin_IsValid);
		GetCullDistanceMax_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCullDistanceMax");
		GetCullDistanceMax_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCullDistanceMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCullDistanceMax_Target_PropertyAddress, GetCullDistanceMax_FunctionAddress, "Target");
		GetCullDistanceMax_Target_Offset = NativeReflectionCached.GetPropertyOffset(GetCullDistanceMax_FunctionAddress, "Target");
		GetCullDistanceMax_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCullDistanceMax_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCullDistanceMax_ReturnValue_PropertyAddress, GetCullDistanceMax_FunctionAddress, "ReturnValue");
		GetCullDistanceMax_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCullDistanceMax_FunctionAddress, "ReturnValue");
		GetCullDistanceMax_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCullDistanceMax_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCullDistanceMax_IsValid = GetCullDistanceMax_FunctionAddress != IntPtr.Zero && GetCullDistanceMax_Target_IsValid && GetCullDistanceMax_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GetCullDistanceMax", GetCullDistanceMax_IsValid);
		GatherAllFoliageActorToMainLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GatherAllFoliageActorToMainLevel");
		GatherAllFoliageActorToMainLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherAllFoliageActorToMainLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GatherAllFoliageActorToMainLevel_MainLevel_PropertyAddress, GatherAllFoliageActorToMainLevel_FunctionAddress, "MainLevel");
		GatherAllFoliageActorToMainLevel_MainLevel_Offset = NativeReflectionCached.GetPropertyOffset(GatherAllFoliageActorToMainLevel_FunctionAddress, "MainLevel");
		GatherAllFoliageActorToMainLevel_MainLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherAllFoliageActorToMainLevel_FunctionAddress, "MainLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_PropertyAddress, GatherAllFoliageActorToMainLevel_FunctionAddress, "DestoryFoliageActorInTileLevel");
		GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_Offset = NativeReflectionCached.GetPropertyOffset(GatherAllFoliageActorToMainLevel_FunctionAddress, "DestoryFoliageActorInTileLevel");
		GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherAllFoliageActorToMainLevel_FunctionAddress, "DestoryFoliageActorInTileLevel", Classes.FBoolProperty);
		GatherAllFoliageActorToMainLevel_IsValid = GatherAllFoliageActorToMainLevel_FunctionAddress != IntPtr.Zero && GatherAllFoliageActorToMainLevel_MainLevel_IsValid && GatherAllFoliageActorToMainLevel_DestoryFoliageActorInTileLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorToMainLevel", GatherAllFoliageActorToMainLevel_IsValid);
		GatherAllFoliageActorToCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GatherAllFoliageActorToCurrentLevel");
		GatherAllFoliageActorToCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherAllFoliageActorToCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_PropertyAddress, GatherAllFoliageActorToCurrentLevel_FunctionAddress, "DestoryFoliageActorInTileLevel");
		GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_Offset = NativeReflectionCached.GetPropertyOffset(GatherAllFoliageActorToCurrentLevel_FunctionAddress, "DestoryFoliageActorInTileLevel");
		GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherAllFoliageActorToCurrentLevel_FunctionAddress, "DestoryFoliageActorInTileLevel", Classes.FBoolProperty);
		GatherAllFoliageActorToCurrentLevel_IsValid = GatherAllFoliageActorToCurrentLevel_FunctionAddress != IntPtr.Zero && GatherAllFoliageActorToCurrentLevel_DestoryFoliageActorInTileLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorToCurrentLevel", GatherAllFoliageActorToCurrentLevel_IsValid);
		GatherAllFoliageActorsToMainLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GatherAllFoliageActorsToMainLevels");
		GatherAllFoliageActorsToMainLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherAllFoliageActorsToMainLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_PropertyAddress, GatherAllFoliageActorsToMainLevels_FunctionAddress, "DestoryFoliageActorInTileLevel");
		GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_Offset = NativeReflectionCached.GetPropertyOffset(GatherAllFoliageActorsToMainLevels_FunctionAddress, "DestoryFoliageActorInTileLevel");
		GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherAllFoliageActorsToMainLevels_FunctionAddress, "DestoryFoliageActorInTileLevel", Classes.FBoolProperty);
		GatherAllFoliageActorsToMainLevels_IsValid = GatherAllFoliageActorsToMainLevels_FunctionAddress != IntPtr.Zero && GatherAllFoliageActorsToMainLevels_DestoryFoliageActorInTileLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:GatherAllFoliageActorsToMainLevels", GatherAllFoliageActorsToMainLevels_IsValid);
		FixFoliageComponentAttach_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixFoliageComponentAttach");
		FixFoliageComponentAttach_ParamsSize = NativeReflection.GetFunctionParamsSize(FixFoliageComponentAttach_FunctionAddress);
		FixFoliageComponentAttach_IsValid = FixFoliageComponentAttach_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:FixFoliageComponentAttach", FixFoliageComponentAttach_IsValid);
		FindComponentByFoliageType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindComponentByFoliageType");
		FindComponentByFoliageType_ParamsSize = NativeReflection.GetFunctionParamsSize(FindComponentByFoliageType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindComponentByFoliageType_InFoliageType_PropertyAddress, FindComponentByFoliageType_FunctionAddress, "InFoliageType");
		FindComponentByFoliageType_InFoliageType_Offset = NativeReflectionCached.GetPropertyOffset(FindComponentByFoliageType_FunctionAddress, "InFoliageType");
		FindComponentByFoliageType_InFoliageType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindComponentByFoliageType_FunctionAddress, "InFoliageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindComponentByFoliageType_ReturnValue_PropertyAddress, FindComponentByFoliageType_FunctionAddress, "ReturnValue");
		FindComponentByFoliageType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindComponentByFoliageType_FunctionAddress, "ReturnValue");
		FindComponentByFoliageType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindComponentByFoliageType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindComponentByFoliageType_IsValid = FindComponentByFoliageType_FunctionAddress != IntPtr.Zero && FindComponentByFoliageType_InFoliageType_IsValid && FindComponentByFoliageType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:FindComponentByFoliageType", FindComponentByFoliageType_IsValid);
		ConvertStaticMeshActorToFoliage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertStaticMeshActorToFoliage");
		ConvertStaticMeshActorToFoliage_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertStaticMeshActorToFoliage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertStaticMeshActorToFoliage_SelectedActor_PropertyAddress, ConvertStaticMeshActorToFoliage_FunctionAddress, "SelectedActor");
		ConvertStaticMeshActorToFoliage_SelectedActor_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStaticMeshActorToFoliage_FunctionAddress, "SelectedActor");
		ConvertStaticMeshActorToFoliage_SelectedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStaticMeshActorToFoliage_FunctionAddress, "SelectedActor", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertStaticMeshActorToFoliage_CanAddNewFoliage_PropertyAddress, ConvertStaticMeshActorToFoliage_FunctionAddress, "CanAddNewFoliage");
		ConvertStaticMeshActorToFoliage_CanAddNewFoliage_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStaticMeshActorToFoliage_FunctionAddress, "CanAddNewFoliage");
		ConvertStaticMeshActorToFoliage_CanAddNewFoliage_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStaticMeshActorToFoliage_FunctionAddress, "CanAddNewFoliage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertStaticMeshActorToFoliage_ReturnValue_PropertyAddress, ConvertStaticMeshActorToFoliage_FunctionAddress, "ReturnValue");
		ConvertStaticMeshActorToFoliage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStaticMeshActorToFoliage_FunctionAddress, "ReturnValue");
		ConvertStaticMeshActorToFoliage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStaticMeshActorToFoliage_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ConvertStaticMeshActorToFoliage_IsValid = ConvertStaticMeshActorToFoliage_FunctionAddress != IntPtr.Zero && ConvertStaticMeshActorToFoliage_SelectedActor_IsValid && ConvertStaticMeshActorToFoliage_CanAddNewFoliage_IsValid && ConvertStaticMeshActorToFoliage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:ConvertStaticMeshActorToFoliage", ConvertStaticMeshActorToFoliage_IsValid);
		CommandletCleanAllFoliageInstancesBaseID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CommandletCleanAllFoliageInstancesBaseID");
		CommandletCleanAllFoliageInstancesBaseID_ParamsSize = NativeReflection.GetFunctionParamsSize(CommandletCleanAllFoliageInstancesBaseID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CommandletCleanAllFoliageInstancesBaseID_Level_PropertyAddress, CommandletCleanAllFoliageInstancesBaseID_FunctionAddress, "Level");
		CommandletCleanAllFoliageInstancesBaseID_Level_Offset = NativeReflectionCached.GetPropertyOffset(CommandletCleanAllFoliageInstancesBaseID_FunctionAddress, "Level");
		CommandletCleanAllFoliageInstancesBaseID_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(CommandletCleanAllFoliageInstancesBaseID_FunctionAddress, "Level", Classes.FObjectProperty);
		CommandletCleanAllFoliageInstancesBaseID_IsValid = CommandletCleanAllFoliageInstancesBaseID_FunctionAddress != IntPtr.Zero && CommandletCleanAllFoliageInstancesBaseID_Level_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:CommandletCleanAllFoliageInstancesBaseID", CommandletCleanAllFoliageInstancesBaseID_IsValid);
		CleanAllFoliageInstancesBaseID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanAllFoliageInstancesBaseID");
		CleanAllFoliageInstancesBaseID_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanAllFoliageInstancesBaseID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CleanAllFoliageInstancesBaseID_Level_PropertyAddress, CleanAllFoliageInstancesBaseID_FunctionAddress, "Level");
		CleanAllFoliageInstancesBaseID_Level_Offset = NativeReflectionCached.GetPropertyOffset(CleanAllFoliageInstancesBaseID_FunctionAddress, "Level");
		CleanAllFoliageInstancesBaseID_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanAllFoliageInstancesBaseID_FunctionAddress, "Level", Classes.FObjectProperty);
		CleanAllFoliageInstancesBaseID_IsValid = CleanAllFoliageInstancesBaseID_FunctionAddress != IntPtr.Zero && CleanAllFoliageInstancesBaseID_Level_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorStaticMeshFoliageLibrary:CleanAllFoliageInstancesBaseID", CleanAllFoliageInstancesBaseID_IsValid);
	}
}
