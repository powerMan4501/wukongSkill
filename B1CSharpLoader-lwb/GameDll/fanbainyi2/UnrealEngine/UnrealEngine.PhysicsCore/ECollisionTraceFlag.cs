using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PhysicsCore.ECollisionTraceFlag", "PhysicsCore", UnrealModuleType.Engine)]
public enum ECollisionTraceFlag : byte
{
	CTF_UseDefault,
	CTF_UseSimpleAndComplex,
	CTF_UseSimpleAsComplex,
	CTF_UseComplexAsSimple
}
