using System;
using System.Collections.Generic;

namespace b1;

public class FsmNodeInstanceFactory
{
	private static Dictionary<string, Type> NodeClassDictionary { get; }

	static FsmNodeInstanceFactory()
	{
		NodeClassDictionary = new Dictionary<string, Type>();
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Initial, typeof(FsmNodeInstance_Initial));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.CustomEnter, typeof(FsmNodeInstance_CustomEnter));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.CustomExit, typeof(FsmNodeInstance_CustomExit));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Single, typeof(FsmNodeInstance_State));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Final, typeof(FsmNodeInstance_Final));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Junction, typeof(FsmNodeInstance_Junction));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Fork, typeof(FsmNodeInstance_Fork));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Join, typeof(FsmNodeInstance_Join));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Terminate, typeof(FsmNodeInstance_Terminate));
		NodeClassDictionary.Add(B1CalliopeDef.StateNode.Reroute, typeof(FsmNodeInstance_Reroute));
	}

	public static FsmNodeInstance Create(FCalliopeNode InNode, FsmInstance InParentInstance)
	{
		if (NodeClassDictionary.TryGetValue(InNode.NodeClass, out var value))
		{
			FsmNodeInstance obj = (FsmNodeInstance)Activator.CreateInstance(value);
			obj.Node = InNode;
			obj.ParentInstance = InParentInstance;
			obj.Initialize();
			return obj;
		}
		return null;
	}
}
