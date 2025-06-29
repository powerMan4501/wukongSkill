using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CinematicPrestreaming;

[UClass(Flags = (ClassFlags)812122272uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection", "CinematicPrestreaming", UnrealModuleType.EnginePlugin)]
public class UMovieSceneCinePrestreamingSection : UMovieSceneSection, IMovieSceneEntityProvider, IInterface
{
	private static bool PrestreamingAsset_IsValid;

	private static int PrestreamingAsset_Offset;

	private static bool StartFrameOffset_IsValid;

	private static int StartFrameOffset_Offset;

	private static bool QualityLevel_IsValid;

	private static int QualityLevel_Offset;

	private static bool SetStartFrameOffset_IsValid;

	private static IntPtr SetStartFrameOffset_FunctionAddress;

	private static int SetStartFrameOffset_ParamsSize;

	private static bool SetStartFrameOffset_InOffset_IsValid;

	private static FFieldAddress SetStartFrameOffset_InOffset_PropertyAddress;

	private static int SetStartFrameOffset_InOffset_Offset;

	private static bool SetQualityLevel_IsValid;

	private static IntPtr SetQualityLevel_FunctionAddress;

	private static int SetQualityLevel_ParamsSize;

	private static bool SetQualityLevel_InLevel_IsValid;

	private static FFieldAddress SetQualityLevel_InLevel_PropertyAddress;

	private static int SetQualityLevel_InLevel_Offset;

	private static bool SetPrestreamingAsset_IsValid;

	private static IntPtr SetPrestreamingAsset_FunctionAddress;

	private static int SetPrestreamingAsset_ParamsSize;

	private static bool SetPrestreamingAsset_InData_IsValid;

	private static FFieldAddress SetPrestreamingAsset_InData_PropertyAddress;

	private static int SetPrestreamingAsset_InData_Offset;

	private static bool GetQualityLevel_IsValid;

	private static IntPtr GetQualityLevel_FunctionAddress;

	private static int GetQualityLevel_ParamsSize;

	private static bool GetQualityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetQualityLevel_ReturnValue_PropertyAddress;

	private static int GetQualityLevel_ReturnValue_Offset;

	private static bool GetPrestreamingAsset_IsValid;

	private static IntPtr GetPrestreamingAsset_FunctionAddress;

	private static int GetPrestreamingAsset_ParamsSize;

	private static bool GetPrestreamingAsset_ReturnValue_IsValid;

	private static FFieldAddress GetPrestreamingAsset_ReturnValue_PropertyAddress;

	private static int GetPrestreamingAsset_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393695068291077uL)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:PrestreamingAsset")]
	protected TSoftObject<UCinePrestreamingData> PrestreamingAsset
	{
		get
		{
			CheckDestroyed();
			if (!PrestreamingAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:PrestreamingAsset");
				return default(TSoftObject<UCinePrestreamingData>);
			}
			return TSoftObjectMarshaler<UCinePrestreamingData>.FromNative(IntPtr.Add(base.Address, PrestreamingAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PrestreamingAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:PrestreamingAsset");
			}
			else
			{
				TSoftObjectMarshaler<UCinePrestreamingData>.ToNative(IntPtr.Add(base.Address, PrestreamingAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:StartFrameOffset")]
	protected int StartFrameOffset
	{
		get
		{
			CheckDestroyed();
			if (!StartFrameOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:StartFrameOffset");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartFrameOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartFrameOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:StartFrameOffset");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartFrameOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272263001178629uL)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:QualityLevel")]
	protected int QualityLevel
	{
		get
		{
			CheckDestroyed();
			if (!QualityLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:QualityLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, QualityLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QualityLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:QualityLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, QualityLevel_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetStartFrameOffset")]
	public unsafe void SetStartFrameOffset(int InOffset)
	{
		CheckDestroyed();
		if (!SetStartFrameOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetStartFrameOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartFrameOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartFrameOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetStartFrameOffset_InOffset_Offset), 0, SetStartFrameOffset_InOffset_PropertyAddress.Address, InOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartFrameOffset_FunctionAddress, intPtr, SetStartFrameOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetQualityLevel")]
	public unsafe void SetQualityLevel(int InLevel)
	{
		CheckDestroyed();
		if (!SetQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetQualityLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetQualityLevel_InLevel_Offset), 0, SetQualityLevel_InLevel_PropertyAddress.Address, InLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetQualityLevel_FunctionAddress, intPtr, SetQualityLevel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetPrestreamingAsset")]
	public unsafe void SetPrestreamingAsset(UCinePrestreamingData InData)
	{
		CheckDestroyed();
		if (!SetPrestreamingAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetPrestreamingAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPrestreamingAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPrestreamingAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCinePrestreamingData>.ToNative(IntPtr.Add(intPtr, SetPrestreamingAsset_InData_Offset), 0, SetPrestreamingAsset_InData_PropertyAddress.Address, InData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPrestreamingAsset_FunctionAddress, intPtr, SetPrestreamingAsset_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:GetQualityLevel")]
	public unsafe int GetQualityLevel()
	{
		CheckDestroyed();
		if (!GetQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:GetQualityLevel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQualityLevel_FunctionAddress, intPtr, GetQualityLevel_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetQualityLevel_ReturnValue_Offset), 0, GetQualityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:GetPrestreamingAsset")]
	public unsafe TSoftObject<UCinePrestreamingData> GetPrestreamingAsset()
	{
		CheckDestroyed();
		if (!GetPrestreamingAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:GetPrestreamingAsset");
			return default(TSoftObject<UCinePrestreamingData>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrestreamingAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrestreamingAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPrestreamingAsset_FunctionAddress, intPtr, GetPrestreamingAsset_ParamsSize);
		TSoftObject<UCinePrestreamingData> result = TSoftObjectMarshaler<UCinePrestreamingData>.FromNative(IntPtr.Add(intPtr, GetPrestreamingAsset_ReturnValue_Offset), 0, GetPrestreamingAsset_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPrestreamingAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMovieSceneCinePrestreamingSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCinePrestreamingSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCinePrestreamingSection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection");
		PrestreamingAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrestreamingAsset");
		PrestreamingAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrestreamingAsset", Classes.FSoftObjectProperty);
		StartFrameOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartFrameOffset");
		StartFrameOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartFrameOffset", Classes.FIntProperty);
		QualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QualityLevel");
		QualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QualityLevel", Classes.FIntProperty);
		SetStartFrameOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStartFrameOffset");
		SetStartFrameOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartFrameOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartFrameOffset_InOffset_PropertyAddress, SetStartFrameOffset_FunctionAddress, "InOffset");
		SetStartFrameOffset_InOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetStartFrameOffset_FunctionAddress, "InOffset");
		SetStartFrameOffset_InOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartFrameOffset_FunctionAddress, "InOffset", Classes.FIntProperty);
		SetStartFrameOffset_IsValid = SetStartFrameOffset_FunctionAddress != IntPtr.Zero && SetStartFrameOffset_InOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetStartFrameOffset", SetStartFrameOffset_IsValid);
		SetQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetQualityLevel");
		SetQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetQualityLevel_InLevel_PropertyAddress, SetQualityLevel_FunctionAddress, "InLevel");
		SetQualityLevel_InLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetQualityLevel_FunctionAddress, "InLevel");
		SetQualityLevel_InLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQualityLevel_FunctionAddress, "InLevel", Classes.FIntProperty);
		SetQualityLevel_IsValid = SetQualityLevel_FunctionAddress != IntPtr.Zero && SetQualityLevel_InLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetQualityLevel", SetQualityLevel_IsValid);
		SetPrestreamingAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPrestreamingAsset");
		SetPrestreamingAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPrestreamingAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPrestreamingAsset_InData_PropertyAddress, SetPrestreamingAsset_FunctionAddress, "InData");
		SetPrestreamingAsset_InData_Offset = NativeReflectionCached.GetPropertyOffset(SetPrestreamingAsset_FunctionAddress, "InData");
		SetPrestreamingAsset_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPrestreamingAsset_FunctionAddress, "InData", Classes.FObjectProperty);
		SetPrestreamingAsset_IsValid = SetPrestreamingAsset_FunctionAddress != IntPtr.Zero && SetPrestreamingAsset_InData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:SetPrestreamingAsset", SetPrestreamingAsset_IsValid);
		GetQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetQualityLevel");
		GetQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQualityLevel_ReturnValue_PropertyAddress, GetQualityLevel_FunctionAddress, "ReturnValue");
		GetQualityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQualityLevel_FunctionAddress, "ReturnValue");
		GetQualityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQualityLevel_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetQualityLevel_IsValid = GetQualityLevel_FunctionAddress != IntPtr.Zero && GetQualityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:GetQualityLevel", GetQualityLevel_IsValid);
		GetPrestreamingAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPrestreamingAsset");
		GetPrestreamingAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrestreamingAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrestreamingAsset_ReturnValue_PropertyAddress, GetPrestreamingAsset_FunctionAddress, "ReturnValue");
		GetPrestreamingAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrestreamingAsset_FunctionAddress, "ReturnValue");
		GetPrestreamingAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrestreamingAsset_FunctionAddress, "ReturnValue", Classes.FSoftObjectProperty);
		GetPrestreamingAsset_IsValid = GetPrestreamingAsset_FunctionAddress != IntPtr.Zero && GetPrestreamingAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreaming.MovieSceneCinePrestreamingSection:GetPrestreamingAsset", GetPrestreamingAsset_IsValid);
	}
}
