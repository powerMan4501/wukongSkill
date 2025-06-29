using UnrealEngine.Runtime;

namespace UnrealEngine.WindowsTargetPlatform;

[UEnum]
[UMetaPath("/Script/WindowsTargetPlatform.EWindowsRHIFeatureLevel", "WindowsTargetPlatform", UnrealModuleType.Engine)]
public enum EWindowsRHIFeatureLevel
{
	ES3_1,
	SM5,
	SM6
}
