using System;
using System.Text;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("通知专属物件")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem")]
internal class BED_BehaviorNode_NotifyExclusiveItem : b1.BED_BehaviorNode_Action
{
	private static bool ActorTag_IsValid;

	private static int ActorTag_Offset;

	private static bool NotifyTag_IsValid;

	private static int NotifyTag_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Notify")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:ActorTag")]
	public FGameplayTag ActorTag
	{
		get
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:ActorTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, ActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:ActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, ActorTag_Offset), value);
			}
		}
	}

	[Category("Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:NotifyTag")]
	public FGameplayTag NotifyTag
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:NotifyTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, NotifyTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:NotifyTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, NotifyTag_Offset), value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.NotifyExclusiveItem;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_NotifyExclusiveItem
		{
			ActorTag = ActorTag.TagName.PlainName,
			NotifyTag = NotifyTag.TagName.PlainName
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (GameplayTagExtension.IsValid(ActorTag))
		{
			stringBuilder.AppendLine("专属ActorTag: " + ActorTag.TagName.PlainName);
		}
		else
		{
			stringBuilder.AppendLine("未配置专属ActorTag");
		}
		if (GameplayTagExtension.IsValid(NotifyTag))
		{
			stringBuilder.Append($"通知内容：{NotifyTag.TagName}");
		}
		else
		{
			stringBuilder.Append("未配置需要通知的内容");
		}
		return stringBuilder.ToString();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_NotifyExclusiveItem bED_BehaviorNode_NotifyExclusiveItem = GCHelper.Find<b1.BED_BehaviorNode_NotifyExclusiveItem>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_NotifyExclusiveItem.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem");
		ActorTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorTag");
		ActorTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorTag", Classes.FStructProperty);
		NotifyTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyTag");
		NotifyTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyTag", Classes.FStructProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_NotifyExclusiveItem:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_NotifyExclusiveItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_NotifyExclusiveItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_NotifyExclusiveItem));
	}
}
