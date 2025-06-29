using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.StructProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FStructProperty : FProperty
{
	private CachedUObject<UScriptStruct> unrealStruct;

	public override EPropertyType PropertyType => EPropertyType.Struct;

	public UScriptStruct Struct
	{
		get
		{
			return unrealStruct.Update(Native_FStructProperty.Get_Struct(base.Address));
		}
		set
		{
			Native_FStructProperty.Set_Struct(base.Address, unrealStruct.Set(value));
		}
	}

	public FStructProperty()
	{
	}

	public FStructProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
