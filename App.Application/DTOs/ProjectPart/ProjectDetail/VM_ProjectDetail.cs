// Decompiled with JetBrains decompiler
// Type: App.Application.VM_ProjectDetail
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectDetail
{
    public int ProjectTypeId { get; set; }

    public string ProjectTypeTitle { get; set; }

    public int ProjectId { get; set; }

    public string ProjectTitle { get; set; }

    public int ProjectPartCount { get; set; }

    public string ProjectSummary { get; set; }

    public string ProjectDescription { get; set; }

    public List<VM_ProjectDetailPart> ProjectParts { get; set; }

    public List<VM_ProjectDetailComponent> ProjectComponents { get; set; }
}
