using System;
using AOT;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FCoreUObjectDelegates
{
	public class OnObjectModifiedHandler : NativeMulticastDelegate<Native_FCoreUObjectDelegates.Del_OnObjectModified, Native_FCoreUObjectDelegates.Del_Reg_OnObjectModified, OnObjectModifiedHandler.Signature>
	{
		public delegate void Signature(UObject objectBeingModified);

		[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
		private static void NativeCallback(IntPtr objectBeingModified)
		{
			try
			{
				NativeDelegate<Native_FCoreUObjectDelegates.Del_OnObjectModified, Native_FCoreUObjectDelegates.Del_Reg_OnObjectModified, Signature>.managed.Delegate?.Invoke(GCHelper.Find<UObject>(objectBeingModified));
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnAssetLoadedHandler : NativeMulticastDelegate<Native_FCoreUObjectDelegates.Del_OnAssetLoaded, Native_FCoreUObjectDelegates.Del_Reg_OnAssetLoaded, OnAssetLoadedHandler.Signature>
	{
		public delegate void Signature(UObject asset);

		[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
		private static void NativeCallback(IntPtr asset)
		{
			try
			{
				NativeDelegate<Native_FCoreUObjectDelegates.Del_OnAssetLoaded, Native_FCoreUObjectDelegates.Del_Reg_OnAssetLoaded, Signature>.managed.Delegate?.Invoke(GCHelper.Find<UObject>(asset));
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnObjectSavedHandler : NativeMulticastDelegate<Native_FCoreUObjectDelegates.Del_OnObjectSaved, Native_FCoreUObjectDelegates.Del_Reg_OnObjectSaved, OnObjectSavedHandler.Signature>
	{
		public delegate void Signature(UObject savedObject);

		[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
		private static void NativeCallback(IntPtr savedObject)
		{
			try
			{
				NativeDelegate<Native_FCoreUObjectDelegates.Del_OnObjectSaved, Native_FCoreUObjectDelegates.Del_Reg_OnObjectSaved, Signature>.managed.Delegate?.Invoke(GCHelper.Find<UObject>(savedObject));
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class PreLoadMapHandler : NativeMulticastDelegate<Native_FCoreUObjectDelegates.Del_PreLoadMap, Native_FCoreUObjectDelegates.Del_Reg_PreLoadMap, PreLoadMapHandler.Signature>
	{
		public delegate void Signature(string mapName);

		[MonoNativeFunctionWrapper]
		public delegate void NativeDel(ref FScriptArray mapName);

		[MonoPInvokeCallback(typeof(NativeDel))]
		private static void NativeCallback(ref FScriptArray mapName)
		{
			try
			{
				string mapName2 = FStringMarshaler.FromArray(mapName, destroy: false);
				NativeDelegate<Native_FCoreUObjectDelegates.Del_PreLoadMap, Native_FCoreUObjectDelegates.Del_Reg_PreLoadMap, Signature>.managed.Delegate?.Invoke(mapName2);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class PostLoadMapWithWorldHandler : NativeMulticastDelegate<Native_FCoreUObjectDelegates.Del_PostLoadMapWithWorld, Native_FCoreUObjectDelegates.Del_Reg_PostLoadMapWithWorld, PostLoadMapWithWorldHandler.Signature>
	{
		[MonoNativeFunctionWrapper]
		public delegate void Signature(UObject loadedWorld);

		[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
		private static void NativeCallback(IntPtr loadedWorld)
		{
			try
			{
				NativeDelegate<Native_FCoreUObjectDelegates.Del_PostLoadMapWithWorld, Native_FCoreUObjectDelegates.Del_Reg_PostLoadMapWithWorld, Signature>.managed.Delegate?.Invoke(GCHelper.Find<UObject>(loadedWorld));
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class PostDemoPlayHandler : NativeSimpleMulticastDelegate<Native_FCoreUObjectDelegates.Del_Reg_PostDemoPlay>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreUObjectDelegates.Del_Reg_PostDemoPlay>.NativeCallbackImpl();
		}
	}

	public class PreGarbageCollectHandler : NativeSimpleMulticastDelegate<Native_FCoreUObjectDelegates.Del_Reg_PreGarbageCollect>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreUObjectDelegates.Del_Reg_PreGarbageCollect>.NativeCallbackImpl();
		}
	}

	public class PostGarbageCollectHandler : NativeSimpleMulticastDelegate<Native_FCoreUObjectDelegates.Del_Reg_PostGarbageCollect>
	{
		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_FCoreUObjectDelegates.Del_Reg_PostGarbageCollect>.NativeCallbackImpl();
		}
	}

	public static OnObjectModifiedHandler OnObjectModified;

	public static OnAssetLoadedHandler OnAssetLoaded;

	public static OnObjectSavedHandler OnObjectSaved;

	public static PreLoadMapHandler PreLoadMap;

	public static PostLoadMapWithWorldHandler PostLoadMapWithWorld;

	public static PostDemoPlayHandler PostDemoPlay;

	public static PreGarbageCollectHandler PreGarbageCollect;

	public static PostGarbageCollectHandler PostGarbageCollect;

	static FCoreUObjectDelegates()
	{
		OnObjectModified = new OnObjectModifiedHandler();
		OnAssetLoaded = new OnAssetLoadedHandler();
		OnObjectSaved = new OnObjectSavedHandler();
		PreLoadMap = new PreLoadMapHandler();
		PostLoadMapWithWorld = new PostLoadMapWithWorldHandler();
		PostDemoPlay = new PostDemoPlayHandler();
		PreGarbageCollect = new PreGarbageCollectHandler();
		PostGarbageCollect = new PostGarbageCollectHandler();
		HotReload.RegisterNativeDelegateManager(typeof(FCoreUObjectDelegates));
	}
}
