using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EGSSceneActorActivationType")]
public enum EGSSceneActorActivationType : byte
{
	[DisplayName("物理模拟")]
	[UMeta(MD.Hidden)]
	[Tooltip("开关物理模拟")]
	PhysicsSimulation,
	[Tooltip("开关特效显示")]
	[DisplayName("特效显示")]
	EmitterActivation,
	[DisplayName("允许Tick")]
	[Tooltip("开关允许Tick")]
	TickEnable,
	[Tooltip("应用某些BGUActor所设定的休眠策略")]
	[DisplayName("BGUActor休眠策略")]
	BGUActorActivation,
	[DisplayName("隐藏")]
	[Tooltip("按距离隐藏，Actor离开距离隐藏，进入距离显示")]
	HiddenInGame,
	[Tooltip("按距离隐藏，Actor离开关闭碰撞，进入距离开启碰撞")]
	[DisplayName("碰撞开关")]
	ActorCollision
}
