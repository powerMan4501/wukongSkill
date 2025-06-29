using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.UMGSpline;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMGSpline.SplineWidget", "UMGSpline", UnrealModuleType.GamePlugin)]
public class USplineWidget : UWidget
{
	private static bool SplineInfo_IsValid;

	private static int SplineInfo_Offset;

	private static bool SplineDebugInfo_IsValid;

	private static int SplineDebugInfo_Offset;

	private static bool UpdateSpline_IsValid;

	private static IntPtr UpdateSpline_FunctionAddress;

	private static int UpdateSpline_ParamsSize;

	private static bool SetSplineType_IsValid;

	private static IntPtr SetSplineType_FunctionAddress;

	private static int SetSplineType_ParamsSize;

	private static bool SetSplineType_Type_IsValid;

	private static FFieldAddress SetSplineType_Type_PropertyAddress;

	private static int SetSplineType_Type_Offset;

	private static bool SetSplineThickness_IsValid;

	private static IntPtr SetSplineThickness_FunctionAddress;

	private static int SetSplineThickness_ParamsSize;

	private static bool SetSplineThickness_Thickness_IsValid;

	private static FFieldAddress SetSplineThickness_Thickness_PropertyAddress;

	private static int SetSplineThickness_Thickness_Offset;

	private static bool SetSplineMaterial_IsValid;

	private static IntPtr SetSplineMaterial_FunctionAddress;

	private static int SetSplineMaterial_ParamsSize;

	private static bool SetSplineMaterial_Material_IsValid;

	private static FFieldAddress SetSplineMaterial_Material_PropertyAddress;

	private static int SetSplineMaterial_Material_Offset;

	private static bool RemoveSplinePoint_IsValid;

	private static IntPtr RemoveSplinePoint_FunctionAddress;

	private static int RemoveSplinePoint_ParamsSize;

	private static bool RemoveSplinePoint_Index_IsValid;

	private static FFieldAddress RemoveSplinePoint_Index_PropertyAddress;

	private static int RemoveSplinePoint_Index_Offset;

	private static bool RemoveSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress RemoveSplinePoint_bUpdateSpline_PropertyAddress;

	private static int RemoveSplinePoint_bUpdateSpline_Offset;

	private static bool RemoveAllSplinePoint_IsValid;

	private static IntPtr RemoveAllSplinePoint_FunctionAddress;

	private static int RemoveAllSplinePoint_ParamsSize;

	private static bool RemoveAllSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress RemoveAllSplinePoint_bUpdateSpline_PropertyAddress;

	private static int RemoveAllSplinePoint_bUpdateSpline_Offset;

	private static bool GetTangentAtSplinePoint_IsValid;

	private static IntPtr GetTangentAtSplinePoint_FunctionAddress;

	private static int GetTangentAtSplinePoint_ParamsSize;

	private static bool GetTangentAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetTangentAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetTangentAtSplinePoint_PointIndex_Offset;

	private static bool GetTangentAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetTangentAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetTangentAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetTangentAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetTangentAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetTangentAtSplinePoint_ReturnValue_Offset;

	private static bool GetTangentAtSplineInputKey_IsValid;

	private static IntPtr GetTangentAtSplineInputKey_FunctionAddress;

	private static int GetTangentAtSplineInputKey_ParamsSize;

	private static bool GetTangentAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetTangentAtSplineInputKey_InKey_PropertyAddress;

	private static int GetTangentAtSplineInputKey_InKey_Offset;

	private static bool GetTangentAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetTangentAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetTangentAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetTangentAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetTangentAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetTangentAtSplineInputKey_ReturnValue_Offset;

	private static bool GetTangentAtDistanceAlongSpline_IsValid;

	private static IntPtr GetTangentAtDistanceAlongSpline_FunctionAddress;

	private static int GetTangentAtDistanceAlongSpline_ParamsSize;

	private static bool GetTangentAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetTangentAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetTangentAtDistanceAlongSpline_Distance_Offset;

	private static bool GetTangentAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetTangentAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetTangentAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetTangentAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetTangentAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetTangentAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetSplineType_IsValid;

	private static IntPtr GetSplineType_FunctionAddress;

	private static int GetSplineType_ParamsSize;

	private static bool GetSplineType_ReturnValue_IsValid;

	private static FFieldAddress GetSplineType_ReturnValue_PropertyAddress;

	private static int GetSplineType_ReturnValue_Offset;

	private static bool GetSplineThickness_IsValid;

	private static IntPtr GetSplineThickness_FunctionAddress;

	private static int GetSplineThickness_ParamsSize;

	private static bool GetSplineThickness_ReturnValue_IsValid;

	private static FFieldAddress GetSplineThickness_ReturnValue_PropertyAddress;

	private static int GetSplineThickness_ReturnValue_Offset;

	private static bool GetSplineMaterial_IsValid;

	private static IntPtr GetSplineMaterial_FunctionAddress;

	private static int GetSplineMaterial_ParamsSize;

	private static bool GetSplineMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetSplineMaterial_ReturnValue_PropertyAddress;

	private static int GetSplineMaterial_ReturnValue_Offset;

	private static bool GetSplineLength_IsValid;

	private static IntPtr GetSplineLength_FunctionAddress;

	private static int GetSplineLength_ParamsSize;

	private static bool GetSplineLength_ReturnValue_IsValid;

	private static FFieldAddress GetSplineLength_ReturnValue_PropertyAddress;

	private static int GetSplineLength_ReturnValue_Offset;

	private static bool GetSplineDynamicMaterial_IsValid;

	private static IntPtr GetSplineDynamicMaterial_FunctionAddress;

	private static int GetSplineDynamicMaterial_ParamsSize;

	private static bool GetSplineDynamicMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetSplineDynamicMaterial_ReturnValue_PropertyAddress;

	private static int GetSplineDynamicMaterial_ReturnValue_Offset;

	private static bool GetRotationAngleAtSplineInputKey_IsValid;

	private static IntPtr GetRotationAngleAtSplineInputKey_FunctionAddress;

	private static int GetRotationAngleAtSplineInputKey_ParamsSize;

	private static bool GetRotationAngleAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetRotationAngleAtSplineInputKey_InKey_PropertyAddress;

	private static int GetRotationAngleAtSplineInputKey_InKey_Offset;

	private static bool GetRotationAngleAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetRotationAngleAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetRotationAngleAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetRotationAngleAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetRotationAngleAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetRotationAngleAtSplineInputKey_ReturnValue_Offset;

	private static bool GetRotationAngleAtDistanceAlongSpline_IsValid;

	private static IntPtr GetRotationAngleAtDistanceAlongSpline_FunctionAddress;

	private static int GetRotationAngleAtDistanceAlongSpline_ParamsSize;

