using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEPigsyStoryIAndRTypeList : ReadOnlyPrimitiveList<EPigsyStoryIAndRType>
{
	public ReadOnlyEPigsyStoryIAndRTypeList(RepeatedField<EPigsyStoryIAndRType> pbData)
		: base(pbData)
	{
	}
}
