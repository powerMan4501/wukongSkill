using ILRuntime.Runtime.CLRBinding;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.Generated;

internal class CLRBindings
{
	private static void RegisterBindingAction()
	{
		CLRBindingUtils.RegisterBindingAction(Initialize);
	}

	public static void Initialize(AppDomain app)
	{
	}

	public static void Shutdown(AppDomain app)
	{
	}
}
