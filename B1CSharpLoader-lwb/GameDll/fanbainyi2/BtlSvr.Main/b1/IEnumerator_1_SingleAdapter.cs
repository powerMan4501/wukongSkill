using System;
using System.Collections;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class IEnumerator_1_SingleAdapter : CrossBindingAdaptor
{
	public class Adapter : IEnumerator<float>, IDisposable, IEnumerator, CrossBindingAdaptorType
	{
		private CrossBindingFunctionInfo<float> mget_Current_0 = new CrossBindingFunctionInfo<float>("get_Current");

		private CrossBindingMethodInfo mDispose_1 = new CrossBindingMethodInfo("Dispose");

		private CrossBindingFunctionInfo<bool> mMoveNext_2 = new CrossBindingFunctionInfo<bool>("MoveNext");

		private CrossBindingMethodInfo mReset_3 = new CrossBindingMethodInfo("Reset");

		private bool isInvokingToString;

		private ILTypeInstance instance;

		private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

		public ILTypeInstance ILInstance => instance;

		public float Current => mget_Current_0.Invoke(instance);

		object IEnumerator.Current => Current;

		public Adapter()
		{
		}

		public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			this.appdomain = appdomain;
			this.instance = instance;
		}

		public void Dispose()
		{
			mDispose_1.Invoke(instance);
		}

		public bool MoveNext()
		{
			return mMoveNext_2.Invoke(instance);
		}

		public void Reset()
		{
			mReset_3.Invoke(instance);
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

	public override Type BaseCLRType => typeof(IEnumerator<float>);

	public override Type AdaptorType => typeof(Adapter);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adapter(appdomain, instance);
	}
}
