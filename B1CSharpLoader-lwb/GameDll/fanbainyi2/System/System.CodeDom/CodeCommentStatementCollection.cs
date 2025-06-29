using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeCommentStatementCollection : CollectionBase
{
	public CodeCommentStatement this[int index]
	{
		get
		{
			return (CodeCommentStatement)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeCommentStatementCollection()
	{
	}

	public CodeCommentStatementCollection(CodeCommentStatementCollection value)
	{
		AddRange(value);
	}

	public CodeCommentStatementCollection(CodeCommentStatement[] value)
	{
		AddRange(value);
	}

	public int Add(CodeCommentStatement value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CodeCommentStatement[] value)
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

	public void AddRange(CodeCommentStatementCollection value)
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

	public bool Contains(CodeCommentStatement value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeCommentStatement[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeCommentStatement value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeCommentStatement value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeCommentStatement value)
	{
		base.List.Remove(value);
	}
}
