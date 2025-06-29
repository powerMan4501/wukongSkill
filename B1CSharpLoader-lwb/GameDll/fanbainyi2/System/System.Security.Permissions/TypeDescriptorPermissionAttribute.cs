namespace System.Security.Permissions;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class TypeDescriptorPermissionAttribute : CodeAccessSecurityAttribute
{
	private TypeDescriptorPermissionFlags m_flags;

	public TypeDescriptorPermissionFlags Flags
	{
		get
		{
			return m_flags;
		}
		set
		{
			TypeDescriptorPermission.VerifyFlags(value);
			m_flags = value;
		}
	}

	public bool RestrictedRegistrationAccess
	{
		get
		{
			return (m_flags & TypeDescriptorPermissionFlags.RestrictedRegistrationAccess) != 0;
		}
		set
		{
			m_flags = (value ? (m_flags | TypeDescriptorPermissionFlags.RestrictedRegistrationAccess) : (m_flags & ~TypeDescriptorPermissionFlags.RestrictedRegistrationAccess));
		}
	}

	public TypeDescriptorPermissionAttribute(SecurityAction action)
		: base(action)
	{
	}

	public override IPermission CreatePermission()
	{
		if (base.Unrestricted)
		{
			return new TypeDescriptorPermission(PermissionState.Unrestricted);
		}
		return new TypeDescriptorPermission(m_flags);
	}
}
