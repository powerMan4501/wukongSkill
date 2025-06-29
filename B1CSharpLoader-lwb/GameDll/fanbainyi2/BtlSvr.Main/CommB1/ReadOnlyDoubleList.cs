using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyDoubleList : ReadOnlyPrimitiveList<double>
{
	public ReadOnlyDoubleList(RepeatedField<double> pbData)
		: base(pbData)
	{
	}
}
