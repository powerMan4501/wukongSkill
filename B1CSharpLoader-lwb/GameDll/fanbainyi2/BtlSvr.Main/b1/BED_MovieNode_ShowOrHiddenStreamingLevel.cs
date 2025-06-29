using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("地图：显示/隐藏")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel")]
internal class BED_MovieNode_ShowOrHiddenStreamingLevel : BED_MovieNode
{
	private static bool StreamingLevelName_IsValid;

	private static int StreamingLevelName_Offset;

	private static bool bVisible_IsValid;

	private static int bVisible_Offset;

	private static FFieldAddress bVisible_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Category("Config")]
	[DisplayName("地图名")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:StreamingLevelName")]
	public FName StreamingLevelName
	{
		get
		{
			CheckDestroyed();
			if (!StreamingLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:StreamingLevelName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StreamingLevelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamingLevelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:StreamingLevelName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StreamingLevelName_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("勾选表示显示，不勾表示隐藏")]
	[DisplayName("显示/隐藏")]
	[Category("Config")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:bVisible")]
	public bool bVisible
	{
		get
		{
			CheckDestroyed();
			if (!bVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:bVisible");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bVisible_Offset), 0, bVisible_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:bVisible");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bVisible_Offset), 0, bVisible_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		bVisible = true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.ShowOrHiddenStreamingLevel;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (bVisible)
		{
			return $"显示关卡：{StreamingLevelName}";
		}
		return $"隐藏关卡：{StreamingLevelName}";
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_ShowOrHiddenStreamingLevel
		{
			StreamingLevelName = StreamingLevelName.ToString(),
			IsVisible = bVisible
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_ShowOrHiddenStreamingLevel bED_MovieNode_ShowOrHiddenStreamingLevel = GCHelper.Find<b1.BED_MovieNode_ShowOrHiddenStreamingLevel>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_ShowOrHiddenStreamingLevel.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel");
		StreamingLevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "StreamingLevelName");
		StreamingLevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StreamingLevelName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bVisible_PropertyAddress, intPtr, "bVisible");
		bVisible_Offset = NativeReflection.GetPropertyOffset(intPtr, "bVisible");
		bVisible_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bVisible", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_ShowOrHiddenStreamingLevel:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_ShowOrHiddenStreamingLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_ShowOrHiddenStreamingLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_ShowOrHiddenStreamingLevel));
	}
}
