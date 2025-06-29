using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UEnum]
[UMetaPath("/Script/Paper2D.ESpritePivotMode", "Paper2D", UnrealModuleType.EnginePlugin)]
public enum ESpritePivotMode
{
	Top_Left,
	Top_Center,
	Top_Right,
	Center_Left,
	Center_Center,
	Center_Right,
	Bottom_Left,
	Bottom_Center,
	Bottom_Right,
	Custom
}
