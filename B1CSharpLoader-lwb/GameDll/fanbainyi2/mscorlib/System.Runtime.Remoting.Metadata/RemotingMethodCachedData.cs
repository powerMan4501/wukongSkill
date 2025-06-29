using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Remoting.Metadata;

internal class RemotingMethodCachedData : RemotingCachedData
{
	[Serializable]
	[Flags]
	private enum MethodCacheFlags
	{
		None = 0,
		CheckedOneWay = 1,
		IsOneWay = 2,
		CheckedOverloaded = 4,
		IsOverloaded = 8,
		CheckedForAsync = 0x10,
		CheckedForReturnType = 0x20
	}

	private MethodBase RI;

	private ParameterInfo[] _parameters;

	private MethodCacheFlags flags;

	private string _typeAndAssemblyName;

	private string _methodName;

	private Type _returnType;

	private int[] _inRefArgMap;

	private int[] _outRefArgMap;

	private int[] _outOnlyArgMap;

	private int[] _nonRefOutArgMap;

	private int[] _marshalRequestMap;

	private int[] _marshalResponseMap;

	internal string TypeAndAssemblyName
	{
		[SecurityCritical]
		get
		{
			if (_typeAndAssemblyName == null)
			{
				UpdateNames();
			}
			return _typeAndAssemblyName;
		}
	}

	internal string MethodName
	{
		[SecurityCritical]
		get
		{
			if (_methodName == null)
			{
				UpdateNames();
			}
			return _methodName;
		}
	}

	internal ParameterInfo[] Parameters
	{
		get
		{
			if (_parameters == null)
			{
				_parameters = RI.GetParameters();
			}
			return _parameters;
		}
	}

	internal int[] OutRefArgMap
	{
		get
		{
			if (_outRefArgMap == null)
			{
				GetArgMaps();
			}
			return _outRefArgMap;
		}
	}

	internal int[] OutOnlyArgMap
	{
		get
		{
			if (_outOnlyArgMap == null)
			{
				GetArgMaps();
			}
			return _outOnlyArgMap;
		}
	}

	internal int[] NonRefOutArgMap
	{
		get
		{
			if (_nonRefOutArgMap == null)
			{
				GetArgMaps();
			}
			return _nonRefOutArgMap;
		}
	}

	internal int[] MarshalRequestArgMap
	{
		get
		{
			if (_marshalRequestMap == null)
			{
				GetArgMaps();
			}
			return _marshalRequestMap;
		}
	}

	internal int[] MarshalResponseArgMap
	{
		get
		{
			if (_marshalResponseMap == null)
			{
				GetArgMaps();
			}
			return _marshalResponseMap;
		}
	}

	internal Type ReturnType
	{
		get
		{
			if ((flags & MethodCacheFlags.CheckedForReturnType) == 0)
			{
				MethodInfo methodInfo = RI as MethodInfo;
				if (methodInfo != null)
				{
					Type returnType = methodInfo.ReturnType;
					if (returnType != typeof(void))
					{
						_returnType = returnType;
					}
				}
				flags |= MethodCacheFlags.CheckedForReturnType;
			}
			return _returnType;
		}
	}

	internal RemotingMethodCachedData(RuntimeMethodInfo ri)
	{
		RI = ri;
	}

	internal RemotingMethodCachedData(RuntimeConstructorInfo ri)
	{
		RI = ri;
	}

	internal override SoapAttribute GetSoapAttributeNoLock()
	{
		SoapAttribute soapAttribute = null;
		object[] customAttributes = RI.GetCustomAttributes(typeof(SoapMethodAttribute), inherit: true);
		soapAttribute = ((customAttributes == null || customAttributes.Length == 0) ? new SoapMethodAttribute() : ((SoapAttribute)customAttributes[0]));
		soapAttribute.SetReflectInfo(RI);
		return soapAttribute;
	}

	[SecurityCritical]
	private void UpdateNames()
	{
		MethodBase rI = RI;
		_methodName = rI.Name;
		if (rI.DeclaringType != null)
		{
			_typeAndAssemblyName = RemotingServices.GetDefaultQualifiedTypeName((RuntimeType)rI.DeclaringType);
		}
	}

	private void GetArgMaps()
	{
		lock (this)
		{
			if (_inRefArgMap == null)
			{
				int[] inRefArgMap = null;
				int[] outRefArgMap = null;
				int[] outOnlyArgMap = null;
				int[] nonRefOutArgMap = null;
				int[] marshalRequestMap = null;
				int[] marshalResponseMap = null;
				ArgMapper.GetParameterMaps(Parameters, out inRefArgMap, out outRefArgMap, out outOnlyArgMap, out nonRefOutArgMap, out marshalRequestMap, out marshalResponseMap);
				_inRefArgMap = inRefArgMap;
				_outRefArgMap = outRefArgMap;
				_outOnlyArgMap = outOnlyArgMap;
				_nonRefOutArgMap = nonRefOutArgMap;
				_marshalRequestMap = marshalRequestMap;
				_marshalResponseMap = marshalResponseMap;
			}
		}
	}

	internal bool IsOneWayMethod()
	{
		if ((flags & MethodCacheFlags.CheckedOneWay) == 0)
		{
			MethodCacheFlags methodCacheFlags = MethodCacheFlags.CheckedOneWay;
			object[] customAttributes = RI.GetCustomAttributes(typeof(OneWayAttribute), inherit: true);
			if (customAttributes != null && customAttributes.Length != 0)
			{
				methodCacheFlags |= MethodCacheFlags.IsOneWay;
			}
			flags |= methodCacheFlags;
			return (methodCacheFlags & MethodCacheFlags.IsOneWay) != 0;
		}
		return (flags & MethodCacheFlags.IsOneWay) != 0;
	}

	internal bool IsOverloaded()
	{
		if ((flags & MethodCacheFlags.CheckedOverloaded) == 0)
		{
			MethodCacheFlags methodCacheFlags = MethodCacheFlags.CheckedOverloaded;
			MethodBase rI = RI;
			RuntimeMethodInfo runtimeMethodInfo = null;
			RuntimeConstructorInfo runtimeConstructorInfo = null;
			if ((runtimeMethodInfo = rI as RuntimeMethodInfo) != null)
			{
				if (runtimeMethodInfo.IsOverloaded)
				{
					methodCacheFlags |= MethodCacheFlags.IsOverloaded;
				}
			}
			else
			{
				if (!((runtimeConstructorInfo = rI as RuntimeConstructorInfo) != null))
				{
					throw new NotSupportedException(Environment.GetResourceString("InvalidOperation_Method"));
				}
				if (runtimeConstructorInfo.IsOverloaded)
				{
					methodCacheFlags |= MethodCacheFlags.IsOverloaded;
				}
			}
			flags |= methodCacheFlags;
		}
		return (flags & MethodCacheFlags.IsOverloaded) != 0;
	}
}
