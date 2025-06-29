using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger")]
internal class GSDispLib_PostProcessDebugger : AActor
{
	public float TimePassed;

	private static bool PPConf_IsValid;

	private static int PPConf_Offset;

	private static bool PPContext_IsValid;

	private static int PPContext_Offset;

	private static bool PPClass_IsValid;

	private static int PPClass_Offset;

	private static bool PPParameters_IsValid;

	private static int PPParameters_Offset;

	private static bool ImageProcessorConfig_IsValid;

	private static int ImageProcessorConfig_Offset;

	private static bool AutoBegin_IsValid;

	private static int AutoBegin_Offset;

	private static FFieldAddress AutoBegin_PropertyAddress;

	private static bool StopEffect_IsValid;

	private static IntPtr StopEffect_FunctionAddress;

	private static int StopEffect_ParamsSize;

	private static bool BeginEffect_IsValid;

	private static IntPtr BeginEffect_FunctionAddress;

	private static int BeginEffect_ParamsSize;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPConf")]
	protected UDispLib_PostProcessConf PPConf
	{
		get
		{
			CheckDestroyed();
			if (!PPConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPConf");
				return null;
			}
			return UObjectMarshaler<UDispLib_PostProcessConf>.FromNative(IntPtr.Add(base.Address, PPConf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPConf");
			}
			else
			{
				UObjectMarshaler<UDispLib_PostProcessConf>.ToNative(IntPtr.Add(base.Address, PPConf_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPContext")]
	protected GSDispLib_PostProcessContext PPContext
	{
		get
		{
			CheckDestroyed();
			if (!PPContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPContext");
				return null;
			}
			return UObjectMarshaler<GSDispLib_PostProcessContext>.FromNative(IntPtr.Add(base.Address, PPContext_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPContext_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPContext");
			}
			else
			{
				UObjectMarshaler<GSDispLib_PostProcessContext>.ToNative(IntPtr.Add(base.Address, PPContext_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPClass")]
	public TSubclassOf<GSDispLib_PostProcessActor> PPClass
	{
		get
		{
			CheckDestroyed();
			if (!PPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPClass");
				return default(TSubclassOf<GSDispLib_PostProcessActor>);
			}
			return TSubclassOfMarshaler<GSDispLib_PostProcessActor>.FromNative(IntPtr.Add(base.Address, PPClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPClass");
			}
			else
			{
				TSubclassOfMarshaler<GSDispLib_PostProcessActor>.ToNative(IntPtr.Add(base.Address, PPClass_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPParameters")]
	public UDispLib_PPEffectParameters PPParameters
	{
		get
		{
			CheckDestroyed();
			if (!PPParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPParameters");
				return null;
			}
			return UObjectMarshaler<UDispLib_PPEffectParameters>.FromNative(IntPtr.Add(base.Address, PPParameters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PPParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:PPParameters");
			}
			else
			{
				UObjectMarshaler<UDispLib_PPEffectParameters>.ToNative(IntPtr.Add(base.Address, PPParameters_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ImageProcessorConfig")]
	public BWS_DispLibImageProcessorConfig ImageProcessorConfig
	{
		get
		{
			CheckDestroyed();
			if (!ImageProcessorConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ImageProcessorConfig");
				return null;
			}
			return UObjectMarshaler<BWS_DispLibImageProcessorConfig>.FromNative(IntPtr.Add(base.Address, ImageProcessorConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImageProcessorConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ImageProcessorConfig");
			}
			else
			{
				UObjectMarshaler<BWS_DispLibImageProcessorConfig>.ToNative(IntPtr.Add(base.Address, ImageProcessorConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:AutoBegin")]
	public bool AutoBegin
	{
		get
		{
			CheckDestroyed();
			if (!AutoBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:AutoBegin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoBegin_Offset), 0, AutoBegin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessDebugger:AutoBegin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoBegin_Offset), 0, AutoBegin_PropertyAddress.Address, value);
			}
		}
	}

	public BWS_PostProcessCommon CommonEffect { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.SceneComponent);
		PPParameters = UObject.NewObject<UDispLib_PPEffectParameters>(this, B1GlobalFNames.PPDebuggerParameters, EObjectFlags.ClassDefaultObject, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
	}

	private void PrintString(string str)
	{
		PrintString(str, FLinearColor.White, printToLog: true, 0f);
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		PPContext = UObject.NewObject<GSDispLib_PostProcessContext>(this);
		PPContext.Config = PPConf;
		APostProcessVolume aPostProcessVolume = UGameplayStatics.GetActorOfClass(this, UClass.GetClass<APostProcessVolume>()) as APostProcessVolume;
		if (aPostProcessVolume != null)
		{
			PPContext.PostProcessVolume = aPostProcessVolume;
		}
		PPContext.World = base.World;
		PPContext.ImageProcessor = UObject.NewObject<BWS_DispLibImageProcessor>(this, B1GlobalFNames.PPDebuggerParameters, EObjectFlags.ClassDefaultObject, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
		PPContext.ImageProcessor.InitParameters();
		PPContext.ImageProcessor.Config = ImageProcessorConfig;
		CommonEffect = BWS_PostProcessCommon.Create(PPContext, PPClass);
		if (CommonEffect != null && AutoBegin)
		{
			CommonEffect.Begin(PPContext, PPParameters);
		}
		TimePassed = 0f;
	}

	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
		if (!(PPContext == null) && !(PPContext.PostProcessVolume == null) && CommonEffect != null && CommonEffect.IsActive())
		{
			CommonEffect.OnTick(DeltaSeconds, PPContext);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:BeginEffect")]
	protected void BeginEffect()
	{
		if (CommonEffect != null)
		{
			CommonEffect.Begin(PPContext, PPParameters);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessDebugger:StopEffect")]
	protected void StopEffect()
	{
		if (CommonEffect != null)
		{
			CommonEffect.End(PPContext);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessDebugger:StopEffect")]
	private static void StopEffect__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.GSDispLib_PostProcessDebugger gSDispLib_PostProcessDebugger = GCHelper.Find<GSDispLib.GSDispLib_PostProcessDebugger>(obj);
		gSDispLib_PostProcessDebugger.StopEffect();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessDebugger:BeginEffect")]
	private static void BeginEffect__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.GSDispLib_PostProcessDebugger gSDispLib_PostProcessDebugger = GCHelper.Find<GSDispLib.GSDispLib_PostProcessDebugger>(obj);
		gSDispLib_PostProcessDebugger.BeginEffect();
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.GSDispLib_PostProcessDebugger gSDispLib_PostProcessDebugger = GCHelper.Find<GSDispLib.GSDispLib_PostProcessDebugger>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		gSDispLib_PostProcessDebugger.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.GSDispLib_PostProcessDebugger gSDispLib_PostProcessDebugger = GCHelper.Find<GSDispLib.GSDispLib_PostProcessDebugger>(obj);
		gSDispLib_PostProcessDebugger.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSDispLib_PostProcessDebugger");
		PPConf_Offset = NativeReflection.GetPropertyOffset(intPtr, "PPConf");
		PPConf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PPConf", Classes.FObjectProperty);
		PPContext_Offset = NativeReflection.GetPropertyOffset(intPtr, "PPContext");
		PPContext_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PPContext", Classes.FObjectProperty);
		PPClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "PPClass");
		PPClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PPClass", Classes.FClassProperty);
		PPParameters_Offset = NativeReflection.GetPropertyOffset(intPtr, "PPParameters");
		PPParameters_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PPParameters", Classes.FObjectProperty);
		ImageProcessorConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImageProcessorConfig");
		ImageProcessorConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImageProcessorConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AutoBegin_PropertyAddress, intPtr, "AutoBegin");
		AutoBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AutoBegin");
		AutoBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AutoBegin", Classes.FBoolProperty);
		StopEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopEffect");
		StopEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(StopEffect_FunctionAddress);
		StopEffect_IsValid = StopEffect_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessDebugger:StopEffect", StopEffect_IsValid);
		BeginEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginEffect");
		BeginEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginEffect_FunctionAddress);
		BeginEffect_IsValid = BeginEffect_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessDebugger:BeginEffect", BeginEffect_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ReceiveTick", ReceiveTick_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSDispLib_PostProcessDebugger:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static GSDispLib_PostProcessDebugger()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.GSDispLib_PostProcessDebugger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.GSDispLib_PostProcessDebugger));
	}
}
