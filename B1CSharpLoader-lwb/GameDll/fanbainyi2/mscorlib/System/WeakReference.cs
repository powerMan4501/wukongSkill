using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
public class WeakReference : ISerializable
{
	internal IntPtr m_handle;

	[__DynamicallyInvokable]
	public virtual extern bool IsAlive
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public virtual bool TrackResurrection
	{
		[__DynamicallyInvokable]
		get
		{
			return IsTrackResurrection();
		}
	}

	[__DynamicallyInvokable]
	public virtual extern object Target
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		set;
	}

	[__DynamicallyInvokable]
	public WeakReference(object target)
		: this(target, trackResurrection: false)
	{
	}

	[__DynamicallyInvokable]
	public WeakReference(object target, bool trackResurrection)
	{
		Create(target, trackResurrection);
	}

	protected WeakReference(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		object value = info.GetValue("TrackedObject", typeof(object));
		bool boolean = info.GetBoolean("TrackResurrection");
		Create(value, boolean);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	extern ~WeakReference();

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("TrackedObject", Target, typeof(object));
		info.AddValue("TrackResurrection", IsTrackResurrection());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern void Create(object target, bool trackResurrection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern bool IsTrackResurrection();
}
[Serializable]
[__DynamicallyInvokable]
public sealed class WeakReference<T> : ISerializable where T : class
{
	internal IntPtr m_handle;

	private extern T Target
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		set;
	}

	[__DynamicallyInvokable]
	public WeakReference(T target)
		: this(target, trackResurrection: false)
	{
	}

	[__DynamicallyInvokable]
	public WeakReference(T target, bool trackResurrection)
	{
		Create(target, trackResurrection);
	}

	internal WeakReference(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		T target = (T)info.GetValue("TrackedObject", typeof(T));
		bool boolean = info.GetBoolean("TrackResurrection");
		Create(target, boolean);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[__DynamicallyInvokable]
	public bool TryGetTarget(out T target)
	{
		return (target = Target) != null;
	}

	[__DynamicallyInvokable]
	public void SetTarget(T target)
	{
		Target = target;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	extern ~WeakReference();

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("TrackedObject", Target, typeof(T));
		info.AddValue("TrackResurrection", IsTrackResurrection());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern void Create(T target, bool trackResurrection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern bool IsTrackResurrection();
}
