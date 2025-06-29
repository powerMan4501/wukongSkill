using System;
using UnrealEngine.Engine;
using UnrealEngine.LandscapeEditorUtilities;
using UnrealEngine.Runtime;

namespace b1.Render.LandscapeBpBrush;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.LandscapeLayerBrush")]
public class LandscapeLayerBrush : ALandscapeBlueprintBrush
{
	private bool bWeightmapRender;

	public float AccTime;

	private static bool BrushManager_IsValid;

	private static int BrushManager_Offset;

	private static bool WeightmapMatList_IsValid;

	private static int WeightmapMatList_Offset;

	private static FFieldAddress WeightmapMatList_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInterface> WeightmapMatList_Marshaler;

	private static bool WeightmapMIDList_IsValid;

	private static int WeightmapMIDList_Offset;

	private static FFieldAddress WeightmapMIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<UMaterialInstanceDynamic> WeightmapMIDList_Marshaler;

	private static bool TickBPBrush_IsValid;

	private static int TickBPBrush_Offset;

	private static FFieldAddress TickBPBrush_PropertyAddress;

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
	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:BrushManager")]
	private BGLandmassActor BrushManager
	{
		get
		{
			CheckDestroyed();
			if (!BrushManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:BrushManager");
				return null;
			}
			return UObjectMarshaler<BGLandmassActor>.FromNative(IntPtr.Add(base.Address, BrushManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:BrushManager");
			}
			else
			{
				UObjectMarshaler<BGLandmassActor>.ToNative(IntPtr.Add(base.Address, BrushManager_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:WeightmapMatList")]
	public TArrayReadWrite<UMaterialInterface> WeightmapMatList
	{
		get
		{
			CheckDestroyed();
			if (!WeightmapMatList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:WeightmapMatList");
				return null;
			}
			if (WeightmapMatList_Marshaler == null)
			{
				WeightmapMatList_Marshaler = new TArrayReadWriteMarshaler<UMaterialInterface>(1, WeightmapMatList_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative);
			}
			return WeightmapMatList_Marshaler.FromNative(IntPtr.Add(base.Address, WeightmapMatList_Offset));
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:WeightmapMIDList")]
	public TArrayReadWrite<UMaterialInstanceDynamic> WeightmapMIDList
	{
		get
		{
			CheckDestroyed();
			if (!WeightmapMIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:WeightmapMIDList");
				return null;
			}
			if (WeightmapMIDList_Marshaler == null)
			{
				WeightmapMIDList_Marshaler = new TArrayReadWriteMarshaler<UMaterialInstanceDynamic>(1, WeightmapMIDList_PropertyAddress, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.FromNative, CachedMarshalingDelegates<UMaterialInstanceDynamic, UObjectMarshaler<UMaterialInstanceDynamic>>.ToNative);
			}
			return WeightmapMIDList_Marshaler.FromNative(IntPtr.Add(base.Address, WeightmapMIDList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:TickBPBrush")]
	public bool TickBPBrush
	{
		get
		{
			CheckDestroyed();
			if (!TickBPBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:TickBPBrush");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TickBPBrush_Offset), 0, TickBPBrush_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TickBPBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:TickBPBrush");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TickBPBrush_Offset), 0, TickBPBrush_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:UpdateInterval")]
	public float UpdateInterval
	{
		get
		{
			CheckDestroyed();
			if (!UpdateInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:UpdateInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpdateInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdateInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeLayerBrush:UpdateInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpdateInterval_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:Initialize")]
	protected override void Initialize_Implementation(FTransform InLandscapeTransform, FIntPoint InLandscapeSize, FIntPoint InLandscapeRenderTargetSize)
	{
		SpawnOrUpdateManager(InLandscapeSize, InLandscapeRenderTargetSize);
	}

	private void BrushSetup(UTextureRenderTarget2D InCombinedResult, FName LayerName)
	{
		BrushManager.AllocateRTs();
		BrushManager.SetMPCParams();
		_ = bWeightmapRender;
	}

	private void DrawBrushMaterial(FName LayerName)
	{
		if (bWeightmapRender)
		{
			UMaterialInstanceDynamic mIDByLayerName = GetMIDByLayerName(LayerName);
			URenderingLibrary.ClearRenderTarget2D(this, BrushManager.WeightmapRT, FLinearColor.Black);
			if (!mIDByLayerName.IsNullOrDestroyed())
			{
				URenderingLibrary.DrawMaterialToRenderTarget(this, BrushManager.WeightmapRT, mIDByLayerName);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:Render")]
	protected override UTextureRenderTarget2D Render_Implementation(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, FName InWeightmapLayerName)
	{
		if (WeightmapMatList.Count != base.AffectedWeightmapLayers.Count)
		{
			return BrushManager.WeightmapRT;
		}
		bWeightmapRender = !InIsHeightmap;
		BrushSetup(InCombinedResult, InWeightmapLayerName);
		DrawBrushMaterial(InWeightmapLayerName);
		if (!bWeightmapRender)
		{
			return BrushManager.HeightmapRT;
		}
		return BrushManager.WeightmapRT;
	}

	private void SpawnOrUpdateManager(FIntPoint InLSSize, FIntPoint InRTSize)
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
		}
	}

	private UMaterialInstanceDynamic GetMIDByLayerName(FName LayerName)
	{
		if (!InitMID())
		{
			return null;
		}
		for (int i = 0; i < base.AffectedWeightmapLayers.Count; i++)
		{
			if (base.AffectedWeightmapLayers[i] == LayerName && WeightmapMatList.Count > i)
			{
				return WeightmapMIDList[i];
			}
		}
		return null;
	}

	private bool InitMID()
	{
		for (int i = 0; i < WeightmapMatList.Count; i++)
		{
			UMaterialInterface uMaterialInterface = WeightmapMatList[i];
			if (uMaterialInterface.IsNullOrDestroyed())
			{
				return false;
			}
			if (i > WeightmapMIDList.Count - 1)
			{
				UMaterialInstanceDynamic item = UMaterialLibrary.CreateDynamicMaterialInstance(this, WeightmapMatList[i], FName.None, EMIDCreationFlags.None);
				WeightmapMIDList.Add(item);
			}
			else if (WeightmapMIDList[i].IsNullOrDestroyed() || WeightmapMIDList[i].GetBaseMaterial() != uMaterialInterface.GetBaseMaterial())
			{
				WeightmapMIDList[i] = UMaterialLibrary.CreateDynamicMaterialInstance(this, WeightmapMatList[i], FName.None, EMIDCreationFlags.None);
			}
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.LandscapeLayerBrush:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		if (TickBPBrush)
		{
			AccTime += DeltaSeconds;
			if (AccTime > UpdateInterval)
			{
				AccTime = 0f;
				UGSE_LandscapeFuncLib.UpdateLandescape(UGSE_LandscapeFuncLib.GetBPBrushOwningLandscape(this));
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeLayerBrush:Render")]
	private static void Render__Invoker(IntPtr buffer, IntPtr obj)
	{
		LandscapeLayerBrush landscapeLayerBrush = GCHelper.Find<LandscapeLayerBrush>(obj);
		bool inIsHeightmap = BoolMarshaler.FromNative(IntPtr.Add(buffer, Render_InIsHeightmap_Offset), 0, Render_InIsHeightmap_PropertyAddress.Address);
		UTextureRenderTarget2D inCombinedResult = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(buffer, Render_InCombinedResult_Offset));
		FName inWeightmapLayerName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, Render_InWeightmapLayerName_Offset));
		UTextureRenderTarget2D value = landscapeLayerBrush.Render_Implementation(inIsHeightmap, inCombinedResult, inWeightmapLayerName);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(buffer, Render_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeLayerBrush:Initialize")]
	private static void Initialize__Invoker(IntPtr buffer, IntPtr obj)
	{
		LandscapeLayerBrush landscapeLayerBrush = GCHelper.Find<LandscapeLayerBrush>(obj);
		FTransform inLandscapeTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeTransform_Offset));
		FIntPoint inLandscapeSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeSize_Offset));
		FIntPoint inLandscapeRenderTargetSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeRenderTargetSize_Offset));
		landscapeLayerBrush.Initialize_Implementation(inLandscapeTransform, inLandscapeSize, inLandscapeRenderTargetSize);
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeLayerBrush:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		LandscapeLayerBrush landscapeLayerBrush = GCHelper.Find<LandscapeLayerBrush>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		landscapeLayerBrush.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.LandscapeLayerBrush");
		BrushManager_Offset = NativeReflection.GetPropertyOffset(intPtr, "BrushManager");
		BrushManager_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BrushManager", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref WeightmapMatList_PropertyAddress, intPtr, "WeightmapMatList");
		WeightmapMatList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeightmapMatList");
		WeightmapMatList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeightmapMatList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref WeightmapMIDList_PropertyAddress, intPtr, "WeightmapMIDList");
		WeightmapMIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeightmapMIDList");
		WeightmapMIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeightmapMIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref TickBPBrush_PropertyAddress, intPtr, "TickBPBrush");
		TickBPBrush_Offset = NativeReflection.GetPropertyOffset(intPtr, "TickBPBrush");
		TickBPBrush_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TickBPBrush", Classes.FBoolProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeLayerBrush:Render", Render_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeLayerBrush:Initialize", Initialize_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeLayerBrush:ReceiveTick", ReceiveTick_IsValid);
	}

	static LandscapeLayerBrush()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(LandscapeLayerBrush)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(LandscapeLayerBrush));
	}
}
