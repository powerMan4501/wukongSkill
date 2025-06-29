using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System.Security.Util;

[Serializable]
internal sealed class URLString : SiteString
{
	private string m_protocol;

	[OptionalField(VersionAdded = 2)]
	private string m_userpass;

	private SiteString m_siteString;

	private int m_port;

	private LocalSiteString m_localSite;

	private DirectoryString m_directory;

	private const string m_defaultProtocol = "file";

	[OptionalField(VersionAdded = 2)]
	private bool m_parseDeferred;

	[OptionalField(VersionAdded = 2)]
	private string m_urlOriginal;

	[OptionalField(VersionAdded = 2)]
	private bool m_parsedOriginal;

	[OptionalField(VersionAdded = 3)]
	private bool m_isUncShare;

	private string m_fullurl;

	public string Scheme
	{
		get
		{
			DoDeferredParse();
			return m_protocol;
		}
	}

	public string Host
	{
		get
		{
			DoDeferredParse();
			if (m_siteString != null)
			{
				return m_siteString.ToString();
			}
			return m_localSite.ToString();
		}
	}

	public string Port
	{
		get
		{
			DoDeferredParse();
			if (m_port == -1)
			{
				return null;
			}
			return m_port.ToString(CultureInfo.InvariantCulture);
		}
	}

	public string Directory
	{
		get
		{
			DoDeferredParse();
			return m_directory.ToString();
		}
	}

	public bool IsRelativeFileUrl
	{
		get
		{
			DoDeferredParse();
			if (string.Equals(m_protocol, "file", StringComparison.OrdinalIgnoreCase) && !m_isUncShare)
			{
				string text = ((m_localSite != null) ? m_localSite.ToString() : null);
				if (text.EndsWith('*'))
				{
					return false;
				}
				string value = ((m_directory != null) ? m_directory.ToString() : null);
				if (text != null && text.Length >= 2 && text.EndsWith(':'))
				{
					return string.IsNullOrEmpty(value);
				}
				return true;
			}
			return false;
		}
	}

