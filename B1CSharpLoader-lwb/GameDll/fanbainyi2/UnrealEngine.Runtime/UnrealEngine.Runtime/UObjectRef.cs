using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class UObjectRef
{
	public IntPtr Native;

	public GCHandle ManagedHandle;

	public UObject Managed;

	public bool IsKnownType;

	public uint Id;

	public int InternalIndex;

	private static uint sid = 1u;

	public event UObjectRefDestroyedHandler OnDestroyed;

	public void Initialize(IntPtr native, Type type, bool isKnownType, int internalIndex)
	{
		InternalIndex = internalIndex;
		Id = sid++;
		Native = native;
		IsKnownType = isKnownType;
		Managed = (UObject)Activator.CreateInstance(type);
		Managed.objRef = this;
		Managed.objRefId = Id;
		Managed.Address = native;
		if (GCHelper.ManagedObjectBeingInitialized != native)
		{
			Managed.Initialize();
		}
		ManagedHandle = GCHandle.Alloc(this, GCHandleType.Weak);
	}

	public void Reset()
	{
		if (this.OnDestroyed != null)
		{
			this.OnDestroyed(this);
		}
		Native = IntPtr.Zero;
		ManagedHandle = default(GCHandle);
		Managed = null;
		IsKnownType = false;
		Id = 0u;
		this.OnDestroyed = null;
	}
}
