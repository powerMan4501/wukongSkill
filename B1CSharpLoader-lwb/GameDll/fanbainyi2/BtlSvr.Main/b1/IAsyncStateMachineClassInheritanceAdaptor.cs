using System;
using System.Runtime.CompilerServices;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class IAsyncStateMachineClassInheritanceAdaptor : CrossBindingAdaptor
{
	public class IAsyncStateMachineAdaptor : IAsyncStateMachine, CrossBindingAdaptorType
	{
		private ILTypeInstance instance;

		private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

		private CrossBindingMethodInfo mMoveNext_0 = new CrossBindingMethodInfo("MoveNext");

		private CrossBindingMethodInfo<IAsyncStateMachine> mSetStateMachine_1 = new CrossBindingMethodInfo<IAsyncStateMachine>("SetStateMachine");

		public ILTypeInstance ILInstance => instance;

		public IAsyncStateMachineAdaptor()
		{
		}

		public IAsyncStateMachineAdaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			this.appdomain = appdomain;
			this.instance = instance;
		}

		public void MoveNext()
		{
			mMoveNext_0.Invoke(instance);
		}

		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			mSetStateMachine_1.Invoke(instance, stateMachine);
		}

		public override string ToString()
		{
			IMethod method = appdomain.ObjectType.GetMethod("ToString", 0);
			method = instance.Type.GetVirtualMethod(method);
			if (method == null || method is ILMethod)
			{
				return instance.ToString();
			}
			return instance.Type.FullName;
		}
	}

	public override Type BaseCLRType => typeof(IAsyncStateMachine);

	public override Type AdaptorType => typeof(IAsyncStateMachineAdaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new IAsyncStateMachineAdaptor(appdomain, instance);
	}
}
