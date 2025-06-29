using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.Utils;
using ILRuntime.Other;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;

namespace LitJson;

public class JsonMapper
{
	private static int max_nesting_depth;

	private static IFormatProvider datetime_format;

	private static IDictionary<Type, ExporterFunc> base_exporters_table;

	private static IDictionary<Type, ExporterFunc> custom_exporters_table;

	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

	private static IDictionary<Type, ArrayMetadata> array_metadata;

	private static readonly object array_metadata_lock;

	private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

	private static readonly object conv_ops_lock;

	private static IDictionary<Type, ObjectMetadata> object_metadata;

	private static readonly object object_metadata_lock;

	private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

	private static readonly object type_properties_lock;

	private static JsonWriter static_writer;

	private static readonly object static_writer_lock;

	static JsonMapper()
	{
		array_metadata_lock = new object();
		conv_ops_lock = new object();
		object_metadata_lock = new object();
		type_properties_lock = new object();
		static_writer_lock = new object();
		max_nesting_depth = 100;
		array_metadata = new Dictionary<Type, ArrayMetadata>();
		conv_ops = new Dictionary<Type, IDictionary<Type, MethodInfo>>();
		object_metadata = new Dictionary<Type, ObjectMetadata>();
		type_properties = new Dictionary<Type, IList<PropertyMetadata>>();
		static_writer = new JsonWriter();
		datetime_format = DateTimeFormatInfo.InvariantInfo;
		base_exporters_table = new Dictionary<Type, ExporterFunc>();
		custom_exporters_table = new Dictionary<Type, ExporterFunc>();
		base_importers_table = new Dictionary<Type, IDictionary<Type, ImporterFunc>>();
		custom_importers_table = new Dictionary<Type, IDictionary<Type, ImporterFunc>>();
		RegisterBaseExporters();
		RegisterBaseImporters();
	}

