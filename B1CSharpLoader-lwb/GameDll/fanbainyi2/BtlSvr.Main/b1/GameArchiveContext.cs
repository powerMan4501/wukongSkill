using System.Collections.Generic;

namespace b1;

public class GameArchiveContext
{
	public int DelaySaveFrameCount;

	public EArchiveDelaySaveSource LastDelaySource;

	public string LastDelayExMessage = "";

	public float TrySaveSnapshotTime;

	public List<ArchiveLock> LockList = new List<ArchiveLock>();

	public int LockTransactionId;

	public float TryStopSaveArchiveTime;

	public List<ArchiveSaveRequestOne> PendingSaveArchiveRequest = new List<ArchiveSaveRequestOne>();

	public Del_OnStopSaveArchiveFinish OnStopSaveArchiveFinish;

	public bool ForceStopFlag;

	public ulong LastShowIOExcepitonMsgTime;

	public float SaveRoleDataArchiveCD;
}
