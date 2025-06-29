using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace UnrealEngine.Runtime;

public abstract class ManagedUnrealReflectionBase
{
	public string Name { get; set; }

	public string Path { get; set; }

	public string Hash { get; set; }

	public void CreateHash()
	{
		string s = Serialize(this);
		using (SHA256 sHA = SHA256.Create())
		{
			byte[] array = sHA.ComputeHash(Encoding.UTF8.GetBytes(s));
			StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			Hash = stringBuilder.ToString();
		}
		PropertyInfo[] properties = GetType().GetProperties();
		for (int j = 0; j < properties.Length; j++)
		{
			object value = properties[j].GetValue(this);
			if (value is IList list)
			{
				for (int k = 0; k < list.Count; k++)
				{
					if (list[k] is ManagedUnrealReflectionBase managedUnrealReflectionBase)
					{
						managedUnrealReflectionBase.CreateHash();
					}
				}
			}
			if (!(value is IDictionary dictionary))
			{
				continue;
			}
			foreach (object key in dictionary.Keys)
			{
				if (key is ManagedUnrealReflectionBase managedUnrealReflectionBase2)
				{
					managedUnrealReflectionBase2.CreateHash();
				}
			}
			foreach (object value2 in dictionary.Values)
			{
				if (value2 is ManagedUnrealReflectionBase managedUnrealReflectionBase3)
				{
					managedUnrealReflectionBase3.CreateHash();
				}
			}
		}
	}

	public virtual void Serialize(BinaryWriter writer)
	{
		WriteString(writer, Hash);
		WriteString(writer, Name);
		WriteString(writer, Path);
	}

	public virtual void Deserialize(BinaryReader reader)
	{
		Hash = ReadString(reader);
		Name = ReadString(reader);
		Path = ReadString(reader);
	}

