using System;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using UnrealEngine.UMG;

public class Adapt_UUserWidget : CrossBindingAdaptor
{
	private class Adaptor : UUserWidget, CrossBindingAdaptorType
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

		protected override void Construct_Implementation()
		{
			if (!Construct_Implementation_Got)
			{
				Construct_Implementation_Method = instance.Type.GetMethod("Construct_Implementation", 0);
				Construct_Implementation_Got = true;
			}
			if (Construct_Implementation_Method != null && !Construct_Implementation_Invoking)
			{
				Construct_Implementation_Invoking = true;
				appdomain.Invoke(Construct_Implementation_Method, instance, null);
				Construct_Implementation_Invoking = false;
			}
			else
			{
				base.Construct_Implementation();
			}
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

	public override Type BaseCLRType => typeof(UUserWidget);

	public override Type[] BaseCLRTypes => null;

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
