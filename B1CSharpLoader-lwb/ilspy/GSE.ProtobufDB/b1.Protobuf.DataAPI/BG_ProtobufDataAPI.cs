using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using BtlU3;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Protobuf.DataAPI;

public sealed class BG_ProtobufDataAPI<T> where T : IMessage, new()
{
	private Dictionary<int, T> _dataDict = new Dictionary<int, T>();

	private List<T> _dataList = new List<T>();

	private Dictionary<int, string> _blameDict = new Dictionary<int, string>();

	private string _propertyID = "ID";

	private static BG_ProtobufDataAPI<T> _instance;

	private object _messageObject;

	private bool _bHasDataGurad;

	private BG_ProtobufDataAPI(string propertyID)
	{
		_dataDict = new Dictionary<int, T>();
		_propertyID = propertyID;
	}

	public static BG_ProtobufDataAPI<T> Get(string propertyID = "ID")
	{
		if (_instance == null)
		{
			_instance = new BG_ProtobufDataAPI<T>(propertyID);
		}
		return _instance;
	}

	public bool LoadData(bool WithOutId = false)
	{
		_dataDict.Clear();
		_blameDict.Clear();
		_dataList.Clear();
		string[] array = typeof(T).ToString().Split('.');
		string typeName = array[array.Length - 1];
		PropertyInfo property = typeof(T).GetProperty(BG_ProtobufDataLoader.Get().DataGuard, BindingFlags.Instance | BindingFlags.Public);
		_bHasDataGurad = property != null;
		return LoadDataFromFilesRecursively(typeName, WithOutId);
	}

	public bool LoadDataFromFilesRecursively(string typeName, bool WithOutId = false)
	{
		if (FPlatformProperties.GetPlatform() == EPlatform.PS5 && !BG_ProtobufDataLoader._UseCDNFile)
		{
			typeName = StringParseHelper.SafeToLower(typeName);
		}
		_dataDict.Clear();
		_blameDict.Clear();
		string[] files = BG_ProtobufDataLoader.Get().GetFiles();
		bool flag = true;
		Regex regex = new Regex($"{Regex.Escape(typeName)}.*\\.data$", RegexOptions.IgnoreCase);
		string[] array = files;
		for (int i = 0; i < array.Length; i++)
		{
			string fileName = array[i];
			string cleanFilename = FPaths.GetCleanFilename(fileName);
			if (regex.IsMatch(cleanFilename))
			{
				flag &= LoadDataFromFile(in fileName, WithOutId);
			}
		}
		return flag;
	}

