using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System;

internal static class LocalAppContext
{
	private delegate bool TryGetSwitchDelegate(string switchName, out bool value);

	private static TryGetSwitchDelegate TryGetSwitchFromCentralAppContext;

	private static bool s_canForwardCalls;

	private static Dictionary<string, bool> s_switchMap;

	private static readonly object s_syncLock;

	private static bool DisableCaching { get; set; }

	static LocalAppContext()
	{
		s_switchMap = new Dictionary<string, bool>();
		s_syncLock = new object();
		s_canForwardCalls = SetupDelegate();
		System.AppContextDefaultValues.PopulateDefaultValues();
		DisableCaching = IsSwitchEnabled("TestSwitch.LocalAppContext.DisableCaching");
	}

	public static bool IsSwitchEnabled(string switchName)
	{
		if (s_canForwardCalls && TryGetSwitchFromCentralAppContext(switchName, out var value))
		{
			return value;
		}
		return IsSwitchEnabledLocal(switchName);
	}

	private static bool IsSwitchEnabledLocal(string switchName)
	{
		bool flag;
		bool value;
		lock (s_switchMap)
		{
			flag = s_switchMap.TryGetValue(switchName, out value);
		}
		if (flag)
		{
			return value;
		}
		return false;
	}

	private static bool SetupDelegate()
	{
		Type type = typeof(object).Assembly.GetType("System.AppContext");
		if (type == null)
		{
			return false;
		}
		MethodInfo method = type.GetMethod("TryGetSwitch", BindingFlags.Static | BindingFlags.Public, null, new Type[2]
		{
			typeof(string),
			typeof(bool).MakeByRefType()
		}, null);
		if (method == null)
		{
			return false;
		}
		TryGetSwitchFromCentralAppContext = (TryGetSwitchDelegate)Delegate.CreateDelegate(typeof(TryGetSwitchDelegate), method);
		return true;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue)
	{
		if (switchValue < 0)
		{
			return false;
		}
		if (switchValue > 0)
		{
			return true;
		}
		return GetCachedSwitchValueInternal(switchName, ref switchValue);
	}

	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue)
	{
		if (DisableCaching)
		{
			return IsSwitchEnabled(switchName);
		}
		bool flag = IsSwitchEnabled(switchName);
		switchValue = (flag ? 1 : (-1));
		return flag;
	}

	internal static void DefineSwitchDefault(string switchName, bool initialValue)
	{
		s_switchMap[switchName] = initialValue;
	}
}
