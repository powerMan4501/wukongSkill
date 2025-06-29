using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
public class AttributeCollection : ICollection, IEnumerable
{
	private struct AttributeEntry
	{
		public Type type;

		public int index;
	}

	public static readonly AttributeCollection Empty = new AttributeCollection((Attribute[])null);

	private static Hashtable _defaultAttributes;

	private Attribute[] _attributes;

	private static object internalSyncObject = new object();

	private const int FOUND_TYPES_LIMIT = 5;

	private AttributeEntry[] _foundAttributeTypes;

	private int _index;

	protected virtual Attribute[] Attributes => _attributes;

	public int Count => Attributes.Length;

	public virtual Attribute this[int index] => Attributes[index];

	public virtual Attribute this[Type attributeType]
	{
		get
		{
			lock (internalSyncObject)
			{
				if (_foundAttributeTypes == null)
				{
					_foundAttributeTypes = new AttributeEntry[5];
				}
				int i;
				for (i = 0; i < 5; i++)
				{
					if (_foundAttributeTypes[i].type == attributeType)
					{
						int index = _foundAttributeTypes[i].index;
						if (index != -1)
						{
							return Attributes[index];
						}
						return GetDefaultAttribute(attributeType);
					}
					if (_foundAttributeTypes[i].type == null)
					{
						break;
					}
				}
				i = _index++;
				if (_index >= 5)
				{
					_index = 0;
				}
				_foundAttributeTypes[i].type = attributeType;
				int num = Attributes.Length;
				for (int j = 0; j < num; j++)
				{
					Attribute attribute = Attributes[j];
					Type type = attribute.GetType();
					if (type == attributeType)
					{
						_foundAttributeTypes[i].index = j;
						return attribute;
					}
				}
				for (int k = 0; k < num; k++)
				{
					Attribute attribute2 = Attributes[k];
					Type type2 = attribute2.GetType();
					if (attributeType.IsAssignableFrom(type2))
					{
						_foundAttributeTypes[i].index = k;
						return attribute2;
					}
				}
				_foundAttributeTypes[i].index = -1;
				return GetDefaultAttribute(attributeType);
			}
		}
	}

	int ICollection.Count => Count;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => null;

	public AttributeCollection(params Attribute[] attributes)
	{
		if (attributes == null)
		{
			attributes = new Attribute[0];
		}
		_attributes = attributes;
		for (int i = 0; i < attributes.Length; i++)
		{
			if (attributes[i] == null)
			{
				throw new ArgumentNullException("attributes");
			}
		}
	}

	protected AttributeCollection()
	{
	}

	public static AttributeCollection FromExisting(AttributeCollection existing, params Attribute[] newAttributes)
	{
		if (existing == null)
		{
			throw new ArgumentNullException("existing");
		}
		if (newAttributes == null)
		{
			newAttributes = new Attribute[0];
		}
		Attribute[] array = new Attribute[existing.Count + newAttributes.Length];
		int count = existing.Count;
		existing.CopyTo(array, 0);
		for (int i = 0; i < newAttributes.Length; i++)
		{
			if (newAttributes[i] == null)
			{
				throw new ArgumentNullException("newAttributes");
			}
			bool flag = false;
			for (int j = 0; j < existing.Count; j++)
			{
				if (array[j].TypeId.Equals(newAttributes[i].TypeId))
				{
					flag = true;
					array[j] = newAttributes[i];
					break;
				}
			}
			if (!flag)
			{
				array[count++] = newAttributes[i];
			}
		}
		Attribute[] array2 = null;
		if (count < array.Length)
		{
			array2 = new Attribute[count];
			Array.Copy(array, 0, array2, 0, count);
		}
		else
		{
			array2 = array;
		}
		return new AttributeCollection(array2);
	}

	public bool Contains(Attribute attribute)
	{
		Attribute attribute2 = this[attribute.GetType()];
		if (attribute2 != null && attribute2.Equals(attribute))
		{
			return true;
		}
		return false;
	}

	public bool Contains(Attribute[] attributes)
	{
		if (attributes == null)
		{
			return true;
		}
		for (int i = 0; i < attributes.Length; i++)
		{
			if (!Contains(attributes[i]))
			{
				return false;
			}
		}
		return true;
	}

	protected Attribute GetDefaultAttribute(Type attributeType)
	{
		lock (internalSyncObject)
		{
			if (_defaultAttributes == null)
			{
				_defaultAttributes = new Hashtable();
			}
			if (_defaultAttributes.ContainsKey(attributeType))
			{
				return (Attribute)_defaultAttributes[attributeType];
			}
			Attribute attribute = null;
			Type reflectionType = TypeDescriptor.GetReflectionType(attributeType);
			FieldInfo field = reflectionType.GetField("Default", BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField);
			if (field != null && field.IsStatic)
			{
				attribute = (Attribute)field.GetValue(null);
			}
			else
			{
				ConstructorInfo constructor = reflectionType.UnderlyingSystemType.GetConstructor(new Type[0]);
				if (constructor != null)
				{
					attribute = (Attribute)constructor.Invoke(new object[0]);
					if (!attribute.IsDefaultAttribute())
					{
						attribute = null;
					}
				}
			}
			_defaultAttributes[attributeType] = attribute;
			return attribute;
		}
	}

	public IEnumerator GetEnumerator()
	{
		return Attributes.GetEnumerator();
	}

	public bool Matches(Attribute attribute)
	{
		for (int i = 0; i < Attributes.Length; i++)
		{
			if (Attributes[i].Match(attribute))
			{
				return true;
			}
		}
		return false;
	}

	public bool Matches(Attribute[] attributes)
	{
		for (int i = 0; i < attributes.Length; i++)
		{
			if (!Matches(attributes[i]))
			{
				return false;
			}
		}
		return true;
	}

	public void CopyTo(Array array, int index)
	{
		Array.Copy(Attributes, 0, array, index, Attributes.Length);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
