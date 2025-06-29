using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_PhysAnimData : b1.IBUC_PhysAnimData
{
	private List<PhysAnimSetting> GeneralSettings;

	private b1.BeAtkPhysAnimSetting BeAtkSetting;

	private b1.BeCatchThrowPhysAnimSetting BeCatchThrowSetting;

	private b1.PhysMoveAnimSetting PhysMoveSetting;

	public b1.BGU_Timeline BeAtkPhysWeightTL;

	public FTransform MeshRelTrf;

	public bool bHasNormal;

	public Dictionary<EPhysAnimType, bool> MapPhysAnimSettingInitState;

	public EPhysAnimType CurrentType { get; set; }

	public bool bPhysicalMoveSnapshot { get; set; }

	public bool bLockPhysicalMoveSnapshot { get; set; }

	public uint HandleID_CollisionProfile { get; set; }

	public void Init()
	{
		CurrentType = EPhysAnimType.None;
		BeAtkSetting = new b1.BeAtkPhysAnimSetting();
		BeCatchThrowSetting = new b1.BeCatchThrowPhysAnimSetting();
		PhysMoveSetting = new b1.PhysMoveAnimSetting();
		GeneralSettings = new List<PhysAnimSetting>(7);
		for (int i = 0; i < 7; i++)
		{
			GeneralSettings.Add(new PhysAnimSetting());
		}
		bPhysicalMoveSnapshot = false;
		bLockPhysicalMoveSnapshot = false;
		BeAtkPhysWeightTL = new b1.BGU_Timeline();
		MapPhysAnimSettingInitState = new Dictionary<EPhysAnimType, bool>();
	}

	public PhysAnimSetting TryGetSetting(EPhysAnimType Type, AActor Owner, out bool bLoadThisTime)
	{
		bLoadThisTime = false;
		if ((int)Type > 7)
		{
			return null;
		}
		if (!MapPhysAnimSettingInitState.TryGetValue(Type, out var value))
		{
			MapPhysAnimSettingInitState.Add(Type, value: false);
			value = false;
		}
		if (!value)
		{
			MapPhysAnimSettingInitState[Type] = InitPhysAnimSetting(Type, Owner);
			if (MapPhysAnimSettingInitState[Type])
			{
				bLoadThisTime = true;
			}
		}
		return Type switch
		{
			EPhysAnimType.BeAttack => BeAtkSetting, 
			EPhysAnimType.BeCatchThrow => BeCatchThrowSetting, 
			EPhysAnimType.PhysicsSimulationMove => PhysMoveSetting, 
			_ => GeneralSettings[(int)Type], 
		};
	}

	public void InitData(BGWBeAtkPhysAnimDataAsset Data)
	{
		BeAtkSetting.PhysAnimProfile = Data.PhysAnimProfile;
		BeAtkSetting.ConstraintProfile = Data.ConstraintProfile;
		BeAtkSetting.KinematicBones = Data.KinematicBones.ToList();
		BeAtkSetting.PhysWeightCurve = Data.PhysWeightCurve;
		BeAtkSetting.MotorStrengthCurve = Data.MotorStrengthCurve;
		BeAtkSetting.HitImpulse = Data.HitImpulse;
		BeAtkSetting.bPartPhysics = Data.bPartPhysics;
		BeAtkSetting.bHitOnPelvis = Data.bHitOnPelvis;
		BeAtkSetting.bScaledByTotalMass = Data.bScaledByTotalMass;
		BeAtkSetting.bCanHitSpine = Data.bCanHitSpine;
		BeAtkSetting.bUseCurveBlend = BeAtkSetting.PhysWeightCurve != null;
	}

	public void InitData(BGWBeCatchThrowPhysAnimDataAsset Data)
	{
		BeCatchThrowSetting.PhysAnimProfile = Data.PhysAnimProfile;
		BeCatchThrowSetting.ConstraintProfile = Data.ConstraintProfile;
		BeCatchThrowSetting.KinematicBones = Data.KinematicBones.ToList();
		BeCatchThrowSetting.BoneNameBelowToSimulatePhysics = Data.BoneNameBelowToSimulatePhysics;
		BeCatchThrowSetting.PhysicsBlendWeight = Data.PhysicsBlendWeight;
	}

	public void InitData(BGWPhysMoveAnimDataAsset Data, in FVector LocalSpaceCollisionOffset)
	{
		BeCatchThrowSetting.PhysAnimProfile = Data.PhysAnimProfile;
		BeCatchThrowSetting.ConstraintProfile = Data.ConstraintProfile;
		BeCatchThrowSetting.KinematicBones = Data.KinematicBones.ToList();
		PhysMoveSetting.BoneNameToSimulatePhysics = Data.BoneNameToSimulatePhysics;
		PhysMoveSetting.LocalSpaceCollisionOffset = LocalSpaceCollisionOffset;
	}

	public void InitData(EPhysAnimType Type, BGWBasePhysAnimDataAsset Data)
	{
		GeneralSettings[(int)Type].PhysAnimProfile = Data.PhysAnimProfile;
		GeneralSettings[(int)Type].ConstraintProfile = Data.ConstraintProfile;
		GeneralSettings[(int)Type].KinematicBones = Data.KinematicBones.ToList();
	}

	private bool InitPhysAnimSetting(EPhysAnimType SourceType, AActor Owner)
	{
		if (Owner == null)
		{
			return false;
		}
		int actorResID = BGU_DataUtil.GetActorResID(Owner);
		switch (SourceType)
		{
		case EPhysAnimType.BeAttack:
		{
			IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Owner);
			if (readOnlyData == null)
			{
				return false;
			}
			FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(readOnlyData.GetCurrentBeAttackedInfoID());
			if (beAttackedInfoDesc == null)
			{
				return false;
			}
			BGWBeAtkPhysAnimDataAsset bGWBeAtkPhysAnimDataAsset = null;
			string beAttackedPhysAnimAsset = beAttackedInfoDesc.BeAttackedPhysAnimAsset;
			bGWBeAtkPhysAnimDataAsset = ((beAttackedPhysAnimAsset.Length != 0) ? BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWBeAtkPhysAnimDataAsset>(beAttackedPhysAnimAsset, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Top) : BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWBeAtkPhysAnimDataAsset>("BGWBeAtkPhysAnimDataAsset'/Game/00Main/BPLibrary/PhysAnim/PhysAnimConfig_BeAttack.PhysAnimConfig_BeAttack'", ELoadResourceType.SyncLoadAndCache));
			if (bGWBeAtkPhysAnimDataAsset == null)
			{
				return false;
			}
			InitData(bGWBeAtkPhysAnimDataAsset);
			break;
		}
		case EPhysAnimType.BeCatchThrow:
		{
			FUStUnitPhysicalAnimationDesc unitPhysicalAnimationDesc2 = BGW_GameDB.GetUnitPhysicalAnimationDesc(actorResID);
			if (unitPhysicalAnimationDesc2 == null || unitPhysicalAnimationDesc2.BeCatchThrowPhysAnimDataAsset.Length == 0)
			{
				return false;
			}
			BGWBeCatchThrowPhysAnimDataAsset bGWBeCatchThrowPhysAnimDataAsset = null;
			bGWBeCatchThrowPhysAnimDataAsset = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWBeCatchThrowPhysAnimDataAsset>(unitPhysicalAnimationDesc2.BeCatchThrowPhysAnimDataAsset, ELoadResourceType.SyncLoadAndCache);
			if (bGWBeCatchThrowPhysAnimDataAsset == null)
			{
				return false;
			}
			InitData(bGWBeCatchThrowPhysAnimDataAsset);
			break;
		}
		case EPhysAnimType.PhysicsSimulationMove:
		{
			FUStUnitPhysicalAnimationDesc unitPhysicalAnimationDesc3 = BGW_GameDB.GetUnitPhysicalAnimationDesc(actorResID);
			if (unitPhysicalAnimationDesc3 == null || unitPhysicalAnimationDesc3.PhysMoveAnimDataAsset.Length == 0)
			{
				return false;
			}
			BGWPhysMoveAnimDataAsset bGWPhysMoveAnimDataAsset = null;
			bGWPhysMoveAnimDataAsset = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWPhysMoveAnimDataAsset>(unitPhysicalAnimationDesc3.PhysMoveAnimDataAsset, ELoadResourceType.SyncLoadAndCache);
			if (bGWPhysMoveAnimDataAsset == null)
			{
				return false;
			}
			if (!(Owner is ACharacter aCharacter))
			{
				return false;
			}
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) - aCharacter.Mesh.GetSocketLocation(bGWPhysMoveAnimDataAsset.BoneNameToSimulatePhysics);
			InitData(bGWPhysMoveAnimDataAsset, MathLib.InverseTransformDirection(aCharacter.Mesh.GetSocketTransform(bGWPhysMoveAnimDataAsset.BoneNameToSimulatePhysics), fVector.GetSafeNormal()) * fVector.Size());
			break;
		}
		case EPhysAnimType.Normal:
		{
			FUStUnitPhysicalAnimationDesc unitPhysicalAnimationDesc = BGW_GameDB.GetUnitPhysicalAnimationDesc(actorResID);
			if (unitPhysicalAnimationDesc != null && unitPhysicalAnimationDesc.NormalPhysAnimDataAsset.Length != 0)
			{
				bHasNormal = true;
				BGWBasePhysAnimDataAsset bGWBasePhysAnimDataAsset = null;
				bGWBasePhysAnimDataAsset = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWBasePhysAnimDataAsset>(unitPhysicalAnimationDesc.NormalPhysAnimDataAsset, ELoadResourceType.SyncLoadAndCache);
				if (bGWBasePhysAnimDataAsset == null)
				{
					return false;
				}
				InitData(SourceType, bGWBasePhysAnimDataAsset);
				break;
			}
			bHasNormal = false;
			return false;
		}
		}
		return true;
	}
}
