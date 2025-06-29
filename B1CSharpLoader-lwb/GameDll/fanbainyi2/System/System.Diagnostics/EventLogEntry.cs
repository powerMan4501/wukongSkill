using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.Win32;

namespace System.Diagnostics;

[Serializable]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
public sealed class EventLogEntry : Component, ISerializable
{
	private static class FieldOffsets
	{
		internal const int LENGTH = 0;

		internal const int RESERVED = 4;

		internal const int RECORDNUMBER = 8;

		internal const int TIMEGENERATED = 12;

		internal const int TIMEWRITTEN = 16;

		internal const int EVENTID = 20;

		internal const int EVENTTYPE = 24;

		internal const int NUMSTRINGS = 26;

		internal const int EVENTCATEGORY = 28;

		internal const int RESERVEDFLAGS = 30;

		internal const int CLOSINGRECORDNUMBER = 32;

		internal const int STRINGOFFSET = 36;

		internal const int USERSIDLENGTH = 40;

		internal const int USERSIDOFFSET = 44;

		internal const int DATALENGTH = 48;

		internal const int DATAOFFSET = 52;

		internal const int RAWDATA = 56;
	}

	internal byte[] dataBuf;

	internal int bufOffset;

	private EventLogInternal owner;

	private string category;

	private string message;

	private static readonly DateTime beginningOfTime = new DateTime(1970, 1, 1, 0, 0, 0);

	private const int OFFSETFIXUP = 56;

	[MonitoringDescription("LogEntryMachineName")]
	public string MachineName
	{
		get
		{
			int i;
			for (i = bufOffset + 56; CharFrom(dataBuf, i) != 0; i += 2)
			{
			}
			i += 2;
			char c = CharFrom(dataBuf, i);
			StringBuilder stringBuilder = new StringBuilder();
			while (c != 0)
			{
				stringBuilder.Append(c);
				i += 2;
				c = CharFrom(dataBuf, i);
			}
			return stringBuilder.ToString();
		}
	}

	[MonitoringDescription("LogEntryData")]
	public byte[] Data
	{
		get
		{
			int num = IntFrom(dataBuf, bufOffset + 48);
			byte[] array = new byte[num];
			Array.Copy(dataBuf, bufOffset + IntFrom(dataBuf, bufOffset + 52), array, 0, num);
			return array;
		}
	}

	[MonitoringDescription("LogEntryIndex")]
	public int Index => IntFrom(dataBuf, bufOffset + 8);

	[MonitoringDescription("LogEntryCategory")]
	public string Category
	{
		get
		{
			if (category == null)
			{
				string messageLibraryNames = GetMessageLibraryNames("CategoryMessageFile");
				string text = owner.FormatMessageWrapper(messageLibraryNames, (uint)CategoryNumber, null);
				if (text == null)
				{
					category = "(" + CategoryNumber.ToString(CultureInfo.CurrentCulture) + ")";
				}
				else
				{
					category = text;
				}
			}
			return category;
		}
	}

	[MonitoringDescription("LogEntryCategoryNumber")]
	public short CategoryNumber => ShortFrom(dataBuf, bufOffset + 28);

