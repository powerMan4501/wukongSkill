using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_EnvironmentChangeCheck")]
internal class BAID_EnvironmentChangeCheck : BAID_Base
{
	private static bool SwitchSchedule_IsValid;

	private static int SwitchSchedule_Offset;

	[BlueprintReadWrite]
	[Tooltip("切换进度 ex:0.5")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_EnvironmentChangeCheck:SwitchSchedule")]
	public float SwitchSchedule
	{
		get
		{
			CheckDestroyed();
			if (!SwitchSchedule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_EnvironmentChangeCheck:SwitchSchedule");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SwitchSchedule_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SwitchSchedule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_EnvironmentChangeCheck:SwitchSchedule");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SwitchSchedule_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		b1.BUC_EnvironmentData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.BUC_EnvironmentData>(bGUCharacterCS);
		if (readOnlyData == null || readOnlyData.EnvMgrActor.IsNullOrDestroyed())
		{
			return false;
		}
		b1.BUC_EnvCtrlData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<b1.BUC_EnvCtrlData>(readOnlyData.EnvMgrActor);
		if (readOnlyData2 == null)
		{
			return false;
		}
		if (readOnlyData2.GetEnvSwitchSchedule(AActorStatics.GetEntityHash(bGUCharacterCS)) >= SwitchSchedule)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_EnvironmentChangeCheck");
		SwitchSchedule_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SwitchSchedule");
		SwitchSchedule_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SwitchSchedule", Classes.FFloatProperty);
	}

	static BAID_EnvironmentChangeCheck()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_EnvironmentChangeCheck)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_EnvironmentChangeCheck));
	}
}
