using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("HandleBattleMessage")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_HandleBattleMessage")]
internal class BED_BehaviorNode_HandleBattleMessage : b1.BED_BehaviorNode_Action
{
	private static bool BattleMessage_IsValid;

	private static int BattleMessage_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_HandleBattleMessage:BattleMessage")]
	public FGameplayTag BattleMessage
	{
		get
		{
			CheckDestroyed();
			if (!BattleMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_HandleBattleMessage:BattleMessage");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, BattleMessage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_HandleBattleMessage:BattleMessage");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, BattleMessage_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.HandleBattleMessage;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_HandleBattleMessage
		{
			MessageContent = BattleMessage.TagName.PlainName
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_HandleBattleMessage");
		BattleMessage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleMessage");
		BattleMessage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleMessage", Classes.FStructProperty);
	}

	static BED_BehaviorNode_HandleBattleMessage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_HandleBattleMessage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_HandleBattleMessage));
	}
}
