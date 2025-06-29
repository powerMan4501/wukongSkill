using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintSpawnableComponent]
[ClassGroup("GSSimProjectionUIComp")]
[USharpPath("/Script/b1-Managed.BGUStaminaBarUIComp")]
public class BGUStaminaBarUIComp : USceneComponentTickable
{
	private USceneComponent _staminaBarSockPos1;

	private USceneComponent _staminaBarSockPos2;

	private USceneComponent _staminaBarSockPos3;

	private USceneComponent _staminaBarSockPos4;

	private static bool DrawDebug_IsValid;

	private static int DrawDebug_Offset;

	private static FFieldAddress DrawDebug_PropertyAddress;

	private static bool PlayerCameraManager_IsValid;

	private static int PlayerCameraManager_Offset;

	private static bool SetGSEnabled_IsValid;

	private static IntPtr SetGSEnabled_FunctionAddress;

	private static int SetGSEnabled_ParamsSize;

	private static bool SetGSEnabled_IsEnabled_IsValid;

	private static int SetGSEnabled_IsEnabled_Offset;

	private static FFieldAddress SetGSEnabled_IsEnabled_PropertyAddress;

	private static bool BeginPlayGS_IsValid;

	private static IntPtr BeginPlayGS_FunctionAddress;

	private static int BeginPlayGS_ParamsSize;

	private static bool TickComponentGS_IsValid;

	private static IntPtr TickComponentGS_FunctionAddress;

	private static int TickComponentGS_ParamsSize;

	private static bool TickComponentGS_DeltaTime_IsValid;

