// Decompiled with JetBrains decompiler
// Type: App.Application.VM_SceneParagraphItem
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll

namespace App.Application;

[Serializable]
public class VM_SceneParagraphItem
{
    public int Id { get; set; }

    public int SceneId { get; set; }

    public int? LocationId { get; set; }

    public int? CharacterId { get; set; }
}
