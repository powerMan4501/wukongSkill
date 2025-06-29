using System;

namespace b1;

public class EffectTemplateTipsAttribute : Attribute
{
	private string[] Tips;

	public EffectTemplateTipsAttribute(params string[] _tips)
	{
		Tips = _tips;
	}

	public string[] GetParamterInfo()
	{
		return Tips;
	}
}
