using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProjectileObjSpdTypeList : ReadOnlyPrimitiveList<EProjectileObjSpdType>
{
	public ReadOnlyEProjectileObjSpdTypeList(RepeatedField<EProjectileObjSpdType> pbData)
		: base(pbData)
	{
	}
}
