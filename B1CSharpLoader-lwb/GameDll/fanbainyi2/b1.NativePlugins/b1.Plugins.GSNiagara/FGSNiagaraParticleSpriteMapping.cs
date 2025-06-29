using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSNiagara;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/GSNiagara.GSNiagaraParticleSpriteMapping", "GSNiagara", UnrealModuleType.GamePlugin)]
public struct FGSNiagaraParticleSpriteMapping
{
	private static bool SpriteIndex_IsValid;

	private static int SpriteIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraParticleSpriteMapping:SpriteIndex")]
	public int SpriteIndex;

	private static int FGSNiagaraParticleSpriteMapping_StructSize;

	public FGSNiagaraParticleSpriteMapping Copy()
	{
		return this;
	}

	static FGSNiagaraParticleSpriteMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSNiagaraParticleSpriteMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSNiagaraParticleSpriteMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/GSNiagara.GSNiagaraParticleSpriteMapping");
		FGSNiagaraParticleSpriteMapping_StructSize = NativeReflection.GetStructSize(unrealStruct);
		SpriteIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpriteIndex");
		SpriteIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpriteIndex", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSNiagaraParticleSpriteMapping));
	}
}
