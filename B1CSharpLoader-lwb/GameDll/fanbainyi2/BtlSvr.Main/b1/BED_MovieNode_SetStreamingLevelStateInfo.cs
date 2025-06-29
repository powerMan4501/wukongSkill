using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("地图：设置关卡加载状态")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_SetStreamingLevelStateInfo")]
internal class BED_MovieNode_SetStreamingLevelStateInfo : BED_MovieNode
{
	private static bool LevelStateRequestConfig_IsValid;

	private static int LevelStateRequestConfig_Offset;

	private static FFieldAddress LevelStateRequestConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FMovieLevelStateRequestConfig> LevelStateRequestConfig_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("关卡加载状态配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_SetStreamingLevelStateInfo:LevelStateRequestConfig")]
	public TArrayReadWrite<FMovieLevelStateRequestConfig> LevelStateRequestConfig
	{
		get
		{
			CheckDestroyed();
			if (!LevelStateRequestConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_SetStreamingLevelStateInfo:LevelStateRequestConfig");
				return null;
			}
			if (LevelStateRequestConfig_Marshaler == null)
			{
				LevelStateRequestConfig_Marshaler = new TArrayReadWriteMarshaler<FMovieLevelStateRequestConfig>(1, LevelStateRequestConfig_PropertyAddress, CachedMarshalingDelegates<FMovieLevelStateRequestConfig, BlittableTypeMarshaler<FMovieLevelStateRequestConfig>>.FromNative, CachedMarshalingDelegates<FMovieLevelStateRequestConfig, BlittableTypeMarshaler<FMovieLevelStateRequestConfig>>.ToNative);
			}
			return LevelStateRequestConfig_Marshaler.FromNative(IntPtr.Add(base.Address, LevelStateRequestConfig_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.SetStreamingLevelStateInfo;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_SetStreamingLevelStateInfo:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string text = "设置关卡加载状态：";
		if (LevelStateRequestConfig.Count > 0)
		{
			foreach (FMovieLevelStateRequestConfig item in LevelStateRequestConfig)
			{
				text += $"\n关卡ID：{item.LevelID}   DataAssetID:{item.ConfigID}";
			}
		}
		else
		{
			text += "  无";
		}
		return text;
	}

	public override byte[] GetCustomData()
	{
		MovieCustom_SetStreamingLevelStateInfo movieCustom_SetStreamingLevelStateInfo = new MovieCustom_SetStreamingLevelStateInfo();
		foreach (FMovieLevelStateRequestConfig item in LevelStateRequestConfig)
		{
			movieCustom_SetStreamingLevelStateInfo.LevelStateRequestInfo.Add(new CalliopeCustom_RequestLevelStateInfo
			{
				LevelId = item.LevelID,
				ConfigId = item.ConfigID
			});
		}
		return movieCustom_SetStreamingLevelStateInfo.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_SetStreamingLevelStateInfo:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_SetStreamingLevelStateInfo bED_MovieNode_SetStreamingLevelStateInfo = GCHelper.Find<b1.BED_MovieNode_SetStreamingLevelStateInfo>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_SetStreamingLevelStateInfo.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_SetStreamingLevelStateInfo");
		NativeReflection.GetPropertyRef(ref LevelStateRequestConfig_PropertyAddress, intPtr, "LevelStateRequestConfig");
		LevelStateRequestConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelStateRequestConfig");
		LevelStateRequestConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelStateRequestConfig", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_SetStreamingLevelStateInfo:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_SetStreamingLevelStateInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_SetStreamingLevelStateInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_SetStreamingLevelStateInfo));
	}
}
