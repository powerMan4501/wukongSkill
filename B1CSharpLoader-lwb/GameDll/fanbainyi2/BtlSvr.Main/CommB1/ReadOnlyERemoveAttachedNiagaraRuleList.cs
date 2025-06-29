using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyERemoveAttachedNiagaraRuleList : ReadOnlyPrimitiveList<ERemoveAttachedNiagaraRule>
{
	public ReadOnlyERemoveAttachedNiagaraRuleList(RepeatedField<ERemoveAttachedNiagaraRule> pbData)
		: base(pbData)
	{
	}
}
