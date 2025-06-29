using System.Security;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics;

internal class MessageBoxPopup
{
	private AutoResetEvent m_Event;

	private string m_Body;

	private string m_Title;

	private int m_Flags;

	public int ReturnValue { get; set; }

	[SecurityCritical]
	public MessageBoxPopup(string body, string title, int flags)
	{
		m_Event = new AutoResetEvent(initialState: false);
		m_Body = body;
		m_Title = title;
		m_Flags = flags;
	}

	public int ShowMessageBox()
	{
		Thread thread = new Thread(DoPopup);
		thread.Start();
		m_Event.WaitOne();
		return ReturnValue;
	}

	[SecuritySafeCritical]
	public void DoPopup()
	{
		ReturnValue = Microsoft.Win32.SafeNativeMethods.MessageBox(IntPtr.Zero, m_Body, m_Title, m_Flags);
		m_Event.Set();
	}
}
