using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyCommCfgTypeList : ReadOnlyPrimitiveList<CommCfgType>
{
	public ReadOnlyCommCfgTypeList(RepeatedField<CommCfgType> pbData)
		: base(pbData)
	{
	}
}
