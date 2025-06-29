using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace b1.AutoQA;

public class MemReportHelper_Comparator
{
	public readonly string SectionTypeString = string.Empty;

	private readonly bool IsAlphasort;

	private readonly List<string> CompareDataList1 = new List<string>();

	private readonly List<string> CompareDataList2 = new List<string>();

	private List<string> IncreaseDataList = new List<string>();

	private List<string> DecreaseDataList = new List<string>();

	public MemReportHelper_Comparator(List<string> ReportContent1, List<string> ReportContent2, string InSectionTypeString, bool IsOrdered)
	{
		SectionTypeString = InSectionTypeString;
		IsAlphasort = IsOrdered;
		CompareDataList1 = GetCompareDataList(ReportContent1);
		CompareDataList2 = GetCompareDataList(ReportContent2);
		GenDiffDataList(IsOrdered);
	}

	private List<string> GetCompareDataList(List<string> ReportContent)
	{
		List<string> list = new List<string>();
		string text = (IsAlphasort ? ("Obj List: class=" + SectionTypeString + " -alphasort") : ("Obj List: class=" + SectionTypeString + " -resourcesizesort"));
		int num = 0;
		foreach (string item in ReportContent)
		{
			switch (num)
			{
			case 1:
				num = 2;
				break;
			case 2:
				num = 3;
				break;
			case 3:
			{
				if (string.IsNullOrWhiteSpace(item))
				{
					goto end_IL_00a3;
				}
				string objectPath = MemReportHelper_ExportDotMemory.GetObjectPath(item.Trim());
				if (objectPath != string.Empty)
				{
					list.Add(objectPath);
				}
				break;
			}
			}
			if (item.Trim() == text)
			{
				num = 1;
			}
			continue;
			end_IL_00a3:
			break;
		}
		return list;
	}

	private void GenDiffDataList(bool IsOrdered)
	{
		IncreaseDataList = GetDiff3(CompareDataList1, CompareDataList2, IsOrdered);
		DecreaseDataList = GetDiff3(CompareDataList2, CompareDataList1, IsOrdered);
		if (IncreaseDataList.Count > 300)
		{
			IncreaseDataList = IncreaseDataList.GetRange(0, 300);
		}
	}

	private List<string> GetDiff(List<string> LeftDataList, List<string> RightDataList, bool IsOrdered)
	{
		List<string> list = new List<string>();
		if (LeftDataList.Count <= 0)
		{
			return RightDataList;
		}
		if (RightDataList.Count <= 0)
		{
			return list;
		}
		int num = 0;
		for (int i = 0; i < RightDataList.Count; i++)
		{
			bool flag = false;
			for (int j = num; j < LeftDataList.Count; j++)
			{
				if (LeftDataList[j] == RightDataList[i])
				{
					flag = true;
					if (IsOrdered)
					{
						num = j;
					}
					break;
				}
			}
			if (!flag)
			{
				list.Add(RightDataList[i]);
			}
		}
		return list;
	}

	private List<string> GetDiff2(List<string> LeftDataList, List<string> RightDataList, bool IsOrdered)
	{
		List<string> list = new List<string>();
		if (!IsOrdered)
		{
			BGW_LogUtil.LogError("[MemReportHelper_Comparator] 输入数据不是有序的，无法进行Diff！");
			return list;
		}
		if (LeftDataList.Count <= 0)
		{
			return RightDataList;
		}
		if (RightDataList.Count <= 0)
		{
			return list;
		}
		List<int> list2 = new List<int>();
		for (int i = 0; i < RightDataList.Count; i++)
		{
			list2.Add(-1);
			for (int j = 0; j < LeftDataList.Count; j++)
			{
				if (RightDataList[i] == LeftDataList[j])
				{
					list2[i] = j;
					break;
				}
			}
		}
		List<int> list3 = new List<int>();
		for (int k = 0; k < LeftDataList.Count; k++)
		{
			list3.Add(-1);
			for (int l = 0; l < RightDataList.Count; l++)
			{
				if (LeftDataList[k] == RightDataList[l])
				{
					list3[k] = l;
					break;
				}
			}
		}
		int num = 0;
		int num2 = 0;
		while (num2 < RightDataList.Count)
		{
			if (num >= LeftDataList.Count)
			{
				list.Add(RightDataList[num2]);
				num2++;
				continue;
			}
			int num3 = list2[num2];
			if (num3 < 0)
			{
				if (list3[num] < 0)
				{
					string text = RemoveNumberedParts(LeftDataList[num]);
					string text2 = RemoveNumberedParts(RightDataList[num2]);
					if (text == text2)
					{
						num2++;
						num++;
						continue;
					}
					bool flag = LeftDataList[num] != text;
					bool flag2 = RightDataList[num2] != text2;
					if (flag && flag2)
					{
						list.Add(RightDataList[num2]);
						num2++;
						num++;
					}
					else if (!flag && flag2)
					{
						num++;
					}
					else if (flag && !flag2)
					{
						list.Add(RightDataList[num2]);
						num2++;
					}
					else
					{
						list.Add(RightDataList[num2]);
						num2++;
						num++;
					}
				}
				else
				{
					list.Add(RightDataList[num2]);
					num2++;
				}
			}
			else
			{
				num = num3 + 1;
				num2++;
			}
		}
		return list;
	}

