using System;
using System.Collections.Generic;
using System.IO;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_CalliopeDataReader
{
	private static BGW_CalliopeDataReader Instance { get; set; }

	public Dictionary<string, FCalliopeGraph> FileDataCache { get; } = new Dictionary<string, FCalliopeGraph>();

	public static BGW_CalliopeDataReader Get()
	{
		return Instance ?? (Instance = new BGW_CalliopeDataReader());
	}

	public FCalliopeGraph LoadGraphByAssetPath(string AssetPathName, string AssetName, bool bUseCache = false)
	{
		if (bUseCache && FileDataCache.TryGetValue(AssetPathName, out var value))
		{
			return value;
		}
		CalliopeRootData calliopeRootData = new CalliopeRootData();
		if (string.IsNullOrEmpty(AssetPathName) || string.IsNullOrEmpty(AssetName))
		{
			BGW_LogUtil.LogError("BGW_CalliopeDataReader LoadData failed: " + AssetName + " is not valid path");
			return null;
		}
		string dataFilePathByAssetPath = GetDataFilePathByAssetPath(AssetPathName, AssetName);
		if (LoadFile(dataFilePathByAssetPath, out var ReadBytes) < 0)
		{
			BGW_LogUtil.LogError("BGW_CalliopeDataReader LoadData failed: " + dataFilePathByAssetPath + " load error");
			return null;
		}
		calliopeRootData.MergeFrom(ReadBytes);
		FCalliopeGraph graph = GetGraph(calliopeRootData);
		graph.GraphName = AssetName;
		if (bUseCache)
		{
			FileDataCache[AssetPathName] = graph;
		}
		return graph;
	}

	public static string GetDataFilePathByAssetPath(string AssetPathName, string AssetName)
	{
		string projectDir = FPaths.ProjectDir;
		string path = AssetName + ".Data";
		string path2 = "CalliopeData/2.0";
		string path3 = FPaths.GetPath(AssetPathName).TrimStart('/');
		return Path.Combine(projectDir, path2, path3, path);
	}

	public string GetAssetPathByDataFilePath(string DataPath)
	{
		int num = DataPath.LastIndexOf('/') + 1;
		if (num == 0 || num == DataPath.Length)
		{
			return "";
		}
		int num2 = DataPath.IndexOf('.', num);
		string text = ((num2 == -1) ? DataPath.Substring(num) : DataPath.Substring(num, num2 - num));
		string oldValue = USystemLibrary.GetProjectDirectory() + "CalliopeData/2.0";
		return "UCalliopeAsset'" + DataPath.Substring(0, num).Replace(oldValue, "") + text + "." + text + "'";
	}

	private int LoadFile(string InFilePath, out byte[] ReadBytes)
	{
		ReadBytes = null;
		if (UGSE_FileFuncLib.LoadFileToArray(InFilePath, out var FileData))
		{
			ReadBytes = FileData.ToArray();
			return 0;
		}
		return -1;
	}

	private FCalliopeGraph GetBranchGraph(FCalliopeGraph Graph, string GraphIdentifier)
	{
		if (string.IsNullOrEmpty(GraphIdentifier))
		{
			return Graph;
		}
		if (Graph.BranchGraphs.ContainsKey(GraphIdentifier))
		{
			return Graph.BranchGraphs[GraphIdentifier];
		}
		FCalliopeGraph fCalliopeGraph = new FCalliopeGraph();
		fCalliopeGraph.GraphClass = Graph.GraphClass;
		fCalliopeGraph.Identifier = GraphIdentifier;
		Graph.BranchGraphs.Add(GraphIdentifier, fCalliopeGraph);
		return fCalliopeGraph;
	}

	private FCalliopeGraph GetGraph(CalliopeRootData RootData)
	{
		if (RootData == null || RootData.Graph == null)
		{
			return null;
		}
		CalliopeGraphData graph = RootData.Graph;
		if (graph == null)
		{
			return null;
		}
		int num = graph.NodeCollection.Count + graph.EdgeCollection.Count + 1;
		FCalliopeGraph fCalliopeGraph = new FCalliopeGraph
		{
			GraphClass = graph.GraphClass
		};
		object[] ObjectCache = new object[num];
		ObjectCache[0] = fCalliopeGraph;
		foreach (CalliopeNodeData item in graph.NodeCollection)
		{
			FCalliopeNode node = GetNode(graph, RootData.VersionId, ref ObjectCache, item.Index);
			if (node != null)
			{
				if (string.IsNullOrEmpty(node.GraphIdentifier))
				{
					fCalliopeGraph.Nodes.Add(node);
				}
				else
				{
					GetBranchGraph(fCalliopeGraph, node.GraphIdentifier).Nodes.Add(node);
				}
			}
		}
		foreach (CalliopeEdgeData item2 in graph.EdgeCollection)
		{
			FCalliopeEdge edge = GetEdge(graph, RootData.VersionId, ref ObjectCache, item2.Index);
			if (edge != null)
			{
				if (string.IsNullOrEmpty(edge.GraphIdentifier))
				{
					fCalliopeGraph.Edges.Add(edge);
				}
				else
				{
					GetBranchGraph(fCalliopeGraph, edge.GraphIdentifier).Edges.Add(edge);
				}
			}
		}
		return fCalliopeGraph;
	}

	private FCalliopeEdge GetEdge(CalliopeGraphData GraphData, uint Version, ref object[] ObjectCache, int Index)
	{
		int num = Index + GraphData.NodeCollection.Count + 1;
		object obj = ObjectCache[num];
		if (obj != null)
		{
			if (obj is FCalliopeEdge result)
			{
				return result;
			}
			BGW_LogUtil.LogError($"Calliope Recorder Cache Warning: Index : {Index} is not a Edge");
		}
		if (GraphData.EdgeCollection.Count <= Index)
		{
			BGW_LogUtil.LogError($"Calliope Recorder Error: Load Edge of Index : {Index} is null");
			return null;
		}
		CalliopeEdgeData calliopeEdgeData = GraphData.EdgeCollection[Index];
		if (calliopeEdgeData == null)
		{
			BGW_LogUtil.LogError($"Calliope Recorder Error: Load Edge of Index : {Index} is not FCalliopeRecordEdge");
			return null;
		}
		FCalliopeEdge fCalliopeEdge = new FCalliopeEdge
		{
			FromPinName = calliopeEdgeData.FromPin,
			ToPinName = calliopeEdgeData.ToPin,
			From = GetNode(GraphData, Version, ref ObjectCache, calliopeEdgeData.FromNode),
			To = GetNode(GraphData, Version, ref ObjectCache, calliopeEdgeData.ToNode)
		};
		fCalliopeEdge.GraphIdentifier = fCalliopeEdge.From.GraphIdentifier;
		fCalliopeEdge.From.OutputEdges.Add(fCalliopeEdge.FromPinName, fCalliopeEdge);
		fCalliopeEdge.To.InputEdges.Add(fCalliopeEdge);
		ObjectCache[num] = fCalliopeEdge;
		return fCalliopeEdge;
	}

	private FCalliopeNode GetNode(CalliopeGraphData GraphData, uint Version, ref object[] ObjectCache, int Index)
	{
		int num = Index + 1;
		object obj = ObjectCache[num];
		if (obj != null)
		{
			if (obj is FCalliopeNode result)
			{
				return result;
			}
			BGW_LogUtil.LogError($"Calliope Recorder Cache Warning: Index : {Index} is not a Node");
		}
		if (GraphData.NodeCollection.Count <= Index)
		{
			BGW_LogUtil.LogError($"Calliope Recorder Error: Load Node of Index : {Index} is null");
			return null;
		}
		CalliopeNodeData calliopeNodeData = GraphData.NodeCollection[Index];
		if (calliopeNodeData == null)
		{
			BGW_LogUtil.LogError($"Calliope Recorder Error: Load Node of Index : {Index} is not FCalliopeRecordNode");
			return null;
		}
		FCalliopeNode fCalliopeNode = null;
		switch (Version)
		{
		case 0u:
			fCalliopeNode = new FCalliopeNode
			{
				NodeGuid = new Guid(calliopeNodeData.NodeGuid.ToByteArray()),
				NodeData = calliopeNodeData.CustomData.ToByteArray(),
				CustomDataVersion = calliopeNodeData.VersionId,
				NodeClass = calliopeNodeData.NodeClass
			};
			break;
		case 1u:
		{
			CalliopeNodeCustomDataV1 calliopeNodeCustomDataV = new CalliopeNodeCustomDataV1();
			calliopeNodeCustomDataV.MergeFrom(calliopeNodeData.CustomData);
			fCalliopeNode = new FCalliopeNode
			{
				NodeGuid = new Guid(calliopeNodeData.NodeGuid.ToByteArray()),
				NodeData = calliopeNodeCustomDataV.CustomData.ToByteArray(),
				CustomDataVersion = calliopeNodeData.VersionId,
				GraphIdentifier = calliopeNodeCustomDataV.GraphIdentifier,
				NodeClass = calliopeNodeData.NodeClass
			};
			break;
		}
		}
		ObjectCache[num] = fCalliopeNode;
		return fCalliopeNode;
	}
}
