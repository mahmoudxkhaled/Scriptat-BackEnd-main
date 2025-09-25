
namespace App.Application
{
    public interface ICoreHelper
    {
        Task<string> GetProjectCode(int _projectId);

        Task<List<VM_Component>> GetComponentList(
          int _projectId,
          int[]? _projectElementArray,
          List<VM_ComponentOption>? _options);
    }
}
