using System.ComponentModel;
using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Event, AllowMultiple = true, Inherited = false)]
public class PerformanceCounterPermissionAttribute : CodeAccessSecurityAttribute
{
	private string categoryName;

	private string machineName;

	private PerformanceCounterPermissionAccess permissionAccess;

	public string CategoryName
	{
		get
		{
			return categoryName;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			categoryName = value;
		}
	}

	public string MachineName
	{
		get
		{
			return machineName;
		}
		set
		{
			if (!SyntaxCheck.CheckMachineName(value))
			{
				throw new ArgumentException(SR.GetString("InvalidProperty", "MachineName", value));
			}
			machineName = value;
		}
	}

	public PerformanceCounterPermissionAccess PermissionAccess
	{
		get
		{
			return permissionAccess;
		}
		set
		{
			permissionAccess = value;
		}
	}

	public PerformanceCounterPermissionAttribute(SecurityAction action)
		: base(action)
	{
		categoryName = "*";
		machineName = ".";
		permissionAccess = PerformanceCounterPermissionAccess.Write;
	}

	public override IPermission CreatePermission()
	{
		if (base.Unrestricted)
		{
			return new PerformanceCounterPermission(PermissionState.Unrestricted);
		}
		return new PerformanceCounterPermission(PermissionAccess, MachineName, CategoryName);
	}
}
