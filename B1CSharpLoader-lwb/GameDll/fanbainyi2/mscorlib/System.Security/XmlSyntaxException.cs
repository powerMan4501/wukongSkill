using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security;

[Serializable]
[ComVisible(true)]
public sealed class XmlSyntaxException : SystemException
{
	public XmlSyntaxException()
		: base(Environment.GetResourceString("XMLSyntax_InvalidSyntax"))
	{
		SetErrorCode(-2146233320);
	}

	public XmlSyntaxException(string message)
		: base(message)
	{
		SetErrorCode(-2146233320);
	}

	public XmlSyntaxException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233320);
	}

	public XmlSyntaxException(int lineNumber)
		: base(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("XMLSyntax_SyntaxError"), lineNumber))
	{
		SetErrorCode(-2146233320);
	}

	public XmlSyntaxException(int lineNumber, string message)
		: base(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("XMLSyntax_SyntaxErrorEx"), lineNumber, message))
	{
		SetErrorCode(-2146233320);
	}

	internal XmlSyntaxException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