	private bool LoadDataFromFile(in string fileName, bool WithOutId = false)
	{
		bool result = false;
		_ = BGW_LogUtil.IsPrintToScreen;
		try
		{
			if (UGSE_FileFuncLib.LoadFileToArray(fileName, out var FileData))
			{
				MemoryStream memoryStream = new MemoryStream(FileData.ToArray());
				string text = typeof(T).ToString();
				text.IndexOf('.');
				object obj = Activator.CreateInstance(Type.GetType(text.Insert(text.IndexOf('.') + 1, "TB"), throwOnError: true, ignoreCase: true));
				object value = obj.GetType().GetProperty("Parser").GetValue(obj);
				MethodInfo method = value.GetType().GetMethod("ParseFrom", new Type[1] { typeof(Stream) });
				_messageObject = method.Invoke(value, new object[1] { memoryStream });
				object value2 = _messageObject.GetType().GetProperty("List").GetValue(_messageObject);
				int num = fileName.LastIndexOf('-');
				string blameName = "";
				if (num > 0)
				{
					int num2 = fileName.LastIndexOf('.');
					blameName = fileName.Substring(num + 1, num2 - num - 1);
				}
				if (WithOutId)
				{
					foreach (T item in value2 as IEnumerable<T>)
					{
						_dataList.Add(item);
					}
				}
				else
				{
					foreach (T item2 in value2 as IEnumerable<T>)
					{
						TryAddToDictionary(item2, blameName);
					}
				}
				result = true;
			}
		}
		catch (Exception e)
		{
			FMessage.OpenDialog("Handle protobuf data of " + fileName + " error!");
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.InvokeFunction);
		}
		return result;
	}

	private bool AddDataFromObject(in object obj)
	{
		TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
		if (converter.CanConvertFrom(obj.GetType()))
		{
			T data = (T)converter.ConvertFrom(obj);
			return TryAddToDictionary(data, "");
		}
		return false;
	}

	private bool TryAddToDictionary(T data, string blameName)
	{
		object obj = data.GetType().GetProperty(_propertyID, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)?.GetValue(data);
		if (obj == null)
		{
			return false;
		}
		if (_bHasDataGurad)
		{
			PropertyInfo property = data.GetType().GetProperty(BG_ProtobufDataLoader.Get().DataGuard);
			if (property != null)
			{
				if ((string)property.GetValue(data) != BG_ProtobufDataLoader.Get().DataGuard)
				{
					throw new FailedDataGuardException();
				}
				property.SetValue(data, "");
			}
		}
		int duplicatedID = (int)obj;
		if (_dataDict.TryGetValue(duplicatedID, out var _))
		{
			throw new DuplicatedIDException(in duplicatedID);
		}
		_dataDict[duplicatedID] = data;
		if (blameName.Length > 0)
		{
			switch (blameName)
			{
			case "hs":
				blameName = "hasa";
				break;
			case "lz":
				blameName = "feiluo";
				break;
			case "jj":
				blameName = "songjiajun";
				break;
			case "zh":
				blameName = "ziheng";
				break;
			case "rd":
				blameName = "rongda";
				break;
			case "zl":
				blameName = "yanzhenlong";
				break;
			}
			_blameDict[duplicatedID] = blameName;
		}
		return true;
	}

	public T FindByID(int ResID)
	{
		return GetDataDescByID(in ResID);
	}

	public void InsertDebugData(int ResID, T Data)
	{
	}

	public T GetDataDescByID(in int resID)
	{
		if (_dataDict.TryGetValue(resID, out var value))
		{
			return value;
		}
		return default(T);
	}

	public string GetBlameByID(in int resID)
	{
		if (_blameDict.TryGetValue(resID, out var value))
		{
			return value;
		}
		return null;
	}

	public Dictionary<int, T> GetAll()
	{
		return _dataDict;
	}

	public List<T> GetAllList()
	{
		return _dataList;
	}

	public Dictionary<int, string> GetAllBlames()
	{
		return _blameDict;
	}

	public Dictionary<int, List<FUStB2DSkillStage>> InitMontageEffectData()
	{
		string montageDataFullPath = BG_ProtobufDataLoader.Get().GetMontageDataFullPath();
		string[] files = Directory.GetFiles(montageDataFullPath, "*.data");
		Dictionary<int, List<FUStB2DSkillStage>> dictionary = new Dictionary<int, List<FUStB2DSkillStage>>();
		string[] array = files;
		foreach (string text in array)
		{
			try
			{
				if (!UGSE_FileFuncLib.LoadFileToArray(montageDataFullPath, out var FileData))
				{
					continue;
				}
				MemoryStream input = new MemoryStream(FileData.ToArray());
				FUStB2DSkillData fUStB2DSkillData = new FUStB2DSkillData();
				fUStB2DSkillData.MergeFrom(input);
				foreach (FUStB2DSkillStage stageDatum in fUStB2DSkillData.StageData)
				{
					int key = stageDatum.EffectId / 100;
					List<FUStB2DSkillStage> list = new List<FUStB2DSkillStage>();
					if (dictionary.ContainsKey(key))
					{
						list = dictionary[key];
						list.Add(stageDatum);
					}
					else
					{
						list.Add(stageDatum);
						dictionary.Add(key, list);
					}
				}
			}
			catch (Exception ex)
			{
				USystemLibrary.PrintString(null, "加载" + text + "失败！" + ex, bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 20f, FName.None);
			}
		}
		return dictionary;
	}

	public Dictionary<int, List<FUStB2DComboSkill>> InitComboSkillData()
	{
		string montageDataFullPath = BG_ProtobufDataLoader.Get().GetMontageDataFullPath();
		string[] files = Directory.GetFiles(montageDataFullPath, "*.data");
		Dictionary<int, List<FUStB2DComboSkill>> dictionary = new Dictionary<int, List<FUStB2DComboSkill>>();
		string[] array = files;
		foreach (string text in array)
		{
			try
			{
				if (!UGSE_FileFuncLib.LoadFileToArray(montageDataFullPath, out var FileData))
				{
					continue;
				}
				MemoryStream input = new MemoryStream(FileData.ToArray());
				string[] array2 = text.Split('\\', '.');
				string text2 = "";
				if (array2.Length >= 2)
				{
					text2 = array2[array2.Length - 2];
				}
				if (text2.Contains("/"))
				{
					string[] array3 = text.Split('/', '.');
					if (array3.Length >= 2)
					{
						text2 = array3[array3.Length - 2];
					}
				}
				FUStB2DSkillData fUStB2DSkillData = new FUStB2DSkillData();
				fUStB2DSkillData.MergeFrom(input);
				foreach (FUStB2DComboSkill comboDatum in fUStB2DSkillData.ComboData)
				{
					List<FUStB2DComboSkill> list = new List<FUStB2DComboSkill>();
					int key = int.Parse(text2);
					if (dictionary.ContainsKey(key))
					{
						list = dictionary[key];
						list.Add(comboDatum);
					}
					else
					{
						list.Add(comboDatum);
						dictionary.Add(key, list);
					}
				}
			}
			catch (Exception ex)
			{
				USystemLibrary.PrintString(null, "加载" + text + "失败！" + ex, bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 20f, FName.None);
			}
		}
		return dictionary;
	}
}
