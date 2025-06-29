using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using LitJson;

namespace ProtobufLoader;

public static class Config
{
	public static bool ShutUp = false;

	public static bool ShuutUp = false;

	public static bool ShuuutUp = false;

	public static bool EnableChineseConsoleLog = true;

	public static void LoadConfig()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		string path = "CSharpLoader\\Mods\\" + MyExten.Name + "\\config.json";
		if (!File.Exists(path))
		{
			MyExten.Error("No Config File");
			return;
		}
		try
		{
			JsonData obj = JsonMapper.ToObject(File.ReadAllText(path));
			Type typeFromHandle = typeof(Config);
			foreach (JsonData item in (IEnumerable)obj["Config"])
			{
				JsonData val = item;
				if (!val.IsObject)
				{
					continue;
				}
				JsonField jsonField = JsonMapper.ToObject<JsonField>(JsonMapper.ToJson((object)val));
				FieldInfo field = typeFromHandle.GetField(jsonField.Name, BindingFlags.Static | BindingFlags.Public);
				if (field == null)
				{
					MyExten.Error("Can't Set Field " + jsonField.Name);
					continue;
				}
				JsonData val2 = null;
				if (val.Keys.Contains("CurrentValue") && val["CurrentValue"] != null)
				{
					val2 = val["CurrentValue"];
				}
				else if (val.Keys.Contains("DefaultValue"))
				{
					val2 = val["DefaultValue"];
				}
				if (val2 == null)
				{
					MyExten.Error("No Value For " + jsonField.Name);
				}
				else if (field.FieldType == typeof(List<string>))
				{
					if (jsonField.Type.ToLower() == "list<string>" && val2.IsArray)
					{
						List<string> value = JsonMapper.ToObject<List<string>>(JsonMapper.ToJson((object)val2));
						field.SetValue(null, value);
					}
					else
					{
						MyExten.Log(field.FieldType.Name + " no match " + jsonField.Type, 1);
					}
				}
				else if (field.FieldType == typeof(int))
				{
					if (jsonField.Type.ToLower() == "int" && val2.IsInt)
					{
						field.SetValue(null, (int)val2);
					}
					else
					{
						MyExten.Log(field.FieldType.Name + " no match " + jsonField.Type, 1);
					}
				}
				else if (field.FieldType == typeof(bool))
				{
					if (jsonField.Type.ToLower() == "bool" && val2.IsBoolean)
					{
						field.SetValue(null, (bool)val2);
					}
					else
					{
						MyExten.Log(field.FieldType.Name + " no match " + jsonField.Type, 1);
					}
				}
			}
			MyExten.Log($"Config loaded {ShutUp} {ShuutUp} {ShuuutUp}");
		}
		catch (Exception)
		{
			MyExten.Error("Fail to Parse Config File");
		}
	}
}
