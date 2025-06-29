using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyMoneyTypeList : ReadOnlyPrimitiveList<MoneyType>
{
	public ReadOnlyMoneyTypeList(RepeatedField<MoneyType> pbData)
		: base(pbData)
	{
	}
}
