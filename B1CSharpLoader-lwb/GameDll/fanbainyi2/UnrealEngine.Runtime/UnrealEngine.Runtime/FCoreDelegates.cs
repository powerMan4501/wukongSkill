using System;
using AOT;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FCoreDelegates
{
	public class OnControllerConnectionChangeHandler : NativeMulticastDelegate<Native_FCoreDelegates.Del_OnControllerConnectionChange, Native_FCoreDelegates.Del_Reg_OnControllerConnectionChange, OnControllerConnectionChangeHandler.Signature>
	{
		public delegate void Signature(csbool connected, int userId, int controllerIndex);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool connected, int userId, int controllerIndex)
		{
			try
			{
				NativeDelegate<Native_FCoreDelegates.Del_OnControllerConnectionChange, Native_FCoreDelegates.Del_Reg_OnControllerConnectionChange, Signature>.managed.Delegate?.Invoke(connected, userId, controllerIndex);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnHandleSystemEnsureHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnHandleSystemEnsure>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnHandleSystemEnsure>.NativeCallbackImpl();
		}
	}

	public class OnHandleSystemErrorHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnHandleSystemError>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnHandleSystemError>.NativeCallbackImpl();
		}
	}

	public class OnShutdownAfterErrorHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnShutdownAfterError>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnShutdownAfterError>.NativeCallbackImpl();
		}
	}

	public class OnInitHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnInit>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnInit>.NativeCallbackImpl();
		}
	}

	public class OnPostEngineInitHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnPostEngineInit>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnPostEngineInit>.NativeCallbackImpl();
		}
	}

	public class OnExitHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnExit>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnExit>.NativeCallbackImpl();
		}
	}

	public class OnPreExitHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnPreExit>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnPreExit>.NativeCallbackImpl();
		}
	}

	public class OnBeginFrameHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnBeginFrame>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnBeginFrame>.NativeCallbackImpl();
		}
	}

	public class OnEndFrameHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnEndFrame>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_OnEndFrame>.NativeCallbackImpl();
		}
	}

	public class ApplicationWillDeactivateDelegateHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationWillDeactivateDelegate>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationWillDeactivateDelegate>.NativeCallbackImpl();
		}
	}

	public class ApplicationHasReactivatedDelegateHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationHasReactivatedDelegate>
	{
	}

	public class ApplicationWillEnterBackgroundDelegateHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationWillEnterBackgroundDelegate>
	{
	}

	public class ApplicationHasEnteredForegroundDelegateHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationHasEnteredForegroundDelegate>
	{
	}

	public class ApplicationWillTerminateDelegateHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationWillTerminateDelegate>
	{
	}

	public class JumpToDefinitionDelegateHandler : NativeMulticastDelegate<Native_FCoreDelegates.Del_JumpToDefinitionDelegate, Native_FCoreDelegates.Del_Reg_JumpToDefinitionDelegate, JumpToDefinitionDelegateHandler.Signature>
	{
		public delegate void Signature(string ModuleName, string ClassName, string FunctionName);

		public delegate void Native(ref FScriptArray ModuleName, ref FScriptArray ClassName, ref FScriptArray FunctionName);

		[MonoPInvokeCallback(typeof(Native))]
		private static void NativeCallback(ref FScriptArray ModuleName, ref FScriptArray ClassName, ref FScriptArray FunctionName)
		{
			try
			{
				NativeDelegate<Native_FCoreDelegates.Del_JumpToDefinitionDelegate, Native_FCoreDelegates.Del_Reg_JumpToDefinitionDelegate, Signature>.managed.Delegate?.Invoke(FStringMarshaler.FromArray(ModuleName, destroy: false), FStringMarshaler.FromArray(ClassName, destroy: false), FStringMarshaler.FromArray(FunctionName, destroy: false));
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class ApplicationIsSystemUiOverlaidDelegateHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationIsSystemUiOverlaidDelegate>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationIsSystemUiOverlaidDelegate>.NativeCallbackImpl();
		}
	}

	public class ApplicationNoSystemUiOverlaidDelegateHandler : NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationNoSystemUiOverlaidDelegate>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreDelegates.Del_Reg_ApplicationNoSystemUiOverlaidDelegate>.NativeCallbackImpl();
		}
	}

	public static OnControllerConnectionChangeHandler OnControllerConnectionChange;

	public static OnHandleSystemEnsureHandler OnHandleSystemEnsure;

	public static OnHandleSystemErrorHandler OnHandleSystemError;

	public static OnShutdownAfterErrorHandler OnShutdownAfterError;

	public static OnInitHandler OnInit;

	public static OnPostEngineInitHandler OnPostEngineInit;

	public static OnExitHandler OnExit;

	public static OnPreExitHandler OnPreExit;

	public static OnBeginFrameHandler OnBeginFrame;

	public static OnEndFrameHandler OnEndFrame;

	public static ApplicationWillDeactivateDelegateHandler ApplicationWillDeactivateDelegate;

	public static ApplicationHasReactivatedDelegateHandler ApplicationHasReactivatedDelegate;

	public static ApplicationWillEnterBackgroundDelegateHandler ApplicationWillEnterBackgroundDelegate;

	public static ApplicationHasEnteredForegroundDelegateHandler ApplicationHasEnteredForegroundDelegate;

	public static ApplicationWillTerminateDelegateHandler ApplicationWillTerminateDelegate;

	public static JumpToDefinitionDelegateHandler JumpToDefinitionDelegate;

	public static ApplicationIsSystemUiOverlaidDelegateHandler ApplicationIsSystemUiOverlaidDelegate;

	public static ApplicationNoSystemUiOverlaidDelegateHandler ApplicationNoSystemUiOverlaidDelegate;

	static FCoreDelegates()
	{
		OnControllerConnectionChange = new OnControllerConnectionChangeHandler();
		OnHandleSystemEnsure = new OnHandleSystemEnsureHandler();
		OnHandleSystemError = new OnHandleSystemErrorHandler();
		OnShutdownAfterError = new OnShutdownAfterErrorHandler();
		OnInit = new OnInitHandler();
		OnPostEngineInit = new OnPostEngineInitHandler();
		OnExit = new OnExitHandler();
		OnPreExit = new OnPreExitHandler();
		OnBeginFrame = new OnBeginFrameHandler();
		OnEndFrame = new OnEndFrameHandler();
		ApplicationWillDeactivateDelegate = new ApplicationWillDeactivateDelegateHandler();
		ApplicationHasReactivatedDelegate = new ApplicationHasReactivatedDelegateHandler();
		ApplicationWillEnterBackgroundDelegate = new ApplicationWillEnterBackgroundDelegateHandler();
		ApplicationHasEnteredForegroundDelegate = new ApplicationHasEnteredForegroundDelegateHandler();
		ApplicationWillTerminateDelegate = new ApplicationWillTerminateDelegateHandler();
		JumpToDefinitionDelegate = new JumpToDefinitionDelegateHandler();
		ApplicationIsSystemUiOverlaidDelegate = new ApplicationIsSystemUiOverlaidDelegateHandler();
		ApplicationNoSystemUiOverlaidDelegate = new ApplicationNoSystemUiOverlaidDelegateHandler();
		HotReload.RegisterNativeDelegateManager(typeof(FCoreDelegates));
	}
}
