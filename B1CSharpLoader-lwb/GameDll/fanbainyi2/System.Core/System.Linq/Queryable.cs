using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Linq;

[global::__DynamicallyInvokable]
public static class Queryable
{
	private static MethodInfo GetMethodInfo<T1, T2>(Func<T1, T2> f, T1 unused1)
	{
		return f.Method;
	}

	private static MethodInfo GetMethodInfo<T1, T2, T3>(Func<T1, T2, T3> f, T1 unused1, T2 unused2)
	{
		return f.Method;
	}

	private static MethodInfo GetMethodInfo<T1, T2, T3, T4>(Func<T1, T2, T3, T4> f, T1 unused1, T2 unused2, T3 unused3)
	{
		return f.Method;
	}

	private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5> f, T1 unused1, T2 unused2, T3 unused3, T4 unused4)
	{
		return f.Method;
	}

	private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6> f, T1 unused1, T2 unused2, T3 unused3, T4 unused4, T5 unused5)
	{
		return f.Method;
	}

	private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7> f, T1 unused1, T2 unused2, T3 unused3, T4 unused4, T5 unused5, T6 unused6)
	{
		return f.Method;
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TElement> AsQueryable<TElement>(this IEnumerable<TElement> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IQueryable<TElement>)
		{
			return (IQueryable<TElement>)source;
		}
		return new EnumerableQuery<TElement>(source);
	}

	[global::__DynamicallyInvokable]
	public static IQueryable AsQueryable(this IEnumerable source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IQueryable)
		{
			return (IQueryable)source;
		}
		Type type = TypeHelper.FindGenericType(typeof(IEnumerable<>), source.GetType());
		if (type == null)
		{
			throw Error.ArgumentNotIEnumerableGeneric("source");
		}
		return EnumerableQuery.Create(type.GetGenericArguments()[0], source);
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Where, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Where, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> OfType<TResult>(this IQueryable source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(OfType<TResult>, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> Cast<TResult>(this IQueryable source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(Cast<TResult>, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(Select, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> Select<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(Select, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TResult>>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(SelectMany, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> SelectMany<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TResult>>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(SelectMany, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, int, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (collectionSelector == null)
		{
			throw Error.ArgumentNull("collectionSelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(SelectMany, source, collectionSelector, resultSelector), new Expression[3]
		{
			source.Expression,
			Expression.Quote(collectionSelector),
			Expression.Quote(resultSelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> SelectMany<TSource, TCollection, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, IEnumerable<TCollection>>> collectionSelector, Expression<Func<TSource, TCollection, TResult>> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (collectionSelector == null)
		{
			throw Error.ArgumentNull("collectionSelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(SelectMany, source, collectionSelector, resultSelector), new Expression[3]
		{
			source.Expression,
			Expression.Quote(collectionSelector),
			Expression.Quote(resultSelector)
		}));
	}

	private static Expression GetSourceExpression<TSource>(IEnumerable<TSource> source)
	{
		if (source is IQueryable<TSource> queryable)
		{
			return queryable.Expression;
		}
		return Expression.Constant(source, typeof(IEnumerable<TSource>));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return outer.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(Join, outer, inner, outerKeySelector, innerKeySelector, resultSelector), outer.Expression, GetSourceExpression(inner), Expression.Quote(outerKeySelector), Expression.Quote(innerKeySelector), Expression.Quote(resultSelector)));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> Join<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return outer.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(Join, outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer), outer.Expression, GetSourceExpression(inner), Expression.Quote(outerKeySelector), Expression.Quote(innerKeySelector), Expression.Quote(resultSelector), Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return outer.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(GroupJoin, outer, inner, outerKeySelector, innerKeySelector, resultSelector), outer.Expression, GetSourceExpression(inner), Expression.Quote(outerKeySelector), Expression.Quote(innerKeySelector), Expression.Quote(resultSelector)));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IQueryable<TOuter> outer, IEnumerable<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, IEnumerable<TInner>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return outer.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(GroupJoin, outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer), outer.Expression, GetSourceExpression(inner), Expression.Quote(outerKeySelector), Expression.Quote(innerKeySelector), Expression.Quote(resultSelector), Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(OrderBy, source, keySelector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(keySelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(OrderBy, source, keySelector, comparer), new Expression[3]
		{
			source.Expression,
			Expression.Quote(keySelector),
			Expression.Constant(comparer, typeof(IComparer<TKey>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(OrderByDescending, source, keySelector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(keySelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> OrderByDescending<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(OrderByDescending, source, keySelector, comparer), new Expression[3]
		{
			source.Expression,
			Expression.Quote(keySelector),
			Expression.Constant(comparer, typeof(IComparer<TKey>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(ThenBy, source, keySelector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(keySelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> ThenBy<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(ThenBy, source, keySelector, comparer), new Expression[3]
		{
			source.Expression,
			Expression.Quote(keySelector),
			Expression.Constant(comparer, typeof(IComparer<TKey>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(ThenByDescending, source, keySelector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(keySelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IOrderedQueryable<TSource> ThenByDescending<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return (IOrderedQueryable<TSource>)source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(ThenByDescending, source, keySelector, comparer), new Expression[3]
		{
			source.Expression,
			Expression.Quote(keySelector),
			Expression.Constant(comparer, typeof(IComparer<TKey>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Take<TSource>(this IQueryable<TSource> source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Take, source, count), new Expression[2]
		{
			source.Expression,
			Expression.Constant(count)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(TakeWhile, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> TakeWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(TakeWhile, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Skip<TSource>(this IQueryable<TSource> source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Skip, source, count), new Expression[2]
		{
			source.Expression,
			Expression.Constant(count)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(SkipWhile, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> SkipWhile<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(SkipWhile, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return source.Provider.CreateQuery<IGrouping<TKey, TSource>>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(keySelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (elementSelector == null)
		{
			throw Error.ArgumentNull("elementSelector");
		}
		return source.Provider.CreateQuery<IGrouping<TKey, TElement>>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector, elementSelector), new Expression[3]
		{
			source.Expression,
			Expression.Quote(keySelector),
			Expression.Quote(elementSelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		return source.Provider.CreateQuery<IGrouping<TKey, TSource>>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector, comparer), new Expression[3]
		{
			source.Expression,
			Expression.Quote(keySelector),
			Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (elementSelector == null)
		{
			throw Error.ArgumentNull("elementSelector");
		}
		return source.Provider.CreateQuery<IGrouping<TKey, TElement>>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector, elementSelector, comparer), source.Expression, Expression.Quote(keySelector), Expression.Quote(elementSelector), Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (elementSelector == null)
		{
			throw Error.ArgumentNull("elementSelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector, elementSelector, resultSelector), source.Expression, Expression.Quote(keySelector), Expression.Quote(elementSelector), Expression.Quote(resultSelector)));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector, resultSelector), new Expression[3]
		{
			source.Expression,
			Expression.Quote(keySelector),
			Expression.Quote(resultSelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> GroupBy<TSource, TKey, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TKey, IEnumerable<TSource>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector, resultSelector, comparer), source.Expression, Expression.Quote(keySelector), Expression.Quote(resultSelector), Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> keySelector, Expression<Func<TSource, TElement>> elementSelector, Expression<Func<TKey, IEnumerable<TElement>, TResult>> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (elementSelector == null)
		{
			throw Error.ArgumentNull("elementSelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return source.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(GroupBy, source, keySelector, elementSelector, resultSelector, comparer), source.Expression, Expression.Quote(keySelector), Expression.Quote(elementSelector), Expression.Quote(resultSelector), Expression.Constant(comparer, typeof(IEqualityComparer<TKey>))));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Distinct, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Distinct<TSource>(this IQueryable<TSource> source, IEqualityComparer<TSource> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Distinct, source, comparer), new Expression[2]
		{
			source.Expression,
			Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Concat<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Concat, source1, source2), new Expression[2]
		{
			source1.Expression,
			GetSourceExpression(source2)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TResult> Zip<TFirst, TSecond, TResult>(this IQueryable<TFirst> source1, IEnumerable<TSecond> source2, Expression<Func<TFirst, TSecond, TResult>> resultSelector)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return source1.Provider.CreateQuery<TResult>(Expression.Call(null, GetMethodInfo(Zip, source1, source2, resultSelector), new Expression[3]
		{
			source1.Expression,
			GetSourceExpression(source2),
			Expression.Quote(resultSelector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Union, source1, source2), new Expression[2]
		{
			source1.Expression,
			GetSourceExpression(source2)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Union<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Union, source1, source2, comparer), new Expression[3]
		{
			source1.Expression,
			GetSourceExpression(source2),
			Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Intersect, source1, source2), new Expression[2]
		{
			source1.Expression,
			GetSourceExpression(source2)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Intersect<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Intersect, source1, source2, comparer), new Expression[3]
		{
			source1.Expression,
			GetSourceExpression(source2),
			Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Except, source1, source2), new Expression[2]
		{
			source1.Expression,
			GetSourceExpression(source2)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Except<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Except, source1, source2, comparer), new Expression[3]
		{
			source1.Expression,
			GetSourceExpression(source2),
			Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource First<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(First, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TSource First<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(First, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(FirstOrDefault, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TSource FirstOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(FirstOrDefault, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource Last<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(Last, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TSource Last<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(Last, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(LastOrDefault, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TSource LastOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(LastOrDefault, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource Single<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(Single, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TSource Single<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(Single, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(SingleOrDefault, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TSource SingleOrDefault<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(SingleOrDefault, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource ElementAt<TSource>(this IQueryable<TSource> source, int index)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (index < 0)
		{
			throw Error.ArgumentOutOfRange("index");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(ElementAt, source, index), new Expression[2]
		{
			source.Expression,
			Expression.Constant(index)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource ElementAtOrDefault<TSource>(this IQueryable<TSource> source, int index)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(ElementAtOrDefault, source, index), new Expression[2]
		{
			source.Expression,
			Expression.Constant(index)
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(DefaultIfEmpty, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> DefaultIfEmpty<TSource>(this IQueryable<TSource> source, TSource defaultValue)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(DefaultIfEmpty, source, defaultValue), new Expression[2]
		{
			source.Expression,
			Expression.Constant(defaultValue, typeof(TSource))
		}));
	}

	[global::__DynamicallyInvokable]
	public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<bool>(Expression.Call(null, GetMethodInfo(Contains, source, item), new Expression[2]
		{
			source.Expression,
			Expression.Constant(item, typeof(TSource))
		}));
	}

	[global::__DynamicallyInvokable]
	public static bool Contains<TSource>(this IQueryable<TSource> source, TSource item, IEqualityComparer<TSource> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<bool>(Expression.Call(null, GetMethodInfo(Contains, source, item, comparer), new Expression[3]
		{
			source.Expression,
			Expression.Constant(item, typeof(TSource)),
			Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static IQueryable<TSource> Reverse<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo(Reverse, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.Execute<bool>(Expression.Call(null, GetMethodInfo(SequenceEqual, source1, source2), new Expression[2]
		{
			source1.Expression,
			GetSourceExpression(source2)
		}));
	}

	[global::__DynamicallyInvokable]
	public static bool SequenceEqual<TSource>(this IQueryable<TSource> source1, IEnumerable<TSource> source2, IEqualityComparer<TSource> comparer)
	{
		if (source1 == null)
		{
			throw Error.ArgumentNull("source1");
		}
		if (source2 == null)
		{
			throw Error.ArgumentNull("source2");
		}
		return source1.Provider.Execute<bool>(Expression.Call(null, GetMethodInfo(SequenceEqual, source1, source2, comparer), new Expression[3]
		{
			source1.Expression,
			GetSourceExpression(source2),
			Expression.Constant(comparer, typeof(IEqualityComparer<TSource>))
		}));
	}

	[global::__DynamicallyInvokable]
	public static bool Any<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<bool>(Expression.Call(null, GetMethodInfo(Any, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static bool Any<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<bool>(Expression.Call(null, GetMethodInfo(Any, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static bool All<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<bool>(Expression.Call(null, GetMethodInfo(All, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static int Count<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<int>(Expression.Call(null, GetMethodInfo(Count, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static int Count<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<int>(Expression.Call(null, GetMethodInfo(Count, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static long LongCount<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<long>(Expression.Call(null, GetMethodInfo(LongCount, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static long LongCount<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return source.Provider.Execute<long>(Expression.Call(null, GetMethodInfo(LongCount, source, predicate), new Expression[2]
		{
			source.Expression,
			Expression.Quote(predicate)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource Min<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(Min, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TResult Min<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<TResult>(Expression.Call(null, GetMethodInfo(Min, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource Max<TSource>(this IQueryable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(Max, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static TResult Max<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<TResult>(Expression.Call(null, GetMethodInfo(Max, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static int Sum(this IQueryable<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<int>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static int? Sum(this IQueryable<int?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<int?>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static long Sum(this IQueryable<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<long>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static long? Sum(this IQueryable<long?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<long?>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static float Sum(this IQueryable<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<float>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static float? Sum(this IQueryable<float?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<float?>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double Sum(this IQueryable<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double? Sum(this IQueryable<double?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static decimal Sum(this IQueryable<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<decimal>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static decimal? Sum(this IQueryable<decimal?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<decimal?>(Expression.Call(null, GetMethodInfo(Sum, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static int Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<int>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static int? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<int?>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static long Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<long>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static long? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<long?>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static float Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<float>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static float? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<float?>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static decimal Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<decimal>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static decimal? Sum<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<decimal?>(Expression.Call(null, GetMethodInfo(Sum, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double Average(this IQueryable<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double? Average(this IQueryable<int?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double Average(this IQueryable<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double? Average(this IQueryable<long?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static float Average(this IQueryable<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<float>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static float? Average(this IQueryable<float?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<float?>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double Average(this IQueryable<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double? Average(this IQueryable<double?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static decimal Average(this IQueryable<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<decimal>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static decimal? Average(this IQueryable<decimal?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.Provider.Execute<decimal?>(Expression.Call(null, GetMethodInfo(Average, source), source.Expression));
	}

	[global::__DynamicallyInvokable]
	public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static float Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<float>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static float? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<float?>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static double? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<double?>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static decimal Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<decimal>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static decimal? Average<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<decimal?>(Expression.Call(null, GetMethodInfo(Average, source, selector), new Expression[2]
		{
			source.Expression,
			Expression.Quote(selector)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TSource Aggregate<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, TSource, TSource>> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		return source.Provider.Execute<TSource>(Expression.Call(null, GetMethodInfo(Aggregate, source, func), new Expression[2]
		{
			source.Expression,
			Expression.Quote(func)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TAccumulate Aggregate<TSource, TAccumulate>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		return source.Provider.Execute<TAccumulate>(Expression.Call(null, GetMethodInfo(Aggregate, source, seed, func), new Expression[3]
		{
			source.Expression,
			Expression.Constant(seed),
			Expression.Quote(func)
		}));
	}

	[global::__DynamicallyInvokable]
	public static TResult Aggregate<TSource, TAccumulate, TResult>(this IQueryable<TSource> source, TAccumulate seed, Expression<Func<TAccumulate, TSource, TAccumulate>> func, Expression<Func<TAccumulate, TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return source.Provider.Execute<TResult>(Expression.Call(null, GetMethodInfo(Aggregate, source, seed, func, selector), source.Expression, Expression.Constant(seed), Expression.Quote(func), Expression.Quote(selector)));
	}
}
