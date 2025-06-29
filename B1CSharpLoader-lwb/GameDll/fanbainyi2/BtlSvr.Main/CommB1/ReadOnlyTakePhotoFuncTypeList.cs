using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTakePhotoFuncTypeList : ReadOnlyPrimitiveList<TakePhotoFuncType>
{
	public ReadOnlyTakePhotoFuncTypeList(RepeatedField<TakePhotoFuncType> pbData)
		: base(pbData)
	{
	}
}
