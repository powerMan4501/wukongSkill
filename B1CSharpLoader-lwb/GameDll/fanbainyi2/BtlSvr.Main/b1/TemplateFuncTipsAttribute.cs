using System;

namespace b1;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TemplateFuncTipsAttribute : Attribute
{
	private string Tips;

	public TemplateFuncTipsAttribute(string _Tips)
	{
		Tips = _Tips;
	}

	public string GetTips()
	{
		return Tips;
	}
}
