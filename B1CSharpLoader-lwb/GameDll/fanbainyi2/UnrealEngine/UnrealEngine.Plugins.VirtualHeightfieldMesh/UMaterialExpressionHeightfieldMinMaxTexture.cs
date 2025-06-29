using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VirtualHeightfieldMesh;

[UClass(Flags = (ClassFlags)810033312uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture", "VirtualHeightfieldMesh", UnrealModuleType.EnginePlugin)]
public class UMaterialExpressionHeightfieldMinMaxTexture : UMaterialExpression
{
	private static bool MinMaxTexture_IsValid;

	private static int MinMaxTexture_Offset;

	private static bool SamplerType_IsValid;

	private static FFieldAddress SamplerType_PropertyAddress;

	private static int SamplerType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture:MinMaxTexture")]
	public UHeightfieldMinMaxTexture MinMaxTexture
	{
		get
		{
			CheckDestroyed();
			if (!MinMaxTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture:MinMaxTexture");
				return null;
			}
			return UObjectMarshaler<UHeightfieldMinMaxTexture>.FromNative(IntPtr.Add(base.Address, MinMaxTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinMaxTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture:MinMaxTexture");
			}
			else
			{
				UObjectMarshaler<UHeightfieldMinMaxTexture>.ToNative(IntPtr.Add(base.Address, MinMaxTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture:SamplerType")]
	public EMaterialSamplerType SamplerType
	{
		get
		{
			CheckDestroyed();
			if (!SamplerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture:SamplerType");
				return EMaterialSamplerType.SAMPLERTYPE_Color;
			}
			return EnumMarshaler<EMaterialSamplerType>.FromNative(IntPtr.Add(base.Address, SamplerType_Offset), 0, SamplerType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SamplerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture:SamplerType");
			}
			else
			{
				EnumMarshaler<EMaterialSamplerType>.ToNative(IntPtr.Add(base.Address, SamplerType_Offset), 0, SamplerType_PropertyAddress.Address, value);
			}
		}
	}

	static UMaterialExpressionHeightfieldMinMaxTexture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionHeightfieldMinMaxTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionHeightfieldMinMaxTexture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/VirtualHeightfieldMesh.MaterialExpressionHeightfieldMinMaxTexture");
		MinMaxTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinMaxTexture");
		MinMaxTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinMaxTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SamplerType_PropertyAddress, unrealStruct, "SamplerType");
		SamplerType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SamplerType");
		SamplerType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SamplerType", Classes.FByteProperty);
	}
}
