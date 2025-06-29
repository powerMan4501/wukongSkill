using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailContentTypeList : ReadOnlyPrimitiveList<MailContentType>
{
	public ReadOnlyMailContentTypeList(RepeatedField<MailContentType> pbData)
		: base(pbData)
	{
	}
}
