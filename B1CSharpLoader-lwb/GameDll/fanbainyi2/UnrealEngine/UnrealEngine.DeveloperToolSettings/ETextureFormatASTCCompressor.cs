using UnrealEngine.Runtime;

namespace UnrealEngine.DeveloperToolSettings;

[UEnum]
[UMetaPath("/Script/DeveloperToolSettings.ETextureFormatASTCCompressor", "DeveloperToolSettings", UnrealModuleType.Engine)]
public enum ETextureFormatASTCCompressor
{
	IntelISPC,
	Arm,
	Max
}
