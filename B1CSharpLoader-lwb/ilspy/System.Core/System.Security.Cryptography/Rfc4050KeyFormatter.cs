using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace System.Security.Cryptography;

internal static class Rfc4050KeyFormatter
{
	private const string DomainParametersRoot = "DomainParameters";

	private const string ECDHRoot = "ECDHKeyValue";

	private const string ECDsaRoot = "ECDSAKeyValue";

	private const string NamedCurveElement = "NamedCurve";

	private const string Namespace = "http://www.w3.org/2001/04/xmldsig-more#";

	private const string OidUrnPrefix = "urn:oid:";

	private const string PublicKeyRoot = "PublicKey";

	private const string UrnAttribute = "URN";

	private const string ValueAttribute = "Value";

	private const string XElement = "X";

	private const string YElement = "Y";

	private const string XsiTypeAttribute = "type";

	private const string XsiTypeAttributeValue = "PrimeFieldElemType";

	private const string XsiNamespace = "http://www.w3.org/2001/XMLSchema-instance";

	private const string XsiNamespacePrefix = "xsi";

	private const string ECDSA_P256_OID_VALUE = "1.2.840.10045.3.1.7";

	private const string ECDSA_P384_OID_VALUE = "1.3.132.0.34";

	private const string ECDSA_P521_OID_VALUE = "1.3.132.0.35";

