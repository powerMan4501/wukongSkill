using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Stop All AnimMontage and Skill")]
[UClass]
[USharpPath("/Script/b1-Managed.BSNS_StopAllAnimMontage")]
public class BSNS_StopAllAnimMontage : UMovieSceneCalliopeNotifyStateSection
{
	private static bool bTakePlayerAsUnit_IsValid;

	private static int bTakePlayerAsUnit_Offset;

	private static FFieldAddress bTakePlayerAsUnit_PropertyAddress;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool OnNotifyBegin_IsValid;

	private static IntPtr OnNotifyBegin_FunctionAddress;

	private static int OnNotifyBegin_ParamsSize;

	private static bool OnNotifyBegin_Player_IsValid;

	private static int OnNotifyBegin_Player_Offset;

	private static bool OnNotifyBegin_InStatus_IsValid;

	private static int OnNotifyBegin_InStatus_Offset;

	private static bool OnNotifyBegin_bInBackwards_IsValid;

	private static int OnNotifyBegin_bInBackwards_Offset;

	private static FFieldAddress OnNotifyBegin_bInBackwards_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("StopAllAnimMontage")]
	[DisplayName("主角作为Unit")]
	[USharpPath("/Script/b1-Managed.BSNS_StopAllAnimMontage:bTakePlayerAsUnit")]
	public bool bTakePlayerAsUnit
	{
		get
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_StopAllAnimMontage:bTakePlayerAsUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTakePlayerAsUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_StopAllAnimMontage:bTakePlayerAsUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTakePlayerAsUnit_Offset), 0, bTakePlayerAsUnit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("StopAllAnimMontage")]
	[UMeta(MDProp.EditCondition, "!bTakePlayerAsUnit")]
	[USharpPath("/Script/b1-Managed.BSNS_StopAllAnimMontage:UnitGuid")]
	public FGameplayTag UnitGuid
	{
		get
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_StopAllAnimMontage:UnitGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, UnitGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnitGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BSNS_StopAllAnimMontage:UnitGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, UnitGuid_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BSNS_StopAllAnimMontage:OnNotifyBegin")]
	protected override void OnNotifyBegin_Implementation(UCalliopeLevelSequencePlayer Player, int InStatus, bool bInBackwards)
	{
		UObject playbackContext = Player.GetPlaybackContext();
		ACharacter aCharacter = ((!bTakePlayerAsUnit) ? (BGU_DataUtil.GetActorByGuid(playbackContext, UnitGuid.TagName.PlainName) as ACharacter) : UGameplayStatics.GetPlayerCharacter(playbackContext, 0));
		if (aCharacter != null)
		{
			if (aCharacter.Mesh != null)
			{
				aCharacter.Mesh.GetAnimInstance().StopSlotAnimation(GetDurationTime(), FName.None);
			}
			BUS_EventCollectionCS.Get(aCharacter)?.Evt_UnitTryBreakSkill.Invoke("Sequence中触发打断技能");
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BSNS_StopAllAnimMontage:OnNotifyBegin")]
	private static void OnNotifyBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BSNS_StopAllAnimMontage bSNS_StopAllAnimMontage = GCHelper.Find<BSNS_StopAllAnimMontage>(obj);
		UCalliopeLevelSequencePlayer player = UObjectMarshaler<UCalliopeLevelSequencePlayer>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_Player_Offset));
		int inStatus = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnNotifyBegin_InStatus_Offset));
		bool bInBackwards = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNotifyBegin_bInBackwards_Offset), 0, OnNotifyBegin_bInBackwards_PropertyAddress.Address);
		bSNS_StopAllAnimMontage.OnNotifyBegin_Implementation(player, inStatus, bInBackwards);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BSNS_StopAllAnimMontage");
		NativeReflection.GetPropertyRef(ref bTakePlayerAsUnit_PropertyAddress, intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTakePlayerAsUnit");
		bTakePlayerAsUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTakePlayerAsUnit", Classes.FBoolProperty);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStructProperty);
		OnNotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnNotifyBegin");
		OnNotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNotifyBegin_FunctionAddress);
		OnNotifyBegin_Player_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "Player");
		OnNotifyBegin_Player_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "Player", Classes.FObjectProperty);
		OnNotifyBegin_InStatus_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "InStatus");
		OnNotifyBegin_InStatus_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "InStatus", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnNotifyBegin_bInBackwards_PropertyAddress, OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_Offset = NativeReflection.GetPropertyOffset(OnNotifyBegin_FunctionAddress, "bInBackwards");
		OnNotifyBegin_bInBackwards_IsValid = NativeReflection.ValidatePropertyClass(OnNotifyBegin_FunctionAddress, "bInBackwards", Classes.FBoolProperty);
		OnNotifyBegin_IsValid = OnNotifyBegin_FunctionAddress != IntPtr.Zero && OnNotifyBegin_Player_IsValid && OnNotifyBegin_InStatus_IsValid && OnNotifyBegin_bInBackwards_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BSNS_StopAllAnimMontage:OnNotifyBegin", OnNotifyBegin_IsValid);
	}

	static BSNS_StopAllAnimMontage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BSNS_StopAllAnimMontage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BSNS_StopAllAnimMontage));
	}
}
