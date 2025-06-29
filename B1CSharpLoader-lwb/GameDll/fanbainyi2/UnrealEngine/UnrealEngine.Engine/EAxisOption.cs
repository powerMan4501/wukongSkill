using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAxisOption", "Engine", UnrealModuleType.Engine)]
public enum EAxisOption
{
	X,
	Y,
	Z,
	X_Neg,
	Y_Neg,
	Z_Neg,
	Custom
}
