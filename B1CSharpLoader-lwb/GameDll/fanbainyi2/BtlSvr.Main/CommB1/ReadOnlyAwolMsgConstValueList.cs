using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwolMsgConstValueList : ReadOnlyPrimitiveList<AwolMsgConstValue>
{
	public ReadOnlyAwolMsgConstValueList(RepeatedField<AwolMsgConstValue> pbData)
		: base(pbData)
	{
	}
}
