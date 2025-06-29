using System;
using b1.GSMUI;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class Adapt_IGSMUIDestruct : CrossBindingAdaptor
{
	public class Adaptor : IGSMUIDestruct, CrossBindingAdaptorType
	{
		protected ILTypeInstance _instance;

		protected ILRuntime.Runtime.Enviorment.AppDomain _appdomain { get; set; }

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

		public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			_appdomain = appdomain;
			_instance = instance;
		}

		public void GSOnDestruct()
		{
			IMethod method = _instance.Type.GetMethod("GSOnDestruct", 0);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance);
			}
		}
	}

	public override Type BaseCLRType => typeof(IGSMUIDestruct);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
