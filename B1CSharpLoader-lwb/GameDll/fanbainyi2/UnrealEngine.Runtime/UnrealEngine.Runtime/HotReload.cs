using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace UnrealEngine.Runtime;

public static class HotReload
{
	public static class Timing
	{
		public class Element : IDisposable
		{
			private Stopwatch stopwatch;

			public TimeSpan Time => stopwatch.Elapsed;

			public TimeSpan TotalTimeStart { get; private set; }

			public TimeSpan TotalTimeEnd { get; private set; }

			public string Name { get; private set; }

			public Element Parent { get; private set; }

			public List<Element> Children { get; private set; }

			public bool IsRoot => Parent == null;

			public Element(string name)
			{
				if (totalElapsedStopwatch == null)
				{
					totalElapsedStopwatch = new Stopwatch();
					totalElapsedStopwatch.Start();
				}
				TotalTimeStart = totalElapsedStopwatch.Elapsed;
				Name = name;
				stopwatch = new Stopwatch();
				stopwatch.Start();
				Children = new List<Element>();
				Parent = currentElement;
				if (Parent != null)
				{
					Parent.Children.Add(this);
				}
				currentElement = this;
				depth++;
			}

			public void Dispose()
			{
				stopwatch.Stop();
				TotalTimeEnd = totalElapsedStopwatch.Elapsed;
				depth--;
				currentElement = Parent;
			}
		}

		private static Dictionary<string, Element> elements = new Dictionary<string, Element>();

		public const string TotalLoadTime = "TotalLoadTime";

		public const string DataStore_Load = "HotReload.DataStore.Load";

		public const string NativeFunctions_LoadAssemblies = "NativeFunctions.LoadAssemblies";

		public const string Classes_OnNativeFunctionsRegistered = "Classes.OnNativeFunctionsRegistered";

		public const string UnrealTypes_Load = "UnrealTypes.Load";

		public const string UnrealTypes_LoadNative = "UnrealTypes.LoadNative";

		public const string UClass_Load = "UClass.Load";

		public const string UObject_CollectGarbage = "UObject.CollectGarbage";

		public const string GC_Collect = "GC.Collect";

		public const string ManagedUnrealModuleInfo_Load = "ManagedUnrealModuleInfo.Load";

		public const string ManagedUnrealTypes_Load = "ManagedUnrealTypes.Load";

		public const string ManagedUnrealTypes_ReinstanceClasses = "ManagedUnrealTypes.ReinstanceClasses";

		public const string HotReload_OnReload = "HotReload.OnReload";

		public const string SharpHotReloadUtils_BroadcastOnHotReload = "SharpHotReloadUtils.BroadcastOnHotReload";

		public const string SharpHotReloadUtils_PreUpdateStructs = "SharpHotReloadUtils.PreUpdateStructs";

		public const string SharpHotReloadUtils_PostUpdateStructs = "SharpHotReloadUtils.PostUpdateStructs";

		public const string SharpHotReloadUtils_FinalizeClasses = "SharpHotReloadUtils.FinalizeClasses";

		public const string SharpHotReloadUtils_UpdateEnum = "SharpHotReloadUtils.UpdateEnum";

		public const string BuildEnum = "BuildTypes.BuildEnum";

		public const string BuildStructs = "BuildTypes.BuildStructs";

		public const string BuildOthers = "BuildTypes.BuildOthers";

		private static Stopwatch totalElapsedStopwatch;

		private static Element currentElement;

		private static int depth = 0;

		public static void Print(bool isReload)
		{
			elements.TryGetValue("TotalLoadTime", out var _);
		}

		public static void PrintAll()
		{
			if (!elements.TryGetValue("TotalLoadTime", out var _))
			{
				return;
			}
			foreach (KeyValuePair<string, Element> element in elements)
			{
				if (element.Value.IsRoot)
				{
					PrintRecursive(element.Value, 0);
				}
			}
		}

		private static void PrintRecursive(Element element, int indent)
		{
			int indent2 = indent + 2;
			foreach (Element child in element.Children)
			{
				PrintRecursive(child, indent2);
			}
		}

		public static Element Create(string name)
		{
			return null;
		}
	}

