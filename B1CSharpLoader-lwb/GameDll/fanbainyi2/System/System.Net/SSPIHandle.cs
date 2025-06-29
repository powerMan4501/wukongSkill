using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Net;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct SSPIHandle
{
	private IntPtr HandleHi;

	private IntPtr HandleLo;

	public bool IsZero
	{
		get
		{
			if (HandleHi == IntPtr.Zero)
			{
				return HandleLo == IntPtr.Zero;
			}
			return false;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetToInvalid()
	{
		HandleHi = IntPtr.Zero;
		HandleLo = IntPtr.Zero;
	}

	public override string ToString()
	{
		return HandleHi.ToString("x") + ":" + HandleLo.ToString("x");
	}
}
