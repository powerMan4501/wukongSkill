using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace BossRushV4;

public static class Utils
{
	public static T GetFieldOrPropertyValue<T>(string fieldName, object instance, BindingFlags flags)
	{
		Type type = instance.GetType();
		return (T)GetFieldOrPropertyValue(type, fieldName, instance, flags);
	}

	public static object GetFieldOrPropertyValue(Type type, string fieldName, object instance, BindingFlags flags)
	{
		FieldInfo field = type.GetField(fieldName, flags);
		if (field != null)
		{
			return field.GetValue(instance);
		}
		PropertyInfo property = type.GetProperty(fieldName, flags);
		if (property != null)
		{
			return property.GetValue(instance);
		}
		return null;
	}

	public static void SetFieldOrPropertyValue<T>(string fieldName, object instance, BindingFlags flags, object value)
	{
		Type type = instance.GetType();
		SetFieldOrPropertyValue(type, fieldName, instance, flags, value);
	}

	public static void SetFieldOrPropertyValue(Type type, string fieldName, object instance, BindingFlags flags, object value)
	{
		FieldInfo field = type.GetField(fieldName, flags);
		if (field != null)
		{
			field.SetValue(instance, value);
			return;
		}
		PropertyInfo property = type.GetProperty(fieldName, flags);
		if (property != null)
		{
			property.SetValue(instance, value);
		}
	}

	public static object InvokeMethod(Type type, object instance, string methodName, object[] paramsArray, BindingFlags flags)
	{
		MethodInfo method = type.GetMethod(methodName, flags);
		if (method != null)
		{
			return method.Invoke(instance, paramsArray);
		}
		return null;
	}

	public static object InvokeMethod(Type type, object instance, string methodName, object[] paramsArray, BindingFlags flags, Type[] paramTypes)
	{
		MethodInfo method = type.GetMethod(methodName, flags, null, paramTypes, null);
		if (method != null)
		{
			return method.Invoke(instance, paramsArray);
		}
		return null;
	}

	public static T LoadConfig<T>()
	{
		string name = typeof(T).Name;
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(baseDirectory, "CSharpLoader\\Mods\\" + BossRushV4.Instance.Name + "\\" + name + ".data");
		if (!File.Exists(text))
		{
			Console.WriteLine(" Data Not Found " + text);
			text = Path.Combine(baseDirectory, "CSharpLoader\\Mods\\" + BossRushV4.Instance.Name + "\\" + name + ".json");
			if (!File.Exists(text))
			{
				Console.WriteLine(" Json Not Found " + text);
				return default(T);
			}
			string value = File.ReadAllText(text);
			return JsonConvert.DeserializeObject<T>(value);
		}
		using BinaryReader binaryReader = new BinaryReader(new FileStream(text, FileMode.Open));
		int count = binaryReader.ReadInt32();
		byte[] key = binaryReader.ReadBytes(count);
		int count2 = binaryReader.ReadInt32();
		byte[] iv = binaryReader.ReadBytes(count2);
		int count3 = binaryReader.ReadInt32();
		byte[] data = binaryReader.ReadBytes(count3);
		byte[] bytes = Decrypt(data, key, iv);
		string value2 = Encoding.UTF8.GetString(bytes);
		return JsonConvert.DeserializeObject<T>(value2);
	}

	public static void SaveConfig(object instance, bool saveJson = true)
	{
		if (instance == null)
		{
			return;
		}
		string name = instance.GetType().Name;
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string path = Path.Combine(baseDirectory, "CSharpLoader\\Mods\\" + BossRushV4.Instance.Name + "\\" + name + ".data");
		string path2 = Path.Combine(baseDirectory, "CSharpLoader\\Mods\\" + BossRushV4.Instance.Name + "\\" + name + ".json");
		if (!File.Exists(path))
		{
			File.Delete(path);
		}
		if (!File.Exists(path2))
		{
			File.Delete(path2);
		}
		string text = JsonConvert.SerializeObject(instance);
		using (Aes aes = Aes.Create())
		{
			aes.GenerateKey();
			aes.GenerateIV();
			byte[] key = aes.Key;
			byte[] iV = aes.IV;
			Console.WriteLine("AES Key: " + Convert.ToBase64String(key));
			Console.WriteLine("AES IV: " + Convert.ToBase64String(iV));
			byte[] array = Encrypt(Encoding.UTF8.GetBytes(text), key, iV);
			using BinaryWriter binaryWriter = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate));
			binaryWriter.Write(key.Length);
			binaryWriter.Write(key);
			binaryWriter.Write(iV.Length);
			binaryWriter.Write(iV);
			binaryWriter.Write(array.Length);
			binaryWriter.Write(array);
		}
		if (saveJson)
		{
			File.WriteAllText(path2, text);
		}
	}

	public static byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
	{
		using Aes aes = Aes.Create();
		aes.Key = key;
		aes.IV = iv;
		using ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
		return PerformCryptography(data, cryptoTransform);
	}

	public static byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
	{
		using Aes aes = Aes.Create();
		aes.Key = key;
		aes.IV = iv;
		using ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
		return PerformCryptography(data, cryptoTransform);
	}

	private static byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
		cryptoStream.Write(data, 0, data.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}
}