	internal static ECParameters FromXml(string xml, out bool isEcdh)
	{
		ECParameters parameters = default(ECParameters);
		using TextReader input = new StringReader(xml);
		using XmlTextReader reader = new XmlTextReader(input);
		XPathDocument xPathDocument = new XPathDocument(reader);
		XPathNavigator xPathNavigator = xPathDocument.CreateNavigator();
		if (!xPathNavigator.MoveToFirstChild())
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingDomainParameters"));
		}
		parameters.Curve = ReadCurve(xPathNavigator, out isEcdh);
		if (!xPathNavigator.MoveToNext(XPathNodeType.Element))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingPublicKey"));
		}
		ReadPublicKey(xPathNavigator, ref parameters);
		return parameters;
	}

	private static ECCurve ReadCurve(XPathNavigator navigator, out bool isEcdh)
	{
		if (navigator.NamespaceURI != "http://www.w3.org/2001/04/xmldsig-more#")
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_UnexpectedXmlNamespace", navigator.NamespaceURI, "http://www.w3.org/2001/04/xmldsig-more#"));
		}
		bool flag = navigator.Name == "ECDHKeyValue";
		bool flag2 = navigator.Name == "ECDSAKeyValue";
		if (!flag && !flag2)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_UnknownEllipticCurveAlgorithm"));
		}
		if (!navigator.MoveToFirstChild() || navigator.Name != "DomainParameters")
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingDomainParameters"));
		}
		if (!navigator.MoveToFirstChild() || navigator.Name != "NamedCurve")
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingDomainParameters"));
		}
		if (!navigator.MoveToFirstAttribute() || navigator.Name != "URN" || string.IsNullOrEmpty(navigator.Value))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingDomainParameters"));
		}
		string value = navigator.Value;
		if (!value.StartsWith("urn:oid:", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_UnknownEllipticCurve"));
		}
		navigator.MoveToParent();
		navigator.MoveToParent();
		isEcdh = flag;
		return ECCurve.CreateFromValue(value.Substring("urn:oid:".Length));
	}

	private static void ReadPublicKey(XPathNavigator navigator, ref ECParameters parameters)
	{
		if (navigator.NamespaceURI != "http://www.w3.org/2001/04/xmldsig-more#")
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_UnexpectedXmlNamespace", navigator.NamespaceURI, "http://www.w3.org/2001/04/xmldsig-more#"));
		}
		if (navigator.Name != "PublicKey")
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingPublicKey"));
		}
		if (!navigator.MoveToFirstChild() || navigator.Name != "X")
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingPublicKey"));
		}
		if (!navigator.MoveToFirstAttribute() || navigator.Name != "Value" || string.IsNullOrEmpty(navigator.Value))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingPublicKey"));
		}
		BigInteger bigInteger = BigInteger.Parse(navigator.Value, CultureInfo.InvariantCulture);
		navigator.MoveToParent();
		if (!navigator.MoveToNext(XPathNodeType.Element) || navigator.Name != "Y")
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingPublicKey"));
		}
		if (!navigator.MoveToFirstAttribute() || navigator.Name != "Value" || string.IsNullOrEmpty(navigator.Value))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_MissingPublicKey"));
		}
		BigInteger bigInteger2 = BigInteger.Parse(navigator.Value, CultureInfo.InvariantCulture);
		byte[] array = bigInteger.ToByteArray();
		byte[] array2 = bigInteger2.ToByteArray();
		int num = array.Length;
		int num2 = array2.Length;
		if (num > 0 && array[num - 1] == 0)
		{
			num--;
		}
		if (num2 > 0 && array2[num2 - 1] == 0)
		{
			num2--;
		}
		int num3 = Math.Max(num, num2);
		try
		{
			using ECDsa eCDsa = ECDsa.Create(parameters.Curve);
			int val = (eCDsa.KeySize + 7) / 8;
			num3 = Math.Max(num3, val);
		}
		catch (ArgumentException)
		{
		}
		catch (CryptographicException)
		{
		}
		catch (NotSupportedException)
		{
		}
		Array.Resize(ref array, num3);
		Array.Resize(ref array2, num3);
		Array.Reverse(array);
		Array.Reverse(array2);
		parameters.Q.X = array;
		parameters.Q.Y = array2;
	}

	private static void WriteDomainParameters(XmlWriter writer, ref ECParameters parameters)
	{
		Oid oid = parameters.Curve.Oid;
		if (!parameters.Curve.IsNamed || oid == null)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_UnknownEllipticCurve"));
		}
		string text = oid.Value;
		if (string.IsNullOrEmpty(text))
		{
			switch (oid.FriendlyName)
			{
			case "nistP256":
				text = "1.2.840.10045.3.1.7";
				break;
			case "nistP384":
				text = "1.3.132.0.34";
				break;
			case "nistP521":
				text = "1.3.132.0.35";
				break;
			default:
			{
				Oid oid2 = new Oid();
				oid2.FriendlyName = oid.FriendlyName;
				text = oid2.Value;
				break;
			}
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_UnknownEllipticCurve"));
		}
		writer.WriteStartElement("DomainParameters");
		writer.WriteStartElement("NamedCurve");
		writer.WriteAttributeString("URN", "urn:oid:" + text);
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	private static void WritePublicKeyValue(XmlWriter writer, ref ECParameters parameters)
	{
		writer.WriteStartElement("PublicKey");
		byte[] x = parameters.Q.X;
		byte[] y = parameters.Q.Y;
		int num = x.Length;
		int num2 = y.Length;
		if ((x[0] & 0x80) == 128)
		{
			num++;
		}
		if ((y[0] & 0x80) == 128)
		{
			num2++;
		}
		byte[] array = new byte[num];
		byte[] array2 = new byte[num2];
		Buffer.BlockCopy(x, 0, array, num - x.Length, x.Length);
		Buffer.BlockCopy(y, 0, array2, num2 - y.Length, y.Length);
		Array.Reverse(array);
		Array.Reverse(array2);
		BigInteger bigInteger = new BigInteger(array);
		BigInteger bigInteger2 = new BigInteger(array2);
		writer.WriteStartElement("X");
		writer.WriteAttributeString("Value", bigInteger.ToString("R", CultureInfo.InvariantCulture));
		writer.WriteAttributeString("xsi", "type", "http://www.w3.org/2001/XMLSchema-instance", "PrimeFieldElemType");
		writer.WriteEndElement();
		writer.WriteStartElement("Y");
		writer.WriteAttributeString("Value", bigInteger2.ToString("R", CultureInfo.InvariantCulture));
		writer.WriteAttributeString("xsi", "type", "http://www.w3.org/2001/XMLSchema-instance", "PrimeFieldElemType");
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	internal static string ToXml(ECParameters parameters, bool isEcdh)
	{
		parameters.Validate();
		StringBuilder stringBuilder = new StringBuilder();
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Indent = true;
		xmlWriterSettings.IndentChars = "  ";
		xmlWriterSettings.OmitXmlDeclaration = true;
		using (XmlWriter xmlWriter = XmlWriter.Create(stringBuilder, xmlWriterSettings))
		{
			string localName = (isEcdh ? "ECDHKeyValue" : "ECDSAKeyValue");
			xmlWriter.WriteStartElement(localName, "http://www.w3.org/2001/04/xmldsig-more#");
			WriteDomainParameters(xmlWriter, ref parameters);
			WritePublicKeyValue(xmlWriter, ref parameters);
			xmlWriter.WriteEndElement();
		}
		return stringBuilder.ToString();
	}
}
