using System.Reflection;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Metadata;

internal class RemotingFieldCachedData : RemotingCachedData
{
	private FieldInfo RI;

	internal RemotingFieldCachedData(RuntimeFieldInfo ri)
	{
		RI = ri;
	}

	internal RemotingFieldCachedData(SerializationFieldInfo ri)
	{
		RI = ri;
	}

	internal override SoapAttribute GetSoapAttributeNoLock()
	{
		SoapAttribute soapAttribute = null;
		object[] customAttributes = RI.GetCustomAttributes(typeof(SoapFieldAttribute), inherit: false);
		soapAttribute = ((customAttributes == null || customAttributes.Length == 0) ? new SoapFieldAttribute() : ((SoapAttribute)customAttributes[0]));
		soapAttribute.SetReflectInfo(RI);
		return soapAttribute;
	}
}
