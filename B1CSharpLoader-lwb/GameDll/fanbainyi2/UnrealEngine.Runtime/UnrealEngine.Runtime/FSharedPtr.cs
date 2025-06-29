using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FSharedPtr
{
	public IntPtr Object;

	public IntPtr ReferenceController;

	public int GetSharedReferenceCount(ESPMode mode)
	{
		return Native_FReferenceControllerOps.GetSharedReferenceCount(ReferenceController, mode);
	}

	public bool IsUnique(ESPMode mode)
	{
		return GetSharedReferenceCount(mode) == 1;
	}

	public bool IsValid()
	{
		return Object != IntPtr.Zero;
	}

	public void AddSharedReference(ESPMode mode)
	{
		Native_FReferenceControllerOps.AddSharedReference(ReferenceController, mode);
	}

	public void ConditionallyAddSharedReference(ESPMode mode)
	{
		Native_FReferenceControllerOps.ConditionallyAddSharedReference(ReferenceController, mode);
	}

	public void ReleaseSharedReference(ESPMode mode)
	{
		Native_FReferenceControllerOps.ReleaseSharedReference(ReferenceController, mode);
	}

	public void AddWeakReference(ESPMode mode)
	{
		Native_FReferenceControllerOps.AddWeakReference(ReferenceController, mode);
	}

	public void ReleaseWeakReference(ESPMode mode)
	{
		Native_FReferenceControllerOps.ReleaseWeakReference(ReferenceController, mode);
	}

	public override string ToString()
	{
		return ToString(ESPMode.ThreadSafe);
	}

	public string ToString(ESPMode mode)
	{
		return "SharedPtr {" + Object + ", " + ReferenceController + ":" + GetSharedReferenceCount(mode) + "}";
	}
}
