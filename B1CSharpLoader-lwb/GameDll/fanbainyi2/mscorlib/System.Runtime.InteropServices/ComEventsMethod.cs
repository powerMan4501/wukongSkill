using System.Reflection;

namespace System.Runtime.InteropServices;

internal class ComEventsMethod
{
	internal class DelegateWrapper
	{
		private Delegate _d;

		private bool _once;

		private int _expectedParamsCount;

		private Type[] _cachedTargetTypes;

		public Delegate Delegate
		{
			get
			{
				return _d;
			}
			set
			{
				_d = value;
			}
		}

		public DelegateWrapper(Delegate d)
		{
			_d = d;
		}

		public object Invoke(object[] args)
		{
			if ((object)_d == null)
			{
				return null;
			}
			if (!_once)
			{
				PreProcessSignature();
				_once = true;
			}
			if (_cachedTargetTypes != null && _expectedParamsCount == args.Length)
			{
				for (int i = 0; i < _expectedParamsCount; i++)
				{
					if (_cachedTargetTypes[i] != null)
					{
						args[i] = Enum.ToObject(_cachedTargetTypes[i], args[i]);
					}
				}
			}
			return _d.DynamicInvoke(args);
		}

		private void PreProcessSignature()
		{
			ParameterInfo[] parameters = _d.Method.GetParameters();
			_expectedParamsCount = parameters.Length;
			Type[] array = new Type[_expectedParamsCount];
			bool flag = false;
			for (int i = 0; i < _expectedParamsCount; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				if (parameterInfo.ParameterType.IsByRef && parameterInfo.ParameterType.HasElementType && parameterInfo.ParameterType.GetElementType().IsEnum)
				{
					flag = true;
					array[i] = parameterInfo.ParameterType.GetElementType();
				}
			}
			if (flag)
			{
				_cachedTargetTypes = array;
			}
		}
	}

	private DelegateWrapper[] _delegateWrappers;

	private int _dispid;

	private ComEventsMethod _next;

	internal int DispId => _dispid;

	internal bool Empty
	{
		get
		{
			if (_delegateWrappers != null)
			{
				return _delegateWrappers.Length == 0;
			}
			return true;
		}
	}

	internal ComEventsMethod(int dispid)
	{
		_delegateWrappers = null;
		_dispid = dispid;
	}

	internal static ComEventsMethod Find(ComEventsMethod methods, int dispid)
	{
		while (methods != null && methods._dispid != dispid)
		{
			methods = methods._next;
		}
		return methods;
	}

	internal static ComEventsMethod Add(ComEventsMethod methods, ComEventsMethod method)
	{
		method._next = methods;
		return method;
	}

	internal static ComEventsMethod Remove(ComEventsMethod methods, ComEventsMethod method)
	{
		if (methods == method)
		{
			methods = methods._next;
		}
		else
		{
			ComEventsMethod comEventsMethod = methods;
			while (comEventsMethod != null && comEventsMethod._next != method)
			{
				comEventsMethod = comEventsMethod._next;
			}
			if (comEventsMethod != null)
			{
				comEventsMethod._next = method._next;
			}
		}
		return methods;
	}

	internal void AddDelegate(Delegate d)
	{
		int num = 0;
		if (_delegateWrappers != null)
		{
			num = _delegateWrappers.Length;
		}
		for (int i = 0; i < num; i++)
		{
			if (_delegateWrappers[i].Delegate.GetType() == d.GetType())
			{
				_delegateWrappers[i].Delegate = Delegate.Combine(_delegateWrappers[i].Delegate, d);
				return;
			}
		}
		DelegateWrapper[] array = new DelegateWrapper[num + 1];
		if (num > 0)
		{
			_delegateWrappers.CopyTo(array, 0);
		}
		DelegateWrapper delegateWrapper = new DelegateWrapper(d);
		array[num] = delegateWrapper;
		_delegateWrappers = array;
	}

	internal void RemoveDelegate(Delegate d)
	{
		int num = _delegateWrappers.Length;
		int num2 = -1;
		for (int i = 0; i < num; i++)
		{
			if (_delegateWrappers[i].Delegate.GetType() == d.GetType())
			{
				num2 = i;
				break;
			}
		}
		if (num2 < 0)
		{
			return;
		}
		Delegate obj = Delegate.Remove(_delegateWrappers[num2].Delegate, d);
		if ((object)obj != null)
		{
			_delegateWrappers[num2].Delegate = obj;
			return;
		}
		if (num == 1)
		{
			_delegateWrappers = null;
			return;
		}
		DelegateWrapper[] array = new DelegateWrapper[num - 1];
		int j;
		for (j = 0; j < num2; j++)
		{
			array[j] = _delegateWrappers[j];
		}
		for (; j < num - 1; j++)
		{
			array[j] = _delegateWrappers[j + 1];
		}
		_delegateWrappers = array;
	}

	internal object Invoke(object[] args)
	{
		object result = null;
		DelegateWrapper[] delegateWrappers = _delegateWrappers;
		DelegateWrapper[] array = delegateWrappers;
		foreach (DelegateWrapper delegateWrapper in array)
		{
			if (delegateWrapper != null && (object)delegateWrapper.Delegate != null)
			{
				result = delegateWrapper.Invoke(args);
			}
		}
		return result;
	}
}
