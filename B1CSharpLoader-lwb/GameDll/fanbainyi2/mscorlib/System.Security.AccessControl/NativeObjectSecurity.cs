using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Security.AccessControl;

public abstract class NativeObjectSecurity : CommonObjectSecurity
{
	[SecuritySafeCritical]
	protected internal delegate Exception ExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context);

	private readonly ResourceType _resourceType;

	private ExceptionFromErrorCode _exceptionFromErrorCode;

	private object _exceptionContext;

	private readonly uint ProtectedDiscretionaryAcl = 2147483648u;

	private readonly uint ProtectedSystemAcl = 1073741824u;

	private readonly uint UnprotectedDiscretionaryAcl = 536870912u;

	private readonly uint UnprotectedSystemAcl = 268435456u;

	protected NativeObjectSecurity(bool isContainer, ResourceType resourceType)
		: base(isContainer)
	{
		_resourceType = resourceType;
	}

	protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
		: this(isContainer, resourceType)
	{
		_exceptionContext = exceptionContext;
		_exceptionFromErrorCode = exceptionFromErrorCode;
	}

	[SecurityCritical]
	internal NativeObjectSecurity(ResourceType resourceType, CommonSecurityDescriptor securityDescriptor)
		: this(resourceType, securityDescriptor, null)
	{
	}

	[SecurityCritical]
	internal NativeObjectSecurity(ResourceType resourceType, CommonSecurityDescriptor securityDescriptor, ExceptionFromErrorCode exceptionFromErrorCode)
		: base(securityDescriptor)
	{
		_resourceType = resourceType;
		_exceptionFromErrorCode = exceptionFromErrorCode;
	}

	[SecuritySafeCritical]
	protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
		: this(resourceType, CreateInternal(resourceType, isContainer, name, null, includeSections, createByName: true, exceptionFromErrorCode, exceptionContext), exceptionFromErrorCode)
	{
	}

	protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections)
		: this(isContainer, resourceType, name, includeSections, null, null)
	{
	}

	[SecuritySafeCritical]
	protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
		: this(resourceType, CreateInternal(resourceType, isContainer, null, handle, includeSections, createByName: false, exceptionFromErrorCode, exceptionContext), exceptionFromErrorCode)
	{
	}

	[SecuritySafeCritical]
	protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections)
		: this(isContainer, resourceType, handle, includeSections, null, null)
	{
	}

	[SecurityCritical]
	private static CommonSecurityDescriptor CreateInternal(ResourceType resourceType, bool isContainer, string name, SafeHandle handle, AccessControlSections includeSections, bool createByName, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
	{
		if (createByName && name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!createByName && handle == null)
		{
			throw new ArgumentNullException("handle");
		}
		RawSecurityDescriptor resultSd;
		int securityInfo = Win32.GetSecurityInfo(resourceType, name, handle, includeSections, out resultSd);
		if (securityInfo != 0)
		{
			Exception ex = null;
			if (exceptionFromErrorCode != null)
			{
				ex = exceptionFromErrorCode(securityInfo, name, handle, exceptionContext);
			}
			if (ex == null)
			{
				ex = securityInfo switch
				{
					5 => new UnauthorizedAccessException(), 
					1307 => new InvalidOperationException(Environment.GetResourceString("AccessControl_InvalidOwner")), 
					1308 => new InvalidOperationException(Environment.GetResourceString("AccessControl_InvalidGroup")), 
					87 => new InvalidOperationException(Environment.GetResourceString("AccessControl_UnexpectedError", securityInfo)), 
					123 => new ArgumentException(Environment.GetResourceString("Argument_InvalidName"), "name"), 
					2 => (name == null) ? new FileNotFoundException() : new FileNotFoundException(name), 
					1350 => new NotSupportedException(Environment.GetResourceString("AccessControl_NoAssociatedSecurity")), 
					_ => new InvalidOperationException(Environment.GetResourceString("AccessControl_UnexpectedError", securityInfo)), 
				};
			}
			throw ex;
		}
		return new CommonSecurityDescriptor(isContainer, isDS: false, resultSd, trusted: true);
	}

	[SecurityCritical]
	private void Persist(string name, SafeHandle handle, AccessControlSections includeSections, object exceptionContext)
	{
		WriteLock();
		try
		{
			SecurityInfos securityInfos = (SecurityInfos)0;
			SecurityIdentifier owner = null;
			SecurityIdentifier securityIdentifier = null;
			SystemAcl sacl = null;
			DiscretionaryAcl dacl = null;
			if ((includeSections & AccessControlSections.Owner) != AccessControlSections.None && _securityDescriptor.Owner != null)
			{
				securityInfos |= SecurityInfos.Owner;
				owner = _securityDescriptor.Owner;
			}
			if ((includeSections & AccessControlSections.Group) != AccessControlSections.None && _securityDescriptor.Group != null)
			{
				securityInfos |= SecurityInfos.Group;
				securityIdentifier = _securityDescriptor.Group;
			}
			if ((includeSections & AccessControlSections.Audit) != AccessControlSections.None)
			{
				securityInfos |= SecurityInfos.SystemAcl;
				sacl = ((!_securityDescriptor.IsSystemAclPresent || _securityDescriptor.SystemAcl == null || _securityDescriptor.SystemAcl.Count <= 0) ? null : _securityDescriptor.SystemAcl);
				securityInfos = (SecurityInfos)(((_securityDescriptor.ControlFlags & ControlFlags.SystemAclProtected) == 0) ? ((int)securityInfos | (int)UnprotectedSystemAcl) : ((int)securityInfos | (int)ProtectedSystemAcl));
			}
			if ((includeSections & AccessControlSections.Access) != AccessControlSections.None && _securityDescriptor.IsDiscretionaryAclPresent)
			{
				securityInfos |= SecurityInfos.DiscretionaryAcl;
				dacl = ((!_securityDescriptor.DiscretionaryAcl.EveryOneFullAccessForNullDacl) ? _securityDescriptor.DiscretionaryAcl : null);
				securityInfos = (SecurityInfos)(((_securityDescriptor.ControlFlags & ControlFlags.DiscretionaryAclProtected) == 0) ? ((int)securityInfos | (int)UnprotectedDiscretionaryAcl) : ((int)securityInfos | (int)ProtectedDiscretionaryAcl));
			}
			if (securityInfos == (SecurityInfos)0)
			{
				return;
			}
			int num = Win32.SetSecurityInfo(_resourceType, name, handle, securityInfos, owner, securityIdentifier, sacl, dacl);
			if (num != 0)
			{
				Exception ex = null;
				if (_exceptionFromErrorCode != null)
				{
					ex = _exceptionFromErrorCode(num, name, handle, exceptionContext);
				}
				if (ex == null)
				{
					ex = num switch
					{
						5 => new UnauthorizedAccessException(), 
						1307 => new InvalidOperationException(Environment.GetResourceString("AccessControl_InvalidOwner")), 
						1308 => new InvalidOperationException(Environment.GetResourceString("AccessControl_InvalidGroup")), 
						123 => new ArgumentException(Environment.GetResourceString("Argument_InvalidName"), "name"), 
						6 => new NotSupportedException(Environment.GetResourceString("AccessControl_InvalidHandle")), 
						2 => new FileNotFoundException(), 
						1350 => new NotSupportedException(Environment.GetResourceString("AccessControl_NoAssociatedSecurity")), 
						_ => new InvalidOperationException(Environment.GetResourceString("AccessControl_UnexpectedError", num)), 
					};
				}
				throw ex;
			}
			base.OwnerModified = false;
			base.GroupModified = false;
			base.AccessRulesModified = false;
			base.AuditRulesModified = false;
		}
		finally
		{
			WriteUnlock();
		}
	}

	protected sealed override void Persist(string name, AccessControlSections includeSections)
	{
		Persist(name, includeSections, _exceptionContext);
	}

	[SecuritySafeCritical]
	protected void Persist(string name, AccessControlSections includeSections, object exceptionContext)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		Persist(name, null, includeSections, exceptionContext);
	}

	[SecuritySafeCritical]
	protected sealed override void Persist(SafeHandle handle, AccessControlSections includeSections)
	{
		Persist(handle, includeSections, _exceptionContext);
	}

	[SecuritySafeCritical]
	protected void Persist(SafeHandle handle, AccessControlSections includeSections, object exceptionContext)
	{
		if (handle == null)
		{
			throw new ArgumentNullException("handle");
		}
		Persist(null, handle, includeSections, exceptionContext);
	}
}
