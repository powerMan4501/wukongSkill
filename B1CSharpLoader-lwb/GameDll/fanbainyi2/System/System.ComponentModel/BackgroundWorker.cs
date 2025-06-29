using System.Security.Permissions;
using System.Threading;

namespace System.ComponentModel;

[SRDescription("BackgroundWorker_Desc")]
[DefaultEvent("DoWork")]
[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class BackgroundWorker : Component
{
	private delegate void WorkerThreadStartDelegate(object argument);

	private static readonly object doWorkKey = new object();

	private static readonly object runWorkerCompletedKey = new object();

	private static readonly object progressChangedKey = new object();

	private bool canCancelWorker;

	private bool workerReportsProgress;

	private bool cancellationPending;

	private bool isRunning;

	private AsyncOperation asyncOperation;

	private readonly WorkerThreadStartDelegate threadStart;

	private readonly SendOrPostCallback operationCompleted;

	private readonly SendOrPostCallback progressReporter;

	[Browsable(false)]
	[SRDescription("BackgroundWorker_CancellationPending")]
	[global::__DynamicallyInvokable]
	public bool CancellationPending
	{
		[global::__DynamicallyInvokable]
		get
		{
			return cancellationPending;
		}
	}

	[Browsable(false)]
	[SRDescription("BackgroundWorker_IsBusy")]
	[global::__DynamicallyInvokable]
	public bool IsBusy
	{
		[global::__DynamicallyInvokable]
		get
		{
			return isRunning;
		}
	}

	[SRCategory("PropertyCategoryAsynchronous")]
	[SRDescription("BackgroundWorker_WorkerReportsProgress")]
	[DefaultValue(false)]
	[global::__DynamicallyInvokable]
	public bool WorkerReportsProgress
	{
		[global::__DynamicallyInvokable]
		get
		{
			return workerReportsProgress;
		}
		[global::__DynamicallyInvokable]
		set
		{
			workerReportsProgress = value;
		}
	}

	[SRCategory("PropertyCategoryAsynchronous")]
	[SRDescription("BackgroundWorker_WorkerSupportsCancellation")]
	[DefaultValue(false)]
	[global::__DynamicallyInvokable]
	public bool WorkerSupportsCancellation
	{
		[global::__DynamicallyInvokable]
		get
		{
			return canCancelWorker;
		}
		[global::__DynamicallyInvokable]
		set
		{
			canCancelWorker = value;
		}
	}

	[SRCategory("PropertyCategoryAsynchronous")]
	[SRDescription("BackgroundWorker_DoWork")]
	[global::__DynamicallyInvokable]
	public event DoWorkEventHandler DoWork
	{
		[global::__DynamicallyInvokable]
		add
		{
			base.Events.AddHandler(doWorkKey, value);
		}
		[global::__DynamicallyInvokable]
		remove
		{
			base.Events.RemoveHandler(doWorkKey, value);
		}
	}

	[SRCategory("PropertyCategoryAsynchronous")]
	[SRDescription("BackgroundWorker_ProgressChanged")]
	[global::__DynamicallyInvokable]
	public event ProgressChangedEventHandler ProgressChanged
	{
		[global::__DynamicallyInvokable]
		add
		{
			base.Events.AddHandler(progressChangedKey, value);
		}
		[global::__DynamicallyInvokable]
		remove
		{
			base.Events.RemoveHandler(progressChangedKey, value);
		}
	}

	[SRCategory("PropertyCategoryAsynchronous")]
	[SRDescription("BackgroundWorker_RunWorkerCompleted")]
	[global::__DynamicallyInvokable]
	public event RunWorkerCompletedEventHandler RunWorkerCompleted
	{
		[global::__DynamicallyInvokable]
		add
		{
			base.Events.AddHandler(runWorkerCompletedKey, value);
		}
		[global::__DynamicallyInvokable]
		remove
		{
			base.Events.RemoveHandler(runWorkerCompletedKey, value);
		}
	}

	[global::__DynamicallyInvokable]
	public BackgroundWorker()
	{
		threadStart = WorkerThreadStart;
		operationCompleted = AsyncOperationCompleted;
		progressReporter = ProgressReporter;
	}

	private void AsyncOperationCompleted(object arg)
	{
		isRunning = false;
		cancellationPending = false;
		OnRunWorkerCompleted((RunWorkerCompletedEventArgs)arg);
	}

	[global::__DynamicallyInvokable]
	public void CancelAsync()
	{
		if (!WorkerSupportsCancellation)
		{
			throw new InvalidOperationException(SR.GetString("BackgroundWorker_WorkerDoesntSupportCancellation"));
		}
		cancellationPending = true;
	}

	[global::__DynamicallyInvokable]
	protected virtual void OnDoWork(DoWorkEventArgs e)
	{
		((DoWorkEventHandler)base.Events[doWorkKey])?.Invoke(this, e);
	}

	[global::__DynamicallyInvokable]
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
	{
		((RunWorkerCompletedEventHandler)base.Events[runWorkerCompletedKey])?.Invoke(this, e);
	}

	[global::__DynamicallyInvokable]
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
	{
		((ProgressChangedEventHandler)base.Events[progressChangedKey])?.Invoke(this, e);
	}

	private void ProgressReporter(object arg)
	{
		OnProgressChanged((ProgressChangedEventArgs)arg);
	}

	[global::__DynamicallyInvokable]
	public void ReportProgress(int percentProgress)
	{
		ReportProgress(percentProgress, null);
	}

	[global::__DynamicallyInvokable]
	public void ReportProgress(int percentProgress, object userState)
	{
		if (!WorkerReportsProgress)
		{
			throw new InvalidOperationException(SR.GetString("BackgroundWorker_WorkerDoesntReportProgress"));
		}
		ProgressChangedEventArgs e = new ProgressChangedEventArgs(percentProgress, userState);
		if (asyncOperation != null)
		{
			asyncOperation.Post(progressReporter, e);
		}
		else
		{
			progressReporter(e);
		}
	}

	[global::__DynamicallyInvokable]
	public void RunWorkerAsync()
	{
		RunWorkerAsync(null);
	}

	[global::__DynamicallyInvokable]
	public void RunWorkerAsync(object argument)
	{
		if (isRunning)
		{
			throw new InvalidOperationException(SR.GetString("BackgroundWorker_WorkerAlreadyRunning"));
		}
		isRunning = true;
		cancellationPending = false;
		asyncOperation = AsyncOperationManager.CreateOperation(null);
		threadStart.BeginInvoke(argument, null, null);
	}

	private void WorkerThreadStart(object argument)
	{
		object result = null;
		Exception error = null;
		bool cancelled = false;
		try
		{
			DoWorkEventArgs e = new DoWorkEventArgs(argument);
			OnDoWork(e);
			if (e.Cancel)
			{
				cancelled = true;
			}
			else
			{
				result = e.Result;
			}
		}
		catch (Exception ex)
		{
			error = ex;
		}
		RunWorkerCompletedEventArgs arg = new RunWorkerCompletedEventArgs(result, error, cancelled);
		asyncOperation.PostOperationCompleted(operationCompleted, arg);
	}
}
