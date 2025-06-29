using System;
using b1.EventDelDefine;
using Google.Protobuf;
using GurGsReplicate;

namespace b1;

public class BPS_DataReplicationSystemSvr : PlayerStateSystemBase
{
	private BPC_PlayerStateTestData mPlayerStateTestData;

	private BPC_RoleBaseData mRoleBaseData;

	private BPC_TransactionData mTransactionData;

	public int ReplicateFrameCounter = 10;

	public override void OnAttach()
	{
		mPlayerStateTestData = RequireWritableData<BPC_PlayerStateTestData>();
		mRoleBaseData = RequireWritableData<BPC_RoleBaseData>();
		mTransactionData = RequireWritableData<BPC_TransactionData>();
		OnAttachHandWritten();
	}

	public byte[] GenerateReplicatedData(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		RepDataAll repDataAll = new RepDataAll();
		repDataAll.Version = BGWGameInstanceCS.sGlobalReplicateVersionAlloc;
		repDataAll.OldVersion = OldGlobalVersion;
		if (mPlayerStateTestData != null)
		{
			repDataAll.PlayerStateTestData = mPlayerStateTestData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mRoleBaseData != null)
		{
			repDataAll.RoleBaseData = mRoleBaseData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		if (mTransactionData != null)
		{
			repDataAll.TransactionData = mTransactionData.GetRepDataForNetRep(ConnectionPtr, OldGlobalVersion);
		}
		return repDataAll.ToByteArray();
	}

	public void OnAttachHandWritten()
	{
		GetPlayerEventCollection().Evt_BPS_CollectReplicateData += new Del_CollectReplicateData(CollectReplicateData);
	}

	public void CollectReplicateData(IntPtr ConnectionPtr, int OldVersion, out byte[] ReplicationBytes)
	{
		try
		{
			ReplicationBytes = GenerateReplicatedData(ConnectionPtr, OldVersion);
		}
		catch (Exception arg)
		{
			ReplicationBytes = null;
			BGW_LogUtil.LogError($"Replicate Data Error!!! {arg}");
		}
	}
}
