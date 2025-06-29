using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyHistoricTypeList : ReadOnlyPrimitiveList<HistoricType>
{
	public ReadOnlyHistoricTypeList(RepeatedField<HistoricType> pbData)
		: base(pbData)
	{
	}
}
