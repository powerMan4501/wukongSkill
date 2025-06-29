using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.LandscapeReader", "UnrealExtent", UnrealModuleType.Game)]
public class ULandscapeReader : UObject
{
	private static bool WeightDataElementSize_IsValid;

	private static IntPtr WeightDataElementSize_FunctionAddress;

	private static int WeightDataElementSize_ParamsSize;

	private static bool WeightDataElementSize_ReturnValue_IsValid;

	private static FFieldAddress WeightDataElementSize_ReturnValue_PropertyAddress;

	private static int WeightDataElementSize_ReturnValue_Offset;

	private static bool WeightDataElementNum_IsValid;

	private static IntPtr WeightDataElementNum_FunctionAddress;

	private static int WeightDataElementNum_ParamsSize;

	private static bool WeightDataElementNum_LayerIndex_IsValid;

	private static FFieldAddress WeightDataElementNum_LayerIndex_PropertyAddress;

	private static int WeightDataElementNum_LayerIndex_Offset;

	private static bool WeightDataElementNum_ReturnValue_IsValid;

	private static FFieldAddress WeightDataElementNum_ReturnValue_PropertyAddress;

	private static int WeightDataElementNum_ReturnValue_Offset;

	private static bool SampleWeightData_IsValid;

	private static IntPtr SampleWeightData_FunctionAddress;

	private static int SampleWeightData_ParamsSize;

	private static bool SampleWeightData_worldPos_IsValid;

	private static FFieldAddress SampleWeightData_worldPos_PropertyAddress;

	private static int SampleWeightData_worldPos_Offset;

	private static bool SampleWeightData_LayerIndex_IsValid;

	private static FFieldAddress SampleWeightData_LayerIndex_PropertyAddress;

	private static int SampleWeightData_LayerIndex_Offset;

	private static bool SampleWeightData_SampleType_IsValid;

	private static FFieldAddress SampleWeightData_SampleType_PropertyAddress;

	private static int SampleWeightData_SampleType_Offset;

	private static bool SampleWeightData_ReturnValue_IsValid;

	private static FFieldAddress SampleWeightData_ReturnValue_PropertyAddress;

	private static int SampleWeightData_ReturnValue_Offset;

	private static bool SampleHeightData_IsValid;

	private static IntPtr SampleHeightData_FunctionAddress;

	private static int SampleHeightData_ParamsSize;

	private static bool SampleHeightData_worldPos_IsValid;

	private static FFieldAddress SampleHeightData_worldPos_PropertyAddress;

	private static int SampleHeightData_worldPos_Offset;

	private static bool SampleHeightData_SampleType_IsValid;

	private static FFieldAddress SampleHeightData_SampleType_PropertyAddress;

	private static int SampleHeightData_SampleType_Offset;

	private static bool SampleHeightData_ReturnValue_IsValid;

	private static FFieldAddress SampleHeightData_ReturnValue_PropertyAddress;

	private static int SampleHeightData_ReturnValue_Offset;

	private static bool HeightDataElementSize_IsValid;

	private static IntPtr HeightDataElementSize_FunctionAddress;

	private static int HeightDataElementSize_ParamsSize;

	private static bool HeightDataElementSize_ReturnValue_IsValid;

	private static FFieldAddress HeightDataElementSize_ReturnValue_PropertyAddress;

	private static int HeightDataElementSize_ReturnValue_Offset;

	private static bool HeightDataElementNum_IsValid;

	private static IntPtr HeightDataElementNum_FunctionAddress;

	private static int HeightDataElementNum_ParamsSize;

	private static bool HeightDataElementNum_ReturnValue_IsValid;

	private static FFieldAddress HeightDataElementNum_ReturnValue_PropertyAddress;

	private static int HeightDataElementNum_ReturnValue_Offset;

	private static bool GetWeightDataInRect_IsValid;

	private static IntPtr GetWeightDataInRect_FunctionAddress;

