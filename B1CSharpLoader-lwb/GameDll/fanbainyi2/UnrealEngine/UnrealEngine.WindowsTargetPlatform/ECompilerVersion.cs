using UnrealEngine.Runtime;

namespace UnrealEngine.WindowsTargetPlatform;

[UEnum]
[UMetaPath("/Script/WindowsTargetPlatform.ECompilerVersion", "WindowsTargetPlatform", UnrealModuleType.Engine)]
public enum ECompilerVersion
{
	Default,
	VisualStudio2015,
	VisualStudio2017,
	VisualStudio2019,
	VisualStudio2022
}
