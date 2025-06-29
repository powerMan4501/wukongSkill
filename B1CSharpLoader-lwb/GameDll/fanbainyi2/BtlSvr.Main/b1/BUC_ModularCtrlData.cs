using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ModularCtrlData : IPersistentECSData
{
	public enum ModularActorState
	{
		InPhysicsSimulation,
		InInterpolation,
		Finished,
		Detached
	}

	public BGUModularMgrActor OwnerMgr;

	public Dictionary<TStrongObjectPtr<AActor>, ModularActorState> ModularActors;

	public bool bAutoAttachModularActors;

	public bool bDestroyAfterOwnerDeath;

	public bool bNeedsCopyPose;

	public Dictionary<FName, int> ModularBreakDownProjectileMap;

	public Dictionary<string, List<TStrongObjectPtr<AActor>>> DetachedModularActors;

	public Dictionary<string, ModularDetachData> ModularDetachDatas;

	public Dictionary<string, List<TStrongObjectPtr<AActor>>> RestoredModularActors;

	public Dictionary<List<string>, bool> PABodiesResponseForRestore;

	private const int PredefinedVectorSlotsNum = 5;

	public FVector[] PredefinedVectorSlots;

	private bool bIsFrameSwitched;

	public List<FTWImpulseData> TWImpulseDataList;

	public UCurveFloat TWImpulseBlendCurve;

	public List<FTWForceData> TWForceDataList;

	public UCurveFloat TWForceBlendCurve;

	public float PhysicsDistanceThreshold;

	public float InterpolationDistanceThreshold;

	public UCurveFloat LocationInterpolationSpeedCurve;

	public UCurveFloat RotationInterpolationSpeedCurve;

	public uint CapsuleCollisionResponseHandleID;

	public uint MeshCollisionResponseHandleID;

	public bool bPendingHideModularActors;

	public BUC_ModularCtrlData()
	{
		ModularActors = new Dictionary<TStrongObjectPtr<AActor>, ModularActorState>();
		DetachedModularActors = new Dictionary<string, List<TStrongObjectPtr<AActor>>>();
		ModularDetachDatas = new Dictionary<string, ModularDetachData>();
		RestoredModularActors = new Dictionary<string, List<TStrongObjectPtr<AActor>>>();
		PABodiesResponseForRestore = new Dictionary<List<string>, bool>();
		PredefinedVectorSlots = new FVector[5];
		TWImpulseDataList = new List<FTWImpulseData>();
		TWForceDataList = new List<FTWForceData>();
		bIsFrameSwitched = false;
	}

	public void CopyBPDataToData(BGWDataAsset_TigerWoodsConfig TigerWoodsConfig)
	{
		if (!(TigerWoodsConfig == null))
		{
			TWImpulseDataList = TigerWoodsConfig.TWImpulseDataList.ToList();
			TWImpulseBlendCurve = TigerWoodsConfig.TWImpulseBlendCurve;
			TWForceDataList = TigerWoodsConfig.TWForceDataList.ToList();
			TWForceBlendCurve = TigerWoodsConfig.TWForceBlendCurve;
			PhysicsDistanceThreshold = TigerWoodsConfig.PhysicsDistanceThreshold;
			InterpolationDistanceThreshold = TigerWoodsConfig.InterpolationDistanceThreshold;
			LocationInterpolationSpeedCurve = TigerWoodsConfig.LocationInterpolationSpeedCurve;
			RotationInterpolationSpeedCurve = TigerWoodsConfig.RotationInterpolationSpeedCurve;
		}
	}

	public List<TStrongObjectPtr<AActor>> GetDetachedModularActors(string BoneName)
	{
		if (DetachedModularActors.ContainsKey(BoneName))
		{
			return DetachedModularActors[BoneName];
		}
		return null;
	}

	public void GetDetachedComponentTags(List<string> BoneNames, out List<string> ComponentTags)
	{
		ComponentTags = new List<string>();
		foreach (string BoneName in BoneNames)
		{
			ComponentTags.Add(ModularDetachDatas[BoneName].ComponentTag);
		}
	}

	public bool GetSwitchFrameBool()
	{
		return bIsFrameSwitched;
	}

	public void SwitchFrameBool()
	{
		bIsFrameSwitched = !bIsFrameSwitched;
	}
}
