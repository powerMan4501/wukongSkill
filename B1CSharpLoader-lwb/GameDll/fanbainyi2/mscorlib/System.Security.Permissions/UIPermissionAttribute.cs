using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
[ComVisible(true)]
public sealed class UIPermissionAttribute : CodeAccessSecurityAttribute
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
			m_clipboardFlag = value;
		}
	}

	public UIPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (m_unrestricted)
		{
			return new UIPermission(PermissionState.Unrestricted);
		}
		return new UIPermission(m_windowFlag, m_clipboardFlag);
	}
}
