using System;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_HandleBattleMessage")]
internal class BAIT_HandleBattleMessage : BAIT_Base
{
	private static bool BattleMessage_IsValid;

	private static int BattleMessage_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_HandleBattleMessage:BattleMessage")]
	public FGameplayTag BattleMessage
	{
		get
		{
			CheckDestroyed();
			if (!BattleMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_HandleBattleMessage:BattleMessage");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, BattleMessage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_HandleBattleMessage:BattleMessage");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, BattleMessage_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor)?.Evt_HandleBattleMessage.Invoke(BattleMessage);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(OwnerActor, EBattleInfoType.CSGDebug, $"<character>{OwnerActor.GetName().ConvertLongGuid2DisplayGuid()}</><effect>【CSGDEBUG】</><action> 通过BT发起了BattleMessage </><effectnum>{BattleMessage.TagName}</>");
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_HandleBattleMessage");
		BattleMessage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleMessage");
		BattleMessage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleMessage", Classes.FStructProperty);
	}

	static BAIT_HandleBattleMessage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_HandleBattleMessage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_HandleBattleMessage));
	}
}
