// Decompiled with JetBrains decompiler
// Type: App.Application.VM_ProjectNavigatorPartCard
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectNavigatorPartCard
{
    public int ProjectId { get; set; }

    public int ScriptTypeId { get; set; }

    public string ScriptTypeTitle { get; set; }

    public int ProjectPartId { get; set; }

    public string ProjectPartTitle { get; set; }

    public string? ProjectPartSummary { get; set; }

    public int? ProjectPartPageCount { get; set; }

    public int? ProjectPartSceneCount { get; set; }

    public int? ProjectPartWordCount { get; set; }

    public int OrderNo { get; set; }
}