	private List<string> GetDiff3(List<string> LeftDataList, List<string> RightDataList, bool IsOrdered)
	{
		List<string> list = new List<string>();
		if (!IsOrdered)
		{
			BGW_LogUtil.LogError("[MemReportHelper_Comparator] 输入数据不是有序的，无法进行Diff！");
			return list;
		}
		if (LeftDataList.Count <= 0)
		{
			return RightDataList;
		}
		if (RightDataList.Count <= 0)
		{
			return list;
		}
		List<string> list2 = new List<string>();
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		for (int i = 0; i < RightDataList.Count; i++)
		{
			string text = RemoveNumberedParts(RightDataList[i]);
			if (text != RightDataList[i])
			{
				if (dictionary.ContainsKey(text))
				{
					dictionary[text]++;
				}
				else
				{
					dictionary.Add(text, 1);
				}
				list2.Add(text + "AccumulateSameFlag_" + dictionary[text]);
			}
			else
			{
				list2.Add(RightDataList[i]);
			}
		}
		List<string> list3 = new List<string>();
		dictionary = new Dictionary<string, int>();
		for (int j = 0; j < LeftDataList.Count; j++)
		{
			string text2 = RemoveNumberedParts(LeftDataList[j]);
			if (text2 != LeftDataList[j])
			{
				if (dictionary.ContainsKey(text2))
				{
					dictionary[text2]++;
				}
				else
				{
					dictionary.Add(text2, 1);
				}
				list3.Add(text2 + "AccumulateSameFlag_" + dictionary[text2]);
			}
			else
			{
				list3.Add(LeftDataList[j]);
			}
		}
		int num = 0;
		for (int k = 0; k < RightDataList.Count; k++)
		{
			bool flag = false;
			for (int l = num; l < LeftDataList.Count; l++)
			{
				if (list2[k] == list3[l])
				{
					flag = true;
					num = l + 1;
					break;
				}
			}
			if (!flag)
			{
				list.Add(RightDataList[k]);
			}
		}
		return list;
	}

	private string RemoveNumberedParts(string input)
	{
		string pattern = "_\\d{6,}";
		return Regex.Replace(input, pattern, "");
	}

	private List<string> FilterMeaninglessPart(List<string> InputData)
	{
		List<string> list = new List<string>();
		if (InputData == null || InputData.Count <= 0)
		{
			return list;
		}
		foreach (string InputDatum in InputData)
		{
			if (!InputDatum.Contains("/Engine/Transient"))
			{
				list.Add(InputDatum);
			}
		}
		return list;
	}

	public int GetDiffDataNum(bool InIsIncrease)
	{
		if (InIsIncrease)
		{
			return IncreaseDataList.Count;
		}
		return DecreaseDataList.Count;
	}

	public string GetDiffDataByIndex(int Index, bool InIsIncrease)
	{
		if (InIsIncrease)
		{
			if (Index >= IncreaseDataList.Count)
			{
				return string.Empty;
			}
			return IncreaseDataList[Index];
		}
		if (Index >= DecreaseDataList.Count)
		{
			return string.Empty;
		}
		return DecreaseDataList[Index];
	}
}
