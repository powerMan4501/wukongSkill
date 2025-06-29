using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming")]
public class BMPS_LevelStreaming : BMPS_Base
{
	private List<string> LoadLevelNameList;

	private List<string> UnLoadLevelNameList;

	private List<string> AutoLevelNameList;

	private static bool GeometryLevelsLoadSetting_IsValid;

	private static int GeometryLevelsLoadSetting_Offset;

	private static FFieldAddress GeometryLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, ELevelLoadState> GeometryLevelsLoadSetting_Marshaler;

	private static bool SeqLevelsLoadSetting_IsValid;

	private static int SeqLevelsLoadSetting_Offset;

	private static FFieldAddress SeqLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, ELevelLoadState> SeqLevelsLoadSetting_Marshaler;

	private static bool ItemLevelsLoadSetting_IsValid;

	private static int ItemLevelsLoadSetting_Offset;

	private static FFieldAddress ItemLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, ELevelLoadState> ItemLevelsLoadSetting_Marshaler;

	private static bool OtherLevelsLoadSetting_IsValid;

	private static int OtherLevelsLoadSetting_Offset;

	private static FFieldAddress OtherLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, ELevelLoadState> OtherLevelsLoadSetting_Marshaler;

	private static bool MonsterLevelsLoadSetting_IsValid;

	private static int MonsterLevelsLoadSetting_Offset;

	private static FFieldAddress MonsterLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, ELevelLoadState> MonsterLevelsLoadSetting_Marshaler;

	private static bool RefreshCurrentLevelNames_IsValid;

	private static IntPtr RefreshCurrentLevelNames_FunctionAddress;

	private static int RefreshCurrentLevelNames_ParamsSize;

	private static bool GetDisplayTextCS_IsValid;

	private static IntPtr GetDisplayTextCS_FunctionAddress;

	private static int GetDisplayTextCS_ParamsSize;

	private static bool GetDisplayTextCS_ReturnValue_IsValid;

	private static int GetDisplayTextCS_ReturnValue_Offset;

	private static FFieldAddress GetDisplayTextCS_ReturnValue_PropertyAddress;

	private static bool SetupForPipelineCS_IsValid;

	private static IntPtr SetupForPipelineCS_FunctionAddress;

	private static int SetupForPipelineCS_ParamsSize;

	private static bool SetupForPipelineCS_InPipeline_IsValid;

	private static int SetupForPipelineCS_InPipeline_Offset;

	private static bool TeardownForPipelineCS_IsValid;

	private static IntPtr TeardownForPipelineCS_FunctionAddress;

	private static int TeardownForPipelineCS_ParamsSize;

	private static bool TeardownForPipelineCS_InPipeline_IsValid;

