using System;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class Adapt_FSMConditionBase : CrossBindingAdaptor
{
	public class Adaptor : FSMConditionBase, CrossBindingAdaptorType
	{
		private CrossBindingFunctionInfo<string> sGetResult = new CrossBindingFunctionInfo<string>("GetResult");

		private CrossBindingFunctionInfo<object> sGetNextNodeInputParam = new CrossBindingFunctionInfo<object>("GetNextNodeInputParam");

		private ILTypeInstance instance;

		private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

		public ILTypeInstance ILInstance => instance;

		public Adaptor()
		{
		}

		public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			this.appdomain = appdomain;
			this.instance = instance;
		}

		public override string GetResult()
		{
			return sGetResult.Invoke(instance);
		}

		public override object GetNextNodeInputParam()
		{
			if (sGetNextNodeInputParam.CheckShouldInvokeBase(instance))
			{
				return base.GetNextNodeInputParam();
			}
			return sGetNextNodeInputParam.Invoke(instance);
		}
	}

	public override Type BaseCLRType => typeof(FSMConditionBase);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
