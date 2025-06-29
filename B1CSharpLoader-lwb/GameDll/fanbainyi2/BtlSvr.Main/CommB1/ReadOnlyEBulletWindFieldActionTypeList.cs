using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBulletWindFieldActionTypeList : ReadOnlyPrimitiveList<EBulletWindFieldActionType>
{
	public ReadOnlyEBulletWindFieldActionTypeList(RepeatedField<EBulletWindFieldActionType> pbData)
		: base(pbData)
	{
	}
}
