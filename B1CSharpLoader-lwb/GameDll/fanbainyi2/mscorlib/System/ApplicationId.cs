using System.Runtime.InteropServices;
using System.Security.Util;
using System.Text;

namespace System;

[Serializable]
[ComVisible(true)]
public sealed class ApplicationId
{
	private string m_name;

	private Version m_version;

	private string m_processorArchitecture;

	private string m_culture;

	internal byte[] m_publicKeyToken;

	public byte[] PublicKeyToken
	{
		get
		{
			byte[] array = new byte[m_publicKeyToken.Length];
			Array.Copy(m_publicKeyToken, 0, array, 0, m_publicKeyToken.Length);
			return array;
		}
	}

	public string Name => m_name;

	public Version Version => m_version;

	public string ProcessorArchitecture => m_processorArchitecture;

	public string Culture => m_culture;

	internal ApplicationId()
	{
	}

	public ApplicationId(byte[] publicKeyToken, string name, Version version, string processorArchitecture, string culture)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyApplicationName"));
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		if (publicKeyToken == null)
		{
			throw new ArgumentNullException("publicKeyToken");
		}
		m_publicKeyToken = new byte[publicKeyToken.Length];
		Array.Copy(publicKeyToken, 0, m_publicKeyToken, 0, publicKeyToken.Length);
		m_name = name;
		m_version = version;
		m_processorArchitecture = processorArchitecture;
		m_culture = culture;
	}

	public ApplicationId Copy()
	{
		return new ApplicationId(m_publicKeyToken, m_name, m_version, m_processorArchitecture, m_culture);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		stringBuilder.Append(m_name);
		if (m_culture != null)
		{
			stringBuilder.Append(", culture=\"");
			stringBuilder.Append(m_culture);
			stringBuilder.Append("\"");
		}
		stringBuilder.Append(", version=\"");
		stringBuilder.Append(m_version.ToString());
		stringBuilder.Append("\"");
		if (m_publicKeyToken != null)
		{
			stringBuilder.Append(", publicKeyToken=\"");
			stringBuilder.Append(Hex.EncodeHexString(m_publicKeyToken));
			stringBuilder.Append("\"");
		}
		if (m_processorArchitecture != null)
		{
			stringBuilder.Append(", processorArchitecture =\"");
			stringBuilder.Append(m_processorArchitecture);
			stringBuilder.Append("\"");
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	public override bool Equals(object o)
	{
		if (!(o is ApplicationId applicationId))
		{
			return false;
		}
		if (!object.Equals(m_name, applicationId.m_name) || !object.Equals(m_version, applicationId.m_version) || !object.Equals(m_processorArchitecture, applicationId.m_processorArchitecture) || !object.Equals(m_culture, applicationId.m_culture))
		{
			return false;
		}
		if (m_publicKeyToken.Length != applicationId.m_publicKeyToken.Length)
		{
			return false;
		}
		for (int i = 0; i < m_publicKeyToken.Length; i++)
		{
			if (m_publicKeyToken[i] != applicationId.m_publicKeyToken[i])
			{
				return false;
			}
		}
		return true;
	}

	public override int GetHashCode()
	{
		return m_name.GetHashCode() ^ m_version.GetHashCode();
	}
}
