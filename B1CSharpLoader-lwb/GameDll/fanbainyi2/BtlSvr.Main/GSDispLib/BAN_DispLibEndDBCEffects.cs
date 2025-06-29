using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib End DBC Effect")]
[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects")]
internal class BAN_DispLibEndDBCEffects : BAN_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool EditorPlayActive_IsValid;

	private static int EditorPlayActive_Offset;

	private static FFieldAddress EditorPlayActive_PropertyAddress;

	private static bool CompTag_IsValid;

	private static int CompTag_Offset;

	private static bool OnlyEndFX_IsValid;

	private static int OnlyEndFX_Offset;

	private static FFieldAddress OnlyEndFX_PropertyAddress;

	private static bool OnlyEndProcedureEndMode_IsValid;

	private static int OnlyEndProcedureEndMode_Offset;

	private static FFieldAddress OnlyEndProcedureEndMode_PropertyAddress;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UMeta(MD.ToolTip, "关闭后动画编辑器不会播放当前效果")]
	[DisplayName("Editor Active")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EditorActive");
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
	[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EditorPlayActive")]
	public bool EditorPlayActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorPlayActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EditorPlayActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorPlayActive_Offset), 0, EditorPlayActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorPlayActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EditorPlayActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorPlayActive_Offset), 0, EditorPlayActive_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects:CompTag")]
	public FName CompTag
	{
		get
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:CompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:CompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTag_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects:OnlyEndFX")]
	public bool OnlyEndFX
	{
		get
		{
			CheckDestroyed();
			if (!OnlyEndFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:OnlyEndFX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlyEndFX_Offset), 0, OnlyEndFX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlyEndFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:OnlyEndFX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlyEndFX_Offset), 0, OnlyEndFX_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects:OnlyEndProcedureEndMode")]
	public bool OnlyEndProcedureEndMode
	{
		get
		{
			CheckDestroyed();
			if (!OnlyEndProcedureEndMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:OnlyEndProcedureEndMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlyEndProcedureEndMode_Offset), 0, OnlyEndProcedureEndMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlyEndProcedureEndMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:OnlyEndProcedureEndMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlyEndProcedureEndMode_Offset), 0, OnlyEndProcedureEndMode_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EndStagePriority")]
	public int EndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibEndDBCEffects:EndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndStagePriority_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		OnlyEndFX = true;
		EndStagePriority = -1;
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibEndDBCEffects:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		EndDBCEffects(meshComp, animation);
	}

	protected void EndDBCEffects(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		Runtime_EndDBCEffects(MeshComp);
	}

	protected void Runtime_EndDBCEffects(USkeletalMeshComponent MeshComp)
	{
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(MeshComp.GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(MeshComp.GetOwner())).Evt_DLDWorld_RequestEndDBCEffectsByTag(CompTag, OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority);
		}
		else
		{
			bUS_DispLibEventCollection.Evt_RequestEndDBCEffectsByTag(CompTag, OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibEndDBCEffects:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BAN_DispLibEndDBCEffects bAN_DispLibEndDBCEffects = GCHelper.Find<GSDispLib.BAN_DispLibEndDBCEffects>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibEndDBCEffects.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibEndDBCEffects");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EditorPlayActive_PropertyAddress, intPtr, "EditorPlayActive");
		EditorPlayActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorPlayActive");
		EditorPlayActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorPlayActive", Classes.FBoolProperty);
		CompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTag");
		CompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OnlyEndFX_PropertyAddress, intPtr, "OnlyEndFX");
		OnlyEndFX_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnlyEndFX");
		OnlyEndFX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnlyEndFX", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnlyEndProcedureEndMode_PropertyAddress, intPtr, "OnlyEndProcedureEndMode");
		OnlyEndProcedureEndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnlyEndProcedureEndMode");
		OnlyEndProcedureEndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnlyEndProcedureEndMode", Classes.FBoolProperty);
		EndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStagePriority");
		EndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStagePriority", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibEndDBCEffects:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibEndDBCEffects()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BAN_DispLibEndDBCEffects)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BAN_DispLibEndDBCEffects));
	}
}
