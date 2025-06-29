using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Plugins.SequencerScripting;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LevelSequenceEditor;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem", "LevelSequenceEditor", UnrealModuleType.EnginePlugin)]
public class ULevelSequenceEditorSubsystem : UEditorSubsystem
{
	private static bool SyncSectionsUsingSourceTimecode_IsValid;

	private static IntPtr SyncSectionsUsingSourceTimecode_FunctionAddress;

	private static int SyncSectionsUsingSourceTimecode_ParamsSize;

	private static bool SyncSectionsUsingSourceTimecode_Sections_IsValid;

	private static FFieldAddress SyncSectionsUsingSourceTimecode_Sections_PropertyAddress;

	private static int SyncSectionsUsingSourceTimecode_Sections_Offset;

	private static bool SnapSectionsToTimelineUsingSourceTimecode_IsValid;

	private static IntPtr SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress;

	private static int SnapSectionsToTimelineUsingSourceTimecode_ParamsSize;

	private static bool SnapSectionsToTimelineUsingSourceTimecode_Sections_IsValid;

	private static FFieldAddress SnapSectionsToTimelineUsingSourceTimecode_Sections_PropertyAddress;

	private static int SnapSectionsToTimelineUsingSourceTimecode_Sections_Offset;

	private static bool ReplaceBindingWithActors_IsValid;

	private static IntPtr ReplaceBindingWithActors_FunctionAddress;

	private static int ReplaceBindingWithActors_ParamsSize;

	private static bool ReplaceBindingWithActors_Actors_IsValid;

	private static FFieldAddress ReplaceBindingWithActors_Actors_PropertyAddress;

	private static int ReplaceBindingWithActors_Actors_Offset;

	private static bool ReplaceBindingWithActors_ObjectBinding_IsValid;

	private static FFieldAddress ReplaceBindingWithActors_ObjectBinding_PropertyAddress;

	private static int ReplaceBindingWithActors_ObjectBinding_Offset;

	private static bool RemoveInvalidBindings_IsValid;

	private static IntPtr RemoveInvalidBindings_FunctionAddress;

	private static int RemoveInvalidBindings_ParamsSize;

	private static bool RemoveInvalidBindings_ObjectBinding_IsValid;

	private static FFieldAddress RemoveInvalidBindings_ObjectBinding_PropertyAddress;

	private static int RemoveInvalidBindings_ObjectBinding_Offset;

	private static bool RemoveAllBindings_IsValid;

	private static IntPtr RemoveAllBindings_FunctionAddress;

	private static int RemoveAllBindings_ParamsSize;

	private static bool RemoveAllBindings_ObjectBinding_IsValid;

	private static FFieldAddress RemoveAllBindings_ObjectBinding_PropertyAddress;

	private static int RemoveAllBindings_ObjectBinding_Offset;

	private static bool RemoveActorsFromBinding_IsValid;

	private static IntPtr RemoveActorsFromBinding_FunctionAddress;

	private static int RemoveActorsFromBinding_ParamsSize;

	private static bool RemoveActorsFromBinding_Actors_IsValid;

	private static FFieldAddress RemoveActorsFromBinding_Actors_PropertyAddress;

	private static int RemoveActorsFromBinding_Actors_Offset;

	private static bool RemoveActorsFromBinding_ObjectBinding_IsValid;

	private static FFieldAddress RemoveActorsFromBinding_ObjectBinding_PropertyAddress;

	private static int RemoveActorsFromBinding_ObjectBinding_Offset;

	private static bool RebindComponent_IsValid;

	private static IntPtr RebindComponent_FunctionAddress;

	private static int RebindComponent_ParamsSize;

	private static bool RebindComponent_ComponentBindings_IsValid;

	private static FFieldAddress RebindComponent_ComponentBindings_PropertyAddress;

	private static int RebindComponent_ComponentBindings_Offset;

	private static bool RebindComponent_ComponentName_IsValid;

	private static FFieldAddress RebindComponent_ComponentName_PropertyAddress;

