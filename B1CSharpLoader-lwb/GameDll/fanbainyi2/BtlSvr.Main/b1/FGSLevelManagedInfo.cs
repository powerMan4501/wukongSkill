namespace b1;

public class FGSLevelManagedInfo
{
	public EGSLevelState LevelState;

	public string RequesterID { get; }

	public FGSLevelManagedInfo(string requesterID, EGSLevelState levelState)
	{
		RequesterID = requesterID;
		LevelState = levelState;
	}

	public void ChangeLevelState(EGSLevelState levelState)
	{
		LevelState = levelState;
	}
}
