using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Contexts;

internal class DynamicPropertyHolder
{
	private const int GROW_BY = 8;

	private IDynamicProperty[] _props;

	private int _numProps;

	private IDynamicMessageSink[] _sinks;

	internal virtual IDynamicProperty[] DynamicProperties
	{
		get
		{
			if (_props == null)
			{
				return null;
			}
			lock (this)
			{
				IDynamicProperty[] array = new IDynamicProperty[_numProps];
				Array.Copy(_props, array, _numProps);
				return array;
			}
		}
	}

	internal virtual ArrayWithSize DynamicSinks
	{
		[SecurityCritical]
		get
		{
			if (_numProps == 0)
			{
				return null;
			}
			lock (this)
			{
				if (_sinks == null)
				{
					_sinks = new IDynamicMessageSink[_numProps + 8];
					for (int i = 0; i < _numProps; i++)
					{
						_sinks[i] = ((IContributeDynamicSink)_props[i]).GetDynamicSink();
					}
				}
			}
			return new ArrayWithSize(_sinks, _numProps);
		}
	}

	[SecurityCritical]
	internal virtual bool AddDynamicProperty(IDynamicProperty prop)
	{
		lock (this)
		{
			CheckPropertyNameClash(prop.Name, _props, _numProps);
			bool flag = false;
			if (_props == null || _numProps == _props.Length)
			{
				_props = GrowPropertiesArray(_props);
				flag = true;
			}
			_props[_numProps++] = prop;
			if (flag)
			{
				_sinks = GrowDynamicSinksArray(_sinks);
			}
			if (_sinks == null)
			{
				_sinks = new IDynamicMessageSink[_props.Length];
				for (int i = 0; i < _numProps; i++)
				{
					_sinks[i] = ((IContributeDynamicSink)_props[i]).GetDynamicSink();
				}
			}
			else
			{
				_sinks[_numProps - 1] = ((IContributeDynamicSink)prop).GetDynamicSink();
			}
			return true;
		}
	}

	[SecurityCritical]
	internal virtual bool RemoveDynamicProperty(string name)
	{
		lock (this)
		{
			for (int i = 0; i < _numProps; i++)
			{
				if (_props[i].Name.Equals(name))
				{
					_props[i] = _props[_numProps - 1];
					_numProps--;
					_sinks = null;
					return true;
				}
			}
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Contexts_NoProperty"), name));
		}
	}

	private static IDynamicMessageSink[] GrowDynamicSinksArray(IDynamicMessageSink[] sinks)
	{
		int num = ((sinks != null) ? sinks.Length : 0) + 8;
		IDynamicMessageSink[] array = new IDynamicMessageSink[num];
		if (sinks != null)
		{
			Array.Copy(sinks, array, sinks.Length);
		}
		return array;
	}

	[SecurityCritical]
	internal static void NotifyDynamicSinks(IMessage msg, ArrayWithSize dynSinks, bool bCliSide, bool bStart, bool bAsync)
	{
		for (int i = 0; i < dynSinks.Count; i++)
		{
			if (bStart)
			{
				dynSinks.Sinks[i].ProcessMessageStart(msg, bCliSide, bAsync);
			}
			else
			{
				dynSinks.Sinks[i].ProcessMessageFinish(msg, bCliSide, bAsync);
			}
		}
	}

	[SecurityCritical]
	internal static void CheckPropertyNameClash(string name, IDynamicProperty[] props, int count)
	{
		for (int i = 0; i < count; i++)
		{
			if (props[i].Name.Equals(name))
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_DuplicatePropertyName"));
			}
		}
	}

	internal static IDynamicProperty[] GrowPropertiesArray(IDynamicProperty[] props)
	{
		int num = ((props != null) ? props.Length : 0) + 8;
		IDynamicProperty[] array = new IDynamicProperty[num];
		if (props != null)
		{
			Array.Copy(props, array, props.Length);
		}
		return array;
	}
}
