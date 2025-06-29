using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMotionBlurTypeList : ReadOnlyPrimitiveList<EMotionBlurType>
{
	public ReadOnlyEMotionBlurTypeList(RepeatedField<EMotionBlurType> pbData)
		: base(pbData)
	{
	}
}
