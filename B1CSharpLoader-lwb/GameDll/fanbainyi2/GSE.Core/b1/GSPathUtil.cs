using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public class GSPathUtil
{
	private static JsonData EmptyJsonData = JsonMapper.ToObject("{}");

	public static string ProjectDir => FPaths.ProjectDir;

	public static string ProjectConfigDir => FPaths.ProjectConfigDir;

	public static string ProjectContentDir => FPaths.ProjectContentDir;

	public static string SearchProjectConfigFile(string FileName)
	{
		string text = "";
		string[] array = new string[4]
		{
			CombineProjectConfigSubPath(text, FileName),
			CombineProjectConfigSubPath(FPlatformProperties.GetPlatform().ToString(), FileName),
			CombineProjectConfigSubPath("gs", FileName),
			CombineProjectConfigSubPath(FileName)
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (FPaths.FileExists(array[i]))
			{
				return array[i];
			}
		}
		return null;
	}

	public static string CombineProjectConfigSubPath(params string[] SubPathList)
	{
		string[] array = new string[SubPathList.Length + 1];
		array[0] = FPaths.ProjectConfigDir;
		SubPathList.CopyTo(array, 1);
		return FPaths.Combine(array);
	}

	public static string ReadUTF8FileText(string FilePath)
	{
		byte[] array = ReadBlobFileContent(FilePath);
		if (array != null && array.Length != 0)
		{
			try
			{
				return Encoding.UTF8.GetString(array);
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError($"read file length:{array.Length} convert to utf8 fail:{ex.Message}");
				return null;
			}
		}
		return null;
	}

	public static byte[] ReadBlobFileContent(string FilePath)
	{
		if (!FPaths.FileExists(FilePath))
		{
			return null;
		}
		try
		{
			return File.ReadAllBytes(FilePath);
		}
		catch (Exception)
		{
			BGW_LogUtil.LogError("read exist file:" + FilePath + " content fail");
		}
		return null;
	}

	public static JsonData ParseJsonConfig(string FilePath)
	{
		try
		{
			if (FilePath == null || !FPaths.FileExists(FilePath))
			{
				return EmptyJsonData;
			}
			string text = ReadUTF8FileText(FilePath);
			if (text != null)
			{
				return JsonMapper.ToObject(text);
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("parse json config:" + FilePath + " fail " + ex.Message);
		}
		return EmptyJsonData;
	}

	public static object ParseJsonFromString(string JsonText)
	{
		return JsonDataParse(JsonMapper.ToObject(JsonText));
		static object JsonDataParse(JsonData InJsonData)
		{
			if (InJsonData == null)
			{
				return null;
			}
			if (InJsonData.IsObject)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				{
					foreach (string key in InJsonData.Keys)
					{
						JsonData inJsonData = InJsonData[key];
						if (!dictionary.ContainsKey(key))
						{
							dictionary.Add(key, JsonDataParse(inJsonData));
						}
					}
					return dictionary;
				}
			}
			if (InJsonData.IsArray)
			{
				List<object> list = new List<object>();
				for (int i = 0; i < InJsonData.Count; i++)
				{
					JsonData inJsonData2 = InJsonData[i];
					list.Add(JsonDataParse(inJsonData2));
				}
				return list;
			}
			return InJsonData.ToString();
		}
	}
}