	private static int TickComponentGS_DeltaTime_Offset;

	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "是否显示debug图形")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUStaminaBarUIComp:DrawDebug")]
	public bool DrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStaminaBarUIComp:DrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStaminaBarUIComp:DrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	private bool IsGSEnabled { get; set; }

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUStaminaBarUIComp:PlayerCameraManager")]
	public APlayerCameraManager PlayerCameraManager
	{
		get
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStaminaBarUIComp:PlayerCameraManager");
				return null;
			}
			return UObjectMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStaminaBarUIComp:PlayerCameraManager");
			}
			else
			{
				UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DrawDebug = false;
		IsGSEnabled = true;
		SetTickGroup(ETickingGroup.PostUpdateWork);
	}

	[USharpPath("/Script/b1-Managed.BGUStaminaBarUIComp:BeginPlayGS")]
	protected override void BeginPlayGS_Implementation()
	{
		PlayerCameraManager = UGameplayStatics.GetPlayerCameraManager(GetOwner().World, 0);
		GetChildrenComponents(bIncludeAllDescendants: true, out var Children);
		foreach (USceneComponent item in Children)
		{
			if (item.ComponentHasTag(B1GlobalFNames.GSSBarSockPos1))
			{
				_staminaBarSockPos1 = item;
			}
			if (item.ComponentHasTag(B1GlobalFNames.GSSBarSockPos2))
			{
				_staminaBarSockPos2 = item;
			}
			if (item.ComponentHasTag(B1GlobalFNames.GSSBarSockPos3))
			{
				_staminaBarSockPos3 = item;
			}
			if (item.ComponentHasTag(B1GlobalFNames.GSSBarSockPos4))
			{
				_staminaBarSockPos4 = item;
			}
		}
	}

	public void GetRefPosOut(out FVector RefPos1, out FVector RefPos2, out FVector RefPos3, out FVector RefPos4)
	{
		RefPos1 = FVector.ZeroVector;
		RefPos2 = FVector.ZeroVector;
		RefPos3 = FVector.ZeroVector;
		RefPos4 = FVector.ZeroVector;
		if (_staminaBarSockPos1 != null)
		{
			RefPos1 = _staminaBarSockPos1.GetWorldLocation();
		}
		if (_staminaBarSockPos2 != null)
		{
			RefPos2 = _staminaBarSockPos2.GetWorldLocation();
		}
		if (_staminaBarSockPos3 != null)
		{
			RefPos3 = _staminaBarSockPos3.GetWorldLocation();
		}
		if (_staminaBarSockPos4 != null)
		{
			RefPos4 = _staminaBarSockPos4.GetWorldLocation();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[UMeta(MD.ToolTip, "是否正常工作")]
	[USharpPath("/Script/b1-Managed.BGUStaminaBarUIComp:SetGSEnabled")]
	public void SetGSEnabled(bool IsEnabled)
	{
		IsGSEnabled = IsEnabled;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUStaminaBarUIComp:TickComponentGS")]
	protected override void TickComponentGS_Implementation(float DeltaTime)
	{
		_ = DrawDebug;
		FRotator cameraRotation = PlayerCameraManager.GetCameraRotation();
		FRotator worldRotation = GetWorldRotation();
		worldRotation.Yaw = cameraRotation.Yaw;
		SetWorldRotation(worldRotation, bSweep: false, out var _, bTeleport: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUStaminaBarUIComp:SetGSEnabled")]
	private static void SetGSEnabled__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUStaminaBarUIComp bGUStaminaBarUIComp = GCHelper.Find<BGUStaminaBarUIComp>(obj);
		bool gSEnabled = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetGSEnabled_IsEnabled_Offset), 0, SetGSEnabled_IsEnabled_PropertyAddress.Address);
		bGUStaminaBarUIComp.SetGSEnabled(gSEnabled);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUStaminaBarUIComp:BeginPlayGS")]
	private static void BeginPlayGS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUStaminaBarUIComp bGUStaminaBarUIComp = GCHelper.Find<BGUStaminaBarUIComp>(obj);
		bGUStaminaBarUIComp.BeginPlayGS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUStaminaBarUIComp:TickComponentGS")]
	private static void TickComponentGS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUStaminaBarUIComp bGUStaminaBarUIComp = GCHelper.Find<BGUStaminaBarUIComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentGS_DeltaTime_Offset));
		bGUStaminaBarUIComp.TickComponentGS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUStaminaBarUIComp");
		NativeReflection.GetPropertyRef(ref DrawDebug_PropertyAddress, intPtr, "DrawDebug");
		DrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebug");
		DrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebug", Classes.FBoolProperty);
		PlayerCameraManager_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerCameraManager");
		PlayerCameraManager_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerCameraManager", Classes.FObjectProperty);
		SetGSEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSEnabled");
		SetGSEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSEnabled_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetGSEnabled_IsEnabled_PropertyAddress, SetGSEnabled_FunctionAddress, "IsEnabled");
		SetGSEnabled_IsEnabled_Offset = NativeReflection.GetPropertyOffset(SetGSEnabled_FunctionAddress, "IsEnabled");
		SetGSEnabled_IsEnabled_IsValid = NativeReflection.ValidatePropertyClass(SetGSEnabled_FunctionAddress, "IsEnabled", Classes.FBoolProperty);
		SetGSEnabled_IsValid = SetGSEnabled_FunctionAddress != IntPtr.Zero && SetGSEnabled_IsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUStaminaBarUIComp:SetGSEnabled", SetGSEnabled_IsValid);
		BeginPlayGS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayGS");
		BeginPlayGS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayGS_FunctionAddress);
		BeginPlayGS_IsValid = BeginPlayGS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUStaminaBarUIComp:BeginPlayGS", BeginPlayGS_IsValid);
		TickComponentGS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentGS");
		TickComponentGS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentGS_FunctionAddress);
		TickComponentGS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentGS_FunctionAddress, "DeltaTime");
		TickComponentGS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentGS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentGS_IsValid = TickComponentGS_FunctionAddress != IntPtr.Zero && TickComponentGS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUStaminaBarUIComp:TickComponentGS", TickComponentGS_IsValid);
	}

	static BGUStaminaBarUIComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUStaminaBarUIComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUStaminaBarUIComp));
	}
}
