using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ExpandableObjectConverter : TypeConverter
{
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		return TypeDescriptor.GetProperties(value, attributes);
	}

	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}
}
