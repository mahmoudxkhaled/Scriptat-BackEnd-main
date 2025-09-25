// Decompiled with JetBrains decompiler
// Type: App.Application.VM_ProjectDetailPartScene
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectDetailPartScene
{
    public int ProjectPartId { get; set; }

    public int SceneId { get; set; }

    public int OrderNo { get; set; }

    public int SceneNo { get; set; }

    public string? SceneTitle { get; set; }

    public string? SceneNoText { get; set; }

    public string? SceneDescription { get; set; }

    public int? SceneTimeMode { get; set; }

    public int? LocationTypeMode { get; set; }

    public string? SceneTransitionTypeText { get; set; }

    public List<VM_ProjectDetailPartSceneParagraph> SceneParagraphs { get; set; }
}
