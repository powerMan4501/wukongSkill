using System.Collections.Generic;
using System.Text;

namespace b1;

public class FTriggerAnalysisReport
{
	public string TriggerType { get; set; }

	public Dictionary<string, Dictionary<int, string>> Cpg2Node2CmgDictionary { get; } = new Dictionary<string, Dictionary<int, string>>();

	public Dictionary<string, Dictionary<string, int>> Cmg2Cpg2NodeDictionary { get; } = new Dictionary<string, Dictionary<string, int>>();

	public static void RecordTriggerType(ref Dictionary<string, FTriggerAnalysisReport> Reports, string ConditionType, string CpgName, int NodeIndex, string CmgName)
	{
		FTriggerAnalysisReport fTriggerAnalysisReport = null;
		if (Reports.TryGetValue(ConditionType, out var value))
		{
			fTriggerAnalysisReport = value;
		}
		else
		{
			fTriggerAnalysisReport = new FTriggerAnalysisReport
			{
				TriggerType = ConditionType
			};
			Reports[ConditionType] = fTriggerAnalysisReport;
		}
		if (!fTriggerAnalysisReport.Cmg2Cpg2NodeDictionary.TryGetValue(CmgName, out var value2))
		{
			value2 = new Dictionary<string, int>();
			fTriggerAnalysisReport.Cmg2Cpg2NodeDictionary[CmgName] = value2;
		}
		value2[CpgName] = NodeIndex;
		if (!fTriggerAnalysisReport.Cpg2Node2CmgDictionary.TryGetValue(CpgName, out var value3))
		{
			value3 = new Dictionary<int, string>();
			fTriggerAnalysisReport.Cpg2Node2CmgDictionary[CpgName] = value3;
		}
		value3[NodeIndex] = CmgName;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("---------------------------Begin--------------------------");
		stringBuilder.AppendLine("TriggerType:" + TriggerType);
		stringBuilder.AppendLine($"\t 关联CPG数量：{Cpg2Node2CmgDictionary.Count}");
		foreach (KeyValuePair<string, Dictionary<int, string>> item in Cpg2Node2CmgDictionary)
		{
			stringBuilder.AppendLine($"\t\t CPG:{item.Key} 包含CMG数量：{item.Value.Count}");
			foreach (KeyValuePair<int, string> item2 in item.Value)
			{
				stringBuilder.AppendLine($"\t\t\t NodeIndex:{item2.Key}  CMG:{item2.Value}");
			}
		}
		stringBuilder.AppendLine($"\t 关联CMG数量：{Cmg2Cpg2NodeDictionary.Count}");
		foreach (KeyValuePair<string, Dictionary<string, int>> item3 in Cmg2Cpg2NodeDictionary)
		{
			stringBuilder.AppendLine($"\t\t CMG:{item3.Key} 包含CPG数量：{item3.Value.Count}");
			foreach (KeyValuePair<string, int> item4 in item3.Value)
			{
				stringBuilder.AppendLine($"\t\t\t CPG:{item4.Key}  NodeIndex:{item4.Value}");
			}
		}
		stringBuilder.AppendLine("----------------------------End---------------------------");
		return stringBuilder.ToString();
	}
}
