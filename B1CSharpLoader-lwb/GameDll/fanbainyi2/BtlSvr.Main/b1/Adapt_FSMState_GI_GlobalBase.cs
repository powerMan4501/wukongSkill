using System;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class Adapt_FSMState_GI_GlobalBase : CrossBindingAdaptor
{
	public class Adaptor : FSMState_GI_GlobalBase, CrossBindingAdaptorType
	{
		private CrossBindingMethodInfo sVMOnEnter = new CrossBindingMethodInfo("OnEnter");

		private CrossBindingFunctionInfo<float, int> sVMOnTick = new CrossBindingFunctionInfo<float, int>("OnTick");

		private CrossBindingMethodInfo sVMOnExit = new CrossBindingMethodInfo("OnExit");

		private CrossBindingMethodInfo<FSMRuntimeInstance_GI_Global, FCalliopeNode, object> sVMInit = new CrossBindingMethodInfo<FSMRuntimeInstance_GI_Global, FCalliopeNode, object>("Init");

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

		public override void OnEnter()
		{
			if (sVMOnEnter.CheckShouldInvokeBase(instance))
			{
				base.OnEnter();
			}
			else
			{
				sVMOnEnter.Invoke(instance);
			}
		}

		public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			if (sVMInit.CheckShouldInvokeBase(instance))
			{
				base.Init(RuntimeInstance, Node, InputParams);
			}
			else
			{
				sVMInit.Invoke(instance, RuntimeInstance, Node, InputParams);
			}
		}

		public override int OnTick(float Delta)
		{
			if (sVMOnTick.CheckShouldInvokeBase(instance))
			{
				return base.OnTick(Delta);
			}
			return sVMOnTick.Invoke(instance, Delta);
		}

		public override void OnExit()
		{
			if (sVMOnExit.CheckShouldInvokeBase(instance))
			{
				base.OnExit();
			}
			else
			{
				sVMOnExit.Invoke(instance);
			}
		}
	}

	public override Type BaseCLRType => typeof(FSMState_GI_GlobalBase);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
