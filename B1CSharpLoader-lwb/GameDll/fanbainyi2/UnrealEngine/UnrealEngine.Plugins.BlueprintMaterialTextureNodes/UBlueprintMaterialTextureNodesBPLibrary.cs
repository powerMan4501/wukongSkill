using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BlueprintMaterialTextureNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary", "BlueprintMaterialTextureNodes", UnrealModuleType.EnginePlugin)]
public class UBlueprintMaterialTextureNodesBPLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Texture2D_SampleUV_EditorOnly_IsValid;

	private static IntPtr Texture2D_SampleUV_EditorOnly_FunctionAddress;

	private static int Texture2D_SampleUV_EditorOnly_ParamsSize;

	private static bool Texture2D_SampleUV_EditorOnly_Texture_IsValid;

	private static FFieldAddress Texture2D_SampleUV_EditorOnly_Texture_PropertyAddress;

	private static int Texture2D_SampleUV_EditorOnly_Texture_Offset;

	private static bool Texture2D_SampleUV_EditorOnly_UV_IsValid;

	private static FFieldAddress Texture2D_SampleUV_EditorOnly_UV_PropertyAddress;

	private static int Texture2D_SampleUV_EditorOnly_UV_Offset;

	private static bool Texture2D_SampleUV_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress Texture2D_SampleUV_EditorOnly_ReturnValue_PropertyAddress;

	private static int Texture2D_SampleUV_EditorOnly_ReturnValue_Offset;

	private static bool SetMICVectorParam_EditorOnly_IsValid;

	private static IntPtr SetMICVectorParam_EditorOnly_FunctionAddress;

	private static int SetMICVectorParam_EditorOnly_ParamsSize;

	private static bool SetMICVectorParam_EditorOnly_Material_IsValid;

	private static FFieldAddress SetMICVectorParam_EditorOnly_Material_PropertyAddress;

	private static int SetMICVectorParam_EditorOnly_Material_Offset;

	private static bool SetMICVectorParam_EditorOnly_ParamName_IsValid;

	private static FFieldAddress SetMICVectorParam_EditorOnly_ParamName_PropertyAddress;

	private static int SetMICVectorParam_EditorOnly_ParamName_Offset;

	private static bool SetMICVectorParam_EditorOnly_Value_IsValid;

	private static FFieldAddress SetMICVectorParam_EditorOnly_Value_PropertyAddress;

	private static int SetMICVectorParam_EditorOnly_Value_Offset;

	private static bool SetMICVectorParam_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress SetMICVectorParam_EditorOnly_ReturnValue_PropertyAddress;

	private static int SetMICVectorParam_EditorOnly_ReturnValue_Offset;

	private static bool SetMICTwoSided_EditorOnly_IsValid;

	private static IntPtr SetMICTwoSided_EditorOnly_FunctionAddress;

	private static int SetMICTwoSided_EditorOnly_ParamsSize;

	private static bool SetMICTwoSided_EditorOnly_Material_IsValid;

	private static FFieldAddress SetMICTwoSided_EditorOnly_Material_PropertyAddress;

	private static int SetMICTwoSided_EditorOnly_Material_Offset;

	private static bool SetMICTwoSided_EditorOnly_TwoSided_IsValid;

	private static FFieldAddress SetMICTwoSided_EditorOnly_TwoSided_PropertyAddress;

	private static int SetMICTwoSided_EditorOnly_TwoSided_Offset;

	private static bool SetMICTwoSided_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress SetMICTwoSided_EditorOnly_ReturnValue_PropertyAddress;

	private static int SetMICTwoSided_EditorOnly_ReturnValue_Offset;

	private static bool SetMICTextureParam_EditorOnly_IsValid;

	private static IntPtr SetMICTextureParam_EditorOnly_FunctionAddress;

	private static int SetMICTextureParam_EditorOnly_ParamsSize;

	private static bool SetMICTextureParam_EditorOnly_Material_IsValid;

	private static FFieldAddress SetMICTextureParam_EditorOnly_Material_PropertyAddress;

	private static int SetMICTextureParam_EditorOnly_Material_Offset;

	private static bool SetMICTextureParam_EditorOnly_ParamName_IsValid;

	private static FFieldAddress SetMICTextureParam_EditorOnly_ParamName_PropertyAddress;

	private static int SetMICTextureParam_EditorOnly_ParamName_Offset;

	private static bool SetMICTextureParam_EditorOnly_Texture_IsValid;

	private static FFieldAddress SetMICTextureParam_EditorOnly_Texture_PropertyAddress;

	private static int SetMICTextureParam_EditorOnly_Texture_Offset;

	private static bool SetMICTextureParam_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress SetMICTextureParam_EditorOnly_ReturnValue_PropertyAddress;

	private static int SetMICTextureParam_EditorOnly_ReturnValue_Offset;

	private static bool SetMICShadingModel_EditorOnly_IsValid;

	private static IntPtr SetMICShadingModel_EditorOnly_FunctionAddress;

	private static int SetMICShadingModel_EditorOnly_ParamsSize;

	private static bool SetMICShadingModel_EditorOnly_Material_IsValid;

	private static FFieldAddress SetMICShadingModel_EditorOnly_Material_PropertyAddress;

	private static int SetMICShadingModel_EditorOnly_Material_Offset;

	private static bool SetMICShadingModel_EditorOnly_ShadingModel_IsValid;

	private static FFieldAddress SetMICShadingModel_EditorOnly_ShadingModel_PropertyAddress;

	private static int SetMICShadingModel_EditorOnly_ShadingModel_Offset;

	private static bool SetMICShadingModel_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress SetMICShadingModel_EditorOnly_ReturnValue_PropertyAddress;

	private static int SetMICShadingModel_EditorOnly_ReturnValue_Offset;

	private static bool SetMICScalarParam_EditorOnly_IsValid;

	private static IntPtr SetMICScalarParam_EditorOnly_FunctionAddress;

	private static int SetMICScalarParam_EditorOnly_ParamsSize;

	private static bool SetMICScalarParam_EditorOnly_Material_IsValid;

	private static FFieldAddress SetMICScalarParam_EditorOnly_Material_PropertyAddress;

	private static int SetMICScalarParam_EditorOnly_Material_Offset;

	private static bool SetMICScalarParam_EditorOnly_ParamName_IsValid;

	private static FFieldAddress SetMICScalarParam_EditorOnly_ParamName_PropertyAddress;

	private static int SetMICScalarParam_EditorOnly_ParamName_Offset;

	private static bool SetMICScalarParam_EditorOnly_Value_IsValid;

	private static FFieldAddress SetMICScalarParam_EditorOnly_Value_PropertyAddress;

	private static int SetMICScalarParam_EditorOnly_Value_Offset;

	private static bool SetMICScalarParam_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress SetMICScalarParam_EditorOnly_ReturnValue_PropertyAddress;

	private static int SetMICScalarParam_EditorOnly_ReturnValue_Offset;

	private static bool SetMICDitheredLODTransition_EditorOnly_IsValid;

	private static IntPtr SetMICDitheredLODTransition_EditorOnly_FunctionAddress;

	private static int SetMICDitheredLODTransition_EditorOnly_ParamsSize;

	private static bool SetMICDitheredLODTransition_EditorOnly_Material_IsValid;

	private static FFieldAddress SetMICDitheredLODTransition_EditorOnly_Material_PropertyAddress;

	private static int SetMICDitheredLODTransition_EditorOnly_Material_Offset;

	private static bool SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_IsValid;

	private static FFieldAddress SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_PropertyAddress;

	private static int SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_Offset;

	private static bool SetMICDitheredLODTransition_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress SetMICDitheredLODTransition_EditorOnly_ReturnValue_PropertyAddress;

	private static int SetMICDitheredLODTransition_EditorOnly_ReturnValue_Offset;

	private static bool SetMICBlendMode_EditorOnly_IsValid;

	private static IntPtr SetMICBlendMode_EditorOnly_FunctionAddress;

	private static int SetMICBlendMode_EditorOnly_ParamsSize;

	private static bool SetMICBlendMode_EditorOnly_Material_IsValid;

	private static FFieldAddress SetMICBlendMode_EditorOnly_Material_PropertyAddress;

	private static int SetMICBlendMode_EditorOnly_Material_Offset;

	private static bool SetMICBlendMode_EditorOnly_BlendMode_IsValid;

	private static FFieldAddress SetMICBlendMode_EditorOnly_BlendMode_PropertyAddress;

	private static int SetMICBlendMode_EditorOnly_BlendMode_Offset;

	private static bool SetMICBlendMode_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress SetMICBlendMode_EditorOnly_ReturnValue_PropertyAddress;

	private static int SetMICBlendMode_EditorOnly_ReturnValue_Offset;

	private static bool RenderTarget_SampleUV_EditorOnly_IsValid;

	private static IntPtr RenderTarget_SampleUV_EditorOnly_FunctionAddress;

	private static int RenderTarget_SampleUV_EditorOnly_ParamsSize;

	private static bool RenderTarget_SampleUV_EditorOnly_InRenderTarget_IsValid;

	private static FFieldAddress RenderTarget_SampleUV_EditorOnly_InRenderTarget_PropertyAddress;

	private static int RenderTarget_SampleUV_EditorOnly_InRenderTarget_Offset;

	private static bool RenderTarget_SampleUV_EditorOnly_UV_IsValid;

	private static FFieldAddress RenderTarget_SampleUV_EditorOnly_UV_PropertyAddress;

	private static int RenderTarget_SampleUV_EditorOnly_UV_Offset;

	private static bool RenderTarget_SampleUV_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress RenderTarget_SampleUV_EditorOnly_ReturnValue_PropertyAddress;

	private static int RenderTarget_SampleUV_EditorOnly_ReturnValue_Offset;

	private static bool RenderTarget_SampleRectangle_EditorOnly_IsValid;

	private static IntPtr RenderTarget_SampleRectangle_EditorOnly_FunctionAddress;

	private static int RenderTarget_SampleRectangle_EditorOnly_ParamsSize;

	private static bool RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_IsValid;

	private static FFieldAddress RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_PropertyAddress;

	private static int RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_Offset;

	private static bool RenderTarget_SampleRectangle_EditorOnly_InRect_IsValid;

	private static FFieldAddress RenderTarget_SampleRectangle_EditorOnly_InRect_PropertyAddress;

	private static int RenderTarget_SampleRectangle_EditorOnly_InRect_Offset;

	private static bool RenderTarget_SampleRectangle_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress RenderTarget_SampleRectangle_EditorOnly_ReturnValue_PropertyAddress;

	private static int RenderTarget_SampleRectangle_EditorOnly_ReturnValue_Offset;

	private static bool CreateMIC_EditorOnly_IsValid;

	private static IntPtr CreateMIC_EditorOnly_FunctionAddress;

	private static int CreateMIC_EditorOnly_ParamsSize;

	private static bool CreateMIC_EditorOnly_Material_IsValid;

	private static FFieldAddress CreateMIC_EditorOnly_Material_PropertyAddress;

	private static int CreateMIC_EditorOnly_Material_Offset;

	private static bool CreateMIC_EditorOnly_Name_IsValid;

	private static FFieldAddress CreateMIC_EditorOnly_Name_PropertyAddress;

	private static int CreateMIC_EditorOnly_Name_Offset;

	private static bool CreateMIC_EditorOnly_ReturnValue_IsValid;

	private static FFieldAddress CreateMIC_EditorOnly_ReturnValue_PropertyAddress;

	private static int CreateMIC_EditorOnly_ReturnValue_Offset;

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:Texture2D_SampleUV_EditorOnly")]
	public unsafe static FLinearColor Texture2D_SampleUV_EditorOnly(UTexture2D Texture, FVector2D UV)
	{
		if (!Texture2D_SampleUV_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:Texture2D_SampleUV_EditorOnly");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Texture2D_SampleUV_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Texture2D_SampleUV_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, Texture2D_SampleUV_EditorOnly_Texture_Offset), 0, Texture2D_SampleUV_EditorOnly_Texture_PropertyAddress.Address, Texture);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, Texture2D_SampleUV_EditorOnly_UV_Offset), 0, Texture2D_SampleUV_EditorOnly_UV_PropertyAddress.Address, UV);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Texture2D_SampleUV_EditorOnly_FunctionAddress, intPtr, Texture2D_SampleUV_EditorOnly_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, Texture2D_SampleUV_EditorOnly_ReturnValue_Offset), 0, Texture2D_SampleUV_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICVectorParam_EditorOnly")]
	public unsafe static bool SetMICVectorParam_EditorOnly(UMaterialInstanceConstant Material, string ParamName, FLinearColor Value)
	{
		if (!SetMICVectorParam_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICVectorParam_EditorOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMICVectorParam_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMICVectorParam_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstanceConstant>.ToNative(IntPtr.Add(intPtr, SetMICVectorParam_EditorOnly_Material_Offset), 0, SetMICVectorParam_EditorOnly_Material_PropertyAddress.Address, Material);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMICVectorParam_EditorOnly_ParamName_Offset), 0, SetMICVectorParam_EditorOnly_ParamName_PropertyAddress.Address, ParamName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetMICVectorParam_EditorOnly_Value_Offset), 0, SetMICVectorParam_EditorOnly_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMICVectorParam_EditorOnly_FunctionAddress, intPtr, SetMICVectorParam_EditorOnly_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMICVectorParam_EditorOnly_ParamName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMICVectorParam_EditorOnly_ReturnValue_Offset), 0, SetMICVectorParam_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICTwoSided_EditorOnly")]
	public unsafe static bool SetMICTwoSided_EditorOnly(UMaterialInstanceConstant Material, bool TwoSided = false)
	{
		if (!SetMICTwoSided_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICTwoSided_EditorOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMICTwoSided_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMICTwoSided_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstanceConstant>.ToNative(IntPtr.Add(intPtr, SetMICTwoSided_EditorOnly_Material_Offset), 0, SetMICTwoSided_EditorOnly_Material_PropertyAddress.Address, Material);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMICTwoSided_EditorOnly_TwoSided_Offset), 0, SetMICTwoSided_EditorOnly_TwoSided_PropertyAddress.Address, TwoSided);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMICTwoSided_EditorOnly_FunctionAddress, intPtr, SetMICTwoSided_EditorOnly_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMICTwoSided_EditorOnly_ReturnValue_Offset), 0, SetMICTwoSided_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICTextureParam_EditorOnly")]
	public unsafe static bool SetMICTextureParam_EditorOnly(UMaterialInstanceConstant Material, string ParamName, UTexture2D Texture)
	{
		if (!SetMICTextureParam_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICTextureParam_EditorOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMICTextureParam_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMICTextureParam_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstanceConstant>.ToNative(IntPtr.Add(intPtr, SetMICTextureParam_EditorOnly_Material_Offset), 0, SetMICTextureParam_EditorOnly_Material_PropertyAddress.Address, Material);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMICTextureParam_EditorOnly_ParamName_Offset), 0, SetMICTextureParam_EditorOnly_ParamName_PropertyAddress.Address, ParamName);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetMICTextureParam_EditorOnly_Texture_Offset), 0, SetMICTextureParam_EditorOnly_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMICTextureParam_EditorOnly_FunctionAddress, intPtr, SetMICTextureParam_EditorOnly_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMICTextureParam_EditorOnly_ParamName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMICTextureParam_EditorOnly_ReturnValue_Offset), 0, SetMICTextureParam_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICShadingModel_EditorOnly")]
	public unsafe static bool SetMICShadingModel_EditorOnly(UMaterialInstanceConstant Material, EMaterialShadingModel ShadingModel = EMaterialShadingModel.MSM_DefaultLit)
	{
		if (!SetMICShadingModel_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICShadingModel_EditorOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMICShadingModel_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMICShadingModel_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstanceConstant>.ToNative(IntPtr.Add(intPtr, SetMICShadingModel_EditorOnly_Material_Offset), 0, SetMICShadingModel_EditorOnly_Material_PropertyAddress.Address, Material);
		EnumMarshaler<EMaterialShadingModel>.ToNative(IntPtr.Add(intPtr, SetMICShadingModel_EditorOnly_ShadingModel_Offset), 0, SetMICShadingModel_EditorOnly_ShadingModel_PropertyAddress.Address, ShadingModel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMICShadingModel_EditorOnly_FunctionAddress, intPtr, SetMICShadingModel_EditorOnly_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMICShadingModel_EditorOnly_ReturnValue_Offset), 0, SetMICShadingModel_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICScalarParam_EditorOnly")]
	public unsafe static bool SetMICScalarParam_EditorOnly(UMaterialInstanceConstant Material, string ParamName = "test", float Value = 0f)
	{
		if (!SetMICScalarParam_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICScalarParam_EditorOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMICScalarParam_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMICScalarParam_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstanceConstant>.ToNative(IntPtr.Add(intPtr, SetMICScalarParam_EditorOnly_Material_Offset), 0, SetMICScalarParam_EditorOnly_Material_PropertyAddress.Address, Material);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMICScalarParam_EditorOnly_ParamName_Offset), 0, SetMICScalarParam_EditorOnly_ParamName_PropertyAddress.Address, ParamName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMICScalarParam_EditorOnly_Value_Offset), 0, SetMICScalarParam_EditorOnly_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMICScalarParam_EditorOnly_FunctionAddress, intPtr, SetMICScalarParam_EditorOnly_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMICScalarParam_EditorOnly_ParamName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMICScalarParam_EditorOnly_ReturnValue_Offset), 0, SetMICScalarParam_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICDitheredLODTransition_EditorOnly")]
	public unsafe static bool SetMICDitheredLODTransition_EditorOnly(UMaterialInstanceConstant Material, bool DitheredLODTransition = false)
	{
		if (!SetMICDitheredLODTransition_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICDitheredLODTransition_EditorOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMICDitheredLODTransition_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMICDitheredLODTransition_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstanceConstant>.ToNative(IntPtr.Add(intPtr, SetMICDitheredLODTransition_EditorOnly_Material_Offset), 0, SetMICDitheredLODTransition_EditorOnly_Material_PropertyAddress.Address, Material);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_Offset), 0, SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_PropertyAddress.Address, DitheredLODTransition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMICDitheredLODTransition_EditorOnly_FunctionAddress, intPtr, SetMICDitheredLODTransition_EditorOnly_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMICDitheredLODTransition_EditorOnly_ReturnValue_Offset), 0, SetMICDitheredLODTransition_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICBlendMode_EditorOnly")]
	public unsafe static bool SetMICBlendMode_EditorOnly(UMaterialInstanceConstant Material, EBlendMode BlendMode = EBlendMode.BLEND_Opaque)
	{
		if (!SetMICBlendMode_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICBlendMode_EditorOnly");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMICBlendMode_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMICBlendMode_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstanceConstant>.ToNative(IntPtr.Add(intPtr, SetMICBlendMode_EditorOnly_Material_Offset), 0, SetMICBlendMode_EditorOnly_Material_PropertyAddress.Address, Material);
		EnumMarshaler<EBlendMode>.ToNative(IntPtr.Add(intPtr, SetMICBlendMode_EditorOnly_BlendMode_Offset), 0, SetMICBlendMode_EditorOnly_BlendMode_PropertyAddress.Address, BlendMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMICBlendMode_EditorOnly_FunctionAddress, intPtr, SetMICBlendMode_EditorOnly_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetMICBlendMode_EditorOnly_ReturnValue_Offset), 0, SetMICBlendMode_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:RenderTarget_SampleUV_EditorOnly")]
	public unsafe static FLinearColor RenderTarget_SampleUV_EditorOnly(UTextureRenderTarget2D InRenderTarget, FVector2D UV)
	{
		if (!RenderTarget_SampleUV_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:RenderTarget_SampleUV_EditorOnly");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenderTarget_SampleUV_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenderTarget_SampleUV_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, RenderTarget_SampleUV_EditorOnly_InRenderTarget_Offset), 0, RenderTarget_SampleUV_EditorOnly_InRenderTarget_PropertyAddress.Address, InRenderTarget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, RenderTarget_SampleUV_EditorOnly_UV_Offset), 0, RenderTarget_SampleUV_EditorOnly_UV_PropertyAddress.Address, UV);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenderTarget_SampleUV_EditorOnly_FunctionAddress, intPtr, RenderTarget_SampleUV_EditorOnly_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, RenderTarget_SampleUV_EditorOnly_ReturnValue_Offset), 0, RenderTarget_SampleUV_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:RenderTarget_SampleRectangle_EditorOnly")]
	public unsafe static List<FLinearColor> RenderTarget_SampleRectangle_EditorOnly(UTextureRenderTarget2D InRenderTarget, FLinearColor InRect)
	{
		if (!RenderTarget_SampleRectangle_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:RenderTarget_SampleRectangle_EditorOnly");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenderTarget_SampleRectangle_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenderTarget_SampleRectangle_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_Offset), 0, RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_PropertyAddress.Address, InRenderTarget);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, RenderTarget_SampleRectangle_EditorOnly_InRect_Offset), 0, RenderTarget_SampleRectangle_EditorOnly_InRect_PropertyAddress.Address, InRect);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, intPtr, RenderTarget_SampleRectangle_EditorOnly_ParamsSize);
		List<FLinearColor> result = new TArrayCopyMarshaler<FLinearColor>(1, RenderTarget_SampleRectangle_EditorOnly_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(intPtr, RenderTarget_SampleRectangle_EditorOnly_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(RenderTarget_SampleRectangle_EditorOnly_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:CreateMIC_EditorOnly")]
	public unsafe static UMaterialInstanceConstant CreateMIC_EditorOnly(UMaterialInterface Material, string Name = "MIC_")
	{
		if (!CreateMIC_EditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:CreateMIC_EditorOnly");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateMIC_EditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateMIC_EditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, CreateMIC_EditorOnly_Material_Offset), 0, CreateMIC_EditorOnly_Material_PropertyAddress.Address, Material);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateMIC_EditorOnly_Name_Offset), 0, CreateMIC_EditorOnly_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateMIC_EditorOnly_FunctionAddress, intPtr, CreateMIC_EditorOnly_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateMIC_EditorOnly_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMaterialInstanceConstant>.FromNative(IntPtr.Add(intPtr, CreateMIC_EditorOnly_ReturnValue_Offset), 0, CreateMIC_EditorOnly_ReturnValue_PropertyAddress.Address);
	}

	static UBlueprintMaterialTextureNodesBPLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBlueprintMaterialTextureNodesBPLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBlueprintMaterialTextureNodesBPLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary");
		Texture2D_SampleUV_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Texture2D_SampleUV_EditorOnly");
		Texture2D_SampleUV_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(Texture2D_SampleUV_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Texture2D_SampleUV_EditorOnly_Texture_PropertyAddress, Texture2D_SampleUV_EditorOnly_FunctionAddress, "Texture");
		Texture2D_SampleUV_EditorOnly_Texture_Offset = NativeReflectionCached.GetPropertyOffset(Texture2D_SampleUV_EditorOnly_FunctionAddress, "Texture");
		Texture2D_SampleUV_EditorOnly_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(Texture2D_SampleUV_EditorOnly_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Texture2D_SampleUV_EditorOnly_UV_PropertyAddress, Texture2D_SampleUV_EditorOnly_FunctionAddress, "UV");
		Texture2D_SampleUV_EditorOnly_UV_Offset = NativeReflectionCached.GetPropertyOffset(Texture2D_SampleUV_EditorOnly_FunctionAddress, "UV");
		Texture2D_SampleUV_EditorOnly_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(Texture2D_SampleUV_EditorOnly_FunctionAddress, "UV", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Texture2D_SampleUV_EditorOnly_ReturnValue_PropertyAddress, Texture2D_SampleUV_EditorOnly_FunctionAddress, "ReturnValue");
		Texture2D_SampleUV_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Texture2D_SampleUV_EditorOnly_FunctionAddress, "ReturnValue");
		Texture2D_SampleUV_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Texture2D_SampleUV_EditorOnly_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Texture2D_SampleUV_EditorOnly_IsValid = Texture2D_SampleUV_EditorOnly_FunctionAddress != IntPtr.Zero && Texture2D_SampleUV_EditorOnly_Texture_IsValid && Texture2D_SampleUV_EditorOnly_UV_IsValid && Texture2D_SampleUV_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:Texture2D_SampleUV_EditorOnly", Texture2D_SampleUV_EditorOnly_IsValid);
		SetMICVectorParam_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMICVectorParam_EditorOnly");
		SetMICVectorParam_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMICVectorParam_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMICVectorParam_EditorOnly_Material_PropertyAddress, SetMICVectorParam_EditorOnly_FunctionAddress, "Material");
		SetMICVectorParam_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMICVectorParam_EditorOnly_FunctionAddress, "Material");
		SetMICVectorParam_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICVectorParam_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICVectorParam_EditorOnly_ParamName_PropertyAddress, SetMICVectorParam_EditorOnly_FunctionAddress, "ParamName");
		SetMICVectorParam_EditorOnly_ParamName_Offset = NativeReflectionCached.GetPropertyOffset(SetMICVectorParam_EditorOnly_FunctionAddress, "ParamName");
		SetMICVectorParam_EditorOnly_ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICVectorParam_EditorOnly_FunctionAddress, "ParamName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICVectorParam_EditorOnly_Value_PropertyAddress, SetMICVectorParam_EditorOnly_FunctionAddress, "Value");
		SetMICVectorParam_EditorOnly_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetMICVectorParam_EditorOnly_FunctionAddress, "Value");
		SetMICVectorParam_EditorOnly_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICVectorParam_EditorOnly_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICVectorParam_EditorOnly_ReturnValue_PropertyAddress, SetMICVectorParam_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICVectorParam_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMICVectorParam_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICVectorParam_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICVectorParam_EditorOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMICVectorParam_EditorOnly_IsValid = SetMICVectorParam_EditorOnly_FunctionAddress != IntPtr.Zero && SetMICVectorParam_EditorOnly_Material_IsValid && SetMICVectorParam_EditorOnly_ParamName_IsValid && SetMICVectorParam_EditorOnly_Value_IsValid && SetMICVectorParam_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICVectorParam_EditorOnly", SetMICVectorParam_EditorOnly_IsValid);
		SetMICTwoSided_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMICTwoSided_EditorOnly");
		SetMICTwoSided_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMICTwoSided_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMICTwoSided_EditorOnly_Material_PropertyAddress, SetMICTwoSided_EditorOnly_FunctionAddress, "Material");
		SetMICTwoSided_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMICTwoSided_EditorOnly_FunctionAddress, "Material");
		SetMICTwoSided_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICTwoSided_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICTwoSided_EditorOnly_TwoSided_PropertyAddress, SetMICTwoSided_EditorOnly_FunctionAddress, "TwoSided");
		SetMICTwoSided_EditorOnly_TwoSided_Offset = NativeReflectionCached.GetPropertyOffset(SetMICTwoSided_EditorOnly_FunctionAddress, "TwoSided");
		SetMICTwoSided_EditorOnly_TwoSided_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICTwoSided_EditorOnly_FunctionAddress, "TwoSided", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICTwoSided_EditorOnly_ReturnValue_PropertyAddress, SetMICTwoSided_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICTwoSided_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMICTwoSided_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICTwoSided_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICTwoSided_EditorOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMICTwoSided_EditorOnly_IsValid = SetMICTwoSided_EditorOnly_FunctionAddress != IntPtr.Zero && SetMICTwoSided_EditorOnly_Material_IsValid && SetMICTwoSided_EditorOnly_TwoSided_IsValid && SetMICTwoSided_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICTwoSided_EditorOnly", SetMICTwoSided_EditorOnly_IsValid);
		SetMICTextureParam_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMICTextureParam_EditorOnly");
		SetMICTextureParam_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMICTextureParam_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMICTextureParam_EditorOnly_Material_PropertyAddress, SetMICTextureParam_EditorOnly_FunctionAddress, "Material");
		SetMICTextureParam_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMICTextureParam_EditorOnly_FunctionAddress, "Material");
		SetMICTextureParam_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICTextureParam_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICTextureParam_EditorOnly_ParamName_PropertyAddress, SetMICTextureParam_EditorOnly_FunctionAddress, "ParamName");
		SetMICTextureParam_EditorOnly_ParamName_Offset = NativeReflectionCached.GetPropertyOffset(SetMICTextureParam_EditorOnly_FunctionAddress, "ParamName");
		SetMICTextureParam_EditorOnly_ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICTextureParam_EditorOnly_FunctionAddress, "ParamName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICTextureParam_EditorOnly_Texture_PropertyAddress, SetMICTextureParam_EditorOnly_FunctionAddress, "Texture");
		SetMICTextureParam_EditorOnly_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetMICTextureParam_EditorOnly_FunctionAddress, "Texture");
		SetMICTextureParam_EditorOnly_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICTextureParam_EditorOnly_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICTextureParam_EditorOnly_ReturnValue_PropertyAddress, SetMICTextureParam_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICTextureParam_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMICTextureParam_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICTextureParam_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICTextureParam_EditorOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMICTextureParam_EditorOnly_IsValid = SetMICTextureParam_EditorOnly_FunctionAddress != IntPtr.Zero && SetMICTextureParam_EditorOnly_Material_IsValid && SetMICTextureParam_EditorOnly_ParamName_IsValid && SetMICTextureParam_EditorOnly_Texture_IsValid && SetMICTextureParam_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICTextureParam_EditorOnly", SetMICTextureParam_EditorOnly_IsValid);
		SetMICShadingModel_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMICShadingModel_EditorOnly");
		SetMICShadingModel_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMICShadingModel_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMICShadingModel_EditorOnly_Material_PropertyAddress, SetMICShadingModel_EditorOnly_FunctionAddress, "Material");
		SetMICShadingModel_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMICShadingModel_EditorOnly_FunctionAddress, "Material");
		SetMICShadingModel_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICShadingModel_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICShadingModel_EditorOnly_ShadingModel_PropertyAddress, SetMICShadingModel_EditorOnly_FunctionAddress, "ShadingModel");
		SetMICShadingModel_EditorOnly_ShadingModel_Offset = NativeReflectionCached.GetPropertyOffset(SetMICShadingModel_EditorOnly_FunctionAddress, "ShadingModel");
		SetMICShadingModel_EditorOnly_ShadingModel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICShadingModel_EditorOnly_FunctionAddress, "ShadingModel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICShadingModel_EditorOnly_ReturnValue_PropertyAddress, SetMICShadingModel_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICShadingModel_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMICShadingModel_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICShadingModel_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICShadingModel_EditorOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMICShadingModel_EditorOnly_IsValid = SetMICShadingModel_EditorOnly_FunctionAddress != IntPtr.Zero && SetMICShadingModel_EditorOnly_Material_IsValid && SetMICShadingModel_EditorOnly_ShadingModel_IsValid && SetMICShadingModel_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICShadingModel_EditorOnly", SetMICShadingModel_EditorOnly_IsValid);
		SetMICScalarParam_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMICScalarParam_EditorOnly");
		SetMICScalarParam_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMICScalarParam_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMICScalarParam_EditorOnly_Material_PropertyAddress, SetMICScalarParam_EditorOnly_FunctionAddress, "Material");
		SetMICScalarParam_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMICScalarParam_EditorOnly_FunctionAddress, "Material");
		SetMICScalarParam_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICScalarParam_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICScalarParam_EditorOnly_ParamName_PropertyAddress, SetMICScalarParam_EditorOnly_FunctionAddress, "ParamName");
		SetMICScalarParam_EditorOnly_ParamName_Offset = NativeReflectionCached.GetPropertyOffset(SetMICScalarParam_EditorOnly_FunctionAddress, "ParamName");
		SetMICScalarParam_EditorOnly_ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICScalarParam_EditorOnly_FunctionAddress, "ParamName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICScalarParam_EditorOnly_Value_PropertyAddress, SetMICScalarParam_EditorOnly_FunctionAddress, "Value");
		SetMICScalarParam_EditorOnly_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetMICScalarParam_EditorOnly_FunctionAddress, "Value");
		SetMICScalarParam_EditorOnly_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICScalarParam_EditorOnly_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICScalarParam_EditorOnly_ReturnValue_PropertyAddress, SetMICScalarParam_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICScalarParam_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMICScalarParam_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICScalarParam_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICScalarParam_EditorOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMICScalarParam_EditorOnly_IsValid = SetMICScalarParam_EditorOnly_FunctionAddress != IntPtr.Zero && SetMICScalarParam_EditorOnly_Material_IsValid && SetMICScalarParam_EditorOnly_ParamName_IsValid && SetMICScalarParam_EditorOnly_Value_IsValid && SetMICScalarParam_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICScalarParam_EditorOnly", SetMICScalarParam_EditorOnly_IsValid);
		SetMICDitheredLODTransition_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMICDitheredLODTransition_EditorOnly");
		SetMICDitheredLODTransition_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMICDitheredLODTransition_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMICDitheredLODTransition_EditorOnly_Material_PropertyAddress, SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "Material");
		SetMICDitheredLODTransition_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "Material");
		SetMICDitheredLODTransition_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_PropertyAddress, SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "DitheredLODTransition");
		SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_Offset = NativeReflectionCached.GetPropertyOffset(SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "DitheredLODTransition");
		SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "DitheredLODTransition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICDitheredLODTransition_EditorOnly_ReturnValue_PropertyAddress, SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICDitheredLODTransition_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICDitheredLODTransition_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICDitheredLODTransition_EditorOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMICDitheredLODTransition_EditorOnly_IsValid = SetMICDitheredLODTransition_EditorOnly_FunctionAddress != IntPtr.Zero && SetMICDitheredLODTransition_EditorOnly_Material_IsValid && SetMICDitheredLODTransition_EditorOnly_DitheredLODTransition_IsValid && SetMICDitheredLODTransition_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICDitheredLODTransition_EditorOnly", SetMICDitheredLODTransition_EditorOnly_IsValid);
		SetMICBlendMode_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMICBlendMode_EditorOnly");
		SetMICBlendMode_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMICBlendMode_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMICBlendMode_EditorOnly_Material_PropertyAddress, SetMICBlendMode_EditorOnly_FunctionAddress, "Material");
		SetMICBlendMode_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMICBlendMode_EditorOnly_FunctionAddress, "Material");
		SetMICBlendMode_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICBlendMode_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICBlendMode_EditorOnly_BlendMode_PropertyAddress, SetMICBlendMode_EditorOnly_FunctionAddress, "BlendMode");
		SetMICBlendMode_EditorOnly_BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(SetMICBlendMode_EditorOnly_FunctionAddress, "BlendMode");
		SetMICBlendMode_EditorOnly_BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICBlendMode_EditorOnly_FunctionAddress, "BlendMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMICBlendMode_EditorOnly_ReturnValue_PropertyAddress, SetMICBlendMode_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICBlendMode_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMICBlendMode_EditorOnly_FunctionAddress, "ReturnValue");
		SetMICBlendMode_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMICBlendMode_EditorOnly_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetMICBlendMode_EditorOnly_IsValid = SetMICBlendMode_EditorOnly_FunctionAddress != IntPtr.Zero && SetMICBlendMode_EditorOnly_Material_IsValid && SetMICBlendMode_EditorOnly_BlendMode_IsValid && SetMICBlendMode_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:SetMICBlendMode_EditorOnly", SetMICBlendMode_EditorOnly_IsValid);
		RenderTarget_SampleUV_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenderTarget_SampleUV_EditorOnly");
		RenderTarget_SampleUV_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(RenderTarget_SampleUV_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenderTarget_SampleUV_EditorOnly_InRenderTarget_PropertyAddress, RenderTarget_SampleUV_EditorOnly_FunctionAddress, "InRenderTarget");
		RenderTarget_SampleUV_EditorOnly_InRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(RenderTarget_SampleUV_EditorOnly_FunctionAddress, "InRenderTarget");
		RenderTarget_SampleUV_EditorOnly_InRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTarget_SampleUV_EditorOnly_FunctionAddress, "InRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTarget_SampleUV_EditorOnly_UV_PropertyAddress, RenderTarget_SampleUV_EditorOnly_FunctionAddress, "UV");
		RenderTarget_SampleUV_EditorOnly_UV_Offset = NativeReflectionCached.GetPropertyOffset(RenderTarget_SampleUV_EditorOnly_FunctionAddress, "UV");
		RenderTarget_SampleUV_EditorOnly_UV_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTarget_SampleUV_EditorOnly_FunctionAddress, "UV", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTarget_SampleUV_EditorOnly_ReturnValue_PropertyAddress, RenderTarget_SampleUV_EditorOnly_FunctionAddress, "ReturnValue");
		RenderTarget_SampleUV_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenderTarget_SampleUV_EditorOnly_FunctionAddress, "ReturnValue");
		RenderTarget_SampleUV_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTarget_SampleUV_EditorOnly_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		RenderTarget_SampleUV_EditorOnly_IsValid = RenderTarget_SampleUV_EditorOnly_FunctionAddress != IntPtr.Zero && RenderTarget_SampleUV_EditorOnly_InRenderTarget_IsValid && RenderTarget_SampleUV_EditorOnly_UV_IsValid && RenderTarget_SampleUV_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:RenderTarget_SampleUV_EditorOnly", RenderTarget_SampleUV_EditorOnly_IsValid);
		RenderTarget_SampleRectangle_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenderTarget_SampleRectangle_EditorOnly");
		RenderTarget_SampleRectangle_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(RenderTarget_SampleRectangle_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_PropertyAddress, RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "InRenderTarget");
		RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "InRenderTarget");
		RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "InRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTarget_SampleRectangle_EditorOnly_InRect_PropertyAddress, RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "InRect");
		RenderTarget_SampleRectangle_EditorOnly_InRect_Offset = NativeReflectionCached.GetPropertyOffset(RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "InRect");
		RenderTarget_SampleRectangle_EditorOnly_InRect_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "InRect", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTarget_SampleRectangle_EditorOnly_ReturnValue_PropertyAddress, RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "ReturnValue");
		RenderTarget_SampleRectangle_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "ReturnValue");
		RenderTarget_SampleRectangle_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderTarget_SampleRectangle_EditorOnly_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		RenderTarget_SampleRectangle_EditorOnly_IsValid = RenderTarget_SampleRectangle_EditorOnly_FunctionAddress != IntPtr.Zero && RenderTarget_SampleRectangle_EditorOnly_InRenderTarget_IsValid && RenderTarget_SampleRectangle_EditorOnly_InRect_IsValid && RenderTarget_SampleRectangle_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:RenderTarget_SampleRectangle_EditorOnly", RenderTarget_SampleRectangle_EditorOnly_IsValid);
		CreateMIC_EditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateMIC_EditorOnly");
		CreateMIC_EditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateMIC_EditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateMIC_EditorOnly_Material_PropertyAddress, CreateMIC_EditorOnly_FunctionAddress, "Material");
		CreateMIC_EditorOnly_Material_Offset = NativeReflectionCached.GetPropertyOffset(CreateMIC_EditorOnly_FunctionAddress, "Material");
		CreateMIC_EditorOnly_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMIC_EditorOnly_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMIC_EditorOnly_Name_PropertyAddress, CreateMIC_EditorOnly_FunctionAddress, "Name");
		CreateMIC_EditorOnly_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateMIC_EditorOnly_FunctionAddress, "Name");
		CreateMIC_EditorOnly_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMIC_EditorOnly_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMIC_EditorOnly_ReturnValue_PropertyAddress, CreateMIC_EditorOnly_FunctionAddress, "ReturnValue");
		CreateMIC_EditorOnly_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateMIC_EditorOnly_FunctionAddress, "ReturnValue");
		CreateMIC_EditorOnly_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateMIC_EditorOnly_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateMIC_EditorOnly_IsValid = CreateMIC_EditorOnly_FunctionAddress != IntPtr.Zero && CreateMIC_EditorOnly_Material_IsValid && CreateMIC_EditorOnly_Name_IsValid && CreateMIC_EditorOnly_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BlueprintMaterialTextureNodes.BlueprintMaterialTextureNodesBPLibrary:CreateMIC_EditorOnly", CreateMIC_EditorOnly_IsValid);
	}
}
