// Decompiled with JetBrains decompiler
// Type: App.Application.ProjectList.VM_ProjectNew
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectNew
{
    public int ProjectTypeId { get; set; }

    public string ProjectCode { get; set; }

    public string ProjectTitle { get; set; }

    public int ProjectPartCount { get; set; }

    public string ProjectDescription { get; set; }

    public int ScriptTypeId { get; set; }

    public string ProjectPartTitle { get; set; }

    public string? ProjectPartFileUrl { get; set; }

    public string UserId { get; set; }
}
