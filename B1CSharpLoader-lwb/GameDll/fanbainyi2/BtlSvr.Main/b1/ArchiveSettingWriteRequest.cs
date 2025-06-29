using CommB1;

namespace b1;

public class ArchiveSettingWriteRequest : ArchiveAsyncRequest
{
	public string FileName;

	public UISettingArchiveData UISettingArchiveData;

	private BGW_ArchiveReadWriteWorker ArchiveWorker;

	public ArchiveSettingWriteRequest(BGW_ArchiveReadWriteWorker ArchiveWorker)
	{
		this.ArchiveWorker = ArchiveWorker;
	}

	public override AsyncTaskRunResult RunTask()
	{
		return ArchiveWorker.DoWriteSettingTask(this);
	}

	public override void OnTaskFinish(AsyncTaskRunResult TaskResult)
	{
		if (!TaskResult.IsSuccess)
		{
			SysLogUtil.ARCHIVE.LogError("ArchiveSettingWriteRequest Fail, FileName:" + FileName);
		}
	}
}
