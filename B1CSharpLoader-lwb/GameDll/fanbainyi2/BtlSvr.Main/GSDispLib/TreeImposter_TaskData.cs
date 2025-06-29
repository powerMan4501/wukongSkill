using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TreeImposter_TaskData")]
public struct TreeImposter_TaskData
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:TreeMeshAsset")]
	public UStaticMesh TreeMeshAsset;

	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:BakeLOD")]
	public int BakeLOD;

	[UMeta(MDProp.MakeStructureDefaultValue, 1.065f)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:CardMicoScale")]
	public float CardMicoScale;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:CardPairCount")]
	public int CardPairCount;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:CaptureRTSize")]
	public int CaptureRTSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:ShotTextureSize")]
	public int ShotTextureSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:TrunkMaskThreshold")]
	public float TrunkMaskThreshold;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TreeImposter_TaskData:LeafMaskThreshold")]
	public float LeafMaskThreshold;

	private static int TreeImposter_TaskData_StructSize;

	private static int TreeImposter_TaskData_IsValid;

	private static bool TreeMeshAsset_IsValid;

	private static int TreeMeshAsset_Offset;

	private static bool BakeLOD_IsValid;

	private static int BakeLOD_Offset;

	private static bool CardMicoScale_IsValid;

	private static int CardMicoScale_Offset;

	private static bool CardPairCount_IsValid;

	private static int CardPairCount_Offset;

	private static bool CaptureRTSize_IsValid;

	private static int CaptureRTSize_Offset;

	private static bool ShotTextureSize_IsValid;

	private static int ShotTextureSize_Offset;

	private static bool TrunkMaskThreshold_IsValid;

	private static int TrunkMaskThreshold_Offset;

	private static bool LeafMaskThreshold_IsValid;

	private static int LeafMaskThreshold_Offset;

	public TreeImposter_TaskData(UStaticMesh _TreeMeshAsset = null, int _BakeLOD = 0, float _CardMicoScale = 1.065f, int _CardPairCount = 4, int _CaptureRTSize = 256, int _ShotTextureSize = 256, float _TrunkMaskThreshold = 0.9f, float _LeafMaskThreshold = 0.175f)
	{
		TreeMeshAsset = _TreeMeshAsset;
		BakeLOD = _BakeLOD;
		CardMicoScale = _CardMicoScale;
		CardPairCount = _CardPairCount;
		CaptureRTSize = _CaptureRTSize;
		ShotTextureSize = _ShotTextureSize;
		TrunkMaskThreshold = _TrunkMaskThreshold;
		LeafMaskThreshold = _LeafMaskThreshold;
	}

	public TreeImposter_TaskData Copy()
	{
		return this;
	}

	public static TreeImposter_TaskData FromNative(IntPtr nativeBuffer)
	{
		return new TreeImposter_TaskData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TreeImposter_TaskData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TreeImposter_TaskData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TreeImposter_TaskData(IntPtr.Add(nativeBuffer, arrayIndex * TreeImposter_TaskData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TreeImposter_TaskData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TreeImposter_TaskData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TreeImposter_TaskData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeImposter_TaskData");
			return;
		}
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(nativeStruct, TreeMeshAsset_Offset), TreeMeshAsset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BakeLOD_Offset), BakeLOD);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CardMicoScale_Offset), CardMicoScale);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CardPairCount_Offset), CardPairCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CaptureRTSize_Offset), CaptureRTSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ShotTextureSize_Offset), ShotTextureSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TrunkMaskThreshold_Offset), TrunkMaskThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LeafMaskThreshold_Offset), LeafMaskThreshold);
	}

	public TreeImposter_TaskData(IntPtr nativeStruct)
	{
		if (TreeImposter_TaskData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeImposter_TaskData");
			TreeMeshAsset = null;
			BakeLOD = 0;
			CardMicoScale = 0f;
			CardPairCount = 0;
			CaptureRTSize = 0;
			ShotTextureSize = 0;
			TrunkMaskThreshold = 0f;
			LeafMaskThreshold = 0f;
		}
		else
		{
			TreeMeshAsset = UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(nativeStruct, TreeMeshAsset_Offset));
			BakeLOD = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BakeLOD_Offset));
			CardMicoScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CardMicoScale_Offset));
			CardPairCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CardPairCount_Offset));
			CaptureRTSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CaptureRTSize_Offset));
			ShotTextureSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ShotTextureSize_Offset));
			TrunkMaskThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TrunkMaskThreshold_Offset));
			LeafMaskThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LeafMaskThreshold_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TreeImposter_TaskData");
		TreeImposter_TaskData_StructSize = NativeReflection.GetStructSize(intPtr);
		TreeMeshAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "TreeMeshAsset");
		TreeMeshAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TreeMeshAsset", Classes.FObjectProperty);
		BakeLOD_Offset = NativeReflection.GetPropertyOffset(intPtr, "BakeLOD");
		BakeLOD_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BakeLOD", Classes.FIntProperty);
		CardMicoScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "CardMicoScale");
		CardMicoScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CardMicoScale", Classes.FFloatProperty);
		CardPairCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "CardPairCount");
		CardPairCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CardPairCount", Classes.FIntProperty);
		CaptureRTSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "CaptureRTSize");
		CaptureRTSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CaptureRTSize", Classes.FIntProperty);
		ShotTextureSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShotTextureSize");
		ShotTextureSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShotTextureSize", Classes.FIntProperty);
		TrunkMaskThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "TrunkMaskThreshold");
		TrunkMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TrunkMaskThreshold", Classes.FFloatProperty);
		LeafMaskThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeafMaskThreshold");
		LeafMaskThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeafMaskThreshold", Classes.FFloatProperty);
		TreeImposter_TaskData_IsValid = ((intPtr != IntPtr.Zero && TreeMeshAsset_IsValid && BakeLOD_IsValid && CardMicoScale_IsValid && CardPairCount_IsValid && CaptureRTSize_IsValid && ShotTextureSize_IsValid && TrunkMaskThreshold_IsValid && LeafMaskThreshold_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TreeImposter_TaskData", (byte)TreeImposter_TaskData_IsValid != 0);
	}

	static TreeImposter_TaskData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TreeImposter_TaskData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TreeImposter_TaskData));
	}
}
