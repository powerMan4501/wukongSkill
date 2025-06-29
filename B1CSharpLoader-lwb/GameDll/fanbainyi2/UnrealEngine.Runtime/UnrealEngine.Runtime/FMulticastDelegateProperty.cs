using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UClass(Flags = (ClassFlags)272629888uL)]
[UMetaPath("/Script/CoreUObject.MulticastDelegateProperty")]
public class FMulticastDelegateProperty : FProperty
{
	private CachedUObject<UFunction> signatureFunction;

	private PropertyAccessor<FMulticastScriptDelegate> accessor;

	public override EPropertyType PropertyType => EPropertyType.MulticastDelegate;

	public UFunction SignatureFunction
	{
		get
		{
			return signatureFunction.Update(Native_FMulticastDelegateProperty.Get_SignatureFunction(base.Address));
		}
		set
		{
			Native_FMulticastDelegateProperty.Set_SignatureFunction(base.Address, signatureFunction.Set(value));
		}
	}

	public PropertyAccessor<FMulticastScriptDelegate> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FMulticastScriptDelegate>(this);
		}
	}

	public FMulticastDelegateProperty()
	{
	}

	public FMulticastDelegateProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
