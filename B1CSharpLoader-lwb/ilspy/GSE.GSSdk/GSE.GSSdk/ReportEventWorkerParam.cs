using System.Collections.Concurrent;
using System.Threading;

namespace GSE.GSSdk;

internal class ReportEventWorkerParam
{
	public CancellationToken CancelToken;

	public bool EnableLocalStore;

	public ConcurrentQueue<ReportEventItemRaw> EvtQueueRaw;

	public HttpPostAsyncProxy PostProxy;
}
