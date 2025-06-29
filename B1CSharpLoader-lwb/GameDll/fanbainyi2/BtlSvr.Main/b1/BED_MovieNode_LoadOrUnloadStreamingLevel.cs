using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("地图：加载/卸载")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel")]
internal class BED_MovieNode_LoadOrUnloadStreamingLevel : BED_MovieNode
{
	private static bool StreamingLevelName_IsValid;

	private static int StreamingLevelName_Offset;

	private static bool bLoadOrUnload_IsValid;

	private static int bLoadOrUnload_Offset;

	private static FFieldAddress bLoadOrUnload_PropertyAddress;

	private static bool FinishLoadEventTag_IsValid;

	private static int FinishLoadEventTag_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[DisplayName("地图名")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:StreamingLevelName")]
	public FName StreamingLevelName
	{
		get
		{
			CheckDestroyed();
			if (!StreamingLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:StreamingLevelName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StreamingLevelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamingLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:StreamingLevelName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StreamingLevelName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Config")]
	[Tooltip("勾选表示加载，不勾表示卸载")]
	[DisplayName("加载/卸载")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:bLoadOrUnload")]
	public bool bLoadOrUnload
	{
		get
		{
			CheckDestroyed();
			if (!bLoadOrUnload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:bLoadOrUnload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoadOrUnload_Offset), 0, bLoadOrUnload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoadOrUnload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:bLoadOrUnload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoadOrUnload_Offset), 0, bLoadOrUnload_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bLoadOrUnload")]
	[DisplayName("加载完成时发送的事件")]
	[Category("Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:FinishLoadEventTag")]
	public FGameplayTag FinishLoadEventTag
	{
		get
		{
			CheckDestroyed();
			if (!FinishLoadEventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:FinishLoadEventTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, FinishLoadEventTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinishLoadEventTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:FinishLoadEventTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, FinishLoadEventTag_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bLoadOrUnload = true;
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.LoadOrUnloadStreamingLevel;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (bLoadOrUnload)
		{
			return $"加载关卡：{StreamingLevelName} \n完成事件:{FinishLoadEventTag.TagName}";
		}
		return $"卸载关卡：{StreamingLevelName}";
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_LoadOrUnloadStreamingLevel
		{
			StreamingLevelName = StreamingLevelName.ToString(),
			IsLoadOrUnload = bLoadOrUnload,
			FinishLoadEvent = FinishLoadEventTag.TagName.ToString()
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_LoadOrUnloadStreamingLevel bED_MovieNode_LoadOrUnloadStreamingLevel = GCHelper.Find<b1.BED_MovieNode_LoadOrUnloadStreamingLevel>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_LoadOrUnloadStreamingLevel.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel");
		StreamingLevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "StreamingLevelName");
		StreamingLevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StreamingLevelName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bLoadOrUnload_PropertyAddress, intPtr, "bLoadOrUnload");
		bLoadOrUnload_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoadOrUnload");
		bLoadOrUnload_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoadOrUnload", Classes.FBoolProperty);
		FinishLoadEventTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "FinishLoadEventTag");
		FinishLoadEventTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FinishLoadEventTag", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_LoadOrUnloadStreamingLevel:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_LoadOrUnloadStreamingLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_LoadOrUnloadStreamingLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_LoadOrUnloadStreamingLevel));
	}
}
