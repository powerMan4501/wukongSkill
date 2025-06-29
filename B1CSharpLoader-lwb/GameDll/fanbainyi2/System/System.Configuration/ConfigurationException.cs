using System.Configuration.Internal;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Xml;

namespace System.Configuration;

[Serializable]
public class ConfigurationException : SystemException
{
	private const string HTTP_PREFIX = "http:";

	private string _filename;

	private int _line;

	public override string Message
	{
		get
		{
			string filename = Filename;
			if (!string.IsNullOrEmpty(filename))
			{
				if (Line != 0)
				{
					return BareMessage + " (" + filename + " line " + Line.ToString(CultureInfo.InvariantCulture) + ")";
				}
				return BareMessage + " (" + filename + ")";
			}
			if (Line != 0)
			{
				return BareMessage + " (line " + Line.ToString("G", CultureInfo.InvariantCulture) + ")";
			}
			return BareMessage;
		}
	}

	public virtual string BareMessage => base.Message;

	public virtual string Filename => SafeFilename(_filename);

	public virtual int Line => _line;

	private void Init(string filename, int line)
	{
		base.HResult = -2146232062;
		_filename = filename;
		_line = line;
	}

	protected ConfigurationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Init(info.GetString("filename"), info.GetInt32("line"));
	}

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	public ConfigurationException()
		: this(null, null, null, 0)
	{
	}

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	public ConfigurationException(string message)
		: this(message, null, null, 0)
	{
	}

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	public ConfigurationException(string message, Exception inner)
		: this(message, inner, null, 0)
	{
	}

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	public ConfigurationException(string message, XmlNode node)
		: this(message, null, GetUnsafeXmlNodeFilename(node), GetXmlNodeLineNumber(node))
	{
	}

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	public ConfigurationException(string message, Exception inner, XmlNode node)
		: this(message, inner, GetUnsafeXmlNodeFilename(node), GetXmlNodeLineNumber(node))
	{
	}

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	public ConfigurationException(string message, string filename, int line)
		: this(message, null, filename, line)
	{
	}

	[Obsolete("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
	public ConfigurationException(string message, Exception inner, string filename, int line)
		: base(message, inner)
	{
		Init(filename, line);
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("filename", _filename);
		info.AddValue("line", _line);
	}

	[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetFilename instead")]
	public static string GetXmlNodeFilename(XmlNode node)
	{
		return SafeFilename(GetUnsafeXmlNodeFilename(node));
	}

	[Obsolete("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetLinenumber instead")]
	public static int GetXmlNodeLineNumber(XmlNode node)
	{
		if (node is IConfigErrorInfo configErrorInfo)
		{
			return configErrorInfo.LineNumber;
		}
		return 0;
	}

	[FileIOPermission(SecurityAction.Assert, AllFiles = FileIOPermissionAccess.PathDiscovery)]
	private static string FullPathWithAssert(string filename)
	{
		string result = null;
		try
		{
			result = Path.GetFullPath(filename);
		}
		catch
		{
		}
		return result;
	}

	internal static string SafeFilename(string filename)
	{
		if (string.IsNullOrEmpty(filename))
		{
			return filename;
		}
		if (filename.StartsWith("http:", StringComparison.OrdinalIgnoreCase))
		{
			return filename;
		}
		try
		{
			if (!Path.IsPathRooted(filename))
			{
				return filename;
			}
		}
		catch
		{
			return null;
		}
		try
		{
			string fullPath = Path.GetFullPath(filename);
		}
		catch (SecurityException)
		{
			try
			{
				string path = FullPathWithAssert(filename);
				filename = Path.GetFileName(path);
			}
			catch
			{
				filename = null;
			}
		}
		catch
		{
			filename = null;
		}
		return filename;
	}

	private static string GetUnsafeXmlNodeFilename(XmlNode node)
	{
		if (node is IConfigErrorInfo configErrorInfo)
		{
			return configErrorInfo.Filename;
		}
		return string.Empty;
	}
}
