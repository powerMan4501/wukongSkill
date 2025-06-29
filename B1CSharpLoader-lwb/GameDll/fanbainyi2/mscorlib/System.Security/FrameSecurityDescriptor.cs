using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security;

[Serializable]
internal class FrameSecurityDescriptor
{
	private PermissionSet m_assertions;

	private PermissionSet m_denials;

	private PermissionSet m_restriction;

	private PermissionSet m_DeclarativeAssertions;

	private PermissionSet m_DeclarativeDenials;

	private PermissionSet m_DeclarativeRestrictions;

	[NonSerialized]
	[SecurityCritical]
	private SafeAccessTokenHandle m_callerToken;

	[NonSerialized]
	[SecurityCritical]
	private SafeAccessTokenHandle m_impToken;

	private bool m_AssertFT;

	private bool m_assertAllPossible;

	private bool m_declSecComputed;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void IncrementOverridesCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void DecrementOverridesCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void IncrementAssertCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void DecrementAssertCount();

	internal FrameSecurityDescriptor()
	{
	}

	private PermissionSet CreateSingletonSet(IPermission perm)
	{
		PermissionSet permissionSet = new PermissionSet(fUnrestricted: false);
		permissionSet.AddPermission(perm.Copy());
		return permissionSet;
	}

	internal bool HasImperativeAsserts()
	{
		return m_assertions != null;
	}

	internal bool HasImperativeDenials()
	{
		return m_denials != null;
	}

	internal bool HasImperativeRestrictions()
	{
		return m_restriction != null;
	}

	[SecurityCritical]
	internal void SetAssert(IPermission perm)
	{
		m_assertions = CreateSingletonSet(perm);
		IncrementAssertCount();
	}

	[SecurityCritical]
	internal void SetAssert(PermissionSet permSet)
	{
		m_assertions = permSet.Copy();
		m_AssertFT = m_AssertFT || m_assertions.IsUnrestricted();
		IncrementAssertCount();
	}

	internal PermissionSet GetAssertions(bool fDeclarative)
	{
		if (!fDeclarative)
		{
			return m_assertions;
		}
		return m_DeclarativeAssertions;
	}

	[SecurityCritical]
	internal void SetAssertAllPossible()
	{
		m_assertAllPossible = true;
		IncrementAssertCount();
	}

	internal bool GetAssertAllPossible()
	{
		return m_assertAllPossible;
	}

	[SecurityCritical]
	internal void SetDeny(IPermission perm)
	{
		m_denials = CreateSingletonSet(perm);
		IncrementOverridesCount();
	}

	[SecurityCritical]
	internal void SetDeny(PermissionSet permSet)
	{
		m_denials = permSet.Copy();
		IncrementOverridesCount();
	}

	internal PermissionSet GetDenials(bool fDeclarative)
	{
		if (!fDeclarative)
		{
			return m_denials;
		}
		return m_DeclarativeDenials;
	}

	[SecurityCritical]
	internal void SetPermitOnly(IPermission perm)
	{
		m_restriction = CreateSingletonSet(perm);
		IncrementOverridesCount();
	}

	[SecurityCritical]
	internal void SetPermitOnly(PermissionSet permSet)
	{
		m_restriction = permSet.Copy();
		IncrementOverridesCount();
	}

	internal PermissionSet GetPermitOnly(bool fDeclarative)
	{
		if (!fDeclarative)
		{
			return m_restriction;
		}
		return m_DeclarativeRestrictions;
	}

	[SecurityCritical]
	internal void SetTokenHandles(SafeAccessTokenHandle callerToken, SafeAccessTokenHandle impToken)
	{
		if (m_callerToken != null && !m_callerToken.IsInvalid)
		{
			m_callerToken.Dispose();
		}
		m_callerToken = callerToken;
		m_impToken = impToken;
	}

	[SecurityCritical]
	internal void RevertAssert()
	{
		if (m_assertions != null)
		{
			m_assertions = null;
			DecrementAssertCount();
		}
		if (m_DeclarativeAssertions != null)
		{
			m_AssertFT = m_DeclarativeAssertions.IsUnrestricted();
		}
		else
		{
			m_AssertFT = false;
		}
	}

