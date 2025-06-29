using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib Play Custom Camera Shake")]
[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake")]
public class BAN_DispLibPlayCustomCameraShake : BAN_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool EditorPlayActive_IsValid;

	private static int EditorPlayActive_Offset;

	private static FFieldAddress EditorPlayActive_PropertyAddress;

	private static bool CustomCameraShake_IsValid;

	private static int CustomCameraShake_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Editor Active")]
	[UMeta(MD.ToolTip, "关闭后编辑器预览时不会播放当前效果，不影响编辑器运行时，不影响真机运行时")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Editor Play Active")]
	[UMeta(MD.ToolTip, "关闭后编辑器运行时不会播放当前效果，不影响真机运行时")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:EditorPlayActive")]
	public bool EditorPlayActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorPlayActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:EditorPlayActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorPlayActive_Offset), 0, EditorPlayActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorPlayActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:EditorPlayActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorPlayActive_Offset), 0, EditorPlayActive_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("CustomCameraShake")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "关闭后编辑器运行时不会播放当前效果，不影响真机运行时")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:CustomCameraShake")]
	public BUC_DispLibDBC_PlayCustomCameraShake CustomCameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CustomCameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:CustomCameraShake");
				return default(BUC_DispLibDBC_PlayCustomCameraShake);
			}
			return BUC_DispLibDBC_PlayCustomCameraShake.FromNative(IntPtr.Add(base.Address, CustomCameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomCameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:CustomCameraShake");
			}
			else
			{
				BUC_DispLibDBC_PlayCustomCameraShake.ToNative(IntPtr.Add(base.Address, CustomCameraShake_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	protected bool PlayCameraShakeByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		return Runtime_DoCustomCameraShakeByDBC(MeshComp, Animation);
	}

	private bool Runtime_DoCustomCameraShakeByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		if (!BGU_DispLibDataUtil.GetCurActiveMontageeUniqueID(MeshComp, Animation, out var MontageeUniqueID))
		{
			return false;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(MeshComp.GetOwner());
		if (bUS_DispLibEventCollection != null)
		{
			bUS_DispLibEventCollection.Evt_RequestApply_One_CustomCameraShake(CustomCameraShake, GetUniqueID(), MontageeUniqueID);
		}
		else
		{
			BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(MeshComp.GetOwner()))?.Evt_DLDWorld_RequestApplyOneCustomCameraShake(CustomCameraShake, MeshComp, GetUniqueID(), MontageeUniqueID);
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		base.Received_Notify_Implementation(meshComp, animation, default(FAnimNotifyEventReference));
		PlayCameraShakeByDBC(meshComp, animation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_DispLibPlayCustomCameraShake bAN_DispLibPlayCustomCameraShake = GCHelper.Find<BAN_DispLibPlayCustomCameraShake>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibPlayCustomCameraShake.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EditorPlayActive_PropertyAddress, intPtr, "EditorPlayActive");
		EditorPlayActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorPlayActive");
		EditorPlayActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorPlayActive", Classes.FBoolProperty);
		CustomCameraShake_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomCameraShake");
		CustomCameraShake_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomCameraShake", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibPlayCustomCameraShake:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibPlayCustomCameraShake()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_DispLibPlayCustomCameraShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_DispLibPlayCustomCameraShake));
	}
}
