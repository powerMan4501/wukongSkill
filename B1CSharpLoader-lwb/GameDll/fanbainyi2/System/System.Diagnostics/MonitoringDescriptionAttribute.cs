using System.ComponentModel;

namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.All)]
public class MonitoringDescriptionAttribute : DescriptionAttribute
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

	public MonitoringDescriptionAttribute(string description)
		: base(description)
	{
	}
}
