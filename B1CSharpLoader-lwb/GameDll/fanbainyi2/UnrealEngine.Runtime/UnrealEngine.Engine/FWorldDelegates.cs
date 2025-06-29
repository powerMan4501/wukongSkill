using System;
using AOT;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public static class FWorldDelegates
{
	public class OnPostWorldCreationHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_WorldEvent, Native_FWorldDelegates.Del_Reg_OnPostWorldCreation, OnPostWorldCreationHandler.Signature>
	{
		public delegate void Signature(IntPtr world);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_WorldEvent, Native_FWorldDelegates.Del_Reg_OnPostWorldCreation, Signature>.managed.Delegate?.Invoke(world);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnSeamlessTravelStartHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_SeamlessTravelStart, Native_FWorldDelegates.Del_Reg_OnSeamlessTravelStart, OnSeamlessTravelStartHandler.Signature>
	{
		public delegate void Signature(IntPtr world, string Levelname);

		[MonoPInvokeCallback(typeof(Native_FWorldDelegates.Del_SeamlessTravelStart))]
		private static void NativeCallback(IntPtr world, IntPtr LevelnamePtr)
		{
			try
			{
				string levelname = FStringMarshaler.FromPtr(LevelnamePtr);
				NativeDelegate<Native_FWorldDelegates.Del_SeamlessTravelStart, Native_FWorldDelegates.Del_Reg_OnSeamlessTravelStart, Signature>.managed.Delegate?.Invoke(world, levelname);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnSeamlessTravelTransitionHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_SeamlessTravelTransition, Native_FWorldDelegates.Del_Reg_OnSeamlessTravelTransition, OnSeamlessTravelTransitionHandler.Signature>
	{
		public delegate void Signature(IntPtr world);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_SeamlessTravelTransition, Native_FWorldDelegates.Del_Reg_OnSeamlessTravelTransition, Signature>.managed.Delegate?.Invoke(world);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnPreWorldInitializationHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_WorldInitializationEvent, Native_FWorldDelegates.Del_Reg_OnPreWorldInitialization, OnPreWorldInitializationHandler.Signature>
	{
		public delegate void Signature(IntPtr world, IntPtr ivs);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world, IntPtr ivs)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_WorldInitializationEvent, Native_FWorldDelegates.Del_Reg_OnPreWorldInitialization, Signature>.managed.Delegate?.Invoke(world, ivs);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnPostWorldInitializationHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_WorldInitializationEvent, Native_FWorldDelegates.Del_Reg_OnPostWorldInitialization, OnPostWorldInitializationHandler.Signature>
	{
		public delegate void Signature(IntPtr world, IntPtr ivs);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world, IntPtr ivs)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_WorldInitializationEvent, Native_FWorldDelegates.Del_Reg_OnPostWorldInitialization, Signature>.managed.Delegate?.Invoke(world, ivs);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnPostDuplicateHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_WorldPostDuplicateEvent, Native_FWorldDelegates.Del_Reg_OnPostDuplicate, OnPostDuplicateHandler.Signature>
	{
		public delegate void Signature(IntPtr world, csbool duplicateForPIE, IntPtr replacementMap, IntPtr objectsToFixReferences);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world, csbool duplicateForPIE, IntPtr replacementMap, IntPtr objectsToFixReferences)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_WorldPostDuplicateEvent, Native_FWorldDelegates.Del_Reg_OnPostDuplicate, Signature>.managed.Delegate?.Invoke(world, duplicateForPIE, replacementMap, objectsToFixReferences);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnWorldCleanupHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_WorldCleanupEvent, Native_FWorldDelegates.Del_Reg_OnWorldCleanup, OnWorldCleanupHandler.Signature>
	{
		public delegate void Signature(IntPtr world, csbool sessionEnded, csbool cleanupResources);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world, csbool sessionEnded, csbool cleanupResources)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_WorldCleanupEvent, Native_FWorldDelegates.Del_Reg_OnWorldCleanup, Signature>.managed.Delegate?.Invoke(world, sessionEnded, cleanupResources);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnPostWorldCleanupHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_WorldCleanupEvent, Native_FWorldDelegates.Del_Reg_OnPostWorldCleanup, OnPostWorldCleanupHandler.Signature>
	{
		public delegate void Signature(IntPtr world, bool sessionEnded, bool cleanupResources);

		public delegate void NativeDel(IntPtr world, csbool sessionEnded, csbool cleanupResources);

		[MonoPInvokeCallback(typeof(NativeDel))]
		private static void NativeCallback(IntPtr world, csbool sessionEnded, csbool cleanupResources)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_WorldCleanupEvent, Native_FWorldDelegates.Del_Reg_OnPostWorldCleanup, Signature>.managed.Delegate?.Invoke(world, sessionEnded, cleanupResources);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnPreWorldFinishDestroyHandler : NativeMulticastDelegate<Native_FWorldDelegates.Del_WorldEvent, Native_FWorldDelegates.Del_Reg_OnPreWorldFinishDestroy, OnPreWorldFinishDestroyHandler.Signature>
	{
		public delegate void Signature(IntPtr world);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world)
		{
			try
			{
				NativeDelegate<Native_FWorldDelegates.Del_WorldEvent, Native_FWorldDelegates.Del_Reg_OnPreWorldFinishDestroy, Signature>.managed.Delegate?.Invoke(world);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public static OnPostWorldCreationHandler OnPostWorldCreation;

	public static OnSeamlessTravelStartHandler OnSeamlessTravelStart;

	public static OnSeamlessTravelTransitionHandler OnSeamlessTravelTransition;

	public static OnPreWorldInitializationHandler OnPreWorldInitialization;

	public static OnPostWorldInitializationHandler OnPostWorldInitialization;

	public static OnPostDuplicateHandler OnPostDuplicate;

	public static OnWorldCleanupHandler OnWorldCleanup;

	public static OnPostWorldCleanupHandler OnPostWorldCleanup;

	public static OnPreWorldFinishDestroyHandler OnPreWorldFinishDestroy;

	static FWorldDelegates()
	{
		OnPostWorldCreation = new OnPostWorldCreationHandler();
		OnSeamlessTravelStart = new OnSeamlessTravelStartHandler();
		OnSeamlessTravelTransition = new OnSeamlessTravelTransitionHandler();
		OnPreWorldInitialization = new OnPreWorldInitializationHandler();
		OnPostWorldInitialization = new OnPostWorldInitializationHandler();
		OnPostDuplicate = new OnPostDuplicateHandler();
		OnWorldCleanup = new OnWorldCleanupHandler();
		OnPostWorldCleanup = new OnPostWorldCleanupHandler();
		OnPreWorldFinishDestroy = new OnPreWorldFinishDestroyHandler();
		HotReload.RegisterNativeDelegateManager(typeof(FWorldDelegates));
	}
}
