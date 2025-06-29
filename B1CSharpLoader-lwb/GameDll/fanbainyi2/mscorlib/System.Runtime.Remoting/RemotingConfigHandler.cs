using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Security;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Runtime.Remoting;

internal static class RemotingConfigHandler
{
	internal class RemotingConfigInfo
	{
		private Hashtable _exportableClasses;

		private Hashtable _remoteTypeInfo;

		private Hashtable _remoteAppInfo;

		private Hashtable _wellKnownExportInfo;

		private static char[] SepSpace = new char[1] { ' ' };

		private static char[] SepPound = new char[1] { '#' };

		private static char[] SepSemiColon = new char[1] { ';' };

		private static char[] SepEquals = new char[1] { '=' };

		private static object s_wkoStartLock = new object();

		private static PermissionSet s_fullTrust = new PermissionSet(PermissionState.Unrestricted);

		internal RemotingConfigInfo()
		{
			_remoteTypeInfo = Hashtable.Synchronized(new Hashtable());
			_exportableClasses = Hashtable.Synchronized(new Hashtable());
			_remoteAppInfo = Hashtable.Synchronized(new Hashtable());
			_wellKnownExportInfo = Hashtable.Synchronized(new Hashtable());
		}

		private string EncodeTypeAndAssemblyNames(string typeName, string assemblyName)
		{
			return typeName + ", " + assemblyName.ToLower(CultureInfo.InvariantCulture);
		}

		internal void StoreActivatedExports(RemotingXmlConfigFileData configData)
		{
			foreach (RemotingXmlConfigFileData.TypeEntry serverActivatedEntry in configData.ServerActivatedEntries)
			{
				ActivatedServiceTypeEntry activatedServiceTypeEntry = new ActivatedServiceTypeEntry(serverActivatedEntry.TypeName, serverActivatedEntry.AssemblyName);
				activatedServiceTypeEntry.ContextAttributes = CreateContextAttributesFromConfigEntries(serverActivatedEntry.ContextAttributes);
				RemotingConfiguration.RegisterActivatedServiceType(activatedServiceTypeEntry);
			}
		}

		[SecurityCritical]
		internal void StoreInteropEntries(RemotingXmlConfigFileData configData)
		{
			foreach (RemotingXmlConfigFileData.InteropXmlElementEntry interopXmlElementEntry in configData.InteropXmlElementEntries)
			{
				Assembly assembly = Assembly.Load(interopXmlElementEntry.UrtAssemblyName);
				Type type = assembly.GetType(interopXmlElementEntry.UrtTypeName);
				SoapServices.RegisterInteropXmlElement(interopXmlElementEntry.XmlElementName, interopXmlElementEntry.XmlElementNamespace, type);
			}
			foreach (RemotingXmlConfigFileData.InteropXmlTypeEntry interopXmlTypeEntry in configData.InteropXmlTypeEntries)
			{
				Assembly assembly2 = Assembly.Load(interopXmlTypeEntry.UrtAssemblyName);
				Type type2 = assembly2.GetType(interopXmlTypeEntry.UrtTypeName);
				SoapServices.RegisterInteropXmlType(interopXmlTypeEntry.XmlTypeName, interopXmlTypeEntry.XmlTypeNamespace, type2);
			}
			foreach (RemotingXmlConfigFileData.PreLoadEntry preLoadEntry in configData.PreLoadEntries)
			{
				Assembly assembly3 = Assembly.Load(preLoadEntry.AssemblyName);
				if (preLoadEntry.TypeName != null)
				{
					Type type3 = assembly3.GetType(preLoadEntry.TypeName);
					SoapServices.PreLoad(type3);
				}
				else
				{
					SoapServices.PreLoad(assembly3);
				}
			}
		}

		internal void StoreRemoteAppEntries(RemotingXmlConfigFileData configData)
		{
			char[] trimChars = new char[1] { '/' };
			foreach (RemotingXmlConfigFileData.RemoteAppEntry remoteAppEntry in configData.RemoteAppEntries)
			{
				string text = remoteAppEntry.AppUri;
				if (text != null && !text.EndsWith("/", StringComparison.Ordinal))
				{
					text = text.TrimEnd(trimChars);
				}
				foreach (RemotingXmlConfigFileData.TypeEntry activatedObject in remoteAppEntry.ActivatedObjects)
				{
					ActivatedClientTypeEntry activatedClientTypeEntry = new ActivatedClientTypeEntry(activatedObject.TypeName, activatedObject.AssemblyName, text);
					activatedClientTypeEntry.ContextAttributes = CreateContextAttributesFromConfigEntries(activatedObject.ContextAttributes);
					RemotingConfiguration.RegisterActivatedClientType(activatedClientTypeEntry);
				}
				foreach (RemotingXmlConfigFileData.ClientWellKnownEntry wellKnownObject in remoteAppEntry.WellKnownObjects)
				{
					WellKnownClientTypeEntry wellKnownClientTypeEntry = new WellKnownClientTypeEntry(wellKnownObject.TypeName, wellKnownObject.AssemblyName, wellKnownObject.Url);
					wellKnownClientTypeEntry.ApplicationUrl = text;
					RemotingConfiguration.RegisterWellKnownClientType(wellKnownClientTypeEntry);
				}
			}
		}

