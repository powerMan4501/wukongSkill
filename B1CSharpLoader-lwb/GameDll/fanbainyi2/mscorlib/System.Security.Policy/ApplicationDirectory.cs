using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class ApplicationDirectory : EvidenceBase
{
	private URLString m_appDirectory;

	public string Directory => m_appDirectory.ToString();

	public ApplicationDirectory(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		m_appDirectory = new URLString(name);
	}

	private ApplicationDirectory(URLString appDirectory)
	{
		m_appDirectory = appDirectory;
	}

	public override bool Equals(object o)
	{
		if (!(o is ApplicationDirectory applicationDirectory))
		{
			return false;
		}
		return m_appDirectory.Equals(applicationDirectory.m_appDirectory);
	}

	public override int GetHashCode()
	{
		return m_appDirectory.GetHashCode();
	}

	public override EvidenceBase Clone()
	{
		return new ApplicationDirectory(m_appDirectory);
	}

	public object Copy()
	{
		return Clone();
	}

	internal SecurityElement ToXml()
	{
		SecurityElement securityElement = new SecurityElement("System.Security.Policy.ApplicationDirectory");
		securityElement.AddAttribute("version", "1");
		if (m_appDirectory != null)
		{
			securityElement.AddChild(new SecurityElement("Directory", m_appDirectory.ToString()));
		}
		return securityElement;
	}

	public override string ToString()
	{
		return ToXml().ToString();
	}
}
