using System.Collections.Generic;
using System.Text;

namespace b1;

public class FMovieAnalysisInfo
{
	public int SequenceID { get; set; }

	public bool bCanRepeatPlay { get; set; }

	public string MovieGraphPath { get; set; }

	public BED_MovieAsset MovieAsset { get; set; }

	public Dictionary<int, string> ProcessAssetNameDictionary { get; } = new Dictionary<int, string>();

	public Dictionary<int, Dictionary<int, Queue<FMovieCallPath>>> ProcessMovieCallStack { get; } = new Dictionary<int, Dictionary<int, Queue<FMovieCallPath>>>();

	public HashSet<string> ReferenceLevelList { get; } = new HashSet<string>();

	public List<FMovieTriggerRelationInfo> TriggerRelations { get; } = new List<FMovieTriggerRelationInfo>();

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("---------------------------Begin--------------------------");
		stringBuilder.AppendLine($"SequenceID:{SequenceID} Graph:{BGW_StringExtensions.ConvertSoftObjPath2AssetName(MovieGraphPath)}");
		stringBuilder.Append("Dependency Level: ");
		foreach (string referenceLevel in ReferenceLevelList)
		{
			stringBuilder.Append(" " + referenceLevel + " ");
		}
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("CallStack:");
		foreach (KeyValuePair<int, Dictionary<int, Queue<FMovieCallPath>>> item in ProcessMovieCallStack)
		{
			stringBuilder.AppendLine($"\tPsmID:{item.Key} Graph:{BGW_StringExtensions.ConvertSoftObjPath2AssetName(ProcessAssetNameDictionary[item.Key])}");
			List<string> list = new List<string>();
			foreach (KeyValuePair<int, Queue<FMovieCallPath>> item2 in item.Value)
			{
				stringBuilder.AppendLine($"\t\tNodeIndex:{item2.Key}");
				foreach (FMovieCallPath item3 in item2.Value)
				{
					stringBuilder.AppendLine($"\t\t\t{item3}");
					switch (item3.NodeClass)
					{
					case "Idle":
						list.Add(item3.ConditionType);
						break;
					case "battle":
						list.Add(item3.ConditionType);
						break;
					case "Group":
						if (item3.ConditionType == "Auto")
						{
							list.Add("ResetGroup");
						}
						else
						{
							list.Add(item3.ConditionType);
						}
						break;
					}
				}
				stringBuilder.AppendLine("\t\tTriggerCondition:" + string.Join(" / ", list));
			}
		}
		stringBuilder.AppendLine("----------------------------End---------------------------");
		return stringBuilder.ToString();
	}
}