	private static bool GetRotationAngleAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetRotationAngleAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetRotationAngleAtDistanceAlongSpline_Distance_Offset;

	private static bool GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetRotationAngleAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetRotationAngleAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetRotationAngleAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetNumberOfSplinePoints_IsValid;

	private static IntPtr GetNumberOfSplinePoints_FunctionAddress;

	private static int GetNumberOfSplinePoints_ParamsSize;

	private static bool GetNumberOfSplinePoints_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfSplinePoints_ReturnValue_PropertyAddress;

	private static int GetNumberOfSplinePoints_ReturnValue_Offset;

	private static bool GetLocationAtSplinePoint_IsValid;

	private static IntPtr GetLocationAtSplinePoint_FunctionAddress;

	private static int GetLocationAtSplinePoint_ParamsSize;

	private static bool GetLocationAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetLocationAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetLocationAtSplinePoint_PointIndex_Offset;

	private static bool GetLocationAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetLocationAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetLocationAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetLocationAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetLocationAtSplinePoint_ReturnValue_Offset;

	private static bool GetLocationAtSplineInputKey_IsValid;

	private static IntPtr GetLocationAtSplineInputKey_FunctionAddress;

	private static int GetLocationAtSplineInputKey_ParamsSize;

	private static bool GetLocationAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetLocationAtSplineInputKey_InKey_PropertyAddress;

	private static int GetLocationAtSplineInputKey_InKey_Offset;

	private static bool GetLocationAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetLocationAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetLocationAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetLocationAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetLocationAtSplineInputKey_ReturnValue_Offset;

	private static bool GetLocationAtDistanceAlongSpline_IsValid;

	private static IntPtr GetLocationAtDistanceAlongSpline_FunctionAddress;

	private static int GetLocationAtDistanceAlongSpline_ParamsSize;

	private static bool GetLocationAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetLocationAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetLocationAtDistanceAlongSpline_Distance_Offset;

	private static bool GetLocationAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetLocationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetLocationAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetLocationAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetLocationAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetLocationAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetInputKeyAtDistanceAlongSpline_IsValid;

	private static IntPtr GetInputKeyAtDistanceAlongSpline_FunctionAddress;

	private static int GetInputKeyAtDistanceAlongSpline_ParamsSize;

	private static bool GetInputKeyAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetInputKeyAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetInputKeyAtDistanceAlongSpline_Distance_Offset;

	private static bool GetInputKeyAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetInputKeyAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetInputKeyAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetInputKeyAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetInputKeyAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetInputKeyAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool GetDistanceAlongSplineAtSplineInputKey_IsValid;

	private static IntPtr GetDistanceAlongSplineAtSplineInputKey_FunctionAddress;

	private static int GetDistanceAlongSplineAtSplineInputKey_ParamsSize;

	private static bool GetDistanceAlongSplineAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetDistanceAlongSplineAtSplineInputKey_InKey_PropertyAddress;

	private static int GetDistanceAlongSplineAtSplineInputKey_InKey_Offset;

	private static bool GetDistanceAlongSplineAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetDistanceAlongSplineAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetDistanceAlongSplineAtSplineInputKey_ReturnValue_Offset;

	private static bool GetDirectionAtSplinePoint_IsValid;

	private static IntPtr GetDirectionAtSplinePoint_FunctionAddress;

	private static int GetDirectionAtSplinePoint_ParamsSize;

	private static bool GetDirectionAtSplinePoint_PointIndex_IsValid;

	private static FFieldAddress GetDirectionAtSplinePoint_PointIndex_PropertyAddress;

	private static int GetDirectionAtSplinePoint_PointIndex_Offset;

	private static bool GetDirectionAtSplinePoint_CoordinateSpace_IsValid;

	private static FFieldAddress GetDirectionAtSplinePoint_CoordinateSpace_PropertyAddress;

	private static int GetDirectionAtSplinePoint_CoordinateSpace_Offset;

	private static bool GetDirectionAtSplinePoint_ReturnValue_IsValid;

	private static FFieldAddress GetDirectionAtSplinePoint_ReturnValue_PropertyAddress;

	private static int GetDirectionAtSplinePoint_ReturnValue_Offset;

	private static bool GetDirectionAtSplineInputKey_IsValid;

	private static IntPtr GetDirectionAtSplineInputKey_FunctionAddress;

	private static int GetDirectionAtSplineInputKey_ParamsSize;

	private static bool GetDirectionAtSplineInputKey_InKey_IsValid;

	private static FFieldAddress GetDirectionAtSplineInputKey_InKey_PropertyAddress;

	private static int GetDirectionAtSplineInputKey_InKey_Offset;

	private static bool GetDirectionAtSplineInputKey_CoordinateSpace_IsValid;

	private static FFieldAddress GetDirectionAtSplineInputKey_CoordinateSpace_PropertyAddress;

	private static int GetDirectionAtSplineInputKey_CoordinateSpace_Offset;

	private static bool GetDirectionAtSplineInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetDirectionAtSplineInputKey_ReturnValue_PropertyAddress;

	private static int GetDirectionAtSplineInputKey_ReturnValue_Offset;

	private static bool GetDirectionAtDistanceAlongSpline_IsValid;

	private static IntPtr GetDirectionAtDistanceAlongSpline_FunctionAddress;

	private static int GetDirectionAtDistanceAlongSpline_ParamsSize;

	private static bool GetDirectionAtDistanceAlongSpline_Distance_IsValid;

	private static FFieldAddress GetDirectionAtDistanceAlongSpline_Distance_PropertyAddress;

	private static int GetDirectionAtDistanceAlongSpline_Distance_Offset;

	private static bool GetDirectionAtDistanceAlongSpline_CoordinateSpace_IsValid;

	private static FFieldAddress GetDirectionAtDistanceAlongSpline_CoordinateSpace_PropertyAddress;

	private static int GetDirectionAtDistanceAlongSpline_CoordinateSpace_Offset;

	private static bool GetDirectionAtDistanceAlongSpline_ReturnValue_IsValid;

	private static FFieldAddress GetDirectionAtDistanceAlongSpline_ReturnValue_PropertyAddress;

	private static int GetDirectionAtDistanceAlongSpline_ReturnValue_Offset;

	private static bool ChangeSplinePointAtIndex_IsValid;

	private static IntPtr ChangeSplinePointAtIndex_FunctionAddress;

	private static int ChangeSplinePointAtIndex_ParamsSize;

	private static bool ChangeSplinePointAtIndex_SplinePoint_IsValid;

	private static FFieldAddress ChangeSplinePointAtIndex_SplinePoint_PropertyAddress;

	private static int ChangeSplinePointAtIndex_SplinePoint_Offset;

	private static bool ChangeSplinePointAtIndex_Index_IsValid;

	private static FFieldAddress ChangeSplinePointAtIndex_Index_PropertyAddress;

