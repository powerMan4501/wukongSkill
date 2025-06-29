using System;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.TextProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FTextProperty : FProperty
{
	public override EPropertyType PropertyType => EPropertyType.Text;

	public FTextProperty()
	{
	}

	public FTextProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
