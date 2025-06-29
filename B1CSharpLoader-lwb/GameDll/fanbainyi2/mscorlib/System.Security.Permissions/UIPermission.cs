using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class UIPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
{
	private UIPermissionWindow m_windowFlag;

	private UIPermissionClipboard m_clipboardFlag;

	public UIPermissionWindow Window
	{
		get
		{
			return m_windowFlag;
		}
		set
		{
			VerifyWindowFlag(value);
			m_windowFlag = value;
		}
	}

	public UIPermissionClipboard Clipboard
	{
		get
		{
			return m_clipboardFlag;
		}
		set
		{
			VerifyClipboardFlag(value);
			m_clipboardFlag = value;
		}
	}

	public UIPermission(PermissionState state)
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

	public UIPermission(UIPermissionWindow windowFlag, UIPermissionClipboard clipboardFlag)
	{
		VerifyWindowFlag(windowFlag);
		VerifyClipboardFlag(clipboardFlag);
		m_windowFlag = windowFlag;
		m_clipboardFlag = clipboardFlag;
	}

	public UIPermission(UIPermissionWindow windowFlag)
	{
		VerifyWindowFlag(windowFlag);
		m_windowFlag = windowFlag;
	}

	public UIPermission(UIPermissionClipboard clipboardFlag)
	{
		VerifyClipboardFlag(clipboardFlag);
		m_clipboardFlag = clipboardFlag;
	}

	private static void VerifyWindowFlag(UIPermissionWindow flag)
	{
		if (flag < UIPermissionWindow.NoWindows || flag > UIPermissionWindow.AllWindows)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)flag));
		}
	}

	private static void VerifyClipboardFlag(UIPermissionClipboard flag)
	{
		if (flag < UIPermissionClipboard.NoClipboard || flag > UIPermissionClipboard.AllClipboard)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)flag));
		}
	}

	private void Reset()
	{
		m_windowFlag = UIPermissionWindow.NoWindows;
		m_clipboardFlag = UIPermissionClipboard.NoClipboard;
	}

	private void SetUnrestricted(bool unrestricted)
	{
		if (unrestricted)
		{
			m_windowFlag = UIPermissionWindow.AllWindows;
			m_clipboardFlag = UIPermissionClipboard.AllClipboard;
		}
	}

	public bool IsUnrestricted()
	{
		if (m_windowFlag == UIPermissionWindow.AllWindows)
		{
			return m_clipboardFlag == UIPermissionClipboard.AllClipboard;
		}
		return false;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			if (m_windowFlag == UIPermissionWindow.NoWindows)
			{
				return m_clipboardFlag == UIPermissionClipboard.NoClipboard;
			}
			return false;
		}
		try
		{
			UIPermission uIPermission = (UIPermission)target;
			if (uIPermission.IsUnrestricted())
			{
				return true;
			}
			if (IsUnrestricted())
			{
				return false;
			}
			return m_windowFlag <= uIPermission.m_windowFlag && m_clipboardFlag <= uIPermission.m_clipboardFlag;
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
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
		UIPermission uIPermission = (UIPermission)target;
		UIPermissionWindow uIPermissionWindow = ((m_windowFlag < uIPermission.m_windowFlag) ? m_windowFlag : uIPermission.m_windowFlag);
		UIPermissionClipboard uIPermissionClipboard = ((m_clipboardFlag < uIPermission.m_clipboardFlag) ? m_clipboardFlag : uIPermission.m_clipboardFlag);
		if (uIPermissionWindow == UIPermissionWindow.NoWindows && uIPermissionClipboard == UIPermissionClipboard.NoClipboard)
		{
			return null;
		}
		return new UIPermission(uIPermissionWindow, uIPermissionClipboard);
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
		UIPermission uIPermission = (UIPermission)target;
		UIPermissionWindow uIPermissionWindow = ((m_windowFlag > uIPermission.m_windowFlag) ? m_windowFlag : uIPermission.m_windowFlag);
		UIPermissionClipboard uIPermissionClipboard = ((m_clipboardFlag > uIPermission.m_clipboardFlag) ? m_clipboardFlag : uIPermission.m_clipboardFlag);
		if (uIPermissionWindow == UIPermissionWindow.NoWindows && uIPermissionClipboard == UIPermissionClipboard.NoClipboard)
		{
			return null;
		}
		return new UIPermission(uIPermissionWindow, uIPermissionClipboard);
	}

	public override IPermission Copy()
	{
		return new UIPermission(m_windowFlag, m_clipboardFlag);
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.UIPermission");
		if (!IsUnrestricted())
		{
			if (m_windowFlag != UIPermissionWindow.NoWindows)
			{
				securityElement.AddAttribute("Window", Enum.GetName(typeof(UIPermissionWindow), m_windowFlag));
			}
			if (m_clipboardFlag != UIPermissionClipboard.NoClipboard)
			{
				securityElement.AddAttribute("Clipboard", Enum.GetName(typeof(UIPermissionClipboard), m_clipboardFlag));
			}
		}
		else
		{
			securityElement.AddAttribute("Unrestricted", "true");
		}
		return securityElement;
	}

	public override void FromXml(SecurityElement esd)
	{
		CodeAccessPermission.ValidateElement(esd, this);
		if (XMLUtil.IsUnrestricted(esd))
		{
			SetUnrestricted(unrestricted: true);
			return;
		}
		m_windowFlag = UIPermissionWindow.NoWindows;
		m_clipboardFlag = UIPermissionClipboard.NoClipboard;
		string text = esd.Attribute("Window");
		if (text != null)
		{
			m_windowFlag = (UIPermissionWindow)Enum.Parse(typeof(UIPermissionWindow), text);
		}
		string text2 = esd.Attribute("Clipboard");
		if (text2 != null)
		{
			m_clipboardFlag = (UIPermissionClipboard)Enum.Parse(typeof(UIPermissionClipboard), text2);
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 7;
	}
}
