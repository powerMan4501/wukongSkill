namespace System.Collections.Generic;

[global::__DynamicallyInvokable]
public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
	[global::__DynamicallyInvokable]
	new bool Add(T item);

	[global::__DynamicallyInvokable]
	void UnionWith(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	void IntersectWith(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	void ExceptWith(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	void SymmetricExceptWith(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	bool IsSubsetOf(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	bool IsSupersetOf(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	bool IsProperSupersetOf(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	bool IsProperSubsetOf(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	bool Overlaps(IEnumerable<T> other);

	[global::__DynamicallyInvokable]
	bool SetEquals(IEnumerable<T> other);
}
