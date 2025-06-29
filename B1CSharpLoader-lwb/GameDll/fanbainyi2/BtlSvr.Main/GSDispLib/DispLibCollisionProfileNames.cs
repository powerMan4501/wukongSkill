using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.DispLibCollisionProfileNames")]
public enum DispLibCollisionProfileNames : byte
{
	NoCollision,
	BlockAll,
	OverlapAll,
	BlockAllDynamic,
	GroundBrick,
	Rock_Big,
	Rock_Small
}
