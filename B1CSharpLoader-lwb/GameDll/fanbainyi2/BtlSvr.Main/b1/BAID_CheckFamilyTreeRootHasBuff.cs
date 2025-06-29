using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff")]
public class BAID_CheckFamilyTreeRootHasBuff : BAID_Base
{
	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	private static bool IsReverseConidtion_IsValid;

	private static int IsReverseConidtion_Offset;

	private static FFieldAddress IsReverseConidtion_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff:BuffId")]
	public int BuffId
	{
		get
		{
			CheckDestroyed();
			if (!BuffId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff:BuffId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff:BuffId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffId_Offset), value);
			}
		}
	}

	[DisplayName("反转条件")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff:IsReverseConidtion")]
	public bool IsReverseConidtion
	{
		get
		{
			CheckDestroyed();
			if (!IsReverseConidtion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff:IsReverseConidtion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsReverseConidtion_Offset), 0, IsReverseConidtion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsReverseConidtion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff:IsReverseConidtion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsReverseConidtion_Offset), 0, IsReverseConidtion_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		AGameStateBase gameState = UGameplayStatics.GetGameState(OwnerActor);
		if (gameState == null)
		{
			return false;
		}
		BGC_CircusControlData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CircusControlData>(gameState);
		if (readOnlyData == null)
		{
			return false;
		}
		CircusMember circusRootMember = readOnlyData.GetCircusRootMember(OwnerActor);
		if (circusRootMember == null)
		{
			return false;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(OwnerActor, circusRootMember.ActorGuid);
		if (actorByGuid == null)
		{
			return false;
		}
		BUC_BuffData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(actorByGuid);
		if (readOnlyData2 == null)
		{
			return false;
		}
		if (IsReverseConidtion)
		{
			return !readOnlyData2.HasBuff(BuffId);
		}
		return readOnlyData2.HasBuff(BuffId);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckFamilyTreeRootHasBuff");
		BuffId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsReverseConidtion_PropertyAddress, unrealStruct, "IsReverseConidtion");
		IsReverseConidtion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsReverseConidtion");
		IsReverseConidtion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsReverseConidtion", Classes.FBoolProperty);
	}

	static BAID_CheckFamilyTreeRootHasBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckFamilyTreeRootHasBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckFamilyTreeRootHasBuff));
	}
}
