using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBytesList : ReadOnlyPrimitiveList<ByteString>
{
	public ReadOnlyBytesList(RepeatedField<ByteString> pbData)
		: base(pbData)
	{
	}
}
