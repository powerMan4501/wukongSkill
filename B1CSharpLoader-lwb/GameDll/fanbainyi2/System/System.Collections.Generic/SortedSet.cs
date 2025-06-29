using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Collections.Generic;

[Serializable]
[DebuggerTypeProxy(typeof(SortedSetDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[global::__DynamicallyInvokable]
public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, ISerializable, IDeserializationCallback, IReadOnlyCollection<T>
{
	[Serializable]
	internal sealed class TreeSubSet : SortedSet<T>, ISerializable, IDeserializationCallback
	{
		private SortedSet<T> underlying;

		private T min;

		private T max;

		private bool lBoundActive;

		private bool uBoundActive;

		public TreeSubSet(SortedSet<T> Underlying, T Min, T Max, bool lowerBoundActive, bool upperBoundActive)
			: base(Underlying.Comparer)
		{
			underlying = Underlying;
			min = Min;
			max = Max;
			lBoundActive = lowerBoundActive;
			uBoundActive = upperBoundActive;
			root = underlying.FindRange(min, max, lBoundActive, uBoundActive);
			count = 0;
			version = -1;
			VersionCheckImpl();
		}

		private TreeSubSet()
		{
			comparer = null;
		}

		private TreeSubSet(SerializationInfo info, StreamingContext context)
		{
			siInfo = info;
			OnDeserializationImpl(info);
		}

		internal override bool AddIfNotPresent(T item)
		{
			if (!IsWithinRange(item))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.collection);
			}
			bool result = underlying.AddIfNotPresent(item);
			VersionCheck();
			return result;
		}

		public override bool Contains(T item)
		{
			VersionCheck();
			return base.Contains(item);
		}

		internal override bool DoRemove(T item)
		{
			if (!IsWithinRange(item))
			{
				return false;
			}
			bool result = underlying.Remove(item);
			VersionCheck();
			return result;
		}

		public override void Clear()
		{
			if (count != 0)
			{
				List<T> toRemove = new List<T>();
				BreadthFirstTreeWalk(delegate(Node n)
				{
					toRemove.Add(n.Item);
					return true;
				});
				while (toRemove.Count != 0)
				{
					underlying.Remove(toRemove[toRemove.Count - 1]);
					toRemove.RemoveAt(toRemove.Count - 1);
				}
				root = null;
				count = 0;
				version = underlying.version;
			}
		}

		internal override bool IsWithinRange(T item)
		{
			int num = (lBoundActive ? base.Comparer.Compare(min, item) : (-1));
			if (num > 0)
			{
				return false;
			}
			num = ((!uBoundActive) ? 1 : base.Comparer.Compare(max, item));
			if (num < 0)
			{
				return false;
			}
			return true;
		}

		internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action, bool reverse)
		{
			VersionCheck();
			if (root == null)
			{
				return true;
			}
			Stack<Node> stack = new Stack<Node>(2 * log2(count + 1));
			Node node = root;
			while (node != null)
			{
				if (IsWithinRange(node.Item))
				{
					stack.Push(node);
					node = (reverse ? node.Right : node.Left);
				}
				else
				{
					node = ((!lBoundActive || base.Comparer.Compare(min, node.Item) <= 0) ? node.Left : node.Right);
				}
			}
			while (stack.Count != 0)
			{
				node = stack.Pop();
				if (!action(node))
				{
					return false;
				}
				Node node2 = (reverse ? node.Left : node.Right);
				while (node2 != null)
				{
					if (IsWithinRange(node2.Item))
					{
						stack.Push(node2);
						node2 = (reverse ? node2.Right : node2.Left);
					}
					else
					{
						node2 = ((!lBoundActive || base.Comparer.Compare(min, node2.Item) <= 0) ? node2.Left : node2.Right);
					}
				}
			}
			return true;
		}

		internal override bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action)
		{
			VersionCheck();
			if (root == null)
			{
				return true;
			}
			List<Node> list = new List<Node>();
			list.Add(root);
			while (list.Count != 0)
			{
				Node node = list[0];
				list.RemoveAt(0);
				if (IsWithinRange(node.Item) && !action(node))
				{
					return false;
				}
				if (node.Left != null && (!lBoundActive || base.Comparer.Compare(min, node.Item) < 0))
				{
					list.Add(node.Left);
				}
				if (node.Right != null && (!uBoundActive || base.Comparer.Compare(max, node.Item) > 0))
				{
					list.Add(node.Right);
				}
			}
			return true;
		}

		internal override Node FindNode(T item)
		{
			if (!IsWithinRange(item))
			{
				return null;
			}
			VersionCheck();
			return base.FindNode(item);
		}

		internal override int InternalIndexOf(T item)
		{
			int num = -1;
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					num++;
					if (base.Comparer.Compare(item, current) == 0)
					{
						return num;
					}
				}
			}
			return -1;
		}

		internal override void VersionCheck()
		{
			VersionCheckImpl();
		}

		private void VersionCheckImpl()
		{
			if (version != underlying.version)
			{
				root = underlying.FindRange(min, max, lBoundActive, uBoundActive);
				version = underlying.version;
				count = 0;
				InOrderTreeWalk(delegate
				{
					count++;
					return true;
				});
			}
		}

		public override SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
		{
			if (lBoundActive && base.Comparer.Compare(min, lowerValue) > 0)
			{
				throw new ArgumentOutOfRangeException("lowerValue");
			}
			if (uBoundActive && base.Comparer.Compare(max, upperValue) < 0)
			{
				throw new ArgumentOutOfRangeException("upperValue");
			}
			return (TreeSubSet)underlying.GetViewBetween(lowerValue, upperValue);
		}

		internal override void IntersectWithEnumerable(IEnumerable<T> other)
		{
			List<T> list = new List<T>(base.Count);
			foreach (T item in other)
			{
				if (Contains(item))
				{
					list.Add(item);
					Remove(item);
				}
			}
			Clear();
			AddAllElements(list);
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			GetObjectData(info, context);
		}

		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			info.AddValue("Max", max, typeof(T));
			info.AddValue("Min", min, typeof(T));
			info.AddValue("lBoundActive", lBoundActive);
			info.AddValue("uBoundActive", uBoundActive);
			base.GetObjectData(info, context);
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		protected override void OnDeserialization(object sender)
		{
			OnDeserializationImpl(sender);
		}

		private void OnDeserializationImpl(object sender)
		{
			if (siInfo == null)
			{
				ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_InvalidOnDeser);
			}
			comparer = (IComparer<T>)siInfo.GetValue("Comparer", typeof(IComparer<T>));
			int @int = siInfo.GetInt32("Count");
			max = (T)siInfo.GetValue("Max", typeof(T));
			min = (T)siInfo.GetValue("Min", typeof(T));
			lBoundActive = siInfo.GetBoolean("lBoundActive");
			uBoundActive = siInfo.GetBoolean("uBoundActive");
			underlying = new SortedSet<T>();
			if (@int != 0)
			{
				T[] array = (T[])siInfo.GetValue("Items", typeof(T[]));
				if (array == null)
				{
					ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingValues);
				}
				for (int i = 0; i < array.Length; i++)
				{
					underlying.Add(array[i]);
				}
			}
			underlying.version = siInfo.GetInt32("Version");
			count = underlying.count;
			version = underlying.version - 1;
			VersionCheck();
			if (count != @int)
			{
				ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MismatchedCount);
			}
			siInfo = null;
		}
	}

	internal class Node
	{
		public bool IsRed;

		public T Item;

		public Node Left;

		public Node Right;

		public Node(T item)
		{
			Item = item;
			IsRed = true;
		}

		public Node(T item, bool isRed)
		{
			Item = item;
			IsRed = isRed;
		}
	}

	[Serializable]
	[global::__DynamicallyInvokable]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private SortedSet<T> tree;

		private int version;

		private Stack<Node> stack;

		private Node current;

		private static Node dummyNode = new Node(default(T));

		private bool reverse;

		private SerializationInfo siInfo;

		[global::__DynamicallyInvokable]
		public T Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (current != null)
				{
					return current.Item;
				}
				return default(T);
			}
		}

		[global::__DynamicallyInvokable]
		object IEnumerator.Current
		{
			[global::__DynamicallyInvokable]
			get
			{
				if (current == null)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumOpCantHappen);
				}
				return current.Item;
			}
		}

		internal bool NotStartedOrEnded => current == null;

		internal Enumerator(SortedSet<T> set)
		{
			tree = set;
			tree.VersionCheck();
			version = tree.version;
			stack = new Stack<Node>(2 * SortedSet<T>.log2(set.Count + 1));
			current = null;
			reverse = false;
			siInfo = null;
			Intialize();
		}

		internal Enumerator(SortedSet<T> set, bool reverse)
		{
			tree = set;
			tree.VersionCheck();
			version = tree.version;
			stack = new Stack<Node>(2 * SortedSet<T>.log2(set.Count + 1));
			current = null;
			this.reverse = reverse;
			siInfo = null;
			Intialize();
		}

		private Enumerator(SerializationInfo info, StreamingContext context)
		{
			tree = null;
			version = -1;
			current = null;
			reverse = false;
			stack = null;
			siInfo = info;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			GetObjectData(info, context);
		}

		private void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			info.AddValue("Tree", tree, typeof(SortedSet<T>));
			info.AddValue("EnumVersion", version);
			info.AddValue("Reverse", reverse);
			info.AddValue("EnumStarted", !NotStartedOrEnded);
			info.AddValue("Item", (current == null) ? dummyNode.Item : current.Item, typeof(T));
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
			OnDeserialization(sender);
		}

		private void OnDeserialization(object sender)
		{
			if (siInfo == null)
			{
				ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_InvalidOnDeser);
			}
			tree = (SortedSet<T>)siInfo.GetValue("Tree", typeof(SortedSet<T>));
			version = siInfo.GetInt32("EnumVersion");
			reverse = siInfo.GetBoolean("Reverse");
			bool boolean = siInfo.GetBoolean("EnumStarted");
			stack = new Stack<Node>(2 * SortedSet<T>.log2(tree.Count + 1));
			current = null;
			if (boolean)
			{
				T y = (T)siInfo.GetValue("Item", typeof(T));
				Intialize();
				while (MoveNext() && tree.Comparer.Compare(Current, y) != 0)
				{
				}
			}
		}

		private void Intialize()
		{
			current = null;
			Node node = tree.root;
			Node node2 = null;
			Node node3 = null;
			while (node != null)
			{
				node2 = (reverse ? node.Right : node.Left);
				node3 = (reverse ? node.Left : node.Right);
				if (tree.IsWithinRange(node.Item))
				{
					stack.Push(node);
					node = node2;
				}
				else
				{
					node = ((node2 != null && tree.IsWithinRange(node2.Item)) ? node2 : node3);
				}
			}
		}

		[global::__DynamicallyInvokable]
		public bool MoveNext()
		{
			tree.VersionCheck();
			if (version != tree.version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			if (stack.Count == 0)
			{
				current = null;
				return false;
			}
			current = stack.Pop();
			Node node = (reverse ? current.Left : current.Right);
			Node node2 = null;
			Node node3 = null;
			while (node != null)
			{
				node2 = (reverse ? node.Right : node.Left);
				node3 = (reverse ? node.Left : node.Right);
				if (tree.IsWithinRange(node.Item))
				{
					stack.Push(node);
					node = node2;
				}
				else
				{
					node = ((node3 != null && tree.IsWithinRange(node3.Item)) ? node3 : node2);
				}
			}
			return true;
		}

		[global::__DynamicallyInvokable]
		public void Dispose()
		{
		}

		internal void Reset()
		{
			if (version != tree.version)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
			}
			stack.Clear();
			Intialize();
		}

		[global::__DynamicallyInvokable]
		void IEnumerator.Reset()
		{
			Reset();
		}
	}

	internal struct ElementCount
	{
		internal int uniqueCount;

		internal int unfoundCount;
	}

	private Node root;

	private IComparer<T> comparer;

	private int count;

	private int version;

	private object _syncRoot;

	private const string ComparerName = "Comparer";

	private const string CountName = "Count";

	private const string ItemsName = "Items";

	private const string VersionName = "Version";

	private const string TreeName = "Tree";

	private const string NodeValueName = "Item";

	private const string EnumStartName = "EnumStarted";

	private const string ReverseName = "Reverse";

	private const string EnumVersionName = "EnumVersion";

	private const string minName = "Min";

	private const string maxName = "Max";

	private const string lBoundActiveName = "lBoundActive";

	private const string uBoundActiveName = "uBoundActive";

	private SerializationInfo siInfo;

	internal const int StackAllocThreshold = 100;

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			VersionCheck();
			return count;
		}
	}

	[global::__DynamicallyInvokable]
	public IComparer<T> Comparer
	{
		[global::__DynamicallyInvokable]
		get
		{
			return comparer;
		}
	}

	[global::__DynamicallyInvokable]
	bool ICollection<T>.IsReadOnly
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	bool ICollection.IsSynchronized
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	object ICollection.SyncRoot
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_syncRoot == null)
			{
				Interlocked.CompareExchange(ref _syncRoot, new object(), null);
			}
			return _syncRoot;
		}
	}

	[global::__DynamicallyInvokable]
	public T Min
	{
		[global::__DynamicallyInvokable]
		get
		{
			T ret = default(T);
			InOrderTreeWalk(delegate(Node n)
			{
				ret = n.Item;
				return false;
			});
			return ret;
		}
	}

	[global::__DynamicallyInvokable]
	public T Max
	{
		[global::__DynamicallyInvokable]
		get
		{
			T ret = default(T);
			InOrderTreeWalk(delegate(Node n)
			{
				ret = n.Item;
				return false;
			}, reverse: true);
			return ret;
		}
	}

	[global::__DynamicallyInvokable]
	public SortedSet()
	{
		comparer = Comparer<T>.Default;
	}

	[global::__DynamicallyInvokable]
	public SortedSet(IComparer<T> comparer)
	{
		if (comparer == null)
		{
			this.comparer = Comparer<T>.Default;
		}
		else
		{
			this.comparer = comparer;
		}
	}

	[global::__DynamicallyInvokable]
	public SortedSet(IEnumerable<T> collection)
		: this(collection, (IComparer<T>)Comparer<T>.Default)
	{
	}

	[global::__DynamicallyInvokable]
	public SortedSet(IEnumerable<T> collection, IComparer<T> comparer)
		: this(comparer)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		SortedSet<T> sortedSet = collection as SortedSet<T>;
		SortedSet<T> sortedSet2 = collection as TreeSubSet;
		if (sortedSet != null && sortedSet2 == null && AreComparersEqual(this, sortedSet))
		{
			if (sortedSet.Count == 0)
			{
				count = 0;
				version = 0;
				root = null;
				return;
			}
			Stack<Node> stack = new Stack<Node>(2 * log2(sortedSet.Count) + 2);
			Stack<Node> stack2 = new Stack<Node>(2 * log2(sortedSet.Count) + 2);
			Node left = sortedSet.root;
			Node node = (root = ((left != null) ? new Node(left.Item, left.IsRed) : null));
			while (left != null)
			{
				stack.Push(left);
				stack2.Push(node);
				node.Left = ((left.Left != null) ? new Node(left.Left.Item, left.Left.IsRed) : null);
				left = left.Left;
				node = node.Left;
			}
			while (stack.Count != 0)
			{
				left = stack.Pop();
				node = stack2.Pop();
				Node node2 = left.Right;
				Node node3 = null;
				if (node2 != null)
				{
					node3 = new Node(node2.Item, node2.IsRed);
				}
				node.Right = node3;
				while (node2 != null)
				{
					stack.Push(node2);
					stack2.Push(node3);
					node3.Left = ((node2.Left != null) ? new Node(node2.Left.Item, node2.Left.IsRed) : null);
					node2 = node2.Left;
					node3 = node3.Left;
				}
			}
			count = sortedSet.count;
			version = 0;
			return;
		}
		List<T> list = new List<T>(collection);
		list.Sort(this.comparer);
		for (int i = 1; i < list.Count; i++)
		{
			if (comparer.Compare(list[i], list[i - 1]) == 0)
			{
				list.RemoveAt(i);
				i--;
			}
		}
		root = ConstructRootFromSortedArray(list.ToArray(), 0, list.Count - 1, null);
		count = list.Count;
		version = 0;
	}

	protected SortedSet(SerializationInfo info, StreamingContext context)
	{
		siInfo = info;
	}

	private void AddAllElements(IEnumerable<T> collection)
	{
		foreach (T item in collection)
		{
			if (!Contains(item))
			{
				Add(item);
			}
		}
	}

	private void RemoveAllElements(IEnumerable<T> collection)
	{
		T min = Min;
		T max = Max;
		foreach (T item in collection)
		{
			if (comparer.Compare(item, min) >= 0 && comparer.Compare(item, max) <= 0 && Contains(item))
			{
				Remove(item);
			}
		}
	}

	private bool ContainsAllElements(IEnumerable<T> collection)
	{
		foreach (T item in collection)
		{
			if (!Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	internal bool InOrderTreeWalk(TreeWalkPredicate<T> action)
	{
		return InOrderTreeWalk(action, reverse: false);
	}

	internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action, bool reverse)
	{
		if (root == null)
		{
			return true;
		}
		Stack<Node> stack = new Stack<Node>(2 * log2(Count + 1));
		for (Node node = root; node != null; node = (reverse ? node.Right : node.Left))
		{
			stack.Push(node);
		}
		while (stack.Count != 0)
		{
			Node node = stack.Pop();
			if (!action(node))
			{
				return false;
			}
			for (Node node2 = (reverse ? node.Left : node.Right); node2 != null; node2 = (reverse ? node2.Right : node2.Left))
			{
				stack.Push(node2);
			}
		}
		return true;
	}

	internal virtual bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action)
	{
		if (root == null)
		{
			return true;
		}
		List<Node> list = new List<Node>();
		list.Add(root);
		while (list.Count != 0)
		{
			Node node = list[0];
			list.RemoveAt(0);
			if (!action(node))
			{
				return false;
			}
			if (node.Left != null)
			{
				list.Add(node.Left);
			}
			if (node.Right != null)
			{
				list.Add(node.Right);
			}
		}
		return true;
	}

	internal virtual void VersionCheck()
	{
	}

	internal virtual bool IsWithinRange(T item)
	{
		return true;
	}

	[global::__DynamicallyInvokable]
	public bool Add(T item)
	{
		return AddIfNotPresent(item);
	}

	[global::__DynamicallyInvokable]
	void ICollection<T>.Add(T item)
	{
		AddIfNotPresent(item);
	}

	internal virtual bool AddIfNotPresent(T item)
	{
		if (root == null)
		{
			root = new Node(item, isRed: false);
			count = 1;
			version++;
			return true;
		}
		Node node = root;
		Node parent = null;
		Node node2 = null;
		Node greatGrandParent = null;
		version++;
		int num = 0;
		while (node != null)
		{
			num = comparer.Compare(item, node.Item);
			if (num == 0)
			{
				root.IsRed = false;
				return false;
			}
			if (Is4Node(node))
			{
				Split4Node(node);
				if (IsRed(parent))
				{
					InsertionBalance(node, ref parent, node2, greatGrandParent);
				}
			}
			greatGrandParent = node2;
			node2 = parent;
			parent = node;
			node = ((num < 0) ? node.Left : node.Right);
		}
		Node node3 = new Node(item);
		if (num > 0)
		{
			parent.Right = node3;
		}
		else
		{
			parent.Left = node3;
		}
		if (parent.IsRed)
		{
			InsertionBalance(node3, ref parent, node2, greatGrandParent);
		}
		root.IsRed = false;
		count++;
		return true;
	}

	[global::__DynamicallyInvokable]
	public bool Remove(T item)
	{
		return DoRemove(item);
	}

	internal virtual bool DoRemove(T item)
	{
		if (root == null)
		{
			return false;
		}
		version++;
		Node node = root;
		Node node2 = null;
		Node node3 = null;
		Node node4 = null;
		Node parentOfMatch = null;
		bool flag = false;
		while (node != null)
		{
			if (Is2Node(node))
			{
				if (node2 == null)
				{
					node.IsRed = true;
				}
				else
				{
					Node node5 = GetSibling(node, node2);
					if (node5.IsRed)
					{
						if (node2.Right == node5)
						{
							RotateLeft(node2);
						}
						else
						{
							RotateRight(node2);
						}
						node2.IsRed = true;
						node5.IsRed = false;
						ReplaceChildOfNodeOrRoot(node3, node2, node5);
						node3 = node5;
						if (node2 == node4)
						{
							parentOfMatch = node5;
						}
						node5 = ((node2.Left == node) ? node2.Right : node2.Left);
					}
					if (Is2Node(node5))
					{
						Merge2Nodes(node2, node, node5);
					}
					else
					{
						TreeRotation treeRotation = RotationNeeded(node2, node, node5);
						Node node6 = null;
						switch (treeRotation)
						{
						case TreeRotation.RightRotation:
							node5.Left.IsRed = false;
							node6 = RotateRight(node2);
							break;
						case TreeRotation.LeftRotation:
							node5.Right.IsRed = false;
							node6 = RotateLeft(node2);
							break;
						case TreeRotation.RightLeftRotation:
							node6 = RotateRightLeft(node2);
							break;
						case TreeRotation.LeftRightRotation:
							node6 = RotateLeftRight(node2);
							break;
						}
						node6.IsRed = node2.IsRed;
						node2.IsRed = false;
						node.IsRed = true;
						ReplaceChildOfNodeOrRoot(node3, node2, node6);
						if (node2 == node4)
						{
							parentOfMatch = node6;
						}
						node3 = node6;
					}
				}
			}
			int num = (flag ? (-1) : comparer.Compare(item, node.Item));
			if (num == 0)
			{
				flag = true;
				node4 = node;
				parentOfMatch = node2;
			}
			node3 = node2;
			node2 = node;
			node = ((num >= 0) ? node.Right : node.Left);
		}
		if (node4 != null)
		{
			ReplaceNode(node4, parentOfMatch, node2, node3);
			count--;
		}
		if (root != null)
		{
			root.IsRed = false;
		}
		return flag;
	}

	[global::__DynamicallyInvokable]
	public virtual void Clear()
	{
		root = null;
		count = 0;
		version++;
	}

	[global::__DynamicallyInvokable]
	public virtual bool Contains(T item)
	{
		return FindNode(item) != null;
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array)
	{
		CopyTo(array, 0, Count);
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int index)
	{
		CopyTo(array, index, Count);
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int index, int count)
	{
		if (array == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
		}
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (index > array.Length || count > array.Length - index)
		{
			throw new ArgumentException(SR.GetString("Arg_ArrayPlusOffTooSmall"));
		}
		count += index;
		InOrderTreeWalk(delegate(Node node)
		{
			if (index >= count)
			{
				return false;
			}
			array[index++] = node.Item;
			return true;
		});
	}

	[global::__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
		}
		if (array.Rank != 1)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
		}
		if (array.GetLowerBound(0) != 0)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
		}
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - index < Count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		if (array is T[] array2)
		{
			CopyTo(array2, index);
			return;
		}
		object[] objects = array as object[];
		if (objects == null)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
		try
		{
			InOrderTreeWalk(delegate(Node node)
			{
				objects[index++] = node.Item;
				return true;
			});
		}
		catch (ArrayTypeMismatchException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
	}

	[global::__DynamicallyInvokable]
	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	[global::__DynamicallyInvokable]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}

	private static Node GetSibling(Node node, Node parent)
	{
		if (parent.Left == node)
		{
			return parent.Right;
		}
		return parent.Left;
	}

	private void InsertionBalance(Node current, ref Node parent, Node grandParent, Node greatGrandParent)
	{
		bool flag = grandParent.Right == parent;
		bool flag2 = parent.Right == current;
		Node node;
		if (flag == flag2)
		{
			node = (flag2 ? RotateLeft(grandParent) : RotateRight(grandParent));
		}
		else
		{
			node = (flag2 ? RotateLeftRight(grandParent) : RotateRightLeft(grandParent));
			parent = greatGrandParent;
		}
		grandParent.IsRed = true;
		node.IsRed = false;
		ReplaceChildOfNodeOrRoot(greatGrandParent, grandParent, node);
	}

	private static bool Is2Node(Node node)
	{
		if (IsBlack(node) && IsNullOrBlack(node.Left))
		{
			return IsNullOrBlack(node.Right);
		}
		return false;
	}

	private static bool Is4Node(Node node)
	{
		if (IsRed(node.Left))
		{
			return IsRed(node.Right);
		}
		return false;
	}

	private static bool IsBlack(Node node)
	{
		if (node != null)
		{
			return !node.IsRed;
		}
		return false;
	}

	private static bool IsNullOrBlack(Node node)
	{
		if (node != null)
		{
			return !node.IsRed;
		}
		return true;
	}

	private static bool IsRed(Node node)
	{
		return node?.IsRed ?? false;
	}

	private static void Merge2Nodes(Node parent, Node child1, Node child2)
	{
		parent.IsRed = false;
		child1.IsRed = true;
		child2.IsRed = true;
	}

	private void ReplaceChildOfNodeOrRoot(Node parent, Node child, Node newChild)
	{
		if (parent != null)
		{
			if (parent.Left == child)
			{
				parent.Left = newChild;
			}
			else
			{
				parent.Right = newChild;
			}
		}
		else
		{
			root = newChild;
		}
	}

	private void ReplaceNode(Node match, Node parentOfMatch, Node succesor, Node parentOfSuccesor)
	{
		if (succesor == match)
		{
			succesor = match.Left;
		}
		else
		{
			if (succesor.Right != null)
			{
				succesor.Right.IsRed = false;
			}
			if (parentOfSuccesor != match)
			{
				parentOfSuccesor.Left = succesor.Right;
				succesor.Right = match.Right;
			}
			succesor.Left = match.Left;
		}
		if (succesor != null)
		{
			succesor.IsRed = match.IsRed;
		}
		ReplaceChildOfNodeOrRoot(parentOfMatch, match, succesor);
	}

	internal virtual Node FindNode(T item)
	{
		Node node = root;
		while (node != null)
		{
			int num = comparer.Compare(item, node.Item);
			if (num == 0)
			{
				return node;
			}
			node = ((num < 0) ? node.Left : node.Right);
		}
		return null;
	}

	internal virtual int InternalIndexOf(T item)
	{
		Node node = root;
		int num = 0;
		while (node != null)
		{
			int num2 = comparer.Compare(item, node.Item);
			if (num2 == 0)
			{
				return num;
			}
			node = ((num2 < 0) ? node.Left : node.Right);
			num = ((num2 < 0) ? (2 * num + 1) : (2 * num + 2));
		}
		return -1;
	}

	internal Node FindRange(T from, T to)
	{
		return FindRange(from, to, lowerBoundActive: true, upperBoundActive: true);
	}

	internal Node FindRange(T from, T to, bool lowerBoundActive, bool upperBoundActive)
	{
		Node node = root;
		while (node != null)
		{
			if (lowerBoundActive && comparer.Compare(from, node.Item) > 0)
			{
				node = node.Right;
				continue;
			}
			if (upperBoundActive && comparer.Compare(to, node.Item) < 0)
			{
				node = node.Left;
				continue;
			}
			return node;
		}
		return null;
	}

	internal void UpdateVersion()
	{
		version++;
	}

	private static Node RotateLeft(Node node)
	{
		Node right = node.Right;
		node.Right = right.Left;
		right.Left = node;
		return right;
	}

	private static Node RotateLeftRight(Node node)
	{
		Node left = node.Left;
		Node right = left.Right;
		node.Left = right.Right;
		right.Right = node;
		left.Right = right.Left;
		right.Left = left;
		return right;
	}

	private static Node RotateRight(Node node)
	{
		Node left = node.Left;
		node.Left = left.Right;
		left.Right = node;
		return left;
	}

	private static Node RotateRightLeft(Node node)
	{
		Node right = node.Right;
		Node left = right.Left;
		node.Right = left.Left;
		left.Left = node;
		right.Left = left.Right;
		left.Right = right;
		return left;
	}

	private static TreeRotation RotationNeeded(Node parent, Node current, Node sibling)
	{
		if (IsRed(sibling.Left))
		{
			if (parent.Left == current)
			{
				return TreeRotation.RightLeftRotation;
			}
			return TreeRotation.RightRotation;
		}
		if (parent.Left == current)
		{
			return TreeRotation.LeftRotation;
		}
		return TreeRotation.LeftRightRotation;
	}

	public static IEqualityComparer<SortedSet<T>> CreateSetComparer()
	{
		return new SortedSetEqualityComparer<T>();
	}

	public static IEqualityComparer<SortedSet<T>> CreateSetComparer(IEqualityComparer<T> memberEqualityComparer)
	{
		return new SortedSetEqualityComparer<T>(memberEqualityComparer);
	}

	internal static bool SortedSetEquals(SortedSet<T> set1, SortedSet<T> set2, IComparer<T> comparer)
	{
		if (set1 == null)
		{
			return set2 == null;
		}
		if (set2 == null)
		{
			return false;
		}
		if (AreComparersEqual(set1, set2))
		{
			if (set1.Count != set2.Count)
			{
				return false;
			}
			return set1.SetEquals(set2);
		}
		bool flag = false;
		foreach (T item in set1)
		{
			flag = false;
			foreach (T item2 in set2)
			{
				if (comparer.Compare(item, item2) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	private static bool AreComparersEqual(SortedSet<T> set1, SortedSet<T> set2)
	{
		return set1.Comparer.Equals(set2.Comparer);
	}

	private static void Split4Node(Node node)
	{
		node.IsRed = true;
		node.Left.IsRed = false;
		node.Right.IsRed = false;
	}

	internal T[] ToArray()
	{
		T[] array = new T[Count];
		CopyTo(array);
		return array;
	}

	[global::__DynamicallyInvokable]
	public void UnionWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		SortedSet<T> sortedSet = other as SortedSet<T>;
		TreeSubSet treeSubSet = this as TreeSubSet;
		if (treeSubSet != null)
		{
			VersionCheck();
		}
		if (sortedSet != null && treeSubSet == null && count == 0)
		{
			SortedSet<T> sortedSet2 = new SortedSet<T>(sortedSet, comparer);
			root = sortedSet2.root;
			count = sortedSet2.count;
			version++;
		}
		else if (sortedSet != null && treeSubSet == null && AreComparersEqual(this, sortedSet) && sortedSet.Count > Count / 2)
		{
			T[] array = new T[sortedSet.Count + Count];
			int num = 0;
			Enumerator enumerator = GetEnumerator();
			Enumerator enumerator2 = sortedSet.GetEnumerator();
			bool flag = !enumerator.MoveNext();
			bool flag2 = !enumerator2.MoveNext();
			while (!flag && !flag2)
			{
				int num2 = Comparer.Compare(enumerator.Current, enumerator2.Current);
				if (num2 < 0)
				{
					array[num++] = enumerator.Current;
					flag = !enumerator.MoveNext();
				}
				else if (num2 == 0)
				{
					array[num++] = enumerator2.Current;
					flag = !enumerator.MoveNext();
					flag2 = !enumerator2.MoveNext();
				}
				else
				{
					array[num++] = enumerator2.Current;
					flag2 = !enumerator2.MoveNext();
				}
			}
			if (!flag || !flag2)
			{
				Enumerator enumerator3 = (flag ? enumerator2 : enumerator);
				do
				{
					array[num++] = enumerator3.Current;
				}
				while (enumerator3.MoveNext());
			}
			root = null;
			root = ConstructRootFromSortedArray(array, 0, num - 1, null);
			count = num;
			version++;
		}
		else
		{
			AddAllElements(other);
		}
	}

	private static Node ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, Node redNode)
	{
		int num = endIndex - startIndex + 1;
		if (num == 0)
		{
			return null;
		}
		Node node = null;
		switch (num)
		{
		case 1:
			node = new Node(arr[startIndex], isRed: false);
			if (redNode != null)
			{
				node.Left = redNode;
			}
			break;
		case 2:
			node = new Node(arr[startIndex], isRed: false);
			node.Right = new Node(arr[endIndex], isRed: false);
			node.Right.IsRed = true;
			if (redNode != null)
			{
				node.Left = redNode;
			}
			break;
		case 3:
			node = new Node(arr[startIndex + 1], isRed: false);
			node.Left = new Node(arr[startIndex], isRed: false);
			node.Right = new Node(arr[endIndex], isRed: false);
			if (redNode != null)
			{
				node.Left.Left = redNode;
			}
			break;
		default:
		{
			int num2 = (startIndex + endIndex) / 2;
			node = new Node(arr[num2], isRed: false);
			node.Left = ConstructRootFromSortedArray(arr, startIndex, num2 - 1, redNode);
			if (num % 2 == 0)
			{
				node.Right = ConstructRootFromSortedArray(arr, num2 + 2, endIndex, new Node(arr[num2 + 1], isRed: true));
			}
			else
			{
				node.Right = ConstructRootFromSortedArray(arr, num2 + 1, endIndex, null);
			}
			break;
		}
		}
		return node;
	}

	[global::__DynamicallyInvokable]
	public virtual void IntersectWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (Count == 0)
		{
			return;
		}
		SortedSet<T> sortedSet = other as SortedSet<T>;
		TreeSubSet treeSubSet = this as TreeSubSet;
		if (treeSubSet != null)
		{
			VersionCheck();
		}
		if (sortedSet != null && treeSubSet == null && AreComparersEqual(this, sortedSet))
		{
			T[] array = new T[Count];
			int num = 0;
			Enumerator enumerator = GetEnumerator();
			Enumerator enumerator2 = sortedSet.GetEnumerator();
			bool flag = !enumerator.MoveNext();
			bool flag2 = !enumerator2.MoveNext();
			T max = Max;
			T min = Min;
			while (!flag && !flag2 && Comparer.Compare(enumerator2.Current, max) <= 0)
			{
				int num2 = Comparer.Compare(enumerator.Current, enumerator2.Current);
				if (num2 < 0)
				{
					flag = !enumerator.MoveNext();
				}
				else if (num2 == 0)
				{
					array[num++] = enumerator2.Current;
					flag = !enumerator.MoveNext();
					flag2 = !enumerator2.MoveNext();
				}
				else
				{
					flag2 = !enumerator2.MoveNext();
				}
			}
			root = null;
			root = ConstructRootFromSortedArray(array, 0, num - 1, null);
			count = num;
			version++;
		}
		else
		{
			IntersectWithEnumerable(other);
		}
	}

	internal virtual void IntersectWithEnumerable(IEnumerable<T> other)
	{
		List<T> list = new List<T>(Count);
		foreach (T item in other)
		{
			if (Contains(item))
			{
				list.Add(item);
				Remove(item);
			}
		}
		Clear();
		AddAllElements(list);
	}

	[global::__DynamicallyInvokable]
	public void ExceptWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (count == 0)
		{
			return;
		}
		if (other == this)
		{
			Clear();
		}
		else
		{
			if (other is SortedSet<T> sortedSet && AreComparersEqual(this, sortedSet))
			{
				if (comparer.Compare(sortedSet.Max, Min) < 0 || comparer.Compare(sortedSet.Min, Max) > 0)
				{
					return;
				}
				T min = Min;
				T max = Max;
				{
					foreach (T item in other)
					{
						if (comparer.Compare(item, min) >= 0)
						{
							if (comparer.Compare(item, max) > 0)
							{
								break;
							}
							Remove(item);
						}
					}
					return;
				}
			}
			RemoveAllElements(other);
		}
	}

	[global::__DynamicallyInvokable]
	public void SymmetricExceptWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (Count == 0)
		{
			UnionWith(other);
			return;
		}
		if (other == this)
		{
			Clear();
			return;
		}
		if (other is SortedSet<T> sortedSet && AreComparersEqual(this, sortedSet))
		{
			SymmetricExceptWithSameEC(sortedSet);
			return;
		}
		T[] array = new List<T>(other).ToArray();
		Array.Sort(array, Comparer);
		SymmetricExceptWithSameEC(array);
	}

	internal void SymmetricExceptWithSameEC(ISet<T> other)
	{
		foreach (T item in other)
		{
			if (Contains(item))
			{
				Remove(item);
			}
			else
			{
				Add(item);
			}
		}
	}

	internal void SymmetricExceptWithSameEC(T[] other)
	{
		if (other.Length == 0)
		{
			return;
		}
		T y = other[0];
		for (int i = 0; i < other.Length; i++)
		{
			for (; i < other.Length && i != 0 && comparer.Compare(other[i], y) == 0; i++)
			{
			}
			if (i < other.Length)
			{
				if (Contains(other[i]))
				{
					Remove(other[i]);
				}
				else
				{
					Add(other[i]);
				}
				y = other[i];
				continue;
			}
			break;
		}
	}

	[SecuritySafeCritical]
	[global::__DynamicallyInvokable]
	public bool IsSubsetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (Count == 0)
		{
			return true;
		}
		if (other is SortedSet<T> sortedSet && AreComparersEqual(this, sortedSet))
		{
			if (Count > sortedSet.Count)
			{
				return false;
			}
			return IsSubsetOfSortedSetWithSameEC(sortedSet);
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: false);
		if (elementCount.uniqueCount == Count)
		{
			return elementCount.unfoundCount >= 0;
		}
		return false;
	}

	private bool IsSubsetOfSortedSetWithSameEC(SortedSet<T> asSorted)
	{
		SortedSet<T> viewBetween = asSorted.GetViewBetween(Min, Max);
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				if (!viewBetween.Contains(current))
				{
					return false;
				}
			}
		}
		return true;
	}

	[SecuritySafeCritical]
	[global::__DynamicallyInvokable]
	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is ICollection && Count == 0)
		{
			return (other as ICollection).Count > 0;
		}
		if (other is SortedSet<T> sortedSet && AreComparersEqual(this, sortedSet))
		{
			if (Count >= sortedSet.Count)
			{
				return false;
			}
			return IsSubsetOfSortedSetWithSameEC(sortedSet);
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: false);
		if (elementCount.uniqueCount == Count)
		{
			return elementCount.unfoundCount > 0;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public bool IsSupersetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is ICollection && (other as ICollection).Count == 0)
		{
			return true;
		}
		if (other is SortedSet<T> sortedSet && AreComparersEqual(this, sortedSet))
		{
			if (Count < sortedSet.Count)
			{
				return false;
			}
			SortedSet<T> viewBetween = GetViewBetween(sortedSet.Min, sortedSet.Max);
			foreach (T item in sortedSet)
			{
				if (!viewBetween.Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		return ContainsAllElements(other);
	}

	[SecuritySafeCritical]
	[global::__DynamicallyInvokable]
	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (Count == 0)
		{
			return false;
		}
		if (other is ICollection && (other as ICollection).Count == 0)
		{
			return true;
		}
		if (other is SortedSet<T> sortedSet && AreComparersEqual(sortedSet, this))
		{
			if (sortedSet.Count >= Count)
			{
				return false;
			}
			SortedSet<T> viewBetween = GetViewBetween(sortedSet.Min, sortedSet.Max);
			foreach (T item in sortedSet)
			{
				if (!viewBetween.Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: true);
		if (elementCount.uniqueCount < Count)
		{
			return elementCount.unfoundCount == 0;
		}
		return false;
	}

	[SecuritySafeCritical]
	[global::__DynamicallyInvokable]
	public bool SetEquals(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is SortedSet<T> sortedSet && AreComparersEqual(this, sortedSet))
		{
			IEnumerator<T> enumerator = GetEnumerator();
			IEnumerator<T> enumerator2 = sortedSet.GetEnumerator();
			bool flag = !enumerator.MoveNext();
			bool flag2 = !enumerator2.MoveNext();
			while (!flag && !flag2)
			{
				if (Comparer.Compare(enumerator.Current, enumerator2.Current) != 0)
				{
					return false;
				}
				flag = !enumerator.MoveNext();
				flag2 = !enumerator2.MoveNext();
			}
			return flag && flag2;
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: true);
		if (elementCount.uniqueCount == Count)
		{
			return elementCount.unfoundCount == 0;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public bool Overlaps(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (Count == 0)
		{
			return false;
		}
		if (other is ICollection<T> && (other as ICollection<T>).Count == 0)
		{
			return false;
		}
		if (other is SortedSet<T> sortedSet && AreComparersEqual(this, sortedSet) && (comparer.Compare(Min, sortedSet.Max) > 0 || comparer.Compare(Max, sortedSet.Min) < 0))
		{
			return false;
		}
		foreach (T item in other)
		{
			if (Contains(item))
			{
				return true;
			}
		}
		return false;
	}

	[SecurityCritical]
	private unsafe ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
	{
		ElementCount result = default(ElementCount);
		if (Count == 0)
		{
			int num = 0;
			using (IEnumerator<T> enumerator = other.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					num++;
				}
			}
			result.uniqueCount = 0;
			result.unfoundCount = num;
			return result;
		}
		int n = Count;
		int num2 = BitHelper.ToIntArrayLength(n);
		BitHelper bitHelper;
		if (num2 <= 100)
		{
			int* bitArrayPtr = stackalloc int[num2];
			bitHelper = new BitHelper(bitArrayPtr, num2);
		}
		else
		{
			int[] bitArray = new int[num2];
			bitHelper = new BitHelper(bitArray, num2);
		}
		int num3 = 0;
		int num4 = 0;
		foreach (T item in other)
		{
			int num5 = InternalIndexOf(item);
			if (num5 >= 0)
			{
				if (!bitHelper.IsMarked(num5))
				{
					bitHelper.MarkBit(num5);
					num4++;
				}
			}
			else
			{
				num3++;
				if (returnIfUnfound)
				{
					break;
				}
			}
		}
		result.uniqueCount = num4;
		result.unfoundCount = num3;
		return result;
	}

	[global::__DynamicallyInvokable]
	public int RemoveWhere(Predicate<T> match)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		List<T> matches = new List<T>(Count);
		BreadthFirstTreeWalk(delegate(Node n)
		{
			if (match(n.Item))
			{
				matches.Add(n.Item);
			}
			return true;
		});
		int num = 0;
		for (int num2 = matches.Count - 1; num2 >= 0; num2--)
		{
			if (Remove(matches[num2]))
			{
				num++;
			}
		}
		return num;
	}

	[global::__DynamicallyInvokable]
	public IEnumerable<T> Reverse()
	{
		Enumerator e = new Enumerator(this, reverse: true);
		while (e.MoveNext())
		{
			yield return e.Current;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
	{
		if (Comparer.Compare(lowerValue, upperValue) > 0)
		{
			throw new ArgumentException("lowerBound is greater than upperBound");
		}
		return new TreeSubSet(this, lowerValue, upperValue, lowerBoundActive: true, upperBoundActive: true);
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		GetObjectData(info, context);
	}

	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
		}
		info.AddValue("Count", count);
		info.AddValue("Comparer", comparer, typeof(IComparer<T>));
		info.AddValue("Version", version);
		if (root != null)
		{
			T[] array = new T[Count];
			CopyTo(array, 0);
			info.AddValue("Items", array, typeof(T[]));
		}
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		OnDeserialization(sender);
	}

	protected virtual void OnDeserialization(object sender)
	{
		if (comparer != null)
		{
			return;
		}
		if (siInfo == null)
		{
			ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_InvalidOnDeser);
		}
		comparer = (IComparer<T>)siInfo.GetValue("Comparer", typeof(IComparer<T>));
		int @int = siInfo.GetInt32("Count");
		if (@int != 0)
		{
			T[] array = (T[])siInfo.GetValue("Items", typeof(T[]));
			if (array == null)
			{
				ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingValues);
			}
			for (int i = 0; i < array.Length; i++)
			{
				Add(array[i]);
			}
		}
		version = siInfo.GetInt32("Version");
		if (count != @int)
		{
			ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MismatchedCount);
		}
		siInfo = null;
	}

	public bool TryGetValue(T equalValue, out T actualValue)
	{
		Node node = FindNode(equalValue);
		if (node != null)
		{
			actualValue = node.Item;
			return true;
		}
		actualValue = default(T);
		return false;
	}

	private static int log2(int value)
	{
		int num = 0;
		while (value > 0)
		{
			num++;
			value >>= 1;
		}
		return num;
	}
}
