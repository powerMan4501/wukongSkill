using System;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.LandscapeEditorUtilities;
using UnrealEngine.Runtime;

namespace b1.Render.LandscapeBpBrush;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.LandscapeRoadBrush")]
internal class LandscapeRoadBrush : ALandscapeBlueprintBrush
{
	private bool bHeightmapRender;

	private string CurLayerName;

	private string PreLayerName = "";

	private float AccTime;

	private static bool BrushManager_IsValid;

	private static int BrushManager_Offset;

	private static bool ParentHeightmapMat_IsValid;

	private static int ParentHeightmapMat_Offset;

	private static bool HeightmapMID_IsValid;

	private static int HeightmapMID_Offset;

	private static bool BaseLayerWeightMat_IsValid;

	private static int BaseLayerWeightMat_Offset;

	private static bool ALayerWeightMat_IsValid;

	private static int ALayerWeightMat_Offset;

	private static bool BLayerWeightMat_IsValid;

	private static int BLayerWeightMat_Offset;

	private static bool WeightmapMID_IsValid;

	private static int WeightmapMID_Offset;

	private static bool UpdateInterval_IsValid;

	private static int UpdateInterval_Offset;

	private static bool Render_IsValid;

	private static IntPtr Render_FunctionAddress;

	private static int Render_ParamsSize;

	private static bool Render_InIsHeightmap_IsValid;

	private static int Render_InIsHeightmap_Offset;

	private static FFieldAddress Render_InIsHeightmap_PropertyAddress;

	private static bool Render_InCombinedResult_IsValid;

	private static int Render_InCombinedResult_Offset;

	private static bool Render_InWeightmapLayerName_IsValid;

	private static int Render_InWeightmapLayerName_Offset;

	private static bool Render_ReturnValue_IsValid;

	private static int Render_ReturnValue_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InLandscapeTransform_IsValid;

	private static int Initialize_InLandscapeTransform_Offset;

	private static FFieldAddress Initialize_InLandscapeTransform_PropertyAddress;

	private static bool Initialize_InLandscapeSize_IsValid;

	private static int Initialize_InLandscapeSize_Offset;

	private static FFieldAddress Initialize_InLandscapeSize_PropertyAddress;

	private static bool Initialize_InLandscapeRenderTargetSize_IsValid;

	private static int Initialize_InLandscapeRenderTargetSize_Offset;

