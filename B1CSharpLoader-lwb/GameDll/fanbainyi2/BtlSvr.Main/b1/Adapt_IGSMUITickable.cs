using System;
using b1.GSMUI;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class Adapt_IGSMUITickable : CrossBindingAdaptor
{
	public class Adaptor : IGSMUITickable, CrossBindingAdaptorType
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

		public bool IsUObjectDestroyed()
		{
			IMethod method = _instance.Type.GetMethod("IsUObjectDestroyed", 0);
			if (method != null)
			{
				return (bool)_appdomain.Invoke(method, _instance);
			}
			return false;
		}

		public bool IsGSNeedTick()
		{
			IMethod method = _instance.Type.GetMethod("IsGSNeedTick", 0);
			if (method != null)
			{
				return (bool)_appdomain.Invoke(method, _instance);
			}
			return true;
		}

		public void DoGSTick(float DeltaTime)
		{
			IMethod method = _instance.Type.GetMethod("DoGSTick", 1);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, DeltaTime);
			}
		}

		public void BindTickMgr(GSMUITickMgr _TickMgr)
		{
			IMethod method = _instance.Type.GetMethod("BindTickMgr", 1);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, _TickMgr);
			}
		}
	}

	public override Type BaseCLRType => typeof(IGSMUITickable);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
