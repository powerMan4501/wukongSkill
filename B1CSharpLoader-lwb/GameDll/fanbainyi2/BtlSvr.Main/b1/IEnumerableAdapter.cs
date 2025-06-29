using System;
using System.Collections;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class IEnumerableAdapter : CrossBindingAdaptor
{
	public class Adapter : IEnumerable, CrossBindingAdaptorType
	{
		private CrossBindingFunctionInfo<IEnumerator> mGetEnumerator_0 = new CrossBindingFunctionInfo<IEnumerator>("GetEnumerator");

		private bool isInvokingToString;

		private ILTypeInstance instance;

		private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

		public ILTypeInstance ILInstance => instance;

		public Adapter()
		{
		}

		public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			this.appdomain = appdomain;
			this.instance = instance;
		}

		public IEnumerator GetEnumerator()
		{
			return mGetEnumerator_0.Invoke(instance);
		}

		public override string ToString()
		{
			IMethod method = appdomain.ObjectType.GetMethod("ToString", 0);
			method = instance.Type.GetVirtualMethod(method);
			if (method == null || method is ILMethod)
			{
				if (!isInvokingToString)
				{
					isInvokingToString = true;
					string result = instance.ToString();
					isInvokingToString = false;
					return result;
				}
				return instance.Type.FullName;
			}
			return instance.Type.FullName;
		}
	}

	public override Type BaseCLRType => typeof(IEnumerable);

	public override Type AdaptorType => typeof(Adapter);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adapter(appdomain, instance);
	}
}
