using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailInnerTypeList : ReadOnlyPrimitiveList<MailInnerType>
{
	public ReadOnlyMailInnerTypeList(RepeatedField<MailInnerType> pbData)
		: base(pbData)
	{
	}
}
