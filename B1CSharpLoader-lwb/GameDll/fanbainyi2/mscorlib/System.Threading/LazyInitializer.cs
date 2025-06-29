using System.Security.Permissions;

namespace System.Threading;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public static class LazyInitializer
{
	[__DynamicallyInvokable]
	public static T EnsureInitialized<T>(ref T target) where T : class
	{
		if (Volatile.Read(ref target) != null)
		{
			return target;
		}
		return EnsureInitializedCore(ref target, LazyHelpers<T>.s_activatorFactorySelector);
	}

	[__DynamicallyInvokable]
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
	{
		if (Volatile.Read(ref target) != null)
		{
			return target;
		}
		return EnsureInitializedCore(ref target, valueFactory);
	}

	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
	{
		T val = valueFactory();
		if (val == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Lazy_StaticInit_InvalidOperation"));
		}
		Interlocked.CompareExchange(ref target, val, null);
		return target;
	}

	[__DynamicallyInvokable]
	public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock)
	{
		if (Volatile.Read(ref initialized))
		{
			return target;
		}
		return EnsureInitializedCore(ref target, ref initialized, ref syncLock, LazyHelpers<T>.s_activatorFactorySelector);
	}

	[__DynamicallyInvokable]
	public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory)
	{
		if (Volatile.Read(ref initialized))
		{
			return target;
		}
		return EnsureInitializedCore(ref target, ref initialized, ref syncLock, valueFactory);
	}

	private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory)
	{
		object obj = syncLock;
		if (obj == null)
		{
			object obj2 = new object();
			obj = Interlocked.CompareExchange(ref syncLock, obj2, null);
			if (obj == null)
			{
				obj = obj2;
			}
		}
		lock (obj)
		{
			if (!Volatile.Read(ref initialized))
			{
				target = valueFactory();
				Volatile.Write(ref initialized, value: true);
			}
		}
		return target;
	}
}
