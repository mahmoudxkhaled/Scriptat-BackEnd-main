// Decompiled with JetBrains decompiler
// Type: App.Application.Component.VM_ComponentElementImage
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

[Serializable]
public class VM_ComponentElementImage
{
    public int Id { get; set; }

    public int ProjectElementId { get; set; }

    public string ElementImageTitle { get; set; }

    public string ElementImageUrl { get; set; }

    public bool IsApprove { get; set; }
}
