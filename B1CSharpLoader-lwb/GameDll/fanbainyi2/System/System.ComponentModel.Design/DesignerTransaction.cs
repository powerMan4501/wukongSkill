using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class DesignerTransaction : IDisposable
{
	private bool committed;

	private bool canceled;

	private bool suppressedFinalization;

	private string desc;

	public bool Canceled => canceled;

	public bool Committed => committed;

	public string Description => desc;

	protected DesignerTransaction()
		: this("")
	{
	}

	protected DesignerTransaction(string description)
	{
		desc = description;
	}

	public void Cancel()
	{
		if (!canceled && !committed)
		{
			canceled = true;
			GC.SuppressFinalize(this);
			suppressedFinalization = true;
			OnCancel();
		}
	}

	public void Commit()
	{
		if (!committed && !canceled)
		{
			committed = true;
			GC.SuppressFinalize(this);
			suppressedFinalization = true;
			OnCommit();
		}
	}

	protected abstract void OnCancel();

	protected abstract void OnCommit();

	~DesignerTransaction()
	{
		Dispose(disposing: false);
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		if (!suppressedFinalization)
		{
			GC.SuppressFinalize(this);
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		Cancel();
	}
}
