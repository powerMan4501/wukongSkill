using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Set Character Module Constraint Profile")]
[USharpPath("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile")]
internal class BANS_GSSetCharacterModuleConstraintProfile : BANS_GSBase
{
	private static bool EquipPosition_IsValid;

	private static int EquipPosition_Offset;

	private static FFieldAddress EquipPosition_PropertyAddress;

	private static bool ConstraintProfileName_IsValid;

	private static int ConstraintProfileName_Offset;

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

	[Category("Anim Notify Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:EquipPosition")]
	public EquipPosition EquipPosition
	{
		get
		{
			CheckDestroyed();
			if (!EquipPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:EquipPosition");
				return EquipPosition.Head;
			}
			return EnumMarshaler<EquipPosition>.FromNative(IntPtr.Add(base.Address, EquipPosition_Offset), 0, EquipPosition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EquipPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:EquipPosition");
			}
			else
			{
				EnumMarshaler<EquipPosition>.ToNative(IntPtr.Add(base.Address, EquipPosition_Offset), 0, EquipPosition_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:ConstraintProfileName")]
	public FName ConstraintProfileName
	{
		get
		{
			CheckDestroyed();
			if (!ConstraintProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:ConstraintProfileName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ConstraintProfileName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConstraintProfileName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:ConstraintProfileName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ConstraintProfileName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				int fromInstanceID = NotifyParam.FromInstanceID;
				int uniqueID = (int)GetUniqueID();
				bUS_GSEventCollection.Evt_SetCharacterModuleConstraintProfile.Invoke(EquipPosition, ConstraintProfileName, fromInstanceID, uniqueID);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				int fromInstanceID = NotifyParam.FromInstanceID;
				int uniqueID = (int)GetUniqueID();
				bUS_GSEventCollection.Evt_SetCharacterModuleConstraintProfile.Invoke(EquipPosition, in FName.None, fromInstanceID, uniqueID);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCharacterModuleConstraintProfile bANS_GSSetCharacterModuleConstraintProfile = GCHelper.Find<b1.BANS_GSSetCharacterModuleConstraintProfile>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSetCharacterModuleConstraintProfile.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCharacterModuleConstraintProfile bANS_GSSetCharacterModuleConstraintProfile = GCHelper.Find<b1.BANS_GSSetCharacterModuleConstraintProfile>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetCharacterModuleConstraintProfile.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile");
		NativeReflection.GetPropertyRef(ref EquipPosition_PropertyAddress, intPtr, "EquipPosition");
		EquipPosition_Offset = NativeReflection.GetPropertyOffset(intPtr, "EquipPosition");
		EquipPosition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EquipPosition", Classes.FEnumProperty);
		ConstraintProfileName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConstraintProfileName");
		ConstraintProfileName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConstraintProfileName", Classes.FNameProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCharacterModuleConstraintProfile:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSetCharacterModuleConstraintProfile()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetCharacterModuleConstraintProfile)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetCharacterModuleConstraintProfile));
	}
}
