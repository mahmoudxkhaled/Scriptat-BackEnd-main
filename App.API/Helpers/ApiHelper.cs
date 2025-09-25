using App.Application;


namespace Scriptat.API.Helper
{
    public static class ApiHelper
    {
        public static async Task<string> UploadUserImage(HttpRequest httpRequest)
        {
            string empty = string.Empty;
            string _uniqueFilePath = string.Empty;
            string _rootFolder = Directory.GetCurrentDirectory();
            string _projectFolder = string.Format("/Uploads/{0}_{1}", (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper());
            if (httpRequest.Form.Files.Count > 0)
            {
                if (!Directory.Exists(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder)))
                    Directory.CreateDirectory(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder));
                foreach (IFormFile file in (IEnumerable<IFormFile>)httpRequest.Form.Files)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    _uniqueFilePath = string.Format("{0}/{1}.{2}.{3}", (object)_projectFolder, (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper(), (object)fileName);
                    using (FileStream stream = File.Create(string.Format("{0}{1}", (object)_rootFolder, (object)_uniqueFilePath)))
                        await file.CopyToAsync((Stream)stream);
                }
            }
            string str = _uniqueFilePath;
            _uniqueFilePath = (string)null;
            _rootFolder = (string)null;
            _projectFolder = (string)null;
            return str;
        }
        public static async Task<string> UploadFiles(HttpRequest httpRequest)
        {
            string empty = string.Empty;
            string _uniqueFilePath = string.Empty;
            string _rootFolder = Directory.GetCurrentDirectory();
            string _projectFolder = string.Format("/Uploads/{0}_{1}", (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper());
            if (httpRequest.Form.Files.Count > 0)
            {
                if (!Directory.Exists(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder)))
                    Directory.CreateDirectory(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder));
                foreach (IFormFile file in (IEnumerable<IFormFile>)httpRequest.Form.Files)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    _uniqueFilePath = string.Format("{0}/{1}.{2}.{3}", (object)_projectFolder, (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper(), (object)fileName);
                    using (FileStream stream = File.Create(string.Format("{0}{1}", (object)_rootFolder, (object)_uniqueFilePath)))
                        await file.CopyToAsync((Stream)stream);
                }
            }
            string str = _uniqueFilePath;
            _uniqueFilePath = (string)null;
            _rootFolder = (string)null;
            _projectFolder = (string)null;
            return str;
        }

        public static async Task<VM_ProjectFile> UploadProjectFiles(
          HttpRequest httpRequest,
          string _projectTitle)
        {
            string empty = string.Empty;
            string _uniqueFilePath = string.Empty;
            string _rootFolder = Directory.GetCurrentDirectory();
            string _projectCode = string.Format("{0}_{1}", (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper());
            string _projectFolder = string.Format("/Uploads/ProjectFiles/{0}", (object)_projectCode);
            if (httpRequest.Form.Files.Count > 0)
            {
                if (!Directory.Exists(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder)))
                    Directory.CreateDirectory(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder));
                foreach (IFormFile file in (IEnumerable<IFormFile>)httpRequest.Form.Files)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    _uniqueFilePath = string.Format("{0}/{1}.{2}.{3}", (object)_projectFolder, (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper(), (object)fileName);
                    using (FileStream stream = File.Create(string.Format("{0}{1}", (object)_rootFolder, (object)_uniqueFilePath)))
                        await file.CopyToAsync((Stream)stream);
                }
            }
            VM_ProjectFile vmProjectFile = new VM_ProjectFile()
            {
                ProjectCode = _projectCode,
                ProjectFileUrl = _uniqueFilePath
            };
            _uniqueFilePath = (string)null;
            _rootFolder = (string)null;
            _projectCode = (string)null;
            _projectFolder = (string)null;
            return vmProjectFile;
        }

        public static async Task<string> UploadProjectFiles(
          HttpRequest httpRequest,
          string _projectCode,
          string _projectTitle)
        {
            string empty = string.Empty;
            string _uniqueFilePath = string.Empty;
            string _rootFolder = Directory.GetCurrentDirectory();
            string _projectFolder = string.Format("/Uploads/ProjectFiles/{0}", (object)_projectCode);
            if (httpRequest.Form.Files.Count > 0)
            {
                if (!Directory.Exists(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder)))
                    Directory.CreateDirectory(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder));
                foreach (IFormFile file in (IEnumerable<IFormFile>)httpRequest.Form.Files)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    _uniqueFilePath = string.Format("{0}/{1}.{2}.{3}", (object)_projectFolder, (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper(), (object)fileName);
                    using (FileStream stream = File.Create(string.Format("{0}{1}", (object)_rootFolder, (object)_uniqueFilePath)))
                        await file.CopyToAsync((Stream)stream);
                }
            }
            string str = _uniqueFilePath;
            _uniqueFilePath = (string)null;
            _rootFolder = (string)null;
            _projectFolder = (string)null;
            return str;
        }

        public static async Task<string> UploadProjectFiles(
          HttpRequest httpRequest,
          string _projectCode,
          string _projectTitle,
          bool _isImage)
        {
            string empty = string.Empty;
            string _uniqueFilePath = string.Empty;
            string _rootFolder = Directory.GetCurrentDirectory();
            string _projectFolder = !_isImage ? string.Format("/Uploads/ProjectFiles/{0}", (object)_projectCode) : string.Format("/Uploads/ProjectFiles/{0}/Images", (object)_projectCode);
            if (httpRequest.Form.Files.Count > 0)
            {
                if (!Directory.Exists(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder)))
                    Directory.CreateDirectory(string.Format("{0}{1}", (object)_rootFolder, (object)_projectFolder));
                foreach (IFormFile file in (IEnumerable<IFormFile>)httpRequest.Form.Files)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    _uniqueFilePath = string.Format("{0}/{1}.{2}.{3}", (object)_projectFolder, (object)DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss").Replace(".", ""), (object)Guid.NewGuid().ToString().Replace("-", "").ToUpper(), (object)fileName);
                    using (FileStream stream = File.Create(string.Format("{0}{1}", (object)_rootFolder, (object)_uniqueFilePath)))
                        await file.CopyToAsync((Stream)stream);
                }
            }
            string str = _uniqueFilePath;
            _uniqueFilePath = (string)null;
            _rootFolder = (string)null;
            _projectFolder = (string)null;
            return str;
        }
    }
}
