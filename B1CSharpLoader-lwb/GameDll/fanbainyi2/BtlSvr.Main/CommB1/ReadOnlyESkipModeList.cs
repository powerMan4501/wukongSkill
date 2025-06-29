using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkipModeList : ReadOnlyPrimitiveList<ESkipMode>
{
	public ReadOnlyESkipModeList(RepeatedField<ESkipMode> pbData)
		: base(pbData)
	{
	}
}
