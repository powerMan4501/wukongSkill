using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("条件检查")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_ConditionQuery")]
public class BED_MovieNode_ConditionQuery : BED_MovieNode
{
	private static bool MovieConditionQueryConfig_IsValid;

	private static int MovieConditionQueryConfig_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_ConditionQuery:MovieConditionQueryConfig")]
	public FMovieConditionQueryConfig MovieConditionQueryConfig
	{
		get
		{
			CheckDestroyed();
			if (!MovieConditionQueryConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ConditionQuery:MovieConditionQueryConfig");
				return default(FMovieConditionQueryConfig);
			}
			return FMovieConditionQueryConfig.FromNative(IntPtr.Add(base.Address, MovieConditionQueryConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MovieConditionQueryConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ConditionQuery:MovieConditionQueryConfig");
			}
			else
			{
				FMovieConditionQueryConfig.ToNative(IntPtr.Add(base.Address, MovieConditionQueryConfig_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Failed
		});
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.ConditionQuery;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_ConditionQuery:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		string text = "条件检查";
		if (MovieConditionQueryConfig.ConditionQueryType == EMovieConditionQueryType.AllLevelSwitchStateFinish)
		{
			text += "\n地图：检查CMG关卡状态请求完成";
		}
		else if (MovieConditionQueryConfig.ConditionQueryType == EMovieConditionQueryType.GroupUnitBirthFinish)
		{
			text = text + "\n地图：群体单位是否全部出生完全\n群体单位Guid：" + MovieConditionQueryConfig.GroupUnitGuid.TagName.PlainName;
		}
		return text;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_ConditionQuery
		{
			ConditionQueryType = (int)MovieConditionQueryConfig.ConditionQueryType,
			GroupUnitGuid = MovieConditionQueryConfig.GroupUnitGuid.TagName.PlainName
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_ConditionQuery:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_MovieNode_ConditionQuery bED_MovieNode_ConditionQuery = GCHelper.Find<BED_MovieNode_ConditionQuery>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_ConditionQuery.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_ConditionQuery");
		MovieConditionQueryConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "MovieConditionQueryConfig");
		MovieConditionQueryConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MovieConditionQueryConfig", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_ConditionQuery:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_ConditionQuery()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_MovieNode_ConditionQuery)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_MovieNode_ConditionQuery));
	}
}