	private static int ChangeSplinePointAtIndex_Index_Offset;

	private static bool ChangeSplinePointAtIndex_bUpdateSpline_IsValid;

	private static FFieldAddress ChangeSplinePointAtIndex_bUpdateSpline_PropertyAddress;

	private static int ChangeSplinePointAtIndex_bUpdateSpline_Offset;

	private static bool AddSplinePointAtIndex_IsValid;

	private static IntPtr AddSplinePointAtIndex_FunctionAddress;

	private static int AddSplinePointAtIndex_ParamsSize;

	private static bool AddSplinePointAtIndex_SplinePoint_IsValid;

	private static FFieldAddress AddSplinePointAtIndex_SplinePoint_PropertyAddress;

	private static int AddSplinePointAtIndex_SplinePoint_Offset;

	private static bool AddSplinePointAtIndex_Index_IsValid;

	private static FFieldAddress AddSplinePointAtIndex_Index_PropertyAddress;

	private static int AddSplinePointAtIndex_Index_Offset;

	private static bool AddSplinePointAtIndex_bUpdateSpline_IsValid;

	private static FFieldAddress AddSplinePointAtIndex_bUpdateSpline_PropertyAddress;

	private static int AddSplinePointAtIndex_bUpdateSpline_Offset;

	private static bool AddSplinePoint_IsValid;

	private static IntPtr AddSplinePoint_FunctionAddress;

	private static int AddSplinePoint_ParamsSize;

	private static bool AddSplinePoint_SplinePoint_IsValid;

	private static FFieldAddress AddSplinePoint_SplinePoint_PropertyAddress;

	private static int AddSplinePoint_SplinePoint_Offset;

	private static bool AddSplinePoint_bUpdateSpline_IsValid;

	private static FFieldAddress AddSplinePoint_bUpdateSpline_PropertyAddress;