	[SecurityCritical]
	internal void RevertAssertAllPossible()
	{
		if (m_assertAllPossible)
		{
			m_assertAllPossible = false;
			DecrementAssertCount();
		}
	}

	[SecurityCritical]
	internal void RevertDeny()
	{
		if (HasImperativeDenials())
		{
			DecrementOverridesCount();
			m_denials = null;
		}
	}

	[SecurityCritical]
	internal void RevertPermitOnly()
	{
		if (HasImperativeRestrictions())
		{
			DecrementOverridesCount();
			m_restriction = null;
		}
	}

	[SecurityCritical]
	internal void RevertAll()
	{
		RevertAssert();
		RevertAssertAllPossible();
		RevertDeny();
		RevertPermitOnly();
	}

	[SecurityCritical]
	internal bool CheckDemand(CodeAccessPermission demand, PermissionToken permToken, RuntimeMethodHandleInternal rmh)
	{
		bool flag = CheckDemand2(demand, permToken, rmh, fDeclarative: false);
		if (flag)
		{
			flag = CheckDemand2(demand, permToken, rmh, fDeclarative: true);
		}
		return flag;
	}

	[SecurityCritical]
	internal bool CheckDemand2(CodeAccessPermission demand, PermissionToken permToken, RuntimeMethodHandleInternal rmh, bool fDeclarative)
	{
		if (GetPermitOnly(fDeclarative) != null)
		{
			GetPermitOnly(fDeclarative).CheckDecoded(demand, permToken);
		}
		if (GetDenials(fDeclarative) != null)
		{
			GetDenials(fDeclarative).CheckDecoded(demand, permToken);
		}
		if (GetAssertions(fDeclarative) != null)
		{
			GetAssertions(fDeclarative).CheckDecoded(demand, permToken);
		}
		bool flag = SecurityManager._SetThreadSecurity(bThreadSecurity: false);
		try
		{
			PermissionSet permitOnly = GetPermitOnly(fDeclarative);
			if (permitOnly != null)
			{
				CodeAccessPermission codeAccessPermission = (CodeAccessPermission)permitOnly.GetPermission(demand);
				if (codeAccessPermission == null)
				{
					if (!permitOnly.IsUnrestricted())
					{
						throw new SecurityException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Security_Generic"), demand.GetType().AssemblyQualifiedName), null, permitOnly, SecurityRuntime.GetMethodInfo(rmh), demand, demand);
					}
				}
				else
				{
					bool flag2 = true;
					try
					{
						flag2 = !demand.CheckPermitOnly(codeAccessPermission);
					}
					catch (ArgumentException)
					{
					}
					if (flag2)
					{
						throw new SecurityException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Security_Generic"), demand.GetType().AssemblyQualifiedName), null, permitOnly, SecurityRuntime.GetMethodInfo(rmh), demand, demand);
					}
				}
			}
			permitOnly = GetDenials(fDeclarative);
			if (permitOnly != null)
			{
				CodeAccessPermission denied = (CodeAccessPermission)permitOnly.GetPermission(demand);
				if (permitOnly.IsUnrestricted())
				{
					throw new SecurityException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Security_Generic"), demand.GetType().AssemblyQualifiedName), permitOnly, null, SecurityRuntime.GetMethodInfo(rmh), demand, demand);
				}
				bool flag3 = true;
				try
				{
					flag3 = !demand.CheckDeny(denied);
				}
				catch (ArgumentException)
				{
				}
				if (flag3)
				{
					throw new SecurityException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Security_Generic"), demand.GetType().AssemblyQualifiedName), permitOnly, null, SecurityRuntime.GetMethodInfo(rmh), demand, demand);
				}
			}
			if (GetAssertAllPossible())
			{
				return false;
			}
			permitOnly = GetAssertions(fDeclarative);
			if (permitOnly != null)
			{
				CodeAccessPermission asserted = (CodeAccessPermission)permitOnly.GetPermission(demand);
				try
				{
					if (permitOnly.IsUnrestricted() || demand.CheckAssert(asserted))
					{
						return false;
					}
				}
				catch (ArgumentException)
				{
				}
			}
		}
		finally
		{
			if (flag)
			{
				SecurityManager._SetThreadSecurity(bThreadSecurity: true);
			}
		}
		return true;
	}

