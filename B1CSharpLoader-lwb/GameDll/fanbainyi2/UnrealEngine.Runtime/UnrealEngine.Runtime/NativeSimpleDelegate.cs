using System;
using AOT;

namespace UnrealEngine.Runtime;

public class NativeSimpleDelegate<TRegisterNativeDelegate> : NativeDelegate<FSimpleDelegate, TRegisterNativeDelegate, FSimpleDelegate> where TRegisterNativeDelegate : class
{
	[MonoPInvokeCallback(typeof(Del_Void))]
	private static void NativeCallback()
	{
		try
		{
			NativeDelegate<FSimpleDelegate, TRegisterNativeDelegate, FSimpleDelegate>.managed.Delegate?.Invoke();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}
}
