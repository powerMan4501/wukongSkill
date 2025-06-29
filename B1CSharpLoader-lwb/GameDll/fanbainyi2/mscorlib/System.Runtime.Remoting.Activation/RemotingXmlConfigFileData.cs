using System.Collections;
using System.Reflection;

namespace System.Runtime.Remoting.Activation;

internal class RemotingXmlConfigFileData
{
	internal class ChannelEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal Hashtable Properties;

		internal bool DelayLoad;

		internal ArrayList ClientSinkProviders = new ArrayList();

		internal ArrayList ServerSinkProviders = new ArrayList();

		internal ChannelEntry(string typeName, string assemblyName, Hashtable properties)
		{
			TypeName = typeName;
			AssemblyName = assemblyName;
			Properties = properties;
		}
	}

	internal class ClientWellKnownEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal string Url;

		internal ClientWellKnownEntry(string typeName, string assemName, string url)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			Url = url;
		}
	}

	internal class ContextAttributeEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal Hashtable Properties;

		internal ContextAttributeEntry(string typeName, string assemName, Hashtable properties)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			Properties = properties;
		}
	}

	internal class InteropXmlElementEntry
	{
		internal string XmlElementName;

		internal string XmlElementNamespace;

		internal string UrtTypeName;

		internal string UrtAssemblyName;

		internal InteropXmlElementEntry(string xmlElementName, string xmlElementNamespace, string urtTypeName, string urtAssemblyName)
		{
			XmlElementName = xmlElementName;
			XmlElementNamespace = xmlElementNamespace;
			UrtTypeName = urtTypeName;
			UrtAssemblyName = urtAssemblyName;
		}
	}

	internal class CustomErrorsEntry
	{
		internal CustomErrorsModes Mode;

		internal CustomErrorsEntry(CustomErrorsModes mode)
		{
			Mode = mode;
		}
	}

	internal class InteropXmlTypeEntry
	{
		internal string XmlTypeName;

		internal string XmlTypeNamespace;

		internal string UrtTypeName;

		internal string UrtAssemblyName;

		internal InteropXmlTypeEntry(string xmlTypeName, string xmlTypeNamespace, string urtTypeName, string urtAssemblyName)
		{
			XmlTypeName = xmlTypeName;
			XmlTypeNamespace = xmlTypeNamespace;
			UrtTypeName = urtTypeName;
			UrtAssemblyName = urtAssemblyName;
		}
	}

	internal class LifetimeEntry
	{
		internal bool IsLeaseTimeSet;

		internal bool IsRenewOnCallTimeSet;

		internal bool IsSponsorshipTimeoutSet;

		internal bool IsLeaseManagerPollTimeSet;

		private TimeSpan _leaseTime;

		private TimeSpan _renewOnCallTime;

		private TimeSpan _sponsorshipTimeout;

		private TimeSpan _leaseManagerPollTime;

		internal TimeSpan LeaseTime
		{
			get
			{
				return _leaseTime;
			}
			set
			{
				_leaseTime = value;
				IsLeaseTimeSet = true;
			}
		}

		internal TimeSpan RenewOnCallTime
		{
			get
			{
				return _renewOnCallTime;
			}
			set
			{
				_renewOnCallTime = value;
				IsRenewOnCallTimeSet = true;
			}
		}

		internal TimeSpan SponsorshipTimeout
		{
			get
			{
				return _sponsorshipTimeout;
			}
			set
			{
				_sponsorshipTimeout = value;
				IsSponsorshipTimeoutSet = true;
			}
		}

		internal TimeSpan LeaseManagerPollTime
		{
			get
			{
				return _leaseManagerPollTime;
			}
			set
			{
				_leaseManagerPollTime = value;
				IsLeaseManagerPollTimeSet = true;
			}
		}
	}

	internal class PreLoadEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		public PreLoadEntry(string typeName, string assemblyName)
		{
			TypeName = typeName;
			AssemblyName = assemblyName;
		}
	}

	internal class RemoteAppEntry
	{
		internal string AppUri;

		internal ArrayList WellKnownObjects = new ArrayList();

		internal ArrayList ActivatedObjects = new ArrayList();

		internal RemoteAppEntry(string appUri)
		{
			AppUri = appUri;
		}

		internal void AddWellKnownEntry(string typeName, string assemName, string url)
		{
			ClientWellKnownEntry value = new ClientWellKnownEntry(typeName, assemName, url);
			WellKnownObjects.Add(value);
		}

		internal void AddActivatedEntry(string typeName, string assemName, ArrayList contextAttributes)
		{
			TypeEntry value = new TypeEntry(typeName, assemName, contextAttributes);
			ActivatedObjects.Add(value);
		}
	}

	internal class ServerWellKnownEntry : TypeEntry
	{
		internal string ObjectURI;

		internal WellKnownObjectMode ObjectMode;

		internal ServerWellKnownEntry(string typeName, string assemName, ArrayList contextAttributes, string objURI, WellKnownObjectMode objMode)
			: base(typeName, assemName, contextAttributes)
		{
			ObjectURI = objURI;
			ObjectMode = objMode;
		}
	}

	internal class SinkProviderEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal Hashtable Properties;

		internal ArrayList ProviderData = new ArrayList();

		internal bool IsFormatter;

		internal SinkProviderEntry(string typeName, string assemName, Hashtable properties, bool isFormatter)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			Properties = properties;
			IsFormatter = isFormatter;
		}
	}

	internal class TypeEntry
	{
		internal string TypeName;

		internal string AssemblyName;

		internal ArrayList ContextAttributes;

		internal TypeEntry(string typeName, string assemName, ArrayList contextAttributes)
		{
			TypeName = typeName;
			AssemblyName = assemName;
			ContextAttributes = contextAttributes;
		}
	}

	internal static volatile bool LoadTypes;

	internal string ApplicationName;

	internal LifetimeEntry Lifetime;

	internal bool UrlObjRefMode = RemotingConfigHandler.UrlObjRefMode;

	internal CustomErrorsEntry CustomErrors;

	internal ArrayList ChannelEntries = new ArrayList();

	internal ArrayList InteropXmlElementEntries = new ArrayList();

	internal ArrayList InteropXmlTypeEntries = new ArrayList();

	internal ArrayList PreLoadEntries = new ArrayList();

	internal ArrayList RemoteAppEntries = new ArrayList();

	internal ArrayList ServerActivatedEntries = new ArrayList();

	internal ArrayList ServerWellKnownEntries = new ArrayList();

	internal void AddInteropXmlElementEntry(string xmlElementName, string xmlElementNamespace, string urtTypeName, string urtAssemblyName)
	{
		TryToLoadTypeIfApplicable(urtTypeName, urtAssemblyName);
		InteropXmlElementEntry value = new InteropXmlElementEntry(xmlElementName, xmlElementNamespace, urtTypeName, urtAssemblyName);
		InteropXmlElementEntries.Add(value);
	}

	internal void AddInteropXmlTypeEntry(string xmlTypeName, string xmlTypeNamespace, string urtTypeName, string urtAssemblyName)
	{
		TryToLoadTypeIfApplicable(urtTypeName, urtAssemblyName);
		InteropXmlTypeEntry value = new InteropXmlTypeEntry(xmlTypeName, xmlTypeNamespace, urtTypeName, urtAssemblyName);
		InteropXmlTypeEntries.Add(value);
	}

	internal void AddPreLoadEntry(string typeName, string assemblyName)
	{
		TryToLoadTypeIfApplicable(typeName, assemblyName);
		PreLoadEntry value = new PreLoadEntry(typeName, assemblyName);
		PreLoadEntries.Add(value);
	}

	internal RemoteAppEntry AddRemoteAppEntry(string appUri)
	{
		RemoteAppEntry remoteAppEntry = new RemoteAppEntry(appUri);
		RemoteAppEntries.Add(remoteAppEntry);
		return remoteAppEntry;
	}

	internal void AddServerActivatedEntry(string typeName, string assemName, ArrayList contextAttributes)
	{
		TryToLoadTypeIfApplicable(typeName, assemName);
		TypeEntry value = new TypeEntry(typeName, assemName, contextAttributes);
		ServerActivatedEntries.Add(value);
	}

	internal ServerWellKnownEntry AddServerWellKnownEntry(string typeName, string assemName, ArrayList contextAttributes, string objURI, WellKnownObjectMode objMode)
	{
		TryToLoadTypeIfApplicable(typeName, assemName);
		ServerWellKnownEntry serverWellKnownEntry = new ServerWellKnownEntry(typeName, assemName, contextAttributes, objURI, objMode);
		ServerWellKnownEntries.Add(serverWellKnownEntry);
		return serverWellKnownEntry;
	}

	private void TryToLoadTypeIfApplicable(string typeName, string assemblyName)
	{
		if (LoadTypes)
		{
			Assembly assembly = Assembly.Load(assemblyName);
			if (assembly == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_AssemblyLoadFailed", assemblyName));
			}
			Type type = assembly.GetType(typeName, throwOnError: false, ignoreCase: false);
			if (type == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_BadType", typeName));
			}
		}
	}
}
