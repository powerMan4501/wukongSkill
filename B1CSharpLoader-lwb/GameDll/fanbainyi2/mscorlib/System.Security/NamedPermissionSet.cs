using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Security;

[Serializable]
[ComVisible(true)]
public sealed class NamedPermissionSet : PermissionSet
{
	private string m_name;

	private string m_description;

	[OptionalField(VersionAdded = 2)]
	internal string m_descrResource;

	private static object s_InternalSyncObject;

	public string Name
	{
		get
		{
			return m_name;
		}
		set
		{
			CheckName(value);
			m_name = value;
		}
	}

	public string Description
	{
		get
		{
			if (m_descrResource != null)
			{
				m_description = Environment.GetResourceString(m_descrResource);
				m_descrResource = null;
			}
			return m_description;
		}
		set
		{
			m_description = value;
			m_descrResource = null;
		}
	}

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	internal NamedPermissionSet()
	{
	}

	public NamedPermissionSet(string name)
	{
		CheckName(name);
		m_name = name;
	}

	public NamedPermissionSet(string name, PermissionState state)
		: base(state)
	{
		CheckName(name);
		m_name = name;
	}

	public NamedPermissionSet(string name, PermissionSet permSet)
		: base(permSet)
	{
		CheckName(name);
		m_name = name;
	}

	public NamedPermissionSet(NamedPermissionSet permSet)
		: base(permSet)
	{
		m_name = permSet.m_name;
		m_description = permSet.Description;
	}

	internal NamedPermissionSet(SecurityElement permissionSetXml)
		: base(PermissionState.None)
	{
		FromXml(permissionSetXml);
	}

	private static void CheckName(string name)
	{
		if (name == null || name.Equals(""))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NPMSInvalidName"));
		}
	}

	public override PermissionSet Copy()
	{
		return new NamedPermissionSet(this);
	}

	public NamedPermissionSet Copy(string name)
	{
		NamedPermissionSet namedPermissionSet = new NamedPermissionSet(this);
		namedPermissionSet.Name = name;
		return namedPermissionSet;
	}

	public override SecurityElement ToXml()
	{
		SecurityElement securityElement = ToXml("System.Security.NamedPermissionSet");
		if (m_name != null && !m_name.Equals(""))
		{
			securityElement.AddAttribute("Name", SecurityElement.Escape(m_name));
		}
		if (Description != null && !Description.Equals(""))
		{
			securityElement.AddAttribute("Description", SecurityElement.Escape(Description));
		}
		return securityElement;
	}

	public override void FromXml(SecurityElement et)
	{
		FromXml(et, allowInternalOnly: false, ignoreTypeLoadFailures: false);
	}

	internal override void FromXml(SecurityElement et, bool allowInternalOnly, bool ignoreTypeLoadFailures)
	{
		if (et == null)
		{
			throw new ArgumentNullException("et");
		}
		string text = et.Attribute("Name");
		m_name = ((text == null) ? null : text);
		text = et.Attribute("Description");
		m_description = ((text == null) ? "" : text);
		m_descrResource = null;
		base.FromXml(et, allowInternalOnly, ignoreTypeLoadFailures);
	}

	internal void FromXmlNameOnly(SecurityElement et)
	{
		string text = et.Attribute("Name");
		m_name = ((text == null) ? null : text);
	}

	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		return base.Equals(obj);
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
