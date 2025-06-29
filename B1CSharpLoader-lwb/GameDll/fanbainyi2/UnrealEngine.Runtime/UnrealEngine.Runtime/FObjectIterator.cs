using System;
using System.Collections;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FObjectIterator : IEnumerator<UObject>, IDisposable, IEnumerator
{
	private IntPtr objectArrayPtr;

	private int index;

	private UObject currentObject;

	private UClass unrealClass;

	private EObjectFlags exclusionFlags;

	private EInternalObjectFlags internalExclusionFlags;

	private UClass uobjectClass;

	public UObject Current => currentObject;

	object IEnumerator.Current => currentObject;

	public FObjectIterator()
		: this(null)
	{
	}

	public FObjectIterator(UClass unrealClass, bool onlyGCedObjects = false, EObjectFlags additionalExclusionFlags = EObjectFlags.NoFlags, EInternalObjectFlags internalExclusionFlags = EInternalObjectFlags.None)
	{
		objectArrayPtr = Native_FUObjectArray.GetGUObjectArray();
		index = -1;
		this.unrealClass = unrealClass;
		exclusionFlags = additionalExclusionFlags;
		this.internalExclusionFlags = internalExclusionFlags;
		uobjectClass = UClass.GetClass<UObject>();
		if (unrealClass == uobjectClass)
		{
			unrealClass = null;
		}
	}

	public void Dispose()
	{
	}

	public bool MoveNext()
	{
		if (objectArrayPtr == IntPtr.Zero)
		{
			return false;
		}
		currentObject = null;
		while (++index < Native_FUObjectArray.GetObjectArrayNum(objectArrayPtr))
		{
			UObject uObject = GCHelper.Find<UObject>(Native_FUObjectArray.GetObjectAtIndex(objectArrayPtr, index));
			if (uObject != null && uObject.HasAnyFlags(exclusionFlags) && (!(unrealClass != null) || !(unrealClass != uobjectClass) || uObject.IsA(unrealClass)) && !uObject.HasAnyInternalFlags(internalExclusionFlags))
			{
				currentObject = uObject;
				return true;
			}
		}
		return false;
	}

	public void Reset()
	{
		index = -1;
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}
}
