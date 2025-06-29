using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SceneCaptureComponent2D", "Engine", UnrealModuleType.Engine)]
public class USceneCaptureComponent2D : USceneCaptureComponent
{
	private static bool ProjectionType_IsValid;

	private static FFieldAddress ProjectionType_PropertyAddress;

	private static int ProjectionType_Offset;

	private static bool FOVAngle_IsValid;

	private static int FOVAngle_Offset;

	private static bool OrthoWidth_IsValid;

	private static int OrthoWidth_Offset;

	private static bool TextureTarget_IsValid;

	private static int TextureTarget_Offset;

	private static bool CompositeMode_IsValid;

	private static FFieldAddress CompositeMode_PropertyAddress;

	private static int CompositeMode_Offset;

	private static bool PostProcessSettings_IsValid;

	private static int PostProcessSettings_Offset;

	private static bool PostProcessBlendWeight_IsValid;

	private static int PostProcessBlendWeight_Offset;

	private static bool CustomNearClippingPlane_IsValid;

	private static int CustomNearClippingPlane_Offset;

	private static bool UseCustomProjectionMatrix_IsValid;

	private static FFieldAddress UseCustomProjectionMatrix_PropertyAddress;

	private static int UseCustomProjectionMatrix_Offset;

	private static bool CustomProjectionMatrix_IsValid;

	private static int CustomProjectionMatrix_Offset;

	private static bool UseFauxOrthoViewPos_IsValid;

	private static FFieldAddress UseFauxOrthoViewPos_PropertyAddress;

	private static int UseFauxOrthoViewPos_Offset;

	private static bool EnableOrthographicTiling_IsValid;

	private static FFieldAddress EnableOrthographicTiling_PropertyAddress;

	private static int EnableOrthographicTiling_Offset;

	private static bool NumXTiles_IsValid;

	private static int NumXTiles_Offset;

	private static bool NumYTiles_IsValid;

	private static int NumYTiles_Offset;

	private static bool EnableClipPlane_IsValid;

	private static FFieldAddress EnableClipPlane_PropertyAddress;

	private static int EnableClipPlane_Offset;

	private static bool ClipPlaneBase_IsValid;

	private static int ClipPlaneBase_Offset;

	private static bool ClipPlaneNormal_IsValid;

	private static int ClipPlaneNormal_Offset;

	private static bool CameraCutThisFrame_IsValid;

	private static FFieldAddress CameraCutThisFrame_PropertyAddress;

	private static int CameraCutThisFrame_Offset;

	private static bool ConsiderUnrenderedOpaquePixelAsFullyTranslucent_IsValid;

	private static FFieldAddress ConsiderUnrenderedOpaquePixelAsFullyTranslucent_PropertyAddress;

	private static int ConsiderUnrenderedOpaquePixelAsFullyTranslucent_Offset;

	private static bool DisableFlipCopyGLES_IsValid;

	private static FFieldAddress DisableFlipCopyGLES_PropertyAddress;

	private static int DisableFlipCopyGLES_Offset;

	private static bool RemoveBlendable_IsValid;

	private static IntPtr RemoveBlendable_FunctionAddress;

	private static int RemoveBlendable_ParamsSize;

	private static bool RemoveBlendable_InBlendableObject_IsValid;

	private static FFieldAddress RemoveBlendable_InBlendableObject_PropertyAddress;

	private static int RemoveBlendable_InBlendableObject_Offset;

	private static bool CaptureScene_IsValid;

	private static IntPtr CaptureScene_FunctionAddress;

	private static int CaptureScene_ParamsSize;

	private static bool AddOrUpdateBlendable_IsValid;

	private static IntPtr AddOrUpdateBlendable_FunctionAddress;

	private static int AddOrUpdateBlendable_ParamsSize;

	private static bool AddOrUpdateBlendable_InBlendableObject_IsValid;

	private static FFieldAddress AddOrUpdateBlendable_InBlendableObject_PropertyAddress;

	private static int AddOrUpdateBlendable_InBlendableObject_Offset;

	private static bool AddOrUpdateBlendable_InWeight_IsValid;

	private static FFieldAddress AddOrUpdateBlendable_InWeight_PropertyAddress;

