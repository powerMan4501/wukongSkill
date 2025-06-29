using System;
using Google.Protobuf;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

public class Adapt_IMessage : CrossBindingAdaptor
{
	public class Adaptor : MyAdaptor, IMessage
	{
		public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
			: base(appdomain, instance)
		{
		}

		protected override AdaptHelper.AdaptMethod[] GetAdaptMethods()
		{
			return new AdaptHelper.AdaptMethod[3]
			{
				new AdaptHelper.AdaptMethod
				{
					Name = "MergeFrom",
					ParamCount = 1
				},
				new AdaptHelper.AdaptMethod
				{
					Name = "WriteTo",
					ParamCount = 1
				},
				new AdaptHelper.AdaptMethod
				{
					Name = "CalculateSize",
					ParamCount = 0
				}
			};
		}

		public void MergeFrom(CodedInputStream input)
		{
			Invoke(0, input);
		}

		public void WriteTo(CodedOutputStream output)
		{
			Invoke(1, output);
		}

		public int CalculateSize()
		{
			return (int)Invoke(2);
		}
	}

	public override Type BaseCLRType => typeof(IMessage);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
