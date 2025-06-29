using UnrealEngine.Runtime;

namespace b1;

internal interface IBUC_MFDirectionData
{
	EMagicFieldDirectionUsage MFDirectionUsage { get; }

	EMagicFieldDirectionType MFDirectionType { get; }

	EMagicFieldDirectionTypeDetail MFDirectionTypeDetail { get; }

	FName AnchorPointTag { get; }
}
