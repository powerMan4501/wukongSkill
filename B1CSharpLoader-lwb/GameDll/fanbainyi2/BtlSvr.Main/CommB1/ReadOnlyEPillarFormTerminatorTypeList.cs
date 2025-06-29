using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEPillarFormTerminatorTypeList : ReadOnlyPrimitiveList<EPillarFormTerminatorType>
{
	public ReadOnlyEPillarFormTerminatorTypeList(RepeatedField<EPillarFormTerminatorType> pbData)
		: base(pbData)
	{
	}
}
