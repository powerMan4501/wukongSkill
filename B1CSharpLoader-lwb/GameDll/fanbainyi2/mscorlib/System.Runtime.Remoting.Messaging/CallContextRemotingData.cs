namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class CallContextRemotingData : ICloneable
{
	private string _logicalCallID;

	internal string LogicalCallID
	{
		get
		{
			return _logicalCallID;
		}
		set
		{
			_logicalCallID = value;
		}
	}

	internal bool HasInfo => _logicalCallID != null;

	public object Clone()
	{
		CallContextRemotingData callContextRemotingData = new CallContextRemotingData();
		callContextRemotingData.LogicalCallID = LogicalCallID;
		return callContextRemotingData;
	}
}
