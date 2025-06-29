using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.MovieConditionQueryType")]
public enum EMovieConditionQueryType : byte
{
	[DisplayName("所有关卡状态切换完毕")]
	AllLevelSwitchStateFinish,
	[DisplayName("群体单位出生完成")]
	GroupUnitBirthFinish
}
