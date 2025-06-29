using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using b1.ECS;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using b1.Plugins.AsyncLoadingScreen;
using Diana.Common;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr")]
public class BGW_PreloadAssetMgr : GameInstanceSystemBaseUObj
{
	private enum CacheState
	{
		FailLoad = -1,
		Loading,
		Cached
	}

	private class PreloadingInfo
	{
		public List<string> PathList = new List<string>();

		public void CreateNewSlowTask(string defaultMessage)
		{
		}

		public void DisposeSlowTask()
		{
		}

		public void ChangeTotalAmountOfWork(int NewTotalAmountOfWork)
		{
		}

		public void EnterProgressFrame(float expectedWorkThisFrame)
		{
		}
	}

	private class PreloadResourceCounter
	{
		public float LoadFinishCounterTimer = 1f;

		public float MaxWaitingForHideScreenAssetTimer;

		public Dictionary<EPreloadAssetSourceType, PreloadingInfo> ResourceDict = new Dictionary<EPreloadAssetSourceType, PreloadingInfo>();

		private List<string> NeedHideInLoadingScreenAssetCounter = new List<string>();

		public void AddItem(string Path, EPreloadAssetSourceType AssetType, EAssetPriority Priority)
		{
			if (ResourceDict.TryGetValue(AssetType, out var value))
			{
				if (!value.PathList.Contains(Path))
				{
					if (Priority >= EAssetPriority.High && !NeedHideInLoadingScreenAssetCounter.Contains(Path))
					{
						MaxWaitingForHideScreenAssetTimer = 10f;
						NeedHideInLoadingScreenAssetCounter.Add(Path);
					}
					value.PathList.Add(Path);
				}
			}
			else
			{
				if (Priority >= EAssetPriority.High && !NeedHideInLoadingScreenAssetCounter.Contains(Path))
				{
					MaxWaitingForHideScreenAssetTimer = 10f;
					NeedHideInLoadingScreenAssetCounter.Add(Path);
				}
				ResourceDict.Add(AssetType, new PreloadingInfo
				{
					PathList = new List<string> { Path }
				});
			}
		}

		public void RemoveItem(string Path)
		{
			foreach (KeyValuePair<EPreloadAssetSourceType, PreloadingInfo> item in ResourceDict)
			{
				if (item.Value.PathList.Contains(Path))
				{
					item.Value.PathList.Remove(Path);
				}
			}
			if (NeedHideInLoadingScreenAssetCounter.Contains(Path))
			{
				MaxWaitingForHideScreenAssetTimer = 10f;
				NeedHideInLoadingScreenAssetCounter.Remove(Path);
			}
		}

		public int GetNeedHideInLoadingScreenAssetCounter()
		{
			return NeedHideInLoadingScreenAssetCounter.Count;
		}

		public int GetCounterByType(EPreloadAssetSourceType AssetType)
		{
			if (ResourceDict.TryGetValue(AssetType, out var value))
			{
				return value.PathList.Count;
			}
			return -1;
		}

		public int GetAllResourceCounter()
		{
			int num = 0;
			foreach (KeyValuePair<EPreloadAssetSourceType, PreloadingInfo> item in ResourceDict)
			{
				num += item.Value.PathList.Count;
			}
			return num;
		}

		public bool IsPreloading()
		{
			foreach (KeyValuePair<EPreloadAssetSourceType, PreloadingInfo> item in ResourceDict)
			{
				if (item.Value.PathList.Count > 0)
				{
					return true;
				}
			}
			return false;
		}

		public bool IsAssetAllLoadFinishForLoadingScreen()
		{
			if (NeedHideInLoadingScreenAssetCounter.Count > 0)
			{
				return MaxWaitingForHideScreenAssetTimer <= 0f;
			}
			return true;
		}
	}

	private class ResourceInfo
	{
		private static string LOGGER_CATEGORY = "PreloadAsyncLoadCallback";

		private UObject Owner;

		private Dictionary<int, Action<int, UObject>> FinishCallbackActionDict = new Dictionary<int, Action<int, UObject>>();

		public CacheState State;

		public bool bIsTriggerUnLoad;

		public EAssetPriority LoadPriority;

		public EPreloadAssetSourceType SourceType;

		public List<int> RelatedResIDList = new List<int>();

		private TStrongObjectPtr<UObject> mObj = new TStrongObjectPtr<UObject>();

		public UObject Obj
		{
			get
			{
				return mObj.Get();
			}
			set
			{
				mObj.Set(value);
			}
		}

		public ResourceInfo(UObject _Owner, CacheState _State, EAssetPriority _LoadPriority, EPreloadAssetSourceType _SourceType)
		{
			State = _State;
			bIsTriggerUnLoad = false;
			LoadPriority = _LoadPriority;
			SourceType = _SourceType;
			Obj = null;
			Owner = _Owner;
		}

		public ResourceInfo(UObject _Owner, UObject _Obj, EAssetPriority _LoadPriority, EPreloadAssetSourceType _SourceType)
		{
			State = CacheState.Cached;
			bIsTriggerUnLoad = false;
			LoadPriority = _LoadPriority;
			SourceType = _SourceType;
			Obj = _Obj;
			Owner = _Owner;
		}

		public void Clear()
		{
			if (State == CacheState.Cached)
			{
				FinishCallbackActionDict.Clear();
			}
			Obj = null;
			mObj.SetNull();
			bIsTriggerUnLoad = true;
		}

		public void CallFinishCallback()
		{
			foreach (KeyValuePair<int, Action<int, UObject>> item in FinishCallbackActionDict)
			{
				int key = item.Key;
				Delegate[] invocationList = item.Value.GetInvocationList();
				foreach (Delegate obj in invocationList)
				{
					_ = obj?.Target?.GetType().FullName;
					if ((object)obj == null || obj.Target == null)
					{
						continue;
					}
					bool flag = false;
					if (obj.Target is ICallbackValidator callbackValidator)
					{
						if (callbackValidator.IsValidAcceptCallback())
						{
							flag = true;
						}
					}
					else
					{
						flag = !obj.Target.GetType().Name.Contains("DisplayClass") || true;
					}
					if (flag)
					{
						object[] parameters = new object[2] { key, Obj };
						obj.Method.Invoke(obj.Target, parameters);
					}
				}
			}
			if (!B1Global.GIsGameReleased)
			{
				BGW_AssetCollectorUtilMgr.Get(Owner)?.OnAssetLoaded(Obj, SourceType);
			}
			FinishCallbackActionDict.Clear();
		}

		public void AddFinishCallback(int CallbackReqID, Action<int, UObject> NewCallbackFunc)
		{
			if (NewCallbackFunc != null && NewCallbackFunc.Target != null)
			{
				bool flag = false;
				if (NewCallbackFunc.Target is ICallbackValidator callbackValidator)
				{
					if (callbackValidator.IsValidAcceptCallback())
					{
						flag = true;
					}
				}
				else
				{
					flag = !NewCallbackFunc.Target.GetType().Name.Contains("DisplayClass") || true;
				}
				if (flag)
				{
					if (!FinishCallbackActionDict.TryGetValue(CallbackReqID, out var _))
					{
						FinishCallbackActionDict.Add(CallbackReqID, null);
					}
					Dictionary<int, Action<int, UObject>> finishCallbackActionDict = FinishCallbackActionDict;
					finishCallbackActionDict[CallbackReqID] = (Action<int, UObject>)Delegate.Combine(finishCallbackActionDict[CallbackReqID], NewCallbackFunc);
				}
			}
			_ = NewCallbackFunc?.Target;
		}

		private void AyncLoadCallbackErrorLog(string Message)
		{
		}
	}

	private class UnitResIDAssetInfo
	{
		public bool bIsPlayer;

		public float ReleaseTimer = RELEASE_DURATION;

		public List<string> GuidList = new List<string>();

		public EUnitPreloadLevel NowUnitPreloadLevel;

		public List<string> BeAttackedConfigList = new List<string>();

		public Dictionary<string, List<TStrongObjectPtr<UAnimMontage>>> BehitNormalStiffAMDic = new Dictionary<string, List<TStrongObjectPtr<UAnimMontage>>>();

		public List<string> DeathDispConfigList = new List<string>();

		public Dictionary<string, List<TStrongObjectPtr<UAnimMontage>>> DeathDispAMDic = new Dictionary<string, List<TStrongObjectPtr<UAnimMontage>>>();

		public List<string> OtherResourcePathList = new List<string>();

		public UnitResIDAssetInfo(bool IsPlayer, EUnitPreloadLevel PreloadLevel, string GUIDStr)
		{
			bIsPlayer = IsPlayer;
			if (!GuidList.Contains(GUIDStr))
			{
				GuidList.Add(GUIDStr);
			}
		}
	}

	private class PreloadAsyncLoadUserData
	{
		public int ResID;

		public EAssetPriority Priority;

		public EPreloadAssetSourceType PreloadAssetType;

		public static readonly PreloadAsyncLoadUserData GlobalComm = new PreloadAsyncLoadUserData(EPreloadAssetSourceType.GlobalResource_Common, EAssetPriority.Top);

		public PreloadAsyncLoadUserData(EPreloadAssetSourceType _PreloadAssetType, EAssetPriority _Priority = EAssetPriority.Low, int _ResID = -1)
		{
			ResID = _ResID;
			Priority = _Priority;
			PreloadAssetType = _PreloadAssetType;
		}
	}

	private class BGWAssetManager
	{
		private class RequestInfo
		{
			public FSoftObjectPath path;

			public ObjectsLoadedCallBack callback;

			public bool needCache;

			public TWeakObject<UObject> Owner;

			public object UserData;
		}

		private class AssetLoadFinishRequest
		{
			public Action FinishCallback { get; }

			public EAssetPriority MinPriority { get; }

			public float RemainTimeOutPeriodSecond { get; set; }

			public AssetLoadFinishRequest(EAssetPriority InMinPriority, Action InFinishCallback, float InTimeOutPeriodSecond)
			{
				MinPriority = InMinPriority;
				FinishCallback = InFinishCallback;
				RemainTimeOutPeriodSecond = InTimeOutPeriodSecond;
			}
		}

		private static int GlobleRequestID = 1;

		private static BGWAssetManager msInstance = null;

		private bool ProhibitLoadObject;

		public static bool bStartRecordingPreloadAssets = false;

		public static string RecordingPreloadAssetsPath;

		private static string[] IgnoreRecordingPreloadAssetPaths = new string[5] { "/Game/00Main/UI", "/Game/00MainHZ/UIDev", "/Game/00MainHZ/Item/DanYao", "/Game/00MainHZ/Item/Hulu", "/Game/00MainHZ/Item/YaoCai" };

		private Queue<RequestInfo> TopRequests;

		private Queue<RequestInfo> HighRequests;

		private Queue<RequestInfo> MediumRequests;

		private Queue<RequestInfo> LowRequests;

		private Dictionary<int, TStrongObjectPtr<BGWAssetLoaderRequestCS>> AssetRequests = new Dictionary<int, TStrongObjectPtr<BGWAssetLoaderRequestCS>>();

		private Dictionary<FSoftObjectPath, TStrongObjectPtr<CacheAssetReference>> CachedAssets = new Dictionary<FSoftObjectPath, TStrongObjectPtr<CacheAssetReference>>();

		private List<AssetLoadFinishRequest> AssetLoadFinishRequests { get; } = new List<AssetLoadFinishRequest>();

		public static BGWAssetManager Get(UObject Context = null)
		{
			return msInstance ?? (msInstance = new BGWAssetManager());
		}

		public static void GeneratePreloadDA(string DAPath, string DAName, string TxtPath)
		{
			DAPath += DAName;
			string path = $"{DAPath}.{DAName}";
			BGWAssetManager bGWAssetManager = Get();
			UBGWPreloadDataAsset uBGWPreloadDataAsset = bGWAssetManager.RequestSyncLoadObject(path) as UBGWPreloadDataAsset;
			if (uBGWPreloadDataAsset == null && UBGWFunctionLibrary.BGWCreatePreloadDataAsset(DAPath, DAName))
			{
				uBGWPreloadDataAsset = bGWAssetManager.RequestSyncLoadObject(path) as UBGWPreloadDataAsset;
			}
			if (!(uBGWPreloadDataAsset != null))
			{
				return;
			}
			uBGWPreloadDataAsset.PreloadAssets.Clear();
			string path2 = ((TxtPath == "") ? RecordingPreloadAssetsPath : TxtPath);
			if (!File.Exists(path2))
			{
				return;
			}
			foreach (string item in File.ReadLines(path2))
			{
				FSoftObjectPath softObject = default(FSoftObjectPath);
				softObject.SetPath(item);
				uBGWPreloadDataAsset.PreloadAssets.Add(new TSoftObject<UObject>(softObject));
			}
			UGSE_FileFuncLib.PromptForCheckoutAndSave(uBGWPreloadDataAsset);
		}

		public UObject RequestSyncLoadObject(string path, bool needCache = false)
		{
			if (!PreloadAssetHelper.IsPathValid(path))
			{
				return null;
			}
			FSoftObjectPath fSoftObjectPath = default(FSoftObjectPath);
			fSoftObjectPath.SetPath(path);
			if (CachedAssets.TryGetValue(fSoftObjectPath, out var value))
			{
				CacheAssetReference cacheAssetReference = value.Get();
				if (cacheAssetReference.AssetState == CacheAssetReference.CacheAssetState.Loaded)
				{
					if (needCache)
					{
						int refCount = cacheAssetReference.refCount + 1;
						cacheAssetReference.refCount = refCount;
						CachedAssets[fSoftObjectPath] = value;
					}
					return cacheAssetReference.refObj;
				}
				if (cacheAssetReference.AssetState == CacheAssetReference.CacheAssetState.FileNotFound)
				{
					return null;
				}
			}
			if (needCache)
			{
				prepareCache(fSoftObjectPath);
			}
			UObject uObject = fSoftObjectPath.ResolveObject();
			if (uObject == null || !uObject.IsValidLowLevel())
			{
				uObject = UBGWAssetLoader.SyncLoadObject(fSoftObjectPath);
			}
			if (needCache)
			{
				if (uObject != null)
				{
					doCache(path, uObject);
				}
				else
				{
					doCacheFailed(path);
				}
			}
			if (uObject != null)
			{
				UGSE_EngineFuncLib.LogWLevel("同步加载资源:" + path, 6);
			}
			ProcessSoftRefsInLoadedAsset(uObject, EAssetPriority.Top);
			return uObject;
		}

		public int RequestAsyncLoadObject(FSoftObjectPath path, ObjectsLoadedCallBack callback, EAssetPriority priority = EAssetPriority.Default, bool needCache = false, UObject Owner = null, object UserData = null)
		{
			if (!PreloadAssetHelper.IsPathValid(path.Path))
			{
				return 0;
			}
			UObject uObject = path.ResolveObject();
			if (uObject != null && uObject.IsValidLowLevel())
			{
				List<FSoftObjectPath> list = new List<FSoftObjectPath>();
				list.Add(path);
				List<UObject> list2 = new List<UObject>();
				list2.Add(uObject);
				ProcessSoftRefsInLoadedAsset(uObject, priority);
				callback(list, list2, UserData);
				return 1;
			}
			Queue<RequestInfo> pendingRequestQueueByAssetPriority = GetPendingRequestQueueByAssetPriority(priority);
			RequestInfo requestInfo = new RequestInfo();
			requestInfo.path = path;
			requestInfo.callback = callback;
			requestInfo.needCache = needCache;
			requestInfo.Owner.Set(Owner);
			requestInfo.UserData = UserData;
			pendingRequestQueueByAssetPriority.Enqueue(requestInfo);
			return 1;
		}

		public int RequestAsyncLoadObject(string path, ObjectsLoadedCallBack callback, EAssetPriority priority = EAssetPriority.Default, bool needCache = false, UObject Owner = null, object UserData = null)
		{
			if (ProhibitLoadObject)
			{
				return 0;
			}
			if (!PreloadAssetHelper.IsPathValid(path))
			{
				return 0;
			}
			FSoftObjectPath path2 = default(FSoftObjectPath);
			path2.SetPath(path);
			if (bStartRecordingPreloadAssets)
			{
				bool flag = false;
				string[] ignoreRecordingPreloadAssetPaths = IgnoreRecordingPreloadAssetPaths;
				foreach (string value in ignoreRecordingPreloadAssetPaths)
				{
					if (path.Contains(value))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					File.AppendAllText(RecordingPreloadAssetsPath, path + "\n");
				}
			}
			return RequestAsyncLoadObject(path2, callback, priority, needCache, Owner, UserData);
		}

		public int RequestAsyncLoadObjects(List<FSoftObjectPath> path, ObjectsLoadedCallBack callback, EAssetPriority priority = EAssetPriority.Default, bool needCache = false, UObject Owner = null, object UserData = null)
		{
			int num = 0;
			for (int i = 0; i < path.Count; i++)
			{
				num += RequestAsyncLoadObject(path[i], callback, EAssetPriority.Default, needCache, Owner, UserData);
			}
			return num;
		}

		public int RequestAsyncLoadObjects(List<string> path, ObjectsLoadedCallBack callback, EAssetPriority priority = EAssetPriority.Default, bool needCache = false, UObject Owner = null, object UserData = null)
		{
			List<FSoftObjectPath> list = new List<FSoftObjectPath>();
			foreach (string item2 in path)
			{
				if (PreloadAssetHelper.IsPathValid(item2))
				{
					FSoftObjectPath item = default(FSoftObjectPath);
					item.SetPath(item2);
					list.Add(item);
				}
			}
			return RequestAsyncLoadObjects(list, callback, priority, needCache, Owner, UserData);
		}

