using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProjectileScaleCurveXAxisTypeList : ReadOnlyPrimitiveList<EProjectileScaleCurveXAxisType>
{
	public ReadOnlyEProjectileScaleCurveXAxisTypeList(RepeatedField<EProjectileScaleCurveXAxisType> pbData)
		: base(pbData)
	{
	}
}
