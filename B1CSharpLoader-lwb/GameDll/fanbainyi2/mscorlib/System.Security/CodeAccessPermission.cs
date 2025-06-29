using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;
using System.Threading;

namespace System.Security;

[Serializable]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, ControlEvidence = true, ControlPolicy = true)]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable, IStackWalk
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static void RevertAssert()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.RevertAssert(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Deny is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static void RevertDeny()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.RevertDeny(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static void RevertPermitOnly()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.RevertPermitOnly(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static void RevertAll()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.RevertAll(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public void Demand()
	{
		if (!CheckDemand(null))
		{
			StackCrawlMark stackMark = StackCrawlMark.LookForMyCallersCaller;
			CodeAccessSecurityEngine.Check(this, ref stackMark);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	internal static void Demand(PermissionType permissionType)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCallersCaller;
		CodeAccessSecurityEngine.SpecialDemand(permissionType, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public void Assert()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		CodeAccessSecurityEngine.Assert(this, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	internal static void Assert(bool allPossible)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityRuntime.AssertAllPossible(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Deny is obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public void Deny()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		CodeAccessSecurityEngine.Deny(this, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public void PermitOnly()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		CodeAccessSecurityEngine.PermitOnly(this, ref stackMark);
	}

	public virtual IPermission Union(IPermission other)
	{
		if (other == null)
		{
			return Copy();
		}
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_SecurityPermissionUnion"));
	}

	internal static SecurityElement CreatePermissionElement(IPermission perm, string permname)
	{
		SecurityElement securityElement = new SecurityElement("IPermission");
		XMLUtil.AddClassAttribute(securityElement, perm.GetType(), permname);
		securityElement.AddAttribute("version", "1");
		return securityElement;
	}

	internal static void ValidateElement(SecurityElement elem, IPermission perm)
	{
		if (elem == null)
		{
			throw new ArgumentNullException("elem");
		}
		if (!XMLUtil.IsPermissionElement(perm, elem))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotAPermissionElement"));
		}
		string text = elem.Attribute("version");
		if (text != null && !text.Equals("1"))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidXMLBadVersion"));
		}
	}

	public abstract SecurityElement ToXml();

	public abstract void FromXml(SecurityElement elem);

	public override string ToString()
	{
		return ToXml().ToString();
	}

	internal bool VerifyType(IPermission perm)
	{
		if (perm == null || perm.GetType() != GetType())
		{
			return false;
		}
		return true;
	}

	public abstract IPermission Copy();

	public abstract IPermission Intersect(IPermission target);

	public abstract bool IsSubsetOf(IPermission target);

	[ComVisible(false)]
	public override bool Equals(object obj)
	{
		IPermission permission = obj as IPermission;
		if (obj != null && permission == null)
		{
			return false;
		}
		try
		{
			if (!IsSubsetOf(permission))
			{
				return false;
			}
			if (permission != null && !permission.IsSubsetOf(this))
			{
				return false;
			}
		}
		catch (ArgumentException)
		{
			return false;
		}
		return true;
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	internal bool CheckDemand(CodeAccessPermission grant)
	{
		return IsSubsetOf(grant);
	}

	internal bool CheckPermitOnly(CodeAccessPermission permitted)
	{
		return IsSubsetOf(permitted);
	}

	internal bool CheckDeny(CodeAccessPermission denied)
	{
		return Intersect(denied)?.IsSubsetOf(null) ?? true;
	}

	internal bool CheckAssert(CodeAccessPermission asserted)
	{
		return IsSubsetOf(asserted);
	}
}