	public static string Serialize<T>(T obj) where T : ManagedUnrealReflectionBase
	{
		using MemoryStream memoryStream = new MemoryStream();
		using BinaryWriter writer = new BinaryWriter(memoryStream);
		obj.Serialize(writer);
		byte[] array = memoryStream.ToArray();
		StringBuilder stringBuilder = new StringBuilder(array.Length * 2);
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static T Deserialize<T>(string str) where T : ManagedUnrealReflectionBase, new()
	{
		try
		{
			byte[] array = new byte[str.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				int num = str[i * 2];
				int num2 = str[i * 2 + 1];
				num = (num & 0xF) + ((num & 0x40) >> 6) * 9;
				num2 = (num2 & 0xF) + ((num2 & 0x40) >> 6) * 9;
				array[i] = (byte)((num << 4) | num2);
			}
			using MemoryStream input = new MemoryStream(array);
			using BinaryReader reader = new BinaryReader(input);
			T val = new T();
			val.Deserialize(reader);
			return val;
		}
		catch
		{
			return null;
		}
	}

	protected void WriteTypeReference(BinaryWriter writer, ManagedUnrealTypeInfoReference obj)
	{
		if (obj == null)
		{
			writer.Write(value: false);
			return;
		}
		writer.Write(value: true);
		WriteEnum(writer, obj.TypeCode);
		WriteString(writer, obj.Path);
	}

	protected ManagedUnrealTypeInfoReference ReadTypeReference(BinaryReader reader)
	{
		if (reader.ReadBoolean())
		{
			return new ManagedUnrealTypeInfoReference
			{
				TypeCode = ReadEnum<EPropertyType>(reader),
				Path = ReadString(reader)
			};
		}
		return null;
	}

	protected void WriteTypeReferences(BinaryWriter writer, List<ManagedUnrealTypeInfoReference> objs)
	{
		int num = objs?.Count ?? 0;
		writer.Write(num);
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				WriteTypeReference(writer, objs[i]);
			}
		}
	}

	protected List<ManagedUnrealTypeInfoReference> ReadTypeReferences(BinaryReader reader)
	{
		List<ManagedUnrealTypeInfoReference> list = new List<ManagedUnrealTypeInfoReference>();
		int num = reader.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			ManagedUnrealTypeInfoReference managedUnrealTypeInfoReference = ReadTypeReference(reader);
			if (managedUnrealTypeInfoReference != null)
			{
				list.Add(managedUnrealTypeInfoReference);
			}
		}
		return list;
	}

	protected void WriteObjects<T>(BinaryWriter writer, List<T> objs) where T : ManagedUnrealReflectionBase
	{
		int num = objs?.Count ?? 0;
		writer.Write(num);
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				WriteObject(writer, objs[i]);
			}
		}
	}

	protected List<T> ReadObjects<T>(BinaryReader reader) where T : ManagedUnrealReflectionBase, new()
	{
		List<T> list = new List<T>();
		int num = reader.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			T val = ReadObject<T>(reader);
			if (val != null)
			{
				list.Add(val);
			}
		}
		return list;
	}

	protected void WriteStringSet(BinaryWriter writer, HashSet<string> values)
	{
		int num = values?.Count ?? 0;
		writer.Write(num);
		if (num <= 0)
		{
			return;
		}
		foreach (string value in values)
		{
			WriteString(writer, value);
		}
	}

	protected HashSet<string> ReadStringSet(BinaryReader reader)
	{
		HashSet<string> hashSet = new HashSet<string>();
		int num = reader.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			hashSet.Add(ReadString(reader));
		}
		return hashSet;
	}

	protected void WriteObject(BinaryWriter writer, ManagedUnrealReflectionBase obj)
	{
		if (obj == null)
		{
			writer.Write(value: false);
			return;
		}
		writer.Write(value: true);
		obj.Serialize(writer);
	}

	protected T ReadObject<T>(BinaryReader reader) where T : ManagedUnrealReflectionBase, new()
	{
		if (reader.ReadBoolean())
		{
			T val = new T();
			val.Deserialize(reader);
			return val;
		}
		return null;
	}

	protected void WriteEnum<T>(BinaryWriter writer, T value)
	{
		switch (GetEnumTypeCode(typeof(T)))
		{
		case TypeCode.SByte:
			writer.Write((sbyte)Convert.ChangeType(value, typeof(sbyte)));
			break;
		case TypeCode.Byte:
			writer.Write((byte)Convert.ChangeType(value, typeof(byte)));
			break;
		case TypeCode.Int16:
			writer.Write((short)Convert.ChangeType(value, typeof(short)));
			break;
		case TypeCode.UInt16:
			writer.Write((ushort)Convert.ChangeType(value, typeof(ushort)));
			break;
		case TypeCode.Int32:
			writer.Write((int)Convert.ChangeType(value, typeof(int)));
			break;
		case TypeCode.UInt32:
			writer.Write((uint)Convert.ChangeType(value, typeof(uint)));
			break;
		case TypeCode.Int64:
			writer.Write((long)Convert.ChangeType(value, typeof(long)));
			break;
		case TypeCode.UInt64:
			writer.Write((ulong)Convert.ChangeType(value, typeof(ulong)));
			break;
		default:
			throw new NotImplementedException();
		}
	}

	protected T ReadEnum<T>(BinaryReader reader)
	{
		return GetEnumTypeCode(typeof(T)) switch
		{
			TypeCode.SByte => (T)(object)reader.ReadSByte(), 
			TypeCode.Byte => (T)(object)reader.ReadByte(), 
			TypeCode.Int16 => (T)(object)reader.ReadInt16(), 
			TypeCode.UInt16 => (T)(object)reader.ReadUInt16(), 
			TypeCode.Int32 => (T)(object)reader.ReadInt32(), 
			TypeCode.UInt32 => (T)(object)reader.ReadUInt32(), 
			TypeCode.Int64 => (T)(object)reader.ReadInt64(), 
			TypeCode.UInt64 => (T)(object)reader.ReadUInt64(), 
			_ => throw new NotImplementedException(), 
		};
	}

	private TypeCode GetEnumTypeCode(Type enumType)
	{
		return Type.GetTypeCode(Enum.GetUnderlyingType(enumType));
	}

	protected void WriteString(BinaryWriter writer, string value)
	{
		writer.Write((value == null) ? string.Empty : value);
	}

	protected string ReadString(BinaryReader reader)
	{
		return reader.ReadString();
	}

	public static void GenerateSerializerCode()
	{
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		foreach (Type type in types)
		{
			if (type.IsSameOrSubclassOf(typeof(ManagedUnrealReflectionBase)))
			{
				GenerateCode(type, serializer: true);
				GenerateCode(type, serializer: false);
			}
		}
	}

	private static void CodeAppendLine(StringBuilder text, string line, string indentChars, int indent)
	{
		for (int i = 0; i < indent; i++)
		{
			text.Append(indentChars);
		}
		text.AppendLine(line);
	}

	private static string GenerateCode(Type type, bool serializer)
	{
		string indentChars = "    ";
		int num = 2;
		StringBuilder stringBuilder = new StringBuilder();
		string text = "override";
		if (type == typeof(ManagedUnrealReflectionBase))
		{
			text = "virtual";
		}
		if (serializer)
		{
			CodeAppendLine(stringBuilder, "public " + text + " void Serialize(BinaryWriter writer)", indentChars, num);
		}
		else
		{
			CodeAppendLine(stringBuilder, "public " + text + " void Deserialize(BinaryReader reader)", indentChars, num);
		}
		CodeAppendLine(stringBuilder, "{", indentChars, num);
		num++;
		if (type != typeof(ManagedUnrealReflectionBase))
		{
			if (serializer)
			{
				CodeAppendLine(stringBuilder, "base.Serialize(writer);", indentChars, num);
			}
			else
			{
				CodeAppendLine(stringBuilder, "base.Deserialize(reader);", indentChars, num);
			}
		}
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public;
		foreach (PropertyInfo item in from x in type.GetProperties(bindingAttr)
			orderby x.Name
			select x)
		{
			if (item.GetMethod == null || item.SetMethod == null || item.SetMethod.IsPrivate || item.GetMethod.IsStatic || item.GetCustomAttribute<ManagedUnrealReflectIgnoreAttribute>(inherit: false) != null)
			{
				continue;
			}
			string text2 = null;
			if (serializer)
			{
				if (item.PropertyType.IsEnum)
				{
					text2 = "WriteEnum(writer, " + item.Name + ");";
				}
				else
				{
					switch (Type.GetTypeCode(item.PropertyType))
					{
					case TypeCode.Boolean:
					case TypeCode.Char:
					case TypeCode.SByte:
					case TypeCode.Byte:
					case TypeCode.Int16:
					case TypeCode.UInt16:
					case TypeCode.Int32:
					case TypeCode.UInt32:
					case TypeCode.Int64:
					case TypeCode.UInt64:
					case TypeCode.Single:
					case TypeCode.Double:
						text2 = "writer.Write(" + item.Name + ");";
						break;
					case TypeCode.String:
						text2 = "WriteString(writer, " + item.Name + ");";
						break;
					default:
						if (item.PropertyType.IsSameOrSubclassOf(typeof(ManagedUnrealReflectionBase)))
						{
							text2 = "WriteObject(writer, " + item.Name + ");";
						}
						else if (item.PropertyType == typeof(ManagedUnrealTypeInfoReference))
						{
							text2 = "WriteTypeReference(writer, " + item.Name + ");";
						}
						else if (typeof(IList).IsAssignableFrom(item.PropertyType))
						{
							Type type2 = item.PropertyType.GetGenericArguments()[0];
							if (type2.IsSameOrSubclassOf(typeof(ManagedUnrealReflectionBase)))
							{
								text2 = "WriteObjects(writer, " + item.Name + ");";
							}
							else if (type2 == typeof(ManagedUnrealTypeInfoReference))
							{
								text2 = "WriteTypeReferences(writer, " + item.Name + ");";
							}
						}
						else if (item.PropertyType == typeof(HashSet<string>))
						{
							text2 = "WriteStringSet(writer, " + item.Name + ");";
						}
						break;
					}
				}
			}
			else if (item.PropertyType.IsEnum)
			{
				text2 = item.Name + " = ReadEnum<" + item.PropertyType.Name + ">(reader);";
			}
			else
			{
				switch (Type.GetTypeCode(item.PropertyType))
				{
				case TypeCode.Boolean:
					text2 = item.Name + " = reader.ReadBoolean();";
					break;
				case TypeCode.Char:
					text2 = item.Name + " = reader.ReadChar();";
					break;
				case TypeCode.SByte:
					text2 = item.Name + " = reader.ReadSByte();";
					break;
				case TypeCode.Byte:
					text2 = item.Name + " = reader.ReadByte();";
					break;
				case TypeCode.Int16:
					text2 = item.Name + " = reader.ReadInt16();";
					break;
				case TypeCode.UInt16:
					text2 = item.Name + " = reader.ReadUInt16();";
					break;
				case TypeCode.Int32:
					text2 = item.Name + " = reader.ReadInt32();";
					break;
				case TypeCode.UInt32:
					text2 = item.Name + " = reader.ReadUInt32();";
					break;
				case TypeCode.Int64:
					text2 = item.Name + " = reader.ReadInt64();";
					break;
				case TypeCode.UInt64:
					text2 = item.Name + " = reader.ReadUInt64();";
					break;
				case TypeCode.String:
					text2 = item.Name + " = ReadString(reader);";
					break;
				case TypeCode.Single:
					text2 = item.Name + " = reader.ReadSingle();";
					break;
				case TypeCode.Double:
					text2 = item.Name + " = reader.ReadDouble();";
					break;
				default:
					if (item.PropertyType.IsSameOrSubclassOf(typeof(ManagedUnrealReflectionBase)))
					{
						text2 = item.Name + " = ReadObject<" + item.PropertyType.Name + ">(reader);";
					}
					else if (item.PropertyType == typeof(ManagedUnrealTypeInfoReference))
					{
						text2 = item.Name + " = ReadTypeReference(reader);";
					}
					else if (typeof(IList).IsAssignableFrom(item.PropertyType))
					{
						Type type3 = item.PropertyType.GetGenericArguments()[0];
						if (type3.IsSameOrSubclassOf(typeof(ManagedUnrealReflectionBase)))
						{
							text2 = item.Name + " = ReadObjects<" + type3.Name + ">(reader);";
						}
						else if (type3 == typeof(ManagedUnrealTypeInfoReference))
						{
							text2 = item.Name + " = ReadTypeReferences(reader);";
						}
					}
					else if (item.PropertyType == typeof(HashSet<string>))
					{
						text2 = item.Name + " = ReadStringSet(reader);";
					}
					break;
				}
			}
			if (string.IsNullOrEmpty(text2))
			{
				throw new NotImplementedException("Unhandled property " + item.Name + " in " + type.FullName);
			}
			CodeAppendLine(stringBuilder, text2, indentChars, num);
		}
		num--;
		CodeAppendLine(stringBuilder, "}", indentChars, num);
		return stringBuilder.ToString();
	}

	public static void UpdateSerializerCode()
	{
		string[] array = null;
		string text = null;
		try
		{
			text = new StackTrace(fNeedFileInfo: true).GetFrame(0).GetFileName();
			if (!string.IsNullOrEmpty(text) && File.Exists(text))
			{
				string directoryName = System.IO.Path.GetDirectoryName(text);
				text = System.IO.Path.GetFileNameWithoutExtension(text) + ".Gen.cs";
				text = System.IO.Path.Combine(directoryName, text);
				if (File.Exists(text))
				{
					array = File.ReadAllLines(text);
				}
			}
		}
		catch
		{
		}
		if (array == null)
		{
			return;
		}
		Dictionary<Type, string> dictionary = new Dictionary<Type, string>();
		Dictionary<Type, string> dictionary2 = new Dictionary<Type, string>();
		string text2 = typeof(ManagedUnrealReflectionBase).Namespace;
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		foreach (Type type in types)
		{
			if (type.IsSameOrSubclassOf(typeof(ManagedUnrealReflectionBase)))
			{
				dictionary[type] = string.Empty;
				dictionary2[type] = string.Empty;
			}
		}
		int j = 0;
		while (j < array.Length)
		{
			string text3 = array[j];
			if (text3.Contains("partial class"))
			{
				int leadingWhitespaceChars = GetLeadingWhitespaceChars(text3);
				string text4 = text3;
				text4 = text4.Substring(text4.IndexOf("class") + 5);
				text4 = text4.Trim();
				text4 = text2 + "." + text4;
				Type type2 = Type.GetType(text4, throwOnError: false);
				if (type2 != null && type2.IsSameOrSubclassOf(typeof(ManagedUnrealReflectionBase)))
				{
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					for (; j < array.Length; j++)
					{
						text3 = array[j];
						if (leadingWhitespaceChars == GetLeadingWhitespaceChars(text3) && text3.Contains("}"))
						{
							break;
						}
						StringBuilder stringBuilder3 = null;
						if (text3.Contains("void Serialize(BinaryWriter"))
						{
							stringBuilder3 = stringBuilder;
						}
						else if (text3.Contains("void Deserialize(BinaryReader"))
						{
							stringBuilder3 = stringBuilder2;
						}
						if (stringBuilder3 == null)
						{
							continue;
						}
						for (; j < array.Length; j++)
						{
							stringBuilder3.AppendLine(array[j]);
							if (array[j].Contains("}"))
							{
								break;
							}
						}
					}
					dictionary[type2] = stringBuilder.ToString();
					dictionary2[type2] = stringBuilder2.ToString();
				}
				else
				{
					j++;
				}
			}
			else
			{
				j++;
			}
		}
		bool flag = false;
		Dictionary<Type, string> dictionary3 = new Dictionary<Type, string>();
		Dictionary<Type, string> dictionary4 = new Dictionary<Type, string>();
		foreach (Type key in dictionary.Keys)
		{
			string text5 = GenerateCode(key, serializer: true);
			string text6 = GenerateCode(key, serializer: false);
			dictionary3.Add(key, text5);
			dictionary4.Add(key, text6);
			bool num = text5 != dictionary[key];
			bool flag2 = text6 != dictionary2[key];
			if (num || flag2)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		StringBuilder stringBuilder4 = new StringBuilder();
		stringBuilder4.AppendLine("using System;");
		stringBuilder4.AppendLine("using System.Collections.Generic;");
		stringBuilder4.AppendLine("using System.IO;");
		stringBuilder4.AppendLine();
		stringBuilder4.AppendLine("namespace " + text2);
		stringBuilder4.AppendLine("{");
		foreach (Type key2 in dictionary.Keys)
		{
			stringBuilder4.AppendLine("    public partial class " + key2.Name);
			stringBuilder4.AppendLine("    {");
			stringBuilder4.AppendLine(dictionary3[key2]);
			stringBuilder4.Append(dictionary4[key2]);
			stringBuilder4.AppendLine("    }");
			stringBuilder4.AppendLine();
		}
		stringBuilder4.Remove(stringBuilder4.Length - Environment.NewLine.Length, Environment.NewLine.Length);
		stringBuilder4.AppendLine("}");
		File.WriteAllText(text, stringBuilder4.ToString());
		Debugger.Break();
	}

	private static int GetLeadingWhitespaceChars(string line)
	{
		int num = 0;
		for (int i = 0; i < line.Length && char.IsWhiteSpace(line[i]); i++)
		{
			num++;
		}
		return num;
	}
}
