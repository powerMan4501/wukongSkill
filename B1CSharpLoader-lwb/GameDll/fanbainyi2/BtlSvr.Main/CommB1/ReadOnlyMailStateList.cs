using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailStateList : ReadOnlyPrimitiveList<MailState>
{
	public ReadOnlyMailStateList(RepeatedField<MailState> pbData)
		: base(pbData)
	{
	}
}
