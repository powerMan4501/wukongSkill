using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapEntity : ISoapXsd
{
	private string _value;

	public static string XsdType => "ENTITY";

	public string Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapEntity()
	{
	}

	public SoapEntity(string value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapEntity Parse(string value)
	{
		return new SoapEntity(value);
	}
}
