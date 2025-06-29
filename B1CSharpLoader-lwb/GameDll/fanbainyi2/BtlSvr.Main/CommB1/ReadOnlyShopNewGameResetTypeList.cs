using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyShopNewGameResetTypeList : ReadOnlyPrimitiveList<ShopNewGameResetType>
{
	public ReadOnlyShopNewGameResetTypeList(RepeatedField<ShopNewGameResetType> pbData)
		: base(pbData)
	{
	}
}
