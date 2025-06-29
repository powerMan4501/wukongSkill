using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class WinRTClassActivator : MarshalByRefObject, IWinRTClassActivator
{
	[SecurityCritical]
	public object ActivateInstance(string activatableClassId)
	{
		ManagedActivationFactory managedActivationFactory = WindowsRuntimeMarshal.GetManagedActivationFactory(LoadWinRTType(activatableClassId));
		return managedActivationFactory.ActivateInstance();
	}

	[SecurityCritical]
	public IntPtr GetActivationFactory(string activatableClassId, ref Guid iid)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = WindowsRuntimeMarshal.GetActivationFactoryForType(LoadWinRTType(activatableClassId));
			IntPtr ppv = IntPtr.Zero;
			int num = Marshal.QueryInterface(intPtr, ref iid, out ppv);
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
			return ppv;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.Release(intPtr);
			}
		}
	}

	private Type LoadWinRTType(string acid)
	{
		Type type = Type.GetType(acid + ", Windows, ContentType=WindowsRuntime");
		if (type == null)
		{
			throw new COMException(-2147221164);
		}
		return type;
	}

	[SecurityCritical]
	internal IntPtr GetIWinRTClassActivator()
	{
		return Marshal.GetComInterfaceForObject(this, typeof(IWinRTClassActivator));
	}
}
