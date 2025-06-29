using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Editor;

[UClass]
[USharpPath("/Script/b1-Managed.GlobalAudioMgr")]
public class GlobalAudioMgr : AActor
{
	public delegate void OnAppBackGroundDelegate();

	public delegate void OnAppForeGroundDelegate();

	private UApplicationLifecycleComponent LifecycleComp;

	public OnAppBackGroundDelegate BackGroundDelegate;

	public OnAppForeGroundDelegate ForeGroundDelegate;

	private static bool BeginPlay_IsValid;

	private static IntPtr BeginPlay_FunctionAddress;

	private static int BeginPlay_ParamsSize;

	private static bool GetUApplicationLifecycleComponent_IsValid;

	private static IntPtr GetUApplicationLifecycleComponent_FunctionAddress;

	private static int GetUApplicationLifecycleComponent_ParamsSize;

	private static bool GetUApplicationLifecycleComponent_ReturnValue_IsValid;

	private static int GetUApplicationLifecycleComponent_ReturnValue_Offset;

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GlobalAudioMgr:BeginPlay")]
	public void BeginPlay()
	{
		LifecycleComp = GetComponentByClass(UClass.GetClass<UApplicationLifecycleComponent>()) as UApplicationLifecycleComponent;
		if (!(LifecycleComp == null))
		{
			LifecycleComp.ApplicationWillEnterBackgroundDelegate.Bind(RunAppBackGroundDelegate);
			LifecycleComp.ApplicationHasEnteredForegroundDelegate.Bind(RunAppForeGroundDelegate);
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GlobalAudioMgr:GetUApplicationLifecycleComponent")]
	public UApplicationLifecycleComponent GetUApplicationLifecycleComponent()
	{
		return LifecycleComp;
	}

	private void RunAppBackGroundDelegate()
	{
		if (BackGroundDelegate != null)
		{
			BackGroundDelegate();
		}
	}

	private void RunAppForeGroundDelegate()
	{
		if (ForeGroundDelegate != null)
		{
			ForeGroundDelegate();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GlobalAudioMgr:BeginPlay")]
	private static void BeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		GlobalAudioMgr globalAudioMgr = GCHelper.Find<GlobalAudioMgr>(obj);
		globalAudioMgr.BeginPlay();
	}

	[UFunctionInvoker("/Script/b1-Managed.GlobalAudioMgr:GetUApplicationLifecycleComponent")]
	private static void GetUApplicationLifecycleComponent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GlobalAudioMgr globalAudioMgr = GCHelper.Find<GlobalAudioMgr>(obj);
		UApplicationLifecycleComponent uApplicationLifecycleComponent = globalAudioMgr.GetUApplicationLifecycleComponent();
		UObjectMarshaler<UApplicationLifecycleComponent>.ToNative(IntPtr.Add(buffer, GetUApplicationLifecycleComponent_ReturnValue_Offset), uApplicationLifecycleComponent);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GlobalAudioMgr");
		BeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlay");
		BeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlay_FunctionAddress);
		BeginPlay_IsValid = BeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GlobalAudioMgr:BeginPlay", BeginPlay_IsValid);
		GetUApplicationLifecycleComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUApplicationLifecycleComponent");
		GetUApplicationLifecycleComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUApplicationLifecycleComponent_FunctionAddress);
		GetUApplicationLifecycleComponent_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetUApplicationLifecycleComponent_FunctionAddress, "ReturnValue");
		GetUApplicationLifecycleComponent_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetUApplicationLifecycleComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetUApplicationLifecycleComponent_IsValid = GetUApplicationLifecycleComponent_FunctionAddress != IntPtr.Zero && GetUApplicationLifecycleComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GlobalAudioMgr:GetUApplicationLifecycleComponent", GetUApplicationLifecycleComponent_IsValid);
	}

	static GlobalAudioMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GlobalAudioMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GlobalAudioMgr));
	}
}
