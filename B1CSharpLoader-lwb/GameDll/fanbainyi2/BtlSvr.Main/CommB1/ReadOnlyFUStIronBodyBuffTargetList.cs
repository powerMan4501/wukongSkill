using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyFUStIronBodyBuffTargetList : ReadOnlyPrimitiveList<FUStIronBodyBuffTarget>
{
	public ReadOnlyFUStIronBodyBuffTargetList(RepeatedField<FUStIronBodyBuffTarget> pbData)
		: base(pbData)
	{
	}
}
