using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEMenuBtnActionTypeList : ReadOnlyPrimitiveList<EMenuBtnActionType>
{
	public ReadOnlyEMenuBtnActionTypeList(RepeatedField<EMenuBtnActionType> pbData)
		: base(pbData)
	{
	}
}
