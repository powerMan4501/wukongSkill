using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public abstract class StructAsClass : IDisposable
{
	private bool initialized;

	private bool selfAllocated;

	private IntPtr structAddress;

	public UObject Owner { get; internal set; }

	public IntPtr Address { get; internal set; }

	public StructAsClass()
	{
		structAddress = GetStructAddress();
		Initialize();
	}

	protected void CheckDestroyed()
	{
		if (Owner != null && Owner.IsDestroyed)
		{
			throw new UObjectDestroyedException("Trying to access a StructAsClass which points to memory of a destroyed UObject (" + NativeReflection.GetUFieldPathName(structAddress) + ")");
		}
		if (!initialized)
		{
			throw new Exception("Trying to access a StructAsClass which either wasn't initialized or was destroyed (" + NativeReflection.GetUFieldPathName(structAddress) + ")");
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void EnsureNotInitialized()
	{
		if (initialized)
		{
			throw new Exception("StructAsClass is already initialized '" + GetType().FullName + "'");
		}
		if (structAddress == IntPtr.Zero)
		{
			throw new Exception("StructAsClass is not loaded '" + GetType().FullName + "'");
		}
	}

	public void Initialize(IntPtr address)
	{
		Initialize();
		InternalCopyFrom(address);
	}

	internal void Initialize()
	{
		if (!initialized)
		{
			_ = structAddress;
			if (Address == IntPtr.Zero)
			{
				Address = FMemory.Malloc(NativeReflection.GetStructSize(structAddress));
				Native_UStruct.InitializeStruct(structAddress, Address, 1);
				selfAllocated = true;
			}
			initialized = true;
		}
	}

	~StructAsClass()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!(Address != IntPtr.Zero))
		{
			return;
		}
		if (selfAllocated)
		{
			_ = structAddress;
			if (!SharedRuntimeState.IsShutdown)
			{
				Native_UStruct.DestroyStruct(structAddress, Address, 1);
			}
			FMemory.Free(Address);
		}
		Address = IntPtr.Zero;
		initialized = false;
		selfAllocated = false;
	}

	private void EnsureInitialized()
	{
		if (!initialized || Address == IntPtr.Zero)
		{
			throw new Exception("StructAsClass is not initialized '" + GetType().FullName + "'");
		}
		if (structAddress == IntPtr.Zero)
		{
			throw new Exception("StructAsClass is not loaded '" + GetType().FullName + "'");
		}
	}

	internal void InternalCopyTo(IntPtr address)
	{
		EnsureInitialized();
		Native_UScriptStruct.CopyScriptStruct(structAddress, address, Address, 1);
	}

	internal void InternalCopyFrom(IntPtr address)
	{
		if (!(address == IntPtr.Zero))
		{
			EnsureInitialized();
			Native_UScriptStruct.CopyScriptStruct(structAddress, Address, address, 1);
		}
	}

	internal void InternalCopyFromInstance(StructAsClass other)
	{
		if (other != null && other.initialized && !(other.Address == IntPtr.Zero))
		{
			InternalCopyFrom(other.Address);
		}
	}

	protected virtual IntPtr GetStructAddress()
	{
		return IntPtr.Zero;
	}
}
