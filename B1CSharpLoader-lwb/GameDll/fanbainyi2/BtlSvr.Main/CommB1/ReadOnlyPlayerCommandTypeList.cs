using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPlayerCommandTypeList : ReadOnlyPrimitiveList<PlayerCommandType>
{
	public ReadOnlyPlayerCommandTypeList(RepeatedField<PlayerCommandType> pbData)
		: base(pbData)
	{
	}
}
