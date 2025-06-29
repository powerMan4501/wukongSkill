using System;
using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FReferenceFinder : IDisposable
{
	private IntPtr address;

	private TArrayUnsafe<IntPtr> objArray;

	public FReferenceFinder(UObject outer, bool requireDirectOuter = true, bool shouldIgnoreArchetype = false, bool serializeRecursively = false, bool shouldIgnoreTransient = false)
		: this((outer == null) ? IntPtr.Zero : outer.Address, requireDirectOuter, shouldIgnoreArchetype, serializeRecursively, shouldIgnoreTransient)
	{
	}

	public FReferenceFinder(IntPtr outer, bool requireDirectOuter = true, bool shouldIgnoreArchetype = false, bool serializeRecursively = false, bool shouldIgnoreTransient = false)
	{
		objArray = new TArrayUnsafe<IntPtr>();
		address = Native_FReferenceFinder.New(objArray.Address, outer, requireDirectOuter, shouldIgnoreArchetype, serializeRecursively, shouldIgnoreTransient);
	}

	public void FindReferences(IntPtr obj, IntPtr referencingObject = default(IntPtr), IntPtr referencingProperty = default(IntPtr))
	{
		Native_FReferenceFinder.FindReferences(address, obj, referencingObject, referencingProperty);
	}

	public void FindReferences(UObject obj, UObject referencingObject = null, FProperty referencingProperty = null)
	{
		FindReferences((obj == null) ? IntPtr.Zero : obj.Address, (referencingObject == null) ? IntPtr.Zero : referencingObject.Address, (referencingProperty == null) ? IntPtr.Zero : referencingProperty.Address);
	}

	public IntPtr[] GetObjectPtrs()
	{
		return objArray.ToArray();
	}

	public UObject[] GetObjects()
	{
		UObject[] array = new UObject[objArray.Count];
		for (int i = 0; i < objArray.Count; i++)
		{
			array[i] = GCHelper.Find<UObject>(objArray[i]);
		}
		return array;
	}

	public void Dispose()
	{
		if (address != IntPtr.Zero)
		{
			Native_FReferenceFinder.Delete(address);
			address = IntPtr.Zero;
		}
		if (objArray != null)
		{
			objArray.Dispose();
			objArray = null;
		}
	}
}
