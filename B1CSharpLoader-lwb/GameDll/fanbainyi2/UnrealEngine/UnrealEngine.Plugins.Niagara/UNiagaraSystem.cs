using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Niagara.NiagaraSystem", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraSystem : UFXSystemAsset
{
	private static bool CastShadow_IsValid;

	private static FFieldAddress CastShadow_PropertyAddress;

	private static int CastShadow_Offset;

	private static bool ReceivesDecals_IsValid;

	private static FFieldAddress ReceivesDecals_PropertyAddress;

	private static int ReceivesDecals_Offset;

	private static bool RenderCustomDepth_IsValid;

	private static FFieldAddress RenderCustomDepth_PropertyAddress;

	private static int RenderCustomDepth_Offset;

	private static bool CustomDepthStencilWriteMask_IsValid;

	private static FFieldAddress CustomDepthStencilWriteMask_PropertyAddress;

	private static int CustomDepthStencilWriteMask_Offset;

	private static bool CustomDepthStencilValue_IsValid;

	private static int CustomDepthStencilValue_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Niagara.NiagaraSystem:bCastShadow")]
	public bool CastShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:bCastShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:bCastShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Niagara.NiagaraSystem:bReceivesDecals")]
	public bool ReceivesDecals
	{
		get
		{
			CheckDestroyed();
			if (!ReceivesDecals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:bReceivesDecals");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReceivesDecals_Offset), 0, ReceivesDecals_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReceivesDecals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:bReceivesDecals");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReceivesDecals_Offset), 0, ReceivesDecals_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Niagara.NiagaraSystem:bRenderCustomDepth")]
	public bool RenderCustomDepth
	{
		get
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:bRenderCustomDepth");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:bRenderCustomDepth");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Niagara.NiagaraSystem:CustomDepthStencilWriteMask")]
	public ERendererStencilMask CustomDepthStencilWriteMask
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:CustomDepthStencilWriteMask");
				return ERendererStencilMask.ERSM_Default;
			}
			return EnumMarshaler<ERendererStencilMask>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:CustomDepthStencilWriteMask");
			}
			else
			{
				EnumMarshaler<ERendererStencilMask>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Niagara.NiagaraSystem:CustomDepthStencilValue")]
	public int CustomDepthStencilValue
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:CustomDepthStencilValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraSystem:CustomDepthStencilValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset), value);
			}
		}
	}

	static UNiagaraSystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraSystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Niagara.NiagaraSystem");
		NativeReflectionCached.GetPropertyRef(ref CastShadow_PropertyAddress, unrealStruct, "bCastShadow");
		CastShadow_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCastShadow");
		CastShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCastShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivesDecals_PropertyAddress, unrealStruct, "bReceivesDecals");
		ReceivesDecals_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bReceivesDecals");
		ReceivesDecals_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bReceivesDecals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderCustomDepth_PropertyAddress, unrealStruct, "bRenderCustomDepth");
		RenderCustomDepth_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bRenderCustomDepth");
		RenderCustomDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bRenderCustomDepth", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomDepthStencilWriteMask_PropertyAddress, unrealStruct, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomDepthStencilWriteMask", Classes.FEnumProperty);
		CustomDepthStencilValue_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CustomDepthStencilValue");
		CustomDepthStencilValue_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CustomDepthStencilValue", Classes.FIntProperty);
	}
}
