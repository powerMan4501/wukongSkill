using System.Reflection;
using System.Runtime.Remoting.Metadata;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class ArgMapper
{
	private int[] _map;

	private IMethodMessage _mm;

	private RemotingMethodCachedData _methodCachedData;

	internal int[] Map => _map;

	internal int ArgCount
	{
		get
		{
			if (_map == null)
			{
				return 0;
			}
			return _map.Length;
		}
	}

	internal object[] Args
	{
		[SecurityCritical]
		get
		{
			if (_map == null)
			{
				return null;
			}
			object[] array = new object[_map.Length];
			for (int i = 0; i < _map.Length; i++)
			{
				array[i] = _mm.GetArg(_map[i]);
			}
			return array;
		}
	}

	internal Type[] ArgTypes
	{
		get
		{
			Type[] array = null;
			if (_map != null)
			{
				ParameterInfo[] parameters = _methodCachedData.Parameters;
				array = new Type[_map.Length];
				for (int i = 0; i < _map.Length; i++)
				{
					array[i] = parameters[_map[i]].ParameterType;
				}
			}
			return array;
		}
	}

	internal string[] ArgNames
	{
		get
		{
			string[] array = null;
			if (_map != null)
			{
				ParameterInfo[] parameters = _methodCachedData.Parameters;
				array = new string[_map.Length];
				for (int i = 0; i < _map.Length; i++)
				{
					array[i] = parameters[_map[i]].Name;
				}
			}
			return array;
		}
	}

	[SecurityCritical]
	internal ArgMapper(IMethodMessage mm, bool fOut)
	{
		_mm = mm;
		MethodBase methodBase = _mm.MethodBase;
		_methodCachedData = InternalRemotingServices.GetReflectionCachedData(methodBase);
		if (fOut)
		{
			_map = _methodCachedData.MarshalResponseArgMap;
		}
		else
		{
			_map = _methodCachedData.MarshalRequestArgMap;
		}
	}

	[SecurityCritical]
	internal ArgMapper(MethodBase mb, bool fOut)
	{
		_methodCachedData = InternalRemotingServices.GetReflectionCachedData(mb);
		if (fOut)
		{
			_map = _methodCachedData.MarshalResponseArgMap;
		}
		else
		{
			_map = _methodCachedData.MarshalRequestArgMap;
		}
	}

	[SecurityCritical]
	internal object GetArg(int argNum)
	{
		if (_map == null || argNum < 0 || argNum >= _map.Length)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
		return _mm.GetArg(_map[argNum]);
	}

	[SecurityCritical]
	internal string GetArgName(int argNum)
	{
		if (_map == null || argNum < 0 || argNum >= _map.Length)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InternalState"));
		}
		return _mm.GetArgName(_map[argNum]);
	}

	internal static void GetParameterMaps(ParameterInfo[] parameters, out int[] inRefArgMap, out int[] outRefArgMap, out int[] outOnlyArgMap, out int[] nonRefOutArgMap, out int[] marshalRequestMap, out int[] marshalResponseMap)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int[] array = new int[parameters.Length];
		int[] array2 = new int[parameters.Length];
		int num7 = 0;
		foreach (ParameterInfo parameterInfo in parameters)
		{
			bool isIn = parameterInfo.IsIn;
			bool isOut = parameterInfo.IsOut;
			bool isByRef = parameterInfo.ParameterType.IsByRef;
			if (!isByRef)
			{
				num++;
				if (isOut)
				{
					num4++;
				}
			}
			else if (isOut)
			{
				num2++;
				num3++;
			}
			else
			{
				num++;
				num2++;
			}
			bool flag = false;
			bool flag2 = false;
			if (isByRef)
			{
				if (isIn == isOut)
				{
					flag = true;
					flag2 = true;
				}
				else
				{
					flag = isIn;
					flag2 = isOut;
				}
			}
			else
			{
				flag = true;
				flag2 = isOut;
			}
			if (flag)
			{
				array[num5++] = num7;
			}
			if (flag2)
			{
				array2[num6++] = num7;
			}
			num7++;
		}
		inRefArgMap = new int[num];
		outRefArgMap = new int[num2];
		outOnlyArgMap = new int[num3];
		nonRefOutArgMap = new int[num4];
		num = 0;
		num2 = 0;
		num3 = 0;
		num4 = 0;
		for (num7 = 0; num7 < parameters.Length; num7++)
		{
			ParameterInfo parameterInfo2 = parameters[num7];
			bool isOut2 = parameterInfo2.IsOut;
			if (!parameterInfo2.ParameterType.IsByRef)
			{
				inRefArgMap[num++] = num7;
				if (isOut2)
				{
					nonRefOutArgMap[num4++] = num7;
				}
			}
			else if (isOut2)
			{
				outRefArgMap[num2++] = num7;
				outOnlyArgMap[num3++] = num7;
			}
			else
			{
				inRefArgMap[num++] = num7;
				outRefArgMap[num2++] = num7;
			}
		}
		marshalRequestMap = new int[num5];
		Array.Copy(array, marshalRequestMap, num5);
		marshalResponseMap = new int[num6];
		Array.Copy(array2, marshalResponseMap, num6);
	}

	internal static object[] ExpandAsyncEndArgsToSyncArgs(RemotingMethodCachedData syncMethod, object[] asyncEndArgs)
	{
		object[] array = new object[syncMethod.Parameters.Length];
		int[] outRefArgMap = syncMethod.OutRefArgMap;
		for (int i = 0; i < outRefArgMap.Length; i++)
		{
			array[outRefArgMap[i]] = asyncEndArgs[i];
		}
		return array;
	}
}
