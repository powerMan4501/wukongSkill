using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeCatchClauseCollection : CollectionBase
{
	public CodeCatchClause this[int index]
	{
		get
		{
			return (CodeCatchClause)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeCatchClauseCollection()
	{
	}

	public CodeCatchClauseCollection(CodeCatchClauseCollection value)
	{
		AddRange(value);
	}

	public CodeCatchClauseCollection(CodeCatchClause[] value)
	{
		AddRange(value);
	}

	public int Add(CodeCatchClause value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CodeCatchClause[] value)
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

	public void AddRange(CodeCatchClauseCollection value)
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

	public bool Contains(CodeCatchClause value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeCatchClause[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeCatchClause value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeCatchClause value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeCatchClause value)
	{
		base.List.Remove(value);
	}
}