	private static int GetWeightDataInRect_ParamsSize;

	private static bool GetWeightDataInRect_MinX_IsValid;

	private static FFieldAddress GetWeightDataInRect_MinX_PropertyAddress;

	private static int GetWeightDataInRect_MinX_Offset;

	private static bool GetWeightDataInRect_MinY_IsValid;

	private static FFieldAddress GetWeightDataInRect_MinY_PropertyAddress;

	private static int GetWeightDataInRect_MinY_Offset;

	private static bool GetWeightDataInRect_MaxX_IsValid;

	private static FFieldAddress GetWeightDataInRect_MaxX_PropertyAddress;

	private static int GetWeightDataInRect_MaxX_Offset;

	private static bool GetWeightDataInRect_MaxY_IsValid;

	private static FFieldAddress GetWeightDataInRect_MaxY_PropertyAddress;

	private static int GetWeightDataInRect_MaxY_Offset;

	private static bool GetWeightDataInRect_layerIndex_IsValid;

	private static FFieldAddress GetWeightDataInRect_layerIndex_PropertyAddress;

	private static int GetWeightDataInRect_layerIndex_Offset;

	private static bool GetWeightDataInRect_ReturnValue_IsValid;

	private static FFieldAddress GetWeightDataInRect_ReturnValue_PropertyAddress;

	private static int GetWeightDataInRect_ReturnValue_Offset;

	private static bool GetWeightData_IsValid;

	private static IntPtr GetWeightData_FunctionAddress;

	private static int GetWeightData_ParamsSize;

	private static bool GetWeightData_LayerIndex_IsValid;

	private static FFieldAddress GetWeightData_LayerIndex_PropertyAddress;

	private static int GetWeightData_LayerIndex_Offset;

	private static bool GetWeightData_ReturnValue_IsValid;

	private static FFieldAddress GetWeightData_ReturnValue_PropertyAddress;

	private static int GetWeightData_ReturnValue_Offset;

	private static bool GetHeightDataInRect_IsValid;

	private static IntPtr GetHeightDataInRect_FunctionAddress;

	private static int GetHeightDataInRect_ParamsSize;

	private static bool GetHeightDataInRect_MinX_IsValid;

	private static FFieldAddress GetHeightDataInRect_MinX_PropertyAddress;

	private static int GetHeightDataInRect_MinX_Offset;

	private static bool GetHeightDataInRect_MinY_IsValid;

	private static FFieldAddress GetHeightDataInRect_MinY_PropertyAddress;

	private static int GetHeightDataInRect_MinY_Offset;

	private static bool GetHeightDataInRect_MaxX_IsValid;

	private static FFieldAddress GetHeightDataInRect_MaxX_PropertyAddress;

	private static int GetHeightDataInRect_MaxX_Offset;

	private static bool GetHeightDataInRect_MaxY_IsValid;

	private static FFieldAddress GetHeightDataInRect_MaxY_PropertyAddress;

	private static int GetHeightDataInRect_MaxY_Offset;

	private static bool GetHeightDataInRect_ReturnValue_IsValid;

	private static FFieldAddress GetHeightDataInRect_ReturnValue_PropertyAddress;

	private static int GetHeightDataInRect_ReturnValue_Offset;

	private static bool GetHeightData_IsValid;

	private static IntPtr GetHeightData_FunctionAddress;

	private static int GetHeightData_ParamsSize;

	private static bool GetHeightData_ReturnValue_IsValid;

	private static FFieldAddress GetHeightData_ReturnValue_PropertyAddress;

	private static int GetHeightData_ReturnValue_Offset;

	private static bool Cache_IsValid;

	private static IntPtr Cache_FunctionAddress;

	private static int Cache_ParamsSize;

	private static bool Cache_NewLandscapeProxy_IsValid;

	private static FFieldAddress Cache_NewLandscapeProxy_PropertyAddress;

