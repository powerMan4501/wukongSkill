using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UEnum]
[UMetaPath("/Script/V8.ELogVerbosity_JS", "V8", UnrealModuleType.GamePlugin)]
public enum ELogVerbosity_JS
{
	NoLogging,
	Fatal,
	Error,
	Warning,
	Display,
	Log,
	Verbose,
	VeryVerbose
}
