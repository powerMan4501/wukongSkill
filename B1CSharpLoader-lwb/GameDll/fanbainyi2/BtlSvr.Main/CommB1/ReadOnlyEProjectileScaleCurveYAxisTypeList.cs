using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProjectileScaleCurveYAxisTypeList : ReadOnlyPrimitiveList<EProjectileScaleCurveYAxisType>
{
	public ReadOnlyEProjectileScaleCurveYAxisTypeList(RepeatedField<EProjectileScaleCurveYAxisType> pbData)
		: base(pbData)
	{
	}
}
