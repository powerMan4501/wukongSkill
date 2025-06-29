using System;
using b1.UI.Comm;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace b1;

public class Adapt_IAutoSizeItem : CrossBindingAdaptor
{
	public class Adaptor : IAutoSizeItem, CrossBindingAdaptorType
	{
		protected ILTypeInstance _instance;

		protected ILRuntime.Runtime.Enviorment.AppDomain _appdomain { get; set; }

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
			_appdomain = appdomain;
			_instance = instance;
		}

		public BUI_Button GetBUIButton()
		{
			IMethod method = _instance.Type.GetMethod("GetBUIButton", 0);
			if (method != null)
			{
				return (BUI_Button)_appdomain.Invoke(method, _instance);
			}
			return null;
		}

		public void SetSizeMultiple(float SizeMultiple)
		{
			IMethod method = _instance.Type.GetMethod("SetSizeMultiple", 1);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, SizeMultiple);
			}
		}

		public void SetScaleMultiple(float ScaleMultiple)
		{
			IMethod method = _instance.Type.GetMethod("SetScaleMultiple", 1);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, ScaleMultiple);
			}
		}

		public float GetSizeMultiple()
		{
			IMethod method = _instance.Type.GetMethod("GetSizeMultiple", 0);
			if (method != null)
			{
				return (float)_appdomain.Invoke(method, _instance);
			}
			return 0f;
		}

		public float GetScaleMultiple()
		{
			IMethod method = _instance.Type.GetMethod("GetScaleMultiple", 0);
			if (method != null)
			{
				return (float)_appdomain.Invoke(method, _instance);
			}
			return 0f;
		}

		public void SetPosition(float Position)
		{
			IMethod method = _instance.Type.GetMethod("SetPosition", 1);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, Position);
			}
		}

		public float GetPosition()
		{
			IMethod method = _instance.Type.GetMethod("GetPosition", 0);
			if (method != null)
			{
				return (float)_appdomain.Invoke(method, _instance);
			}
			return 0f;
		}

		public void SetBasePosition(float Position)
		{
			IMethod method = _instance.Type.GetMethod("SetBasePosition", 1);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, Position);
			}
		}

		public float GetBasePosition()
		{
			IMethod method = _instance.Type.GetMethod("GetBasePosition", 0);
			if (method != null)
			{
				return (float)_appdomain.Invoke(method, _instance);
			}
			return 0f;
		}

		public void SetOrder(int Order)
		{
			IMethod method = _instance.Type.GetMethod("SetOrder", 1);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, Order);
			}
		}

		public int GetOrder()
		{
			IMethod method = _instance.Type.GetMethod("GetOrder", 0);
			if (method != null)
			{
				return (int)_appdomain.Invoke(method, _instance);
			}
			return 0;
		}

		public void SetIsActive(EChangeReason Reason, bool IsActive)
		{
			IMethod method = _instance.Type.GetMethod("SetIsActive", 2);
			if (method != null)
			{
				_appdomain.Invoke(method, _instance, Reason, IsActive);
			}
		}

		public bool GetIsActive()
		{
			IMethod method = _instance.Type.GetMethod("GetIsActive", 0);
			if (method != null)
			{
				return (bool)_appdomain.Invoke(method, _instance);
			}
			return false;
		}

		public bool IsVisable()
		{
			IMethod method = _instance.Type.GetMethod("IsVisable", 0);
			if (method != null)
			{
				return (bool)_appdomain.Invoke(method, _instance);
			}
			return false;
		}
	}

	public override Type BaseCLRType => typeof(IAutoSizeItem);

	public override Type AdaptorType => typeof(Adaptor);

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return new Adaptor(appdomain, instance);
	}
}
