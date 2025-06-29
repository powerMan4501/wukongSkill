using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1.Protobuf.DataAPI;

internal class TableDataDiffHelper
{
	private readonly TableDataInfo OldTableDataInfo;

	private readonly TableDataInfo NewTableDataInfo;

	private readonly List<KeyValuePair<KeyValuePair<int, IMessage>, KeyValuePair<int, IMessage>>> LineModifyList = new List<KeyValuePair<KeyValuePair<int, IMessage>, KeyValuePair<int, IMessage>>>();

	private readonly List<KeyValuePair<int, IMessage>> LineDeleteList = new List<KeyValuePair<int, IMessage>>();

	private readonly List<KeyValuePair<int, IMessage>> LineAddList = new List<KeyValuePair<int, IMessage>>();

	private readonly bool IsHasIdProperty;

	public TableDataDiffHelper(string OldTableDataPath, IMessage NewTableDataObj, string NewTableDataPath, Type TargetTableType)
	{
		OldTableDataInfo = new TableDataInfo(OldTableDataPath, TargetTableType);
		if (NewTableDataPath != null && File.Exists(NewTableDataPath))
		{
			NewTableDataInfo = new TableDataInfo(NewTableDataPath, TargetTableType);
		}
		else
		{
			NewTableDataInfo = new TableDataInfo(NewTableDataObj, TargetTableType);
		}
		IsHasIdProperty = OldTableDataInfo.GetIsHasIdProperty() && NewTableDataInfo.GetIsHasIdProperty();
		GenDiffResult();
	}

	private void GenDiffResult()
	{
		if (OldTableDataInfo == null || NewTableDataInfo == null)
		{
			return;
		}
		List<KeyValuePair<int, IMessage>> dataListForDiff = OldTableDataInfo.GetDataListForDiff();
		List<KeyValuePair<int, IMessage>> dataListForDiff2 = NewTableDataInfo.GetDataListForDiff();
		int num = 0;
		int num2 = 0;
		while (num < dataListForDiff.Count || num2 < dataListForDiff2.Count)
		{
			if (num >= dataListForDiff.Count)
			{
				LineAddList.Add(dataListForDiff2[num2]);
				num2++;
				continue;
			}
			if (num2 >= dataListForDiff2.Count)
			{
				LineDeleteList.Add(dataListForDiff[num]);
				num++;
				continue;
			}
			KeyValuePair<int, IMessage> keyValuePair = dataListForDiff[num];
			KeyValuePair<int, IMessage> keyValuePair2 = dataListForDiff2[num2];
			if (keyValuePair.Key == keyValuePair2.Key)
			{
				if (IsHasIdProperty && !keyValuePair.Value.Equals(keyValuePair2.Value))
				{
					LineModifyList.Add(new KeyValuePair<KeyValuePair<int, IMessage>, KeyValuePair<int, IMessage>>(keyValuePair, keyValuePair2));
				}
				num++;
				num2++;
				continue;
			}
			if (IsHasIdProperty)
			{
				if (keyValuePair.Key < keyValuePair2.Key)
				{
					LineDeleteList.Add(keyValuePair);
					num++;
				}
				else if (keyValuePair.Key > keyValuePair2.Key)
				{
					LineAddList.Add(keyValuePair2);
					num2++;
				}
				continue;
			}
			if (NewTableDataInfo.IsExistKey(keyValuePair.Key))
			{
				LineDeleteList.Add(keyValuePair);
				num++;
			}
			if (OldTableDataInfo.IsExistKey(keyValuePair2.Key))
			{
				LineAddList.Add(keyValuePair2);
				num2++;
			}
		}
	}

	public bool RuleValidation_AnyChange(out string ErrorReason)
	{
		if (LineModifyList.Count > 0 || LineDeleteList.Count > 0 || LineAddList.Count > 0)
		{
			ErrorReason = $"存在数据变动(增:{LineAddList.Count}删:{LineDeleteList.Count}改:{LineModifyList.Count})";
			return false;
		}
		ErrorReason = "";
		return true;
	}

