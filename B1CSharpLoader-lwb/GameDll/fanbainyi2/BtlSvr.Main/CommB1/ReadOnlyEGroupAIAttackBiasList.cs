using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGroupAIAttackBiasList : ReadOnlyPrimitiveList<EGroupAIAttackBias>
{
	public ReadOnlyEGroupAIAttackBiasList(RepeatedField<EGroupAIAttackBias> pbData)
		: base(pbData)
	{
	}
}
