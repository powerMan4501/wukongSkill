using System.Collections.Generic;
using System.Text;

namespace b1;

public class FTaskStageAnalysisInfo
{
	public int TaskStageID { get; set; }

	public string TaskGraphPath { get; set; }

	public Dictionary<int, Dictionary<int, Queue<FMovieCallPath>>> ActivatedCallPathStack { get; } = new Dictionary<int, Dictionary<int, Queue<FMovieCallPath>>>();

	public Dictionary<int, Dictionary<int, Queue<FMovieCallPath>>> FinishedCallPathStack { get; } = new Dictionary<int, Dictionary<int, Queue<FMovieCallPath>>>();

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"TaskStageID:{TaskStageID}\t");
		foreach (KeyValuePair<int, Dictionary<int, Queue<FMovieCallPath>>> item in ActivatedCallPathStack)
		{
			stringBuilder.AppendLine($"\tActived TaskLine:{item.Key} TaskGraph:{BGW_StringExtensions.ConvertSoftObjPath2AssetName(TaskGraphPath)}");
			foreach (KeyValuePair<int, Queue<FMovieCallPath>> item2 in item.Value)
			{
				stringBuilder.AppendLine($"\t\tNodeIndex:{item2.Key}");
				foreach (FMovieCallPath item3 in item2.Value)
				{
					stringBuilder.AppendLine($"\t\t\t{item3}");
				}
			}
		}
		foreach (KeyValuePair<int, Dictionary<int, Queue<FMovieCallPath>>> item4 in FinishedCallPathStack)
		{
			stringBuilder.AppendLine($"\tFinished TaskLine:{item4.Key} TaskGraph:{BGW_StringExtensions.ConvertSoftObjPath2AssetName(TaskGraphPath)}");
			foreach (KeyValuePair<int, Queue<FMovieCallPath>> item5 in item4.Value)
			{
				stringBuilder.AppendLine($"\t\tNodeIndex:{item5.Key}");
				foreach (FMovieCallPath item6 in item5.Value)
				{
					stringBuilder.AppendLine($"\t\t\t{item6}");
				}
			}
		}
		return stringBuilder.ToString();
	}
}
