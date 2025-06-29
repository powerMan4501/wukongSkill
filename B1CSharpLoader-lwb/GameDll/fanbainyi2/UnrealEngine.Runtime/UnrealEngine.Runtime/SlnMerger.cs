using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UnrealEngine.Runtime;

public class SlnMerger
{
	private class Project
	{
		public string ProjectTypeGuid { get; set; }

		public string Name { get; set; }

		public string Path { get; set; }

		public string Guid { get; set; }

		public List<string> AdditionalLines { get; private set; }

		public Project()
		{
			AdditionalLines = new List<string>();
		}

		public string ToString(string relativeToSln)
		{
			Uri uri = new Uri(relativeToSln);
			Uri uri2 = new Uri(Path);
			string originalString = uri.MakeRelativeUri(uri2).OriginalString;
			return "Project(\"" + ProjectTypeGuid + "\") = \"" + Name + "\", \"" + originalString + "\", \"" + Guid + "\"";
		}
	}

	private class Solution
	{
		private List<string> linesList = new List<string>();

		private int lastEndProjectLine = -1;

		public string Path { get; private set; }

		public List<Project> Projects { get; private set; }

		public Solution(string path)
		{
			Projects = new List<Project>();
			Load(path);
		}

		public void Load(string path)
		{
			Path = path;
			Projects.Clear();
			try
			{
				if (!File.Exists(path))
				{
					return;
				}
				string directoryName = System.IO.Path.GetDirectoryName(path);
				Project project = null;
				string[] array = File.ReadAllLines(path);
				linesList = array.ToList();
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					if (text.StartsWith("Project("))
					{
						string[] array2 = text.Split('"');
						if (array2.Length > 7)
						{
							project = new Project();
							project.ProjectTypeGuid = array2[1];
							project.Name = array2[3];
							project.Path = System.IO.Path.GetFullPath(System.IO.Path.Combine(directoryName, array2[5]));
							project.Guid = array2[7];
							if (!System.IO.Path.HasExtension(project.Path))
							{
								project = null;
							}
						}
					}
					else if (project != null)
					{
						project.AdditionalLines.Add(text);
						if (text.StartsWith("EndProject"))
						{
							lastEndProjectLine = i;
							Projects.Add(project);
							project = null;
						}
					}
				}
				if (project != null)
				{
					lastEndProjectLine = array.Length - 1;
					Projects.Add(project);
				}
			}
			catch
			{
			}
		}

		public bool MergeAndSave(Solution other)
		{
			if (lastEndProjectLine == -1 || !File.Exists(Path))
			{
				return false;
			}
			try
			{
				System.IO.Path.GetDirectoryName(Path);
				foreach (Project project in other.Projects.ToArray().Reverse())
				{
					if (Projects.FirstOrDefault((Project x) => x.Guid == project.Guid) != null)
					{
						continue;
					}
					string item = project.ToString(Path);
					foreach (string item2 in project.AdditionalLines.ToArray().Reverse())
					{
						linesList.Insert(lastEndProjectLine + 1, item2);
					}
					linesList.Insert(lastEndProjectLine + 1, item);
				}
				File.WriteAllLines(Path, linesList.ToArray());
				return true;
			}
			catch
			{
			}
			return false;
		}
	}

	public static bool MergeSolutions(string mergeSolutionPath, string withSolutionPath)
	{
		Solution solution = new Solution(mergeSolutionPath);
		Solution solution2 = new Solution(withSolutionPath);
		if (solution.Projects.Count > 0 && solution2.Projects.Count > 0)
		{
			return solution.MergeAndSave(solution2);
		}
		return false;
	}
}
