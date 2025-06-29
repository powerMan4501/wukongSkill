using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_AssistStateCheck")]
public class BAID_AssistStateCheck : BAID_Base
{
	private static bool AssistState_IsValid;

	private static int AssistState_Offset;

	private static FFieldAddress AssistState_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_AssistStateCheck:AssistState")]
	public EPartnerAssistState AssistState
	{
		get
		{
			CheckDestroyed();
			if (!AssistState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_AssistStateCheck:AssistState");
				return EPartnerAssistState.None;
			}
			return EnumMarshaler<EPartnerAssistState>.FromNative(IntPtr.Add(base.Address, AssistState_Offset), 0, AssistState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AssistState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_AssistStateCheck:AssistState");
			}
			else
			{
				EnumMarshaler<EPartnerAssistState>.ToNative(IntPtr.Add(base.Address, AssistState_Offset), 0, AssistState_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor.IsNullOrDestroyed())
		{
			return false;
		}
		BUC_HeroSwitchData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_HeroSwitchData>(OwnerActor);
		if (readOnlyData == null)
		{
			return false;
		}
		return AssistState == readOnlyData.CurPartnerAssistState;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_AssistStateCheck");
		NativeReflection.GetPropertyRef(ref AssistState_PropertyAddress, unrealStruct, "AssistState");
		AssistState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AssistState");
		AssistState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AssistState", Classes.FEnumProperty);
	}

	static BAID_AssistStateCheck()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_AssistStateCheck)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_AssistStateCheck));
	}
}
