using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_ExecuteGMSystemComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_ExecuteCommandGM += new Del_Void_StringList(OnExecuteCommandGM);
	}

	private void OnExecuteCommandGM(List<string> ListArgs)
	{
		ParseArgs(ListArgs, out var name, out var args);
		RequireReadOnlyData<IBUC_GMSystemData, BUC_GMSystemData>()?.GetCommandByName(name)?.Invoke(args);
	}

	private void ParseArgs(List<string> listArgs, out string name, out string[] args)
	{
		if (listArgs.Count == 1)
		{
			name = listArgs[0];
			args = Array.Empty<string>();
		}
		else if (listArgs.Count > 1)
		{
			name = listArgs[0];
			args = listArgs.Skip(1).ToArray();
		}
		else
		{
			name = null;
			args = null;
		}
	}
}
