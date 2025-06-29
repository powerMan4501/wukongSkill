using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaPlaylist", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaPlaylist : UObject
{
	private static bool Replace_IsValid;

	private static IntPtr Replace_FunctionAddress;

	private static int Replace_ParamsSize;

	private static bool Replace_Index_IsValid;

	private static FFieldAddress Replace_Index_PropertyAddress;

	private static int Replace_Index_Offset;

	private static bool Replace_Replacement_IsValid;

	private static FFieldAddress Replace_Replacement_PropertyAddress;

	private static int Replace_Replacement_Offset;

	private static bool Replace_ReturnValue_IsValid;

	private static FFieldAddress Replace_ReturnValue_PropertyAddress;

	private static int Replace_ReturnValue_Offset;

	private static bool RemoveAt_IsValid;

	private static IntPtr RemoveAt_FunctionAddress;

	private static int RemoveAt_ParamsSize;

	private static bool RemoveAt_Index_IsValid;

	private static FFieldAddress RemoveAt_Index_PropertyAddress;

	private static int RemoveAt_Index_Offset;

	private static bool RemoveAt_ReturnValue_IsValid;

	private static FFieldAddress RemoveAt_ReturnValue_PropertyAddress;

	private static int RemoveAt_ReturnValue_Offset;

	private static bool Remove_IsValid;

	private static IntPtr Remove_FunctionAddress;

	private static int Remove_ParamsSize;

	private static bool Remove_MediaSource_IsValid;

	private static FFieldAddress Remove_MediaSource_PropertyAddress;

	private static int Remove_MediaSource_Offset;

	private static bool Remove_ReturnValue_IsValid;

	private static FFieldAddress Remove_ReturnValue_PropertyAddress;

	private static int Remove_ReturnValue_Offset;

	private static bool Num_IsValid;

	private static IntPtr Num_FunctionAddress;

	private static int Num_ParamsSize;

	private static bool Num_ReturnValue_IsValid;

	private static FFieldAddress Num_ReturnValue_PropertyAddress;

	private static int Num_ReturnValue_Offset;

	private static bool Insert_IsValid;

	private static IntPtr Insert_FunctionAddress;

	private static int Insert_ParamsSize;

	private static bool Insert_MediaSource_IsValid;

	private static FFieldAddress Insert_MediaSource_PropertyAddress;

	private static int Insert_MediaSource_Offset;

	private static bool Insert_Index_IsValid;

	private static FFieldAddress Insert_Index_PropertyAddress;

	private static int Insert_Index_Offset;

	private static bool GetRandom_IsValid;

	private static IntPtr GetRandom_FunctionAddress;

	private static int GetRandom_ParamsSize;

	private static bool GetRandom_OutIndex_IsValid;

	private static FFieldAddress GetRandom_OutIndex_PropertyAddress;

	private static int GetRandom_OutIndex_Offset;

	private static bool GetRandom_ReturnValue_IsValid;

	private static FFieldAddress GetRandom_ReturnValue_PropertyAddress;

	private static int GetRandom_ReturnValue_Offset;

	private static bool GetPrevious_IsValid;

	private static IntPtr GetPrevious_FunctionAddress;

	private static int GetPrevious_ParamsSize;

	private static bool GetPrevious_InOutIndex_IsValid;

	private static FFieldAddress GetPrevious_InOutIndex_PropertyAddress;

	private static int GetPrevious_InOutIndex_Offset;

	private static bool GetPrevious_ReturnValue_IsValid;

	private static FFieldAddress GetPrevious_ReturnValue_PropertyAddress;

	private static int GetPrevious_ReturnValue_Offset;

	private static bool GetNext_IsValid;

	private static IntPtr GetNext_FunctionAddress;

	private static int GetNext_ParamsSize;

	private static bool GetNext_InOutIndex_IsValid;

	private static FFieldAddress GetNext_InOutIndex_PropertyAddress;

	private static int GetNext_InOutIndex_Offset;

	private static bool GetNext_ReturnValue_IsValid;

	private static FFieldAddress GetNext_ReturnValue_PropertyAddress;

	private static int GetNext_ReturnValue_Offset;

	private static bool Get_IsValid;

	private static IntPtr Get_FunctionAddress;

	private static int Get_ParamsSize;

	private static bool Get_Index_IsValid;

	private static FFieldAddress Get_Index_PropertyAddress;

	private static int Get_Index_Offset;

	private static bool Get_ReturnValue_IsValid;

	private static FFieldAddress Get_ReturnValue_PropertyAddress;

	private static int Get_ReturnValue_Offset;

	private static bool AddUrl_IsValid;

	private static IntPtr AddUrl_FunctionAddress;

	private static int AddUrl_ParamsSize;

	private static bool AddUrl_Url_IsValid;

	private static FFieldAddress AddUrl_Url_PropertyAddress;

	private static int AddUrl_Url_Offset;

	private static bool AddUrl_ReturnValue_IsValid;

	private static FFieldAddress AddUrl_ReturnValue_PropertyAddress;

	private static int AddUrl_ReturnValue_Offset;

	private static bool AddFile_IsValid;

	private static IntPtr AddFile_FunctionAddress;

	private static int AddFile_ParamsSize;

	private static bool AddFile_FilePath_IsValid;

	private static FFieldAddress AddFile_FilePath_PropertyAddress;

	private static int AddFile_FilePath_Offset;

	private static bool AddFile_ReturnValue_IsValid;

	private static FFieldAddress AddFile_ReturnValue_PropertyAddress;

	private static int AddFile_ReturnValue_Offset;

	private static bool Add_IsValid;

	private static IntPtr Add_FunctionAddress;

	private static int Add_ParamsSize;

	private static bool Add_MediaSource_IsValid;

	private static FFieldAddress Add_MediaSource_PropertyAddress;

	private static int Add_MediaSource_Offset;

	private static bool Add_ReturnValue_IsValid;

	private static FFieldAddress Add_ReturnValue_PropertyAddress;

	private static int Add_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:Replace")]
	public unsafe bool Replace(int Index, UMediaSource Replacement)
	{
		CheckDestroyed();
		if (!Replace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:Replace");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Replace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Replace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Replace_Index_Offset), 0, Replace_Index_PropertyAddress.Address, Index);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, Replace_Replacement_Offset), 0, Replace_Replacement_PropertyAddress.Address, Replacement);
		NativeReflection.InvokeFunctionOptimized(base.Address, Replace_FunctionAddress, intPtr, Replace_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Replace_ReturnValue_Offset), 0, Replace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:RemoveAt")]
	public unsafe bool RemoveAt(int Index)
	{
		CheckDestroyed();
		if (!RemoveAt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:RemoveAt");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveAt_Index_Offset), 0, RemoveAt_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAt_FunctionAddress, intPtr, RemoveAt_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAt_ReturnValue_Offset), 0, RemoveAt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:Remove")]
	public unsafe bool Remove(UMediaSource MediaSource)
	{
		CheckDestroyed();
		if (!Remove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:Remove");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Remove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Remove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, Remove_MediaSource_Offset), 0, Remove_MediaSource_PropertyAddress.Address, MediaSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, Remove_FunctionAddress, intPtr, Remove_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Remove_ReturnValue_Offset), 0, Remove_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:Num")]
	public unsafe int Num()
	{
		CheckDestroyed();
		if (!Num_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:Num");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Num_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Num_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Num_FunctionAddress, intPtr, Num_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Num_ReturnValue_Offset), 0, Num_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:Insert")]
	public unsafe void Insert(UMediaSource MediaSource, int Index)
	{
		CheckDestroyed();
		if (!Insert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:Insert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Insert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Insert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, Insert_MediaSource_Offset), 0, Insert_MediaSource_PropertyAddress.Address, MediaSource);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Insert_Index_Offset), 0, Insert_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, Insert_FunctionAddress, intPtr, Insert_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:GetRandom")]
	public unsafe UMediaSource GetRandom(out int OutIndex)
	{
		CheckDestroyed();
		if (!GetRandom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:GetRandom");
			OutIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRandom_FunctionAddress, intPtr, GetRandom_ParamsSize);
		OutIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRandom_OutIndex_Offset), 0, GetRandom_OutIndex_PropertyAddress.Address);
		return UObjectMarshaler<UMediaSource>.FromNative(IntPtr.Add(intPtr, GetRandom_ReturnValue_Offset), 0, GetRandom_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:GetPrevious")]
	public unsafe UMediaSource GetPrevious(out int InOutIndex)
	{
		CheckDestroyed();
		if (!GetPrevious_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:GetPrevious");
			InOutIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrevious_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrevious_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPrevious_FunctionAddress, intPtr, GetPrevious_ParamsSize);
		InOutIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPrevious_InOutIndex_Offset), 0, GetPrevious_InOutIndex_PropertyAddress.Address);
		return UObjectMarshaler<UMediaSource>.FromNative(IntPtr.Add(intPtr, GetPrevious_ReturnValue_Offset), 0, GetPrevious_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:GetNext")]
	public unsafe UMediaSource GetNext(out int InOutIndex)
	{
		CheckDestroyed();
		if (!GetNext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:GetNext");
			InOutIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNext_FunctionAddress, intPtr, GetNext_ParamsSize);
		InOutIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNext_InOutIndex_Offset), 0, GetNext_InOutIndex_PropertyAddress.Address);
		return UObjectMarshaler<UMediaSource>.FromNative(IntPtr.Add(intPtr, GetNext_ReturnValue_Offset), 0, GetNext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:Get")]
	public unsafe UMediaSource Get(int Index)
	{
		CheckDestroyed();
		if (!Get_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:Get");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Get_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Get_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Get_Index_Offset), 0, Get_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, Get_FunctionAddress, intPtr, Get_ParamsSize);
		return UObjectMarshaler<UMediaSource>.FromNative(IntPtr.Add(intPtr, Get_ReturnValue_Offset), 0, Get_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:AddUrl")]
	public unsafe bool AddUrl(string Url)
	{
		CheckDestroyed();
		if (!AddUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:AddUrl");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddUrl_Url_Offset), 0, AddUrl_Url_PropertyAddress.Address, Url);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddUrl_FunctionAddress, intPtr, AddUrl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddUrl_Url_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddUrl_ReturnValue_Offset), 0, AddUrl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:AddFile")]
	public unsafe bool AddFile(string FilePath)
	{
		CheckDestroyed();
		if (!AddFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:AddFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFile_FilePath_Offset), 0, AddFile_FilePath_PropertyAddress.Address, FilePath);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddFile_FunctionAddress, intPtr, AddFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFile_FilePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddFile_ReturnValue_Offset), 0, AddFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.MediaPlaylist:Add")]
	public unsafe bool Add(UMediaSource MediaSource)
	{
		CheckDestroyed();
		if (!Add_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaPlaylist:Add");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Add_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Add_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaSource>.ToNative(IntPtr.Add(intPtr, Add_MediaSource_Offset), 0, Add_MediaSource_PropertyAddress.Address, MediaSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, Add_FunctionAddress, intPtr, Add_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Add_ReturnValue_Offset), 0, Add_ReturnValue_PropertyAddress.Address);
	}

	static UMediaPlaylist()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaPlaylist)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaPlaylist));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MediaAssets.MediaPlaylist");
		Replace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Replace");
		Replace_ParamsSize = NativeReflection.GetFunctionParamsSize(Replace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Replace_Index_PropertyAddress, Replace_FunctionAddress, "Index");
		Replace_Index_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "Index");
		Replace_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Replace_Replacement_PropertyAddress, Replace_FunctionAddress, "Replacement");
		Replace_Replacement_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "Replacement");
		Replace_Replacement_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "Replacement", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Replace_ReturnValue_PropertyAddress, Replace_FunctionAddress, "ReturnValue");
		Replace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Replace_FunctionAddress, "ReturnValue");
		Replace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Replace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Replace_IsValid = Replace_FunctionAddress != IntPtr.Zero && Replace_Index_IsValid && Replace_Replacement_IsValid && Replace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:Replace", Replace_IsValid);
		RemoveAt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAt");
		RemoveAt_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAt_Index_PropertyAddress, RemoveAt_FunctionAddress, "Index");
		RemoveAt_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAt_FunctionAddress, "Index");
		RemoveAt_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAt_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAt_ReturnValue_PropertyAddress, RemoveAt_FunctionAddress, "ReturnValue");
		RemoveAt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAt_FunctionAddress, "ReturnValue");
		RemoveAt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAt_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAt_IsValid = RemoveAt_FunctionAddress != IntPtr.Zero && RemoveAt_Index_IsValid && RemoveAt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:RemoveAt", RemoveAt_IsValid);
		Remove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Remove");
		Remove_ParamsSize = NativeReflection.GetFunctionParamsSize(Remove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Remove_MediaSource_PropertyAddress, Remove_FunctionAddress, "MediaSource");
		Remove_MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(Remove_FunctionAddress, "MediaSource");
		Remove_MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(Remove_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Remove_ReturnValue_PropertyAddress, Remove_FunctionAddress, "ReturnValue");
		Remove_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Remove_FunctionAddress, "ReturnValue");
		Remove_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Remove_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Remove_IsValid = Remove_FunctionAddress != IntPtr.Zero && Remove_MediaSource_IsValid && Remove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:Remove", Remove_IsValid);
		Num_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Num");
		Num_ParamsSize = NativeReflection.GetFunctionParamsSize(Num_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Num_ReturnValue_PropertyAddress, Num_FunctionAddress, "ReturnValue");
		Num_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Num_FunctionAddress, "ReturnValue");
		Num_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Num_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Num_IsValid = Num_FunctionAddress != IntPtr.Zero && Num_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:Num", Num_IsValid);
		Insert_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Insert");
		Insert_ParamsSize = NativeReflection.GetFunctionParamsSize(Insert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Insert_MediaSource_PropertyAddress, Insert_FunctionAddress, "MediaSource");
		Insert_MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(Insert_FunctionAddress, "MediaSource");
		Insert_MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(Insert_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Insert_Index_PropertyAddress, Insert_FunctionAddress, "Index");
		Insert_Index_Offset = NativeReflectionCached.GetPropertyOffset(Insert_FunctionAddress, "Index");
		Insert_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(Insert_FunctionAddress, "Index", Classes.FIntProperty);
		Insert_IsValid = Insert_FunctionAddress != IntPtr.Zero && Insert_MediaSource_IsValid && Insert_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:Insert", Insert_IsValid);
		GetRandom_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRandom");
		GetRandom_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandom_OutIndex_PropertyAddress, GetRandom_FunctionAddress, "OutIndex");
		GetRandom_OutIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetRandom_FunctionAddress, "OutIndex");
		GetRandom_OutIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandom_FunctionAddress, "OutIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandom_ReturnValue_PropertyAddress, GetRandom_FunctionAddress, "ReturnValue");
		GetRandom_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandom_FunctionAddress, "ReturnValue");
		GetRandom_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandom_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRandom_IsValid = GetRandom_FunctionAddress != IntPtr.Zero && GetRandom_OutIndex_IsValid && GetRandom_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:GetRandom", GetRandom_IsValid);
		GetPrevious_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPrevious");
		GetPrevious_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrevious_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrevious_InOutIndex_PropertyAddress, GetPrevious_FunctionAddress, "InOutIndex");
		GetPrevious_InOutIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetPrevious_FunctionAddress, "InOutIndex");
		GetPrevious_InOutIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrevious_FunctionAddress, "InOutIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPrevious_ReturnValue_PropertyAddress, GetPrevious_FunctionAddress, "ReturnValue");
		GetPrevious_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrevious_FunctionAddress, "ReturnValue");
		GetPrevious_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrevious_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPrevious_IsValid = GetPrevious_FunctionAddress != IntPtr.Zero && GetPrevious_InOutIndex_IsValid && GetPrevious_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:GetPrevious", GetPrevious_IsValid);
		GetNext_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNext");
		GetNext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNext_InOutIndex_PropertyAddress, GetNext_FunctionAddress, "InOutIndex");
		GetNext_InOutIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNext_FunctionAddress, "InOutIndex");
		GetNext_InOutIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNext_FunctionAddress, "InOutIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNext_ReturnValue_PropertyAddress, GetNext_FunctionAddress, "ReturnValue");
		GetNext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNext_FunctionAddress, "ReturnValue");
		GetNext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNext_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNext_IsValid = GetNext_FunctionAddress != IntPtr.Zero && GetNext_InOutIndex_IsValid && GetNext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:GetNext", GetNext_IsValid);
		Get_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Get");
		Get_ParamsSize = NativeReflection.GetFunctionParamsSize(Get_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Get_Index_PropertyAddress, Get_FunctionAddress, "Index");
		Get_Index_Offset = NativeReflectionCached.GetPropertyOffset(Get_FunctionAddress, "Index");
		Get_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(Get_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Get_ReturnValue_PropertyAddress, Get_FunctionAddress, "ReturnValue");
		Get_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Get_FunctionAddress, "ReturnValue");
		Get_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Get_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Get_IsValid = Get_FunctionAddress != IntPtr.Zero && Get_Index_IsValid && Get_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:Get", Get_IsValid);
		AddUrl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddUrl");
		AddUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(AddUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddUrl_Url_PropertyAddress, AddUrl_FunctionAddress, "Url");
		AddUrl_Url_Offset = NativeReflectionCached.GetPropertyOffset(AddUrl_FunctionAddress, "Url");
		AddUrl_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUrl_FunctionAddress, "Url", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUrl_ReturnValue_PropertyAddress, AddUrl_FunctionAddress, "ReturnValue");
		AddUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddUrl_FunctionAddress, "ReturnValue");
		AddUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUrl_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddUrl_IsValid = AddUrl_FunctionAddress != IntPtr.Zero && AddUrl_Url_IsValid && AddUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:AddUrl", AddUrl_IsValid);
		AddFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddFile");
		AddFile_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFile_FilePath_PropertyAddress, AddFile_FunctionAddress, "FilePath");
		AddFile_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(AddFile_FunctionAddress, "FilePath");
		AddFile_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFile_FunctionAddress, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFile_ReturnValue_PropertyAddress, AddFile_FunctionAddress, "ReturnValue");
		AddFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFile_FunctionAddress, "ReturnValue");
		AddFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddFile_IsValid = AddFile_FunctionAddress != IntPtr.Zero && AddFile_FilePath_IsValid && AddFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:AddFile", AddFile_IsValid);
		Add_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Add");
		Add_ParamsSize = NativeReflection.GetFunctionParamsSize(Add_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Add_MediaSource_PropertyAddress, Add_FunctionAddress, "MediaSource");
		Add_MediaSource_Offset = NativeReflectionCached.GetPropertyOffset(Add_FunctionAddress, "MediaSource");
		Add_MediaSource_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FunctionAddress, "MediaSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Add_ReturnValue_PropertyAddress, Add_FunctionAddress, "ReturnValue");
		Add_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Add_FunctionAddress, "ReturnValue");
		Add_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Add_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Add_IsValid = Add_FunctionAddress != IntPtr.Zero && Add_MediaSource_IsValid && Add_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaPlaylist:Add", Add_IsValid);
	}
}
