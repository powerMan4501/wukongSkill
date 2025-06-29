using System;
using b1.EventDelDefine;
using Google.Protobuf;
using GurGsReplicate;

namespace b1;

public class BUS_DataReplicationSystemSvr : UActorCompBaseCS
{
	private BUC_ABPHelperData mABPHelperData;

	private BUC_AttrContainer mAttrContainer;

	private BUC_BuffData mBuffData;

	private BUC_ChargeSkillData mChargeSkillData;

	private BUC_FallDyingData mFallDyingData;

	private BUC_MontageSyncData mMontageSyncData;

	private BUC_PredictionTestData mPredictionTestData;

	private BUC_ReplicateTestData mReplicateTestData;

	private BUC_SimpleStateData mSimpleStateData;

	private BUC_TargetInfoData mTargetInfoData;

	private BUC_UnitHatredData mUnitHatredData;

	private BUC_UnitStateData mUnitStateData;

	private BUC_ObjActorMovementData mObjActorMovementData;

	private BUC_InteractData mInteractData;

	private BUC_ProjectileBasicData mProjectileBasicData;

	public override void OnAttach()
	{
		mABPHelperData = RequireWritableData<BUC_ABPHelperData>();
		mAttrContainer = RequireWritableData<BUC_AttrContainer>();
		mBuffData = RequireWritableData<BUC_BuffData>();
		mChargeSkillData = RequireWritableData<BUC_ChargeSkillData>();
		mFallDyingData = RequireWritableData<BUC_FallDyingData>();
		mMontageSyncData = RequireWritableData<BUC_MontageSyncData>();
		mPredictionTestData = RequireWritableData<BUC_PredictionTestData>();
		mReplicateTestData = RequireWritableData<BUC_ReplicateTestData>();
		mSimpleStateData = RequireWritableData<BUC_SimpleStateData>();
		mTargetInfoData = RequireWritableData<BUC_TargetInfoData>();
		mUnitHatredData = RequireWritableData<BUC_UnitHatredData>();
		mUnitStateData = RequireWritableData<BUC_UnitStateData>();
		mObjActorMovementData = RequireWritableData<BUC_ObjActorMovementData>();
		mInteractData = RequireWritableData<BUC_InteractData>();
		mProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		OnAttachHandWritten();
	}

	public byte[] GenerateReplicatedData(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		RepDataAll repDataAll = new RepDataAll();
		repDataAll.Version = BGWGameInstanceCS.sGlobalReplicateVersionAlloc;
		repDataAll.OldVersion = OldGlobalVersion;
		if (mABPHelperData != null)
		{
			repDataAll.ABPHelperData = mABPHelperData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mAttrContainer != null)
		{
			repDataAll.AttrContainer = mAttrContainer.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mBuffData != null)
		{
			repDataAll.BuffData = mBuffData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mChargeSkillData != null)
		{
			repDataAll.ChargeSkillData = mChargeSkillData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mFallDyingData != null)
		{
			repDataAll.FallDyingData = mFallDyingData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mMontageSyncData != null)
		{
			repDataAll.MontageSyncData = mMontageSyncData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mPredictionTestData != null)
		{
			repDataAll.PredictionTestData = mPredictionTestData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mReplicateTestData != null)
		{
			repDataAll.ReplicateTestData = mReplicateTestData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mSimpleStateData != null)
		{
			repDataAll.SimpleStateData = mSimpleStateData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mTargetInfoData != null)
		{
			repDataAll.TargetInfoData = mTargetInfoData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mUnitHatredData != null)
		{
			repDataAll.UnitHatredData = mUnitHatredData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mUnitStateData != null)
		{
			repDataAll.UnitStateData = mUnitStateData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mObjActorMovementData != null)
		{
			repDataAll.ObjActorMovementData = mObjActorMovementData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mInteractData != null)
		{
			repDataAll.InteractData = mInteractData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mProjectileBasicData != null)
		{
			repDataAll.ProjectileBasicData = mProjectileBasicData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		return repDataAll.ToByteArray();
	}

	public void OnAttachHandWritten()
	{
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		base.BUSEventCollection.Evt_CollectReplicateData += new Del_CollectReplicateData(CollectReplicateData);
	}

	public override void OnNetDeActive()
	{
		base.OnNetDeActive();
		base.BUSEventCollection.Evt_CollectReplicateData -= new Del_CollectReplicateData(CollectReplicateData);
	}

	public void CollectReplicateData(IntPtr ConnecttionAddr, int OldVersion, out byte[] ReplicationBytes)
	{
		try
		{
			ReplicationBytes = GenerateReplicatedData(ConnecttionAddr, OldVersion);
		}
		catch (Exception arg)
		{
			ReplicationBytes = null;
			BGW_LogUtil.LogError($"Replicate Data Error!!! {arg}");
		}
	}
}
