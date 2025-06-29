using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.ClassProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FClassProperty : FObjectProperty
{
	private CachedUObject<UClass> metaClass;

	public override EPropertyType PropertyType => EPropertyType.Class;

	public UClass MetaClass
	{
		get
		{
			return metaClass.Update(Native_FClassProperty.Get_MetaClass(base.Address));
		}
		set
		{
			Native_FClassProperty.Set_MetaClass(base.Address, metaClass.Set(value));
		}
	}

	public FClassProperty()
	{
	}

	public FClassProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public void SetMetaClass(UClass newMetaClass)
	{
		Native_FClassProperty.SetMetaClass(base.Address, (newMetaClass == null) ? IntPtr.Zero : newMetaClass.Address);
	}
}
