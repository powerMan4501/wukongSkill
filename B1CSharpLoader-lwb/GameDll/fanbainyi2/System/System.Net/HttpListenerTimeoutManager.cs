using System.Net.Configuration;

namespace System.Net;

public class HttpListenerTimeoutManager
{
	private HttpListener listener;

	private int[] timeouts;

	private uint minSendBytesPerSecond;

	public TimeSpan EntityBody
	{
		get
		{
			return GetTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.EntityBody);
		}
		set
		{
			SetTimespanTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.EntityBody, value);
		}
	}

	public TimeSpan DrainEntityBody
	{
		get
		{
			return GetTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.DrainEntityBody);
		}
		set
		{
			SetTimespanTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.DrainEntityBody, value);
		}
	}

	public TimeSpan RequestQueue
	{
		get
		{
			return GetTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.RequestQueue);
		}
		set
		{
			SetTimespanTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.RequestQueue, value);
		}
	}

	public TimeSpan IdleConnection
	{
		get
		{
			return GetTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.IdleConnection);
		}
		set
		{
			SetTimespanTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.IdleConnection, value);
		}
	}

	public TimeSpan HeaderWait
	{
		get
		{
			return GetTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.HeaderWait);
		}
		set
		{
			SetTimespanTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE.HeaderWait, value);
		}
	}

	public long MinSendBytesPerSecond
	{
		get
		{
			return minSendBytesPerSecond;
		}
		set
		{
			if (value < 0 || value > uint.MaxValue)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			listener.SetServerTimeout(timeouts, (uint)value);
			minSendBytesPerSecond = (uint)value;
		}
	}

	internal HttpListenerTimeoutManager(HttpListener context)
	{
		listener = context;
		timeouts = new int[5];
		LoadConfigurationSettings();
	}

	private void LoadConfigurationSettings()
	{
		long[] httpListenerTimeouts = SettingsSectionInternal.Section.HttpListenerTimeouts;
		bool flag = false;
		for (int i = 0; i < timeouts.Length; i++)
		{
			if (httpListenerTimeouts[i] != 0L)
			{
				timeouts[i] = (int)httpListenerTimeouts[i];
				flag = true;
			}
		}
		if (httpListenerTimeouts[5] != 0L)
		{
			minSendBytesPerSecond = (uint)httpListenerTimeouts[5];
			flag = true;
		}
		if (flag)
		{
			listener.SetServerTimeout(timeouts, minSendBytesPerSecond);
		}
	}

	private TimeSpan GetTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE type)
	{
		return new TimeSpan(0, 0, timeouts[(int)type]);
	}

	private void SetTimespanTimeout(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_TYPE type, TimeSpan value)
	{
		long num = Convert.ToInt64(value.TotalSeconds);
		if (num < 0 || num > 65535)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		int[] array = timeouts;
		array[(int)type] = (int)num;
		listener.SetServerTimeout(array, minSendBytesPerSecond);
		timeouts[(int)type] = (int)num;
	}
}
