using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS  SetCompVisibility")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility")]
internal class BANS_GSSetCompVisibility : BANS_GSBase
{
	private static bool ForOwnerActor_IsValid;

	private static int ForOwnerActor_Offset;

	private static FFieldAddress ForOwnerActor_PropertyAddress;

	private static bool ForWeaponActor_IsValid;

	private static int ForWeaponActor_Offset;

	private static FFieldAddress ForWeaponActor_PropertyAddress;

	private static bool IsVisible_IsValid;

	private static int IsVisible_Offset;

	private static FFieldAddress IsVisible_PropertyAddress;

	private static bool CompTagName_IsValid;

	private static int CompTagName_Offset;

	private static bool NeedRecoverInEnd_IsValid;

	private static int NeedRecoverInEnd_Offset;

	private static FFieldAddress NeedRecoverInEnd_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:ForOwnerActor")]
	public bool ForOwnerActor
	{
		get
		{
			CheckDestroyed();
			if (!ForOwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:ForOwnerActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForOwnerActor_Offset), 0, ForOwnerActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForOwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:ForOwnerActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForOwnerActor_Offset), 0, ForOwnerActor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:ForWeaponActor")]
	public bool ForWeaponActor
	{
		get
		{
			CheckDestroyed();
			if (!ForWeaponActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:ForWeaponActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForWeaponActor_Offset), 0, ForWeaponActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForWeaponActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:ForWeaponActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForWeaponActor_Offset), 0, ForWeaponActor_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:IsVisible")]
	public bool IsVisible
	{
		get
		{
			CheckDestroyed();
			if (!IsVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:IsVisible");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsVisible_Offset), 0, IsVisible_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:IsVisible");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsVisible_Offset), 0, IsVisible_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:CompTagName")]
	public FName CompTagName
	{
		get
		{
			CheckDestroyed();
			if (!CompTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:CompTagName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTagName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:CompTagName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTagName_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:NeedRecoverInEnd")]
	public bool NeedRecoverInEnd
	{
		get
		{
			CheckDestroyed();
			if (!NeedRecoverInEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:NeedRecoverInEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRecoverInEnd_Offset), 0, NeedRecoverInEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRecoverInEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCompVisibility:NeedRecoverInEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRecoverInEnd_Offset), 0, NeedRecoverInEnd_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (NotifyParam.owner == null)
		{
			return;
		}
		List<AActor> list = new List<AActor>();
		if (ForOwnerActor)
		{
			list.Add(NotifyParam.owner);
		}
		if (ForWeaponActor)
		{
			int num = BGUFunctionLibraryCS.BGUGetWeaponNum(NotifyParam.owner);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(NotifyParam.owner, i);
					if (!(aActor == null))
					{
						list.Add(aActor);
					}
				}
			}
		}
		foreach (AActor item in list)
		{
			SetCompVisibilityToActor(item, IsVisible);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (!NeedRecoverInEnd)
		{
			return;
		}
		List<AActor> list = new List<AActor>();
		if (ForOwnerActor)
		{
			list.Add(NotifyParam.owner);
		}
		if (ForWeaponActor)
		{
			int num = BGUFunctionLibraryCS.BGUGetWeaponNum(NotifyParam.owner);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(NotifyParam.owner, i);
					if (!(aActor == null))
					{
						list.Add(aActor);
					}
				}
			}
		}
		foreach (AActor item in list)
		{
			SetCompVisibilityToActor(item, !IsVisible);
		}
	}

	private void SetCompVisibilityToActor(AActor Target, bool bIsVisible)
	{
		if (Target == null)
		{
			return;
		}
		List<UActorComponent> componentsByTag = Target.GetComponentsByTag(UClass.GetClass<USceneComponent>(), CompTagName);
		if (componentsByTag == null || componentsByTag.Count <= 0)
		{
			return;
		}
		foreach (UActorComponent item in componentsByTag)
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (uSceneComponent != null)
			{
				uSceneComponent.SetVisibility(bIsVisible);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCompVisibility bANS_GSSetCompVisibility = GCHelper.Find<b1.BANS_GSSetCompVisibility>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSetCompVisibility.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCompVisibility bANS_GSSetCompVisibility = GCHelper.Find<b1.BANS_GSSetCompVisibility>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSSetCompVisibility.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCompVisibility bANS_GSSetCompVisibility = GCHelper.Find<b1.BANS_GSSetCompVisibility>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetCompVisibility.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetCompVisibility");
		NativeReflection.GetPropertyRef(ref ForOwnerActor_PropertyAddress, intPtr, "ForOwnerActor");
		ForOwnerActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForOwnerActor");
		ForOwnerActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForOwnerActor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ForWeaponActor_PropertyAddress, intPtr, "ForWeaponActor");
		ForWeaponActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForWeaponActor");
		ForWeaponActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForWeaponActor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsVisible_PropertyAddress, intPtr, "IsVisible");
		IsVisible_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsVisible");
		IsVisible_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsVisible", Classes.FBoolProperty);
		CompTagName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTagName");
		CompTagName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTagName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref NeedRecoverInEnd_PropertyAddress, intPtr, "NeedRecoverInEnd");
		NeedRecoverInEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedRecoverInEnd");
		NeedRecoverInEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedRecoverInEnd", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCompVisibility:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSetCompVisibility()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetCompVisibility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetCompVisibility));
	}
}
