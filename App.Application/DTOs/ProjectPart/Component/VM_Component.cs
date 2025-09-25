namespace App.Application;

[Serializable]
public class VM_Component
{
    public int ProjectId { get; set; }

    public int ComponentTypeId { get; set; }

    public string ComponentTitle { get; set; }

    public string? ComponentDescription { get; set; }

    public int[] ProjectPartArray { get; set; }

    public int[] SceneArray { get; set; }

    public int OrderNo { get; set; }

    public List<VM_ComponentElement> ComponentElements { get; set; }
}
