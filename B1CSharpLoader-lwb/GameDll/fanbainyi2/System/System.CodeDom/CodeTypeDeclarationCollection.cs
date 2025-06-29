using System.Collections;
using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeTypeDeclarationCollection : CollectionBase
{
	public CodeTypeDeclaration this[int index]
	{
		get
		{
			return (CodeTypeDeclaration)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public CodeTypeDeclarationCollection()
	{
	}

	public CodeTypeDeclarationCollection(CodeTypeDeclarationCollection value)
	{
		AddRange(value);
	}

	public CodeTypeDeclarationCollection(CodeTypeDeclaration[] value)
	{
		AddRange(value);
	}

	public int Add(CodeTypeDeclaration value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CodeTypeDeclaration[] value)
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

	public void AddRange(CodeTypeDeclarationCollection value)
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

	public bool Contains(CodeTypeDeclaration value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CodeTypeDeclaration[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CodeTypeDeclaration value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CodeTypeDeclaration value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CodeTypeDeclaration value)
	{
		base.List.Remove(value);
	}
}
