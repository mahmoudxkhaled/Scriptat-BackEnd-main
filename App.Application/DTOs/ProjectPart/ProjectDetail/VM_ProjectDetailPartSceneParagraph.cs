// Decompiled with JetBrains decompiler
// Type: App.Application.VM_ProjectDetailPartSceneParagraph
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectDetailPartSceneParagraph
{
    public int OrderNo { get; set; }

    public int SceneId { get; set; }

    public int ParagraphId { get; set; }

    public int SceneParagraphTypeId { get; set; }

    public bool IsShowAllowed { get; set; }

    public string ParagraphText { get; set; }

    public int SceneParagraphFormatKey { get; set; }
}
