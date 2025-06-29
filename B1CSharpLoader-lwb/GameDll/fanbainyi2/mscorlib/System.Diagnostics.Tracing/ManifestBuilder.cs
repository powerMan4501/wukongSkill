using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text;
using Microsoft.Reflection;

namespace System.Diagnostics.Tracing;

internal class ManifestBuilder
{
	private class ChannelInfo
	{
		public string Name;

		public ulong Keywords;

		public EventChannelAttribute Attribs;
	}

	private Dictionary<int, string> opcodeTab;

	private Dictionary<int, string> taskTab;

	private Dictionary<int, ChannelInfo> channelTab;

	private Dictionary<ulong, string> keywordTab;

	private Dictionary<string, Type> mapsTab;

	private Dictionary<string, string> stringTab;

	private ulong nextChannelKeywordBit = 9223372036854775808uL;

	private const int MaxCountChannels = 8;

	private StringBuilder sb;

	private StringBuilder events;

	private StringBuilder templates;

	private string providerName;

	private ResourceManager resources;

	private EventManifestOptions flags;

	private IList<string> errors;

	private Dictionary<string, List<int>> perEventByteArrayArgIndices;

	private string eventName;

	private int numParams;

	private List<int> byteArrArgIndices;

	public IList<string> Errors => errors;

	public ManifestBuilder(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags)
	{
		this.providerName = providerName;
		this.flags = flags;
		this.resources = resources;
		sb = new StringBuilder();
		events = new StringBuilder();
		templates = new StringBuilder();
		opcodeTab = new Dictionary<int, string>();
		stringTab = new Dictionary<string, string>();
		errors = new List<string>();
		perEventByteArrayArgIndices = new Dictionary<string, List<int>>();
		sb.AppendLine("<instrumentationManifest xmlns=\"http://schemas.microsoft.com/win/2004/08/events\">");
		sb.AppendLine(" <instrumentation xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:win=\"http://manifests.microsoft.com/win/2004/08/windows/events\">");
		sb.AppendLine("  <events xmlns=\"http://schemas.microsoft.com/win/2004/08/events\">");
		sb.Append("<provider name=\"").Append(providerName).Append("\" guid=\"{")
			.Append(providerGuid.ToString())
			.Append("}");
		if (dllName != null)
		{
			sb.Append("\" resourceFileName=\"").Append(dllName).Append("\" messageFileName=\"")
				.Append(dllName);
		}
		string value = providerName.Replace("-", "").Replace(".", "_");
		sb.Append("\" symbol=\"").Append(value);
		sb.Append("\">").AppendLine();
	}

