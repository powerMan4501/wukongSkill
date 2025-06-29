using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets.Method)]
[ComVisible(true)]
public sealed class SoapMethodAttribute : SoapAttribute
{
	private string _SoapAction;

	private string _responseXmlElementName;

	private string _responseXmlNamespace;

	private string _returnXmlElementName;

	private bool _bSoapActionExplicitySet;

	internal bool SoapActionExplicitySet => _bSoapActionExplicitySet;

	public string SoapAction
	{
		[SecuritySafeCritical]
		get
		{
			if (_SoapAction == null)
			{
				_SoapAction = XmlTypeNamespaceOfDeclaringType + "#" + ((MemberInfo)ReflectInfo).Name;
			}
			return _SoapAction;
		}
		set
		{
			_SoapAction = value;
			_bSoapActionExplicitySet = true;
		}
	}

	public override bool UseAttribute
	{
		get
		{
			return false;
		}
		set
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Attribute_UseAttributeNotsettable"));
		}
	}

	public override string XmlNamespace
	{
		[SecuritySafeCritical]
		get
		{
			if (ProtXmlNamespace == null)
			{
				ProtXmlNamespace = XmlTypeNamespaceOfDeclaringType;
			}
			return ProtXmlNamespace;
		}
		set
		{
			ProtXmlNamespace = value;
		}
	}

	public string ResponseXmlElementName
	{
		get
		{
			if (_responseXmlElementName == null && ReflectInfo != null)
			{
				_responseXmlElementName = ((MemberInfo)ReflectInfo).Name + "Response";
			}
			return _responseXmlElementName;
		}
		set
		{
			_responseXmlElementName = value;
		}
	}

	public string ResponseXmlNamespace
	{
		get
		{
			if (_responseXmlNamespace == null)
			{
				_responseXmlNamespace = XmlNamespace;
			}
			return _responseXmlNamespace;
		}
		set
		{
			_responseXmlNamespace = value;
		}
	}

	public string ReturnXmlElementName
	{
		get
		{
			if (_returnXmlElementName == null)
			{
				_returnXmlElementName = "return";
			}
			return _returnXmlElementName;
		}
		set
		{
			_returnXmlElementName = value;
		}
	}

	private string XmlTypeNamespaceOfDeclaringType
	{
		[SecurityCritical]
		get
		{
			if (ReflectInfo != null)
			{
				Type declaringType = ((MemberInfo)ReflectInfo).DeclaringType;
				return XmlNamespaceEncoder.GetXmlNamespaceForType((RuntimeType)declaringType, null);
			}
			return null;
		}
	}
}
