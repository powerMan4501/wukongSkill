using System;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.CLRBinding;

public class CLRBindingUtils
{
	private static Action<ILRuntime.Runtime.Enviorment.AppDomain> initializeAction;

	public static void RegisterBindingAction(Action<ILRuntime.Runtime.Enviorment.AppDomain> action)
	{
		initializeAction = action;
	}

	public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain appDomain)
	{
		if (initializeAction != null)
		{
			initializeAction(appDomain);
		}
	}
}
