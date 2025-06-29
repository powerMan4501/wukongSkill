using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[Abstract]
[UClass(Flags = (ClassFlags)812646561uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection", "Calliope", UnrealModuleType.GamePlugin)]
public class UMovieSceneCalliopeNormalSection : UMovieSceneCalliopeSectionBase
{
	private static bool SectionNameForShow_IsValid;

	private static int SectionNameForShow_Offset;

	private static bool SectionBeingDestroyed_IsValid;

	private IntPtr SectionBeingDestroyed_InstanceFunctionAddress;

	private static IntPtr SectionBeingDestroyed_FunctionAddress;

	private static int SectionBeingDestroyed_ParamsSize;

	private static bool SectionBeingDestroyed_InSectionData_IsValid;

	private static FFieldAddress SectionBeingDestroyed_InSectionData_PropertyAddress;

	private static int SectionBeingDestroyed_InSectionData_Offset;

	private static bool MakeSectionData_IsValid;

	private IntPtr MakeSectionData_InstanceFunctionAddress;

	private static IntPtr MakeSectionData_FunctionAddress;

	private static int MakeSectionData_ParamsSize;

	private static bool MakeSectionData_ReturnValue_IsValid;

	private static FFieldAddress MakeSectionData_ReturnValue_PropertyAddress;

	private static int MakeSectionData_ReturnValue_Offset;

	private static bool GetStartTime_IsValid;

	private static IntPtr GetStartTime_FunctionAddress;

	private static int GetStartTime_ParamsSize;

	private static bool GetStartTime_ReturnValue_IsValid;

	private static FFieldAddress GetStartTime_ReturnValue_PropertyAddress;

	private static int GetStartTime_ReturnValue_Offset;

	private static bool GetMovieMaxDuration_IsValid;

	private static IntPtr GetMovieMaxDuration_FunctionAddress;

	private static int GetMovieMaxDuration_ParamsSize;

	private static bool GetMovieMaxDuration_ReturnValue_IsValid;

	private static FFieldAddress GetMovieMaxDuration_ReturnValue_PropertyAddress;

	private static int GetMovieMaxDuration_ReturnValue_Offset;

	private static bool GetEndTime_IsValid;

	private static IntPtr GetEndTime_FunctionAddress;

	private static int GetEndTime_ParamsSize;

	private static bool GetEndTime_ReturnValue_IsValid;

	private static FFieldAddress GetEndTime_ReturnValue_PropertyAddress;

	private static int GetEndTime_ReturnValue_Offset;

	private static bool GetDurationTime_IsValid;

	private IntPtr GetDurationTime_InstanceFunctionAddress;

	private static IntPtr GetDurationTime_FunctionAddress;

	private static int GetDurationTime_ParamsSize;

	private static bool GetDurationTime_ReturnValue_IsValid;

	private static FFieldAddress GetDurationTime_ReturnValue_PropertyAddress;

	private static int GetDurationTime_ReturnValue_Offset;

	private static bool Evaluate_IsValid;

	private IntPtr Evaluate_InstanceFunctionAddress;

	private static IntPtr Evaluate_FunctionAddress;

	private static int Evaluate_ParamsSize;

	private static bool Evaluate_InSectionData_IsValid;

	private static FFieldAddress Evaluate_InSectionData_PropertyAddress;

	private static int Evaluate_InSectionData_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:SectionNameForShow")]
	public FName SectionNameForShow
	{
		get
		{
			CheckDestroyed();
			if (!SectionNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:SectionNameForShow");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SectionNameForShow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:SectionNameForShow");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SectionNameForShow_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:SectionBeingDestroyed")]
	public unsafe void SectionBeingDestroyed(UMovieSceneCalliopeSectionData InSectionData)
	{
		CheckDestroyed();
		if (!SectionBeingDestroyed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:SectionBeingDestroyed");
			return;
		}
		if (SectionBeingDestroyed_InstanceFunctionAddress == IntPtr.Zero)
		{
			SectionBeingDestroyed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SectionBeingDestroyed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SectionBeingDestroyed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SectionBeingDestroyed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneCalliopeSectionData>.ToNative(IntPtr.Add(intPtr, SectionBeingDestroyed_InSectionData_Offset), 0, SectionBeingDestroyed_InSectionData_PropertyAddress.Address, InSectionData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SectionBeingDestroyed_InstanceFunctionAddress, intPtr, SectionBeingDestroyed_ParamsSize);
	}

	protected unsafe virtual void SectionBeingDestroyed_Implementation(UMovieSceneCalliopeSectionData InSectionData)
	{
		CheckDestroyed();
		if (!SectionBeingDestroyed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:SectionBeingDestroyed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SectionBeingDestroyed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SectionBeingDestroyed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneCalliopeSectionData>.ToNative(IntPtr.Add(intPtr, SectionBeingDestroyed_InSectionData_Offset), 0, SectionBeingDestroyed_InSectionData_PropertyAddress.Address, InSectionData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SectionBeingDestroyed_FunctionAddress, intPtr, SectionBeingDestroyed_ParamsSize);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:MakeSectionData")]
	public unsafe UMovieSceneCalliopeSectionData MakeSectionData()
	{
		CheckDestroyed();
		if (!MakeSectionData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:MakeSectionData");
			return null;
		}
		if (MakeSectionData_InstanceFunctionAddress == IntPtr.Zero)
		{
			MakeSectionData_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "MakeSectionData");
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeSectionData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeSectionData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeSectionData_InstanceFunctionAddress, intPtr, MakeSectionData_ParamsSize);
		return UObjectMarshaler<UMovieSceneCalliopeSectionData>.FromNative(IntPtr.Add(intPtr, MakeSectionData_ReturnValue_Offset), 0, MakeSectionData_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual UMovieSceneCalliopeSectionData MakeSectionData_Implementation()
	{
		CheckDestroyed();
		if (!MakeSectionData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:MakeSectionData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeSectionData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeSectionData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeSectionData_FunctionAddress, intPtr, MakeSectionData_ParamsSize);
		return UObjectMarshaler<UMovieSceneCalliopeSectionData>.FromNative(IntPtr.Add(intPtr, MakeSectionData_ReturnValue_Offset), 0, MakeSectionData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:GetStartTime")]
	public unsafe float GetStartTime()
	{
		CheckDestroyed();
		if (!GetStartTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:GetStartTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartTime_FunctionAddress, intPtr, GetStartTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStartTime_ReturnValue_Offset), 0, GetStartTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:GetMovieMaxDuration")]
	public unsafe float GetMovieMaxDuration()
	{
		CheckDestroyed();
		if (!GetMovieMaxDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:GetMovieMaxDuration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMovieMaxDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMovieMaxDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMovieMaxDuration_FunctionAddress, intPtr, GetMovieMaxDuration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMovieMaxDuration_ReturnValue_Offset), 0, GetMovieMaxDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:GetEndTime")]
	public unsafe float GetEndTime()
	{
		CheckDestroyed();
		if (!GetEndTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:GetEndTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndTime_FunctionAddress, intPtr, GetEndTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEndTime_ReturnValue_Offset), 0, GetEndTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:GetDurationTime")]
	public unsafe float GetDurationTime()
	{
		CheckDestroyed();
		if (!GetDurationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:GetDurationTime");
			return 0f;
		}
		if (GetDurationTime_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDurationTime_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDurationTime");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDurationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDurationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDurationTime_InstanceFunctionAddress, intPtr, GetDurationTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDurationTime_ReturnValue_Offset), 0, GetDurationTime_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual float GetDurationTime_Implementation()
	{
		CheckDestroyed();
		if (!GetDurationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:GetDurationTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDurationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDurationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDurationTime_FunctionAddress, intPtr, GetDurationTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDurationTime_ReturnValue_Offset), 0, GetDurationTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.MovieSceneCalliopeNormalSection:Evaluate")]
	public unsafe void Evaluate(UMovieSceneCalliopeSectionData InSectionData)
	{
		CheckDestroyed();
		if (!Evaluate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:Evaluate");
			return;
		}
		if (Evaluate_InstanceFunctionAddress == IntPtr.Zero)
		{
			Evaluate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Evaluate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Evaluate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Evaluate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneCalliopeSectionData>.ToNative(IntPtr.Add(intPtr, Evaluate_InSectionData_Offset), 0, Evaluate_InSectionData_PropertyAddress.Address, InSectionData);
		NativeReflection.InvokeFunctionOptimized(base.Address, Evaluate_InstanceFunctionAddress, intPtr, Evaluate_ParamsSize);
	}

	protected unsafe virtual void Evaluate_Implementation(UMovieSceneCalliopeSectionData InSectionData)
	{
		CheckDestroyed();
		if (!Evaluate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.MovieSceneCalliopeNormalSection:Evaluate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Evaluate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Evaluate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneCalliopeSectionData>.ToNative(IntPtr.Add(intPtr, Evaluate_InSectionData_Offset), 0, Evaluate_InSectionData_PropertyAddress.Address, InSectionData);
		NativeReflection.InvokeFunctionOptimized(base.Address, Evaluate_FunctionAddress, intPtr, Evaluate_ParamsSize);
	}

	static UMovieSceneCalliopeNormalSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneCalliopeNormalSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneCalliopeNormalSection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.MovieSceneCalliopeNormalSection");
		SectionNameForShow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectionNameForShow");
		SectionNameForShow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectionNameForShow", Classes.FNameProperty);
		SectionBeingDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SectionBeingDestroyed");
		SectionBeingDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(SectionBeingDestroyed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SectionBeingDestroyed_InSectionData_PropertyAddress, SectionBeingDestroyed_FunctionAddress, "InSectionData");
		SectionBeingDestroyed_InSectionData_Offset = NativeReflectionCached.GetPropertyOffset(SectionBeingDestroyed_FunctionAddress, "InSectionData");
		SectionBeingDestroyed_InSectionData_IsValid = NativeReflectionCached.ValidatePropertyClass(SectionBeingDestroyed_FunctionAddress, "InSectionData", Classes.FObjectProperty);
		SectionBeingDestroyed_IsValid = SectionBeingDestroyed_FunctionAddress != IntPtr.Zero && SectionBeingDestroyed_InSectionData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNormalSection:SectionBeingDestroyed", SectionBeingDestroyed_IsValid);
		MakeSectionData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeSectionData");
		MakeSectionData_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeSectionData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeSectionData_ReturnValue_PropertyAddress, MakeSectionData_FunctionAddress, "ReturnValue");
		MakeSectionData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeSectionData_FunctionAddress, "ReturnValue");
		MakeSectionData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeSectionData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MakeSectionData_IsValid = MakeSectionData_FunctionAddress != IntPtr.Zero && MakeSectionData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNormalSection:MakeSectionData", MakeSectionData_IsValid);
		GetStartTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartTime");
		GetStartTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartTime_ReturnValue_PropertyAddress, GetStartTime_FunctionAddress, "ReturnValue");
		GetStartTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartTime_FunctionAddress, "ReturnValue");
		GetStartTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStartTime_IsValid = GetStartTime_FunctionAddress != IntPtr.Zero && GetStartTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNormalSection:GetStartTime", GetStartTime_IsValid);
		GetMovieMaxDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMovieMaxDuration");
		GetMovieMaxDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMovieMaxDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMovieMaxDuration_ReturnValue_PropertyAddress, GetMovieMaxDuration_FunctionAddress, "ReturnValue");
		GetMovieMaxDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMovieMaxDuration_FunctionAddress, "ReturnValue");
		GetMovieMaxDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMovieMaxDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMovieMaxDuration_IsValid = GetMovieMaxDuration_FunctionAddress != IntPtr.Zero && GetMovieMaxDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNormalSection:GetMovieMaxDuration", GetMovieMaxDuration_IsValid);
		GetEndTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEndTime");
		GetEndTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndTime_ReturnValue_PropertyAddress, GetEndTime_FunctionAddress, "ReturnValue");
		GetEndTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndTime_FunctionAddress, "ReturnValue");
		GetEndTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEndTime_IsValid = GetEndTime_FunctionAddress != IntPtr.Zero && GetEndTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNormalSection:GetEndTime", GetEndTime_IsValid);
		GetDurationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDurationTime");
		GetDurationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDurationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDurationTime_ReturnValue_PropertyAddress, GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDurationTime_FunctionAddress, "ReturnValue");
		GetDurationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDurationTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDurationTime_IsValid = GetDurationTime_FunctionAddress != IntPtr.Zero && GetDurationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNormalSection:GetDurationTime", GetDurationTime_IsValid);
		Evaluate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Evaluate");
		Evaluate_ParamsSize = NativeReflection.GetFunctionParamsSize(Evaluate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Evaluate_InSectionData_PropertyAddress, Evaluate_FunctionAddress, "InSectionData");
		Evaluate_InSectionData_Offset = NativeReflectionCached.GetPropertyOffset(Evaluate_FunctionAddress, "InSectionData");
		Evaluate_InSectionData_IsValid = NativeReflectionCached.ValidatePropertyClass(Evaluate_FunctionAddress, "InSectionData", Classes.FObjectProperty);
		Evaluate_IsValid = Evaluate_FunctionAddress != IntPtr.Zero && Evaluate_InSectionData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.MovieSceneCalliopeNormalSection:Evaluate", Evaluate_IsValid);
	}
}
