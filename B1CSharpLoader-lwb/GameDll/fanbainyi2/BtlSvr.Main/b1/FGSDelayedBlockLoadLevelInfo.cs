using System.Collections.Generic;

namespace b1;

public class FGSDelayedBlockLoadLevelInfo
{
	public int OperationID;

	public EGSLevelState LevelState;

	public List<string> LevelNames;

	public FGSDelayedBlockLoadLevelInfo(int operationID, EGSLevelState levelState, List<string> levelNames)
	{
		OperationID = operationID;
		LevelState = levelState;
		LevelNames = new List<string>(levelNames);
	}
}
