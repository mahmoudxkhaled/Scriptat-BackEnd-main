using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace App.Infrastructure
{
	public class ReturnResult
	{
		public bool IsSuccess { get; set; }
		public string SuccessfullMessage { get; set; }
		public bool HasError { get; set; }
		public string ErrorMessage { get; set; }
		public List<ModelErrorList> ModelError { get; set; }
		public UserDto UserObject { get; set; }
	}
	public class ModelErrorList
	{
		public string key { get; set; }
		public string ErrorMessage { get; set; }
	}
}
