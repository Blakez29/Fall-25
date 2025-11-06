using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROBLEMS.MODELS;
using System.Windows.Forms; // For OpenFileDialog in Windows Forms

namespace Fall25.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var test_model = new PROBLEM() { PROMPT = "How to start coding", PRIMARY_INPUT = "Effort", RESULT = "Pending" };
        Console.WriteLine(test_model.PROMPT);
        Console.WriteLine(test_model.RESULT);
        return View();
    }

    public IActionResult Privacy()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = CONFIGURATION.INPUT_DATA_FILE_PATH; // Set initial directory
       //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Filter file types

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string selectedFilePath = openFileDialog.FileName;
            Console.WriteLine(selectedFilePath);
            // Do something with the selected file, e.g., read its content
        }
        
        return View();
    }
}
