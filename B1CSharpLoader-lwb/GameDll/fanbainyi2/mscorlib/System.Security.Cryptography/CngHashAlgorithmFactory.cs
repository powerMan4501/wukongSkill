using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace System.Security.Cryptography;

internal sealed class CngHashAlgorithmFactory<THashAlgorithm> where THashAlgorithm : HashAlgorithm
{
	private static class FactoryBuilder
	{
		private static class Impl
		{
			internal static Func<THashAlgorithm> SafeCreateFactory(string fullTypeName, out Exception exception)
			{
				exception = null;
				try
				{
					try
					{
						Func<THashAlgorithm> func = DangerousFetchFactoryFromSystemCore(fullTypeName);
						THashAlgorithm val = func();
						if (val != null)
						{
							val.Dispose();
							return func;
						}
					}
					catch (Exception ex)
					{
						exception = ex;
					}
				}
				catch
				{
				}
				return null;
			}

			[SecuritySafeCritical]
			[ReflectionPermission(SecurityAction.Assert, Flags = ReflectionPermissionFlag.AllFlags)]
			private static Func<THashAlgorithm> DangerousFetchFactoryFromSystemCore(string fullTypeName)
			{
				Assembly assembly = Assembly.Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
				Type type = assembly.GetType(fullTypeName + "Factory");
				MethodInfo method = type.GetMethod("CreateNew", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
				return (Func<THashAlgorithm>)method.CreateDelegate(typeof(Func<THashAlgorithm>));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Func<THashAlgorithm> SafeCreateFactory(string fullTypeName, out Exception exception)
		{
			return Impl.SafeCreateFactory(fullTypeName, out exception);
		}
	}

	private readonly string _fullTypeName;

	private Func<THashAlgorithm> _innerFactory;

	private volatile bool _innerFactoryInitialized;

	private Exception _mostRecentException;

	internal CngHashAlgorithmFactory(string fullTypeName)
	{
		_fullTypeName = fullTypeName;
	}

	internal THashAlgorithm CreateInstance()
	{
		THashAlgorithm val = null;
		if (!_innerFactoryInitialized && !AppDomain.IsStillInEarlyInit())
		{
			_innerFactory = FactoryBuilder.SafeCreateFactory(_fullTypeName, out _mostRecentException);
			_innerFactoryInitialized = true;
		}
		if (_innerFactoryInitialized)
		{
			try
			{
				try
				{
					Func<THashAlgorithm> innerFactory = _innerFactory;
					val = ((innerFactory != null) ? innerFactory() : null);
				}
				catch (Exception mostRecentException)
				{
					_mostRecentException = mostRecentException;
				}
			}
			catch
			{
			}
		}
		if (val == null)
		{
			val = (THashAlgorithm)CryptoConfig.CreateFromName(_fullTypeName);
		}
		return val;
	}
}
