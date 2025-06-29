using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTakePhotoConfigTabList : ReadOnlyPrimitiveList<TakePhotoConfigTab>
{
	public ReadOnlyTakePhotoConfigTabList(RepeatedField<TakePhotoConfigTab> pbData)
		: base(pbData)
	{
	}
}
