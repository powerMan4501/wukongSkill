namespace UnrealEngine.Runtime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.EPropertyAccessChangeNotifyMode", "CoreUObject", UnrealModuleType.Engine)]
public enum EPropertyAccessChangeNotifyMode : byte
{
	Default,
	Never,
	Always
}
