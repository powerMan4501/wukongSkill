using System;

namespace UnrealEngine.Runtime;

public class NativeSimpleMulticastDelegate<TRegisterNativeDelegate> : NativeMulticastDelegate<FSimpleMulticastDelegate, TRegisterNativeDelegate, FSimpleMulticastDelegate> where TRegisterNativeDelegate : class
{
	protected static void NativeCallbackImpl()
	{
		try
		{
			NativeDelegate<FSimpleMulticastDelegate, TRegisterNativeDelegate, FSimpleMulticastDelegate>.managed.Delegate?.Invoke();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}
}
