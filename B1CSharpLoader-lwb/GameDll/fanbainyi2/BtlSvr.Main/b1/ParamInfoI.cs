using System;

namespace b1;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ParamInfoI : ParamInfoBase
{
	public ParamInfoI(int InIndex, string InDescription)
		: base(InIndex, InDescription)
	{
	}
}