	private static int RebindComponent_ComponentName_Offset;

	private static bool FixActorReferences_IsValid;

	private static IntPtr FixActorReferences_FunctionAddress;

	private static int FixActorReferences_ParamsSize;

	private static bool BakeTransform_IsValid;

	private static IntPtr BakeTransform_FunctionAddress;

	private static int BakeTransform_ParamsSize;

	private static bool BakeTransform_ObjectBindings_IsValid;

	private static FFieldAddress BakeTransform_ObjectBindings_PropertyAddress;

	private static int BakeTransform_ObjectBindings_Offset;

	private static bool BakeTransform_BakeInTime_IsValid;

	private static FFieldAddress BakeTransform_BakeInTime_PropertyAddress;

	private static int BakeTransform_BakeInTime_Offset;

	private static bool BakeTransform_BakeOutTime_IsValid;

	private static FFieldAddress BakeTransform_BakeOutTime_PropertyAddress;

	private static int BakeTransform_BakeOutTime_Offset;

	private static bool BakeTransform_BakeInterval_IsValid;

	private static FFieldAddress BakeTransform_BakeInterval_PropertyAddress;

	private static int BakeTransform_BakeInterval_Offset;

	private static bool BakeTransform_Params_IsValid;

	private static FFieldAddress BakeTransform_Params_PropertyAddress;

	private static int BakeTransform_Params_Offset;

	private static bool AddActorsToBinding_IsValid;

	private static IntPtr AddActorsToBinding_FunctionAddress;

	private static int AddActorsToBinding_ParamsSize;

	private static bool AddActorsToBinding_Actors_IsValid;

	private static FFieldAddress AddActorsToBinding_Actors_PropertyAddress;

	private static int AddActorsToBinding_Actors_Offset;

	private static bool AddActorsToBinding_ObjectBinding_IsValid;

	private static FFieldAddress AddActorsToBinding_ObjectBinding_PropertyAddress;

