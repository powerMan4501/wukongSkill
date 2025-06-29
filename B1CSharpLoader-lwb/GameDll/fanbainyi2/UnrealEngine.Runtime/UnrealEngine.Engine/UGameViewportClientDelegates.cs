using AOT;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public static class UGameViewportClientDelegates
{
	public class OnViewportCreatedHandler : NativeSimpleMulticastDelegate<Native_UGameViewportClientDelegates.Del_Reg_OnViewportCreated>
	{
		public delegate void Signature();

		[MonoPInvokeCallback(typeof(Del_Void))]
		private static void NativeCallback()
		{
			NativeSimpleMulticastDelegate<Native_UGameViewportClientDelegates.Del_Reg_OnViewportCreated>.NativeCallbackImpl();
		}
	}

	public static OnViewportCreatedHandler OnViewportCreated;

	static UGameViewportClientDelegates()
	{
		OnViewportCreated = new OnViewportCreatedHandler();
		HotReload.RegisterNativeDelegateManager(typeof(UGameViewportClientDelegates));
	}
}
