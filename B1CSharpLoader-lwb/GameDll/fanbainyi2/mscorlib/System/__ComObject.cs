using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Security.Permissions;

namespace System;

[__DynamicallyInvokable]
internal class __ComObject : MarshalByRefObject
{
	private Hashtable m_ObjectToDataMap;

	protected __ComObject()
	{
	}

	public override string ToString()
	{
		if (AppDomain.IsAppXModel() && this is IStringable stringable)
		{
			return stringable.ToString();
		}
		return base.ToString();
	}

	[SecurityCritical]
	internal IntPtr GetIUnknown(out bool fIsURTAggregated)
	{
		fIsURTAggregated = !GetType().IsDefined(typeof(ComImportAttribute), inherit: false);
		return Marshal.GetIUnknownForObject(this);
	}

	internal object GetData(object key)
	{
		object result = null;
		lock (this)
		{
			if (m_ObjectToDataMap != null)
			{
				result = m_ObjectToDataMap[key];
			}
		}
		return result;
	}

	internal bool SetData(object key, object data)
	{
		bool result = false;
		lock (this)
		{
			if (m_ObjectToDataMap == null)
			{
				m_ObjectToDataMap = new Hashtable();
			}
			if (m_ObjectToDataMap[key] == null)
			{
				m_ObjectToDataMap[key] = data;
				result = true;
			}
		}
		return result;
	}

	[SecurityCritical]
	internal void ReleaseAllData()
	{
		lock (this)
		{
			if (m_ObjectToDataMap == null)
			{
				return;
			}
			foreach (object value in m_ObjectToDataMap.Values)
			{
				if (value is IDisposable disposable)
				{
					disposable.Dispose();
				}
				if (value is __ComObject o)
				{
					Marshal.ReleaseComObject(o);
				}
			}
			m_ObjectToDataMap = null;
		}
	}

	[SecurityCritical]
	internal object GetEventProvider(RuntimeType t)
	{
		object obj = GetData(t);
		if (obj == null)
		{
			obj = CreateEventProvider(t);
		}
		return obj;
	}

	[SecurityCritical]
	internal int ReleaseSelf()
	{
		return Marshal.InternalReleaseComObject(this);
	}

	[SecurityCritical]
	internal void FinalReleaseSelf()
	{
		Marshal.InternalFinalReleaseComObject(this);
	}

	[SecurityCritical]
	[ReflectionPermission(SecurityAction.Assert, MemberAccess = true)]
	private object CreateEventProvider(RuntimeType t)
	{
		object obj = Activator.CreateInstance(t, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[1] { this }, null);
		if (!SetData(t, obj))
		{
			if (obj is IDisposable disposable)
			{
				disposable.Dispose();
			}
			obj = GetData(t);
		}
		return obj;
	}
}
