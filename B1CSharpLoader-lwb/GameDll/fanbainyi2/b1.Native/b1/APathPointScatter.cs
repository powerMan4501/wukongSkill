using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.PathPointScatter", "FuncLibEditor", UnrealModuleType.Game)]
public class APathPointScatter : AActor
{
	private static bool EnableEditorTick_IsValid;

	private static FFieldAddress EnableEditorTick_PropertyAddress;

	private static int EnableEditorTick_Offset;

	private static bool ScatterPattern_IsValid;

	private static int ScatterPattern_Offset;

	private static bool ScatteredPoints_IsValid;

	private static FFieldAddress ScatteredPoints_PropertyAddress;

	private static int ScatteredPoints_Offset;

	private TArrayReadWriteMarshaler<FVector> ScatteredPoints_MarshalerCached;

	private static bool AdjustedPoints_IsValid;

	private static FFieldAddress AdjustedPoints_PropertyAddress;

	private static int AdjustedPoints_Offset;

	private TArrayReadWriteMarshaler<FVector> AdjustedPoints_MarshalerCached;

	private static bool FoundedNavmeshVolumes_IsValid;

	private static FFieldAddress FoundedNavmeshVolumes_PropertyAddress;

	private static int FoundedNavmeshVolumes_Offset;

	private TArrayReadWriteMarshaler<ANavMeshBoundsVolume> FoundedNavmeshVolumes_MarshalerCached;

	private static bool AdjustedPointDensity_IsValid;

	private static int AdjustedPointDensity_Offset;

	private static bool UpdateSortedPointsByIntensity_IsValid;

	private static IntPtr UpdateSortedPointsByIntensity_FunctionAddress;

	private static int UpdateSortedPointsByIntensity_ParamsSize;

	private static bool UpdateSortedPointsByIntensity_SortedPoints_IsValid;

	private static FFieldAddress UpdateSortedPointsByIntensity_SortedPoints_PropertyAddress;

	private static int UpdateSortedPointsByIntensity_SortedPoints_Offset;

	private static bool UpdateSortedPointsByIntensity_Intensity_IsValid;

	private static FFieldAddress UpdateSortedPointsByIntensity_Intensity_PropertyAddress;

	private static int UpdateSortedPointsByIntensity_Intensity_Offset;

	private static bool UpdateSortedPointsByIntensity_ReturnValue_IsValid;

	private static FFieldAddress UpdateSortedPointsByIntensity_ReturnValue_PropertyAddress;

	private static int UpdateSortedPointsByIntensity_ReturnValue_Offset;

	private static bool SortPointsFromFirstElem_IsValid;

	private static IntPtr SortPointsFromFirstElem_FunctionAddress;

	private static int SortPointsFromFirstElem_ParamsSize;

	private static bool SortPointsFromFirstElem_InPoints_IsValid;

	private static FFieldAddress SortPointsFromFirstElem_InPoints_PropertyAddress;

	private static int SortPointsFromFirstElem_InPoints_Offset;

	private static bool SortPointsFromFirstElem_OutPoints_IsValid;

	private static FFieldAddress SortPointsFromFirstElem_OutPoints_PropertyAddress;

	private static int SortPointsFromFirstElem_OutPoints_Offset;

	private static bool SortPointsByDistance_IsValid;

	private static IntPtr SortPointsByDistance_FunctionAddress;

	private static int SortPointsByDistance_ParamsSize;

	private static bool SortPointsByDistance_InPoints_IsValid;

	private static FFieldAddress SortPointsByDistance_InPoints_PropertyAddress;

	private static int SortPointsByDistance_InPoints_Offset;

	private static bool SortPointsByDistance_OutPoints_IsValid;

	private static FFieldAddress SortPointsByDistance_OutPoints_PropertyAddress;

	private static int SortPointsByDistance_OutPoints_Offset;

	private static bool SortPointsByDistance_InStartPoint_IsValid;

	private static FFieldAddress SortPointsByDistance_InStartPoint_PropertyAddress;

	private static int SortPointsByDistance_InStartPoint_Offset;

	private static bool SortPointsByDistance_bAscending_IsValid;

	private static FFieldAddress SortPointsByDistance_bAscending_PropertyAddress;

	private static int SortPointsByDistance_bAscending_Offset;

	private static bool ScatterAllNavmeshBoundsVolumesOfSubLevel_IsValid;

	private static IntPtr ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress;

	private static int ScatterAllNavmeshBoundsVolumesOfSubLevel_ParamsSize;

	private static bool ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_IsValid;

	private static FFieldAddress ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_PropertyAddress;

	private static int ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_Offset;

	private static bool ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_IsValid;

	private static FFieldAddress ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_PropertyAddress;

	private static int ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_Offset;

	private static bool ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_IsValid;

	private static FFieldAddress ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_PropertyAddress;

	private static int ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_Offset;

	private static bool ScatterActor_IsValid;

	private static IntPtr ScatterActor_FunctionAddress;

	private static int ScatterActor_ParamsSize;

	private static bool ScatterActor_InActor_IsValid;

	private static FFieldAddress ScatterActor_InActor_PropertyAddress;

	private static int ScatterActor_InActor_Offset;

	private static bool ScatterActor_InScatterPattern_IsValid;

	private static FFieldAddress ScatterActor_InScatterPattern_PropertyAddress;

	private static int ScatterActor_InScatterPattern_Offset;

	private static bool ScatterActor_ReturnValue_IsValid;

	private static FFieldAddress ScatterActor_ReturnValue_PropertyAddress;

	private static int ScatterActor_ReturnValue_Offset;

	private static bool IsPointWithinRange_IsValid;

	private static IntPtr IsPointWithinRange_FunctionAddress;

	private static int IsPointWithinRange_ParamsSize;

	private static bool IsPointWithinRange_InPoint_IsValid;

	private static FFieldAddress IsPointWithinRange_InPoint_PropertyAddress;

	private static int IsPointWithinRange_InPoint_Offset;

	private static bool IsPointWithinRange_InActor_IsValid;

	private static FFieldAddress IsPointWithinRange_InActor_PropertyAddress;

	private static int IsPointWithinRange_InActor_Offset;

	private static bool IsPointWithinRange_ReturnValue_IsValid;

	private static FFieldAddress IsPointWithinRange_ReturnValue_PropertyAddress;

	private static int IsPointWithinRange_ReturnValue_Offset;

	private static bool IsActorWithinScatterRange_IsValid;

	private static IntPtr IsActorWithinScatterRange_FunctionAddress;

	private static int IsActorWithinScatterRange_ParamsSize;

	private static bool IsActorWithinScatterRange_InActor_IsValid;

	private static FFieldAddress IsActorWithinScatterRange_InActor_PropertyAddress;

	private static int IsActorWithinScatterRange_InActor_Offset;

	private static bool IsActorWithinScatterRange_InScatterActor_IsValid;

