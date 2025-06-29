using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets.Field)]
[ComVisible(true)]
public sealed class SoapFieldAttribute : SoapAttribute
{
	[Serializable]
	[Flags]
	private enum ExplicitlySet
	{
		None = 0,
		XmlElementName = 1
	}

	private ExplicitlySet _explicitlySet;

	private string _xmlElementName;

	private int _order;

	public string XmlElementName
	{
		get
		{
			if (_xmlElementName == null && ReflectInfo != null)
			{
				_xmlElementName = ((FieldInfo)ReflectInfo).Name;
			}
			return _xmlElementName;
		}
		set
		{
			_xmlElementName = value;
			_explicitlySet |= ExplicitlySet.XmlElementName;
		}
	}

	public int Order
	{
		get
		{
			return _order;
		}
		set
		{
			_order = value;
		}
	}

	public bool IsInteropXmlElement()
	{
		return (_explicitlySet & ExplicitlySet.XmlElementName) != 0;
	}
}