	[OnDeserialized]
	public void OnDeserialized(StreamingContext ctx)
	{
		if (m_urlOriginal == null)
		{
			m_parseDeferred = false;
			m_parsedOriginal = false;
			m_userpass = "";
			m_urlOriginal = m_fullurl;
			m_fullurl = null;
		}
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			DoDeferredParse();
			m_fullurl = m_urlOriginal;
		}
	}

	[OnSerialized]
	private void OnSerialized(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			m_fullurl = null;
		}
	}

	public URLString()
	{
		m_protocol = "";
		m_userpass = "";
		m_siteString = new SiteString();
		m_port = -1;
		m_localSite = null;
		m_directory = new DirectoryString();
		m_parseDeferred = false;
	}

	private void DoDeferredParse()
	{
		if (m_parseDeferred)
		{
			ParseString(m_urlOriginal, m_parsedOriginal);
			m_parseDeferred = false;
		}
	}

	public URLString(string url)
		: this(url, parsed: false, doDeferredParsing: false)
	{
	}

	public URLString(string url, bool parsed)
		: this(url, parsed, doDeferredParsing: false)
	{
	}

	internal URLString(string url, bool parsed, bool doDeferredParsing)
	{
		m_port = -1;
		m_userpass = "";
		DoFastChecks(url);
		m_urlOriginal = url;
		m_parsedOriginal = parsed;
		m_parseDeferred = true;
		if (doDeferredParsing)
		{
			DoDeferredParse();
		}
	}

	private string UnescapeURL(string url)
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire(url.Length);
		int num = 0;
		int num2 = -1;
		int num3 = -1;
		num2 = url.IndexOf('[', num);
		if (num2 != -1)
		{
			num3 = url.IndexOf(']', num2);
		}
		while (true)
		{
			int num4 = url.IndexOf('%', num);
			if (num4 == -1)
			{
				stringBuilder = stringBuilder.Append(url, num, url.Length - num);
				return StringBuilderCache.GetStringAndRelease(stringBuilder);
			}
			if (num4 > num2 && num4 < num3)
			{
				stringBuilder = stringBuilder.Append(url, num, num3 - num + 1);
				num = num3 + 1;
				continue;
			}
			if (url.Length - num4 < 2)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
			}
			if (url[num4 + 1] == 'u' || url[num4 + 1] == 'U')
			{
				if (url.Length - num4 < 6)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
				}
				try
				{
					char value = (char)((Hex.ConvertHexDigit(url[num4 + 2]) << 12) | (Hex.ConvertHexDigit(url[num4 + 3]) << 8) | (Hex.ConvertHexDigit(url[num4 + 4]) << 4) | Hex.ConvertHexDigit(url[num4 + 5]));
					stringBuilder = stringBuilder.Append(url, num, num4 - num);
					stringBuilder = stringBuilder.Append(value);
				}
				catch (ArgumentException)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
				}
				num = num4 + 6;
			}
			else
			{
				if (url.Length - num4 < 3)
				{
					break;
				}
				try
				{
					char value2 = (char)((Hex.ConvertHexDigit(url[num4 + 1]) << 4) | Hex.ConvertHexDigit(url[num4 + 2]));
					stringBuilder = stringBuilder.Append(url, num, num4 - num);
					stringBuilder = stringBuilder.Append(value2);
				}
				catch (ArgumentException)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
				}
				num = num4 + 3;
			}
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
	}

	private string ParseProtocol(string url)
	{
		int num = url.IndexOf(':');
		string result;
		switch (num)
		{
		case 0:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
		case -1:
			m_protocol = "file";
			result = url;
			break;
		default:
			if (url.Length > num + 1)
			{
				if (num == "file".Length && string.Compare(url, 0, "file", 0, num, StringComparison.OrdinalIgnoreCase) == 0)
				{
					m_protocol = "file";
					result = url.Substring(num + 1);
					m_isUncShare = true;
				}
				else if (url[num + 1] != '\\')
				{
					if (url.Length <= num + 2 || url[num + 1] != '/' || url[num + 2] != '/')
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
					}
					m_protocol = url.Substring(0, num);
					for (int i = 0; i < m_protocol.Length; i++)
					{
						char c = m_protocol[i];
						if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c < '0' || c > '9') && c != '+' && c != '.' && c != '-')
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
						}
					}
					result = url.Substring(num + 3);
				}
				else
				{
					m_protocol = "file";
					result = url;
				}
				break;
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
		}
		return result;
	}

	private string ParsePort(string url)
	{
		string text = url;
		char[] anyOf = new char[2] { ':', '/' };
		int num = 0;
		int num2 = text.IndexOf('@');
		if (num2 != -1 && text.IndexOf('/', 0, num2) == -1)
		{
			m_userpass = text.Substring(0, num2);
			num = num2 + 1;
		}
		int num3 = -1;
		int num4 = -1;
		int num5 = -1;
		num3 = url.IndexOf('[', num);
		if (num3 != -1)
		{
			num4 = url.IndexOf(']', num3);
		}
		num5 = ((num4 == -1) ? text.IndexOfAny(anyOf, num) : text.IndexOfAny(anyOf, num4));
		if (num5 != -1 && text[num5] == ':')
		{
			if (text[num5 + 1] >= '0' && text[num5 + 1] <= '9')
			{
				int num6 = text.IndexOf('/', num);
				if (num6 == -1)
				{
					m_port = int.Parse(text.Substring(num5 + 1), CultureInfo.InvariantCulture);
					if (m_port < 0)
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
					}
					return text.Substring(num, num5 - num);
				}
				if (num6 > num5)
				{
					m_port = int.Parse(text.Substring(num5 + 1, num6 - num5 - 1), CultureInfo.InvariantCulture);
					return text.Substring(num, num5 - num) + text.Substring(num6);
				}
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
		}
		return text.Substring(num);
	}

	internal static string PreProcessForExtendedPathRemoval(string url, bool isFileUrl)
	{
		return PreProcessForExtendedPathRemoval(checkPathLength: true, url, isFileUrl);
	}

	internal static string PreProcessForExtendedPathRemoval(bool checkPathLength, string url, bool isFileUrl)
	{
		bool isUncShare = false;
		return PreProcessForExtendedPathRemoval(checkPathLength, url, isFileUrl, ref isUncShare);
	}

	private static string PreProcessForExtendedPathRemoval(string url, bool isFileUrl, ref bool isUncShare)
	{
		return PreProcessForExtendedPathRemoval(checkPathLength: true, url, isFileUrl, ref isUncShare);
	}

	private static string PreProcessForExtendedPathRemoval(bool checkPathLength, string url, bool isFileUrl, ref bool isUncShare)
	{
		StringBuilder stringBuilder = new StringBuilder(url);
		int num = 0;
		int num2 = 0;
		if (url.Length - num >= 4 && (string.Compare(url, num, "//?/", 0, 4, StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(url, num, "//./", 0, 4, StringComparison.OrdinalIgnoreCase) == 0))
		{
			stringBuilder.Remove(num2, 4);
			num += 4;
		}
		else
		{
			if (isFileUrl)
			{
				while (url[num] == '/')
				{
					num++;
					num2++;
				}
			}
			if (url.Length - num >= 4 && (string.Compare(url, num, "\\\\?\\", 0, 4, StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(url, num, "\\\\?/", 0, 4, StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(url, num, "\\\\.\\", 0, 4, StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(url, num, "\\\\./", 0, 4, StringComparison.OrdinalIgnoreCase) == 0))
			{
				stringBuilder.Remove(num2, 4);
				num += 4;
			}
		}
		if (isFileUrl)
		{
			int i = 0;
			bool flag = false;
			for (; i < stringBuilder.Length && (stringBuilder[i] == '/' || stringBuilder[i] == '\\'); i++)
			{
				if (!flag && stringBuilder[i] == '\\')
				{
					flag = true;
					if (i + 1 < stringBuilder.Length && stringBuilder[i + 1] == '\\')
					{
						isUncShare = true;
					}
				}
			}
			stringBuilder.Remove(0, i);
			stringBuilder.Replace('\\', '/');
		}
		if (checkPathLength)
		{
			CheckPathTooLong(stringBuilder);
		}
		return stringBuilder.ToString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CheckPathTooLong(StringBuilder path)
	{
		if (path.Length >= (AppContextSwitches.BlockLongPaths ? 260 : 32767))
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
	}

	private string PreProcessURL(string url, bool isFileURL)
	{
		url = ((!isFileURL) ? url.Replace('\\', '/') : PreProcessForExtendedPathRemoval(url, isFileUrl: true, ref m_isUncShare));
		return url;
	}

	private void ParseFileURL(string url)
	{
		int num = url.IndexOf('/');
		if (num != -1 && ((num == 2 && url[num - 1] != ':' && url[num - 1] != '|') || num != 2) && num != url.Length - 1)
		{
			int num2 = url.IndexOf('/', num + 1);
			num = ((num2 == -1) ? (-1) : num2);
		}
		string text = ((num != -1) ? url.Substring(0, num) : url);
		if (text.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidUrl"));
		}
		bool flag;
		int i;
		if (text[0] == '\\' && text[1] == '\\')
		{
			flag = true;
			i = 2;
		}
		else
		{
			i = 0;
			flag = false;
		}
		bool flag2 = true;
		for (; i < text.Length; i++)
		{
			char c = text[i];
			if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z') && (c < '0' || c > '9') && c != '-' && c != '/' && c != ':' && c != '|' && c != '.' && c != '*' && c != '$' && (!flag || c != ' '))
			{
				flag2 = false;
				break;
			}
		}
		text = ((!flag2) ? text.ToUpper(CultureInfo.InvariantCulture) : string.SmallCharToUpper(text));
		m_localSite = new LocalSiteString(text);
		if (num == -1)
		{
			if (text[text.Length - 1] == '*')
			{
				m_directory = new DirectoryString("*", checkForIllegalChars: false);
			}
			else
			{
				m_directory = new DirectoryString();
			}
		}
		else
		{
			string text2 = url.Substring(num + 1);
			if (text2.Length == 0)
			{
				m_directory = new DirectoryString();
			}
			else
			{
				m_directory = new DirectoryString(text2, checkForIllegalChars: true);
			}
		}
		m_siteString = null;
	}

	private void ParseNonFileURL(string url)
	{
		int num = url.IndexOf('/');
		if (num == -1)
		{
			m_localSite = null;
			m_siteString = new SiteString(url);
			m_directory = new DirectoryString();
			return;
		}
		string site = url.Substring(0, num);
		m_localSite = null;
		m_siteString = new SiteString(site);
		string text = url.Substring(num + 1);
		if (text.Length == 0)
		{
			m_directory = new DirectoryString();
		}
		else
		{
			m_directory = new DirectoryString(text, checkForIllegalChars: false);
		}
	}

	private void DoFastChecks(string url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (url.Length == 0)
		{
			throw new FormatException(Environment.GetResourceString("Format_StringZeroLength"));
		}
	}

	private void ParseString(string url, bool parsed)
	{
		if (!parsed)
		{
			url = UnescapeURL(url);
		}
		string url2 = ParseProtocol(url);
		bool flag = string.Compare(m_protocol, "file", StringComparison.OrdinalIgnoreCase) == 0;
		url2 = PreProcessURL(url2, flag);
		if (flag)
		{
			ParseFileURL(url2);
			return;
		}
		url2 = ParsePort(url2);
		ParseNonFileURL(url2);
	}

	public string GetFileName()
	{
		DoDeferredParse();
		if (string.Compare(m_protocol, "file", StringComparison.OrdinalIgnoreCase) != 0)
		{
			return null;
		}
		string text = Directory.Replace('/', '\\');
		string text2 = Host.Replace('/', '\\');
		int num = text2.IndexOf('\\');
		if (num == -1)
		{
			if (text2.Length != 2 || (text2[1] != ':' && text2[1] != '|'))
			{
				text2 = "\\\\" + text2;
			}
		}
		else if (num != 2 || (num == 2 && text2[1] != ':' && text2[1] != '|'))
		{
			text2 = "\\\\" + text2;
		}
		return text2 + "\\" + text;
	}

	public string GetDirectoryName()
	{
		DoDeferredParse();
		if (string.Compare(m_protocol, "file", StringComparison.OrdinalIgnoreCase) != 0)
		{
			return null;
		}
		string text = Directory.Replace('/', '\\');
		int num = 0;
		for (int num2 = text.Length; num2 > 0; num2--)
		{
			if (text[num2 - 1] == '\\')
			{
				num = num2;
				break;
			}
		}
		string text2 = Host.Replace('/', '\\');
		int num3 = text2.IndexOf('\\');
		if (num3 == -1)
		{
			if (text2.Length != 2 || (text2[1] != ':' && text2[1] != '|'))
			{
				text2 = "\\\\" + text2;
			}
		}
		else if (num3 > 2 || (num3 == 2 && text2[1] != ':' && text2[1] != '|'))
		{
			text2 = "\\\\" + text2;
		}
		text2 += "\\";
		if (num > 0)
		{
			text2 += text.Substring(0, num);
		}
		return text2;
	}

	public override SiteString Copy()
	{
		return new URLString(m_urlOriginal, m_parsedOriginal);
	}

	public override bool IsSubsetOf(SiteString site)
	{
		if (site == null)
		{
			return false;
		}
		if (!(site is URLString uRLString))
		{
			return false;
		}
		DoDeferredParse();
		uRLString.DoDeferredParse();
		URLString uRLString2 = SpecialNormalizeUrl();
		URLString uRLString3 = uRLString.SpecialNormalizeUrl();
		if (string.Compare(uRLString2.m_protocol, uRLString3.m_protocol, StringComparison.OrdinalIgnoreCase) == 0 && uRLString2.m_directory.IsSubsetOf(uRLString3.m_directory))
		{
			if (uRLString2.m_localSite != null)
			{
				return uRLString2.m_localSite.IsSubsetOf(uRLString3.m_localSite);
			}
			if (uRLString2.m_port != uRLString3.m_port)
			{
				return false;
			}
			if (uRLString3.m_siteString != null)
			{
				return uRLString2.m_siteString.IsSubsetOf(uRLString3.m_siteString);
			}
			return false;
		}
		return false;
	}

	public override string ToString()
	{
		return m_urlOriginal;
	}

	public override bool Equals(object o)
	{
		DoDeferredParse();
		if (o == null || !(o is URLString))
		{
			return false;
		}
		return Equals((URLString)o);
	}

	public override int GetHashCode()
	{
		DoDeferredParse();
		TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
		int num = 0;
		if (m_protocol != null)
		{
			num = textInfo.GetCaseInsensitiveHashCode(m_protocol);
		}
		num = ((m_localSite == null) ? (num ^ m_siteString.GetHashCode()) : (num ^ m_localSite.GetHashCode()));
		return num ^ m_directory.GetHashCode();
	}

	public bool Equals(URLString url)
	{
		return CompareUrls(this, url);
	}

	public static bool CompareUrls(URLString url1, URLString url2)
	{
		if (url1 == null && url2 == null)
		{
			return true;
		}
		if (url1 == null || url2 == null)
		{
			return false;
		}
		url1.DoDeferredParse();
		url2.DoDeferredParse();
		URLString uRLString = url1.SpecialNormalizeUrl();
		URLString uRLString2 = url2.SpecialNormalizeUrl();
		if (string.Compare(uRLString.m_protocol, uRLString2.m_protocol, StringComparison.OrdinalIgnoreCase) != 0)
		{
			return false;
		}
		if (string.Compare(uRLString.m_protocol, "file", StringComparison.OrdinalIgnoreCase) == 0)
		{
			if (!uRLString.m_localSite.IsSubsetOf(uRLString2.m_localSite) || !uRLString2.m_localSite.IsSubsetOf(uRLString.m_localSite))
			{
				return false;
			}
		}
		else
		{
			if (string.Compare(uRLString.m_userpass, uRLString2.m_userpass, StringComparison.Ordinal) != 0)
			{
				return false;
			}
			if (!uRLString.m_siteString.IsSubsetOf(uRLString2.m_siteString) || !uRLString2.m_siteString.IsSubsetOf(uRLString.m_siteString))
			{
				return false;
			}
			if (url1.m_port != url2.m_port)
			{
				return false;
			}
		}
		if (!uRLString.m_directory.IsSubsetOf(uRLString2.m_directory) || !uRLString2.m_directory.IsSubsetOf(uRLString.m_directory))
		{
			return false;
		}
		return true;
	}

	internal string NormalizeUrl()
	{
		DoDeferredParse();
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		if (string.Compare(m_protocol, "file", StringComparison.OrdinalIgnoreCase) == 0)
		{
			stringBuilder = stringBuilder.AppendFormat("FILE:///{0}/{1}", m_localSite.ToString(), m_directory.ToString());
		}
		else
		{
			stringBuilder = stringBuilder.AppendFormat("{0}://{1}{2}", m_protocol, m_userpass, m_siteString.ToString());
			if (m_port != -1)
			{
				stringBuilder = stringBuilder.AppendFormat("{0}", m_port);
			}
			stringBuilder = stringBuilder.AppendFormat("/{0}", m_directory.ToString());
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder).ToUpper(CultureInfo.InvariantCulture);
	}

	[SecuritySafeCritical]
	internal URLString SpecialNormalizeUrl()
	{
		DoDeferredParse();
		if (string.Compare(m_protocol, "file", StringComparison.OrdinalIgnoreCase) != 0)
		{
			return this;
		}
		string text = m_localSite.ToString();
		if (text.Length == 2 && (text[1] == '|' || text[1] == ':'))
		{
			string s = null;
			GetDeviceName(text, JitHelpers.GetStringHandleOnStack(ref s));
			if (s != null)
			{
				if (s.IndexOf("://", StringComparison.Ordinal) != -1)
				{
					URLString uRLString = new URLString(s + "/" + m_directory.ToString());
					uRLString.DoDeferredParse();
					return uRLString;
				}
				URLString uRLString2 = new URLString("file://" + s + "/" + m_directory.ToString());
				uRLString2.DoDeferredParse();
				return uRLString2;
			}
			return this;
		}
		return this;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetDeviceName(string driveLetter, StringHandleOnStack retDeviceName);
}
