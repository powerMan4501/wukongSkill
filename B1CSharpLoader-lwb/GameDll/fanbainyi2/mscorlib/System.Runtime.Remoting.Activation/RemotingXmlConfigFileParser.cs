using System.Collections;
using System.Globalization;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting.Activation;

internal static class RemotingXmlConfigFileParser
{
	private static Hashtable _channelTemplates = CreateSyncCaseInsensitiveHashtable();

	private static Hashtable _clientChannelSinkTemplates = CreateSyncCaseInsensitiveHashtable();

	private static Hashtable _serverChannelSinkTemplates = CreateSyncCaseInsensitiveHashtable();

	private static Hashtable CreateSyncCaseInsensitiveHashtable()
	{
		return Hashtable.Synchronized(CreateCaseInsensitiveHashtable());
	}

	private static Hashtable CreateCaseInsensitiveHashtable()
	{
		return new Hashtable(StringComparer.InvariantCultureIgnoreCase);
	}

	public static RemotingXmlConfigFileData ParseDefaultConfiguration()
	{
		ConfigNode configNode = new ConfigNode("system.runtime.remoting", null);
		ConfigNode configNode2 = new ConfigNode("application", configNode);
		configNode.Children.Add(configNode2);
		ConfigNode configNode3 = new ConfigNode("channels", configNode2);
		configNode2.Children.Add(configNode3);
		ConfigNode configNode4 = new ConfigNode("channel", configNode2);
		configNode4.Attributes.Add(new DictionaryEntry("ref", "http client"));
		configNode4.Attributes.Add(new DictionaryEntry("displayName", "http client (delay loaded)"));
		configNode4.Attributes.Add(new DictionaryEntry("delayLoadAsClientChannel", "true"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode2);
		configNode4.Attributes.Add(new DictionaryEntry("ref", "tcp client"));
		configNode4.Attributes.Add(new DictionaryEntry("displayName", "tcp client (delay loaded)"));
		configNode4.Attributes.Add(new DictionaryEntry("delayLoadAsClientChannel", "true"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode2);
		configNode4.Attributes.Add(new DictionaryEntry("ref", "ipc client"));
		configNode4.Attributes.Add(new DictionaryEntry("displayName", "ipc client (delay loaded)"));
		configNode4.Attributes.Add(new DictionaryEntry("delayLoadAsClientChannel", "true"));
		configNode3.Children.Add(configNode4);
		configNode3 = new ConfigNode("channels", configNode);
		configNode.Children.Add(configNode3);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "http"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Http.HttpChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "http client"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Http.HttpClientChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "http server"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Http.HttpServerChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "tcp"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Tcp.TcpChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "tcp client"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Tcp.TcpClientChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "tcp server"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Tcp.TcpServerChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "ipc"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Ipc.IpcChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "ipc client"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Ipc.IpcClientChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		configNode4 = new ConfigNode("channel", configNode3);
		configNode4.Attributes.Add(new DictionaryEntry("id", "ipc server"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.Ipc.IpcServerChannel, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode3.Children.Add(configNode4);
		ConfigNode configNode5 = new ConfigNode("channelSinkProviders", configNode);
		configNode.Children.Add(configNode5);
		ConfigNode configNode6 = new ConfigNode("clientProviders", configNode5);
		configNode5.Children.Add(configNode6);
		configNode4 = new ConfigNode("formatter", configNode6);
		configNode4.Attributes.Add(new DictionaryEntry("id", "soap"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.SoapClientFormatterSinkProvider, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode6.Children.Add(configNode4);
		configNode4 = new ConfigNode("formatter", configNode6);
		configNode4.Attributes.Add(new DictionaryEntry("id", "binary"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.BinaryClientFormatterSinkProvider, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode6.Children.Add(configNode4);
		ConfigNode configNode7 = new ConfigNode("serverProviders", configNode5);
		configNode5.Children.Add(configNode7);
		configNode4 = new ConfigNode("formatter", configNode7);
		configNode4.Attributes.Add(new DictionaryEntry("id", "soap"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.SoapServerFormatterSinkProvider, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode7.Children.Add(configNode4);
		configNode4 = new ConfigNode("formatter", configNode7);
		configNode4.Attributes.Add(new DictionaryEntry("id", "binary"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.Channels.BinaryServerFormatterSinkProvider, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode7.Children.Add(configNode4);
		configNode4 = new ConfigNode("provider", configNode7);
		configNode4.Attributes.Add(new DictionaryEntry("id", "wsdl"));
		configNode4.Attributes.Add(new DictionaryEntry("type", "System.Runtime.Remoting.MetadataServices.SdlChannelSinkProvider, System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"));
		configNode7.Children.Add(configNode4);
		return ParseConfigNode(configNode);
	}

	public static RemotingXmlConfigFileData ParseConfigFile(string filename)
	{
		ConfigTreeParser configTreeParser = new ConfigTreeParser();
		ConfigNode rootNode = configTreeParser.Parse(filename, "/configuration/system.runtime.remoting");
		return ParseConfigNode(rootNode);
	}

	private static RemotingXmlConfigFileData ParseConfigNode(ConfigNode rootNode)
	{
		RemotingXmlConfigFileData remotingXmlConfigFileData = new RemotingXmlConfigFileData();
		if (rootNode == null)
		{
			return null;
		}
		foreach (DictionaryEntry attribute in rootNode.Attributes)
		{
			string text = attribute.Key.ToString();
			_ = text == "version";
		}
		ConfigNode configNode = null;
		ConfigNode configNode2 = null;
		ConfigNode configNode3 = null;
		ConfigNode configNode4 = null;
		ConfigNode configNode5 = null;
		foreach (ConfigNode child in rootNode.Children)
		{
			switch (child.Name)
			{
			case "application":
				if (configNode != null)
				{
					ReportUniqueSectionError(rootNode, configNode, remotingXmlConfigFileData);
				}
				configNode = child;
				break;
			case "channels":
				if (configNode2 != null)
				{
					ReportUniqueSectionError(rootNode, configNode2, remotingXmlConfigFileData);
				}
				configNode2 = child;
				break;
			case "channelSinkProviders":
				if (configNode3 != null)
				{
					ReportUniqueSectionError(rootNode, configNode3, remotingXmlConfigFileData);
				}
				configNode3 = child;
				break;
			case "debug":
				if (configNode4 != null)
				{
					ReportUniqueSectionError(rootNode, configNode4, remotingXmlConfigFileData);
				}
				configNode4 = child;
				break;
			case "customErrors":
				if (configNode5 != null)
				{
					ReportUniqueSectionError(rootNode, configNode5, remotingXmlConfigFileData);
				}
				configNode5 = child;
				break;
			}
		}
		if (configNode4 != null)
		{
			ProcessDebugNode(configNode4, remotingXmlConfigFileData);
		}
		if (configNode3 != null)
		{
			ProcessChannelSinkProviderTemplates(configNode3, remotingXmlConfigFileData);
		}
		if (configNode2 != null)
		{
			ProcessChannelTemplates(configNode2, remotingXmlConfigFileData);
		}
		if (configNode != null)
		{
			ProcessApplicationNode(configNode, remotingXmlConfigFileData);
		}
		if (configNode5 != null)
		{
			ProcessCustomErrorsNode(configNode5, remotingXmlConfigFileData);
		}
		return remotingXmlConfigFileData;
	}

	private static void ReportError(string errorStr, RemotingXmlConfigFileData configData)
	{
		throw new RemotingException(errorStr);
	}

	private static void ReportUniqueSectionError(ConfigNode parent, ConfigNode child, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_NodeMustBeUnique"), child.Name, parent.Name), configData);
	}

	private static void ReportUnknownValueError(ConfigNode node, string value, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_UnknownValue"), node.Name, value), configData);
	}

	private static void ReportMissingAttributeError(ConfigNode node, string attributeName, RemotingXmlConfigFileData configData)
	{
		ReportMissingAttributeError(node.Name, attributeName, configData);
	}

	private static void ReportMissingAttributeError(string nodeDescription, string attributeName, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_RequiredXmlAttribute"), nodeDescription, attributeName), configData);
	}

	private static void ReportMissingTypeAttributeError(ConfigNode node, string attributeName, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_MissingTypeAttribute"), node.Name, attributeName), configData);
	}

	private static void ReportMissingXmlTypeAttributeError(ConfigNode node, string attributeName, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_MissingXmlTypeAttribute"), node.Name, attributeName), configData);
	}

	private static void ReportInvalidTimeFormatError(string time, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_InvalidTimeFormat"), time), configData);
	}

	private static void ReportNonTemplateIdAttributeError(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_NonTemplateIdAttribute"), node.Name), configData);
	}

	private static void ReportTemplateCannotReferenceTemplateError(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_TemplateCannotReferenceTemplate"), node.Name), configData);
	}

	private static void ReportUnableToResolveTemplateReferenceError(ConfigNode node, string referenceName, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_UnableToResolveTemplate"), node.Name, referenceName), configData);
	}

	private static void ReportAssemblyVersionInfoPresent(string assemName, string entryDescription, RemotingXmlConfigFileData configData)
	{
		ReportError(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Config_VersionPresent"), assemName, entryDescription), configData);
	}

	private static void ProcessDebugNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (text == "loadTypes")
			{
				RemotingXmlConfigFileData.LoadTypes = Convert.ToBoolean((string)attribute.Value, CultureInfo.InvariantCulture);
			}
		}
	}

	private static void ProcessApplicationNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (text.Equals("name"))
			{
				configData.ApplicationName = (string)attribute.Value;
			}
		}
		foreach (ConfigNode child in node.Children)
		{
			switch (child.Name)
			{
			case "channels":
				ProcessChannelsNode(child, configData);
				break;
			case "client":
				ProcessClientNode(child, configData);
				break;
			case "lifetime":
				ProcessLifetimeNode(node, child, configData);
				break;
			case "service":
				ProcessServiceNode(child, configData);
				break;
			case "soapInterop":
				ProcessSoapInteropNode(child, configData);
				break;
			}
		}
	}

	private static void ProcessCustomErrorsNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (text.Equals("mode"))
			{
				string text2 = (string)attribute.Value;
				CustomErrorsModes mode = CustomErrorsModes.On;
				if (string.Compare(text2, "on", StringComparison.OrdinalIgnoreCase) == 0)
				{
					mode = CustomErrorsModes.On;
				}
				else if (string.Compare(text2, "off", StringComparison.OrdinalIgnoreCase) == 0)
				{
					mode = CustomErrorsModes.Off;
				}
				else if (string.Compare(text2, "remoteonly", StringComparison.OrdinalIgnoreCase) == 0)
				{
					mode = CustomErrorsModes.RemoteOnly;
				}
				else
				{
					ReportUnknownValueError(node, text2, configData);
				}
				configData.CustomErrors = new RemotingXmlConfigFileData.CustomErrorsEntry(mode);
			}
		}
	}

	private static void ProcessLifetimeNode(ConfigNode parentNode, ConfigNode node, RemotingXmlConfigFileData configData)
	{
		if (configData.Lifetime != null)
		{
			ReportUniqueSectionError(node, parentNode, configData);
		}
		configData.Lifetime = new RemotingXmlConfigFileData.LifetimeEntry();
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			switch (attribute.Key.ToString())
			{
			case "leaseTime":
				configData.Lifetime.LeaseTime = ParseTime((string)attribute.Value, configData);
				break;
			case "sponsorshipTimeout":
				configData.Lifetime.SponsorshipTimeout = ParseTime((string)attribute.Value, configData);
				break;
			case "renewOnCallTime":
				configData.Lifetime.RenewOnCallTime = ParseTime((string)attribute.Value, configData);
				break;
			case "leaseManagerPollTime":
				configData.Lifetime.LeaseManagerPollTime = ParseTime((string)attribute.Value, configData);
				break;
			}
		}
	}

	private static void ProcessServiceNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (!(name == "wellknown"))
			{
				if (name == "activated")
				{
					ProcessServiceActivatedNode(child, configData);
				}
			}
			else
			{
				ProcessServiceWellKnownNode(child, configData);
			}
		}
	}

	private static void ProcessClientNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		string text = null;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text2 = attribute.Key.ToString();
			if (!(text2 == "url"))
			{
				if (text2 == "displayName")
				{
				}
			}
			else
			{
				text = (string)attribute.Value;
			}
		}
		RemotingXmlConfigFileData.RemoteAppEntry remoteAppEntry = configData.AddRemoteAppEntry(text);
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (!(name == "wellknown"))
			{
				if (name == "activated")
				{
					ProcessClientActivatedNode(child, configData, remoteAppEntry);
				}
			}
			else
			{
				ProcessClientWellKnownNode(child, configData, remoteAppEntry);
			}
		}
		if (remoteAppEntry.ActivatedObjects.Count > 0 && text == null)
		{
			ReportMissingAttributeError(node, "url", configData);
		}
	}

	private static void ProcessSoapInteropNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (text == "urlObjRef")
			{
				configData.UrlObjRefMode = Convert.ToBoolean(attribute.Value, CultureInfo.InvariantCulture);
			}
		}
		foreach (ConfigNode child in node.Children)
		{
			switch (child.Name)
			{
			case "preLoad":
				ProcessPreLoadNode(child, configData);
				break;
			case "interopXmlElement":
				ProcessInteropXmlElementNode(child, configData);
				break;
			case "interopXmlType":
				ProcessInteropXmlTypeNode(child, configData);
				break;
			}
		}
	}

	private static void ProcessChannelsNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (ConfigNode child in node.Children)
		{
			if (child.Name.Equals("channel"))
			{
				RemotingXmlConfigFileData.ChannelEntry value = ProcessChannelsChannelNode(child, configData, isTemplate: false);
				configData.ChannelEntries.Add(value);
			}
		}
	}

	private static void ProcessServiceWellKnownNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		string typeName = null;
		string assemName = null;
		ArrayList arrayList = new ArrayList();
		string text = null;
		WellKnownObjectMode objMode = WellKnownObjectMode.Singleton;
		bool flag = false;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			switch (attribute.Key.ToString())
			{
			case "mode":
			{
				string strA = (string)attribute.Value;
				flag = true;
				if (string.CompareOrdinal(strA, "Singleton") == 0)
				{
					objMode = WellKnownObjectMode.Singleton;
				}
				else if (string.CompareOrdinal(strA, "SingleCall") == 0)
				{
					objMode = WellKnownObjectMode.SingleCall;
				}
				else
				{
					flag = false;
				}
				break;
			}
			case "objectUri":
				text = (string)attribute.Value;
				break;
			case "type":
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
				break;
			}
		}
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (!(name == "contextAttribute"))
			{
				if (name == "lifetime")
				{
				}
			}
			else
			{
				arrayList.Add(ProcessContextAttributeNode(child, configData));
			}
		}
		if (!flag)
		{
			ReportError(Environment.GetResourceString("Remoting_Config_MissingWellKnownModeAttribute"), configData);
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingTypeAttributeError(node, "type", configData);
		}
		if (text == null)
		{
			text = typeName + ".soap";
		}
		configData.AddServerWellKnownEntry(typeName, assemName, arrayList, text, objMode);
	}

	private static void ProcessServiceActivatedNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		string typeName = null;
		string assemName = null;
		ArrayList arrayList = new ArrayList();
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (text == "type")
			{
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
			}
		}
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (!(name == "contextAttribute"))
			{
				if (name == "lifetime")
				{
				}
			}
			else
			{
				arrayList.Add(ProcessContextAttributeNode(child, configData));
			}
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingTypeAttributeError(node, "type", configData);
		}
		if (CheckAssemblyNameForVersionInfo(assemName))
		{
			ReportAssemblyVersionInfoPresent(assemName, "service activated", configData);
		}
		configData.AddServerActivatedEntry(typeName, assemName, arrayList);
	}

	private static void ProcessClientWellKnownNode(ConfigNode node, RemotingXmlConfigFileData configData, RemotingXmlConfigFileData.RemoteAppEntry remoteApp)
	{
		string typeName = null;
		string assemName = null;
		string text = null;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			switch (attribute.Key.ToString())
			{
			case "type":
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
				break;
			case "url":
				text = (string)attribute.Value;
				break;
			}
		}
		if (text == null)
		{
			ReportMissingAttributeError("WellKnown client", "url", configData);
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingTypeAttributeError(node, "type", configData);
		}
		if (CheckAssemblyNameForVersionInfo(assemName))
		{
			ReportAssemblyVersionInfoPresent(assemName, "client wellknown", configData);
		}
		remoteApp.AddWellKnownEntry(typeName, assemName, text);
	}

	private static void ProcessClientActivatedNode(ConfigNode node, RemotingXmlConfigFileData configData, RemotingXmlConfigFileData.RemoteAppEntry remoteApp)
	{
		string typeName = null;
		string assemName = null;
		ArrayList arrayList = new ArrayList();
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (text == "type")
			{
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
			}
		}
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (name == "contextAttribute")
			{
				arrayList.Add(ProcessContextAttributeNode(child, configData));
			}
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingTypeAttributeError(node, "type", configData);
		}
		remoteApp.AddActivatedEntry(typeName, assemName, arrayList);
	}

	private static void ProcessInteropXmlElementNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		string typeName = null;
		string assemName = null;
		string typeName2 = null;
		string assemName2 = null;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (!(text == "xml"))
			{
				if (text == "clr")
				{
					RemotingConfigHandler.ParseType((string)attribute.Value, out typeName2, out assemName2);
				}
			}
			else
			{
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
			}
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingXmlTypeAttributeError(node, "xml", configData);
		}
		if (typeName2 == null || assemName2 == null)
		{
			ReportMissingTypeAttributeError(node, "clr", configData);
		}
		configData.AddInteropXmlElementEntry(typeName, assemName, typeName2, assemName2);
	}

	private static void ProcessInteropXmlTypeNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		string typeName = null;
		string assemName = null;
		string typeName2 = null;
		string assemName2 = null;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (!(text == "xml"))
			{
				if (text == "clr")
				{
					RemotingConfigHandler.ParseType((string)attribute.Value, out typeName2, out assemName2);
				}
			}
			else
			{
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
			}
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingXmlTypeAttributeError(node, "xml", configData);
		}
		if (typeName2 == null || assemName2 == null)
		{
			ReportMissingTypeAttributeError(node, "clr", configData);
		}
		configData.AddInteropXmlTypeEntry(typeName, assemName, typeName2, assemName2);
	}

	private static void ProcessPreLoadNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		string typeName = null;
		string assemName = null;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = attribute.Key.ToString();
			if (!(text == "type"))
			{
				if (text == "assembly")
				{
					assemName = (string)attribute.Value;
				}
			}
			else
			{
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
			}
		}
		if (assemName == null)
		{
			ReportError(Environment.GetResourceString("Remoting_Config_PreloadRequiresTypeOrAssembly"), configData);
		}
		configData.AddPreLoadEntry(typeName, assemName);
	}

	private static RemotingXmlConfigFileData.ContextAttributeEntry ProcessContextAttributeNode(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		string typeName = null;
		string assemName = null;
		Hashtable hashtable = CreateCaseInsensitiveHashtable();
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = ((string)attribute.Key).ToLower(CultureInfo.InvariantCulture);
			if (text == "type")
			{
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
			}
			else
			{
				hashtable[text] = attribute.Value;
			}
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingTypeAttributeError(node, "type", configData);
		}
		return new RemotingXmlConfigFileData.ContextAttributeEntry(typeName, assemName, hashtable);
	}

	private static RemotingXmlConfigFileData.ChannelEntry ProcessChannelsChannelNode(ConfigNode node, RemotingXmlConfigFileData configData, bool isTemplate)
	{
		string key = null;
		string typeName = null;
		string assemName = null;
		Hashtable hashtable = CreateCaseInsensitiveHashtable();
		bool delayLoad = false;
		RemotingXmlConfigFileData.ChannelEntry channelEntry = null;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = (string)attribute.Key;
			switch (text)
			{
			case "id":
				if (!isTemplate)
				{
					ReportNonTemplateIdAttributeError(node, configData);
				}
				else
				{
					key = ((string)attribute.Value).ToLower(CultureInfo.InvariantCulture);
				}
				break;
			case "ref":
				if (isTemplate)
				{
					ReportTemplateCannotReferenceTemplateError(node, configData);
					break;
				}
				channelEntry = (RemotingXmlConfigFileData.ChannelEntry)_channelTemplates[attribute.Value];
				if (channelEntry == null)
				{
					ReportUnableToResolveTemplateReferenceError(node, attribute.Value.ToString(), configData);
					break;
				}
				typeName = channelEntry.TypeName;
				assemName = channelEntry.AssemblyName;
				foreach (DictionaryEntry property in channelEntry.Properties)
				{
					hashtable[property.Key] = property.Value;
				}
				break;
			case "type":
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
				break;
			case "delayLoadAsClientChannel":
				delayLoad = Convert.ToBoolean((string)attribute.Value, CultureInfo.InvariantCulture);
				break;
			default:
				hashtable[text] = attribute.Value;
				break;
			case "displayName":
				break;
			}
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingTypeAttributeError(node, "type", configData);
		}
		RemotingXmlConfigFileData.ChannelEntry channelEntry2 = new RemotingXmlConfigFileData.ChannelEntry(typeName, assemName, hashtable);
		channelEntry2.DelayLoad = delayLoad;
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (!(name == "clientProviders"))
			{
				if (name == "serverProviders")
				{
					ProcessSinkProviderNodes(child, channelEntry2, configData, isServer: true);
				}
			}
			else
			{
				ProcessSinkProviderNodes(child, channelEntry2, configData, isServer: false);
			}
		}
		if (channelEntry != null)
		{
			if (channelEntry2.ClientSinkProviders.Count == 0)
			{
				channelEntry2.ClientSinkProviders = channelEntry.ClientSinkProviders;
			}
			if (channelEntry2.ServerSinkProviders.Count == 0)
			{
				channelEntry2.ServerSinkProviders = channelEntry.ServerSinkProviders;
			}
		}
		if (isTemplate)
		{
			_channelTemplates[key] = channelEntry2;
			return null;
		}
		return channelEntry2;
	}

	private static void ProcessSinkProviderNodes(ConfigNode node, RemotingXmlConfigFileData.ChannelEntry channelEntry, RemotingXmlConfigFileData configData, bool isServer)
	{
		foreach (ConfigNode child in node.Children)
		{
			RemotingXmlConfigFileData.SinkProviderEntry value = ProcessSinkProviderNode(child, configData, isTemplate: false, isServer);
			if (isServer)
			{
				channelEntry.ServerSinkProviders.Add(value);
			}
			else
			{
				channelEntry.ClientSinkProviders.Add(value);
			}
		}
	}

	private static RemotingXmlConfigFileData.SinkProviderEntry ProcessSinkProviderNode(ConfigNode node, RemotingXmlConfigFileData configData, bool isTemplate, bool isServer)
	{
		bool isFormatter = false;
		string name = node.Name;
		if (name.Equals("formatter"))
		{
			isFormatter = true;
		}
		else if (name.Equals("provider"))
		{
			isFormatter = false;
		}
		else
		{
			ReportError(Environment.GetResourceString("Remoting_Config_ProviderNeedsElementName"), configData);
		}
		string key = null;
		string typeName = null;
		string assemName = null;
		Hashtable hashtable = CreateCaseInsensitiveHashtable();
		RemotingXmlConfigFileData.SinkProviderEntry sinkProviderEntry = null;
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			string text = (string)attribute.Key;
			switch (text)
			{
			case "id":
				if (!isTemplate)
				{
					ReportNonTemplateIdAttributeError(node, configData);
				}
				else
				{
					key = (string)attribute.Value;
				}
				break;
			case "ref":
				if (isTemplate)
				{
					ReportTemplateCannotReferenceTemplateError(node, configData);
					break;
				}
				sinkProviderEntry = ((!isServer) ? ((RemotingXmlConfigFileData.SinkProviderEntry)_clientChannelSinkTemplates[attribute.Value]) : ((RemotingXmlConfigFileData.SinkProviderEntry)_serverChannelSinkTemplates[attribute.Value]));
				if (sinkProviderEntry == null)
				{
					ReportUnableToResolveTemplateReferenceError(node, attribute.Value.ToString(), configData);
					break;
				}
				typeName = sinkProviderEntry.TypeName;
				assemName = sinkProviderEntry.AssemblyName;
				foreach (DictionaryEntry property in sinkProviderEntry.Properties)
				{
					hashtable[property.Key] = property.Value;
				}
				break;
			case "type":
				RemotingConfigHandler.ParseType((string)attribute.Value, out typeName, out assemName);
				break;
			default:
				hashtable[text] = attribute.Value;
				break;
			}
		}
		if (typeName == null || assemName == null)
		{
			ReportMissingTypeAttributeError(node, "type", configData);
		}
		RemotingXmlConfigFileData.SinkProviderEntry sinkProviderEntry2 = new RemotingXmlConfigFileData.SinkProviderEntry(typeName, assemName, hashtable, isFormatter);
		foreach (ConfigNode child in node.Children)
		{
			SinkProviderData value = ProcessSinkProviderData(child, configData);
			sinkProviderEntry2.ProviderData.Add(value);
		}
		if (sinkProviderEntry != null && sinkProviderEntry2.ProviderData.Count == 0)
		{
			sinkProviderEntry2.ProviderData = sinkProviderEntry.ProviderData;
		}
		if (isTemplate)
		{
			if (isServer)
			{
				_serverChannelSinkTemplates[key] = sinkProviderEntry2;
			}
			else
			{
				_clientChannelSinkTemplates[key] = sinkProviderEntry2;
			}
			return null;
		}
		return sinkProviderEntry2;
	}

	private static SinkProviderData ProcessSinkProviderData(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		SinkProviderData sinkProviderData = new SinkProviderData(node.Name);
		foreach (ConfigNode child in node.Children)
		{
			SinkProviderData value = ProcessSinkProviderData(child, configData);
			sinkProviderData.Children.Add(value);
		}
		foreach (DictionaryEntry attribute in node.Attributes)
		{
			sinkProviderData.Properties[attribute.Key] = attribute.Value;
		}
		return sinkProviderData;
	}

	private static void ProcessChannelTemplates(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (name == "channel")
			{
				ProcessChannelsChannelNode(child, configData, isTemplate: true);
			}
		}
	}

	private static void ProcessChannelSinkProviderTemplates(ConfigNode node, RemotingXmlConfigFileData configData)
	{
		foreach (ConfigNode child in node.Children)
		{
			string name = child.Name;
			if (!(name == "clientProviders"))
			{
				if (name == "serverProviders")
				{
					ProcessChannelProviderTemplates(child, configData, isServer: true);
				}
			}
			else
			{
				ProcessChannelProviderTemplates(child, configData, isServer: false);
			}
		}
	}

	private static void ProcessChannelProviderTemplates(ConfigNode node, RemotingXmlConfigFileData configData, bool isServer)
	{
		foreach (ConfigNode child in node.Children)
		{
			ProcessSinkProviderNode(child, configData, isTemplate: true, isServer);
		}
	}

	private static bool CheckAssemblyNameForVersionInfo(string assemName)
	{
		if (assemName == null)
		{
			return false;
		}
		int num = assemName.IndexOf(',');
		return num != -1;
	}

	private static TimeSpan ParseTime(string time, RemotingXmlConfigFileData configData)
	{
		string time2 = time;
		string text = "s";
		int num = 0;
		char c = ' ';
		if (time.Length > 0)
		{
			c = time[time.Length - 1];
		}
		TimeSpan result = TimeSpan.FromSeconds(0.0);
		try
		{
			if (!char.IsDigit(c))
			{
				if (time.Length == 0)
				{
					ReportInvalidTimeFormatError(time2, configData);
				}
				time = time.ToLower(CultureInfo.InvariantCulture);
				num = 1;
				if (time.EndsWith("ms", StringComparison.Ordinal))
				{
					num = 2;
				}
				text = time.Substring(time.Length - num, num);
			}
			int num2 = int.Parse(time.Substring(0, time.Length - num), CultureInfo.InvariantCulture);
			switch (text)
			{
			case "d":
				result = TimeSpan.FromDays(num2);
				break;
			case "h":
				result = TimeSpan.FromHours(num2);
				break;
			case "m":
				result = TimeSpan.FromMinutes(num2);
				break;
			case "s":
				result = TimeSpan.FromSeconds(num2);
				break;
			case "ms":
				result = TimeSpan.FromMilliseconds(num2);
				break;
			default:
				ReportInvalidTimeFormatError(time2, configData);
				break;
			}
		}
		catch (Exception)
		{
			ReportInvalidTimeFormatError(time2, configData);
		}
		return result;
	}
}
