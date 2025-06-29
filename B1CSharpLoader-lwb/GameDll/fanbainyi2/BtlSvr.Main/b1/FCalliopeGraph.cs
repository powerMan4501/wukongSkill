using System.Collections.Generic;

namespace b1;

public class FCalliopeGraph
{
	public string GraphClass { get; set; }

	public string GraphName { get; set; }

	public string Identifier { get; set; }

	public List<FCalliopeEdge> Edges { get; } = new List<FCalliopeEdge>();

	public List<FCalliopeNode> Nodes { get; } = new List<FCalliopeNode>();

	public Dictionary<string, FCalliopeGraph> BranchGraphs { get; } = new Dictionary<string, FCalliopeGraph>();

	public object GraphCacheData { get; set; }

	public static bool IsValid(FCalliopeGraph Graph)
	{
		if (Graph != null)
		{
			return Graph.Nodes.Count > 0;
		}
		return false;
	}

	public FCalliopeNode GetStartNode()
	{
		if (Nodes.Count > 0)
		{
			return Nodes[0];
		}
		return null;
	}
}
