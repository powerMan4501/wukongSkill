using System.Security;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.IO.MemoryMappedFiles;

public sealed class MemoryMappedViewAccessor : UnmanagedMemoryAccessor
{
	private MemoryMappedView m_view;

	public SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			if (m_view == null)
			{
				return null;
			}
			return m_view.ViewHandle;
		}
	}

	public long PointerOffset
	{
		get
		{
			if (m_view == null)
			{
				throw new InvalidOperationException(System.SR.GetString("InvalidOperation_ViewIsNull"));
			}
			return m_view.PointerOffset;
		}
	}

	[SecurityCritical]
	internal MemoryMappedViewAccessor(MemoryMappedView view)
	{
		m_view = view;
		Initialize(m_view.ViewHandle, m_view.PointerOffset, m_view.Size, MemoryMappedFile.GetFileAccess(m_view.Access));
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && m_view != null && !m_view.IsClosed)
			{
				Flush();
			}
		}
		finally
		{
			try
			{
				if (m_view != null)
				{
					m_view.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
	}

	[SecurityCritical]
	public void Flush()
	{
		if (!base.IsOpen)
		{
			throw new ObjectDisposedException("MemoryMappedViewAccessor", System.SR.GetString("ObjectDisposed_ViewAccessorClosed"));
		}
		if (m_view != null)
		{
			m_view.Flush((IntPtr)base.Capacity);
		}
	}
}
