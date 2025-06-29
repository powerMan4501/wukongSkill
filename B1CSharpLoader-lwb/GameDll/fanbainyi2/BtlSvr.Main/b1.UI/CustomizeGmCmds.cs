using System.Collections.Generic;

namespace b1.UI;

internal struct CustomizeGmCmds
{
	public string CmdName;

	public List<string> Cmds;

	public CustomizeGmCmds(string name, List<string> cmds)
	{
		CmdName = name;
		Cmds = new List<string>(cmds.ToArray());
	}
}
