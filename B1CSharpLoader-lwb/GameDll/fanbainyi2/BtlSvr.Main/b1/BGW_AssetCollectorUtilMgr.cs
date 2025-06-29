using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using b1.BGW;
using b1.ECS;
using GSDispLib;
using ILRuntime.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_AssetCollectorUtilMgr")]
public class BGW_AssetCollectorUtilMgr : GameInstanceSystemBaseUObj
{
	private enum EAssetCollectType
	{
		ByLevel,
		Player
	}

	private enum EAssetType
	{
		Niagara,
		PreloadedAsset
	}

	private static string OutputFolder;

	private static string PreloadedAssetFolder;

	private static string NiagaraAssetFolder;

	private bool EnableAssetCollection;

	private IBIC_LevelData LevelData;

	private Dictionary<int, List<string>> NiagaraAssets = new Dictionary<int, List<string>>();

	private Dictionary<int, HashSet<string>> PreloadedAssets = new Dictionary<int, HashSet<string>>();

	private Dictionary<int, HashSet<string>> SearchedReferenceAssets = new Dictionary<int, HashSet<string>>();

	private static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult_IsValid;

	private static IntPtr CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress;

	private static int CollectNiagaraAssetsFromPreloadAssetCollectionResult_ParamsSize;

	private static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_IsValid;

	private static int CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_Offset;

	private static FFieldAddress CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_PropertyAddress;

	private static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_IsValid;

	private static int CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_Offset;

	private static FFieldAddress CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_PropertyAddress;

	public override void OnInit()
	{
		base.OnInit();
	}

