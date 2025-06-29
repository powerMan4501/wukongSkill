using System;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

public class Adapt_Exception : CrossBindingAdaptor
{
	public class Adaptor : Exception, CrossBindingAdaptorType
	{
		protected ILTypeInstance _instance;

		private static CrossBindingFunctionInfo<string> mToString = new CrossBindingFunctionInfo<string>("ToString");

		protected ILRuntime.Runtime.Enviorment.AppDomain AppDomain { get; set; }

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
			AppDomain = appdomain;
			_instance = instance;
		}

		public override string ToString()
		{
			return mToString.Invoke(_instance);
		}
	}

	public override Type BaseCLRType => typeof(Exception);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
