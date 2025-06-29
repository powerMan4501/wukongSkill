using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyESuperResolutionsamplingList : ReadOnlyPrimitiveList<ESuperResolutionsampling>
{
	public ReadOnlyESuperResolutionsamplingList(RepeatedField<ESuperResolutionsampling> pbData)
		: base(pbData)
	{
	}
}