	private static int AddSplinePoint_bUpdateSpline_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:SplineInfo")]
	public FUMGSplineInfo SplineInfo
	{
		get
		{
			CheckDestroyed();
			if (!SplineInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMGSpline.SplineWidget:SplineInfo");
				return default(FUMGSplineInfo);
			}
			return FUMGSplineInfo.FromNative(IntPtr.Add(base.Address, SplineInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMGSpline.SplineWidget:SplineInfo");
			}
			else
			{
				FUMGSplineInfo.ToNative(IntPtr.Add(base.Address, SplineInfo_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:SplineDebugInfo")]
	public FUMGSplineDebugInfo SplineDebugInfo
	{
		get
		{
			CheckDestroyed();
			if (!SplineDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMGSpline.SplineWidget:SplineDebugInfo");
				return default(FUMGSplineDebugInfo);
			}
			return FUMGSplineDebugInfo.FromNative(IntPtr.Add(base.Address, SplineDebugInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMGSpline.SplineWidget:SplineDebugInfo");
			}
			else
			{
				FUMGSplineDebugInfo.ToNative(IntPtr.Add(base.Address, SplineDebugInfo_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:UpdateSpline")]
	public unsafe void UpdateSpline()
	{
		CheckDestroyed();
		if (!UpdateSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:UpdateSpline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateSpline_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateSpline_FunctionAddress, argsSize: UpdateSpline_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:SetSplineType")]
	public unsafe void SetSplineType(EUMGSplineType Type)
	{
		CheckDestroyed();
		if (!SetSplineType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:SetSplineType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplineType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplineType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUMGSplineType>.ToNative(IntPtr.Add(intPtr, SetSplineType_Type_Offset), 0, SetSplineType_Type_PropertyAddress.Address, Type);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSplineType_FunctionAddress, intPtr, SetSplineType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:SetSplineThickness")]
	public unsafe void SetSplineThickness(float Thickness)
	{
		CheckDestroyed();
		if (!SetSplineThickness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:SetSplineThickness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplineThickness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplineThickness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSplineThickness_Thickness_Offset), 0, SetSplineThickness_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSplineThickness_FunctionAddress, intPtr, SetSplineThickness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:SetSplineMaterial")]
	public unsafe void SetSplineMaterial(UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetSplineMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:SetSplineMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplineMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplineMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetSplineMaterial_Material_Offset), 0, SetSplineMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSplineMaterial_FunctionAddress, intPtr, SetSplineMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:RemoveSplinePoint")]
	public unsafe void RemoveSplinePoint(int Index, bool bUpdateSpline)
	{
		CheckDestroyed();
		if (!RemoveSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:RemoveSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveSplinePoint_Index_Offset), 0, RemoveSplinePoint_Index_PropertyAddress.Address, Index);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveSplinePoint_bUpdateSpline_Offset), 0, RemoveSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSplinePoint_FunctionAddress, intPtr, RemoveSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:RemoveAllSplinePoint")]
	public unsafe void RemoveAllSplinePoint(bool bUpdateSpline)
	{
		CheckDestroyed();
		if (!RemoveAllSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:RemoveAllSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllSplinePoint_bUpdateSpline_Offset), 0, RemoveAllSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllSplinePoint_FunctionAddress, intPtr, RemoveAllSplinePoint_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetTangentAtSplinePoint")]
	public unsafe FVector2D GetTangentAtSplinePoint(int PointIndex, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetTangentAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetTangentAtSplinePoint");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplinePoint_PointIndex_Offset), 0, GetTangentAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplinePoint_CoordinateSpace_Offset), 0, GetTangentAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentAtSplinePoint_FunctionAddress, intPtr, GetTangentAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetTangentAtSplinePoint_ReturnValue_Offset), 0, GetTangentAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetTangentAtSplineInputKey")]
	public unsafe FVector2D GetTangentAtSplineInputKey(float InKey, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetTangentAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetTangentAtSplineInputKey");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplineInputKey_InKey_Offset), 0, GetTangentAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTangentAtSplineInputKey_CoordinateSpace_Offset), 0, GetTangentAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentAtSplineInputKey_FunctionAddress, intPtr, GetTangentAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetTangentAtSplineInputKey_ReturnValue_Offset), 0, GetTangentAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetTangentAtDistanceAlongSpline")]
	public unsafe FVector2D GetTangentAtDistanceAlongSpline(float Distance, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetTangentAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetTangentAtDistanceAlongSpline");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTangentAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTangentAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetTangentAtDistanceAlongSpline_Distance_Offset), 0, GetTangentAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetTangentAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetTangentAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTangentAtDistanceAlongSpline_FunctionAddress, intPtr, GetTangentAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetTangentAtDistanceAlongSpline_ReturnValue_Offset), 0, GetTangentAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetSplineType")]
	public unsafe EUMGSplineType GetSplineType()
	{
		CheckDestroyed();
		if (!GetSplineType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetSplineType");
			return EUMGSplineType.Linear;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineType_FunctionAddress, intPtr, GetSplineType_ParamsSize);
		return EnumMarshaler<EUMGSplineType>.FromNative(IntPtr.Add(intPtr, GetSplineType_ReturnValue_Offset), 0, GetSplineType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetSplineThickness")]
	public unsafe float GetSplineThickness()
	{
		CheckDestroyed();
		if (!GetSplineThickness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetSplineThickness");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineThickness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineThickness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineThickness_FunctionAddress, intPtr, GetSplineThickness_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSplineThickness_ReturnValue_Offset), 0, GetSplineThickness_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetSplineMaterial")]
	public unsafe UMaterialInterface GetSplineMaterial()
	{
		CheckDestroyed();
		if (!GetSplineMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetSplineMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineMaterial_FunctionAddress, intPtr, GetSplineMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetSplineMaterial_ReturnValue_Offset), 0, GetSplineMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetSplineLength")]
	public unsafe float GetSplineLength()
	{
		CheckDestroyed();
		if (!GetSplineLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetSplineLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineLength_FunctionAddress, intPtr, GetSplineLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSplineLength_ReturnValue_Offset), 0, GetSplineLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetSplineDynamicMaterial")]
	public unsafe UMaterialInstanceDynamic GetSplineDynamicMaterial()
	{
		CheckDestroyed();
		if (!GetSplineDynamicMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetSplineDynamicMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineDynamicMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineDynamicMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineDynamicMaterial_FunctionAddress, intPtr, GetSplineDynamicMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetSplineDynamicMaterial_ReturnValue_Offset), 0, GetSplineDynamicMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetRotationAngleAtSplineInputKey")]
	public unsafe float GetRotationAngleAtSplineInputKey(float InKey, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRotationAngleAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetRotationAngleAtSplineInputKey");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationAngleAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationAngleAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRotationAngleAtSplineInputKey_InKey_Offset), 0, GetRotationAngleAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRotationAngleAtSplineInputKey_CoordinateSpace_Offset), 0, GetRotationAngleAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationAngleAtSplineInputKey_FunctionAddress, intPtr, GetRotationAngleAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRotationAngleAtSplineInputKey_ReturnValue_Offset), 0, GetRotationAngleAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetRotationAngleAtDistanceAlongSpline")]
	public unsafe float GetRotationAngleAtDistanceAlongSpline(float Distance, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetRotationAngleAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetRotationAngleAtDistanceAlongSpline");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationAngleAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationAngleAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRotationAngleAtDistanceAlongSpline_Distance_Offset), 0, GetRotationAngleAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationAngleAtDistanceAlongSpline_FunctionAddress, intPtr, GetRotationAngleAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRotationAngleAtDistanceAlongSpline_ReturnValue_Offset), 0, GetRotationAngleAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetNumberOfSplinePoints")]
	public unsafe int GetNumberOfSplinePoints()
	{
		CheckDestroyed();
		if (!GetNumberOfSplinePoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetNumberOfSplinePoints");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfSplinePoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfSplinePoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfSplinePoints_FunctionAddress, intPtr, GetNumberOfSplinePoints_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfSplinePoints_ReturnValue_Offset), 0, GetNumberOfSplinePoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetLocationAtSplinePoint")]
	public unsafe FVector2D GetLocationAtSplinePoint(int PointIndex, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLocationAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetLocationAtSplinePoint");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplinePoint_PointIndex_Offset), 0, GetLocationAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplinePoint_CoordinateSpace_Offset), 0, GetLocationAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAtSplinePoint_FunctionAddress, intPtr, GetLocationAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetLocationAtSplinePoint_ReturnValue_Offset), 0, GetLocationAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetLocationAtSplineInputKey")]
	public unsafe FVector2D GetLocationAtSplineInputKey(float InKey, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLocationAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetLocationAtSplineInputKey");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplineInputKey_InKey_Offset), 0, GetLocationAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAtSplineInputKey_CoordinateSpace_Offset), 0, GetLocationAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAtSplineInputKey_FunctionAddress, intPtr, GetLocationAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetLocationAtSplineInputKey_ReturnValue_Offset), 0, GetLocationAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetLocationAtDistanceAlongSpline")]
	public unsafe FVector2D GetLocationAtDistanceAlongSpline(float Distance, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetLocationAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetLocationAtDistanceAlongSpline");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocationAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocationAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLocationAtDistanceAlongSpline_Distance_Offset), 0, GetLocationAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetLocationAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetLocationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocationAtDistanceAlongSpline_FunctionAddress, intPtr, GetLocationAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetLocationAtDistanceAlongSpline_ReturnValue_Offset), 0, GetLocationAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetInputKeyAtDistanceAlongSpline")]
	public unsafe float GetInputKeyAtDistanceAlongSpline(float Distance, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetInputKeyAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetInputKeyAtDistanceAlongSpline");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputKeyAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputKeyAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetInputKeyAtDistanceAlongSpline_Distance_Offset), 0, GetInputKeyAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetInputKeyAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetInputKeyAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputKeyAtDistanceAlongSpline_FunctionAddress, intPtr, GetInputKeyAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputKeyAtDistanceAlongSpline_ReturnValue_Offset), 0, GetInputKeyAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetDistanceAlongSplineAtSplineInputKey")]
	public unsafe float GetDistanceAlongSplineAtSplineInputKey(float InKey)
	{
		CheckDestroyed();
		if (!GetDistanceAlongSplineAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetDistanceAlongSplineAtSplineInputKey");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDistanceAlongSplineAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDistanceAlongSplineAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDistanceAlongSplineAtSplineInputKey_InKey_Offset), 0, GetDistanceAlongSplineAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, intPtr, GetDistanceAlongSplineAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDistanceAlongSplineAtSplineInputKey_ReturnValue_Offset), 0, GetDistanceAlongSplineAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetDirectionAtSplinePoint")]
	public unsafe FVector2D GetDirectionAtSplinePoint(int PointIndex, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetDirectionAtSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetDirectionAtSplinePoint");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectionAtSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectionAtSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplinePoint_PointIndex_Offset), 0, GetDirectionAtSplinePoint_PointIndex_PropertyAddress.Address, PointIndex);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplinePoint_CoordinateSpace_Offset), 0, GetDirectionAtSplinePoint_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDirectionAtSplinePoint_FunctionAddress, intPtr, GetDirectionAtSplinePoint_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetDirectionAtSplinePoint_ReturnValue_Offset), 0, GetDirectionAtSplinePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetDirectionAtSplineInputKey")]
	public unsafe FVector2D GetDirectionAtSplineInputKey(float InKey, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetDirectionAtSplineInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetDirectionAtSplineInputKey");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectionAtSplineInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectionAtSplineInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplineInputKey_InKey_Offset), 0, GetDirectionAtSplineInputKey_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDirectionAtSplineInputKey_CoordinateSpace_Offset), 0, GetDirectionAtSplineInputKey_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDirectionAtSplineInputKey_FunctionAddress, intPtr, GetDirectionAtSplineInputKey_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetDirectionAtSplineInputKey_ReturnValue_Offset), 0, GetDirectionAtSplineInputKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:GetDirectionAtDistanceAlongSpline")]
	public unsafe FVector2D GetDirectionAtDistanceAlongSpline(float Distance, EUMGSplineCoordinateSpace CoordinateSpace)
	{
		CheckDestroyed();
		if (!GetDirectionAtDistanceAlongSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:GetDirectionAtDistanceAlongSpline");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectionAtDistanceAlongSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectionAtDistanceAlongSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDirectionAtDistanceAlongSpline_Distance_Offset), 0, GetDirectionAtDistanceAlongSpline_Distance_PropertyAddress.Address, Distance);
		EnumMarshaler<EUMGSplineCoordinateSpace>.ToNative(IntPtr.Add(intPtr, GetDirectionAtDistanceAlongSpline_CoordinateSpace_Offset), 0, GetDirectionAtDistanceAlongSpline_CoordinateSpace_PropertyAddress.Address, CoordinateSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDirectionAtDistanceAlongSpline_FunctionAddress, intPtr, GetDirectionAtDistanceAlongSpline_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetDirectionAtDistanceAlongSpline_ReturnValue_Offset), 0, GetDirectionAtDistanceAlongSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:ChangeSplinePointAtIndex")]
	public unsafe void ChangeSplinePointAtIndex(FUMGSplinePoint SplinePoint, int Index, bool bUpdateSpline)
	{
		CheckDestroyed();
		if (!ChangeSplinePointAtIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:ChangeSplinePointAtIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeSplinePointAtIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeSplinePointAtIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ChangeSplinePointAtIndex_SplinePoint_PropertyAddress.Address, intPtr);
		FUMGSplinePoint.ToNative(IntPtr.Add(intPtr, ChangeSplinePointAtIndex_SplinePoint_Offset), 0, ChangeSplinePointAtIndex_SplinePoint_PropertyAddress.Address, SplinePoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ChangeSplinePointAtIndex_Index_Offset), 0, ChangeSplinePointAtIndex_Index_PropertyAddress.Address, Index);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeSplinePointAtIndex_bUpdateSpline_Offset), 0, ChangeSplinePointAtIndex_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChangeSplinePointAtIndex_FunctionAddress, intPtr, ChangeSplinePointAtIndex_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:AddSplinePointAtIndex")]
	public unsafe void AddSplinePointAtIndex(FUMGSplinePoint SplinePoint, int Index, bool bUpdateSpline)
	{
		CheckDestroyed();
		if (!AddSplinePointAtIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:AddSplinePointAtIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSplinePointAtIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSplinePointAtIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddSplinePointAtIndex_SplinePoint_PropertyAddress.Address, intPtr);
		FUMGSplinePoint.ToNative(IntPtr.Add(intPtr, AddSplinePointAtIndex_SplinePoint_Offset), 0, AddSplinePointAtIndex_SplinePoint_PropertyAddress.Address, SplinePoint);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddSplinePointAtIndex_Index_Offset), 0, AddSplinePointAtIndex_Index_PropertyAddress.Address, Index);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSplinePointAtIndex_bUpdateSpline_Offset), 0, AddSplinePointAtIndex_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSplinePointAtIndex_FunctionAddress, intPtr, AddSplinePointAtIndex_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMGSpline.SplineWidget:AddSplinePoint")]
	public unsafe void AddSplinePoint(FUMGSplinePoint SplinePoint, bool bUpdateSpline)
	{
		CheckDestroyed();
		if (!AddSplinePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGSpline.SplineWidget:AddSplinePoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSplinePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSplinePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddSplinePoint_SplinePoint_PropertyAddress.Address, intPtr);
		FUMGSplinePoint.ToNative(IntPtr.Add(intPtr, AddSplinePoint_SplinePoint_Offset), 0, AddSplinePoint_SplinePoint_PropertyAddress.Address, SplinePoint);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSplinePoint_bUpdateSpline_Offset), 0, AddSplinePoint_bUpdateSpline_PropertyAddress.Address, bUpdateSpline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSplinePoint_FunctionAddress, intPtr, AddSplinePoint_ParamsSize);
	}

	static USplineWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USplineWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USplineWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMGSpline.SplineWidget");
		SplineInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SplineInfo");
		SplineInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SplineInfo", Classes.FStructProperty);
		SplineDebugInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SplineDebugInfo");
		SplineDebugInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SplineDebugInfo", Classes.FStructProperty);
		UpdateSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSpline");
		UpdateSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSpline_FunctionAddress);
		UpdateSpline_IsValid = UpdateSpline_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:UpdateSpline", UpdateSpline_IsValid);
		SetSplineType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSplineType");
		SetSplineType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplineType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplineType_Type_PropertyAddress, SetSplineType_FunctionAddress, "Type");
		SetSplineType_Type_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineType_FunctionAddress, "Type");
		SetSplineType_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineType_FunctionAddress, "Type", Classes.FEnumProperty);
		SetSplineType_IsValid = SetSplineType_FunctionAddress != IntPtr.Zero && SetSplineType_Type_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:SetSplineType", SetSplineType_IsValid);
		SetSplineThickness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSplineThickness");
		SetSplineThickness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplineThickness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplineThickness_Thickness_PropertyAddress, SetSplineThickness_FunctionAddress, "Thickness");
		SetSplineThickness_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineThickness_FunctionAddress, "Thickness");
		SetSplineThickness_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineThickness_FunctionAddress, "Thickness", Classes.FFloatProperty);
		SetSplineThickness_IsValid = SetSplineThickness_FunctionAddress != IntPtr.Zero && SetSplineThickness_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:SetSplineThickness", SetSplineThickness_IsValid);
		SetSplineMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSplineMaterial");
		SetSplineMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplineMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplineMaterial_Material_PropertyAddress, SetSplineMaterial_FunctionAddress, "Material");
		SetSplineMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineMaterial_FunctionAddress, "Material");
		SetSplineMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetSplineMaterial_IsValid = SetSplineMaterial_FunctionAddress != IntPtr.Zero && SetSplineMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:SetSplineMaterial", SetSplineMaterial_IsValid);
		RemoveSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveSplinePoint");
		RemoveSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSplinePoint_Index_PropertyAddress, RemoveSplinePoint_FunctionAddress, "Index");
		RemoveSplinePoint_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSplinePoint_FunctionAddress, "Index");
		RemoveSplinePoint_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSplinePoint_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSplinePoint_bUpdateSpline_PropertyAddress, RemoveSplinePoint_FunctionAddress, "bUpdateSpline");
		RemoveSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSplinePoint_FunctionAddress, "bUpdateSpline");
		RemoveSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		RemoveSplinePoint_IsValid = RemoveSplinePoint_FunctionAddress != IntPtr.Zero && RemoveSplinePoint_Index_IsValid && RemoveSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:RemoveSplinePoint", RemoveSplinePoint_IsValid);
		RemoveAllSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveAllSplinePoint");
		RemoveAllSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllSplinePoint_bUpdateSpline_PropertyAddress, RemoveAllSplinePoint_FunctionAddress, "bUpdateSpline");
		RemoveAllSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllSplinePoint_FunctionAddress, "bUpdateSpline");
		RemoveAllSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		RemoveAllSplinePoint_IsValid = RemoveAllSplinePoint_FunctionAddress != IntPtr.Zero && RemoveAllSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:RemoveAllSplinePoint", RemoveAllSplinePoint_IsValid);
		GetTangentAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentAtSplinePoint");
		GetTangentAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplinePoint_PointIndex_PropertyAddress, GetTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetTangentAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplinePoint_FunctionAddress, "PointIndex");
		GetTangentAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplinePoint_CoordinateSpace_PropertyAddress, GetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplinePoint_ReturnValue_PropertyAddress, GetTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetTangentAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplinePoint_FunctionAddress, "ReturnValue");
		GetTangentAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTangentAtSplinePoint_IsValid = GetTangentAtSplinePoint_FunctionAddress != IntPtr.Zero && GetTangentAtSplinePoint_PointIndex_IsValid && GetTangentAtSplinePoint_CoordinateSpace_IsValid && GetTangentAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetTangentAtSplinePoint", GetTangentAtSplinePoint_IsValid);
		GetTangentAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentAtSplineInputKey");
		GetTangentAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplineInputKey_InKey_PropertyAddress, GetTangentAtSplineInputKey_FunctionAddress, "InKey");
		GetTangentAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplineInputKey_FunctionAddress, "InKey");
		GetTangentAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplineInputKey_CoordinateSpace_PropertyAddress, GetTangentAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetTangentAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtSplineInputKey_ReturnValue_PropertyAddress, GetTangentAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetTangentAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetTangentAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTangentAtSplineInputKey_IsValid = GetTangentAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetTangentAtSplineInputKey_InKey_IsValid && GetTangentAtSplineInputKey_CoordinateSpace_IsValid && GetTangentAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetTangentAtSplineInputKey", GetTangentAtSplineInputKey_IsValid);
		GetTangentAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTangentAtDistanceAlongSpline");
		GetTangentAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTangentAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtDistanceAlongSpline_Distance_PropertyAddress, GetTangentAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetTangentAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetTangentAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetTangentAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetTangentAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetTangentAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTangentAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetTangentAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetTangentAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTangentAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetTangentAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTangentAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTangentAtDistanceAlongSpline_IsValid = GetTangentAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetTangentAtDistanceAlongSpline_Distance_IsValid && GetTangentAtDistanceAlongSpline_CoordinateSpace_IsValid && GetTangentAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetTangentAtDistanceAlongSpline", GetTangentAtDistanceAlongSpline_IsValid);
		GetSplineType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSplineType");
		GetSplineType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineType_ReturnValue_PropertyAddress, GetSplineType_FunctionAddress, "ReturnValue");
		GetSplineType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineType_FunctionAddress, "ReturnValue");
		GetSplineType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetSplineType_IsValid = GetSplineType_FunctionAddress != IntPtr.Zero && GetSplineType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetSplineType", GetSplineType_IsValid);
		GetSplineThickness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSplineThickness");
		GetSplineThickness_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineThickness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineThickness_ReturnValue_PropertyAddress, GetSplineThickness_FunctionAddress, "ReturnValue");
		GetSplineThickness_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineThickness_FunctionAddress, "ReturnValue");
		GetSplineThickness_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineThickness_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSplineThickness_IsValid = GetSplineThickness_FunctionAddress != IntPtr.Zero && GetSplineThickness_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetSplineThickness", GetSplineThickness_IsValid);
		GetSplineMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSplineMaterial");
		GetSplineMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineMaterial_ReturnValue_PropertyAddress, GetSplineMaterial_FunctionAddress, "ReturnValue");
		GetSplineMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineMaterial_FunctionAddress, "ReturnValue");
		GetSplineMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSplineMaterial_IsValid = GetSplineMaterial_FunctionAddress != IntPtr.Zero && GetSplineMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetSplineMaterial", GetSplineMaterial_IsValid);
		GetSplineLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSplineLength");
		GetSplineLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineLength_ReturnValue_PropertyAddress, GetSplineLength_FunctionAddress, "ReturnValue");
		GetSplineLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineLength_FunctionAddress, "ReturnValue");
		GetSplineLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSplineLength_IsValid = GetSplineLength_FunctionAddress != IntPtr.Zero && GetSplineLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetSplineLength", GetSplineLength_IsValid);
		GetSplineDynamicMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSplineDynamicMaterial");
		GetSplineDynamicMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineDynamicMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineDynamicMaterial_ReturnValue_PropertyAddress, GetSplineDynamicMaterial_FunctionAddress, "ReturnValue");
		GetSplineDynamicMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineDynamicMaterial_FunctionAddress, "ReturnValue");
		GetSplineDynamicMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineDynamicMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSplineDynamicMaterial_IsValid = GetSplineDynamicMaterial_FunctionAddress != IntPtr.Zero && GetSplineDynamicMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetSplineDynamicMaterial", GetSplineDynamicMaterial_IsValid);
		GetRotationAngleAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRotationAngleAtSplineInputKey");
		GetRotationAngleAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationAngleAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAngleAtSplineInputKey_InKey_PropertyAddress, GetRotationAngleAtSplineInputKey_FunctionAddress, "InKey");
		GetRotationAngleAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAngleAtSplineInputKey_FunctionAddress, "InKey");
		GetRotationAngleAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAngleAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAngleAtSplineInputKey_CoordinateSpace_PropertyAddress, GetRotationAngleAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRotationAngleAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAngleAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetRotationAngleAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAngleAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAngleAtSplineInputKey_ReturnValue_PropertyAddress, GetRotationAngleAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRotationAngleAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAngleAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetRotationAngleAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAngleAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRotationAngleAtSplineInputKey_IsValid = GetRotationAngleAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetRotationAngleAtSplineInputKey_InKey_IsValid && GetRotationAngleAtSplineInputKey_CoordinateSpace_IsValid && GetRotationAngleAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetRotationAngleAtSplineInputKey", GetRotationAngleAtSplineInputKey_IsValid);
		GetRotationAngleAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRotationAngleAtDistanceAlongSpline");
		GetRotationAngleAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationAngleAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAngleAtDistanceAlongSpline_Distance_PropertyAddress, GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRotationAngleAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetRotationAngleAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationAngleAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRotationAngleAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetRotationAngleAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationAngleAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRotationAngleAtDistanceAlongSpline_IsValid = GetRotationAngleAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetRotationAngleAtDistanceAlongSpline_Distance_IsValid && GetRotationAngleAtDistanceAlongSpline_CoordinateSpace_IsValid && GetRotationAngleAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetRotationAngleAtDistanceAlongSpline", GetRotationAngleAtDistanceAlongSpline_IsValid);
		GetNumberOfSplinePoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumberOfSplinePoints");
		GetNumberOfSplinePoints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfSplinePoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfSplinePoints_ReturnValue_PropertyAddress, GetNumberOfSplinePoints_FunctionAddress, "ReturnValue");
		GetNumberOfSplinePoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfSplinePoints_FunctionAddress, "ReturnValue");
		GetNumberOfSplinePoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfSplinePoints_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfSplinePoints_IsValid = GetNumberOfSplinePoints_FunctionAddress != IntPtr.Zero && GetNumberOfSplinePoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetNumberOfSplinePoints", GetNumberOfSplinePoints_IsValid);
		GetLocationAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAtSplinePoint");
		GetLocationAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplinePoint_PointIndex_PropertyAddress, GetLocationAtSplinePoint_FunctionAddress, "PointIndex");
		GetLocationAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplinePoint_FunctionAddress, "PointIndex");
		GetLocationAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplinePoint_CoordinateSpace_PropertyAddress, GetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplinePoint_ReturnValue_PropertyAddress, GetLocationAtSplinePoint_FunctionAddress, "ReturnValue");
		GetLocationAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplinePoint_FunctionAddress, "ReturnValue");
		GetLocationAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocationAtSplinePoint_IsValid = GetLocationAtSplinePoint_FunctionAddress != IntPtr.Zero && GetLocationAtSplinePoint_PointIndex_IsValid && GetLocationAtSplinePoint_CoordinateSpace_IsValid && GetLocationAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetLocationAtSplinePoint", GetLocationAtSplinePoint_IsValid);
		GetLocationAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAtSplineInputKey");
		GetLocationAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplineInputKey_InKey_PropertyAddress, GetLocationAtSplineInputKey_FunctionAddress, "InKey");
		GetLocationAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplineInputKey_FunctionAddress, "InKey");
		GetLocationAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplineInputKey_CoordinateSpace_PropertyAddress, GetLocationAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetLocationAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtSplineInputKey_ReturnValue_PropertyAddress, GetLocationAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetLocationAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetLocationAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocationAtSplineInputKey_IsValid = GetLocationAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetLocationAtSplineInputKey_InKey_IsValid && GetLocationAtSplineInputKey_CoordinateSpace_IsValid && GetLocationAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetLocationAtSplineInputKey", GetLocationAtSplineInputKey_IsValid);
		GetLocationAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocationAtDistanceAlongSpline");
		GetLocationAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocationAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtDistanceAlongSpline_Distance_PropertyAddress, GetLocationAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetLocationAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetLocationAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetLocationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetLocationAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetLocationAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocationAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetLocationAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetLocationAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocationAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetLocationAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocationAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocationAtDistanceAlongSpline_IsValid = GetLocationAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetLocationAtDistanceAlongSpline_Distance_IsValid && GetLocationAtDistanceAlongSpline_CoordinateSpace_IsValid && GetLocationAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetLocationAtDistanceAlongSpline", GetLocationAtDistanceAlongSpline_IsValid);
		GetInputKeyAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputKeyAtDistanceAlongSpline");
		GetInputKeyAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputKeyAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputKeyAtDistanceAlongSpline_Distance_PropertyAddress, GetInputKeyAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetInputKeyAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetInputKeyAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputKeyAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetInputKeyAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetInputKeyAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetInputKeyAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputKeyAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetInputKeyAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetInputKeyAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetInputKeyAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKeyAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetInputKeyAtDistanceAlongSpline_IsValid = GetInputKeyAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetInputKeyAtDistanceAlongSpline_Distance_IsValid && GetInputKeyAtDistanceAlongSpline_CoordinateSpace_IsValid && GetInputKeyAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetInputKeyAtDistanceAlongSpline", GetInputKeyAtDistanceAlongSpline_IsValid);
		GetDistanceAlongSplineAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDistanceAlongSplineAtSplineInputKey");
		GetDistanceAlongSplineAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceAlongSplineAtSplineInputKey_InKey_PropertyAddress, GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "InKey");
		GetDistanceAlongSplineAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "InKey");
		GetDistanceAlongSplineAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceAlongSplineAtSplineInputKey_ReturnValue_PropertyAddress, GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDistanceAlongSplineAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDistanceAlongSplineAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceAlongSplineAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDistanceAlongSplineAtSplineInputKey_IsValid = GetDistanceAlongSplineAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetDistanceAlongSplineAtSplineInputKey_InKey_IsValid && GetDistanceAlongSplineAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetDistanceAlongSplineAtSplineInputKey", GetDistanceAlongSplineAtSplineInputKey_IsValid);
		GetDirectionAtSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDirectionAtSplinePoint");
		GetDirectionAtSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectionAtSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplinePoint_PointIndex_PropertyAddress, GetDirectionAtSplinePoint_FunctionAddress, "PointIndex");
		GetDirectionAtSplinePoint_PointIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplinePoint_FunctionAddress, "PointIndex");
		GetDirectionAtSplinePoint_PointIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplinePoint_FunctionAddress, "PointIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplinePoint_CoordinateSpace_PropertyAddress, GetDirectionAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplinePoint_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplinePoint_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplinePoint_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplinePoint_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplinePoint_ReturnValue_PropertyAddress, GetDirectionAtSplinePoint_FunctionAddress, "ReturnValue");
		GetDirectionAtSplinePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplinePoint_FunctionAddress, "ReturnValue");
		GetDirectionAtSplinePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplinePoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirectionAtSplinePoint_IsValid = GetDirectionAtSplinePoint_FunctionAddress != IntPtr.Zero && GetDirectionAtSplinePoint_PointIndex_IsValid && GetDirectionAtSplinePoint_CoordinateSpace_IsValid && GetDirectionAtSplinePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetDirectionAtSplinePoint", GetDirectionAtSplinePoint_IsValid);
		GetDirectionAtSplineInputKey_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDirectionAtSplineInputKey");
		GetDirectionAtSplineInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectionAtSplineInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplineInputKey_InKey_PropertyAddress, GetDirectionAtSplineInputKey_FunctionAddress, "InKey");
		GetDirectionAtSplineInputKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplineInputKey_FunctionAddress, "InKey");
		GetDirectionAtSplineInputKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplineInputKey_FunctionAddress, "InKey", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplineInputKey_CoordinateSpace_PropertyAddress, GetDirectionAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplineInputKey_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplineInputKey_FunctionAddress, "CoordinateSpace");
		GetDirectionAtSplineInputKey_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplineInputKey_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtSplineInputKey_ReturnValue_PropertyAddress, GetDirectionAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDirectionAtSplineInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtSplineInputKey_FunctionAddress, "ReturnValue");
		GetDirectionAtSplineInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtSplineInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirectionAtSplineInputKey_IsValid = GetDirectionAtSplineInputKey_FunctionAddress != IntPtr.Zero && GetDirectionAtSplineInputKey_InKey_IsValid && GetDirectionAtSplineInputKey_CoordinateSpace_IsValid && GetDirectionAtSplineInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetDirectionAtSplineInputKey", GetDirectionAtSplineInputKey_IsValid);
		GetDirectionAtDistanceAlongSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDirectionAtDistanceAlongSpline");
		GetDirectionAtDistanceAlongSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectionAtDistanceAlongSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtDistanceAlongSpline_Distance_PropertyAddress, GetDirectionAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetDirectionAtDistanceAlongSpline_Distance_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtDistanceAlongSpline_FunctionAddress, "Distance");
		GetDirectionAtDistanceAlongSpline_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtDistanceAlongSpline_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtDistanceAlongSpline_CoordinateSpace_PropertyAddress, GetDirectionAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetDirectionAtDistanceAlongSpline_CoordinateSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace");
		GetDirectionAtDistanceAlongSpline_CoordinateSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtDistanceAlongSpline_FunctionAddress, "CoordinateSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectionAtDistanceAlongSpline_ReturnValue_PropertyAddress, GetDirectionAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetDirectionAtDistanceAlongSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectionAtDistanceAlongSpline_FunctionAddress, "ReturnValue");
		GetDirectionAtDistanceAlongSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectionAtDistanceAlongSpline_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirectionAtDistanceAlongSpline_IsValid = GetDirectionAtDistanceAlongSpline_FunctionAddress != IntPtr.Zero && GetDirectionAtDistanceAlongSpline_Distance_IsValid && GetDirectionAtDistanceAlongSpline_CoordinateSpace_IsValid && GetDirectionAtDistanceAlongSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:GetDirectionAtDistanceAlongSpline", GetDirectionAtDistanceAlongSpline_IsValid);
		ChangeSplinePointAtIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangeSplinePointAtIndex");
		ChangeSplinePointAtIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeSplinePointAtIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeSplinePointAtIndex_SplinePoint_PropertyAddress, ChangeSplinePointAtIndex_FunctionAddress, "SplinePoint");
		ChangeSplinePointAtIndex_SplinePoint_Offset = NativeReflectionCached.GetPropertyOffset(ChangeSplinePointAtIndex_FunctionAddress, "SplinePoint");
		ChangeSplinePointAtIndex_SplinePoint_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeSplinePointAtIndex_FunctionAddress, "SplinePoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeSplinePointAtIndex_Index_PropertyAddress, ChangeSplinePointAtIndex_FunctionAddress, "Index");
		ChangeSplinePointAtIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(ChangeSplinePointAtIndex_FunctionAddress, "Index");
		ChangeSplinePointAtIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeSplinePointAtIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeSplinePointAtIndex_bUpdateSpline_PropertyAddress, ChangeSplinePointAtIndex_FunctionAddress, "bUpdateSpline");
		ChangeSplinePointAtIndex_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(ChangeSplinePointAtIndex_FunctionAddress, "bUpdateSpline");
		ChangeSplinePointAtIndex_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeSplinePointAtIndex_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		ChangeSplinePointAtIndex_IsValid = ChangeSplinePointAtIndex_FunctionAddress != IntPtr.Zero && ChangeSplinePointAtIndex_SplinePoint_IsValid && ChangeSplinePointAtIndex_Index_IsValid && ChangeSplinePointAtIndex_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:ChangeSplinePointAtIndex", ChangeSplinePointAtIndex_IsValid);
		AddSplinePointAtIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSplinePointAtIndex");
		AddSplinePointAtIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSplinePointAtIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePointAtIndex_SplinePoint_PropertyAddress, AddSplinePointAtIndex_FunctionAddress, "SplinePoint");
		AddSplinePointAtIndex_SplinePoint_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePointAtIndex_FunctionAddress, "SplinePoint");
		AddSplinePointAtIndex_SplinePoint_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePointAtIndex_FunctionAddress, "SplinePoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePointAtIndex_Index_PropertyAddress, AddSplinePointAtIndex_FunctionAddress, "Index");
		AddSplinePointAtIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePointAtIndex_FunctionAddress, "Index");
		AddSplinePointAtIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePointAtIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePointAtIndex_bUpdateSpline_PropertyAddress, AddSplinePointAtIndex_FunctionAddress, "bUpdateSpline");
		AddSplinePointAtIndex_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePointAtIndex_FunctionAddress, "bUpdateSpline");
		AddSplinePointAtIndex_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePointAtIndex_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		AddSplinePointAtIndex_IsValid = AddSplinePointAtIndex_FunctionAddress != IntPtr.Zero && AddSplinePointAtIndex_SplinePoint_IsValid && AddSplinePointAtIndex_Index_IsValid && AddSplinePointAtIndex_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:AddSplinePointAtIndex", AddSplinePointAtIndex_IsValid);
		AddSplinePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSplinePoint");
		AddSplinePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSplinePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePoint_SplinePoint_PropertyAddress, AddSplinePoint_FunctionAddress, "SplinePoint");
		AddSplinePoint_SplinePoint_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePoint_FunctionAddress, "SplinePoint");
		AddSplinePoint_SplinePoint_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePoint_FunctionAddress, "SplinePoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSplinePoint_bUpdateSpline_PropertyAddress, AddSplinePoint_FunctionAddress, "bUpdateSpline");
		AddSplinePoint_bUpdateSpline_Offset = NativeReflectionCached.GetPropertyOffset(AddSplinePoint_FunctionAddress, "bUpdateSpline");
		AddSplinePoint_bUpdateSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSplinePoint_FunctionAddress, "bUpdateSpline", Classes.FBoolProperty);
		AddSplinePoint_IsValid = AddSplinePoint_FunctionAddress != IntPtr.Zero && AddSplinePoint_SplinePoint_IsValid && AddSplinePoint_bUpdateSpline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGSpline.SplineWidget:AddSplinePoint", AddSplinePoint_IsValid);
	}
}