		public UObject RequestAsyncLoadIfNotCached(string path, ObjectsLoadedCallBack AsyncCallback, EAssetPriority priority = EAssetPriority.Default, bool needCache = false, UObject Owner = null, object UserData = null)
		{
			UObject uObject = TryGetCachedObject(path);
			if (uObject != null)
			{
				if (needCache)
				{
					doCache(path, uObject);
				}
				return uObject;
			}
			RequestAsyncLoadObject(path, AsyncCallback, priority, needCache, Owner, UserData);
			return null;
		}

		public int CacheAsset(string path, bool isSync, EAssetPriority priority = EAssetPriority.Default, object UserData = null)
		{
			if (!PreloadAssetHelper.IsPathValid(path))
			{
				return 0;
			}
			FSoftObjectPath key = default(FSoftObjectPath);
			key.SetPath(path);
			if (CachedAssets.TryGetValue(key, out var value))
			{
				CacheAssetReference cacheAssetReference = value.Get();
				int refCount = cacheAssetReference.refCount + 1;
				cacheAssetReference.refCount = refCount;
				CachedAssets[key] = value;
				return cacheAssetReference.refCount;
			}
			if (isSync)
			{
				RequestSyncLoadObject(path, needCache: true);
			}
			else
			{
				RequestAsyncLoadObject(path, delegate
				{
				}, priority, needCache: true, null, UserData);
			}
			return 1;
		}

		public int UnCacheAsset(FSoftObjectPath path)
		{
			return UnCacheAsset(path.AssetPathName.ToString());
		}

		public int UnCacheAsset(string path)
		{
			FSoftObjectPath key = default(FSoftObjectPath);
			key.SetPath(path);
			if (CachedAssets.TryGetValue(key, out var value))
			{
				CacheAssetReference cacheAssetReference = value.Get();
				if (cacheAssetReference.AssetState == CacheAssetReference.CacheAssetState.FileNotFound)
				{
					return 0;
				}
				int refCount = cacheAssetReference.refCount - 1;
				cacheAssetReference.refCount = refCount;
				if (cacheAssetReference.refCount <= 0)
				{
					CachedAssets.Remove(key);
					return 0;
				}
				CachedAssets[key] = value;
				return cacheAssetReference.refCount;
			}
			return 0;
		}

		public UObject TryGetCachedObject(FSoftObjectPath path)
		{
			if (CachedAssets.TryGetValue(path, out var value))
			{
				if (value.Get().AssetState == CacheAssetReference.CacheAssetState.Loaded)
				{
					return value.Get().refObj;
				}
				return null;
			}
			return null;
		}

		public UObject TryGetCachedObject(string path)
		{
			FSoftObjectPath path2 = default(FSoftObjectPath);
			path2.SetPath(path);
			return TryGetCachedObject(path2);
		}

		public bool CancelAsyncLoadRequestByOwner(UObject owner)
		{
			if (owner == null)
			{
				return false;
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, TStrongObjectPtr<BGWAssetLoaderRequestCS>> assetRequest in AssetRequests)
			{
				BGWAssetLoaderRequestCS bGWAssetLoaderRequestCS = assetRequest.Value.Get();
				if (!(bGWAssetLoaderRequestCS == null) && !bGWAssetLoaderRequestCS.IsDestroyed && bGWAssetLoaderRequestCS.Owner.IsValid() && bGWAssetLoaderRequestCS.Owner.Get() == owner)
				{
					bGWAssetLoaderRequestCS.Cancel();
					list.Add(assetRequest.Key);
				}
			}
			foreach (int item in list)
			{
				AssetRequests[item].Set(null);
				AssetRequests.Remove(item);
			}
			CancelPendingRequestByOwner(ref TopRequests, owner);
			CancelPendingRequestByOwner(ref HighRequests, owner);
			CancelPendingRequestByOwner(ref MediumRequests, owner);
			CancelPendingRequestByOwner(ref LowRequests, owner);
			return true;
		}

		private void CancelPendingRequestByOwner(ref Queue<RequestInfo> queue, UObject Owner)
		{
			int num = 0;
			List<RequestInfo> list = new List<RequestInfo>(queue.Count);
			RequestInfo[] array = queue.ToArray();
			foreach (RequestInfo requestInfo in array)
			{
				if (requestInfo.Owner.IsValid() && requestInfo.Owner.Get() == Owner)
				{
					num++;
				}
				else
				{
					list.Add(requestInfo);
				}
			}
			if (num > 0)
			{
				queue = new Queue<RequestInfo>(list);
			}
		}

		private int prepareCache(FSoftObjectPath path)
		{
			if (CachedAssets.TryGetValue(path, out var value))
			{
				CacheAssetReference cacheAssetReference = value.Get();
				int refCount = cacheAssetReference.refCount + 1;
				cacheAssetReference.refCount = refCount;
				CachedAssets[path] = value;
				return cacheAssetReference.refCount;
			}
			CacheAssetReference cacheAssetReference2 = UObject.NewObject<CacheAssetReference>();
			cacheAssetReference2.refCount = 1;
			cacheAssetReference2.refObj = null;
			cacheAssetReference2.AssetState = CacheAssetReference.CacheAssetState.Loading;
			value = new TStrongObjectPtr<CacheAssetReference>();
			value.Set(cacheAssetReference2);
			CachedAssets[path] = value;
			return cacheAssetReference2.refCount;
		}

		private bool doCache(string path, UObject obj)
		{
			if (obj == null || !PreloadAssetHelper.IsPathValid(path))
			{
				return false;
			}
			FSoftObjectPath key = default(FSoftObjectPath);
			key.SetPath(path);
			if (CachedAssets.TryGetValue(key, out var value))
			{
				CacheAssetReference cacheAssetReference = value.Get();
				if (cacheAssetReference.AssetState == CacheAssetReference.CacheAssetState.Loaded)
				{
					int refCount = cacheAssetReference.refCount + 1;
					cacheAssetReference.refCount = refCount;
					CachedAssets[key] = value;
				}
				else if (cacheAssetReference.AssetState == CacheAssetReference.CacheAssetState.Loading)
				{
					cacheAssetReference.AssetState = CacheAssetReference.CacheAssetState.Loaded;
					cacheAssetReference.refObj = obj;
					CachedAssets[key] = value;
				}
				else
				{
					BGW_LogUtil.LogError("doCache Failed. AssetState = 0. path: " + path);
				}
			}
			return true;
		}

		private void doCacheFailed(string path)
		{
			FSoftObjectPath key = default(FSoftObjectPath);
			key.SetPath(path);
			if (CachedAssets.TryGetValue(key, out var value))
			{
				CacheAssetReference cacheAssetReference = value.Get();
				if (cacheAssetReference.AssetState == CacheAssetReference.CacheAssetState.Loading)
				{
					cacheAssetReference.refCount = 0;
					cacheAssetReference.AssetState = CacheAssetReference.CacheAssetState.FileNotFound;
					CachedAssets[key] = value;
				}
			}
		}

		public void OnInit()
		{
			GlobleRequestID = 1;
			TopRequests = new Queue<RequestInfo>();
			HighRequests = new Queue<RequestInfo>();
			MediumRequests = new Queue<RequestInfo>();
			LowRequests = new Queue<RequestInfo>();
		}

		public void OnTickWithGroup(float DeltaTime, int TickGroup)
		{
		}

		public void OnTick(float DeltaTime)
		{
			if (AssetRequests.Count == 0)
			{
				ComsumeRequest();
			}
			TickForAssetLoadFinish(DeltaTime);
		}

		public void OnShutdown()
		{
			foreach (KeyValuePair<int, TStrongObjectPtr<BGWAssetLoaderRequestCS>> assetRequest in AssetRequests)
			{
				BGWAssetLoaderRequestCS bGWAssetLoaderRequestCS = assetRequest.Value.Get();
				if (!(bGWAssetLoaderRequestCS == null) && !bGWAssetLoaderRequestCS.IsDestroyed)
				{
					assetRequest.Value.Set(null);
					bGWAssetLoaderRequestCS.Cancel();
				}
			}
			AssetRequests.Clear();
			PrintAllMissingFiles();
			CachedAssets.Clear();
		}

		public void PrintAllMissingFiles()
		{
			foreach (KeyValuePair<FSoftObjectPath, TStrongObjectPtr<CacheAssetReference>> cachedAsset in CachedAssets)
			{
				if (cachedAsset.Value.Get().AssetState == CacheAssetReference.CacheAssetState.FileNotFound)
				{
					BGW_LogUtil.LogError("Can't find file:" + cachedAsset.Key.Path);
				}
			}
		}

		private int GetLoadPriorityFromAssetPriority(EAssetPriority EAssetPriority)
		{
			return EAssetPriority switch
			{
				EAssetPriority.Top => 90, 
				EAssetPriority.High => 70, 
				EAssetPriority.Medium => 30, 
				EAssetPriority.Low => 10, 
				_ => 0, 
			};
		}

		private int GetAssetPriorityCost(EAssetPriority EAssetPriority)
		{
			return EAssetPriority switch
			{
				EAssetPriority.Top => 5, 
				EAssetPriority.High => 8, 
				EAssetPriority.Medium => 10, 
				EAssetPriority.Low => 15, 
				_ => 100, 
			};
		}

		private Queue<RequestInfo> GetPendingRequestQueueByAssetPriority(EAssetPriority EAssetPriority)
		{
			return EAssetPriority switch
			{
				EAssetPriority.Top => TopRequests, 
				EAssetPriority.High => HighRequests, 
				EAssetPriority.Medium => MediumRequests, 
				EAssetPriority.Low => LowRequests, 
				_ => LowRequests, 
			};
		}

		private void ComsumeRequest()
		{
			int num = 100;
			while (num > 0)
			{
				if (TopRequests.Count > 0)
				{
					RequestInfo info = TopRequests.Dequeue();
					int num2 = doRequestAsyncLoad(info, EAssetPriority.Top);
					num -= num2;
					continue;
				}
				if (HighRequests.Count > 0)
				{
					RequestInfo info2 = HighRequests.Dequeue();
					int num3 = doRequestAsyncLoad(info2, EAssetPriority.High);
					num -= num3;
					continue;
				}
				if (MediumRequests.Count > 0)
				{
					RequestInfo info3 = MediumRequests.Dequeue();
					int num4 = doRequestAsyncLoad(info3, EAssetPriority.Medium);
					num -= num4;
					continue;
				}
				if (LowRequests.Count != 0)
				{
					RequestInfo info4 = LowRequests.Dequeue();
					int num5 = doRequestAsyncLoad(info4, EAssetPriority.Low);
					num -= num5;
					continue;
				}
				break;
			}
		}

		private int doRequestAsyncLoad(RequestInfo Info, EAssetPriority priority = EAssetPriority.Default)
		{
			if (!PreloadAssetHelper.IsPathValid(Info.path.Path))
			{
				return 0;
			}
			if (CachedAssets.TryGetValue(Info.path, out var value) && value.Get().AssetState == CacheAssetReference.CacheAssetState.FileNotFound)
			{
				List<FSoftObjectPath> list = new List<FSoftObjectPath>();
				list.Add(Info.path);
				List<UObject> list2 = new List<UObject>();
				list2.Add(null);
				Info.callback(list, list2, Info.UserData);
				return 0;
			}
			UObject uObject = TryGetCachedObject(Info.path);
			if (uObject != null)
			{
				if (Info.needCache)
				{
					doCache(Info.path.Path, uObject);
				}
				List<FSoftObjectPath> list3 = new List<FSoftObjectPath>();
				list3.Add(Info.path);
				List<UObject> list4 = new List<UObject>();
				list4.Add(uObject);
				Info.callback(list3, list4, Info.UserData);
				return 0;
			}
			BGWAssetLoaderRequestCS req = UObject.NewObject<BGWAssetLoaderRequestCS>();
			req.RequestID = GlobleRequestID++;
			req.Owner = Info.Owner;
			if (Info.needCache)
			{
				prepareCache(Info.path);
			}
			req.BindCallback(delegate(List<FSoftObjectPath> requests, List<UObject> loaded)
			{
				for (int i = 0; i < loaded.Count; i++)
				{
					UObject uObject2 = loaded[i];
					string path = requests[i].Path;
					if (Info.needCache)
					{
						if (uObject2 != null)
						{
							doCache(path, uObject2);
						}
						else
						{
							doCacheFailed(path);
						}
					}
					ProcessSoftRefsInLoadedAsset(uObject2, priority);
				}
				Info.callback(requests, loaded, Info.UserData);
				AssetRequests[req.RequestID].Set(null);
				AssetRequests.Remove(req.RequestID);
			});
			TStrongObjectPtr<BGWAssetLoaderRequestCS> value2 = new TStrongObjectPtr<BGWAssetLoaderRequestCS>(req);
			AssetRequests.Add(req.RequestID, value2);
			int loadPriorityFromAssetPriority = GetLoadPriorityFromAssetPriority(priority);
			UBGWAssetLoader.AsyncLoadObject(Info.path, req, loadPriorityFromAssetPriority);
			return GetAssetPriorityCost(priority);
		}

		private void ProcessSoftRefsInLoadedAsset(UObject loadedObj, EAssetPriority Priority)
		{
			if (loadedObj == null)
			{
				return;
			}
			Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>> NotifySoftPath = new Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>>();
			Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>> NotifyStateSoftPath = new Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>>();
			bool flag = false;
			if (loadedObj.IsA<UAnimSequenceBase>())
			{
				BGUFuncLibAnim.BGUGetOneAnimNotifySoftPathSet(loadedObj as UAnimSequenceBase, ref NotifySoftPath, ref NotifyStateSoftPath);
				flag = GSGameplayCVar.CVar_AnimAsyncLoadSoftRes.GetValueInGameThread() == 1;
			}
			else if (loadedObj is b1.IBGWDataAssetHasAnimationReferences iBGWDataAssetHasAnimationReferences)
			{
				iBGWDataAssetHasAnimationReferences.GetAnimationReferences(out var AnimMontages);
				BGUFuncLibAnim.BGUGetAnimsNotifySoftPathSet(in AnimMontages, ref NotifySoftPath, ref NotifyStateSoftPath);
				flag = true;
			}
			foreach (KeyValuePair<BAN_GSBase, HashSet<FSoftObjectPath>> item in NotifySoftPath)
			{
				foreach (FSoftObjectPath item2 in item.Value)
				{
					BAN_GSBase Notify = item.Key;
					if (flag)
					{
						Notify.isPreload = true;
						RequestAsyncLoadObject(item2, delegate(List<FSoftObjectPath> SoftObjectPaths, List<UObject> LoadedObjects, object _1)
						{
							if (Notify.IsValidLowLevelFast())
							{
								foreach (UObject LoadedObject in LoadedObjects)
								{
									if (LoadedObject != null)
									{
										BGW_NativeFuncs.AddNotifyPreloadedAsset(Notify.Address, LoadedObject.Address);
									}
								}
							}
						}, Priority);
					}
					else
					{
						UObject uObject = RequestSyncLoadObject(item2.Path);
						if (uObject != null)
						{
							BGW_NativeFuncs.AddNotifyPreloadedAsset(Notify.Address, uObject.Address);
						}
					}
				}
			}
			foreach (KeyValuePair<BANS_GSBase, HashSet<FSoftObjectPath>> item3 in NotifyStateSoftPath)
			{
				foreach (FSoftObjectPath item4 in item3.Value)
				{
					BANS_GSBase NotifyState = item3.Key;
					if (flag)
					{
						NotifyState.isPreload = true;
						RequestAsyncLoadObject(item4, delegate(List<FSoftObjectPath> SoftObjectPaths, List<UObject> LoadedObjects, object _1)
						{
							if (NotifyState.IsValidLowLevelFast())
							{
								foreach (UObject LoadedObject2 in LoadedObjects)
								{
									if (LoadedObject2 != null)
									{
										BGW_NativeFuncs.AddNotifyPreloadedAsset(NotifyState.Address, LoadedObject2.Address);
									}
								}
							}
						}, Priority);
					}
					else
					{
						UObject uObject2 = RequestSyncLoadObject(item4.Path);
						if (uObject2 != null)
						{
							BGW_NativeFuncs.AddNotifyPreloadedAsset(NotifyState.Address, uObject2.Address);
						}
					}
				}
			}
		}

		public void OnSetProhibitLoadObject(bool _ProhibitLoadObject)
		{
			ProhibitLoadObject = _ProhibitLoadObject;
		}

		public bool CheckAllLoadTaskFinish()
		{
			if (TopRequests.Count > 0 || HighRequests.Count > 0 || MediumRequests.Count > 0 || LowRequests.Count > 0)
			{
				return false;
			}
			return true;
		}

		public void RequestAssetLoadFinishCallback(EAssetPriority MinPriority, Action FinishCallback, float TimeOutPeriodSecond = 3000f)
		{
			if (FinishCallback != null)
			{
				AssetLoadFinishRequests.Add(new AssetLoadFinishRequest(MinPriority, FinishCallback, TimeOutPeriodSecond));
			}
		}

		public bool IsAssetAllLoadFinishByMinPriority(EAssetPriority MinPriority)
		{
			int num = 0;
			int num2 = 0;
			if (MinPriority <= EAssetPriority.Top)
			{
				num2++;
				if (TopRequests.Count <= 0)
				{
					num++;
				}
			}
			if (MinPriority <= EAssetPriority.High)
			{
				num2++;
				if (HighRequests.Count <= 0)
				{
					num++;
				}
			}
			if (MinPriority <= EAssetPriority.Medium)
			{
				num2++;
				if (MediumRequests.Count <= 0)
				{
					num++;
				}
			}
			if (MinPriority <= EAssetPriority.Low)
			{
				num2++;
				if (LowRequests.Count <= 0)
				{
					num++;
				}
			}
			return num2 == num;
		}

