using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyShopRefreshTypeList : ReadOnlyPrimitiveList<ShopRefreshType>
{
	public ReadOnlyShopRefreshTypeList(RepeatedField<ShopRefreshType> pbData)
		: base(pbData)
	{
	}
}
