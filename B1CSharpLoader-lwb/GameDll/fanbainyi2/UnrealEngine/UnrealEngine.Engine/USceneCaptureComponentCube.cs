using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SceneCaptureComponentCube", "Engine", UnrealModuleType.Engine)]
public class USceneCaptureComponentCube : USceneCaptureComponent
{
	private static bool TextureTarget_IsValid;

	private static int TextureTarget_Offset;

	private static bool CaptureRotation_IsValid;

	private static FFieldAddress CaptureRotation_PropertyAddress;

	private static int CaptureRotation_Offset;

	private static bool TextureTargetLeft_IsValid;

	private static int TextureTargetLeft_Offset;

	private static bool TextureTargetRight_IsValid;

	private static int TextureTargetRight_Offset;

	private static bool TextureTargetODS_IsValid;

	private static int TextureTargetODS_Offset;

	private static bool IPD_IsValid;

	private static int IPD_Offset;

	private static bool CaptureScene_IsValid;

	private static IntPtr CaptureScene_FunctionAddress;

	private static int CaptureScene_ParamsSize;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponentCube:TextureTarget")]
	public UTextureRenderTargetCube TextureTarget
	{
		get
		{
			CheckDestroyed();
			if (!TextureTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTarget");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTargetCube>.FromNative(IntPtr.Add(base.Address, TextureTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTarget");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTargetCube>.ToNative(IntPtr.Add(base.Address, TextureTarget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponentCube:bCaptureRotation")]
	public bool CaptureRotation
	{
		get
		{
			CheckDestroyed();
			if (!CaptureRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:bCaptureRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CaptureRotation_Offset), 0, CaptureRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:bCaptureRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CaptureRotation_Offset), 0, CaptureRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponentCube:TextureTargetLeft")]
	public UTextureRenderTargetCube TextureTargetLeft
	{
		get
		{
			CheckDestroyed();
			if (!TextureTargetLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTargetLeft");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTargetCube>.FromNative(IntPtr.Add(base.Address, TextureTargetLeft_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureTargetLeft_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTargetLeft");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTargetCube>.ToNative(IntPtr.Add(base.Address, TextureTargetLeft_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponentCube:TextureTargetRight")]
	public UTextureRenderTargetCube TextureTargetRight
	{
		get
		{
			CheckDestroyed();
			if (!TextureTargetRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTargetRight");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTargetCube>.FromNative(IntPtr.Add(base.Address, TextureTargetRight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureTargetRight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTargetRight");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTargetCube>.ToNative(IntPtr.Add(base.Address, TextureTargetRight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponentCube:TextureTargetODS")]
	public UTextureRenderTarget2D TextureTargetODS
	{
		get
		{
			CheckDestroyed();
			if (!TextureTargetODS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTargetODS");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, TextureTargetODS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureTargetODS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:TextureTargetODS");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, TextureTargetODS_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SceneCaptureComponentCube:IPD")]
	public float IPD
	{
		get
		{
			CheckDestroyed();
			if (!IPD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:IPD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IPD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IPD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneCaptureComponentCube:IPD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IPD_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneCaptureComponentCube:CaptureScene")]
	public unsafe void CaptureScene()
	{
		CheckDestroyed();
		if (!CaptureScene_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneCaptureComponentCube:CaptureScene");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureScene_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureScene_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CaptureScene_FunctionAddress, argsSize: CaptureScene_ParamsSize);
	}

	static USceneCaptureComponentCube()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USceneCaptureComponentCube)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USceneCaptureComponentCube));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SceneCaptureComponentCube");
		TextureTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureTarget");
		TextureTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureRotation_PropertyAddress, intPtr, "bCaptureRotation");
		CaptureRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCaptureRotation");
		CaptureRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCaptureRotation", Classes.FBoolProperty);
		TextureTargetLeft_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureTargetLeft");
		TextureTargetLeft_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureTargetLeft", Classes.FObjectProperty);
		TextureTargetRight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureTargetRight");
		TextureTargetRight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureTargetRight", Classes.FObjectProperty);
		TextureTargetODS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureTargetODS");
		TextureTargetODS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureTargetODS", Classes.FObjectProperty);
		IPD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IPD");
		IPD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IPD", Classes.FFloatProperty);
		CaptureScene_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CaptureScene");
		CaptureScene_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureScene_FunctionAddress);
		CaptureScene_IsValid = CaptureScene_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneCaptureComponentCube:CaptureScene", CaptureScene_IsValid);
	}
}
