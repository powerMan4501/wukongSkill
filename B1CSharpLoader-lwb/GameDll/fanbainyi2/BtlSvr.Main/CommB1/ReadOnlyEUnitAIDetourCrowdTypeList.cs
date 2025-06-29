using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEUnitAIDetourCrowdTypeList : ReadOnlyPrimitiveList<EUnitAIDetourCrowdType>
{
	public ReadOnlyEUnitAIDetourCrowdTypeList(RepeatedField<EUnitAIDetourCrowdType> pbData)
		: base(pbData)
	{
	}
}
