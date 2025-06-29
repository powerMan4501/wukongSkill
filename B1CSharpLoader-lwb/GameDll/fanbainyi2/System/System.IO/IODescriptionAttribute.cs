using System.ComponentModel;

namespace System.IO;

[AttributeUsage(AttributeTargets.All)]
public class IODescriptionAttribute : DescriptionAttribute
{
	private bool replaced;

	public override string Description
	{
		get
		{
			if (!replaced)
			{
				replaced = true;
				base.DescriptionValue = SR.GetString(base.Description);
			}
			return base.Description;
		}
	}

	public IODescriptionAttribute(string description)
		: base(description)
	{
	}
}
