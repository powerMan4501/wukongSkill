using System;
using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TUFieldIterator<T> : IEnumerator<T>, IDisposable, IEnumerator, IEnumerable<T>, IEnumerable where T : UObject
{
	private UClass typeClass;

	private UStruct targetStruct;

	private UStruct unrealStruct;

	private UField field;

	private int interfaceIndex;

	private bool includeSuper;

	private bool includeDeprecated;

	private bool includeInterface;

	private bool first;

	public T Current => field as T;

	object IEnumerator.Current => field;

	public TUFieldIterator(UStruct unrealStruct, bool includeSuper = true, bool includeDeprecated = true, bool includeInterface = false)
	{
		typeClass = UClass.GetClass<T>();
		targetStruct = unrealStruct;
		this.unrealStruct = unrealStruct;
		field = GetFieldsFromStruct(unrealStruct);
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
		UField uField = field;
		UStruct inheritanceSuper = unrealStruct;
		while (inheritanceSuper != null)
		{
			while (uField != null)
			{
				UClass uClass = uField.GetClass();
				FProperty fProperty = new FProperty(uField.Address);
				if (uClass.HasAllCastFlags(typeClass.ClassCastFlags) && (includeDeprecated || !uClass.HasAllCastFlags(EClassCastFlags.FProperty) || !fProperty.HasAllPropertyFlags(EPropertyFlags.Deprecated)))
				{
					unrealStruct = inheritanceSuper;
					field = uField;
					return true;
				}
				uField = uField.Next;
			}
			if (includeInterface)
			{
				UClass obj = inheritanceSuper as UClass;
				interfaceIndex++;
				FImplementedInterface[] interfaces = obj.Interfaces;
				if (interfaces != null && interfaceIndex < interfaces.Length)
				{
					UClass interfaceClass = interfaces[interfaceIndex].InterfaceClass;
					uField = GetFieldsFromStruct(interfaceClass);
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
			uField = GetFieldsFromStruct(inheritanceSuper);
			interfaceIndex = -1;
		}
		unrealStruct = inheritanceSuper;
		field = uField;
		return field != null;
	}

	public void Reset()
	{
		unrealStruct = targetStruct;
		field = GetFieldsFromStruct(unrealStruct);
		interfaceIndex = -1;
		first = true;
	}

	private UField GetFieldsFromStruct(UStruct unrealStruct)
	{
		if (unrealStruct == null)
		{
			return null;
		}
		return unrealStruct.Children;
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
