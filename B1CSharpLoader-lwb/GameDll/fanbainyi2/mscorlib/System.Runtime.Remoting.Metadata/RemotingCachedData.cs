namespace System.Runtime.Remoting.Metadata;

internal abstract class RemotingCachedData
{
	private SoapAttribute _soapAttr;

	internal SoapAttribute GetSoapAttribute()
	{
		if (_soapAttr == null)
		{
			lock (this)
			{
				if (_soapAttr == null)
				{
					_soapAttr = GetSoapAttributeNoLock();
				}
			}
		}
		return _soapAttr;
	}

	internal abstract SoapAttribute GetSoapAttributeNoLock();
}