	private static int AddActorsToBinding_ObjectBinding_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:SyncSectionsUsingSourceTimecode")]
	public unsafe void SyncSectionsUsingSourceTimecode(List<UMovieSceneSection> Sections)
	{
		CheckDestroyed();
		if (!SyncSectionsUsingSourceTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:SyncSectionsUsingSourceTimecode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncSectionsUsingSourceTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncSectionsUsingSourceTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMovieSceneSection>(1, SyncSectionsUsingSourceTimecode_Sections_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).ToNative(IntPtr.Add(intPtr, SyncSectionsUsingSourceTimecode_Sections_Offset), Sections);
		NativeReflection.InvokeFunctionOptimized(base.Address, SyncSectionsUsingSourceTimecode_FunctionAddress, intPtr, SyncSectionsUsingSourceTimecode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SyncSectionsUsingSourceTimecode_Sections_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:SnapSectionsToTimelineUsingSourceTimecode")]
	public unsafe void SnapSectionsToTimelineUsingSourceTimecode(List<UMovieSceneSection> Sections)
	{
		CheckDestroyed();
		if (!SnapSectionsToTimelineUsingSourceTimecode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:SnapSectionsToTimelineUsingSourceTimecode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SnapSectionsToTimelineUsingSourceTimecode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SnapSectionsToTimelineUsingSourceTimecode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UMovieSceneSection>(1, SnapSectionsToTimelineUsingSourceTimecode_Sections_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).ToNative(IntPtr.Add(intPtr, SnapSectionsToTimelineUsingSourceTimecode_Sections_Offset), Sections);
		NativeReflection.InvokeFunctionOptimized(base.Address, SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress, intPtr, SnapSectionsToTimelineUsingSourceTimecode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SnapSectionsToTimelineUsingSourceTimecode_Sections_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:ReplaceBindingWithActors")]
	public unsafe void ReplaceBindingWithActors(List<AActor> Actors, FSequencerBindingProxy ObjectBinding)
	{
		CheckDestroyed();
		if (!ReplaceBindingWithActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:ReplaceBindingWithActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceBindingWithActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceBindingWithActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ReplaceBindingWithActors_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceBindingWithActors_Actors_Offset), Actors);
		NativeReflection.InitializeValue_InContainer(ReplaceBindingWithActors_ObjectBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, ReplaceBindingWithActors_ObjectBinding_Offset), 0, ReplaceBindingWithActors_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceBindingWithActors_FunctionAddress, intPtr, ReplaceBindingWithActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceBindingWithActors_Actors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveInvalidBindings")]
	public unsafe void RemoveInvalidBindings(FSequencerBindingProxy ObjectBinding)
	{
		CheckDestroyed();
		if (!RemoveInvalidBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveInvalidBindings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveInvalidBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveInvalidBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveInvalidBindings_ObjectBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, RemoveInvalidBindings_ObjectBinding_Offset), 0, RemoveInvalidBindings_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveInvalidBindings_FunctionAddress, intPtr, RemoveInvalidBindings_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveAllBindings")]
	public unsafe void RemoveAllBindings(FSequencerBindingProxy ObjectBinding)
	{
		CheckDestroyed();
		if (!RemoveAllBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveAllBindings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveAllBindings_ObjectBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, RemoveAllBindings_ObjectBinding_Offset), 0, RemoveAllBindings_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllBindings_FunctionAddress, intPtr, RemoveAllBindings_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveActorsFromBinding")]
	public unsafe void RemoveActorsFromBinding(List<AActor> Actors, FSequencerBindingProxy ObjectBinding)
	{
		CheckDestroyed();
		if (!RemoveActorsFromBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveActorsFromBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveActorsFromBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveActorsFromBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, RemoveActorsFromBinding_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveActorsFromBinding_Actors_Offset), Actors);
		NativeReflection.InitializeValue_InContainer(RemoveActorsFromBinding_ObjectBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, RemoveActorsFromBinding_ObjectBinding_Offset), 0, RemoveActorsFromBinding_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveActorsFromBinding_FunctionAddress, intPtr, RemoveActorsFromBinding_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveActorsFromBinding_Actors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RebindComponent")]
	public unsafe void RebindComponent(List<FSequencerBindingProxy> ComponentBindings, FName ComponentName)
	{
		CheckDestroyed();
		if (!RebindComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RebindComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RebindComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RebindComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSequencerBindingProxy>(1, RebindComponent_ComponentBindings_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).ToNative(IntPtr.Add(intPtr, RebindComponent_ComponentBindings_Offset), ComponentBindings);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RebindComponent_ComponentName_Offset), 0, RebindComponent_ComponentName_PropertyAddress.Address, ComponentName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RebindComponent_FunctionAddress, intPtr, RebindComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RebindComponent_ComponentBindings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:FixActorReferences")]
	public unsafe void FixActorReferences()
	{
		CheckDestroyed();
		if (!FixActorReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:FixActorReferences");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixActorReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixActorReferences_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FixActorReferences_FunctionAddress, argsSize: FixActorReferences_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:BakeTransform")]
	public unsafe void BakeTransform(List<FSequencerBindingProxy> ObjectBindings, FFrameTime BakeInTime, FFrameTime BakeOutTime, FFrameTime BakeInterval, FMovieSceneScriptingParams Params)
	{
		CheckDestroyed();
		if (!BakeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:BakeTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BakeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BakeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSequencerBindingProxy>(1, BakeTransform_ObjectBindings_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).ToNative(IntPtr.Add(intPtr, BakeTransform_ObjectBindings_Offset), ObjectBindings);
		NativeReflection.InitializeValue_InContainer(BakeTransform_BakeInTime_PropertyAddress.Address, intPtr);
		FFrameTime.ToNative(IntPtr.Add(intPtr, BakeTransform_BakeInTime_Offset), 0, BakeTransform_BakeInTime_PropertyAddress.Address, BakeInTime);
		NativeReflection.InitializeValue_InContainer(BakeTransform_BakeOutTime_PropertyAddress.Address, intPtr);
		FFrameTime.ToNative(IntPtr.Add(intPtr, BakeTransform_BakeOutTime_Offset), 0, BakeTransform_BakeOutTime_PropertyAddress.Address, BakeOutTime);
		NativeReflection.InitializeValue_InContainer(BakeTransform_BakeInterval_PropertyAddress.Address, intPtr);
		FFrameTime.ToNative(IntPtr.Add(intPtr, BakeTransform_BakeInterval_Offset), 0, BakeTransform_BakeInterval_PropertyAddress.Address, BakeInterval);
		NativeReflection.InitializeValue_InContainer(BakeTransform_Params_PropertyAddress.Address, intPtr);
		FMovieSceneScriptingParams.ToNative(IntPtr.Add(intPtr, BakeTransform_Params_Offset), 0, BakeTransform_Params_PropertyAddress.Address, Params);
		NativeReflection.InvokeFunctionOptimized(base.Address, BakeTransform_FunctionAddress, intPtr, BakeTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BakeTransform_ObjectBindings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:AddActorsToBinding")]
	public unsafe void AddActorsToBinding(List<AActor> Actors, FSequencerBindingProxy ObjectBinding)
	{
		CheckDestroyed();
		if (!AddActorsToBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:AddActorsToBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorsToBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorsToBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, AddActorsToBinding_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, AddActorsToBinding_Actors_Offset), Actors);
		NativeReflection.InitializeValue_InContainer(AddActorsToBinding_ObjectBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, AddActorsToBinding_ObjectBinding_Offset), 0, AddActorsToBinding_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorsToBinding_FunctionAddress, intPtr, AddActorsToBinding_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddActorsToBinding_Actors_PropertyAddress.Address, intPtr);
	}

	static ULevelSequenceEditorSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULevelSequenceEditorSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULevelSequenceEditorSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem");
		SyncSectionsUsingSourceTimecode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SyncSectionsUsingSourceTimecode");
		SyncSectionsUsingSourceTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncSectionsUsingSourceTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SyncSectionsUsingSourceTimecode_Sections_PropertyAddress, SyncSectionsUsingSourceTimecode_FunctionAddress, "Sections");
		SyncSectionsUsingSourceTimecode_Sections_Offset = NativeReflectionCached.GetPropertyOffset(SyncSectionsUsingSourceTimecode_FunctionAddress, "Sections");
		SyncSectionsUsingSourceTimecode_Sections_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncSectionsUsingSourceTimecode_FunctionAddress, "Sections", Classes.FArrayProperty);
		SyncSectionsUsingSourceTimecode_IsValid = SyncSectionsUsingSourceTimecode_FunctionAddress != IntPtr.Zero && SyncSectionsUsingSourceTimecode_Sections_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:SyncSectionsUsingSourceTimecode", SyncSectionsUsingSourceTimecode_IsValid);
		SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SnapSectionsToTimelineUsingSourceTimecode");
		SnapSectionsToTimelineUsingSourceTimecode_ParamsSize = NativeReflection.GetFunctionParamsSize(SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SnapSectionsToTimelineUsingSourceTimecode_Sections_PropertyAddress, SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress, "Sections");
		SnapSectionsToTimelineUsingSourceTimecode_Sections_Offset = NativeReflectionCached.GetPropertyOffset(SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress, "Sections");
		SnapSectionsToTimelineUsingSourceTimecode_Sections_IsValid = NativeReflectionCached.ValidatePropertyClass(SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress, "Sections", Classes.FArrayProperty);
		SnapSectionsToTimelineUsingSourceTimecode_IsValid = SnapSectionsToTimelineUsingSourceTimecode_FunctionAddress != IntPtr.Zero && SnapSectionsToTimelineUsingSourceTimecode_Sections_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:SnapSectionsToTimelineUsingSourceTimecode", SnapSectionsToTimelineUsingSourceTimecode_IsValid);
		ReplaceBindingWithActors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReplaceBindingWithActors");
		ReplaceBindingWithActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceBindingWithActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceBindingWithActors_Actors_PropertyAddress, ReplaceBindingWithActors_FunctionAddress, "Actors");
		ReplaceBindingWithActors_Actors_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceBindingWithActors_FunctionAddress, "Actors");
		ReplaceBindingWithActors_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceBindingWithActors_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceBindingWithActors_ObjectBinding_PropertyAddress, ReplaceBindingWithActors_FunctionAddress, "ObjectBinding");
		ReplaceBindingWithActors_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceBindingWithActors_FunctionAddress, "ObjectBinding");
		ReplaceBindingWithActors_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceBindingWithActors_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		ReplaceBindingWithActors_IsValid = ReplaceBindingWithActors_FunctionAddress != IntPtr.Zero && ReplaceBindingWithActors_Actors_IsValid && ReplaceBindingWithActors_ObjectBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:ReplaceBindingWithActors", ReplaceBindingWithActors_IsValid);
		RemoveInvalidBindings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveInvalidBindings");
		RemoveInvalidBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInvalidBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveInvalidBindings_ObjectBinding_PropertyAddress, RemoveInvalidBindings_FunctionAddress, "ObjectBinding");
		RemoveInvalidBindings_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInvalidBindings_FunctionAddress, "ObjectBinding");
		RemoveInvalidBindings_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInvalidBindings_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		RemoveInvalidBindings_IsValid = RemoveInvalidBindings_FunctionAddress != IntPtr.Zero && RemoveInvalidBindings_ObjectBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveInvalidBindings", RemoveInvalidBindings_IsValid);
		RemoveAllBindings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllBindings");
		RemoveAllBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllBindings_ObjectBinding_PropertyAddress, RemoveAllBindings_FunctionAddress, "ObjectBinding");
		RemoveAllBindings_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllBindings_FunctionAddress, "ObjectBinding");
		RemoveAllBindings_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllBindings_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		RemoveAllBindings_IsValid = RemoveAllBindings_FunctionAddress != IntPtr.Zero && RemoveAllBindings_ObjectBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveAllBindings", RemoveAllBindings_IsValid);
		RemoveActorsFromBinding_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveActorsFromBinding");
		RemoveActorsFromBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveActorsFromBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveActorsFromBinding_Actors_PropertyAddress, RemoveActorsFromBinding_FunctionAddress, "Actors");
		RemoveActorsFromBinding_Actors_Offset = NativeReflectionCached.GetPropertyOffset(RemoveActorsFromBinding_FunctionAddress, "Actors");
		RemoveActorsFromBinding_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveActorsFromBinding_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveActorsFromBinding_ObjectBinding_PropertyAddress, RemoveActorsFromBinding_FunctionAddress, "ObjectBinding");
		RemoveActorsFromBinding_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(RemoveActorsFromBinding_FunctionAddress, "ObjectBinding");
		RemoveActorsFromBinding_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveActorsFromBinding_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		RemoveActorsFromBinding_IsValid = RemoveActorsFromBinding_FunctionAddress != IntPtr.Zero && RemoveActorsFromBinding_Actors_IsValid && RemoveActorsFromBinding_ObjectBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RemoveActorsFromBinding", RemoveActorsFromBinding_IsValid);
		RebindComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RebindComponent");
		RebindComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RebindComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RebindComponent_ComponentBindings_PropertyAddress, RebindComponent_FunctionAddress, "ComponentBindings");
		RebindComponent_ComponentBindings_Offset = NativeReflectionCached.GetPropertyOffset(RebindComponent_FunctionAddress, "ComponentBindings");
		RebindComponent_ComponentBindings_IsValid = NativeReflectionCached.ValidatePropertyClass(RebindComponent_FunctionAddress, "ComponentBindings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RebindComponent_ComponentName_PropertyAddress, RebindComponent_FunctionAddress, "ComponentName");
		RebindComponent_ComponentName_Offset = NativeReflectionCached.GetPropertyOffset(RebindComponent_FunctionAddress, "ComponentName");
		RebindComponent_ComponentName_IsValid = NativeReflectionCached.ValidatePropertyClass(RebindComponent_FunctionAddress, "ComponentName", Classes.FNameProperty);
		RebindComponent_IsValid = RebindComponent_FunctionAddress != IntPtr.Zero && RebindComponent_ComponentBindings_IsValid && RebindComponent_ComponentName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:RebindComponent", RebindComponent_IsValid);
		FixActorReferences_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FixActorReferences");
		FixActorReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(FixActorReferences_FunctionAddress);
		FixActorReferences_IsValid = FixActorReferences_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:FixActorReferences", FixActorReferences_IsValid);
		BakeTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BakeTransform");
		BakeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(BakeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BakeTransform_ObjectBindings_PropertyAddress, BakeTransform_FunctionAddress, "ObjectBindings");
		BakeTransform_ObjectBindings_Offset = NativeReflectionCached.GetPropertyOffset(BakeTransform_FunctionAddress, "ObjectBindings");
		BakeTransform_ObjectBindings_IsValid = NativeReflectionCached.ValidatePropertyClass(BakeTransform_FunctionAddress, "ObjectBindings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BakeTransform_BakeInTime_PropertyAddress, BakeTransform_FunctionAddress, "BakeInTime");
		BakeTransform_BakeInTime_Offset = NativeReflectionCached.GetPropertyOffset(BakeTransform_FunctionAddress, "BakeInTime");
		BakeTransform_BakeInTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BakeTransform_FunctionAddress, "BakeInTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BakeTransform_BakeOutTime_PropertyAddress, BakeTransform_FunctionAddress, "BakeOutTime");
		BakeTransform_BakeOutTime_Offset = NativeReflectionCached.GetPropertyOffset(BakeTransform_FunctionAddress, "BakeOutTime");
		BakeTransform_BakeOutTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BakeTransform_FunctionAddress, "BakeOutTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BakeTransform_BakeInterval_PropertyAddress, BakeTransform_FunctionAddress, "BakeInterval");
		BakeTransform_BakeInterval_Offset = NativeReflectionCached.GetPropertyOffset(BakeTransform_FunctionAddress, "BakeInterval");
		BakeTransform_BakeInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(BakeTransform_FunctionAddress, "BakeInterval", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BakeTransform_Params_PropertyAddress, BakeTransform_FunctionAddress, "Params");
		BakeTransform_Params_Offset = NativeReflectionCached.GetPropertyOffset(BakeTransform_FunctionAddress, "Params");
		BakeTransform_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(BakeTransform_FunctionAddress, "Params", Classes.FStructProperty);
		BakeTransform_IsValid = BakeTransform_FunctionAddress != IntPtr.Zero && BakeTransform_ObjectBindings_IsValid && BakeTransform_BakeInTime_IsValid && BakeTransform_BakeOutTime_IsValid && BakeTransform_BakeInterval_IsValid && BakeTransform_Params_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:BakeTransform", BakeTransform_IsValid);
		AddActorsToBinding_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddActorsToBinding");
		AddActorsToBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorsToBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorsToBinding_Actors_PropertyAddress, AddActorsToBinding_FunctionAddress, "Actors");
		AddActorsToBinding_Actors_Offset = NativeReflectionCached.GetPropertyOffset(AddActorsToBinding_FunctionAddress, "Actors");
		AddActorsToBinding_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorsToBinding_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorsToBinding_ObjectBinding_PropertyAddress, AddActorsToBinding_FunctionAddress, "ObjectBinding");
		AddActorsToBinding_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(AddActorsToBinding_FunctionAddress, "ObjectBinding");
		AddActorsToBinding_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorsToBinding_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		AddActorsToBinding_IsValid = AddActorsToBinding_FunctionAddress != IntPtr.Zero && AddActorsToBinding_Actors_IsValid && AddActorsToBinding_ObjectBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem:AddActorsToBinding", AddActorsToBinding_IsValid);
	}
}