	[MonitoringDescription("LogEntryEventID")]
	[Obsolete("This property has been deprecated.  Please use System.Diagnostics.EventLogEntry.InstanceId instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public int EventID => IntFrom(dataBuf, bufOffset + 20) & 0x3FFFFFFF;

	[MonitoringDescription("LogEntryEntryType")]
	public EventLogEntryType EntryType => (EventLogEntryType)ShortFrom(dataBuf, bufOffset + 24);

	[MonitoringDescription("LogEntryMessage")]
	[Editor("System.ComponentModel.Design.BinaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Message
	{
		get
		{
			if (message == null)
			{
				string messageLibraryNames = GetMessageLibraryNames("EventMessageFile");
				int num = IntFrom(dataBuf, bufOffset + 20);
				string text = owner.FormatMessageWrapper(messageLibraryNames, (uint)num, ReplacementStrings);
				if (text == null)
				{
					StringBuilder stringBuilder = new StringBuilder(SR.GetString("MessageNotFormatted", num, Source));
					string[] replacementStrings = ReplacementStrings;
					for (int i = 0; i < replacementStrings.Length; i++)
					{
						if (i != 0)
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append("'");
						stringBuilder.Append(replacementStrings[i]);
						stringBuilder.Append("'");
					}
					text = stringBuilder.ToString();
				}
				else
				{
					text = ReplaceMessageParameters(text, ReplacementStrings);
				}
				message = text;
			}
			return message;
		}
	}

	[MonitoringDescription("LogEntrySource")]
	public string Source
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = bufOffset + 56;
			for (char c = CharFrom(dataBuf, num); c != 0; c = CharFrom(dataBuf, num))
			{
				stringBuilder.Append(c);
				num += 2;
			}
			return stringBuilder.ToString();
		}
	}

	[MonitoringDescription("LogEntryReplacementStrings")]
	public string[] ReplacementStrings
	{
		get
		{
			string[] array = new string[ShortFrom(dataBuf, bufOffset + 26)];
			int num = 0;
			int num2 = bufOffset + IntFrom(dataBuf, bufOffset + 36);
			StringBuilder stringBuilder = new StringBuilder();
			while (num < array.Length)
			{
				char c = CharFrom(dataBuf, num2);
				if (c != 0)
				{
					stringBuilder.Append(c);
				}
				else
				{
					array[num] = stringBuilder.ToString();
					num++;
					stringBuilder = new StringBuilder();
				}
				num2 += 2;
			}
			return array;
		}
	}

	[MonitoringDescription("LogEntryResourceId")]
	[ComVisible(false)]
	public long InstanceId => (uint)IntFrom(dataBuf, bufOffset + 20);

	[MonitoringDescription("LogEntryTimeGenerated")]
	public DateTime TimeGenerated => beginningOfTime.AddSeconds(IntFrom(dataBuf, bufOffset + 12)).ToLocalTime();

	[MonitoringDescription("LogEntryTimeWritten")]
	public DateTime TimeWritten => beginningOfTime.AddSeconds(IntFrom(dataBuf, bufOffset + 16)).ToLocalTime();

	[MonitoringDescription("LogEntryUserName")]
	public string UserName
	{
		get
		{
			int num = IntFrom(dataBuf, bufOffset + 40);
			if (num == 0)
			{
				return null;
			}
			byte[] array = new byte[num];
			Array.Copy(dataBuf, bufOffset + IntFrom(dataBuf, bufOffset + 44), array, 0, array.Length);
			int userNameSize = 256;
			int domainNameSize = 256;
			int eUse = 0;
			StringBuilder stringBuilder = new StringBuilder(userNameSize);
			StringBuilder stringBuilder2 = new StringBuilder(domainNameSize);
			StringBuilder stringBuilder3 = new StringBuilder();
			if (Microsoft.Win32.UnsafeNativeMethods.LookupAccountSid(MachineName, array, stringBuilder, ref userNameSize, stringBuilder2, ref domainNameSize, ref eUse) != 0)
			{
				stringBuilder3.Append(stringBuilder2.ToString());
				stringBuilder3.Append("\\");
				stringBuilder3.Append(stringBuilder.ToString());
			}
			return stringBuilder3.ToString();
		}
	}

	internal EventLogEntry(byte[] buf, int offset, EventLogInternal log)
	{
		dataBuf = buf;
		bufOffset = offset;
		owner = log;
		GC.SuppressFinalize(this);
	}

	private EventLogEntry(SerializationInfo info, StreamingContext context)
	{
		dataBuf = (byte[])info.GetValue("DataBuffer", typeof(byte[]));
		string logName = info.GetString("LogName");
		string machineName = info.GetString("MachineName");
		owner = new EventLogInternal(logName, machineName, "");
		GC.SuppressFinalize(this);
	}

	private char CharFrom(byte[] buf, int offset)
	{
		return (char)ShortFrom(buf, offset);
	}

	public bool Equals(EventLogEntry otherEntry)
	{
		if (otherEntry == null)
		{
			return false;
		}
		int num = IntFrom(dataBuf, bufOffset);
		int num2 = IntFrom(otherEntry.dataBuf, otherEntry.bufOffset);
		if (num != num2)
		{
			return false;
		}
		int num3 = bufOffset;
		int num4 = bufOffset + num;
		int num5 = otherEntry.bufOffset;
		int num6 = num3;
		while (num6 < num4)
		{
			if (dataBuf[num6] != otherEntry.dataBuf[num5])
			{
				return false;
			}
			num6++;
			num5++;
		}
		return true;
	}

	private int IntFrom(byte[] buf, int offset)
	{
		return (-16777216 & (buf[offset + 3] << 24)) | (0xFF0000 & (buf[offset + 2] << 16)) | (0xFF00 & (buf[offset + 1] << 8)) | (0xFF & buf[offset]);
	}

	internal string ReplaceMessageParameters(string msg, string[] insertionStrings)
	{
		int num = msg.IndexOf('%');
		if (num < 0)
		{
			return msg;
		}
		int num2 = 0;
		int length = msg.Length;
		StringBuilder stringBuilder = new StringBuilder();
		string messageLibraryNames = GetMessageLibraryNames("ParameterMessageFile");
		while (num >= 0)
		{
			string text = null;
			int i;
			for (i = num + 1; i < length && char.IsDigit(msg, i); i++)
			{
			}
			uint result = 0u;
			if (i != num + 1)
			{
				uint.TryParse(msg.Substring(num + 1, i - num - 1), out result);
			}
			if (result != 0)
			{
				text = owner.FormatMessageWrapper(messageLibraryNames, result, insertionStrings);
			}
			if (text != null)
			{
				if (num > num2)
				{
					stringBuilder.Append(msg, num2, num - num2);
				}
				stringBuilder.Append(text);
				num2 = i;
			}
			num = msg.IndexOf('%', num + 1);
		}
		if (length - num2 > 0)
		{
			stringBuilder.Append(msg, num2, length - num2);
		}
		return stringBuilder.ToString();
	}

	private static RegistryKey GetSourceRegKey(string logName, string source, string machineName)
	{
		RegistryKey registryKey = null;
		RegistryKey registryKey2 = null;
		try
		{
			registryKey = EventLog.GetEventLogRegKey(machineName, writable: false);
			if (registryKey == null)
			{
				return null;
			}
			registryKey2 = ((logName != null) ? registryKey.OpenSubKey(logName, writable: false) : registryKey.OpenSubKey("Application", writable: false));
			return registryKey2?.OpenSubKey(source, writable: false);
		}
		finally
		{
			registryKey?.Close();
			registryKey2?.Close();
		}
	}

	private string GetMessageLibraryNames(string libRegKey)
	{
		string text = null;
		RegistryKey registryKey = null;
		try
		{
			registryKey = GetSourceRegKey(owner.Log, Source, owner.MachineName);
			if (registryKey != null)
			{
				text = (string)registryKey.GetValue(libRegKey);
			}
		}
		finally
		{
			registryKey?.Close();
		}
		if (text == null)
		{
			return null;
		}
		if (owner.MachineName != ".")
		{
			string[] array = text.Split(';');
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Length >= 2 && array[i][1] == ':')
				{
					stringBuilder.Append("\\\\");
					stringBuilder.Append(owner.MachineName);
					stringBuilder.Append("\\");
					stringBuilder.Append(array[i][0]);
					stringBuilder.Append("$");
					stringBuilder.Append(array[i], 2, array[i].Length - 2);
					stringBuilder.Append(';');
				}
			}
			if (stringBuilder.Length == 0)
			{
				return null;
			}
			return stringBuilder.ToString(0, stringBuilder.Length - 1);
		}
		return text;
	}

	private short ShortFrom(byte[] buf, int offset)
	{
		return (short)((0xFF00 & (buf[offset + 1] << 8)) | (0xFF & buf[offset]));
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = IntFrom(dataBuf, bufOffset);
		byte[] array = new byte[num];
		Array.Copy(dataBuf, bufOffset, array, 0, num);
		info.AddValue("DataBuffer", array, typeof(byte[]));
		info.AddValue("LogName", owner.Log);
		info.AddValue("MachineName", owner.MachineName);
	}
}
