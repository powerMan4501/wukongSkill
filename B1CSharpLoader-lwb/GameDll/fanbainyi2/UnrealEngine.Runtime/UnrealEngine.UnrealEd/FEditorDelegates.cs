using System;
using AOT;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.UnrealEd;

public static class FEditorDelegates
{
	public class PreBeginPIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PreBeginPIE, PreBeginPIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PreBeginPIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class BeginPIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_BeginPIE, BeginPIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_BeginPIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class PostPIEStartedHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PostPIEStarted, PostPIEStartedHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PostPIEStarted, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class PrePIEEndedHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PrePIEEnded, PrePIEEndedHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PrePIEEnded, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class EndPIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_EndPIE, EndPIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_EndPIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class PausePIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PausePIE, PausePIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_PausePIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class ResumePIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_ResumePIE, ResumePIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_ResumePIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class SingleStepPIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_SingleStepPIE, SingleStepPIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_SingleStepPIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnPreSwitchBeginPIEAndSIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_OnPreSwitchBeginPIEAndSIE, OnPreSwitchBeginPIEAndSIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_OnPreSwitchBeginPIEAndSIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnSwitchBeginPIEAndSIEHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_OnSwitchBeginPIEAndSIE, OnSwitchBeginPIEAndSIEHandler.Signature>
	{
		public delegate void Signature(csbool simulating);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(csbool simulating)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEEvent, Native_FEditorDelegates.Del_Reg_OnSwitchBeginPIEAndSIE, Signature>.managed.Delegate?.Invoke(simulating);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnMapOpenedHandler : NativeMulticastDelegate<Native_FEditorDelegates.Del_OnPIEMapOpenedEvent, Native_FEditorDelegates.Del_Reg_OnMapOpened, OnMapOpenedHandler.Signature>
	{
		public delegate void Signature(string filename, bool bAsTemplate);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(string filename, bool bAsTemplate)
		{
			try
			{
				NativeDelegate<Native_FEditorDelegates.Del_OnPIEMapOpenedEvent, Native_FEditorDelegates.Del_Reg_OnMapOpened, Signature>.managed.Delegate?.Invoke(filename, bAsTemplate);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public static PreBeginPIEHandler PreBeginPIE;

	public static BeginPIEHandler BeginPIE;

	public static PostPIEStartedHandler PostPIEStarted;

	public static PrePIEEndedHandler PrePIEEnded;

	public static EndPIEHandler EndPIE;

	public static PausePIEHandler PausePIE;

	public static ResumePIEHandler ResumePIE;

	public static SingleStepPIEHandler SingleStepPIE;

	public static OnPreSwitchBeginPIEAndSIEHandler OnPreSwitchBeginPIEAndSIE;

	public static OnSwitchBeginPIEAndSIEHandler OnSwitchBeginPIEAndSIE;

	public static OnMapOpenedHandler OnMapOpened;

	static FEditorDelegates()
	{
		PreBeginPIE = new PreBeginPIEHandler();
		BeginPIE = new BeginPIEHandler();
		PostPIEStarted = new PostPIEStartedHandler();
		PrePIEEnded = new PrePIEEndedHandler();
		EndPIE = new EndPIEHandler();
		PausePIE = new PausePIEHandler();
		ResumePIE = new ResumePIEHandler();
		SingleStepPIE = new SingleStepPIEHandler();
		OnPreSwitchBeginPIEAndSIE = new OnPreSwitchBeginPIEAndSIEHandler();
		OnSwitchBeginPIEAndSIE = new OnSwitchBeginPIEAndSIEHandler();
		OnMapOpened = new OnMapOpenedHandler();
		HotReload.RegisterNativeDelegateManager(typeof(FEditorDelegates));
	}
}
