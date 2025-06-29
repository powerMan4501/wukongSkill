using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEPELevelInheritedTypeList : ReadOnlyPrimitiveList<EPELevelInheritedType>
{
	public ReadOnlyEPELevelInheritedTypeList(RepeatedField<EPELevelInheritedType> pbData)
		: base(pbData)
	{
	}
}
