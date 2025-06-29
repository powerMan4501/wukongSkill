using System.Security.Permissions;
using System.Text.RegularExpressions;

namespace System.Management.Instrumentation;

[AttributeUsage(AttributeTargets.Assembly)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class WmiConfigurationAttribute : Attribute
{
	private string _Scope;

	private string _SecurityRestriction;

	private string _NamespaceSecurity;

	private ManagementHostingModel _HostingModel;

	private string _HostingGroup;

	private bool _IdentifyLevel = true;

	public string SecurityRestriction
	{
		get
		{
			return _SecurityRestriction;
		}
		set
		{
			_SecurityRestriction = value;
		}
	}

	public string NamespaceSecurity
	{
		get
		{
			return _NamespaceSecurity;
		}
		set
		{
			_NamespaceSecurity = value;
		}
	}

	public bool IdentifyLevel
	{
		get
		{
			return _IdentifyLevel;
		}
		set
		{
			_IdentifyLevel = value;
		}
	}

	public ManagementHostingModel HostingModel
	{
		get
		{
			return _HostingModel;
		}
		set
		{
			_HostingModel = value;
		}
	}

	public string HostingGroup
	{
		get
		{
			return _HostingGroup;
		}
		set
		{
			_HostingGroup = value;
		}
	}

	public string Scope => _Scope;

	public WmiConfigurationAttribute(string scope)
	{
		string text = scope;
		if (text != null)
		{
			text = text.Replace('/', '\\');
		}
		if (text == null || text.Length == 0)
		{
			text = "root\\default";
		}
		bool flag = true;
		string[] array = text.Split('\\');
		foreach (string text2 in array)
		{
			if (text2.Length != 0 && (!flag || string.Compare(text2, "root", StringComparison.OrdinalIgnoreCase) == 0) && Regex.Match(text2, "^[a-z,A-Z]").Success && !Regex.Match(text2, "_$").Success)
			{
				_ = Regex.Match(text2, "[^a-z,A-Z,0-9,_,\\u0080-\\uFFFF]").Success;
			}
			flag = false;
		}
		_Scope = text;
	}
}