	public override void OnAttach()
	{
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		EnableAssetCollection = FPaths.FileExists(OutputFolder + "\\EnableAssetCollection");
		if (EnableAssetCollection)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			if (bGW_EventCollection != null)
			{
				bGW_EventCollection.Evt_BGW_PlayerRequestPreload = (BGW_EventCollection.Del_BGW_PlayerRequestPreload)Delegate.Combine(bGW_EventCollection.Evt_BGW_PlayerRequestPreload, new BGW_EventCollection.Del_BGW_PlayerRequestPreload(OnPreloadPlayerRes));
			}
			LoadExistCSV(NiagaraAssetFolder, NiagaraAssets);
			LoadExportedLevelNiagaraAssets();
		}
	}

	private void OnPreloadPlayerRes(Entity PlayerEntity, bool IsOriginPlayer)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_BGW_PlayerRequestAllDescByAbilityPreload(PlayerEntity);
		}
	}

	public static BGW_AssetCollectorUtilMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_AssetCollectorUtilMgr>(Context);
	}

	public override void OnShutdown()
	{
		if (EnableAssetCollection)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			if (bGW_EventCollection != null)
			{
				bGW_EventCollection.Evt_BGW_PlayerRequestPreload = (BGW_EventCollection.Del_BGW_PlayerRequestPreload)Delegate.Remove(bGW_EventCollection.Evt_BGW_PlayerRequestPreload, new BGW_EventCollection.Del_BGW_PlayerRequestPreload(OnPreloadPlayerRes));
			}
			OutputCSV();
		}
		base.OnShutdown();
	}

	private static void LoadExistCSV<T>(string Folder, Dictionary<int, T> LoadDict) where T : ICollection<string>, new()
	{
		string[] names = Enum.GetNames(typeof(EAssetCollectType));
		string[] names2 = Enum.GetNames(typeof(EAssetType));
		string text = string.Join("|", names);
		string text2 = string.Join("|", names2);
		Regex regex = new Regex("^(-?\\d+)_(" + text2 + ")_(" + text + ")$");
		Directory.CreateDirectory(Folder);
		string[] files = Directory.GetFiles(Folder, "*.csv");
		foreach (string path in files)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
			Match match = regex.Match(fileNameWithoutExtension);
			if (!match.Success)
			{
				continue;
			}
			int key = match.Groups[1].Value.ToInt32();
			T value = new T();
			StreamReader streamReader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
			for (string text3 = streamReader.ReadLine(); text3 != null; text3 = streamReader.ReadLine())
			{
				if (!value.Contains(text3))
				{
					value.Add(text3);
				}
			}
			LoadDict.Add(key, value);
		}
	}

	private void LoadExportedLevelNiagaraAssets()
	{
		foreach (KeyValuePair<int, List<string>> exportedLevelNiagaraAsset in BGUFuncLibResCS.GetExportedLevelNiagaraAssets())
		{
			if (NiagaraAssets.TryGetValue(exportedLevelNiagaraAsset.Key, out var value))
			{
				NiagaraAssets[exportedLevelNiagaraAsset.Key] = value.Union(exportedLevelNiagaraAsset.Value).ToList();
			}
			else
			{
				NiagaraAssets[exportedLevelNiagaraAsset.Key] = exportedLevelNiagaraAsset.Value;
			}
		}
	}

	private void OutputCSV()
	{
		if (EnableAssetCollection)
		{
			OutputCSV(EAssetType.Niagara, NiagaraAssets, NiagaraAssetFolder);
			OutputCSV(EAssetType.PreloadedAsset, PreloadedAssets, PreloadedAssetFolder);
		}
	}

	private static void OutputCSV<T>(EAssetType AssetType, Dictionary<int, T> OutputDict, string Folder) where T : IEnumerable<string>
	{
		if (!Directory.Exists(Folder))
		{
			Directory.CreateDirectory(Folder);
		}
		foreach (KeyValuePair<int, T> item in OutputDict)
		{
			string text = GetFileName(item.Key, AssetType, (item.Key == -1) ? EAssetCollectType.Player : EAssetCollectType.ByLevel) ?? "";
			FileStream fileStream = new FileStream(Folder + "\\" + text, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			foreach (string item2 in item.Value)
			{
				streamWriter.WriteLine(item2);
			}
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
		}
	}

	private static string GetFileName(int uid, EAssetType AssetType, EAssetCollectType AssetCollectType)
	{
		return $"{uid}_{AssetType}_{AssetCollectType}.csv";
	}

	public void OnAssetLoaded(UObject AssetObject, EPreloadAssetSourceType SourceType)
	{
		if (EnableAssetCollection && !(AssetObject == null))
		{
			EAssetCollectType assetCollectType = EAssetCollectType.ByLevel;
			if (SourceType >= EPreloadAssetSourceType.PlayerResource_All && SourceType <= EPreloadAssetSourceType.PlayerResource_End)
			{
				assetCollectType = EAssetCollectType.Player;
			}
			int collectID = GetCollectID(assetCollectType);
			DBCHandler(AssetObject, collectID);
			TransEffectHandler(AssetObject, collectID);
			AnimAssetHandler(AssetObject, collectID);
			TryGetNiagaraRef(SearchedReferenceAssets, NiagaraAssets, AssetObject, collectID);
			CollectPreloadedAsset(AssetObject, collectID);
		}
	}

	private int GetCollectID(EAssetCollectType AssetCollectType)
	{
		int result = LevelData.CurrentLevelID;
		if (AssetCollectType == EAssetCollectType.Player)
		{
			result = -1;
		}
		return result;
	}

	private void CollectNiagaraAssetPath(string Path, int CollectID)
	{
		CollectPath(NiagaraAssets, CollectID, Path);
	}

	private void CollectPreloadedAsset(UObject LoadedAsset, int CollectID)
	{
		if (!(LoadedAsset == null))
		{
			CollectPath(PreloadedAssets, CollectID, LoadedAsset.PathName);
		}
	}

	private static bool CollectPath<T>(Dictionary<int, T> Dict, int CollectID, string Path) where T : ICollection<string>, new()
	{
		if (Dict.TryGetValue(CollectID, out var value))
		{
			if (!value.Contains(Path))
			{
				value.Add(Path);
				return true;
			}
			return false;
		}
		Dict.Add(CollectID, new T { Path });
		return true;
	}

	private static void TryGetNiagaraRef<T1, T2>(Dictionary<int, T1> CachedSearchedReferenceAssets, Dictionary<int, T2> NiagaraAssetCollection, UObject AssetObject, int CollectID) where T1 : ICollection<string>, new() where T2 : ICollection<string>, new()
	{
		UAssetDataArray assetDataFromPackageObj = UGSE_AssetUtilFuncLib.GetAssetDataFromPackageObj(new List<UObject> { AssetObject });
		assetDataFromPackageObj = UGSE_AssetUtilFuncLib.GetDependenciesAssetsFromAssets(assetDataFromPackageObj);
		int count = assetDataFromPackageObj.AssetDataArr.Count;
		for (int i = 0; i < count; i++)
		{
			FAssetData fAssetData = assetDataFromPackageObj.AssetDataArr[i];
			string text = fAssetData.ObjectPath.ToString();
			if (!CollectPath(CachedSearchedReferenceAssets, CollectID, text))
			{
				continue;
			}
			UClass uClass = UClass.GetClass(fAssetData.AssetClass.ToString());
			if (uClass == UClass.GetClass<UNiagaraSystem>())
			{
				CollectPath(NiagaraAssetCollection, CollectID, text);
			}
			else if (uClass != UClass.GetClass<UWorld>())
			{
				UObject uObject = UObject.LoadObject<UObject>(null, text);
				if (uObject != null)
				{
					TryGetNiagaraRef(CachedSearchedReferenceAssets, NiagaraAssetCollection, uObject, CollectID);
				}
			}
		}
	}

	private void DBCHandler(UObject AssetObject, int CollectID)
	{
		BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = AssetObject as BUC_DispLibDispBaseConfigDataAsset;
		if (bUC_DispLibDispBaseConfigDataAsset == null)
		{
			return;
		}
		foreach (BUC_DispLibDBC_PlayNiagara item in bUC_DispLibDispBaseConfigDataAsset.PlayNiagara)
		{
			if (item.Template != null)
			{
				CollectNiagaraAssetPath(item.Template.PathName, CollectID);
			}
		}
		foreach (BUC_DispLibDBC_PlayAdvanceNiagara item2 in bUC_DispLibDispBaseConfigDataAsset.PlayAdvanceNiagara)
		{
			if (item2.Template != null)
			{
				CollectNiagaraAssetPath(item2.Template.PathName, CollectID);
			}
		}
	}

	private void TransEffectHandler(UObject AssetObject, int CollectID)
	{
		BGWDataAsset_TransEffectSetting bGWDataAsset_TransEffectSetting = AssetObject as BGWDataAsset_TransEffectSetting;
		if (!(bGWDataAsset_TransEffectSetting == null) && bGWDataAsset_TransEffectSetting.TransEffect != null)
		{
			CollectNiagaraAssetPath(bGWDataAsset_TransEffectSetting.TransEffect.PathName, CollectID);
		}
	}

	private void AnimAssetHandler(UObject AssetObject, int CollectID)
	{
		if (AssetObject == null)
		{
			return;
		}
		Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>> NotifySoftPath = new Dictionary<BAN_GSBase, HashSet<FSoftObjectPath>>();
		Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>> NotifyStateSoftPath = new Dictionary<BANS_GSBase, HashSet<FSoftObjectPath>>();
		if (AssetObject.IsA<UAnimSequenceBase>())
		{
			BGUFuncLibAnim.BGUGetOneAnimNotifySoftPathSet(AssetObject as UAnimSequenceBase, ref NotifySoftPath, ref NotifyStateSoftPath);
		}
		else
		{
			if (!(AssetObject is b1.IBGWDataAssetHasAnimationReferences iBGWDataAssetHasAnimationReferences))
			{
				return;
			}
			iBGWDataAssetHasAnimationReferences.GetAnimationReferences(out var AnimMontages);
			BGUFuncLibAnim.BGUGetAnimsNotifySoftPathSet(in AnimMontages, ref NotifySoftPath, ref NotifyStateSoftPath);
		}
		foreach (KeyValuePair<BAN_GSBase, HashSet<FSoftObjectPath>> item in NotifySoftPath)
		{
			if (item.Key is BAN_GSPlayNiagaraFX bAN_GSPlayNiagaraFX)
			{
				CollectNiagaraAssetPath(bAN_GSPlayNiagaraFX.template.Path, CollectID);
			}
		}
		foreach (KeyValuePair<BANS_GSBase, HashSet<FSoftObjectPath>> item2 in NotifyStateSoftPath)
		{
			if (item2.Key is GSDispLib.BANS_GSTimedPlayNiagaraFX bANS_GSTimedPlayNiagaraFX)
			{
				CollectNiagaraAssetPath(bANS_GSTimedPlayNiagaraFX.template.Path, CollectID);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGW_AssetCollectorUtilMgr:CollectNiagaraAssetsFromPreloadAssetCollectionResult")]
	public static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult(out string OutputInfo)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (!Directory.Exists(PreloadedAssetFolder))
		{
			OutputInfo = "Preload收集信息输出目录不存在：" + PreloadedAssetFolder;
			return false;
		}
		Dictionary<int, HashSet<string>> cachedSearchedReferenceAssets = new Dictionary<int, HashSet<string>>();
		Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
		Dictionary<int, List<string>> dictionary2 = new Dictionary<int, List<string>>();
		Dictionary<int, List<string>> dictionary3 = new Dictionary<int, List<string>>();
		LoadExistCSV(PreloadedAssetFolder, dictionary);
		LoadExistCSV(NiagaraAssetFolder, dictionary3);
		foreach (KeyValuePair<int, List<string>> item in dictionary)
		{
			int key = item.Key;
			foreach (string item2 in item.Value)
			{
				UObject uObject = UObject.LoadObject<UObject>(null, item2);
				if (uObject != null)
				{
					TryGetNiagaraRef(cachedSearchedReferenceAssets, dictionary3, uObject, key);
				}
				else
				{
					CollectPath(dictionary2, key, item2);
				}
			}
		}
		OutputCSV(EAssetType.Niagara, dictionary3, NiagaraAssetFolder);
		stringBuilder.Append("成功获取Preload列表中的Niagara引用信息！");
		if (dictionary2.Count > 0)
		{
			stringBuilder.AppendLine("存在Preload收集列表中无法查找到的资源：");
			foreach (KeyValuePair<int, List<string>> item3 in dictionary2)
			{
				int key2 = item3.Key;
				stringBuilder.AppendLine($"    ID: {key2}");
				foreach (string item4 in item3.Value)
				{
					stringBuilder.AppendLine("        " + item4);
				}
			}
			OutputInfo = stringBuilder.ToString();
			return false;
		}
		OutputInfo = stringBuilder.ToString();
		return true;
	}

	static BGW_AssetCollectorUtilMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_AssetCollectorUtilMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_AssetCollectorUtilMgr));
		OutputFolder = FPaths.ProjectDir + "\\Saved\\AssetCollection";
		PreloadedAssetFolder = OutputFolder + $"\\{EAssetType.PreloadedAsset}";
		NiagaraAssetFolder = OutputFolder;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_AssetCollectorUtilMgr:CollectNiagaraAssetsFromPreloadAssetCollectionResult")]
	private static void CollectNiagaraAssetsFromPreloadAssetCollectionResult__Invoker(IntPtr buffer, IntPtr obj)
	{
		string OutputInfo;
		bool value = CollectNiagaraAssetsFromPreloadAssetCollectionResult(out OutputInfo);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_Offset), 0, CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_Offset), OutputInfo);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_AssetCollectorUtilMgr");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CollectNiagaraAssetsFromPreloadAssetCollectionResult");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_ParamsSize = NativeReflection.GetFunctionParamsSize(CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_PropertyAddress, CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress, "OutputInfo");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_Offset = NativeReflection.GetPropertyOffset(CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress, "OutputInfo");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_IsValid = NativeReflection.ValidatePropertyClass(CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress, "OutputInfo", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_PropertyAddress, CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress, "ReturnValue");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress, "ReturnValue");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_IsValid = CollectNiagaraAssetsFromPreloadAssetCollectionResult_FunctionAddress != IntPtr.Zero && CollectNiagaraAssetsFromPreloadAssetCollectionResult_OutputInfo_IsValid && CollectNiagaraAssetsFromPreloadAssetCollectionResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_AssetCollectorUtilMgr:CollectNiagaraAssetsFromPreloadAssetCollectionResult", CollectNiagaraAssetsFromPreloadAssetCollectionResult_IsValid);
	}
}
