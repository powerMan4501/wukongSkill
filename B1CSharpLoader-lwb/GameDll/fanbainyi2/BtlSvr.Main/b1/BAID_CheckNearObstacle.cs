using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckNearObstacle")]
internal class BAID_CheckNearObstacle : BAID_Base
{
	private static bool EscapeThreshold_IsValid;

	private static int EscapeThreshold_Offset;

	[BlueprintReadWrite]
	[DisplayName("脱困阈值")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("当墙角检查分数超过阈值时，触发脱困逻辑")]
	[USharpPath("/Script/b1-Managed.BAID_CheckNearObstacle:EscapeThreshold")]
	public int EscapeThreshold
	{
		get
		{
			CheckDestroyed();
			if (!EscapeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckNearObstacle:EscapeThreshold");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EscapeThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EscapeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckNearObstacle:EscapeThreshold");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EscapeThreshold_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		EscapeThreshold = 3;
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (aBGUCharacter == null)
		{
			return false;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(aBGUCharacter);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		AIData_Memory memory = unPersistentReadOnlyData.Memory;
		if (memory == null)
		{
			return false;
		}
		return memory.ObstacleCheckScore - (float)EscapeThreshold > 1E-08f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckNearObstacle");
		EscapeThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EscapeThreshold");
		EscapeThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EscapeThreshold", Classes.FIntProperty);
	}

	static BAID_CheckNearObstacle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckNearObstacle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckNearObstacle));
	}
}
