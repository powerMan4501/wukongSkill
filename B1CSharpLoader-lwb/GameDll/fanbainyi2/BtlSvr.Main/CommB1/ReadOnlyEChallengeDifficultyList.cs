using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEChallengeDifficultyList : ReadOnlyPrimitiveList<EChallengeDifficulty>
{
	public ReadOnlyEChallengeDifficultyList(RepeatedField<EChallengeDifficulty> pbData)
		: base(pbData)
	{
	}
}
