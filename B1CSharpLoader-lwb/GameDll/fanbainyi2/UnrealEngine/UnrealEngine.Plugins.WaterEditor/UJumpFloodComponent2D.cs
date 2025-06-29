using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.WaterEditor;

[UClass(Flags = (ClassFlags)819986596uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D", "WaterEditor", UnrealModuleType.EnginePlugin)]
public class UJumpFloodComponent2D : UActorComponent
{
	private static bool JumpStepMaterial_IsValid;

	private static int JumpStepMaterial_Offset;

	private static bool FindEdgesMaterial_IsValid;

	private static int FindEdgesMaterial_Offset;

	private static bool BlurEdgesMaterial_IsValid;

	private static int BlurEdgesMaterial_Offset;

	private static bool UseBlur_IsValid;

	private static FFieldAddress UseBlur_PropertyAddress;

	private static int UseBlur_Offset;

	private static bool BlurPasses_IsValid;

	private static int BlurPasses_Offset;

	private static bool SingleJumpStep_IsValid;

	private static IntPtr SingleJumpStep_FunctionAddress;

	private static int SingleJumpStep_ParamsSize;

	private static bool SingleJumpStep_ReturnValue_IsValid;

	private static FFieldAddress SingleJumpStep_ReturnValue_PropertyAddress;

	private static int SingleJumpStep_ReturnValue_Offset;

	private static bool SingleBlurStep_IsValid;

	private static IntPtr SingleBlurStep_FunctionAddress;

	private static int SingleBlurStep_ParamsSize;

	private static bool SingleBlurStep_ReturnValue_IsValid;

	private static FFieldAddress SingleBlurStep_ReturnValue_PropertyAddress;

	private static int SingleBlurStep_ReturnValue_Offset;

	private static bool JumpFlood_IsValid;

	private static IntPtr JumpFlood_FunctionAddress;

	private static int JumpFlood_ParamsSize;

	private static bool JumpFlood_SeedRT_IsValid;

	private static FFieldAddress JumpFlood_SeedRT_PropertyAddress;

	private static int JumpFlood_SeedRT_Offset;

	private static bool JumpFlood_SceneCaptureZ_IsValid;

	private static FFieldAddress JumpFlood_SceneCaptureZ_PropertyAddress;

	private static int JumpFlood_SceneCaptureZ_Offset;

	private static bool JumpFlood_Curl_IsValid;

	private static FFieldAddress JumpFlood_Curl_PropertyAddress;

	private static int JumpFlood_Curl_Offset;

	private static bool JumpFlood_UseDepth_IsValid;

	private static FFieldAddress JumpFlood_UseDepth_PropertyAddress;

	private static int JumpFlood_UseDepth_Offset;

	private static bool JumpFlood_ZxLocationT_IsValid;

	private static FFieldAddress JumpFlood_ZxLocationT_PropertyAddress;

	private static int JumpFlood_ZxLocationT_Offset;

	private static bool FindEdges_Debug_IsValid;

	private static IntPtr FindEdges_Debug_FunctionAddress;

	private static int FindEdges_Debug_ParamsSize;

	private static bool FindEdges_Debug_SeedRT_IsValid;

	private static FFieldAddress FindEdges_Debug_SeedRT_PropertyAddress;

	private static int FindEdges_Debug_SeedRT_Offset;

	private static bool FindEdges_Debug_CaptureZ_IsValid;

	private static FFieldAddress FindEdges_Debug_CaptureZ_PropertyAddress;

	private static int FindEdges_Debug_CaptureZ_Offset;

	private static bool FindEdges_Debug_Curl_IsValid;

	private static FFieldAddress FindEdges_Debug_Curl_PropertyAddress;

	private static int FindEdges_Debug_Curl_Offset;

	private static bool FindEdges_Debug_DestRT_IsValid;

	private static FFieldAddress FindEdges_Debug_DestRT_PropertyAddress;

	private static int FindEdges_Debug_DestRT_Offset;

	private static bool FindEdges_Debug_ZOffset_IsValid;

	private static FFieldAddress FindEdges_Debug_ZOffset_PropertyAddress;

	private static int FindEdges_Debug_ZOffset_Offset;

	private static bool FindEdges_IsValid;

	private static IntPtr FindEdges_FunctionAddress;

	private static int FindEdges_ParamsSize;

	private static bool FindEdges_SeedRT_IsValid;

	private static FFieldAddress FindEdges_SeedRT_PropertyAddress;

	private static int FindEdges_SeedRT_Offset;

	private static bool FindEdges_CaptureZ_IsValid;

	private static FFieldAddress FindEdges_CaptureZ_PropertyAddress;

	private static int FindEdges_CaptureZ_Offset;

	private static bool FindEdges_Curl_IsValid;

	private static FFieldAddress FindEdges_Curl_PropertyAddress;

	private static int FindEdges_Curl_Offset;

	private static bool FindEdges_UseDepth_IsValid;

	private static FFieldAddress FindEdges_UseDepth_PropertyAddress;

	private static int FindEdges_UseDepth_Offset;

	private static bool FindEdges_ZxLocationT_IsValid;

	private static FFieldAddress FindEdges_ZxLocationT_PropertyAddress;

	private static int FindEdges_ZxLocationT_Offset;

	private static bool FindEdges_ReturnValue_IsValid;

	private static FFieldAddress FindEdges_ReturnValue_PropertyAddress;

	private static int FindEdges_ReturnValue_Offset;

	private static bool CreateMIDs_IsValid;

	private static IntPtr CreateMIDs_FunctionAddress;

	private static int CreateMIDs_ParamsSize;

	private static bool CreateMIDs_ReturnValue_IsValid;

	private static FFieldAddress CreateMIDs_ReturnValue_PropertyAddress;

	private static int CreateMIDs_ReturnValue_Offset;

	private static bool AssignRenderTargets_IsValid;

	private static IntPtr AssignRenderTargets_FunctionAddress;

	private static int AssignRenderTargets_ParamsSize;

	private static bool AssignRenderTargets_InRTA_IsValid;

	private static FFieldAddress AssignRenderTargets_InRTA_PropertyAddress;

	private static int AssignRenderTargets_InRTA_Offset;

	private static bool AssignRenderTargets_InRTB_IsValid;

	private static FFieldAddress AssignRenderTargets_InRTB_PropertyAddress;

	private static int AssignRenderTargets_InRTB_Offset;

	[UProperty(Flags = (PropFlags)6759867280787973uL)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:JumpStepMaterial")]
	public UMaterialInterface JumpStepMaterial
	{
		get
		{
			CheckDestroyed();
			if (!JumpStepMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:JumpStepMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, JumpStepMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpStepMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:JumpStepMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, JumpStepMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280787973uL)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:FindEdgesMaterial")]
	public UMaterialInterface FindEdgesMaterial
	{
		get
		{
			CheckDestroyed();
			if (!FindEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:FindEdgesMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, FindEdgesMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FindEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:FindEdgesMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, FindEdgesMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280787973uL)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:BlurEdgesMaterial")]
	public UMaterialInterface BlurEdgesMaterial
	{
		get
		{
			CheckDestroyed();
			if (!BlurEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:BlurEdgesMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, BlurEdgesMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlurEdgesMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:BlurEdgesMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, BlurEdgesMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:UseBlur")]
	public bool UseBlur
	{
		get
		{
			CheckDestroyed();
			if (!UseBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:UseBlur");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseBlur_Offset), 0, UseBlur_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:UseBlur");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseBlur_Offset), 0, UseBlur_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:BlurPasses")]
	public int BlurPasses
	{
		get
		{
			CheckDestroyed();
			if (!BlurPasses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:BlurPasses");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BlurPasses_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlurPasses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.JumpFloodComponent2D:BlurPasses");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BlurPasses_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:SingleJumpStep")]
	public unsafe UTextureRenderTarget2D SingleJumpStep()
	{
		CheckDestroyed();
		if (!SingleJumpStep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.JumpFloodComponent2D:SingleJumpStep");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SingleJumpStep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SingleJumpStep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SingleJumpStep_FunctionAddress, intPtr, SingleJumpStep_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, SingleJumpStep_ReturnValue_Offset), 0, SingleJumpStep_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:SingleBlurStep")]
	public unsafe UTextureRenderTarget2D SingleBlurStep()
	{
		CheckDestroyed();
		if (!SingleBlurStep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.JumpFloodComponent2D:SingleBlurStep");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SingleBlurStep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SingleBlurStep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SingleBlurStep_FunctionAddress, intPtr, SingleBlurStep_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, SingleBlurStep_ReturnValue_Offset), 0, SingleBlurStep_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:JumpFlood")]
	public unsafe void JumpFlood(UTextureRenderTarget2D SeedRT, float SceneCaptureZ, FLinearColor Curl, bool UseDepth, float ZxLocationT)
	{
		CheckDestroyed();
		if (!JumpFlood_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.JumpFloodComponent2D:JumpFlood");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JumpFlood_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JumpFlood_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, JumpFlood_SeedRT_Offset), 0, JumpFlood_SeedRT_PropertyAddress.Address, SeedRT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, JumpFlood_SceneCaptureZ_Offset), 0, JumpFlood_SceneCaptureZ_PropertyAddress.Address, SceneCaptureZ);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, JumpFlood_Curl_Offset), 0, JumpFlood_Curl_PropertyAddress.Address, Curl);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, JumpFlood_UseDepth_Offset), 0, JumpFlood_UseDepth_PropertyAddress.Address, UseDepth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, JumpFlood_ZxLocationT_Offset), 0, JumpFlood_ZxLocationT_PropertyAddress.Address, ZxLocationT);
		NativeReflection.InvokeFunctionOptimized(base.Address, JumpFlood_FunctionAddress, intPtr, JumpFlood_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:FindEdges_Debug")]
	public unsafe void FindEdges_Debug(UTextureRenderTarget2D SeedRT, float CaptureZ, FLinearColor Curl, UTextureRenderTarget2D DestRT, float ZOffset)
	{
		CheckDestroyed();
		if (!FindEdges_Debug_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.JumpFloodComponent2D:FindEdges_Debug");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindEdges_Debug_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindEdges_Debug_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, FindEdges_Debug_SeedRT_Offset), 0, FindEdges_Debug_SeedRT_PropertyAddress.Address, SeedRT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindEdges_Debug_CaptureZ_Offset), 0, FindEdges_Debug_CaptureZ_PropertyAddress.Address, CaptureZ);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, FindEdges_Debug_Curl_Offset), 0, FindEdges_Debug_Curl_PropertyAddress.Address, Curl);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, FindEdges_Debug_DestRT_Offset), 0, FindEdges_Debug_DestRT_PropertyAddress.Address, DestRT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindEdges_Debug_ZOffset_Offset), 0, FindEdges_Debug_ZOffset_PropertyAddress.Address, ZOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindEdges_Debug_FunctionAddress, intPtr, FindEdges_Debug_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:FindEdges")]
	public unsafe UTextureRenderTarget2D FindEdges(UTextureRenderTarget2D SeedRT, float CaptureZ, FLinearColor Curl, bool UseDepth, float ZxLocationT)
	{
		CheckDestroyed();
		if (!FindEdges_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.JumpFloodComponent2D:FindEdges");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindEdges_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindEdges_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, FindEdges_SeedRT_Offset), 0, FindEdges_SeedRT_PropertyAddress.Address, SeedRT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindEdges_CaptureZ_Offset), 0, FindEdges_CaptureZ_PropertyAddress.Address, CaptureZ);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, FindEdges_Curl_Offset), 0, FindEdges_Curl_PropertyAddress.Address, Curl);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindEdges_UseDepth_Offset), 0, FindEdges_UseDepth_PropertyAddress.Address, UseDepth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindEdges_ZxLocationT_Offset), 0, FindEdges_ZxLocationT_PropertyAddress.Address, ZxLocationT);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindEdges_FunctionAddress, intPtr, FindEdges_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, FindEdges_ReturnValue_Offset), 0, FindEdges_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:CreateMIDs")]
	public unsafe bool CreateMIDs()
	{
		CheckDestroyed();
		if (!CreateMIDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.JumpFloodComponent2D:CreateMIDs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateMIDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateMIDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateMIDs_FunctionAddress, intPtr, CreateMIDs_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CreateMIDs_ReturnValue_Offset), 0, CreateMIDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.JumpFloodComponent2D:AssignRenderTargets")]
	public unsafe void AssignRenderTargets(UTextureRenderTarget2D InRTA, UTextureRenderTarget2D InRTB)
	{
		CheckDestroyed();
		if (!AssignRenderTargets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.JumpFloodComponent2D:AssignRenderTargets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssignRenderTargets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssignRenderTargets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, AssignRenderTargets_InRTA_Offset), 0, AssignRenderTargets_InRTA_PropertyAddress.Address, InRTA);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, AssignRenderTargets_InRTB_Offset), 0, AssignRenderTargets_InRTB_PropertyAddress.Address, InRTB);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssignRenderTargets_FunctionAddress, intPtr, AssignRenderTargets_ParamsSize);
	}

	static UJumpFloodComponent2D()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJumpFloodComponent2D)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJumpFloodComponent2D));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/WaterEditor.JumpFloodComponent2D");
		JumpStepMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpStepMaterial");
		JumpStepMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpStepMaterial", Classes.FObjectProperty);
		FindEdgesMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FindEdgesMaterial");
		FindEdgesMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FindEdgesMaterial", Classes.FObjectProperty);
		BlurEdgesMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlurEdgesMaterial");
		BlurEdgesMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlurEdgesMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBlur_PropertyAddress, intPtr, "UseBlur");
		UseBlur_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseBlur");
		UseBlur_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseBlur", Classes.FBoolProperty);
		BlurPasses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlurPasses");
		BlurPasses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlurPasses", Classes.FIntProperty);
		SingleJumpStep_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SingleJumpStep");
		SingleJumpStep_ParamsSize = NativeReflection.GetFunctionParamsSize(SingleJumpStep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SingleJumpStep_ReturnValue_PropertyAddress, SingleJumpStep_FunctionAddress, "ReturnValue");
		SingleJumpStep_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SingleJumpStep_FunctionAddress, "ReturnValue");
		SingleJumpStep_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SingleJumpStep_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SingleJumpStep_IsValid = SingleJumpStep_FunctionAddress != IntPtr.Zero && SingleJumpStep_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.JumpFloodComponent2D:SingleJumpStep", SingleJumpStep_IsValid);
		SingleBlurStep_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SingleBlurStep");
		SingleBlurStep_ParamsSize = NativeReflection.GetFunctionParamsSize(SingleBlurStep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SingleBlurStep_ReturnValue_PropertyAddress, SingleBlurStep_FunctionAddress, "ReturnValue");
		SingleBlurStep_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SingleBlurStep_FunctionAddress, "ReturnValue");
		SingleBlurStep_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SingleBlurStep_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SingleBlurStep_IsValid = SingleBlurStep_FunctionAddress != IntPtr.Zero && SingleBlurStep_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.JumpFloodComponent2D:SingleBlurStep", SingleBlurStep_IsValid);
		JumpFlood_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "JumpFlood");
		JumpFlood_ParamsSize = NativeReflection.GetFunctionParamsSize(JumpFlood_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JumpFlood_SeedRT_PropertyAddress, JumpFlood_FunctionAddress, "SeedRT");
		JumpFlood_SeedRT_Offset = NativeReflectionCached.GetPropertyOffset(JumpFlood_FunctionAddress, "SeedRT");
		JumpFlood_SeedRT_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpFlood_FunctionAddress, "SeedRT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref JumpFlood_SceneCaptureZ_PropertyAddress, JumpFlood_FunctionAddress, "SceneCaptureZ");
		JumpFlood_SceneCaptureZ_Offset = NativeReflectionCached.GetPropertyOffset(JumpFlood_FunctionAddress, "SceneCaptureZ");
		JumpFlood_SceneCaptureZ_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpFlood_FunctionAddress, "SceneCaptureZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref JumpFlood_Curl_PropertyAddress, JumpFlood_FunctionAddress, "Curl");
		JumpFlood_Curl_Offset = NativeReflectionCached.GetPropertyOffset(JumpFlood_FunctionAddress, "Curl");
		JumpFlood_Curl_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpFlood_FunctionAddress, "Curl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref JumpFlood_UseDepth_PropertyAddress, JumpFlood_FunctionAddress, "UseDepth");
		JumpFlood_UseDepth_Offset = NativeReflectionCached.GetPropertyOffset(JumpFlood_FunctionAddress, "UseDepth");
		JumpFlood_UseDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpFlood_FunctionAddress, "UseDepth", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref JumpFlood_ZxLocationT_PropertyAddress, JumpFlood_FunctionAddress, "ZxLocationT");
		JumpFlood_ZxLocationT_Offset = NativeReflectionCached.GetPropertyOffset(JumpFlood_FunctionAddress, "ZxLocationT");
		JumpFlood_ZxLocationT_IsValid = NativeReflectionCached.ValidatePropertyClass(JumpFlood_FunctionAddress, "ZxLocationT", Classes.FFloatProperty);
		JumpFlood_IsValid = JumpFlood_FunctionAddress != IntPtr.Zero && JumpFlood_SeedRT_IsValid && JumpFlood_SceneCaptureZ_IsValid && JumpFlood_Curl_IsValid && JumpFlood_UseDepth_IsValid && JumpFlood_ZxLocationT_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.JumpFloodComponent2D:JumpFlood", JumpFlood_IsValid);
		FindEdges_Debug_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindEdges_Debug");
		FindEdges_Debug_ParamsSize = NativeReflection.GetFunctionParamsSize(FindEdges_Debug_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_Debug_SeedRT_PropertyAddress, FindEdges_Debug_FunctionAddress, "SeedRT");
		FindEdges_Debug_SeedRT_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_Debug_FunctionAddress, "SeedRT");
		FindEdges_Debug_SeedRT_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_Debug_FunctionAddress, "SeedRT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_Debug_CaptureZ_PropertyAddress, FindEdges_Debug_FunctionAddress, "CaptureZ");
		FindEdges_Debug_CaptureZ_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_Debug_FunctionAddress, "CaptureZ");
		FindEdges_Debug_CaptureZ_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_Debug_FunctionAddress, "CaptureZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_Debug_Curl_PropertyAddress, FindEdges_Debug_FunctionAddress, "Curl");
		FindEdges_Debug_Curl_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_Debug_FunctionAddress, "Curl");
		FindEdges_Debug_Curl_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_Debug_FunctionAddress, "Curl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_Debug_DestRT_PropertyAddress, FindEdges_Debug_FunctionAddress, "DestRT");
		FindEdges_Debug_DestRT_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_Debug_FunctionAddress, "DestRT");
		FindEdges_Debug_DestRT_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_Debug_FunctionAddress, "DestRT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_Debug_ZOffset_PropertyAddress, FindEdges_Debug_FunctionAddress, "ZOffset");
		FindEdges_Debug_ZOffset_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_Debug_FunctionAddress, "ZOffset");
		FindEdges_Debug_ZOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_Debug_FunctionAddress, "ZOffset", Classes.FFloatProperty);
		FindEdges_Debug_IsValid = FindEdges_Debug_FunctionAddress != IntPtr.Zero && FindEdges_Debug_SeedRT_IsValid && FindEdges_Debug_CaptureZ_IsValid && FindEdges_Debug_Curl_IsValid && FindEdges_Debug_DestRT_IsValid && FindEdges_Debug_ZOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.JumpFloodComponent2D:FindEdges_Debug", FindEdges_Debug_IsValid);
		FindEdges_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindEdges");
		FindEdges_ParamsSize = NativeReflection.GetFunctionParamsSize(FindEdges_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_SeedRT_PropertyAddress, FindEdges_FunctionAddress, "SeedRT");
		FindEdges_SeedRT_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_FunctionAddress, "SeedRT");
		FindEdges_SeedRT_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_FunctionAddress, "SeedRT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_CaptureZ_PropertyAddress, FindEdges_FunctionAddress, "CaptureZ");
		FindEdges_CaptureZ_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_FunctionAddress, "CaptureZ");
		FindEdges_CaptureZ_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_FunctionAddress, "CaptureZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_Curl_PropertyAddress, FindEdges_FunctionAddress, "Curl");
		FindEdges_Curl_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_FunctionAddress, "Curl");
		FindEdges_Curl_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_FunctionAddress, "Curl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_UseDepth_PropertyAddress, FindEdges_FunctionAddress, "UseDepth");
		FindEdges_UseDepth_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_FunctionAddress, "UseDepth");
		FindEdges_UseDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_FunctionAddress, "UseDepth", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_ZxLocationT_PropertyAddress, FindEdges_FunctionAddress, "ZxLocationT");
		FindEdges_ZxLocationT_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_FunctionAddress, "ZxLocationT");
		FindEdges_ZxLocationT_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_FunctionAddress, "ZxLocationT", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindEdges_ReturnValue_PropertyAddress, FindEdges_FunctionAddress, "ReturnValue");
		FindEdges_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindEdges_FunctionAddress, "ReturnValue");
		FindEdges_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindEdges_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindEdges_IsValid = FindEdges_FunctionAddress != IntPtr.Zero && FindEdges_SeedRT_IsValid && FindEdges_CaptureZ_IsValid && FindEdges_Curl_IsValid && FindEdges_UseDepth_IsValid && FindEdges_ZxLocationT_IsValid && FindEdges_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.JumpFloodComponent2D:FindEdges", FindEdges_IsValid);
		CreateMIDs_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateMIDs");
		CreateMIDs_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateMIDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateMIDs_ReturnValue_PropertyAddress, CreateMIDs_FunctionAddress, "ReturnValue");
		CreateMIDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateMIDs_FunctionAddress, "ReturnValue");
		CreateMIDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMIDs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreateMIDs_IsValid = CreateMIDs_FunctionAddress != IntPtr.Zero && CreateMIDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.JumpFloodComponent2D:CreateMIDs", CreateMIDs_IsValid);
		AssignRenderTargets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssignRenderTargets");
		AssignRenderTargets_ParamsSize = NativeReflection.GetFunctionParamsSize(AssignRenderTargets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssignRenderTargets_InRTA_PropertyAddress, AssignRenderTargets_FunctionAddress, "InRTA");
		AssignRenderTargets_InRTA_Offset = NativeReflectionCached.GetPropertyOffset(AssignRenderTargets_FunctionAddress, "InRTA");
		AssignRenderTargets_InRTA_IsValid = NativeReflectionCached.ValidatePropertyClass(AssignRenderTargets_FunctionAddress, "InRTA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssignRenderTargets_InRTB_PropertyAddress, AssignRenderTargets_FunctionAddress, "InRTB");
		AssignRenderTargets_InRTB_Offset = NativeReflectionCached.GetPropertyOffset(AssignRenderTargets_FunctionAddress, "InRTB");
		AssignRenderTargets_InRTB_IsValid = NativeReflectionCached.ValidatePropertyClass(AssignRenderTargets_FunctionAddress, "InRTB", Classes.FObjectProperty);
		AssignRenderTargets_IsValid = AssignRenderTargets_FunctionAddress != IntPtr.Zero && AssignRenderTargets_InRTA_IsValid && AssignRenderTargets_InRTB_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.JumpFloodComponent2D:AssignRenderTargets", AssignRenderTargets_IsValid);
	}
}