	private static FFieldAddress IsActorWithinScatterRange_InScatterActor_PropertyAddress;

	private static int IsActorWithinScatterRange_InScatterActor_Offset;

	private static bool IsActorWithinScatterRange_ReturnValue_IsValid;

	private static FFieldAddress IsActorWithinScatterRange_ReturnValue_PropertyAddress;

	private static int IsActorWithinScatterRange_ReturnValue_Offset;

	private static bool IntensifySortedPoints_IsValid;

	private static IntPtr IntensifySortedPoints_FunctionAddress;

	private static int IntensifySortedPoints_ParamsSize;

	private static bool IntensifySortedPoints_SortedPoints_IsValid;

	private static FFieldAddress IntensifySortedPoints_SortedPoints_PropertyAddress;

	private static int IntensifySortedPoints_SortedPoints_Offset;

	private static bool IntensifySortedPoints_Intensity_IsValid;

	private static FFieldAddress IntensifySortedPoints_Intensity_PropertyAddress;

	private static int IntensifySortedPoints_Intensity_Offset;

	private static bool IntensifySortedPoints_ReturnValue_IsValid;

	private static FFieldAddress IntensifySortedPoints_ReturnValue_PropertyAddress;

	private static int IntensifySortedPoints_ReturnValue_Offset;

	private static bool FuseSortedPoints_IsValid;

	private static IntPtr FuseSortedPoints_FunctionAddress;

	private static int FuseSortedPoints_ParamsSize;

	private static bool FuseSortedPoints_SortedPoints_IsValid;

	private static FFieldAddress FuseSortedPoints_SortedPoints_PropertyAddress;

	private static int FuseSortedPoints_SortedPoints_Offset;

	private static bool FuseSortedPoints_MergeScale_IsValid;

	private static FFieldAddress FuseSortedPoints_MergeScale_PropertyAddress;

	private static int FuseSortedPoints_MergeScale_Offset;

	private static bool FuseSortedPoints_ReturnValue_IsValid;

	private static FFieldAddress FuseSortedPoints_ReturnValue_PropertyAddress;

	private static int FuseSortedPoints_ReturnValue_Offset;

	private static bool CullUnreachablePointsFromStart_IsValid;

	private static IntPtr CullUnreachablePointsFromStart_FunctionAddress;

	private static int CullUnreachablePointsFromStart_ParamsSize;

	private static bool CullUnreachablePointsFromStart_InFirstStartPoint_IsValid;

	private static FFieldAddress CullUnreachablePointsFromStart_InFirstStartPoint_PropertyAddress;

	private static int CullUnreachablePointsFromStart_InFirstStartPoint_Offset;

	private static bool CullUnreachablePointsFromStart_InNavigablePoints_IsValid;

	private static FFieldAddress CullUnreachablePointsFromStart_InNavigablePoints_PropertyAddress;

	private static int CullUnreachablePointsFromStart_InNavigablePoints_Offset;

	private static bool CullUnreachablePointsFromStart_ReturnValue_IsValid;

	private static FFieldAddress CullUnreachablePointsFromStart_ReturnValue_PropertyAddress;

	private static int CullUnreachablePointsFromStart_ReturnValue_Offset;

	private static bool CullUnNavigablePoints_IsValid;

	private static IntPtr CullUnNavigablePoints_FunctionAddress;

	private static int CullUnNavigablePoints_ParamsSize;

	private static bool CullUnNavigablePoints_InScatteredPoints_IsValid;

	private static FFieldAddress CullUnNavigablePoints_InScatteredPoints_PropertyAddress;

	private static int CullUnNavigablePoints_InScatteredPoints_Offset;

	private static bool CullUnNavigablePoints_InScatteringActor_IsValid;

	private static FFieldAddress CullUnNavigablePoints_InScatteringActor_PropertyAddress;

	private static int CullUnNavigablePoints_InScatteringActor_Offset;

	private static bool CullUnNavigablePoints_ReturnValue_IsValid;

	private static FFieldAddress CullUnNavigablePoints_ReturnValue_PropertyAddress;

	private static int CullUnNavigablePoints_ReturnValue_Offset;

	private static bool CullDuplicatesFromSortedPoints_IsValid;

	private static IntPtr CullDuplicatesFromSortedPoints_FunctionAddress;

	private static int CullDuplicatesFromSortedPoints_ParamsSize;

	private static bool CullDuplicatesFromSortedPoints_InSortedPoints_IsValid;

	private static FFieldAddress CullDuplicatesFromSortedPoints_InSortedPoints_PropertyAddress;

	private static int CullDuplicatesFromSortedPoints_InSortedPoints_Offset;

	private static bool CullDuplicatesFromSortedPoints_MinDist_IsValid;

	private static FFieldAddress CullDuplicatesFromSortedPoints_MinDist_PropertyAddress;

	private static int CullDuplicatesFromSortedPoints_MinDist_Offset;

	private static bool CullDuplicatesFromSortedPoints_MaxDist_IsValid;

	private static FFieldAddress CullDuplicatesFromSortedPoints_MaxDist_PropertyAddress;

	private static int CullDuplicatesFromSortedPoints_MaxDist_Offset;

	private static bool CullDuplicatesFromSortedPoints_ReturnValue_IsValid;

	private static FFieldAddress CullDuplicatesFromSortedPoints_ReturnValue_PropertyAddress;

	private static int CullDuplicatesFromSortedPoints_ReturnValue_Offset;

	private static bool CreatePointInstances_IsValid;

	private IntPtr CreatePointInstances_InstanceFunctionAddress;

	private static IntPtr CreatePointInstances_FunctionAddress;

	private static int CreatePointInstances_ParamsSize;

	private static bool CreatePointInstances_InPoints_IsValid;

	private static FFieldAddress CreatePointInstances_InPoints_PropertyAddress;

	private static int CreatePointInstances_InPoints_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV2_IsValid;

	private static IntPtr ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV2_ParamsSize;

	private static bool ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV2_InOffset_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV2_InOffset_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV2_InOffset_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV1_IsValid;

	private static IntPtr ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV1_ParamsSize;

	private static bool ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV1_InOffset_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV1_InOffset_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV1_InOffset_Offset;

	private static bool ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_IsValid;

	private static FFieldAddress ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_PropertyAddress;