	public bool RuleValidation_LineAdd(out string ErrorReason)
	{
		if (LineAddList.Count > 0)
		{
			if (IsHasIdProperty)
			{
				ErrorReason = $"添加了新行(ID:{LineAddList.First().Key})";
			}
			else
			{
				ErrorReason = "添加了新行";
			}
			return false;
		}
		ErrorReason = "";
		return true;
	}

	public bool RuleValidation_LineDelete(out string ErrorReason, List<int> TargetIdList)
	{
		if (TargetIdList != null && TargetIdList.Count > 0)
		{
			foreach (KeyValuePair<int, IMessage> lineDelete in LineDeleteList)
			{
				if (TargetIdList.Contains(lineDelete.Key))
				{
					ErrorReason = $"存在ID为{lineDelete.Key}的行被移除";
					return false;
				}
			}
		}
		else if (LineDeleteList.Count > 0)
		{
			if (IsHasIdProperty)
			{
				ErrorReason = $"存在旧行被移除(ID:{LineDeleteList.First().Key})";
			}
			else
			{
				ErrorReason = "存在旧行被移除";
			}
			return false;
		}
		ErrorReason = "";
		return true;
	}

	public bool RuleValidation_LineModify(out string ErrorReason, List<int> TargetIdList)
	{
		if (TargetIdList != null && TargetIdList.Count > 0)
		{
			foreach (KeyValuePair<KeyValuePair<int, IMessage>, KeyValuePair<int, IMessage>> lineModify in LineModifyList)
			{
				if (TargetIdList.Contains(lineModify.Key.Key))
				{
					ErrorReason = $"存在ID为{lineModify.Key.Key}的行数据被修改";
					return false;
				}
			}
		}
		else if (LineModifyList.Count > 0)
		{
			if (IsHasIdProperty)
			{
				ErrorReason = $"存在行数据被修改(ID:{LineModifyList.First().Key.Key})";
			}
			else
			{
				ErrorReason = "存在行数据被修改";
			}
			return false;
		}
		ErrorReason = "";
		return true;
	}

	public bool RuleValidation_ValueModify(out string ErrorReason, List<object> TargetPropertyList, List<int> TargetIdList)
	{
		return RuleValidation_Value(out ErrorReason, TargetPropertyList, TargetIdList, 0);
	}

	public bool RuleValidation_ValueIncrease(out string ErrorReason, List<object> TargetPropertyList, List<int> TargetIdList)
	{
		return RuleValidation_Value(out ErrorReason, TargetPropertyList, TargetIdList, 1);
	}

	public bool RuleValidation_ValueDecrease(out string ErrorReason, List<object> TargetPropertyList, List<int> TargetIdList)
	{
		return RuleValidation_Value(out ErrorReason, TargetPropertyList, TargetIdList, -1);
	}

