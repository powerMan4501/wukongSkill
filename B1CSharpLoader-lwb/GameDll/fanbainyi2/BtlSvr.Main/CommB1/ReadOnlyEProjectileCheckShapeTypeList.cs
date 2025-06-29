using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProjectileCheckShapeTypeList : ReadOnlyPrimitiveList<EProjectileCheckShapeType>
{
	public ReadOnlyEProjectileCheckShapeTypeList(RepeatedField<EProjectileCheckShapeType> pbData)
		: base(pbData)
	{
	}
}
