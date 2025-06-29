using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeNamespaceCollection : CollectionBase
{
	public CodeNamespace this[int index]
	{
		get
		{
			return (CodeNamespace)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeNamespaceCollection()
	{
	}

	public CodeNamespaceCollection(CodeNamespaceCollection value)
	{
		AddRange(value);
	}

	public CodeNamespaceCollection(CodeNamespace[] value)
	{
		AddRange(value);
	}

	public int Add(CodeNamespace value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CodeNamespace[] value)
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

	public void AddRange(CodeNamespaceCollection value)
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

	public bool Contains(CodeNamespace value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeNamespace[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeNamespace value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeNamespace value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeNamespace value)
	{
		base.List.Remove(value);
	}
}
