using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionTextureBase", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionTextureBase : UMaterialExpression
{
	private static bool Texture_IsValid;

	private static int Texture_Offset;

	private static bool SamplerType_IsValid;

	private static FFieldAddress SamplerType_PropertyAddress;

	private static int SamplerType_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionTextureBase:Texture")]
	public UTexture Texture
	{
		get
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureBase:Texture");
				return null;
			}
			return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(base.Address, Texture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureBase:Texture");
			}
			else
			{
				UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(base.Address, Texture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionTextureBase:SamplerType")]
	public EMaterialSamplerType SamplerType
	{
		get
		{
			CheckDestroyed();
			if (!SamplerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureBase:SamplerType");
				return EMaterialSamplerType.SAMPLERTYPE_Color;
			}
			return EnumMarshaler<EMaterialSamplerType>.FromNative(IntPtr.Add(base.Address, SamplerType_Offset), 0, SamplerType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SamplerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionTextureBase:SamplerType");
			}
			else
			{
				EnumMarshaler<EMaterialSamplerType>.ToNative(IntPtr.Add(base.Address, SamplerType_Offset), 0, SamplerType_PropertyAddress.Address, value);
			}
		}
	}

	static UMaterialExpressionTextureBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionTextureBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionTextureBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionTextureBase");
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SamplerType_PropertyAddress, unrealStruct, "SamplerType");
		SamplerType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SamplerType");
		SamplerType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SamplerType", Classes.FByteProperty);
	}
}
