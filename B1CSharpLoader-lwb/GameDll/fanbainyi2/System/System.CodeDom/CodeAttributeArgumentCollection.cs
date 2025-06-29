using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeAttributeArgumentCollection : CollectionBase
{
	public CodeAttributeArgument this[int index]
	{
		get
		{
			return (CodeAttributeArgument)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeAttributeArgumentCollection()
	{
	}

	public CodeAttributeArgumentCollection(CodeAttributeArgumentCollection value)
	{
		AddRange(value);
	}

	public CodeAttributeArgumentCollection(CodeAttributeArgument[] value)
	{
		AddRange(value);
	}

	public int Add(CodeAttributeArgument value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CodeAttributeArgument[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		for (int i = 0; i < value.Length; i++)
		{
			Add(value[i]);
		}
	}

	public void AddRange(CodeAttributeArgumentCollection value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		int count = value.Count;
		for (int i = 0; i < count; i++)
		{
			Add(value[i]);
		}
	}

	public bool Contains(CodeAttributeArgument value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeAttributeArgument[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeAttributeArgument value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeAttributeArgument value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeAttributeArgument value)
	{
		base.List.Remove(value);
	}
}
