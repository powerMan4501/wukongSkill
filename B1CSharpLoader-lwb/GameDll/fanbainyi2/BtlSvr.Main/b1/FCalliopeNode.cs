using System;
using System.Collections.Generic;

namespace b1;

public class FCalliopeNode
{
	public Guid NodeGuid { get; set; }

	public string GraphIdentifier { get; set; }

	public string NodeClass { get; set; }

	public byte[] NodeData { get; set; }

	public uint CustomDataVersion { get; set; }

	public List<FCalliopeEdge> InputEdges { get; } = new List<FCalliopeEdge>();

	public Dictionary<string, FCalliopeEdge> OutputEdges { get; } = new Dictionary<string, FCalliopeEdge>();
}
