using System;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1.Render;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.CustomShadowComp")]
internal class CustomShadowComp : UBaseActorCompTickable
{
	private static bool MPC_CustomShadow_IsValid;

	private static int MPC_CustomShadow_Offset;

	private static bool Player_Actor_IsValid;

	private static int Player_Actor_Offset;

	private static bool RerenderSpeed_IsValid;

	private static int RerenderSpeed_Offset;

	private static bool OrthoWidth_IsValid;

	private static int OrthoWidth_Offset;

	private static bool SceneCapture_Actor_IsValid;

	private static int SceneCapture_Actor_Offset;

	private static bool Light_Actor_IsValid;

	private static int Light_Actor_Offset;

	private static bool SceneCapture_Comp_IsValid;

	private static int SceneCapture_Comp_Offset;

	private static bool LandscapeProxy_IsValid;

	private static int LandscapeProxy_Offset;

	private static bool LightVector_IsValid;

	private static int LightVector_Offset;

	private static bool CurrentRenderPos_IsValid;

	private static int CurrentRenderPos_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Tick_IsValid;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:MPC_CustomShadow")]
	public UMaterialParameterCollection MPC_CustomShadow
	{
		get
		{
			CheckDestroyed();
			if (!MPC_CustomShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:MPC_CustomShadow");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_CustomShadow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_CustomShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:MPC_CustomShadow");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_CustomShadow_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:Player_Actor")]
	private AActor Player_Actor
	{
		get
		{
			CheckDestroyed();
			if (!Player_Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:Player_Actor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, Player_Actor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Player_Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:Player_Actor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, Player_Actor_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:RerenderSpeed")]
	private float RerenderSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RerenderSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:RerenderSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RerenderSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RerenderSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:RerenderSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RerenderSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:OrthoWidth")]
	private float OrthoWidth
	{
		get
		{
			CheckDestroyed();
			if (!OrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:OrthoWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OrthoWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:OrthoWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OrthoWidth_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:SceneCapture_Actor")]
	private ASceneCapture2D SceneCapture_Actor
	{
		get
		{
			CheckDestroyed();
			if (!SceneCapture_Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:SceneCapture_Actor");
				return null;
			}
			return UObjectMarshaler<ASceneCapture2D>.FromNative(IntPtr.Add(base.Address, SceneCapture_Actor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneCapture_Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:SceneCapture_Actor");
			}
			else
			{
				UObjectMarshaler<ASceneCapture2D>.ToNative(IntPtr.Add(base.Address, SceneCapture_Actor_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:Light_Actor")]
	private ADirectionalLight Light_Actor
	{
		get
		{
			CheckDestroyed();
			if (!Light_Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:Light_Actor");
				return null;
			}
			return UObjectMarshaler<ADirectionalLight>.FromNative(IntPtr.Add(base.Address, Light_Actor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Light_Actor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:Light_Actor");
			}
			else
			{
				UObjectMarshaler<ADirectionalLight>.ToNative(IntPtr.Add(base.Address, Light_Actor_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:SceneCapture_Comp")]
	private USceneCaptureComponent2D SceneCapture_Comp
	{
		get
		{
			CheckDestroyed();
			if (!SceneCapture_Comp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:SceneCapture_Comp");
				return null;
			}
			return UObjectMarshaler<USceneCaptureComponent2D>.FromNative(IntPtr.Add(base.Address, SceneCapture_Comp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneCapture_Comp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:SceneCapture_Comp");
			}
			else
			{
				UObjectMarshaler<USceneCaptureComponent2D>.ToNative(IntPtr.Add(base.Address, SceneCapture_Comp_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:LandscapeProxy")]
	private ALandscapeProxy LandscapeProxy
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:LandscapeProxy");
				return null;
			}
			return UObjectMarshaler<ALandscapeProxy>.FromNative(IntPtr.Add(base.Address, LandscapeProxy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:LandscapeProxy");
			}
			else
			{
				UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(base.Address, LandscapeProxy_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:LightVector")]
	private FVector LightVector
	{
		get
		{
			CheckDestroyed();
			if (!LightVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:LightVector");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LightVector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightVector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:LightVector");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LightVector_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:CurrentRenderPos")]
	private FVector CurrentRenderPos
	{
		get
		{
			CheckDestroyed();
			if (!CurrentRenderPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:CurrentRenderPos");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CurrentRenderPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurrentRenderPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.CustomShadowComp:CurrentRenderPos");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CurrentRenderPos_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.CustomShadowComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		Init();
	}

	[USharpPath("/Script/b1-Managed.CustomShadowComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		Tick();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:Init")]
	public void Init()
	{
		OrthoWidth = UMaterialLibrary.GetScalarParameterValue(this, MPC_CustomShadow, B1GlobalFNames.OrthoWidth);
		RerenderSpeed = UMaterialLibrary.GetScalarParameterValue(this, MPC_CustomShadow, B1GlobalFNames.RerenderSpeed);
		ALandscapeProxy[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ALandscapeProxy>(this);
		LandscapeProxy = allActorsOfClass[0];
		ADirectionalLight[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<ADirectionalLight>(this);
		Light_Actor = allActorsOfClass2[0];
		ASceneCapture2D[] allActorsOfClass3 = UGameplayStatics.GetAllActorsOfClass<ASceneCapture2D>(this);
		SceneCapture_Actor = allActorsOfClass3[0];
		BGUPlayerCharacterCS[] allActorsOfClass4 = UGameplayStatics.GetAllActorsOfClass<BGUPlayerCharacterCS>(this);
		Player_Actor = allActorsOfClass4[0];
		LightVector = Light_Actor.GetActorRotation().RotateVector(new FVector(1.0, 0.0, 0.0));
		SceneCapture_Actor.SetActorRotation(Light_Actor.GetActorRotation(), bTeleportPhysics: false);
		SceneCapture_Comp = SceneCapture_Actor.GetComponentByClass<USceneCaptureComponent2D>();
		SceneCapture_Comp.OrthoWidth = OrthoWidth;
		CurrentRenderPos = Player_Actor.GetActorLocation();
		UpdateShadowMap(Player_Actor.GetActorLocation());
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.CustomShadowComp:Tick")]
	public void Tick()
	{
		if (!(Player_Actor == null))
		{
			LightVector = Light_Actor.GetActorRotation().RotateVector(new FVector(1.0, 0.0, 0.0));
			SceneCapture_Actor.SetActorRotation(Light_Actor.GetActorRotation(), bTeleportPhysics: false);
			if (MathLib.Dist(CurrentRenderPos, Player_Actor.GetActorLocation()) > OrthoWidth / 2f * (1f - RerenderSpeed))
			{
				CurrentRenderPos = Player_Actor.GetActorLocation();
				UpdateShadowMap(CurrentRenderPos);
			}
		}
	}

	private void UpdateShadowMap(FVector CurrentPos)
	{
		SceneCapture_Actor.SetActorLocation(CurrentPos - SceneCapture_Comp.OrthoWidth * LightVector, bSweep: false, out var _, bTeleport: false);
		SetCustomShadowMaterial(MPC_CustomShadow, SceneCapture_Actor, LightVector, OrthoWidth);
		if (!SceneCapture_Comp.CameraCutThisFrame)
		{
			SceneCapture_Comp.CaptureScene();
		}
	}

	private void SetCustomShadowMaterial(UMaterialParameterCollection MPC, AActor SceneCaptureActor, FVector LightDir, float OrthoWidth)
	{
		FMatrix fMatrix = SceneCaptureActor.GetActorTransform().ToMatrixNoScale().Inverse();
		FVector4 fVector = fMatrix.GetColumn(0);
		FVector4 fVector2 = fMatrix.GetColumn(1);
		FVector4 fVector3 = fMatrix.GetColumn(2);
		FVector4 fVector4 = fMatrix.GetTransposed().GetColumn(3);
		FLinearColor parameterValue = new FLinearColor(fVector.X, fVector.Y, fVector.Z);
		FLinearColor parameterValue2 = new FLinearColor(fVector2.X, fVector2.Y, fVector2.Z);
		FLinearColor parameterValue3 = new FLinearColor(fVector3.X, fVector3.Y, fVector3.Z);
		FLinearColor parameterValue4 = new FLinearColor(fVector4.X, fVector4.Y, fVector4.Z);
		FLinearColor parameterValue5 = new FLinearColor(LightDir.X, LightDir.Y, LightDir.Z);
		UMaterialLibrary.SetVectorParameterValue(this, MPC, B1GlobalFNames.X, parameterValue);
		UMaterialLibrary.SetVectorParameterValue(this, MPC, B1GlobalFNames.Y, parameterValue2);
		UMaterialLibrary.SetVectorParameterValue(this, MPC, B1GlobalFNames.Z, parameterValue3);
		UMaterialLibrary.SetVectorParameterValue(this, MPC, B1GlobalFNames.W, parameterValue4);
		UMaterialLibrary.SetVectorParameterValue(this, MPC, B1GlobalFNames.LightVector, parameterValue5);
	}

	[UFunctionInvoker("/Script/b1-Managed.CustomShadowComp:Init")]
	private static void Init__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.CustomShadowComp customShadowComp = GCHelper.Find<b1.Render.CustomShadowComp>(obj);
		customShadowComp.Init();
	}

	[UFunctionInvoker("/Script/b1-Managed.CustomShadowComp:Tick")]
	private static void Tick__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.CustomShadowComp customShadowComp = GCHelper.Find<b1.Render.CustomShadowComp>(obj);
		customShadowComp.Tick();
	}

	[UFunctionInvoker("/Script/b1-Managed.CustomShadowComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.CustomShadowComp customShadowComp = GCHelper.Find<b1.Render.CustomShadowComp>(obj);
		customShadowComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.CustomShadowComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.CustomShadowComp customShadowComp = GCHelper.Find<b1.Render.CustomShadowComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		customShadowComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.CustomShadowComp");
		MPC_CustomShadow_Offset = NativeReflection.GetPropertyOffset(intPtr, "MPC_CustomShadow");
		MPC_CustomShadow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MPC_CustomShadow", Classes.FObjectProperty);
		Player_Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Player_Actor");
		Player_Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Player_Actor", Classes.FObjectProperty);
		RerenderSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RerenderSpeed");
		RerenderSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RerenderSpeed", Classes.FFloatProperty);
		OrthoWidth_Offset = NativeReflection.GetPropertyOffset(intPtr, "OrthoWidth");
		OrthoWidth_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OrthoWidth", Classes.FFloatProperty);
		SceneCapture_Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneCapture_Actor");
		SceneCapture_Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneCapture_Actor", Classes.FObjectProperty);
		Light_Actor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Light_Actor");
		Light_Actor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Light_Actor", Classes.FObjectProperty);
		SceneCapture_Comp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneCapture_Comp");
		SceneCapture_Comp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneCapture_Comp", Classes.FObjectProperty);
		LandscapeProxy_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandscapeProxy");
		LandscapeProxy_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandscapeProxy", Classes.FObjectProperty);
		LightVector_Offset = NativeReflection.GetPropertyOffset(intPtr, "LightVector");
		LightVector_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LightVector", Classes.FStructProperty);
		CurrentRenderPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurrentRenderPos");
		CurrentRenderPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurrentRenderPos", Classes.FStructProperty);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.CustomShadowComp:Init", Init_IsValid);
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.CustomShadowComp:Tick", Tick_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.CustomShadowComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.CustomShadowComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static CustomShadowComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.Render.CustomShadowComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.Render.CustomShadowComp));
	}
}
