using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_FOnButtonClickedEvent_LamdaHolder")]
public class BUI_FOnButtonClickedEvent_LamdaHolder : UObject
{
	private static readonly FName CBName;

	private FOnButtonClickedEvent.Signature CB;

	private static bool LamdaCB_IsValid;

	private static IntPtr LamdaCB_FunctionAddress;

	private static int LamdaCB_ParamsSize;

	public void Set(FOnButtonClickedEvent Evt, FOnButtonClickedEvent.Signature Func)
	{
		CB = (FOnButtonClickedEvent.Signature)Delegate.Combine(CB, Func);
		Evt.Bind(this, CBName);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_FOnButtonClickedEvent_LamdaHolder:LamdaCB")]
	public void LamdaCB()
	{
		CB?.Invoke();
	}

	static BUI_FOnButtonClickedEvent_LamdaHolder()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_FOnButtonClickedEvent_LamdaHolder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_FOnButtonClickedEvent_LamdaHolder));
		CBName = B1GlobalFNames.LamdaCB;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_FOnButtonClickedEvent_LamdaHolder:LamdaCB")]
	private static void LamdaCB__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_FOnButtonClickedEvent_LamdaHolder bUI_FOnButtonClickedEvent_LamdaHolder = GCHelper.Find<BUI_FOnButtonClickedEvent_LamdaHolder>(obj);
		bUI_FOnButtonClickedEvent_LamdaHolder.LamdaCB();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_FOnButtonClickedEvent_LamdaHolder");
		LamdaCB_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LamdaCB");
		LamdaCB_ParamsSize = NativeReflection.GetFunctionParamsSize(LamdaCB_FunctionAddress);
		LamdaCB_IsValid = LamdaCB_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_FOnButtonClickedEvent_LamdaHolder:LamdaCB", LamdaCB_IsValid);
	}
}
