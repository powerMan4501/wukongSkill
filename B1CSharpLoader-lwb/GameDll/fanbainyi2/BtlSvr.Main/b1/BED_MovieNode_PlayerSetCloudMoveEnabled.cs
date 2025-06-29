using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("玩家：设置筋斗云状态")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled")]
internal class BED_MovieNode_PlayerSetCloudMoveEnabled : BED_MovieNode
{
	private static bool bIsEnabled_IsValid;

	private static int bIsEnabled_Offset;

	private static FFieldAddress bIsEnabled_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[Category("Movie")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("筋斗云状态")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled:bIsEnabled")]
	public bool bIsEnabled
	{
		get
		{
			CheckDestroyed();
			if (!bIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled:bIsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsEnabled_Offset), 0, bIsEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled:bIsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsEnabled_Offset), 0, bIsEnabled_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.Default);
		bIsEnabled = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.PlayerSetCloudMoveEnabled;
	}

	public override byte[] GetCustomData()
	{
		return new MovieCustom_PlayerSetCloudMoveEnabled
		{
			IsEnabled = bIsEnabled
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(bIsEnabled ? "启用" : "关闭");
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_PlayerSetCloudMoveEnabled bED_MovieNode_PlayerSetCloudMoveEnabled = GCHelper.Find<b1.BED_MovieNode_PlayerSetCloudMoveEnabled>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_PlayerSetCloudMoveEnabled.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled");
		NativeReflection.GetPropertyRef(ref bIsEnabled_PropertyAddress, intPtr, "bIsEnabled");
		bIsEnabled_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsEnabled");
		bIsEnabled_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsEnabled", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_PlayerSetCloudMoveEnabled:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_PlayerSetCloudMoveEnabled()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_PlayerSetCloudMoveEnabled)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_PlayerSetCloudMoveEnabled));
	}
}
