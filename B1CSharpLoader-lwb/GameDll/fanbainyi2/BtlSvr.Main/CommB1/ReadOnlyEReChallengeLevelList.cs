using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEReChallengeLevelList : ReadOnlyPrimitiveList<EReChallengeLevel>
{
	public ReadOnlyEReChallengeLevelList(RepeatedField<EReChallengeLevel> pbData)
		: base(pbData)
	{
	}
}