	private static int Cache_NewLandscapeProxy_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:WeightDataElementSize")]
	public unsafe int WeightDataElementSize()
	{
		CheckDestroyed();
		if (!WeightDataElementSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:WeightDataElementSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WeightDataElementSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WeightDataElementSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, WeightDataElementSize_FunctionAddress, intPtr, WeightDataElementSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, WeightDataElementSize_ReturnValue_Offset), 0, WeightDataElementSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:WeightDataElementNum")]
	public unsafe int WeightDataElementNum(int LayerIndex)
	{
		CheckDestroyed();
		if (!WeightDataElementNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:WeightDataElementNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WeightDataElementNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WeightDataElementNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, WeightDataElementNum_LayerIndex_Offset), 0, WeightDataElementNum_LayerIndex_PropertyAddress.Address, LayerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, WeightDataElementNum_FunctionAddress, intPtr, WeightDataElementNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, WeightDataElementNum_ReturnValue_Offset), 0, WeightDataElementNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:SampleWeightData")]
	public unsafe float SampleWeightData(FVector worldPos, int LayerIndex, ESampleType SampleType)
	{
		CheckDestroyed();
		if (!SampleWeightData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:SampleWeightData");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SampleWeightData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SampleWeightData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SampleWeightData_worldPos_Offset), 0, SampleWeightData_worldPos_PropertyAddress.Address, worldPos);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SampleWeightData_LayerIndex_Offset), 0, SampleWeightData_LayerIndex_PropertyAddress.Address, LayerIndex);
		EnumMarshaler<ESampleType>.ToNative(IntPtr.Add(intPtr, SampleWeightData_SampleType_Offset), 0, SampleWeightData_SampleType_PropertyAddress.Address, SampleType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SampleWeightData_FunctionAddress, intPtr, SampleWeightData_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, SampleWeightData_ReturnValue_Offset), 0, SampleWeightData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:SampleHeightData")]
	public unsafe float SampleHeightData(FVector worldPos, ESampleType SampleType)
	{
		CheckDestroyed();
		if (!SampleHeightData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:SampleHeightData");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SampleHeightData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SampleHeightData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SampleHeightData_worldPos_Offset), 0, SampleHeightData_worldPos_PropertyAddress.Address, worldPos);
		EnumMarshaler<ESampleType>.ToNative(IntPtr.Add(intPtr, SampleHeightData_SampleType_Offset), 0, SampleHeightData_SampleType_PropertyAddress.Address, SampleType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SampleHeightData_FunctionAddress, intPtr, SampleHeightData_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, SampleHeightData_ReturnValue_Offset), 0, SampleHeightData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:HeightDataElementSize")]
	public unsafe int HeightDataElementSize()
	{
		CheckDestroyed();
		if (!HeightDataElementSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:HeightDataElementSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HeightDataElementSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HeightDataElementSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HeightDataElementSize_FunctionAddress, intPtr, HeightDataElementSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, HeightDataElementSize_ReturnValue_Offset), 0, HeightDataElementSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:HeightDataElementNum")]
	public unsafe int HeightDataElementNum()
	{
		CheckDestroyed();
		if (!HeightDataElementNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:HeightDataElementNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HeightDataElementNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HeightDataElementNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HeightDataElementNum_FunctionAddress, intPtr, HeightDataElementNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, HeightDataElementNum_ReturnValue_Offset), 0, HeightDataElementNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:GetWeightDataInRect")]
	public unsafe FIntPtr GetWeightDataInRect(int MinX, int MinY, int MaxX, int MaxY, int layerIndex)
	{
		CheckDestroyed();
		if (!GetWeightDataInRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:GetWeightDataInRect");
			return default(FIntPtr);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWeightDataInRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWeightDataInRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWeightDataInRect_MinX_Offset), 0, GetWeightDataInRect_MinX_PropertyAddress.Address, MinX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWeightDataInRect_MinY_Offset), 0, GetWeightDataInRect_MinY_PropertyAddress.Address, MinY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWeightDataInRect_MaxX_Offset), 0, GetWeightDataInRect_MaxX_PropertyAddress.Address, MaxX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWeightDataInRect_MaxY_Offset), 0, GetWeightDataInRect_MaxY_PropertyAddress.Address, MaxY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWeightDataInRect_layerIndex_Offset), 0, GetWeightDataInRect_layerIndex_PropertyAddress.Address, layerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWeightDataInRect_FunctionAddress, intPtr, GetWeightDataInRect_ParamsSize);
		return BlittableTypeMarshaler<FIntPtr>.FromNative(IntPtr.Add(intPtr, GetWeightDataInRect_ReturnValue_Offset), 0, GetWeightDataInRect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:GetWeightData")]
	public unsafe FIntPtr GetWeightData(int LayerIndex)
	{
		CheckDestroyed();
		if (!GetWeightData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:GetWeightData");
			return default(FIntPtr);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWeightData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWeightData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWeightData_LayerIndex_Offset), 0, GetWeightData_LayerIndex_PropertyAddress.Address, LayerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWeightData_FunctionAddress, intPtr, GetWeightData_ParamsSize);
		return BlittableTypeMarshaler<FIntPtr>.FromNative(IntPtr.Add(intPtr, GetWeightData_ReturnValue_Offset), 0, GetWeightData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:GetHeightDataInRect")]
	public unsafe FIntPtr GetHeightDataInRect(int MinX, int MinY, int MaxX, int MaxY)
	{
		CheckDestroyed();
		if (!GetHeightDataInRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:GetHeightDataInRect");
			return default(FIntPtr);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHeightDataInRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHeightDataInRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightDataInRect_MinX_Offset), 0, GetHeightDataInRect_MinX_PropertyAddress.Address, MinX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightDataInRect_MinY_Offset), 0, GetHeightDataInRect_MinY_PropertyAddress.Address, MinY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightDataInRect_MaxX_Offset), 0, GetHeightDataInRect_MaxX_PropertyAddress.Address, MaxX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightDataInRect_MaxY_Offset), 0, GetHeightDataInRect_MaxY_PropertyAddress.Address, MaxY);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHeightDataInRect_FunctionAddress, intPtr, GetHeightDataInRect_ParamsSize);
		return BlittableTypeMarshaler<FIntPtr>.FromNative(IntPtr.Add(intPtr, GetHeightDataInRect_ReturnValue_Offset), 0, GetHeightDataInRect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:GetHeightData")]
	public unsafe FIntPtr GetHeightData()
	{
		CheckDestroyed();
		if (!GetHeightData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:GetHeightData");
			return default(FIntPtr);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHeightData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHeightData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHeightData_FunctionAddress, intPtr, GetHeightData_ParamsSize);
		return BlittableTypeMarshaler<FIntPtr>.FromNative(IntPtr.Add(intPtr, GetHeightData_ReturnValue_Offset), 0, GetHeightData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LandscapeReader:Cache")]
	public unsafe void Cache(ALandscapeProxy NewLandscapeProxy)
	{
		CheckDestroyed();
		if (!Cache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LandscapeReader:Cache");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(intPtr, Cache_NewLandscapeProxy_Offset), 0, Cache_NewLandscapeProxy_PropertyAddress.Address, NewLandscapeProxy);
		NativeReflection.InvokeFunctionOptimized(base.Address, Cache_FunctionAddress, intPtr, Cache_ParamsSize);
	}

	static ULandscapeReader()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULandscapeReader)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULandscapeReader));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.LandscapeReader");
		WeightDataElementSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WeightDataElementSize");
		WeightDataElementSize_ParamsSize = NativeReflection.GetFunctionParamsSize(WeightDataElementSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WeightDataElementSize_ReturnValue_PropertyAddress, WeightDataElementSize_FunctionAddress, "ReturnValue");
		WeightDataElementSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WeightDataElementSize_FunctionAddress, "ReturnValue");
		WeightDataElementSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WeightDataElementSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		WeightDataElementSize_IsValid = WeightDataElementSize_FunctionAddress != IntPtr.Zero && WeightDataElementSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:WeightDataElementSize", WeightDataElementSize_IsValid);
		WeightDataElementNum_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WeightDataElementNum");
		WeightDataElementNum_ParamsSize = NativeReflection.GetFunctionParamsSize(WeightDataElementNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WeightDataElementNum_LayerIndex_PropertyAddress, WeightDataElementNum_FunctionAddress, "LayerIndex");
		WeightDataElementNum_LayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(WeightDataElementNum_FunctionAddress, "LayerIndex");
		WeightDataElementNum_LayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(WeightDataElementNum_FunctionAddress, "LayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref WeightDataElementNum_ReturnValue_PropertyAddress, WeightDataElementNum_FunctionAddress, "ReturnValue");
		WeightDataElementNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WeightDataElementNum_FunctionAddress, "ReturnValue");
		WeightDataElementNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WeightDataElementNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		WeightDataElementNum_IsValid = WeightDataElementNum_FunctionAddress != IntPtr.Zero && WeightDataElementNum_LayerIndex_IsValid && WeightDataElementNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:WeightDataElementNum", WeightDataElementNum_IsValid);
		SampleWeightData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SampleWeightData");
		SampleWeightData_ParamsSize = NativeReflection.GetFunctionParamsSize(SampleWeightData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SampleWeightData_worldPos_PropertyAddress, SampleWeightData_FunctionAddress, "worldPos");
		SampleWeightData_worldPos_Offset = NativeReflectionCached.GetPropertyOffset(SampleWeightData_FunctionAddress, "worldPos");
		SampleWeightData_worldPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleWeightData_FunctionAddress, "worldPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleWeightData_LayerIndex_PropertyAddress, SampleWeightData_FunctionAddress, "LayerIndex");
		SampleWeightData_LayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(SampleWeightData_FunctionAddress, "LayerIndex");
		SampleWeightData_LayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleWeightData_FunctionAddress, "LayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleWeightData_SampleType_PropertyAddress, SampleWeightData_FunctionAddress, "SampleType");
		SampleWeightData_SampleType_Offset = NativeReflectionCached.GetPropertyOffset(SampleWeightData_FunctionAddress, "SampleType");
		SampleWeightData_SampleType_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleWeightData_FunctionAddress, "SampleType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleWeightData_ReturnValue_PropertyAddress, SampleWeightData_FunctionAddress, "ReturnValue");
		SampleWeightData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SampleWeightData_FunctionAddress, "ReturnValue");
		SampleWeightData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleWeightData_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		SampleWeightData_IsValid = SampleWeightData_FunctionAddress != IntPtr.Zero && SampleWeightData_worldPos_IsValid && SampleWeightData_LayerIndex_IsValid && SampleWeightData_SampleType_IsValid && SampleWeightData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:SampleWeightData", SampleWeightData_IsValid);
		SampleHeightData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SampleHeightData");
		SampleHeightData_ParamsSize = NativeReflection.GetFunctionParamsSize(SampleHeightData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SampleHeightData_worldPos_PropertyAddress, SampleHeightData_FunctionAddress, "worldPos");
		SampleHeightData_worldPos_Offset = NativeReflectionCached.GetPropertyOffset(SampleHeightData_FunctionAddress, "worldPos");
		SampleHeightData_worldPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleHeightData_FunctionAddress, "worldPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleHeightData_SampleType_PropertyAddress, SampleHeightData_FunctionAddress, "SampleType");
		SampleHeightData_SampleType_Offset = NativeReflectionCached.GetPropertyOffset(SampleHeightData_FunctionAddress, "SampleType");
		SampleHeightData_SampleType_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleHeightData_FunctionAddress, "SampleType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SampleHeightData_ReturnValue_PropertyAddress, SampleHeightData_FunctionAddress, "ReturnValue");
		SampleHeightData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SampleHeightData_FunctionAddress, "ReturnValue");
		SampleHeightData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SampleHeightData_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		SampleHeightData_IsValid = SampleHeightData_FunctionAddress != IntPtr.Zero && SampleHeightData_worldPos_IsValid && SampleHeightData_SampleType_IsValid && SampleHeightData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:SampleHeightData", SampleHeightData_IsValid);
		HeightDataElementSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HeightDataElementSize");
		HeightDataElementSize_ParamsSize = NativeReflection.GetFunctionParamsSize(HeightDataElementSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HeightDataElementSize_ReturnValue_PropertyAddress, HeightDataElementSize_FunctionAddress, "ReturnValue");
		HeightDataElementSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HeightDataElementSize_FunctionAddress, "ReturnValue");
		HeightDataElementSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HeightDataElementSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		HeightDataElementSize_IsValid = HeightDataElementSize_FunctionAddress != IntPtr.Zero && HeightDataElementSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:HeightDataElementSize", HeightDataElementSize_IsValid);
		HeightDataElementNum_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HeightDataElementNum");
		HeightDataElementNum_ParamsSize = NativeReflection.GetFunctionParamsSize(HeightDataElementNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HeightDataElementNum_ReturnValue_PropertyAddress, HeightDataElementNum_FunctionAddress, "ReturnValue");
		HeightDataElementNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HeightDataElementNum_FunctionAddress, "ReturnValue");
		HeightDataElementNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HeightDataElementNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		HeightDataElementNum_IsValid = HeightDataElementNum_FunctionAddress != IntPtr.Zero && HeightDataElementNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:HeightDataElementNum", HeightDataElementNum_IsValid);
		GetWeightDataInRect_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWeightDataInRect");
		GetWeightDataInRect_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWeightDataInRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWeightDataInRect_MinX_PropertyAddress, GetWeightDataInRect_FunctionAddress, "MinX");
		GetWeightDataInRect_MinX_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightDataInRect_FunctionAddress, "MinX");
		GetWeightDataInRect_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightDataInRect_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWeightDataInRect_MinY_PropertyAddress, GetWeightDataInRect_FunctionAddress, "MinY");
		GetWeightDataInRect_MinY_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightDataInRect_FunctionAddress, "MinY");
		GetWeightDataInRect_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightDataInRect_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWeightDataInRect_MaxX_PropertyAddress, GetWeightDataInRect_FunctionAddress, "MaxX");
		GetWeightDataInRect_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightDataInRect_FunctionAddress, "MaxX");
		GetWeightDataInRect_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightDataInRect_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWeightDataInRect_MaxY_PropertyAddress, GetWeightDataInRect_FunctionAddress, "MaxY");
		GetWeightDataInRect_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightDataInRect_FunctionAddress, "MaxY");
		GetWeightDataInRect_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightDataInRect_FunctionAddress, "MaxY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWeightDataInRect_layerIndex_PropertyAddress, GetWeightDataInRect_FunctionAddress, "layerIndex");
		GetWeightDataInRect_layerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightDataInRect_FunctionAddress, "layerIndex");
		GetWeightDataInRect_layerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightDataInRect_FunctionAddress, "layerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWeightDataInRect_ReturnValue_PropertyAddress, GetWeightDataInRect_FunctionAddress, "ReturnValue");
		GetWeightDataInRect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightDataInRect_FunctionAddress, "ReturnValue");
		GetWeightDataInRect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightDataInRect_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWeightDataInRect_IsValid = GetWeightDataInRect_FunctionAddress != IntPtr.Zero && GetWeightDataInRect_MinX_IsValid && GetWeightDataInRect_MinY_IsValid && GetWeightDataInRect_MaxX_IsValid && GetWeightDataInRect_MaxY_IsValid && GetWeightDataInRect_layerIndex_IsValid && GetWeightDataInRect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:GetWeightDataInRect", GetWeightDataInRect_IsValid);
		GetWeightData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWeightData");
		GetWeightData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWeightData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWeightData_LayerIndex_PropertyAddress, GetWeightData_FunctionAddress, "LayerIndex");
		GetWeightData_LayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightData_FunctionAddress, "LayerIndex");
		GetWeightData_LayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightData_FunctionAddress, "LayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWeightData_ReturnValue_PropertyAddress, GetWeightData_FunctionAddress, "ReturnValue");
		GetWeightData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWeightData_FunctionAddress, "ReturnValue");
		GetWeightData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWeightData_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWeightData_IsValid = GetWeightData_FunctionAddress != IntPtr.Zero && GetWeightData_LayerIndex_IsValid && GetWeightData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:GetWeightData", GetWeightData_IsValid);
		GetHeightDataInRect_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetHeightDataInRect");
		GetHeightDataInRect_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHeightDataInRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHeightDataInRect_MinX_PropertyAddress, GetHeightDataInRect_FunctionAddress, "MinX");
		GetHeightDataInRect_MinX_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightDataInRect_FunctionAddress, "MinX");
		GetHeightDataInRect_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightDataInRect_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightDataInRect_MinY_PropertyAddress, GetHeightDataInRect_FunctionAddress, "MinY");
		GetHeightDataInRect_MinY_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightDataInRect_FunctionAddress, "MinY");
		GetHeightDataInRect_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightDataInRect_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightDataInRect_MaxX_PropertyAddress, GetHeightDataInRect_FunctionAddress, "MaxX");
		GetHeightDataInRect_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightDataInRect_FunctionAddress, "MaxX");
		GetHeightDataInRect_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightDataInRect_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightDataInRect_MaxY_PropertyAddress, GetHeightDataInRect_FunctionAddress, "MaxY");
		GetHeightDataInRect_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightDataInRect_FunctionAddress, "MaxY");
		GetHeightDataInRect_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightDataInRect_FunctionAddress, "MaxY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightDataInRect_ReturnValue_PropertyAddress, GetHeightDataInRect_FunctionAddress, "ReturnValue");
		GetHeightDataInRect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightDataInRect_FunctionAddress, "ReturnValue");
		GetHeightDataInRect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightDataInRect_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetHeightDataInRect_IsValid = GetHeightDataInRect_FunctionAddress != IntPtr.Zero && GetHeightDataInRect_MinX_IsValid && GetHeightDataInRect_MinY_IsValid && GetHeightDataInRect_MaxX_IsValid && GetHeightDataInRect_MaxY_IsValid && GetHeightDataInRect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:GetHeightDataInRect", GetHeightDataInRect_IsValid);
		GetHeightData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetHeightData");
		GetHeightData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHeightData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHeightData_ReturnValue_PropertyAddress, GetHeightData_FunctionAddress, "ReturnValue");
		GetHeightData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightData_FunctionAddress, "ReturnValue");
		GetHeightData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightData_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetHeightData_IsValid = GetHeightData_FunctionAddress != IntPtr.Zero && GetHeightData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:GetHeightData", GetHeightData_IsValid);
		Cache_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Cache");
		Cache_ParamsSize = NativeReflection.GetFunctionParamsSize(Cache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Cache_NewLandscapeProxy_PropertyAddress, Cache_FunctionAddress, "NewLandscapeProxy");
		Cache_NewLandscapeProxy_Offset = NativeReflectionCached.GetPropertyOffset(Cache_FunctionAddress, "NewLandscapeProxy");
		Cache_NewLandscapeProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(Cache_FunctionAddress, "NewLandscapeProxy", Classes.FObjectProperty);
		Cache_IsValid = Cache_FunctionAddress != IntPtr.Zero && Cache_NewLandscapeProxy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LandscapeReader:Cache", Cache_IsValid);
	}
}
