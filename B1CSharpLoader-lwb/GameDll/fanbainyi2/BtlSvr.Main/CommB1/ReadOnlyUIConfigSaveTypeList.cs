using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyUIConfigSaveTypeList : ReadOnlyPrimitiveList<UIConfigSaveType>
{
	public ReadOnlyUIConfigSaveTypeList(RepeatedField<UIConfigSaveType> pbData)
		: base(pbData)
	{
	}
}
