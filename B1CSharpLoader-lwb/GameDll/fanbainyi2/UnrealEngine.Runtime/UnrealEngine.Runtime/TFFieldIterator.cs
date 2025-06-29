using System;
using System.Collections;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class TFFieldIterator<T> : IEnumerator<T>, IDisposable, IEnumerator, IEnumerable<T>, IEnumerable where T : FProperty
{
	private UStruct targetStruct;

	private UStruct unrealStruct;

	private FField field;

	private int interfaceIndex;

	private bool includeSuper;

	private bool includeDeprecated;

	private bool includeInterface;

	private bool first;

	public T Current
	{
		get
		{
			if (!(field != null) || !(field.Address != IntPtr.Zero))
			{
				return null;
			}
			return new FProperty(field.Address) as T;
		}
	}

	object IEnumerator.Current
	{
		get
		{
			if (!(field != null) || !(field.Address != IntPtr.Zero))
			{
				return null;
			}
			return new FProperty(field.Address);
		}
	}

	public TFFieldIterator(UStruct unrealStruct, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
	{
		targetStruct = unrealStruct;
		this.unrealStruct = unrealStruct;
		field = new FField(GetFieldsFromStruct(unrealStruct).Address);
		interfaceIndex = -1;
		this.includeSuper = includeSuper;
		this.includeDeprecated = includeDeprecated;
		this.includeInterface = includeInterface && unrealStruct as UClass != null;
		first = true;
	}

	public UStruct GetStruct()
	{
		return unrealStruct;
	}

	public void Dispose()
	{
	}

	public bool MoveNext()
	{
		if (first)
		{
			first = false;
		}
		else
		{
			field = field.Next;
		}
		FField fField = field;
		UStruct inheritanceSuper = unrealStruct;
		while (inheritanceSuper != null)
		{
			while (fField != null && fField.Address != IntPtr.Zero)
			{
				if ((bool)Native_FField.HasAllCastFlags(fField.Address, 1uL) && (includeDeprecated || !Native_FField.HasAllCastFlags(fField.Address, 32768uL) || !new FProperty(fField.Address).HasAllPropertyFlags(EPropertyFlags.Deprecated)))
				{
					unrealStruct = inheritanceSuper;
					field = fField;
					return true;
				}
				fField = fField.Next;
			}
			if (includeInterface)
			{
				UClass obj = inheritanceSuper as UClass;
				interfaceIndex++;
				FImplementedInterface[] interfaces = obj.Interfaces;
				if (interfaces != null && interfaceIndex < interfaces.Length)
				{
					UClass interfaceClass = interfaces[interfaceIndex].InterfaceClass;
					fField = GetFieldsFromStruct(interfaceClass);
					continue;
				}
			}
			if (!includeSuper)
			{
				break;
			}
			inheritanceSuper = inheritanceSuper.GetInheritanceSuper();
			if (!(inheritanceSuper != null))
			{
				break;
			}
			fField = GetFieldsFromStruct(inheritanceSuper);
			interfaceIndex = -1;
		}
		unrealStruct = inheritanceSuper;
		field = fField;
		if (field != null)
		{
			return field.Address != IntPtr.Zero;
		}
		return false;
	}

	public void Reset()
	{
		unrealStruct = targetStruct;
		field = GetFieldsFromStruct(unrealStruct);
		interfaceIndex = -1;
		first = true;
	}

	private FField GetFieldsFromStruct(UStruct unrealStruct)
	{
		if (unrealStruct == null)
		{
			return null;
		}
		return new FField(unrealStruct.ChildProperties);
	}

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return this;
	}
}
