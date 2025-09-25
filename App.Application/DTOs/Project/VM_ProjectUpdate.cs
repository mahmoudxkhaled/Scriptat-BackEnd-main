// Decompiled with JetBrains decompiler
// Type: App.Application.ProjectList.VM_ProjectUpdate
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectUpdate
{
    public int ProjectId { get; set; }

    public string ProjectTitle { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectSummary { get; set; }

    public string? ProjectSummaryFileUrl { get; set; }

    public string? ProjectDescription { get; set; }

    public int ProjectPartCount { get; set; }

    public int ProjectTypeId { get; set; }
}
