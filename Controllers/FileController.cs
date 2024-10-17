using lr_seven.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr_seven.Controllers
{
    public class FileController: Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DownloadFile(FileGetModel model)
        {
            if (ModelState.IsValid)
            {
                var fileContent = $"{model.FirstName}\n{model.LastName}";
                byte[] byteFileContent = System.Text.Encoding.UTF8.GetBytes(fileContent);
                var fileName = $"{model.FileName}.txt";
                var fileType = "text/plain";

                return File(byteFileContent, fileType, fileName);
            }
            else
            {
                return View(model);
            }
        }
    }
}
