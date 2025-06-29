using System;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWMonkeySummonDataAsset")]
public class BGWMonkeySummonDataAsset : UBGWDataAsset
{
	private static bool SummonSpawnPointList_IsValid;

	private static int SummonSpawnPointList_Offset;

	private static FFieldAddress SummonSpawnPointList_PropertyAddress;

	private TArrayReadWriteMarshaler<FSummonSpawnQuene> SummonSpawnPointList_Marshaler;

	private static bool MapSummonSateBehaviorTree_IsValid;

	private static int MapSummonSateBehaviorTree_Offset;

	private static FFieldAddress MapSummonSateBehaviorTree_PropertyAddress;

	private TMapReadWriteMarshaler<ESummonBehaviorState, UBehaviorTree> MapSummonSateBehaviorTree_Marshaler;

	private static bool DefauleSummonBehaviorState_IsValid;

	private static int DefauleSummonBehaviorState_Offset;

	private static FFieldAddress DefauleSummonBehaviorState_PropertyAddress;

	private static bool bAllowSpawnPointAwayFromNavMesh_IsValid;

	private static int bAllowSpawnPointAwayFromNavMesh_Offset;

	private static FFieldAddress bAllowSpawnPointAwayFromNavMesh_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWMonkeySummonDataAsset:SummonSpawnPointList")]
	public TArrayReadWrite<FSummonSpawnQuene> SummonSpawnPointList
	{
		get
		{
			CheckDestroyed();
			if (!SummonSpawnPointList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonkeySummonDataAsset:SummonSpawnPointList");
				return null;
			}
			if (SummonSpawnPointList_Marshaler == null)
			{
				SummonSpawnPointList_Marshaler = new TArrayReadWriteMarshaler<FSummonSpawnQuene>(1, SummonSpawnPointList_PropertyAddress, CachedMarshalingDelegates<FSummonSpawnQuene, FSummonSpawnQuene>.FromNative, CachedMarshalingDelegates<FSummonSpawnQuene, FSummonSpawnQuene>.ToNative);
			}
			return SummonSpawnPointList_Marshaler.FromNative(IntPtr.Add(base.Address, SummonSpawnPointList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWMonkeySummonDataAsset:MapSummonSateBehaviorTree")]
	public TMapReadWrite<ESummonBehaviorState, UBehaviorTree> MapSummonSateBehaviorTree
	{
		get
		{
			CheckDestroyed();
			if (!MapSummonSateBehaviorTree_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonkeySummonDataAsset:MapSummonSateBehaviorTree");
				return null;
			}
			if (MapSummonSateBehaviorTree_Marshaler == null)
			{
				MapSummonSateBehaviorTree_Marshaler = new TMapReadWriteMarshaler<ESummonBehaviorState, UBehaviorTree>(1, MapSummonSateBehaviorTree_PropertyAddress, CachedMarshalingDelegates<ESummonBehaviorState, EnumMarshaler<ESummonBehaviorState>>.FromNative, CachedMarshalingDelegates<ESummonBehaviorState, EnumMarshaler<ESummonBehaviorState>>.ToNative, CachedMarshalingDelegates<UBehaviorTree, UObjectMarshaler<UBehaviorTree>>.FromNative, CachedMarshalingDelegates<UBehaviorTree, UObjectMarshaler<UBehaviorTree>>.ToNative);
			}
			return MapSummonSateBehaviorTree_Marshaler.FromNative(IntPtr.Add(base.Address, MapSummonSateBehaviorTree_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWMonkeySummonDataAsset:DefauleSummonBehaviorState")]
	public ESummonBehaviorState DefauleSummonBehaviorState
	{
		get
		{
			CheckDestroyed();
			if (!DefauleSummonBehaviorState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonkeySummonDataAsset:DefauleSummonBehaviorState");
				return ESummonBehaviorState.Default;
			}
			return EnumMarshaler<ESummonBehaviorState>.FromNative(IntPtr.Add(base.Address, DefauleSummonBehaviorState_Offset), 0, DefauleSummonBehaviorState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefauleSummonBehaviorState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonkeySummonDataAsset:DefauleSummonBehaviorState");
			}
			else
			{
				EnumMarshaler<ESummonBehaviorState>.ToNative(IntPtr.Add(base.Address, DefauleSummonBehaviorState_Offset), 0, DefauleSummonBehaviorState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWMonkeySummonDataAsset:bAllowSpawnPointAwayFromNavMesh")]
	public bool bAllowSpawnPointAwayFromNavMesh
	{
		get
		{
			CheckDestroyed();
			if (!bAllowSpawnPointAwayFromNavMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonkeySummonDataAsset:bAllowSpawnPointAwayFromNavMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAllowSpawnPointAwayFromNavMesh_Offset), 0, bAllowSpawnPointAwayFromNavMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAllowSpawnPointAwayFromNavMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonkeySummonDataAsset:bAllowSpawnPointAwayFromNavMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAllowSpawnPointAwayFromNavMesh_Offset), 0, bAllowSpawnPointAwayFromNavMesh_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWMonkeySummonDataAsset");
		NativeReflection.GetPropertyRef(ref SummonSpawnPointList_PropertyAddress, unrealStruct, "SummonSpawnPointList");
		SummonSpawnPointList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SummonSpawnPointList");
		SummonSpawnPointList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SummonSpawnPointList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MapSummonSateBehaviorTree_PropertyAddress, unrealStruct, "MapSummonSateBehaviorTree");
		MapSummonSateBehaviorTree_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapSummonSateBehaviorTree");
		MapSummonSateBehaviorTree_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapSummonSateBehaviorTree", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref DefauleSummonBehaviorState_PropertyAddress, unrealStruct, "DefauleSummonBehaviorState");
		DefauleSummonBehaviorState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefauleSummonBehaviorState");
		DefauleSummonBehaviorState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefauleSummonBehaviorState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bAllowSpawnPointAwayFromNavMesh_PropertyAddress, unrealStruct, "bAllowSpawnPointAwayFromNavMesh");
		bAllowSpawnPointAwayFromNavMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAllowSpawnPointAwayFromNavMesh");
		bAllowSpawnPointAwayFromNavMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAllowSpawnPointAwayFromNavMesh", Classes.FBoolProperty);
	}

	static BGWMonkeySummonDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWMonkeySummonDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWMonkeySummonDataAsset));
	}
}
