using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMobStrengthLevelList : ReadOnlyPrimitiveList<EMobStrengthLevel>
{
	public ReadOnlyEMobStrengthLevelList(RepeatedField<EMobStrengthLevel> pbData)
		: base(pbData)
	{
	}
}
