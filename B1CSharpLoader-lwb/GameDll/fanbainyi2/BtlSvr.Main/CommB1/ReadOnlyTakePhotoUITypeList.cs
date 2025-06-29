using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTakePhotoUITypeList : ReadOnlyPrimitiveList<TakePhotoUIType>
{
	public ReadOnlyTakePhotoUITypeList(RepeatedField<TakePhotoUIType> pbData)
		: base(pbData)
	{
	}
}
