using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DropItemFlyCurveType")]
public enum EDropItemFlyCurveType : byte
{
	FastBezier,
	CurveTranslation
}
