using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyManagedSceneObjTypeList : ReadOnlyPrimitiveList<ManagedSceneObjType>
{
	public ReadOnlyManagedSceneObjTypeList(RepeatedField<ManagedSceneObjType> pbData)
		: base(pbData)
	{
	}
}
