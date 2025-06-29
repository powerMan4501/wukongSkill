using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class ZoneIdentityPermission : CodeAccessPermission, IBuiltInPermission
{
	private const uint AllZones = 31u;

	[OptionalField(VersionAdded = 2)]
	private uint m_zones;

	[OptionalField(VersionAdded = 2)]
	private string m_serializedPermission;

	private SecurityZone m_zone = SecurityZone.NoZone;

	public SecurityZone SecurityZone
	{
		get
		{
			SecurityZone securityZone = SecurityZone.NoZone;
			int num = 0;
			for (uint num2 = 1u; num2 < 31; num2 <<= 1)
			{
				if ((m_zones & num2) != 0)
				{
					if (securityZone != SecurityZone.NoZone)
					{
						return SecurityZone.NoZone;
					}
					securityZone = (SecurityZone)num;
				}
				num++;
			}
			return securityZone;
		}
		set
		{
			VerifyZone(value);
			if (value == SecurityZone.NoZone)
			{
				m_zones = 0u;
			}
			else
			{
				m_zones = (uint)(1 << (int)value);
			}
		}
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			if (m_serializedPermission != null)
			{
				FromXml(SecurityElement.FromString(m_serializedPermission));
				m_serializedPermission = null;
			}
			else
			{
				SecurityZone = m_zone;
				m_zone = SecurityZone.NoZone;
			}
		}
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			m_serializedPermission = ToXml().ToString();
			m_zone = SecurityZone;
		}
	}

	[OnSerialized]
	private void OnSerialized(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			m_serializedPermission = null;
			m_zone = SecurityZone.NoZone;
		}
	}

	public ZoneIdentityPermission(PermissionState state)
	{
		switch (state)
		{
		case PermissionState.Unrestricted:
			m_zones = 31u;
			break;
		case PermissionState.None:
			m_zones = 0u;
			break;
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPermissionState"));
		}
	}

	public ZoneIdentityPermission(SecurityZone zone)
	{
		SecurityZone = zone;
	}

	internal ZoneIdentityPermission(uint zones)
	{
		m_zones = zones & 0x1F;
	}

	internal void AppendZones(ArrayList zoneList)
	{
		int num = 0;
		for (uint num2 = 1u; num2 < 31; num2 <<= 1)
		{
			if ((m_zones & num2) != 0)
			{
				zoneList.Add((SecurityZone)num);
			}
			num++;
		}
	}

	private static void VerifyZone(SecurityZone zone)
	{
		if (zone < SecurityZone.NoZone || zone > SecurityZone.Untrusted)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalZone"));
		}
	}

	public override IPermission Copy()
	{
		return new ZoneIdentityPermission(m_zones);
	}

	public override bool IsSubsetOf(IPermission target)
	{
		if (target == null)
		{
			return m_zones == 0;
		}
		if (!(target is ZoneIdentityPermission zoneIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		return (m_zones & zoneIdentityPermission.m_zones) == m_zones;
	}

	public override IPermission Intersect(IPermission target)
	{
		if (target == null)
		{
			return null;
		}
		if (!(target is ZoneIdentityPermission zoneIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		uint num = m_zones & zoneIdentityPermission.m_zones;
		if (num == 0)
		{
			return null;
		}
		return new ZoneIdentityPermission(num);
	}

	public override IPermission Union(IPermission target)
	{
		if (target == null)
		{
			if (m_zones == 0)
			{
				return null;
			}
			return Copy();
		}
		if (!(target is ZoneIdentityPermission zoneIdentityPermission))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_WrongType", GetType().FullName));
		}
		return new ZoneIdentityPermission(m_zones | zoneIdentityPermission.m_zones);
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = CodeAccessPermission.CreatePermissionElement(this, "System.Security.Permissions.ZoneIdentityPermission");
		if (SecurityZone != SecurityZone.NoZone)
		{
			securityElement.AddAttribute("Zone", Enum.GetName(typeof(SecurityZone), SecurityZone));
		}
		else
		{
			int num = 0;
			for (uint num2 = 1u; num2 < 31; num2 <<= 1)
			{
				if ((m_zones & num2) != 0)
				{
					SecurityElement securityElement2 = new SecurityElement("Zone");
					securityElement2.AddAttribute("Zone", Enum.GetName(typeof(SecurityZone), (SecurityZone)num));
					securityElement.AddChild(securityElement2);
				}
				num++;
			}
		}
		return securityElement;
	}

	public override void FromXml(SecurityElement esd)
	{
		m_zones = 0u;
		CodeAccessPermission.ValidateElement(esd, this);
		string text = esd.Attribute("Zone");
		if (text != null)
		{
			SecurityZone = (SecurityZone)Enum.Parse(typeof(SecurityZone), text);
		}
		if (esd.Children == null)
		{
			return;
		}
		foreach (SecurityElement child in esd.Children)
		{
			text = child.Attribute("Zone");
			int num = (int)Enum.Parse(typeof(SecurityZone), text);
			if (num != -1)
			{
				m_zones |= (uint)(1 << num);
			}
		}
	}

	int IBuiltInPermission.GetTokenIndex()
	{
		return GetTokenIndex();
	}

	internal static int GetTokenIndex()
	{
		return 14;
	}
}
