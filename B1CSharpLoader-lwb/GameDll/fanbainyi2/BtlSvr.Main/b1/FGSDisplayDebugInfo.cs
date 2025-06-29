using System.Collections.Generic;
using b1.Plugins.GSDisplayDebug;
using UnrealEngine.Runtime;

namespace b1;

public class FGSDisplayDebugInfo
{
	public List<FGSDebugInfo> Infos = new List<FGSDebugInfo>();

	public void AppendInfo(string Info, FColor Color = default(FColor))
	{
		if (Color == default(FColor))
		{
			Color = FColor.White;
		}
		Infos.Add(new FGSDebugInfo
		{
			DebugColor = Color,
			DebugLine = Info
		});
	}
}
