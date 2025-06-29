using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class DesignerTransactionCloseEventArgs : EventArgs
{
	private bool commit;

	private bool lastTransaction;

	public bool TransactionCommitted => commit;

	public bool LastTransaction => lastTransaction;

	[Obsolete("This constructor is obsolete. Use DesignerTransactionCloseEventArgs(bool, bool) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public DesignerTransactionCloseEventArgs(bool commit)
		: this(commit, lastTransaction: true)
	{
	}

	public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction)
	{
		this.commit = commit;
		this.lastTransaction = lastTransaction;
	}
}
