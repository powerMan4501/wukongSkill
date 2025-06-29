using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperFlipbook", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperFlipbook : UObject
{
	private static bool FramesPerSecond_IsValid;

	private static int FramesPerSecond_Offset;

	private static bool DefaultMaterial_IsValid;

	private static int DefaultMaterial_Offset;

	private static bool CollisionSource_IsValid;

	private static FFieldAddress CollisionSource_PropertyAddress;

	private static int CollisionSource_Offset;

	private static bool IsValidKeyFrameIndex_IsValid;

	private static IntPtr IsValidKeyFrameIndex_FunctionAddress;

	private static int IsValidKeyFrameIndex_ParamsSize;

	private static bool IsValidKeyFrameIndex_Index_IsValid;

	private static FFieldAddress IsValidKeyFrameIndex_Index_PropertyAddress;

	private static int IsValidKeyFrameIndex_Index_Offset;

	private static bool IsValidKeyFrameIndex_ReturnValue_IsValid;

	private static FFieldAddress IsValidKeyFrameIndex_ReturnValue_PropertyAddress;

	private static int IsValidKeyFrameIndex_ReturnValue_Offset;

	private static bool GetTotalDuration_IsValid;

	private static IntPtr GetTotalDuration_FunctionAddress;

	private static int GetTotalDuration_ParamsSize;

	private static bool GetTotalDuration_ReturnValue_IsValid;

	private static FFieldAddress GetTotalDuration_ReturnValue_PropertyAddress;

	private static int GetTotalDuration_ReturnValue_Offset;

	private static bool GetSpriteAtTime_IsValid;

	private static IntPtr GetSpriteAtTime_FunctionAddress;

	private static int GetSpriteAtTime_ParamsSize;

	private static bool GetSpriteAtTime_Time_IsValid;

	private static FFieldAddress GetSpriteAtTime_Time_PropertyAddress;

	private static int GetSpriteAtTime_Time_Offset;

	private static bool GetSpriteAtTime_bClampToEnds_IsValid;

	private static FFieldAddress GetSpriteAtTime_bClampToEnds_PropertyAddress;

	private static int GetSpriteAtTime_bClampToEnds_Offset;

	private static bool GetSpriteAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetSpriteAtTime_ReturnValue_PropertyAddress;

	private static int GetSpriteAtTime_ReturnValue_Offset;

	private static bool GetSpriteAtFrame_IsValid;

	private static IntPtr GetSpriteAtFrame_FunctionAddress;

	private static int GetSpriteAtFrame_ParamsSize;

	private static bool GetSpriteAtFrame_FrameIndex_IsValid;

	private static FFieldAddress GetSpriteAtFrame_FrameIndex_PropertyAddress;

	private static int GetSpriteAtFrame_FrameIndex_Offset;

	private static bool GetSpriteAtFrame_ReturnValue_IsValid;

	private static FFieldAddress GetSpriteAtFrame_ReturnValue_PropertyAddress;

	private static int GetSpriteAtFrame_ReturnValue_Offset;

	private static bool GetNumKeyFrames_IsValid;

	private static IntPtr GetNumKeyFrames_FunctionAddress;

	private static int GetNumKeyFrames_ParamsSize;

	private static bool GetNumKeyFrames_ReturnValue_IsValid;

	private static FFieldAddress GetNumKeyFrames_ReturnValue_PropertyAddress;

	private static int GetNumKeyFrames_ReturnValue_Offset;

	private static bool GetNumFrames_IsValid;

	private static IntPtr GetNumFrames_FunctionAddress;

	private static int GetNumFrames_ParamsSize;

	private static bool GetNumFrames_ReturnValue_IsValid;

	private static FFieldAddress GetNumFrames_ReturnValue_PropertyAddress;

	private static int GetNumFrames_ReturnValue_Offset;

	private static bool GetKeyFrameIndexAtTime_IsValid;

	private static IntPtr GetKeyFrameIndexAtTime_FunctionAddress;

	private static int GetKeyFrameIndexAtTime_ParamsSize;

	private static bool GetKeyFrameIndexAtTime_Time_IsValid;

	private static FFieldAddress GetKeyFrameIndexAtTime_Time_PropertyAddress;

	private static int GetKeyFrameIndexAtTime_Time_Offset;

	private static bool GetKeyFrameIndexAtTime_bClampToEnds_IsValid;

	private static FFieldAddress GetKeyFrameIndexAtTime_bClampToEnds_PropertyAddress;

	private static int GetKeyFrameIndexAtTime_bClampToEnds_Offset;

	private static bool GetKeyFrameIndexAtTime_ReturnValue_IsValid;

	private static FFieldAddress GetKeyFrameIndexAtTime_ReturnValue_PropertyAddress;

	private static int GetKeyFrameIndexAtTime_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:FramesPerSecond")]
	protected float FramesPerSecond
	{
		get
		{
			CheckDestroyed();
			if (!FramesPerSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbook:FramesPerSecond");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FramesPerSecond_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FramesPerSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbook:FramesPerSecond");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FramesPerSecond_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:DefaultMaterial")]
	protected UMaterialInterface DefaultMaterial
	{
		get
		{
			CheckDestroyed();
			if (!DefaultMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbook:DefaultMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, DefaultMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbook:DefaultMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, DefaultMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:CollisionSource")]
	protected EFlipbookCollisionMode CollisionSource
	{
		get
		{
			CheckDestroyed();
			if (!CollisionSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbook:CollisionSource");
				return EFlipbookCollisionMode.NoCollision;
			}
			return EnumMarshaler<EFlipbookCollisionMode>.FromNative(IntPtr.Add(base.Address, CollisionSource_Offset), 0, CollisionSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CollisionSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperFlipbook:CollisionSource");
			}
			else
			{
				EnumMarshaler<EFlipbookCollisionMode>.ToNative(IntPtr.Add(base.Address, CollisionSource_Offset), 0, CollisionSource_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:IsValidKeyFrameIndex")]
	public unsafe bool IsValidKeyFrameIndex(int Index)
	{
		CheckDestroyed();
		if (!IsValidKeyFrameIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbook:IsValidKeyFrameIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidKeyFrameIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidKeyFrameIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsValidKeyFrameIndex_Index_Offset), 0, IsValidKeyFrameIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidKeyFrameIndex_FunctionAddress, intPtr, IsValidKeyFrameIndex_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidKeyFrameIndex_ReturnValue_Offset), 0, IsValidKeyFrameIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:GetTotalDuration")]
	public unsafe float GetTotalDuration()
	{
		CheckDestroyed();
		if (!GetTotalDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbook:GetTotalDuration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTotalDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTotalDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTotalDuration_FunctionAddress, intPtr, GetTotalDuration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTotalDuration_ReturnValue_Offset), 0, GetTotalDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:GetSpriteAtTime")]
	public unsafe UPaperSprite GetSpriteAtTime(float Time, bool bClampToEnds = false)
	{
		CheckDestroyed();
		if (!GetSpriteAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbook:GetSpriteAtTime");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpriteAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpriteAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetSpriteAtTime_Time_Offset), 0, GetSpriteAtTime_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSpriteAtTime_bClampToEnds_Offset), 0, GetSpriteAtTime_bClampToEnds_PropertyAddress.Address, bClampToEnds);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpriteAtTime_FunctionAddress, intPtr, GetSpriteAtTime_ParamsSize);
		return UObjectMarshaler<UPaperSprite>.FromNative(IntPtr.Add(intPtr, GetSpriteAtTime_ReturnValue_Offset), 0, GetSpriteAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:GetSpriteAtFrame")]
	public unsafe UPaperSprite GetSpriteAtFrame(int FrameIndex)
	{
		CheckDestroyed();
		if (!GetSpriteAtFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbook:GetSpriteAtFrame");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpriteAtFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpriteAtFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSpriteAtFrame_FrameIndex_Offset), 0, GetSpriteAtFrame_FrameIndex_PropertyAddress.Address, FrameIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpriteAtFrame_FunctionAddress, intPtr, GetSpriteAtFrame_ParamsSize);
		return UObjectMarshaler<UPaperSprite>.FromNative(IntPtr.Add(intPtr, GetSpriteAtFrame_ReturnValue_Offset), 0, GetSpriteAtFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:GetNumKeyFrames")]
	public unsafe int GetNumKeyFrames()
	{
		CheckDestroyed();
		if (!GetNumKeyFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbook:GetNumKeyFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumKeyFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumKeyFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumKeyFrames_FunctionAddress, intPtr, GetNumKeyFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumKeyFrames_ReturnValue_Offset), 0, GetNumKeyFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:GetNumFrames")]
	public unsafe int GetNumFrames()
	{
		CheckDestroyed();
		if (!GetNumFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbook:GetNumFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumFrames_FunctionAddress, intPtr, GetNumFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumFrames_ReturnValue_Offset), 0, GetNumFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Paper2D.PaperFlipbook:GetKeyFrameIndexAtTime")]
	public unsafe int GetKeyFrameIndexAtTime(float Time, bool bClampToEnds = false)
	{
		CheckDestroyed();
		if (!GetKeyFrameIndexAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperFlipbook:GetKeyFrameIndexAtTime");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyFrameIndexAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyFrameIndexAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetKeyFrameIndexAtTime_Time_Offset), 0, GetKeyFrameIndexAtTime_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetKeyFrameIndexAtTime_bClampToEnds_Offset), 0, GetKeyFrameIndexAtTime_bClampToEnds_PropertyAddress.Address, bClampToEnds);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetKeyFrameIndexAtTime_FunctionAddress, intPtr, GetKeyFrameIndexAtTime_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetKeyFrameIndexAtTime_ReturnValue_Offset), 0, GetKeyFrameIndexAtTime_ReturnValue_PropertyAddress.Address);
	}

	static UPaperFlipbook()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperFlipbook)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperFlipbook));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Paper2D.PaperFlipbook");
		FramesPerSecond_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FramesPerSecond");
		FramesPerSecond_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FramesPerSecond", Classes.FFloatProperty);
		DefaultMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultMaterial");
		DefaultMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CollisionSource_PropertyAddress, intPtr, "CollisionSource");
		CollisionSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionSource");
		CollisionSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionSource", Classes.FByteProperty);
		IsValidKeyFrameIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsValidKeyFrameIndex");
		IsValidKeyFrameIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidKeyFrameIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidKeyFrameIndex_Index_PropertyAddress, IsValidKeyFrameIndex_FunctionAddress, "Index");
		IsValidKeyFrameIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(IsValidKeyFrameIndex_FunctionAddress, "Index");
		IsValidKeyFrameIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidKeyFrameIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidKeyFrameIndex_ReturnValue_PropertyAddress, IsValidKeyFrameIndex_FunctionAddress, "ReturnValue");
		IsValidKeyFrameIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidKeyFrameIndex_FunctionAddress, "ReturnValue");
		IsValidKeyFrameIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidKeyFrameIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidKeyFrameIndex_IsValid = IsValidKeyFrameIndex_FunctionAddress != IntPtr.Zero && IsValidKeyFrameIndex_Index_IsValid && IsValidKeyFrameIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbook:IsValidKeyFrameIndex", IsValidKeyFrameIndex_IsValid);
		GetTotalDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTotalDuration");
		GetTotalDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTotalDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTotalDuration_ReturnValue_PropertyAddress, GetTotalDuration_FunctionAddress, "ReturnValue");
		GetTotalDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalDuration_FunctionAddress, "ReturnValue");
		GetTotalDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTotalDuration_IsValid = GetTotalDuration_FunctionAddress != IntPtr.Zero && GetTotalDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbook:GetTotalDuration", GetTotalDuration_IsValid);
		GetSpriteAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpriteAtTime");
		GetSpriteAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpriteAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpriteAtTime_Time_PropertyAddress, GetSpriteAtTime_FunctionAddress, "Time");
		GetSpriteAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetSpriteAtTime_FunctionAddress, "Time");
		GetSpriteAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpriteAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpriteAtTime_bClampToEnds_PropertyAddress, GetSpriteAtTime_FunctionAddress, "bClampToEnds");
		GetSpriteAtTime_bClampToEnds_Offset = NativeReflectionCached.GetPropertyOffset(GetSpriteAtTime_FunctionAddress, "bClampToEnds");
		GetSpriteAtTime_bClampToEnds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpriteAtTime_FunctionAddress, "bClampToEnds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpriteAtTime_ReturnValue_PropertyAddress, GetSpriteAtTime_FunctionAddress, "ReturnValue");
		GetSpriteAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpriteAtTime_FunctionAddress, "ReturnValue");
		GetSpriteAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpriteAtTime_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSpriteAtTime_IsValid = GetSpriteAtTime_FunctionAddress != IntPtr.Zero && GetSpriteAtTime_Time_IsValid && GetSpriteAtTime_bClampToEnds_IsValid && GetSpriteAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbook:GetSpriteAtTime", GetSpriteAtTime_IsValid);
		GetSpriteAtFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpriteAtFrame");
		GetSpriteAtFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpriteAtFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpriteAtFrame_FrameIndex_PropertyAddress, GetSpriteAtFrame_FunctionAddress, "FrameIndex");
		GetSpriteAtFrame_FrameIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetSpriteAtFrame_FunctionAddress, "FrameIndex");
		GetSpriteAtFrame_FrameIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpriteAtFrame_FunctionAddress, "FrameIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpriteAtFrame_ReturnValue_PropertyAddress, GetSpriteAtFrame_FunctionAddress, "ReturnValue");
		GetSpriteAtFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpriteAtFrame_FunctionAddress, "ReturnValue");
		GetSpriteAtFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpriteAtFrame_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSpriteAtFrame_IsValid = GetSpriteAtFrame_FunctionAddress != IntPtr.Zero && GetSpriteAtFrame_FrameIndex_IsValid && GetSpriteAtFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbook:GetSpriteAtFrame", GetSpriteAtFrame_IsValid);
		GetNumKeyFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumKeyFrames");
		GetNumKeyFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumKeyFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumKeyFrames_ReturnValue_PropertyAddress, GetNumKeyFrames_FunctionAddress, "ReturnValue");
		GetNumKeyFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumKeyFrames_FunctionAddress, "ReturnValue");
		GetNumKeyFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumKeyFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumKeyFrames_IsValid = GetNumKeyFrames_FunctionAddress != IntPtr.Zero && GetNumKeyFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbook:GetNumKeyFrames", GetNumKeyFrames_IsValid);
		GetNumFrames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumFrames");
		GetNumFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumFrames_ReturnValue_PropertyAddress, GetNumFrames_FunctionAddress, "ReturnValue");
		GetNumFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumFrames_FunctionAddress, "ReturnValue");
		GetNumFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumFrames_IsValid = GetNumFrames_FunctionAddress != IntPtr.Zero && GetNumFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbook:GetNumFrames", GetNumFrames_IsValid);
		GetKeyFrameIndexAtTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetKeyFrameIndexAtTime");
		GetKeyFrameIndexAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyFrameIndexAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyFrameIndexAtTime_Time_PropertyAddress, GetKeyFrameIndexAtTime_FunctionAddress, "Time");
		GetKeyFrameIndexAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyFrameIndexAtTime_FunctionAddress, "Time");
		GetKeyFrameIndexAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyFrameIndexAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyFrameIndexAtTime_bClampToEnds_PropertyAddress, GetKeyFrameIndexAtTime_FunctionAddress, "bClampToEnds");
		GetKeyFrameIndexAtTime_bClampToEnds_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyFrameIndexAtTime_FunctionAddress, "bClampToEnds");
		GetKeyFrameIndexAtTime_bClampToEnds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyFrameIndexAtTime_FunctionAddress, "bClampToEnds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyFrameIndexAtTime_ReturnValue_PropertyAddress, GetKeyFrameIndexAtTime_FunctionAddress, "ReturnValue");
		GetKeyFrameIndexAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyFrameIndexAtTime_FunctionAddress, "ReturnValue");
		GetKeyFrameIndexAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyFrameIndexAtTime_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetKeyFrameIndexAtTime_IsValid = GetKeyFrameIndexAtTime_FunctionAddress != IntPtr.Zero && GetKeyFrameIndexAtTime_Time_IsValid && GetKeyFrameIndexAtTime_bClampToEnds_IsValid && GetKeyFrameIndexAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperFlipbook:GetKeyFrameIndexAtTime", GetKeyFrameIndexAtTime_IsValid);
	}
}
