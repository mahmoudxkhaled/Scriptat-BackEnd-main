// Decompiled with JetBrains decompiler
// Type: App.Application.VM_ProjectDetailComponent
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ProjectDetailComponent
{
    public int ComponentId { get; set; }

    public string ComponentTitle { get; set; }

    public string? ComponentDescription { get; set; }

    public int[] ProjectPartArray { get; set; }

    public int[] SceneArray { get; set; }

    public int OrderNo { get; set; }

    public List<VM_ProjectDetailElement> ProjectElements { get; set; }
}
