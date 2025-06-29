using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwolMsgTypeList : ReadOnlyPrimitiveList<AwolMsgType>
{
	public ReadOnlyAwolMsgTypeList(RepeatedField<AwolMsgType> pbData)
		: base(pbData)
	{
	}
}
