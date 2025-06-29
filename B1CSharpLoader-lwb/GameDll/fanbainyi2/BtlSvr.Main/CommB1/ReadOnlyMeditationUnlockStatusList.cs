using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMeditationUnlockStatusList : ReadOnlyPrimitiveList<MeditationUnlockStatus>
{
	public ReadOnlyMeditationUnlockStatusList(RepeatedField<MeditationUnlockStatus> pbData)
		: base(pbData)
	{
	}
}
