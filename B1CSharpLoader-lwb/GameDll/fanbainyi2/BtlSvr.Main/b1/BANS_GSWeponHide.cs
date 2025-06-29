using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Weapon Hide")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSWeponHide")]
internal class BANS_GSWeponHide : BANS_GSBase
{
	private static bool WeaponIndex_IsValid;

	private static int WeaponIndex_Offset;

	private static FFieldAddress WeaponIndex_PropertyAddress;

	private TArrayReadWriteMarshaler<int> WeaponIndex_Marshaler;

	private static bool IsHidden_IsValid;

	private static int IsHidden_Offset;

	private static FFieldAddress IsHidden_PropertyAddress;

	private static bool OpenCollisionIfNotHidden_IsValid;

	private static int OpenCollisionIfNotHidden_Offset;

	private static FFieldAddress OpenCollisionIfNotHidden_PropertyAddress;

	private static bool NotRestore_IsValid;

	private static int NotRestore_Offset;

	private static FFieldAddress NotRestore_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

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
	[USharpPath("/Script/b1-Managed.BANS_GSWeponHide:WeaponIndex")]
	public TArrayReadWrite<int> WeaponIndex
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeponHide:WeaponIndex");
				return null;
			}
			if (WeaponIndex_Marshaler == null)
			{
				WeaponIndex_Marshaler = new TArrayReadWriteMarshaler<int>(1, WeaponIndex_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return WeaponIndex_Marshaler.FromNative(IntPtr.Add(base.Address, WeaponIndex_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSWeponHide:IsHidden")]
	public bool IsHidden
	{
		get
		{
			CheckDestroyed();
			if (!IsHidden_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeponHide:IsHidden");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsHidden_Offset), 0, IsHidden_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsHidden_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeponHide:IsHidden");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsHidden_Offset), 0, IsHidden_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("暂时没用")]
	[USharpPath("/Script/b1-Managed.BANS_GSWeponHide:OpenCollisionIfNotHidden")]
	public bool OpenCollisionIfNotHidden
	{
		get
		{
			CheckDestroyed();
			if (!OpenCollisionIfNotHidden_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeponHide:OpenCollisionIfNotHidden");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenCollisionIfNotHidden_Offset), 0, OpenCollisionIfNotHidden_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenCollisionIfNotHidden_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeponHide:OpenCollisionIfNotHidden");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenCollisionIfNotHidden_Offset), 0, OpenCollisionIfNotHidden_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSWeponHide:NotRestore")]
	public bool NotRestore
	{
		get
		{
			CheckDestroyed();
			if (!NotRestore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeponHide:NotRestore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NotRestore_Offset), 0, NotRestore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotRestore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSWeponHide:NotRestore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NotRestore_Offset), 0, NotRestore_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSWeponHide:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			SetWeaponHideOrShow(bGUCharacterCS, IsHidden);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSWeponHide:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!NotRestore)
		{
			BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				SetWeaponHideOrShow(bGUCharacterCS, !IsHidden);
			}
		}
	}

	private void SetWeaponHideOrShow(BGUCharacterCS OwnerChr, bool _IsHidden)
	{
		foreach (int item in WeaponIndex)
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(OwnerChr, item);
			if (aActor != null)
			{
				BGUWeaponBase bGUWeaponBase = aActor as BGUWeaponBase;
				if (bGUWeaponBase != null)
				{
					bGUWeaponBase.SetActorHiddenInGame(_IsHidden);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSWeponHide:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSWeponHide bANS_GSWeponHide = GCHelper.Find<b1.BANS_GSWeponHide>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSWeponHide.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSWeponHide:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSWeponHide bANS_GSWeponHide = GCHelper.Find<b1.BANS_GSWeponHide>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSWeponHide.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSWeponHide");
		NativeReflection.GetPropertyRef(ref WeaponIndex_PropertyAddress, intPtr, "WeaponIndex");
		WeaponIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndex");
		WeaponIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndex", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsHidden_PropertyAddress, intPtr, "IsHidden");
		IsHidden_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsHidden");
		IsHidden_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsHidden", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenCollisionIfNotHidden_PropertyAddress, intPtr, "OpenCollisionIfNotHidden");
		OpenCollisionIfNotHidden_Offset = NativeReflection.GetPropertyOffset(intPtr, "OpenCollisionIfNotHidden");
		OpenCollisionIfNotHidden_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OpenCollisionIfNotHidden", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NotRestore_PropertyAddress, intPtr, "NotRestore");
		NotRestore_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotRestore");
		NotRestore_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotRestore", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSWeponHide:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSWeponHide:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSWeponHide()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSWeponHide)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSWeponHide));
	}
}
