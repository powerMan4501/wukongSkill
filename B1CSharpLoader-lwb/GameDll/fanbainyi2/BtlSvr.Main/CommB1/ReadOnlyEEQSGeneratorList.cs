using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEEQSGeneratorList : ReadOnlyPrimitiveList<EEQSGenerator>
{
	public ReadOnlyEEQSGeneratorList(RepeatedField<EEQSGenerator> pbData)
		: base(pbData)
	{
	}
}
