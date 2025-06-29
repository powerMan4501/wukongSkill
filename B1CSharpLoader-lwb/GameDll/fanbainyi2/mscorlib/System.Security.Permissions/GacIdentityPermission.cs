using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class GacIdentityPermission : CodeAccessPermission, IBuiltInPermission
{
	public GacIdentityPermission(PermissionState state)
	{
		if (state != PermissionState.Unrestricted && state != PermissionState.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public GacIdentityPermission()
	{
	}

	public override IPermission Copy()
	{
		return new GacIdentityPermission();
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return false;
		}
		if (!(target is GacIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		return true;
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is GacIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		return Copy();
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (!(target is GacIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		return Copy();
	}

	public override SecurityElement ToXml()
	{
		return CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.GacIdentityPermission");
	}

	public override void FromXml(SecurityElement securityElement)
	{
		CodeAccessPermission.ValidateElement(securityElement, this);
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 15;
	}
}
