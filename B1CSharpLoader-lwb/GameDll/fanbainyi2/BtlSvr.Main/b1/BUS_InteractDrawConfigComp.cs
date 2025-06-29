using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_InteractDrawConfigComp")]
public class BUS_InteractDrawConfigComp : UActorEditCompBase
{
	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool NPC_IsValid;

	private static int NPC_Offset;

	private static bool M_CombineTexture_IsValid;

	private static int M_CombineTexture_Offset;

	private static bool RT_LandscapeMap_IsValid;

	private static int RT_LandscapeMap_Offset;

	private static bool RT_DataStorage_IsValid;

	private static int RT_DataStorage_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_InteractDrawConfigComp:MPC")]
	public UMaterialParameterCollection MPC
	{
		get
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:MPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:MPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_InteractDrawConfigComp:NPC")]
	public UNiagaraParameterCollection NPC
	{
		get
		{
			CheckDestroyed();
			if (!NPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:NPC");
				return null;
			}
			return UObjectMarshaler<UNiagaraParameterCollection>.FromNative(IntPtr.Add(base.Address, NPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:NPC");
			}
			else
			{
				UObjectMarshaler<UNiagaraParameterCollection>.ToNative(IntPtr.Add(base.Address, NPC_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_InteractDrawConfigComp:M_CombineTexture")]
	public UMaterial M_CombineTexture
	{
		get
		{
			CheckDestroyed();
			if (!M_CombineTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:M_CombineTexture");
				return null;
			}
			return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(base.Address, M_CombineTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!M_CombineTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:M_CombineTexture");
			}
			else
			{
				UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(base.Address, M_CombineTexture_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_InteractDrawConfigComp:RT_LandscapeMap")]
	public UTextureRenderTarget2D RT_LandscapeMap
	{
		get
		{
			CheckDestroyed();
			if (!RT_LandscapeMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:RT_LandscapeMap");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_LandscapeMap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_LandscapeMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:RT_LandscapeMap");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_LandscapeMap_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_InteractDrawConfigComp:RT_DataStorage")]
	public UTextureRenderTarget2D RT_DataStorage
	{
		get
		{
			CheckDestroyed();
			if (!RT_DataStorage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:RT_DataStorage");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_DataStorage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_DataStorage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_InteractDrawConfigComp:RT_DataStorage");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_DataStorage_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_InteractDrawData bUC_InteractDrawData = RequireWritableData<BUC_InteractDrawData>();
		if (MPC != null)
		{
			bUC_InteractDrawData.GlobalMPC.Set(MPC);
		}
		if (NPC != null)
		{
			bUC_InteractDrawData.GlobalNPC.Set(UNiagaraFunctionLibrary.GetNiagaraParameterCollection(GetOwner(), NPC));
		}
		if (M_CombineTexture != null)
		{
			bUC_InteractDrawData.M_CombineTexture.Set(M_CombineTexture);
		}
		if (RT_LandscapeMap != null)
		{
			bUC_InteractDrawData.RT_LandscapeMap.Set(RT_LandscapeMap);
		}
		if (RT_DataStorage != null)
		{
			bUC_InteractDrawData.DataStorageRTSize = RT_DataStorage.SizeX;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_InteractDrawConfigComp");
		MPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPC");
		MPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPC", Classes.FObjectProperty);
		NPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NPC");
		NPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NPC", Classes.FObjectProperty);
		M_CombineTexture_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "M_CombineTexture");
		M_CombineTexture_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "M_CombineTexture", Classes.FObjectProperty);
		RT_LandscapeMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RT_LandscapeMap");
		RT_LandscapeMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RT_LandscapeMap", Classes.FObjectProperty);
		RT_DataStorage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RT_DataStorage");
		RT_DataStorage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RT_DataStorage", Classes.FObjectProperty);
	}

	static BUS_InteractDrawConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_InteractDrawConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_InteractDrawConfigComp));
	}
}
