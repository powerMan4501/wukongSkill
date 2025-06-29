using System.Collections;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class TypeDescriptionProvider
{
	private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
	{
	}

	private TypeDescriptionProvider _parent;

	private EmptyCustomTypeDescriptor _emptyDescriptor;

	protected TypeDescriptionProvider()
	{
	}

	protected TypeDescriptionProvider(TypeDescriptionProvider parent)
	{
		_parent = parent;
	}

	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
	{
		if (_parent != null)
		{
			return _parent.CreateInstance(provider, objectType, argTypes, args);
		}
		if (objectType == null)
		{
			throw new ArgumentNullException("objectType");
		}
		return SecurityUtils.SecureCreateInstance(objectType, args);
	}

	public virtual IDictionary GetCache(object instance)
	{
		if (_parent != null)
		{
			return _parent.GetCache(instance);
		}
		return null;
	}

	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
	{
		if (_parent != null)
		{
			return _parent.GetExtendedTypeDescriptor(instance);
		}
		if (_emptyDescriptor == null)
		{
			_emptyDescriptor = new EmptyCustomTypeDescriptor();
		}
		return _emptyDescriptor;
	}

	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
	{
		if (_parent != null)
		{
			return _parent.GetExtenderProviders(instance);
		}
		if (instance == null)
		{
			throw new ArgumentNullException("instance");
		}
		return new IExtenderProvider[0];
	}

	public virtual string GetFullComponentName(object component)
	{
		if (_parent != null)
		{
			return _parent.GetFullComponentName(component);
		}
		return GetTypeDescriptor(component).GetComponentName();
	}

	public Type GetReflectionType(Type objectType)
	{
		return GetReflectionType(objectType, null);
	}

	public Type GetReflectionType(object instance)
	{
		if (instance == null)
		{
			throw new ArgumentNullException("instance");
		}
		return GetReflectionType(instance.GetType(), instance);
	}

	public virtual Type GetReflectionType(Type objectType, object instance)
	{
		if (_parent != null)
		{
			return _parent.GetReflectionType(objectType, instance);
		}
		return objectType;
	}

	public virtual Type GetRuntimeType(Type reflectionType)
	{
		if (_parent != null)
		{
			return _parent.GetRuntimeType(reflectionType);
		}
		if (reflectionType == null)
		{
			throw new ArgumentNullException("reflectionType");
		}
		if (reflectionType.GetType().Assembly == typeof(object).Assembly)
		{
			return reflectionType;
		}
		return reflectionType.UnderlyingSystemType;
	}

	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
	{
		return GetTypeDescriptor(objectType, null);
	}

	public ICustomTypeDescriptor GetTypeDescriptor(object instance)
	{
		if (instance == null)
		{
			throw new ArgumentNullException("instance");
		}
		return GetTypeDescriptor(instance.GetType(), instance);
	}

	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
	{
		if (_parent != null)
		{
			return _parent.GetTypeDescriptor(objectType, instance);
		}
		if (_emptyDescriptor == null)
		{
			_emptyDescriptor = new EmptyCustomTypeDescriptor();
		}
		return _emptyDescriptor;
	}

	public virtual bool IsSupportedType(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (_parent != null)
		{
			return _parent.IsSupportedType(type);
		}
		return true;
	}
}
