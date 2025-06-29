using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent")]
public class FluidHeightmapFogComponent : UActorComponent
{
	private int MinHeight = 130;

	private int MaxHeight = 150;

	private static bool RT_TopHeightmap_IsValid;

	private static int RT_TopHeightmap_Offset;

	private static bool RT_BottomHeightmap_IsValid;

	private static int RT_BottomHeightmap_Offset;

	private static bool MID_BaseHeightmap_IsValid;

	private static int MID_BaseHeightmap_Offset;

	private static bool MID_PSFogOutput_IsValid;

	private static int MID_PSFogOutput_Offset;

	private static bool PS_FogOutput_IsValid;

	private static int PS_FogOutput_Offset;

	private static bool BB_Heightmap_IsValid;

	private static int BB_Heightmap_Offset;

	private static bool DebuggerActor_IsValid;

	private static int DebuggerActor_Offset;

	private static bool BoundingSize_IsValid;

	private static int BoundingSize_Offset;

	private static bool InitComp_IsValid;

	private static IntPtr InitComp_FunctionAddress;

	private static int InitComp_ParamsSize;

	private static bool RenderHeightmap_IsValid;

	private static IntPtr RenderHeightmap_FunctionAddress;

	private static int RenderHeightmap_ParamsSize;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:RT_TopHeightmap")]
	private UTextureRenderTarget2D RT_TopHeightmap
	{
		get
		{
			CheckDestroyed();
			if (!RT_TopHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:RT_TopHeightmap");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_TopHeightmap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_TopHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:RT_TopHeightmap");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_TopHeightmap_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:RT_BottomHeightmap")]
	private UTextureRenderTarget2D RT_BottomHeightmap
	{
		get
		{
			CheckDestroyed();
			if (!RT_BottomHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:RT_BottomHeightmap");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_BottomHeightmap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_BottomHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:RT_BottomHeightmap");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_BottomHeightmap_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:MID_BaseHeightmap")]
	private UMaterialInstanceDynamic MID_BaseHeightmap
	{
		get
		{
			CheckDestroyed();
			if (!MID_BaseHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:MID_BaseHeightmap");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, MID_BaseHeightmap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MID_BaseHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:MID_BaseHeightmap");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, MID_BaseHeightmap_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:MID_PSFogOutput")]
	private UMaterialInstanceDynamic MID_PSFogOutput
	{
		get
		{
			CheckDestroyed();
			if (!MID_PSFogOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:MID_PSFogOutput");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, MID_PSFogOutput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MID_PSFogOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:MID_PSFogOutput");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, MID_PSFogOutput_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:PS_FogOutput")]
	private UParticleSystemComponent PS_FogOutput
	{
		get
		{
			CheckDestroyed();
			if (!PS_FogOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:PS_FogOutput");
				return null;
			}
			return UObjectMarshaler<UParticleSystemComponent>.FromNative(IntPtr.Add(base.Address, PS_FogOutput_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PS_FogOutput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:PS_FogOutput");
			}
			else
			{
				UObjectMarshaler<UParticleSystemComponent>.ToNative(IntPtr.Add(base.Address, PS_FogOutput_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:BB_Heightmap")]
	private UBoxComponent BB_Heightmap
	{
		get
		{
			CheckDestroyed();
			if (!BB_Heightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:BB_Heightmap");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, BB_Heightmap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BB_Heightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:BB_Heightmap");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, BB_Heightmap_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:DebuggerActor")]
	private RenderTargetDebugger DebuggerActor
	{
		get
		{
			CheckDestroyed();
			if (!DebuggerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:DebuggerActor");
				return null;
			}
			return UObjectMarshaler<RenderTargetDebugger>.FromNative(IntPtr.Add(base.Address, DebuggerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebuggerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:DebuggerActor");
			}
			else
			{
				UObjectMarshaler<RenderTargetDebugger>.ToNative(IntPtr.Add(base.Address, DebuggerActor_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:BoundingSize")]
	private int BoundingSize
	{
		get
		{
			CheckDestroyed();
			if (!BoundingSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:BoundingSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BoundingSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoundingSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.FluidHeightmapFogComponent:BoundingSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BoundingSize_Offset), value);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:InitComp")]
	public void InitComp()
	{
		UMaterial parent = UObject.LoadObject<UMaterial>(this, "/Game/00MainSZ/TestMap/wenyong/FogTest/Material/M_FluidHeightmapCube.M_FluidHeightmapCube");
		UMaterial parent2 = UObject.LoadObject<UMaterial>(this, "/Game/00MainSZ/TestMap/wenyong/FogTest/Material/M_FluidHeightmapParticle.M_FluidHeightmapParticle");
		UParticleSystem emitterTemplate = UObject.LoadObject<UParticleSystem>(this, "/Game/00MainSZ/TestMap/wenyong/FogTest/Particle/PS_FogOutput.PS_FogOutput");
		int num = 16;
		int num2 = 256;
		int num3 = 256;
		int num4 = num2 * num;
		int num5 = num3 * num;
		FVector actorLocation = GetOwner().GetActorLocation();
		RT_TopHeightmap = URenderingLibrary.CreateRenderTarget2D(this, num2, num3, ETextureRenderTargetFormat.RTF_R16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
		RT_BottomHeightmap = URenderingLibrary.CreateRenderTarget2D(this, num2, num3, ETextureRenderTargetFormat.RTF_R16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
		MID_BaseHeightmap = UMaterialLibrary.CreateDynamicMaterialInstance(this, parent, B1Names.None, EMIDCreationFlags.None);
		MID_PSFogOutput = UMaterialLibrary.CreateDynamicMaterialInstance(this, parent2, B1Names.None, EMIDCreationFlags.None);
		MID_BaseHeightmap.SetVectorParameterValue(B1Names.BoundingInfo, new FLinearColor(MinHeight, MaxHeight, num2, num));
		MID_BaseHeightmap.SetVectorParameterValue(B1Names.Params, new FLinearColor(1f, 1f, 1f));
		MID_PSFogOutput.SetTextureParameterValue(B1Names.TopHeightmap, RT_TopHeightmap);
		MID_PSFogOutput.SetTextureParameterValue(B1Names.BottomHeightmap, RT_BottomHeightmap);
		MID_PSFogOutput.SetVectorParameterValue(B1Names.Bounding, new FLinearColor(actorLocation.X - (float)num4 * 0.5f, actorLocation.Y - (float)num5 * 0.5f, actorLocation.X + (float)num4 * 0.5f, actorLocation.Y + (float)num5 * 0.5f));
		MID_PSFogOutput.SetVectorParameterValue(B1Names.BoundingInfo, new FLinearColor(MinHeight, MaxHeight, num2, num));
		MID_PSFogOutput.SetVectorParameterValue(B1Names.Params, new FLinearColor(1f, 1f, 1f));
		PS_FogOutput = UGameplayStatics.SpawnEmitterAtLocation(this, emitterTemplate, GetOwner().GetActorLocation(), FRotator.ZeroRotator, FVector.OneVector, bAutoDestroy: false, EPSCPoolMethod.None, bAutoActivateSystem: true);
		PS_FogOutput.SetMaterial(0, MID_PSFogOutput);
		DebuggerActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay<RenderTargetDebugger>(GetOwner().World);
		DebuggerActor.InitWithParam(RT_TopHeightmap, new FLinearColor(0.05f, -130f, 0f, 0f));
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.FluidHeightmapFogComponent:RenderHeightmap")]
	private void RenderHeightmap()
	{
		MID_BaseHeightmap.SetVectorParameterValue(B1Names.Params, new FLinearColor(1f, 1f, MinHeight));
		URenderingLibrary.DrawMaterialToRenderTarget(this, RT_BottomHeightmap, MID_BaseHeightmap);
		MID_BaseHeightmap.SetVectorParameterValue(B1Names.Params, new FLinearColor(1f, 1f, MaxHeight));
		URenderingLibrary.DrawMaterialToRenderTarget(this, RT_TopHeightmap, MID_BaseHeightmap);
	}

	[UFunctionInvoker("/Script/b1-Managed.FluidHeightmapFogComponent:InitComp")]
	private static void InitComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		FluidHeightmapFogComponent fluidHeightmapFogComponent = GCHelper.Find<FluidHeightmapFogComponent>(obj);
		fluidHeightmapFogComponent.InitComp();
	}

	[UFunctionInvoker("/Script/b1-Managed.FluidHeightmapFogComponent:RenderHeightmap")]
	private static void RenderHeightmap__Invoker(IntPtr buffer, IntPtr obj)
	{
		FluidHeightmapFogComponent fluidHeightmapFogComponent = GCHelper.Find<FluidHeightmapFogComponent>(obj);
		fluidHeightmapFogComponent.RenderHeightmap();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.FluidHeightmapFogComponent");
		RT_TopHeightmap_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT_TopHeightmap");
		RT_TopHeightmap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT_TopHeightmap", Classes.FObjectProperty);
		RT_BottomHeightmap_Offset = NativeReflection.GetPropertyOffset(intPtr, "RT_BottomHeightmap");
		RT_BottomHeightmap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RT_BottomHeightmap", Classes.FObjectProperty);
		MID_BaseHeightmap_Offset = NativeReflection.GetPropertyOffset(intPtr, "MID_BaseHeightmap");
		MID_BaseHeightmap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MID_BaseHeightmap", Classes.FObjectProperty);
		MID_PSFogOutput_Offset = NativeReflection.GetPropertyOffset(intPtr, "MID_PSFogOutput");
		MID_PSFogOutput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MID_PSFogOutput", Classes.FObjectProperty);
		PS_FogOutput_Offset = NativeReflection.GetPropertyOffset(intPtr, "PS_FogOutput");
		PS_FogOutput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PS_FogOutput", Classes.FObjectProperty);
		BB_Heightmap_Offset = NativeReflection.GetPropertyOffset(intPtr, "BB_Heightmap");
		BB_Heightmap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BB_Heightmap", Classes.FObjectProperty);
		DebuggerActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "DebuggerActor");
		DebuggerActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DebuggerActor", Classes.FObjectProperty);
		BoundingSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoundingSize");
		BoundingSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoundingSize", Classes.FIntProperty);
		InitComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitComp");
		InitComp_ParamsSize = NativeReflection.GetFunctionParamsSize(InitComp_FunctionAddress);
		InitComp_IsValid = InitComp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FluidHeightmapFogComponent:InitComp", InitComp_IsValid);
		RenderHeightmap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RenderHeightmap");
		RenderHeightmap_ParamsSize = NativeReflection.GetFunctionParamsSize(RenderHeightmap_FunctionAddress);
		RenderHeightmap_IsValid = RenderHeightmap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.FluidHeightmapFogComponent:RenderHeightmap", RenderHeightmap_IsValid);
	}

	static FluidHeightmapFogComponent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FluidHeightmapFogComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FluidHeightmapFogComponent));
	}
}
