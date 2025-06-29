using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Teleport")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_Teleport")]
internal class BANS_Teleport : BANS_GSBase
{
	private static bool TeleportPointType_IsValid;

	private static int TeleportPointType_Offset;

	private static FFieldAddress TeleportPointType_PropertyAddress;

	private static bool TeleportPointLocationOffset_IsValid;

	private static int TeleportPointLocationOffset_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("传送点位置类型")]
	[USharpPath("/Script/b1-Managed.BANS_Teleport:TeleportPointType")]
	public ETeleportPointType TeleportPointType
	{
		get
		{
			CheckDestroyed();
			if (!TeleportPointType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_Teleport:TeleportPointType");
				return ETeleportPointType.CachedInteractItem;
			}
			return EnumMarshaler<ETeleportPointType>.FromNative(IntPtr.Add(base.Address, TeleportPointType_Offset), 0, TeleportPointType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TeleportPointType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_Teleport:TeleportPointType");
			}
			else
			{
				EnumMarshaler<ETeleportPointType>.ToNative(IntPtr.Add(base.Address, TeleportPointType_Offset), 0, TeleportPointType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("传送点位置Offset")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_Teleport:TeleportPointLocationOffset")]
	public FVector TeleportPointLocationOffset
	{
		get
		{
			CheckDestroyed();
			if (!TeleportPointLocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_Teleport:TeleportPointLocationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, TeleportPointLocationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeleportPointLocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_Teleport:TeleportPointLocationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, TeleportPointLocationOffset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		TeleportPointLocationOffset = FVector.ZeroVector;
		if (UBGUFunctionLibraryForCS.BGUGetIsEditor())
		{
			base.NotifyColor = FColor.Blue;
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_Teleport:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (bGUCharacterCS != null && TeleportPointType == ETeleportPointType.CachedInteractItem)
		{
			IBUC_AiInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AiInteractData, BUC_AiInteractData>(bGUCharacterCS);
			if (readOnlyData != null && ECSExtension.ToActor(readOnlyData.CurrentInteractingEntityRef) != null)
			{
				FTransform matchingPosTargetTransform = readOnlyData.MatchingPosTargetTransform;
				matchingPosTargetTransform.SetLocation(matchingPosTargetTransform.GetLocation() + TeleportPointLocationOffset);
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_TeleportMoveByTrans.Invoke(matchingPosTargetTransform);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_Teleport:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_Teleport bANS_Teleport = GCHelper.Find<b1.BANS_Teleport>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_Teleport.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_Teleport");
		NativeReflection.GetPropertyRef(ref TeleportPointType_PropertyAddress, intPtr, "TeleportPointType");
		TeleportPointType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportPointType");
		TeleportPointType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportPointType", Classes.FEnumProperty);
		TeleportPointLocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportPointLocationOffset");
		TeleportPointLocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportPointLocationOffset", Classes.FStructProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_Teleport:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_Teleport()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_Teleport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_Teleport));
	}
}
