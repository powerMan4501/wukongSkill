using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLobyConstList : ReadOnlyPrimitiveList<LobyConst>
{
	public ReadOnlyLobyConstList(RepeatedField<LobyConst> pbData)
		: base(pbData)
	{
	}
}
