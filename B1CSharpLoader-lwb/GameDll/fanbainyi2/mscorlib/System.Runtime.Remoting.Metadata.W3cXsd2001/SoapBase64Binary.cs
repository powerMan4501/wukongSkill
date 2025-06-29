using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapBase64Binary : ISoapXsd
{
	private byte[] _value;

	public static string XsdType => "base64Binary";

	public byte[] Value
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

	public SoapBase64Binary()
	{
	}

	public SoapBase64Binary(byte[] value)
	{
		_value = value;
	}

	public override string ToString()
	{
		if (_value == null)
		{
			return null;
		}
		return SoapType.LineFeedsBin64(Convert.ToBase64String(_value));
	}

	public static SoapBase64Binary Parse(string value)
	{
		if (value == null || value.Length == 0)
		{
			return new SoapBase64Binary(new byte[0]);
		}
		byte[] value2;
		try
		{
			value2 = Convert.FromBase64String(SoapType.FilterBin64(value));
		}
		catch (Exception)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid"), "base64Binary", value));
		}
		return new SoapBase64Binary(value2);
	}
}
