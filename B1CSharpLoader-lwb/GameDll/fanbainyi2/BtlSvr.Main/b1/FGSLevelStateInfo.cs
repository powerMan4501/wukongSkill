using System.Collections.Generic;

namespace b1;

public class FGSLevelStateInfo
{
	public string LevelName;

	public EGSLevelState LevelState;

	public bool BlockOnLoad;

	public bool DisableKeyword;

	public EGSLevelStateInfoLayerType StateLayer;

	public List<FGSLevelStateRequesterInfo> Requesters;

	private const string Unrecorded = "Unrecorded.";

	public FGSLevelStateInfo(FGSLevelStateInfo Other)
	{
		LevelName = Other.LevelName;
		LevelState = Other.LevelState;
		BlockOnLoad = Other.BlockOnLoad;
		StateLayer = Other.StateLayer;
		DisableKeyword = Other.DisableKeyword;
		Requesters = new List<FGSLevelStateRequesterInfo>(Other.Requesters);
	}

	public FGSLevelStateInfo(string LevelName, FGSLevelStateInfo Other)
	{
		this.LevelName = LevelName;
		LevelState = Other.LevelState;
		BlockOnLoad = Other.BlockOnLoad;
		StateLayer = Other.StateLayer;
		DisableKeyword = Other.DisableKeyword;
		Requesters = new List<FGSLevelStateRequesterInfo>(Other.Requesters);
	}

	public FGSLevelStateInfo(string levelName, EGSLevelState levelState, bool disableKeyword, EGSLevelStateInfoLayerType stateLayer, string RequesterName, bool blockOnLoad = false)
	{
		LevelName = levelName;
		LevelState = levelState;
		BlockOnLoad = blockOnLoad;
		DisableKeyword = disableKeyword;
		StateLayer = stateLayer;
		Requesters = new List<FGSLevelStateRequesterInfo>();
		if (RequesterName != null)
		{
			Requesters.Add(new FGSLevelStateRequesterInfo(levelName, RequesterName, blockOnLoad, levelState, stateLayer));
		}
		else
		{
			Requesters.Add(new FGSLevelStateRequesterInfo(levelName, "Unrecorded.", blockOnLoad, levelState, stateLayer));
		}
		BlockOnLoad = blockOnLoad;
	}

	public bool MergeInfo(FGSLevelStateInfo OtherInfo)
	{
		MergeRequesters(OtherInfo);
		if (StateLayer > OtherInfo.StateLayer)
		{
			return true;
		}
		LevelState = OtherInfo.LevelState;
		BlockOnLoad |= OtherInfo.BlockOnLoad;
		DisableKeyword = ((StateLayer == OtherInfo.StateLayer) ? (DisableKeyword & OtherInfo.DisableKeyword) : OtherInfo.DisableKeyword);
		bool result = StateLayer < OtherInfo.StateLayer;
		StateLayer = OtherInfo.StateLayer;
		return result;
	}

	public void MergeRequesters(FGSLevelStateInfo OtherInfo)
	{
		foreach (FGSLevelStateRequesterInfo OtherRequester in OtherInfo.Requesters)
		{
			int num = Requesters.FindIndex((FGSLevelStateRequesterInfo r) => r.Requester == OtherRequester.Requester && r.LevelState == OtherRequester.LevelState);
			if (num >= 0)
			{
				Requesters[num] = OtherRequester;
			}
			else
			{
				Requesters.Add(OtherRequester);
			}
		}
	}

	public void ReplaceBy(FGSLevelStateInfo Other)
	{
		LevelState = Other.LevelState;
		BlockOnLoad = Other.BlockOnLoad;
		StateLayer = Other.StateLayer;
		DisableKeyword = Other.DisableKeyword;
		Requesters.Clear();
		Requesters.AddRange(Other.Requesters);
	}

	public bool GetConflictedRequesters(ref Dictionary<EGSLevelStateInfoLayerType, List<string>> LayeredRequesters, ref Dictionary<EGSLevelStateInfoLayerType, EGSLevelState> RequestedStates)
	{
		if (LayeredRequesters == null)
		{
			LayeredRequesters = new Dictionary<EGSLevelStateInfoLayerType, List<string>>();
		}
		else
		{
			foreach (List<string> value3 in LayeredRequesters.Values)
			{
				value3.Clear();
			}
		}
		if (RequestedStates == null)
		{
			RequestedStates = new Dictionary<EGSLevelStateInfoLayerType, EGSLevelState>();
		}
		else
		{
			RequestedStates.Clear();
		}
		bool flag = false;
		foreach (FGSLevelStateRequesterInfo requester in Requesters)
		{
			string item = $"{requester.Requester} | State : {requester.LevelState} | 关键词 : {requester.RequestName}";
			if (LayeredRequesters.TryGetValue(requester.StateLayer, out var value))
			{
				value.Add(item);
			}
			else
			{
				LayeredRequesters.Add(requester.StateLayer, new List<string> { item });
			}
			if (RequestedStates.TryGetValue(requester.StateLayer, out var value2))
			{
				flag |= requester.LevelState != value2;
			}
			else
			{
				RequestedStates.Add(requester.StateLayer, requester.LevelState);
			}
		}
		return flag;
	}
}
