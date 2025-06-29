using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818413729uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.TextureRenderTarget", "Engine", UnrealModuleType.Engine)]
public class UTextureRenderTarget : UTexture
{
	private static bool TargetGamma_IsValid;

	private static int TargetGamma_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureRenderTarget:TargetGamma")]
	public float TargetGamma
	{
		get
		{
			CheckDestroyed();
			if (!TargetGamma_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget:TargetGamma");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TargetGamma_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetGamma_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextureRenderTarget:TargetGamma");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TargetGamma_Offset), value);
			}
		}
	}

	static UTextureRenderTarget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextureRenderTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextureRenderTarget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.TextureRenderTarget");
		TargetGamma_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetGamma");
		TargetGamma_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetGamma", Classes.FFloatProperty);
	}
}
