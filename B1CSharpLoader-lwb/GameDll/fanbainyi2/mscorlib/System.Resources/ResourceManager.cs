using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading;

namespace System.Resources;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class ResourceManager
{
	internal class CultureNameResourceSetPair
	{
		public string lastCultureName;

		public ResourceSet lastResourceSet;
	}

	internal class ResourceManagerMediator
	{
		private ResourceManager _rm;

		internal string ModuleDir => _rm.moduleDir;

		internal Type LocationInfo => _rm._locationInfo;

		internal Type UserResourceSet => _rm._userResourceSet;

		internal string BaseNameField => _rm.BaseNameField;

		internal CultureInfo NeutralResourcesCulture
		{
			get
			{
				return _rm._neutralResourcesCulture;
			}
			set
			{
				_rm._neutralResourcesCulture = value;
			}
		}

		internal bool LookedForSatelliteContractVersion
		{
			get
			{
				return _rm._lookedForSatelliteContractVersion;
			}
			set
			{
				_rm._lookedForSatelliteContractVersion = value;
			}
		}

		internal Version SatelliteContractVersion
		{
			get
			{
				return _rm._satelliteContractVersion;
			}
			set
			{
				_rm._satelliteContractVersion = value;
			}
		}

		internal UltimateResourceFallbackLocation FallbackLoc
		{
			get
			{
				return _rm.FallbackLocation;
			}
			set
			{
				_rm._fallbackLoc = value;
			}
		}

		internal RuntimeAssembly CallingAssembly => _rm.m_callingAssembly;

		internal RuntimeAssembly MainAssembly => (RuntimeAssembly)_rm.MainAssembly;

		internal string BaseName => _rm.BaseName;

		internal ResourceManagerMediator(ResourceManager rm)
		{
			if (rm == null)
			{
				throw new ArgumentNullException("rm");
			}
			_rm = rm;
		}

		internal string GetResourceFileName(CultureInfo culture)
		{
			return _rm.GetResourceFileName(culture);
		}

		internal Version ObtainSatelliteContractVersion(Assembly a)
		{
			return GetSatelliteContractVersion(a);
		}

		[SecurityCritical]
		internal bool TryLookingForSatellite(CultureInfo lookForCulture)
		{
			return _rm.TryLookingForSatellite(lookForCulture);
		}
	}

	protected string BaseNameField;

	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets;

	[NonSerialized]
	private Dictionary<string, ResourceSet> _resourceSets;

	private string moduleDir;

	protected Assembly MainAssembly;

	private Type _locationInfo;

	private Type _userResourceSet;

	private CultureInfo _neutralResourcesCulture;

	[NonSerialized]
	private CultureNameResourceSetPair _lastUsedResourceCache;

	private bool _ignoreCase;

	private bool UseManifest;

	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem;

	private static volatile Hashtable _installedSatelliteInfo;

	private static volatile bool _checkedConfigFile;

	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc;

	[OptionalField]
	private Version _satelliteContractVersion;

	[OptionalField]
	private bool _lookedForSatelliteContractVersion;

	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly;

	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly;

	[NonSerialized]
	private IResourceGroveler resourceGroveler;

	public static readonly int MagicNumber = -1091581234;

	public static readonly int HeaderVersionNumber = 1;

	private static readonly Type _minResourceSet = typeof(ResourceSet);

	internal static readonly string ResReaderTypeName = typeof(ResourceReader).FullName;

	internal static readonly string ResSetTypeName = typeof(RuntimeResourceSet).FullName;

	internal static readonly string MscorlibName = typeof(ResourceReader).Assembly.FullName;

	internal const string ResFileExtension = ".resources";

	internal const int ResFileExtensionLength = 10;

	internal static readonly int DEBUG = 0;

	private static volatile bool s_IsAppXModel;

	[NonSerialized]
	private bool _bUsingModernResourceManagement;

	[NonSerialized]
	[SecurityCritical]
	private WindowsRuntimeResourceManagerBase _WinRTResourceManager;

