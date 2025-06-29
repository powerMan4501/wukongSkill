using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailTypeList : ReadOnlyPrimitiveList<MailType>
{
	public ReadOnlyMailTypeList(RepeatedField<MailType> pbData)
		: base(pbData)
	{
	}
}
