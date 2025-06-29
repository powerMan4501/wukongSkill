using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEUIConfigTabList : ReadOnlyPrimitiveList<EUIConfigTab>
{
	public ReadOnlyEUIConfigTabList(RepeatedField<EUIConfigTab> pbData)
		: base(pbData)
	{
	}
}
