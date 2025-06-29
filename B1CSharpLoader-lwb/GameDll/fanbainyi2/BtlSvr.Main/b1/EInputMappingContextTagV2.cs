using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.InputMappingContextTagV2")]
public enum EInputMappingContextTagV2 : byte
{
	None,
	[DisplayName("移动")]
	Move,
	[DisplayName("镜头")]
	Camera,
	[DisplayName("技能")]
	Skill,
	[DisplayName("组合键")]
	Chord,
	[DisplayName("交互")]
	Interact,
	[DisplayName("坐骑")]
	Ride,
	[DisplayName("UI输入")]
	UI,
	[DisplayName("UI输入(Top)")]
	GSUI_TOP,
	[DisplayName("战斗下UI")]
	Battle_UI,
	[DisplayName("战斗下UI松手")]
	Battle_UI_Release,
	[DisplayName("战斗下UI跳过")]
	Battle_UI_Skip,
	[DisplayName("回放")]
	Replay,
	[DisplayName("820试玩")]
	GM_Temp,
	[DisplayName("解冻")]
	Unfreeze,
	[DisplayName("翻滚和冲刺")]
	SprintAndDodge,
	[DisplayName("法术和物品")]
	SpellAndUseItem,
	[DisplayName("Loading Screen")]
	LoadingScreen,
	[DisplayName("筋斗云")]
	Cloud,
	[DisplayName("Debug")]
	ShepherdDebug,
	[DisplayName("交互跳过")]
	InteractSkip,
	[DisplayName("拍照模式")]
	TakePhoto,
	[DisplayName("蛐蛐模式")]
	CricketBattle,
	[DisplayName("远程镜头控制")]
	RemoteCamera,
	[DisplayName("战斗触发UI输入")]
	BattleTriggerUI,
	[DisplayName("人种袋")]
	Vigor,
	[DisplayName("GM")]
	GM,
	[DisplayName("地图")]
	Map
}
