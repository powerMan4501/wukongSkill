using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using b1.Plugins.Calliope;
using b1.Protobuf.BG_ParserManager;
using b1.Protobuf.DataAPI;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_CalliopeDataConverter
{
	private class SubGraphNode
	{
		public string Name { get; set; }

		public List<SubGraphNode> Children { get; set; }

		public SubGraphNode(string name)
		{
			Name = name;
			Children = new List<SubGraphNode>();
		}
	}

	private static readonly uint DataVersion = 1u;

	private static BGW_CalliopeDataConverter Instance { get; set; }

	public static BGW_CalliopeDataConverter Get()
	{
		return Instance ?? (Instance = new BGW_CalliopeDataConverter());
	}

	public int ExportData(BED_CalliopeAssetBase CalliopeAsset, out string FinalErrorMsg, bool bLocalMode = false)
	{
		FinalErrorMsg = "";
		bool flag = CalliopeAsset as BED_FSMAsset != null;
		bool flag2 = CalliopeAsset.HasDeleteNodeLimit();
		string TargetFile = GetDataFilePathByAssetPath(CalliopeAsset.GetPathName(), CalliopeAsset.GetName(), ".Data");
		if (File.Exists(TargetFile))
		{
			if (!bLocalMode)
			{
				if (flag2 && !ProcessFileRevertIfCheckOut(in TargetFile, out var ErrorMsg))
				{
					FinalErrorMsg = "Calliope Data 导出失败！！！！！，详细错误信息：" + ErrorMsg;
					return -1;
				}
				if (!ProcessFileCheckout(in TargetFile, out var ErrorMsg2))
				{
					FinalErrorMsg = "Calliope Data 导出失败！！！！！，P4 Checkout 失败,详细错误信息：" + ErrorMsg2;
					return -1;
				}
			}
		}
		else
		{
			flag2 = false;
		}
		string TargetFile2 = GetDataFilePathByAssetPath(CalliopeAsset.GetPathName(), CalliopeAsset.GetName(), ".Mermaid.txt");
		if (flag && File.Exists(TargetFile2) && !bLocalMode && !ProcessFileCheckout(in TargetFile2, out var ErrorMsg3))
		{
			FinalErrorMsg = "Calliope Mermaid 导出失败！！！！！，P4 Checkout 失败,详细错误信息：" + ErrorMsg3;
			return -1;
		}
		UClass value = CalliopeAsset.GetStartNodeClass().Value;
		if (CalliopeAsset.GetStartNodeClass() == null)
		{
			FinalErrorMsg = "Calliope Data 导出失败！！！！！，Start结点类未定义";
			return -2;
		}
		Dictionary<BED_CalliopeNodeBae, CalliopeNodeData> dictionary = new Dictionary<BED_CalliopeNodeBae, CalliopeNodeData>();
		BED_CalliopeNodeBae bED_CalliopeNodeBae = null;
		Dictionary<FCalliopeGuid, UCalliopeNode> nodes = CalliopeAsset.GetNodes();
		if (flag2)
		{
			FCalliopeGraph fCalliopeGraph = GameplayTagExtension.LoadGraph(TargetFile);
			if (fCalliopeGraph != null)
			{
				foreach (FCalliopeNode node in fCalliopeGraph.Nodes)
				{
					if (!nodes.ContainsKey(GameplayTagExtension.ConvertToCalliopeGuid(node.NodeGuid)))
					{
						FinalErrorMsg = "Calliope Data 导出失败！！！！！\n当前视图不允许删除已有节点，可能引发坏档情况！！！！";
						return -3;
					}
				}
			}
		}
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> item in nodes)
		{
			BED_CalliopeNodeBae bED_CalliopeNodeBae2 = item.Value as BED_CalliopeNodeBae;
			if (!(bED_CalliopeNodeBae2 == null) && !string.IsNullOrEmpty(bED_CalliopeNodeBae2.GetNodeName()))
			{
				if (UClass.GetClass(bED_CalliopeNodeBae2.GetType()).Equals(value))
				{
					bED_CalliopeNodeBae = bED_CalliopeNodeBae2;
				}
				string graphIdentifier = "";
				if (bED_CalliopeNodeBae2.GetGraphIdentifierInCS(out var OutGraphIdentifier))
				{
					graphIdentifier = OutGraphIdentifier.PlainName;
				}
				CalliopeNodeCustomDataV1 message = new CalliopeNodeCustomDataV1
				{
					GraphIdentifier = graphIdentifier,
					CustomData = ByteString.CopyFrom(bED_CalliopeNodeBae2.GetCustomData())
				};
				byte[] bytes = GameplayTagExtension.ConvertToGuid(item.Key).ToByteArray();
				CalliopeNodeData value2 = new CalliopeNodeData
				{
					NodeClass = bED_CalliopeNodeBae2.GetNodeName(),
					NodeGuid = ByteString.CopyFrom(bytes),
					CustomData = message.ToByteString(),
					VersionId = bED_CalliopeNodeBae2.GetCustomDataVersion()
				};
				if (!bED_CalliopeNodeBae2.CheckNodeQueryable(out var ErrorMassager))
				{
					UGSFuncLibForEditor.ShowNotifyText("存在风险节点" + bED_CalliopeNodeBae2.GetName() + "\n" + ErrorMassager);
					BGW_LogUtil.LogError("存在风险节点" + bED_CalliopeNodeBae2.GetName() + "\n" + ErrorMassager);
				}
				dictionary.Add(bED_CalliopeNodeBae2, value2);
			}
		}
		CalliopeRootData calliopeRootData = new CalliopeRootData
		{
			Time = DateTime.Now.ToString("G"),
			VersionId = DataVersion
		};
		if (bED_CalliopeNodeBae == null && CalliopeAsset.IsStartNodeNecessary())
		{
			FinalErrorMsg = "Calliope Data 导出失败！！！！！，没有找到Start结点";
			return -3;
		}
		CalliopeGraphData calliopeGraphData = (calliopeRootData.Graph = new CalliopeGraphData
		{
			GraphClass = CalliopeAsset.GetType().ToString()
		});
		CalliopeNodeData calliopeNodeData = null;
		if (bED_CalliopeNodeBae != null)
		{
			calliopeNodeData = dictionary[bED_CalliopeNodeBae];
			calliopeNodeData.Index = calliopeGraphData.NodeCollection.Count;
			calliopeGraphData.NodeCollection.Add(calliopeNodeData);
		}
		foreach (KeyValuePair<BED_CalliopeNodeBae, CalliopeNodeData> item2 in dictionary)
		{
			if (!(item2.Key == bED_CalliopeNodeBae))
			{
				item2.Value.Index = calliopeGraphData.NodeCollection.Count;
				calliopeGraphData.NodeCollection.Add(item2.Value);
			}
		}
		foreach (KeyValuePair<BED_CalliopeNodeBae, CalliopeNodeData> item3 in dictionary)
		{
			foreach (FCalliopePin outputPin in item3.Key.GetOutputPins())
			{
				FCalliopeConnectedPin connection = item3.Key.GetConnection(outputPin.PinName);
				if (!nodes.ContainsKey(connection.NodeGuid))
				{
					continue;
				}
				BED_CalliopeNodeBae bED_CalliopeNodeBae3 = nodes[connection.NodeGuid] as BED_CalliopeNodeBae;
				if (!(bED_CalliopeNodeBae3 == null))
				{
					CalliopeNodeData calliopeNodeData2 = dictionary[bED_CalliopeNodeBae3];
					if (calliopeNodeData2 != null)
					{
						CalliopeEdgeData obj = new CalliopeEdgeData
						{
							FromNode = item3.Value.Index
						};
						FName pinName = outputPin.PinName;
						obj.FromPin = pinName.PlainName;
						obj.ToNode = calliopeNodeData2.Index;
						obj.ToPin = connection.PinName.PlainName;
						obj.Index = calliopeGraphData.EdgeCollection.Count;
						CalliopeEdgeData calliopeEdgeData = obj;
						calliopeGraphData.EdgeCollection.Add(calliopeEdgeData);
						item3.Value.OutputEdges.Add(calliopeEdgeData.Index);
						calliopeNodeData2.InputEdges.Add(calliopeEdgeData.Index);
					}
				}
			}
		}
		if (SaveFile(TargetFile, calliopeRootData.ToByteArray(), "Data") < 0)
		{
			FinalErrorMsg = "Calliope Data 导出失败！！！！！，文件写入失败";
			return -4;
		}
		if (flag)
		{
			CheckSubGraphLimit(CalliopeAsset);
			byte[] mermaidSB = GetMermaidSB(calliopeRootData, dictionary);
			if (SaveFile(TargetFile2, mermaidSB, "Mermaid") < 0)
			{
				FinalErrorMsg = "Calliope Mermaid 导出失败！！！！！，文件写入失败";
				return -4;
			}
		}
		return 0;
	}

	private byte[] GetMermaidSB(CalliopeRootData RootData, Dictionary<BED_CalliopeNodeBae, CalliopeNodeData> NodeRecordMap)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("graph TD");
		stringBuilder.AppendLine("classDef ClassStartEnd fill:#D14F21FF,color:#000");
		stringBuilder.AppendLine("classDef ClassAnyState fill:#D4FAD6FF,color:#000");
		stringBuilder.AppendLine("classDef ClassSubGraph fill:#FAD0A2FF,color:#000");
		stringBuilder.AppendLine("classDef ClassCondition fill:#C2C48EFF,color:#000");
		stringBuilder.AppendLine("classDef ClassState fill:#5C9CD4FF,color:#FFF");
		int num = 0;
		Dictionary<CalliopeNodeData, string> dictionary = new Dictionary<CalliopeNodeData, string>();
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		dictionary2.Add("ClassStartEnd", "");
		dictionary2.Add("ClassAnyState", "");
		dictionary2.Add("ClassSubGraph", "");
		dictionary2.Add("ClassCondition", "");
		dictionary2.Add("ClassState", "");
		foreach (CalliopeNodeData item in RootData.Graph.NodeCollection)
		{
			if (item.NodeClass.Contains("Reroute"))
			{
				continue;
			}
			if (!dictionary.TryGetValue(item, out var value))
			{
				num++;
				value = "A" + num;
				dictionary.Add(item, value);
			}
			string CodeLeft = "[";
			string CodeRight = "]";
			string nodeClass = item.NodeClass;
			if (nodeClass.Contains("BED_FSMNode_Start") || nodeClass.Contains("BED_FSMNode_End"))
			{
				Dictionary<string, string> dictionary3 = dictionary2;
				dictionary3["ClassStartEnd"] = dictionary3["ClassStartEnd"] + value + ",";
			}
			else if (nodeClass.Contains("GlobalAnyState"))
			{
				Dictionary<string, string> dictionary3 = dictionary2;
				dictionary3["ClassAnyState"] = dictionary3["ClassAnyState"] + value + ",";
			}
			else if (nodeClass.Contains("SubG_"))
			{
				Dictionary<string, string> dictionary3 = dictionary2;
				dictionary3["ClassSubGraph"] = dictionary3["ClassSubGraph"] + value + ",";
			}
			else if (nodeClass.Contains("Condition"))
			{
				Dictionary<string, string> dictionary3 = dictionary2;
				dictionary3["ClassCondition"] = dictionary3["ClassCondition"] + value + ",";
			}
			else
			{
				Dictionary<string, string> dictionary3 = dictionary2;
				dictionary3["ClassState"] = dictionary3["ClassState"] + value + ",";
			}
			Dictionary<int, string> Edges = new Dictionary<int, string>();
			GetOutputEdges(RootData.Graph, item, IsMain: true, ref Edges);
			GetCodeStr(nodeClass, Edges.Count, ref CodeLeft, ref CodeRight);
			nodeClass = nodeClass.Substring(nodeClass.LastIndexOf('_') + 1);
			string text = value + CodeLeft + nodeClass + CodeRight;
			foreach (KeyValuePair<int, string> item2 in Edges)
			{
				CalliopeEdgeData calliopeEdgeData = RootData.Graph.EdgeCollection[item2.Key];
				CalliopeNodeData calliopeNodeData = RootData.Graph.NodeCollection[calliopeEdgeData.ToNode];
				string text2 = "|" + item2.Value + "|";
				if (text2 == "|Out|" || text2 == "|Finish|")
				{
					text2 = "";
				}
				if (!dictionary.TryGetValue(calliopeNodeData, out var value2))
				{
					num++;
					value2 = "A" + num;
					dictionary.Add(calliopeNodeData, value2);
				}
				string CodeLeft2 = "[";
				string CodeRight2 = "]";
				string nodeClass2 = calliopeNodeData.NodeClass;
				GetCodeStr(nodeClass2, 0, ref CodeLeft2, ref CodeRight2);
				nodeClass2 = nodeClass2.Substring(nodeClass2.LastIndexOf('_') + 1);
				string text3 = text2 + value2 + CodeLeft2 + nodeClass2 + CodeRight2;
				stringBuilder.AppendLine(text + " --> " + text3);
			}
		}
		string[] array = stringBuilder.ToString().Replace("\r\n", "?").Split('?');
		List<string> list = new List<string>();
		string[] array2 = array;
		foreach (string text4 in array2)
		{
			if (!list.Contains(text4) || text4.Contains("End"))
			{
				list.Add(text4);
			}
		}
		stringBuilder.Clear();
		foreach (string item3 in list)
		{
			stringBuilder.AppendLine(item3);
		}
		foreach (KeyValuePair<string, string> item4 in dictionary2)
		{
			if (item4.Value.Length > 0)
			{
				string value3 = "class " + item4.Value + " " + item4.Key;
				stringBuilder.AppendLine(value3);
			}
		}
		return Encoding.UTF8.GetBytes(stringBuilder.ToString());
	}

	private void GetCodeStr(string NodeName, int EdgesNum, ref string CodeLeft, ref string CodeRight)
	{
		if (NodeName.Contains("Condition"))
		{
			CodeLeft = "{";
			CodeRight = "}";
		}
		else if (NodeName.Contains("SubG_"))
		{
			CodeLeft = "((";
			CodeRight = "))";
		}
	}

	private void GetOutputEdges(CalliopeGraphData Graph, CalliopeNodeData NodeData, bool IsMain, ref Dictionary<int, string> Edges, string PinName = "")
	{
		foreach (int outputEdge in NodeData.OutputEdges)
		{
			CalliopeEdgeData calliopeEdgeData = Graph.EdgeCollection[outputEdge];
			CalliopeNodeData calliopeNodeData = Graph.NodeCollection[calliopeEdgeData.ToNode];
			if (IsMain)
			{
				PinName = calliopeEdgeData.FromPin;
			}
			if (calliopeNodeData.NodeClass.Contains("Reroute"))
			{
				GetOutputEdges(Graph, calliopeNodeData, IsMain: false, ref Edges, PinName);
			}
			else
			{
				Edges.Add(outputEdge, PinName);
			}
		}
	}

	private void SetMermaidSB(CalliopeRootData RootData, int EndeDataIdx, ref StringBuilder MermaidSB, ref int TagIdx, ref Dictionary<CalliopeNodeData, string> TagIdxDic, ref string LastTag)
	{
		CalliopeNodeData calliopeNodeData = RootData.Graph.NodeCollection[RootData.Graph.EdgeCollection[EndeDataIdx].ToNode];
		string fromPin = RootData.Graph.EdgeCollection[EndeDataIdx].FromPin;
		List<int> list = new List<int>();
		foreach (int outputEdge in calliopeNodeData.OutputEdges)
		{
			if (outputEdge > 0)
			{
				list.Add(outputEdge);
			}
		}
		if (!TagIdxDic.TryGetValue(calliopeNodeData, out var value))
		{
			TagIdx++;
			value = "A" + TagIdx;
			TagIdxDic.Add(calliopeNodeData, value);
		}
		string text = "|" + fromPin + "|";
		if (text.Contains("Out") || text.Contains("Finish"))
		{
			text = "";
		}
		string nodeClass = calliopeNodeData.NodeClass;
		nodeClass = nodeClass.Substring(nodeClass.LastIndexOf('_') + 1);
		string text2 = LastTag + " --> " + text + value + "[" + nodeClass + "]";
		if (text2.Contains("Reroute"))
		{
			text2 = "";
		}
		else
		{
			LastTag = value;
			MermaidSB.AppendLine(text2);
		}
		if (list.Count == 0)
		{
			MermaidSB.AppendLine("--> B[End]");
			return;
		}
		if (list.Count == 1)
		{
			SetMermaidSB(RootData, list[0], ref MermaidSB, ref TagIdx, ref TagIdxDic, ref LastTag);
			return;
		}
		foreach (int item in list)
		{
			string text3 = value + "{" + nodeClass + "}";
			if (text3.Contains("Reroute"))
			{
				text3 = "";
			}
			else
			{
				LastTag = text3;
			}
			SetMermaidSB(RootData, item, ref MermaidSB, ref TagIdx, ref TagIdxDic, ref LastTag);
		}
	}

	private void CheckSubGraphLimit(BED_CalliopeAssetBase CalliopeAsset)
	{
		SubGraphNode ParentNode = new SubGraphNode(CalliopeAsset.GetName());
		GetSubGraphTree(CalliopeAsset, ref ParentNode);
		List<string> list = new List<string>();
		GetSubGraphLineList(ParentNode, "", list);
		List<int> list2 = new List<int>();
		for (int i = 0; i < list.Count; i++)
		{
			for (int j = 0; j < list.Count; j++)
			{
				if (i != j && list[j].Contains(list[i]))
				{
					list2.Add(i);
					break;
				}
			}
		}
		for (int num = list2.Count - 1; num >= 0; num--)
		{
			list.RemoveAt(list2[num]);
		}
		string text = "";
		int num2 = IConsoleManager.Get().FindConsoleVariable("editor.Calliope.SubGraphMaxNum").GetInt();
		foreach (string item in list)
		{
			string[] array = item.Split(new string[1] { "->" }, StringSplitOptions.None);
			if (array.Length > num2)
			{
				text += $"当前子图嵌套层数:{array.Length}已超过允许嵌套层数:{num2}，请控制子图嵌套层数在范围内。\r\n嵌套链为：{item}";
				break;
			}
		}
		Dictionary<FCalliopeGuid, UCalliopeNode> nodes = CalliopeAsset.GetNodes();
		int num3 = 0;
		foreach (UCalliopeNode value in nodes.Values)
		{
			if (!(value == null) && !UClass.GetClass(value.GetType()).Equals(UClass.GetClass<BED_FSMNode_Reroute>()))
			{
				num3++;
			}
		}
		int num4 = IConsoleManager.Get().FindConsoleVariable("editor.Calliope.NodeMaxNum").GetInt();
		if (num3 > num4)
		{
			text += $"\r\n当前存在节点:{num3}已超过允许存在节点:{num4}，请控制节点数量在范围内。";
		}
		if (text.Length > 0)
		{
			FMessage.OpenDialog(text, "Waring");
		}
	}

	private void GetSubGraphTree(BED_CalliopeAssetBase CalliopeAsset, ref SubGraphNode ParentNode)
	{
		if (CalliopeAsset == null)
		{
			return;
		}
		foreach (UCalliopeNode value in CalliopeAsset.GetNodes().Values)
		{
			if (value.IsNullOrDestroyed())
			{
				continue;
			}
			BED_FSMNode_SubGraph bED_FSMNode_SubGraph = value as BED_FSMNode_SubGraph;
			if (bED_FSMNode_SubGraph == null)
			{
				continue;
			}
			string nodeName = bED_FSMNode_SubGraph.GetNodeName();
			bool flag = false;
			foreach (SubGraphNode child in ParentNode.Children)
			{
				if (child.Name == nodeName)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				continue;
			}
			if (bED_FSMNode_SubGraph.SubGraphAsset.IsValid)
			{
				SubGraphNode ParentNode2 = new SubGraphNode(nodeName);
				GetSubGraphTree(bED_FSMNode_SubGraph.SubGraphAsset.Value, ref ParentNode2);
				ParentNode.Children.Add(ParentNode2);
			}
			else if (!bED_FSMNode_SubGraph.SubGraphAsset.IsNull)
			{
				BED_FSMAsset bED_FSMAsset = bED_FSMNode_SubGraph.SubGraphAsset.LoadSynchronous();
				if (bED_FSMAsset != null)
				{
					SubGraphNode ParentNode3 = new SubGraphNode(nodeName);
					GetSubGraphTree(bED_FSMAsset, ref ParentNode3);
					ParentNode.Children.Add(ParentNode3);
				}
			}
		}
	}

	private void GetSubGraphLineList(SubGraphNode ParentNode, string SubGrapgLine, List<string> SubGraphLineList)
	{
		SubGrapgLine += ParentNode.Name;
		SubGraphLineList.Add(SubGrapgLine);
		foreach (SubGraphNode child in ParentNode.Children)
		{
			GetSubGraphLineList(child, SubGrapgLine + " -> ", SubGraphLineList);
		}
	}

	private void GetSubGraphLevelNum(List<BED_CalliopeAssetBase> CalliopeAssetList, ref int LevelNum)
	{
		if (CalliopeAssetList.Count == 0)
		{
			return;
		}
		LevelNum++;
		List<BED_CalliopeAssetBase> list = new List<BED_CalliopeAssetBase>();
		foreach (BED_CalliopeAssetBase CalliopeAsset in CalliopeAssetList)
		{
			if (CalliopeAsset.IsNullOrDestroyed())
			{
				continue;
			}
			foreach (UCalliopeNode value in CalliopeAsset.GetNodes().Values)
			{
				if (!value.IsNullOrDestroyed())
				{
					BED_FSMNode_SubGraph bED_FSMNode_SubGraph = value as BED_FSMNode_SubGraph;
					if (!(bED_FSMNode_SubGraph == null) && bED_FSMNode_SubGraph.SubGraphAsset.IsValid)
					{
						list.Add(bED_FSMNode_SubGraph.SubGraphAsset.Value);
					}
				}
			}
		}
		GetSubGraphLevelNum(list, ref LevelNum);
	}

	private List<BED_CalliopeAssetBase> GetSubGraphNum(BED_CalliopeAssetBase CalliopeAsset)
	{
		List<BED_CalliopeAssetBase> list = new List<BED_CalliopeAssetBase>();
		if (CalliopeAsset == null)
		{
			return list;
		}
		foreach (UCalliopeNode value in CalliopeAsset.GetNodes().Values)
		{
			if (!value.IsNullOrDestroyed())
			{
				BED_FSMNode_SubGraph bED_FSMNode_SubGraph = value as BED_FSMNode_SubGraph;
				if (bED_FSMNode_SubGraph != null)
				{
					list.Add(bED_FSMNode_SubGraph.SubGraphAsset.Value);
				}
			}
		}
		return list;
	}

	private string GetDataFilePathByAssetPath(string AssetPathName, string AssetName, string Extension)
	{
		string projectDir = FPaths.ProjectDir;
		if (string.IsNullOrEmpty(AssetPathName) || string.IsNullOrEmpty(AssetName) || string.IsNullOrEmpty(projectDir) || !Directory.Exists(projectDir))
		{
			UGSFuncLibForEditor.ShowNotifyText("FCalliopeRecorder Error: Asset is null Or Path " + projectDir + " not exist");
			BGW_LogUtil.LogError("FCalliopeRecorder Error: Asset is null Or Path " + projectDir + " not exist");
			return null;
		}
		string path = AssetName + Extension;
		string path2 = "CalliopeData/2.0";
		string path3 = FPaths.GetPath(AssetPathName).TrimStart('/');
		return Path.GetFullPath(Path.Combine(projectDir, path2, path3, path));
	}

	private bool ProcessFileCheckout(in string TargetFile, out string ErrorMsg)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool result = false;
		IBG_TableToolP4Helper iBG_TableToolP4Helper = BG_TableToolP4HelperCreator.CreateP4HelperInstance();
		BG_ParserStatusManager bG_ParserStatusManager = BG_ParserStatusManager.Get();
		if (!(iBG_TableToolP4Helper.IsUseExternalP4Config() ? iBG_TableToolP4Helper.IsP4Connecting() : UGSFunclibPerforceSourceControlModule.IsSourceControlEnabled()))
		{
			if (iBG_TableToolP4Helper.IsUseExternalP4Config())
			{
				stringBuilder.AppendLine(iBG_TableToolP4Helper.GetLastOutput());
			}
			stringBuilder.AppendLine("=======================================");
			stringBuilder.AppendLine("**** P4未能连接！请将Unreal连接至P4！****");
			stringBuilder.AppendLine("=======================================");
		}
		else if (!(iBG_TableToolP4Helper.IsUseExternalP4Config() ? iBG_TableToolP4Helper.CheckOutFile(TargetFile) : UGSFunclibPerforceSourceControlModule.CheckOutOrAddFile(TargetFile)))
		{
			if (iBG_TableToolP4Helper.IsUseExternalP4Config())
			{
				stringBuilder.AppendLine(iBG_TableToolP4Helper.GetLastOutput());
			}
			stringBuilder.AppendLine("\n**** 错误！无法Checkout文件" + TargetFile + "! ****");
			UGSFunclibPerforceSourceControlModule.QueryFileState(out var inState, TargetFile);
			string checkedOutOther = inState.CheckedOutOther;
			if (checkedOutOther != "")
			{
				stringBuilder.AppendLine("**** 该文件已被" + checkedOutOther + "迁出-_-请直接联系该用户以解锁文件~ ****");
			}
			bG_ParserStatusManager.ProcessStatusDict[TargetFile] = FILE_PROCESS_STATUS.PROCESS_FAILED;
		}
		else
		{
			stringBuilder.AppendLine("\nCheckout成功:" + TargetFile);
			result = true;
		}
		ErrorMsg = stringBuilder.ToString();
		return result;
	}

	private bool ProcessFileMarkForAdd(in string TargetFile, out string ErrorMsg)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool result = false;
		IBG_TableToolP4Helper iBG_TableToolP4Helper = BG_TableToolP4HelperCreator.CreateP4HelperInstance();
		BG_ParserStatusManager bG_ParserStatusManager = BG_ParserStatusManager.Get();
		if (!(iBG_TableToolP4Helper.IsUseExternalP4Config() ? iBG_TableToolP4Helper.IsP4Connecting() : UGSFunclibPerforceSourceControlModule.IsSourceControlEnabled()))
		{
			if (iBG_TableToolP4Helper.IsUseExternalP4Config())
			{
				stringBuilder.AppendLine(iBG_TableToolP4Helper.GetLastOutput());
			}
			stringBuilder.AppendLine("=======================================");
			stringBuilder.AppendLine("**** P4未能连接！请将Unreal连接至P4！****");
			stringBuilder.AppendLine("=======================================");
		}
		else if (!(iBG_TableToolP4Helper.IsUseExternalP4Config() ? iBG_TableToolP4Helper.MarkForAddFile(TargetFile) : UGSFunclibPerforceSourceControlModule.MarkFileForAdd(TargetFile)))
		{
			if (iBG_TableToolP4Helper.IsUseExternalP4Config())
			{
				stringBuilder.AppendLine(iBG_TableToolP4Helper.GetLastOutput());
			}
			stringBuilder.AppendLine("\n**** 错误！无法Mark For Add文件" + TargetFile + "! ****");
			UGSFunclibPerforceSourceControlModule.QueryFileState(out var inState, TargetFile);
			string checkedOutOther = inState.CheckedOutOther;
			if (checkedOutOther != "")
			{
				stringBuilder.AppendLine("**** 该文件已被" + checkedOutOther + "迁出-_-请直接联系该用户以解锁文件~ ****");
			}
			bG_ParserStatusManager.ProcessStatusDict[TargetFile] = FILE_PROCESS_STATUS.PROCESS_FAILED;
		}
		else
		{
			stringBuilder.AppendLine("\nCheckout成功:" + TargetFile);
			result = true;
		}
		ErrorMsg = stringBuilder.ToString();
		return result;
	}

	private bool ProcessFileRevertIfCheckOut(in string TargetFile, out string ErrorMsg)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool result = false;
		IBG_TableToolP4Helper iBG_TableToolP4Helper = BG_TableToolP4HelperCreator.CreateP4HelperInstance();
		BG_ParserStatusManager bG_ParserStatusManager = BG_ParserStatusManager.Get();
		if (!iBG_TableToolP4Helper.IsUseExternalP4Config())
		{
			if (!UGSFunclibPerforceSourceControlModule.IsSourceControlEnabled())
			{
				stringBuilder.AppendLine("=======================================");
				stringBuilder.AppendLine("**** P4未能连接！请将Unreal连接至P4！****");
				stringBuilder.AppendLine("=======================================");
			}
			else
			{
				UGSFunclibPerforceSourceControlModule.QueryFileState(out var inState, TargetFile);
				if (inState.IsCheckedOut)
				{
					if (!UGSFunclibPerforceSourceControlModule.RevertFile(TargetFile))
					{
						stringBuilder.AppendLine("\n**** 错误！无法revert文件" + TargetFile + "! ****");
						bG_ParserStatusManager.ProcessStatusDict[TargetFile] = FILE_PROCESS_STATUS.PROCESS_FAILED;
					}
					else
					{
						result = true;
					}
				}
				else
				{
					result = true;
				}
			}
		}
		ErrorMsg = stringBuilder.ToString();
		return result;
	}

	private int SaveFile(string InFilePath, byte[] WriteBytes, string LogName)
	{
		string TargetFile = Path.GetFullPath(InFilePath);
		string directoryName = Path.GetDirectoryName(TargetFile);
		if (string.IsNullOrEmpty(TargetFile) || string.IsNullOrEmpty(directoryName))
		{
			return -1;
		}
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		FileStream fileStream;
		if (File.Exists(TargetFile))
		{
			fileStream = File.OpenWrite(TargetFile);
		}
		else
		{
			fileStream = File.Create(TargetFile);
			if (!ProcessFileMarkForAdd(in TargetFile, out var ErrorMsg))
			{
				UGSFuncLibForEditor.ShowNotifyText("Calliope " + LogName + " 导出失败！！！！！，P4 MarkForAdd 失败,详细错误信息：" + ErrorMsg);
				BGW_LogUtil.LogError("Calliope " + LogName + " 导出失败！！！！！，P4 MarkForAdd 失败,详细错误信息：" + ErrorMsg);
				return -1;
			}
		}
		fileStream.Seek(0L, SeekOrigin.Begin);
		fileStream.SetLength(0L);
		try
		{
			fileStream.Write(WriteBytes, 0, WriteBytes.Length);
		}
		catch (Exception ex)
		{
			UGSFuncLibForEditor.ShowNotifyText("Calliope " + LogName + "导出失败！！！，详情见OutputLog");
			BGW_LogUtil.LogError("Calliope " + LogName + " 导出失败！！！！！，错误：" + ex.Message);
			throw new Exception(ex.Message);
		}
		finally
		{
			fileStream.Close();
		}
		UGSFuncLibForEditor.ShowNotifyText("Calliope " + LogName + " 导出成功，路径：" + TargetFile);
		return 0;
	}
}
