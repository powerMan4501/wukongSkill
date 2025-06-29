using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, ExternalProcessMgmt = true)]
public sealed class LicenseManager
{
	private class LicenseInteropHelper
	{
		internal class CLRLicenseContext : LicenseContext
		{
			private LicenseUsageMode usageMode;

			private Type type;

			private string key;

			public override LicenseUsageMode UsageMode => usageMode;

			public CLRLicenseContext(LicenseUsageMode usageMode, Type type)
			{
				this.usageMode = usageMode;
				this.type = type;
			}

			public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
			{
				if (!(type == this.type))
				{
					return null;
				}
				return key;
			}

			public override void SetSavedLicenseKey(Type type, string key)
			{
				if (type == this.type)
				{
					this.key = key;
				}
			}
		}

		private const int S_OK = 0;

		private const int E_NOTIMPL = -2147467263;

		private const int CLASS_E_NOTLICENSED = -2147221230;

		private const int E_FAIL = -2147483640;

		private DesigntimeLicenseContext helperContext;

		private LicenseContext savedLicenseContext;

		private Type savedType;

		private static object AllocateAndValidateLicense(RuntimeTypeHandle rth, IntPtr bstrKey, int fDesignTime)
		{
			Type typeFromHandle = Type.GetTypeFromHandle(rth);
			CLRLicenseContext cLRLicenseContext = new CLRLicenseContext((fDesignTime != 0) ? LicenseUsageMode.Designtime : LicenseUsageMode.Runtime, typeFromHandle);
			if (fDesignTime == 0 && bstrKey != (IntPtr)0)
			{
				cLRLicenseContext.SetSavedLicenseKey(typeFromHandle, Marshal.PtrToStringBSTR(bstrKey));
			}
			try
			{
				return CreateWithContext(typeFromHandle, cLRLicenseContext);
			}
			catch (LicenseException ex)
			{
				throw new COMException(ex.Message, -2147221230);
			}
		}

		private static int RequestLicKey(RuntimeTypeHandle rth, ref IntPtr pbstrKey)
		{
			Type typeFromHandle = Type.GetTypeFromHandle(rth);
			if (!ValidateInternalRecursive(CurrentContext, typeFromHandle, null, allowExceptions: false, out var license, out var licenseKey))
			{
				return -2147483640;
			}
			if (licenseKey == null)
			{
				return -2147483640;
			}
			pbstrKey = Marshal.StringToBSTR(licenseKey);
			if (license != null)
			{
				license.Dispose();
				license = null;
			}
			return 0;
		}

		private void GetLicInfo(RuntimeTypeHandle rth, ref int pRuntimeKeyAvail, ref int pLicVerified)
		{
			pRuntimeKeyAvail = 0;
			pLicVerified = 0;
			Type typeFromHandle = Type.GetTypeFromHandle(rth);
			if (helperContext == null)
			{
				helperContext = new DesigntimeLicenseContext();
			}
			else
			{
				helperContext.savedLicenseKeys.Clear();
			}
			if (ValidateInternalRecursive(helperContext, typeFromHandle, null, allowExceptions: false, out var license, out var _))
			{
				if (helperContext.savedLicenseKeys.Contains(typeFromHandle.AssemblyQualifiedName))
				{
					pRuntimeKeyAvail = 1;
				}
				if (license != null)
				{
					license.Dispose();
					license = null;
					pLicVerified = 1;
				}
			}
		}

		private void GetCurrentContextInfo(ref int fDesignTime, ref IntPtr bstrKey, RuntimeTypeHandle rth)
		{
			savedLicenseContext = CurrentContext;
			savedType = Type.GetTypeFromHandle(rth);
			if (savedLicenseContext.UsageMode == LicenseUsageMode.Designtime)
			{
				fDesignTime = 1;
				bstrKey = (IntPtr)0;
			}
			else
			{
				fDesignTime = 0;
				string savedLicenseKey = savedLicenseContext.GetSavedLicenseKey(savedType, null);
				bstrKey = Marshal.StringToBSTR(savedLicenseKey);
			}
		}

		private void SaveKeyInCurrentContext(IntPtr bstrKey)
		{
			if (bstrKey != (IntPtr)0)
			{
				savedLicenseContext.SetSavedLicenseKey(savedType, Marshal.PtrToStringBSTR(bstrKey));
			}
		}
	}

	private static readonly object selfLock = new object();

	private static volatile LicenseContext context = null;

	private static object contextLockHolder = null;

	private static volatile Hashtable providers;

	private static volatile Hashtable providerInstances;

	private static object internalSyncObject = new object();

	public static LicenseContext CurrentContext
	{
		get
		{
			if (context == null)
			{
				lock (internalSyncObject)
				{
					if (context == null)
					{
						context = new RuntimeLicenseContext();
					}
				}
			}
			return context;
		}
		set
		{
			lock (internalSyncObject)
			{
				if (contextLockHolder != null)
				{
					throw new InvalidOperationException(SR.GetString("LicMgrContextCannotBeChanged"));
				}
				context = value;
			}
		}
	}

	public static LicenseUsageMode UsageMode
	{
		get
		{
			if (context != null)
			{
				return context.UsageMode;
			}
			return LicenseUsageMode.Runtime;
		}
	}

