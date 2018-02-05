using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace LatexDraw
{
    internal static class Logic
    {
        private static FileStream _fileStream;
        private static string _path;
        private static string _name;
        private static string _title;
        private const string _filetype = ".tex";
        private const string _author = "Herman Berget";

        public static void Create(string path, string name = "File", string title = "Title")
        {
            _path = path + "/";            
            _name = name;
            _title = title;

            _fileStream = File.Create(_path + _name + _filetype);

            CreateFrontpage();
            WritePreamble();
            WriteMain();
            WriteEnd();

            _fileStream.Close();

            Compile();
        }

        private static void CreateFrontpage()
        {
            FileStream file = File.Create(_path + "Forside.tex");
            string frontPageText ="\\author{" + _author + "}\n"
                                + "\\title{" + _title + "}\n"
                                + "\\date{\\today}\n"
                                + "\\pagenumbering{gobble}\n"
                                + "\\maketitle\n"
                                + "\\newpage\n"
                                + "\\pagenumbering{arabic}"
                                + "\\newgeometry{margin=0cm}\n";

            AddText(file, frontPageText);
            file.Close();
        }

        private static void WriteEnd()
        {
            AddText(_fileStream, "\\end{document}");
        }

        private static void WriteMain()
        {
            List<string> _pictureNames = GetFileNames("*.png");
            foreach (string s in _pictureNames)
            {
                AddText(_fileStream, "\\includegraphics[width=\\textwidth]{./" + s + "}\n");
            }
        }

        private static List<string> GetFileNames(string pattern)
        {
            DirectoryInfo directory = new DirectoryInfo(_path);
            FileInfo[] info = directory.GetFiles(pattern, SearchOption.TopDirectoryOnly);
            List<string> names = new List<string>();
            foreach (FileInfo f in info)
                names.Add(f.Name);
            return names;
        }

        private static void WritePreamble()
        {
            string preambleText = "% Preamble\n% Tilpasning til norsk\n\\documentclass[a4paper, norsk]{article}\n"
                                 + "\\usepackage[T1]{fontenc}\n\\usepackage[utf8]{inputenc}\n\\usepackage[norsk]{babel}\n"
                                 + "\\usepackage[section]{placeins}\n% For å inkludere figurer\n\\usepackage{graphicx}\n"
                                 + "\\usepackage{geometry}\n\n\\begin{document}\n\\input{./Forside.tex}\n";

            AddText(_fileStream, preambleText);
        }

        private static void AddText(FileStream filestream, string value)
        {
            byte[] text = new UTF8Encoding(true).GetBytes(value);
            filestream.Write(text, 0, text.Length);
        }

        private static void Compile()
        {            
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C cd " + _path + "&& pdflatex \"" + _name + _filetype + "\" && \"" + _name + ".pdf\""
            };
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
