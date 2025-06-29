using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEACFactDataOperateTypeList : ReadOnlyPrimitiveList<EACFactDataOperateType>
{
	public ReadOnlyEACFactDataOperateTypeList(RepeatedField<EACFactDataOperateType> pbData)
		: base(pbData)
	{
	}
}
