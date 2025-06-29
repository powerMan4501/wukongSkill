using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEFsmSolverTypeList : ReadOnlyPrimitiveList<EFsmSolverType>
{
	public ReadOnlyEFsmSolverTypeList(RepeatedField<EFsmSolverType> pbData)
		: base(pbData)
	{
	}
}
