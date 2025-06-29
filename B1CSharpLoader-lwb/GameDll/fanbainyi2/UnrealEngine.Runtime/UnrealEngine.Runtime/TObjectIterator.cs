using System;
using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TObjectIterator<T> : IEnumerator<T>, IDisposable, IEnumerator where T : UObject
{
	private UObject[] objectArray;

	private int index;

	public T Current
	{
		get
		{
			if (objectArray != null && index >= 0 && index < objectArray.Length)
			{
				return objectArray[index] as T;
			}
			return null;
		}
	}

	object IEnumerator.Current => Current;

	public TObjectIterator(EObjectFlags additionalExclusionFlags = EObjectFlags.ClassDefaultObject, bool includeDerivedClasses = true, EInternalObjectFlags internalExclusionFlags = EInternalObjectFlags.None)
	{
		index = -1;
		objectArray = UObjectHash.GetObjectsOfClass<T>(includeDerivedClasses, additionalExclusionFlags, internalExclusionFlags);
	}

	public void Dispose()
	{
	}

	public bool MoveNext()
	{
		if (objectArray == null)
		{
			return false;
		}
		while (++index < objectArray.Length)
		{
			if (Current != null)
			{
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
