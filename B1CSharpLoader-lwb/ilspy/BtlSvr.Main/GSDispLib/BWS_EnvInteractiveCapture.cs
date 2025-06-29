using System;
using System.Collections.Generic;
using b1;
using b1.Plugins.GSNiagara;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture")]
public class BWS_EnvInteractiveCapture : AActor
{
	public readonly FName CaptureSizeName = B1GlobalFNames.CaptureSize;

	public readonly FName CaptureLocationName = B1GlobalFNames.CaptureLocation;

	public readonly string NiagaraArrayVariableName = "User.GSParticleArray";

	public readonly FLinearColor ClearColor = new FLinearColor(0.5f, 0.5f, 0f);

	private bool bCapturingEnabled = true;

	private List<BWS_EnvInteractiveItem> TempInteractiveItems = new List<BWS_EnvInteractiveItem>();

	private List<BWS_EnvInteractivePrimitive> InteractivePrims = new List<BWS_EnvInteractivePrimitive>();

	private int InteractorCount;

	private static bool ParticleArrayData_IsValid;

	private static int ParticleArrayData_Offset;

	private static bool RTSize_IsValid;

	private static int RTSize_Offset;

	private static bool RT_IsValid;

	private static int RT_Offset;

	private static bool SceneCaptureComponent_IsValid;

	private static int SceneCaptureComponent_Offset;

	private static bool CaptureMPC_IsValid;

	private static int CaptureMPC_Offset;

	private static bool CaptureInterval_IsValid;

	private static int CaptureInterval_Offset;

	private static bool ParticleFadeDuration_IsValid;

	private static int ParticleFadeDuration_Offset;

	private static bool ParicleHeight_IsValid;

	private static int ParicleHeight_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool OnLateInit_IsValid;

	private static IntPtr OnLateInit_FunctionAddress;

	private static int OnLateInit_ParamsSize;

	private IntPtr OnLateInit_InstanceFunctionAddressInstance;

	private static bool TriggerOnce_IsValid;

	private static IntPtr TriggerOnce_FunctionAddress;

	private static int TriggerOnce_ParamsSize;

	private static bool TriggerOnce_Position_IsValid;

	private static int TriggerOnce_Position_Offset;

	private static FFieldAddress TriggerOnce_Position_PropertyAddress;

	private static bool TriggerOnce_Size_IsValid;

	private static int TriggerOnce_Size_Offset;

	private static FFieldAddress TriggerOnce_Size_PropertyAddress;

	private static bool TriggerOnce_InteractiveType_IsValid;

	private static int TriggerOnce_InteractiveType_Offset;

	private static bool TriggerOnce_Intensity_IsValid;

	private static int TriggerOnce_Intensity_Offset;

	private static bool TriggerOnce_Duration_IsValid;

	private static int TriggerOnce_Duration_Offset;

	private static bool TriggerOnce_ReturnValue_IsValid;

	private static int TriggerOnce_ReturnValue_Offset;

	private static bool OnEnableDebug_IsValid;

	private static IntPtr OnEnableDebug_FunctionAddress;

	private static int OnEnableDebug_ParamsSize;

	private IntPtr OnEnableDebug_InstanceFunctionAddressInstance;

	private static bool OnTickCapture_IsValid;

	private static IntPtr OnTickCapture_FunctionAddress;

	private static int OnTickCapture_ParamsSize;

	private static bool AddInteractor_IsValid;

	private static IntPtr AddInteractor_FunctionAddress;

	private static int AddInteractor_ParamsSize;

	private static bool AddInteractor_PrimComp_IsValid;

	private static int AddInteractor_PrimComp_Offset;

	private static bool AddInteractor_InteractiveType_IsValid;

	private static int AddInteractor_InteractiveType_Offset;

	private static bool AddInteractor_Size_IsValid;

	private static int AddInteractor_Size_Offset;

	private static FFieldAddress AddInteractor_Size_PropertyAddress;

	private static bool AddInteractor_Intensity_IsValid;

	private static int AddInteractor_Intensity_Offset;

	private static bool AddInteractor_Duration_IsValid;

	private static int AddInteractor_Duration_Offset;

	private static bool AddInteractor_ReturnValue_IsValid;

	private static int AddInteractor_ReturnValue_Offset;

	private static bool RemoveInteractor_IsValid;

	private static IntPtr RemoveInteractor_FunctionAddress;

	private static int RemoveInteractor_ParamsSize;

	private static bool RemoveInteractor_InteractorID_IsValid;

	private static int RemoveInteractor_InteractorID_Offset;

