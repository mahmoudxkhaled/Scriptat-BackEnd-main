// Decompiled with JetBrains decompiler
// Type: App.Application.VM_ProjectDetailElement
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

public class VM_ProjectDetailElement
{
    public int ProjectComponentId { get; set; }

    public int ProjectElementId { get; set; }

    public string ProjectElementName { get; set; }

    public string? ProjectElementDescription { get; set; }

    public string? ProjectElementCandidateName { get; set; }

    public string? ProjectElementImageUrl { get; set; }

    public int[] ProjectPartArray { get; set; }

    public int[] SceneArray { get; set; }

    public int ProjectId { get; set; }

    public List<VM_ProjectDetailElementChild> ProjectElementAliases { get; set; }

    public List<VM_ProjectDetailElementImage> ProjectElementImages { get; set; }
}
