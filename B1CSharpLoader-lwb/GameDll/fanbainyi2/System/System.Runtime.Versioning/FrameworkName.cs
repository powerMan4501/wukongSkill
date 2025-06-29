using System.Text;

namespace System.Runtime.Versioning;

[Serializable]
[global::__DynamicallyInvokable]
public sealed class FrameworkName : IEquatable<FrameworkName>
{
	private readonly string m_identifier;

	private readonly Version m_version;

	private readonly string m_profile;

	private string m_fullName;

	private const char c_componentSeparator = ',';

	private const char c_keyValueSeparator = '=';

	private const char c_versionValuePrefix = 'v';

	private const string c_versionKey = "Version";

	private const string c_profileKey = "Profile";

	[global::__DynamicallyInvokable]
	public string Identifier
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_identifier;
		}
	}

	[global::__DynamicallyInvokable]
	public Version Version
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_version;
		}
	}

	[global::__DynamicallyInvokable]
	public string Profile
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_profile;
		}
	}

	[global::__DynamicallyInvokable]
	public string FullName
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (m_fullName == null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(Identifier);
				stringBuilder.Append(',');
				stringBuilder.Append("Version").Append('=');
				stringBuilder.Append('v');
				stringBuilder.Append(Version);
				if (!string.IsNullOrEmpty(Profile))
				{
					stringBuilder.Append(',');
					stringBuilder.Append("Profile").Append('=');
					stringBuilder.Append(Profile);
				}
				m_fullName = stringBuilder.ToString();
			}
			return m_fullName;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		return Equals(obj as FrameworkName);
	}

	[global::__DynamicallyInvokable]
	public bool Equals(FrameworkName other)
	{
		if ((object)other == null)
		{
			return false;
		}
		if (Identifier == other.Identifier && Version == other.Version)
		{
			return Profile == other.Profile;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return Identifier.GetHashCode() ^ Version.GetHashCode() ^ Profile.GetHashCode();
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return FullName;
	}

	[global::__DynamicallyInvokable]
	public FrameworkName(string identifier, Version version)
		: this(identifier, version, null)
	{
	}

	[global::__DynamicallyInvokable]
	public FrameworkName(string identifier, Version version, string profile)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (identifier.Trim().Length == 0)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "identifier"), "identifier");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		m_identifier = identifier.Trim();
		m_version = (Version)version.Clone();
		m_profile = ((profile == null) ? string.Empty : profile.Trim());
	}

	[global::__DynamicallyInvokable]
	public FrameworkName(string frameworkName)
	{
		if (frameworkName == null)
		{
			throw new ArgumentNullException("frameworkName");
		}
		if (frameworkName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("net_emptystringcall", "frameworkName"), "frameworkName");
		}
		string[] array = frameworkName.Split(',');
		if (array.Length < 2 || array.Length > 3)
		{
			throw new ArgumentException(SR.GetString("Argument_FrameworkNameTooShort"), "frameworkName");
		}
		m_identifier = array[0].Trim();
		if (m_identifier.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_FrameworkNameInvalid"), "frameworkName");
		}
		bool flag = false;
		m_profile = string.Empty;
		for (int i = 1; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('=');
			if (array2.Length != 2)
			{
				throw new ArgumentException(SR.GetString("Argument_FrameworkNameInvalid"), "frameworkName");
			}
			string text = array2[0].Trim();
			string text2 = array2[1].Trim();
			if (text.Equals("Version", StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
				if (text2.Length > 0 && (text2[0] == 'v' || text2[0] == 'V'))
				{
					text2 = text2.Substring(1);
				}
				try
				{
					m_version = new Version(text2);
				}
				catch (Exception innerException)
				{
					throw new ArgumentException(SR.GetString("Argument_FrameworkNameInvalidVersion"), "frameworkName", innerException);
				}
			}
			else
			{
				if (!text.Equals("Profile", StringComparison.OrdinalIgnoreCase))
				{
					throw new ArgumentException(SR.GetString("Argument_FrameworkNameInvalid"), "frameworkName");
				}
				if (!string.IsNullOrEmpty(text2))
				{
					m_profile = text2;
				}
			}
		}
		if (!flag)
		{
			throw new ArgumentException(SR.GetString("Argument_FrameworkNameMissingVersion"), "frameworkName");
		}
	}

	[global::__DynamicallyInvokable]
	public static bool operator ==(FrameworkName left, FrameworkName right)
	{
		return left?.Equals(right) ?? ((object)right == null);
	}

	[global::__DynamicallyInvokable]
	public static bool operator !=(FrameworkName left, FrameworkName right)
	{
		return !(left == right);
	}
}
