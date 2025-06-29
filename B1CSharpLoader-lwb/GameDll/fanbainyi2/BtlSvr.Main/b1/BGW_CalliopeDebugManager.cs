using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_CalliopeDebugManager")]
public class BGW_CalliopeDebugManager : GameInstanceSystemBaseUObj
{
	private string CalliopeLogDir = FPaths.ProjectLogDir + "CalliopeLog.log";

	private Dictionary<FName, TWeakObject<UCalliopeAsset>> ActivedCalliopeInstances { get; } = new Dictionary<FName, TWeakObject<UCalliopeAsset>>();

	public override void OnInit()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_StartCalliopeInstance = (BGW_EventCollection.Del_Void_CalliopeAsset)Delegate.Combine(bGW_EventCollection.Evt_StartCalliopeInstance, new BGW_EventCollection.Del_Void_CalliopeAsset(OnStartCalliopeInstance));
			bGW_EventCollection.Evt_FinishCalliopeInstance = (BGW_EventCollection.Del_Void_CalliopeAsset)Delegate.Combine(bGW_EventCollection.Evt_FinishCalliopeInstance, new BGW_EventCollection.Del_Void_CalliopeAsset(OnFinishCalliopeInstance));
		}
	}

	public static BGW_CalliopeDebugManager Get(UObject InWorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_CalliopeDebugManager>(InWorldContext);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		ActivedCalliopeInstances.Clear();
	}

	public int GetActiveCalliopeInstances(out List<FName> OutInstanceNames)
	{
		OutInstanceNames = new List<FName>();
		foreach (FName key in ActivedCalliopeInstances.Keys)
		{
			OutInstanceNames.Add(key);
		}
		return OutInstanceNames.Count;
	}

	public UCalliopeAsset GetCalliopeInstanceByName(string InInstanceName)
	{
		if (ActivedCalliopeInstances.TryGetValue(new FName(InInstanceName), out var value) && value.IsValid())
		{
			return value.Get();
		}
		return null;
	}

	public void GetAssetCurrentNodeDebugInfo(FName InInstanceName, out StringBuilder DebugInfoStringBuilder)
	{
		DebugInfoStringBuilder = new StringBuilder();
		if (!ActivedCalliopeInstances.TryGetValue(InInstanceName, out var value) || !value.IsValid())
		{
			return;
		}
		UCalliopeAsset uCalliopeAsset = value.Get();
		DebugInfoStringBuilder.AppendLine($"Calliope Asset : {InInstanceName}");
		DebugInfoStringBuilder.AppendLine($"当前节点数:{uCalliopeAsset.ActiveNodes.Count}");
		DebugInfoStringBuilder.AppendLine();
		DebugInfoStringBuilder.Append("执行历史：");
		for (int i = 0; i < uCalliopeAsset.ExecuteHistory.Count; i++)
		{
			if (i != 0)
			{
				DebugInfoStringBuilder.Append(" -> ");
			}
			int num = uCalliopeAsset.ExecuteHistory[i];
			DebugInfoStringBuilder.Append($"{num}");
		}
		DebugInfoStringBuilder.AppendLine();
		foreach (UCalliopeNode activeNode in uCalliopeAsset.ActiveNodes)
		{
			if (!activeNode.IsCalliopeActive())
			{
				continue;
			}
			DebugInfoStringBuilder.AppendLine("---------------------------------------------");
			DebugInfoStringBuilder.AppendLine($"当前激活节点：{activeNode.GetFName()}");
			DebugInfoStringBuilder.AppendLine($"节点序号：{activeNode.NodeIndex}");
			if (activeNode is BED_CalliopeNodeBae bED_CalliopeNodeBae)
			{
				DebugInfoStringBuilder.Append("节点类：" + bED_CalliopeNodeBae.GetNodeName());
			}
			DebugInfoStringBuilder.AppendLine();
			DebugInfoStringBuilder.AppendLine("节点输入：");
			List<FCalliopePin> inputPins = activeNode.GetInputPins();
			for (int j = 0; j < inputPins.Count; j++)
			{
				FCalliopePin fCalliopePin = inputPins[j];
				if (j != 0)
				{
					DebugInfoStringBuilder.Append(", ");
				}
				DebugInfoStringBuilder.Append($"{fCalliopePin.PinName}");
			}
			DebugInfoStringBuilder.AppendLine();
			DebugInfoStringBuilder.AppendLine("节点输出：");
			List<FCalliopePin> outputPins = activeNode.GetOutputPins();
			for (int k = 0; k < outputPins.Count; k++)
			{
				FCalliopePin fCalliopePin2 = outputPins[k];
				if (k != 0)
				{
					DebugInfoStringBuilder.Append(", ");
				}
				DebugInfoStringBuilder.Append($"{fCalliopePin2.PinName}");
			}
			DebugInfoStringBuilder.AppendLine();
		}
	}

	private void OnStartCalliopeInstance(UCalliopeAsset InAsset)
	{
		FName fName = InAsset.GetFName();
		if (!(fName == FName.None) && !ActivedCalliopeInstances.ContainsKey(fName))
		{
			ActivedCalliopeInstances.Add(fName, new TWeakObject<UCalliopeAsset>(InAsset));
		}
	}

	private void OnFinishCalliopeInstance(UCalliopeAsset InAsset)
	{
		if (ActivedCalliopeInstances.Count != 0)
		{
			FName fName = InAsset.GetFName();
			if (!(fName == FName.None) && ActivedCalliopeInstances.ContainsKey(fName))
			{
				ActivedCalliopeInstances.Remove(fName);
			}
		}
	}

	public void LogCalliopeActivateNode(UCalliopeNode Node)
	{
		if (GSGameplayCVar.CVar_CalliopeNodeDebugLog.GetValueInGameThread() != 0)
		{
			string message = $"CalliopeAsset: {Node.GetCalliopeAsset().GetFName()}".PadRight(50, ' ') + $"  [{Node.NodeIndex}] {Node.GetName()}  ".PadRight(50, ' ') + "  Node Input";
			LogCalliopeDebugInfo(message);
		}
	}

	public void LogCalliopeDeactivateNode(UCalliopeNode Node)
	{
		if (GSGameplayCVar.CVar_CalliopeNodeDebugLog.GetValueInGameThread() != 0)
		{
			string message = $"CalliopeAsset: {Node.GetCalliopeAsset().GetFName()}".PadRight(50, ' ') + $"  [{Node.NodeIndex}] {Node.GetName()}  ".PadRight(50, ' ') + "  Node Output";
			LogCalliopeDebugInfo(message);
		}
	}

	private void LogCalliopeDebugInfo(string message)
	{
		string directoryName = Path.GetDirectoryName(CalliopeLogDir);
		if (directoryName.Length > 0)
		{
			Directory.CreateDirectory(directoryName);
		}
		FileStream fileStream = new FileStream(CalliopeLogDir, FileMode.Append);
		StreamWriter streamWriter = new StreamWriter(fileStream);
		streamWriter.WriteLine($"[{DateTime.Now}] {message}");
		streamWriter.Close();
		fileStream.Close();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_CalliopeDebugManager");
	}

	static BGW_CalliopeDebugManager()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_CalliopeDebugManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_CalliopeDebugManager));
	}
}