	private bool RuleValidation_Value(out string ErrorReason, List<object> TargetPropertyObjList, List<int> TargetIdList, int ValidationFlag)
	{
		foreach (object TargetPropertyObj in TargetPropertyObjList)
		{
			if (TargetPropertyObj is string text)
			{
				if (string.IsNullOrWhiteSpace(text))
				{
					continue;
				}
				foreach (KeyValuePair<KeyValuePair<int, IMessage>, KeyValuePair<int, IMessage>> lineModify in LineModifyList)
				{
					if (TargetIdList == null || TargetIdList.Count <= 0 || TargetIdList.Contains(lineModify.Key.Key))
					{
						object PropertyValue;
						bool num = OldTableDataInfo.TryGetPropertyValue(lineModify.Key.Value, text, out PropertyValue);
						object PropertyValue2;
						bool flag = NewTableDataInfo.TryGetPropertyValue(lineModify.Value.Value, text, out PropertyValue2);
						if (num && flag && PropertyValue != null && PropertyValue2 != null && !RuleValidation_ValueChange(PropertyValue, PropertyValue2, ValidationFlag, out ErrorReason, lineModify.Key.Key, text))
						{
							return false;
						}
					}
				}
			}
			else
			{
				if (!(TargetPropertyObj is Dictionary<string, object> dictionary) || !dictionary.TryGetValue("RootProperty", out var value) || !(value is string text2) || string.IsNullOrWhiteSpace(text2))
				{
					continue;
				}
				foreach (KeyValuePair<KeyValuePair<int, IMessage>, KeyValuePair<int, IMessage>> lineModify2 in LineModifyList)
				{
					if (TargetIdList != null && TargetIdList.Count > 0 && !TargetIdList.Contains(lineModify2.Key.Key))
					{
						continue;
					}
					object PropertyValue3;
					bool num2 = OldTableDataInfo.TryGetPropertyValue(lineModify2.Key.Value, text2, out PropertyValue3);
					object PropertyValue4;
					bool flag2 = NewTableDataInfo.TryGetPropertyValue(lineModify2.Value.Value, text2, out PropertyValue4);
					if (!(num2 && flag2) || PropertyValue3 == null || PropertyValue4 == null || PropertyValue3.Equals(PropertyValue4))
					{
						continue;
					}
					List<object> list = ObjectConvertToList(PropertyValue3);
					List<object> list2 = ObjectConvertToList(PropertyValue4);
					int num3 = list.Count();
					int num4 = list2.Count();
					if (num3 != num4 && dictionary.TryGetValue("NumCheck", out var value2) && value2 is string text3)
					{
						if (text3 == "Modify" && num3 != num4)
						{
							ErrorReason = $"ID为{lineModify2.Key.Key}的行的{text2}字段的数量被修改了({num3}->{num4})";
							return false;
						}
						if (text3 == "Add" && num3 < num4)
						{
							ErrorReason = $"ID为{lineModify2.Key.Key}的行的{text2}字段的数量变多了({num3}->{num4})";
							return false;
						}
						if (text3 == "Remove" && num3 > num4)
						{
							ErrorReason = $"ID为{lineModify2.Key.Key}的行的{text2}字段的数量变少了({num3}->{num4})";
							return false;
						}
					}
					if (num3 <= 0 || num4 <= 0 || !dictionary.TryGetValue("PropertyList", out var value3))
					{
						continue;
					}
					int num5 = FMath.Min(num3, num4);
					if (!(value3 is IEnumerable<object> enumerable) || enumerable == null)
					{
						continue;
					}
					foreach (object item in enumerable)
					{
						if (!(item is string text4) || string.IsNullOrWhiteSpace(text4))
						{
							continue;
						}
						for (int i = 0; i < num5; i++)
						{
							object obj = list[i];
							object obj2 = list2[i];
							if (PropertyValue3 == null || obj2 == null)
							{
								continue;
							}
							Type type = obj.GetType();
							Type type2 = obj2.GetType();
							if (!(type != null) || !(type2 != null) || !(type == type2))
							{
								continue;
							}
							PropertyInfo property = type.GetProperty(text4);
							if (property != null)
							{
								object value4 = property.GetValue(obj);
								object value5 = property.GetValue(obj2);
								if (!RuleValidation_ValueChange(value4, value5, ValidationFlag, out ErrorReason, lineModify2.Key.Key, text2 + "/" + text4))
								{
									return false;
								}
							}
						}
					}
				}
			}
		}
		ErrorReason = "";
		return true;
	}

	private bool RuleValidation_ValueChange(object OldValue, object NewValue, int ValidationFlag, out string ErrorReason, int LineID, string TargetProperty)
	{
		if (OldValue != null && NewValue != null && !OldValue.Equals(NewValue))
		{
			if (ValidationFlag == 0)
			{
				ErrorReason = $"ID为{LineID}的行的{TargetProperty}字段被修改({OldValue}->{NewValue})";
				return false;
			}
			if (OldValue is IComparable obj && NewValue is IComparable comparable)
			{
				if (ValidationFlag < 0)
				{
					if (comparable.CompareTo(obj) < 0)
					{
						ErrorReason = $"ID为{LineID}的行的{TargetProperty}字段被修改变小了({OldValue}->{NewValue})";
						return false;
					}
				}
				else if (comparable.CompareTo(obj) > 0)
				{
					ErrorReason = $"ID为{LineID}的行的{TargetProperty}字段被修改变大了({OldValue}->{NewValue})";
					return false;
				}
			}
		}
		ErrorReason = "";
		return true;
	}

	private List<object> ObjectConvertToList(object TargetObj)
	{
		List<object> list = new List<object>();
		if (TargetObj is IList list2)
		{
			foreach (object item in list2)
			{
				if (item != null)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}
}
