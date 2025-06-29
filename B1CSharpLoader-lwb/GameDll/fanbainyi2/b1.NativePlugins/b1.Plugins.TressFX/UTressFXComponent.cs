using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/TressFX.TressFXComponent", "TressFX", UnrealModuleType.GamePlugin)]
public class UTressFXComponent : UPrimitiveComponent
{
	private static bool EnableSimulation_IsValid;

	private static FFieldAddress EnableSimulation_PropertyAddress;

	private static int EnableSimulation_Offset;

	private static bool HairPhysicsAsset_IsValid;

	private static int HairPhysicsAsset_Offset;

	private static bool Asset_IsValid;

	private static int Asset_Offset;

	private static bool HairMaterial_IsValid;

	private static int HairMaterial_Offset;

	private static bool HairMaterialLowQuality_IsValid;

	private static int HairMaterialLowQuality_Offset;

	private static bool ShadeSettings_IsValid;

	private static int ShadeSettings_Offset;

	private static bool LodScreenSize_IsValid;

	private static int LodScreenSize_Offset;

	private static bool MorphTargetBindingAsset_IsValid;

	private static int MorphTargetBindingAsset_Offset;

	private static bool GenerateCardMesh_IsValid;

	private static FFieldAddress GenerateCardMesh_PropertyAddress;

	private static int GenerateCardMesh_Offset;

	private static bool CardMeshComponentReference_IsValid;

	private static int CardMeshComponentReference_Offset;

	private static bool ResetPositions_IsValid;

	private static IntPtr ResetPositions_FunctionAddress;

	private static int ResetPositions_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:EnableSimulation")]
	public bool EnableSimulation
	{
		get
		{
			CheckDestroyed();
			if (!EnableSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:EnableSimulation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSimulation_Offset), 0, EnableSimulation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:EnableSimulation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSimulation_Offset), 0, EnableSimulation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628565uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:HairPhysicsAsset")]
	public UPhysicsAsset HairPhysicsAsset
	{
		get
		{
			CheckDestroyed();
			if (!HairPhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:HairPhysicsAsset");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, HairPhysicsAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HairPhysicsAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:HairPhysicsAsset");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, HairPhysicsAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:Asset")]
	public UTressFXAsset Asset
	{
		get
		{
			CheckDestroyed();
			if (!Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:Asset");
				return null;
			}
			return UObjectMarshaler<UTressFXAsset>.FromNative(IntPtr.Add(base.Address, Asset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Asset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:Asset");
			}
			else
			{
				UObjectMarshaler<UTressFXAsset>.ToNative(IntPtr.Add(base.Address, Asset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:HairMaterial")]
	public UMaterialInterface HairMaterial
	{
		get
		{
			CheckDestroyed();
			if (!HairMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:HairMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, HairMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HairMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:HairMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, HairMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:HairMaterialLowQuality")]
	public UMaterialInterface HairMaterialLowQuality
	{
		get
		{
			CheckDestroyed();
			if (!HairMaterialLowQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:HairMaterialLowQuality");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, HairMaterialLowQuality_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HairMaterialLowQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:HairMaterialLowQuality");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, HairMaterialLowQuality_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:ShadeSettings")]
	public FTressFXShadeSettings ShadeSettings
	{
		get
		{
			CheckDestroyed();
			if (!ShadeSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:ShadeSettings");
				return default(FTressFXShadeSettings);
			}
			return FTressFXShadeSettings.FromNative(IntPtr.Add(base.Address, ShadeSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadeSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:ShadeSettings");
			}
			else
			{
				FTressFXShadeSettings.ToNative(IntPtr.Add(base.Address, ShadeSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:LodScreenSize")]
	public float LodScreenSize
	{
		get
		{
			CheckDestroyed();
			if (!LodScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:LodScreenSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LodScreenSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LodScreenSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:LodScreenSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LodScreenSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:MorphTargetBindingAsset")]
	public UTressFXBindingAsset MorphTargetBindingAsset
	{
		get
		{
			CheckDestroyed();
			if (!MorphTargetBindingAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:MorphTargetBindingAsset");
				return null;
			}
			return UObjectMarshaler<UTressFXBindingAsset>.FromNative(IntPtr.Add(base.Address, MorphTargetBindingAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MorphTargetBindingAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:MorphTargetBindingAsset");
			}
			else
			{
				UObjectMarshaler<UTressFXBindingAsset>.ToNative(IntPtr.Add(base.Address, MorphTargetBindingAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:bGenerateCardMesh")]
	public bool GenerateCardMesh
	{
		get
		{
			CheckDestroyed();
			if (!GenerateCardMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:bGenerateCardMesh");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GenerateCardMesh_Offset), 0, GenerateCardMesh_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenerateCardMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:bGenerateCardMesh");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GenerateCardMesh_Offset), 0, GenerateCardMesh_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/TressFX.TressFXComponent:CardMeshComponentReference")]
	public FComponentReference CardMeshComponentReference
	{
		get
		{
			CheckDestroyed();
			if (!CardMeshComponentReference_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:CardMeshComponentReference");
				return default(FComponentReference);
			}
			return FComponentReference.FromNative(IntPtr.Add(base.Address, CardMeshComponentReference_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CardMeshComponentReference_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/TressFX.TressFXComponent:CardMeshComponentReference");
			}
			else
			{
				FComponentReference.ToNative(IntPtr.Add(base.Address, CardMeshComponentReference_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/TressFX.TressFXComponent:ResetPositions")]
	public unsafe void ResetPositions()
	{
		CheckDestroyed();
		if (!ResetPositions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/TressFX.TressFXComponent:ResetPositions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetPositions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetPositions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetPositions_FunctionAddress, argsSize: ResetPositions_ParamsSize);
	}

	static UTressFXComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTressFXComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTressFXComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/TressFX.TressFXComponent");
		NativeReflectionCached.GetPropertyRef(ref EnableSimulation_PropertyAddress, intPtr, "EnableSimulation");
		EnableSimulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnableSimulation");
		EnableSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnableSimulation", Classes.FBoolProperty);
		HairPhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairPhysicsAsset");
		HairPhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairPhysicsAsset", Classes.FObjectProperty);
		Asset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Asset");
		Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Asset", Classes.FObjectProperty);
		HairMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairMaterial");
		HairMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairMaterial", Classes.FObjectProperty);
		HairMaterialLowQuality_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairMaterialLowQuality");
		HairMaterialLowQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairMaterialLowQuality", Classes.FObjectProperty);
		ShadeSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadeSettings");
		ShadeSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadeSettings", Classes.FStructProperty);
		LodScreenSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LodScreenSize");
		LodScreenSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LodScreenSize", Classes.FFloatProperty);
		MorphTargetBindingAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MorphTargetBindingAsset");
		MorphTargetBindingAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MorphTargetBindingAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateCardMesh_PropertyAddress, intPtr, "bGenerateCardMesh");
		GenerateCardMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateCardMesh");
		GenerateCardMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateCardMesh", Classes.FBoolProperty);
		CardMeshComponentReference_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CardMeshComponentReference");
		CardMeshComponentReference_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CardMeshComponentReference", Classes.FStructProperty);
		ResetPositions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetPositions");
		ResetPositions_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPositions_FunctionAddress);
		ResetPositions_IsValid = ResetPositions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/TressFX.TressFXComponent:ResetPositions", ResetPositions_IsValid);
	}
}
