using System.Reflection;

namespace System.Runtime.Remoting.Metadata;

internal class RemotingParameterCachedData : RemotingCachedData
{
	private RuntimeParameterInfo RI;

	internal RemotingParameterCachedData(RuntimeParameterInfo ri)
	{
		RI = ri;
	}

	internal override SoapAttribute GetSoapAttributeNoLock()
	{
		SoapAttribute soapAttribute = null;
		object[] customAttributes = RI.GetCustomAttributes(typeof(SoapParameterAttribute), inherit: true);
		soapAttribute = ((customAttributes == null || customAttributes.Length == 0) ? new SoapParameterAttribute() : ((SoapParameterAttribute)customAttributes[0]));
		soapAttribute.SetReflectInfo(RI);
		return soapAttribute;
	}
}
