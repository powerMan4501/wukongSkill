using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class FileDialogPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	private FileDialogPermissionAccess access;

	public FileDialogPermissionAccess Access
	{
		get
		{
			return access;
		}
		set
		{
			VerifyAccess(value);
			access = value;
		}
	}

	public FileDialogPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			SetUnrestricted(unrestricted: true);
			break;
		case PermissionState.None:
			SetUnrestricted(unrestricted: false);
			Reset();
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public FileDialogPermission(FileDialogPermissionAccess access)
	{
		VerifyAccess(access);
		this.access = access;
	}

	public override IPermission Copy()
	{
		return new FileDialogPermission(access);
	}

	public override void FromXml(SecurityElement esd)
	{
		CodeAccessPermission.ValidateElement(esd, this);
		if (XMLUtil.IsUnrestricted(esd))
		{
			SetUnrestricted(unrestricted: true);
			return;
		}
		access = FileDialogPermissionAccess.None;
		string text = esd.Attribute("Access");
		if (text != null)
		{
			access = (FileDialogPermissionAccess)Enum.Parse(typeof(FileDialogPermissionAccess), text);
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 1;
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!VerifyType(target))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		FileDialogPermission fileDialogPermission = (FileDialogPermission)target;
		FileDialogPermissionAccess fileDialogPermissionAccess = access & fileDialogPermission.Access;
		if (fileDialogPermissionAccess == FileDialogPermissionAccess.None)
		{
			return null;
		}
		return new FileDialogPermission(fileDialogPermissionAccess);
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return access == FileDialogPermissionAccess.None;
		}
		try
		{
			FileDialogPermission fileDialogPermission = (FileDialogPermission)target;
			if (fileDialogPermission.IsUnrestricted())
			{
				return true;
			}
			if (IsUnrestricted())
			{
				return false;
			}
			int num = (int)(access & FileDialogPermissionAccess.Open);
			int num2 = (int)(access & FileDialogPermissionAccess.Save);
			int num3 = (int)(fileDialogPermission.Access & FileDialogPermissionAccess.Open);
			int num4 = (int)(fileDialogPermission.Access & FileDialogPermissionAccess.Save);
			return num <= num3 && num2 <= num4;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
	}

	public bool IsUnrestricted()
	{
		return access == FileDialogPermissionAccess.OpenSave;
	}

	private void Reset()
	{
		access = FileDialogPermissionAccess.None;
	}

	private void SetUnrestricted(bool unrestricted)
	{
		if (unrestricted)
		{
			access = FileDialogPermissionAccess.OpenSave;
		}
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.FileDialogPermission");
		if (!IsUnrestricted())
		{
			if (access != FileDialogPermissionAccess.None)
			{
				securityElement.AddAttribute("Access", Enum.GetName(typeof(FileDialogPermissionAccess), access));
			}
		}
		else
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			return Copy();
		}
		if (!VerifyType(target))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		FileDialogPermission fileDialogPermission = (FileDialogPermission)target;
		return new FileDialogPermission(access | fileDialogPermission.Access);
	}

	private static void VerifyAccess(FileDialogPermissionAccess access)
	{
		if ((access & ~FileDialogPermissionAccess.OpenSave) != FileDialogPermissionAccess.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)access));
		}
	}
}
