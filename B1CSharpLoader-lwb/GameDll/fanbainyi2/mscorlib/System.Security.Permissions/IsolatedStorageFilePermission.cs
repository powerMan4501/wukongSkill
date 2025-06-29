using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class IsolatedStorageFilePermission : IsolatedStoragePermission, IBuiltInPermission
{
	public IsolatedStorageFilePermission(PermissionState state)
		: base(state)
	{
	}

	internal IsolatedStorageFilePermission(IsolatedStorageContainment UsageAllowed, long ExpirationDays, bool PermanentData)
		: base(UsageAllowed, ExpirationDays, PermanentData)
	{
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
		IsolatedStorageFilePermission isolatedStorageFilePermission = (IsolatedStorageFilePermission)target;
		if (IsUnrestricted() || isolatedStorageFilePermission.IsUnrestricted())
		{
			return new IsolatedStorageFilePermission(PermissionState.Unrestricted);
		}
		IsolatedStorageFilePermission isolatedStorageFilePermission2 = new IsolatedStorageFilePermission(PermissionState.None);
		isolatedStorageFilePermission2.m_userQuota = IsolatedStoragePermission.max(m_userQuota, isolatedStorageFilePermission.m_userQuota);
		isolatedStorageFilePermission2.m_machineQuota = IsolatedStoragePermission.max(m_machineQuota, isolatedStorageFilePermission.m_machineQuota);
		isolatedStorageFilePermission2.m_expirationDays = IsolatedStoragePermission.max(m_expirationDays, isolatedStorageFilePermission.m_expirationDays);
		isolatedStorageFilePermission2.m_permanentData = m_permanentData || isolatedStorageFilePermission.m_permanentData;
		isolatedStorageFilePermission2.m_allowed = (IsolatedStorageContainment)IsolatedStoragePermission.max((long)m_allowed, (long)isolatedStorageFilePermission.m_allowed);
		return isolatedStorageFilePermission2;
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			if (m_userQuota == 0L && m_machineQuota == 0L && m_expirationDays == 0L && !m_permanentData)
			{
				return m_allowed == IsolatedStorageContainment.None;
			}
			return false;
		}
		try
		{
			IsolatedStorageFilePermission isolatedStorageFilePermission = (IsolatedStorageFilePermission)target;
			if (isolatedStorageFilePermission.IsUnrestricted())
			{
				return true;
			}
			return isolatedStorageFilePermission.m_userQuota >= m_userQuota && isolatedStorageFilePermission.m_machineQuota >= m_machineQuota && isolatedStorageFilePermission.m_expirationDays >= m_expirationDays && (isolatedStorageFilePermission.m_permanentData || !m_permanentData) && isolatedStorageFilePermission.m_allowed >= m_allowed;
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
		IsolatedStorageFilePermission isolatedStorageFilePermission = (IsolatedStorageFilePermission)target;
		if (isolatedStorageFilePermission.IsUnrestricted())
		{
			return Copy();
		}
		if (IsUnrestricted())
		{
			return target.Copy();
		}
		IsolatedStorageFilePermission isolatedStorageFilePermission2 = new IsolatedStorageFilePermission(PermissionState.None);
		isolatedStorageFilePermission2.m_userQuota = IsolatedStoragePermission.min(m_userQuota, isolatedStorageFilePermission.m_userQuota);
		isolatedStorageFilePermission2.m_machineQuota = IsolatedStoragePermission.min(m_machineQuota, isolatedStorageFilePermission.m_machineQuota);
		isolatedStorageFilePermission2.m_expirationDays = IsolatedStoragePermission.min(m_expirationDays, isolatedStorageFilePermission.m_expirationDays);
		isolatedStorageFilePermission2.m_permanentData = m_permanentData && isolatedStorageFilePermission.m_permanentData;
		isolatedStorageFilePermission2.m_allowed = (IsolatedStorageContainment)IsolatedStoragePermission.min((long)m_allowed, (long)isolatedStorageFilePermission.m_allowed);
		if (isolatedStorageFilePermission2.m_userQuota == 0L && isolatedStorageFilePermission2.m_machineQuota == 0L && isolatedStorageFilePermission2.m_expirationDays == 0L && !isolatedStorageFilePermission2.m_permanentData && isolatedStorageFilePermission2.m_allowed == IsolatedStorageContainment.None)
		{
			return null;
		}
		return isolatedStorageFilePermission2;
	}

	public override IPermission Copy()
	{
		IsolatedStorageFilePermission isolatedStorageFilePermission = new IsolatedStorageFilePermission(PermissionState.Unrestricted);
		if (!IsUnrestricted())
		{
			isolatedStorageFilePermission.m_userQuota = m_userQuota;
			isolatedStorageFilePermission.m_machineQuota = m_machineQuota;
			isolatedStorageFilePermission.m_expirationDays = m_expirationDays;
			isolatedStorageFilePermission.m_permanentData = m_permanentData;
			isolatedStorageFilePermission.m_allowed = m_allowed;
		}
		return isolatedStorageFilePermission;
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 3;
	}

	[ComVisible(false)]
	public override SecurityElement ToXml()
	{
		return ToXml("System.Security.Permissions.IsolatedStorageFilePermission");
	}
}
