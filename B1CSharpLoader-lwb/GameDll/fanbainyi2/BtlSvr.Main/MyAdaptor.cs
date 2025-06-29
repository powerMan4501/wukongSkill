using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

public abstract class MyAdaptor : CrossBindingAdaptorType
{
	protected ILTypeInstance _instance;

	private AdaptHelper.AdaptMethod[] _methods;

	protected AppDomain AppDomain { get; set; }

	public ILTypeInstance ILInstance
	{
		get
		{
			return _instance;
		}
		set
		{
			_instance = value;
		}
	}

	protected abstract AdaptHelper.AdaptMethod[] GetAdaptMethods();

	protected object Invoke(int index, params object[] p)
	{
		if (_methods == null)
		{
			_methods = GetAdaptMethods();
		}
		IMethod method = AdaptHelper.GetMethod(_instance.Type, _methods[index]);
		return AppDomain.Invoke(method, _instance, p);
	}

	protected MyAdaptor(AppDomain appdomain, ILTypeInstance instance)
	{
		AppDomain = appdomain;
		_instance = instance;
	}
}
