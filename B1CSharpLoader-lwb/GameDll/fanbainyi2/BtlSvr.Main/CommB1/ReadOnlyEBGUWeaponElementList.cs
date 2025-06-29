using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEBGUWeaponElementList : ReadOnlyPrimitiveList<EBGUWeaponElement>
{
	public ReadOnlyEBGUWeaponElementList(RepeatedField<EBGUWeaponElement> pbData)
		: base(pbData)
	{
	}
}
