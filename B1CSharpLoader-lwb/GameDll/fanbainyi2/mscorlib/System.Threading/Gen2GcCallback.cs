using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading;

internal sealed class Gen2GcCallback : CriticalFinalizerObject
{
	private Func<object, bool> m_callback;

	private GCHandle m_weakTargetObj;

	[SecuritySafeCritical]
	public Gen2GcCallback()
	{
	}

	public static void Register(Func<object, bool> callback, object targetObj)
	{
		Gen2GcCallback gen2GcCallback = new Gen2GcCallback();
		gen2GcCallback.Setup(callback, targetObj);
	}

	[SecuritySafeCritical]
	private void Setup(Func<object, bool> callback, object targetObj)
	{
		m_callback = callback;
		m_weakTargetObj = GCHandle.Alloc(targetObj, GCHandleType.Weak);
	}

	[SecuritySafeCritical]
	~Gen2GcCallback()
	{
		if (!m_weakTargetObj.IsAllocated)
		{
			return;
		}
		object target = m_weakTargetObj.Target;
		if (target == null)
		{
			m_weakTargetObj.Free();
			return;
		}
		try
		{
			if (!m_callback(target))
			{
				return;
			}
		}
		catch
		{
		}
		if (!Environment.HasShutdownStarted && !AppDomain.CurrentDomain.IsFinalizingForUnload())
		{
			GC.ReRegisterForFinalize(this);
		}
	}
}
