using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapQName : ISoapXsd
{
	private string _name;

	private string _namespace;

	private string _key;

	public static string XsdType => "QName";

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public string Namespace
	{
		get
		{
			return _namespace;
		}
		set
		{
			_namespace = value;
		}
	}

	public string Key
	{
		get
		{
			return _key;
		}
		set
		{
			_key = value;
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapQName()
	{
	}

	public SoapQName(string value)
	{
		_name = value;
	}

	public SoapQName(string key, string name)
	{
		_name = name;
		_key = key;
	}

	public SoapQName(string key, string name, string namespaceValue)
	{
		_name = name;
		_namespace = namespaceValue;
		_key = key;
	}

	public override string ToString()
	{
		if (_key == null || _key.Length == 0)
		{
			return _name;
		}
		return _key + ":" + _name;
	}

	public static SoapQName Parse(string value)
	{
		if (value == null)
		{
			return new SoapQName();
		}
		string key = "";
		string name = value;
		int num = value.IndexOf(':');
		if (num > 0)
		{
			key = value.Substring(0, num);
			name = value.Substring(num + 1);
		}
		return new SoapQName(key, name);
	}
}
