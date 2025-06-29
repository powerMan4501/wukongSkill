using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyECharacterModularTypeList : ReadOnlyPrimitiveList<ECharacterModularType>
{
	public ReadOnlyECharacterModularTypeList(RepeatedField<ECharacterModularType> pbData)
		: base(pbData)
	{
	}
}
