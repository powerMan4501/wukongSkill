using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAttenuationShape", "Engine", UnrealModuleType.Engine)]
public enum EAttenuationShape : byte
{
	Sphere,
	Capsule,
	Box,
	Cone
}
