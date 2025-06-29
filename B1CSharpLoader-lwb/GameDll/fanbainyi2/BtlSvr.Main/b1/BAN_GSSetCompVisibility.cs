using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN GSSetCompVisibility")]
[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility")]
internal class BAN_GSSetCompVisibility : BAN_GSBase
{
	private static bool ForOwnerActor_IsValid;

	private static int ForOwnerActor_Offset;

	private static FFieldAddress ForOwnerActor_PropertyAddress;

	private static bool ForWeaponActor_IsValid;

	private static int ForWeaponActor_Offset;

	private static FFieldAddress ForWeaponActor_PropertyAddress;

	private static bool CompClass_IsValid;

	private static int CompClass_Offset;

	private static bool IsVisible_IsValid;

	private static int IsVisible_Offset;

	private static FFieldAddress IsVisible_PropertyAddress;

	private static bool CompTagName_IsValid;

	private static int CompTagName_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility:ForOwnerActor")]
	public bool ForOwnerActor
	{
		get
		{
			CheckDestroyed();
			if (!ForOwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:ForOwnerActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForOwnerActor_Offset), 0, ForOwnerActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForOwnerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:ForOwnerActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForOwnerActor_Offset), 0, ForOwnerActor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility:ForWeaponActor")]
	public bool ForWeaponActor
	{
		get
		{
			CheckDestroyed();
			if (!ForWeaponActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:ForWeaponActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForWeaponActor_Offset), 0, ForWeaponActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForWeaponActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:ForWeaponActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForWeaponActor_Offset), 0, ForWeaponActor_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility:CompClass")]
	public TSubclassOf<UActorComponent> CompClass
	{
		get
		{
			CheckDestroyed();
			if (!CompClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:CompClass");
				return default(TSubclassOf<UActorComponent>);
			}
			return TSubclassOfMarshaler<UActorComponent>.FromNative(IntPtr.Add(base.Address, CompClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:CompClass");
			}
			else
			{
				TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(base.Address, CompClass_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility:IsVisible")]
	public bool IsVisible
	{
		get
		{
			CheckDestroyed();
			if (!IsVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:IsVisible");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsVisible_Offset), 0, IsVisible_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsVisible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:IsVisible");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsVisible_Offset), 0, IsVisible_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility:CompTagName")]
	public FName CompTagName
	{
		get
		{
			CheckDestroyed();
			if (!CompTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:CompTagName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTagName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetCompVisibility:CompTagName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTagName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSetCompVisibility:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
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
					if (aActor != null)
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

	private void SetCompVisibilityToActor(AActor Target, bool bIsVisible)
	{
		if (Target == null)
		{
			return;
		}
		List<UActorComponent> componentsByTag = Target.GetComponentsByTag(CompClass, CompTagName);
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

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSetCompVisibility:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSetCompVisibility bAN_GSSetCompVisibility = GCHelper.Find<b1.BAN_GSSetCompVisibility>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSetCompVisibility.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSetCompVisibility:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSetCompVisibility bAN_GSSetCompVisibility = GCHelper.Find<b1.BAN_GSSetCompVisibility>(obj);
		bool value = bAN_GSSetCompVisibility.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSetCompVisibility");
		NativeReflection.GetPropertyRef(ref ForOwnerActor_PropertyAddress, intPtr, "ForOwnerActor");
		ForOwnerActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForOwnerActor");
		ForOwnerActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForOwnerActor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ForWeaponActor_PropertyAddress, intPtr, "ForWeaponActor");
		ForWeaponActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForWeaponActor");
		ForWeaponActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForWeaponActor", Classes.FBoolProperty);
		CompClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompClass");
		CompClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref IsVisible_PropertyAddress, intPtr, "IsVisible");
		IsVisible_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsVisible");
		IsVisible_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsVisible", Classes.FBoolProperty);
		CompTagName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTagName");
		CompTagName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTagName", Classes.FNameProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSetCompVisibility:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSetCompVisibility:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSSetCompVisibility()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSSetCompVisibility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSSetCompVisibility));
	}
}
