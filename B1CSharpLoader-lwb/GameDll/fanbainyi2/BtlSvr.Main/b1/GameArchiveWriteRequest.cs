using System.Collections.Generic;

namespace b1;

public class GameArchiveWriteRequest : ArchiveAsyncRequest
{
	public int ArchiveId;

	public GSArchiveFileContainer WriteArchiveFileContainer;

	public List<ArchiveSaveRequestOne> PendingArchiveRequests = new List<ArchiveSaveRequestOne>();

	private BGW_ArchiveReadWriteWorker ArchiveWorker;

	public GameArchiveWriteRequest(BGW_ArchiveReadWriteWorker ArchiveWorker)
	{
		this.ArchiveWorker = ArchiveWorker;
	}

	public override AsyncTaskRunResult RunTask()
	{
		return ArchiveWorker.DoWriteArchiveTask(this);
	}

	public override void OnTaskFinish(AsyncTaskRunResult TaskResult)
	{
		ArchiveWorker.OnWriteArchiveTaskFinish(this, TaskResult.IsSuccess);
	}
}
