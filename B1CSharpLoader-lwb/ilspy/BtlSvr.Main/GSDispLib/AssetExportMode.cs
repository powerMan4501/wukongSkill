using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.AssetExportMode")]
public enum AssetExportMode : byte
{
	INCREMENT,
	COMPLETELY,
	CUSTOM_NAME,
	ONLY_JSON_DATA
}
