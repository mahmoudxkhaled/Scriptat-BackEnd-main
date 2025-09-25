namespace App.Application
{
    public interface IComponentRepository
    {
        Task<bool> AddElementImage(VM_ProjectElementImage _elementImage);

        Task<List<VM_ComponentDropDownItem>> GetComponentDropDownList(int _projectId);

        Task<VM_ComponentDropDownLinkedList> GetComponentLinkedDropDownList(
          int _projectId,
          int _sceneId,
          int _componentId);
    }
}