		[SecurityCritical]
		internal void StoreWellKnownExports(RemotingXmlConfigFileData configData)
		{
			foreach (RemotingXmlConfigFileData.ServerWellKnownEntry serverWellKnownEntry in configData.ServerWellKnownEntries)
			{
				WellKnownServiceTypeEntry wellKnownServiceTypeEntry = new WellKnownServiceTypeEntry(serverWellKnownEntry.TypeName, serverWellKnownEntry.AssemblyName, serverWellKnownEntry.ObjectURI, serverWellKnownEntry.ObjectMode);
				wellKnownServiceTypeEntry.ContextAttributes = null;
				RegisterWellKnownServiceType(wellKnownServiceTypeEntry);
			}
		}

		private static IContextAttribute[] CreateContextAttributesFromConfigEntries(ArrayList contextAttributes)
		{
			int count = contextAttributes.Count;
			if (count == 0)
			{
				return null;
			}
			IContextAttribute[] array = new IContextAttribute[count];
			int num = 0;
			foreach (RemotingXmlConfigFileData.ContextAttributeEntry contextAttribute2 in contextAttributes)
			{
				Assembly assembly = Assembly.Load(contextAttribute2.AssemblyName);
				IContextAttribute contextAttribute = null;
				Hashtable properties = contextAttribute2.Properties;
				contextAttribute = ((properties == null || properties.Count <= 0) ? ((IContextAttribute)Activator.CreateInstance(assembly.GetType(contextAttribute2.TypeName, throwOnError: false, ignoreCase: false), nonPublic: true)) : ((IContextAttribute)Activator.CreateInstance(args: new object[1] { properties }, type: assembly.GetType(contextAttribute2.TypeName, throwOnError: false, ignoreCase: false), bindingAttr: BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, binder: null, culture: null, activationAttributes: null)));
				array[num++] = contextAttribute;
			}
			return array;
		}

		internal bool ActivationAllowed(string typeName, string assemblyName)
		{
			return _exportableClasses.ContainsKey(EncodeTypeAndAssemblyNames(typeName, assemblyName));
		}

		internal ActivatedClientTypeEntry QueryRemoteActivate(string typeName, string assemblyName)
		{
			string key = EncodeTypeAndAssemblyNames(typeName, assemblyName);
			if (!(_remoteTypeInfo[key] is ActivatedClientTypeEntry activatedClientTypeEntry))
			{
				return null;
			}
			if (activatedClientTypeEntry.GetRemoteAppEntry() == null)
			{
				RemoteAppEntry remoteAppEntry = (RemoteAppEntry)_remoteAppInfo[activatedClientTypeEntry.ApplicationUrl];
				if (remoteAppEntry == null)
				{
					throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Activation_MissingRemoteAppEntry"), activatedClientTypeEntry.ApplicationUrl));
				}
				activatedClientTypeEntry.CacheRemoteAppEntry(remoteAppEntry);
			}
			return activatedClientTypeEntry;
		}

		internal WellKnownClientTypeEntry QueryConnect(string typeName, string assemblyName)
		{
			string key = EncodeTypeAndAssemblyNames(typeName, assemblyName);
			if (!(_remoteTypeInfo[key] is WellKnownClientTypeEntry result))
			{
				return null;
			}
			return result;
		}

		internal ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes()
		{
			ActivatedServiceTypeEntry[] array = new ActivatedServiceTypeEntry[_exportableClasses.Count];
			int num = 0;
			foreach (DictionaryEntry exportableClass in _exportableClasses)
			{
				array[num++] = (ActivatedServiceTypeEntry)exportableClass.Value;
			}
			return array;
		}

		internal WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes()
		{
			WellKnownServiceTypeEntry[] array = new WellKnownServiceTypeEntry[_wellKnownExportInfo.Count];
			int num = 0;
			foreach (DictionaryEntry item in _wellKnownExportInfo)
			{
				WellKnownServiceTypeEntry wellKnownServiceTypeEntry = (WellKnownServiceTypeEntry)item.Value;
				WellKnownServiceTypeEntry wellKnownServiceTypeEntry2 = new WellKnownServiceTypeEntry(wellKnownServiceTypeEntry.TypeName, wellKnownServiceTypeEntry.AssemblyName, wellKnownServiceTypeEntry.ObjectUri, wellKnownServiceTypeEntry.Mode);
				wellKnownServiceTypeEntry2.ContextAttributes = wellKnownServiceTypeEntry.ContextAttributes;
				array[num++] = wellKnownServiceTypeEntry2;
			}
			return array;
		}

