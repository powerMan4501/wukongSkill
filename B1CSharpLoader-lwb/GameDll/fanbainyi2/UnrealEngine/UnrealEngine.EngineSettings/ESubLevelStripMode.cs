using UnrealEngine.Runtime;

namespace UnrealEngine.EngineSettings;

[UEnum]
[UMetaPath("/Script/EngineSettings.ESubLevelStripMode", "EngineSettings", UnrealModuleType.Engine)]
public enum ESubLevelStripMode
{
	ExactClass,
	IsChildOf
}
