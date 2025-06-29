using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyDisplayControl820List : ReadOnlyPrimitiveList<DisplayControl820>
{
	public ReadOnlyDisplayControl820List(RepeatedField<DisplayControl820> pbData)
		: base(pbData)
	{
	}
}
