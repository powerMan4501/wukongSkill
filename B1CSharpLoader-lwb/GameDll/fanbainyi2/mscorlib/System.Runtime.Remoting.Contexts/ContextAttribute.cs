using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting.Contexts;

[Serializable]
[SecurityCritical]
[AttributeUsage(AttributeTargets.Class)]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class ContextAttribute : Attribute, IContextAttribute, IContextProperty
{
	protected string AttributeName;

	public virtual string Name
	{
		[SecurityCritical]
		get
		{
			return AttributeName;
		}
	}

	public ContextAttribute(string name)
	{
		AttributeName = name;
	}

	[SecurityCritical]
	public virtual bool IsNewContextOK(Context newCtx)
	{
		return true;
	}

	[SecurityCritical]
	public virtual void Freeze(Context newContext)
	{
	}

	[SecuritySafeCritical]
	public override bool Equals(object o)
	{
		if (o is IContextProperty contextProperty)
		{
			return AttributeName.Equals(contextProperty.Name);
		}
		return false;
	}

	[SecuritySafeCritical]
	public override int GetHashCode()
	{
		return AttributeName.GetHashCode();
	}

	[SecurityCritical]
	public virtual bool IsContextOK(Context ctx, IConstructionCallMessage ctorMsg)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (ctorMsg == null)
		{
			throw new ArgumentNullException("ctorMsg");
		}
		if (!ctorMsg.ActivationType.IsContextful)
		{
			return true;
		}
		object property = ctx.GetProperty(AttributeName);
		if (property != null && Equals(property))
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	public virtual void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
	{
		if (ctorMsg == null)
		{
			throw new ArgumentNullException("ctorMsg");
		}
		ctorMsg.ContextProperties.Add(this);
	}
}
