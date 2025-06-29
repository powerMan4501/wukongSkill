using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Channels;

[Serializable]
internal class CrossAppDomainData
{
	private object _ContextID = 0;

	private int _DomainID;

	private string _processGuid;

	internal virtual IntPtr ContextID => new IntPtr((int)_ContextID);

	internal virtual int DomainID
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return _DomainID;
		}
	}

	internal virtual string ProcessGuid => _processGuid;

	internal CrossAppDomainData(IntPtr ctxId, int domainID, string processGuid)
	{
		_DomainID = domainID;
		_processGuid = processGuid;
		_ContextID = ctxId.ToInt32();
	}

	internal bool IsFromThisProcess()
	{
		return Identity.ProcessGuid.Equals(_processGuid);
	}

	[SecurityCritical]
	internal bool IsFromThisAppDomain()
	{
		if (IsFromThisProcess())
		{
			return Thread.GetDomain().GetId() == _DomainID;
		}
		return false;
	}
}
