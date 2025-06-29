using System;
using UnrealEngine.Engine;
using UnrealEngine.LandscapeEditorUtilities;
using UnrealEngine.Runtime;

namespace b1.Render.LandscapeBpBrush;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest")]
public class LandscapeBpBrushTest : ALandscapeBlueprintBrush
{
	private bool bHeightmapRender;

	private static bool BrushManager_IsValid;

	private static int BrushManager_Offset;

	private static bool ParentHeightmapMat_IsValid;

	private static int ParentHeightmapMat_Offset;

	private static bool HeightmapMID_IsValid;

	private static int HeightmapMID_Offset;

	private static bool Path_IsValid;

	private static int Path_Offset;

	private static bool ParentWeightmapMat_IsValid;

	private static int ParentWeightmapMat_Offset;

	private static bool WeightmapMID_IsValid;

	private static int WeightmapMID_Offset;

	private static bool NoiseOffset_IsValid;

	private static int NoiseOffset_Offset;

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

	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:BrushManager")]
	private BGLandmassActor BrushManager
	{
		get
		{
			CheckDestroyed();
			if (!BrushManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:BrushManager");
				return null;
			}
			return UObjectMarshaler<BGLandmassActor>.FromNative(IntPtr.Add(base.Address, BrushManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrushManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:BrushManager");
			}
			else
			{
				UObjectMarshaler<BGLandmassActor>.ToNative(IntPtr.Add(base.Address, BrushManager_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:ParentHeightmapMat")]
	public UMaterialInterface ParentHeightmapMat
	{
		get
		{
			CheckDestroyed();
			if (!ParentHeightmapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:ParentHeightmapMat");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, ParentHeightmapMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentHeightmapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:ParentHeightmapMat");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, ParentHeightmapMat_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:HeightmapMID")]
	private UMaterialInstanceDynamic HeightmapMID
	{
		get
		{
			CheckDestroyed();
			if (!HeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:HeightmapMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, HeightmapMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:HeightmapMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, HeightmapMID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:Path")]
	public string Path
	{
		get
		{
			CheckDestroyed();
			if (!Path_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:Path");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Path_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Path_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:Path");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Path_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:ParentWeightmapMat")]
	public UMaterialInterface ParentWeightmapMat
	{
		get
		{
			CheckDestroyed();
			if (!ParentWeightmapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:ParentWeightmapMat");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, ParentWeightmapMat_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentWeightmapMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:ParentWeightmapMat");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, ParentWeightmapMat_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:WeightmapMID")]
	private UMaterialInstanceDynamic WeightmapMID
	{
		get
		{
			CheckDestroyed();
			if (!WeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:WeightmapMID");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, WeightmapMID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeightmapMID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:WeightmapMID");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, WeightmapMID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:NoiseOffset")]
	public float NoiseOffset
	{
		get
		{
			CheckDestroyed();
			if (!NoiseOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:NoiseOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NoiseOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NoiseOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.LandscapeBpBrushTest:NoiseOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NoiseOffset_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:Initialize")]
	protected override void Initialize_Implementation(FTransform InLandscapeTransform, FIntPoint InLandscapeSize, FIntPoint InLandscapeRenderTargetSize)
	{
		SpawnOrUpdateManager(InLandscapeSize, InLandscapeRenderTargetSize);
	}

	private void BrushSetup(UTextureRenderTarget2D InCombinedResult)
	{
		BrushManager.AllocateRTs();
		BrushManager.SetMPCParams();
		if (HeightmapMID.IsNullOrDestroyed())
		{
			HeightmapMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, ParentHeightmapMat, FName.None, EMIDCreationFlags.None);
		}
		if (WeightmapMID.IsNullOrDestroyed())
		{
			WeightmapMID = UMaterialLibrary.CreateDynamicMaterialInstance(this, ParentWeightmapMat, FName.None, EMIDCreationFlags.None);
		}
		HeightmapMID.SetTextureParameterValue(B1GlobalFNames.HeightRT, InCombinedResult);
		WeightmapMID.SetTextureParameterValue(B1GlobalFNames.HeightRT, InCombinedResult);
		WeightmapMID.SetScalarParameterValue(B1GlobalFNames.NoiseOffset, NoiseOffset);
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

	[USharpPath("/Script/b1-Managed.LandscapeBpBrushTest:Render")]
	protected override UTextureRenderTarget2D Render_Implementation(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, FName InWeightmapLayerName)
	{
		if (ParentHeightmapMat.IsNullOrDestroyed() || ParentWeightmapMat.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("HeightmapMat/WeightmapMapt is invalid");
			return null;
		}
		bHeightmapRender = InIsHeightmap;
		BrushSetup(InCombinedResult);
		DrawBrushMaterial();
		if (!bHeightmapRender)
		{
			return BrushManager.WeightmapRT;
		}
		return BrushManager.HeightmapRT;
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

	[UFunctionInvoker("/Script/b1-Managed.LandscapeBpBrushTest:Render")]
	private static void Render__Invoker(IntPtr buffer, IntPtr obj)
	{
		LandscapeBpBrushTest landscapeBpBrushTest = GCHelper.Find<LandscapeBpBrushTest>(obj);
		bool inIsHeightmap = BoolMarshaler.FromNative(IntPtr.Add(buffer, Render_InIsHeightmap_Offset), 0, Render_InIsHeightmap_PropertyAddress.Address);
		UTextureRenderTarget2D inCombinedResult = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(buffer, Render_InCombinedResult_Offset));
		FName inWeightmapLayerName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, Render_InWeightmapLayerName_Offset));
		UTextureRenderTarget2D value = landscapeBpBrushTest.Render_Implementation(inIsHeightmap, inCombinedResult, inWeightmapLayerName);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(buffer, Render_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.LandscapeBpBrushTest:Initialize")]
	private static void Initialize__Invoker(IntPtr buffer, IntPtr obj)
	{
		LandscapeBpBrushTest landscapeBpBrushTest = GCHelper.Find<LandscapeBpBrushTest>(obj);
		FTransform inLandscapeTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeTransform_Offset));
		FIntPoint inLandscapeSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeSize_Offset));
		FIntPoint inLandscapeRenderTargetSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(buffer, Initialize_InLandscapeRenderTargetSize_Offset));
		landscapeBpBrushTest.Initialize_Implementation(inLandscapeTransform, inLandscapeSize, inLandscapeRenderTargetSize);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.LandscapeBpBrushTest");
		BrushManager_Offset = NativeReflection.GetPropertyOffset(intPtr, "BrushManager");
		BrushManager_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BrushManager", Classes.FObjectProperty);
		ParentHeightmapMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParentHeightmapMat");
		ParentHeightmapMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParentHeightmapMat", Classes.FObjectProperty);
		HeightmapMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeightmapMID");
		HeightmapMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeightmapMID", Classes.FObjectProperty);
		Path_Offset = NativeReflection.GetPropertyOffset(intPtr, "Path");
		Path_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Path", Classes.FStrProperty);
		ParentWeightmapMat_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParentWeightmapMat");
		ParentWeightmapMat_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParentWeightmapMat", Classes.FObjectProperty);
		WeightmapMID_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeightmapMID");
		WeightmapMID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeightmapMID", Classes.FObjectProperty);
		NoiseOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "NoiseOffset");
		NoiseOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NoiseOffset", Classes.FFloatProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeBpBrushTest:Render", Render_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.LandscapeBpBrushTest:Initialize", Initialize_IsValid);
	}

	static LandscapeBpBrushTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(LandscapeBpBrushTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(LandscapeBpBrushTest));
	}
}
