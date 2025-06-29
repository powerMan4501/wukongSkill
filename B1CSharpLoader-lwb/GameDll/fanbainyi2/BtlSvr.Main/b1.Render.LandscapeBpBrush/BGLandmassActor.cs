using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render.LandscapeBpBrush;

[UClass]
[USharpPath("/Script/b1-Managed.BGLandmassActor")]
public class BGLandmassActor : AActor
{
	private static bool WeightmapRT_IsValid;

	private static int WeightmapRT_Offset;

	private static bool HeightmapRT_IsValid;

	private static int HeightmapRT_Offset;

	private static bool LandscapeMPC_IsValid;

	private static int LandscapeMPC_Offset;

	private static bool LandscapeQuads_IsValid;

	private static int LandscapeQuads_Offset;

	private static bool LandscapeRTRes_IsValid;

	private static int LandscapeRTRes_Offset;

	private static bool LandscapeTransform_IsValid;

	private static int LandscapeTransform_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGLandmassActor:WeightmapRT")]
	public UTextureRenderTarget2D WeightmapRT
	{
		get
		{
			CheckDestroyed();
			if (!WeightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:WeightmapRT");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, WeightmapRT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:WeightmapRT");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, WeightmapRT_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGLandmassActor:HeightmapRT")]
	public UTextureRenderTarget2D HeightmapRT
	{
		get
		{
			CheckDestroyed();
			if (!HeightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:HeightmapRT");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, HeightmapRT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:HeightmapRT");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, HeightmapRT_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGLandmassActor:LandscapeMPC")]
	public UMaterialParameterCollection LandscapeMPC
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeMPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, LandscapeMPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeMPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeMPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, LandscapeMPC_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGLandmassActor:LandscapeQuads")]
	public FIntPoint LandscapeQuads
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeQuads_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeQuads");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, LandscapeQuads_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeQuads_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeQuads");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, LandscapeQuads_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGLandmassActor:LandscapeRTRes")]
	public FIntPoint LandscapeRTRes
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeRTRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeRTRes");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, LandscapeRTRes_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeRTRes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeRTRes");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, LandscapeRTRes_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGLandmassActor:LandscapeTransform")]
	public FTransform LandscapeTransform
	{
		get
		{
			CheckDestroyed();
			if (!LandscapeTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, LandscapeTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LandscapeTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGLandmassActor:LandscapeTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, LandscapeTransform_Offset), value);
			}
		}
	}

	public void CreateOrUpdateRT(ref UTextureRenderTarget2D RT, FIntPoint Size, ETextureRenderTargetFormat RtFormat)
	{
		if (!RT.IsNullOrDestroyed())
		{
			if (RT.SizeX != Size.X || RT.SizeY != Size.Y)
			{
				RT = URenderingLibrary.CreateRenderTarget2D(this, Size.X, Size.Y, RtFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
			}
		}
		else
		{
			RT = URenderingLibrary.CreateRenderTarget2D(this, Size.X, Size.Y, RtFormat, FLinearColor.Black, bAutoGenerateMipMaps: false);
		}
	}

	public void AllocateRTs()
	{
		UTextureRenderTarget2D RT = null;
		CreateOrUpdateRT(ref RT, LandscapeRTRes, ETextureRenderTargetFormat.RTF_RGBA8);
		HeightmapRT = RT;
		UTextureRenderTarget2D RT2 = null;
		CreateOrUpdateRT(ref RT2, LandscapeRTRes, ETextureRenderTargetFormat.RTF_R8);
		WeightmapRT = RT2;
	}

	public void SetMPCParams()
	{
		if (LandscapeMPC == null)
		{
			LandscapeMPC = UObject.LoadObject<UMaterialParameterCollection>(this, "/Landmass/Landscape/BlueprintBrushes/MPC/MPC_Landscape.MPC_Landscape");
		}
		if (LandscapeMPC == null)
		{
			BGW_LogUtil.LogError("BGLandmassActor.SetMPCParams load mpc failed.");
			return;
		}
		UMaterialLibrary.SetVectorParameterValue(this, LandscapeMPC, B1GlobalFNames.LandscapeLocation, new FLinearColor(LandscapeTransform.GetLocation()));
		UMaterialLibrary.SetScalarParameterValue(this, LandscapeMPC, B1GlobalFNames.RTResX, LandscapeRTRes.X);
		UMaterialLibrary.SetScalarParameterValue(this, LandscapeMPC, B1GlobalFNames.RTResY, LandscapeRTRes.Y);
		UMaterialLibrary.SetScalarParameterValue(this, LandscapeMPC, B1GlobalFNames.LSQuadsX, LandscapeQuads.X);
		UMaterialLibrary.SetScalarParameterValue(this, LandscapeMPC, B1GlobalFNames.LSQuadsY, LandscapeQuads.Y);
		FVector fVector = new FVector(LandscapeQuads.X, LandscapeQuads.Y, 0.5120000243186951);
		UMaterialLibrary.SetScalarParameterValue(this, LandscapeMPC, B1GlobalFNames.WorldSizeX, fVector.X);
		UMaterialLibrary.SetScalarParameterValue(this, LandscapeMPC, B1GlobalFNames.WorldSizeY, fVector.Y);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGLandmassActor");
		WeightmapRT_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeightmapRT");
		WeightmapRT_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeightmapRT", Classes.FObjectProperty);
		HeightmapRT_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeightmapRT");
		HeightmapRT_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeightmapRT", Classes.FObjectProperty);
		LandscapeMPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LandscapeMPC");
		LandscapeMPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LandscapeMPC", Classes.FObjectProperty);
		LandscapeQuads_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LandscapeQuads");
		LandscapeQuads_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LandscapeQuads", Classes.FStructProperty);
		LandscapeRTRes_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LandscapeRTRes");
		LandscapeRTRes_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LandscapeRTRes", Classes.FStructProperty);
		LandscapeTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LandscapeTransform");
		LandscapeTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LandscapeTransform", Classes.FStructProperty);
	}

	static BGLandmassActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGLandmassActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGLandmassActor));
	}
}
