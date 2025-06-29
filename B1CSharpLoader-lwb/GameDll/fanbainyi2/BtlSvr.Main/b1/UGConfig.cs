using UnrealEngine.Runtime;

namespace b1;

public class UGConfig : UObject
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	public UGSViewPortHelper GSViewPortHelper { get; set; }
}
