
namespace App.Application
{
  public class ApiResult
  {
    public bool success { get; set; }

    public List<ApiError> errorList { get; set; }

    public object data { get; set; }
  }
}