	private LicenseManager()
	{
	}

	private static void CacheProvider(Type type, LicenseProvider provider)
	{
		if (providers == null)
		{
			providers = new Hashtable();
		}
		providers[type] = provider;
		if (provider != null)
		{
			if (providerInstances == null)
			{
				providerInstances = new Hashtable();
			}
			providerInstances[provider.GetType()] = provider;
		}
	}

	public static object CreateWithContext(Type type, LicenseContext creationContext)
	{
		return CreateWithContext(type, creationContext, new object[0]);
	}

	public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
	{
		object obj = null;
		lock (internalSyncObject)
		{
			LicenseContext currentContext = CurrentContext;
			try
			{
				CurrentContext = creationContext;
				LockContext(selfLock);
				try
				{
					return SecurityUtils.SecureCreateInstance(type, args);
				}
				catch (TargetInvocationException ex)
				{
					throw ex.InnerException;
				}
			}
			finally
			{
				UnlockContext(selfLock);
				CurrentContext = currentContext;
			}
		}
	}

	private static bool GetCachedNoLicenseProvider(Type type)
	{
		if (providers != null)
		{
			return providers.ContainsKey(type);
		}
		return false;
	}

	private static LicenseProvider GetCachedProvider(Type type)
	{
		if (providers != null)
		{
			return (LicenseProvider)providers[type];
		}
		return null;
	}

	private static LicenseProvider GetCachedProviderInstance(Type providerType)
	{
		if (providerInstances != null)
		{
			return (LicenseProvider)providerInstances[providerType];
		}
		return null;
	}

	private static IntPtr GetLicenseInteropHelperType()
	{
		return typeof(LicenseInteropHelper).TypeHandle.Value;
	}

	public static bool IsLicensed(Type type)
	{
		License license;
		bool result = ValidateInternal(type, null, allowExceptions: false, out license);
		if (license != null)
		{
			license.Dispose();
			license = null;
		}
		return result;
	}

	public static bool IsValid(Type type)
	{
		License license;
		bool result = ValidateInternal(type, null, allowExceptions: false, out license);
		if (license != null)
		{
			license.Dispose();
			license = null;
		}
		return result;
	}

	public static bool IsValid(Type type, object instance, out License license)
	{
		return ValidateInternal(type, instance, allowExceptions: false, out license);
	}

	public static void LockContext(object contextUser)
	{
		lock (internalSyncObject)
		{
			if (contextLockHolder != null)
			{
				throw new InvalidOperationException(SR.GetString("LicMgrAlreadyLocked"));
			}
			contextLockHolder = contextUser;
		}
	}

	public static void UnlockContext(object contextUser)
	{
		lock (internalSyncObject)
		{
			if (contextLockHolder != contextUser)
			{
				throw new ArgumentException(SR.GetString("LicMgrDifferentUser"));
			}
			contextLockHolder = null;
		}
	}

	private static bool ValidateInternal(Type type, object instance, bool allowExceptions, out License license)
	{
		string licenseKey;
		return ValidateInternalRecursive(CurrentContext, type, instance, allowExceptions, out license, out licenseKey);
	}

	private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, out License license, out string licenseKey)
	{
		LicenseProvider licenseProvider = GetCachedProvider(type);
		if (licenseProvider == null && !GetCachedNoLicenseProvider(type))
		{
			LicenseProviderAttribute licenseProviderAttribute = (LicenseProviderAttribute)Attribute.GetCustomAttribute(type, typeof(LicenseProviderAttribute), inherit: false);
			if (licenseProviderAttribute != null)
			{
				Type licenseProvider2 = licenseProviderAttribute.LicenseProvider;
				licenseProvider = GetCachedProviderInstance(licenseProvider2);
				if (licenseProvider == null)
				{
					licenseProvider = (LicenseProvider)SecurityUtils.SecureCreateInstance(licenseProvider2);
				}
			}
			CacheProvider(type, licenseProvider);
		}
		license = null;
		bool flag = true;
		licenseKey = null;
		if (licenseProvider != null)
		{
			license = licenseProvider.GetLicense(context, type, instance, allowExceptions);
			if (license == null)
			{
				flag = false;
			}
			else
			{
				licenseKey = license.LicenseKey;
			}
		}
		if (flag && instance == null)
		{
			Type baseType = type.BaseType;
			if (baseType != typeof(object) && baseType != null)
			{
				if (license != null)
				{
					license.Dispose();
					license = null;
				}
				flag = ValidateInternalRecursive(context, baseType, null, allowExceptions, out license, out var _);
				if (license != null)
				{
					license.Dispose();
					license = null;
				}
			}
		}
		return flag;
	}

	public static void Validate(Type type)
	{
		if (!ValidateInternal(type, null, allowExceptions: true, out var license))
		{
			throw new LicenseException(type);
		}
		if (license != null)
		{
			license.Dispose();
			license = null;
		}
	}

	public static License Validate(Type type, object instance)
	{
		if (!ValidateInternal(type, instance, allowExceptions: true, out var license))
		{
			throw new LicenseException(type, instance);
		}
		return license;
	}
}