	private static void AddArrayMetadata(Type type)
	{
		if (array_metadata.ContainsKey(type))
		{
			return;
		}
		ArrayMetadata value = new ArrayMetadata
		{
			IsArray = type.IsArray
		};
		if (type.FullName == "LitJson.JsonData")
		{
			value.ElementType = type;
			value.IsList = true;
		}
		else
		{
			if (type.GetInterface("System.Collections.IList") != null)
			{
				value.IsList = true;
			}
			if (type is ILRuntimeWrapperType)
			{
				ILRuntimeWrapperType iLRuntimeWrapperType = (ILRuntimeWrapperType)type;
				if (value.IsArray)
				{
					value.ElementType = iLRuntimeWrapperType.CLRType.ElementType.ReflectionType;
				}
				else
				{
					value.ElementType = iLRuntimeWrapperType.CLRType.GenericArguments[0].Value.ReflectionType;
				}
			}
			else
			{
				PropertyInfo[] properties = type.GetProperties();
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (!(propertyInfo.Name != "Item"))
					{
						ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
						if (indexParameters.Length == 1 && indexParameters[0].ParameterType == typeof(int))
						{
							value.ElementType = propertyInfo.PropertyType;
						}
					}
				}
			}
		}
		lock (array_metadata_lock)
		{
			try
			{
				array_metadata.Add(type, value);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static void AddObjectMetadata(Type type)
	{
		if (object_metadata.ContainsKey(type))
		{
			return;
		}
		ObjectMetadata value = default(ObjectMetadata);
		if (type.GetInterface("System.Collections.IDictionary") != null)
		{
			value.IsDictionary = true;
		}
		value.Properties = new Dictionary<string, PropertyMetadata>();
		if (type.FullName == "LitJson.JsonData")
		{
			value.ElementType = type;
		}
		else
		{
			PropertyInfo[] properties = type.GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (Attribute.IsDefined(propertyInfo, typeof(JsonIgnoreAttribute), inherit: true))
				{
					continue;
				}
				if (propertyInfo.Name == "Item")
				{
					ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
					if (indexParameters.Length == 1 && indexParameters[0].ParameterType == typeof(string))
					{
						if (type is ILRuntimeWrapperType)
						{
							value.ElementType = ((ILRuntimeWrapperType)type).CLRType.GenericArguments[1].Value.ReflectionType;
						}
						else
						{
							value.ElementType = propertyInfo.PropertyType;
						}
					}
				}
				else
				{
					PropertyMetadata value2 = new PropertyMetadata
					{
						Info = propertyInfo,
						Type = propertyInfo.PropertyType
					};
					value.Properties.Add(propertyInfo.Name, value2);
				}
			}
			FieldInfo[] fields = type.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (!Attribute.IsDefined(fieldInfo, typeof(JsonIgnoreAttribute), inherit: true))
				{
					PropertyMetadata value3 = new PropertyMetadata
					{
						Info = fieldInfo,
						IsField = true,
						Type = fieldInfo.FieldType
					};
					value.Properties.Add(fieldInfo.Name, value3);
				}
			}
		}
		lock (object_metadata_lock)
		{
			try
			{
				object_metadata.Add(type, value);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static void AddTypeProperties(Type type)
	{
		if (type_properties.ContainsKey(type))
		{
			return;
		}
		IList<PropertyMetadata> list = new List<PropertyMetadata>();
		PropertyInfo[] properties = type.GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (!Attribute.IsDefined(propertyInfo, typeof(JsonIgnoreAttribute), inherit: true) && !(propertyInfo.Name == "Item"))
			{
				list.Add(new PropertyMetadata
				{
					Info = propertyInfo,
					IsField = false
				});
			}
		}
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (!Attribute.IsDefined(fieldInfo, typeof(JsonIgnoreAttribute), inherit: true))
			{
				list.Add(new PropertyMetadata
				{
					Info = fieldInfo,
					IsField = true
				});
			}
		}
		lock (type_properties_lock)
		{
			try
			{
				type_properties.Add(type, list);
			}
			catch (ArgumentException)
			{
			}
		}
	}

	private static MethodInfo GetConvOp(Type t1, Type t2)
	{
		lock (conv_ops_lock)
		{
			if (!conv_ops.ContainsKey(t1))
			{
				conv_ops.Add(t1, new Dictionary<Type, MethodInfo>());
			}
		}
		if (conv_ops[t1].ContainsKey(t2))
		{
			return conv_ops[t1][t2];
		}
		MethodInfo method = t1.GetMethod("op_Implicit", new Type[1] { t2 });
		lock (conv_ops_lock)
		{
			try
			{
				conv_ops[t1].Add(t2, method);
				return method;
			}
			catch (ArgumentException)
			{
				return conv_ops[t1][t2];
			}
		}
	}

	private static object ReadValue(Type inst_type, JsonReader reader)
	{
		reader.Read();
		if (reader.Token == JsonToken.ArrayEnd)
		{
			return null;
		}
		if (reader.Token == JsonToken.Null)
		{
			if (inst_type.IsClass || inst_type != null)
			{
				return null;
			}
			throw new JsonException($"Can't assign null to an instance of type {inst_type}");
		}
		if (reader.Token == JsonToken.Double || reader.Token == JsonToken.Int || reader.Token == JsonToken.Long || reader.Token == JsonToken.String || reader.Token == JsonToken.Boolean)
		{
			Type type = reader.Value.GetType();
			Type type2 = ((inst_type is ILRuntimeWrapperType) ? ((ILRuntimeWrapperType)inst_type).CLRType.TypeForCLR : inst_type);
			if (type2.IsAssignableFrom(type))
			{
				return reader.Value;
			}
			if (type2 is ILRuntimeType && ((ILRuntimeType)type2).ILType.IsEnum && (type == typeof(int) || type == typeof(long) || type == typeof(short) || type == typeof(byte)))
			{
				return reader.Value;
			}
			if (custom_importers_table.ContainsKey(type) && custom_importers_table[type].ContainsKey(type2))
			{
				return custom_importers_table[type][type2](reader.Value);
			}
			if (base_importers_table.ContainsKey(type) && base_importers_table[type].ContainsKey(type2))
			{
				return base_importers_table[type][type2](reader.Value);
			}
			if (type2.IsEnum)
			{
				return Enum.ToObject(type2, reader.Value);
			}
			MethodInfo convOp = GetConvOp(type2, type);
			if (convOp != null)
			{
				return convOp.Invoke(null, new object[1] { reader.Value });
			}
			throw new JsonException($"Can't assign value '{reader.Value}' (type {type}) to type {inst_type}");
		}
		object obj = null;
		if (reader.Token == JsonToken.ArrayStart)
		{
			AddArrayMetadata(inst_type);
			ArrayMetadata arrayMetadata = array_metadata[inst_type];
			if (!arrayMetadata.IsArray && !arrayMetadata.IsList)
			{
				throw new JsonException($"Type {inst_type} can't act as an array");
			}
			IList list;
			Type elementType;
			if (inst_type.FullName == "LitJson.JsonData")
			{
				list = new JsonData();
				elementType = arrayMetadata.ElementType;
			}
			else if (!arrayMetadata.IsArray)
			{
				list = (IList)Activator.CreateInstance(inst_type);
				elementType = arrayMetadata.ElementType;
			}
			else
			{
				list = new ArrayList();
				elementType = inst_type.GetElementType();
			}
			while (true)
			{
				object obj2 = ReadValue(elementType, reader);
				if (obj2 == null && reader.Token == JsonToken.ArrayEnd)
				{
					break;
				}
				Type pt = ((elementType is ILRuntimeWrapperType) ? ((ILRuntimeWrapperType)elementType).RealType : elementType);
				obj2 = ((!(elementType is ILRuntimeType) || !((ILRuntimeType)elementType).ILType.IsEnum) ? pt.CheckCLRTypes(obj2) : ((object)(int)obj2));
				list.Add(obj2);
			}
			if (arrayMetadata.IsArray)
			{
				int count = list.Count;
				obj = Array.CreateInstance(elementType, count);
				for (int i = 0; i < count; i++)
				{
					((Array)obj).SetValue(list[i], i);
				}
			}
			else
			{
				obj = list;
			}
		}
		else if (reader.Token == JsonToken.ObjectStart)
		{
			AddObjectMetadata(inst_type);
			ObjectMetadata objectMetadata = object_metadata[inst_type];
			obj = ((inst_type.FullName == "LitJson.JsonData") ? new JsonData() : ((!(inst_type is ILRuntimeType)) ? Activator.CreateInstance(inst_type) : ((ILRuntimeType)inst_type).ILType.Instantiate()));
			bool flag = objectMetadata.IsDictionary && inst_type.GetGenericArguments()[0] == typeof(int);
			while (true)
			{
				reader.Read();
				if (reader.Token == JsonToken.ObjectEnd)
				{
					break;
				}
				string text = (string)reader.Value;
				if (objectMetadata.Properties.ContainsKey(text))
				{
					PropertyMetadata propertyMetadata = objectMetadata.Properties[text];
					if (propertyMetadata.IsField)
					{
						((FieldInfo)propertyMetadata.Info).SetValue(obj, ReadValue(propertyMetadata.Type, reader));
						continue;
					}
					PropertyInfo propertyInfo = (PropertyInfo)propertyMetadata.Info;
					if (propertyInfo.CanWrite)
					{
						propertyInfo.SetValue(obj, ReadValue(propertyMetadata.Type, reader), null);
					}
					else
					{
						ReadValue(propertyMetadata.Type, reader);
					}
					continue;
				}
				if (!objectMetadata.IsDictionary)
				{
					if (!reader.SkipNonMembers)
					{
						throw new JsonException($"The type {inst_type} doesn't have the property '{text}'");
					}
					ReadSkip(reader);
					continue;
				}
				IDictionary dictionary = (IDictionary)obj;
				object obj3 = ReadValue(objectMetadata.ElementType, reader);
				Type pt2 = ((objectMetadata.ElementType is ILRuntimeWrapperType) ? ((ILRuntimeWrapperType)objectMetadata.ElementType).RealType : objectMetadata.ElementType);
				if (flag)
				{
					Type type3 = inst_type.GetGenericArguments()[1];
					if (!(type3 is IConvertible))
					{
						if (type3 == typeof(double))
						{
							object value = Convert.ChangeType(obj3.ToString(), type3);
							dictionary.Add(Convert.ToInt32(text), value);
						}
						else
						{
							obj3 = pt2.CheckCLRTypes(obj3);
							dictionary.Add(Convert.ToInt32(text), obj3);
						}
					}
					else
					{
						object value2 = Convert.ChangeType(obj3, type3);
						dictionary.Add(Convert.ToInt32(text), value2);
					}
				}
				else
				{
					obj3 = pt2.CheckCLRTypes(obj3);
					dictionary.Add(text, obj3);
				}
			}
		}
		return obj;
	}

	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
	{
		reader.Read();
		if (reader.Token == JsonToken.ArrayEnd || reader.Token == JsonToken.Null)
		{
			return null;
		}
		IJsonWrapper jsonWrapper = factory();
		if (reader.Token == JsonToken.String)
		{
			jsonWrapper.SetString((string)reader.Value);
			return jsonWrapper;
		}
		if (reader.Token == JsonToken.Double)
		{
			jsonWrapper.SetDouble((double)reader.Value);
			return jsonWrapper;
		}
		if (reader.Token == JsonToken.Int)
		{
			jsonWrapper.SetInt((int)reader.Value);
			return jsonWrapper;
		}
		if (reader.Token == JsonToken.Long)
		{
			jsonWrapper.SetLong((long)reader.Value);
			return jsonWrapper;
		}
		if (reader.Token == JsonToken.Boolean)
		{
			jsonWrapper.SetBoolean((bool)reader.Value);
			return jsonWrapper;
		}
		if (reader.Token == JsonToken.ArrayStart)
		{
			jsonWrapper.SetJsonType(JsonType.Array);
			while (true)
			{
				IJsonWrapper jsonWrapper2 = ReadValue(factory, reader);
				if (jsonWrapper2 == null && reader.Token == JsonToken.ArrayEnd)
				{
					break;
				}
				jsonWrapper.Add(jsonWrapper2);
			}
		}
		else if (reader.Token == JsonToken.ObjectStart)
		{
			jsonWrapper.SetJsonType(JsonType.Object);
			while (true)
			{
				reader.Read();
				if (reader.Token == JsonToken.ObjectEnd)
				{
					break;
				}
				string key = (string)reader.Value;
				jsonWrapper[key] = ReadValue(factory, reader);
			}
		}
		return jsonWrapper;
	}

	private static void ReadSkip(JsonReader reader)
	{
		ToWrapper(() => new JsonMockWrapper(), reader);
	}

	private static void RegisterBaseExporters()
	{
		base_exporters_table[typeof(byte)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write(Convert.ToInt32((byte)obj));
		};
		base_exporters_table[typeof(char)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write(Convert.ToString((char)obj));
		};
		base_exporters_table[typeof(DateTime)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write(Convert.ToString((DateTime)obj, datetime_format));
		};
		base_exporters_table[typeof(decimal)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write((decimal)obj);
		};
		base_exporters_table[typeof(sbyte)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write(Convert.ToInt32((sbyte)obj));
		};
		base_exporters_table[typeof(short)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write(Convert.ToInt32((short)obj));
		};
		base_exporters_table[typeof(ushort)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write(Convert.ToInt32((ushort)obj));
		};
		base_exporters_table[typeof(uint)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write(Convert.ToUInt64((uint)obj));
		};
		base_exporters_table[typeof(ulong)] = delegate(object obj, JsonWriter writer)
		{
			writer.Write((ulong)obj);
		};
	}

	private static void RegisterBaseImporters()
	{
		ImporterFunc importer = (object input) => Convert.ToByte((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(byte), importer);
		importer = (object input) => Convert.ToUInt64((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(ulong), importer);
		importer = (object input) => Convert.ToSByte((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(sbyte), importer);
		importer = (object input) => Convert.ToInt16((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(short), importer);
		importer = (object input) => Convert.ToInt64((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(long), importer);
		importer = (object input) => Convert.ToUInt16((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(ushort), importer);
		importer = (object input) => Convert.ToUInt32((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(uint), importer);
		importer = (object input) => Convert.ToSingle((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(float), importer);
		importer = (object input) => Convert.ToDouble((int)input);
		RegisterImporter(base_importers_table, typeof(int), typeof(double), importer);
		importer = (object input) => Convert.ToDecimal((double)input);
		RegisterImporter(base_importers_table, typeof(double), typeof(decimal), importer);
		importer = (object input) => Convert.ToUInt32((long)input);
		RegisterImporter(base_importers_table, typeof(long), typeof(uint), importer);
		importer = (object input) => Convert.ToChar((string)input);
		RegisterImporter(base_importers_table, typeof(string), typeof(char), importer);
		importer = (object input) => Convert.ToDateTime((string)input, datetime_format);
		RegisterImporter(base_importers_table, typeof(string), typeof(DateTime), importer);
	}

	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
	{
		if (!table.ContainsKey(json_type))
		{
			table.Add(json_type, new Dictionary<Type, ImporterFunc>());
		}
		table[json_type][value_type] = importer;
	}

	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
	{
		if (depth > max_nesting_depth)
		{
			throw new JsonException($"Max allowed object depth reached while trying to export from type {obj.GetType()}");
		}
		if (obj == null)
		{
			writer.Write(null);
			return;
		}
		Type type = ((obj is ILTypeInstance) ? ((ILTypeInstance)obj).Type.ReflectionType : ((!(obj is CrossBindingAdaptorType)) ? obj.GetType() : ((CrossBindingAdaptorType)obj).ILInstance.Type.ReflectionType));
		if (custom_exporters_table.ContainsKey(type))
		{
			custom_exporters_table[type](obj, writer);
			return;
		}
		if (base_exporters_table.ContainsKey(type))
		{
			base_exporters_table[type](obj, writer);
			return;
		}
		if (obj is IJsonWrapper)
		{
			if (writer_is_private)
			{
				writer.TextWriter.Write(((IJsonWrapper)obj).ToJson());
			}
			else
			{
				((IJsonWrapper)obj).ToJson(writer);
			}
			return;
		}
		if (obj is string)
		{
			writer.Write((string)obj);
			return;
		}
		if (obj is double)
		{
			writer.Write((double)obj);
			return;
		}
		if (obj is long)
		{
			writer.Write((long)obj);
			return;
		}
		if (obj is int)
		{
			writer.Write((int)obj);
			return;
		}
		if (obj is bool)
		{
			writer.Write((bool)obj);
			return;
		}
		if (obj is Array)
		{
			writer.WriteArrayStart();
			foreach (object item in (Array)obj)
			{
				WriteValue(item, writer, writer_is_private, depth + 1);
			}
			writer.WriteArrayEnd();
			return;
		}
		if (obj is IList)
		{
			writer.WriteArrayStart();
			foreach (object item2 in (IList)obj)
			{
				WriteValue(item2, writer, writer_is_private, depth + 1);
			}
			writer.WriteArrayEnd();
			return;
		}
		if (obj is IDictionary)
		{
			writer.WriteObjectStart();
			foreach (DictionaryEntry item3 in (IDictionary)obj)
			{
				writer.WritePropertyName(item3.Key.ToString());
				WriteValue(item3.Value, writer, writer_is_private, depth + 1);
			}
			writer.WriteObjectEnd();
			return;
		}
		if (obj is Enum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type);
			if (underlyingType == typeof(long))
			{
				writer.Write((long)obj);
			}
			else if (underlyingType == typeof(uint))
			{
				writer.Write((uint)obj);
			}
			else if (underlyingType == typeof(ulong))
			{
				writer.Write((ulong)obj);
			}
			else if (underlyingType == typeof(ushort))
			{
				writer.Write((ushort)obj);
			}
			else if (underlyingType == typeof(short))
			{
				writer.Write((short)obj);
			}
			else if (underlyingType == typeof(byte))
			{
				writer.Write((byte)obj);
			}
			else if (underlyingType == typeof(sbyte))
			{
				writer.Write((sbyte)obj);
			}
			else
			{
				writer.Write((int)obj);
			}
			return;
		}
		if (obj is float)
		{
			writer.Write((float)obj);
			return;
		}
		if (obj is byte)
		{
			writer.Write((byte)obj);
			return;
		}
		AddTypeProperties(type);
		IList<PropertyMetadata> list = type_properties[type];
		writer.WriteObjectStart();
		foreach (PropertyMetadata item4 in list)
		{
			if (item4.IsField)
			{
				writer.WritePropertyName(item4.Info.Name);
				WriteValue(((FieldInfo)item4.Info).GetValue(obj), writer, writer_is_private, depth + 1);
				continue;
			}
			PropertyInfo propertyInfo = (PropertyInfo)item4.Info;
			if (propertyInfo.CanRead && obj.ToString() != "Google.Protobuf.ByteString")
			{
				writer.WritePropertyName(item4.Info.Name);
				WriteValue(propertyInfo.GetValue(obj, null), writer, writer_is_private, depth + 1);
			}
		}
		writer.WriteObjectEnd();
	}

	public static string ToJson(object obj)
	{
		lock (static_writer_lock)
		{
			static_writer.Reset();
			WriteValue(obj, static_writer, writer_is_private: true, 0);
			return static_writer.ToString();
		}
	}

	public static void ToJson(object obj, JsonWriter writer)
	{
		WriteValue(obj, writer, writer_is_private: false, 0);
	}

	public static JsonData ToObject(JsonReader reader)
	{
		return (JsonData)ToWrapper(() => new JsonData(), reader);
	}

	public static JsonData ToObject(TextReader reader)
	{
		JsonReader reader2 = new JsonReader(reader);
		return (JsonData)ToWrapper(() => new JsonData(), reader2);
	}

	public static JsonData ToObject(string json)
	{
		return (JsonData)ToWrapper(() => new JsonData(), json);
	}

	public static T ToObject<T>(JsonReader reader)
	{
		return (T)ReadValue(typeof(T), reader);
	}

	public static T ToObject<T>(TextReader reader)
	{
		JsonReader reader2 = new JsonReader(reader);
		return (T)ReadValue(typeof(T), reader2);
	}

	public static T ToObject<T>(string json)
	{
		JsonReader reader = new JsonReader(json);
		return (T)ReadValue(typeof(T), reader);
	}

	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
	{
		return ReadValue(factory, reader);
	}

	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
	{
		JsonReader reader = new JsonReader(json);
		return ReadValue(factory, reader);
	}

	public static void RegisterExporter<T>(ExporterFunc<T> exporter)
	{
		ExporterFunc value = delegate(object obj, JsonWriter writer)
		{
			exporter((T)obj, writer);
		};
		custom_exporters_table[typeof(T)] = value;
	}

	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
	{
		ImporterFunc importer2 = (object input) => importer((TJson)input);
		RegisterImporter(custom_importers_table, typeof(TJson), typeof(TValue), importer2);
	}

	public static void UnregisterExporters()
	{
		custom_exporters_table.Clear();
	}

	public static void UnregisterImporters()
	{
		custom_importers_table.Clear();
	}

	public unsafe static void RegisterILRuntimeCLRRedirection(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		MethodInfo[] methods = typeof(JsonMapper).GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name == "ToObject" && methodInfo.IsGenericMethodDefinition)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				if (parameters[0].ParameterType == typeof(string))
				{
					appdomain.RegisterCLRMethodRedirection(methodInfo, JsonToObject);
				}
				else if (parameters[0].ParameterType == typeof(JsonReader))
				{
					appdomain.RegisterCLRMethodRedirection(methodInfo, JsonToObject2);
				}
				else if (parameters[0].ParameterType == typeof(TextReader))
				{
					appdomain.RegisterCLRMethodRedirection(methodInfo, JsonToObject3);
				}
			}
		}
	}

	public unsafe static StackObject* JsonToObject(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		ILRuntime.Runtime.Enviorment.AppDomain appDomain = intp.AppDomain;
		StackObject* esp2 = ILIntepreter.Minus(esp, 1);
		StackObject* esp3 = ILIntepreter.Minus(esp, 1);
		string json_text = (string)typeof(string).CheckCLRTypes(StackObject.ToObject(esp3, appDomain, mStack));
		intp.Free(esp3);
		object obj = ReadValue(method.GenericArguments[0].ReflectionType, new JsonReader(json_text));
		return ILIntepreter.PushObject(esp2, mStack, obj);
	}

	public unsafe static StackObject* JsonToObject2(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		ILRuntime.Runtime.Enviorment.AppDomain appDomain = intp.AppDomain;
		StackObject* esp2 = ILIntepreter.Minus(esp, 1);
		StackObject* esp3 = ILIntepreter.Minus(esp, 1);
		JsonReader reader = (JsonReader)typeof(JsonReader).CheckCLRTypes(StackObject.ToObject(esp3, appDomain, mStack));
		intp.Free(esp3);
		object obj = ReadValue(method.GenericArguments[0].ReflectionType, reader);
		return ILIntepreter.PushObject(esp2, mStack, obj);
	}

	public unsafe static StackObject* JsonToObject3(ILIntepreter intp, StackObject* esp, UncheckedList<object> mStack, CLRMethod method, bool isNewObj)
	{
		ILRuntime.Runtime.Enviorment.AppDomain appDomain = intp.AppDomain;
		StackObject* esp2 = ILIntepreter.Minus(esp, 1);
		StackObject* esp3 = ILIntepreter.Minus(esp, 1);
		TextReader reader = (TextReader)typeof(TextReader).CheckCLRTypes(StackObject.ToObject(esp3, appDomain, mStack));
		intp.Free(esp3);
		object obj = ReadValue(method.GenericArguments[0].ReflectionType, new JsonReader(reader));
		return ILIntepreter.PushObject(esp2, mStack, obj);
	}
}
