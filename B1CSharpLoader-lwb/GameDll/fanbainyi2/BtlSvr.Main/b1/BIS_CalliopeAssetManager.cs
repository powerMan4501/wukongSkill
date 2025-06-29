using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.Calliope;

namespace b1;

public class BIS_CalliopeAssetManager : GameInstanceSystemBase
{
	private const int PerFrameCreateInstanceCountLimit = 1;

	private const int PerFrameDequeueRequestCountLimit = 100;

	private b1.BIC_CalliopeAssetData CalliopeAssetData { get; set; }

	private BGW_EventCollection BGWEventCollection { get; set; }

	public override void OnAttach()
	{
		CalliopeAssetData = RequireWritableGameInstanceData<b1.BIC_CalliopeAssetData>();
		BGWEventCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection bGWEventCollection = BGWEventCollection;
		bGWEventCollection.Evt_RegisterCalliopeAsset = (BGW_EventCollection.Del_Void_CalliopeAssetInfo)Delegate.Combine(bGWEventCollection.Evt_RegisterCalliopeAsset, new BGW_EventCollection.Del_Void_CalliopeAssetInfo(OnRegisterCalliopeAsset));
		BGW_EventCollection bGWEventCollection2 = BGWEventCollection;
		bGWEventCollection2.Evt_SendCalliopeAssetRequest = (BGW_EventCollection.Del_Void_CalliopeAssetRequest)Delegate.Combine(bGWEventCollection2.Evt_SendCalliopeAssetRequest, new BGW_EventCollection.Del_Void_CalliopeAssetRequest(OnReceiveCalliopeAssetRequest));
	}

	public override void OnInit()
	{
		BGW_CalliopeDataReader.Get().FileDataCache.Clear();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		int num = 0;
		int num2 = 0;
		foreach (KeyValuePair<Guid, FCalliopeAssetInfo> item in CalliopeAssetData.CalliopeAssetDictionary)
		{
			FCalliopeAssetInfo value = item.Value;
			switch (value.Phase)
			{
			case ECalliopeAssetPhase.Unloaded:
			{
				UCalliopeAsset uCalliopeAsset = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UCalliopeAsset>(value.AssetPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low, value.AsyncLoadFinishCallback);
				if (uCalliopeAsset != null)
				{
					PrintDebugLog("获取Calliope资源缓存成功：" + value.AssetPath);
					value.TemplateAsset = uCalliopeAsset;
					value.Phase = ECalliopeAssetPhase.Loaded;
				}
				else if (value.Phase == ECalliopeAssetPhase.Loaded)
				{
					PrintDebugLog("获取Calliope资源立即完成：" + value.AssetPath);
				}
				else
				{
					PrintDebugLog("请求加载Calliope资源：" + value.AssetPath);
					value.Phase = ECalliopeAssetPhase.Loading;
				}
				break;
			}
			case ECalliopeAssetPhase.Loaded:
				if (num < 1)
				{
					value.AssetInstance = UCalliopeAsset.CreateInstance(base.Owner, value.TemplateAsset, value.InstancePrefixName);
					if (value.AssetInstance != null)
					{
						PrintDebugLog("创建Calliope资源成功：" + value.AssetInstance.GetName());
						value.Phase = ECalliopeAssetPhase.Created;
					}
					else
					{
						PrintDebugLog("创建Calliope资源失败：" + value.AssetPath);
					}
					num++;
				}
				break;
			case ECalliopeAssetPhase.Created:
				while (value.RequestQueue.Count != 0 && num2 < 100)
				{
					num2++;
					OnHandleAssetRequest(value);
				}
				break;
			case ECalliopeAssetPhase.Finished:
				CalliopeAssetData.WaitForClearAssetList.Add(value.InstanceID);
				break;
			}
		}
		foreach (Guid waitForClearAsset in CalliopeAssetData.WaitForClearAssetList)
		{
			if (CalliopeAssetData.CalliopeAssetDictionary.TryGetValue(waitForClearAsset, out var value2))
			{
				value2.AssetInstance = null;
				value2.TemplateAsset = null;
				CalliopeAssetData.CalliopeAssetDictionary.Remove(waitForClearAsset);
			}
		}
		CalliopeAssetData.WaitForClearAssetList.Clear();
	}

	public override void OnShutdown()
	{
		foreach (KeyValuePair<Guid, FCalliopeAssetInfo> item in CalliopeAssetData.CalliopeAssetDictionary)
		{
			FCalliopeAssetInfo value = item.Value;
			value.TemplateAsset = null;
			value.AssetInstance = null;
		}
		CalliopeAssetData.CalliopeAssetDictionary.Clear();
		BGW_CalliopeDataReader.Get().FileDataCache.Clear();
	}

	private void OnRegisterCalliopeAsset(ECalliopeAssetType InAssetType, Guid InInstanceID, string InAssetPath, string InstancePrefixName)
	{
	}

	private void OnReceiveCalliopeAssetRequest(FCalliopeAssetRequest InRequest)
	{
		if (CalliopeAssetData.CalliopeAssetDictionary.TryGetValue(InRequest.InstanceID, out var value))
		{
			value.RequestQueue.Enqueue(InRequest);
		}
	}

	private bool OnHandleAssetRequest(FCalliopeAssetInfo AssetInfo)
	{
		if (AssetInfo == null || AssetInfo.AssetInstance == null)
		{
			return false;
		}
		FCalliopeAssetRequest fCalliopeAssetRequest = AssetInfo.RequestQueue.Peek();
		switch (fCalliopeAssetRequest.RequestType)
		{
		case ECalliopeAssetRequestType.StartInstance:
			AssetInfo.AssetInstance.StartInstance();
			break;
		case ECalliopeAssetRequestType.StartAseSubInstance:
		{
			if (CalliopeAssetData.CalliopeAssetDictionary.TryGetValue(fCalliopeAssetRequest.ParentInstanceID, out var value) && value.Phase >= ECalliopeAssetPhase.Created)
			{
				AssetInfo.AssetInstance.StartAsSubInstance(value.AssetInstance, fCalliopeAssetRequest.NodeGuid);
				break;
			}
			return false;
		}
		case ECalliopeAssetRequestType.FinishInstance:
			AssetInfo.AssetInstance.FinishInstance();
			AssetInfo.Phase = ECalliopeAssetPhase.Finished;
			break;
		case ECalliopeAssetRequestType.RecordNodeInput:
			AssetInfo.AssetInstance.RecordInput(fCalliopeAssetRequest.NodeGuid, fCalliopeAssetRequest.PinName);
			break;
		case ECalliopeAssetRequestType.RecordNodeOutput:
			AssetInfo.AssetInstance.RecordOutput(fCalliopeAssetRequest.NodeGuid, fCalliopeAssetRequest.PinName);
			break;
		case ECalliopeAssetRequestType.RecordOnlyNode:
			AssetInfo.AssetInstance.RecordOnlyNode(fCalliopeAssetRequest.NodeGuid);
			break;
		case ECalliopeAssetRequestType.ClearRecordData:
			AssetInfo.AssetInstance.ClearRecordData();
			break;
		case ECalliopeAssetRequestType.DeactiveNode:
			AssetInfo.AssetInstance.DeactivateNode(fCalliopeAssetRequest.NodeGuid);
			break;
		}
		AssetInfo.RequestQueue.Dequeue();
		return true;
	}

	private void PrintDebugLog(string LogStr)
	{
	}
}
