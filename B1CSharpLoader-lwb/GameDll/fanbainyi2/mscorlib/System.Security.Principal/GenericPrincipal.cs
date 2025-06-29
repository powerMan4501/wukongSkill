using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;

namespace System.Security.Principal;

[Serializable]
[ComVisible(true)]
public class GenericPrincipal : ClaimsPrincipal
{
	private IIdentity m_identity;

	private string[] m_roles;

	public override IIdentity Identity => m_identity;

	public GenericPrincipal(IIdentity identity, string[] roles)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		m_identity = identity;
		if (roles != null)
		{
			m_roles = new string[roles.Length];
			for (int i = 0; i < roles.Length; i++)
			{
				m_roles[i] = roles[i];
			}
		}
		else
		{
			m_roles = null;
		}
		AddIdentityWithRoles(m_identity, m_roles);
	}

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context)
	{
		ClaimsIdentity claimsIdentity = null;
		foreach (ClaimsIdentity identity in base.Identities)
		{
			if (identity != null)
			{
				claimsIdentity = identity;
				break;
			}
		}
		if (m_roles != null && m_roles.Length != 0 && claimsIdentity != null)
		{
			claimsIdentity.ExternalClaims.Add(new RoleClaimProvider("LOCAL AUTHORITY", m_roles, claimsIdentity).Claims);
		}
		else if (claimsIdentity == null)
		{
			AddIdentityWithRoles(m_identity, m_roles);
		}
	}

	[SecuritySafeCritical]
	private void AddIdentityWithRoles(IIdentity identity, string[] roles)
	{
		ClaimsIdentity claimsIdentity = ((!(identity is ClaimsIdentity claimsIdentity2)) ? new ClaimsIdentity(identity) : claimsIdentity2.Clone());
		if (roles != null && roles.Length != 0)
		{
			claimsIdentity.ExternalClaims.Add(new RoleClaimProvider("LOCAL AUTHORITY", roles, claimsIdentity).Claims);
		}
		base.AddIdentity(claimsIdentity);
	}

	public override bool IsInRole(string role)
	{
		if (role == null || m_roles == null)
		{
			return false;
		}
		for (int i = 0; i < m_roles.Length; i++)
		{
			if (m_roles[i] != null && string.Compare(m_roles[i], role, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		return base.IsInRole(role);
	}
}
