using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

public class Adapt_CrashTest : CrossBindingAdaptor
{
	private class Adaptor : CrashTest, CrossBindingAdaptorType
	{
		private ILTypeInstance instance;

		private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

		private IMethod Construct_Implementation_Method;

		private bool Construct_Implementation_Got;

		private bool Construct_Implementation_Invoking;

		public ILTypeInstance ILInstance => instance;

		public Adaptor()
		{
		}

		public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			this.appdomain = appdomain;
			this.instance = instance;
		}

		public override void TestCrash()
		{
			IMethod method = instance.Type.GetMethod("TestCrash", 0);
			if (method != null)
			{
				appdomain.Invoke(method, instance, null);
			}
		}
	}

	public override Type BaseCLRType => typeof(CrashTest);

	public override Type[] BaseCLRTypes => null;

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
