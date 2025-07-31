using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCAD;

internal class PreSelectSettings
{
    public string OutputFilePath { get; set; } = string.Empty;
    public List<string> SourceFiles { get; set; } = [];
    public string ScriptText { get; set; } = string.Empty;
}