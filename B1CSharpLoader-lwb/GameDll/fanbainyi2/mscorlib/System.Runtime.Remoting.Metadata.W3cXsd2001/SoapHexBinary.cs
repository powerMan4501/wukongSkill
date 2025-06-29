using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapHexBinary : ISoapXsd
{
	private byte[] _value;

	private StringBuilder sb = new StringBuilder(100);

	public static string XsdType => "hexBinary";

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

	public SoapHexBinary()
	{
	}

	public SoapHexBinary(byte[] value)
	{
		_value = value;
	}

	public override string ToString()
	{
		sb.Length = 0;
		for (int i = 0; i < _value.Length; i++)
		{
			string text = _value[i].ToString("X", CultureInfo.InvariantCulture);
			if (text.Length == 1)
			{
				sb.Append('0');
			}
			sb.Append(text);
		}
		return sb.ToString();
	}

	public static SoapHexBinary Parse(string value)
	{
		return new SoapHexBinary(ToByteArray(SoapType.FilterBin64(value)));
	}

	private static byte[] ToByteArray(string value)
	{
		char[] array = value.ToCharArray();
		if (array.Length % 2 != 0)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid"), "xsd:hexBinary", value));
		}
		byte[] array2 = new byte[array.Length / 2];
		for (int i = 0; i < array.Length / 2; i++)
		{
			array2[i] = (byte)(ToByte(array[i * 2], value) * 16 + ToByte(array[i * 2 + 1], value));
		}
		return array2;
	}

	private static byte ToByte(char c, string value)
	{
		byte b = 0;
		string text = c.ToString();
		try
		{
			text = c.ToString();
			return byte.Parse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		catch (Exception)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid", "xsd:hexBinary", value));
		}
	}
}