	[NonSerialized]
	private bool _PRIonAppXInitialized;

	[NonSerialized]
	private PRIExceptionInfo _PRIExceptionInfo;

	public virtual string BaseName => BaseNameField;

	public virtual bool IgnoreCase
	{
		get
		{
			return _ignoreCase;
		}
		set
		{
			_ignoreCase = value;
		}
	}

	public virtual Type ResourceSetType
	{
		get
		{
			if (!(_userResourceSet == null))
			{
				return _userResourceSet;
			}
			return typeof(RuntimeResourceSet);
		}
	}

	protected UltimateResourceFallbackLocation FallbackLocation
	{
		get
		{
			return _fallbackLoc;
		}
		set
		{
			_fallbackLoc = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
	}

	protected ResourceManager()
	{
		Init();
		_lastUsedResourceCache = new CultureNameResourceSetPair();
		ResourceManagerMediator mediator = new ResourceManagerMediator(this);
		resourceGroveler = new ManifestBasedResourceGroveler(mediator);
	}

	private ResourceManager(string baseName, string resourceDir, Type usingResourceSet)
	{
		if (baseName == null)
		{
			throw new ArgumentNullException("baseName");
		}
		if (resourceDir == null)
		{
			throw new ArgumentNullException("resourceDir");
		}
		BaseNameField = baseName;
		moduleDir = resourceDir;
		_userResourceSet = usingResourceSet;
		ResourceSets = new Hashtable();
		_resourceSets = new Dictionary<string, ResourceSet>();
		_lastUsedResourceCache = new CultureNameResourceSetPair();
		UseManifest = false;
		ResourceManagerMediator mediator = new ResourceManagerMediator(this);
		resourceGroveler = new FileBasedResourceGroveler(mediator);
		if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled())
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string resourceFileName = GetResourceFileName(invariantCulture);
			if (resourceGroveler.HasNeutralResources(invariantCulture, resourceFileName))
			{
				FrameworkEventSource.Log.ResourceManagerNeutralResourcesFound(BaseNameField, MainAssembly, resourceFileName);
			}
			else
			{
				FrameworkEventSource.Log.ResourceManagerNeutralResourcesNotFound(BaseNameField, MainAssembly, resourceFileName);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public ResourceManager(string baseName, Assembly assembly)
	{
		if (baseName == null)
		{
			throw new ArgumentNullException("baseName");
		}
		if (null == assembly)
		{
			throw new ArgumentNullException("assembly");
		}
		if (!(assembly is RuntimeAssembly))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"));
		}
		MainAssembly = assembly;
		BaseNameField = baseName;
		SetAppXConfiguration();
		CommonAssemblyInit();
		m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
		if (assembly == typeof(object).Assembly && m_callingAssembly != assembly)
		{
			m_callingAssembly = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceManager(string baseName, Assembly assembly, Type usingResourceSet)
	{
		if (baseName == null)
		{
			throw new ArgumentNullException("baseName");
		}
		if (null == assembly)
		{
			throw new ArgumentNullException("assembly");
		}
		if (!(assembly is RuntimeAssembly))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"));
		}
		MainAssembly = assembly;
		BaseNameField = baseName;
		if (usingResourceSet != null && usingResourceSet != _minResourceSet && !usingResourceSet.IsSubclassOf(_minResourceSet))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ResMgrNotResSet"), "usingResourceSet");
		}
		_userResourceSet = usingResourceSet;
		CommonAssemblyInit();
		m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
		if (assembly == typeof(object).Assembly && m_callingAssembly != assembly)
		{
			m_callingAssembly = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public ResourceManager(Type resourceSource)
	{
		if (null == resourceSource)
		{
			throw new ArgumentNullException("resourceSource");
		}
		if (!(resourceSource is RuntimeType))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		_locationInfo = resourceSource;
		MainAssembly = _locationInfo.Assembly;
		BaseNameField = resourceSource.Name;
		SetAppXConfiguration();
		CommonAssemblyInit();
		m_callingAssembly = (RuntimeAssembly)Assembly.GetCallingAssembly();
		if (MainAssembly == typeof(object).Assembly && m_callingAssembly != MainAssembly)
		{
			m_callingAssembly = null;
		}
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
		_resourceSets = null;
		resourceGroveler = null;
		_lastUsedResourceCache = null;
	}

	[SecuritySafeCritical]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		_resourceSets = new Dictionary<string, ResourceSet>();
		_lastUsedResourceCache = new CultureNameResourceSetPair();
		ResourceManagerMediator mediator = new ResourceManagerMediator(this);
		if (UseManifest)
		{
			resourceGroveler = new ManifestBasedResourceGroveler(mediator);
		}
		else
		{
			resourceGroveler = new FileBasedResourceGroveler(mediator);
		}
		if (m_callingAssembly == null)
		{
			m_callingAssembly = (RuntimeAssembly)_callingAssembly;
		}
		if (UseManifest && _neutralResourcesCulture == null)
		{
			_neutralResourcesCulture = ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(MainAssembly, ref _fallbackLoc);
		}
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		_callingAssembly = m_callingAssembly;
		UseSatelliteAssem = UseManifest;
		ResourceSets = new Hashtable();
	}

	[SecuritySafeCritical]
	private void CommonAssemblyInit()
	{
		if (!_bUsingModernResourceManagement)
		{
			UseManifest = true;
			_resourceSets = new Dictionary<string, ResourceSet>();
			_lastUsedResourceCache = new CultureNameResourceSetPair();
			_fallbackLoc = UltimateResourceFallbackLocation.MainAssembly;
			ResourceManagerMediator mediator = new ResourceManagerMediator(this);
			resourceGroveler = new ManifestBasedResourceGroveler(mediator);
		}
		_neutralResourcesCulture = ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(MainAssembly, ref _fallbackLoc);
		if (_bUsingModernResourceManagement)
		{
			return;
		}
		if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled())
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string resourceFileName = GetResourceFileName(invariantCulture);
			if (resourceGroveler.HasNeutralResources(invariantCulture, resourceFileName))
			{
				FrameworkEventSource.Log.ResourceManagerNeutralResourcesFound(BaseNameField, MainAssembly, resourceFileName);
			}
			else
			{
				string resName = resourceFileName;
				if (_locationInfo != null && _locationInfo.Namespace != null)
				{
					resName = _locationInfo.Namespace + Type.Delimiter + resourceFileName;
				}
				FrameworkEventSource.Log.ResourceManagerNeutralResourcesNotFound(BaseNameField, MainAssembly, resName);
			}
		}
		ResourceSets = new Hashtable();
	}

