// Decompiled with JetBrains decompiler
// Type: App.Application.Component.VM_ComponentDropDownLinkedList
// Assembly: Scriptat.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC72002-5CAB-4DE2-978E-7A253500809A
// Assembly location: H:\Scriptat\API\Scriptat.Data.dll


#nullable enable
namespace App.Application;

public class VM_ComponentDropDownLinkedList
{
    public int SelectedComponentTypeId { get; set; }

    public string SelectedComponentTitle { get; set; }

    public List<VM_ComponentDropDownLinkedListItem> SelectedComponentListItems { get; set; }

    public int LinkedComponentTypeId { get; set; }

    public string LinkedComponentTitle { get; set; }

    public List<VM_ComponentDropDownLinkedListItem> LinkedComponentListItems { get; set; }
}
