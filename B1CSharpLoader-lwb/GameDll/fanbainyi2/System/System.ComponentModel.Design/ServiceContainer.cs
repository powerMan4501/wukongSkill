using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ServiceContainer : IServiceContainer, IServiceProvider, IDisposable
{
	private sealed class ServiceCollection<T> : Dictionary<Type, T>
	{
		private sealed class EmbeddedTypeAwareTypeComparer : IEqualityComparer<Type>
		{
			public bool Equals(Type x, Type y)
			{
				return x.IsEquivalentTo(y);
			}

			public int GetHashCode(Type obj)
			{
				return obj.FullName.GetHashCode();
			}
		}

		private static EmbeddedTypeAwareTypeComparer serviceTypeComparer = new EmbeddedTypeAwareTypeComparer();

		public ServiceCollection()
			: base((IEqualityComparer<Type>)serviceTypeComparer)
		{
		}
	}

	private ServiceCollection<object> services;

	private IServiceProvider parentProvider;

	private static Type[] _defaultServices = new Type[2]
	{
		typeof(IServiceContainer),
		typeof(ServiceContainer)
	};

	private static TraceSwitch TRACESERVICE = new TraceSwitch("TRACESERVICE", "ServiceProvider: Trace service provider requests.");

	private IServiceContainer Container
	{
		get
		{
			IServiceContainer result = null;
			if (parentProvider != null)
			{
				result = (IServiceContainer)parentProvider.GetService(typeof(IServiceContainer));
			}
			return result;
		}
	}

	protected virtual Type[] DefaultServices => _defaultServices;

	private ServiceCollection<object> Services
	{
		get
		{
			if (services == null)
			{
				services = new ServiceCollection<object>();
			}
			return services;
		}
	}

	public ServiceContainer()
	{
	}

	public ServiceContainer(IServiceProvider parentProvider)
	{
		this.parentProvider = parentProvider;
	}

	public void AddService(Type serviceType, object serviceInstance)
	{
		AddService(serviceType, serviceInstance, promote: false);
	}

	public virtual void AddService(Type serviceType, object serviceInstance, bool promote)
	{
		if (promote)
		{
			IServiceContainer container = Container;
			if (container != null)
			{
				container.AddService(serviceType, serviceInstance, promote);
				return;
			}
		}
		if (serviceType == null)
		{
			throw new ArgumentNullException("serviceType");
		}
		if (serviceInstance == null)
		{
			throw new ArgumentNullException("serviceInstance");
		}
		if (!(serviceInstance is ServiceCreatorCallback) && !serviceInstance.GetType().IsCOMObject && !serviceType.IsAssignableFrom(serviceInstance.GetType()))
		{
			throw new ArgumentException(SR.GetString("ErrorInvalidServiceInstance", serviceType.FullName));
		}
		if (Services.ContainsKey(serviceType))
		{
			throw new ArgumentException(SR.GetString("ErrorServiceExists", serviceType.FullName), "serviceType");
		}
		Services[serviceType] = serviceInstance;
	}

	public void AddService(Type serviceType, ServiceCreatorCallback callback)
	{
		AddService(serviceType, callback, promote: false);
	}

	public virtual void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote)
	{
		if (promote)
		{
			IServiceContainer container = Container;
			if (container != null)
			{
				container.AddService(serviceType, callback, promote);
				return;
			}
		}
		if (serviceType == null)
		{
			throw new ArgumentNullException("serviceType");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		if (Services.ContainsKey(serviceType))
		{
			throw new ArgumentException(SR.GetString("ErrorServiceExists", serviceType.FullName), "serviceType");
		}
		Services[serviceType] = callback;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		ServiceCollection<object> serviceCollection = services;
		services = null;
		if (serviceCollection == null)
		{
			return;
		}
		foreach (object value in serviceCollection.Values)
		{
			if (value is IDisposable)
			{
				((IDisposable)value).Dispose();
			}
		}
	}

	public virtual object GetService(Type serviceType)
	{
		object value = null;
		Type[] defaultServices = DefaultServices;
		for (int i = 0; i < defaultServices.Length; i++)
		{
			if (serviceType.IsEquivalentTo(defaultServices[i]))
			{
				value = this;
				break;
			}
		}
		if (value == null)
		{
			Services.TryGetValue(serviceType, out value);
		}
		if (value is ServiceCreatorCallback)
		{
			value = ((ServiceCreatorCallback)value)(this, serviceType);
			if (value != null && !value.GetType().IsCOMObject && !serviceType.IsAssignableFrom(value.GetType()))
			{
				value = null;
			}
			Services[serviceType] = value;
		}
		if (value == null && parentProvider != null)
		{
			value = parentProvider.GetService(serviceType);
		}
		return value;
	}

	public void RemoveService(Type serviceType)
	{
		RemoveService(serviceType, promote: false);
	}

	public virtual void RemoveService(Type serviceType, bool promote)
	{
		if (promote)
		{
			IServiceContainer container = Container;
			if (container != null)
			{
				container.RemoveService(serviceType, promote);
				return;
			}
		}
		if (serviceType == null)
		{
			throw new ArgumentNullException("serviceType");
		}
		Services.Remove(serviceType);
	}
}
