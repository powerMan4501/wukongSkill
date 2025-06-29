using UnrealEngine.Runtime;

namespace b1;

[UMeta(MDEnum.UseEnumValuesAsMaskValuesInEditor, true)]
[UMeta(MDEnum.Bitflags)]
[UEnum]
[USharpPath("/Script/b1-Managed.EnvironmentItemStateMachineAbilityType")]
public enum EEnvironmentItemStateMachineAbilityType : byte
{
	[UMeta(MD.Hidden)]
	Default = 0,
	[UMeta(MDFunc.DisplayName, "播放字幕功能")]
	PlayDialogue = 2
}
