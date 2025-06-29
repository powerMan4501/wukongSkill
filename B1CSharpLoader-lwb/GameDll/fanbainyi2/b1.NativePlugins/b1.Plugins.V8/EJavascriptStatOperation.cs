using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UEnum]
[UMetaPath("/Script/V8.EJavascriptStatOperation", "V8", UnrealModuleType.GamePlugin)]
public enum EJavascriptStatOperation
{
	Invalid,
	SetLongName,
	AdvanceFrameEventGameThread,
	AdvanceFrameEventRenderThread,
	CycleScopeStart,
	CycleScopeEnd,
	SpecialMessageMarker,
	Set,
	Clear,
	Add,
	Subtract,
	ChildrenStart,
	ChildrenEnd,
	Leaf,
	MaxVal,
	Memory
}
