using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyFUStGlobalConfigTypeList : ReadOnlyPrimitiveList<FUStGlobalConfigType>
{
	public ReadOnlyFUStGlobalConfigTypeList(RepeatedField<FUStGlobalConfigType> pbData)
		: base(pbData)
	{
	}
}
