using System;
using b1.Plugins.AkAudio;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor")]
public class BGUChapterSurpriseActor : AActor
{
	private float DrawDuringTime;

	private static bool DefaultRootComp_IsValid;

	private static int DefaultRootComp_Offset;

	private static bool ActiveDebugComp_IsValid;

	private static int ActiveDebugComp_Offset;

	private static bool InteractDebugComp_IsValid;

	private static int InteractDebugComp_Offset;

	private static bool SurpriseID_IsValid;

	private static int SurpriseID_Offset;

	private static bool CameraStartTransform_IsValid;

	private static int CameraStartTransform_Offset;

	private static bool CameraTargetTransform_IsValid;

	private static int CameraTargetTransform_Offset;

	private static bool CameraBlendTime_IsValid;

	private static int CameraBlendTime_Offset;

	private static bool CameraBlendFunction_IsValid;

	private static int CameraBlendFunction_Offset;

	private static FFieldAddress CameraBlendFunction_PropertyAddress;

	private static bool CameraBlendExp_IsValid;

	private static int CameraBlendExp_Offset;

	private static bool AudioEvent_IsValid;

	private static int AudioEvent_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:DefaultRootComp")]
	private USceneComponent DefaultRootComp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:DefaultRootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:DefaultRootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:ActiveDebugComp")]
	public UBGUDebugCircleComponent ActiveDebugComp
	{
		get
		{
			CheckDestroyed();
			if (!ActiveDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:ActiveDebugComp");
				return null;
			}
			return UObjectMarshaler<UBGUDebugCircleComponent>.FromNative(IntPtr.Add(base.Address, ActiveDebugComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActiveDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:ActiveDebugComp");
			}
			else
			{
				UObjectMarshaler<UBGUDebugCircleComponent>.ToNative(IntPtr.Add(base.Address, ActiveDebugComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:InteractDebugComp")]
	public UBGUDebugCircleComponent InteractDebugComp
	{
		get
		{
			CheckDestroyed();
			if (!InteractDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:InteractDebugComp");
				return null;
			}
			return UObjectMarshaler<UBGUDebugCircleComponent>.FromNative(IntPtr.Add(base.Address, InteractDebugComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractDebugComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:InteractDebugComp");
			}
			else
			{
				UObjectMarshaler<UBGUDebugCircleComponent>.ToNative(IntPtr.Add(base.Address, InteractDebugComp_Offset), value);
			}
		}
	}

	[DisplayName("彩蛋ID")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:SurpriseID")]
	public int SurpriseID
	{
		get
		{
			CheckDestroyed();
			if (!SurpriseID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:SurpriseID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SurpriseID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SurpriseID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:SurpriseID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SurpriseID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("镜头初始位置")]
	[Category("Sequence")]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:CameraStartTransform")]
	public FTransform CameraStartTransform
	{
		get
		{
			CheckDestroyed();
			if (!CameraStartTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraStartTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, CameraStartTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraStartTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraStartTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, CameraStartTransform_Offset), value);
			}
		}
	}

	[DisplayName("镜头目标位置")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Sequence")]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:CameraTargetTransform")]
	public FTransform CameraTargetTransform
	{
		get
		{
			CheckDestroyed();
			if (!CameraTargetTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraTargetTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, CameraTargetTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraTargetTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraTargetTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, CameraTargetTransform_Offset), value);
			}
		}
	}

	[DisplayName("镜头Blend时间")]
	[Category("Sequence")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendTime")]
	public float CameraBlendTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Sequence")]
	[DisplayName("镜头Blend函数")]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendFunction")]
	public EEasingFunc CameraBlendFunction
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendFunction");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, CameraBlendFunction_Offset), 0, CameraBlendFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendFunction");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, CameraBlendFunction_Offset), 0, CameraBlendFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Sequence")]
	[EditAnywhere]
	[DisplayName("镜头Blend系数")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendExp")]
	public float CameraBlendExp
	{
		get
		{
			CheckDestroyed();
			if (!CameraBlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendExp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBlendExp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBlendExp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:CameraBlendExp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBlendExp_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Sequence")]
	[DisplayName("Audio")]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:AudioEvent")]
	public UAkAudioEvent AudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!AudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:AudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterSurpriseActor:AudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AudioEvent_Offset), value);
			}
		}
	}

	public SurpriseDesc SurpriseDesc { get; set; }

	public GSBindProp<EInteractUIState> InteractUIState { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DefaultRootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultRootComp);
		base.RootComponent = DefaultRootComp;
		ActiveDebugComp = initializer.CreateDefaultSubobject<UBGUDebugCircleComponent>(this, new FName("ActiveDebugComp"));
		ActiveDebugComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		ActiveDebugComp.ShapeColor = FColor.Pink;
		ActiveDebugComp.SetHiddenInGame(NewHidden: true);
		InteractDebugComp = initializer.CreateDefaultSubobject<UBGUDebugCircleComponent>(this, new FName("InteractDebugComp"));
		InteractDebugComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		InteractDebugComp.ShapeColor = FColor.Blue;
		InteractDebugComp.SetHiddenInGame(NewHidden: true);
		CameraBlendTime = 2f;
		CameraBlendFunction = EEasingFunc.EaseOut;
		CameraBlendExp = 2f;
		InteractUIState = new GSBindProp<EInteractUIState>();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:OnConstructionCS")]
	public void OnConstructionCS()
	{
		InitSurprise();
	}

	public void InitSurprise()
	{
		if (SurpriseDesc == null)
		{
			SurpriseDesc = GameDBRuntime.GetSurpriseDesc(SurpriseID);
			RefreshDebugDraw();
		}
	}

	[USharpPath("/Script/b1-Managed.BGUChapterSurpriseActor:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
		TickDraw(DeltaSeconds);
	}

	private void TickDraw(float DeltaSeconds)
	{
		if (DebugConfig.ChapterDebug || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(this))
		{
			DrawDuringTime -= DeltaSeconds;
			_ = DrawDuringTime;
			_ = 5f;
		}
	}

	private void RefreshDebugDraw()
	{
		ActiveDebugComp.SetHiddenInGame(NewHidden: true);
		InteractDebugComp.SetHiddenInGame(NewHidden: true);
		ActiveDebugComp.SetVisibility(bNewVisibility: false);
		InteractDebugComp.SetVisibility(bNewVisibility: false);
		if ((DebugConfig.ChapterDebug || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(this)) && SurpriseDesc != null)
		{
			ActiveDebugComp.SetCircleRadius(SurpriseDesc.ActiveRadius);
			ActiveDebugComp.SetVisibility(bNewVisibility: true);
			ActiveDebugComp.SetHiddenInGame(NewHidden: false);
			InteractDebugComp.SetCircleRadius(SurpriseDesc.InteractRadius);
			InteractDebugComp.SetVisibility(bNewVisibility: true);
			InteractDebugComp.SetHiddenInGame(NewHidden: false);
		}
	}

	public void SetStateValue(EInteractUIState State)
	{
		InteractUIState.SetValue(EChangeReason.Init, State);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUChapterSurpriseActor:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUChapterSurpriseActor bGUChapterSurpriseActor = GCHelper.Find<BGUChapterSurpriseActor>(obj);
		bGUChapterSurpriseActor.OnConstructionCS();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUChapterSurpriseActor:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUChapterSurpriseActor bGUChapterSurpriseActor = GCHelper.Find<BGUChapterSurpriseActor>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUChapterSurpriseActor.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUChapterSurpriseActor");
		DefaultRootComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRootComp");
		DefaultRootComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRootComp", Classes.FObjectProperty);
		ActiveDebugComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActiveDebugComp");
		ActiveDebugComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActiveDebugComp", Classes.FObjectProperty);
		InteractDebugComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractDebugComp");
		InteractDebugComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractDebugComp", Classes.FObjectProperty);
		SurpriseID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurpriseID");
		SurpriseID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurpriseID", Classes.FIntProperty);
		CameraStartTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraStartTransform");
		CameraStartTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraStartTransform", Classes.FStructProperty);
		CameraTargetTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraTargetTransform");
		CameraTargetTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraTargetTransform", Classes.FStructProperty);
		CameraBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendTime");
		CameraBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CameraBlendFunction_PropertyAddress, intPtr, "CameraBlendFunction");
		CameraBlendFunction_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendFunction");
		CameraBlendFunction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendFunction", Classes.FEnumProperty);
		CameraBlendExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraBlendExp");
		CameraBlendExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraBlendExp", Classes.FFloatProperty);
		AudioEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AudioEvent");
		AudioEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AudioEvent", Classes.FObjectProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUChapterSurpriseActor:OnConstructionCS", OnConstructionCS_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUChapterSurpriseActor:ReceiveTick", ReceiveTick_IsValid);
	}

	static BGUChapterSurpriseActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUChapterSurpriseActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUChapterSurpriseActor));
	}
}