	private static int TeardownForPipelineCS_InPipeline_Offset;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("场景关卡加载配置")]
	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:GeometryLevelsLoadSetting")]
	public TMapReadWrite<string, ELevelLoadState> GeometryLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!GeometryLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_LevelStreaming:GeometryLevelsLoadSetting");
				return null;
			}
			if (GeometryLevelsLoadSetting_Marshaler == null)
			{
				GeometryLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, ELevelLoadState>(1, GeometryLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.FromNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.ToNative);
			}
			return GeometryLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, GeometryLevelsLoadSetting_Offset));
		}
	}

	[DisplayName("Seq关卡加载配置")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:SeqLevelsLoadSetting")]
	public TMapReadWrite<string, ELevelLoadState> SeqLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!SeqLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_LevelStreaming:SeqLevelsLoadSetting");
				return null;
			}
			if (SeqLevelsLoadSetting_Marshaler == null)
			{
				SeqLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, ELevelLoadState>(1, SeqLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.FromNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.ToNative);
			}
			return SeqLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, SeqLevelsLoadSetting_Offset));
		}
	}

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[DisplayName("Item关卡加载配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:ItemLevelsLoadSetting")]
	public TMapReadWrite<string, ELevelLoadState> ItemLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!ItemLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_LevelStreaming:ItemLevelsLoadSetting");
				return null;
			}
			if (ItemLevelsLoadSetting_Marshaler == null)
			{
				ItemLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, ELevelLoadState>(1, ItemLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.FromNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.ToNative);
			}
			return ItemLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, ItemLevelsLoadSetting_Offset));
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("其他关卡加载配置")]
	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:OtherLevelsLoadSetting")]
	public TMapReadWrite<string, ELevelLoadState> OtherLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!OtherLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_LevelStreaming:OtherLevelsLoadSetting");
				return null;
			}
			if (OtherLevelsLoadSetting_Marshaler == null)
			{
				OtherLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, ELevelLoadState>(1, OtherLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.FromNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.ToNative);
			}
			return OtherLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, OtherLevelsLoadSetting_Offset));
		}
	}

	[DisplayName("Monster关卡加载配置")]
	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:MonsterLevelsLoadSetting")]
	public TMapReadWrite<string, ELevelLoadState> MonsterLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!MonsterLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BMPS_LevelStreaming:MonsterLevelsLoadSetting");
				return null;
			}
			if (MonsterLevelsLoadSetting_Marshaler == null)
			{
				MonsterLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, ELevelLoadState>(1, MonsterLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.FromNative, CachedMarshalingDelegates<ELevelLoadState, EnumMarshaler<ELevelLoadState>>.ToNative);
			}
			return MonsterLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, MonsterLevelsLoadSetting_Offset));
		}
	}

	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:RefreshCurrentLevelNames")]
	public void RefreshCurrentLevelNames()
	{
		UGSEditorLevelLibrary.GetCurrentAllWCLevelsName(out var OutLevelsName);
		if (OutLevelsName == null)
		{
			return;
		}
		Dictionary<string, ELevelLoadState> dictionary = GeometryLevelsLoadSetting.ToDictionary();
		GeometryLevelsLoadSetting.Clear();
		Dictionary<string, ELevelLoadState> dictionary2 = SeqLevelsLoadSetting.ToDictionary();
		SeqLevelsLoadSetting.Clear();
		Dictionary<string, ELevelLoadState> dictionary3 = ItemLevelsLoadSetting.ToDictionary();
		ItemLevelsLoadSetting.Clear();
		Dictionary<string, ELevelLoadState> dictionary4 = OtherLevelsLoadSetting.ToDictionary();
		OtherLevelsLoadSetting.Clear();
		Dictionary<string, ELevelLoadState> dictionary5 = MonsterLevelsLoadSetting.ToDictionary();
		MonsterLevelsLoadSetting.Clear();
		foreach (string item in OutLevelsName)
		{
			ELevelLoadState value5;
			if (item.ToLower().Contains("map"))
			{
				if (dictionary.TryGetValue(item, out var value))
				{
					GeometryLevelsLoadSetting[item] = value;
				}
				else
				{
					GeometryLevelsLoadSetting[item] = ELevelLoadState.Auto;
				}
			}
			else if (item.ToLower().Contains("seq"))
			{
				if (dictionary2.TryGetValue(item, out var value2))
				{
					SeqLevelsLoadSetting[item] = value2;
				}
				else
				{
					SeqLevelsLoadSetting[item] = ELevelLoadState.Unload;
				}
			}
			else if (item.ToLower().Contains("item"))
			{
				if (dictionary3.TryGetValue(item, out var value3))
				{
					ItemLevelsLoadSetting[item] = value3;
				}
				else
				{
					ItemLevelsLoadSetting[item] = ELevelLoadState.Unload;
				}
			}
			else if (item.ToLower().Contains("monster"))
			{
				if (dictionary5.TryGetValue(item, out var value4))
				{
					MonsterLevelsLoadSetting[item] = value4;
				}
				else
				{
					MonsterLevelsLoadSetting[item] = ELevelLoadState.Unload;
				}
			}
			else if (dictionary4.TryGetValue(item, out value5))
			{
				OtherLevelsLoadSetting[item] = value5;
			}
			else
			{
				OtherLevelsLoadSetting[item] = ELevelLoadState.Auto;
			}
		}
	}

	private static void RemoveUnExistLevels(IDictionary<string, ELevelLoadState> LevelsLoadSetting, List<string> CurrentLevels)
	{
		foreach (string item in LevelsLoadSetting.Keys.ToList())
		{
			if (!CurrentLevels.Contains(item))
			{
				LevelsLoadSetting.Remove(item);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:SetupForPipelineCS")]
	protected override void SetupForPipelineCS_Implementation(UMoviePipeline InPipeline)
	{
		LoadLevelNameList = new List<string>();
		UnLoadLevelNameList = new List<string>();
		AutoLevelNameList = new List<string>();
		GetLoadedAndUnloadedLevels(InPipeline, GeometryLevelsLoadSetting, ref LoadLevelNameList, ref UnLoadLevelNameList, ref AutoLevelNameList);
		GetLoadedAndUnloadedLevels(InPipeline, SeqLevelsLoadSetting, ref LoadLevelNameList, ref UnLoadLevelNameList, ref AutoLevelNameList);
		GetLoadedAndUnloadedLevels(InPipeline, ItemLevelsLoadSetting, ref LoadLevelNameList, ref UnLoadLevelNameList, ref AutoLevelNameList);
		GetLoadedAndUnloadedLevels(InPipeline, MonsterLevelsLoadSetting, ref LoadLevelNameList, ref UnLoadLevelNameList, ref AutoLevelNameList);
		GetLoadedAndUnloadedLevels(InPipeline, OtherLevelsLoadSetting, ref LoadLevelNameList, ref UnLoadLevelNameList, ref AutoLevelNameList);
		UBGUWCStreamingFuncLib.SetLevelsStateByNames(InPipeline, LoadLevelNameList, EGSLevelState.LoadedVisible, 0, bBlockOnLoad: true);
		UBGUWCStreamingFuncLib.SetLevelsStateByNames(InPipeline, UnLoadLevelNameList, EGSLevelState.Unloaded, 1, bBlockOnLoad: true);
		UBGUWCStreamingFuncLib.SetLevelsStateByNames(InPipeline, AutoLevelNameList, EGSLevelState.Auto, 2);
		LoadLevelNameList.Clear();
		UnLoadLevelNameList.Clear();
		AutoLevelNameList.Clear();
		GetLoadedAndUnloadedLevels(InPipeline, GeometryLevelsLoadSetting, ref LoadLevelNameList, ref UnLoadLevelNameList, ref AutoLevelNameList, bUseWCTile: true);
		GetLoadedAndUnloadedLevels(InPipeline, OtherLevelsLoadSetting, ref LoadLevelNameList, ref UnLoadLevelNameList, ref AutoLevelNameList, bUseWCTile: true);
		foreach (string loadLevelName in LoadLevelNameList)
		{
			UBGUWCStreamingFuncLib.SetLevelsState(InPipeline, loadLevelName, EGSLevelState.LoadedVisible, 3, bKeywordMatch: true, bBlockOnLoad: true);
		}
		foreach (string unLoadLevelName in UnLoadLevelNameList)
		{
			UBGUWCStreamingFuncLib.SetLevelsState(InPipeline, unLoadLevelName, EGSLevelState.Unloaded, 4, bKeywordMatch: true, bBlockOnLoad: true);
		}
		foreach (string autoLevelName in AutoLevelNameList)
		{
			UBGUWCStreamingFuncLib.SetLevelsState(InPipeline, autoLevelName, EGSLevelState.Auto, 5);
		}
	}

	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:TeardownForPipelineCS")]
	protected override void TeardownForPipelineCS_Implementation(UMoviePipeline InPipeline)
	{
		LoadLevelNameList = null;
		UnLoadLevelNameList = null;
		AutoLevelNameList = null;
	}

	private void GetLoadedAndUnloadedLevels(UObject InWorldContext, IDictionary<string, ELevelLoadState> InLevelLoadSettings, ref List<string> LoadLevelNameList, ref List<string> UnLoadLevelNameList, ref List<string> AutoLevelNameList, bool bUseWCTile = false)
	{
		foreach (KeyValuePair<string, ELevelLoadState> InLevelLoadSetting in InLevelLoadSettings)
		{
			string item = (bUseWCTile ? (InLevelLoadSetting.Key + "_WCTile") : InLevelLoadSetting.Key);
			switch (InLevelLoadSetting.Value)
			{
			case ELevelLoadState.Load:
				LoadLevelNameList.Add(item);
				break;
			case ELevelLoadState.Unload:
				UnLoadLevelNameList.Add(item);
				break;
			case ELevelLoadState.Auto:
				AutoLevelNameList.Add(item);
				break;
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BMPS_LevelStreaming:GetDisplayTextCS")]
	protected override string GetDisplayTextCS_Implementation()
	{
		return "子关卡加载";
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_LevelStreaming:RefreshCurrentLevelNames")]
	private static void RefreshCurrentLevelNames__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_LevelStreaming bMPS_LevelStreaming = GCHelper.Find<BMPS_LevelStreaming>(obj);
		bMPS_LevelStreaming.RefreshCurrentLevelNames();
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_LevelStreaming:GetDisplayTextCS")]
	private static void GetDisplayTextCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_LevelStreaming bMPS_LevelStreaming = GCHelper.Find<BMPS_LevelStreaming>(obj);
		string displayTextCS_Implementation = bMPS_LevelStreaming.GetDisplayTextCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDisplayTextCS_ReturnValue_Offset), displayTextCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_LevelStreaming:SetupForPipelineCS")]
	private static void SetupForPipelineCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_LevelStreaming bMPS_LevelStreaming = GCHelper.Find<BMPS_LevelStreaming>(obj);
		UMoviePipeline inPipeline = UObjectMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(buffer, SetupForPipelineCS_InPipeline_Offset));
		bMPS_LevelStreaming.SetupForPipelineCS_Implementation(inPipeline);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_LevelStreaming:TeardownForPipelineCS")]
	private static void TeardownForPipelineCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_LevelStreaming bMPS_LevelStreaming = GCHelper.Find<BMPS_LevelStreaming>(obj);
		UMoviePipeline inPipeline = UObjectMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(buffer, TeardownForPipelineCS_InPipeline_Offset));
		bMPS_LevelStreaming.TeardownForPipelineCS_Implementation(inPipeline);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BMPS_LevelStreaming");
		NativeReflection.GetPropertyRef(ref GeometryLevelsLoadSetting_PropertyAddress, intPtr, "GeometryLevelsLoadSetting");
		GeometryLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeometryLevelsLoadSetting");
		GeometryLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeometryLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SeqLevelsLoadSetting_PropertyAddress, intPtr, "SeqLevelsLoadSetting");
		SeqLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "SeqLevelsLoadSetting");
		SeqLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SeqLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref ItemLevelsLoadSetting_PropertyAddress, intPtr, "ItemLevelsLoadSetting");
		ItemLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemLevelsLoadSetting");
		ItemLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref OtherLevelsLoadSetting_PropertyAddress, intPtr, "OtherLevelsLoadSetting");
		OtherLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "OtherLevelsLoadSetting");
		OtherLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OtherLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref MonsterLevelsLoadSetting_PropertyAddress, intPtr, "MonsterLevelsLoadSetting");
		MonsterLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "MonsterLevelsLoadSetting");
		MonsterLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MonsterLevelsLoadSetting", Classes.FMapProperty);
		RefreshCurrentLevelNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshCurrentLevelNames");
		RefreshCurrentLevelNames_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshCurrentLevelNames_FunctionAddress);
		RefreshCurrentLevelNames_IsValid = RefreshCurrentLevelNames_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_LevelStreaming:RefreshCurrentLevelNames", RefreshCurrentLevelNames_IsValid);
		GetDisplayTextCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisplayTextCS");
		GetDisplayTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayTextCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDisplayTextCS_ReturnValue_PropertyAddress, GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDisplayTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayTextCS_IsValid = GetDisplayTextCS_FunctionAddress != IntPtr.Zero && GetDisplayTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_LevelStreaming:GetDisplayTextCS", GetDisplayTextCS_IsValid);
		SetupForPipelineCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupForPipelineCS");
		SetupForPipelineCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupForPipelineCS_FunctionAddress);
		SetupForPipelineCS_InPipeline_Offset = NativeReflection.GetPropertyOffset(SetupForPipelineCS_FunctionAddress, "InPipeline");
		SetupForPipelineCS_InPipeline_IsValid = NativeReflection.ValidatePropertyClass(SetupForPipelineCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		SetupForPipelineCS_IsValid = SetupForPipelineCS_FunctionAddress != IntPtr.Zero && SetupForPipelineCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_LevelStreaming:SetupForPipelineCS", SetupForPipelineCS_IsValid);
		TeardownForPipelineCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TeardownForPipelineCS");
		TeardownForPipelineCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TeardownForPipelineCS_FunctionAddress);
		TeardownForPipelineCS_InPipeline_Offset = NativeReflection.GetPropertyOffset(TeardownForPipelineCS_FunctionAddress, "InPipeline");
		TeardownForPipelineCS_InPipeline_IsValid = NativeReflection.ValidatePropertyClass(TeardownForPipelineCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		TeardownForPipelineCS_IsValid = TeardownForPipelineCS_FunctionAddress != IntPtr.Zero && TeardownForPipelineCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_LevelStreaming:TeardownForPipelineCS", TeardownForPipelineCS_IsValid);
	}

	static BMPS_LevelStreaming()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BMPS_LevelStreaming)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BMPS_LevelStreaming));
	}
}