		private void TickForAssetLoadFinish(float DeltaTime)
		{
			if (AssetLoadFinishRequests.Count == 0)
			{
				return;
			}
			for (int i = 0; i < AssetLoadFinishRequests.Count; i++)
			{
				AssetLoadFinishRequest assetLoadFinishRequest = AssetLoadFinishRequests[i];
				if (assetLoadFinishRequest == null)
				{
					AssetLoadFinishRequests.RemoveAt(i);
					i--;
					continue;
				}
				assetLoadFinishRequest.RemainTimeOutPeriodSecond -= DeltaTime;
				bool flag = assetLoadFinishRequest.RemainTimeOutPeriodSecond > 0f;
				if (flag && TopRequests.Count > 0)
				{
					flag = false;
				}
				if (flag && assetLoadFinishRequest.MinPriority <= EAssetPriority.High && HighRequests.Count > 0)
				{
					flag = false;
				}
				if (flag && assetLoadFinishRequest.MinPriority <= EAssetPriority.Medium && MediumRequests.Count > 0)
				{
					flag = false;
				}
				if (flag && assetLoadFinishRequest.MinPriority <= EAssetPriority.Low && LowRequests.Count > 0)
				{
					flag = false;
				}
				if (flag)
				{
					AssetLoadFinishRequests.RemoveAt(i);
					i--;
					assetLoadFinishRequest.FinishCallback();
				}
			}
		}
	}

	private static float RELEASE_DURATION;

	private Dictionary<TStrongObjectPtr<UAkAudioEvent>, float> SustainAkReference = new Dictionary<TStrongObjectPtr<UAkAudioEvent>, float>();

	private int TryGetCachedResourceObjStatId = -1;

	private int CurrentLevelID = -1;

	private int ReqID;

	private PreloadLevelConfig PL_Config;

	private Dictionary<int, UnitResIDAssetInfo> UnitResIDAssets = new Dictionary<int, UnitResIDAssetInfo>();

	private Dictionary<string, ResourceInfo> AllResources = new Dictionary<string, ResourceInfo>();

	private Dictionary<EPreloadAssetSourceType, List<string>> AllResourcesTmp = new Dictionary<EPreloadAssetSourceType, List<string>>();

	private PreloadResourceCounter ResourceCounter = new PreloadResourceCounter();

	private List<string> AbnormalResourcePathList = new List<string>();

	private List<string> AlwaysCookPathList = new List<string>();

	private bool EnableDebugCounterLog;

	private bool EnableDebugLog;

	private bool ClosePreload;

	private bool IgnoreAsyncLoad;

	private bool NeedInitGlobalRes;

	private Dictionary<string, EAssetPriority> LoadList = new Dictionary<string, EAssetPriority>();

	private Type UBLUEPRINT_TYPE = typeof(UBlueprint);

	private List<EPreloadAssetSourceType> PreloadResourceDetailInfoTypeList = new List<EPreloadAssetSourceType>();

	private static bool BattleSCConfigDataAsset_IsValid;

	private static int BattleSCConfigDataAsset_Offset;

	private static bool HatredConfigDataAsset_IsValid;

	private static int HatredConfigDataAsset_Offset;

	private static bool UIConfigDataAsset_IsValid;

	private static int UIConfigDataAsset_Offset;

	private static bool MapConfigDataAsset_IsValid;

	private static int MapConfigDataAsset_Offset;

	private static bool FallDyingConfigDataAsset_IsValid;

	private static int FallDyingConfigDataAsset_Offset;

	private static bool Demo820ConfigDataAsset_IsValid;

	private static int Demo820ConfigDataAsset_Offset;

	private static bool CricketBattleDataAsset_IsValid;

	private static int CricketBattleDataAsset_Offset;

	private static bool EquipPreviewConfigDataAsset_IsValid;

	private static int EquipPreviewConfigDataAsset_Offset;

	private static bool TransPreviewConfigDataAsset_IsValid;

	private static int TransPreviewConfigDataAsset_Offset;

	private static bool BHLItemTmpDataAsset_IsValid;

	private static int BHLItemTmpDataAsset_Offset;

	private static bool MPCStickProg_IsValid;

	private static int MPCStickProg_Offset;

	private static bool MonsterManualConfigDataAsset_IsValid;

	private static int MonsterManualConfigDataAsset_Offset;

	private static bool ObservationModeConfig_IsValid;

	private static int ObservationModeConfig_Offset;

	private static bool ABSPosToUVConfig_IsValid;

	private static int ABSPosToUVConfig_Offset;

	private static bool DamageNumConfig_IsValid;

	private static int DamageNumConfig_Offset;

	private static bool GameConfig_IsValid;

	private static int GameConfig_Offset;

	private static bool LevelSequenceConfig_IsValid;

	private static int LevelSequenceConfig_Offset;

	private static bool AISkillScoreConfigDataAsset_IsValid;

	private static int AISkillScoreConfigDataAsset_Offset;

	private static bool AIHatredConfigDataAsset_IsValid;

	private static int AIHatredConfigDataAsset_Offset;

	private static bool CoinDropFXNumConfig_IsValid;

	private static int CoinDropFXNumConfig_Offset;

	private static bool DA_B1_DispLibGameDB_IsValid;

	private static int DA_B1_DispLibGameDB_Offset;

	private static bool DefaultLocalFluid2DConfig_IsValid;

	private static int DefaultLocalFluid2DConfig_Offset;

	private static bool DestructibleImpulseConfig_IsValid;

	private static int DestructibleImpulseConfig_Offset;

	private static bool UnitDynamicObstacle_DefaultDBC_IsValid;

	private static int UnitDynamicObstacle_DefaultDBC_Offset;

	private static bool BattleFieldPerformanceOptConfig_IsValid;

	private static int BattleFieldPerformanceOptConfig_Offset;

	private static bool MatLayerFunctionMappingConfigMap_IsValid;

	private static int MatLayerFunctionMappingConfigMap_Offset;

	private static FFieldAddress MatLayerFunctionMappingConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, BGWDataAsset_MatLayerFunctionMappingConfig> MatLayerFunctionMappingConfigMap_Marshaler;

	private static bool EnvironmentMaskGlobalConfig_IsValid;

	private static int EnvironmentMaskGlobalConfig_Offset;

	private static bool AnimationSyncStateMonster2WukongConfig_IsValid;

	private static int AnimationSyncStateMonster2WukongConfig_Offset;

	private static bool AnimationSyncStateMonster2MonsterConfig_IsValid;

	private static int AnimationSyncStateMonster2MonsterConfig_Offset;

	private static bool FrozenAccMatCurve_IsValid;

	private static int FrozenAccMatCurve_Offset;

	private static bool BulletSmartSelectTargetConfig_IsValid;

	private static int BulletSmartSelectTargetConfig_Offset;

	private static bool _CloudMoveConfig_IsValid;

	private static int _CloudMoveConfig_Offset;

	private static bool LevelInfo_IsValid;

	private static int LevelInfo_Offset;

	private static bool HitAudioPreloadListConfig_IsValid;

	private static int HitAudioPreloadListConfig_Offset;

	private static bool RebirthGeoInfo_IsValid;

	private static int RebirthGeoInfo_Offset;

	private static bool TROConfig_Small_IsValid;

	private static int TROConfig_Small_Offset;

	private static bool TROConfig_Medium_IsValid;

	private static int TROConfig_Medium_Offset;

	private static bool TROConfig_MediumBig_IsValid;

	private static int TROConfig_MediumBig_Offset;

	private static bool TROConfig_Big_IsValid;

	private static int TROConfig_Big_Offset;

	private static bool TROConfig_Huge_IsValid;

	private static int TROConfig_Huge_Offset;

	private static bool AssetHolderMap_IsValid;

	private static int AssetHolderMap_Offset;

	private static FFieldAddress AssetHolderMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, b1.BGW.UAsyncLoadAssetHolder> AssetHolderMap_Marshaler;