	[SecurityCritical]
	internal bool CheckSetDemand(PermissionSet demandSet, out PermissionSet alteredDemandSet, RuntimeMethodHandleInternal rmh)
	{
		PermissionSet alteredDemandSet2 = null;
		PermissionSet alteredDemandSet3 = null;
		bool flag = CheckSetDemand2(demandSet, out alteredDemandSet2, rmh, fDeclarative: false);
		if (alteredDemandSet2 != null)
		{
			demandSet = alteredDemandSet2;
		}
		if (flag)
		{
			flag = CheckSetDemand2(demandSet, out alteredDemandSet3, rmh, fDeclarative: true);
		}
		if (alteredDemandSet3 != null)
		{
			alteredDemandSet = alteredDemandSet3;
		}
		else if (alteredDemandSet2 != null)
		{
			alteredDemandSet = alteredDemandSet2;
		}
		else
		{
			alteredDemandSet = null;
		}
		return flag;
	}

	[SecurityCritical]
	internal bool CheckSetDemand2(PermissionSet demandSet, out PermissionSet alteredDemandSet, RuntimeMethodHandleInternal rmh, bool fDeclarative)
	{
		alteredDemandSet = null;
		if (demandSet == null || demandSet.IsEmpty())
		{
			return false;
		}
		if (GetPermitOnly(fDeclarative) != null)
		{
			GetPermitOnly(fDeclarative).CheckDecoded(demandSet);
		}
		if (GetDenials(fDeclarative) != null)
		{
			GetDenials(fDeclarative).CheckDecoded(demandSet);
		}
		if (GetAssertions(fDeclarative) != null)
		{
			GetAssertions(fDeclarative).CheckDecoded(demandSet);
		}
		bool flag = SecurityManager._SetThreadSecurity(bThreadSecurity: false);
		try
		{
			PermissionSet permitOnly = GetPermitOnly(fDeclarative);
			if (permitOnly != null)
			{
				IPermission firstPermThatFailed = null;
				bool flag2 = true;
				try
				{
					flag2 = !demandSet.CheckPermitOnly(permitOnly, out firstPermThatFailed);
				}
				catch (ArgumentException)
				{
				}
				if (flag2)
				{
					throw new SecurityException(Environment.GetResourceString("Security_GenericNoType"), null, permitOnly, SecurityRuntime.GetMethodInfo(rmh), demandSet, firstPermThatFailed);
				}
			}
			permitOnly = GetDenials(fDeclarative);
			if (permitOnly != null)
			{
				IPermission firstPermThatFailed2 = null;
				bool flag3 = true;
				try
				{
					flag3 = !demandSet.CheckDeny(permitOnly, out firstPermThatFailed2);
				}
				catch (ArgumentException)
				{
				}
				if (flag3)
				{
					throw new SecurityException(Environment.GetResourceString("Security_GenericNoType"), permitOnly, null, SecurityRuntime.GetMethodInfo(rmh), demandSet, firstPermThatFailed2);
				}
			}
			if (GetAssertAllPossible())
			{
				return false;
			}
			permitOnly = GetAssertions(fDeclarative);
			if (permitOnly != null)
			{
				if (demandSet.CheckAssertion(permitOnly))
				{
					return false;
				}
				if (!permitOnly.IsUnrestricted())
				{
					PermissionSet.RemoveAssertedPermissionSet(demandSet, permitOnly, out alteredDemandSet);
				}
			}
		}
		finally
		{
			if (flag)
			{
				SecurityManager._SetThreadSecurity(bThreadSecurity: true);
			}
		}
		return true;
	}
}
