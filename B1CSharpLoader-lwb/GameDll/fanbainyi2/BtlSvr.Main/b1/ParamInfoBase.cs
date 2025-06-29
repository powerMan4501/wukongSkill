using System;

namespace b1;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ParamInfoBase : Attribute
{
	public int Index { get; }

	public string Description { get; }

	public ParamInfoBase(int InIndex, string InDescription)
	{
		Index = InIndex;
		Description = InDescription;
	}
}