	public void AddOpcode(string name, int value)
	{
		if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None)
		{
			if (value <= 10 || value >= 239)
			{
				ManifestError(Environment.GetResourceString("EventSource_IllegalOpcodeValue", name, value));
			}
			if (opcodeTab.TryGetValue(value, out var value2) && !name.Equals(value2, StringComparison.Ordinal))
			{
				ManifestError(Environment.GetResourceString("EventSource_OpcodeCollision", name, value2, value));
			}
		}
		opcodeTab[value] = name;
	}

	public void AddTask(string name, int value)
	{
		if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None)
		{
			if (value <= 0 || value >= 65535)
			{
				ManifestError(Environment.GetResourceString("EventSource_IllegalTaskValue", name, value));
			}
			if (taskTab != null && taskTab.TryGetValue(value, out var value2) && !name.Equals(value2, StringComparison.Ordinal))
			{
				ManifestError(Environment.GetResourceString("EventSource_TaskCollision", name, value2, value));
			}
		}
		if (taskTab == null)
		{
			taskTab = new Dictionary<int, string>();
		}
		taskTab[value] = name;
	}

	public void AddKeyword(string name, ulong value)
	{
		if ((value & (value - 1)) != 0L)
		{
			ManifestError(Environment.GetResourceString("EventSource_KeywordNeedPowerOfTwo", "0x" + value.ToString("x", CultureInfo.CurrentCulture), name), runtimeCritical: true);
		}
		if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None)
		{
			if (value >= 17592186044416L && !name.StartsWith("Session", StringComparison.Ordinal))
			{
				ManifestError(Environment.GetResourceString("EventSource_IllegalKeywordsValue", name, "0x" + value.ToString("x", CultureInfo.CurrentCulture)));
			}
			if (keywordTab != null && keywordTab.TryGetValue(value, out var value2) && !name.Equals(value2, StringComparison.Ordinal))
			{
				ManifestError(Environment.GetResourceString("EventSource_KeywordCollision", name, value2, "0x" + value.ToString("x", CultureInfo.CurrentCulture)));
			}
		}
		if (keywordTab == null)
		{
			keywordTab = new Dictionary<ulong, string>();
		}
		keywordTab[value] = name;
	}

	public void AddChannel(string name, int value, EventChannelAttribute channelAttribute)
	{
		EventChannel eventChannel = (EventChannel)value;
		if (value < 16 || value > 255)
		{
			ManifestError(Environment.GetResourceString("EventSource_EventChannelOutOfRange", name, value));
		}
		else if ((int)eventChannel >= 16 && (int)eventChannel <= 19 && channelAttribute != null && EventChannelToChannelType(eventChannel) != channelAttribute.EventChannelType)
		{
			ManifestError(Environment.GetResourceString("EventSource_ChannelTypeDoesNotMatchEventChannelValue", name, ((EventChannel)value/*cast due to .constrained prefix*/).ToString()));
		}
		ulong channelKeyword = GetChannelKeyword(eventChannel);
		if (channelTab == null)
		{
			channelTab = new Dictionary<int, ChannelInfo>(4);
		}
		channelTab[value] = new ChannelInfo
		{
			Name = name,
			Keywords = channelKeyword,
			Attribs = channelAttribute
		};
	}

	private EventChannelType EventChannelToChannelType(EventChannel channel)
	{
		return (EventChannelType)(channel - 16 + 1);
	}

	private EventChannelAttribute GetDefaultChannelAttribute(EventChannel channel)
	{
		EventChannelAttribute eventChannelAttribute = new EventChannelAttribute();
		eventChannelAttribute.EventChannelType = EventChannelToChannelType(channel);
		if (eventChannelAttribute.EventChannelType <= EventChannelType.Operational)
		{
			eventChannelAttribute.Enabled = true;
		}
		return eventChannelAttribute;
	}

	public ulong[] GetChannelData()
	{
		if (channelTab == null)
		{
			return new ulong[0];
		}
		int num = -1;
		foreach (int key in channelTab.Keys)
		{
			if (key > num)
			{
				num = key;
			}
		}
		ulong[] array = new ulong[num + 1];
		foreach (KeyValuePair<int, ChannelInfo> item in channelTab)
		{
			array[item.Key] = item.Value.Keywords;
		}
		return array;
	}

	public void StartEvent(string eventName, EventAttribute eventAttribute)
	{
		this.eventName = eventName;
		numParams = 0;
		byteArrArgIndices = null;
		events.Append("  <event").Append(" value=\"").Append(eventAttribute.EventId)
			.Append("\"")
			.Append(" version=\"")
			.Append(eventAttribute.Version)
			.Append("\"")
			.Append(" level=\"")
			.Append(GetLevelName(eventAttribute.Level))
			.Append("\"")
			.Append(" symbol=\"")
			.Append(eventName)
			.Append("\"");
		WriteMessageAttrib(events, "event", eventName, eventAttribute.Message);
		if (eventAttribute.Keywords != EventKeywords.None)
		{
			events.Append(" keywords=\"").Append(GetKeywords((ulong)eventAttribute.Keywords, eventName)).Append("\"");
		}
		if (eventAttribute.Opcode != EventOpcode.Info)
		{
			events.Append(" opcode=\"").Append(GetOpcodeName(eventAttribute.Opcode, eventName)).Append("\"");
		}
		if (eventAttribute.Task != EventTask.None)
		{
			events.Append(" task=\"").Append(GetTaskName(eventAttribute.Task, eventName)).Append("\"");
		}
		if (eventAttribute.Channel != EventChannel.None)
		{
			events.Append(" channel=\"").Append(GetChannelName(eventAttribute.Channel, eventName, eventAttribute.Message)).Append("\"");
		}
	}

	public void AddEventParameter(Type type, string name)
	{
		if (numParams == 0)
		{
			templates.Append("  <template tid=\"").Append(eventName).Append("Args\">")
				.AppendLine();
		}
		if (type == typeof(byte[]))
		{
			if (byteArrArgIndices == null)
			{
				byteArrArgIndices = new List<int>(4);
			}
			byteArrArgIndices.Add(numParams);
			numParams++;
			templates.Append("   <data name=\"").Append(name).Append("Size\" inType=\"win:UInt32\"/>")
				.AppendLine();
		}
		numParams++;
		templates.Append("   <data name=\"").Append(name).Append("\" inType=\"")
			.Append(GetTypeName(type))
			.Append("\"");
		if ((type.IsArray || type.IsPointer) && type.GetElementType() == typeof(byte))
		{
			templates.Append(" length=\"").Append(name).Append("Size\"");
		}
		if (type.IsEnum() && Enum.GetUnderlyingType(type) != typeof(ulong) && Enum.GetUnderlyingType(type) != typeof(long))
		{
			templates.Append(" map=\"").Append(type.Name).Append("\"");
			if (mapsTab == null)
			{
				mapsTab = new Dictionary<string, Type>();
			}
			if (!mapsTab.ContainsKey(type.Name))
			{
				mapsTab.Add(type.Name, type);
			}
		}
		templates.Append("/>").AppendLine();
	}

	public void EndEvent()
	{
		if (numParams > 0)
		{
			templates.Append("  </template>").AppendLine();
			events.Append(" template=\"").Append(eventName).Append("Args\"");
		}
		events.Append("/>").AppendLine();
		if (byteArrArgIndices != null)
		{
			perEventByteArrayArgIndices[eventName] = byteArrArgIndices;
		}
		if (stringTab.TryGetValue("event_" + eventName, out var value))
		{
			value = TranslateToManifestConvention(value, eventName);
			stringTab["event_" + eventName] = value;
		}
		eventName = null;
		numParams = 0;
		byteArrArgIndices = null;
	}

	public ulong GetChannelKeyword(EventChannel channel)
	{
		if (channelTab == null)
		{
			channelTab = new Dictionary<int, ChannelInfo>(4);
		}
		if (channelTab.Count == 8)
		{
			ManifestError(Environment.GetResourceString("EventSource_MaxChannelExceeded"));
		}
		ulong keywords;
		if (!channelTab.TryGetValue((int)channel, out var value))
		{
			keywords = nextChannelKeywordBit;
			nextChannelKeywordBit >>= 1;
		}
		else
		{
			keywords = value.Keywords;
		}
		return keywords;
	}

	public byte[] CreateManifest()
	{
		string s = CreateManifestString();
		return Encoding.UTF8.GetBytes(s);
	}

	public void ManifestError(string msg, bool runtimeCritical = false)
	{
		if ((flags & EventManifestOptions.Strict) != EventManifestOptions.None)
		{
			errors.Add(msg);
		}
		else if (runtimeCritical)
		{
			throw new ArgumentException(msg);
		}
	}

	private string CreateManifestString()
	{
		if (channelTab != null)
		{
			sb.Append(" <channels>").AppendLine();
			List<KeyValuePair<int, ChannelInfo>> list = new List<KeyValuePair<int, ChannelInfo>>();
			foreach (KeyValuePair<int, ChannelInfo> item in channelTab)
			{
				list.Add(item);
			}
			list.Sort((KeyValuePair<int, ChannelInfo> p1, KeyValuePair<int, ChannelInfo> p2) => -Comparer<ulong>.Default.Compare(p1.Value.Keywords, p2.Value.Keywords));
			foreach (KeyValuePair<int, ChannelInfo> item2 in list)
			{
				int key = item2.Key;
				ChannelInfo value = item2.Value;
				string text = null;
				string text2 = "channel";
				bool flag = false;
				string text3 = null;
				if (value.Attribs != null)
				{
					EventChannelAttribute attribs = value.Attribs;
					if (Enum.IsDefined(typeof(EventChannelType), attribs.EventChannelType))
					{
						text = attribs.EventChannelType.ToString();
					}
					flag = attribs.Enabled;
				}
				if (text3 == null)
				{
					text3 = providerName + "/" + value.Name;
				}
				sb.Append("  <").Append(text2);
				sb.Append(" chid=\"").Append(value.Name).Append("\"");
				sb.Append(" name=\"").Append(text3).Append("\"");
				if (text2 == "channel")
				{
					WriteMessageAttrib(sb, "channel", value.Name, null);
					sb.Append(" value=\"").Append(key).Append("\"");
					if (text != null)
					{
						sb.Append(" type=\"").Append(text).Append("\"");
					}
					sb.Append(" enabled=\"").Append(flag.ToString().ToLower()).Append("\"");
				}
				sb.Append("/>").AppendLine();
			}
			sb.Append(" </channels>").AppendLine();
		}
		if (taskTab != null)
		{
			sb.Append(" <tasks>").AppendLine();
			List<int> list2 = new List<int>(taskTab.Keys);
			list2.Sort();
			foreach (int item3 in list2)
			{
				sb.Append("  <task");
				WriteNameAndMessageAttribs(sb, "task", taskTab[item3]);
				sb.Append(" value=\"").Append(item3).Append("\"/>")
					.AppendLine();
			}
			sb.Append(" </tasks>").AppendLine();
		}
		if (mapsTab != null)
		{
			sb.Append(" <maps>").AppendLine();
			foreach (Type value3 in mapsTab.Values)
			{
				bool flag2 = EventSource.GetCustomAttributeHelper(value3, typeof(FlagsAttribute), flags) != null;
				string value2 = (flag2 ? "bitMap" : "valueMap");
				sb.Append("  <").Append(value2).Append(" name=\"")
					.Append(value3.Name)
					.Append("\">")
					.AppendLine();
				FieldInfo[] fields = value3.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);
				FieldInfo[] array = fields;
				foreach (FieldInfo fieldInfo in array)
				{
					object rawConstantValue = fieldInfo.GetRawConstantValue();
					if (rawConstantValue == null)
					{
						continue;
					}
					long num2;
					if (rawConstantValue is int)
					{
						num2 = (int)rawConstantValue;
					}
					else
					{
						if (!(rawConstantValue is long))
						{
							continue;
						}
						num2 = (long)rawConstantValue;
					}
					if (!flag2 || ((num2 & (num2 - 1)) == 0L && num2 != 0L))
					{
						sb.Append("   <map value=\"0x").Append(num2.ToString("x", CultureInfo.InvariantCulture)).Append("\"");
						WriteMessageAttrib(sb, "map", value3.Name + "." + fieldInfo.Name, fieldInfo.Name);
						sb.Append("/>").AppendLine();
					}
				}
				sb.Append("  </").Append(value2).Append(">")
					.AppendLine();
			}
			sb.Append(" </maps>").AppendLine();
		}
		sb.Append(" <opcodes>").AppendLine();
		List<int> list3 = new List<int>(opcodeTab.Keys);
		list3.Sort();
		foreach (int item4 in list3)
		{
			sb.Append("  <opcode");
			WriteNameAndMessageAttribs(sb, "opcode", opcodeTab[item4]);
			sb.Append(" value=\"").Append(item4).Append("\"/>")
				.AppendLine();
		}
		sb.Append(" </opcodes>").AppendLine();
		if (keywordTab != null)
		{
			sb.Append(" <keywords>").AppendLine();
			List<ulong> list4 = new List<ulong>(keywordTab.Keys);
			list4.Sort();
			foreach (ulong item5 in list4)
			{
				sb.Append("  <keyword");
				WriteNameAndMessageAttribs(sb, "keyword", keywordTab[item5]);
				sb.Append(" mask=\"0x").Append(item5.ToString("x", CultureInfo.InvariantCulture)).Append("\"/>")
					.AppendLine();
			}
			sb.Append(" </keywords>").AppendLine();
		}
		sb.Append(" <events>").AppendLine();
		sb.Append(events);
		sb.Append(" </events>").AppendLine();
		sb.Append(" <templates>").AppendLine();
		if (templates.Length > 0)
		{
			sb.Append(templates);
		}
		else
		{
			sb.Append("    <template tid=\"_empty\"></template>").AppendLine();
		}
		sb.Append(" </templates>").AppendLine();
		sb.Append("</provider>").AppendLine();
		sb.Append("</events>").AppendLine();
		sb.Append("</instrumentation>").AppendLine();
		sb.Append("<localization>").AppendLine();
		List<CultureInfo> list5 = null;
		if (resources != null && (flags & EventManifestOptions.AllCultures) != EventManifestOptions.None)
		{
			list5 = GetSupportedCultures(resources);
		}
		else
		{
			list5 = new List<CultureInfo>();
			list5.Add(CultureInfo.CurrentUICulture);
		}
		string[] array2 = new string[stringTab.Keys.Count];
		stringTab.Keys.CopyTo(array2, 0);
		ArraySortHelper<string>.IntrospectiveSort(array2, 0, array2.Length, Comparer<string>.Default);
		foreach (CultureInfo item6 in list5)
		{
			sb.Append(" <resources culture=\"").Append(item6.Name).Append("\">")
				.AppendLine();
			sb.Append("  <stringTable>").AppendLine();
			string[] array3 = array2;
			foreach (string text4 in array3)
			{
				string localizedMessage = GetLocalizedMessage(text4, item6, etwFormat: true);
				sb.Append("   <string id=\"").Append(text4).Append("\" value=\"")
					.Append(localizedMessage)
					.Append("\"/>")
					.AppendLine();
			}
			sb.Append("  </stringTable>").AppendLine();
			sb.Append(" </resources>").AppendLine();
		}
		sb.Append("</localization>").AppendLine();
		sb.AppendLine("</instrumentationManifest>");
		return sb.ToString();
	}

	private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name)
	{
		stringBuilder.Append(" name=\"").Append(name).Append("\"");
		WriteMessageAttrib(sb, elementName, name, name);
	}

	private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value)
	{
		string text = elementName + "_" + name;
		if (resources != null)
		{
			string text2 = resources.GetString(text, CultureInfo.InvariantCulture);
			if (text2 != null)
			{
				value = text2;
			}
		}
		if (value != null)
		{
			stringBuilder.Append(" message=\"$(string.").Append(text).Append(")\"");
			if (stringTab.TryGetValue(text, out var value2) && !value2.Equals(value))
			{
				ManifestError(Environment.GetResourceString("EventSource_DuplicateStringKey", text), runtimeCritical: true);
			}
			else
			{
				stringTab[text] = value;
			}
		}
	}

	internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat)
	{
		string value = null;
		if (resources != null)
		{
			string text = resources.GetString(key, ci);
			if (text != null)
			{
				value = text;
				if (etwFormat && key.StartsWith("event_"))
				{
					string evtName = key.Substring("event_".Length);
					value = TranslateToManifestConvention(value, evtName);
				}
			}
		}
		if (etwFormat && value == null)
		{
			stringTab.TryGetValue(key, out value);
		}
		return value;
	}

	private static List<CultureInfo> GetSupportedCultures(ResourceManager resources)
	{
		List<CultureInfo> list = new List<CultureInfo>();
		CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
		foreach (CultureInfo cultureInfo in cultures)
		{
			if (resources.GetResourceSet(cultureInfo, createIfNotExists: true, tryParents: false) != null)
			{
				list.Add(cultureInfo);
			}
		}
		if (!list.Contains(CultureInfo.CurrentUICulture))
		{
			list.Insert(0, CultureInfo.CurrentUICulture);
		}
		return list;
	}

	private static string GetLevelName(EventLevel level)
	{
		return ((level >= (EventLevel)16) ? "" : "win:") + level;
	}

	private string GetChannelName(EventChannel channel, string eventName, string eventMessage)
	{
		ChannelInfo value = null;
		if (channelTab == null || !channelTab.TryGetValue((int)channel, out value))
		{
			if ((int)channel < 16)
			{
				ManifestError(Environment.GetResourceString("EventSource_UndefinedChannel", channel, eventName));
			}
			if (channelTab == null)
			{
				channelTab = new Dictionary<int, ChannelInfo>(4);
			}
			string text = channel.ToString();
			if (19 < (int)channel)
			{
				text = "Channel" + text;
			}
			AddChannel(text, (int)channel, GetDefaultChannelAttribute(channel));
			if (!channelTab.TryGetValue((int)channel, out value))
			{
				ManifestError(Environment.GetResourceString("EventSource_UndefinedChannel", channel, eventName));
			}
		}
		if (resources != null && eventMessage == null)
		{
			eventMessage = resources.GetString("event_" + eventName, CultureInfo.InvariantCulture);
		}
		if (value.Attribs.EventChannelType == EventChannelType.Admin && eventMessage == null)
		{
			ManifestError(Environment.GetResourceString("EventSource_EventWithAdminChannelMustHaveMessage", eventName, value.Name));
		}
		return value.Name;
	}

	private string GetTaskName(EventTask task, string eventName)
	{
		if (task == EventTask.None)
		{
			return "";
		}
		if (taskTab == null)
		{
			taskTab = new Dictionary<int, string>();
		}
		if (!taskTab.TryGetValue((int)task, out var value))
		{
			return taskTab[(int)task] = eventName;
		}
		return value;
	}

	private string GetOpcodeName(EventOpcode opcode, string eventName)
	{
		switch (opcode)
		{
		case EventOpcode.Info:
			return "win:Info";
		case EventOpcode.Start:
			return "win:Start";
		case EventOpcode.Stop:
			return "win:Stop";
		case EventOpcode.DataCollectionStart:
			return "win:DC_Start";
		case EventOpcode.DataCollectionStop:
			return "win:DC_Stop";
		case EventOpcode.Extension:
			return "win:Extension";
		case EventOpcode.Reply:
			return "win:Reply";
		case EventOpcode.Resume:
			return "win:Resume";
		case EventOpcode.Suspend:
			return "win:Suspend";
		case EventOpcode.Send:
			return "win:Send";
		case EventOpcode.Receive:
			return "win:Receive";
		default:
		{
			if (opcodeTab == null || !opcodeTab.TryGetValue((int)opcode, out var value))
			{
				ManifestError(Environment.GetResourceString("EventSource_UndefinedOpcode", opcode, eventName), runtimeCritical: true);
				return null;
			}
			return value;
		}
		}
	}

	private string GetKeywords(ulong keywords, string eventName)
	{
		string text = "";
		for (ulong num = 1uL; num != 0L; num <<= 1)
		{
			if ((keywords & num) != 0L)
			{
				string value = null;
				if ((keywordTab == null || !keywordTab.TryGetValue(num, out value)) && num >= 281474976710656L)
				{
					value = string.Empty;
				}
				if (value == null)
				{
					ManifestError(Environment.GetResourceString("EventSource_UndefinedKeyword", "0x" + num.ToString("x", CultureInfo.CurrentCulture), eventName), runtimeCritical: true);
					value = string.Empty;
				}
				if (text.Length != 0 && value.Length != 0)
				{
					text += " ";
				}
				text += value;
			}
		}
		return text;
	}

	private string GetTypeName(Type type)
	{
		if (type.IsEnum())
		{
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			string typeName = GetTypeName(fields[0].FieldType);
			return typeName.Replace("win:Int", "win:UInt");
		}
		switch (type.GetTypeCode())
		{
		case TypeCode.Boolean:
			return "win:Boolean";
		case TypeCode.Byte:
			return "win:UInt8";
		case TypeCode.Char:
		case TypeCode.UInt16:
			return "win:UInt16";
		case TypeCode.UInt32:
			return "win:UInt32";
		case TypeCode.UInt64:
			return "win:UInt64";
		case TypeCode.SByte:
			return "win:Int8";
		case TypeCode.Int16:
			return "win:Int16";
		case TypeCode.Int32:
			return "win:Int32";
		case TypeCode.Int64:
			return "win:Int64";
		case TypeCode.String:
			return "win:UnicodeString";
		case TypeCode.Single:
			return "win:Float";
		case TypeCode.Double:
			return "win:Double";
		case TypeCode.DateTime:
			return "win:FILETIME";
		default:
			if (type == typeof(Guid))
			{
				return "win:GUID";
			}
			if (type == typeof(IntPtr))
			{
				return "win:Pointer";
			}
			if ((type.IsArray || type.IsPointer) && type.GetElementType() == typeof(byte))
			{
				return "win:Binary";
			}
			ManifestError(Environment.GetResourceString("EventSource_UnsupportedEventTypeInManifest", type.Name), runtimeCritical: true);
			return string.Empty;
		}
	}

	private static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count)
	{
		if (stringBuilder == null)
		{
			stringBuilder = new StringBuilder();
		}
		stringBuilder.Append(eventMessage, startIndex, count);
	}

	private string TranslateToManifestConvention(string eventMessage, string evtName)
	{
		StringBuilder stringBuilder = null;
		int writtenSoFar = 0;
		int num = -1;
		int i = 0;
		while (i < eventMessage.Length)
		{
			if (eventMessage[i] == '%')
			{
				UpdateStringBuilder(ref stringBuilder, eventMessage, writtenSoFar, i - writtenSoFar);
				stringBuilder.Append("%%");
				i++;
				writtenSoFar = i;
			}
			else if (i < eventMessage.Length - 1 && ((eventMessage[i] == '{' && eventMessage[i + 1] == '{') || (eventMessage[i] == '}' && eventMessage[i + 1] == '}')))
			{
				UpdateStringBuilder(ref stringBuilder, eventMessage, writtenSoFar, i - writtenSoFar);
				stringBuilder.Append(eventMessage[i]);
				i++;
				i++;
				writtenSoFar = i;
			}
			else if (eventMessage[i] == '{')
			{
				int num2 = i;
				i++;
				int num3 = 0;
				for (; i < eventMessage.Length && char.IsDigit(eventMessage[i]); i++)
				{
					num3 = num3 * 10 + eventMessage[i] - 48;
				}
				if (i < eventMessage.Length && eventMessage[i] == '}')
				{
					i++;
					UpdateStringBuilder(ref stringBuilder, eventMessage, writtenSoFar, num2 - writtenSoFar);
					int value = TranslateIndexToManifestConvention(num3, evtName);
					stringBuilder.Append('%').Append(value);
					if (i < eventMessage.Length && eventMessage[i] == '!')
					{
						i++;
						stringBuilder.Append("%!");
					}
					writtenSoFar = i;
				}
				else
				{
					ManifestError(Environment.GetResourceString("EventSource_UnsupportedMessageProperty", evtName, eventMessage));
				}
			}
			else if ((num = "&<>'\"\r\n\t".IndexOf(eventMessage[i])) >= 0)
			{
				string[] array = new string[8] { "&amp;", "&lt;", "&gt;", "&apos;", "&quot;", "%r", "%n", "%t" };
				Action<char, string> action = delegate(char ch, string escape)
				{
					UpdateStringBuilder(ref stringBuilder, eventMessage, writtenSoFar, i - writtenSoFar);
					i++;
					stringBuilder.Append(escape);
					writtenSoFar = i;
				};
				action(eventMessage[i], array[num]);
			}
			else
			{
				i++;
			}
		}
		if (stringBuilder == null)
		{
			return eventMessage;
		}
		UpdateStringBuilder(ref stringBuilder, eventMessage, writtenSoFar, i - writtenSoFar);
		return stringBuilder.ToString();
	}

	private int TranslateIndexToManifestConvention(int idx, string evtName)
	{
		if (perEventByteArrayArgIndices.TryGetValue(evtName, out var value))
		{
			foreach (int item in value)
			{
				if (idx >= item)
				{
					idx++;
					continue;
				}
				break;
			}
		}
		return idx + 1;
	}
}