	private static FFieldAddress Initialize_InLandscapeRenderTargetSize_PropertyAddress;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:BrushManager")]
	private BGLandmassActor BrushManager
	{
		get
		{
			CheckDestroyed();
			if (!BrushManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:BrushManager");
				return null;
			}
			return UObjectMarshaler<BGLandmassActor>.FromNative(IntPtr.Add(base.Address, BrushManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:BrushManager");
			}
			else
			{
				UObjectMarshaler<BGLandmassActor>.ToNative(IntPtr.Add(base.Address, BrushManager_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:ParentHeightmapMat")]
	public UMaterialInterface ParentHeightmapMat
	{
		get
		{
			CheckDestroyed();
			if (!ParentHeightmapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:ParentHeightmapMat");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, ParentHeightmapMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentHeightmapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:ParentHeightmapMat");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, ParentHeightmapMat_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:HeightmapMID")]
	private UMaterialInstanceDynamic HeightmapMID
	{
		get
		{
			CheckDestroyed();
			if (!HeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:HeightmapMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, HeightmapMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:HeightmapMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, HeightmapMID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:BaseLayerWeightMat")]
	public UMaterialInterface BaseLayerWeightMat
	{
		get
		{
			CheckDestroyed();
			if (!BaseLayerWeightMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:BaseLayerWeightMat");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, BaseLayerWeightMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseLayerWeightMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:BaseLayerWeightMat");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, BaseLayerWeightMat_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:ALayerWeightMat")]
	public UMaterialInterface ALayerWeightMat
	{
		get
		{
			CheckDestroyed();
			if (!ALayerWeightMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:ALayerWeightMat");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, ALayerWeightMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ALayerWeightMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:ALayerWeightMat");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, ALayerWeightMat_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:BLayerWeightMat")]
	public UMaterialInterface BLayerWeightMat
	{
		get
		{
			CheckDestroyed();
			if (!BLayerWeightMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:BLayerWeightMat");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, BLayerWeightMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BLayerWeightMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:BLayerWeightMat");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, BLayerWeightMat_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:WeightmapMID")]
	private UMaterialInstanceDynamic WeightmapMID
	{
		get
		{
			CheckDestroyed();
			if (!WeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:WeightmapMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, WeightmapMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:WeightmapMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, WeightmapMID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:UpdateInterval")]
	public float UpdateInterval
	{
		get
		{
			CheckDestroyed();
			if (!UpdateInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:UpdateInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpdateInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdateInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeRoadBrush:UpdateInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpdateInterval_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:Initialize")]
	protected override void Initialize_Implementation(FTransform InLandscapeTransform, FIntPoint InLandscapeSize, FIntPoint InLandscapeRenderTargetSize)
	{
		SpawnOrUpdateManager(InLandscapeTransform, InLandscapeSize, InLandscapeRenderTargetSize);
	}

	private void BrushSetup(UTextureRenderTarget2D InCombinedResult, UMaterialInterface ParentWeightmapMat)
	{
		BrushManager.AllocateRTs();
		BrushManager.SetMPCParams();
		if (HeightmapMID.IsNullOrDestroyed())
		{
			HeightmapMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, ParentHeightmapMat, FName.None, EMIDCreationFlags.None);
		}
		if (CurLayerName != PreLayerName)
		{
			WeightmapMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, ParentWeightmapMat, FName.None, EMIDCreationFlags.None);
			PreLayerName = CurLayerName;
		}
		HeightmapMID.SetTextureParameterValue(B1GlobalFNames.HeightRT, InCombinedResult);
		WeightmapMID.SetTextureParameterValue(B1GlobalFNames.WeightRT, InCombinedResult);
	}

	private void DrawBrushMaterial()
	{
		if (bHeightmapRender)
		{
			URenderingLibrary.ClearRenderTarget2D(this, BrushManager.HeightmapRT, FLinearColor.Black);
			URenderingLibrary.DrawMaterialToRenderTarget(this, BrushManager.HeightmapRT, HeightmapMID);
		}
		else
		{
			URenderingLibrary.ClearRenderTarget2D(this, BrushManager.WeightmapRT, FLinearColor.Black);
			URenderingLibrary.DrawMaterialToRenderTarget(this, BrushManager.WeightmapRT, WeightmapMID);
		}
	}

	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:Render")]
	protected override UTextureRenderTarget2D Render_Implementation(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, FName InWeightmapLayerName)
	{
		if (ParentHeightmapMat.IsNullOrDestroyed() || BaseLayerWeightMat.IsNullOrDestroyed() || ALayerWeightMat.IsNullOrDestroyed() || BLayerWeightMat.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("HeightmapMat/WeightmapMapt is invalid");
			return null;
		}
		CurLayerName = InWeightmapLayerName.PlainName;
		UMaterialInterface parentWeightmapMat = ((!(InWeightmapLayerName.PlainName == "Layer3")) ? BaseLayerWeightMat : ALayerWeightMat);
		bHeightmapRender = InIsHeightmap;
		BrushSetup(InCombinedResult, parentWeightmapMat);
		DrawBrushMaterial();
		if (!bHeightmapRender)
		{
			return BrushManager.WeightmapRT;
		}
		return BrushManager.HeightmapRT;
	}

	[USharpPath("/Script/b1-Managed.LandscapeRoadBrush:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		AccTime += DeltaSeconds;
		if (AccTime > UpdateInterval)
		{
			AccTime = 0f;
			ALandscape bPBrushOwningLandscape = UGSE_LandscapeFuncLib.GetBPBrushOwningLandscape(this);
			if (!bPBrushOwningLandscape.IsNullOrDestroyed())
			{
				UGSE_LandscapeFuncLib.UpdateLandescape(bPBrushOwningLandscape);
			}
		}
	}

	private void SpawnOrUpdateManager(FTransform InLsTransform, FIntPoint InLSSize, FIntPoint InRTSize)
	{
		if (BrushManager.IsNullOrDestroyed())
		{
			if (UGameplayStatics.GetAllActorsOfClass<BGLandmassActor>(this).Length != 0)
			{
				BrushManager = UGameplayStatics.GetAllActorsOfClass<BGLandmassActor>(this)[0];
			}
			else
			{
				BrushManager = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay<BGLandmassActor>(base.World);
			}
			BrushManager.LandscapeQuads = InLSSize;
			BrushManager.LandscapeRTRes = InRTSize;
			BrushManager.LandscapeTransform = InLsTransform;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeRoadBrush:Render")]
	private static void Render__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.LandscapeBpBrush.LandscapeRoadBrush landscapeRoadBrush = GCHelper.Find<b1.Render.LandscapeBpBrush.LandscapeRoadBrush>(obj);
		bool inIsHeightmap = BoolMarshaler.FromNative(IntPtr.Add(buffer, Render_InIsHeightmap_Offset), 0, Render_InIsHeightmap_PropertyAddress.Address);
		UTextureRenderTarget2D inCombinedResult = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(buffer, Render_InCombinedResult_Offset));
		FName inWeightmapLayerName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, Render_InWeightmapLayerName_Offset));
		UTextureRenderTarget2D value = landscapeRoadBrush.Render_Implementation(inIsHeightmap, inCombinedResult, inWeightmapLayerName);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(buffer, Render_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeRoadBrush:Initialize")]
	private static void Initialize__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.LandscapeBpBrush.LandscapeRoadBrush landscapeRoadBrush = GCHelper.Find<b1.Render.LandscapeBpBrush.LandscapeRoadBrush>(obj);
		FTransform inLandscapeTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeTransform_Offset));
		FIntPoint inLandscapeSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeSize_Offset));
		FIntPoint inLandscapeRenderTargetSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeRenderTargetSize_Offset));
		landscapeRoadBrush.Initialize_Implementation(inLandscapeTransform, inLandscapeSize, inLandscapeRenderTargetSize);
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeRoadBrush:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.Render.LandscapeBpBrush.LandscapeRoadBrush landscapeRoadBrush = GCHelper.Find<b1.Render.LandscapeBpBrush.LandscapeRoadBrush>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		landscapeRoadBrush.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.LandscapeRoadBrush");
		BrushManager_Offset = NativeReflection.GetPropertyOffset(intPtr, "BrushManager");
		BrushManager_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BrushManager", Classes.FObjectProperty);
		ParentHeightmapMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParentHeightmapMat");
		ParentHeightmapMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParentHeightmapMat", Classes.FObjectProperty);
		HeightmapMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeightmapMID");
		HeightmapMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeightmapMID", Classes.FObjectProperty);
		BaseLayerWeightMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseLayerWeightMat");
		BaseLayerWeightMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseLayerWeightMat", Classes.FObjectProperty);
		ALayerWeightMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ALayerWeightMat");
		ALayerWeightMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ALayerWeightMat", Classes.FObjectProperty);
		BLayerWeightMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "BLayerWeightMat");
		BLayerWeightMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BLayerWeightMat", Classes.FObjectProperty);
		WeightmapMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeightmapMID");
		WeightmapMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeightmapMID", Classes.FObjectProperty);
		UpdateInterval_Offset = NativeReflection.GetPropertyOffset(intPtr, "UpdateInterval");
		UpdateInterval_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UpdateInterval", Classes.FFloatProperty);
		Render_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Render");
		Render_ParamsSize = NativeReflection.GetFunctionParamsSize(Render_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Render_InIsHeightmap_PropertyAddress, Render_FunctionAddress, "InIsHeightmap");
		Render_InIsHeightmap_Offset = NativeReflection.GetPropertyOffset(Render_FunctionAddress, "InIsHeightmap");
		Render_InIsHeightmap_IsValid = NativeReflection.ValidatePropertyClass(Render_FunctionAddress, "InIsHeightmap", Classes.FBoolProperty);
		Render_InCombinedResult_Offset = NativeReflection.GetPropertyOffset(Render_FunctionAddress, "InCombinedResult");
		Render_InCombinedResult_IsValid = NativeReflection.ValidatePropertyClass(Render_FunctionAddress, "InCombinedResult", Classes.FObjectProperty);
		Render_InWeightmapLayerName_Offset = NativeReflection.GetPropertyOffset(Render_FunctionAddress, "InWeightmapLayerName");
		Render_InWeightmapLayerName_IsValid = NativeReflection.ValidatePropertyClass(Render_FunctionAddress, "InWeightmapLayerName", Classes.FNameProperty);
		Render_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Render_FunctionAddress, "ReturnValue");
		Render_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Render_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Render_IsValid = Render_FunctionAddress != IntPtr.Zero && Render_InIsHeightmap_IsValid && Render_InCombinedResult_IsValid && Render_InWeightmapLayerName_IsValid && Render_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeRoadBrush:Render", Render_IsValid);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Initialize_InLandscapeTransform_PropertyAddress, Initialize_FunctionAddress, "InLandscapeTransform");
		Initialize_InLandscapeTransform_Offset = NativeReflection.GetPropertyOffset(Initialize_FunctionAddress, "InLandscapeTransform");
		Initialize_InLandscapeTransform_IsValid = NativeReflection.ValidatePropertyClass(Initialize_FunctionAddress, "InLandscapeTransform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Initialize_InLandscapeSize_PropertyAddress, Initialize_FunctionAddress, "InLandscapeSize");
		Initialize_InLandscapeSize_Offset = NativeReflection.GetPropertyOffset(Initialize_FunctionAddress, "InLandscapeSize");
		Initialize_InLandscapeSize_IsValid = NativeReflection.ValidatePropertyClass(Initialize_FunctionAddress, "InLandscapeSize", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Initialize_InLandscapeRenderTargetSize_PropertyAddress, Initialize_FunctionAddress, "InLandscapeRenderTargetSize");
		Initialize_InLandscapeRenderTargetSize_Offset = NativeReflection.GetPropertyOffset(Initialize_FunctionAddress, "InLandscapeRenderTargetSize");
		Initialize_InLandscapeRenderTargetSize_IsValid = NativeReflection.ValidatePropertyClass(Initialize_FunctionAddress, "InLandscapeRenderTargetSize", Classes.FStructProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InLandscapeTransform_IsValid && Initialize_InLandscapeSize_IsValid && Initialize_InLandscapeRenderTargetSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeRoadBrush:Initialize", Initialize_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeRoadBrush:ReceiveTick", ReceiveTick_IsValid);
	}

	static LandscapeRoadBrush()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.Render.LandscapeBpBrush.LandscapeRoadBrush)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.Render.LandscapeBpBrush.LandscapeRoadBrush));
	}
}
