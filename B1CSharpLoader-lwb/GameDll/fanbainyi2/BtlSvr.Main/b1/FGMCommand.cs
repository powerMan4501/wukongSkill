using System;
using UnrealEngine.UMG;

namespace b1;

public class FGMCommand
{
	public EGMCommandType CommandType { get; set; }

	public string CommandName { get; set; }

	public bool bEnable { get; set; }

	public FOnCheckBoxComponentStateChanged.Signature CheckSignature { get; set; }

	public Func<bool, string> Func_GetCommand { get; set; }

	public string GetCommand()
	{
		return Func_GetCommand(bEnable);
	}
}
