using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlySignStyleList : ReadOnlyPrimitiveList<SignStyle>
{
	public ReadOnlySignStyleList(RepeatedField<SignStyle> pbData)
		: base(pbData)
	{
	}
}