	public virtual void ReleaseAllResources()
	{
		if (FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerReleasingResources(BaseNameField, MainAssembly);
		}
		Dictionary<string, ResourceSet> resourceSets = _resourceSets;
		_resourceSets = new Dictionary<string, ResourceSet>();
		_lastUsedResourceCache = new CultureNameResourceSetPair();
		lock (resourceSets)
		{
			IDictionaryEnumerator dictionaryEnumerator = resourceSets.GetEnumerator();
			IDictionaryEnumerator dictionaryEnumerator2 = null;
			if (ResourceSets != null)
			{
				dictionaryEnumerator2 = ResourceSets.GetEnumerator();
			}
			ResourceSets = new Hashtable();
			while (dictionaryEnumerator.MoveNext())
			{
				((ResourceSet)dictionaryEnumerator.Value).Close();
			}
			if (dictionaryEnumerator2 != null)
			{
				while (dictionaryEnumerator2.MoveNext())
				{
					((ResourceSet)dictionaryEnumerator2.Value).Close();
				}
			}
		}
	}

	public static ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, Type usingResourceSet)
	{
		return new ResourceManager(baseName, resourceDir, usingResourceSet);
	}

	protected virtual string GetResourceFileName(CultureInfo culture)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		stringBuilder.Append(BaseNameField);
		if (!culture.HasInvariantCultureName)
		{
			CultureInfo.VerifyCultureName(culture.Name, throwException: true);
			stringBuilder.Append('.');
			stringBuilder.Append(culture.Name);
		}
		stringBuilder.Append(".resources");
		return stringBuilder.ToString();
	}

	internal ResourceSet GetFirstResourceSet(CultureInfo culture)
	{
		if (_neutralResourcesCulture != null && culture.Name == _neutralResourcesCulture.Name)
		{
			culture = CultureInfo.InvariantCulture;
		}
		if (_lastUsedResourceCache != null)
		{
			lock (_lastUsedResourceCache)
			{
				if (culture.Name == _lastUsedResourceCache.lastCultureName)
				{
					return _lastUsedResourceCache.lastResourceSet;
				}
			}
		}
		Dictionary<string, ResourceSet> resourceSets = _resourceSets;
		ResourceSet value = null;
		if (resourceSets != null)
		{
			lock (resourceSets)
			{
				resourceSets.TryGetValue(culture.Name, out value);
			}
		}
		if (value != null)
		{
			if (_lastUsedResourceCache != null)
			{
				lock (_lastUsedResourceCache)
				{
					_lastUsedResourceCache.lastCultureName = culture.Name;
					_lastUsedResourceCache.lastResourceSet = value;
				}
			}
			return value;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		Dictionary<string, ResourceSet> resourceSets = _resourceSets;
		if (resourceSets != null)
		{
			lock (resourceSets)
			{
				if (resourceSets.TryGetValue(culture.Name, out var value))
				{
					return value;
				}
			}
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		if (UseManifest && culture.HasInvariantCultureName)
		{
			string resourceFileName = GetResourceFileName(culture);
			RuntimeAssembly runtimeAssembly = (RuntimeAssembly)MainAssembly;
			Stream manifestResourceStream = runtimeAssembly.GetManifestResourceStream(_locationInfo, resourceFileName, m_callingAssembly == MainAssembly, ref stackMark);
			if (createIfNotExists && manifestResourceStream != null)
			{
				ResourceSet value = ((ManifestBasedResourceGroveler)resourceGroveler).CreateResourceSet(manifestResourceStream, MainAssembly);
				AddResourceSet(resourceSets, culture.Name, ref value);
				return value;
			}
		}
		return InternalGetResourceSet(culture, createIfNotExists, tryParents);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalGetResourceSet(culture, createIfNotExists, tryParents, ref stackMark);
	}

	[SecurityCritical]
	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark)
	{
		Dictionary<string, ResourceSet> resourceSets = _resourceSets;
		ResourceSet value = null;
		CultureInfo cultureInfo = null;
		lock (resourceSets)
		{
			if (resourceSets.TryGetValue(requestedCulture.Name, out value))
			{
				if (FrameworkEventSource.IsInitialized)
				{
					FrameworkEventSource.Log.ResourceManagerFoundResourceSetInCache(BaseNameField, MainAssembly, requestedCulture.Name);
				}
				return value;
			}
		}
		ResourceFallbackManager resourceFallbackManager = new ResourceFallbackManager(requestedCulture, _neutralResourcesCulture, tryParents);
		foreach (CultureInfo item in resourceFallbackManager)
		{
			if (FrameworkEventSource.IsInitialized)
			{
				FrameworkEventSource.Log.ResourceManagerLookingForResourceSet(BaseNameField, MainAssembly, item.Name);
			}
			lock (resourceSets)
			{
				if (resourceSets.TryGetValue(item.Name, out value))
				{
					if (FrameworkEventSource.IsInitialized)
					{
						FrameworkEventSource.Log.ResourceManagerFoundResourceSetInCache(BaseNameField, MainAssembly, item.Name);
					}
					if (requestedCulture != item)
					{
						cultureInfo = item;
					}
					break;
				}
			}
			value = resourceGroveler.GrovelForResourceSet(item, resourceSets, tryParents, createIfNotExists, ref stackMark);
			if (value != null)
			{
				cultureInfo = item;
				break;
			}
		}
		if (value != null && cultureInfo != null)
		{
			foreach (CultureInfo item2 in resourceFallbackManager)
			{
				AddResourceSet(resourceSets, item2.Name, ref value);
				if (item2 == cultureInfo)
				{
					break;
				}
			}
		}
		return value;
	}

	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
	{
		lock (localResourceSets)
		{
			if (localResourceSets.TryGetValue(cultureName, out var value))
			{
				if (value != rs)
				{
					if (!localResourceSets.ContainsValue(rs))
					{
						rs.Dispose();
					}
					rs = value;
				}
			}
			else
			{
				localResourceSets.Add(cultureName, rs);
			}
		}
	}

	protected static Version GetSatelliteContractVersion(Assembly a)
	{
		if (a == null)
		{
			throw new ArgumentNullException("a", Environment.GetResourceString("ArgumentNull_Assembly"));
		}
		string text = null;
		if (a.ReflectionOnly)
		{
			foreach (CustomAttributeData customAttribute in CustomAttributeData.GetCustomAttributes(a))
			{
				if (customAttribute.Constructor.DeclaringType == typeof(SatelliteContractVersionAttribute))
				{
					text = (string)customAttribute.ConstructorArguments[0].Value;
					break;
				}
			}
			if (text == null)
			{
				return null;
			}
		}
		else
		{
			object[] customAttributes = a.GetCustomAttributes(typeof(SatelliteContractVersionAttribute), inherit: false);
			if (customAttributes.Length == 0)
			{
				return null;
			}
			text = ((SatelliteContractVersionAttribute)customAttributes[0]).Version;
		}
		try
		{
			return new Version(text);
		}
		catch (ArgumentOutOfRangeException innerException)
		{
			if (a == typeof(object).Assembly)
			{
				return null;
			}
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidSatelliteContract_Asm_Ver", a.ToString(), text), innerException);
		}
	}

	[SecuritySafeCritical]
	protected static CultureInfo GetNeutralResourcesLanguage(Assembly a)
	{
		UltimateResourceFallbackLocation fallbackLocation = UltimateResourceFallbackLocation.MainAssembly;
		return ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(a, ref fallbackLocation);
	}

	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
	{
		int num = asmTypeName1.IndexOf(',');
		if (((num == -1) ? asmTypeName1.Length : num) != typeName2.Length)
		{
			return false;
		}
		if (string.Compare(asmTypeName1, 0, typeName2, 0, typeName2.Length, StringComparison.Ordinal) != 0)
		{
			return false;
		}
		if (num == -1)
		{
			return true;
		}
		while (char.IsWhiteSpace(asmTypeName1[++num]))
		{
		}
		AssemblyName assemblyName = new AssemblyName(asmTypeName1.Substring(num));
		if (string.Compare(assemblyName.Name, asmName2.Name, StringComparison.OrdinalIgnoreCase) != 0)
		{
			return false;
		}
		if (string.Compare(assemblyName.Name, "mscorlib", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (assemblyName.CultureInfo != null && asmName2.CultureInfo != null && assemblyName.CultureInfo.LCID != asmName2.CultureInfo.LCID)
		{
			return false;
		}
		byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
		byte[] publicKeyToken2 = asmName2.GetPublicKeyToken();
		if (publicKeyToken != null && publicKeyToken2 != null)
		{
			if (publicKeyToken.Length != publicKeyToken2.Length)
			{
				return false;
			}
			for (int i = 0; i < publicKeyToken.Length; i++)
			{
				if (publicKeyToken[i] != publicKeyToken2[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	[SecuritySafeCritical]
	private string GetStringFromPRI(string stringName, string startingCulture, string neutralResourcesCulture)
	{
		if (stringName.Length == 0)
		{
			return null;
		}
		string text = null;
		return _WinRTResourceManager.GetString(stringName, string.IsNullOrEmpty(startingCulture) ? null : startingCulture, string.IsNullOrEmpty(neutralResourcesCulture) ? null : neutralResourcesCulture);
	}

	[SecurityCritical]
	internal static WindowsRuntimeResourceManagerBase GetWinRTResourceManager()
	{
		Type type = Type.GetType("System.Resources.WindowsRuntimeResourceManager, System.Runtime.WindowsRuntime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", throwOnError: true);
		return (WindowsRuntimeResourceManagerBase)Activator.CreateInstance(type, nonPublic: true);
	}

	[SecuritySafeCritical]
	private bool ShouldUseSatelliteAssemblyResourceLookupUnderAppX(RuntimeAssembly resourcesAssembly)
	{
		return resourcesAssembly.IsFrameworkAssembly();
	}

	[SecuritySafeCritical]
	private void SetAppXConfiguration()
	{
		bool flag = false;
		RuntimeAssembly runtimeAssembly = (RuntimeAssembly)MainAssembly;
		if (runtimeAssembly == null)
		{
			runtimeAssembly = m_callingAssembly;
		}
		if (!(runtimeAssembly != null) || !(runtimeAssembly != typeof(object).Assembly) || !AppDomain.IsAppXModel() || AppDomain.IsAppXNGen)
		{
			return;
		}
		s_IsAppXModel = true;
		string text = ((_locationInfo == null) ? BaseNameField : _locationInfo.FullName);
		if (text == null)
		{
			text = string.Empty;
		}
		WindowsRuntimeResourceManagerBase windowsRuntimeResourceManagerBase = null;
		bool flag2 = false;
		if (AppDomain.IsAppXDesignMode())
		{
			windowsRuntimeResourceManagerBase = GetWinRTResourceManager();
			try
			{
				flag2 = windowsRuntimeResourceManagerBase.Initialize(runtimeAssembly.Location, text, out var _);
				flag = !flag2;
			}
			catch (Exception ex)
			{
				flag = true;
				if (ex.IsTransient)
				{
					throw;
				}
			}
		}
		if (flag)
		{
			return;
		}
		_bUsingModernResourceManagement = !ShouldUseSatelliteAssemblyResourceLookupUnderAppX(runtimeAssembly);
		if (!_bUsingModernResourceManagement)
		{
			return;
		}
		if (windowsRuntimeResourceManagerBase != null && flag2)
		{
			_WinRTResourceManager = windowsRuntimeResourceManagerBase;
			_PRIonAppXInitialized = true;
			return;
		}
		_WinRTResourceManager = GetWinRTResourceManager();
		try
		{
			_PRIonAppXInitialized = _WinRTResourceManager.Initialize(runtimeAssembly.Location, text, out _PRIExceptionInfo);
		}
		catch (FileNotFoundException)
		{
		}
		catch (Exception ex3)
		{
			if (ex3.HResult != -2147009761)
			{
				throw;
			}
		}
	}

	[__DynamicallyInvokable]
	public virtual string GetString(string name)
	{
		return GetString(name, null);
	}

	[__DynamicallyInvokable]
	public virtual string GetString(string name, CultureInfo culture)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (s_IsAppXModel && culture == CultureInfo.CurrentUICulture)
		{
			culture = null;
		}
		if (_bUsingModernResourceManagement)
		{
			if (!_PRIonAppXInitialized)
			{
				if (_PRIExceptionInfo != null && _PRIExceptionInfo._PackageSimpleName != null && _PRIExceptionInfo._ResWFile != null)
				{
					throw new MissingManifestResourceException(Environment.GetResourceString("MissingManifestResource_ResWFileNotLoaded", _PRIExceptionInfo._ResWFile, _PRIExceptionInfo._PackageSimpleName));
				}
				throw new MissingManifestResourceException(Environment.GetResourceString("MissingManifestResource_NoPRIresources"));
			}
			return GetStringFromPRI(name, culture?.Name, _neutralResourcesCulture.Name);
		}
		if (culture == null)
		{
			culture = Thread.CurrentThread.GetCurrentUICultureNoAppX();
		}
		if (FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerLookupStarted(BaseNameField, MainAssembly, culture.Name);
		}
		ResourceSet resourceSet = GetFirstResourceSet(culture);
		if (resourceSet != null)
		{
			string text = resourceSet.GetString(name, _ignoreCase);
			if (text != null)
			{
				return text;
			}
		}
		ResourceFallbackManager resourceFallbackManager = new ResourceFallbackManager(culture, _neutralResourcesCulture, useParents: true);
		foreach (CultureInfo item in resourceFallbackManager)
		{
			ResourceSet resourceSet2 = InternalGetResourceSet(item, createIfNotExists: true, tryParents: true);
			if (resourceSet2 == null)
			{
				break;
			}
			if (resourceSet2 == resourceSet)
			{
				continue;
			}
			string text2 = resourceSet2.GetString(name, _ignoreCase);
			if (text2 != null)
			{
				if (_lastUsedResourceCache != null)
				{
					lock (_lastUsedResourceCache)
					{
						_lastUsedResourceCache.lastCultureName = item.Name;
						_lastUsedResourceCache.lastResourceSet = resourceSet2;
					}
				}
				return text2;
			}
			resourceSet = resourceSet2;
		}
		if (FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerLookupFailed(BaseNameField, MainAssembly, culture.Name);
		}
		return null;
	}

	public virtual object GetObject(string name)
	{
		return GetObject(name, null, wrapUnmanagedMemStream: true);
	}

	public virtual object GetObject(string name, CultureInfo culture)
	{
		return GetObject(name, culture, wrapUnmanagedMemStream: true);
	}

	private object GetObject(string name, CultureInfo culture, bool wrapUnmanagedMemStream)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (s_IsAppXModel && culture == CultureInfo.CurrentUICulture)
		{
			culture = null;
		}
		if (culture == null)
		{
			culture = Thread.CurrentThread.GetCurrentUICultureNoAppX();
		}
		if (FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerLookupStarted(BaseNameField, MainAssembly, culture.Name);
		}
		ResourceSet resourceSet = GetFirstResourceSet(culture);
		if (resourceSet != null)
		{
			object obj = resourceSet.GetObject(name, _ignoreCase);
			if (obj != null)
			{
				UnmanagedMemoryStream unmanagedMemoryStream = obj as UnmanagedMemoryStream;
				if (unmanagedMemoryStream != null && wrapUnmanagedMemStream)
				{
					return new UnmanagedMemoryStreamWrapper(unmanagedMemoryStream);
				}
				return obj;
			}
		}
		ResourceFallbackManager resourceFallbackManager = new ResourceFallbackManager(culture, _neutralResourcesCulture, useParents: true);
		foreach (CultureInfo item in resourceFallbackManager)
		{
			ResourceSet resourceSet2 = InternalGetResourceSet(item, createIfNotExists: true, tryParents: true);
			if (resourceSet2 == null)
			{
				break;
			}
			if (resourceSet2 == resourceSet)
			{
				continue;
			}
			object obj2 = resourceSet2.GetObject(name, _ignoreCase);
			if (obj2 != null)
			{
				if (_lastUsedResourceCache != null)
				{
					lock (_lastUsedResourceCache)
					{
						_lastUsedResourceCache.lastCultureName = item.Name;
						_lastUsedResourceCache.lastResourceSet = resourceSet2;
					}
				}
				UnmanagedMemoryStream unmanagedMemoryStream2 = obj2 as UnmanagedMemoryStream;
				if (unmanagedMemoryStream2 != null && wrapUnmanagedMemStream)
				{
					return new UnmanagedMemoryStreamWrapper(unmanagedMemoryStream2);
				}
				return obj2;
			}
			resourceSet = resourceSet2;
		}
		if (FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerLookupFailed(BaseNameField, MainAssembly, culture.Name);
		}
		return null;
	}

	[ComVisible(false)]
	public UnmanagedMemoryStream GetStream(string name)
	{
		return GetStream(name, null);
	}

	[ComVisible(false)]
	public UnmanagedMemoryStream GetStream(string name, CultureInfo culture)
	{
		object obj = GetObject(name, culture, wrapUnmanagedMemStream: false);
		UnmanagedMemoryStream unmanagedMemoryStream = obj as UnmanagedMemoryStream;
		if (unmanagedMemoryStream == null && obj != null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ResourceNotStream_Name", name));
		}
		return unmanagedMemoryStream;
	}

	[SecurityCritical]
	private bool TryLookingForSatellite(CultureInfo lookForCulture)
	{
		if (!_checkedConfigFile)
		{
			lock (this)
			{
				if (!_checkedConfigFile)
				{
					_checkedConfigFile = true;
					_installedSatelliteInfo = GetSatelliteAssembliesFromConfig();
				}
			}
		}
		if (_installedSatelliteInfo == null)
		{
			return true;
		}
		string[] array = (string[])_installedSatelliteInfo[MainAssembly.FullName];
		if (array == null)
		{
			return true;
		}
		int num = Array.IndexOf(array, lookForCulture.Name);
		if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled())
		{
			if (num < 0)
			{
				FrameworkEventSource.Log.ResourceManagerCultureNotFoundInConfigFile(BaseNameField, MainAssembly, lookForCulture.Name);
			}
			else
			{
				FrameworkEventSource.Log.ResourceManagerCultureFoundInConfigFile(BaseNameField, MainAssembly, lookForCulture.Name);
			}
		}
		return num >= 0;
	}

	[SecurityCritical]
	private Hashtable GetSatelliteAssembliesFromConfig()
	{
		string configurationFileInternal = AppDomain.CurrentDomain.FusionStore.ConfigurationFileInternal;
		if (configurationFileInternal == null)
		{
			return null;
		}
		if (configurationFileInternal.Length >= 2 && (configurationFileInternal[1] == Path.VolumeSeparatorChar || (configurationFileInternal[0] == Path.DirectorySeparatorChar && configurationFileInternal[1] == Path.DirectorySeparatorChar)) && !File.InternalExists(configurationFileInternal))
		{
			return null;
		}
		ConfigTreeParser configTreeParser = new ConfigTreeParser();
		string configPath = "/configuration/satelliteassemblies";
		ConfigNode configNode = null;
		try
		{
			configNode = configTreeParser.Parse(configurationFileInternal, configPath, skipSecurityStuff: true);
		}
		catch (Exception)
		{
		}
		if (configNode == null)
		{
			return null;
		}
		Hashtable hashtable = new Hashtable(StringComparer.OrdinalIgnoreCase);
		foreach (ConfigNode child in configNode.Children)
		{
			if (!string.Equals(child.Name, "assembly"))
			{
				throw new ApplicationException(Environment.GetResourceString("XMLSyntax_InvalidSyntaxSatAssemTag", Path.GetFileName(configurationFileInternal), child.Name));
			}
			if (child.Attributes.Count == 0)
			{
				throw new ApplicationException(Environment.GetResourceString("XMLSyntax_InvalidSyntaxSatAssemTagNoAttr", Path.GetFileName(configurationFileInternal)));
			}
			DictionaryEntry dictionaryEntry = child.Attributes[0];
			string text = (string)dictionaryEntry.Value;
			if (!object.Equals(dictionaryEntry.Key, "name") || string.IsNullOrEmpty(text) || child.Attributes.Count > 1)
			{
				throw new ApplicationException(Environment.GetResourceString("XMLSyntax_InvalidSyntaxSatAssemTagBadAttr", Path.GetFileName(configurationFileInternal), dictionaryEntry.Key, dictionaryEntry.Value));
			}
			ArrayList arrayList = new ArrayList(5);
			foreach (ConfigNode child2 in child.Children)
			{
				if (child2.Value != null)
				{
					arrayList.Add(child2.Value);
				}
			}
			string[] array = new string[arrayList.Count];
			for (int i = 0; i < array.Length; i++)
			{
				string cultureName = (array[i] = (string)arrayList[i]);
				if (FrameworkEventSource.IsInitialized)
				{
					FrameworkEventSource.Log.ResourceManagerAddingCultureFromConfigFile(BaseNameField, MainAssembly, cultureName);
				}
			}
			hashtable.Add(text, array);
		}
		return hashtable;
	}
}
