using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEFollowPartnerSpawnTypeList : ReadOnlyPrimitiveList<EFollowPartnerSpawnType>
{
	public ReadOnlyEFollowPartnerSpawnTypeList(RepeatedField<EFollowPartnerSpawnType> pbData)
		: base(pbData)
	{
	}
}
