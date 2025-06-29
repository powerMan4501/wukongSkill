using System;

namespace b1.AutoQA;

internal class QADirectionsIterator
{
	public QADirections[] Dirs;

	private int currentIndex;

	public QADirectionsIterator()
	{
		Dirs = (QADirections[])Enum.GetValues(typeof(QADirections));
		currentIndex = -1;
	}

	public void RollBackDirIndex()
	{
		if (currentIndex != -1)
		{
			currentIndex--;
		}
	}

	public QADirections? GetNextUnused()
	{
		currentIndex++;
		if (currentIndex < Dirs.Length)
		{
			return Dirs[currentIndex];
		}
		return null;
	}
}
