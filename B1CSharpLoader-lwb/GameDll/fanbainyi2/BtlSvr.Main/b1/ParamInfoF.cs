using System;

namespace b1;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ParamInfoF : ParamInfoBase
{
	public ParamInfoF(int InIndex, string InDescription)
		: base(InIndex, InDescription)
	{
	}
}
