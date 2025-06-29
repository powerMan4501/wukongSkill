using System;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume")]
internal class BGUDispInteractAreaVolume : BGUActorBaseCS
{
	private TStrongObjectPtr<UMaterial> M_CombineTexture = new TStrongObjectPtr<UMaterial>();

	private TStrongObjectPtr<UTextureRenderTarget2D> RT_LandscapeMap = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private static bool DispInteractAreaVolume_IsValid;

	private static int DispInteractAreaVolume_Offset;

	private static bool LandscapeMaxHeight_IsValid;

	private static int LandscapeMaxHeight_Offset;

	private static bool LandScape_IsValid;

	private static int LandScape_Offset;

	private static bool WeightLayerName_IsValid;

	private static int WeightLayerName_Offset;

	private static bool SimulationSize_cm_IsValid;

	private static int SimulationSize_cm_Offset;

	private static bool InteractiveData_StorageSize_cm_IsValid;

	private static int InteractiveData_StorageSize_cm_Offset;

	private static bool InteractDistLimitToDispActor_IsValid;

	private static int InteractDistLimitToDispActor_Offset;

	private static bool NS_Landscape_Interactive_Particles_IsValid;

	private static int NS_Landscape_Interactive_Particles_Offset;

	private static bool NS_Landscape_Interactive_Simulator_IsValid;

	private static int NS_Landscape_Interactive_Simulator_Offset;

	private static bool LS_HeightMap_IsValid;

	private static int LS_HeightMap_Offset;

	private static bool LS_WeightMap_IsValid;

	private static int LS_WeightMap_Offset;

	private static bool MinX_IsValid;

	private static int MinX_Offset;

	private static bool MinY_IsValid;

	private static int MinY_Offset;

	private static bool MaxX_IsValid;

	private static int MaxX_Offset;

	private static bool MaxY_IsValid;

	private static int MaxY_Offset;

	private static bool LandscapeOriginOffset_IsValid;

	private static int LandscapeOriginOffset_Offset;

	private static bool UpdateLandScapeInfo_IsValid;

	private static IntPtr UpdateLandScapeInfo_FunctionAddress;