	public override bool bTickEnabled => true;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:BattleSCConfigDataAsset")]
	public BGWDataAsset_BattleSCConfig BattleSCConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!BattleSCConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BattleSCConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_BattleSCConfig>.FromNative(IntPtr.Add(base.Address, BattleSCConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleSCConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BattleSCConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_BattleSCConfig>.ToNative(IntPtr.Add(base.Address, BattleSCConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:HatredConfigDataAsset")]
	public BGWHatredConfigDataAsset HatredConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!HatredConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:HatredConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWHatredConfigDataAsset>.FromNative(IntPtr.Add(base.Address, HatredConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HatredConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:HatredConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWHatredConfigDataAsset>.ToNative(IntPtr.Add(base.Address, HatredConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:UIConfigDataAsset")]
	public BGWUIConfigDataAsset UIConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!UIConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:UIConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWUIConfigDataAsset>.FromNative(IntPtr.Add(base.Address, UIConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UIConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:UIConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWUIConfigDataAsset>.ToNative(IntPtr.Add(base.Address, UIConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:MapConfigDataAsset")]
	public BGWMapUIConfigDataAsset MapConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!MapConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:MapConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWMapUIConfigDataAsset>.FromNative(IntPtr.Add(base.Address, MapConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:MapConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWMapUIConfigDataAsset>.ToNative(IntPtr.Add(base.Address, MapConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:FallDyingConfigDataAsset")]
	public BGWFallDyingConfigDataAsset FallDyingConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!FallDyingConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:FallDyingConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWFallDyingConfigDataAsset>.FromNative(IntPtr.Add(base.Address, FallDyingConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FallDyingConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:FallDyingConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWFallDyingConfigDataAsset>.ToNative(IntPtr.Add(base.Address, FallDyingConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:Demo820ConfigDataAsset")]
	public BGWDemo820ConfigDataAsset Demo820ConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!Demo820ConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:Demo820ConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWDemo820ConfigDataAsset>.FromNative(IntPtr.Add(base.Address, Demo820ConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Demo820ConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:Demo820ConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWDemo820ConfigDataAsset>.ToNative(IntPtr.Add(base.Address, Demo820ConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:CricketBattleDataAsset")]
	public BGWCricketBattleDataAsset CricketBattleDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!CricketBattleDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:CricketBattleDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWCricketBattleDataAsset>.FromNative(IntPtr.Add(base.Address, CricketBattleDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CricketBattleDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:CricketBattleDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWCricketBattleDataAsset>.ToNative(IntPtr.Add(base.Address, CricketBattleDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:EquipPreviewConfigDataAsset")]
	public BGWEquipPreviewConfigDataAsset EquipPreviewConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!EquipPreviewConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:EquipPreviewConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWEquipPreviewConfigDataAsset>.FromNative(IntPtr.Add(base.Address, EquipPreviewConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EquipPreviewConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:EquipPreviewConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWEquipPreviewConfigDataAsset>.ToNative(IntPtr.Add(base.Address, EquipPreviewConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:TransPreviewConfigDataAsset")]
	public BGWTransPreviewConfigDataAsset TransPreviewConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!TransPreviewConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TransPreviewConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWTransPreviewConfigDataAsset>.FromNative(IntPtr.Add(base.Address, TransPreviewConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransPreviewConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TransPreviewConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWTransPreviewConfigDataAsset>.ToNative(IntPtr.Add(base.Address, TransPreviewConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:BHLItemTmpDataAsset")]
	public BGWBHLItemTmpDataAsset BHLItemTmpDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!BHLItemTmpDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BHLItemTmpDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWBHLItemTmpDataAsset>.FromNative(IntPtr.Add(base.Address, BHLItemTmpDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BHLItemTmpDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BHLItemTmpDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWBHLItemTmpDataAsset>.ToNative(IntPtr.Add(base.Address, BHLItemTmpDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:MPCStickProg")]
	public UMaterialParameterCollection MPCStickProg
	{
		get
		{
			CheckDestroyed();
			if (!MPCStickProg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:MPCStickProg");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPCStickProg_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPCStickProg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:MPCStickProg");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPCStickProg_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:MonsterManualConfigDataAsset")]
	public BGWMonsterManualConfigDataAsset MonsterManualConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!MonsterManualConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:MonsterManualConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWMonsterManualConfigDataAsset>.FromNative(IntPtr.Add(base.Address, MonsterManualConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MonsterManualConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:MonsterManualConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWMonsterManualConfigDataAsset>.ToNative(IntPtr.Add(base.Address, MonsterManualConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:ObservationModeConfig")]
	public BGWDataAsset_ObservationModeConfig ObservationModeConfig
	{
		get
		{
			CheckDestroyed();
			if (!ObservationModeConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:ObservationModeConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_ObservationModeConfig>.FromNative(IntPtr.Add(base.Address, ObservationModeConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservationModeConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:ObservationModeConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_ObservationModeConfig>.ToNative(IntPtr.Add(base.Address, ObservationModeConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:ABSPosToUVConfig")]
	public BGWDataAsset_ABSPosToUVConfig ABSPosToUVConfig
	{
		get
		{
			CheckDestroyed();
			if (!ABSPosToUVConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:ABSPosToUVConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_ABSPosToUVConfig>.FromNative(IntPtr.Add(base.Address, ABSPosToUVConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABSPosToUVConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:ABSPosToUVConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_ABSPosToUVConfig>.ToNative(IntPtr.Add(base.Address, ABSPosToUVConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:DamageNumConfig")]
	public BGWDataAsset_DamageNumConfig DamageNumConfig
	{
		get
		{
			CheckDestroyed();
			if (!DamageNumConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DamageNumConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_DamageNumConfig>.FromNative(IntPtr.Add(base.Address, DamageNumConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DamageNumConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DamageNumConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_DamageNumConfig>.ToNative(IntPtr.Add(base.Address, DamageNumConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:GameConfig")]
	public BGWDataAsset_GameConfig GameConfig
	{
		get
		{
			CheckDestroyed();
			if (!GameConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:GameConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_GameConfig>.FromNative(IntPtr.Add(base.Address, GameConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:GameConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_GameConfig>.ToNative(IntPtr.Add(base.Address, GameConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:LevelSequenceConfig")]
	public BGWDataAsset_LevelSequenceConfig LevelSequenceConfig
	{
		get
		{
			CheckDestroyed();
			if (!LevelSequenceConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:LevelSequenceConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_LevelSequenceConfig>.FromNative(IntPtr.Add(base.Address, LevelSequenceConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelSequenceConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:LevelSequenceConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_LevelSequenceConfig>.ToNative(IntPtr.Add(base.Address, LevelSequenceConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:AISkillScoreConfigDataAsset")]
	public BGWAISkillScoreConfigDataAsset AISkillScoreConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!AISkillScoreConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AISkillScoreConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWAISkillScoreConfigDataAsset>.FromNative(IntPtr.Add(base.Address, AISkillScoreConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AISkillScoreConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AISkillScoreConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWAISkillScoreConfigDataAsset>.ToNative(IntPtr.Add(base.Address, AISkillScoreConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:AIHatredConfigDataAsset")]
	public BGWDataAsset_AIHatredConfig AIHatredConfigDataAsset
	{
		get
		{
			CheckDestroyed();
			if (!AIHatredConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AIHatredConfigDataAsset");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AIHatredConfig>.FromNative(IntPtr.Add(base.Address, AIHatredConfigDataAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIHatredConfigDataAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AIHatredConfigDataAsset");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AIHatredConfig>.ToNative(IntPtr.Add(base.Address, AIHatredConfigDataAsset_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:CoinDropFXNumConfig")]
	public BGWDataAsset_CoinDropFXNumConfig CoinDropFXNumConfig
	{
		get
		{
			CheckDestroyed();
			if (!CoinDropFXNumConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:CoinDropFXNumConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_CoinDropFXNumConfig>.FromNative(IntPtr.Add(base.Address, CoinDropFXNumConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CoinDropFXNumConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:CoinDropFXNumConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_CoinDropFXNumConfig>.ToNative(IntPtr.Add(base.Address, CoinDropFXNumConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:DA_B1_DispLibGameDB")]
	public BGW_DispLibGameDBDataAsset DA_B1_DispLibGameDB
	{
		get
		{
			CheckDestroyed();
			if (!DA_B1_DispLibGameDB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DA_B1_DispLibGameDB");
				return null;
			}
			return UObjectMarshaler<BGW_DispLibGameDBDataAsset>.FromNative(IntPtr.Add(base.Address, DA_B1_DispLibGameDB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DA_B1_DispLibGameDB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DA_B1_DispLibGameDB");
			}
			else
			{
				UObjectMarshaler<BGW_DispLibGameDBDataAsset>.ToNative(IntPtr.Add(base.Address, DA_B1_DispLibGameDB_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:DefaultLocalFluid2DConfig")]
	public BGWDataAsset_LocalFluid2DConfig DefaultLocalFluid2DConfig
	{
		get
		{
			CheckDestroyed();
			if (!DefaultLocalFluid2DConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DefaultLocalFluid2DConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_LocalFluid2DConfig>.FromNative(IntPtr.Add(base.Address, DefaultLocalFluid2DConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultLocalFluid2DConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DefaultLocalFluid2DConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_LocalFluid2DConfig>.ToNative(IntPtr.Add(base.Address, DefaultLocalFluid2DConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:DestructibleImpulseConfig")]
	public BGWDataAsset_DestructibleImpulseConfig DestructibleImpulseConfig
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleImpulseConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DestructibleImpulseConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_DestructibleImpulseConfig>.FromNative(IntPtr.Add(base.Address, DestructibleImpulseConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleImpulseConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:DestructibleImpulseConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_DestructibleImpulseConfig>.ToNative(IntPtr.Add(base.Address, DestructibleImpulseConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:UnitDynamicObstacle_DefaultDBC")]
	public BGWDataAsset_B1DBC UnitDynamicObstacle_DefaultDBC
	{
		get
		{
			CheckDestroyed();
			if (!UnitDynamicObstacle_DefaultDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:UnitDynamicObstacle_DefaultDBC");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, UnitDynamicObstacle_DefaultDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitDynamicObstacle_DefaultDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:UnitDynamicObstacle_DefaultDBC");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, UnitDynamicObstacle_DefaultDBC_Offset), value);
			}
		}
	}

	[UProperty]
	public static BGWDataAsset_PreloadOutlaws UnitPreload_Outlaws { get; set; }

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:BattleFieldPerformanceOptConfig")]
	public BGWDataAsset_BattleFieldPerformanceOptConfig BattleFieldPerformanceOptConfig
	{
		get
		{
			CheckDestroyed();
			if (!BattleFieldPerformanceOptConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BattleFieldPerformanceOptConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_BattleFieldPerformanceOptConfig>.FromNative(IntPtr.Add(base.Address, BattleFieldPerformanceOptConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleFieldPerformanceOptConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BattleFieldPerformanceOptConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_BattleFieldPerformanceOptConfig>.ToNative(IntPtr.Add(base.Address, BattleFieldPerformanceOptConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:MatLayerFunctionMappingConfigMap")]
	public TMapReadWrite<int, BGWDataAsset_MatLayerFunctionMappingConfig> MatLayerFunctionMappingConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!MatLayerFunctionMappingConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:MatLayerFunctionMappingConfigMap");
				return null;
			}
			if (MatLayerFunctionMappingConfigMap_Marshaler == null)
			{
				MatLayerFunctionMappingConfigMap_Marshaler = new TMapReadWriteMarshaler<int, BGWDataAsset_MatLayerFunctionMappingConfig>(1, MatLayerFunctionMappingConfigMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<BGWDataAsset_MatLayerFunctionMappingConfig, UObjectMarshaler<BGWDataAsset_MatLayerFunctionMappingConfig>>.FromNative, CachedMarshalingDelegates<BGWDataAsset_MatLayerFunctionMappingConfig, UObjectMarshaler<BGWDataAsset_MatLayerFunctionMappingConfig>>.ToNative);
			}
			return MatLayerFunctionMappingConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, MatLayerFunctionMappingConfigMap_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:EnvironmentMaskGlobalConfig")]
	public BGWDataAsset_EnvironmentMaskGlobalConfig EnvironmentMaskGlobalConfig
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentMaskGlobalConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:EnvironmentMaskGlobalConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_EnvironmentMaskGlobalConfig>.FromNative(IntPtr.Add(base.Address, EnvironmentMaskGlobalConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvironmentMaskGlobalConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:EnvironmentMaskGlobalConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_EnvironmentMaskGlobalConfig>.ToNative(IntPtr.Add(base.Address, EnvironmentMaskGlobalConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:AnimationSyncStateMonster2WukongConfig")]
	public BGWDataAsset_AnimationSyncStateConfig AnimationSyncStateMonster2WukongConfig
	{
		get
		{
			CheckDestroyed();
			if (!AnimationSyncStateMonster2WukongConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AnimationSyncStateMonster2WukongConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AnimationSyncStateConfig>.FromNative(IntPtr.Add(base.Address, AnimationSyncStateMonster2WukongConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationSyncStateMonster2WukongConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AnimationSyncStateMonster2WukongConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AnimationSyncStateConfig>.ToNative(IntPtr.Add(base.Address, AnimationSyncStateMonster2WukongConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:AnimationSyncStateMonster2MonsterConfig")]
	public BGWDataAsset_AnimationSyncStateConfig AnimationSyncStateMonster2MonsterConfig
	{
		get
		{
			CheckDestroyed();
			if (!AnimationSyncStateMonster2MonsterConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AnimationSyncStateMonster2MonsterConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AnimationSyncStateConfig>.FromNative(IntPtr.Add(base.Address, AnimationSyncStateMonster2MonsterConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationSyncStateMonster2MonsterConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AnimationSyncStateMonster2MonsterConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AnimationSyncStateConfig>.ToNative(IntPtr.Add(base.Address, AnimationSyncStateMonster2MonsterConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:FrozenAccMatCurve")]
	public UCurveFloat FrozenAccMatCurve
	{
		get
		{
			CheckDestroyed();
			if (!FrozenAccMatCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:FrozenAccMatCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, FrozenAccMatCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrozenAccMatCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:FrozenAccMatCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, FrozenAccMatCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:BulletSmartSelectTargetConfig")]
	public BGWDataAsset_BulletSmartSelectTargetConfig BulletSmartSelectTargetConfig
	{
		get
		{
			CheckDestroyed();
			if (!BulletSmartSelectTargetConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BulletSmartSelectTargetConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_BulletSmartSelectTargetConfig>.FromNative(IntPtr.Add(base.Address, BulletSmartSelectTargetConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletSmartSelectTargetConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:BulletSmartSelectTargetConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_BulletSmartSelectTargetConfig>.ToNative(IntPtr.Add(base.Address, BulletSmartSelectTargetConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:_CloudMoveConfig")]
	private BGWDataAsset_CloudMoveConfig _CloudMoveConfig
	{
		get
		{
			CheckDestroyed();
			if (!_CloudMoveConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:_CloudMoveConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_CloudMoveConfig>.FromNative(IntPtr.Add(base.Address, _CloudMoveConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!_CloudMoveConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:_CloudMoveConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_CloudMoveConfig>.ToNative(IntPtr.Add(base.Address, _CloudMoveConfig_Offset), value);
			}
		}
	}

	public BGWDataAsset_CloudMoveConfig CloudMoveConfig
	{
		get
		{
			if (_CloudMoveConfig == null)
			{
				_CloudMoveConfig = Load_Internal<BGWDataAsset_CloudMoveConfig>("BGWDataAsset_CloudMoveConfig'/Game/00Main/DataAsset/DA_CloudMoveConfig.DA_CloudMoveConfig'");
			}
			return _CloudMoveConfig;
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:LevelInfo")]
	public BGWDataAsset_LevelInfo LevelInfo
	{
		get
		{
			CheckDestroyed();
			if (!LevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:LevelInfo");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_LevelInfo>.FromNative(IntPtr.Add(base.Address, LevelInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:LevelInfo");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_LevelInfo>.ToNative(IntPtr.Add(base.Address, LevelInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:HitAudioPreloadListConfig")]
	public BGWDataAsset_HitAudioPreloadList HitAudioPreloadListConfig
	{
		get
		{
			CheckDestroyed();
			if (!HitAudioPreloadListConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:HitAudioPreloadListConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_HitAudioPreloadList>.FromNative(IntPtr.Add(base.Address, HitAudioPreloadListConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitAudioPreloadListConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:HitAudioPreloadListConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_HitAudioPreloadList>.ToNative(IntPtr.Add(base.Address, HitAudioPreloadListConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:RebirthGeoInfo")]
	public BGWDataAsset_RebirthGeoInfo RebirthGeoInfo
	{
		get
		{
			CheckDestroyed();
			if (!RebirthGeoInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:RebirthGeoInfo");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_RebirthGeoInfo>.FromNative(IntPtr.Add(base.Address, RebirthGeoInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthGeoInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:RebirthGeoInfo");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_RebirthGeoInfo>.ToNative(IntPtr.Add(base.Address, RebirthGeoInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Small")]
	public BGWDataAsset_TROConfig TROConfig_Small
	{
		get
		{
			CheckDestroyed();
			if (!TROConfig_Small_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Small");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TROConfig>.FromNative(IntPtr.Add(base.Address, TROConfig_Small_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TROConfig_Small_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Small");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TROConfig>.ToNative(IntPtr.Add(base.Address, TROConfig_Small_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Medium")]
	public BGWDataAsset_TROConfig TROConfig_Medium
	{
		get
		{
			CheckDestroyed();
			if (!TROConfig_Medium_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Medium");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TROConfig>.FromNative(IntPtr.Add(base.Address, TROConfig_Medium_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TROConfig_Medium_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Medium");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TROConfig>.ToNative(IntPtr.Add(base.Address, TROConfig_Medium_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_MediumBig")]
	public BGWDataAsset_TROConfig TROConfig_MediumBig
	{
		get
		{
			CheckDestroyed();
			if (!TROConfig_MediumBig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_MediumBig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TROConfig>.FromNative(IntPtr.Add(base.Address, TROConfig_MediumBig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TROConfig_MediumBig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_MediumBig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TROConfig>.ToNative(IntPtr.Add(base.Address, TROConfig_MediumBig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Big")]
	public BGWDataAsset_TROConfig TROConfig_Big
	{
		get
		{
			CheckDestroyed();
			if (!TROConfig_Big_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Big");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TROConfig>.FromNative(IntPtr.Add(base.Address, TROConfig_Big_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TROConfig_Big_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Big");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TROConfig>.ToNative(IntPtr.Add(base.Address, TROConfig_Big_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Huge")]
	public BGWDataAsset_TROConfig TROConfig_Huge
	{
		get
		{
			CheckDestroyed();
			if (!TROConfig_Huge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Huge");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TROConfig>.FromNative(IntPtr.Add(base.Address, TROConfig_Huge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TROConfig_Huge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:TROConfig_Huge");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TROConfig>.ToNative(IntPtr.Add(base.Address, TROConfig_Huge_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGW_PreloadAssetMgr:AssetHolderMap")]
	private TMapReadWrite<int, b1.BGW.UAsyncLoadAssetHolder> AssetHolderMap
	{
		get
		{
			CheckDestroyed();
			if (!AssetHolderMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PreloadAssetMgr:AssetHolderMap");
				return null;
			}
			if (AssetHolderMap_Marshaler == null)
			{
				AssetHolderMap_Marshaler = new TMapReadWriteMarshaler<int, b1.BGW.UAsyncLoadAssetHolder>(1, AssetHolderMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<b1.BGW.UAsyncLoadAssetHolder, UObjectMarshaler<b1.BGW.UAsyncLoadAssetHolder>>.FromNative, CachedMarshalingDelegates<b1.BGW.UAsyncLoadAssetHolder, UObjectMarshaler<b1.BGW.UAsyncLoadAssetHolder>>.ToNative);
			}
			return AssetHolderMap_Marshaler.FromNative(IntPtr.Add(base.Address, AssetHolderMap_Offset));
		}
	}

	public static void SetReleaseDuration(int NewDuration)
	{
		RELEASE_DURATION = NewDuration;
	}

	private void RemoveResource(string ObjPath)
	{
		if (!AllResources.TryGetValue(ObjPath, out var value))
		{
			return;
		}
		value.Clear();
		AllResources.Remove(ObjPath);
		if (AllResourcesTmp.TryGetValue(value.SourceType, out var value2))
		{
			if (value2.Contains(ObjPath))
			{
				value2.Remove(ObjPath);
			}
			if (value2.Count == 0)
			{
				AllResourcesTmp.Remove(value.SourceType);
			}
		}
		ResourceCounter.RemoveItem(ObjPath);
	}

	private bool IsIgnorePreloadForDebug()
	{
		if (UGSE_EngineFuncLib.HasLaunchOption("IgnorePreloadForDebug"))
		{
			return true;
		}
		return false;
	}

	private bool IsIgnoreAsyncLoadForDebug()
	{
		if (UGSE_EngineFuncLib.HasLaunchOption("IsIgnoreAsyncLoadForDebug"))
		{
			return true;
		}
		return false;
	}

	public static BGW_PreloadAssetMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_PreloadAssetMgr>(Context);
	}

	public static BGW_PreloadAssetMgr Get(UActorCompBaseCS Comp)
	{
		return Comp.PreloadAssetMgr;
	}

	public static BGW_PreloadAssetMgr Get(UActorCompBaseUObj Comp)
	{
		return Comp.PreloadAssetMgr;
	}

	public static BGW_PreloadAssetMgr Get(UBaseActorComp Comp)
	{
		return Get(Comp.GetOwner());
	}

	public override void OnAttach()
	{
		BGWAssetManager.Get().OnInit();
		InitAssetHolder();
		TryGetCachedResourceObjStatId = ProfilerFuncLib.CreateStatID("TryGetCachedResourceObjStatId");
		CurrentLevelID = -1;
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.Preload.EnableDebugCounterLog");
		EnableDebugCounterLog = (object)consoleVariable != null && consoleVariable.GetInt() == 1;
		IConsoleVariable consoleVariable2 = IConsoleManager.Get().FindConsoleVariable("b.Preload.EnableDebugLog");
		EnableDebugLog = (object)consoleVariable2 != null && consoleVariable2.GetInt() == 1;
		IConsoleVariable consoleVariable3 = IConsoleManager.Get().FindConsoleVariable("b.ClosePreload");
		ClosePreload = (object)consoleVariable3 != null && consoleVariable3.GetInt() == 1;
		IConsoleVariable consoleVariable4 = IConsoleManager.Get().FindConsoleVariable("b.IgnoreAsyncLoad");
		IgnoreAsyncLoad = (object)consoleVariable4 != null && consoleVariable4.GetInt() == 1;
		NeedInitGlobalRes = true;
		IConsoleVariable consoleVariable5 = IConsoleManager.Get().FindConsoleVariable("b.Preload.InternalLevel");
		int num = ((consoleVariable5 != null) ? consoleVariable5.GetInt() : 0);
		PL_Config = new PreloadLevelConfig(num);
		if (num > 0)
		{
			ClosePreload = false;
			IgnoreAsyncLoad = false;
			if (num == 3 || num == 4 || num == 5)
			{
				ClosePreload = true;
			}
		}
		bool num2 = BGWGameInstanceCS.Get(this).GetCurLoadingScreenState() == EGSLoadingScreenState.MainThreadUpdating;
		if (num2)
		{
			BGWGameInstanceCS.Get(this).SwitchLoadingScreenThread(UseSlateThread: true);
		}
		PreloadGlobalResource();
		if (num2)
		{
			BGWGameInstanceCS.Get(this).SwitchLoadingScreenThread(UseSlateThread: false);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_BGW_UnitRequestPreload = (BGW_EventCollection.Del_BGW_UnitRequestPreload)Delegate.Combine(bGW_EventCollection.Evt_BGW_UnitRequestPreload, new BGW_EventCollection.Del_BGW_UnitRequestPreload(OnPreloadMonsterRes));
			bGW_EventCollection.Evt_BGW_UnitRequestUnLoad = (BGW_EventCollection.Del_BGW_UnitRequestUnLoad)Delegate.Combine(bGW_EventCollection.Evt_BGW_UnitRequestUnLoad, new BGW_EventCollection.Del_BGW_UnitRequestUnLoad(OnUnitRequestUnLoad));
			bGW_EventCollection.Evt_BGW_InteractRequestPreload = (BGW_EventCollection.Del_BGW_InteractRequestPreload)Delegate.Combine(bGW_EventCollection.Evt_BGW_InteractRequestPreload, new BGW_EventCollection.Del_BGW_InteractRequestPreload(OnInteractRequestPreload));
			bGW_EventCollection.Evt_BGW_DynamicObstaclePreload = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_BGW_DynamicObstaclePreload, new Del_Void_Int(OnDynamicObstaclePreload));
			bGW_EventCollection.Evt_BGW_PlayerRequestPreload = (BGW_EventCollection.Del_BGW_PlayerRequestPreload)Delegate.Combine(bGW_EventCollection.Evt_BGW_PlayerRequestPreload, new BGW_EventCollection.Del_BGW_PlayerRequestPreload(OnPreloadPlayerRes));
			bGW_EventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload = (BGW_EventCollection.Del_BGW_PlayerAbilityChangeRequestPreload)Delegate.Combine(bGW_EventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload, new BGW_EventCollection.Del_BGW_PlayerAbilityChangeRequestPreload(OnPlayerAbilityChangeRequestPreload));
			bGW_EventCollection.Evt_BGW_PlayerRequestAllDescByAbilityPreload = (Del_Void_Entity)Delegate.Combine(bGW_EventCollection.Evt_BGW_PlayerRequestAllDescByAbilityPreload, new Del_Void_Entity(OnPreloadAllPlayerDescByAbility));
			bGW_EventCollection.Evt_leavingMap = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_leavingMap, new Del_Void(OnLeaveCurrentLevel));
			bGW_EventCollection.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnEnterNewLevel));
			bGW_EventCollection.Evt_EnterMainMenu = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_EnterMainMenu, new Del_Void(OnLeaveCurrentLevel));
			bGW_EventCollection.Evt_BGW_SetIgnorePreload = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_BGW_SetIgnorePreload, new Del_Void(OnSetIgnorePreload));
		}
		PreloadAssetHelper.sCommonDescResourceCache_Player.Clear();
		PreloadAssetHelper.sCommonDescResourceCache_Player_IgnoreFX.Clear();
		PreloadAssetHelper.sCommonDescResourceCache_Monster.Clear();
		PreloadAssetHelper.sCommonDescResourceCache_Monster_IgnoreFX.Clear();
		PreloadAssetHelper.sUnitDescResourcCache.Clear();
		PreloadAssetHelper.sUnitDescResourcCache_IgnoreFX.Clear();
	}

	private void PreloadGlobalResource()
	{
		if (NeedInitGlobalRes)
		{
			NeedInitGlobalRes = false;
			InitGlobalDataAsset();
			InitGlobalSoundBank();
			if (!IsIgnorePreloadForDebug() && !PL_Config.IsIgnorePublicResource)
			{
				Dictionary<string, EAssetPriority> PublicResourcePathDic = new Dictionary<string, EAssetPriority>();
				PreloadAssetHelper.GetPublicDataAssetResourceLoadList(ref PublicResourcePathDic);
				PreloadAssetHelper.GetUIBPLoadList(ref PublicResourcePathDic);
				AsyncLoadPublicResource(PublicResourcePathDic, EPreloadAssetSourceType.GlobalResource_Common);
			}
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		PrintAbnormalResourcePathList();
		AssetHolderMap.Clear();
		BGWAssetManager.Get().OnShutdown();
		foreach (ResourceInfo value in AllResources.Values)
		{
			value.Clear();
		}
		UnitResIDAssets.Clear();
		AllResources.Clear();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_BGW_UnitRequestPreload = (BGW_EventCollection.Del_BGW_UnitRequestPreload)Delegate.Remove(bGW_EventCollection.Evt_BGW_UnitRequestPreload, new BGW_EventCollection.Del_BGW_UnitRequestPreload(OnPreloadMonsterRes));
			bGW_EventCollection.Evt_BGW_UnitRequestUnLoad = (BGW_EventCollection.Del_BGW_UnitRequestUnLoad)Delegate.Remove(bGW_EventCollection.Evt_BGW_UnitRequestUnLoad, new BGW_EventCollection.Del_BGW_UnitRequestUnLoad(OnUnitRequestUnLoad));
			bGW_EventCollection.Evt_BGW_InteractRequestPreload = (BGW_EventCollection.Del_BGW_InteractRequestPreload)Delegate.Remove(bGW_EventCollection.Evt_BGW_InteractRequestPreload, new BGW_EventCollection.Del_BGW_InteractRequestPreload(OnInteractRequestPreload));
			bGW_EventCollection.Evt_BGW_DynamicObstaclePreload = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_BGW_DynamicObstaclePreload, new Del_Void_Int(OnDynamicObstaclePreload));
			bGW_EventCollection.Evt_BGW_PlayerRequestPreload = (BGW_EventCollection.Del_BGW_PlayerRequestPreload)Delegate.Remove(bGW_EventCollection.Evt_BGW_PlayerRequestPreload, new BGW_EventCollection.Del_BGW_PlayerRequestPreload(OnPreloadPlayerRes));
			bGW_EventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload = (BGW_EventCollection.Del_BGW_PlayerAbilityChangeRequestPreload)Delegate.Remove(bGW_EventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload, new BGW_EventCollection.Del_BGW_PlayerAbilityChangeRequestPreload(OnPlayerAbilityChangeRequestPreload));
			bGW_EventCollection.Evt_leavingMap = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_leavingMap, new Del_Void(OnLeaveCurrentLevel));
			bGW_EventCollection.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnEnterNewLevel));
			bGW_EventCollection.Evt_EnterMainMenu = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_EnterMainMenu, new Del_Void(OnLeaveCurrentLevel));
			bGW_EventCollection.Evt_BGW_SetIgnorePreload = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_BGW_SetIgnorePreload, new Del_Void(OnSetIgnorePreload));
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		BGWAssetManager.Get().OnTick(DeltaTime);
		if (UnitResIDAssets != null && UnitResIDAssets.Count > 0)
		{
			for (int num = UnitResIDAssets.Count - 1; num >= 0; num--)
			{
				KeyValuePair<int, UnitResIDAssetInfo> keyValuePair = UnitResIDAssets.ElementAt(num);
				int key = keyValuePair.Key;
				UnitResIDAssetInfo value = keyValuePair.Value;
				if (!value.bIsPlayer)
				{
					if (value.GuidList.Count == 0)
					{
						value.ReleaseTimer -= DeltaTime;
					}
					else
					{
						value.ReleaseTimer = RELEASE_DURATION;
					}
					if (value.ReleaseTimer <= 0f)
					{
						if (value.BeAttackedConfigList != null && value.BeAttackedConfigList.Count > 0)
						{
							foreach (string beAttackedConfig in value.BeAttackedConfigList)
							{
								if (!AllResources.TryGetValue(beAttackedConfig, out var value2))
								{
									continue;
								}
								value2.RelatedResIDList.Remove(key);
								if (value2.RelatedResIDList.Count == 0)
								{
									if (value2.State == CacheState.Cached)
									{
										RemoveResource(beAttackedConfig);
									}
									else if (value2.State == CacheState.Loading)
									{
										value2.bIsTriggerUnLoad = true;
									}
								}
							}
							value.BeAttackedConfigList.Clear();
						}
						if (value.BehitNormalStiffAMDic != null)
						{
							foreach (KeyValuePair<string, List<TStrongObjectPtr<UAnimMontage>>> item in value.BehitNormalStiffAMDic)
							{
								foreach (TStrongObjectPtr<UAnimMontage> item2 in item.Value)
								{
									item2.SetNull();
								}
							}
							value.BehitNormalStiffAMDic.Clear();
						}
						if (value.DeathDispConfigList != null && value.DeathDispConfigList.Count > 0)
						{
							foreach (string deathDispConfig in value.DeathDispConfigList)
							{
								if (!AllResources.TryGetValue(deathDispConfig, out var value3))
								{
									continue;
								}
								value3.RelatedResIDList.Remove(key);
								if (value3.RelatedResIDList.Count == 0)
								{
									if (value3.State == CacheState.Cached)
									{
										RemoveResource(deathDispConfig);
									}
									else if (value3.State == CacheState.Loading)
									{
										value3.bIsTriggerUnLoad = true;
									}
								}
							}
							value.DeathDispConfigList.Clear();
						}
						if (value.DeathDispAMDic != null)
						{
							foreach (KeyValuePair<string, List<TStrongObjectPtr<UAnimMontage>>> item3 in value.DeathDispAMDic)
							{
								foreach (TStrongObjectPtr<UAnimMontage> item4 in item3.Value)
								{
									item4.SetNull();
								}
							}
							value.DeathDispAMDic.Clear();
						}
						if (value.OtherResourcePathList != null)
						{
							foreach (string otherResourcePath in value.OtherResourcePathList)
							{
								if (!AllResources.TryGetValue(otherResourcePath, out var value4))
								{
									continue;
								}
								value4.RelatedResIDList.Remove(key);
								if (value4.RelatedResIDList.Count == 0)
								{
									if (value4.State == CacheState.Cached)
									{
										RemoveResource(otherResourcePath);
									}
									else if (value4.State == CacheState.Loading)
									{
										value4.bIsTriggerUnLoad = true;
									}
								}
							}
						}
						UnitResIDAssets.Remove(key);
					}
				}
			}
		}
		if (ResourceCounter.MaxWaitingForHideScreenAssetTimer > 0f)
		{
			ResourceCounter.MaxWaitingForHideScreenAssetTimer -= DeltaTime;
		}
		TStrongObjectPtr<UAkAudioEvent>[] array = SustainAkReference.Keys.ToArray();
		foreach (TStrongObjectPtr<UAkAudioEvent> tStrongObjectPtr in array)
		{
			if (SustainAkReference[tStrongObjectPtr] != -1f)
			{
				if (SustainAkReference[tStrongObjectPtr] <= DeltaTime)
				{
					SustainAkReference.Remove(tStrongObjectPtr);
					tStrongObjectPtr.Dispose();
				}
				else
				{
					SustainAkReference[tStrongObjectPtr] -= DeltaTime;
				}
			}
		}
	}

	private void PrintResourceCounter()
	{
		foreach (EPreloadAssetSourceType value in Enum.GetValues(typeof(EPreloadAssetSourceType)))
		{
			ResourceCounter.GetCounterByType(value);
			_ = 0;
		}
		if (ResourceCounter.GetNeedHideInLoadingScreenAssetCounter() > 0)
		{
			_ = ResourceCounter.MaxWaitingForHideScreenAssetTimer;
			_ = 0f;
		}
	}

	private void OnEnterNewLevel(int NewLevelID)
	{
		if (IConsoleManager.Get().FindConsoleVariable("b.PSO.ForceDisablePSOUsageMask").GetInt() == 0)
		{
			UGSE_EngineFuncLib.SetPSOCacheUsageMask(NewLevelID, -1, -1, -1);
		}
		if (CurrentLevelID == NewLevelID)
		{
			return;
		}
		PreloadGlobalResource();
		LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(NewLevelID);
		if (levelDesc != null)
		{
			BGWHatredConfigDataAsset bGWHatredConfigDataAsset = Load_Internal<BGWHatredConfigDataAsset>(levelDesc.LevelHatredBattleConfig);
			if (bGWHatredConfigDataAsset != null)
			{
				HatredConfigDataAsset = bGWHatredConfigDataAsset;
			}
		}
		CurrentLevelID = NewLevelID;
		if (!IsIgnorePreloadForDebug())
		{
			Dictionary<string, EAssetPriority> LoadList = new Dictionary<string, EAssetPriority>();
			List<int> RelatedUnitResIDList = new List<int>();
			PreloadAssetHelper.LoadLevelResource(NewLevelID, ref LoadList, ref RelatedUnitResIDList);
			LoadPlayerCloudMoveResources(NewLevelID, ref LoadList);
			AsyncLoadPublicResource(LoadList, EPreloadAssetSourceType.GlobalResource_Level);
			if (!PL_Config.IsIgnoreUnitCommRes)
			{
				PreloadUnitCommRes();
			}
		}
	}

	private void LoadPlayerCloudMoveResources(int LevelID, ref Dictionary<string, EAssetPriority> LoadList)
	{
		if (LevelInfo == null || !LevelInfo.LevelTagToLevelIdMap.TryGetValue(ELevelTag.SupportRide, out var value) || !value.LevelIdList.Contains(LevelID) || CloudMoveConfig == null)
		{
			return;
		}
		List<int> list = new List<int>();
		list.AddRange(CloudMoveConfig.GetRideSkills());
		list.AddRange(CloudMoveConfig.GetGetOffSkills());
		foreach (int item in list)
		{
			PreloadAssetHelper.LoadPlayerSkillRelatedResource(item, PL_Config.IsIgnoreAllFX, ref LoadList);
		}
		foreach (string resourcesPath in CloudMoveConfig.GetResourcesPaths())
		{
			if (!LoadList.ContainsKey(resourcesPath))
			{
				LoadList.Add(resourcesPath, EAssetPriority.Medium);
			}
		}
		foreach (int buffConfig in CloudMoveConfig.GetBuffConfigs())
		{
			PreloadAssetHelper.GetBuffPreloadData(buffConfig, LoadList, PL_Config.IsIgnoreAllFX);
		}
	}

	private void OnLeaveCurrentLevel()
	{
		CurrentLevelID = -1;
		NeedInitGlobalRes = true;
		HitAudioPreloadListConfig = null;
		_CloudMoveConfig = null;
		CancelAsyncLoadRequest(new List<(EPreloadAssetSourceType, EPreloadAssetSourceType)> { (EPreloadAssetSourceType.All, EPreloadAssetSourceType.End) });
		UnitResIDAssets.Clear();
		foreach (KeyValuePair<string, ResourceInfo> allResource in AllResources)
		{
			allResource.Value?.Clear();
			ResourceCounter.RemoveItem(allResource.Key);
		}
		AllResources.Clear();
		BGW_GCMgr.ManualGC();
	}

	private void CancelAsyncLoadRequest(List<(EPreloadAssetSourceType, EPreloadAssetSourceType)> InAssetSourceTypeList)
	{
		List<EPreloadAssetSourceType> list = new List<EPreloadAssetSourceType>();
		foreach (var InAssetSourceType in InAssetSourceTypeList)
		{
			if (GetAssetSourceTypeReleateList(InAssetSourceType.Item1, InAssetSourceType.Item2, out var OutList))
			{
				list.AddRange(OutList);
				continue;
			}
			list.Add(InAssetSourceType.Item1);
			list.Add(InAssetSourceType.Item2);
		}
		foreach (EPreloadAssetSourceType item in list)
		{
			if (AssetHolderMap.TryGetValue((int)item, out var value))
			{
				BGWAssetManager.Get().CancelAsyncLoadRequestByOwner(value);
			}
		}
	}

	private bool GetAssetSourceTypeReleateList(EPreloadAssetSourceType AssetSourceTypeBegin, EPreloadAssetSourceType AssetSourceTypeEnd, out List<EPreloadAssetSourceType> OutList)
	{
		OutList = new List<EPreloadAssetSourceType>();
		foreach (EPreloadAssetSourceType value in Enum.GetValues(typeof(EPreloadAssetSourceType)))
		{
			if (value >= AssetSourceTypeEnd)
			{
				break;
			}
			if (value > AssetSourceTypeBegin)
			{
				OutList.Add(value);
			}
		}
		return true;
	}

	private bool CheckIsReleateResourceType(EPreloadAssetSourceType AssetSourceTypeBegin, EPreloadAssetSourceType AssetSourceTypeEnd, EPreloadAssetSourceType ControlGroup)
	{
		if (ControlGroup >= AssetSourceTypeBegin && ControlGroup <= AssetSourceTypeEnd)
		{
			return true;
		}
		return false;
	}

	private void OnSetIgnorePreload()
	{
		ClosePreload = true;
	}

	private void OnInteractRequestPreload(int InteractID)
	{
		if (!IsIgnorePreloadForDebug())
		{
			Dictionary<string, EAssetPriority> LoadList = new Dictionary<string, EAssetPriority>();
			PreloadAssetHelper.LoadInteractResource(InteractID, ref LoadList);
			AsyncLoadUnitResource(LoadList, EUnitPreloadLevel.Top, EPreloadAssetSourceType.Other_Interact, -1);
		}
	}

	private void OnDynamicObstaclePreload(int PerformID)
	{
		if (!IsIgnorePreloadForDebug())
		{
			Dictionary<string, EAssetPriority> LoadList = new Dictionary<string, EAssetPriority>();
			PreloadAssetHelper.LoadDynamicObstacleResource(PerformID, ref LoadList);
			AsyncLoadUnitResource(LoadList, EUnitPreloadLevel.Top, EPreloadAssetSourceType.Other_DynamicObstaclePerform, -1);
		}
	}

	private void OnPreloadMonsterRes(int ResID, int OverrideID, string FinalGUID, EUnitPreloadLevel PreloadLevel)
	{
		if (LoadBeAttackedAndDeathResource(ResID, IsPlayer: false, FinalGUID, PreloadLevel) && !IsIgnorePreloadForDebug())
		{
			LoadList.Clear();
			PreloadAssetHelper.LoadMonsterDescResource(PL_Config, ResID, OverrideID, ref LoadList);
			AsyncLoadUnitResource(LoadList, PreloadLevel, EPreloadAssetSourceType.MonsterResource_Instances, ResID);
		}
	}

	private void OnUnitRequestUnLoad(int ResID, int OverrideID, string FinalGUID)
	{
		if (UnitResIDAssets.TryGetValue(ResID, out var value) && value.GuidList.Contains(FinalGUID))
		{
			value.GuidList.Remove(FinalGUID);
		}
	}

	private void OnPreloadPlayerRes(Entity PlayerEntity, bool IsOriginPlayer)
	{
		AActor aActor = ECSExtension.ToActor(PlayerEntity);
		int actorResID = BGU_DataUtil.GetActorResID(aActor);
		int finalBattleInfoExtendID = BGU_DataUtil.GetFinalBattleInfoExtendID(aActor);
		LoadBeAttackedAndDeathResource(actorResID, IsPlayer: true, string.Empty, EUnitPreloadLevel.Top);
		if (!IsIgnorePreloadForDebug())
		{
			LoadList.Clear();
			PreloadAssetHelper.LoadPlayerDescResource(PL_Config, aActor, actorResID, finalBattleInfoExtendID, IsOriginPlayer, ref LoadList);
			AsyncLoadUnitResource(LoadList, EUnitPreloadLevel.Top, EPreloadAssetSourceType.PlayerResource_Instances, actorResID);
		}
	}

	private void OnPlayerAbilityChangeRequestPreload(Entity PlayerEntity, EPreloadPlayerAbilityType AbilityType)
	{
		if (IsIgnorePreloadForDebug())
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(PlayerEntity);
		int actorResID = BGU_DataUtil.GetActorResID(aActor);
		Dictionary<string, EAssetPriority> LoadList = new Dictionary<string, EAssetPriority>();
		PreloadAssetHelper.LoadPlayerDescByAbility(PL_Config, aActor, actorResID, new List<EPreloadPlayerAbilityType> { AbilityType }, ref LoadList);
		EPreloadAssetSourceType ePreloadAssetSourceType = EPreloadAssetSourceType.None;
		switch (AbilityType)
		{
		case EPreloadPlayerAbilityType.Talent:
			ePreloadAssetSourceType = EPreloadAssetSourceType.PlayerResource_Ability_Talent;
			break;
		case EPreloadPlayerAbilityType.FaBao:
			ePreloadAssetSourceType = EPreloadAssetSourceType.PlayerResource_Ability_FaBao;
			break;
		case EPreloadPlayerAbilityType.Magic:
			ePreloadAssetSourceType = EPreloadAssetSourceType.PlayerResource_Ability_Magic;
			break;
		case EPreloadPlayerAbilityType.Vigor:
			ePreloadAssetSourceType = EPreloadAssetSourceType.PlayerResource_Ability_Vigor;
			break;
		}
		if (ePreloadAssetSourceType == EPreloadAssetSourceType.None)
		{
			return;
		}
		CancelAsyncLoadRequest(new List<(EPreloadAssetSourceType, EPreloadAssetSourceType)> { (ePreloadAssetSourceType, ePreloadAssetSourceType) });
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, ResourceInfo> allResource in AllResources)
		{
			ResourceInfo value = allResource.Value;
			if (value != null && value.SourceType == ePreloadAssetSourceType)
			{
				list.Add(allResource.Key);
			}
		}
		foreach (string item in list)
		{
			ResourceCounter.RemoveItem(item);
			RemoveResource(item);
		}
		AsyncLoadUnitResource(LoadList, EUnitPreloadLevel.Top, ePreloadAssetSourceType, actorResID);
	}

	private void PreloadUnitCommRes()
	{
		if (!IsIgnorePreloadForDebug())
		{
			Dictionary<string, EAssetPriority> LoadList = new Dictionary<string, EAssetPriority>();
			PreloadAssetHelper.LoadUnitCommResource(PL_Config, ref LoadList);
			AsyncLoadUnitResource(LoadList, EUnitPreloadLevel.Top, EPreloadAssetSourceType.MonsterResource_Comm, -1);
		}
	}

	private void OnPreloadAllPlayerDescByAbility(Entity PlayerEntity)
	{
		AActor aActor = ECSExtension.ToActor(PlayerEntity);
		int actorResID = BGU_DataUtil.GetActorResID(aActor);
		if (!IsIgnorePreloadForDebug())
		{
			PreloadAssetHelper.LoadAllPlayerDescByAbility(PL_Config, aActor, actorResID, ref LoadList);
		}
	}

	private void AsyncLoadUnitResource(Dictionary<string, EAssetPriority> PathList, EUnitPreloadLevel PreloadLevel, EPreloadAssetSourceType AssetSourceType, int ResID)
	{
		List<EAssetPriority> list = new List<EAssetPriority>
		{
			EAssetPriority.Top,
			EAssetPriority.High,
			EAssetPriority.Medium,
			EAssetPriority.Low
		};
		switch (PreloadLevel)
		{
		case EUnitPreloadLevel.High:
			list = new List<EAssetPriority>
			{
				EAssetPriority.Top,
				EAssetPriority.High,
				EAssetPriority.Medium
			};
			break;
		case EUnitPreloadLevel.Low:
			list = new List<EAssetPriority> { EAssetPriority.Top };
			break;
		}
		foreach (KeyValuePair<string, EAssetPriority> item in PreloadAssetHelper.Change2ValidPathList(PathList))
		{
			string key = item.Key;
			EAssetPriority value = item.Value;
			if (list.Contains(value))
			{
				Load_Internal<UObject>(key, new PreloadAsyncLoadUserData(AssetSourceType, value, ResID), IsAsyncLoad: true);
			}
		}
	}

	private void AsyncLoadPublicResource(Dictionary<string, EAssetPriority> PathInfoDic, EPreloadAssetSourceType SourceType)
	{
		foreach (KeyValuePair<string, EAssetPriority> item in PreloadAssetHelper.Change2ValidPathList(PathInfoDic))
		{
			Load_Internal<UObject>(item.Key, new PreloadAsyncLoadUserData(SourceType, item.Value), IsAsyncLoad: true);
		}
	}

	private bool LoadBeAttackedAndDeathResource(int ResID, bool IsPlayer, string FinalGUID, EUnitPreloadLevel NewPreloadLevel)
	{
		bool result = false;
		if (!UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			if (NewPreloadLevel == EUnitPreloadLevel.None)
			{
				return false;
			}
			result = true;
			value = new UnitResIDAssetInfo(IsPlayer, NewPreloadLevel, FinalGUID);
			UnitResIDAssets.Add(ResID, value);
			if (!PL_Config.IsIgnoreBeAttackedAndDeathAM)
			{
				EPreloadAssetSourceType preloadAssetType = (IsPlayer ? EPreloadAssetSourceType.PlayerResource_BeAttacked : EPreloadAssetSourceType.MonsterResource_BeAttacked);
				foreach (string unitBeAttackedConfigLoad in PreloadAssetHelper.GetUnitBeAttackedConfigLoadList(ResID))
				{
					if (!value.BeAttackedConfigList.Contains(unitBeAttackedConfigLoad))
					{
						value.BeAttackedConfigList.Add(unitBeAttackedConfigLoad);
						Load_Internal<UObject>(unitBeAttackedConfigLoad, new PreloadAsyncLoadUserData(preloadAssetType, EAssetPriority.Top, ResID), IsAsyncLoad: true);
					}
				}
				preloadAssetType = (IsPlayer ? EPreloadAssetSourceType.PlayerResource_DeathDisp : EPreloadAssetSourceType.MonsterResource_DeathDisp);
				foreach (string unitDeathDispConfigLoad in PreloadAssetHelper.GetUnitDeathDispConfigLoadList(ResID))
				{
					if (!value.DeathDispConfigList.Contains(unitDeathDispConfigLoad))
					{
						value.DeathDispConfigList.Add(unitDeathDispConfigLoad);
						Load_Internal<UObject>(unitDeathDispConfigLoad, new PreloadAsyncLoadUserData(preloadAssetType, EAssetPriority.Top, ResID), IsAsyncLoad: true);
					}
				}
			}
		}
		else
		{
			if (!value.GuidList.Contains(FinalGUID))
			{
				value.GuidList.Add(FinalGUID);
			}
			if (NewPreloadLevel == EUnitPreloadLevel.None)
			{
				value.GuidList.Remove(FinalGUID);
			}
			else if (value.NowUnitPreloadLevel < NewPreloadLevel)
			{
				result = true;
				value.NowUnitPreloadLevel = NewPreloadLevel;
			}
		}
		return result;
	}

	private T Load_Internal<T>(string Path, PreloadAsyncLoadUserData InUserData = null, bool IsAsyncLoad = false, Action<int, UObject> FinishCallbackFunc = null, int CallbackReqID = -1) where T : UObject
	{
		UObject loadedObj = null;
		if (InUserData == null)
		{
			InUserData = PreloadAsyncLoadUserData.GlobalComm;
		}
		if (string.IsNullOrEmpty(Path))
		{
			FinishCallbackFunc?.Invoke(CallbackReqID, null);
			return null;
		}
		if (FPackageName.ParseExportTextPath(Path, out var className, out var ValidObjPath))
		{
			if (className.Contains("Blueprint"))
			{
				bool flag = false;
				if (ValidObjPath.EndsWith("_C"))
				{
					if (ValidObjPath.Contains("_C.") && !ValidObjPath.EndsWith("_C_C"))
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
				if (flag && !UBLUEPRINT_TYPE.IsAssignableFrom(typeof(T)))
				{
					ValidObjPath += "_C";
				}
			}
		}
		else
		{
			ValidObjPath = FPackageName.ExportTextPathToObjectPath(Path);
		}
		if (!PreloadAssetHelper.IsPathValid(ValidObjPath, bOutputLog: false))
		{
			FinishCallbackFunc?.Invoke(CallbackReqID, null);
			return null;
		}
		int resID = InUserData.ResID;
		EAssetPriority eAssetPriority = InUserData.Priority;
		EPreloadAssetSourceType ePreloadAssetSourceType = InUserData.PreloadAssetType;
		ResourceInfo CurrentRI = null;
		if (AllResources.TryGetValue(ValidObjPath, out CurrentRI))
		{
			eAssetPriority = CurrentRI.LoadPriority;
			ePreloadAssetSourceType = CurrentRI.SourceType;
		}
		else
		{
			CurrentRI = new ResourceInfo(this, CacheState.Loading, eAssetPriority, ePreloadAssetSourceType);
			AllResources.Add(ValidObjPath, CurrentRI);
			if (AllResourcesTmp.TryGetValue(ePreloadAssetSourceType, out var value))
			{
				if (!value.Contains(ValidObjPath))
				{
					value.Add(ValidObjPath);
				}
			}
			else
			{
				AllResourcesTmp.Add(ePreloadAssetSourceType, new List<string> { ValidObjPath });
			}
		}
		if (ePreloadAssetSourceType != EPreloadAssetSourceType.PlayerResource_DeathDisp && ePreloadAssetSourceType != EPreloadAssetSourceType.MonsterResource_DeathDisp && ePreloadAssetSourceType != EPreloadAssetSourceType.PlayerResource_BeAttacked && ePreloadAssetSourceType != EPreloadAssetSourceType.MonsterResource_BeAttacked)
		{
			AddOtherResource2List(resID, ValidObjPath);
		}
		if (FinishCallbackFunc != null)
		{
			CurrentRI.AddFinishCallback(CallbackReqID, FinishCallbackFunc);
		}
		CurrentRI.bIsTriggerUnLoad = false;
		if (IsAsyncLoad)
		{
			if (CurrentRI.State == CacheState.Cached)
			{
				loadedObj = CurrentRI.Obj;
				CurrentRI.CallFinishCallback();
			}
			else if (!IsIgnoreAsyncLoadForDebug())
			{
				CurrentRI.State = CacheState.Loading;
				ResourceCounter.AddItem(ValidObjPath, ePreloadAssetSourceType, eAssetPriority);
				ResourceInfo value2;
				if (BGWAssetManager.Get().RequestAsyncLoadObject(ValidObjPath, delegate(List<FSoftObjectPath> _, List<UObject> Loadedobjects, object _UserData)
				{
					int resID2 = -1;
					EPreloadAssetSourceType ePreloadAssetSourceType2 = EPreloadAssetSourceType.None;
					if (_UserData is PreloadAsyncLoadUserData preloadAsyncLoadUserData)
					{
						resID2 = preloadAsyncLoadUserData.ResID;
						ePreloadAssetSourceType2 = preloadAsyncLoadUserData.PreloadAssetType;
					}
					UObject loadedObj2 = Loadedobjects[0];
					string text = ValidObjPath;
					SolveUBlueprint2UClass<T>(ref loadedObj2);
					ResourceCounter.RemoveItem(text);
					switch (ePreloadAssetSourceType2)
					{
					case EPreloadAssetSourceType.MonsterResource_BeAttacked:
					case EPreloadAssetSourceType.PlayerResource_BeAttacked:
						AddBeAttackedConfig2Dic(resID2, text, loadedObj2 as BGWDataAsset_UnitBeAttackedConfig);
						break;
					case EPreloadAssetSourceType.MonsterResource_DeathDisp:
					case EPreloadAssetSourceType.PlayerResource_DeathDisp:
						AddDeathDispConfig2Dic(resID2, text, loadedObj2 as BGWDataAsset_UnitDeathDispConfig);
						break;
					}
					if (AllResources.TryGetValue(text, out var value3))
					{
						if (loadedObj2 != null)
						{
							value3.State = CacheState.Cached;
							value3.Obj = loadedObj2;
						}
						else
						{
							value3.State = CacheState.FailLoad;
						}
						value3.CallFinishCallback();
						if (CurrentRI.bIsTriggerUnLoad || ePreloadAssetSourceType2 == EPreloadAssetSourceType.UIResource_NoCache)
						{
							RemoveResource(text);
						}
					}
				}, eAssetPriority, needCache: false, GetAssetHolder(ePreloadAssetSourceType), new PreloadAsyncLoadUserData(ePreloadAssetSourceType, eAssetPriority, resID)) == 0)
				{
					ResourceCounter.RemoveItem(ValidObjPath);
				}
				else if (AllResources.TryGetValue(ValidObjPath, out value2))
				{
					loadedObj = value2.Obj;
				}
			}
		}
		else
		{
			if (CurrentRI.State == CacheState.Loading)
			{
				loadedObj = BGWAssetManager.Get().RequestSyncLoadObject(ValidObjPath);
				if (loadedObj != null)
				{
					CurrentRI.State = CacheState.Cached;
					CurrentRI.Obj = loadedObj;
				}
				else
				{
					CurrentRI.State = CacheState.FailLoad;
				}
			}
			else if (CurrentRI.State == CacheState.Cached)
			{
				loadedObj = CurrentRI.Obj;
			}
			if (InUserData.PreloadAssetType == EPreloadAssetSourceType.PlayerResource_BeAttacked || InUserData.PreloadAssetType == EPreloadAssetSourceType.MonsterResource_BeAttacked)
			{
				AddBeAttackedConfig2Dic(InUserData.ResID, ValidObjPath, CurrentRI.Obj as BGWDataAsset_UnitBeAttackedConfig);
			}
			else if (InUserData.PreloadAssetType == EPreloadAssetSourceType.PlayerResource_DeathDisp || InUserData.PreloadAssetType == EPreloadAssetSourceType.MonsterResource_DeathDisp)
			{
				AddDeathDispConfig2Dic(InUserData.ResID, ValidObjPath, CurrentRI.Obj as BGWDataAsset_UnitDeathDispConfig);
			}
			CurrentRI.CallFinishCallback();
			if (CurrentRI.SourceType == EPreloadAssetSourceType.UIResource_NoCache || CurrentRI.SourceType == EPreloadAssetSourceType.Other_TamerMonsterClassNoCache)
			{
				RemoveResource(ValidObjPath);
			}
		}
		SolveUBlueprint2UClass<T>(ref loadedObj);
		return loadedObj as T;
	}

	private static void SolveUBlueprint2UClass<T>(ref UObject loadedObj)
	{
		if (!(loadedObj == null) && typeof(UClass).IsAssignableFrom(typeof(T)) && loadedObj is UBlueprint uBlueprint)
		{
			loadedObj = uBlueprint.GeneratedClass;
		}
	}

	private bool CheckIsInAlwaysCookCatalog(string Path)
	{
		if (AlwaysCookPathList.Count == 0)
		{
			AlwaysCookPathList = UBGWFunctionLibrary.BGWGetAlwaysCookPathList();
			AlwaysCookPathList.Add("/Game/00Main/Maps");
		}
		foreach (string alwaysCookPath in AlwaysCookPathList)
		{
			if (Path.Contains(alwaysCookPath))
			{
				return true;
			}
		}
		return false;
	}

	private void InitGlobalDataAsset()
	{
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.HatredConfigDataAsset, out var ConfigInfo);
		HatredConfigDataAsset = Load_Internal<BGWHatredConfigDataAsset>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.UIConfigDataAsset, out ConfigInfo);
		UIConfigDataAsset = Load_Internal<BGWUIConfigDataAsset>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.MapConfigDataAsset, out ConfigInfo);
		MapConfigDataAsset = Load_Internal<BGWMapUIConfigDataAsset>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.FallDyingConfigDataAsset, out ConfigInfo);
		FallDyingConfigDataAsset = Load_Internal<BGWFallDyingConfigDataAsset>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.EquipPreviewConfigDataAsset, out ConfigInfo);
		EquipPreviewConfigDataAsset = Load_Internal<BGWEquipPreviewConfigDataAsset>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.TransPreviewConfigDataAsset, out ConfigInfo);
		TransPreviewConfigDataAsset = Load_Internal<BGWTransPreviewConfigDataAsset>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BHLItemTmpDataAsset, out ConfigInfo);
		BHLItemTmpDataAsset = Load_Internal<BGWBHLItemTmpDataAsset>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.MPCStickProg, out ConfigInfo);
		MPCStickProg = Load_Internal<UMaterialParameterCollection>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.ABSPosToUVConfig, out ConfigInfo);
		ABSPosToUVConfig = Load_Internal<BGWDataAsset_ABSPosToUVConfig>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.UDOPC_DefaultDBC, out ConfigInfo);
		UnitDynamicObstacle_DefaultDBC = Load_Internal<BGWDataAsset_B1DBC>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.UnitPreload_Outlaws, out ConfigInfo);
		UnitPreload_Outlaws = Load_Internal<BGWDataAsset_PreloadOutlaws>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BattleFieldPerformanceOptConfig, out ConfigInfo);
		BattleFieldPerformanceOptConfig = Load_Internal<BGWDataAsset_BattleFieldPerformanceOptConfig>(ConfigInfo.StringValue);
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.FrozenAccMatCurve, out ConfigInfo);
		FrozenAccMatCurve = Load_Internal<UCurveFloat>(ConfigInfo.StringValue);
		if (DebugConfig.Debug820Demo)
		{
			if (DebugConfig.Demo820DebugTest)
			{
				Demo820ConfigDataAsset = Load_Internal<BGWDemo820ConfigDataAsset>("BGWDemo820ConfigDataAsset'/Game/00Main/Maps/2023820/Demo/BP_820demo_config_test.BP_820demo_config_test'");
			}
			else
			{
				Demo820ConfigDataAsset = Load_Internal<BGWDemo820ConfigDataAsset>("BGWDemo820ConfigDataAsset'/Game/00MainTemp/2023820/Demo/BP_820demo_config.BP_820demo_config'");
			}
		}
		if (DebugConfig.CricketBattleMode || BGW_CricketBattleMgr.CmdStart)
		{
			CricketBattleDataAsset = Load_Internal<BGWCricketBattleDataAsset>("BGWCricketBattleDataAsset'/Game/00Main/Design/Config/BP_CricketBattleConfig.BP_CricketBattleConfig'");
		}
		MonsterManualConfigDataAsset = Load_Internal<BGWMonsterManualConfigDataAsset>("BGWMonsterManualConfigDataAsset'/Game/00Main/Design/Config/DA_MonsterManualConfig.DA_MonsterManualConfig'");
		ObservationModeConfig = Load_Internal<BGWDataAsset_ObservationModeConfig>("BGWDataAsset_ObservationModeConfig'/Game/00Main/Design/Config/DA_UIObservationModeConfig.DA_UIObservationModeConfig'");
		DamageNumConfig = Load_Internal<BGWDataAsset_DamageNumConfig>("BGWDataAsset_DamageNumConfig'/Game/00Main/Design/UIConfig/DA_DamageNumConfig.DA_DamageNumConfig'");
		GameConfig = Load_Internal<BGWDataAsset_GameConfig>("BGWDataAsset_GameConfig'/Game/00Main/Design/UIConfig/DA_GameConfig.DA_GameConfig'");
		LevelSequenceConfig = Load_Internal<BGWDataAsset_LevelSequenceConfig>("BGWDataAsset_LevelSequenceConfig'/Game/00Main/Design/Config/DA_LevelSeqConfig.DA_LevelSeqConfig'");
		AISkillScoreConfigDataAsset = Load_Internal<BGWAISkillScoreConfigDataAsset>("BGWDataAsset_AIHatredConfig'/Game/00Main/BPLibrary/BGW/BP_AIHatredConfigDataAsset.BP_AIHatredConfigDataAsset'");
		AIHatredConfigDataAsset = Load_Internal<BGWDataAsset_AIHatredConfig>("BGWAISkillScoreConfigDataAsset'/Game/00Main/Design/AI/SkillScoreFilters/BP_AISkillScoreConfigDA.BP_AISkillScoreConfigDA'");
		CoinDropFXNumConfig = Load_Internal<BGWDataAsset_CoinDropFXNumConfig>("BGWDataAsset_CoinDropFXNumConfig'/Game/00Main/Design/Config/DA_CoinDropFXNumConfig.DA_CoinDropFXNumConfig'");
		LevelInfo = Load_Internal<BGWDataAsset_LevelInfo>("BGWDataAsset_LevelInfo'/Game/00Main/DataAsset/DA_LevelInfo.DA_LevelInfo'");
		RebirthGeoInfo = Load_Internal<BGWDataAsset_RebirthGeoInfo>("BGWDataAsset_LevelInfo'/Game/00Main/DataAsset/DA_RebirthGeoInfo.DA_RebirthGeoInfo'");
		TROConfig_Small = Load_Internal<BGWDataAsset_TROConfig>("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Small.Global_TRODataAsset_Small'");
		TROConfig_Medium = Load_Internal<BGWDataAsset_TROConfig>("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Medium.Global_TRODataAsset_Medium'");
		TROConfig_MediumBig = Load_Internal<BGWDataAsset_TROConfig>("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_MediumBig.Global_TRODataAsset_MediumBig'");
		TROConfig_Big = Load_Internal<BGWDataAsset_TROConfig>("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Big.Global_TRODataAsset_Big'");
		TROConfig_Huge = Load_Internal<BGWDataAsset_TROConfig>("BGWDataAsset_TROConfig'/Game/00Main/BPLibrary/BGW/TRO/Global_TRODataAsset_Huge.Global_TRODataAsset_Huge'");
		DA_B1_DispLibGameDB = Load_Internal<BGW_DispLibGameDBDataAsset>("BGWDataAsset_DA_B1_DispLibGameDB'/Game/00Main/Design/Config/DispConfig/DA_B1_DispLibGameDB.DA_B1_DispLibGameDB'");
		DefaultLocalFluid2DConfig = Load_Internal<BGWDataAsset_LocalFluid2DConfig>("BGWDataAsset_LocalFluid2DConfig'/Game/00Main/DataAsset/DA_LocalFluid2DDefaultConfig.DA_LocalFluid2DDefaultConfig'");
		DestructibleImpulseConfig = Load_Internal<BGWDataAsset_DestructibleImpulseConfig>("BGWDataAsset_DestructibleImpulseConfig'/Game/00Main/DataAsset/DA_DestructibleImpulseConfig.DA_DestructibleImpulseConfig'");
		EnvironmentMaskGlobalConfig = Load_Internal<BGWDataAsset_EnvironmentMaskGlobalConfig>("BGWDataAsset_EnvironmentMaskGlobalConfig'/Game/00Main/DataAsset/DA_EnvironmentMaskGlobalConfig.DA_EnvironmentMaskGlobalConfig'");
		AnimationSyncStateMonster2WukongConfig = Load_Internal<BGWDataAsset_AnimationSyncStateConfig>("BGWDataAsset_AnimationSyncStateConfig'/Game/00Main/DataAsset/ASS/DA_AnimationSyncState_Monster2Wukong.DA_AnimationSyncState_Monster2Wukong'");
		AnimationSyncStateMonster2MonsterConfig = Load_Internal<BGWDataAsset_AnimationSyncStateConfig>("BGWDataAsset_AnimationSyncStateConfig'/Game/00Main/DataAsset/ASS/DA_AnimationSyncState_Monster2Monster.DA_AnimationSyncState_Monster2Monster'");
		MatLayerFunctionMappingConfigMap.Add(0, Load_Internal<BGWDataAsset_MatLayerFunctionMappingConfig>("BGWDataAsset_MatLayerFunctionMappingConfig'/Game/00Main/DataAsset/DA_MatLayerFunctionMappingConfig_1.DA_MatLayerFunctionMappingConfig_1'"));
		HitAudioPreloadListConfig = Load_Internal<BGWDataAsset_HitAudioPreloadList>("BGWDataAsset_HitAudioPreloadList'/Game/00Main/DataAsset/DA_HitAudioPreloadConfig.DA_HitAudioPreloadConfig'");
		BulletSmartSelectTargetConfig = Load_Internal<BGWDataAsset_BulletSmartSelectTargetConfig>("/Game/00Main/Design/Bullets/PlayerBullets/Wukong/FaBao/BGW_wukong_BulletSmartSelectTarget.BGW_wukong_BulletSmartSelectTarget");
		BattleSCConfigDataAsset = Load_Internal<BGWDataAsset_BattleSCConfig>("BGWDataAsset_BattleSCConfig'/Game/00Main/DataAsset/DA_BattleSCConfig.DA_BattleSCConfig'");
	}

	private void InitGlobalSoundBank()
	{
		UAkAudioEvent akAudioEvent = Load_Internal<UAkAudioEvent>("AkAudioEvent'/Game/00Main/Audio/SFX/System/Loading/EVT_system_loading_begin.EVT_system_loading_begin'");
		UAkAudioEvent akAudioEvent2 = Load_Internal<UAkAudioEvent>("AkAudioEvent'/Game/00Main/Audio/SFX/UI/EVT_ui_bus_mute.EVT_ui_bus_mute'");
		SustainAkReferenceWithinTime(akAudioEvent, -1f);
		SustainAkReferenceWithinTime(akAudioEvent2, -1f);
		BGW_CricketBattleMgr.SeqAkAudioEvent = Load_Internal<UAkAudioEvent>("AkAudioEvent'/Game/00Main/Audio/Music/LinShi/EVT_music_nianhui_seq.EVT_music_nianhui_seq'");
		BGW_CricketBattleMgr.PlayAkAudioEvent = Load_Internal<UAkAudioEvent>("AkAudioEvent'/Game/00Main/Audio/Music/LinShi/EVT_music_nianhui_play.EVT_music_nianhui_play'");
		BGW_CricketBattleMgr.StopAkAudioEvent = Load_Internal<UAkAudioEvent>("AkAudioEvent'/Game/00Main/Audio/Music/LinShi/EVT_music_nianhui_stop.EVT_music_nianhui_stop'");
	}

	private void InitAssetHolder()
	{
		foreach (EPreloadAssetSourceType value2 in Enum.GetValues(typeof(EPreloadAssetSourceType)))
		{
			if (!AssetHolderMap.TryGetValue((int)value2, out var _))
			{
				AssetHolderMap.Add((int)value2, UObject.NewObject<b1.BGW.UAsyncLoadAssetHolder>());
			}
		}
	}

	private b1.BGW.UAsyncLoadAssetHolder GetAssetHolder(EPreloadAssetSourceType AssetSourceType)
	{
		if (!AssetHolderMap.ContainsKey((int)AssetSourceType))
		{
			AssetHolderMap.Add((int)AssetSourceType, UObject.NewObject<b1.BGW.UAsyncLoadAssetHolder>());
		}
		return AssetHolderMap[(int)AssetSourceType];
	}

	private void AddOtherResource2List(int ResID, string ObjPath)
	{
		if (UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			if (value.OtherResourcePathList == null)
			{
				value.OtherResourcePathList = new List<string>();
			}
			if (!value.OtherResourcePathList.Contains(ObjPath))
			{
				value.OtherResourcePathList.Add(ObjPath);
			}
			if (AllResources.TryGetValue(ObjPath, out var value2) && !value2.RelatedResIDList.Contains(ResID))
			{
				value2.RelatedResIDList.Add(ResID);
			}
		}
	}

	public static T RequestSyncLoadObjectInEditor<T>(string ObjPath) where T : UObject
	{
		return null;
	}

	public void RequestAsyncLoadForUIResource<T>(string Path, EAssetPriority priority, Action<int, UObject> AsyncLoadFinishCallBack = null, int CallBackReqID = -1, EUIResourceLoadType UIResourceLoadType = EUIResourceLoadType.NoCache) where T : UObject
	{
		if (PL_Config.IsIgnoreUIResourceAsyncLoad)
		{
			return;
		}
		if (string.IsNullOrEmpty(Path))
		{
			AsyncLoadFinishCallBack?.Invoke(CallBackReqID, null);
			return;
		}
		EPreloadAssetSourceType preloadAssetType = EPreloadAssetSourceType.UIResource_ReleaseInChangeLevel;
		switch (UIResourceLoadType)
		{
		case EUIResourceLoadType.CacheAndReleaseWhenChangeLevel:
			preloadAssetType = EPreloadAssetSourceType.UIResource_ReleaseInChangeLevel;
			break;
		case EUIResourceLoadType.CacheAndReleaseWhenReturnMain:
			preloadAssetType = EPreloadAssetSourceType.UIResource_ReleaseInMain;
			break;
		case EUIResourceLoadType.NoCache:
			preloadAssetType = EPreloadAssetSourceType.UIResource_NoCache;
			break;
		}
		Load_Internal<T>(Path, new PreloadAsyncLoadUserData(preloadAssetType, priority), IsAsyncLoad: true, AsyncLoadFinishCallBack, CallBackReqID);
	}

	public T RequestSyncLoadForUIResource<T>(string Path, EUIResourceLoadType UIResourceLoadType = EUIResourceLoadType.CacheAndReleaseWhenChangeLevel) where T : UObject
	{
		if (string.IsNullOrEmpty(Path))
		{
			return null;
		}
		EPreloadAssetSourceType preloadAssetType = EPreloadAssetSourceType.UIResource_ReleaseInChangeLevel;
		switch (UIResourceLoadType)
		{
		case EUIResourceLoadType.CacheAndReleaseWhenChangeLevel:
			preloadAssetType = EPreloadAssetSourceType.UIResource_ReleaseInChangeLevel;
			break;
		case EUIResourceLoadType.CacheAndReleaseWhenReturnMain:
			preloadAssetType = EPreloadAssetSourceType.UIResource_ReleaseInMain;
			break;
		case EUIResourceLoadType.NoCache:
			preloadAssetType = EPreloadAssetSourceType.UIResource_NoCache;
			break;
		}
		return Load_Internal<T>(Path, new PreloadAsyncLoadUserData(preloadAssetType));
	}

	public void TryRecyclingCachedResourceObjForUI(List<string> PathList)
	{
		foreach (string Path in PathList)
		{
			if (FPackageName.ParseExportTextPath(Path, out var className, out var objectPath))
			{
				if (className.Contains("Blueprint"))
				{
					bool flag = false;
					if (objectPath.EndsWith("_C"))
					{
						if (objectPath.Contains("_C.") && !objectPath.EndsWith("_C_C"))
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						objectPath += "_C";
					}
				}
			}
			else
			{
				objectPath = FPackageName.ExportTextPathToObjectPath(Path);
			}
			if (PreloadAssetHelper.IsPathValid(objectPath, bOutputLog: false) && AllResources.TryGetValue(objectPath, out var value) && CheckIsReleateResourceType(EPreloadAssetSourceType.UIResource_All, EPreloadAssetSourceType.UIResource_End, value.SourceType))
			{
				TryRecyclingCachedResourceObj(Path);
			}
		}
	}

	public T RequestSyncLoadForTamerMonsterClass<T>(string Path) where T : UObject
	{
		if (string.IsNullOrEmpty(Path))
		{
			return null;
		}
		return Load_Internal<T>(Path, new PreloadAsyncLoadUserData(EPreloadAssetSourceType.Other_TamerMonsterClassNoCache));
	}

	public T TryGetCachedResourceObj<T>(string Path, ELoadResourceType ELoadType, EAssetPriority LoadPriority = EAssetPriority.Default, Action<int, UObject> AsyncLoadFinishCallBack = null, int CallBackReqID = -1, int ResID = -1) where T : UObject
	{
		if (string.IsNullOrEmpty(Path))
		{
			AsyncLoadFinishCallBack?.Invoke(CallBackReqID, null);
			return null;
		}
		_ = TryGetCachedResourceObjStatId;
		_ = 0;
		bool isAsyncLoad = ELoadType != ELoadResourceType.SyncLoadAndCache;
		PreloadAsyncLoadUserData inUserData = new PreloadAsyncLoadUserData((ResID <= 0) ? EPreloadAssetSourceType.NoPreload : EPreloadAssetSourceType.MonsterResource_Instances, LoadPriority, ResID);
		T val = Load_Internal<T>(Path, inUserData, isAsyncLoad, AsyncLoadFinishCallBack, CallBackReqID);
		_ = TryGetCachedResourceObjStatId;
		_ = 0;
		return (T)val;
	}

	public void TryRecyclingCachedResourceObj(string Path)
	{
		if (string.IsNullOrEmpty(Path))
		{
			return;
		}
		if (FPackageName.ParseExportTextPath(Path, out var className, out var objectPath))
		{
			if (className.Contains("Blueprint"))
			{
				bool flag = false;
				if (objectPath.EndsWith("_C"))
				{
					if (objectPath.Contains("_C.") && !objectPath.EndsWith("_C_C"))
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					objectPath += "_C";
				}
			}
		}
		else
		{
			objectPath = FPackageName.ExportTextPathToObjectPath(Path);
		}
		if (PreloadAssetHelper.IsPathValid(objectPath, bOutputLog: false) && AllResources.TryGetValue(objectPath, out var value))
		{
			switch (value.State)
			{
			case CacheState.Loading:
				_ = value.bIsTriggerUnLoad;
				value.bIsTriggerUnLoad = true;
				break;
			case CacheState.Cached:
				RemoveResource(objectPath);
				break;
			case CacheState.FailLoad:
				break;
			}
		}
	}

	public void SustainAkReferenceWithinTime(UAkAudioEvent AkAudioEvent, float Time = 0f)
	{
		if (!(AkAudioEvent == null))
		{
			float value = ((Time == 0f) ? AkAudioEvent.MinimumDuration : Time);
			TStrongObjectPtr_NoCollect<UAkAudioEvent> key = new TStrongObjectPtr_NoCollect<UAkAudioEvent>(AkAudioEvent);
			if (SustainAkReference.ContainsKey(key))
			{
				SustainAkReference[key] = value;
			}
			else
			{
				SustainAkReference.Add(key, value);
			}
		}
	}

	public bool IsPreloading()
	{
		return ResourceCounter.IsPreloading();
	}

	public bool IsAssetAllLoadFinishForLoadingScreen()
	{
		return ResourceCounter.IsAssetAllLoadFinishForLoadingScreen();
	}

	private void AddBeAttackedConfig2Dic(int ResID, string UBAConfigObjPath, BGWDataAsset_UnitBeAttackedConfig UBAConfig)
	{
		if (!UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			return;
		}
		_ = value.bIsPlayer;
		if (!(UBAConfig != null))
		{
			return;
		}
		if (!value.BeAttackedConfigList.Contains(UBAConfigObjPath))
		{
			value.BeAttackedConfigList.Add(UBAConfigObjPath);
		}
		foreach (UAnimMontage normalStiffAM in UBAConfig.NormalStiffAMList)
		{
			if (!(normalStiffAM != null))
			{
				continue;
			}
			string text = normalStiffAM.GetName();
			string[] array = text.Split('_');
			if (array.Length != 0)
			{
				string text2 = array[^1];
				if (int.TryParse(text2, out var _))
				{
					text = text.Substring(0, text.Length - text2.Length - 1);
				}
			}
			if (value.BehitNormalStiffAMDic.TryGetValue(text, out var _))
			{
				value.BehitNormalStiffAMDic[text].Add(new TStrongObjectPtr<UAnimMontage>(normalStiffAM));
				continue;
			}
			value.BehitNormalStiffAMDic.Add(text, new List<TStrongObjectPtr<UAnimMontage>>
			{
				new TStrongObjectPtr<UAnimMontage>(normalStiffAM)
			});
		}
	}

	private void AddDeathDispConfig2Dic(int ResID, string UDDConfigObjPath, BGWDataAsset_UnitDeathDispConfig UDDConfig)
	{
		if (!UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			return;
		}
		_ = value.bIsPlayer;
		if (!(UDDConfig != null))
		{
			return;
		}
		if (!value.DeathDispConfigList.Contains(UDDConfigObjPath))
		{
			value.DeathDispConfigList.Add(UDDConfigObjPath);
		}
		foreach (UAnimMontage normalDeadAM in UDDConfig.NormalDeadAMList)
		{
			if (!(normalDeadAM != null))
			{
				continue;
			}
			string text = normalDeadAM.GetName();
			string[] array = text.Split('_');
			if (array.Length != 0)
			{
				string text2 = array[^1];
				if (int.TryParse(text2, out var _))
				{
					text = text.Substring(0, text.Length - text2.Length - 1);
				}
			}
			if (value.DeathDispAMDic.TryGetValue(text, out var _))
			{
				value.DeathDispAMDic[text].Add(new TStrongObjectPtr<UAnimMontage>(normalDeadAM));
				continue;
			}
			value.DeathDispAMDic.Add(text, new List<TStrongObjectPtr<UAnimMontage>>
			{
				new TStrongObjectPtr<UAnimMontage>(normalDeadAM)
			});
		}
	}

	public BGWDataAsset_UnitBeAttackedConfig GetUBAConfig(int ResID, int OverrideID, string FinalGUID, string UnitBeAttackedConfigPath)
	{
		BGWDataAsset_UnitBeAttackedConfig result = null;
		if (string.IsNullOrEmpty(UnitBeAttackedConfigPath))
		{
			return result;
		}
		if (!UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			OnPreloadMonsterRes(ResID, OverrideID, FinalGUID, EUnitPreloadLevel.Top);
		}
		if (value != null)
		{
			bool flag = true;
			List<string> beAttackedConfigList = value.BeAttackedConfigList;
			string text = FPackageName.ExportTextPathToObjectPath(UnitBeAttackedConfigPath);
			if (beAttackedConfigList.Contains(text) && AllResources.TryGetValue(text, out var value2))
			{
				if (value2.State == CacheState.Cached)
				{
					flag = false;
					result = value2.Obj as BGWDataAsset_UnitBeAttackedConfig;
				}
				else if (value2.State != CacheState.Loading)
				{
					flag = false;
				}
			}
			if (flag)
			{
				EPreloadAssetSourceType preloadAssetType = (value.bIsPlayer ? EPreloadAssetSourceType.PlayerResource_Instances : EPreloadAssetSourceType.MonsterResource_Instances);
				result = Load_Internal<BGWDataAsset_UnitBeAttackedConfig>(text, new PreloadAsyncLoadUserData(preloadAssetType));
			}
		}
		return result;
	}

	public BGWDataAsset_UnitDeathDispConfig GetUDDConfig(int ResID, int OverrideID, string FinalGUID, string DeathDispConfigPath)
	{
		BGWDataAsset_UnitDeathDispConfig result = null;
		if (string.IsNullOrEmpty(DeathDispConfigPath))
		{
			return result;
		}
		if (!UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			OnPreloadMonsterRes(ResID, OverrideID, FinalGUID, EUnitPreloadLevel.Top);
			UnitResIDAssets.TryGetValue(ResID, out value);
		}
		if (value != null)
		{
			bool flag = true;
			List<string> deathDispConfigList = value.DeathDispConfigList;
			string text = FPackageName.ExportTextPathToObjectPath(DeathDispConfigPath);
			if (deathDispConfigList.Contains(text) && AllResources.TryGetValue(text, out var value2))
			{
				if (value2.State == CacheState.Cached)
				{
					flag = false;
					result = value2.Obj as BGWDataAsset_UnitDeathDispConfig;
				}
				else if (value2.State != CacheState.Loading)
				{
					flag = false;
				}
			}
			if (flag)
			{
				EPreloadAssetSourceType preloadAssetType = (value.bIsPlayer ? EPreloadAssetSourceType.PlayerResource_Instances : EPreloadAssetSourceType.MonsterResource_Instances);
				result = Load_Internal<BGWDataAsset_UnitDeathDispConfig>(text, new PreloadAsyncLoadUserData(preloadAssetType));
			}
		}
		return result;
	}

	public List<UAnimMontage> GetRandomNormalStiffAM(int ResID, string NormalStiffMontageName)
	{
		List<UAnimMontage> list = new List<UAnimMontage>();
		if (UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			Dictionary<string, List<TStrongObjectPtr<UAnimMontage>>> behitNormalStiffAMDic = value.BehitNormalStiffAMDic;
			if (behitNormalStiffAMDic != null && behitNormalStiffAMDic.TryGetValue(NormalStiffMontageName, out var value2) && value2 != null)
			{
				foreach (TStrongObjectPtr<UAnimMontage> item in value2)
				{
					if (item != null)
					{
						list.Add(item.Get());
					}
				}
			}
		}
		return list;
	}

	public List<UAnimMontage> GetRandomDeathDispAM(int ResID, string DeathDispMontageName)
	{
		List<UAnimMontage> list = new List<UAnimMontage>();
		if (UnitResIDAssets.TryGetValue(ResID, out var value))
		{
			Dictionary<string, List<TStrongObjectPtr<UAnimMontage>>> deathDispAMDic = value.DeathDispAMDic;
			if (deathDispAMDic != null && deathDispAMDic.TryGetValue(DeathDispMontageName, out var value2) && value2 != null)
			{
				foreach (TStrongObjectPtr<UAnimMontage> item in value2)
				{
					if (item != null)
					{
						list.Add(item.Get());
					}
				}
			}
		}
		return list;
	}

	public int PreloadCountLeft()
	{
		return ResourceCounter.GetAllResourceCounter();
	}

	public void PrintNoLoadedObjInfoList()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("============================================================");
		stringBuilder.AppendLine("====================还未加载出来的资源列表：====================");
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		stringBuilder.AppendLine("已缓存但未成功加载资源：");
		foreach (KeyValuePair<string, ResourceInfo> allResource in AllResources)
		{
			string key = allResource.Key;
			ResourceInfo value = allResource.Value;
			if (value.Obj == null || value.State != CacheState.Cached)
			{
				num++;
				stringBuilder.AppendLine($"资源路径：{key}，资源加载优先级：{value.LoadPriority}, 当前资源状态：{value.State}");
			}
		}
		stringBuilder.AppendLine("【绑定ResID】单位受击&死亡资源：");
		foreach (KeyValuePair<int, UnitResIDAssetInfo> unitResIDAsset in UnitResIDAssets)
		{
			int key2 = unitResIDAsset.Key;
			UnitResIDAssetInfo value2 = unitResIDAsset.Value;
			stringBuilder.AppendLine($"单位ResID是：{key2}");
			stringBuilder.AppendLine("===已缓存但未加载出来的受击配置（UBAC）路径：===");
			foreach (string beAttackedConfig in value2.BeAttackedConfigList)
			{
				if (AllResources.TryGetValue(beAttackedConfig, out var value3) && (value3.Obj == null || value3.State != CacheState.Cached))
				{
					num2++;
					stringBuilder.AppendLine($"{beAttackedConfig}, 资源状态：{value3.State}");
				}
			}
			stringBuilder.AppendLine("===已缓存但未加载出来的死亡配置（UDDC）路径：===");
			foreach (string deathDispConfig in value2.DeathDispConfigList)
			{
				if (AllResources.TryGetValue(deathDispConfig, out var value4) && (value4.Obj == null || value4.State != CacheState.Cached))
				{
					num3++;
					stringBuilder.AppendLine($"{deathDispConfig}, 资源状态：{value4.State}");
				}
			}
		}
		stringBuilder.AppendLine("计数器里资源：");
		foreach (KeyValuePair<EPreloadAssetSourceType, PreloadingInfo> item in ResourceCounter.ResourceDict)
		{
			stringBuilder.AppendLine($"资源类型：{item.Key}");
			foreach (string path in item.Value.PathList)
			{
				stringBuilder.AppendLine("===资源路径：" + path + "===");
			}
		}
		stringBuilder.AppendLine("==============================结束==============================");
	}

	public void PrintAbnormalResourcePathList()
	{
		foreach (string abnormalResourcePath in AbnormalResourcePathList)
		{
			_ = abnormalResourcePath;
		}
	}

	[Conditional("DEBUG")]
	private void LogDbg(string DbgStr, bool ShowOnScreen = false)
	{
	}

	[Conditional("DEBUG")]
	private void LogDbgCounter(string DbgStr, bool ShowOnScreen = false)
	{
	}

	public void GetPreloadNumInfo(out int ResourceNum_Total, out int ResourceNum_Loading, out int ResourceNum_Failed, out int ResourceNum_Success, out int ResourceNum_Unloading)
	{
		ResourceNum_Total = 0;
		ResourceNum_Loading = 0;
		ResourceNum_Failed = 0;
		ResourceNum_Success = 0;
		ResourceNum_Unloading = 0;
		ResourceNum_Total = AllResources.Count;
		foreach (KeyValuePair<string, ResourceInfo> allResource in AllResources)
		{
			switch (allResource.Value.State)
			{
			case CacheState.FailLoad:
				ResourceNum_Failed++;
				break;
			case CacheState.Loading:
				ResourceNum_Loading++;
				break;
			case CacheState.Cached:
				ResourceNum_Success++;
				break;
			}
			if (allResource.Value.bIsTriggerUnLoad)
			{
				ResourceNum_Unloading++;
			}
		}
	}

	public Dictionary<EPreloadAssetSourceType, int> GetPreloadResourceInfoDict()
	{
		Dictionary<EPreloadAssetSourceType, int> dictionary = new Dictionary<EPreloadAssetSourceType, int>();
		foreach (KeyValuePair<string, ResourceInfo> allResource in AllResources)
		{
			EPreloadAssetSourceType sourceType = allResource.Value.SourceType;
			if (!dictionary.TryGetValue(sourceType, out var value))
			{
				dictionary.Add(sourceType, 1);
			}
			else
			{
				value = (dictionary[sourceType] = value + 1);
			}
		}
		return dictionary;
	}

	public List<FNetStruct_PreloadResourceDetailInfo> GetPreloadResourceDetailInfoList()
	{
		List<FNetStruct_PreloadResourceDetailInfo> list = new List<FNetStruct_PreloadResourceDetailInfo>();
		if (PreloadResourceDetailInfoTypeList.Count > 0)
		{
			foreach (KeyValuePair<string, ResourceInfo> allResource in AllResources)
			{
				ResourceInfo value = allResource.Value;
				if (PreloadResourceDetailInfoTypeList.Contains(value.SourceType))
				{
					list.Add(new FNetStruct_PreloadResourceDetailInfo
					{
						ResourcePath = allResource.Key,
						ResourceType = value.SourceType.ToString(),
						AssetPriority = value.LoadPriority.ToString(),
						RelationResIDs = "先忽略"
					});
				}
			}
		}
		return list;
	}

	public void SetPreloadResourceDetailInfoType(List<string> TypeList)
	{
		PreloadResourceDetailInfoTypeList.Clear();
		string[] names = Enum.GetNames(typeof(EPreloadAssetSourceType));
		foreach (string text in names)
		{
			if (TypeList.Contains(text))
			{
				EPreloadAssetSourceType item = (EPreloadAssetSourceType)Enum.Parse(typeof(EPreloadAssetSourceType), text);
				PreloadResourceDetailInfoTypeList.Add(item);
			}
		}
	}

	public Dictionary<int, (int, int)> GetUnitPreloadInfoDict()
	{
		Dictionary<int, (int, int)> dictionary = new Dictionary<int, (int, int)>();
		foreach (KeyValuePair<int, UnitResIDAssetInfo> unitResIDAsset in UnitResIDAssets)
		{
			int key = unitResIDAsset.Key;
			UnitResIDAssetInfo value = unitResIDAsset.Value;
			int count = value.BeAttackedConfigList.Count;
			int count2 = value.DeathDispConfigList.Count;
			int count3 = value.OtherResourcePathList.Count;
			int num = 0;
			foreach (KeyValuePair<string, List<TStrongObjectPtr<UAnimMontage>>> item2 in value.BehitNormalStiffAMDic)
			{
				num += item2.Value.Count;
			}
			int num2 = 0;
			foreach (KeyValuePair<string, List<TStrongObjectPtr<UAnimMontage>>> item3 in value.DeathDispAMDic)
			{
				num2 += item3.Value.Count;
			}
			int item = count + count2 + count3 + num + num2;
			dictionary[key] = (value.GuidList.Count, item);
		}
		return dictionary;
	}

	static BGW_PreloadAssetMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_PreloadAssetMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_PreloadAssetMgr));
		RELEASE_DURATION = 5f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_PreloadAssetMgr");
		BattleSCConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleSCConfigDataAsset");
		BattleSCConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleSCConfigDataAsset", Classes.FObjectProperty);
		HatredConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HatredConfigDataAsset");
		HatredConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HatredConfigDataAsset", Classes.FObjectProperty);
		UIConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UIConfigDataAsset");
		UIConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UIConfigDataAsset", Classes.FObjectProperty);
		MapConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapConfigDataAsset");
		MapConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapConfigDataAsset", Classes.FObjectProperty);
		FallDyingConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FallDyingConfigDataAsset");
		FallDyingConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FallDyingConfigDataAsset", Classes.FObjectProperty);
		Demo820ConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Demo820ConfigDataAsset");
		Demo820ConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Demo820ConfigDataAsset", Classes.FObjectProperty);
		CricketBattleDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketBattleDataAsset");
		CricketBattleDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketBattleDataAsset", Classes.FObjectProperty);
		EquipPreviewConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EquipPreviewConfigDataAsset");
		EquipPreviewConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EquipPreviewConfigDataAsset", Classes.FObjectProperty);
		TransPreviewConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TransPreviewConfigDataAsset");
		TransPreviewConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TransPreviewConfigDataAsset", Classes.FObjectProperty);
		BHLItemTmpDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BHLItemTmpDataAsset");
		BHLItemTmpDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BHLItemTmpDataAsset", Classes.FObjectProperty);
		MPCStickProg_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPCStickProg");
		MPCStickProg_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPCStickProg", Classes.FObjectProperty);
		MonsterManualConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MonsterManualConfigDataAsset");
		MonsterManualConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MonsterManualConfigDataAsset", Classes.FObjectProperty);
		ObservationModeConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObservationModeConfig");
		ObservationModeConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObservationModeConfig", Classes.FObjectProperty);
		ABSPosToUVConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ABSPosToUVConfig");
		ABSPosToUVConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ABSPosToUVConfig", Classes.FObjectProperty);
		DamageNumConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DamageNumConfig");
		DamageNumConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DamageNumConfig", Classes.FObjectProperty);
		GameConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GameConfig");
		GameConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GameConfig", Classes.FObjectProperty);
		LevelSequenceConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LevelSequenceConfig");
		LevelSequenceConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LevelSequenceConfig", Classes.FObjectProperty);
		AISkillScoreConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AISkillScoreConfigDataAsset");
		AISkillScoreConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AISkillScoreConfigDataAsset", Classes.FObjectProperty);
		AIHatredConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AIHatredConfigDataAsset");
		AIHatredConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AIHatredConfigDataAsset", Classes.FObjectProperty);
		CoinDropFXNumConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CoinDropFXNumConfig");
		CoinDropFXNumConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CoinDropFXNumConfig", Classes.FObjectProperty);
		DA_B1_DispLibGameDB_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DA_B1_DispLibGameDB");
		DA_B1_DispLibGameDB_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DA_B1_DispLibGameDB", Classes.FObjectProperty);
		DefaultLocalFluid2DConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DefaultLocalFluid2DConfig");
		DefaultLocalFluid2DConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DefaultLocalFluid2DConfig", Classes.FObjectProperty);
		DestructibleImpulseConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructibleImpulseConfig");
		DestructibleImpulseConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructibleImpulseConfig", Classes.FObjectProperty);
		UnitDynamicObstacle_DefaultDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UnitDynamicObstacle_DefaultDBC");
		UnitDynamicObstacle_DefaultDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UnitDynamicObstacle_DefaultDBC", Classes.FObjectProperty);
		BattleFieldPerformanceOptConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleFieldPerformanceOptConfig");
		BattleFieldPerformanceOptConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleFieldPerformanceOptConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MatLayerFunctionMappingConfigMap_PropertyAddress, unrealStruct, "MatLayerFunctionMappingConfigMap");
		MatLayerFunctionMappingConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MatLayerFunctionMappingConfigMap");
		MatLayerFunctionMappingConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MatLayerFunctionMappingConfigMap", Classes.FMapProperty);
		EnvironmentMaskGlobalConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnvironmentMaskGlobalConfig");
		EnvironmentMaskGlobalConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnvironmentMaskGlobalConfig", Classes.FObjectProperty);
		AnimationSyncStateMonster2WukongConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimationSyncStateMonster2WukongConfig");
		AnimationSyncStateMonster2WukongConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimationSyncStateMonster2WukongConfig", Classes.FObjectProperty);
		AnimationSyncStateMonster2MonsterConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimationSyncStateMonster2MonsterConfig");
		AnimationSyncStateMonster2MonsterConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimationSyncStateMonster2MonsterConfig", Classes.FObjectProperty);
		FrozenAccMatCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FrozenAccMatCurve");
		FrozenAccMatCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FrozenAccMatCurve", Classes.FObjectProperty);
		BulletSmartSelectTargetConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BulletSmartSelectTargetConfig");
		BulletSmartSelectTargetConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BulletSmartSelectTargetConfig", Classes.FObjectProperty);
		_CloudMoveConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "_CloudMoveConfig");
		_CloudMoveConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "_CloudMoveConfig", Classes.FObjectProperty);
		LevelInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LevelInfo");
		LevelInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LevelInfo", Classes.FObjectProperty);
		HitAudioPreloadListConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitAudioPreloadListConfig");
		HitAudioPreloadListConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitAudioPreloadListConfig", Classes.FObjectProperty);
		RebirthGeoInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthGeoInfo");
		RebirthGeoInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthGeoInfo", Classes.FObjectProperty);
		TROConfig_Small_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TROConfig_Small");
		TROConfig_Small_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TROConfig_Small", Classes.FObjectProperty);
		TROConfig_Medium_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TROConfig_Medium");
		TROConfig_Medium_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TROConfig_Medium", Classes.FObjectProperty);
		TROConfig_MediumBig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TROConfig_MediumBig");
		TROConfig_MediumBig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TROConfig_MediumBig", Classes.FObjectProperty);
		TROConfig_Big_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TROConfig_Big");
		TROConfig_Big_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TROConfig_Big", Classes.FObjectProperty);
		TROConfig_Huge_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TROConfig_Huge");
		TROConfig_Huge_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TROConfig_Huge", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AssetHolderMap_PropertyAddress, unrealStruct, "AssetHolderMap");
		AssetHolderMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AssetHolderMap");
		AssetHolderMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AssetHolderMap", Classes.FMapProperty);
	}
}
