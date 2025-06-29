using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Mark")]
[USharpPath("/Script/b1-Managed.BED_GuideNode_Mark")]
public class BED_GuideNode_Mark : BED_GuideNode_Base
{
	private static bool GuildGroupId_IsValid;

	private static int GuildGroupId_Offset;

	private static bool IsWaitUntilGuideFinish_IsValid;

	private static int IsWaitUntilGuideFinish_Offset;

	private static FFieldAddress IsWaitUntilGuideFinish_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[DisplayName("教学组Id")]
	[Category("新手指引")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_GuideNode_Mark:GuildGroupId")]
	public int GuildGroupId
	{
		get
		{
			CheckDestroyed();
			if (!GuildGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Mark:GuildGroupId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GuildGroupId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GuildGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Mark:GuildGroupId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GuildGroupId_Offset), value);
			}
		}
	}

	[DisplayName("等待当前教学完成")]
	[Category("新手指引")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_GuideNode_Mark:IsWaitUntilGuideFinish")]
	public bool IsWaitUntilGuideFinish
	{
		get
		{
			CheckDestroyed();
			if (!IsWaitUntilGuideFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Mark:IsWaitUntilGuideFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsWaitUntilGuideFinish_Offset), 0, IsWaitUntilGuideFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsWaitUntilGuideFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Mark:IsWaitUntilGuideFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsWaitUntilGuideFinish_Offset), 0, IsWaitUntilGuideFinish_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "新手指引";
		base.NodeStyle = ECalliopeNodeStyle.Default;
		base.SupportsContextPins = false;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.GuideNode.Mark;
	}

	[USharpPath("/Script/b1-Managed.BED_GuideNode_Mark:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"教学组Id: {GuildGroupId}";
	}

	public override byte[] GetCustomData()
	{
		return new GuideCustom_Mark
		{
			GuideGroupId = GuildGroupId,
			IsWaitUntilGuideFinish = IsWaitUntilGuideFinish
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_GuideNode_Mark:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_GuideNode_Mark bED_GuideNode_Mark = GCHelper.Find<BED_GuideNode_Mark>(obj);
		string nodeDescriptionInCS_Implementation = bED_GuideNode_Mark.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_GuideNode_Mark");
		GuildGroupId_Offset = NativeReflection.GetPropertyOffset(intPtr, "GuildGroupId");
		GuildGroupId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GuildGroupId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsWaitUntilGuideFinish_PropertyAddress, intPtr, "IsWaitUntilGuideFinish");
		IsWaitUntilGuideFinish_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsWaitUntilGuideFinish");
		IsWaitUntilGuideFinish_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsWaitUntilGuideFinish", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_GuideNode_Mark:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_GuideNode_Mark()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_GuideNode_Mark)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_GuideNode_Mark));
	}
}
