using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("设置连招长度（一次Combo打多少招）")]
[USharpPath("/Script/b1-Managed.BAIT_CalcComboSkillLength")]
internal class BAIT_CalcComboSkillLength : BAIT_Base
{
	private static bool ComboSkillNumInfo_IsValid;

	private static int ComboSkillNumInfo_Offset;

	private static FFieldAddress ComboSkillNumInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FComboSkillNumInfo> ComboSkillNumInfo_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_CalcComboSkillLength:ComboSkillNumInfo")]
	public TArrayReadWrite<FComboSkillNumInfo> ComboSkillNumInfo
	{
		get
		{
			CheckDestroyed();
			if (!ComboSkillNumInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_CalcComboSkillLength:ComboSkillNumInfo");
				return null;
			}
			if (ComboSkillNumInfo_Marshaler == null)
			{
				ComboSkillNumInfo_Marshaler = new TArrayReadWriteMarshaler<FComboSkillNumInfo>(1, ComboSkillNumInfo_PropertyAddress, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.FromNative, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.ToNative);
			}
			return ComboSkillNumInfo_Marshaler.FromNative(IntPtr.Add(base.Address, ComboSkillNumInfo_Offset));
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS unit)
		{
			BUS_EventCollectionCS.Get(OwnerActor)?.Evt_SetCurComboLength.Invoke(CalcComboSkillLength(unit));
		}
		FinishExecute(bSuccess: true);
	}

	private int CalcComboSkillLength(ABGUCharacter Unit)
	{
		int num = 0;
		int result = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < ComboSkillNumInfo.Count; i++)
		{
			num += ComboSkillNumInfo.Get(i).ComboPercenRatio;
		}
		if (num != 10000)
		{
			USystemLibrary.PrintString(this, "[BAIT_CalcComboSkillLength] 连招概率填错错误，当前全体概率为 = " + (float)num / 10000f, bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
		}
		num2 = UB1Util.GetRandomNumberInt(1, num);
		for (int j = 0; j < ComboSkillNumInfo.Count; j++)
		{
			num3 += ComboSkillNumInfo.Get(j).ComboPercenRatio;
			if (num3 >= num2)
			{
				result = ComboSkillNumInfo.Get(j).ComboNum;
				break;
			}
		}
		AIFuncLibForCS.PrintDebugMessage(Unit, "[BAIT_CalcComboSkillLength]", "当前随机出的连招长度为 : " + result);
		return result;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_CalcComboSkillLength");
		NativeReflection.GetPropertyRef(ref ComboSkillNumInfo_PropertyAddress, unrealStruct, "ComboSkillNumInfo");
		ComboSkillNumInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ComboSkillNumInfo");
		ComboSkillNumInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ComboSkillNumInfo", Classes.FArrayProperty);
	}

	static BAIT_CalcComboSkillLength()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_CalcComboSkillLength)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_CalcComboSkillLength));
	}
}