	public class DataStore
	{
		private Dictionary<string, DataItem.Info> values = new Dictionary<string, DataItem.Info>();

		internal BinaryReader reader;

		internal BinaryWriter writer;

		internal DateTime BeginUnloadTime;

		internal void Close()
		{
			if (reader != null)
			{
				reader.Close();
				reader = null;
			}
			if (writer != null)
			{
				writer.Close();
				writer = null;
			}
			values.Clear();
		}

		public byte[] Save()
		{
			byte[] result = null;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
				writer = binaryWriter;
				binaryWriter.Write(BeginUnloadTime.Ticks);
				binaryWriter.Write(values.Count);
				foreach (KeyValuePair<string, DataItem.Info> value in values)
				{
					binaryWriter.Write((value.Key == null) ? string.Empty : value.Key);
					long position = binaryWriter.BaseStream.Position;
					binaryWriter.Write(0L);
					binaryWriter.Write(0L);
					long position2 = binaryWriter.BaseStream.Position;
					value.Value.Data.Save();
					long position3 = binaryWriter.BaseStream.Position;
					binaryWriter.BaseStream.Position = position;
					binaryWriter.Write(position2);
					binaryWriter.Write(position3);
					binaryWriter.BaseStream.Position = position3;
				}
				result = memoryStream.GetBuffer();
			}
			writer = null;
			return result;
		}

