using System.Collections;
using System.Collections.Generic;
using System.Dynamic.Utils;

namespace System.Linq.Expressions;

internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable
{
	private readonly BlockExpression _block;

	private readonly Expression _arg0;

	public Expression this[int index]
	{
		get
		{
			if (index == 0)
			{
				return _arg0;
			}
			return _block.GetExpression(index);
		}
		set
		{
			throw ContractUtils.Unreachable;
		}
	}

	public int Count => _block.ExpressionCount;

	public bool IsReadOnly => true;

	internal BlockExpressionList(BlockExpression provider, Expression arg0)
	{
		_block = provider;
		_arg0 = arg0;
	}

	public int IndexOf(Expression item)
	{
		if (_arg0 == item)
		{
			return 0;
		}
		for (int i = 1; i < _block.ExpressionCount; i++)
		{
			if (_block.GetExpression(i) == item)
			{
				return i;
			}
		}
		return -1;
	}

	public void Insert(int index, Expression item)
	{
		throw ContractUtils.Unreachable;
	}

	public void RemoveAt(int index)
	{
		throw ContractUtils.Unreachable;
	}

	public void Add(Expression item)
	{
		throw ContractUtils.Unreachable;
	}

	public void Clear()
	{
		throw ContractUtils.Unreachable;
	}

	public bool Contains(Expression item)
	{
		return IndexOf(item) != -1;
	}

	public void CopyTo(Expression[] array, int arrayIndex)
	{
		array[arrayIndex++] = _arg0;
		for (int i = 1; i < _block.ExpressionCount; i++)
		{
			array[arrayIndex++] = _block.GetExpression(i);
		}
	}

	public bool Remove(Expression item)
	{
		throw ContractUtils.Unreachable;
	}

	public IEnumerator<Expression> GetEnumerator()
	{
		yield return _arg0;
		for (int i = 1; i < _block.ExpressionCount; i++)
		{
			yield return _block.GetExpression(i);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		yield return _arg0;
		for (int i = 1; i < _block.ExpressionCount; i++)
		{
			yield return _block.GetExpression(i);
		}
	}
}
