using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EJavascriptMessageSeverity", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJavascriptMessageSeverity
{
	CriticalError,
	Error,
	PerformanceWarning,
	Warning,
	Info
}