	private static int AddOrUpdateBlendable_InWeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:ProjectionType")]
	public ECameraProjectionMode ProjectionType
	{
		get
		{
			CheckDestroyed();
			if (!ProjectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:ProjectionType");
				return ECameraProjectionMode.Perspective;
			}
			return EnumMarshaler<ECameraProjectionMode>.FromNative(IntPtr.Add(base.Address, ProjectionType_Offset), 0, ProjectionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProjectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:ProjectionType");
			}
			else
			{
				EnumMarshaler<ECameraProjectionMode>.ToNative(IntPtr.Add(base.Address, ProjectionType_Offset), 0, ProjectionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:FOVAngle")]
	public float FOVAngle
	{
		get
		{
			CheckDestroyed();
			if (!FOVAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:FOVAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FOVAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FOVAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:FOVAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FOVAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:OrthoWidth")]
	public float OrthoWidth
	{
		get
		{
			CheckDestroyed();
			if (!OrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:OrthoWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OrthoWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:OrthoWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OrthoWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:TextureTarget")]
	public UTextureRenderTarget2D TextureTarget
	{
		get
		{
			CheckDestroyed();
			if (!TextureTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:TextureTarget");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, TextureTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:TextureTarget");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, TextureTarget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:CompositeMode")]
	public ESceneCaptureCompositeMode CompositeMode
	{
		get
		{
			CheckDestroyed();
			if (!CompositeMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:CompositeMode");
				return ESceneCaptureCompositeMode.SCCM_Overwrite;
			}
			return EnumMarshaler<ESceneCaptureCompositeMode>.FromNative(IntPtr.Add(base.Address, CompositeMode_Offset), 0, CompositeMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CompositeMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:CompositeMode");
			}
			else
			{
				EnumMarshaler<ESceneCaptureCompositeMode>.ToNative(IntPtr.Add(base.Address, CompositeMode_Offset), 0, CompositeMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503608217305093uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:PostProcessSettings")]
	public FPostProcessSettings PostProcessSettings
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:PostProcessSettings");
				return default(FPostProcessSettings);
			}
			return FPostProcessSettings.FromNative(IntPtr.Add(base.Address, PostProcessSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:PostProcessSettings");
			}
			else
			{
				FPostProcessSettings.ToNative(IntPtr.Add(base.Address, PostProcessSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:PostProcessBlendWeight")]
	public float PostProcessBlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:PostProcessBlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PostProcessBlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:PostProcessBlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PostProcessBlendWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:CustomNearClippingPlane")]
	public float CustomNearClippingPlane
	{
		get
		{
			CheckDestroyed();
			if (!CustomNearClippingPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:CustomNearClippingPlane");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CustomNearClippingPlane_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomNearClippingPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:CustomNearClippingPlane");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CustomNearClippingPlane_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785924uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:bUseCustomProjectionMatrix")]
	public bool UseCustomProjectionMatrix
	{
		get
		{
			CheckDestroyed();
			if (!UseCustomProjectionMatrix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bUseCustomProjectionMatrix");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCustomProjectionMatrix_Offset), 0, UseCustomProjectionMatrix_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCustomProjectionMatrix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bUseCustomProjectionMatrix");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCustomProjectionMatrix_Offset), 0, UseCustomProjectionMatrix_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508067467100676uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:CustomProjectionMatrix")]
	public FMatrix CustomProjectionMatrix
	{
		get
		{
			CheckDestroyed();
			if (!CustomProjectionMatrix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:CustomProjectionMatrix");
				return default(FMatrix);
			}
			return BlittableTypeMarshaler<FMatrix>.FromNative(IntPtr.Add(base.Address, CustomProjectionMatrix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomProjectionMatrix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:CustomProjectionMatrix");
			}
			else
			{
				BlittableTypeMarshaler<FMatrix>.ToNative(IntPtr.Add(base.Address, CustomProjectionMatrix_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:bUseFauxOrthoViewPos")]
	public bool UseFauxOrthoViewPos
	{
		get
		{
			CheckDestroyed();
			if (!UseFauxOrthoViewPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bUseFauxOrthoViewPos");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseFauxOrthoViewPos_Offset), 0, UseFauxOrthoViewPos_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseFauxOrthoViewPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bUseFauxOrthoViewPos");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseFauxOrthoViewPos_Offset), 0, UseFauxOrthoViewPos_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:bEnableOrthographicTiling")]
	public bool EnableOrthographicTiling
	{
		get
		{
			CheckDestroyed();
			if (!EnableOrthographicTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bEnableOrthographicTiling");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableOrthographicTiling_Offset), 0, EnableOrthographicTiling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableOrthographicTiling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bEnableOrthographicTiling");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableOrthographicTiling_Offset), 0, EnableOrthographicTiling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:NumXTiles")]
	public int NumXTiles
	{
		get
		{
			CheckDestroyed();
			if (!NumXTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:NumXTiles");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumXTiles_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumXTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:NumXTiles");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumXTiles_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:NumYTiles")]
	public int NumYTiles
	{
		get
		{
			CheckDestroyed();
			if (!NumYTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:NumYTiles");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumYTiles_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumYTiles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:NumYTiles");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumYTiles_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:bEnableClipPlane")]
	public bool EnableClipPlane
	{
		get
		{
			CheckDestroyed();
			if (!EnableClipPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bEnableClipPlane");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableClipPlane_Offset), 0, EnableClipPlane_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableClipPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bEnableClipPlane");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableClipPlane_Offset), 0, EnableClipPlane_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:ClipPlaneBase")]
	public FVector ClipPlaneBase
	{
		get
		{
			CheckDestroyed();
			if (!ClipPlaneBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:ClipPlaneBase");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ClipPlaneBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClipPlaneBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:ClipPlaneBase");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ClipPlaneBase_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:ClipPlaneNormal")]
	public FVector ClipPlaneNormal
	{
		get
		{
			CheckDestroyed();
			if (!ClipPlaneNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:ClipPlaneNormal");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ClipPlaneNormal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ClipPlaneNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:ClipPlaneNormal");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ClipPlaneNormal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160540676uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:bCameraCutThisFrame")]
	public bool CameraCutThisFrame
	{
		get
		{
			CheckDestroyed();
			if (!CameraCutThisFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bCameraCutThisFrame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CameraCutThisFrame_Offset), 0, CameraCutThisFrame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraCutThisFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bCameraCutThisFrame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CameraCutThisFrame_Offset), 0, CameraCutThisFrame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:bConsiderUnrenderedOpaquePixelAsFullyTranslucent")]
	public bool ConsiderUnrenderedOpaquePixelAsFullyTranslucent
	{
		get
		{
			CheckDestroyed();
			if (!ConsiderUnrenderedOpaquePixelAsFullyTranslucent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bConsiderUnrenderedOpaquePixelAsFullyTranslucent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConsiderUnrenderedOpaquePixelAsFullyTranslucent_Offset), 0, ConsiderUnrenderedOpaquePixelAsFullyTranslucent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConsiderUnrenderedOpaquePixelAsFullyTranslucent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bConsiderUnrenderedOpaquePixelAsFullyTranslucent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConsiderUnrenderedOpaquePixelAsFullyTranslucent_Offset), 0, ConsiderUnrenderedOpaquePixelAsFullyTranslucent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:bDisableFlipCopyGLES")]
	public bool DisableFlipCopyGLES
	{
		get
		{
			CheckDestroyed();
			if (!DisableFlipCopyGLES_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bDisableFlipCopyGLES");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableFlipCopyGLES_Offset), 0, DisableFlipCopyGLES_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableFlipCopyGLES_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponent2D:bDisableFlipCopyGLES");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableFlipCopyGLES_Offset), 0, DisableFlipCopyGLES_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:RemoveBlendable")]
	public unsafe void RemoveBlendable(IBlendableInterface InBlendableObject)
	{
		CheckDestroyed();
		if (!RemoveBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent2D:RemoveBlendable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBlendable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBlendable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IBlendableInterface>.ToNative(IntPtr.Add(intPtr, RemoveBlendable_InBlendableObject_Offset), 0, RemoveBlendable_InBlendableObject_PropertyAddress.Address, InBlendableObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBlendable_FunctionAddress, intPtr, RemoveBlendable_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:CaptureScene")]
	public unsafe void CaptureScene()
	{
		CheckDestroyed();
		if (!CaptureScene_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent2D:CaptureScene");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureScene_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureScene_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CaptureScene_FunctionAddress, argsSize: CaptureScene_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponent2D:AddOrUpdateBlendable")]
	public unsafe void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
	{
		CheckDestroyed();
		if (!AddOrUpdateBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponent2D:AddOrUpdateBlendable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOrUpdateBlendable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOrUpdateBlendable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IBlendableInterface>.ToNative(IntPtr.Add(intPtr, AddOrUpdateBlendable_InBlendableObject_Offset), 0, AddOrUpdateBlendable_InBlendableObject_PropertyAddress.Address, InBlendableObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddOrUpdateBlendable_InWeight_Offset), 0, AddOrUpdateBlendable_InWeight_PropertyAddress.Address, InWeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddOrUpdateBlendable_FunctionAddress, intPtr, AddOrUpdateBlendable_ParamsSize);
	}

	static USceneCaptureComponent2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USceneCaptureComponent2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USceneCaptureComponent2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SceneCaptureComponent2D");
		NativeReflectionCached.GetPropertyRef(ref ProjectionType_PropertyAddress, intPtr, "ProjectionType");
		ProjectionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectionType");
		ProjectionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectionType", Classes.FByteProperty);
		FOVAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FOVAngle");
		FOVAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FOVAngle", Classes.FFloatProperty);
		OrthoWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrthoWidth");
		OrthoWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrthoWidth", Classes.FFloatProperty);
		TextureTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureTarget");
		TextureTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CompositeMode_PropertyAddress, intPtr, "CompositeMode");
		CompositeMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompositeMode");
		CompositeMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompositeMode", Classes.FByteProperty);
		PostProcessSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessSettings");
		PostProcessSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessSettings", Classes.FStructProperty);
		PostProcessBlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessBlendWeight");
		PostProcessBlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessBlendWeight", Classes.FFloatProperty);
		CustomNearClippingPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomNearClippingPlane");
		CustomNearClippingPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomNearClippingPlane", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCustomProjectionMatrix_PropertyAddress, intPtr, "bUseCustomProjectionMatrix");
		UseCustomProjectionMatrix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCustomProjectionMatrix");
		UseCustomProjectionMatrix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCustomProjectionMatrix", Classes.FBoolProperty);
		CustomProjectionMatrix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomProjectionMatrix");
		CustomProjectionMatrix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomProjectionMatrix", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFauxOrthoViewPos_PropertyAddress, intPtr, "bUseFauxOrthoViewPos");
		UseFauxOrthoViewPos_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseFauxOrthoViewPos");
		UseFauxOrthoViewPos_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseFauxOrthoViewPos", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableOrthographicTiling_PropertyAddress, intPtr, "bEnableOrthographicTiling");
		EnableOrthographicTiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableOrthographicTiling");
		EnableOrthographicTiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableOrthographicTiling", Classes.FBoolProperty);
		NumXTiles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumXTiles");
		NumXTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumXTiles", Classes.FIntProperty);
		NumYTiles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumYTiles");
		NumYTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumYTiles", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableClipPlane_PropertyAddress, intPtr, "bEnableClipPlane");
		EnableClipPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableClipPlane");
		EnableClipPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableClipPlane", Classes.FBoolProperty);
		ClipPlaneBase_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClipPlaneBase");
		ClipPlaneBase_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClipPlaneBase", Classes.FStructProperty);
		ClipPlaneNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClipPlaneNormal");
		ClipPlaneNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClipPlaneNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CameraCutThisFrame_PropertyAddress, intPtr, "bCameraCutThisFrame");
		CameraCutThisFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCameraCutThisFrame");
		CameraCutThisFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCameraCutThisFrame", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ConsiderUnrenderedOpaquePixelAsFullyTranslucent_PropertyAddress, intPtr, "bConsiderUnrenderedOpaquePixelAsFullyTranslucent");
		ConsiderUnrenderedOpaquePixelAsFullyTranslucent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bConsiderUnrenderedOpaquePixelAsFullyTranslucent");
		ConsiderUnrenderedOpaquePixelAsFullyTranslucent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bConsiderUnrenderedOpaquePixelAsFullyTranslucent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableFlipCopyGLES_PropertyAddress, intPtr, "bDisableFlipCopyGLES");
		DisableFlipCopyGLES_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableFlipCopyGLES");
		DisableFlipCopyGLES_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableFlipCopyGLES", Classes.FBoolProperty);
		RemoveBlendable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveBlendable");
		RemoveBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBlendable_InBlendableObject_PropertyAddress, RemoveBlendable_FunctionAddress, "InBlendableObject");
		RemoveBlendable_InBlendableObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBlendable_FunctionAddress, "InBlendableObject");
		RemoveBlendable_InBlendableObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBlendable_FunctionAddress, "InBlendableObject", Classes.FInterfaceProperty);
		RemoveBlendable_IsValid = RemoveBlendable_FunctionAddress != IntPtr.Zero && RemoveBlendable_InBlendableObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent2D:RemoveBlendable", RemoveBlendable_IsValid);
		CaptureScene_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CaptureScene");
		CaptureScene_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureScene_FunctionAddress);
		CaptureScene_IsValid = CaptureScene_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent2D:CaptureScene", CaptureScene_IsValid);
		AddOrUpdateBlendable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOrUpdateBlendable");
		AddOrUpdateBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOrUpdateBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InBlendableObject_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InWeight_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InWeight", Classes.FFloatProperty);
		AddOrUpdateBlendable_IsValid = AddOrUpdateBlendable_FunctionAddress != IntPtr.Zero && AddOrUpdateBlendable_InBlendableObject_IsValid && AddOrUpdateBlendable_InWeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponent2D:AddOrUpdateBlendable", AddOrUpdateBlendable_IsValid);
	}
}
