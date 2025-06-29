using System;

namespace UnrealEngine.Runtime;

[Flags]
public enum EObjectMark : uint
{
	NOMARKS = 0u,
	Saved = 4u,
	TagImp = 8u,
	TagExp = 0x10u,
	NotForClient = 0x20u,
	NotForServer = 0x40u,
	NotAlwaysLoadedForEditorGame = 0x80u,
	EditorOnly = 0x100u,
	ALLMARKS = uint.MaxValue
}
