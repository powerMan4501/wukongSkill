using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN QTE Dec HP")]
[USharpPath("/Script/b1-Managed.BAN_GSQTEDecHP")]
internal class BAN_GSQTEDecHP : BAN_GSBase
{
	private static bool DecHPPercent_IsValid;

	private static int DecHPPercent_Offset;

	private static bool bIsDecToZero_IsValid;

	private static int bIsDecToZero_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("Play Beam FX")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSQTEDecHP:DecHPPercent")]
	public float DecHPPercent
	{
		get
		{
			CheckDestroyed();
			if (!DecHPPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSQTEDecHP:DecHPPercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DecHPPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DecHPPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSQTEDecHP:DecHPPercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DecHPPercent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("Play Beam FX")]
	[USharpPath("/Script/b1-Managed.BAN_GSQTEDecHP:bIsDecToZero")]
	public int bIsDecToZero
	{
		get
		{
			CheckDestroyed();
			if (!bIsDecToZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSQTEDecHP:bIsDecToZero");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, bIsDecToZero_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!bIsDecToZero_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSQTEDecHP:bIsDecToZero");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, bIsDecToZero_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSQTEDecHP:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (aActor != null)
		{
			BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_QTEDecHP.Invoke(DecHPPercent, bIsDecToZero);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSQTEDecHP:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSQTEDecHP bAN_GSQTEDecHP = GCHelper.Find<b1.BAN_GSQTEDecHP>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSQTEDecHP.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSQTEDecHP");
		DecHPPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "DecHPPercent");
		DecHPPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DecHPPercent", Classes.FFloatProperty);
		bIsDecToZero_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsDecToZero");
		bIsDecToZero_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsDecToZero", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSQTEDecHP:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSQTEDecHP()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSQTEDecHP)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSQTEDecHP));
	}
}
