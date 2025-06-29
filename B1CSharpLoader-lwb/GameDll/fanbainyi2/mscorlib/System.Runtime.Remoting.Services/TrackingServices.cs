using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Services;

[SecurityCritical]
[ComVisible(true)]
public class TrackingServices
{
	private static volatile ITrackingHandler[] _Handlers = new ITrackingHandler[0];

	private static volatile int _Size = 0;

	private static object s_TrackingServicesSyncObject = null;

	private static object TrackingServicesSyncObject
	{
		get
		{
			if (s_TrackingServicesSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_TrackingServicesSyncObject, value, null);
			}
			return s_TrackingServicesSyncObject;
		}
	}

	public static ITrackingHandler[] RegisteredHandlers
	{
		[SecurityCritical]
		get
		{
			lock (TrackingServicesSyncObject)
			{
				if (_Size == 0)
				{
					return new ITrackingHandler[0];
				}
				ITrackingHandler[] array = new ITrackingHandler[_Size];
				for (int i = 0; i < _Size; i++)
				{
					array[i] = _Handlers[i];
				}
				return array;
			}
		}
	}

	[SecurityCritical]
	public static void RegisterTrackingHandler(ITrackingHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		lock (TrackingServicesSyncObject)
		{
			if (-1 == Match(handler))
			{
				if (_Handlers == null || _Size == _Handlers.Length)
				{
					ITrackingHandler[] array = new ITrackingHandler[_Size * 2 + 4];
					if (_Handlers != null)
					{
						Array.Copy(_Handlers, array, _Size);
					}
					_Handlers = array;
				}
				Volatile.Write(ref _Handlers[_Size++], handler);
				return;
			}
			throw new RemotingException(Environment.GetResourceString("Remoting_TrackingHandlerAlreadyRegistered", "handler"));
		}
	}

	[SecurityCritical]
	public static void UnregisterTrackingHandler(ITrackingHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		lock (TrackingServicesSyncObject)
		{
			int num = Match(handler);
			if (-1 == num)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_HandlerNotRegistered", handler));
			}
			Array.Copy(_Handlers, num + 1, _Handlers, num, _Size - num - 1);
			_Size--;
		}
	}

	[SecurityCritical]
	internal static void MarshaledObject(object obj, ObjRef or)
	{
		try
		{
			ITrackingHandler[] handlers = _Handlers;
			for (int i = 0; i < _Size; i++)
			{
				Volatile.Read(ref handlers[i]).MarshaledObject(obj, or);
			}
		}
		catch
		{
		}
	}

	[SecurityCritical]
	internal static void UnmarshaledObject(object obj, ObjRef or)
	{
		try
		{
			ITrackingHandler[] handlers = _Handlers;
			for (int i = 0; i < _Size; i++)
			{
				Volatile.Read(ref handlers[i]).UnmarshaledObject(obj, or);
			}
		}
		catch
		{
		}
	}

	[SecurityCritical]
	internal static void DisconnectedObject(object obj)
	{
		try
		{
			ITrackingHandler[] handlers = _Handlers;
			for (int i = 0; i < _Size; i++)
			{
				Volatile.Read(ref handlers[i]).DisconnectedObject(obj);
			}
		}
		catch
		{
		}
	}

	private static int Match(ITrackingHandler handler)
	{
		int result = -1;
		for (int i = 0; i < _Size; i++)
		{
			if (_Handlers[i] == handler)
			{
				result = i;
				break;
			}
		}
		return result;
	}
}
