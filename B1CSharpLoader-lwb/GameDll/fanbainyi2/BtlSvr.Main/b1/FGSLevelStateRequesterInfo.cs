namespace b1;

public class FGSLevelStateRequesterInfo
{
	public string RequestName { get; }

	public string Requester { get; }

	public bool BlockOnLoad { get; }

	public EGSLevelState LevelState { get; }

	public EGSLevelStateInfoLayerType StateLayer { get; }

	public FGSLevelStateRequesterInfo(string requestName, string requester, bool blockOnLoad, EGSLevelState levelState, EGSLevelStateInfoLayerType stateLayer)
	{
		RequestName = requestName;
		Requester = requester;
		BlockOnLoad = blockOnLoad;
		LevelState = levelState;
		StateLayer = stateLayer;
	}
}
