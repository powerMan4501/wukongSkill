using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAttachNiagaraEventTypeList : ReadOnlyPrimitiveList<EAttachNiagaraEventType>
{
	public ReadOnlyEAttachNiagaraEventTypeList(RepeatedField<EAttachNiagaraEventType> pbData)
		: base(pbData)
	{
	}
}
