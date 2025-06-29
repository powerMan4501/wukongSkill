using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Google.Protobuf;

namespace b1.Protobuf.DataAPI;

internal class TableDataInfo
{
	private readonly IMessage TableDataObj;

	private List<KeyValuePair<int, IMessage>> TableDataHashList = new List<KeyValuePair<int, IMessage>>();

	private readonly HashSet<int> KeyValueSet = new HashSet<int>();

	private Type DataEntryType;

	private bool IsHasIdProperty;

	private PropertyInfo DataEntryIDInfo;

	public TableDataInfo(string DataFilePath, Type TargetTableType)
	{
		if (UGSE_FileFuncLib.LoadFileToArray(DataFilePath, out var FileData))
		{
			MemoryStream input = new MemoryStream(FileData.ToArray());
			TableDataObj = (IMessage)Activator.CreateInstance(TargetTableType);
			TableDataObj.MergeFrom(input);
			Init(TargetTableType);
		}
	}

	public TableDataInfo(IMessage InTableDataObj, Type TargetTableType)
	{
		TableDataObj = InTableDataObj;
		Init(TargetTableType);
	}

	private void Init(Type TargetTableType)
	{
		if (TableDataObj == null || TargetTableType == null)
		{
			return;
		}
		PropertyInfo property = TargetTableType.GetProperty("List");
		if (!(property == null))
		{
			object value = property.GetValue(TableDataObj);
			if (value != null && value is IEnumerable<object>)
			{
				GenHashList(value as IEnumerable<object>);
			}
		}
	}

	private void GenHashList(IEnumerable<object> RepeatedListObj)
	{
		TableDataHashList = new List<KeyValuePair<int, IMessage>>();
		if (RepeatedListObj == null)
		{
			return;
		}
		foreach (object item in RepeatedListObj)
		{
			if (!(item is IMessage message))
			{
				continue;
			}
			if (DataEntryType == null)
			{
				DataEntryType = message.GetType();
			}
			if (DataEntryIDInfo == null)
			{
				DataEntryIDInfo = DataEntryType.GetProperty("Id");
			}
			int num;
			if (DataEntryIDInfo == null)
			{
				num = message.GetHashCode();
			}
			else
			{
				object value = DataEntryIDInfo.GetValue(message);
				if (value != null && value is int)
				{
					IsHasIdProperty = true;
					num = (int)value;
				}
				else
				{
					num = message.GetHashCode();
				}
			}
			KeyValueSet.Add(num);
			TableDataHashList.Add(new KeyValuePair<int, IMessage>(num, message));
		}
	}

	public List<KeyValuePair<int, IMessage>> GetDataListForDiff()
	{
		if (IsHasIdProperty)
		{
			return TableDataHashList.OrderBy((KeyValuePair<int, IMessage> pair) => pair.Key).ToList();
		}
		return TableDataHashList;
	}

	public bool GetIsHasIdProperty()
	{
		return IsHasIdProperty;
	}

	public bool IsExistKey(int TargetKeyValue)
	{
		return KeyValueSet.Contains(TargetKeyValue);
	}

	public bool TryGetPropertyValue(IMessage TargetMessage, string PropertyName, out object PropertyValue)
	{
		if (DataEntryType != null && TargetMessage != null)
		{
			PropertyInfo property = DataEntryType.GetProperty(PropertyName);
			if (property != null)
			{
				PropertyValue = property.GetValue(TargetMessage);
				if (PropertyValue != null)
				{
					return true;
				}
			}
		}
		PropertyValue = null;
		return false;
	}
}
