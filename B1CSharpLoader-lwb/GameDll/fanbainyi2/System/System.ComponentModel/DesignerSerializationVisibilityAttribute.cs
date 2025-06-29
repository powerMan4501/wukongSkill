namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	public static readonly DesignerSerializationVisibilityAttribute Content = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content);

	public static readonly DesignerSerializationVisibilityAttribute Hidden = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden);

	public static readonly DesignerSerializationVisibilityAttribute Visible = new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible);

	public static readonly DesignerSerializationVisibilityAttribute Default = Visible;

	private DesignerSerializationVisibility visibility;

	public DesignerSerializationVisibility Visibility => visibility;

	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
	{
		this.visibility = visibility;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is DesignerSerializationVisibilityAttribute designerSerializationVisibilityAttribute)
		{
			return designerSerializationVisibilityAttribute.Visibility == visibility;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool IsDefaultAttribute()
	{
		return Equals(Default);
	}
}
