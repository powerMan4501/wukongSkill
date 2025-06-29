using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UILRuntimeDelegateWrapperBase")]
public abstract class UILRuntimeDelegateWrapperBase : UObject
{
	protected Delegate _action;

	public void SetAction(Delegate action)
	{
		_action = action;
	}

	public Delegate GetAction()
	{
		return _action;
	}

	public abstract Delegate GetSignature();

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.UILRuntimeDelegateWrapperBase");
	}

	static UILRuntimeDelegateWrapperBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UILRuntimeDelegateWrapperBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UILRuntimeDelegateWrapperBase));
	}
}
