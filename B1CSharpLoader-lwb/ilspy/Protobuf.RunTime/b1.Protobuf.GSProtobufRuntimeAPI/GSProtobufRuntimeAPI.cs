using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using b1.Protobuf.DataAPI;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Protobuf.GSProtobufRuntimeAPI;

public sealed class GSProtobufRuntimeAPI<TB, T> where TB : IMessage, new() where T : IMessage
{
	private Dictionary<int, T> _dataDict = new Dictionary<int, T>();

	private string _propertyID = "";

	private static GSProtobufRuntimeAPI<TB, T> _instance;

	private TB _messageTBList = new TB();

	private GSProtobufRuntimeAPI()
	{
		_dataDict = new Dictionary<int, T>();
	}

	public static GSProtobufRuntimeAPI<TB, T> Get()
	{
		if (_instance == null)
		{
			_instance = new GSProtobufRuntimeAPI<TB, T>();
			BG_ProtobufDataLoader.Get().LoadProjectDataSettings(ProjNames.B1.ToString());
		}
		return _instance;
	}

	public bool LoadDataById(string idName = "Id")
	{
		return LoadData(idName);
	}

	public bool LoadData(string idName = "")
	{
		_propertyID = idName;
		_dataDict.Clear();
		char[] separator = new char[3] { '.', ':', ' ' };
		string[] array = typeof(T).ToString().Split(separator);
		string text = array[array.Length - 1].Replace("Type: ", "");
		return LoadDataFromFile(BG_ProtobufDataLoader.Get().GetRunTimeDataFolderFullPath() + text + ".data");
	}

	private bool LoadDataFromFile(in string fileName)
	{
		bool result = false;
		try
		{
			if (UGSE_FileFuncLib.LoadFileToArray(fileName, out var FileData))
			{
				MemoryStream input = new MemoryStream(FileData.ToArray());
				_messageTBList = new TB();
				_messageTBList.MergeFrom(input);
				if (_propertyID != "")
				{
					foreach (T item in typeof(TB).GetProperty("List").GetValue(_messageTBList) as IEnumerable<T>)
					{
						TryAddToDictionary(item);
					}
				}
				result = true;
			}
		}
		catch (DuplicatedIDException ex)
		{
			USystemLibrary.PrintString(null, "加载" + fileName + "中止！出现重复的ID值(" + ex.DuplicatedID + ")", BG_ProtobufDataLoader.IsPrintToScreen, bPrintToLog: true, FLinearColor.Red, 200f, FName.None);
		}
		catch (Exception ex2)
		{
			USystemLibrary.PrintString(null, "加载" + fileName + "失败！" + ex2, BG_ProtobufDataLoader.IsPrintToScreen, bPrintToLog: true, FLinearColor.Red, 200f, FName.None);
		}
		return result;
	}

	private bool AddDataFromObject(in object obj)
	{
		TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
		if (converter.CanConvertFrom(obj.GetType()))
		{
			T data = (T)converter.ConvertFrom(obj);
			return TryAddToDictionary(data);
		}
		return false;
	}

	private bool TryAddToDictionary(T data)
	{
		object obj = data.GetType().GetProperty(_propertyID, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public)?.GetValue(data);
		if (obj == null)
		{
			return false;
		}
		int duplicatedID = Convert.ToInt32(obj);
		if (_dataDict.TryGetValue(duplicatedID, out var _))
		{
			throw new DuplicatedIDException(in duplicatedID);
		}
		_dataDict[duplicatedID] = data;
		return true;
	}

	public TB GetTBList()
	{
		return _messageTBList;
	}

	public T FindByID(int ResID)
	{
		return GetDataDescByID(in ResID);
	}

	public T GetDataDescByID(in int resID)
	{
		if (_dataDict.TryGetValue(resID, out var value))
		{
			return value;
		}
		return default(T);
	}

	public TB GetAll()
	{
		return _messageTBList;
	}
}