	private static int ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:bEnableEditorTick")]
	public bool EnableEditorTick
	{
		get
		{
			CheckDestroyed();
			if (!EnableEditorTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:bEnableEditorTick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableEditorTick_Offset), 0, EnableEditorTick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableEditorTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:bEnableEditorTick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableEditorTick_Offset), 0, EnableEditorTick_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:ScatterPattern")]
	public FScatterPattern ScatterPattern
	{
		get
		{
			CheckDestroyed();
			if (!ScatterPattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:ScatterPattern");
				return default(FScatterPattern);
			}
			return FScatterPattern.FromNative(IntPtr.Add(base.Address, ScatterPattern_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScatterPattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:ScatterPattern");
			}
			else
			{
				FScatterPattern.ToNative(IntPtr.Add(base.Address, ScatterPattern_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:ScatteredPoints")]
	public TArrayReadWrite<FVector> ScatteredPoints
	{
		get
		{
			CheckDestroyed();
			if (!ScatteredPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:ScatteredPoints");
				return null;
			}
			if (ScatteredPoints_MarshalerCached == null)
			{
				ScatteredPoints_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, ScatteredPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return ScatteredPoints_MarshalerCached.FromNative(IntPtr.Add(base.Address, ScatteredPoints_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:AdjustedPoints")]
	public TArrayReadWrite<FVector> AdjustedPoints
	{
		get
		{
			CheckDestroyed();
			if (!AdjustedPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:AdjustedPoints");
				return null;
			}
			if (AdjustedPoints_MarshalerCached == null)
			{
				AdjustedPoints_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, AdjustedPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return AdjustedPoints_MarshalerCached.FromNative(IntPtr.Add(base.Address, AdjustedPoints_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:FoundedNavmeshVolumes")]
	public TArrayReadWrite<ANavMeshBoundsVolume> FoundedNavmeshVolumes
	{
		get
		{
			CheckDestroyed();
			if (!FoundedNavmeshVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:FoundedNavmeshVolumes");
				return null;
			}
			if (FoundedNavmeshVolumes_MarshalerCached == null)
			{
				FoundedNavmeshVolumes_MarshalerCached = new TArrayReadWriteMarshaler<ANavMeshBoundsVolume>(1, FoundedNavmeshVolumes_PropertyAddress, CachedMarshalingDelegates<ANavMeshBoundsVolume, UObjectMarshaler<ANavMeshBoundsVolume>>.FromNative, CachedMarshalingDelegates<ANavMeshBoundsVolume, UObjectMarshaler<ANavMeshBoundsVolume>>.ToNative);
			}
			return FoundedNavmeshVolumes_MarshalerCached.FromNative(IntPtr.Add(base.Address, FoundedNavmeshVolumes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:AdjustedPointDensity")]
	public int AdjustedPointDensity
	{
		get
		{
			CheckDestroyed();
			if (!AdjustedPointDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:AdjustedPointDensity");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AdjustedPointDensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustedPointDensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.PathPointScatter:AdjustedPointDensity");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AdjustedPointDensity_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:UpdateSortedPointsByIntensity")]
	public unsafe List<FVector> UpdateSortedPointsByIntensity(List<FVector> SortedPoints, int Intensity)
	{
		CheckDestroyed();
		if (!UpdateSortedPointsByIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:UpdateSortedPointsByIntensity");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateSortedPointsByIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateSortedPointsByIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, UpdateSortedPointsByIntensity_SortedPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateSortedPointsByIntensity_SortedPoints_Offset), SortedPoints);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UpdateSortedPointsByIntensity_Intensity_Offset), 0, UpdateSortedPointsByIntensity_Intensity_PropertyAddress.Address, Intensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateSortedPointsByIntensity_FunctionAddress, intPtr, UpdateSortedPointsByIntensity_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateSortedPointsByIntensity_SortedPoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, UpdateSortedPointsByIntensity_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, UpdateSortedPointsByIntensity_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(UpdateSortedPointsByIntensity_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:SortPointsFromFirstElem")]
	public unsafe void SortPointsFromFirstElem(ref List<FVector> InPoints, out List<FVector> OutPoints)
	{
		CheckDestroyed();
		if (!SortPointsFromFirstElem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:SortPointsFromFirstElem");
			OutPoints = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortPointsFromFirstElem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortPointsFromFirstElem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FVector> tArrayCopyMarshaler = new TArrayCopyMarshaler<FVector>(1, SortPointsFromFirstElem_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, SortPointsFromFirstElem_InPoints_Offset), InPoints);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortPointsFromFirstElem_FunctionAddress, intPtr, SortPointsFromFirstElem_ParamsSize);
		InPoints = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, SortPointsFromFirstElem_InPoints_Offset));
		NativeReflection.DestroyValue_InContainer(SortPointsFromFirstElem_InPoints_PropertyAddress.Address, intPtr);
		OutPoints = new TArrayCopyMarshaler<FVector>(1, SortPointsFromFirstElem_OutPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, SortPointsFromFirstElem_OutPoints_Offset));
		NativeReflection.DestroyValue_InContainer(SortPointsFromFirstElem_OutPoints_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:SortPointsByDistance")]
	public unsafe void SortPointsByDistance(ref List<FVector> InPoints, out List<FVector> OutPoints, FVector InStartPoint, bool bAscending = true)
	{
		CheckDestroyed();
		if (!SortPointsByDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:SortPointsByDistance");
			OutPoints = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortPointsByDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortPointsByDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FVector> tArrayCopyMarshaler = new TArrayCopyMarshaler<FVector>(1, SortPointsByDistance_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, SortPointsByDistance_InPoints_Offset), InPoints);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SortPointsByDistance_InStartPoint_Offset), 0, SortPointsByDistance_InStartPoint_PropertyAddress.Address, InStartPoint);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SortPointsByDistance_bAscending_Offset), 0, SortPointsByDistance_bAscending_PropertyAddress.Address, bAscending);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortPointsByDistance_FunctionAddress, intPtr, SortPointsByDistance_ParamsSize);
		InPoints = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, SortPointsByDistance_InPoints_Offset));
		NativeReflection.DestroyValue_InContainer(SortPointsByDistance_InPoints_PropertyAddress.Address, intPtr);
		OutPoints = new TArrayCopyMarshaler<FVector>(1, SortPointsByDistance_OutPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, SortPointsByDistance_OutPoints_Offset));
		NativeReflection.DestroyValue_InContainer(SortPointsByDistance_OutPoints_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:ScatterAllNavmeshBoundsVolumesOfSubLevel")]
	public unsafe List<FVector> ScatterAllNavmeshBoundsVolumesOfSubLevel(FScatterStartPointsOfEachStreamingLevel InLevelScatterStartPoints, FScatterPattern InScatterPattern)
	{
		CheckDestroyed();
		if (!ScatterAllNavmeshBoundsVolumesOfSubLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:ScatterAllNavmeshBoundsVolumesOfSubLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScatterAllNavmeshBoundsVolumesOfSubLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScatterAllNavmeshBoundsVolumesOfSubLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_PropertyAddress.Address, intPtr);
		FScatterStartPointsOfEachStreamingLevel.ToNative(IntPtr.Add(intPtr, ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_Offset), 0, ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_PropertyAddress.Address, InLevelScatterStartPoints);
		NativeReflection.InitializeValue_InContainer(ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_PropertyAddress.Address, intPtr);
		FScatterPattern.ToNative(IntPtr.Add(intPtr, ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_Offset), 0, ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_PropertyAddress.Address, InScatterPattern);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, intPtr, ScatterAllNavmeshBoundsVolumesOfSubLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:ScatterActor")]
	public unsafe List<FVector> ScatterActor(AActor InActor, FScatterPattern InScatterPattern)
	{
		CheckDestroyed();
		if (!ScatterActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:ScatterActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScatterActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScatterActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ScatterActor_InActor_Offset), 0, ScatterActor_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InitializeValue_InContainer(ScatterActor_InScatterPattern_PropertyAddress.Address, intPtr);
		FScatterPattern.ToNative(IntPtr.Add(intPtr, ScatterActor_InScatterPattern_Offset), 0, ScatterActor_InScatterPattern_PropertyAddress.Address, InScatterPattern);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScatterActor_FunctionAddress, intPtr, ScatterActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScatterActor_InScatterPattern_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, ScatterActor_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ScatterActor_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ScatterActor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:IsPointWithinRange")]
	public unsafe bool IsPointWithinRange(FVector InPoint, AActor InActor)
	{
		CheckDestroyed();
		if (!IsPointWithinRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:IsPointWithinRange");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPointWithinRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPointWithinRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsPointWithinRange_InPoint_Offset), 0, IsPointWithinRange_InPoint_PropertyAddress.Address, InPoint);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsPointWithinRange_InActor_Offset), 0, IsPointWithinRange_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPointWithinRange_FunctionAddress, intPtr, IsPointWithinRange_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPointWithinRange_ReturnValue_Offset), 0, IsPointWithinRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:IsActorWithinScatterRange")]
	public unsafe bool IsActorWithinScatterRange(AActor InActor, AActor InScatterActor)
	{
		CheckDestroyed();
		if (!IsActorWithinScatterRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:IsActorWithinScatterRange");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActorWithinScatterRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActorWithinScatterRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsActorWithinScatterRange_InActor_Offset), 0, IsActorWithinScatterRange_InActor_PropertyAddress.Address, InActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsActorWithinScatterRange_InScatterActor_Offset), 0, IsActorWithinScatterRange_InScatterActor_PropertyAddress.Address, InScatterActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActorWithinScatterRange_FunctionAddress, intPtr, IsActorWithinScatterRange_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActorWithinScatterRange_ReturnValue_Offset), 0, IsActorWithinScatterRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:IntensifySortedPoints")]
	public unsafe List<FVector> IntensifySortedPoints(List<FVector> SortedPoints, byte Intensity = 1)
	{
		CheckDestroyed();
		if (!IntensifySortedPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:IntensifySortedPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntensifySortedPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntensifySortedPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, IntensifySortedPoints_SortedPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, IntensifySortedPoints_SortedPoints_Offset), SortedPoints);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, IntensifySortedPoints_Intensity_Offset), 0, IntensifySortedPoints_Intensity_PropertyAddress.Address, Intensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, IntensifySortedPoints_FunctionAddress, intPtr, IntensifySortedPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IntensifySortedPoints_SortedPoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, IntensifySortedPoints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, IntensifySortedPoints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(IntensifySortedPoints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:FuseSortedPoints")]
	public unsafe List<FVector> FuseSortedPoints(List<FVector> SortedPoints, byte MergeScale = 1)
	{
		CheckDestroyed();
		if (!FuseSortedPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:FuseSortedPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FuseSortedPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FuseSortedPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, FuseSortedPoints_SortedPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, FuseSortedPoints_SortedPoints_Offset), SortedPoints);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, FuseSortedPoints_MergeScale_Offset), 0, FuseSortedPoints_MergeScale_PropertyAddress.Address, MergeScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, FuseSortedPoints_FunctionAddress, intPtr, FuseSortedPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FuseSortedPoints_SortedPoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, FuseSortedPoints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, FuseSortedPoints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FuseSortedPoints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:CullUnreachablePointsFromStart")]
	public unsafe List<FVector> CullUnreachablePointsFromStart(FVector InFirstStartPoint, List<FVector> InNavigablePoints)
	{
		CheckDestroyed();
		if (!CullUnreachablePointsFromStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:CullUnreachablePointsFromStart");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CullUnreachablePointsFromStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CullUnreachablePointsFromStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CullUnreachablePointsFromStart_InFirstStartPoint_Offset), 0, CullUnreachablePointsFromStart_InFirstStartPoint_PropertyAddress.Address, InFirstStartPoint);
		new TArrayCopyMarshaler<FVector>(1, CullUnreachablePointsFromStart_InNavigablePoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CullUnreachablePointsFromStart_InNavigablePoints_Offset), InNavigablePoints);
		NativeReflection.InvokeFunctionOptimized(base.Address, CullUnreachablePointsFromStart_FunctionAddress, intPtr, CullUnreachablePointsFromStart_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CullUnreachablePointsFromStart_InNavigablePoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, CullUnreachablePointsFromStart_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, CullUnreachablePointsFromStart_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CullUnreachablePointsFromStart_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:CullUnNavigablePoints")]
	public unsafe List<FVector> CullUnNavigablePoints(List<FVector> InScatteredPoints, AActor InScatteringActor)
	{
		CheckDestroyed();
		if (!CullUnNavigablePoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:CullUnNavigablePoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CullUnNavigablePoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CullUnNavigablePoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, CullUnNavigablePoints_InScatteredPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CullUnNavigablePoints_InScatteredPoints_Offset), InScatteredPoints);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CullUnNavigablePoints_InScatteringActor_Offset), 0, CullUnNavigablePoints_InScatteringActor_PropertyAddress.Address, InScatteringActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, CullUnNavigablePoints_FunctionAddress, intPtr, CullUnNavigablePoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CullUnNavigablePoints_InScatteredPoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, CullUnNavigablePoints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, CullUnNavigablePoints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CullUnNavigablePoints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:CullDuplicatesFromSortedPoints")]
	public unsafe List<FVector> CullDuplicatesFromSortedPoints(List<FVector> InSortedPoints, float MinDist = 10f, float MaxDist = 10000f)
	{
		CheckDestroyed();
		if (!CullDuplicatesFromSortedPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:CullDuplicatesFromSortedPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CullDuplicatesFromSortedPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CullDuplicatesFromSortedPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, CullDuplicatesFromSortedPoints_InSortedPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CullDuplicatesFromSortedPoints_InSortedPoints_Offset), InSortedPoints);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CullDuplicatesFromSortedPoints_MinDist_Offset), 0, CullDuplicatesFromSortedPoints_MinDist_PropertyAddress.Address, MinDist);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CullDuplicatesFromSortedPoints_MaxDist_Offset), 0, CullDuplicatesFromSortedPoints_MaxDist_PropertyAddress.Address, MaxDist);
		NativeReflection.InvokeFunctionOptimized(base.Address, CullDuplicatesFromSortedPoints_FunctionAddress, intPtr, CullDuplicatesFromSortedPoints_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CullDuplicatesFromSortedPoints_InSortedPoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, CullDuplicatesFromSortedPoints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, CullDuplicatesFromSortedPoints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CullDuplicatesFromSortedPoints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:CreatePointInstances")]
	public unsafe void CreatePointInstances(List<FVector> InPoints)
	{
		CheckDestroyed();
		if (!CreatePointInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:CreatePointInstances");
			return;
		}
		if (CreatePointInstances_InstanceFunctionAddress == IntPtr.Zero)
		{
			CreatePointInstances_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CreatePointInstances");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePointInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePointInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, CreatePointInstances_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CreatePointInstances_InPoints_Offset), InPoints);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePointInstances_InstanceFunctionAddress, intPtr, CreatePointInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreatePointInstances_InPoints_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void CreatePointInstances_Implementation(List<FVector> InPoints)
	{
		CheckDestroyed();
		if (!CreatePointInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:CreatePointInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePointInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePointInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, CreatePointInstances_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CreatePointInstances_InPoints_Offset), InPoints);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePointInstances_FunctionAddress, intPtr, CreatePointInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreatePointInstances_InPoints_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:ConvertScatteredPointsToNavmeshPointsV2")]
	public unsafe List<FVector> ConvertScatteredPointsToNavmeshPointsV2(List<FVector> InScatteredPoints, ARecastNavMesh InRecastNavmesh, FVector InQueryExtent, FVector InOffset)
	{
		CheckDestroyed();
		if (!ConvertScatteredPointsToNavmeshPointsV2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:ConvertScatteredPointsToNavmeshPointsV2");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertScatteredPointsToNavmeshPointsV2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertScatteredPointsToNavmeshPointsV2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_Offset), InScatteredPoints);
		UObjectMarshaler<ARecastNavMesh>.ToNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_Offset), 0, ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_PropertyAddress.Address, InRecastNavmesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_Offset), 0, ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_PropertyAddress.Address, InQueryExtent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV2_InOffset_Offset), 0, ConvertScatteredPointsToNavmeshPointsV2_InOffset_PropertyAddress.Address, InOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, intPtr, ConvertScatteredPointsToNavmeshPointsV2_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FuncLibEditor.PathPointScatter:ConvertScatteredPointsToNavmeshPointsV1")]
	public unsafe List<FVector> ConvertScatteredPointsToNavmeshPointsV1(List<FVector> InScatteredPoints, FVector InQueryExtent, FVector InOffset)
	{
		CheckDestroyed();
		if (!ConvertScatteredPointsToNavmeshPointsV1_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.PathPointScatter:ConvertScatteredPointsToNavmeshPointsV1");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertScatteredPointsToNavmeshPointsV1_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertScatteredPointsToNavmeshPointsV1_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_Offset), InScatteredPoints);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_Offset), 0, ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_PropertyAddress.Address, InQueryExtent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV1_InOffset_Offset), 0, ConvertScatteredPointsToNavmeshPointsV1_InOffset_PropertyAddress.Address, InOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, intPtr, ConvertScatteredPointsToNavmeshPointsV1_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static APathPointScatter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APathPointScatter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APathPointScatter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.PathPointScatter");
		NativeReflectionCached.GetPropertyRef(ref EnableEditorTick_PropertyAddress, intPtr, "bEnableEditorTick");
		EnableEditorTick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableEditorTick");
		EnableEditorTick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableEditorTick", Classes.FBoolProperty);
		ScatterPattern_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatterPattern");
		ScatterPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatterPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatteredPoints_PropertyAddress, intPtr, "ScatteredPoints");
		ScatteredPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScatteredPoints");
		ScatteredPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScatteredPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AdjustedPoints_PropertyAddress, intPtr, "AdjustedPoints");
		AdjustedPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdjustedPoints");
		AdjustedPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdjustedPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FoundedNavmeshVolumes_PropertyAddress, intPtr, "FoundedNavmeshVolumes");
		FoundedNavmeshVolumes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FoundedNavmeshVolumes");
		FoundedNavmeshVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FoundedNavmeshVolumes", Classes.FArrayProperty);
		AdjustedPointDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdjustedPointDensity");
		AdjustedPointDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdjustedPointDensity", Classes.FIntProperty);
		UpdateSortedPointsByIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSortedPointsByIntensity");
		UpdateSortedPointsByIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSortedPointsByIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateSortedPointsByIntensity_SortedPoints_PropertyAddress, UpdateSortedPointsByIntensity_FunctionAddress, "SortedPoints");
		UpdateSortedPointsByIntensity_SortedPoints_Offset = NativeReflectionCached.GetPropertyOffset(UpdateSortedPointsByIntensity_FunctionAddress, "SortedPoints");
		UpdateSortedPointsByIntensity_SortedPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateSortedPointsByIntensity_FunctionAddress, "SortedPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateSortedPointsByIntensity_Intensity_PropertyAddress, UpdateSortedPointsByIntensity_FunctionAddress, "Intensity");
		UpdateSortedPointsByIntensity_Intensity_Offset = NativeReflectionCached.GetPropertyOffset(UpdateSortedPointsByIntensity_FunctionAddress, "Intensity");
		UpdateSortedPointsByIntensity_Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateSortedPointsByIntensity_FunctionAddress, "Intensity", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateSortedPointsByIntensity_ReturnValue_PropertyAddress, UpdateSortedPointsByIntensity_FunctionAddress, "ReturnValue");
		UpdateSortedPointsByIntensity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UpdateSortedPointsByIntensity_FunctionAddress, "ReturnValue");
		UpdateSortedPointsByIntensity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateSortedPointsByIntensity_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		UpdateSortedPointsByIntensity_IsValid = UpdateSortedPointsByIntensity_FunctionAddress != IntPtr.Zero && UpdateSortedPointsByIntensity_SortedPoints_IsValid && UpdateSortedPointsByIntensity_Intensity_IsValid && UpdateSortedPointsByIntensity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:UpdateSortedPointsByIntensity", UpdateSortedPointsByIntensity_IsValid);
		SortPointsFromFirstElem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SortPointsFromFirstElem");
		SortPointsFromFirstElem_ParamsSize = NativeReflection.GetFunctionParamsSize(SortPointsFromFirstElem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortPointsFromFirstElem_InPoints_PropertyAddress, SortPointsFromFirstElem_FunctionAddress, "InPoints");
		SortPointsFromFirstElem_InPoints_Offset = NativeReflectionCached.GetPropertyOffset(SortPointsFromFirstElem_FunctionAddress, "InPoints");
		SortPointsFromFirstElem_InPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SortPointsFromFirstElem_FunctionAddress, "InPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortPointsFromFirstElem_OutPoints_PropertyAddress, SortPointsFromFirstElem_FunctionAddress, "OutPoints");
		SortPointsFromFirstElem_OutPoints_Offset = NativeReflectionCached.GetPropertyOffset(SortPointsFromFirstElem_FunctionAddress, "OutPoints");
		SortPointsFromFirstElem_OutPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SortPointsFromFirstElem_FunctionAddress, "OutPoints", Classes.FArrayProperty);
		SortPointsFromFirstElem_IsValid = SortPointsFromFirstElem_FunctionAddress != IntPtr.Zero && SortPointsFromFirstElem_InPoints_IsValid && SortPointsFromFirstElem_OutPoints_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:SortPointsFromFirstElem", SortPointsFromFirstElem_IsValid);
		SortPointsByDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SortPointsByDistance");
		SortPointsByDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SortPointsByDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortPointsByDistance_InPoints_PropertyAddress, SortPointsByDistance_FunctionAddress, "InPoints");
		SortPointsByDistance_InPoints_Offset = NativeReflectionCached.GetPropertyOffset(SortPointsByDistance_FunctionAddress, "InPoints");
		SortPointsByDistance_InPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SortPointsByDistance_FunctionAddress, "InPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortPointsByDistance_OutPoints_PropertyAddress, SortPointsByDistance_FunctionAddress, "OutPoints");
		SortPointsByDistance_OutPoints_Offset = NativeReflectionCached.GetPropertyOffset(SortPointsByDistance_FunctionAddress, "OutPoints");
		SortPointsByDistance_OutPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(SortPointsByDistance_FunctionAddress, "OutPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortPointsByDistance_InStartPoint_PropertyAddress, SortPointsByDistance_FunctionAddress, "InStartPoint");
		SortPointsByDistance_InStartPoint_Offset = NativeReflectionCached.GetPropertyOffset(SortPointsByDistance_FunctionAddress, "InStartPoint");
		SortPointsByDistance_InStartPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SortPointsByDistance_FunctionAddress, "InStartPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SortPointsByDistance_bAscending_PropertyAddress, SortPointsByDistance_FunctionAddress, "bAscending");
		SortPointsByDistance_bAscending_Offset = NativeReflectionCached.GetPropertyOffset(SortPointsByDistance_FunctionAddress, "bAscending");
		SortPointsByDistance_bAscending_IsValid = NativeReflectionCached.ValidatePropertyClass(SortPointsByDistance_FunctionAddress, "bAscending", Classes.FBoolProperty);
		SortPointsByDistance_IsValid = SortPointsByDistance_FunctionAddress != IntPtr.Zero && SortPointsByDistance_InPoints_IsValid && SortPointsByDistance_OutPoints_IsValid && SortPointsByDistance_InStartPoint_IsValid && SortPointsByDistance_bAscending_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:SortPointsByDistance", SortPointsByDistance_IsValid);
		ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScatterAllNavmeshBoundsVolumesOfSubLevel");
		ScatterAllNavmeshBoundsVolumesOfSubLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_PropertyAddress, ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "InLevelScatterStartPoints");
		ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_Offset = NativeReflectionCached.GetPropertyOffset(ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "InLevelScatterStartPoints");
		ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "InLevelScatterStartPoints", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_PropertyAddress, ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "InScatterPattern");
		ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_Offset = NativeReflectionCached.GetPropertyOffset(ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "InScatterPattern");
		ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "InScatterPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_PropertyAddress, ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "ReturnValue");
		ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "ReturnValue");
		ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ScatterAllNavmeshBoundsVolumesOfSubLevel_IsValid = ScatterAllNavmeshBoundsVolumesOfSubLevel_FunctionAddress != IntPtr.Zero && ScatterAllNavmeshBoundsVolumesOfSubLevel_InLevelScatterStartPoints_IsValid && ScatterAllNavmeshBoundsVolumesOfSubLevel_InScatterPattern_IsValid && ScatterAllNavmeshBoundsVolumesOfSubLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:ScatterAllNavmeshBoundsVolumesOfSubLevel", ScatterAllNavmeshBoundsVolumesOfSubLevel_IsValid);
		ScatterActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScatterActor");
		ScatterActor_ParamsSize = NativeReflection.GetFunctionParamsSize(ScatterActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScatterActor_InActor_PropertyAddress, ScatterActor_FunctionAddress, "InActor");
		ScatterActor_InActor_Offset = NativeReflectionCached.GetPropertyOffset(ScatterActor_FunctionAddress, "InActor");
		ScatterActor_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterActor_InScatterPattern_PropertyAddress, ScatterActor_FunctionAddress, "InScatterPattern");
		ScatterActor_InScatterPattern_Offset = NativeReflectionCached.GetPropertyOffset(ScatterActor_FunctionAddress, "InScatterPattern");
		ScatterActor_InScatterPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterActor_FunctionAddress, "InScatterPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterActor_ReturnValue_PropertyAddress, ScatterActor_FunctionAddress, "ReturnValue");
		ScatterActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScatterActor_FunctionAddress, "ReturnValue");
		ScatterActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScatterActor_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ScatterActor_IsValid = ScatterActor_FunctionAddress != IntPtr.Zero && ScatterActor_InActor_IsValid && ScatterActor_InScatterPattern_IsValid && ScatterActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:ScatterActor", ScatterActor_IsValid);
		IsPointWithinRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPointWithinRange");
		IsPointWithinRange_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPointWithinRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPointWithinRange_InPoint_PropertyAddress, IsPointWithinRange_FunctionAddress, "InPoint");
		IsPointWithinRange_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(IsPointWithinRange_FunctionAddress, "InPoint");
		IsPointWithinRange_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointWithinRange_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointWithinRange_InActor_PropertyAddress, IsPointWithinRange_FunctionAddress, "InActor");
		IsPointWithinRange_InActor_Offset = NativeReflectionCached.GetPropertyOffset(IsPointWithinRange_FunctionAddress, "InActor");
		IsPointWithinRange_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointWithinRange_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPointWithinRange_ReturnValue_PropertyAddress, IsPointWithinRange_FunctionAddress, "ReturnValue");
		IsPointWithinRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPointWithinRange_FunctionAddress, "ReturnValue");
		IsPointWithinRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPointWithinRange_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPointWithinRange_IsValid = IsPointWithinRange_FunctionAddress != IntPtr.Zero && IsPointWithinRange_InPoint_IsValid && IsPointWithinRange_InActor_IsValid && IsPointWithinRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:IsPointWithinRange", IsPointWithinRange_IsValid);
		IsActorWithinScatterRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsActorWithinScatterRange");
		IsActorWithinScatterRange_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActorWithinScatterRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActorWithinScatterRange_InActor_PropertyAddress, IsActorWithinScatterRange_FunctionAddress, "InActor");
		IsActorWithinScatterRange_InActor_Offset = NativeReflectionCached.GetPropertyOffset(IsActorWithinScatterRange_FunctionAddress, "InActor");
		IsActorWithinScatterRange_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorWithinScatterRange_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActorWithinScatterRange_InScatterActor_PropertyAddress, IsActorWithinScatterRange_FunctionAddress, "InScatterActor");
		IsActorWithinScatterRange_InScatterActor_Offset = NativeReflectionCached.GetPropertyOffset(IsActorWithinScatterRange_FunctionAddress, "InScatterActor");
		IsActorWithinScatterRange_InScatterActor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorWithinScatterRange_FunctionAddress, "InScatterActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActorWithinScatterRange_ReturnValue_PropertyAddress, IsActorWithinScatterRange_FunctionAddress, "ReturnValue");
		IsActorWithinScatterRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActorWithinScatterRange_FunctionAddress, "ReturnValue");
		IsActorWithinScatterRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorWithinScatterRange_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActorWithinScatterRange_IsValid = IsActorWithinScatterRange_FunctionAddress != IntPtr.Zero && IsActorWithinScatterRange_InActor_IsValid && IsActorWithinScatterRange_InScatterActor_IsValid && IsActorWithinScatterRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:IsActorWithinScatterRange", IsActorWithinScatterRange_IsValid);
		IntensifySortedPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IntensifySortedPoints");
		IntensifySortedPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(IntensifySortedPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IntensifySortedPoints_SortedPoints_PropertyAddress, IntensifySortedPoints_FunctionAddress, "SortedPoints");
		IntensifySortedPoints_SortedPoints_Offset = NativeReflectionCached.GetPropertyOffset(IntensifySortedPoints_FunctionAddress, "SortedPoints");
		IntensifySortedPoints_SortedPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(IntensifySortedPoints_FunctionAddress, "SortedPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IntensifySortedPoints_Intensity_PropertyAddress, IntensifySortedPoints_FunctionAddress, "Intensity");
		IntensifySortedPoints_Intensity_Offset = NativeReflectionCached.GetPropertyOffset(IntensifySortedPoints_FunctionAddress, "Intensity");
		IntensifySortedPoints_Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(IntensifySortedPoints_FunctionAddress, "Intensity", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref IntensifySortedPoints_ReturnValue_PropertyAddress, IntensifySortedPoints_FunctionAddress, "ReturnValue");
		IntensifySortedPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IntensifySortedPoints_FunctionAddress, "ReturnValue");
		IntensifySortedPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IntensifySortedPoints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		IntensifySortedPoints_IsValid = IntensifySortedPoints_FunctionAddress != IntPtr.Zero && IntensifySortedPoints_SortedPoints_IsValid && IntensifySortedPoints_Intensity_IsValid && IntensifySortedPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:IntensifySortedPoints", IntensifySortedPoints_IsValid);
		FuseSortedPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FuseSortedPoints");
		FuseSortedPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(FuseSortedPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FuseSortedPoints_SortedPoints_PropertyAddress, FuseSortedPoints_FunctionAddress, "SortedPoints");
		FuseSortedPoints_SortedPoints_Offset = NativeReflectionCached.GetPropertyOffset(FuseSortedPoints_FunctionAddress, "SortedPoints");
		FuseSortedPoints_SortedPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(FuseSortedPoints_FunctionAddress, "SortedPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FuseSortedPoints_MergeScale_PropertyAddress, FuseSortedPoints_FunctionAddress, "MergeScale");
		FuseSortedPoints_MergeScale_Offset = NativeReflectionCached.GetPropertyOffset(FuseSortedPoints_FunctionAddress, "MergeScale");
		FuseSortedPoints_MergeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(FuseSortedPoints_FunctionAddress, "MergeScale", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FuseSortedPoints_ReturnValue_PropertyAddress, FuseSortedPoints_FunctionAddress, "ReturnValue");
		FuseSortedPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FuseSortedPoints_FunctionAddress, "ReturnValue");
		FuseSortedPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FuseSortedPoints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FuseSortedPoints_IsValid = FuseSortedPoints_FunctionAddress != IntPtr.Zero && FuseSortedPoints_SortedPoints_IsValid && FuseSortedPoints_MergeScale_IsValid && FuseSortedPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:FuseSortedPoints", FuseSortedPoints_IsValid);
		CullUnreachablePointsFromStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CullUnreachablePointsFromStart");
		CullUnreachablePointsFromStart_ParamsSize = NativeReflection.GetFunctionParamsSize(CullUnreachablePointsFromStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CullUnreachablePointsFromStart_InFirstStartPoint_PropertyAddress, CullUnreachablePointsFromStart_FunctionAddress, "InFirstStartPoint");
		CullUnreachablePointsFromStart_InFirstStartPoint_Offset = NativeReflectionCached.GetPropertyOffset(CullUnreachablePointsFromStart_FunctionAddress, "InFirstStartPoint");
		CullUnreachablePointsFromStart_InFirstStartPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(CullUnreachablePointsFromStart_FunctionAddress, "InFirstStartPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CullUnreachablePointsFromStart_InNavigablePoints_PropertyAddress, CullUnreachablePointsFromStart_FunctionAddress, "InNavigablePoints");
		CullUnreachablePointsFromStart_InNavigablePoints_Offset = NativeReflectionCached.GetPropertyOffset(CullUnreachablePointsFromStart_FunctionAddress, "InNavigablePoints");
		CullUnreachablePointsFromStart_InNavigablePoints_IsValid = NativeReflectionCached.ValidatePropertyClass(CullUnreachablePointsFromStart_FunctionAddress, "InNavigablePoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CullUnreachablePointsFromStart_ReturnValue_PropertyAddress, CullUnreachablePointsFromStart_FunctionAddress, "ReturnValue");
		CullUnreachablePointsFromStart_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CullUnreachablePointsFromStart_FunctionAddress, "ReturnValue");
		CullUnreachablePointsFromStart_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CullUnreachablePointsFromStart_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CullUnreachablePointsFromStart_IsValid = CullUnreachablePointsFromStart_FunctionAddress != IntPtr.Zero && CullUnreachablePointsFromStart_InFirstStartPoint_IsValid && CullUnreachablePointsFromStart_InNavigablePoints_IsValid && CullUnreachablePointsFromStart_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:CullUnreachablePointsFromStart", CullUnreachablePointsFromStart_IsValid);
		CullUnNavigablePoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CullUnNavigablePoints");
		CullUnNavigablePoints_ParamsSize = NativeReflection.GetFunctionParamsSize(CullUnNavigablePoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CullUnNavigablePoints_InScatteredPoints_PropertyAddress, CullUnNavigablePoints_FunctionAddress, "InScatteredPoints");
		CullUnNavigablePoints_InScatteredPoints_Offset = NativeReflectionCached.GetPropertyOffset(CullUnNavigablePoints_FunctionAddress, "InScatteredPoints");
		CullUnNavigablePoints_InScatteredPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(CullUnNavigablePoints_FunctionAddress, "InScatteredPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CullUnNavigablePoints_InScatteringActor_PropertyAddress, CullUnNavigablePoints_FunctionAddress, "InScatteringActor");
		CullUnNavigablePoints_InScatteringActor_Offset = NativeReflectionCached.GetPropertyOffset(CullUnNavigablePoints_FunctionAddress, "InScatteringActor");
		CullUnNavigablePoints_InScatteringActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CullUnNavigablePoints_FunctionAddress, "InScatteringActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CullUnNavigablePoints_ReturnValue_PropertyAddress, CullUnNavigablePoints_FunctionAddress, "ReturnValue");
		CullUnNavigablePoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CullUnNavigablePoints_FunctionAddress, "ReturnValue");
		CullUnNavigablePoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CullUnNavigablePoints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CullUnNavigablePoints_IsValid = CullUnNavigablePoints_FunctionAddress != IntPtr.Zero && CullUnNavigablePoints_InScatteredPoints_IsValid && CullUnNavigablePoints_InScatteringActor_IsValid && CullUnNavigablePoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:CullUnNavigablePoints", CullUnNavigablePoints_IsValid);
		CullDuplicatesFromSortedPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CullDuplicatesFromSortedPoints");
		CullDuplicatesFromSortedPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(CullDuplicatesFromSortedPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CullDuplicatesFromSortedPoints_InSortedPoints_PropertyAddress, CullDuplicatesFromSortedPoints_FunctionAddress, "InSortedPoints");
		CullDuplicatesFromSortedPoints_InSortedPoints_Offset = NativeReflectionCached.GetPropertyOffset(CullDuplicatesFromSortedPoints_FunctionAddress, "InSortedPoints");
		CullDuplicatesFromSortedPoints_InSortedPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(CullDuplicatesFromSortedPoints_FunctionAddress, "InSortedPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CullDuplicatesFromSortedPoints_MinDist_PropertyAddress, CullDuplicatesFromSortedPoints_FunctionAddress, "MinDist");
		CullDuplicatesFromSortedPoints_MinDist_Offset = NativeReflectionCached.GetPropertyOffset(CullDuplicatesFromSortedPoints_FunctionAddress, "MinDist");
		CullDuplicatesFromSortedPoints_MinDist_IsValid = NativeReflectionCached.ValidatePropertyClass(CullDuplicatesFromSortedPoints_FunctionAddress, "MinDist", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CullDuplicatesFromSortedPoints_MaxDist_PropertyAddress, CullDuplicatesFromSortedPoints_FunctionAddress, "MaxDist");
		CullDuplicatesFromSortedPoints_MaxDist_Offset = NativeReflectionCached.GetPropertyOffset(CullDuplicatesFromSortedPoints_FunctionAddress, "MaxDist");
		CullDuplicatesFromSortedPoints_MaxDist_IsValid = NativeReflectionCached.ValidatePropertyClass(CullDuplicatesFromSortedPoints_FunctionAddress, "MaxDist", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CullDuplicatesFromSortedPoints_ReturnValue_PropertyAddress, CullDuplicatesFromSortedPoints_FunctionAddress, "ReturnValue");
		CullDuplicatesFromSortedPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CullDuplicatesFromSortedPoints_FunctionAddress, "ReturnValue");
		CullDuplicatesFromSortedPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CullDuplicatesFromSortedPoints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CullDuplicatesFromSortedPoints_IsValid = CullDuplicatesFromSortedPoints_FunctionAddress != IntPtr.Zero && CullDuplicatesFromSortedPoints_InSortedPoints_IsValid && CullDuplicatesFromSortedPoints_MinDist_IsValid && CullDuplicatesFromSortedPoints_MaxDist_IsValid && CullDuplicatesFromSortedPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:CullDuplicatesFromSortedPoints", CullDuplicatesFromSortedPoints_IsValid);
		CreatePointInstances_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreatePointInstances");
		CreatePointInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePointInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePointInstances_InPoints_PropertyAddress, CreatePointInstances_FunctionAddress, "InPoints");
		CreatePointInstances_InPoints_Offset = NativeReflectionCached.GetPropertyOffset(CreatePointInstances_FunctionAddress, "InPoints");
		CreatePointInstances_InPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePointInstances_FunctionAddress, "InPoints", Classes.FArrayProperty);
		CreatePointInstances_IsValid = CreatePointInstances_FunctionAddress != IntPtr.Zero && CreatePointInstances_InPoints_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:CreatePointInstances", CreatePointInstances_IsValid);
		ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConvertScatteredPointsToNavmeshPointsV2");
		ConvertScatteredPointsToNavmeshPointsV2_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InScatteredPoints");
		ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InScatteredPoints");
		ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InScatteredPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InRecastNavmesh");
		ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InRecastNavmesh");
		ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InRecastNavmesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InQueryExtent");
		ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InQueryExtent");
		ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InQueryExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV2_InOffset_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InOffset");
		ConvertScatteredPointsToNavmeshPointsV2_InOffset_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InOffset");
		ConvertScatteredPointsToNavmeshPointsV2_InOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "InOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "ReturnValue");
		ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "ReturnValue");
		ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ConvertScatteredPointsToNavmeshPointsV2_IsValid = ConvertScatteredPointsToNavmeshPointsV2_FunctionAddress != IntPtr.Zero && ConvertScatteredPointsToNavmeshPointsV2_InScatteredPoints_IsValid && ConvertScatteredPointsToNavmeshPointsV2_InRecastNavmesh_IsValid && ConvertScatteredPointsToNavmeshPointsV2_InQueryExtent_IsValid && ConvertScatteredPointsToNavmeshPointsV2_InOffset_IsValid && ConvertScatteredPointsToNavmeshPointsV2_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:ConvertScatteredPointsToNavmeshPointsV2", ConvertScatteredPointsToNavmeshPointsV2_IsValid);
		ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConvertScatteredPointsToNavmeshPointsV1");
		ConvertScatteredPointsToNavmeshPointsV1_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InScatteredPoints");
		ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InScatteredPoints");
		ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InScatteredPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InQueryExtent");
		ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InQueryExtent");
		ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InQueryExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV1_InOffset_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InOffset");
		ConvertScatteredPointsToNavmeshPointsV1_InOffset_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InOffset");
		ConvertScatteredPointsToNavmeshPointsV1_InOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "InOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_PropertyAddress, ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "ReturnValue");
		ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "ReturnValue");
		ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ConvertScatteredPointsToNavmeshPointsV1_IsValid = ConvertScatteredPointsToNavmeshPointsV1_FunctionAddress != IntPtr.Zero && ConvertScatteredPointsToNavmeshPointsV1_InScatteredPoints_IsValid && ConvertScatteredPointsToNavmeshPointsV1_InQueryExtent_IsValid && ConvertScatteredPointsToNavmeshPointsV1_InOffset_IsValid && ConvertScatteredPointsToNavmeshPointsV1_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.PathPointScatter:ConvertScatteredPointsToNavmeshPointsV1", ConvertScatteredPointsToNavmeshPointsV1_IsValid);
	}
}
