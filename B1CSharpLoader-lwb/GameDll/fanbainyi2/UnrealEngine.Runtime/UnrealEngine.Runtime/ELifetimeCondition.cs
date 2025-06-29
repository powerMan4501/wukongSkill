namespace UnrealEngine.Runtime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.ELifetimeCondition", "CoreUObject", UnrealModuleType.Engine)]
public enum ELifetimeCondition
{
	[UMeta(MDEnum.DisplayName, "None")]
	None,
	[UMeta(MDEnum.DisplayName, "Initial Only")]
	InitialOnly,
	[UMeta(MDEnum.DisplayName, "Owner Only")]
	OwnerOnly,
	[UMeta(MDEnum.DisplayName, "Skip Owner")]
	SkipOwner,
	[UMeta(MDEnum.DisplayName, "Simulated Only")]
	SimulatedOnly,
	[UMeta(MDEnum.DisplayName, "Autonomous Only")]
	AutonomousOnly,
	[UMeta(MDEnum.DisplayName, "Simulated Or Physics")]
	SimulatedOrPhysics,
	[UMeta(MDEnum.DisplayName, "Initial Or Owner")]
	InitialOrOwner,
	[UMeta(MDEnum.DisplayName, "Custom")]
	Custom,
	[UMeta(MDEnum.DisplayName, "Replay Or Owner")]
	ReplayOrOwner,
	[UMeta(MDEnum.DisplayName, "Replay Only")]
	ReplayOnly,
	[UMeta(MDEnum.DisplayName, "Simulated Only No Replay")]
	SimulatedOnlyNoReplay,
	[UMeta(MDEnum.DisplayName, "Simulated Or Physics No Replay")]
	SimulatedOrPhysicsNoReplay,
	[UMeta(MDEnum.DisplayName, "Skip Replay")]
	SkipReplay
}
