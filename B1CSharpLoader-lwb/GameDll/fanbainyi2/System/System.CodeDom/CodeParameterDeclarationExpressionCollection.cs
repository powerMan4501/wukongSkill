using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeParameterDeclarationExpressionCollection : CollectionBase
{
	public CodeParameterDeclarationExpression this[int index]
	{
		get
		{
			return (CodeParameterDeclarationExpression)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeParameterDeclarationExpressionCollection()
	{
	}

	public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpressionCollection value)
	{
		AddRange(value);
	}

	public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpression[] value)
	{
		AddRange(value);
	}

	public int Add(CodeParameterDeclarationExpression value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CodeParameterDeclarationExpression[] value)
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

	public void AddRange(CodeParameterDeclarationExpressionCollection value)
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

	public bool Contains(CodeParameterDeclarationExpression value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeParameterDeclarationExpression[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeParameterDeclarationExpression value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeParameterDeclarationExpression value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeParameterDeclarationExpression value)
	{
		base.List.Remove(value);
	}
}
