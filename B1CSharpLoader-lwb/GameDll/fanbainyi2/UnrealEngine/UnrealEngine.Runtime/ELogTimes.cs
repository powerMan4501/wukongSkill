namespace UnrealEngine.Runtime;

[UEnum]
[UMetaPath("/Script/CoreUObject.ELogTimes", "CoreUObject", UnrealModuleType.Engine)]
public enum ELogTimes
{
	None,
	UTC,
	SinceGStartTime,
	Local
}
