using System.Collections.Generic;

namespace b1;

public class BUC_GMSystemData : IBUC_GMSystemData
{
	public Dictionary<string, FConsoleCommandInGMSystemDelegate> NameCommandDict { get; set; }

	public BUC_GMSystemData()
	{
		NameCommandDict = new Dictionary<string, FConsoleCommandInGMSystemDelegate>();
	}

	public void AddNameCommand(string Name, FConsoleCommandInGMSystemDelegate Command)
	{
		if (!NameCommandDict.ContainsKey(Name))
		{
			NameCommandDict.Add(Name, Command);
		}
	}

	public FConsoleCommandInGMSystemDelegate GetCommandByName(string Name)
	{
		if (NameCommandDict.ContainsKey(Name))
		{
			return NameCommandDict[Name];
		}
		return null;
	}
}
