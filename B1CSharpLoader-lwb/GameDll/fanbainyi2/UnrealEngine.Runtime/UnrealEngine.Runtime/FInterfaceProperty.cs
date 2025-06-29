using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.InterfaceProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FInterfaceProperty : FProperty
{
	private CachedUObject<UClass> interfaceClass;

	public override EPropertyType PropertyType => EPropertyType.Interface;

	public UClass InterfaceClass
	{
		get
		{
			return interfaceClass.Update(Native_FInterfaceProperty.Get_InterfaceClass(base.Address));
		}
		set
		{
			Native_FInterfaceProperty.Set_InterfaceClass(base.Address, interfaceClass.Set(value));
		}
	}

	public FInterfaceProperty()
	{
	}

	public FInterfaceProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}

	public void SetMetaClass(UClass newInterfaceClass)
	{
		Native_FInterfaceProperty.SetInterfaceClass(base.Address, (newInterfaceClass == null) ? IntPtr.Zero : newInterfaceClass.Address);
	}
}