	private static int UpdateLandScapeInfo_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:DispInteractAreaVolume")]
	public UBoxComponent DispInteractAreaVolume
	{
		get
		{
			CheckDestroyed();
			if (!DispInteractAreaVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:DispInteractAreaVolume");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, DispInteractAreaVolume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DispInteractAreaVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:DispInteractAreaVolume");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, DispInteractAreaVolume_Offset), value);
			}
		}
	}

	[Category("配置")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:LandscapeMaxHeight")]
	public float LandscapeMaxHeight
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeMaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LandscapeMaxHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LandscapeMaxHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeMaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LandscapeMaxHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LandscapeMaxHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("配置")]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:LandScape")]
	public ALandscape LandScape
	{
		get
		{
			CheckDestroyed();
			if (!LandScape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LandScape");
				return null;
			}
			return UObjectMarshaler<ALandscape>.FromNative(IntPtr.Add(base.Address, LandScape_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandScape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LandScape");
			}
			else
			{
				UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(base.Address, LandScape_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("配置")]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:WeightLayerName")]
	public string WeightLayerName
	{
		get
		{
			CheckDestroyed();
			if (!WeightLayerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:WeightLayerName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, WeightLayerName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeightLayerName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:WeightLayerName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, WeightLayerName_Offset), value);
			}
		}
	}

	[Category("配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:SimulationSize_cm")]
	public float SimulationSize_cm
	{
		get
		{
			CheckDestroyed();
			if (!SimulationSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:SimulationSize_cm");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SimulationSize_cm_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SimulationSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:SimulationSize_cm");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SimulationSize_cm_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("配置")]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:InteractiveData_StorageSize_cm")]
	public float InteractiveData_StorageSize_cm
	{
		get
		{
			CheckDestroyed();
			if (!InteractiveData_StorageSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:InteractiveData_StorageSize_cm");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InteractiveData_StorageSize_cm_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractiveData_StorageSize_cm_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:InteractiveData_StorageSize_cm");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InteractiveData_StorageSize_cm_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("配置")]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:InteractDistLimitToDispActor")]
	public float InteractDistLimitToDispActor
	{
		get
		{
			CheckDestroyed();
			if (!InteractDistLimitToDispActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:InteractDistLimitToDispActor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InteractDistLimitToDispActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractDistLimitToDispActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:InteractDistLimitToDispActor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InteractDistLimitToDispActor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:NS_Landscape_Interactive_Particles")]
	public UNiagaraSystem NS_Landscape_Interactive_Particles
	{
		get
		{
			CheckDestroyed();
			if (!NS_Landscape_Interactive_Particles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:NS_Landscape_Interactive_Particles");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, NS_Landscape_Interactive_Particles_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NS_Landscape_Interactive_Particles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:NS_Landscape_Interactive_Particles");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, NS_Landscape_Interactive_Particles_Offset), value);
			}
		}
	}

	[Category("配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:NS_Landscape_Interactive_Simulator")]
	public UNiagaraSystem NS_Landscape_Interactive_Simulator
	{
		get
		{
			CheckDestroyed();
			if (!NS_Landscape_Interactive_Simulator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:NS_Landscape_Interactive_Simulator");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, NS_Landscape_Interactive_Simulator_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NS_Landscape_Interactive_Simulator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:NS_Landscape_Interactive_Simulator");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, NS_Landscape_Interactive_Simulator_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("验证")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:LS_HeightMap")]
	public UTexture2D LS_HeightMap
	{
		get
		{
			CheckDestroyed();
			if (!LS_HeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LS_HeightMap");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, LS_HeightMap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_HeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LS_HeightMap");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, LS_HeightMap_Offset), value);
			}
		}
	}

	[Category("验证")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:LS_WeightMap")]
	public UTexture2D LS_WeightMap
	{
		get
		{
			CheckDestroyed();
			if (!LS_WeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LS_WeightMap");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, LS_WeightMap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LS_WeightMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LS_WeightMap");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, LS_WeightMap_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:MinX")]
	public int MinX
	{
		get
		{
			CheckDestroyed();
			if (!MinX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MinX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MinX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinX_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:MinY")]
	public int MinY
	{
		get
		{
			CheckDestroyed();
			if (!MinY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MinY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MinY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinY_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:MaxX")]
	public int MaxX
	{
		get
		{
			CheckDestroyed();
			if (!MaxX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MaxX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MaxX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxX_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:MaxY")]
	public int MaxY
	{
		get
		{
			CheckDestroyed();
			if (!MaxY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MaxY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:MaxY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxY_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("验证")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:LandscapeOriginOffset")]
	public FVector LandscapeOriginOffset
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeOriginOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LandscapeOriginOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LandscapeOriginOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeOriginOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDispInteractAreaVolume:LandscapeOriginOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LandscapeOriginOffset_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DispInteractAreaVolume = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.DispInteractAreaVolume);
		SetRootComponentCS(DispInteractAreaVolume);
		DispInteractAreaVolume.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
		InteractDistLimitToDispActor = 5000f;
		InteractiveData_StorageSize_cm = 8192f;
		SimulationSize_cm = 2048f;
	}

	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.DispInteractDataComp);
	}

	private void CombineLandscapeMaps()
	{
		if (LS_HeightMap != null && LS_WeightMap != null)
		{
			M_CombineTexture.Set((UMaterial)UGSE_LoadingUtilFuncLib.SyncLoadObject("/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/Materials/M_CombineTexture.M_CombineTexture"));
			RT_LandscapeMap.Set((UTextureRenderTarget2D)UGSE_LoadingUtilFuncLib.SyncLoadObject("/Game/00Main/Design/Tech/Landscape_Interactive_Virtual/RTs/RT_LandscapeMap.RT_LandscapeMap"));
			UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(this, M_CombineTexture.Get(), FName.None, EMIDCreationFlags.None);
			uMaterialInstanceDynamic.SetTextureParameterValue(B1GlobalFNames.R, LS_HeightMap);
			uMaterialInstanceDynamic.SetTextureParameterValue(B1GlobalFNames.G, LS_WeightMap);
			URenderingLibrary.ClearRenderTarget2D(this, RT_LandscapeMap.Get(), FLinearColor.Black);
			URenderingLibrary.DrawMaterialToRenderTarget(this, RT_LandscapeMap.Get(), uMaterialInstanceDynamic);
		}
	}

	[UFunction]
	[Category("配置")]
	[UMeta(MDFunc.CallInEditor)]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUDispInteractAreaVolume:UpdateLandScapeInfo")]
	public void UpdateLandScapeInfo()
	{
		if (LandScape != null)
		{
			UBGUFunctionLibraryForCS.BGUGetLandscapeExtent(LandScape, out var MinX, out var MinY, out var MaxX, out var MaxY);
			this.MinX = MinX;
			this.MinY = MinY;
			this.MaxX = MaxX;
			this.MaxY = MaxY;
			LandscapeOriginOffset = UGSE_LandscapeFuncLib.GetLandscapeOriginOffset(LandScape);
			string pathName = base.World.GetPathName();
			string pathName2 = (GetOuter() as ULevel).GetPathName();
			int num = pathName2.LastIndexOf('/');
			int num2 = pathName2.LastIndexOf('.');
			string text = pathName2.Substring(num + 1, num2 - num - 1);
			string[] array = pathName.Split('/');
			string text2 = "";
			for (int i = 0; i < array.Length - 1; i++)
			{
				text2 = text2 + array[i] + "/";
			}
			text2 += "InteractTex/";
			string text3 = GetName().Substring("BGUDispInteractAreaVolume".Length);
			UBGUFunctionLibraryForCS.BGUGetActorLevelName(this);
			UTexture2D lS_HeightMap = UBGUFunctionLibraryForCS.BGUCreateLandscapeHeightMap(LandScape, text2, text + "_HMTex_" + text3);
			LS_HeightMap = lS_HeightMap;
			if (!string.IsNullOrEmpty(WeightLayerName))
			{
				UTexture2D lS_WeightMap = UGSE_LandscapeFuncLib.SaveLandscapeLayerWeightTex(text2, text + "_WMTex_" + text3, LandScape, WeightLayerName);
				LS_WeightMap = lS_WeightMap;
			}
			CombineLandscapeMaps();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDispInteractAreaVolume:UpdateLandScapeInfo")]
	private static void UpdateLandScapeInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUDispInteractAreaVolume bGUDispInteractAreaVolume = GCHelper.Find<b1.BGUDispInteractAreaVolume>(obj);
		bGUDispInteractAreaVolume.UpdateLandScapeInfo();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDispInteractAreaVolume:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUDispInteractAreaVolume bGUDispInteractAreaVolume = GCHelper.Find<b1.BGUDispInteractAreaVolume>(obj);
		bGUDispInteractAreaVolume.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDispInteractAreaVolume");
		DispInteractAreaVolume_Offset = NativeReflection.GetPropertyOffset(intPtr, "DispInteractAreaVolume");
		DispInteractAreaVolume_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DispInteractAreaVolume", Classes.FObjectProperty);
		LandscapeMaxHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandscapeMaxHeight");
		LandscapeMaxHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandscapeMaxHeight", Classes.FFloatProperty);
		LandScape_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandScape");
		LandScape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandScape", Classes.FObjectProperty);
		WeightLayerName_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeightLayerName");
		WeightLayerName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeightLayerName", Classes.FStrProperty);
		SimulationSize_cm_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimulationSize_cm");
		SimulationSize_cm_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimulationSize_cm", Classes.FFloatProperty);
		InteractiveData_StorageSize_cm_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractiveData_StorageSize_cm");
		InteractiveData_StorageSize_cm_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractiveData_StorageSize_cm", Classes.FFloatProperty);
		InteractDistLimitToDispActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractDistLimitToDispActor");
		InteractDistLimitToDispActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractDistLimitToDispActor", Classes.FFloatProperty);
		NS_Landscape_Interactive_Particles_Offset = NativeReflection.GetPropertyOffset(intPtr, "NS_Landscape_Interactive_Particles");
		NS_Landscape_Interactive_Particles_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NS_Landscape_Interactive_Particles", Classes.FObjectProperty);
		NS_Landscape_Interactive_Simulator_Offset = NativeReflection.GetPropertyOffset(intPtr, "NS_Landscape_Interactive_Simulator");
		NS_Landscape_Interactive_Simulator_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NS_Landscape_Interactive_Simulator", Classes.FObjectProperty);
		LS_HeightMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "LS_HeightMap");
		LS_HeightMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LS_HeightMap", Classes.FObjectProperty);
		LS_WeightMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "LS_WeightMap");
		LS_WeightMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LS_WeightMap", Classes.FObjectProperty);
		MinX_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinX");
		MinX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinX", Classes.FIntProperty);
		MinY_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinY");
		MinY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinY", Classes.FIntProperty);
		MaxX_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxX");
		MaxX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxX", Classes.FIntProperty);
		MaxY_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxY");
		MaxY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxY", Classes.FIntProperty);
		LandscapeOriginOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "LandscapeOriginOffset");
		LandscapeOriginOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LandscapeOriginOffset", Classes.FStructProperty);
		UpdateLandScapeInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateLandScapeInfo");
		UpdateLandScapeInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateLandScapeInfo_FunctionAddress);
		UpdateLandScapeInfo_IsValid = UpdateLandScapeInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDispInteractAreaVolume:UpdateLandScapeInfo", UpdateLandScapeInfo_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDispInteractAreaVolume:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGUDispInteractAreaVolume()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUDispInteractAreaVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUDispInteractAreaVolume));
	}
}
