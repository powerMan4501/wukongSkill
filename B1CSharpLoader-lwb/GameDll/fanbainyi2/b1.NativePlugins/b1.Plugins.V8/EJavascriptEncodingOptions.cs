using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UEnum]
[UMetaPath("/Script/V8.EJavascriptEncodingOptions", "V8", UnrealModuleType.GamePlugin)]
public enum EJavascriptEncodingOptions
{
	AutoDetect,
	ForceAnsi,
	ForceUnicode,
	ForceUTF8,
	ForceUTF8WithoutBOM
}
