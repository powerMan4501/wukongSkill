using System.Collections.Generic;
using System.Text;

namespace b1;

public class FSeqLevelAnalysisInfo
{
	public string LevelName { get; set; }

	public HashSet<FMovieAnalysisInfo> Movies { get; } = new HashSet<FMovieAnalysisInfo>();

	public List<FMovieTriggerRelationInfo> RelationInfos { get; } = new List<FMovieTriggerRelationInfo>();

	public bool MakeTriggerMonitors()
	{
		bool flag = false;
		foreach (FMovieAnalysisInfo movie in Movies)
		{
			if (movie.TriggerRelations.Count > 0)
			{
				flag = true;
				RelationInfos.Add(movie.TriggerRelations[0]);
			}
		}
		if (!flag)
		{
			RelationInfos.Clear();
		}
		return flag;
	}

	public string GetLevelRelationInfo()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(LevelName + ": ");
		foreach (FMovieTriggerRelationInfo relationInfo in RelationInfos)
		{
			stringBuilder.AppendLine($"\t{relationInfo}");
		}
		return stringBuilder.ToString();
	}

	public string GetLevelBriefInfo()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(LevelName + ": ");
		foreach (FMovieAnalysisInfo movie in Movies)
		{
			if (movie.ProcessMovieCallStack.Count == 0)
			{
				continue;
			}
			stringBuilder.AppendLine("\t" + BGW_StringExtensions.ConvertSoftObjPath2AssetName(movie.MovieGraphPath) + " :");
			foreach (FMovieTriggerRelationInfo triggerRelation in movie.TriggerRelations)
			{
				stringBuilder.AppendLine($"\t\t{triggerRelation}");
			}
		}
		stringBuilder.AppendLine();
		return stringBuilder.ToString();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("LevelName:" + LevelName);
		foreach (FMovieAnalysisInfo movie in Movies)
		{
			stringBuilder.AppendLine($"{movie}");
		}
		return stringBuilder.ToString();
	}
}
