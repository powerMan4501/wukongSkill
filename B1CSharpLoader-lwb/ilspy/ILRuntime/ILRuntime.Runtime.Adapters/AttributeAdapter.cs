using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Adapters;

public class AttributeAdapter : CrossBindingAdaptor
{
	public class Adapter : Attribute, CrossBindingAdaptorType
	{
		private ILTypeInstance instance;

		private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

		private bool isToStringGot;

		private IMethod toString;

		public ILTypeInstance ILInstance => instance;

		public Adapter(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
			this.appdomain = appdomain;
			this.instance = instance;
		}

		public override string ToString()
		{
			if (!isToStringGot)
			{
				isToStringGot = true;
				IMethod method = appdomain.ObjectType.GetMethod("ToString", 0);
				toString = instance.Type.GetVirtualMethod(method);
			}
			if (toString == null || toString is ILMethod)
			{
				return instance.ToString();
			}
			return instance.Type.FullName;
		}
	}

	public override Type AdaptorType => typeof(Adapter);

	public override Type BaseCLRType => typeof(Attribute);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adapter(appdomain, instance);
	}
}
