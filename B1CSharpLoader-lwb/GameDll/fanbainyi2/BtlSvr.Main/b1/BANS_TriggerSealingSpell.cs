using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Trigger Sealing Spell")]
[USharpPath("/Script/b1-Managed.BANS_TriggerSealingSpell")]
internal class BANS_TriggerSealingSpell : BANS_GSBase
{
	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_TriggerSealingSpell:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_TriggerSealingSpell.Invoke();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_TriggerSealingSpell:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_TriggerSealingSpell bANS_TriggerSealingSpell = GCHelper.Find<b1.BANS_TriggerSealingSpell>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_TriggerSealingSpell.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BANS_TriggerSealingSpell");
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_TriggerSealingSpell:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_TriggerSealingSpell()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_TriggerSealingSpell)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_TriggerSealingSpell));
	}
}
