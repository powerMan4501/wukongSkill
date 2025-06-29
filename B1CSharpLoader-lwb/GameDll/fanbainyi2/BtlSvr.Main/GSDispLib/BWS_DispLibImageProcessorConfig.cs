using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessorConfig")]
public class BWS_DispLibImageProcessorConfig : UBGWDataAsset
{
	private static bool KawaseMaterialPrototype_IsValid;

	private static int KawaseMaterialPrototype_Offset;

	private static bool RenderTarget0_IsValid;

	private static int RenderTarget0_Offset;

	private static bool RenderTarget1_IsValid;

	private static int RenderTarget1_Offset;

	private static bool BlitMaterialPrototype_IsValid;

	private static int BlitMaterialPrototype_Offset;

	private static bool CombineRGBMaterialPrototype_IsValid;

	private static int CombineRGBMaterialPrototype_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:KawaseMaterialPrototype")]
	public UMaterialInstance KawaseMaterialPrototype
	{
		get
		{
			CheckDestroyed();
			if (!KawaseMaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:KawaseMaterialPrototype");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, KawaseMaterialPrototype_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KawaseMaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:KawaseMaterialPrototype");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, KawaseMaterialPrototype_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:RenderTarget0")]
	public UTextureRenderTarget2D RenderTarget0
	{
		get
		{
			CheckDestroyed();
			if (!RenderTarget0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:RenderTarget0");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RenderTarget0_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderTarget0_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:RenderTarget0");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RenderTarget0_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:RenderTarget1")]
	public UTextureRenderTarget2D RenderTarget1
	{
		get
		{
			CheckDestroyed();
			if (!RenderTarget1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:RenderTarget1");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RenderTarget1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderTarget1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:RenderTarget1");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RenderTarget1_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:BlitMaterialPrototype")]
	public UMaterialInstance BlitMaterialPrototype
	{
		get
		{
			CheckDestroyed();
			if (!BlitMaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:BlitMaterialPrototype");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, BlitMaterialPrototype_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlitMaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:BlitMaterialPrototype");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, BlitMaterialPrototype_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:CombineRGBMaterialPrototype")]
	public UMaterialInstance CombineRGBMaterialPrototype
	{
		get
		{
			CheckDestroyed();
			if (!CombineRGBMaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:CombineRGBMaterialPrototype");
				return null;
			}
			return UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(base.Address, CombineRGBMaterialPrototype_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CombineRGBMaterialPrototype_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BWS_DispLibImageProcessorConfig:CombineRGBMaterialPrototype");
			}
			else
			{
				UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(base.Address, CombineRGBMaterialPrototype_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BWS_DispLibImageProcessorConfig");
		KawaseMaterialPrototype_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "KawaseMaterialPrototype");
		KawaseMaterialPrototype_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "KawaseMaterialPrototype", Classes.FObjectProperty);
		RenderTarget0_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RenderTarget0");
		RenderTarget0_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RenderTarget0", Classes.FObjectProperty);
		RenderTarget1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RenderTarget1");
		RenderTarget1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RenderTarget1", Classes.FObjectProperty);
		BlitMaterialPrototype_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlitMaterialPrototype");
		BlitMaterialPrototype_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlitMaterialPrototype", Classes.FObjectProperty);
		CombineRGBMaterialPrototype_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CombineRGBMaterialPrototype");
		CombineRGBMaterialPrototype_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CombineRGBMaterialPrototype", Classes.FObjectProperty);
	}

	static BWS_DispLibImageProcessorConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BWS_DispLibImageProcessorConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BWS_DispLibImageProcessorConfig));
	}
}
