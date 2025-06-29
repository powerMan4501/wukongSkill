using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Util;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, ControlEvidence = true, ControlPolicy = true)]
public abstract class IsolatedStoragePermission : CodeAccessPermission, IUnrestrictedPermission
{
	internal long m_userQuota;

	internal long m_machineQuota;

	internal long m_expirationDays;

	internal bool m_permanentData;

	internal IsolatedStorageContainment m_allowed;

	private const string _strUserQuota = "UserQuota";

	private const string _strMachineQuota = "MachineQuota";

	private const string _strExpiry = "Expiry";

	private const string _strPermDat = "Permanent";

	public long UserQuota
	{
		get
		{
			return m_userQuota;
		}
		set
		{
			m_userQuota = value;
		}
	}

	public IsolatedStorageContainment UsageAllowed
	{
		get
		{
			return m_allowed;
		}
		set
		{
			m_allowed = value;
		}
	}

	protected IsolatedStoragePermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_userQuota = long.MaxValue;
			m_machineQuota = long.MaxValue;
			m_expirationDays = long.MaxValue;
			m_permanentData = true;
			m_allowed = IsolatedStorageContainment.UnrestrictedIsolatedStorage;
			break;
		case PermissionState.None:
			m_userQuota = 0L;
			m_machineQuota = 0L;
			m_expirationDays = 0L;
			m_permanentData = false;
			m_allowed = IsolatedStorageContainment.None;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	internal IsolatedStoragePermission(IsolatedStorageContainment UsageAllowed, long ExpirationDays, bool PermanentData)
	{
		m_userQuota = 0L;
		m_machineQuota = 0L;
		m_expirationDays = ExpirationDays;
		m_permanentData = PermanentData;
		m_allowed = UsageAllowed;
	}

	internal IsolatedStoragePermission(IsolatedStorageContainment UsageAllowed, long ExpirationDays, bool PermanentData, long UserQuota)
	{
		m_machineQuota = 0L;
		m_userQuota = UserQuota;
		m_expirationDays = ExpirationDays;
		m_permanentData = PermanentData;
		m_allowed = UsageAllowed;
	}

	public bool IsUnrestricted()
	{
		return m_allowed == IsolatedStorageContainment.UnrestrictedIsolatedStorage;
	}

	internal static long min(long x, long y)
	{
		if (x <= y)
		{
			return x;
		}
		return y;
	}

	internal static long max(long x, long y)
	{
		if (x >= y)
		{
			return x;
		}
		return y;
	}

	public override SecurityElement ToXml()
	{
		return ToXml(GetType().FullName);
	}

	internal SecurityElement ToXml(string permName)
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, permName);
		if (!IsUnrestricted())
		{
			securityElement.AddAttribute("Allowed", Enum.GetName(typeof(IsolatedStorageContainment), m_allowed));
			if (m_userQuota > 0)
			{
				securityElement.AddAttribute("UserQuota", m_userQuota.ToString(CultureInfo.InvariantCulture));
			}
			if (m_machineQuota > 0)
			{
				securityElement.AddAttribute("MachineQuota", m_machineQuota.ToString(CultureInfo.InvariantCulture));
			}
			if (m_expirationDays > 0)
			{
				securityElement.AddAttribute("Expiry", m_expirationDays.ToString(CultureInfo.InvariantCulture));
			}
			if (m_permanentData)
			{
				securityElement.AddAttribute("Permanent", m_permanentData.ToString());
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
		m_allowed = IsolatedStorageContainment.None;
		if (XMLUtil.IsUnrestricted(esd))
		{
			m_allowed = IsolatedStorageContainment.UnrestrictedIsolatedStorage;
		}
		else
		{
			string text = esd.Attribute("Allowed");
			if (text != null)
			{
				m_allowed = (IsolatedStorageContainment)Enum.Parse(typeof(IsolatedStorageContainment), text);
			}
		}
		if (m_allowed == IsolatedStorageContainment.UnrestrictedIsolatedStorage)
		{
			m_userQuota = long.MaxValue;
			m_machineQuota = long.MaxValue;
			m_expirationDays = long.MaxValue;
			m_permanentData = true;
			return;
		}
		string text2 = esd.Attribute("UserQuota");
		m_userQuota = ((text2 != null) ? long.Parse(text2, CultureInfo.InvariantCulture) : 0);
		text2 = esd.Attribute("MachineQuota");
		m_machineQuota = ((text2 != null) ? long.Parse(text2, CultureInfo.InvariantCulture) : 0);
		text2 = esd.Attribute("Expiry");
		m_expirationDays = ((text2 != null) ? long.Parse(text2, CultureInfo.InvariantCulture) : 0);
		text2 = esd.Attribute("Permanent");
		m_permanentData = text2 != null && bool.Parse(text2);
	}
}