		public static DataStore Load(byte[] buffer)
		{
			DataStore dataStore = new DataStore();
			if (buffer != null && buffer.Length >= 12)
			{
				BinaryReader binaryReader = (dataStore.reader = new BinaryReader(new MemoryStream(buffer)));
				dataStore.BeginUnloadTime = new DateTime(binaryReader.ReadInt64());
				int num = binaryReader.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					string key = binaryReader.ReadString();
					long startOffset = binaryReader.ReadInt64();
					long num2 = binaryReader.ReadInt64();
					DataItem.Info info = new DataItem.Info();
					info.StartOffset = startOffset;
					info.EndOffset = num2;
					dataStore.values.Add(key, info);
					binaryReader.BaseStream.Position = num2;
				}
			}
			return dataStore;
		}

		public T Create<T>() where T : DataItem, new()
		{
			T val = new T();
			Add(val);
			return val;
		}

		public void Add<T>(T value) where T : DataItem
		{
			string assemblyQualifiedName = typeof(T).AssemblyQualifiedName;
			if (string.IsNullOrEmpty(assemblyQualifiedName))
			{
				return;
			}
			try
			{
				DataItem.Info info = new DataItem.Info();
				info.Data = value;
				value.info = info;
				value.DataStore = this;
				values.Add(assemblyQualifiedName, info);
			}
			catch (ArgumentException)
			{
				FMessage.Log(ELogVerbosity.Error, "HotReload item with the same type has already been added. Type: " + typeof(T).FullName);
			}
		}

		public T Get<T>() where T : DataItem, new()
		{
			if (values.TryGetValue(typeof(T).AssemblyQualifiedName, out var value))
			{
				if (value.Data == null)
				{
					value.Data = new T();
					value.Data.DataStore = this;
					value.Data.info = value;
					if (reader != null && value.StartOffset > 0)
					{
						reader.BaseStream.Position = value.StartOffset;
						value.Data.Load();
					}
				}
				return value.Data as T;
			}
			return null;
		}

		public T GetOrCreate<T>() where T : DataItem, new()
		{
			T val = Get<T>();
			if (val == null)
			{
				val = Create<T>();
			}
			return val;
		}
	}

	public abstract class DataItem
	{
		internal class Info
		{
			public long StartOffset;

			public long EndOffset;

			public DataItem Data;
		}

		private static Encoding encoding = Encoding.Unicode;

		internal Info info;

		public DataStore DataStore { get; internal set; }

		private BinaryReader reader => DataStore.reader;

		private BinaryWriter writer => DataStore.writer;

		public abstract void Load();

		public abstract void Save();

		private bool CanRead(int count)
		{
			if (reader.BaseStream.Position >= info.StartOffset)
			{
				return reader.BaseStream.Position < info.EndOffset;
			}
			return false;
		}

		protected bool ReadBool()
		{
			if (!CanRead(1))
			{
				return false;
			}
			return reader.ReadByte() != 0;
		}

		protected sbyte ReadSByte()
		{
			if (!CanRead(1))
			{
				return 0;
			}
			return reader.ReadSByte();
		}

		protected byte ReadByte()
		{
			if (!CanRead(1))
			{
				return 0;
			}
			return reader.ReadByte();
		}

		protected short ReadInt16()
		{
			if (!CanRead(2))
			{
				return 0;
			}
			return reader.ReadInt16();
		}

		protected ushort ReadUInt16()
		{
			if (!CanRead(2))
			{
				return 0;
			}
			return reader.ReadUInt16();
		}

		protected int ReadInt32()
		{
			if (!CanRead(4))
			{
				return 0;
			}
			return reader.ReadInt32();
		}

		protected uint ReadUInt32()
		{
			if (!CanRead(4))
			{
				return 0u;
			}
			return reader.ReadUInt32();
		}

		protected long ReadInt64()
		{
			if (!CanRead(8))
			{
				return 0L;
			}
			return reader.ReadInt64();
		}

		protected ulong ReadUInt64()
		{
			if (!CanRead(8))
			{
				return 0uL;
			}
			return reader.ReadUInt64();
		}

		protected string ReadString()
		{
			if (CanRead(2))
			{
				byte[] array = ReadBytes(ReadUInt16());
				if (array != null)
				{
					return encoding.GetString(array);
				}
			}
			return string.Empty;
		}

		protected DateTime ReadDateTime()
		{
			if (!CanRead(8))
			{
				return default(DateTime);
			}
			return new DateTime(ReadInt64());
		}

		protected TimeSpan ReadTimeSpan()
		{
			if (!CanRead(8))
			{
				return default(TimeSpan);
			}
			return new TimeSpan(ReadInt64());
		}

		protected float ReadSingle()
		{
			if (!CanRead(4))
			{
				return 0f;
			}
			return reader.ReadSingle();
		}

		protected double ReadDouble()
		{
			if (!CanRead(8))
			{
				return 0.0;
			}
			return reader.ReadDouble();
		}

		protected decimal ReadDecimal()
		{
			if (!CanRead(16))
			{
				return 0m;
			}
			return reader.ReadDecimal();
		}

		protected byte[] ReadBytes(int count)
		{
			if (CanRead(count))
			{
				return reader.ReadBytes(count);
			}
			return null;
		}

		protected byte[] ReadBuffer()
		{
			int count = ReadInt32();
			if (CanRead(count))
			{
				return ReadBytes(count);
			}
			return null;
		}

		protected void WriteBool(bool value)
		{
			writer.Write(value);
		}

		protected void WriteSByte(sbyte value)
		{
			writer.Write(value);
		}

		protected void WriteByte(sbyte value)
		{
			writer.Write(value);
		}

		protected void WriteInt16(short value)
		{
			writer.Write(value);
		}

		protected void WriteUInt16(ushort value)
		{
			writer.Write(value);
		}

		protected void WriteInt32(int value)
		{
			writer.Write(value);
		}

		protected void WriteUInt32(uint value)
		{
			writer.Write(value);
		}

		protected void WriteInt64(long value)
		{
			writer.Write(value);
		}

		protected void WriteUInt64(ulong value)
		{
			writer.Write(value);
		}

		protected void WriteString(string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			byte[] bytes = encoding.GetBytes(value);
			WriteUInt16((ushort)bytes.Length);
			WriteBytes(bytes);
		}

		protected void WriteDateTime(DateTime value)
		{
			WriteInt64(value.Ticks);
		}

		protected void WriteTimeSpan(TimeSpan value)
		{
			WriteInt64(value.Ticks);
		}

		protected void WriteSingle(float value)
		{
			writer.Write(value);
		}

		protected void WriteDouble(double value)
		{
			writer.Write(value);
		}

		protected void WriteDecimal(decimal value)
		{
			writer.Write(value);
		}

		protected void WriteBytes(byte[] buffer)
		{
			writer.Write(buffer);
		}

		protected void WriteBuffer(byte[] buffer)
		{
			if (buffer != null)
			{
				WriteInt32(buffer.Length);
				WriteBytes(buffer);
			}
			else
			{
				WriteInt32(0);
			}
		}
	}

	private static List<Type> nativeDelegateManagers = new List<Type>();

	public static bool MinimalReload { get; internal set; }

	public static DataStore Data { get; internal set; }

	public static bool IsUnloading { get; private set; }

	public static bool IsUnloaded { get; private set; }

	public static bool IsReloading { get; set; }

	public static event HotReloadUnloadBegin UnloadBegin;

	public static event HotReloadUnloadEnd UnloadEnd;

	public static event HotReloadPreReloadBegin PreReloadBegin;

	public static event HotReloadPreReloadEnd PreReloadEnd;

	public static event HotReloadReloadBegin ReloadBegin;

	public static event HotReloadReloadBegin ReloadEnd;

	internal static void OnUnload()
	{
		Data = new DataStore();
		IsUnloading = true;
		try
		{
			if (HotReload.UnloadBegin != null)
			{
				HotReload.UnloadBegin();
			}
		}
		catch (Exception ex)
		{
			FMessage.Log(ELogVerbosity.Error, "HotReload.UnloadBegin failed. Exception: " + Environment.NewLine + ex);
		}
		StaticVarManager.OnUnload();
		EngineLoop.OnUnload();
		FThreading.OnUnload();
		FTicker.OnUnload();
		IConsoleManager.OnUnload();
		ManagedUnrealTypes.OnUnload();
		GCHelper.OnUnload();
		UnbindNativeDelegates();
		IsUnloaded = true;
		try
		{
			if (HotReload.UnloadEnd != null)
			{
				HotReload.UnloadEnd();
			}
		}
		catch (Exception ex2)
		{
			FMessage.Log(ELogVerbosity.Error, "HotReload.UnloadEnd failed. Exception: " + Environment.NewLine + ex2);
		}
	}

	internal static void OnPreReloadBegin()
	{
		try
		{
			if (HotReload.PreReloadBegin != null)
			{
				HotReload.PreReloadBegin();
			}
		}
		catch (Exception ex)
		{
			FMessage.Log(ELogVerbosity.Error, "HotReload.PreReloadBegin failed. Exception: " + Environment.NewLine + ex);
		}
	}

	internal static void OnPreReloadEnd()
	{
		try
		{
			if (HotReload.PreReloadEnd != null)
			{
				HotReload.PreReloadEnd();
			}
		}
		catch (Exception ex)
		{
			FMessage.Log(ELogVerbosity.Error, "HotReload.PreReloadEnd failed. Exception: " + Environment.NewLine + ex);
		}
	}

	internal static void OnReload()
	{
		EngineLoop.OnReload();
		GCHelper.OnReload();
		try
		{
			if (HotReload.ReloadBegin != null)
			{
				HotReload.ReloadBegin();
			}
		}
		catch (Exception ex)
		{
			FMessage.Log(ELogVerbosity.Error, "HotReload.ReloadBegin failed. Exception: " + Environment.NewLine + ex);
		}
		try
		{
			if (HotReload.ReloadEnd != null)
			{
				HotReload.ReloadEnd();
			}
		}
		catch (Exception ex2)
		{
			FMessage.Log(ELogVerbosity.Error, "HotReload.ReloadEnd failed. Exception: " + Environment.NewLine + ex2);
		}
		Data = null;
		IsReloading = false;
	}

	public static void RegisterNativeDelegateManager(Type type)
	{
		nativeDelegateManagers.Add(type);
	}

	internal static void UnbindNativeDelegates()
	{
		foreach (Type nativeDelegateManager in nativeDelegateManagers)
		{
			FieldInfo[] fields = nativeDelegateManager.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (typeof(INativeDelegate).IsAssignableFrom(fieldInfo.FieldType) && fieldInfo.GetValue(null) is INativeDelegate nativeDelegate)
				{
					nativeDelegate.OnUnload();
					fieldInfo.SetValue(null, null);
				}
			}
		}
	}
}
