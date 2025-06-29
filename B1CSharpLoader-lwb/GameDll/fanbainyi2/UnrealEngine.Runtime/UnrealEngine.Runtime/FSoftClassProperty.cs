using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.SoftClassProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FSoftClassProperty : FSoftObjectProperty
{
	private CachedUObject<UClass> metaClass;

	public override EPropertyType PropertyType => EPropertyType.SoftClass;

	public UClass MetaClass
	{
		get
		{
			return metaClass.Update(Native_FSoftClassProperty.Get_MetaClass(base.Address));
		}
		set
		{
			Native_FSoftClassProperty.Set_MetaClass(base.Address, metaClass.Set(value));
		}
	}

	public FSoftClassProperty()
	{
	}

	public FSoftClassProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public void SetMetaClass(UClass newMetaClass)
	{
		Native_FSoftClassProperty.SetMetaClass(base.Address, (newMetaClass == null) ? IntPtr.Zero : newMetaClass.Address);
	}
}
