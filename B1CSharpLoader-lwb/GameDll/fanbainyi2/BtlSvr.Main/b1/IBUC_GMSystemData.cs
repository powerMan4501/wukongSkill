namespace b1;

public interface IBUC_GMSystemData
{
	void AddNameCommand(string Name, FConsoleCommandInGMSystemDelegate Command);

	FConsoleCommandInGMSystemDelegate GetCommandByName(string Name);
}
