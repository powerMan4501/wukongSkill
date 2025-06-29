using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUC_GMUIData
{
	[BlueprintReadWrite]
	[UProperty]
	public FVector OwnerPos { get; set; }
}
