using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECooperativeStatusList : ReadOnlyPrimitiveList<ECooperativeStatus>
{
	public ReadOnlyECooperativeStatusList(RepeatedField<ECooperativeStatus> pbData)
		: base(pbData)
	{
	}
}
