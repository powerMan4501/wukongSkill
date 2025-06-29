using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyActivationStateList : ReadOnlyPrimitiveList<ActivationState>
{
	public ReadOnlyActivationStateList(RepeatedField<ActivationState> pbData)
		: base(pbData)
	{
	}
}
