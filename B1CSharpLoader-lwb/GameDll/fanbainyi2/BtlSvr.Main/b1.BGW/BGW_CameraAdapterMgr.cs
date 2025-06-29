using System;
using System.Collections.Generic;
using b1.GSMUI.GSWidget;
using b1.Plugins.GSEngineExtent;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_CameraAdapterMgr")]
public class BGW_CameraAdapterMgr : GameInstanceSystemBaseUObj
{
	private float NormalCameraFOV = 90f;

	private string RefCameraFOVTagPrefix = "GSRefFOV_";

	private APlayerCameraManager PlayerCameraManager;

	private UCameraComponent LastHandledCameraComponent;

	private HashSet<GSGridConScreenAdapter> GSGridConScreenAdapterSet = new HashSet<GSGridConScreenAdapter>();

	private int TickStatID = -1;

	private bool IsGMForceClose;

	private static bool GSViewPortHelper_IsValid;

	private static int GSViewPortHelper_Offset;

	private static bool OnViewPortResized_IsValid;

	private static IntPtr OnViewPortResized_FunctionAddress;

	private static int OnViewPortResized_ParamsSize;

	private static bool OnViewPortResized_NewWidth_IsValid;

	private static int OnViewPortResized_NewWidth_Offset;

	private static bool OnViewPortResized_NewHeight_IsValid;

	private static int OnViewPortResized_NewHeight_Offset;

	public override bool bTickEnabled => true;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_CameraAdapterMgr:GSViewPortHelper")]
	public UGSViewPortHelper GSViewPortHelper
	{
		get
		{
			CheckDestroyed();
			if (!GSViewPortHelper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CameraAdapterMgr:GSViewPortHelper");
				return null;
			}
			return UObjectMarshaler<UGSViewPortHelper>.FromNative(IntPtr.Add(base.Address, GSViewPortHelper_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSViewPortHelper_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_CameraAdapterMgr:GSViewPortHelper");
			}
			else
			{
				UObjectMarshaler<UGSViewPortHelper>.ToNative(IntPtr.Add(base.Address, GSViewPortHelper_Offset), value);
			}
		}
	}

	public static BGW_CameraAdapterMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_CameraAdapterMgr>(Context);
	}

	private bool IsGMForceCloseAdapt()
	{
		if (GSGameplayCVar.CVar_CloseCamAdapt.GetValueInGameThread() != 0)
		{
			return true;
		}
		return false;
	}

	public void UnRegUIGSGridConScreenAdapter(GSGridConScreenAdapter RefGSGridConScreenAdapter)
	{
		GSGridConScreenAdapterSet.Remove(RefGSGridConScreenAdapter);
	}

	public void RegUIGSGridConScreenAdapter(GSGridConScreenAdapter RefGSGridConScreenAdapter)
	{
		GSGridConScreenAdapterSet.Add(RefGSGridConScreenAdapter);
		RefGSGridConScreenAdapter.UpdateForAdapt(0f);
	}

