using System.Collections.Generic;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

public static class UMovieSceneFolderExtensions_CsExtensions
{
	public static bool SetFolderName(this UMovieSceneFolder Folder, FName InFolderName)
	{
		return UMovieSceneFolderExtensions.SetFolderName(Folder, InFolderName);
	}

	public static bool SetFolderColor(this UMovieSceneFolder Folder, FColor InFolderColor)
	{
		return UMovieSceneFolderExtensions.SetFolderColor(Folder, InFolderColor);
	}

	public static bool RemoveChildObjectBinding(this UMovieSceneFolder Folder, FSequencerBindingProxy InObjectBinding)
	{
		return UMovieSceneFolderExtensions.RemoveChildObjectBinding(Folder, InObjectBinding);
	}

	public static bool RemoveChildMasterTrack(this UMovieSceneFolder Folder, UMovieSceneTrack InMasterTrack)
	{
		return UMovieSceneFolderExtensions.RemoveChildMasterTrack(Folder, InMasterTrack);
	}

	public static bool RemoveChildFolder(this UMovieSceneFolder TargetFolder, UMovieSceneFolder FolderToRemove)
	{
		return UMovieSceneFolderExtensions.RemoveChildFolder(TargetFolder, FolderToRemove);
	}

	public static FName GetFolderName(this UMovieSceneFolder Folder)
	{
		return UMovieSceneFolderExtensions.GetFolderName(Folder);
	}

	public static FColor GetFolderColor(this UMovieSceneFolder Folder)
	{
		return UMovieSceneFolderExtensions.GetFolderColor(Folder);
	}

	public static List<FSequencerBindingProxy> GetChildObjectBindings(this UMovieSceneFolder Folder)
	{
		return UMovieSceneFolderExtensions.GetChildObjectBindings(Folder);
	}

	public static List<UMovieSceneTrack> GetChildMasterTracks(this UMovieSceneFolder Folder)
	{
		return UMovieSceneFolderExtensions.GetChildMasterTracks(Folder);
	}

	public static List<UMovieSceneFolder> GetChildFolders(this UMovieSceneFolder Folder)
	{
		return UMovieSceneFolderExtensions.GetChildFolders(Folder);
	}

	public static bool AddChildObjectBinding(this UMovieSceneFolder Folder, FSequencerBindingProxy InObjectBinding)
	{
		return UMovieSceneFolderExtensions.AddChildObjectBinding(Folder, InObjectBinding);
	}

	public static bool AddChildMasterTrack(this UMovieSceneFolder Folder, UMovieSceneTrack InMasterTrack)
	{
		return UMovieSceneFolderExtensions.AddChildMasterTrack(Folder, InMasterTrack);
	}

	public static bool AddChildFolder(this UMovieSceneFolder TargetFolder, UMovieSceneFolder FolderToAdd)
	{
		return UMovieSceneFolderExtensions.AddChildFolder(TargetFolder, FolderToAdd);
	}
}
