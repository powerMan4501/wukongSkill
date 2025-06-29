using System.Security;

namespace System;

internal struct RuntimeFieldHandleInternal
{
	internal IntPtr m_handle;

	internal static RuntimeFieldHandleInternal EmptyHandle => default(RuntimeFieldHandleInternal);

	internal IntPtr Value
	{
		[SecurityCritical]
		get
		{
			return m_handle;
		}
	}

	internal bool IsNullHandle()
	{
		return m_handle.IsNull();
	}

	[SecurityCritical]
	internal RuntimeFieldHandleInternal(IntPtr value)
	{
		m_handle = value;
	}
}
