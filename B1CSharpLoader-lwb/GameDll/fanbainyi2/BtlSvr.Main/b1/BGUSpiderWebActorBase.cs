using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSpiderWebActorBase")]
public class BGUSpiderWebActorBase : AActor
{
	public bool IsActive;

	private static bool WebComp_IsValid;

	private static int WebComp_Offset;

	private static bool VisibleDistance_IsValid;

	private static int VisibleDistance_Offset;

	private static bool ReceiveData_IsValid;

	private static IntPtr ReceiveData_FunctionAddress;

	private static int ReceiveData_ParamsSize;

	private IntPtr ReceiveData_InstanceFunctionAddressInstance;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[VisibleAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSpiderWebActorBase:WebComp")]
	public UNiagaraComponent WebComp
	{
		get
		{
			CheckDestroyed();
			if (!WebComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderWebActorBase:WebComp");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, WebComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WebComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderWebActorBase:WebComp");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, WebComp_Offset), value);
			}
		}
	}

	[DisplayName("可视距离")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSpiderWebActorBase:VisibleDistance")]
	public int VisibleDistance
	{
		get
		{
			CheckDestroyed();
			if (!VisibleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderWebActorBase:VisibleDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VisibleDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VisibleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderWebActorBase:VisibleDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VisibleDistance_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BGUSpiderWebActorBase:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		WebComp = initializer.CreateDefaultSubobject<UNiagaraComponent>(this, B1GlobalFNames.SpiderWeb);
		WebComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		base.Tags.Add(B1GlobalFNames.SpiderWeb);
		VisibleDistance = 10000;
		IsActive = true;
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGUSpiderWebActorBase:ReceiveData")]
	public unsafe void ReceiveData()
	{
		CheckDestroyed();
		if (!ReceiveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUSpiderWebActorBase:ReceiveData");
			return;
		}
		if (ReceiveData_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			ReceiveData_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveData");
		}
		byte* value = stackalloc byte[(int)(uint)ReceiveData_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, ReceiveData_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, ReceiveData_InstanceFunctionAddressInstance, intPtr, ReceiveData_ParamsSize);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSpiderWebActorBase:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSpiderWebActorBase bGUSpiderWebActorBase = GCHelper.Find<BGUSpiderWebActorBase>(obj);
		bGUSpiderWebActorBase.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSpiderWebActorBase");
		WebComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "WebComp");
		WebComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WebComp", Classes.FObjectProperty);
		VisibleDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "VisibleDistance");
		VisibleDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VisibleDistance", Classes.FIntProperty);
		ReceiveData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveData");
		ReceiveData_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveData_FunctionAddress);
		ReceiveData_IsValid = ReceiveData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSpiderWebActorBase:ReceiveData", ReceiveData_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSpiderWebActorBase:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUSpiderWebActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSpiderWebActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSpiderWebActorBase));
	}
}
