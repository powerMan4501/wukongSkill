using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security.Util;
using System.Text;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class PermissionSetAttribute : CodeAccessSecurityAttribute
{
	private string m_file;

	private string m_name;

	private bool m_unicode;

	private string m_xml;

	private string m_hex;

	public string File
	{
		get
		{
			return m_file;
		}
		set
		{
			m_file = value;
		}
	}

	public bool UnicodeEncoded
	{
		get
		{
			return m_unicode;
		}
		set
		{
			m_unicode = value;
		}
	}

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			m_name = value;
		}
	}

	public string XML
	{
		get
		{
			return m_xml;
		}
		set
		{
			m_xml = value;
		}
	}

	public string Hex
	{
		get
		{
			return m_hex;
		}
		set
		{
			m_hex = value;
		}
	}

	public PermissionSetAttribute(SecurityAction action)
		: base(action)
	{
		m_unicode = false;
	}

	public override IPermission CreatePermission()
	{
		return null;
	}

	private PermissionSet BruteForceParseStream(Stream stream)
	{
		Encoding[] array = new Encoding[3]
		{
			Encoding.UTF8,
			Encoding.ASCII,
			Encoding.Unicode
		};
		StreamReader streamReader = null;
		Exception ex = null;
		int num = 0;
		while (streamReader == null && num < array.Length)
		{
			try
			{
				stream.Position = 0L;
				streamReader = new StreamReader(stream, array[num]);
				return ParsePermissionSet(new Parser(streamReader));
			}
			catch (Exception ex2)
			{
				if (ex == null)
				{
					ex = ex2;
				}
			}
			num++;
		}
		throw ex;
	}

	private PermissionSet ParsePermissionSet(Parser parser)
	{
		SecurityElement topElement = parser.GetTopElement();
		PermissionSet permissionSet = new PermissionSet(PermissionState.None);
		permissionSet.FromXml(topElement);
		return permissionSet;
	}

	[SecuritySafeCritical]
	public PermissionSet CreatePermissionSet()
	{
		if (m_unrestricted)
		{
			return new PermissionSet(PermissionState.Unrestricted);
		}
		if (m_name != null)
		{
			return PolicyLevel.GetBuiltInSet(m_name);
		}
		if (m_xml != null)
		{
			return ParsePermissionSet(new Parser(m_xml.ToCharArray()));
		}
		if (m_hex != null)
		{
			return BruteForceParseStream(new MemoryStream(System.Security.Util.Hex.DecodeHexString(m_hex)));
		}
		if (m_file != null)
		{
			return BruteForceParseStream(new FileStream(m_file, FileMode.Open, FileAccess.Read));
		}
		return new PermissionSet(PermissionState.None);
	}
}
