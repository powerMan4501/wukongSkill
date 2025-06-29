using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public class CodeConnectAccess
{
	private string _LowerCaseScheme;

	private string _LowerCasePort;

	private int _IntPort;

	private const string DefaultStr = "$default";

	private const string OriginStr = "$origin";

	internal const int NoPort = -1;

	internal const int AnyPort = -2;

	public static readonly int DefaultPort = -3;

	public static readonly int OriginPort = -4;

	public static readonly string OriginScheme = "$origin";

	public static readonly string AnyScheme = "*";

	public string Scheme => _LowerCaseScheme;

	public int Port => _IntPort;

	internal bool IsOriginScheme => (object)_LowerCaseScheme == OriginScheme;

	internal bool IsAnyScheme => (object)_LowerCaseScheme == AnyScheme;

	internal bool IsDefaultPort => Port == DefaultPort;

	internal bool IsOriginPort => Port == OriginPort;

	internal string StrPort => _LowerCasePort;

	public CodeConnectAccess(string allowScheme, int allowPort)
	{
		if (!IsValidScheme(allowScheme))
		{
			throw new ArgumentOutOfRangeException("allowScheme");
		}
		SetCodeConnectAccess(allowScheme.ToLower(CultureInfo.InvariantCulture), allowPort);
	}

	public static CodeConnectAccess CreateOriginSchemeAccess(int allowPort)
	{
		CodeConnectAccess codeConnectAccess = new CodeConnectAccess();
		codeConnectAccess.SetCodeConnectAccess(OriginScheme, allowPort);
		return codeConnectAccess;
	}

	public static CodeConnectAccess CreateAnySchemeAccess(int allowPort)
	{
		CodeConnectAccess codeConnectAccess = new CodeConnectAccess();
		codeConnectAccess.SetCodeConnectAccess(AnyScheme, allowPort);
		return codeConnectAccess;
	}

	private CodeConnectAccess()
	{
	}

	private void SetCodeConnectAccess(string lowerCaseScheme, int allowPort)
	{
		_LowerCaseScheme = lowerCaseScheme;
		if (allowPort == DefaultPort)
		{
			_LowerCasePort = "$default";
		}
		else if (allowPort == OriginPort)
		{
			_LowerCasePort = "$origin";
		}
		else
		{
			if (allowPort < 0 || allowPort > 65535)
			{
				throw new ArgumentOutOfRangeException("allowPort");
			}
			_LowerCasePort = allowPort.ToString(CultureInfo.InvariantCulture);
		}
		_IntPort = allowPort;
	}

	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (!(o is CodeConnectAccess codeConnectAccess))
		{
			return false;
		}
		if (Scheme == codeConnectAccess.Scheme)
		{
			return Port == codeConnectAccess.Port;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Scheme.GetHashCode() + Port.GetHashCode();
	}

	internal CodeConnectAccess(string allowScheme, string allowPort)
	{
		if (allowScheme == null || allowScheme.Length == 0)
		{
			throw new ArgumentNullException("allowScheme");
		}
		if (allowPort == null || allowPort.Length == 0)
		{
			throw new ArgumentNullException("allowPort");
		}
		_LowerCaseScheme = allowScheme.ToLower(CultureInfo.InvariantCulture);
		if (_LowerCaseScheme == OriginScheme)
		{
			_LowerCaseScheme = OriginScheme;
		}
		else if (_LowerCaseScheme == AnyScheme)
		{
			_LowerCaseScheme = AnyScheme;
		}
		else if (!IsValidScheme(_LowerCaseScheme))
		{
			throw new ArgumentOutOfRangeException("allowScheme");
		}
		_LowerCasePort = allowPort.ToLower(CultureInfo.InvariantCulture);
		if (_LowerCasePort == "$default")
		{
			_IntPort = DefaultPort;
			return;
		}
		if (_LowerCasePort == "$origin")
		{
			_IntPort = OriginPort;
			return;
		}
		_IntPort = int.Parse(allowPort, CultureInfo.InvariantCulture);
		if (_IntPort < 0 || _IntPort > 65535)
		{
			throw new ArgumentOutOfRangeException("allowPort");
		}
		_LowerCasePort = _IntPort.ToString(CultureInfo.InvariantCulture);
	}

	internal static bool IsValidScheme(string scheme)
	{
		if (scheme == null || scheme.Length == 0 || !IsAsciiLetter(scheme[0]))
		{
			return false;
		}
		for (int num = scheme.Length - 1; num > 0; num--)
		{
			if (!IsAsciiLetterOrDigit(scheme[num]) && scheme[num] != '+' && scheme[num] != '-' && scheme[num] != '.')
			{
				return false;
			}
		}
		return true;
	}

	private static bool IsAsciiLetterOrDigit(char character)
	{
		if (!IsAsciiLetter(character))
		{
			if (character >= '0')
			{
				return character <= '9';
			}
			return false;
		}
		return true;
	}

	private static bool IsAsciiLetter(char character)
	{
		if (character < 'a' || character > 'z')
		{
			if (character >= 'A')
			{
				return character <= 'Z';
			}
			return false;
		}
		return true;
	}
}
