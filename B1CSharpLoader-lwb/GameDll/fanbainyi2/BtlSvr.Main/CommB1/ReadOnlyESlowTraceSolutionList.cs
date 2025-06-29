using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESlowTraceSolutionList : ReadOnlyPrimitiveList<ESlowTraceSolution>
{
	public ReadOnlyESlowTraceSolutionList(RepeatedField<ESlowTraceSolution> pbData)
		: base(pbData)
	{
	}
}
