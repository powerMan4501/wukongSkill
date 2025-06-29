using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Hit Move Collision Scale")]
[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale")]
internal class BANS_GSHitMoveCollisionScale : BANS_GSBase
{
	private static bool CollisionCompName_IsValid;

	private static int CollisionCompName_Offset;

	private static bool UpdateCurve_IsValid;

	private static int UpdateCurve_Offset;

	private static bool NeedUpdateScale_IsValid;

	private static int NeedUpdateScale_Offset;

	private static FFieldAddress NeedUpdateScale_PropertyAddress;

	private static bool NeedSetRelaLocForScale_IsValid;

	private static int NeedSetRelaLocForScale_Offset;

	private static FFieldAddress NeedSetRelaLocForScale_PropertyAddress;

	private static bool NeedUpdateRadius_IsValid;

	private static int NeedUpdateRadius_Offset;

	private static FFieldAddress NeedUpdateRadius_PropertyAddress;

	private static bool HitMoveDir_IsValid;

	private static int HitMoveDir_Offset;

	private static FFieldAddress HitMoveDir_PropertyAddress;

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
	[DisplayName("碰撞推移Comp名")]
	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:CollisionCompName")]
	public FName CollisionCompName
	{
		get
		{
			CheckDestroyed();
			if (!CollisionCompName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:CollisionCompName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CollisionCompName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionCompName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:CollisionCompName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CollisionCompName_Offset), value);
			}
		}
	}

	[Tooltip("曲线的XY分别表示HalfHeight和Radius")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:UpdateCurve")]
	public UCurveVector UpdateCurve
	{
		get
		{
			CheckDestroyed();
			if (!UpdateCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:UpdateCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, UpdateCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdateCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:UpdateCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, UpdateCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedUpdateScale")]
	public bool NeedUpdateScale
	{
		get
		{
			CheckDestroyed();
			if (!NeedUpdateScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedUpdateScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedUpdateScale_Offset), 0, NeedUpdateScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedUpdateScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedUpdateScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedUpdateScale_Offset), 0, NeedUpdateScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedUpdateScale")]
	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedSetRelaLocForScale")]
	public bool NeedSetRelaLocForScale
	{
		get
		{
			CheckDestroyed();
			if (!NeedSetRelaLocForScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedSetRelaLocForScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedSetRelaLocForScale_Offset), 0, NeedSetRelaLocForScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedSetRelaLocForScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedSetRelaLocForScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedSetRelaLocForScale_Offset), 0, NeedSetRelaLocForScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedUpdateRadius")]
	public bool NeedUpdateRadius
	{
		get
		{
			CheckDestroyed();
			if (!NeedUpdateRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedUpdateRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedUpdateRadius_Offset), 0, NeedUpdateRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedUpdateRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:NeedUpdateRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedUpdateRadius_Offset), 0, NeedUpdateRadius_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("Default 指的是按照默认方式挤开")]
	[EditAnywhere]
	[DisplayName("推动方向（按照主角朝向为正方向计算）")]
	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:HitMoveDir")]
	public EHitMoveDir HitMoveDir
	{
		get
		{
			CheckDestroyed();
			if (!HitMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:HitMoveDir");
				return EHitMoveDir.Default;
			}
			return EnumMarshaler<EHitMoveDir>.FromNative(IntPtr.Add(base.Address, HitMoveDir_Offset), 0, HitMoveDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitMoveDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:HitMoveDir");
			}
			else
			{
				EnumMarshaler<EHitMoveDir>.ToNative(IntPtr.Add(base.Address, HitMoveDir_Offset), 0, HitMoveDir_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		NeedUpdateScale = true;
		NeedSetRelaLocForScale = true;
		NeedUpdateRadius = false;
		HitMoveDir = EHitMoveDir.Default;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		float totalScaleTime = NotifyParam.NotifyEndTime - NotifyParam.NotifyBeginTime;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetHitCollisionUpdateInfo.Invoke(CollisionCompName.ToString(), HitMoveDir, UpdateCurve, totalScaleTime, NeedUpdateScale, NeedUpdateRadius, NeedSetRelaLocForScale);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ResetHitCollisionScaleInfo.Invoke(CollisionCompName.ToString());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSHitMoveCollisionScale bANS_GSHitMoveCollisionScale = GCHelper.Find<b1.BANS_GSHitMoveCollisionScale>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSHitMoveCollisionScale.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSHitMoveCollisionScale bANS_GSHitMoveCollisionScale = GCHelper.Find<b1.BANS_GSHitMoveCollisionScale>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSHitMoveCollisionScale.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSHitMoveCollisionScale");
		CollisionCompName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CollisionCompName");
		CollisionCompName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CollisionCompName", Classes.FNameProperty);
		UpdateCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "UpdateCurve");
		UpdateCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UpdateCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref NeedUpdateScale_PropertyAddress, intPtr, "NeedUpdateScale");
		NeedUpdateScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedUpdateScale");
		NeedUpdateScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedUpdateScale", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedSetRelaLocForScale_PropertyAddress, intPtr, "NeedSetRelaLocForScale");
		NeedSetRelaLocForScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedSetRelaLocForScale");
		NeedSetRelaLocForScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedSetRelaLocForScale", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedUpdateRadius_PropertyAddress, intPtr, "NeedUpdateRadius");
		NeedUpdateRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedUpdateRadius");
		NeedUpdateRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedUpdateRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HitMoveDir_PropertyAddress, intPtr, "HitMoveDir");
		HitMoveDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitMoveDir");
		HitMoveDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitMoveDir", Classes.FEnumProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSHitMoveCollisionScale:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSHitMoveCollisionScale()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSHitMoveCollisionScale)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSHitMoveCollisionScale));
	}
}
