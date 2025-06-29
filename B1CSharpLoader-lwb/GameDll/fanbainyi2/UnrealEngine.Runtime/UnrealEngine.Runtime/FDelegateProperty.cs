using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.DelegateProperty", "CoreUObject", UnrealModuleType.Engine)]
public class FDelegateProperty : FProperty
{
	private CachedUObject<UFunction> signatureFunction;

	private PropertyAccessor<FScriptDelegate> accessor;

	public override EPropertyType PropertyType => EPropertyType.Delegate;

	public UFunction SignatureFunction
	{
		get
		{
			return signatureFunction.Update(Native_FDelegateProperty.Get_SignatureFunction(base.Address));
		}
		set
		{
			Native_FDelegateProperty.Set_SignatureFunction(base.Address, signatureFunction.Set(value));
		}
	}

	public PropertyAccessor<FScriptDelegate> Accessor
	{
		get
		{
			if (accessor != null)
			{
				return accessor;
			}
			return accessor = new PropertyAccessor<FScriptDelegate>(this);
		}
	}

	public FDelegateProperty()
	{
	}

	public FDelegateProperty(IntPtr _propertyAddress)
		: base(_propertyAddress)
	{
	}
}
