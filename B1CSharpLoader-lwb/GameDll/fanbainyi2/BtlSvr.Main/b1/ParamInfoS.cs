using System;

namespace b1;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ParamInfoS : ParamInfoBase
{
	public ParamInfoS(int InIndex, string InDescription)
		: base(InIndex, InDescription)
	{
	}
}
