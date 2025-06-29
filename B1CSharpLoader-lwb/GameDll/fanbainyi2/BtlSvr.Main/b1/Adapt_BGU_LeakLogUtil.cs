using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class Adapt_BGU_LeakLogUtil : CrossBindingAdaptor
{
	public class Adaptor : BGU_LeakLogUtil, CrossBindingAdaptorType
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

		protected override GetDelTargetResult GetScriptTargetObj(Delegate InvokeDel)
		{
			IMethod method = _instance.Type.GetMethod("GetScriptTargetObj", 1);
			if (method != null)
			{
				return (GetDelTargetResult)_appdomain.Invoke(method, _instance, InvokeDel);
			}
			return null;
		}
	}

	public override Type BaseCLRType => typeof(BGU_LeakLogUtil);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
