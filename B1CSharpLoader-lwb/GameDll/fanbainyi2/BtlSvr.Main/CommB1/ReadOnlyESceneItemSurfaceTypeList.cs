using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESceneItemSurfaceTypeList : ReadOnlyPrimitiveList<ESceneItemSurfaceType>
{
	public ReadOnlyESceneItemSurfaceTypeList(RepeatedField<ESceneItemSurfaceType> pbData)
		: base(pbData)
	{
	}
}
