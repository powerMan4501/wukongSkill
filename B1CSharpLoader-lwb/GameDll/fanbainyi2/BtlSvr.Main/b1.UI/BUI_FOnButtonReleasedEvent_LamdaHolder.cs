using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_FOnButtonReleasedEvent_LamdaHolder")]
public class BUI_FOnButtonReleasedEvent_LamdaHolder : UObject
{
	private static readonly FName CBName;

	private FOnButtonReleasedEvent.Signature CB;

	private static bool LamdaCB_IsValid;

	private static IntPtr LamdaCB_FunctionAddress;

	private static int LamdaCB_ParamsSize;

	public void Set(FOnButtonReleasedEvent Evt, FOnButtonReleasedEvent.Signature Func)
	{
		CB = (FOnButtonReleasedEvent.Signature)Delegate.Combine(CB, Func);
		Evt.Bind(this, CBName);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_FOnButtonReleasedEvent_LamdaHolder:LamdaCB")]
	public void LamdaCB()
	{
		CB?.Invoke();
	}

	static BUI_FOnButtonReleasedEvent_LamdaHolder()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_FOnButtonReleasedEvent_LamdaHolder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_FOnButtonReleasedEvent_LamdaHolder));
		CBName = B1GlobalFNames.LamdaCB;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_FOnButtonReleasedEvent_LamdaHolder:LamdaCB")]
	private static void LamdaCB__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_FOnButtonReleasedEvent_LamdaHolder bUI_FOnButtonReleasedEvent_LamdaHolder = GCHelper.Find<BUI_FOnButtonReleasedEvent_LamdaHolder>(obj);
		bUI_FOnButtonReleasedEvent_LamdaHolder.LamdaCB();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_FOnButtonReleasedEvent_LamdaHolder");
		LamdaCB_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LamdaCB");
		LamdaCB_ParamsSize = NativeReflection.GetFunctionParamsSize(LamdaCB_FunctionAddress);
		LamdaCB_IsValid = LamdaCB_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_FOnButtonReleasedEvent_LamdaHolder:LamdaCB", LamdaCB_IsValid);
	}
}
