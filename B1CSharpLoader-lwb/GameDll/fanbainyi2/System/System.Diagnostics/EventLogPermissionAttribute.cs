using System.ComponentModel;
using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Event, AllowMultiple = true, Inherited = false)]
public class EventLogPermissionAttribute : CodeAccessSecurityAttribute
{
	private string machineName;

	private EventLogPermissionAccess permissionAccess;

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

	public EventLogPermissionAccess PermissionAccess
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

	public EventLogPermissionAttribute(SecurityAction action)
		: base(action)
	{
		machineName = ".";
		permissionAccess = EventLogPermissionAccess.Write;
	}

	public override IPermission CreatePermission()
	{
		if (base.Unrestricted)
		{
			return new EventLogPermission(PermissionState.Unrestricted);
		}
		return new EventLogPermission(PermissionAccess, MachineName);
	}
}
