using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyShopItemAppendTypeList : ReadOnlyPrimitiveList<ShopItemAppendType>
{
	public ReadOnlyShopItemAppendTypeList(RepeatedField<ShopItemAppendType> pbData)
		: base(pbData)
	{
	}
}
