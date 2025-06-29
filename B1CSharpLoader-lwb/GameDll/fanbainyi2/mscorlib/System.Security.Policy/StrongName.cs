using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class StrongName : EvidenceBase, IIdentityPermissionFactory, IDelayEvaluatedEvidence
{
	private StrongNamePublicKeyBlob m_publicKeyBlob;

	private string m_name;

	private Version m_version;

	[NonSerialized]
	private RuntimeAssembly m_assembly;

	[NonSerialized]
	private bool m_wasUsed;

	public StrongNamePublicKeyBlob PublicKey => m_publicKeyBlob;

	public string Name => m_name;

	public Version Version => m_version;

	bool IDelayEvaluatedEvidence.IsVerified
	{
		[SecurityCritical]
		get
		{
			if (!(m_assembly != null))
			{
				return true;
			}
			return m_assembly.IsStrongNameVerified;
		}
	}

	bool IDelayEvaluatedEvidence.WasUsed => m_wasUsed;

	internal StrongName()
	{
	}

	public StrongName(StrongNamePublicKeyBlob blob, string name, Version version)
		: this(blob, name, version, null)
	{
	}

	internal StrongName(StrongNamePublicKeyBlob blob, string name, Version version, Assembly assembly)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyStrongName"));
		}
		if (blob == null)
		{
			throw new ArgumentNullException("blob");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		RuntimeAssembly runtimeAssembly = assembly as RuntimeAssembly;
		if (assembly != null && runtimeAssembly == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"), "assembly");
		}
		m_publicKeyBlob = blob;
		m_name = name;
		m_version = version;
		m_assembly = runtimeAssembly;
	}

	void IDelayEvaluatedEvidence.MarkUsed()
	{
		m_wasUsed = true;
	}

	internal static bool CompareNames(string asmName, string mcName)
	{
		if (mcName.Length > 0 && mcName[mcName.Length - 1] == '*' && mcName.Length - 1 <= asmName.Length)
		{
			return string.Compare(mcName, 0, asmName, 0, mcName.Length - 1, StringComparison.OrdinalIgnoreCase) == 0;
		}
		return string.Compare(mcName, asmName, StringComparison.OrdinalIgnoreCase) == 0;
	}

	public IPermission CreateIdentityPermission(Evidence evidence)
	{
		return new StrongNameIdentityPermission(m_publicKeyBlob, m_name, m_version);
	}

	public override EvidenceBase Clone()
	{
		return new StrongName(m_publicKeyBlob, m_name, m_version);
	}

	public object Copy()
	{
		return Clone();
	}

	internal SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("StrongName");
		securityElement.AddAttribute("version", "1");
		if (m_publicKeyBlob != null)
		{
			securityElement.AddAttribute("Key", Hex.EncodeHexString(m_publicKeyBlob.PublicKey));
		}
		if (m_name != null)
		{
			securityElement.AddAttribute("Name", m_name);
		}
		if (m_version != null)
		{
			securityElement.AddAttribute("Version", m_version.ToString());
		}
		return securityElement;
	}

	internal void FromXml(SecurityElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (string.Compare(element.Tag, "StrongName", StringComparison.Ordinal) != 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXML"));
		}
		m_publicKeyBlob = null;
		m_version = null;
		string text = element.Attribute("Key");
		if (text != null)
		{
			m_publicKeyBlob = new StrongNamePublicKeyBlob(Hex.DecodeHexString(text));
		}
		m_name = element.Attribute("Name");
		string text2 = element.Attribute("Version");
		if (text2 != null)
		{
			m_version = new Version(text2);
		}
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}

	public override bool Equals(object o)
	{
		if (o is StrongName strongName && object.Equals(m_publicKeyBlob, strongName.m_publicKeyBlob) && object.Equals(m_name, strongName.m_name))
		{
			return object.Equals(m_version, strongName.m_version);
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (m_publicKeyBlob != null)
		{
			return m_publicKeyBlob.GetHashCode();
		}
		if (m_name != null || m_version != null)
		{
			return ((m_name != null) ? m_name.GetHashCode() : 0) + ((!(m_version == null)) ? m_version.GetHashCode() : 0);
		}
		return typeof(StrongName).GetHashCode();
	}

	internal object Normalize()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(m_publicKeyBlob.PublicKey);
		binaryWriter.Write(m_version.Major);
		binaryWriter.Write(m_name);
		memoryStream.Position = 0L;
		return memoryStream;
	}
}