	[UProperty]
	[DisplayName("ParticleArrayData")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParticleArrayData")]
	public UGSNiagaraArrayData ParticleArrayData
	{
		get
		{
			CheckDestroyed();
			if (!ParticleArrayData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParticleArrayData");
				return null;
			}
			return UObjectMarshaler<UGSNiagaraArrayData>.FromNative(IntPtr.Add(base.Address, ParticleArrayData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParticleArrayData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParticleArrayData");
			}
			else
			{
				UObjectMarshaler<UGSNiagaraArrayData>.ToNative(IntPtr.Add(base.Address, ParticleArrayData_Offset), value);
			}
		}
	}

	[DisplayName("RTSize")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:RTSize")]
	public int RTSize
	{
		get
		{
			CheckDestroyed();
			if (!RTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:RTSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RTSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RTSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:RTSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RTSize_Offset), value);
			}
		}
	}

	[DisplayName("RT")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:RT")]
	public UTextureRenderTarget2D RT
	{
		get
		{
			CheckDestroyed();
			if (!RT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:RT");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:RT");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("SceneCaptureComponent")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:SceneCaptureComponent")]
	public USceneCaptureComponent2D SceneCaptureComponent
	{
		get
		{
			CheckDestroyed();
			if (!SceneCaptureComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:SceneCaptureComponent");
				return null;
			}
			return UObjectMarshaler<USceneCaptureComponent2D>.FromNative(IntPtr.Add(base.Address, SceneCaptureComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneCaptureComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:SceneCaptureComponent");
			}
			else
			{
				UObjectMarshaler<USceneCaptureComponent2D>.ToNative(IntPtr.Add(base.Address, SceneCaptureComponent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:CaptureMPC")]
	public UMaterialParameterCollection CaptureMPC
	{
		get
		{
			CheckDestroyed();
			if (!CaptureMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:CaptureMPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, CaptureMPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:CaptureMPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, CaptureMPC_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:CaptureInterval")]
	public float CaptureInterval
	{
		get
		{
			CheckDestroyed();
			if (!CaptureInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:CaptureInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CaptureInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:CaptureInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CaptureInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParticleFadeDuration")]
	public float ParticleFadeDuration
	{
		get
		{
			CheckDestroyed();
			if (!ParticleFadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParticleFadeDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ParticleFadeDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParticleFadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParticleFadeDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ParticleFadeDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParicleHeight")]
	public float ParicleHeight
	{
		get
		{
			CheckDestroyed();
			if (!ParicleHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParicleHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ParicleHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParicleHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:ParicleHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ParicleHeight_Offset), value);
			}
		}
	}

	[BlueprintImplementedEvent]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnLateInit")]
	public unsafe void OnLateInit()
	{
		CheckDestroyed();
		if (!OnLateInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnLateInit");
			return;
		}
		if (OnLateInit_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnLateInit_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnLateInit");
		}
		byte* value = stackalloc byte[(int)(uint)OnLateInit_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnLateInit_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnLateInit_InstanceFunctionAddressInstance, intPtr, OnLateInit_ParamsSize);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnEnableDebug")]
	public unsafe void OnEnableDebug()
	{
		CheckDestroyed();
		if (!OnEnableDebug_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnEnableDebug");
			return;
		}
		if (OnEnableDebug_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnEnableDebug_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnEnableDebug");
		}
		byte* value = stackalloc byte[(int)(uint)OnEnableDebug_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnEnableDebug_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, OnEnableDebug_InstanceFunctionAddressInstance, intPtr, OnEnableDebug_ParamsSize);
	}

	[UFunction]
	[Category("GSEnv|Interactive")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:Init")]
	public void Init()
	{
		if (ParticleArrayData != null)
		{
			ParticleArrayData.ClearParticleArrayData();
		}
		SceneCaptureComponent = GetComponentByClass<USceneCaptureComponent2D>();
		if (SceneCaptureComponent != null)
		{
			SceneCaptureComponent.TextureTarget = RT;
			if (CaptureMPC != null)
			{
				UMaterialLibrary.SetScalarParameterValue(this, CaptureMPC, CaptureSizeName, SceneCaptureComponent.OrthoWidth);
			}
			SceneCaptureComponent.ShowOnlyActors.Clear();
		}
		OnLateInit();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("GSEnv|Interactive")]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnTickCapture")]
	public void OnTickCapture()
	{
		if (RT != null)
		{
			URenderingLibrary.ClearRenderTarget2D(this, RT, ClearColor);
		}
		if (CaptureMPC != null)
		{
			UMaterialLibrary.SetVectorParameterValue(this, CaptureMPC, CaptureLocationName, UMathLibrary.Conv_VectorToLinearColor(GetActorLocation()));
		}
		if (!(ParticleArrayData != null))
		{
			return;
		}
		ParticleArrayData.ClearParticleArrayData();
		foreach (BWS_EnvInteractivePrimitive interactivePrim in InteractivePrims)
		{
			if (interactivePrim.OnTick())
			{
				ParticleArrayData.AddParticle(MakeGSNiagaraParticleInfo(interactivePrim.InteractiveType, new FVector(interactivePrim.Position.X, interactivePrim.Position.Y, ParicleHeight), interactivePrim.Size, default(FLinearColor), interactivePrim.Duration, interactivePrim.Intensity));
			}
		}
		foreach (BWS_EnvInteractiveItem tempInteractiveItem in TempInteractiveItems)
		{
			ParticleArrayData.AddParticle(MakeGSNiagaraParticleInfo(tempInteractiveItem.InteractiveType, new FVector(tempInteractiveItem.Position.X, tempInteractiveItem.Position.Y, ParicleHeight), tempInteractiveItem.Size, default(FLinearColor), tempInteractiveItem.Duration, tempInteractiveItem.Intensity));
		}
		TempInteractiveItems.Clear();
		if (SceneCaptureComponent != null && bCapturingEnabled)
		{
			SceneCaptureComponent.CaptureScene();
		}
	}

	public void SetCapturingEnabled(bool Enabled)
	{
		bCapturingEnabled = Enabled;
	}

	private FGSNiagaraParticleInfo MakeGSNiagaraParticleInfo(int InParticleType, FVector InPosition, FVector InSize, FLinearColor InColor, float InDuration, float InIntensity)
	{
		return new FGSNiagaraParticleInfo
		{
			ParticleType = InParticleType,
			Position = InPosition,
			Size = InSize,
			Color = InColor,
			Duration = InDuration,
			Intensity = InIntensity
		};
	}

	[Category("GSEnv|Interactive")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:TriggerOnce")]
	public int TriggerOnce(FVector Position, FVector Size, int InteractiveType, float Intensity, float Duration)
	{
		BWS_EnvInteractiveItem bWS_EnvInteractiveItem = new BWS_EnvInteractiveItem();
		bWS_EnvInteractiveItem.InteractiveType = InteractiveType;
		bWS_EnvInteractiveItem.Id = InteractorCount++;
		bWS_EnvInteractiveItem.Size = Size;
		bWS_EnvInteractiveItem.Position = Position;
		bWS_EnvInteractiveItem.Intensity = Intensity;
		bWS_EnvInteractiveItem.Duration = Duration;
		TempInteractiveItems.Add(bWS_EnvInteractiveItem);
		return bWS_EnvInteractiveItem.Id;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("GSEnv|Interactive")]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:AddInteractor")]
	public int AddInteractor(UPrimitiveComponent PrimComp, int InteractiveType, FVector Size, float Intensity, float Duration)
	{
		if (PrimComp == null)
		{
			return -1;
		}
		BWS_EnvInteractivePrimitive bWS_EnvInteractivePrimitive = new BWS_EnvInteractivePrimitive();
		bWS_EnvInteractivePrimitive.Id = InteractorCount++;
		bWS_EnvInteractivePrimitive.PrimtiveComp = PrimComp;
		bWS_EnvInteractivePrimitive.InteractiveType = InteractiveType;
		bWS_EnvInteractivePrimitive.Size = Size;
		bWS_EnvInteractivePrimitive.Intensity = Intensity;
		bWS_EnvInteractivePrimitive.Duration = Duration;
		InteractivePrims.Add(bWS_EnvInteractivePrimitive);
		return bWS_EnvInteractivePrimitive.Id;
	}

	[Category("GSEnv|Interactive")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BWS_EnvInteractiveCapture:RemoveInteractor")]
	public void RemoveInteractor(int InteractorID)
	{
		for (int num = InteractivePrims.Count - 1; num >= 0; num--)
		{
			if (InteractivePrims[num].Id == InteractorID)
			{
				InteractivePrims.RemoveAt(num);
				break;
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_EnvInteractiveCapture:Init")]
	private static void Init__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_EnvInteractiveCapture bWS_EnvInteractiveCapture = GCHelper.Find<BWS_EnvInteractiveCapture>(obj);
		bWS_EnvInteractiveCapture.Init();
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_EnvInteractiveCapture:TriggerOnce")]
	private static void TriggerOnce__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_EnvInteractiveCapture bWS_EnvInteractiveCapture = GCHelper.Find<BWS_EnvInteractiveCapture>(obj);
		FVector position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, TriggerOnce_Position_Offset));
		FVector size = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, TriggerOnce_Size_Offset));
		int interactiveType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TriggerOnce_InteractiveType_Offset));
		float intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TriggerOnce_Intensity_Offset));
		float duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TriggerOnce_Duration_Offset));
		int value = bWS_EnvInteractiveCapture.TriggerOnce(position, size, interactiveType, intensity, duration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, TriggerOnce_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnTickCapture")]
	private static void OnTickCapture__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_EnvInteractiveCapture bWS_EnvInteractiveCapture = GCHelper.Find<BWS_EnvInteractiveCapture>(obj);
		bWS_EnvInteractiveCapture.OnTickCapture();
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_EnvInteractiveCapture:AddInteractor")]
	private static void AddInteractor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_EnvInteractiveCapture bWS_EnvInteractiveCapture = GCHelper.Find<BWS_EnvInteractiveCapture>(obj);
		UPrimitiveComponent primComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, AddInteractor_PrimComp_Offset));
		int interactiveType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, AddInteractor_InteractiveType_Offset));
		FVector size = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, AddInteractor_Size_Offset));
		float intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddInteractor_Intensity_Offset));
		float duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddInteractor_Duration_Offset));
		int value = bWS_EnvInteractiveCapture.AddInteractor(primComp, interactiveType, size, intensity, duration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, AddInteractor_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BWS_EnvInteractiveCapture:RemoveInteractor")]
	private static void RemoveInteractor__Invoker(IntPtr buffer, IntPtr obj)
	{
		BWS_EnvInteractiveCapture bWS_EnvInteractiveCapture = GCHelper.Find<BWS_EnvInteractiveCapture>(obj);
		int interactorID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, RemoveInteractor_InteractorID_Offset));
		bWS_EnvInteractiveCapture.RemoveInteractor(interactorID);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BWS_EnvInteractiveCapture");
		ParticleArrayData_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParticleArrayData");
		ParticleArrayData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParticleArrayData", Classes.FObjectProperty);
		RTSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "RTSize");
		RTSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RTSize", Classes.FIntProperty);
		RT_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT");
		RT_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT", Classes.FObjectProperty);
		SceneCaptureComponent_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneCaptureComponent");
		SceneCaptureComponent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneCaptureComponent", Classes.FObjectProperty);
		CaptureMPC_Offset = NativeReflection.GetPropertyOffset(intPtr, "CaptureMPC");
		CaptureMPC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CaptureMPC", Classes.FObjectProperty);
		CaptureInterval_Offset = NativeReflection.GetPropertyOffset(intPtr, "CaptureInterval");
		CaptureInterval_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CaptureInterval", Classes.FFloatProperty);
		ParticleFadeDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParticleFadeDuration");
		ParticleFadeDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParticleFadeDuration", Classes.FFloatProperty);
		ParicleHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParicleHeight");
		ParicleHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParicleHeight", Classes.FFloatProperty);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_EnvInteractiveCapture:Init", Init_IsValid);
		OnLateInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnLateInit");
		OnLateInit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLateInit_FunctionAddress);
		OnLateInit_IsValid = OnLateInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnLateInit", OnLateInit_IsValid);
		TriggerOnce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TriggerOnce");
		TriggerOnce_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerOnce_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TriggerOnce_Position_PropertyAddress, TriggerOnce_FunctionAddress, "Position");
		TriggerOnce_Position_Offset = NativeReflection.GetPropertyOffset(TriggerOnce_FunctionAddress, "Position");
		TriggerOnce_Position_IsValid = NativeReflection.ValidatePropertyClass(TriggerOnce_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TriggerOnce_Size_PropertyAddress, TriggerOnce_FunctionAddress, "Size");
		TriggerOnce_Size_Offset = NativeReflection.GetPropertyOffset(TriggerOnce_FunctionAddress, "Size");
		TriggerOnce_Size_IsValid = NativeReflection.ValidatePropertyClass(TriggerOnce_FunctionAddress, "Size", Classes.FStructProperty);
		TriggerOnce_InteractiveType_Offset = NativeReflection.GetPropertyOffset(TriggerOnce_FunctionAddress, "InteractiveType");
		TriggerOnce_InteractiveType_IsValid = NativeReflection.ValidatePropertyClass(TriggerOnce_FunctionAddress, "InteractiveType", Classes.FIntProperty);
		TriggerOnce_Intensity_Offset = NativeReflection.GetPropertyOffset(TriggerOnce_FunctionAddress, "Intensity");
		TriggerOnce_Intensity_IsValid = NativeReflection.ValidatePropertyClass(TriggerOnce_FunctionAddress, "Intensity", Classes.FFloatProperty);
		TriggerOnce_Duration_Offset = NativeReflection.GetPropertyOffset(TriggerOnce_FunctionAddress, "Duration");
		TriggerOnce_Duration_IsValid = NativeReflection.ValidatePropertyClass(TriggerOnce_FunctionAddress, "Duration", Classes.FFloatProperty);
		TriggerOnce_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TriggerOnce_FunctionAddress, "ReturnValue");
		TriggerOnce_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TriggerOnce_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		TriggerOnce_IsValid = TriggerOnce_FunctionAddress != IntPtr.Zero && TriggerOnce_Position_IsValid && TriggerOnce_Size_IsValid && TriggerOnce_InteractiveType_IsValid && TriggerOnce_Intensity_IsValid && TriggerOnce_Duration_IsValid && TriggerOnce_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_EnvInteractiveCapture:TriggerOnce", TriggerOnce_IsValid);
		OnEnableDebug_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnEnableDebug");
		OnEnableDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnableDebug_FunctionAddress);
		OnEnableDebug_IsValid = OnEnableDebug_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnEnableDebug", OnEnableDebug_IsValid);
		OnTickCapture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTickCapture");
		OnTickCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTickCapture_FunctionAddress);
		OnTickCapture_IsValid = OnTickCapture_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_EnvInteractiveCapture:OnTickCapture", OnTickCapture_IsValid);
		AddInteractor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddInteractor");
		AddInteractor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInteractor_FunctionAddress);
		AddInteractor_PrimComp_Offset = NativeReflection.GetPropertyOffset(AddInteractor_FunctionAddress, "PrimComp");
		AddInteractor_PrimComp_IsValid = NativeReflection.ValidatePropertyClass(AddInteractor_FunctionAddress, "PrimComp", Classes.FObjectProperty);
		AddInteractor_InteractiveType_Offset = NativeReflection.GetPropertyOffset(AddInteractor_FunctionAddress, "InteractiveType");
		AddInteractor_InteractiveType_IsValid = NativeReflection.ValidatePropertyClass(AddInteractor_FunctionAddress, "InteractiveType", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AddInteractor_Size_PropertyAddress, AddInteractor_FunctionAddress, "Size");
		AddInteractor_Size_Offset = NativeReflection.GetPropertyOffset(AddInteractor_FunctionAddress, "Size");
		AddInteractor_Size_IsValid = NativeReflection.ValidatePropertyClass(AddInteractor_FunctionAddress, "Size", Classes.FStructProperty);
		AddInteractor_Intensity_Offset = NativeReflection.GetPropertyOffset(AddInteractor_FunctionAddress, "Intensity");
		AddInteractor_Intensity_IsValid = NativeReflection.ValidatePropertyClass(AddInteractor_FunctionAddress, "Intensity", Classes.FFloatProperty);
		AddInteractor_Duration_Offset = NativeReflection.GetPropertyOffset(AddInteractor_FunctionAddress, "Duration");
		AddInteractor_Duration_IsValid = NativeReflection.ValidatePropertyClass(AddInteractor_FunctionAddress, "Duration", Classes.FFloatProperty);
		AddInteractor_ReturnValue_Offset = NativeReflection.GetPropertyOffset(AddInteractor_FunctionAddress, "ReturnValue");
		AddInteractor_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(AddInteractor_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddInteractor_IsValid = AddInteractor_FunctionAddress != IntPtr.Zero && AddInteractor_PrimComp_IsValid && AddInteractor_InteractiveType_IsValid && AddInteractor_Size_IsValid && AddInteractor_Intensity_IsValid && AddInteractor_Duration_IsValid && AddInteractor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_EnvInteractiveCapture:AddInteractor", AddInteractor_IsValid);
		RemoveInteractor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveInteractor");
		RemoveInteractor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInteractor_FunctionAddress);
		RemoveInteractor_InteractorID_Offset = NativeReflection.GetPropertyOffset(RemoveInteractor_FunctionAddress, "InteractorID");
		RemoveInteractor_InteractorID_IsValid = NativeReflection.ValidatePropertyClass(RemoveInteractor_FunctionAddress, "InteractorID", Classes.FIntProperty);
		RemoveInteractor_IsValid = RemoveInteractor_FunctionAddress != IntPtr.Zero && RemoveInteractor_InteractorID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BWS_EnvInteractiveCapture:RemoveInteractor", RemoveInteractor_IsValid);
	}

	static BWS_EnvInteractiveCapture()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BWS_EnvInteractiveCapture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BWS_EnvInteractiveCapture));
	}
}
