using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Render;

[UClass]
[USharpPath("/Script/b1-Managed.RenderTargetDebugger")]
public class RenderTargetDebugger : AActor
{
	private static bool RT_Debug_IsValid;

	private static int RT_Debug_Offset;

	private static bool MID_RTPreview_IsValid;

	private static int MID_RTPreview_Offset;

	private static bool Mesh_Previewer_IsValid;

	private static int Mesh_Previewer_Offset;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.RenderTargetDebugger:RT_Debug")]
	public UTextureRenderTarget2D RT_Debug
	{
		get
		{
			CheckDestroyed();
			if (!RT_Debug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.RenderTargetDebugger:RT_Debug");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, RT_Debug_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RT_Debug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.RenderTargetDebugger:RT_Debug");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, RT_Debug_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.RenderTargetDebugger:MID_RTPreview")]
	private UMaterialInstanceDynamic MID_RTPreview
	{
		get
		{
			CheckDestroyed();
			if (!MID_RTPreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.RenderTargetDebugger:MID_RTPreview");
				return null;
			}
			return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(base.Address, MID_RTPreview_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MID_RTPreview_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.RenderTargetDebugger:MID_RTPreview");
			}
			else
			{
				UObjectMarshaler<UMaterialInstanceDynamic>.ToNative(IntPtr.Add(base.Address, MID_RTPreview_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.RenderTargetDebugger:Mesh_Previewer")]
	private UStaticMeshComponent Mesh_Previewer
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_Previewer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.RenderTargetDebugger:Mesh_Previewer");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, Mesh_Previewer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_Previewer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.RenderTargetDebugger:Mesh_Previewer");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, Mesh_Previewer_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Mesh_Previewer = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1Names.Mesh_Previewer);
	}

	public void InitWithParam(UTextureRenderTarget2D Target, FLinearColor Params)
	{
		RT_Debug = Target;
		UMaterial parent = UObject.LoadObject<UMaterial>(this, "/Game/00MainSZ/TestMap/wenyong/FogTest/Material/M_RTPreview.M_RTPreview");
		MID_RTPreview = UMaterialLibrary.CreateDynamicMaterialInstance(this, parent, B1Names.None, EMIDCreationFlags.None);
		MID_RTPreview.SetVectorParameterValue(B1Names.Params, Params);
		MID_RTPreview.SetTextureParameterValue(B1Names.RT, Target);
		Mesh_Previewer.SetStaticMesh(UObject.LoadObject<UStaticMesh>(this, "/Engine/BasicShapes/Plane.Plane"));
		Mesh_Previewer.SetMaterial(0, MID_RTPreview);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.RenderTargetDebugger");
		RT_Debug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RT_Debug");
		RT_Debug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RT_Debug", Classes.FObjectProperty);
		MID_RTPreview_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MID_RTPreview");
		MID_RTPreview_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MID_RTPreview", Classes.FObjectProperty);
		Mesh_Previewer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Mesh_Previewer");
		Mesh_Previewer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Mesh_Previewer", Classes.FObjectProperty);
	}

	static RenderTargetDebugger()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(RenderTargetDebugger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(RenderTargetDebugger));
	}
}
