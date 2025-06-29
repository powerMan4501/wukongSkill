using System;

namespace b1;

public class TemplateFunNoteAttribute : Attribute
{
	private string Note;

	public TemplateFunNoteAttribute(string _Note)
	{
		Note = _Note;
	}

	public string GetNote()
	{
		return Note;
	}
}
