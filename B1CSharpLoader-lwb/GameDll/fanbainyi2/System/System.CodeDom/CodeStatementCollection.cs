using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeStatementCollection : CollectionBase
{
	public CodeStatement this[int index]
	{
		get
		{
			return (CodeStatement)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeStatementCollection()
	{
	}

	public CodeStatementCollection(CodeStatementCollection value)
	{
		AddRange(value);
	}

	public CodeStatementCollection(CodeStatement[] value)
	{
		AddRange(value);
	}

	public int Add(CodeStatement value)
	{
		return base.List.Add(value);
	}

	public int Add(CodeExpression value)
	{
		return Add(new CodeExpressionStatement(value));
	}

	public void AddRange(CodeStatement[] value)
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

	public void AddRange(CodeStatementCollection value)
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

	public bool Contains(CodeStatement value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeStatement[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeStatement value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeStatement value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeStatement value)
	{
		base.List.Remove(value);
	}
}
