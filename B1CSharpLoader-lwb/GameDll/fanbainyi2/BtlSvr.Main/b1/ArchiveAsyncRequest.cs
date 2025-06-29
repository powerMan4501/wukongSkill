namespace b1;

public abstract class ArchiveAsyncRequest
{
	public abstract AsyncTaskRunResult RunTask();

	public abstract void OnTaskFinish(AsyncTaskRunResult TaskResult);
}
