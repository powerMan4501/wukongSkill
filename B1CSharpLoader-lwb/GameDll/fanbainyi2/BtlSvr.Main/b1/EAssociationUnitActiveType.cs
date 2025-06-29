using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.AssociationUnitActiveType")]
public enum EAssociationUnitActiveType : byte
{
	[DisplayName("立刻激活")]
	ActiveImmediately,
	[DisplayName("不激活")]
	NoActive
}
