using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Principal;

[Serializable]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, SecurityInfrastructure = true)]
public class WindowsPrincipal : ClaimsPrincipal
{
	private WindowsIdentity m_identity;

	private string[] m_roles;

	private Hashtable m_rolesTable;

	private bool m_rolesLoaded;

	public override IIdentity Identity => m_identity;

	public virtual IEnumerable<Claim> UserClaims
	{
		get
		{
			foreach (ClaimsIdentity identity in Identities)
			{
				if (!(identity is WindowsIdentity windowsIdentity))
				{
					continue;
				}
				foreach (Claim userClaim in windowsIdentity.UserClaims)
				{
					yield return userClaim;
				}
			}
		}
	}

	public virtual IEnumerable<Claim> DeviceClaims
	{
		get
		{
			foreach (ClaimsIdentity identity in Identities)
			{
				if (!(identity is WindowsIdentity windowsIdentity))
				{
					continue;
				}
				foreach (Claim deviceClaim in windowsIdentity.DeviceClaims)
				{
					yield return deviceClaim;
				}
			}
		}
	}

	private WindowsPrincipal()
	{
	}

	public WindowsPrincipal(WindowsIdentity ntIdentity)
		: base(ntIdentity)
	{
		if (ntIdentity == null)
		{
			throw new ArgumentNullException("ntIdentity");
		}
		m_identity = ntIdentity;
	}

	[OnDeserialized]
	[SecuritySafeCritical]
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
		if (claimsIdentity == null)
		{
			base.AddIdentity(m_identity);
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
	public override bool IsInRole(string role)
	{
		if (role == null || role.Length == 0)
		{
			return false;
		}
		NTAccount identity = new NTAccount(role);
		IdentityReferenceCollection identityReferenceCollection = new IdentityReferenceCollection(1);
		identityReferenceCollection.Add(identity);
		IdentityReferenceCollection identityReferenceCollection2 = NTAccount.Translate(identityReferenceCollection, typeof(SecurityIdentifier), forceSuccess: false);
		SecurityIdentifier securityIdentifier = identityReferenceCollection2[0] as SecurityIdentifier;
		if (securityIdentifier != null && IsInRole(securityIdentifier))
		{
			return true;
		}
		return base.IsInRole(role);
	}

	public virtual bool IsInRole(WindowsBuiltInRole role)
	{
		if (role < WindowsBuiltInRole.Administrator || role > WindowsBuiltInRole.Replicator)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)role), "role");
		}
		return IsInRole((int)role);
	}

	public virtual bool IsInRole(int rid)
	{
		SecurityIdentifier sid = new SecurityIdentifier(IdentifierAuthority.NTAuthority, new int[2] { 32, rid });
		return IsInRole(sid);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public virtual bool IsInRole(SecurityIdentifier sid)
	{
		if (sid == null)
		{
			throw new ArgumentNullException("sid");
		}
		if (m_identity.AccessToken.IsInvalid)
		{
			return false;
		}
		SafeAccessTokenHandle phNewToken = SafeAccessTokenHandle.InvalidHandle;
		if (m_identity.ImpersonationLevel == TokenImpersonationLevel.None && !Win32Native.DuplicateTokenEx(m_identity.AccessToken, 8u, IntPtr.Zero, 2u, 2u, ref phNewToken))
		{
			throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
		}
		bool IsMember = false;
		if (!Win32Native.CheckTokenMembership((m_identity.ImpersonationLevel != TokenImpersonationLevel.None) ? m_identity.AccessToken : phNewToken, sid.BinaryForm, ref IsMember))
		{
			throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
		}
		phNewToken.Dispose();
		return IsMember;
	}
}
