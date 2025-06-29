using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeDirectiveCollection : CollectionBase
{
	public CodeDirective this[int index]
	{
		get
		{
			return (CodeDirective)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeDirectiveCollection()
	{
	}

	public CodeDirectiveCollection(CodeDirectiveCollection value)
	{
		AddRange(value);
	}

	public CodeDirectiveCollection(CodeDirective[] value)
	{
		AddRange(value);
	}

	public int Add(CodeDirective value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CodeDirective[] value)
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

	public void AddRange(CodeDirectiveCollection value)
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

	public bool Contains(CodeDirective value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeDirective[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeDirective value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeDirective value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeDirective value)
	{
		base.List.Remove(value);
	}
}
