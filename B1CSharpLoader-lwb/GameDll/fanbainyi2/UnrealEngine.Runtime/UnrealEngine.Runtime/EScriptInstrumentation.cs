namespace UnrealEngine.Runtime;

public enum EScriptInstrumentation
{
	Class,
	ClassScope,
	Instance,
	Event,
	InlineEvent,
	ResumeEvent,
	PureNodeEntry,
	NodeDebugSite,
	NodeEntry,
	NodeExit,
	PushState,
	RestoreState,
	ResetState,
	SuspendState,
	PopState,
	TunnelEndOfThread,
	Stop
}
