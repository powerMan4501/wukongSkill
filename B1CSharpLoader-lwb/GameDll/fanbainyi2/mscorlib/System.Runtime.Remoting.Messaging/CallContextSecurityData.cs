using System.Security.Principal;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class CallContextSecurityData : ICloneable
{
	private IPrincipal _principal;

	internal IPrincipal Principal
	{
		get
		{
			return _principal;
		}
		set
		{
			_principal = value;
		}
	}

	internal bool HasInfo => _principal != null;

	public object Clone()
	{
		CallContextSecurityData callContextSecurityData = new CallContextSecurityData();
		callContextSecurityData._principal = _principal;
		return callContextSecurityData;
	}
}
