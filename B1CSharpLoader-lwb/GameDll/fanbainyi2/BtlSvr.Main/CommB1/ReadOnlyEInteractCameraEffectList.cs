using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEInteractCameraEffectList : ReadOnlyPrimitiveList<EInteractCameraEffect>
{
	public ReadOnlyEInteractCameraEffectList(RepeatedField<EInteractCameraEffect> pbData)
		: base(pbData)
	{
	}
}
