using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
[ComVisible(true)]
public sealed class SoapTypeAttribute : SoapAttribute
{
	[Serializable]
	[Flags]
	private enum ExplicitlySet
	{
		None = 0,
		XmlElementName = 1,
		XmlNamespace = 2,
		XmlTypeName = 4,
		XmlTypeNamespace = 8
	}

	private ExplicitlySet _explicitlySet;

	private SoapOption _SoapOptions;

	private string _XmlElementName;

	private string _XmlTypeName;

	private string _XmlTypeNamespace;

	private XmlFieldOrderOption _XmlFieldOrder;

	public SoapOption SoapOptions
	{
		get
		{
			return _SoapOptions;
		}
		set
		{
			_SoapOptions = value;
		}
	}

	public string XmlElementName
	{
		get
		{
			if (_XmlElementName == null && ReflectInfo != null)
			{
				_XmlElementName = GetTypeName((Type)ReflectInfo);
			}
			return _XmlElementName;
		}
		set
		{
			_XmlElementName = value;
			_explicitlySet |= ExplicitlySet.XmlElementName;
		}
	}

	public override string XmlNamespace
	{
		get
		{
			if (ProtXmlNamespace == null && ReflectInfo != null)
			{
				ProtXmlNamespace = XmlTypeNamespace;
			}
			return ProtXmlNamespace;
		}
		set
		{
			ProtXmlNamespace = value;
			_explicitlySet |= ExplicitlySet.XmlNamespace;
		}
	}

	public string XmlTypeName
	{
		get
		{
			if (_XmlTypeName == null && ReflectInfo != null)
			{
				_XmlTypeName = GetTypeName((Type)ReflectInfo);
			}
			return _XmlTypeName;
		}
		set
		{
			_XmlTypeName = value;
			_explicitlySet |= ExplicitlySet.XmlTypeName;
		}
	}

	public string XmlTypeNamespace
	{
		[SecuritySafeCritical]
		get
		{
			if (_XmlTypeNamespace == null && ReflectInfo != null)
			{
				_XmlTypeNamespace = XmlNamespaceEncoder.GetXmlNamespaceForTypeNamespace((RuntimeType)ReflectInfo, null);
			}
			return _XmlTypeNamespace;
		}
		set
		{
			_XmlTypeNamespace = value;
			_explicitlySet |= ExplicitlySet.XmlTypeNamespace;
		}
	}

	public XmlFieldOrderOption XmlFieldOrder
	{
		get
		{
			return _XmlFieldOrder;
		}
		set
		{
			_XmlFieldOrder = value;
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

	internal bool IsInteropXmlElement()
	{
		return (_explicitlySet & (ExplicitlySet.XmlElementName | ExplicitlySet.XmlNamespace)) != 0;
	}

	internal bool IsInteropXmlType()
	{
		return (_explicitlySet & (ExplicitlySet.XmlTypeName | ExplicitlySet.XmlTypeNamespace)) != 0;
	}

	private static string GetTypeName(Type t)
	{
		if (t.IsNested)
		{
			string fullName = t.FullName;
			string text = t.Namespace;
			if (text == null || text.Length == 0)
			{
				return fullName;
			}
			return fullName.Substring(text.Length + 1);
		}
		return t.Name;
	}
}