		internal ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes()
		{
			int num = 0;
			foreach (DictionaryEntry item in _remoteTypeInfo)
			{
				if (item.Value is ActivatedClientTypeEntry)
				{
					num++;
				}
			}
			ActivatedClientTypeEntry[] array = new ActivatedClientTypeEntry[num];
			int num2 = 0;
			foreach (DictionaryEntry item2 in _remoteTypeInfo)
			{
				if (item2.Value is ActivatedClientTypeEntry activatedClientTypeEntry2)
				{
					string appUrl = null;
					RemoteAppEntry remoteAppEntry = activatedClientTypeEntry2.GetRemoteAppEntry();
					if (remoteAppEntry != null)
					{
						appUrl = remoteAppEntry.GetAppURI();
					}
					ActivatedClientTypeEntry activatedClientTypeEntry3 = new ActivatedClientTypeEntry(activatedClientTypeEntry2.TypeName, activatedClientTypeEntry2.AssemblyName, appUrl);
					activatedClientTypeEntry3.ContextAttributes = activatedClientTypeEntry2.ContextAttributes;
					array[num2++] = activatedClientTypeEntry3;
				}
			}
			return array;
		}

		internal WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes()
		{
			int num = 0;
			foreach (DictionaryEntry item in _remoteTypeInfo)
			{
				if (item.Value is WellKnownClientTypeEntry)
				{
					num++;
				}
			}
			WellKnownClientTypeEntry[] array = new WellKnownClientTypeEntry[num];
			int num2 = 0;
			foreach (DictionaryEntry item2 in _remoteTypeInfo)
			{
				if (item2.Value is WellKnownClientTypeEntry wellKnownClientTypeEntry2)
				{
					WellKnownClientTypeEntry wellKnownClientTypeEntry3 = new WellKnownClientTypeEntry(wellKnownClientTypeEntry2.TypeName, wellKnownClientTypeEntry2.AssemblyName, wellKnownClientTypeEntry2.ObjectUrl);
					RemoteAppEntry remoteAppEntry = wellKnownClientTypeEntry2.GetRemoteAppEntry();
					if (remoteAppEntry != null)
					{
						wellKnownClientTypeEntry3.ApplicationUrl = remoteAppEntry.GetAppURI();
					}
					array[num2++] = wellKnownClientTypeEntry3;
				}
			}
			return array;
		}

