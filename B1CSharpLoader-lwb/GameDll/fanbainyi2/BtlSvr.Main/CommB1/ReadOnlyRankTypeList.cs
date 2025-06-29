using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyRankTypeList : ReadOnlyPrimitiveList<RankType>
{
	public ReadOnlyRankTypeList(RepeatedField<RankType> pbData)
		: base(pbData)
	{
	}
}
