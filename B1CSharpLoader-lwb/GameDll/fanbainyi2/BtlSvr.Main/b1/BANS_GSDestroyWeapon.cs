using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Destroy Weapon")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSDestroyWeapon")]
internal class BANS_GSDestroyWeapon : BANS_GSBase
{
	private static bool WeaponIndexList_IsValid;

	private static int WeaponIndexList_Offset;

	private static FFieldAddress WeaponIndexList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponIndexList_Marshaler;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSDestroyWeapon:WeaponIndexList")]
	public TArrayReadWrite<int> WeaponIndexList
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndexList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDestroyWeapon:WeaponIndexList");
				return null;
			}
			if (WeaponIndexList_Marshaler == null)
			{
				WeaponIndexList_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponIndexList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponIndexList_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponIndexList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDestroyWeapon:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ABGUCharacter aBGUCharacter = NotifyParam.owner as ABGUCharacter;
		if (!(aBGUCharacter != null) || !(aBGUCharacter.World != null))
		{
			return;
		}
		foreach (int weaponIndex in WeaponIndexList)
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(aBGUCharacter, weaponIndex);
			if (aActor != null)
			{
				BGU_UnrealWorldUtil.DestroyActor(aActor);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDestroyWeapon:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSDestroyWeapon bANS_GSDestroyWeapon = GCHelper.Find<b1.BANS_GSDestroyWeapon>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSDestroyWeapon.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSDestroyWeapon");
		NativeReflection.GetPropertyRef(ref WeaponIndexList_PropertyAddress, intPtr, "WeaponIndexList");
		WeaponIndexList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndexList");
		WeaponIndexList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndexList", Classes.FArrayProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDestroyWeapon:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSDestroyWeapon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSDestroyWeapon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSDestroyWeapon));
	}
}