		internal void AddActivatedType(string typeName, string assemblyName, IContextAttribute[] contextAttributes)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			if (assemblyName == null)
			{
				throw new ArgumentNullException("assemblyName");
			}
			if (CheckForRedirectedClientType(typeName, assemblyName))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_CantUseRedirectedTypeForWellKnownService"), typeName, assemblyName));
			}
			ActivatedServiceTypeEntry activatedServiceTypeEntry = new ActivatedServiceTypeEntry(typeName, assemblyName);
			activatedServiceTypeEntry.ContextAttributes = contextAttributes;
			string key = EncodeTypeAndAssemblyNames(typeName, assemblyName);
			_exportableClasses.Add(key, activatedServiceTypeEntry);
		}

		private bool CheckForServiceEntryWithType(string typeName, string asmName)
		{
			if (!CheckForWellKnownServiceEntryWithType(typeName, asmName))
			{
				return ActivationAllowed(typeName, asmName);
			}
			return true;
		}

		private bool CheckForWellKnownServiceEntryWithType(string typeName, string asmName)
		{
			foreach (DictionaryEntry item in _wellKnownExportInfo)
			{
				WellKnownServiceTypeEntry wellKnownServiceTypeEntry = (WellKnownServiceTypeEntry)item.Value;
				if (typeName == wellKnownServiceTypeEntry.TypeName)
				{
					bool flag = false;
					if (asmName == wellKnownServiceTypeEntry.AssemblyName)
					{
						flag = true;
					}
					else if (string.Compare(wellKnownServiceTypeEntry.AssemblyName, 0, asmName, 0, asmName.Length, StringComparison.OrdinalIgnoreCase) == 0 && wellKnownServiceTypeEntry.AssemblyName[asmName.Length] == ',')
					{
						flag = true;
					}
					if (flag)
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool CheckForRedirectedClientType(string typeName, string asmName)
		{
			int num = asmName.IndexOf(",");
			if (num != -1)
			{
				asmName = asmName.Substring(0, num);
			}
			if (QueryRemoteActivate(typeName, asmName) == null)
			{
				return QueryConnect(typeName, asmName) != null;
			}
			return true;
		}

		internal void AddActivatedClientType(ActivatedClientTypeEntry entry)
		{
			if (CheckForRedirectedClientType(entry.TypeName, entry.AssemblyName))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_TypeAlreadyRedirected"), entry.TypeName, entry.AssemblyName));
			}
			if (CheckForServiceEntryWithType(entry.TypeName, entry.AssemblyName))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_CantRedirectActivationOfWellKnownService"), entry.TypeName, entry.AssemblyName));
			}
			string applicationUrl = entry.ApplicationUrl;
			RemoteAppEntry remoteAppEntry = (RemoteAppEntry)_remoteAppInfo[applicationUrl];
			if (remoteAppEntry == null)
			{
				remoteAppEntry = new RemoteAppEntry(applicationUrl, applicationUrl);
				_remoteAppInfo.Add(applicationUrl, remoteAppEntry);
			}
			if (remoteAppEntry != null)
			{
				entry.CacheRemoteAppEntry(remoteAppEntry);
			}
			string key = EncodeTypeAndAssemblyNames(entry.TypeName, entry.AssemblyName);
			_remoteTypeInfo.Add(key, entry);
		}

		internal void AddWellKnownClientType(WellKnownClientTypeEntry entry)
		{
			if (CheckForRedirectedClientType(entry.TypeName, entry.AssemblyName))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_TypeAlreadyRedirected"), entry.TypeName, entry.AssemblyName));
			}
			if (CheckForServiceEntryWithType(entry.TypeName, entry.AssemblyName))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_CantRedirectActivationOfWellKnownService"), entry.TypeName, entry.AssemblyName));
			}
			string applicationUrl = entry.ApplicationUrl;
			RemoteAppEntry remoteAppEntry = null;
			if (applicationUrl != null)
			{
				remoteAppEntry = (RemoteAppEntry)_remoteAppInfo[applicationUrl];
				if (remoteAppEntry == null)
				{
					remoteAppEntry = new RemoteAppEntry(applicationUrl, applicationUrl);
					_remoteAppInfo.Add(applicationUrl, remoteAppEntry);
				}
			}
			if (remoteAppEntry != null)
			{
				entry.CacheRemoteAppEntry(remoteAppEntry);
			}
			string key = EncodeTypeAndAssemblyNames(entry.TypeName, entry.AssemblyName);
			_remoteTypeInfo.Add(key, entry);
		}

		[SecurityCritical]
		internal void AddWellKnownEntry(WellKnownServiceTypeEntry entry)
		{
			AddWellKnownEntry(entry, fReplace: true);
		}

		[SecurityCritical]
		internal void AddWellKnownEntry(WellKnownServiceTypeEntry entry, bool fReplace)
		{
			if (CheckForRedirectedClientType(entry.TypeName, entry.AssemblyName))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_CantUseRedirectedTypeForWellKnownService"), entry.TypeName, entry.AssemblyName));
			}
			string key = entry.ObjectUri.ToLower(CultureInfo.InvariantCulture);
			if (fReplace)
			{
				_wellKnownExportInfo[key] = entry;
				IdentityHolder.RemoveIdentity(entry.ObjectUri);
			}
			else
			{
				_wellKnownExportInfo.Add(key, entry);
			}
		}

		[SecurityCritical]
		internal Type GetServerTypeForUri(string URI)
		{
			Type result = null;
			string key = URI.ToLower(CultureInfo.InvariantCulture);
			WellKnownServiceTypeEntry wellKnownServiceTypeEntry = (WellKnownServiceTypeEntry)_wellKnownExportInfo[key];
			if (wellKnownServiceTypeEntry != null)
			{
				result = LoadType(wellKnownServiceTypeEntry.TypeName, wellKnownServiceTypeEntry.AssemblyName);
			}
			return result;
		}

		[SecurityCritical]
		internal ServerIdentity StartupWellKnownObject(string URI)
		{
			string key = URI.ToLower(CultureInfo.InvariantCulture);
			ServerIdentity result = null;
			WellKnownServiceTypeEntry wellKnownServiceTypeEntry = (WellKnownServiceTypeEntry)_wellKnownExportInfo[key];
			if (wellKnownServiceTypeEntry != null)
			{
				result = StartupWellKnownObject(wellKnownServiceTypeEntry.AssemblyName, wellKnownServiceTypeEntry.TypeName, wellKnownServiceTypeEntry.ObjectUri, wellKnownServiceTypeEntry.Mode);
			}
			return result;
		}

		[SecurityCritical]
		internal ServerIdentity StartupWellKnownObject(string asmName, string svrTypeName, string URI, WellKnownObjectMode mode)
		{
			return StartupWellKnownObject(asmName, svrTypeName, URI, mode, fReplace: false);
		}

		[SecurityCritical]
		internal ServerIdentity StartupWellKnownObject(string asmName, string svrTypeName, string URI, WellKnownObjectMode mode, bool fReplace)
		{
			lock (s_wkoStartLock)
			{
				MarshalByRefObject marshalByRefObject = null;
				ServerIdentity serverIdentity = null;
				Type type = LoadType(svrTypeName, asmName);
				if (!type.IsMarshalByRef)
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_WellKnown_MustBeMBR", svrTypeName));
				}
				serverIdentity = (ServerIdentity)IdentityHolder.ResolveIdentity(URI);
				if (serverIdentity != null && serverIdentity.IsRemoteDisconnected())
				{
					IdentityHolder.RemoveIdentity(URI);
					serverIdentity = null;
				}
				if (serverIdentity == null)
				{
					s_fullTrust.Assert();
					try
					{
						marshalByRefObject = (MarshalByRefObject)Activator.CreateInstance(type, nonPublic: true);
						if (RemotingServices.IsClientProxy(marshalByRefObject))
						{
							RedirectionProxy redirectionProxy = new RedirectionProxy(marshalByRefObject, type);
							redirectionProxy.ObjectMode = mode;
							RemotingServices.MarshalInternal(redirectionProxy, URI, type, updateChannelData: true, isInitializing: true);
							serverIdentity = (ServerIdentity)IdentityHolder.ResolveIdentity(URI);
							serverIdentity.SetSingletonObjectMode();
						}
						else if (type.IsCOMObject && mode == WellKnownObjectMode.Singleton)
						{
							ComRedirectionProxy obj = new ComRedirectionProxy(marshalByRefObject, type);
							RemotingServices.MarshalInternal(obj, URI, type, updateChannelData: true, isInitializing: true);
							serverIdentity = (ServerIdentity)IdentityHolder.ResolveIdentity(URI);
							serverIdentity.SetSingletonObjectMode();
						}
						else
						{
							string objectUri = RemotingServices.GetObjectUri(marshalByRefObject);
							if (objectUri != null)
							{
								throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_WellKnown_CtorCantMarshal"), URI));
							}
							RemotingServices.MarshalInternal(marshalByRefObject, URI, type, updateChannelData: true, isInitializing: true);
							serverIdentity = (ServerIdentity)IdentityHolder.ResolveIdentity(URI);
							if (mode == WellKnownObjectMode.SingleCall)
							{
								serverIdentity.SetSingleCallObjectMode();
							}
							else
							{
								serverIdentity.SetSingletonObjectMode();
							}
						}
					}
					catch
					{
						throw;
					}
					finally
					{
						if (serverIdentity != null)
						{
							serverIdentity.IsInitializing = false;
						}
						CodeAccessPermission.RevertAssert();
					}
				}
				return serverIdentity;
			}
		}

		[SecurityCritical]
		internal static Type LoadType(string typeName, string assemblyName)
		{
			Assembly assembly = null;
			new FileIOPermission(PermissionState.Unrestricted).Assert();
			try
			{
				assembly = Assembly.Load(assemblyName);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
			if (assembly == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_AssemblyLoadFailed", assemblyName));
			}
			Type type = assembly.GetType(typeName, throwOnError: false, ignoreCase: false);
			if (type == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_BadType", typeName + ", " + assemblyName));
			}
			return type;
		}
	}

	private static volatile string _applicationName;

	private static volatile CustomErrorsModes _errorMode = CustomErrorsModes.RemoteOnly;

	private static volatile bool _errorsModeSet = false;

	private static volatile bool _bMachineConfigLoaded = false;

	private static volatile bool _bUrlObjRefMode = false;

	private static Queue _delayLoadChannelConfigQueue = new Queue();

	public static RemotingConfigInfo Info = new RemotingConfigInfo();

	private const string _machineConfigFilename = "machine.config";

	internal static string ApplicationName
	{
		get
		{
			if (_applicationName == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Config_NoAppName"));
			}
			return _applicationName;
		}
		set
		{
			if (_applicationName != null)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_AppNameSet"), _applicationName));
			}
			_applicationName = value;
			char[] trimChars = new char[1] { '/' };
			if (_applicationName.StartsWith("/", StringComparison.Ordinal))
			{
				_applicationName = _applicationName.TrimStart(trimChars);
			}
			if (_applicationName.EndsWith("/", StringComparison.Ordinal))
			{
				_applicationName = _applicationName.TrimEnd(trimChars);
			}
		}
	}

	internal static bool UrlObjRefMode => _bUrlObjRefMode;

	internal static CustomErrorsModes CustomErrorsMode
	{
		get
		{
			return _errorMode;
		}
		set
		{
			if (_errorsModeSet)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_Config_ErrorsModeSet"));
			}
			_errorMode = value;
			_errorsModeSet = true;
		}
	}

	internal static bool HasApplicationNameBeenSet()
	{
		return _applicationName != null;
	}

	[SecurityCritical]
	internal static IMessageSink FindDelayLoadChannelForCreateMessageSink(string url, object data, out string objectURI)
	{
		LoadMachineConfigIfNecessary();
		objectURI = null;
		IMessageSink messageSink = null;
		foreach (DelayLoadClientChannelEntry item in _delayLoadChannelConfigQueue)
		{
			IChannelSender channel = item.Channel;
			if (channel != null)
			{
				messageSink = channel.CreateMessageSink(url, data, out objectURI);
				if (messageSink != null)
				{
					item.RegisterChannel();
					return messageSink;
				}
			}
		}
		return null;
	}

	[SecurityCritical]
	private static void LoadMachineConfigIfNecessary()
	{
		if (_bMachineConfigLoaded)
		{
			return;
		}
		lock (Info)
		{
			if (!_bMachineConfigLoaded)
			{
				RemotingXmlConfigFileData remotingXmlConfigFileData = RemotingXmlConfigFileParser.ParseDefaultConfiguration();
				if (remotingXmlConfigFileData != null)
				{
					ConfigureRemoting(remotingXmlConfigFileData, ensureSecurity: false);
				}
				string machineDirectory = Config.MachineDirectory;
				string text = machineDirectory + "machine.config";
				new FileIOPermission(FileIOPermissionAccess.Read, text).Assert();
				remotingXmlConfigFileData = LoadConfigurationFromXmlFile(text);
				if (remotingXmlConfigFileData != null)
				{
					ConfigureRemoting(remotingXmlConfigFileData, ensureSecurity: false);
				}
				_bMachineConfigLoaded = true;
			}
		}
	}

	[SecurityCritical]
	internal static void DoConfiguration(string filename, bool ensureSecurity)
	{
		LoadMachineConfigIfNecessary();
		RemotingXmlConfigFileData remotingXmlConfigFileData = LoadConfigurationFromXmlFile(filename);
		if (remotingXmlConfigFileData != null)
		{
			ConfigureRemoting(remotingXmlConfigFileData, ensureSecurity);
		}
	}

	private static RemotingXmlConfigFileData LoadConfigurationFromXmlFile(string filename)
	{
		try
		{
			if (filename != null)
			{
				return RemotingXmlConfigFileParser.ParseConfigFile(filename);
			}
			return null;
		}
		catch (Exception ex)
		{
			Exception ex2 = ex.InnerException as FileNotFoundException;
			if (ex2 != null)
			{
				ex = ex2;
			}
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_ReadFailure"), filename, ex));
		}
	}

	[SecurityCritical]
	private static void ConfigureRemoting(RemotingXmlConfigFileData configData, bool ensureSecurity)
	{
		try
		{
			string applicationName = configData.ApplicationName;
			if (applicationName != null)
			{
				ApplicationName = applicationName;
			}
			if (configData.CustomErrors != null)
			{
				_errorMode = configData.CustomErrors.Mode;
			}
			ConfigureChannels(configData, ensureSecurity);
			if (configData.Lifetime != null)
			{
				if (configData.Lifetime.IsLeaseTimeSet)
				{
					LifetimeServices.LeaseTime = configData.Lifetime.LeaseTime;
				}
				if (configData.Lifetime.IsRenewOnCallTimeSet)
				{
					LifetimeServices.RenewOnCallTime = configData.Lifetime.RenewOnCallTime;
				}
				if (configData.Lifetime.IsSponsorshipTimeoutSet)
				{
					LifetimeServices.SponsorshipTimeout = configData.Lifetime.SponsorshipTimeout;
				}
				if (configData.Lifetime.IsLeaseManagerPollTimeSet)
				{
					LifetimeServices.LeaseManagerPollTime = configData.Lifetime.LeaseManagerPollTime;
				}
			}
			_bUrlObjRefMode = configData.UrlObjRefMode;
			Info.StoreRemoteAppEntries(configData);
			Info.StoreActivatedExports(configData);
			Info.StoreInteropEntries(configData);
			Info.StoreWellKnownExports(configData);
			if (configData.ServerActivatedEntries.Count > 0)
			{
				ActivationServices.StartListeningForRemoteRequests();
			}
		}
		catch (Exception arg)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_ConfigurationFailure"), arg));
		}
	}

	[SecurityCritical]
	private static void ConfigureChannels(RemotingXmlConfigFileData configData, bool ensureSecurity)
	{
		RemotingServices.RegisterWellKnownChannels();
		foreach (RemotingXmlConfigFileData.ChannelEntry channelEntry in configData.ChannelEntries)
		{
			if (!channelEntry.DelayLoad)
			{
				IChannel chnl = CreateChannelFromConfigEntry(channelEntry);
				ChannelServices.RegisterChannel(chnl, ensureSecurity);
			}
			else
			{
				_delayLoadChannelConfigQueue.Enqueue(new DelayLoadClientChannelEntry(channelEntry, ensureSecurity));
			}
		}
	}

	[SecurityCritical]
	internal static IChannel CreateChannelFromConfigEntry(RemotingXmlConfigFileData.ChannelEntry entry)
	{
		Type type = RemotingConfigInfo.LoadType(entry.TypeName, entry.AssemblyName);
		bool flag = typeof(IChannelReceiver).IsAssignableFrom(type);
		bool flag2 = typeof(IChannelSender).IsAssignableFrom(type);
		IClientChannelSinkProvider clientChannelSinkProvider = null;
		IServerChannelSinkProvider serverChannelSinkProvider = null;
		if (entry.ClientSinkProviders.Count > 0)
		{
			clientChannelSinkProvider = CreateClientChannelSinkProviderChain(entry.ClientSinkProviders);
		}
		if (entry.ServerSinkProviders.Count > 0)
		{
			serverChannelSinkProvider = CreateServerChannelSinkProviderChain(entry.ServerSinkProviders);
		}
		object[] args;
		if (flag && flag2)
		{
			args = new object[3] { entry.Properties, clientChannelSinkProvider, serverChannelSinkProvider };
		}
		else if (flag)
		{
			args = new object[2] { entry.Properties, serverChannelSinkProvider };
		}
		else
		{
			if (!flag2)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_InvalidChannelType"), type.FullName));
			}
			args = new object[2] { entry.Properties, clientChannelSinkProvider };
		}
		IChannel channel = null;
		try
		{
			return (IChannel)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, args, null, null);
		}
		catch (MissingMethodException)
		{
			string arg = null;
			if (flag && flag2)
			{
				arg = "MyChannel(IDictionary properties, IClientChannelSinkProvider clientSinkProvider, IServerChannelSinkProvider serverSinkProvider)";
			}
			else if (flag)
			{
				arg = "MyChannel(IDictionary properties, IServerChannelSinkProvider serverSinkProvider)";
			}
			else if (flag2)
			{
				arg = "MyChannel(IDictionary properties, IClientChannelSinkProvider clientSinkProvider)";
			}
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_ChannelMissingCtor"), type.FullName, arg));
		}
	}

	[SecurityCritical]
	private static IClientChannelSinkProvider CreateClientChannelSinkProviderChain(ArrayList entries)
	{
		IClientChannelSinkProvider clientChannelSinkProvider = null;
		IClientChannelSinkProvider clientChannelSinkProvider2 = null;
		foreach (RemotingXmlConfigFileData.SinkProviderEntry entry in entries)
		{
			if (clientChannelSinkProvider == null)
			{
				clientChannelSinkProvider = (IClientChannelSinkProvider)CreateChannelSinkProvider(entry, bServer: false);
				clientChannelSinkProvider2 = clientChannelSinkProvider;
			}
			else
			{
				clientChannelSinkProvider2.Next = (IClientChannelSinkProvider)CreateChannelSinkProvider(entry, bServer: false);
				clientChannelSinkProvider2 = clientChannelSinkProvider2.Next;
			}
		}
		return clientChannelSinkProvider;
	}

	[SecurityCritical]
	private static IServerChannelSinkProvider CreateServerChannelSinkProviderChain(ArrayList entries)
	{
		IServerChannelSinkProvider serverChannelSinkProvider = null;
		IServerChannelSinkProvider serverChannelSinkProvider2 = null;
		foreach (RemotingXmlConfigFileData.SinkProviderEntry entry in entries)
		{
			if (serverChannelSinkProvider == null)
			{
				serverChannelSinkProvider = (IServerChannelSinkProvider)CreateChannelSinkProvider(entry, bServer: true);
				serverChannelSinkProvider2 = serverChannelSinkProvider;
			}
			else
			{
				serverChannelSinkProvider2.Next = (IServerChannelSinkProvider)CreateChannelSinkProvider(entry, bServer: true);
				serverChannelSinkProvider2 = serverChannelSinkProvider2.Next;
			}
		}
		return serverChannelSinkProvider;
	}

	[SecurityCritical]
	private static object CreateChannelSinkProvider(RemotingXmlConfigFileData.SinkProviderEntry entry, bool bServer)
	{
		object obj = null;
		Type type = RemotingConfigInfo.LoadType(entry.TypeName, entry.AssemblyName);
		if (bServer)
		{
			if (!typeof(IServerChannelSinkProvider).IsAssignableFrom(type))
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_InvalidSinkProviderType"), type.FullName, "IServerChannelSinkProvider"));
			}
		}
		else if (!typeof(IClientChannelSinkProvider).IsAssignableFrom(type))
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_InvalidSinkProviderType"), type.FullName, "IClientChannelSinkProvider"));
		}
		if (entry.IsFormatter && ((bServer && !typeof(IServerFormatterSinkProvider).IsAssignableFrom(type)) || (!bServer && !typeof(IClientFormatterSinkProvider).IsAssignableFrom(type))))
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_SinkProviderNotFormatter"), type.FullName));
		}
		object[] args = new object[2] { entry.Properties, entry.ProviderData };
		try
		{
			return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, args, null, null);
		}
		catch (MissingMethodException)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_SinkProviderMissingCtor"), type.FullName, "MySinkProvider(IDictionary properties, ICollection providerData)"));
		}
	}

	[SecurityCritical]
	internal static ActivatedClientTypeEntry IsRemotelyActivatedClientType(RuntimeType svrType)
	{
		RemotingTypeCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(svrType);
		string simpleAssemblyName = reflectionCachedData.SimpleAssemblyName;
		ActivatedClientTypeEntry activatedClientTypeEntry = Info.QueryRemoteActivate(svrType.FullName, simpleAssemblyName);
		if (activatedClientTypeEntry == null)
		{
			string assemblyName = reflectionCachedData.AssemblyName;
			activatedClientTypeEntry = Info.QueryRemoteActivate(svrType.FullName, assemblyName);
			if (activatedClientTypeEntry == null)
			{
				activatedClientTypeEntry = Info.QueryRemoteActivate(svrType.Name, simpleAssemblyName);
			}
		}
		return activatedClientTypeEntry;
	}

	internal static ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName)
	{
		return Info.QueryRemoteActivate(typeName, assemblyName);
	}

	[SecurityCritical]
	internal static WellKnownClientTypeEntry IsWellKnownClientType(RuntimeType svrType)
	{
		RemotingTypeCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(svrType);
		string simpleAssemblyName = reflectionCachedData.SimpleAssemblyName;
		WellKnownClientTypeEntry wellKnownClientTypeEntry = Info.QueryConnect(svrType.FullName, simpleAssemblyName);
		if (wellKnownClientTypeEntry == null)
		{
			wellKnownClientTypeEntry = Info.QueryConnect(svrType.Name, simpleAssemblyName);
		}
		return wellKnownClientTypeEntry;
	}

	internal static WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName)
	{
		return Info.QueryConnect(typeName, assemblyName);
	}

	private static void ParseGenericType(string typeAssem, int indexStart, out string typeName, out string assemName)
	{
		int length = typeAssem.Length;
		int num = 1;
		int num2 = indexStart;
		while (num > 0 && ++num2 < length - 1)
		{
			if (typeAssem[num2] == '[')
			{
				num++;
			}
			else if (typeAssem[num2] == ']')
			{
				num--;
			}
		}
		if (num > 0 || num2 >= length)
		{
			typeName = null;
			assemName = null;
			return;
		}
		num2 = typeAssem.IndexOf(',', num2);
		if (num2 >= 0 && num2 < length - 1)
		{
			typeName = typeAssem.Substring(0, num2).Trim();
			assemName = typeAssem.Substring(num2 + 1).Trim();
		}
		else
		{
			typeName = null;
			assemName = null;
		}
	}

	internal static void ParseType(string typeAssem, out string typeName, out string assemName)
	{
		int num = typeAssem.IndexOf("[");
		if (num >= 0 && num < typeAssem.Length - 1)
		{
			ParseGenericType(typeAssem, num, out typeName, out assemName);
			return;
		}
		int num2 = typeAssem.IndexOf(",");
		if (num2 >= 0 && num2 < typeAssem.Length - 1)
		{
			typeName = typeAssem.Substring(0, num2).Trim();
			assemName = typeAssem.Substring(num2 + 1).Trim();
		}
		else
		{
			typeName = null;
			assemName = null;
		}
	}

	[SecurityCritical]
	internal static bool IsActivationAllowed(RuntimeType svrType)
	{
		if (svrType == null)
		{
			return false;
		}
		RemotingTypeCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(svrType);
		string simpleAssemblyName = reflectionCachedData.SimpleAssemblyName;
		return Info.ActivationAllowed(svrType.FullName, simpleAssemblyName);
	}

	[SecurityCritical]
	internal static bool IsActivationAllowed(string TypeName)
	{
		string text = RemotingServices.InternalGetTypeNameFromQualifiedTypeName(TypeName);
		if (text == null)
		{
			return false;
		}
		ParseType(text, out var typeName, out var assemName);
		if (assemName == null)
		{
			return false;
		}
		int num = assemName.IndexOf(',');
		if (num != -1)
		{
			assemName = assemName.Substring(0, num);
		}
		return Info.ActivationAllowed(typeName, assemName);
	}

	internal static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
	{
		Info.AddActivatedType(entry.TypeName, entry.AssemblyName, entry.ContextAttributes);
	}

	[SecurityCritical]
	internal static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
	{
		string typeName = entry.TypeName;
		string assemblyName = entry.AssemblyName;
		string objectUri = entry.ObjectUri;
		WellKnownObjectMode mode = entry.Mode;
		lock (Info)
		{
			Info.AddWellKnownEntry(entry);
		}
	}

	internal static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
	{
		Info.AddActivatedClientType(entry);
	}

	internal static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
	{
		Info.AddWellKnownClientType(entry);
	}

	[SecurityCritical]
	internal static Type GetServerTypeForUri(string URI)
	{
		URI = Identity.RemoveAppNameOrAppGuidIfNecessary(URI);
		return Info.GetServerTypeForUri(URI);
	}

	internal static ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes()
	{
		return Info.GetRegisteredActivatedServiceTypes();
	}

	internal static WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes()
	{
		return Info.GetRegisteredWellKnownServiceTypes();
	}

	internal static ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes()
	{
		return Info.GetRegisteredActivatedClientTypes();
	}

	internal static WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes()
	{
		return Info.GetRegisteredWellKnownClientTypes();
	}

	[SecurityCritical]
	internal static ServerIdentity CreateWellKnownObject(string uri)
	{
		uri = Identity.RemoveAppNameOrAppGuidIfNecessary(uri);
		return Info.StartupWellKnownObject(uri);
	}
}
