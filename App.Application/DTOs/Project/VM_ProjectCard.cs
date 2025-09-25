// Decompiled with JetBrains decompiler
// Type: App.Application.ProjectList.VM_ProjectCard
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectCard
{
    public int ProjectTypeId { get; set; }

    public string ProjectTypeTitle { get; set; }

    public int ProjectId { get; set; }

    public string ProjectTitle { get; set; }

    public string? ProjectDescription { get; set; }

    public int ProjectPartCount { get; set; }

    public int ProjectPartProgressMin { get; set; }

    public int ProjectPartProgressMax { get; set; }

    public bool ProjectPartProgressShow { get; set; }

    public int ProjectBreakdownProgressMin { get; set; }

    public int ProjectBreakdownProgressMax { get; set; }

    public bool ProjectBreakdownProgressShow { get; set; }

    public int ProjectPageCount { get; set; }

    public int ProjectSceneCount { get; set; }

    public int ProjectWordCount { get; set; }

    public bool ProjectDocumentShow { get; set; }

    public List<VM_ProjectCardCharacter> ProjectCharacters { get; set; }
}
