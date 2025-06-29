using System.Collections;
using System.Security.Permissions;

namespace System.CodeDom.Compiler;

[Serializable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CompilerErrorCollection : CollectionBase
{
	public CompilerError this[int index]
	{
		get
		{
			return (CompilerError)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public bool HasErrors
	{
		get
		{
			if (base.Count > 0)
			{
				{
					IEnumerator enumerator = GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CompilerError compilerError = (CompilerError)enumerator.Current;
							if (!compilerError.IsWarning)
							{
								return true;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
			}
			return false;
		}
	}

	public bool HasWarnings
	{
		get
		{
			if (base.Count > 0)
			{
				{
					IEnumerator enumerator = GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							CompilerError compilerError = (CompilerError)enumerator.Current;
							if (compilerError.IsWarning)
							{
								return true;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
			}
			return false;
		}
	}

	public CompilerErrorCollection()
	{
	}

	public CompilerErrorCollection(CompilerErrorCollection value)
	{
		AddRange(value);
	}

	public CompilerErrorCollection(CompilerError[] value)
	{
		AddRange(value);
	}

	public int Add(CompilerError value)
	{
		return base.List.Add(value);
	}

	public void AddRange(CompilerError[] value)
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

	public void AddRange(CompilerErrorCollection value)
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

	public bool Contains(CompilerError value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(CompilerError[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(CompilerError value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, CompilerError value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(CompilerError value)
	{
		base.List.Remove(value);
	}
}
