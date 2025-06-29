using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class CommUpgradeNode<TDesc>
{
	private static Func<int, TDesc> _GetDescFunc;

	private static Func<List<TDesc>> _GetDescListFunc;

	private static Func<TDesc, int> _GetDescIdFunc;

	private static Func<TDesc, int> _GetNextIdFunc;

	public bool IsRootNode;

	public int ResId;

	public int Level = 1;

	public int RootId;

	public TDesc ResDesc;

	public CommUpgradeNode<TDesc> ParentNode;

	public CommUpgradeNode<TDesc> ChildNode;

	public static Dictionary<int, CommUpgradeNode<TDesc>> NodeDict = new Dictionary<int, CommUpgradeNode<TDesc>>();

	public static List<CommUpgradeNode<TDesc>> RootNodeList = new List<CommUpgradeNode<TDesc>>();

	private static TDesc GetDesc(int ResId)
	{
		return _GetDescFunc(ResId);
	}

	private static List<TDesc> GetDescList()
	{
		return _GetDescListFunc();
	}

	private static int GetDescId(TDesc Desc)
	{
		return _GetDescIdFunc(Desc);
	}

	private static int GetNextId(TDesc Desc)
	{
		return _GetNextIdFunc(Desc);
	}

	private static CommUpgradeNode<TDesc> _BuildCommUpgradeNode(TDesc ResDesc)
	{
		int descId = GetDescId(ResDesc);
		if (NodeDict.TryGetValue(descId, out var value))
		{
			return value;
		}
		value = new CommUpgradeNode<TDesc>
		{
			ResId = descId,
			ResDesc = ResDesc,
			RootId = descId
		};
		NodeDict[descId] = value;
		int nextId = GetNextId(ResDesc);
		if (nextId > 0)
		{
			(value.ChildNode = _BuildCommUpgradeNode(GetDesc(nextId))).ParentNode = value;
		}
		return value;
	}

	public static void InitBuildCommNodeTree(Func<int, TDesc> GetDescFunc, Func<List<TDesc>> GetDescListFunc, Func<TDesc, int> GetDescIdFunc, Func<TDesc, int> GetNextIdFunc)
	{
		_GetDescFunc = GetDescFunc;
		_GetDescListFunc = GetDescListFunc;
		_GetDescIdFunc = GetDescIdFunc;
		_GetNextIdFunc = GetNextIdFunc;
		NodeDict.Clear();
		RootNodeList.Clear();
		List<TDesc> descList = GetDescList();
		for (int i = 0; i < descList.Count; i++)
		{
			_BuildCommUpgradeNode(descList[i]);
		}
		for (int j = 0; j < descList.Count; j++)
		{
			CommUpgradeNode<TDesc> nodeById = GetNodeById(GetDescId(descList[j]));
			if (nodeById.ParentNode == null)
			{
				int num = 1;
				nodeById.IsRootNode = true;
				RootNodeList.Add(nodeById);
				for (CommUpgradeNode<TDesc> childNode = nodeById.ChildNode; childNode != null; childNode = childNode.ChildNode)
				{
					num = (childNode.Level = num + 1);
					childNode.RootId = nodeById.ResId;
				}
			}
		}
	}

	public static CommUpgradeNode<TDesc> GetNodeById(int ResId)
	{
		if (NodeDict.TryGetValue(ResId, out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetNodeMaxLevel(CommUpgradeNode<TDesc> Node)
	{
		if (Node.ChildNode == null)
		{
			return Node.Level;
		}
		return GetNodeMaxLevel(Node.ChildNode);
	}

	public CommUpgradeNode<TDesc> GetNodeByLevel(int TargetLevel)
	{
		if (TargetLevel == Level)
		{
			return this;
		}
		bool flag = TargetLevel < Level;
		int num = FMath.Abs(TargetLevel - Level);
		CommUpgradeNode<TDesc> commUpgradeNode = this;
		for (int i = 0; i < num; i++)
		{
			if (flag)
			{
				if (commUpgradeNode.ParentNode == null)
				{
					return commUpgradeNode;
				}
				commUpgradeNode = commUpgradeNode.ParentNode;
			}
			else
			{
				if (commUpgradeNode.ChildNode == null)
				{
					return commUpgradeNode;
				}
				commUpgradeNode = commUpgradeNode.ChildNode;
			}
		}
		return commUpgradeNode;
	}

	public bool IsSingleNode()
	{
		if (!HasParent())
		{
			return !HasChild();
		}
		return false;
	}

	public bool HasParent()
	{
		return ParentNode != null;
	}

	public bool HasChild()
	{
		return ChildNode != null;
	}
}