	public void SetMaintainXYFOV(EAspectRatioAxisConstraint TargeRatio)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (!(firstLocalPlayerController == null))
		{
			UGSE_CameraUtilFuncLib.SetLocalPlayerAspectRatioAxisConstraint(firstLocalPlayerController, TargeRatio);
		}
	}

	public void UIGSGridConAdatperUpdate()
	{
		foreach (GSGridConScreenAdapter item in GSGridConScreenAdapterSet)
		{
			item.UpdateForAdapt(0f);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_CameraAdapterMgr:OnViewPortResized")]
	public void OnViewPortResized(int NewWidth, int NewHeight)
	{
		BGU_CameraAdapterUtilV2.TickUpdateCachedData(this, 0f);
		DoAdapterCameraRatio(IsForce: true);
		UIGSGridConAdatperUpdate();
	}

	public override void OnInit()
	{
		IsGMForceClose = IsGMForceCloseAdapt();
		GSViewPortHelper = UGSE_UMGFuncLib.CreateGSViewPortHelper(this);
		GSViewPortHelper.OnViewPortResized.Bind(OnViewPortResized);
	}

	private UCameraComponent GetWorkingCameraComponent(out bool IsPlayer, AActor NewViewTarget)
	{
		IsPlayer = false;
		PlayerCameraManager = UGameplayStatics.GetPlayerCameraManager(this, 0);
		if (PlayerCameraManager == null)
		{
			return null;
		}
		AActor aActor = NewViewTarget;
		if (aActor == null)
		{
			aActor = UGSE_CameraUtilFuncLib.GetCameraViewTarget(PlayerCameraManager);
		}
		_ = BGU_CameraAdapterUtilV2.IsLogDebug;
		if (aActor != null)
		{
			_ = BGU_CameraAdapterUtilV2.IsLogDebug;
		}
		AActor aActor2 = aActor;
		_ = BGU_CameraAdapterUtilV2.IsLogDebug;
		if (aActor2 == null)
		{
			return null;
		}
		IsPlayer = aActor2 is BGUPlayerCharacterCS;
		foreach (UActorComponent item in aActor2.GetComponentsByClass(UClass.GetClass<UCameraComponent>()))
		{
			UCameraComponent uCameraComponent = item as UCameraComponent;
			if (uCameraComponent != null && uCameraComponent.IsActive())
			{
				return uCameraComponent;
			}
		}
		return null;
	}

	private float CalcFOVFromComponentTag(UCameraComponent TargetCameraComponent)
	{
		float Ret = 0f;
		for (int i = 0; i < TargetCameraComponent.ComponentTags.Count; i++)
		{
			string text = TargetCameraComponent.ComponentTags[i].ToString();
			if (text.Contains(RefCameraFOVTagPrefix) && StringParseHelper.SafeTryFloatParse(text.Replace(RefCameraFOVTagPrefix, ""), out Ret, IsNeedCatch: false))
			{
				return Ret;
			}
		}
		return Ret;
	}

	public int DoAdapterCameraOnce(AActor NewViewTarget)
	{
		return DoAdapterCameraRatio(IsForce: true, NewViewTarget);
	}

	private int DoAdapterCameraRatio(bool IsForce, AActor NewViewTarget = null)
	{
		if (IsGMForceClose)
		{
			_ = BGU_CameraAdapterUtilV2.IsLogDebug;
			return 0;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			_ = BGU_CameraAdapterUtilV2.IsLogDebug;
			return 1;
		}
		bool IsPlayer = false;
		UCameraComponent workingCameraComponent = GetWorkingCameraComponent(out IsPlayer, NewViewTarget);
		if (workingCameraComponent == null)
		{
			_ = BGU_CameraAdapterUtilV2.IsLogDebug;
			return 2;
		}
		_ = BGU_CameraAdapterUtilV2.IsLogDebug;
		if (workingCameraComponent == LastHandledCameraComponent && !IsForce)
		{
			return 3;
		}
		BGU_CameraAdapterUtilV2.QuickCalcCameraRatio(firstLocalPlayerController, out var TargetRatio, out var ConstraintAspectRatioType, out var _, out var _);
		_ = BGU_CameraAdapterUtilV2.IsLogDebug;
		bool flag = false;
		if (ConstraintAspectRatioType != EGSConstraintAspectRatioType.None)
		{
			flag = true;
		}
		UCineCameraComponent uCineCameraComponent = workingCameraComponent as UCineCameraComponent;
		if (uCineCameraComponent != null)
		{
			if (TargetRatio != uCineCameraComponent.Filmback.SensorAspectRatio)
			{
				float sensorHeight = uCineCameraComponent.Filmback.SensorHeight;
				FCameraFilmbackSettings filmback = uCineCameraComponent.Filmback;
				filmback.SensorWidth = sensorHeight * TargetRatio;
				filmback.SensorAspectRatio = TargetRatio;
				uCineCameraComponent.Filmback = filmback;
			}
		}
		else
		{
			if (!IsPlayer)
			{
				float num = CalcFOVFromComponentTag(workingCameraComponent);
				if (num == 0f)
				{
					num = NormalCameraFOV;
				}
				float num2 = BGU_CameraAdapterUtilV2.QuickCalcCameraAdapterFOV(firstLocalPlayerController, num);
				_ = BGU_CameraAdapterUtilV2.IsLogDebug;
				if (num2 != workingCameraComponent.FieldOfView)
				{
					workingCameraComponent.SetFieldOfView(num2);
				}
			}
			if (TargetRatio != workingCameraComponent.AspectRatio)
			{
				workingCameraComponent.AspectRatio = TargetRatio;
			}
		}
		if (workingCameraComponent.ConstrainAspectRatio != flag)
		{
			workingCameraComponent.ConstrainAspectRatio = flag;
		}
		LastHandledCameraComponent = workingCameraComponent;
		return 0;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickGroup == 8)
		{
			BGU_CameraAdapterUtilV2.TickUpdateCachedData(this, DeltaTime);
			DoAdapterCameraRatio(IsForce: true);
			UIGSGridConAdatperUpdate();
		}
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_CameraAdapterMgr:OnViewPortResized")]
	private static void OnViewPortResized__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_CameraAdapterMgr bGW_CameraAdapterMgr = GCHelper.Find<BGW_CameraAdapterMgr>(obj);
		int newWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnViewPortResized_NewWidth_Offset));
		int newHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnViewPortResized_NewHeight_Offset));
		bGW_CameraAdapterMgr.OnViewPortResized(newWidth, newHeight);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_CameraAdapterMgr");
		GSViewPortHelper_Offset = NativeReflection.GetPropertyOffset(intPtr, "GSViewPortHelper");
		GSViewPortHelper_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GSViewPortHelper", Classes.FObjectProperty);
		OnViewPortResized_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnViewPortResized");
		OnViewPortResized_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewPortResized_FunctionAddress);
		OnViewPortResized_NewWidth_Offset = NativeReflection.GetPropertyOffset(OnViewPortResized_FunctionAddress, "NewWidth");
		OnViewPortResized_NewWidth_IsValid = NativeReflection.ValidatePropertyClass(OnViewPortResized_FunctionAddress, "NewWidth", Classes.FIntProperty);
		OnViewPortResized_NewHeight_Offset = NativeReflection.GetPropertyOffset(OnViewPortResized_FunctionAddress, "NewHeight");
		OnViewPortResized_NewHeight_IsValid = NativeReflection.ValidatePropertyClass(OnViewPortResized_FunctionAddress, "NewHeight", Classes.FIntProperty);
		OnViewPortResized_IsValid = OnViewPortResized_FunctionAddress != IntPtr.Zero && OnViewPortResized_NewWidth_IsValid && OnViewPortResized_NewHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_CameraAdapterMgr:OnViewPortResized", OnViewPortResized_IsValid);
	}

	static BGW_CameraAdapterMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_CameraAdapterMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_CameraAdapterMgr));
	}
}
