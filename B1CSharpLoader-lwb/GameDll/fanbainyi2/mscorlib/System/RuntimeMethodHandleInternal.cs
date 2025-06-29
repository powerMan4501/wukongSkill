using System.Security;

namespace System;

internal struct RuntimeMethodHandleInternal
{
	internal IntPtr m_handle;

	internal static RuntimeMethodHandleInternal EmptyHandle => default(RuntimeMethodHandleInternal);

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
	internal RuntimeMethodHandleInternal(IntPtr value)
	{
		m_handle = value;
	}
}
